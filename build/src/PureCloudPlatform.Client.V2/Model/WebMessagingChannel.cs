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
    public partial class WebMessagingChannel :  IEquatable<WebMessagingChannel>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebMessagingChannel" /> class.
        /// </summary>
        public WebMessagingChannel()
        {
            
        }
        
        
        
        /// <summary>
        /// Information about the recipient the message is received from.
        /// </summary>
        /// <value>Information about the recipient the message is received from.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public WebMessagingRecipient From { get; private set; }
        
        
        
        /// <summary>
        /// Information about the recipient the message is sent to.
        /// </summary>
        /// <value>Information about the recipient the message is sent to.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public WebMessagingRecipient To { get; private set; }
        
        
        
        /// <summary>
        /// When the message was processed by Genesys Cloud. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>When the message was processed by Genesys Cloud. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; private set; }
        
        
        
        /// <summary>
        /// Unique provider ID of the message.
        /// </summary>
        /// <value>Unique provider ID of the message.</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebMessagingChannel {\n");
            
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
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
            return this.Equals(obj as WebMessagingChannel);
        }

        /// <summary>
        /// Returns true if WebMessagingChannel instances are equal
        /// </summary>
        /// <param name="other">Instance of WebMessagingChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebMessagingChannel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) &&
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
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
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                
                return hash;
            }
        }
    }

}
