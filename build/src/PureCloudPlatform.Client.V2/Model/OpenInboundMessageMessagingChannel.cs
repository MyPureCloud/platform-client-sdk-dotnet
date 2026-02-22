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
    /// Open Channel-specific information that describes the message and the message channel/provider, with additional message information
    /// </summary>
    [DataContract]
    public partial class OpenInboundMessageMessagingChannel :  IEquatable<OpenInboundMessageMessagingChannel>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenInboundMessageMessagingChannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpenInboundMessageMessagingChannel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenInboundMessageMessagingChannel" /> class.
        /// </summary>
        /// <param name="From">Information about the recipient the message is received from. (required).</param>
        /// <param name="Time">Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="MessageId">Unique provider ID of the message..</param>
        /// <param name="Metadata">Additional Custom Information about the channel..</param>
        public OpenInboundMessageMessagingChannel(OpenMessagingFromRecipient From = null, DateTime? Time = null, string MessageId = null, ConversationChannelMetadata Metadata = null)
        {
            this.From = From;
            this.Time = Time;
            this.MessageId = MessageId;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// Information about the recipient the message is received from.
        /// </summary>
        /// <value>Information about the recipient the message is received from.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public OpenMessagingFromRecipient From { get; set; }



        /// <summary>
        /// Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }



        /// <summary>
        /// Unique provider ID of the message.
        /// </summary>
        /// <value>Unique provider ID of the message.</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }



        /// <summary>
        /// Additional Custom Information about the channel.
        /// </summary>
        /// <value>Additional Custom Information about the channel.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ConversationChannelMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenInboundMessageMessagingChannel {\n");

            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as OpenInboundMessageMessagingChannel);
        }

        /// <summary>
        /// Returns true if OpenInboundMessageMessagingChannel instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenInboundMessageMessagingChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenInboundMessageMessagingChannel other)
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
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) &&
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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

                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();

                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
