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
        
        
        /// <param name="PairingId">The pairing Id created by the trustee. This is required to prove that the trustee agrees to the relationship. (required).</param>
        
        
        
        /// <param name="Enabled">If disabled no trustee user will have access, even if they were previously added. (required).</param>
        
        
        
        /// <param name="Users">The list of users and their roles to which access will be granted. The users are from the trustee and the roles are from the trustor. (required).</param>
        
        
        public TrustCreate(string PairingId = null, bool? Enabled = null, List<TrustUserCreate> Users = null)
        {
            
            
            
            // to ensure "PairingId" is required (not null)
            if (PairingId == null)
            {
                throw new InvalidDataException("PairingId is a required property for TrustCreate and cannot be null");
            }
            else
            {
                this.PairingId = PairingId;
            }
            
            
            
            
            
            // to ensure "Enabled" is required (not null)
            if (Enabled == null)
            {
                throw new InvalidDataException("Enabled is a required property for TrustCreate and cannot be null");
            }
            else
            {
                this.Enabled = Enabled;
            }
            
            
            
            
            
            // to ensure "Users" is required (not null)
            if (Users == null)
            {
                throw new InvalidDataException("Users is a required property for TrustCreate and cannot be null");
            }
            else
            {
                this.Users = Users;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The pairing Id created by the trustee. This is required to prove that the trustee agrees to the relationship.
        /// </summary>
        /// <value>The pairing Id created by the trustee. This is required to prove that the trustee agrees to the relationship.</value>
        [DataMember(Name="pairingId", EmitDefaultValue=false)]
        public string PairingId { get; set; }
        
        
        
        /// <summary>
        /// If disabled no trustee user will have access, even if they were previously added.
        /// </summary>
        /// <value>If disabled no trustee user will have access, even if they were previously added.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// The list of users and their roles to which access will be granted. The users are from the trustee and the roles are from the trustor.
        /// </summary>
        /// <value>The list of users and their roles to which access will be granted. The users are from the trustee and the roles are from the trustor.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<TrustUserCreate> Users { get; set; }
        
        
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
                
                return hash;
            }
        }
    }

}
