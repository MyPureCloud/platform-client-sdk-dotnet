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
    /// ReceivedReplyMessage content object.
    /// </summary>
    [DataContract]
    public partial class ConversationContentReceivedReplyMessage :  IEquatable<ConversationContentReceivedReplyMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentReceivedReplyMessage" /> class.
        /// </summary>
        /// <param name="Header">Text to show in the header..</param>
        /// <param name="Title">Text to show in the title..</param>
        /// <param name="Subtitle">Text to show in the subtitle..</param>
        /// <param name="ButtonLabel">Text to show on the button label..</param>
        /// <param name="ImageUrl">URL of an image..</param>
        public ConversationContentReceivedReplyMessage(string Header = null, string Title = null, string Subtitle = null, string ButtonLabel = null, string ImageUrl = null)
        {
            this.Header = Header;
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.ButtonLabel = ButtonLabel;
            this.ImageUrl = ImageUrl;
            
        }
        


        /// <summary>
        /// Text to show in the header.
        /// </summary>
        /// <value>Text to show in the header.</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public string Header { get; set; }



        /// <summary>
        /// Text to show in the title.
        /// </summary>
        /// <value>Text to show in the title.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Text to show in the subtitle.
        /// </summary>
        /// <value>Text to show in the subtitle.</value>
        [DataMember(Name="subtitle", EmitDefaultValue=false)]
        public string Subtitle { get; set; }



        /// <summary>
        /// Text to show on the button label.
        /// </summary>
        /// <value>Text to show on the button label.</value>
        [DataMember(Name="buttonLabel", EmitDefaultValue=false)]
        public string ButtonLabel { get; set; }



        /// <summary>
        /// URL of an image.
        /// </summary>
        /// <value>URL of an image.</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentReceivedReplyMessage {\n");

            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  ButtonLabel: ").Append(ButtonLabel).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return this.Equals(obj as ConversationContentReceivedReplyMessage);
        }

        /// <summary>
        /// Returns true if ConversationContentReceivedReplyMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentReceivedReplyMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentReceivedReplyMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Header == other.Header ||
                    this.Header != null &&
                    this.Header.Equals(other.Header)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Subtitle == other.Subtitle ||
                    this.Subtitle != null &&
                    this.Subtitle.Equals(other.Subtitle)
                ) &&
                (
                    this.ButtonLabel == other.ButtonLabel ||
                    this.ButtonLabel != null &&
                    this.ButtonLabel.Equals(other.ButtonLabel)
                ) &&
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
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
                if (this.Header != null)
                    hash = hash * 59 + this.Header.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Subtitle != null)
                    hash = hash * 59 + this.Subtitle.GetHashCode();

                if (this.ButtonLabel != null)
                    hash = hash * 59 + this.ButtonLabel.GetHashCode();

                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();

                return hash;
            }
        }
    }

}
