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
    /// TrustRequestCreate
    /// </summary>
    [DataContract]
    public partial class TrustRequestCreate :  IEquatable<TrustRequestCreate>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustRequestCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrustRequestCreate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustRequestCreate" /> class.
        /// </summary>
        
        
        /// <param name="UserIds">The list of trustee users that are requesting access. (required).</param>
        
        
        public TrustRequestCreate(List<string> UserIds = null)
        {
            
            
            
            // to ensure "UserIds" is required (not null)
            if (UserIds == null)
            {
                throw new InvalidDataException("UserIds is a required property for TrustRequestCreate and cannot be null");
            }
            else
            {
                this.UserIds = UserIds;
            }
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The list of trustee users that are requesting access.
        /// </summary>
        /// <value>The list of trustee users that are requesting access.</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrustRequestCreate {\n");
            
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            
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
            return this.Equals(obj as TrustRequestCreate);
        }

        /// <summary>
        /// Returns true if TrustRequestCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of TrustRequestCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustRequestCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
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
                
                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
