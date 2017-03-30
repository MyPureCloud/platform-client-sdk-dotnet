using System.Runtime.Serialization;

namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
    public class Metadata
    {
        [DataMember(EmitDefaultValue = false, Name = "CorrelationId")]
        public string CorrelationId { get; set; }
    }
}