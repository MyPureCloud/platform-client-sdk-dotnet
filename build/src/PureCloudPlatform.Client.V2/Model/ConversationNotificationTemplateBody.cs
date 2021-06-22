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
    public partial class ConversationNotificationTemplateBody :  IEquatable<ConversationNotificationTemplateBody>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNotificationTemplateBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationNotificationTemplateBody() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNotificationTemplateBody" /> class.
        /// </summary>
        /// <param name="Text">Body text. For WhatsApp, ignored..</param>
        /// <param name="Parameters">Template parameters for placeholders in template. (required).</param>
        public ConversationNotificationTemplateBody(string Text = null, List<ConversationNotificationTemplateParameter> Parameters = null)
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
        public List<ConversationNotificationTemplateParameter> Parameters { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationNotificationTemplateBody {\n");
            
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConversationNotificationTemplateBody);
        }

        /// <summary>
        /// Returns true if ConversationNotificationTemplateBody instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationNotificationTemplateBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationNotificationTemplateBody other)
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
