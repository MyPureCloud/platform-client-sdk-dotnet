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
    /// V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate :  IEquatable<V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Language">Language.</param>
        /// <param name="Header">Header.</param>
        /// <param name="Body">Body.</param>
        /// <param name="Footer">Footer.</param>
        public V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate(string Id = null, string Language = null, V2ConversationMessageTypingEventForUserTopicConversationNotificationTemplateHeader Header = null, V2ConversationMessageTypingEventForUserTopicConversationNotificationTemplateBody Body = null, V2ConversationMessageTypingEventForUserTopicConversationNotificationTemplateFooter Footer = null)
        {
            this.Id = Id;
            this.Language = Language;
            this.Header = Header;
            this.Body = Body;
            this.Footer = Footer;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationNotificationTemplateHeader Header { get; set; }



        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationNotificationTemplateBody Body { get; set; }



        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [DataMember(Name="footer", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationNotificationTemplateFooter Footer { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate {\n");

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
            return this.Equals(obj as V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate other)
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
