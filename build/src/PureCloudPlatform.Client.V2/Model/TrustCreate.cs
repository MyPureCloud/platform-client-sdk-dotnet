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
    /// TrustCreate
    /// </summary>
    [DataContract]
    public partial class TrustCreate :  IEquatable<TrustCreate>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrustCreate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustCreate" /> class.
        /// </summary>
        /// <param name="PairingId">The pairing Id created by the trustee. This is required to prove that the trustee agrees to the relationship.  Not required when creating a default pairing with Customer Care..</param>
        /// <param name="Enabled">If disabled no trustee user will have access, even if they were previously added. (required).</param>
        /// <param name="Users">The list of users and their roles to which access will be granted. The users are from the trustee and the roles are from the trustor. If no users are specified, at least one group is required..</param>
        /// <param name="Groups">The list of groups and their roles to which access will be granted. The groups are from the trustee and the roles are from the trustor. If no groups are specified, at least one user is required..</param>
        /// <param name="DateExpired">The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public TrustCreate(string PairingId = null, bool? Enabled = null, List<TrustMemberCreate> Users = null, List<TrustMemberCreate> Groups = null, DateTime? DateExpired = null)
        {
            this.PairingId = PairingId;
            this.Enabled = Enabled;
            this.Users = Users;
            this.Groups = Groups;
            this.DateExpired = DateExpired;
            
        }
        
        
        
        /// <summary>
        /// The pairing Id created by the trustee. This is required to prove that the trustee agrees to the relationship.  Not required when creating a default pairing with Customer Care.
        /// </summary>
        /// <value>The pairing Id created by the trustee. This is required to prove that the trustee agrees to the relationship.  Not required when creating a default pairing with Customer Care.</value>
        [DataMember(Name="pairingId", EmitDefaultValue=false)]
        public string PairingId { get; set; }
        
        
        
        /// <summary>
        /// If disabled no trustee user will have access, even if they were previously added.
        /// </summary>
        /// <value>If disabled no trustee user will have access, even if they were previously added.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// The list of users and their roles to which access will be granted. The users are from the trustee and the roles are from the trustor. If no users are specified, at least one group is required.
        /// </summary>
        /// <value>The list of users and their roles to which access will be granted. The users are from the trustee and the roles are from the trustor. If no users are specified, at least one group is required.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<TrustMemberCreate> Users { get; set; }
        
        
        
        /// <summary>
        /// The list of groups and their roles to which access will be granted. The groups are from the trustee and the roles are from the trustor. If no groups are specified, at least one user is required.
        /// </summary>
        /// <value>The list of groups and their roles to which access will be granted. The groups are from the trustee and the roles are from the trustor. If no groups are specified, at least one user is required.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<TrustMemberCreate> Groups { get; set; }
        
        
        
        /// <summary>
        /// The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateExpired", EmitDefaultValue=false)]
        public DateTime? DateExpired { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrustCreate {\n");
            
            sb.Append("  PairingId: ").Append(PairingId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  DateExpired: ").Append(DateExpired).Append("\n");
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
            return this.Equals(obj as TrustCreate);
        }

        /// <summary>
        /// Returns true if TrustCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of TrustCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PairingId == other.PairingId ||
                    this.PairingId != null &&
                    this.PairingId.Equals(other.PairingId)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
                ) &&
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) &&
                (
                    this.DateExpired == other.DateExpired ||
                    this.DateExpired != null &&
                    this.DateExpired.Equals(other.DateExpired)
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
                
                if (this.PairingId != null)
                    hash = hash * 59 + this.PairingId.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                
                if (this.DateExpired != null)
                    hash = hash * 59 + this.DateExpired.GetHashCode();
                
                return hash;
            }
        }
    }

}
