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
    /// DetectedNamedEntityValue
    /// </summary>
    [DataContract]
    public partial class DetectedNamedEntityValue :  IEquatable<DetectedNamedEntityValue>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedNamedEntityValue" /> class.
        /// </summary>
        public DetectedNamedEntityValue()
        {
            
        }
        
        
        
        /// <summary>
        /// The raw value of the detected named entity.
        /// </summary>
        /// <value>The raw value of the detected named entity.</value>
        [DataMember(Name="raw", EmitDefaultValue=false)]
        public string Raw { get; private set; }
        
        
        
        /// <summary>
        /// The resolved value of the detected named entity.
        /// </summary>
        /// <value>The resolved value of the detected named entity.</value>
        [DataMember(Name="resolved", EmitDefaultValue=false)]
        public string Resolved { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectedNamedEntityValue {\n");
            
            sb.Append("  Raw: ").Append(Raw).Append("\n");
            sb.Append("  Resolved: ").Append(Resolved).Append("\n");
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
            return this.Equals(obj as DetectedNamedEntityValue);
        }

        /// <summary>
        /// Returns true if DetectedNamedEntityValue instances are equal
        /// </summary>
        /// <param name="other">Instance of DetectedNamedEntityValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectedNamedEntityValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Raw == other.Raw ||
                    this.Raw != null &&
                    this.Raw.Equals(other.Raw)
                ) &&
                (
                    this.Resolved == other.Resolved ||
                    this.Resolved != null &&
                    this.Resolved.Equals(other.Resolved)
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
                
                if (this.Raw != null)
                    hash = hash * 59 + this.Raw.GetHashCode();
                
                if (this.Resolved != null)
                    hash = hash * 59 + this.Resolved.GetHashCode();
                
                return hash;
            }
        }
    }

}
