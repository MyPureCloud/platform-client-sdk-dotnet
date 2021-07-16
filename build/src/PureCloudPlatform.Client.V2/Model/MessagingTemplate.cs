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
    /// The messaging template identifies a structured message templates supported by a messaging channel.
    /// </summary>
    [DataContract]
    public partial class MessagingTemplate :  IEquatable<MessagingTemplate>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingTemplate" /> class.
        /// </summary>
        /// <param name="WhatsApp">Defines a messaging template for a WhatsApp messaging channel.</param>
        public MessagingTemplate(WhatsAppDefinition WhatsApp = null)
        {
            this.WhatsApp = WhatsApp;
            
        }
        
        
        
        /// <summary>
        /// Defines a messaging template for a WhatsApp messaging channel
        /// </summary>
        /// <value>Defines a messaging template for a WhatsApp messaging channel</value>
        [DataMember(Name="whatsApp", EmitDefaultValue=false)]
        public WhatsAppDefinition WhatsApp { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingTemplate {\n");
            
            sb.Append("  WhatsApp: ").Append(WhatsApp).Append("\n");
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
            return this.Equals(obj as MessagingTemplate);
        }

        /// <summary>
        /// Returns true if MessagingTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WhatsApp == other.WhatsApp ||
                    this.WhatsApp != null &&
                    this.WhatsApp.Equals(other.WhatsApp)
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
                
                if (this.WhatsApp != null)
                    hash = hash * 59 + this.WhatsApp.GetHashCode();
                
                return hash;
            }
        }
    }

}
