namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
    ///<Summary>
    /// Interface for the Notification (i.e. topic) Data received on the Notification Channel (WebSocket)
    ///</Summary>
    public interface INotificationData
    {
        ///<Summary>
        /// Name of the topic
        ///</Summary>
        string TopicName { get; set; }
        ///<Summary>
        /// Version
        ///</Summary>
        string Version { get; set; }
        ///<Summary>
        /// Metadata
        ///</Summary>
        Metadata Metadata { get; set; }
    }
}