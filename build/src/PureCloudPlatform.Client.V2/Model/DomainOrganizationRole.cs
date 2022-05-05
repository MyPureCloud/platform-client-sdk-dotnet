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
    /// DomainOrganizationRole
    /// </summary>
    [DataContract]
    public partial class DomainOrganizationRole :  IEquatable<DomainOrganizationRole>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainOrganizationRole" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DefaultRoleId">DefaultRoleId.</param>
        /// <param name="Permissions">Permissions.</param>
        /// <param name="PermissionPolicies">PermissionPolicies.</param>
        /// <param name="UserCount">UserCount.</param>
        /// <param name="RoleNeedsUpdate">Optional unless patch operation..</param>
        /// <param name="_Base">_Base.</param>
        /// <param name="_Default">_Default.</param>
        public DomainOrganizationRole(string Name = null, string Description = null, string DefaultRoleId = null, List<string> Permissions = null, List<DomainPermissionPolicy> PermissionPolicies = null, int? UserCount = null, bool? RoleNeedsUpdate = null, bool? _Base = null, bool? _Default = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.DefaultRoleId = DefaultRoleId;
            this.Permissions = Permissions;
            this.PermissionPolicies = PermissionPolicies;
            this.UserCount = UserCount;
            this.RoleNeedsUpdate = RoleNeedsUpdate;
            this._Base = _Base;
            this._Default = _Default;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DefaultRoleId
        /// </summary>
        [DataMember(Name="defaultRoleId", EmitDefaultValue=false)]
        public string DefaultRoleId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }
        
        
        
        /// <summary>
        /// A collection of the permissions the role is not using
        /// </summary>
        /// <value>A collection of the permissions the role is not using</value>
        [DataMember(Name="unusedPermissions", EmitDefaultValue=false)]
        public List<string> UnusedPermissions { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets PermissionPolicies
        /// </summary>
        [DataMember(Name="permissionPolicies", EmitDefaultValue=false)]
        public List<DomainPermissionPolicy> PermissionPolicies { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserCount
        /// </summary>
        [DataMember(Name="userCount", EmitDefaultValue=false)]
        public int? UserCount { get; set; }
        
        
        
        /// <summary>
        /// Optional unless patch operation.
        /// </summary>
        /// <value>Optional unless patch operation.</value>
        [DataMember(Name="roleNeedsUpdate", EmitDefaultValue=false)]
        public bool? RoleNeedsUpdate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets _Base
        /// </summary>
        [DataMember(Name="base", EmitDefaultValue=false)]
        public bool? _Base { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? _Default { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainOrganizationRole {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultRoleId: ").Append(DefaultRoleId).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  UnusedPermissions: ").Append(UnusedPermissions).Append("\n");
            sb.Append("  PermissionPolicies: ").Append(PermissionPolicies).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
            sb.Append("  RoleNeedsUpdate: ").Append(RoleNeedsUpdate).Append("\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as DomainOrganizationRole);
        }

        /// <summary>
        /// Returns true if DomainOrganizationRole instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainOrganizationRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainOrganizationRole other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DefaultRoleId == other.DefaultRoleId ||
                    this.DefaultRoleId != null &&
                    this.DefaultRoleId.Equals(other.DefaultRoleId)
                ) &&
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) &&
                (
                    this.UnusedPermissions == other.UnusedPermissions ||
                    this.UnusedPermissions != null &&
                    this.UnusedPermissions.SequenceEqual(other.UnusedPermissions)
                ) &&
                (
                    this.PermissionPolicies == other.PermissionPolicies ||
                    this.PermissionPolicies != null &&
                    this.PermissionPolicies.SequenceEqual(other.PermissionPolicies)
                ) &&
                (
                    this.UserCount == other.UserCount ||
                    this.UserCount != null &&
                    this.UserCount.Equals(other.UserCount)
                ) &&
                (
                    this.RoleNeedsUpdate == other.RoleNeedsUpdate ||
                    this.RoleNeedsUpdate != null &&
                    this.RoleNeedsUpdate.Equals(other.RoleNeedsUpdate)
                ) &&
                (
                    this._Base == other._Base ||
                    this._Base != null &&
                    this._Base.Equals(other._Base)
                ) &&
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.DefaultRoleId != null)
                    hash = hash * 59 + this.DefaultRoleId.GetHashCode();
                
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                
                if (this.UnusedPermissions != null)
                    hash = hash * 59 + this.UnusedPermissions.GetHashCode();
                
                if (this.PermissionPolicies != null)
                    hash = hash * 59 + this.PermissionPolicies.GetHashCode();
                
                if (this.UserCount != null)
                    hash = hash * 59 + this.UserCount.GetHashCode();
                
                if (this.RoleNeedsUpdate != null)
                    hash = hash * 59 + this.RoleNeedsUpdate.GetHashCode();
                
                if (this._Base != null)
                    hash = hash * 59 + this._Base.GetHashCode();
                
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
