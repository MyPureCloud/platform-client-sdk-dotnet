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
    /// A Rich Link attachment
    /// </summary>
    [DataContract]
    public partial class ConversationContentRichLink :  IEquatable<ConversationContentRichLink>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentRichLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentRichLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentRichLink" /> class.
        /// </summary>
        /// <param name="Header">Header for the Rich Link..</param>
        /// <param name="Footer">Footer text for the Rich Link..</param>
        /// <param name="Text">Text for the body of the Rich Link. (required).</param>
        /// <param name="UrlLabel">Label for the URL of the Rich Link..</param>
        /// <param name="Url">Url for the Rich Link. (required).</param>
        public ConversationContentRichLink(ConversationContentRichLinkHeader Header = null, string Footer = null, string Text = null, string UrlLabel = null, string Url = null)
        {
            this.Header = Header;
            this.Footer = Footer;
            this.Text = Text;
            this.UrlLabel = UrlLabel;
            this.Url = Url;
            
        }
        


        /// <summary>
        /// Header for the Rich Link.
        /// </summary>
        /// <value>Header for the Rich Link.</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public ConversationContentRichLinkHeader Header { get; set; }



        /// <summary>
        /// Footer text for the Rich Link.
        /// </summary>
        /// <value>Footer text for the Rich Link.</value>
        [DataMember(Name="footer", EmitDefaultValue=false)]
        public string Footer { get; set; }



        /// <summary>
        /// Text for the body of the Rich Link.
        /// </summary>
        /// <value>Text for the body of the Rich Link.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Label for the URL of the Rich Link.
        /// </summary>
        /// <value>Label for the URL of the Rich Link.</value>
        [DataMember(Name="urlLabel", EmitDefaultValue=false)]
        public string UrlLabel { get; set; }



        /// <summary>
        /// Url for the Rich Link.
        /// </summary>
        /// <value>Url for the Rich Link.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentRichLink {\n");

            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  UrlLabel: ").Append(UrlLabel).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as ConversationContentRichLink);
        }

        /// <summary>
        /// Returns true if ConversationContentRichLink instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentRichLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentRichLink other)
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
                    this.Footer == other.Footer ||
                    this.Footer != null &&
                    this.Footer.Equals(other.Footer)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.UrlLabel == other.UrlLabel ||
                    this.UrlLabel != null &&
                    this.UrlLabel.Equals(other.UrlLabel)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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

                if (this.Footer != null)
                    hash = hash * 59 + this.Footer.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.UrlLabel != null)
                    hash = hash * 59 + this.UrlLabel.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                return hash;
            }
        }
    }

}
