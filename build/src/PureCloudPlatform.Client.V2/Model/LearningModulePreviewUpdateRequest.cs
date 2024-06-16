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
    /// Learning module preview update request
    /// </summary>
    [DataContract]
    public partial class LearningModulePreviewUpdateRequest :  IEquatable<LearningModulePreviewUpdateRequest>
    {
        /// <summary>
        /// The assignment State
        /// </summary>
        /// <value>The assignment State</value>
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
        /// The assignment State
        /// </summary>
        /// <value>The assignment State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModulePreviewUpdateRequest" /> class.
        /// </summary>
        /// <param name="State">The assignment State.</param>
        /// <param name="CurrentStep">The assignment current step.</param>
        /// <param name="Steps">The assignment Steps.</param>
        /// <param name="Assessment">The assessment for learning module.</param>
        /// <param name="AssessmentForm">The assessment form for learning module.</param>
        public LearningModulePreviewUpdateRequest(StateEnum? State = null, LearningModulePreviewUpdateRequestCurrentStep CurrentStep = null, List<LearningModulePreviewUpdateStep> Steps = null, LearningAssessment Assessment = null, AssessmentForm AssessmentForm = null)
        {
            this.State = State;
            this.CurrentStep = CurrentStep;
            this.Steps = Steps;
            this.Assessment = Assessment;
            this.AssessmentForm = AssessmentForm;
            
        }
        




        /// <summary>
        /// The assignment current step
        /// </summary>
        /// <value>The assignment current step</value>
        [DataMember(Name="currentStep", EmitDefaultValue=false)]
        public LearningModulePreviewUpdateRequestCurrentStep CurrentStep { get; set; }



        /// <summary>
        /// The assignment Steps
        /// </summary>
        /// <value>The assignment Steps</value>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<LearningModulePreviewUpdateStep> Steps { get; set; }



        /// <summary>
        /// The assessment for learning module
        /// </summary>
        /// <value>The assessment for learning module</value>
        [DataMember(Name="assessment", EmitDefaultValue=false)]
        public LearningAssessment Assessment { get; set; }



        /// <summary>
        /// The assessment form for learning module
        /// </summary>
        /// <value>The assessment form for learning module</value>
        [DataMember(Name="assessmentForm", EmitDefaultValue=false)]
        public AssessmentForm AssessmentForm { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningModulePreviewUpdateRequest {\n");

            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CurrentStep: ").Append(CurrentStep).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Assessment: ").Append(Assessment).Append("\n");
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
            return this.Equals(obj as LearningModulePreviewUpdateRequest);
        }

        /// <summary>
        /// Returns true if LearningModulePreviewUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModulePreviewUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModulePreviewUpdateRequest other)
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
                    this.CurrentStep == other.CurrentStep ||
                    this.CurrentStep != null &&
                    this.CurrentStep.Equals(other.CurrentStep)
                ) &&
                (
                    this.Steps == other.Steps ||
                    this.Steps != null &&
                    this.Steps.SequenceEqual(other.Steps)
                ) &&
                (
                    this.Assessment == other.Assessment ||
                    this.Assessment != null &&
                    this.Assessment.Equals(other.Assessment)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.CurrentStep != null)
                    hash = hash * 59 + this.CurrentStep.GetHashCode();

                if (this.Steps != null)
                    hash = hash * 59 + this.Steps.GetHashCode();

                if (this.Assessment != null)
                    hash = hash * 59 + this.Assessment.GetHashCode();

                if (this.AssessmentForm != null)
                    hash = hash * 59 + this.AssessmentForm.GetHashCode();

                return hash;
            }
        }
    }

}
