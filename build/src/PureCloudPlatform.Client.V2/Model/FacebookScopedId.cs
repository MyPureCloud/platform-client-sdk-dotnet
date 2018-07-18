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
    /// Scoped ID for a Facebook user interacting with a page or app
    /// </summary>
    [DataContract]
    public partial class FacebookScopedId :  IEquatable<FacebookScopedId>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookScopedId" /> class.
        /// </summary>
        /// <param name="ScopedId">The unique page/app-specific scopedId for the user.</param>
        public FacebookScopedId(string ScopedId = null)
        {
            this.ScopedId = ScopedId;
            
        }
        
        
        
        /// <summary>
        /// The unique page/app-specific scopedId for the user
        /// </summary>
        /// <value>The unique page/app-specific scopedId for the user</value>
        [DataMember(Name="scopedId", EmitDefaultValue=false)]
        public string ScopedId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacebookScopedId {\n");
            
            sb.Append("  ScopedId: ").Append(ScopedId).Append("\n");
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
            return this.Equals(obj as FacebookScopedId);
        }

        /// <summary>
        /// Returns true if FacebookScopedId instances are equal
        /// </summary>
        /// <param name="other">Instance of FacebookScopedId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacebookScopedId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ScopedId == other.ScopedId ||
                    this.ScopedId != null &&
                    this.ScopedId.Equals(other.ScopedId)
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
                
                if (this.ScopedId != null)
                    hash = hash * 59 + this.ScopedId.GetHashCode();
                
                return hash;
            }
        }
    }

}
