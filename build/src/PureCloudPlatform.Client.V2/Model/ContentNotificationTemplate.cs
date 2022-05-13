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
    /// Template notification object.
    /// </summary>
    [DataContract]
    public partial class ContentNotificationTemplate :  IEquatable<ContentNotificationTemplate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentNotificationTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentNotificationTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentNotificationTemplate" /> class.
        /// </summary>
        /// <param name="Id">The messaging provider template ID. For WhatsApp, 'namespace@name'..</param>
        /// <param name="Language">Template language..</param>
        /// <param name="Header">The template header..</param>
        /// <param name="Body">The template body. (required).</param>
        /// <param name="Footer">The template footer..</param>
        public ContentNotificationTemplate(string Id = null, string Language = null, NotificationTemplateHeader Header = null, NotificationTemplateBody Body = null, NotificationTemplateFooter Footer = null)
        {
            this.Id = Id;
            this.Language = Language;
            this.Header = Header;
            this.Body = Body;
            this.Footer = Footer;
            
        }
        


        /// <summary>
        /// The messaging provider template ID. For WhatsApp, 'namespace@name'.
        /// </summary>
        /// <value>The messaging provider template ID. For WhatsApp, 'namespace@name'.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Template language.
        /// </summary>
        /// <value>Template language.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// The template header.
        /// </summary>
        /// <value>The template header.</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public NotificationTemplateHeader Header { get; set; }



        /// <summary>
        /// The template body.
        /// </summary>
        /// <value>The template body.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public NotificationTemplateBody Body { get; set; }



        /// <summary>
        /// The template footer.
        /// </summary>
        /// <value>The template footer.</value>
        [DataMember(Name="footer", EmitDefaultValue=false)]
        public NotificationTemplateFooter Footer { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentNotificationTemplate {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
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
            return this.Equals(obj as ContentNotificationTemplate);
        }

        /// <summary>
        /// Returns true if ContentNotificationTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentNotificationTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentNotificationTemplate other)
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
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Header == other.Header ||
                    this.Header != null &&
                    this.Header.Equals(other.Header)
                ) &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) &&
                (
                    this.Footer == other.Footer ||
                    this.Footer != null &&
                    this.Footer.Equals(other.Footer)
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

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.Header != null)
                    hash = hash * 59 + this.Header.GetHashCode();

                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();

                if (this.Footer != null)
                    hash = hash * 59 + this.Footer.GetHashCode();

                return hash;
            }
        }
    }

}
