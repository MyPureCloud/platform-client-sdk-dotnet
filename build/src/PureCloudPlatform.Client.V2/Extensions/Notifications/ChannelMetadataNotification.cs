using System.Runtime.Serialization;

namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
    public class ChannelMetadataNotification
    {
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }
    }
}
