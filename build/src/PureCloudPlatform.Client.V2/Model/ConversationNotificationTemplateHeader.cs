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
    /// Template header object.
    /// </summary>
    [DataContract]
    public partial class ConversationNotificationTemplateHeader :  IEquatable<ConversationNotificationTemplateHeader>
    {
        
        
        /// <summary>
        /// Template header type.
        /// </summary>
        /// <value>Template header type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,
            
            /// <summary>
            /// Enum Media for "Media"
            /// </summary>
            [EnumMember(Value = "Media")]
            Media
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Template header type.
        /// </summary>
        /// <value>Template header type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNotificationTemplateHeader" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationNotificationTemplateHeader() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNotificationTemplateHeader" /> class.
        /// </summary>
        /// <param name="Type">Template header type. (required).</param>
        /// <param name="Text">Header text. For WhatsApp, ignored..</param>
        /// <param name="Media">Media template header image..</param>
        /// <param name="Parameters">Template parameters for placeholders in template..</param>
        public ConversationNotificationTemplateHeader(TypeEnum? Type = null, string Text = null, ConversationContentAttachment Media = null, List<ConversationNotificationTemplateParameter> Parameters = null)
        {
            this.Type = Type;
            this.Text = Text;
            this.Media = Media;
            this.Parameters = Parameters;
            
        }
        
        
        
        
        
        /// <summary>
        /// Header text. For WhatsApp, ignored.
        /// </summary>
        /// <value>Header text. For WhatsApp, ignored.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Media template header image.
        /// </summary>
        /// <value>Media template header image.</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public ConversationContentAttachment Media { get; set; }
        
        
        
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
            sb.Append("class ConversationNotificationTemplateHeader {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
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
            return this.Equals(obj as ConversationNotificationTemplateHeader);
        }

        /// <summary>
        /// Returns true if ConversationNotificationTemplateHeader instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationNotificationTemplateHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationNotificationTemplateHeader other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                
                return hash;
            }
        }
    }

}
