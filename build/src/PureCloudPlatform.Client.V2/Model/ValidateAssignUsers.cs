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
    /// ValidateAssignUsers
    /// </summary>
    [DataContract]
    public partial class ValidateAssignUsers :  IEquatable<ValidateAssignUsers>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateAssignUsers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidateAssignUsers() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateAssignUsers" /> class.
        /// </summary>
        /// <param name="MembersToAssign">List of user ids to assign to a performance profile (required).</param>
        public ValidateAssignUsers(List<string> MembersToAssign = null)
        {
            this.MembersToAssign = MembersToAssign;
            
        }
        
        
        
        /// <summary>
        /// List of user ids to assign to a performance profile
        /// </summary>
        /// <value>List of user ids to assign to a performance profile</value>
        [DataMember(Name="membersToAssign", EmitDefaultValue=false)]
        public List<string> MembersToAssign { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateAssignUsers {\n");
            
            sb.Append("  MembersToAssign: ").Append(MembersToAssign).Append("\n");
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
            return this.Equals(obj as ValidateAssignUsers);
        }

        /// <summary>
        /// Returns true if ValidateAssignUsers instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateAssignUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateAssignUsers other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MembersToAssign == other.MembersToAssign ||
                    this.MembersToAssign != null &&
                    this.MembersToAssign.SequenceEqual(other.MembersToAssign)
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
                
                if (this.MembersToAssign != null)
                    hash = hash * 59 + this.MembersToAssign.GetHashCode();
                
                return hash;
            }
        }
    }

}
