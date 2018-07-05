using System.Runtime.Serialization;

namespace Extensions.Notifications
{
    public class ChannelMetadataNotification
    {
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }
    }
}
