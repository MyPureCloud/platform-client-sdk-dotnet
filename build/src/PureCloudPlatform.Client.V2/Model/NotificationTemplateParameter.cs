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
    /// Template parameters for placeholders in template.
    /// </summary>
    [DataContract]
    public partial class NotificationTemplateParameter :  IEquatable<NotificationTemplateParameter>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTemplateParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationTemplateParameter() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTemplateParameter" /> class.
        /// </summary>
        /// <param name="Name">Parameter name..</param>
        /// <param name="Text">Parameter text value. (required).</param>
        public NotificationTemplateParameter(string Name = null, string Text = null)
        {
            this.Name = Name;
            this.Text = Text;
            
        }
        
        
        
        /// <summary>
        /// Parameter name.
        /// </summary>
        /// <value>Parameter name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Parameter text value.
        /// </summary>
        /// <value>Parameter text value.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationTemplateParameter {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as NotificationTemplateParameter);
        }

        /// <summary>
        /// Returns true if NotificationTemplateParameter instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificationTemplateParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationTemplateParameter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                return hash;
            }
        }
    }

}
