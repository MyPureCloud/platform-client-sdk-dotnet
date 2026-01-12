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
    /// RichLink
    /// </summary>
    [DataContract]
    public partial class RichLink :  IEquatable<RichLink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RichLink" /> class.
        /// </summary>
        /// <param name="Header">Header for the Rich Link..</param>
        /// <param name="Footer">Footer text for the Rich Link..</param>
        /// <param name="Text">Text for the body of the Rich Link..</param>
        /// <param name="Url">Url for the Rich Link..</param>
        /// <param name="UrlLabel">Label for the URL of the Rich link..</param>
        public RichLink(RichLinkHeader Header = null, string Footer = null, string Text = null, string Url = null, string UrlLabel = null)
        {
            this.Header = Header;
            this.Footer = Footer;
            this.Text = Text;
            this.Url = Url;
            this.UrlLabel = UrlLabel;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Header for the Rich Link.
        /// </summary>
        /// <value>Header for the Rich Link.</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public RichLinkHeader Header { get; set; }



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
        /// Url for the Rich Link.
        /// </summary>
        /// <value>Url for the Rich Link.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Label for the URL of the Rich link.
        /// </summary>
        /// <value>Label for the URL of the Rich link.</value>
        [DataMember(Name="urlLabel", EmitDefaultValue=false)]
        public string UrlLabel { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RichLink {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UrlLabel: ").Append(UrlLabel).Append("\n");
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
            return this.Equals(obj as RichLink);
        }

        /// <summary>
        /// Returns true if RichLink instances are equal
        /// </summary>
        /// <param name="other">Instance of RichLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RichLink other)
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
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.UrlLabel == other.UrlLabel ||
                    this.UrlLabel != null &&
                    this.UrlLabel.Equals(other.UrlLabel)
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

                if (this.Header != null)
                    hash = hash * 59 + this.Header.GetHashCode();

                if (this.Footer != null)
                    hash = hash * 59 + this.Footer.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.UrlLabel != null)
                    hash = hash * 59 + this.UrlLabel.GetHashCode();

                return hash;
            }
        }
    }

}
