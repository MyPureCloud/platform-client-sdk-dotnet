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
    /// LicenseAssignmentRequest
    /// </summary>
    [DataContract]
    public partial class LicenseAssignmentRequest :  IEquatable<LicenseAssignmentRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseAssignmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LicenseAssignmentRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseAssignmentRequest" /> class.
        /// </summary>
        
        
        /// <param name="LicenseId">The id of the license to assign/unassign. (required).</param>
        
        
        
        /// <param name="UserIdsAdd">The ids of users to assign this license to. (required).</param>
        
        
        
        /// <param name="UserIdsRemove">The ids of users to unassign this license from. (required).</param>
        
        
        public LicenseAssignmentRequest(string LicenseId = null, List<string> UserIdsAdd = null, List<string> UserIdsRemove = null)
        {
            
            
            
            // to ensure "LicenseId" is required (not null)
            if (LicenseId == null)
            {
                throw new InvalidDataException("LicenseId is a required property for LicenseAssignmentRequest and cannot be null");
            }
            else
            {
                this.LicenseId = LicenseId;
            }
            
            
            
            
            
            // to ensure "UserIdsAdd" is required (not null)
            if (UserIdsAdd == null)
            {
                throw new InvalidDataException("UserIdsAdd is a required property for LicenseAssignmentRequest and cannot be null");
            }
            else
            {
                this.UserIdsAdd = UserIdsAdd;
            }
            
            
            
            
            
            // to ensure "UserIdsRemove" is required (not null)
            if (UserIdsRemove == null)
            {
                throw new InvalidDataException("UserIdsRemove is a required property for LicenseAssignmentRequest and cannot be null");
            }
            else
            {
                this.UserIdsRemove = UserIdsRemove;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The id of the license to assign/unassign.
        /// </summary>
        /// <value>The id of the license to assign/unassign.</value>
        [DataMember(Name="licenseId", EmitDefaultValue=false)]
        public string LicenseId { get; set; }
        
        
        
        /// <summary>
        /// The ids of users to assign this license to.
        /// </summary>
        /// <value>The ids of users to assign this license to.</value>
        [DataMember(Name="userIdsAdd", EmitDefaultValue=false)]
        public List<string> UserIdsAdd { get; set; }
        
        
        
        /// <summary>
        /// The ids of users to unassign this license from.
        /// </summary>
        /// <value>The ids of users to unassign this license from.</value>
        [DataMember(Name="userIdsRemove", EmitDefaultValue=false)]
        public List<string> UserIdsRemove { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseAssignmentRequest {\n");
            
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
            
            sb.Append("  UserIdsAdd: ").Append(UserIdsAdd).Append("\n");
            
            sb.Append("  UserIdsRemove: ").Append(UserIdsRemove).Append("\n");
            
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
            return this.Equals(obj as LicenseAssignmentRequest);
        }

        /// <summary>
        /// Returns true if LicenseAssignmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LicenseAssignmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseAssignmentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LicenseId == other.LicenseId ||
                    this.LicenseId != null &&
                    this.LicenseId.Equals(other.LicenseId)
                ) &&
                (
                    this.UserIdsAdd == other.UserIdsAdd ||
                    this.UserIdsAdd != null &&
                    this.UserIdsAdd.SequenceEqual(other.UserIdsAdd)
                ) &&
                (
                    this.UserIdsRemove == other.UserIdsRemove ||
                    this.UserIdsRemove != null &&
                    this.UserIdsRemove.SequenceEqual(other.UserIdsRemove)
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
                
                if (this.LicenseId != null)
                    hash = hash * 59 + this.LicenseId.GetHashCode();
                
                if (this.UserIdsAdd != null)
                    hash = hash * 59 + this.UserIdsAdd.GetHashCode();
                
                if (this.UserIdsRemove != null)
                    hash = hash * 59 + this.UserIdsRemove.GetHashCode();
                
                return hash;
            }
        }
    }

}
