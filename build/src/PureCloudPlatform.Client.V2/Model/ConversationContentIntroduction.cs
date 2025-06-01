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
    /// Introduction content object.
    /// </summary>
    [DataContract]
    public partial class ConversationContentIntroduction :  IEquatable<ConversationContentIntroduction>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentIntroduction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentIntroduction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentIntroduction" /> class.
        /// </summary>
        /// <param name="Title">Text to show in the title. (required).</param>
        /// <param name="Subtitle">Text to show in the subtitle..</param>
        /// <param name="ImageUrl">URL of an image..</param>
        /// <param name="ButtonText">Text to show on the button. (required).</param>
        public ConversationContentIntroduction(string Title = null, string Subtitle = null, string ImageUrl = null, string ButtonText = null)
        {
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.ImageUrl = ImageUrl;
            this.ButtonText = ButtonText;
            
        }
        


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
        /// URL of an image.
        /// </summary>
        /// <value>URL of an image.</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }



        /// <summary>
        /// Text to show on the button.
        /// </summary>
        /// <value>Text to show on the button.</value>
        [DataMember(Name="buttonText", EmitDefaultValue=false)]
        public string ButtonText { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentIntroduction {\n");

            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ButtonText: ").Append(ButtonText).Append("\n");
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
            return this.Equals(obj as ConversationContentIntroduction);
        }

        /// <summary>
        /// Returns true if ConversationContentIntroduction instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentIntroduction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentIntroduction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) &&
                (
                    this.ButtonText == other.ButtonText ||
                    this.ButtonText != null &&
                    this.ButtonText.Equals(other.ButtonText)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Subtitle != null)
                    hash = hash * 59 + this.Subtitle.GetHashCode();

                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();

                if (this.ButtonText != null)
                    hash = hash * 59 + this.ButtonText.GetHashCode();

                return hash;
            }
        }
    }

}
