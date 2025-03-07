using System.Runtime.Serialization;

namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
    ///<Summary>
    /// Notification (i.e. topic) Metadata
    ///</Summary>
    public class Metadata
    {
        ///<Summary>
        /// CorrelationId
        ///</Summary>
        [DataMember(EmitDefaultValue = false, Name = "CorrelationId")]
        public string CorrelationId { get; set; }
    }
}