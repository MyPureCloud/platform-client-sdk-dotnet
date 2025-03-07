using System.Runtime.Serialization;

namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
    ///<Summary>
    /// Notification (i.e. topic) Data received on the Notification Channel (WebSocket)
    ///</Summary>
    public class NotificationData<T> : INotificationData
    {
        ///<Summary>
        /// Name of the topic
        ///</Summary>
        [DataMember(EmitDefaultValue = false, Name = "topicName")]
        public string TopicName { get; set; }

        ///<Summary>
        /// Version
        ///</Summary>
        [DataMember(EmitDefaultValue = false, Name = "version")]
        public string Version { get; set; }

        ///<Summary>
        /// Body of the event
        ///</Summary>
        [DataMember(EmitDefaultValue = false, Name = "eventBody")]
        public T EventBody { get; set; }

        ///<Summary>
        /// Metadata
        ///</Summary>
        [DataMember(EmitDefaultValue = false, Name = "metadata")]
        public Metadata Metadata { get; set; }
    }
}
