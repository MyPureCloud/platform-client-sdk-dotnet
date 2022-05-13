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
    /// AssignUsers
    /// </summary>
    [DataContract]
    public partial class AssignUsers :  IEquatable<AssignUsers>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignUsers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssignUsers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignUsers" /> class.
        /// </summary>
        /// <param name="MembersToAssign">List of user ids to assign to a performance profile (required).</param>
        /// <param name="MembersToRemove">List of user ids to remove from a performance profile (required).</param>
        public AssignUsers(List<string> MembersToAssign = null, List<string> MembersToRemove = null)
        {
            this.MembersToAssign = MembersToAssign;
            this.MembersToRemove = MembersToRemove;
            
        }
        


        /// <summary>
        /// List of user ids to assign to a performance profile
        /// </summary>
        /// <value>List of user ids to assign to a performance profile</value>
        [DataMember(Name="membersToAssign", EmitDefaultValue=false)]
        public List<string> MembersToAssign { get; set; }



        /// <summary>
        /// List of user ids to remove from a performance profile
        /// </summary>
        /// <value>List of user ids to remove from a performance profile</value>
        [DataMember(Name="membersToRemove", EmitDefaultValue=false)]
        public List<string> MembersToRemove { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignUsers {\n");

            sb.Append("  MembersToAssign: ").Append(MembersToAssign).Append("\n");
            sb.Append("  MembersToRemove: ").Append(MembersToRemove).Append("\n");
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
            return this.Equals(obj as AssignUsers);
        }

        /// <summary>
        /// Returns true if AssignUsers instances are equal
        /// </summary>
        /// <param name="other">Instance of AssignUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssignUsers other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MembersToAssign == other.MembersToAssign ||
                    this.MembersToAssign != null &&
                    this.MembersToAssign.SequenceEqual(other.MembersToAssign)
                ) &&
                (
                    this.MembersToRemove == other.MembersToRemove ||
                    this.MembersToRemove != null &&
                    this.MembersToRemove.SequenceEqual(other.MembersToRemove)
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

                if (this.MembersToRemove != null)
                    hash = hash * 59 + this.MembersToRemove.GetHashCode();

                return hash;
            }
        }
    }

}
