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
    /// Media types
    /// </summary>
    [DataContract]
    public partial class MediaTypes :  IEquatable<MediaTypes>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaTypes" /> class.
        /// </summary>
        /// <param name="Allow">Specify allowed media types for inbound and outbound messages. If this field is empty, all inbound and outbound media will be blocked..</param>
        public MediaTypes(MediaTypeAccess Allow = null)
        {
            this.Allow = Allow;
            
        }
        
        
        
        /// <summary>
        /// Specify allowed media types for inbound and outbound messages. If this field is empty, all inbound and outbound media will be blocked.
        /// </summary>
        /// <value>Specify allowed media types for inbound and outbound messages. If this field is empty, all inbound and outbound media will be blocked.</value>
        [DataMember(Name="allow", EmitDefaultValue=false)]
        public MediaTypeAccess Allow { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaTypes {\n");
            
            sb.Append("  Allow: ").Append(Allow).Append("\n");
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
            return this.Equals(obj as MediaTypes);
        }

        /// <summary>
        /// Returns true if MediaTypes instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaTypes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaTypes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Allow == other.Allow ||
                    this.Allow != null &&
                    this.Allow.Equals(other.Allow)
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
                
                if (this.Allow != null)
                    hash = hash * 59 + this.Allow.GetHashCode();
                
                return hash;
            }
        }
    }

}
