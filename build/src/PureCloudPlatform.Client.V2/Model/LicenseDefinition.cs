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
    /// LicenseDefinition
    /// </summary>
    [DataContract]
    public partial class LicenseDefinition :  IEquatable<LicenseDefinition>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseDefinition" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="Permissions">Permissions.</param>
        /// <param name="Prerequisites">Prerequisites.</param>
        /// <param name="Comprises">Comprises.</param>
        public LicenseDefinition(string Description = null, Permissions Permissions = null, List<AddressableLicenseDefinition> Prerequisites = null, List<LicenseDefinition> Comprises = null)
        {
            this.Description = Description;
            this.Permissions = Permissions;
            this.Prerequisites = Prerequisites;
            this.Comprises = Comprises;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public Permissions Permissions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Prerequisites
        /// </summary>
        [DataMember(Name="prerequisites", EmitDefaultValue=false)]
        public List<AddressableLicenseDefinition> Prerequisites { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Comprises
        /// </summary>
        [DataMember(Name="comprises", EmitDefaultValue=false)]
        public List<LicenseDefinition> Comprises { get; set; }
        
        
        
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
            sb.Append("class LicenseDefinition {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Prerequisites: ").Append(Prerequisites).Append("\n");
            sb.Append("  Comprises: ").Append(Comprises).Append("\n");
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
            return this.Equals(obj as LicenseDefinition);
        }

        /// <summary>
        /// Returns true if LicenseDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of LicenseDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseDefinition other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.Equals(other.Permissions)
                ) &&
                (
                    this.Prerequisites == other.Prerequisites ||
                    this.Prerequisites != null &&
                    this.Prerequisites.SequenceEqual(other.Prerequisites)
                ) &&
                (
                    this.Comprises == other.Comprises ||
                    this.Comprises != null &&
                    this.Comprises.SequenceEqual(other.Comprises)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                
                if (this.Prerequisites != null)
                    hash = hash * 59 + this.Prerequisites.GetHashCode();
                
                if (this.Comprises != null)
                    hash = hash * 59 + this.Comprises.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
