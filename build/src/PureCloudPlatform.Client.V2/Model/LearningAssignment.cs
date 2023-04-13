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
    /// Learning module assignment with user information
    /// </summary>
    [DataContract]
    public partial class LearningAssignment :  IEquatable<LearningAssignment>
    {
        /// <summary>
        /// The Learning Assignment state
        /// </summary>
        /// <value>The Learning Assignment state</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Assigned for "Assigned"
            /// </summary>
            [EnumMember(Value = "Assigned")]
            Assigned,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted,
            
            /// <summary>
            /// Enum Notcompleted for "NotCompleted"
            /// </summary>
            [EnumMember(Value = "NotCompleted")]
            Notcompleted,
            
            /// <summary>
            /// Enum Invalidschedule for "InvalidSchedule"
            /// </summary>
            [EnumMember(Value = "InvalidSchedule")]
            Invalidschedule
        }
        /// <summary>
        /// The Learning Assignment state
        /// </summary>
        /// <value>The Learning Assignment state</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignment" /> class.
        /// </summary>
        /// <param name="Assessment">The assessment associated with this assignment.</param>
        /// <param name="State">The Learning Assignment state.</param>
        /// <param name="DateRecommendedForCompletion">The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Version">The version of Learning module assigned.</param>
        /// <param name="Module">The Learning module object associated with this assignment.</param>
        /// <param name="User">The user to whom the assignment is assigned.</param>
        /// <param name="AssessmentForm">The assessment form associated with this assignment.</param>
        public LearningAssignment(LearningAssessment Assessment = null, StateEnum? State = null, DateTime? DateRecommendedForCompletion = null, int? Version = null, LearningModule Module = null, UserReference User = null, AssessmentForm AssessmentForm = null)
        {
            this.Assessment = Assessment;
            this.State = State;
            this.DateRecommendedForCompletion = DateRecommendedForCompletion;
            this.Version = Version;
            this.Module = Module;
            this.User = User;
            this.AssessmentForm = AssessmentForm;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The assessment associated with this assignment
        /// </summary>
        /// <value>The assessment associated with this assignment</value>
        [DataMember(Name="assessment", EmitDefaultValue=false)]
        public LearningAssessment Assessment { get; set; }



        /// <summary>
        /// The user who created the assignment
        /// </summary>
        /// <value>The user who created the assignment</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; private set; }



        /// <summary>
        /// The date when the assignment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date when the assignment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The user who modified the assignment
        /// </summary>
        /// <value>The user who modified the assignment</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; private set; }



        /// <summary>
        /// The date when the assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date when the assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// True if the assignment is overdue
        /// </summary>
        /// <value>True if the assignment is overdue</value>
        [DataMember(Name="isOverdue", EmitDefaultValue=false)]
        public bool? IsOverdue { get; private set; }



        /// <summary>
        /// The user's percentage score for this assignment
        /// </summary>
        /// <value>The user's percentage score for this assignment</value>
        [DataMember(Name="percentageScore", EmitDefaultValue=false)]
        public float? PercentageScore { get; private set; }



        /// <summary>
        /// True if this assignment was created by a Rule
        /// </summary>
        /// <value>True if this assignment was created by a Rule</value>
        [DataMember(Name="isRule", EmitDefaultValue=false)]
        public bool? IsRule { get; private set; }



        /// <summary>
        /// True if this assignment was created manually
        /// </summary>
        /// <value>True if this assignment was created manually</value>
        [DataMember(Name="isManual", EmitDefaultValue=false)]
        public bool? IsManual { get; private set; }



        /// <summary>
        /// True if the assessment was passed
        /// </summary>
        /// <value>True if the assessment was passed</value>
        [DataMember(Name="isPassed", EmitDefaultValue=false)]
        public bool? IsPassed { get; private set; }



        /// <summary>
        /// True if the assignment is based on latest module
        /// </summary>
        /// <value>True if the assignment is based on latest module</value>
        [DataMember(Name="isLatest", EmitDefaultValue=false)]
        public bool? IsLatest { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }





        /// <summary>
        /// The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateRecommendedForCompletion", EmitDefaultValue=false)]
        public DateTime? DateRecommendedForCompletion { get; set; }



        /// <summary>
        /// The version of Learning module assigned
        /// </summary>
        /// <value>The version of Learning module assigned</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The Learning module object associated with this assignment
        /// </summary>
        /// <value>The Learning module object associated with this assignment</value>
        [DataMember(Name="module", EmitDefaultValue=false)]
        public LearningModule Module { get; set; }



        /// <summary>
        /// The user to whom the assignment is assigned
        /// </summary>
        /// <value>The user to whom the assignment is assigned</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The assessment form associated with this assignment
        /// </summary>
        /// <value>The assessment form associated with this assignment</value>
        [DataMember(Name="assessmentForm", EmitDefaultValue=false)]
        public AssessmentForm AssessmentForm { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignment {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Assessment: ").Append(Assessment).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  IsOverdue: ").Append(IsOverdue).Append("\n");
            sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
            sb.Append("  IsRule: ").Append(IsRule).Append("\n");
            sb.Append("  IsManual: ").Append(IsManual).Append("\n");
            sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
            sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DateRecommendedForCompletion: ").Append(DateRecommendedForCompletion).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  AssessmentForm: ").Append(AssessmentForm).Append("\n");
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
            return this.Equals(obj as LearningAssignment);
        }

        /// <summary>
        /// Returns true if LearningAssignment instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignment other)
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
                    this.Assessment == other.Assessment ||
                    this.Assessment != null &&
                    this.Assessment.Equals(other.Assessment)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.IsOverdue == other.IsOverdue ||
                    this.IsOverdue != null &&
                    this.IsOverdue.Equals(other.IsOverdue)
                ) &&
                (
                    this.PercentageScore == other.PercentageScore ||
                    this.PercentageScore != null &&
                    this.PercentageScore.Equals(other.PercentageScore)
                ) &&
                (
                    this.IsRule == other.IsRule ||
                    this.IsRule != null &&
                    this.IsRule.Equals(other.IsRule)
                ) &&
                (
                    this.IsManual == other.IsManual ||
                    this.IsManual != null &&
                    this.IsManual.Equals(other.IsManual)
                ) &&
                (
                    this.IsPassed == other.IsPassed ||
                    this.IsPassed != null &&
                    this.IsPassed.Equals(other.IsPassed)
                ) &&
                (
                    this.IsLatest == other.IsLatest ||
                    this.IsLatest != null &&
                    this.IsLatest.Equals(other.IsLatest)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.DateRecommendedForCompletion == other.DateRecommendedForCompletion ||
                    this.DateRecommendedForCompletion != null &&
                    this.DateRecommendedForCompletion.Equals(other.DateRecommendedForCompletion)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Module == other.Module ||
                    this.Module != null &&
                    this.Module.Equals(other.Module)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.AssessmentForm == other.AssessmentForm ||
                    this.AssessmentForm != null &&
                    this.AssessmentForm.Equals(other.AssessmentForm)
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

                if (this.Assessment != null)
                    hash = hash * 59 + this.Assessment.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.IsOverdue != null)
                    hash = hash * 59 + this.IsOverdue.GetHashCode();

                if (this.PercentageScore != null)
                    hash = hash * 59 + this.PercentageScore.GetHashCode();

                if (this.IsRule != null)
                    hash = hash * 59 + this.IsRule.GetHashCode();

                if (this.IsManual != null)
                    hash = hash * 59 + this.IsManual.GetHashCode();

                if (this.IsPassed != null)
                    hash = hash * 59 + this.IsPassed.GetHashCode();

                if (this.IsLatest != null)
                    hash = hash * 59 + this.IsLatest.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.DateRecommendedForCompletion != null)
                    hash = hash * 59 + this.DateRecommendedForCompletion.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Module != null)
                    hash = hash * 59 + this.Module.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.AssessmentForm != null)
                    hash = hash * 59 + this.AssessmentForm.GetHashCode();

                return hash;
            }
        }
    }

}
