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
    /// TokenInfoClonedUser
    /// </summary>
    [DataContract]
    public partial class TokenInfoClonedUser :  IEquatable<TokenInfoClonedUser>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenInfoClonedUser" /> class.
        /// </summary>
        public TokenInfoClonedUser()
        {
            
        }
        
        
        
        /// <summary>
        /// User id of the original native user
        /// </summary>
        /// <value>User id of the original native user</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Organization of the original native user
        /// </summary>
        /// <value>Organization of the original native user</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public Entity Organization { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenInfoClonedUser {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
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
            return this.Equals(obj as TokenInfoClonedUser);
        }

        /// <summary>
        /// Returns true if TokenInfoClonedUser instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenInfoClonedUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenInfoClonedUser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                
                return hash;
            }
        }
    }

}
