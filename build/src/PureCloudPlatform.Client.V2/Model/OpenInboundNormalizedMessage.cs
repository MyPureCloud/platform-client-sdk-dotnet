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
    /// Open Messaging rich media message structure
    /// </summary>
    [DataContract]
    public partial class OpenInboundNormalizedMessage :  IEquatable<OpenInboundNormalizedMessage>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenInboundNormalizedMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpenInboundNormalizedMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenInboundNormalizedMessage" /> class.
        /// </summary>
        /// <param name="Channel">Channel-specific information that describes the message and the message channel/provider. (required).</param>
        /// <param name="Text">Message text..</param>
        /// <param name="Content">List of content elements..</param>
        /// <param name="Metadata">Additional metadata about this message to capture non-channel specific data..</param>
        public OpenInboundNormalizedMessage(OpenInboundMessageMessagingChannel Channel = null, string Text = null, List<OpenInboundMessageContent> Content = null, Dictionary<string, string> Metadata = null)
        {
            this.Channel = Channel;
            this.Text = Text;
            this.Content = Content;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// Channel-specific information that describes the message and the message channel/provider.
        /// </summary>
        /// <value>Channel-specific information that describes the message and the message channel/provider.</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public OpenInboundMessageMessagingChannel Channel { get; set; }



        /// <summary>
        /// Message text.
        /// </summary>
        /// <value>Message text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// List of content elements.
        /// </summary>
        /// <value>List of content elements.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<OpenInboundMessageContent> Content { get; set; }



        /// <summary>
        /// Additional metadata about this message to capture non-channel specific data.
        /// </summary>
        /// <value>Additional metadata about this message to capture non-channel specific data.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, string> Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenInboundNormalizedMessage {\n");

            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(obj as OpenInboundNormalizedMessage);
        }

        /// <summary>
        /// Returns true if OpenInboundNormalizedMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenInboundNormalizedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenInboundNormalizedMessage other)
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
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(other.Content)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.SequenceEqual(other.Metadata)
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

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
