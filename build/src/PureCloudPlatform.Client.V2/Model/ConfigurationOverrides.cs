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
    /// ConfigurationOverrides
    /// </summary>
    [DataContract]
    public partial class ConfigurationOverrides :  IEquatable<ConfigurationOverrides>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationOverrides" /> class.
        /// </summary>
        /// <param name="Priority">Indicates whether or not the contact will be placed in front of the queue or at the end of the queue..</param>
        public ConfigurationOverrides(bool? Priority = null)
        {
            this.Priority = Priority;
            
        }
        
        
        
        /// <summary>
        /// Indicates whether or not the contact will be placed in front of the queue or at the end of the queue.
        /// </summary>
        /// <value>Indicates whether or not the contact will be placed in front of the queue or at the end of the queue.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public bool? Priority { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationOverrides {\n");
            
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(obj as ConfigurationOverrides);
        }

        /// <summary>
        /// Returns true if ConfigurationOverrides instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfigurationOverrides to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationOverrides other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
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
                
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                
                return hash;
            }
        }
    }

}
