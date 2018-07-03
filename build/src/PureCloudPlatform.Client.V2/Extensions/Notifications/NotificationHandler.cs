using System;
using System.Collections.Generic;
using System.Linq;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
    /// <summary>
    /// A helper class for handling PureCloud notifications
    /// </summary>
    public class NotificationHandler : IDisposable
    {
        private readonly NotificationsApi _notificationsApi = new NotificationsApi();
        private readonly Dictionary<string, Type> _typeMap = new Dictionary<string, Type>(); 

        /// <summary>
        /// The WebSocket object used to receive notifications
        /// </summary>
        public WebSocket WebSocket { get; private set; }

        /// <summary>
        /// The notification channel object
        /// </summary>
        public Channel Channel { get; private set; }

        /// <summary>
        /// The handler for a notification event
        /// </summary>
        /// <param name="notificationData">The notification data, of </param>
        public delegate void NotificationReceivedHandler(INotificationData notificationData);

        /// <summary>
        /// Raised when a notification occurs
        /// </summary>
        public event NotificationReceivedHandler NotificationReceived;

        /// <summary>
        /// Creates a new instance of NotificationHandler
        /// </summary>
        public NotificationHandler()
        {
            WebSocket.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;
            Channel = _notificationsApi.PostNotificationsChannels();
            ConnectSocket(Channel.ConnectUri);
        }

        /// <summary>
        /// Creates a new instance of NotificationHandler from an existing <see cref="Channel"/>
        /// </summary>
        public NotificationHandler(Channel channel)
        {
            WebSocket.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;
            Channel = channel;
            ConnectSocket(Channel.ConnectUri);
        }

        /// <summary>
        /// Adds a subsciption to the specified topic. Events received on this topic will be cast to the given type.
        /// </summary>
        /// <param name="topic">The notification topic to add</param>
        /// <param name="type">The <see cref="Type"/> to cast notifications on this topic to</param>
        public void AddSubscription(string topic, Type type)
        {
            _notificationsApi.PostNotificationsChannelSubscriptions(Channel.Id,
                new List<ChannelTopic>() { new ChannelTopic(topic) });
            _typeMap.Add(topic.ToLowerInvariant(), type);
        }

        /// <summary>
        /// Adds a list of subsciptions to the specified topic. Events received on this topic will be cast to the given type.
        /// </summary>
        /// <param name="subscriptions">A List of Tuples where the first value is the notification topic to add and the second is the Type that should be used when deserializing the notification</param>
        public void AddSubscriptions(List<Tuple<string, Type>> subscriptions) {
            var topicList = subscriptions.Select(s => new ChannelTopic(s.Item1)).ToList();
            _notificationsApi.PostNotificationsChannelSubscriptions(Channel.Id, topicList);
            subscriptions.ForEach(s => _typeMap.Add(s.Item1.ToLowerInvariant(), s.Item2));
        }

        /// <summary>
        /// Removes the subscribed topic
        /// </summary>
        /// <param name="topic">The notification topic to remove</param>
        public void RemoveSubscription(string topic)
        {
            var subscriptions = _notificationsApi.GetNotificationsChannelSubscriptions(Channel.Id);
            var match =
                subscriptions.Entities.FirstOrDefault(
                    e => e.Id.Equals(topic, StringComparison.InvariantCultureIgnoreCase));
            if (match == null) return;
            subscriptions.Entities.Remove(match);
            _notificationsApi.PutNotificationsChannelSubscriptions(Channel.Id, subscriptions.Entities);
            _typeMap.Remove(topic);
        }

        /// <summary>
        /// Removes all subscriptions from the channel
        /// </summary>
        public void RemoveAllSubscriptions()
        {
            _notificationsApi.DeleteNotificationsChannelSubscriptions(Channel.Id);
            _typeMap.Clear();
        }

        private void ConnectSocket(string uri)
        {
            WebSocket = new WebSocket(uri);
            WebSocket.OnMessage += (sender, e) =>
            {
                try
                {
                    var data = JsonConvert.DeserializeObject<NotificationData<JObject>>(e.Data);
                    if (!_typeMap.ContainsKey(data.TopicName.ToLowerInvariant())) return;

                    var genericNotificationType = typeof (NotificationData<>);
                    var specificNotificationType =
                        genericNotificationType.MakeGenericType(_typeMap[data.TopicName.ToLowerInvariant()]);

                    var notification = JsonConvert.DeserializeObject(e.Data, specificNotificationType);
                    if (notification == null)
                        return;

                    NotificationReceived?.Invoke((INotificationData)notification);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            };
            WebSocket.Connect();
        }

        /// <summary>
        /// Removes all subscriptions and closes the websocket
        /// </summary>
        public void Dispose()
        {
            try
            {
                RemoveAllSubscriptions();
                if (WebSocket != null && WebSocket.IsAlive)
                    WebSocket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
