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
    /// OpenInboundStructuredResponseMessage
    /// </summary>
    [DataContract]
    public partial class OpenInboundStructuredResponseMessage :  IEquatable<OpenInboundStructuredResponseMessage>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenInboundStructuredResponseMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpenInboundStructuredResponseMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenInboundStructuredResponseMessage" /> class.
        /// </summary>
        /// <param name="Channel">Channel-specific information that describes the message and the message channel/provider. (required).</param>
        /// <param name="ButtonResponse">Button response element. (required).</param>
        /// <param name="OriginatingMessageId">Id of original structured message that this messages responds to. (required).</param>
        public OpenInboundStructuredResponseMessage(OpenInboundMessageMessagingChannel Channel = null, ContentButtonResponse ButtonResponse = null, string OriginatingMessageId = null)
        {
            this.Channel = Channel;
            this.ButtonResponse = ButtonResponse;
            this.OriginatingMessageId = OriginatingMessageId;
            
        }
        


        /// <summary>
        /// Channel-specific information that describes the message and the message channel/provider.
        /// </summary>
        /// <value>Channel-specific information that describes the message and the message channel/provider.</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public OpenInboundMessageMessagingChannel Channel { get; set; }



        /// <summary>
        /// Button response element.
        /// </summary>
        /// <value>Button response element.</value>
        [DataMember(Name="buttonResponse", EmitDefaultValue=false)]
        public ContentButtonResponse ButtonResponse { get; set; }



        /// <summary>
        /// Id of original structured message that this messages responds to.
        /// </summary>
        /// <value>Id of original structured message that this messages responds to.</value>
        [DataMember(Name="originatingMessageId", EmitDefaultValue=false)]
        public string OriginatingMessageId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenInboundStructuredResponseMessage {\n");

            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
            sb.Append("  OriginatingMessageId: ").Append(OriginatingMessageId).Append("\n");
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
            return this.Equals(obj as OpenInboundStructuredResponseMessage);
        }

        /// <summary>
        /// Returns true if OpenInboundStructuredResponseMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenInboundStructuredResponseMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenInboundStructuredResponseMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Channel == other.Channel ||
                    this.Channel != null &&
                    this.Channel.Equals(other.Channel)
                ) &&
                (
                    this.ButtonResponse == other.ButtonResponse ||
                    this.ButtonResponse != null &&
                    this.ButtonResponse.Equals(other.ButtonResponse)
                ) &&
                (
                    this.OriginatingMessageId == other.OriginatingMessageId ||
                    this.OriginatingMessageId != null &&
                    this.OriginatingMessageId.Equals(other.OriginatingMessageId)
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
                if (this.Channel != null)
                    hash = hash * 59 + this.Channel.GetHashCode();

                if (this.ButtonResponse != null)
                    hash = hash * 59 + this.ButtonResponse.GetHashCode();

                if (this.OriginatingMessageId != null)
                    hash = hash * 59 + this.OriginatingMessageId.GetHashCode();

                return hash;
            }
        }
    }

}
