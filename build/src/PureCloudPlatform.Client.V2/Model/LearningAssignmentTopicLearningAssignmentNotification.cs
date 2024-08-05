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
    /// LearningAssignmentTopicLearningAssignmentNotification
    /// </summary>
    [DataContract]
    public partial class LearningAssignmentTopicLearningAssignmentNotification :  IEquatable<LearningAssignmentTopicLearningAssignmentNotification>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
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
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Native for "Native"
            /// </summary>
            [EnumMember(Value = "Native")]
            Native,
            
            /// <summary>
            /// Enum External for "External"
            /// </summary>
            [EnumMember(Value = "External")]
            External
        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentTopicLearningAssignmentNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="User">User.</param>
        /// <param name="Module">Module.</param>
        /// <param name="Version">Version.</param>
        /// <param name="State">State.</param>
        /// <param name="DateRecommendedForCompletion">DateRecommendedForCompletion.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="IsOverdue">IsOverdue.</param>
        /// <param name="LengthInMinutes">LengthInMinutes.</param>
        /// <param name="PercentageScore">PercentageScore.</param>
        /// <param name="IsPassed">IsPassed.</param>
        /// <param name="Type">Type.</param>
        public LearningAssignmentTopicLearningAssignmentNotification(string Id = null, LearningAssignmentTopicUserReference User = null, LearningAssignmentTopicLearningModuleReference Module = null, int? Version = null, StateEnum? State = null, DateTime? DateRecommendedForCompletion = null, LearningAssignmentTopicUserReference CreatedBy = null, DateTime? DateCreated = null, LearningAssignmentTopicUserReference ModifiedBy = null, DateTime? DateModified = null, bool? IsOverdue = null, int? LengthInMinutes = null, double? PercentageScore = null, bool? IsPassed = null, TypeEnum? Type = null)
        {
            this.Id = Id;
            this.User = User;
            this.Module = Module;
            this.Version = Version;
            this.State = State;
            this.DateRecommendedForCompletion = DateRecommendedForCompletion;
            this.CreatedBy = CreatedBy;
            this.DateCreated = DateCreated;
            this.ModifiedBy = ModifiedBy;
            this.DateModified = DateModified;
            this.IsOverdue = IsOverdue;
            this.LengthInMinutes = LengthInMinutes;
            this.PercentageScore = PercentageScore;
            this.IsPassed = IsPassed;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public LearningAssignmentTopicUserReference User { get; set; }



        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name="module", EmitDefaultValue=false)]
        public LearningAssignmentTopicLearningModuleReference Module { get; set; }



        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }





        /// <summary>
        /// Gets or Sets DateRecommendedForCompletion
        /// </summary>
        [DataMember(Name="dateRecommendedForCompletion", EmitDefaultValue=false)]
        public DateTime? DateRecommendedForCompletion { get; set; }



        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public LearningAssignmentTopicUserReference CreatedBy { get; set; }



        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public LearningAssignmentTopicUserReference ModifiedBy { get; set; }



        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Gets or Sets IsOverdue
        /// </summary>
        [DataMember(Name="isOverdue", EmitDefaultValue=false)]
        public bool? IsOverdue { get; set; }



        /// <summary>
        /// Gets or Sets LengthInMinutes
        /// </summary>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }



        /// <summary>
        /// Gets or Sets PercentageScore
        /// </summary>
        [DataMember(Name="percentageScore", EmitDefaultValue=false)]
        public double? PercentageScore { get; set; }



        /// <summary>
        /// Gets or Sets IsPassed
        /// </summary>
        [DataMember(Name="isPassed", EmitDefaultValue=false)]
        public bool? IsPassed { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignmentTopicLearningAssignmentNotification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DateRecommendedForCompletion: ").Append(DateRecommendedForCompletion).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  IsOverdue: ").Append(IsOverdue).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
            sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as LearningAssignmentTopicLearningAssignmentNotification);
        }

        /// <summary>
        /// Returns true if LearningAssignmentTopicLearningAssignmentNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignmentTopicLearningAssignmentNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignmentTopicLearningAssignmentNotification other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Module == other.Module ||
                    this.Module != null &&
                    this.Module.Equals(other.Module)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                    this.LengthInMinutes == other.LengthInMinutes ||
                    this.LengthInMinutes != null &&
                    this.LengthInMinutes.Equals(other.LengthInMinutes)
                ) &&
                (
                    this.PercentageScore == other.PercentageScore ||
                    this.PercentageScore != null &&
                    this.PercentageScore.Equals(other.PercentageScore)
                ) &&
                (
                    this.IsPassed == other.IsPassed ||
                    this.IsPassed != null &&
                    this.IsPassed.Equals(other.IsPassed)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Module != null)
                    hash = hash * 59 + this.Module.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.DateRecommendedForCompletion != null)
                    hash = hash * 59 + this.DateRecommendedForCompletion.GetHashCode();

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

                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();

                if (this.PercentageScore != null)
                    hash = hash * 59 + this.PercentageScore.GetHashCode();

                if (this.IsPassed != null)
                    hash = hash * 59 + this.IsPassed.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
