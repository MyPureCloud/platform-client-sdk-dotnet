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
    /// TaskManagementObservationDetailContainer
    /// </summary>
    [DataContract]
    public partial class TaskManagementObservationDetailContainer :  IEquatable<TaskManagementObservationDetailContainer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationDetailContainer" /> class.
        /// </summary>
        /// <param name="TypeDetails">Information about worktypes referenced in the results. Present when &#39;type&#39; is included in the expands parameter..</param>
        /// <param name="AssigneeDetails">Information about assignees referenced in the results. Present when &#39;assignee&#39; is included in the expands parameter..</param>
        public TaskManagementObservationDetailContainer(List<WorktypeReference> TypeDetails = null, List<UserReferenceWithName> AssigneeDetails = null)
        {
            this.TypeDetails = TypeDetails;
            this.AssigneeDetails = AssigneeDetails;
            
        }
        


        /// <summary>
        /// Information about worktypes referenced in the results. Present when &#39;type&#39; is included in the expands parameter.
        /// </summary>
        /// <value>Information about worktypes referenced in the results. Present when &#39;type&#39; is included in the expands parameter.</value>
        [DataMember(Name="typeDetails", EmitDefaultValue=false)]
        public List<WorktypeReference> TypeDetails { get; set; }



        /// <summary>
        /// Information about assignees referenced in the results. Present when &#39;assignee&#39; is included in the expands parameter.
        /// </summary>
        /// <value>Information about assignees referenced in the results. Present when &#39;assignee&#39; is included in the expands parameter.</value>
        [DataMember(Name="assigneeDetails", EmitDefaultValue=false)]
        public List<UserReferenceWithName> AssigneeDetails { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskManagementObservationDetailContainer {\n");

            sb.Append("  TypeDetails: ").Append(TypeDetails).Append("\n");
            sb.Append("  AssigneeDetails: ").Append(AssigneeDetails).Append("\n");
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
            return this.Equals(obj as TaskManagementObservationDetailContainer);
        }

        /// <summary>
        /// Returns true if TaskManagementObservationDetailContainer instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementObservationDetailContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementObservationDetailContainer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TypeDetails == other.TypeDetails ||
                    this.TypeDetails != null &&
                    this.TypeDetails.SequenceEqual(other.TypeDetails)
                ) &&
                (
                    this.AssigneeDetails == other.AssigneeDetails ||
                    this.AssigneeDetails != null &&
                    this.AssigneeDetails.SequenceEqual(other.AssigneeDetails)
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
                if (this.TypeDetails != null)
                    hash = hash * 59 + this.TypeDetails.GetHashCode();

                if (this.AssigneeDetails != null)
                    hash = hash * 59 + this.AssigneeDetails.GetHashCode();

                return hash;
            }
        }
    }

}
