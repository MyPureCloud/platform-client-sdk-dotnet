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
    /// UserAuthorization
    /// </summary>
    [DataContract]
    public partial class UserAuthorization :  IEquatable<UserAuthorization>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthorization" /> class.
        /// </summary>
        /// <param name="Roles">Roles.</param>
        public UserAuthorization(List<DomainRole> Roles = null)
        {
            this.Roles = Roles;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<DomainRole> Roles { get; set; }
        
        
        
        /// <summary>
        /// A collection of the roles the user is not using
        /// </summary>
        /// <value>A collection of the roles the user is not using</value>
        [DataMember(Name="unusedRoles", EmitDefaultValue=false)]
        public List<DomainRole> UnusedRoles { get; private set; }
        
        
        
        /// <summary>
        /// A collection of the permissions granted by all assigned roles
        /// </summary>
        /// <value>A collection of the permissions granted by all assigned roles</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; private set; }
        
        
        
        /// <summary>
        /// The policies configured for assigned permissions.
        /// </summary>
        /// <value>The policies configured for assigned permissions.</value>
        [DataMember(Name="permissionPolicies", EmitDefaultValue=false)]
        public List<ResourcePermissionPolicy> PermissionPolicies { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAuthorization {\n");
            
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  UnusedRoles: ").Append(UnusedRoles).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  PermissionPolicies: ").Append(PermissionPolicies).Append("\n");
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
            return this.Equals(obj as UserAuthorization);
        }

        /// <summary>
        /// Returns true if UserAuthorization instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAuthorization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAuthorization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
                ) &&
                (
                    this.UnusedRoles == other.UnusedRoles ||
                    this.UnusedRoles != null &&
                    this.UnusedRoles.SequenceEqual(other.UnusedRoles)
                ) &&
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) &&
                (
                    this.PermissionPolicies == other.PermissionPolicies ||
                    this.PermissionPolicies != null &&
                    this.PermissionPolicies.SequenceEqual(other.PermissionPolicies)
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
                
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                
                if (this.UnusedRoles != null)
                    hash = hash * 59 + this.UnusedRoles.GetHashCode();
                
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                
                if (this.PermissionPolicies != null)
                    hash = hash * 59 + this.PermissionPolicies.GetHashCode();
                
                return hash;
            }
        }
    }

}
