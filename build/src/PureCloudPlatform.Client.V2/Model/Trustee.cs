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
    /// Trustee
    /// </summary>
    [DataContract]
    public partial class Trustee :  IEquatable<Trustee>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Trustee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Trustee() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Trustee" /> class.
        /// </summary>
        /// <param name="Enabled">If disabled no trustee user will have access, even if they were previously added. (required).</param>
        /// <param name="UsesDefaultRole">Denotes if trustee uses admin role by default..</param>
        /// <param name="DateExpired">The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public Trustee(bool? Enabled = null, bool? UsesDefaultRole = null, DateTime? DateExpired = null)
        {
            this.Enabled = Enabled;
            this.UsesDefaultRole = UsesDefaultRole;
            this.DateExpired = DateExpired;
            
        }
        
        
        
        /// <summary>
        /// Organization Id for this trust.
        /// </summary>
        /// <value>Organization Id for this trust.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// If disabled no trustee user will have access, even if they were previously added.
        /// </summary>
        /// <value>If disabled no trustee user will have access, even if they were previously added.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// Denotes if trustee uses admin role by default.
        /// </summary>
        /// <value>Denotes if trustee uses admin role by default.</value>
        [DataMember(Name="usesDefaultRole", EmitDefaultValue=false)]
        public bool? UsesDefaultRole { get; set; }
        
        
        
        /// <summary>
        /// Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateExpired", EmitDefaultValue=false)]
        public DateTime? DateExpired { get; set; }
        
        
        
        /// <summary>
        /// User that created trust.
        /// </summary>
        /// <value>User that created trust.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public OrgUser CreatedBy { get; private set; }
        
        
        
        /// <summary>
        /// Organization associated with this trust.
        /// </summary>
        /// <value>Organization associated with this trust.</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public Organization Organization { get; private set; }
        
        
        
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
            sb.Append("class Trustee {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  UsesDefaultRole: ").Append(UsesDefaultRole).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateExpired: ").Append(DateExpired).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
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
            return this.Equals(obj as Trustee);
        }

        /// <summary>
        /// Returns true if Trustee instances are equal
        /// </summary>
        /// <param name="other">Instance of Trustee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trustee other)
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
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.UsesDefaultRole == other.UsesDefaultRole ||
                    this.UsesDefaultRole != null &&
                    this.UsesDefaultRole.Equals(other.UsesDefaultRole)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateExpired == other.DateExpired ||
                    this.DateExpired != null &&
                    this.DateExpired.Equals(other.DateExpired)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
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
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.UsesDefaultRole != null)
                    hash = hash * 59 + this.UsesDefaultRole.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateExpired != null)
                    hash = hash * 59 + this.DateExpired.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
