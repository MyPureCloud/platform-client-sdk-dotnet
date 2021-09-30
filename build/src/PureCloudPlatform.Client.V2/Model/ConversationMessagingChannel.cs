using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Channel-specific information that describes the message and the message channel/provider.
    /// </summary>
    [DataContract]
    public partial class ConversationMessagingChannel :  IEquatable<ConversationMessagingChannel>
    {
        
        
        
        
        
        /// <summary>
        /// The provider type.
        /// </summary>
        /// <value>The provider type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PlatformEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Twitter for "Twitter"
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Facebook for "Facebook"
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>
            [EnumMember(Value = "Line")]
            Line,
            
            /// <summary>
            /// Enum Whatsapp for "Whatsapp"
            /// </summary>
            [EnumMember(Value = "Whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessaging for "WebMessaging"
            /// </summary>
            [EnumMember(Value = "WebMessaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Sms for "Sms"
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The provider type.
        /// </summary>
        /// <value>The provider type.</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public PlatformEnum? Platform { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessagingChannel" /> class.
        /// </summary>
        public ConversationMessagingChannel()
        {
            
        }
        
        
        
        /// <summary>
        /// The integration ID.
        /// </summary>
        /// <value>The integration ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Unique provider ID of the message such as a Facebook message ID.
        /// </summary>
        /// <value>Unique provider ID of the message such as a Facebook message ID.</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; private set; }
        
        
        
        /// <summary>
        /// Information about the recipient the message is sent to.
        /// </summary>
        /// <value>Information about the recipient the message is sent to.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public ConversationMessagingToRecipient To { get; private set; }
        
        
        
        /// <summary>
        /// Information about the recipient the message is received from.
        /// </summary>
        /// <value>Information about the recipient the message is received from.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public ConversationMessagingFromRecipient From { get; private set; }
        
        
        
        /// <summary>
        /// Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; private set; }
        
        
        
        /// <summary>
        /// Time the message was edited. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Time the message was edited. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// Time the message was deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Time the message was deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateDeleted", EmitDefaultValue=false)]
        public DateTime? DateDeleted { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationMessagingChannel {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DateDeleted: ").Append(DateDeleted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConversationMessagingChannel);
        }

        /// <summary>
        /// Returns true if ConversationMessagingChannel instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationMessagingChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationMessagingChannel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
                ) &&
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.DateDeleted == other.DateDeleted ||
                    this.DateDeleted != null &&
                    this.DateDeleted.Equals(other.DateDeleted)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();
                
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.DateDeleted != null)
                    hash = hash * 59 + this.DateDeleted.GetHashCode();
                
                return hash;
            }
        }
    }

}
