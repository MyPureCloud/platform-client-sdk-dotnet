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
    /// CreateUserAssignmentsRequest
    /// </summary>
    [DataContract]
    public partial class CreateUserAssignmentsRequest :  IEquatable<CreateUserAssignmentsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserAssignmentsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUserAssignmentsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserAssignmentsRequest" /> class.
        /// </summary>
        /// <param name="UserId">The ID of the user assigned to the staffing group. (required).</param>
        /// <param name="Assignments">Assignment effective date ranges for the user. (required).</param>
        public CreateUserAssignmentsRequest(string UserId = null, List<AssignmentEffectiveDateRange> Assignments = null)
        {
            this.UserId = UserId;
            this.Assignments = Assignments;
            
        }
        


        /// <summary>
        /// The ID of the user assigned to the staffing group.
        /// </summary>
        /// <value>The ID of the user assigned to the staffing group.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Assignment effective date ranges for the user.
        /// </summary>
        /// <value>Assignment effective date ranges for the user.</value>
        [DataMember(Name="assignments", EmitDefaultValue=false)]
        public List<AssignmentEffectiveDateRange> Assignments { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserAssignmentsRequest {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as CreateUserAssignmentsRequest);
        }

        /// <summary>
        /// Returns true if CreateUserAssignmentsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateUserAssignmentsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserAssignmentsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.Assignments != null)
                    hash = hash * 59 + this.Assignments.GetHashCode();

                return hash;
            }
        }
    }

}
