using PureCloudPlatform.Client.V2.Model;

using WebSocketSharp;

namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
	/// <summary>
	/// A helper class for handling PureCloud notifications
	/// </summary>
	public interface INotificationHandler : IDisposable
	{
		/// <summary>
		/// The WebSocket object used to receive notifications
		/// </summary>
		WebSocket WebSocket { get; }

		/// <summary>
		/// The notification channel object
		/// </summary>
		Channel Channel { get; }

		/// <summary>
		/// Raised when a notification occurs
		/// </summary>
		event NotificationHandler.NotificationReceivedHandler NotificationReceived;

		/// <summary>
		/// Adds a subsciption to the specified topic. Events received on this topic will be cast to the given type.
		/// </summary>
		/// <param name="topic">The notification topic to add</param>
		/// <param name="type">The <see cref="Type"/> to cast notifications on this topic to</param>
		void AddSubscription(string topic, Type type);

		/// <summary>
		/// Adds a list of subsciptions to the specified topic. Events received on this topic will be cast to the given type.
		/// </summary>
		/// <param name="subscriptions">A List of Tuples where the first value is the notification topic to add and the second is the Type that should be used when deserializing the notification</param>
		void AddSubscriptions(List<Tuple<string, Type>> subscriptions);

		/// <summary>
		/// Removes the subscribed topic
		/// </summary>
		/// <param name="topic">The notification topic to remove</param>
		void RemoveSubscription(string topic);

		/// <summary>
		/// Removes all subscriptions from the channel
		/// </summary>
		void RemoveAllSubscriptions();

		/// <summary>
		/// Sends the ping message to the notification service. Must be subscribed using topic "channel.metadata" and handle with type ChannelMetadataNotification.
		/// </summary>
		void Ping();
	}
}