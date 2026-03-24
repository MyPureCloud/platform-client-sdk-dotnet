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
    /// UserAssignmentsResponse
    /// </summary>
    [DataContract]
    public partial class UserAssignmentsResponse :  IEquatable<UserAssignmentsResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAssignmentsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserAssignmentsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAssignmentsResponse" /> class.
        /// </summary>
        /// <param name="User">User assigned to the staffing group. (required).</param>
        /// <param name="Assignments">Date pairs representing the assignments for the user. (required).</param>
        public UserAssignmentsResponse(UserReference User = null, List<AssignmentEffectiveDateRange> Assignments = null)
        {
            this.User = User;
            this.Assignments = Assignments;
            
        }
        


        /// <summary>
        /// User assigned to the staffing group.
        /// </summary>
        /// <value>User assigned to the staffing group.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// Date pairs representing the assignments for the user.
        /// </summary>
        /// <value>Date pairs representing the assignments for the user.</value>
        [DataMember(Name="assignments", EmitDefaultValue=false)]
        public List<AssignmentEffectiveDateRange> Assignments { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAssignmentsResponse {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Assignments: ").Append(Assignments).Append("\n");
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
            return this.Equals(obj as UserAssignmentsResponse);
        }

        /// <summary>
        /// Returns true if UserAssignmentsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAssignmentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAssignmentsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Assignments == other.Assignments ||
                    this.Assignments != null &&
                    this.Assignments.SequenceEqual(other.Assignments)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Assignments != null)
                    hash = hash * 59 + this.Assignments.GetHashCode();

                return hash;
            }
        }
    }

}
