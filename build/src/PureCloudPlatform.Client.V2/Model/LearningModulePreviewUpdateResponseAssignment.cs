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
    /// Learning module preview update response assignment
    /// </summary>
    [DataContract]
    public partial class LearningModulePreviewUpdateResponseAssignment :  IEquatable<LearningModulePreviewUpdateResponseAssignment>
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
        /// Initializes a new instance of the <see cref="LearningModulePreviewUpdateResponseAssignment" /> class.
        /// </summary>
        /// <param name="State">The Learning Assignment state.</param>
        public LearningModulePreviewUpdateResponseAssignment(StateEnum? State = null)
        {
            this.State = State;
            
        }
        




        /// <summary>
        /// The user&#39;s percentage score for this assignment
        /// </summary>
        /// <value>The user&#39;s percentage score for this assignment</value>
        [DataMember(Name="percentageScore", EmitDefaultValue=false)]
        public float? PercentageScore { get; private set; }



        /// <summary>
        /// The overall completion percentage of assignment
        /// </summary>
        /// <value>The overall completion percentage of assignment</value>
        [DataMember(Name="completionPercentage", EmitDefaultValue=false)]
        public float? CompletionPercentage { get; private set; }



        /// <summary>
        /// The user&#39;s percentage score for this assignment&#39;s assessment
        /// </summary>
        /// <value>The user&#39;s percentage score for this assignment&#39;s assessment</value>
        [DataMember(Name="assessmentPercentageScore", EmitDefaultValue=false)]
        public float? AssessmentPercentageScore { get; private set; }



        /// <summary>
        /// The assessment completion percentage of assignment
        /// </summary>
        /// <value>The assessment completion percentage of assignment</value>
        [DataMember(Name="assessmentCompletionPercentage", EmitDefaultValue=false)]
        public float? AssessmentCompletionPercentage { get; private set; }



        /// <summary>
        /// True if the assessment was passed
        /// </summary>
        /// <value>True if the assessment was passed</value>
        [DataMember(Name="isPassed", EmitDefaultValue=false)]
        public bool? IsPassed { get; private set; }



        /// <summary>
        /// The next assignment step
        /// </summary>
        /// <value>The next assignment step</value>
        [DataMember(Name="currentStep", EmitDefaultValue=false)]
        public LearningModulePreviewUpdateResponseCurrentStep CurrentStep { get; private set; }



        /// <summary>
        /// List of assignment steps
        /// </summary>
        /// <value>List of assignment steps</value>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<LearningModulePreviewUpdateStep> Steps { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningModulePreviewUpdateResponseAssignment {\n");

            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
            sb.Append("  CompletionPercentage: ").Append(CompletionPercentage).Append("\n");
            sb.Append("  AssessmentPercentageScore: ").Append(AssessmentPercentageScore).Append("\n");
            sb.Append("  AssessmentCompletionPercentage: ").Append(AssessmentCompletionPercentage).Append("\n");
            sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
            sb.Append("  CurrentStep: ").Append(CurrentStep).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
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
            return this.Equals(obj as LearningModulePreviewUpdateResponseAssignment);
        }

        /// <summary>
        /// Returns true if LearningModulePreviewUpdateResponseAssignment instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModulePreviewUpdateResponseAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModulePreviewUpdateResponseAssignment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.PercentageScore == other.PercentageScore ||
                    this.PercentageScore != null &&
                    this.PercentageScore.Equals(other.PercentageScore)
                ) &&
                (
                    this.CompletionPercentage == other.CompletionPercentage ||
                    this.CompletionPercentage != null &&
                    this.CompletionPercentage.Equals(other.CompletionPercentage)
                ) &&
                (
                    this.AssessmentPercentageScore == other.AssessmentPercentageScore ||
                    this.AssessmentPercentageScore != null &&
                    this.AssessmentPercentageScore.Equals(other.AssessmentPercentageScore)
                ) &&
                (
                    this.AssessmentCompletionPercentage == other.AssessmentCompletionPercentage ||
                    this.AssessmentCompletionPercentage != null &&
                    this.AssessmentCompletionPercentage.Equals(other.AssessmentCompletionPercentage)
                ) &&
                (
                    this.IsPassed == other.IsPassed ||
                    this.IsPassed != null &&
                    this.IsPassed.Equals(other.IsPassed)
                ) &&
                (
                    this.CurrentStep == other.CurrentStep ||
                    this.CurrentStep != null &&
                    this.CurrentStep.Equals(other.CurrentStep)
                ) &&
                (
                    this.Steps == other.Steps ||
                    this.Steps != null &&
                    this.Steps.SequenceEqual(other.Steps)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.PercentageScore != null)
                    hash = hash * 59 + this.PercentageScore.GetHashCode();

                if (this.CompletionPercentage != null)
                    hash = hash * 59 + this.CompletionPercentage.GetHashCode();

                if (this.AssessmentPercentageScore != null)
                    hash = hash * 59 + this.AssessmentPercentageScore.GetHashCode();

                if (this.AssessmentCompletionPercentage != null)
                    hash = hash * 59 + this.AssessmentCompletionPercentage.GetHashCode();

                if (this.IsPassed != null)
                    hash = hash * 59 + this.IsPassed.GetHashCode();

                if (this.CurrentStep != null)
                    hash = hash * 59 + this.CurrentStep.GetHashCode();

                if (this.Steps != null)
                    hash = hash * 59 + this.Steps.GetHashCode();

                return hash;
            }
        }
    }

}
