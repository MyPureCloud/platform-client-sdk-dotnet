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
    /// ParticipantAttributes
    /// </summary>
    [DataContract]
    public partial class ParticipantAttributes :  IEquatable<ParticipantAttributes>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantAttributes" /> class.
        /// </summary>
        
        
        /// <param name="Attributes">The map of attribute keys to values..</param>
        
        
        public ParticipantAttributes(Dictionary<string, string> Attributes = null)
        {
            
            
            
            
            
            
            
            
            
            
this.Attributes = Attributes;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The map of attribute keys to values.
        /// </summary>
        /// <value>The map of attribute keys to values.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParticipantAttributes {\n");
            
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            
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
            return this.Equals(obj as ParticipantAttributes);
        }

        /// <summary>
        /// Returns true if ParticipantAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of ParticipantAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParticipantAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
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
                
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                
                return hash;
            }
        }
    }

}
