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
    /// Template body object.
    /// </summary>
    [DataContract]
    public partial class NotificationTemplateBody :  IEquatable<NotificationTemplateBody>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTemplateBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationTemplateBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTemplateBody" /> class.
        /// </summary>
        /// <param name="Text">Body text. For WhatsApp, ignored..</param>
        /// <param name="Parameters">Template parameters for placeholders in template. (required).</param>
        public NotificationTemplateBody(string Text = null, List<NotificationTemplateParameter> Parameters = null)
        {
            this.Text = Text;
            this.Parameters = Parameters;
            
        }
        


        /// <summary>
        /// Body text. For WhatsApp, ignored.
        /// </summary>
        /// <value>Body text. For WhatsApp, ignored.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Template parameters for placeholders in template.
        /// </summary>
        /// <value>Template parameters for placeholders in template.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<NotificationTemplateParameter> Parameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationTemplateBody {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(obj as NotificationTemplateBody);
        }

        /// <summary>
        /// Returns true if NotificationTemplateBody instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificationTemplateBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationTemplateBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
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
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();

                return hash;
            }
        }
    }

}
