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
    /// PromptNotificationNotificationErrorMessageParams
    /// </summary>
    [DataContract]
    public partial class PromptNotificationNotificationErrorMessageParams :  IEquatable<PromptNotificationNotificationErrorMessageParams>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptNotificationNotificationErrorMessageParams" /> class.
        /// </summary>
        
        
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        
        
        public PromptNotificationNotificationErrorMessageParams(Dictionary<string, string> AdditionalProperties = null)
        {
            
            
            
            
            
            
            
            
            
            
this.AdditionalProperties = AdditionalProperties;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromptNotificationNotificationErrorMessageParams {\n");
            
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            
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
            return this.Equals(obj as PromptNotificationNotificationErrorMessageParams);
        }

        /// <summary>
        /// Returns true if PromptNotificationNotificationErrorMessageParams instances are equal
        /// </summary>
        /// <param name="other">Instance of PromptNotificationNotificationErrorMessageParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromptNotificationNotificationErrorMessageParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
