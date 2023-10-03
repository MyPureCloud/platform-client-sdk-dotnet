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
    public class NotificationHandler : INotificationHandler
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
            Channel = _notificationsApi.PostNotificationsChannels();
            ConnectSocket(Channel.ConnectUri);
            SubscribeToSystemEvents();
        }

        /// <summary>
        /// Creates a new instance of NotificationHandler with a proxy
        /// </summary>
        public NotificationHandler(string proxyURI, string proxyUsername = null, string proxyPassword = null)
        {
            Channel = _notificationsApi.PostNotificationsChannels();
            ConnectSocket(Channel.ConnectUri, proxyURI, proxyUsername, proxyPassword);
            SubscribeToSystemEvents();
        }

        /// <summary>
        /// Creates a new instance of NotificationHandler with custom NotificationsApi
        /// </summary>
        public NotificationHandler(NotificationsApi notificationsApi)
        {
            _notificationsApi = notificationsApi;
            Channel = _notificationsApi.PostNotificationsChannels();
            ConnectSocket(Channel.ConnectUri);
            SubscribeToSystemEvents();
        }

        /// <summary>
        /// Creates a new instance of NotificationHandler with proxy and custom NotificationsApi
        /// </summary>
        public NotificationHandler(NotificationsApi notificationsApi, string proxyURI, string proxyUsername = null, string proxyPassword = null)
        {
            _notificationsApi = notificationsApi;
            Channel = _notificationsApi.PostNotificationsChannels();
            ConnectSocket(Channel.ConnectUri, proxyURI, proxyUsername, proxyPassword);
            SubscribeToSystemEvents();
        }

        /// <summary>
        /// Creates a new instance of NotificationHandler from an existing <see cref="Channel"/>
        /// </summary>
        public NotificationHandler(Channel channel)
        {
            Channel = channel;
            ConnectSocket(Channel.ConnectUri);
            SubscribeToSystemEvents();
        }

        /// <summary>
        /// Creates a new instance of NotificationHandler with a proxy from an existing <see cref="Channel"/>
        /// </summary>
        public NotificationHandler(Channel channel, string proxyURI, string proxyUsername = null, string proxyPassword = null)
        {
            Channel = channel;
            ConnectSocket(Channel.ConnectUri, proxyURI, proxyUsername, proxyPassword);
            SubscribeToSystemEvents();
        }

        /// <summary>
        /// Creates a new instance of NotificationHandler with an existing Channel object and custom NotificationsApi
        /// </summary>
        public NotificationHandler(Channel channel, NotificationsApi notificationsApi)
        {
            _notificationsApi = notificationsApi;
            Channel = channel;
            ConnectSocket(Channel.ConnectUri);
            SubscribeToSystemEvents();
        }

        /// <summary>
        /// Creates a new instance of NotificationHandler with an existing Channel object, proxy, and custom NotificationsApi
        /// </summary>
        public NotificationHandler(Channel channel, NotificationsApi notificationsApi, string proxyURI, string proxyUsername = null, string proxyPassword = null)
        {
            _notificationsApi = notificationsApi;
            Channel = channel;
            ConnectSocket(Channel.ConnectUri, proxyURI, proxyUsername, proxyPassword);
            SubscribeToSystemEvents();
        }

        /// <summary>
        /// Adds a handler for the v2.system.socket_closing message in order to reconnect to the websocket when the message is received
        /// </summary>
        private void SubscribeToSystemEvents()
        {
            var socketClosingTopic = "v2.system.socket_closing";
            AddHandlerNoSubscribe(socketClosingTopic, typeof(SystemMessageSystemMessage));
            AddHandlerNoSubscribe("channel.metadata", typeof(ChannelMetadataNotification));
            NotificationReceived += (data) =>
            {
                if (data.GetType() == typeof (NotificationData<SystemMessageSystemMessage>) &&
                    string.Compare(data.TopicName, socketClosingTopic) == 0)
                {
                    WebSocket.Close();
                    WebSocket.Connect();
                }
            };
        }

        /// <summary>
        /// Adds a subscription to the specified topic. Events received on this topic will be cast to the given type.
        /// </summary>
        /// <param name="topic">The notification topic to add</param>
        /// <param name="type">The <see cref="Type"/> to cast notifications on this topic to</param>
        public void AddSubscription(string topic, Type type)
        {
            AddSubscriptions(new List<Tuple<string, Type>> { new Tuple<string, Type>(topic, type) });
        }

        /// <summary>
        /// Adds a list of subscriptions to the specified topic. Events received on this topic will be cast to the given type.
        /// </summary>
        /// <param name="subscriptions">A List of Tuples where the first value is the notification topic to add and the second is the Type that should be used when deserializing the notification</param>
        public void AddSubscriptions(List<Tuple<string, Type>> subscriptions) {
            var topicList = subscriptions.Select(s => new ChannelTopic(s.Item1)).Where(t => (t.Id.ToLowerInvariant() != "channel.metadata") && 
                                                                                            (!t.Id.ToLowerInvariant().StartsWith("v2.system"))).ToList();
            _notificationsApi.PostNotificationsChannelSubscriptions(Channel.Id, topicList);
            subscriptions.ForEach(s => _typeMap.Add(s.Item1.ToLowerInvariant(), s.Item2));
        }

        /// <summary>
        /// Adds a handler to the specified topic without subscribing. Events received on this topic will be cast to the given type.
        /// </summary>
        /// <param name="topic">The notification topic to add</param>
        /// <param name="type">The <see cref="Type"/> to cast notifications on this topic to</param>
        public void AddHandlerNoSubscribe(string topic, Type type)
        {
            AddHandlersNoSubscribe(new List<Tuple<string, Type>> { new Tuple<string, Type>(topic, type) });
        }

        /// <summary>
        /// Adds a list of handlers to the specified topic without subscribing. Events received on this topic will be cast to the given type.
        /// </summary>
        /// <param name="subscriptions">A List of Tuples where the first value is the notification topic to add and the second is the Type that should be used when deserializing the notification</param>
        public void AddHandlersNoSubscribe(List<Tuple<string, Type>> subscriptions) {
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
            _typeMap.Remove(topic.ToLowerInvariant());
        }

        /// <summary>
        /// Removes all subscriptions from the channel
        /// </summary>
        public void RemoveAllSubscriptions()
        {
            _notificationsApi.DeleteNotificationsChannelSubscriptions(Channel.Id);
            _typeMap.Clear();
        }

        /// <summary>
        /// Sends the ping message to the notification service. Must be subscribed using topic "channel.metadata" and handle with type ChannelMetadataNotification.
        /// </summary>
        public void Ping()
        {
            WebSocket.Send("{\"message\":\"ping\"}");
        }

        private void ConnectSocket(string uri, string proxyURI = null, string proxyUsername = null, string proxyPassword = null)
        {
            WebSocket = new WebSocket(uri);
            WebSocket.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;
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

            if (proxyURI != null)
            {
                WebSocket.SetProxy(proxyURI, proxyUsername, proxyPassword);
            }

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
