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
    /// LearningAssignmentCreate
    /// </summary>
    [DataContract]
    public partial class LearningAssignmentCreate :  IEquatable<LearningAssignmentCreate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningAssignmentCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentCreate" /> class.
        /// </summary>
        /// <param name="AddToSchedule">If True, adds the assignment to their schedule.</param>
        /// <param name="ModuleId">The Learning module Id associated with this assignment (required).</param>
        /// <param name="UserId">The User for whom the assignment is assigned (required).</param>
        /// <param name="RecommendedCompletionDate">The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="LengthInMinutes">The length in minutes of assignment.</param>
        public LearningAssignmentCreate(bool? AddToSchedule = null, string ModuleId = null, string UserId = null, DateTime? RecommendedCompletionDate = null, int? LengthInMinutes = null)
        {
            this.AddToSchedule = AddToSchedule;
            this.ModuleId = ModuleId;
            this.UserId = UserId;
            this.RecommendedCompletionDate = RecommendedCompletionDate;
            this.LengthInMinutes = LengthInMinutes;
            
        }
        


        /// <summary>
        /// If True, adds the assignment to their schedule
        /// </summary>
        /// <value>If True, adds the assignment to their schedule</value>
        [DataMember(Name="addToSchedule", EmitDefaultValue=false)]
        public bool? AddToSchedule { get; set; }



        /// <summary>
        /// The Learning module Id associated with this assignment
        /// </summary>
        /// <value>The Learning module Id associated with this assignment</value>
        [DataMember(Name="moduleId", EmitDefaultValue=false)]
        public string ModuleId { get; set; }



        /// <summary>
        /// The User for whom the assignment is assigned
        /// </summary>
        /// <value>The User for whom the assignment is assigned</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="recommendedCompletionDate", EmitDefaultValue=false)]
        public DateTime? RecommendedCompletionDate { get; set; }



        /// <summary>
        /// The length in minutes of assignment
        /// </summary>
        /// <value>The length in minutes of assignment</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignmentCreate {\n");

            sb.Append("  AddToSchedule: ").Append(AddToSchedule).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  RecommendedCompletionDate: ").Append(RecommendedCompletionDate).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
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
            return this.Equals(obj as LearningAssignmentCreate);
        }

        /// <summary>
        /// Returns true if LearningAssignmentCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignmentCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignmentCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AddToSchedule == other.AddToSchedule ||
                    this.AddToSchedule != null &&
                    this.AddToSchedule.Equals(other.AddToSchedule)
                ) &&
                (
                    this.ModuleId == other.ModuleId ||
                    this.ModuleId != null &&
                    this.ModuleId.Equals(other.ModuleId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.RecommendedCompletionDate == other.RecommendedCompletionDate ||
                    this.RecommendedCompletionDate != null &&
                    this.RecommendedCompletionDate.Equals(other.RecommendedCompletionDate)
                ) &&
                (
                    this.LengthInMinutes == other.LengthInMinutes ||
                    this.LengthInMinutes != null &&
                    this.LengthInMinutes.Equals(other.LengthInMinutes)
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
                if (this.AddToSchedule != null)
                    hash = hash * 59 + this.AddToSchedule.GetHashCode();

                if (this.ModuleId != null)
                    hash = hash * 59 + this.ModuleId.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.RecommendedCompletionDate != null)
                    hash = hash * 59 + this.RecommendedCompletionDate.GetHashCode();

                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();

                return hash;
            }
        }
    }

}
