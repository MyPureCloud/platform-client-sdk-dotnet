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
    /// Learning module preview get response assignment step
    /// </summary>
    [DataContract]
    public partial class LearningModulePreviewGetResponseStep :  IEquatable<LearningModulePreviewGetResponseStep>
    {
        /// <summary>
        /// The success status of this step
        /// </summary>
        /// <value>The success status of this step</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SuccessStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Passed for "Passed"
            /// </summary>
            [EnumMember(Value = "Passed")]
            Passed,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The completion status of the assignment step
        /// </summary>
        /// <value>The completion status of the assignment step</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CompletionStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Incomplete for "Incomplete"
            /// </summary>
            [EnumMember(Value = "Incomplete")]
            Incomplete,
            
            /// <summary>
            /// Enum Notattempted for "NotAttempted"
            /// </summary>
            [EnumMember(Value = "NotAttempted")]
            Notattempted,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The success status of this step
        /// </summary>
        /// <value>The success status of this step</value>
        [DataMember(Name="successStatus", EmitDefaultValue=false)]
        public SuccessStatusEnum? SuccessStatus { get; private set; }
        /// <summary>
        /// The completion status of the assignment step
        /// </summary>
        /// <value>The completion status of the assignment step</value>
        [DataMember(Name="completionStatus", EmitDefaultValue=false)]
        public CompletionStatusEnum? CompletionStatus { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModulePreviewGetResponseStep" /> class.
        /// </summary>
        /// <param name="CompletionPercentage">The completion percentage for this step.</param>
        public LearningModulePreviewGetResponseStep(float? CompletionPercentage = null)
        {
            this.CompletionPercentage = CompletionPercentage;
            
        }
        


        /// <summary>
        /// The id of the step
        /// </summary>
        /// <value>The id of the step</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The module step data for this step
        /// </summary>
        /// <value>The module step data for this step</value>
        [DataMember(Name="moduleStep", EmitDefaultValue=false)]
        public LearningModuleInformStep ModuleStep { get; private set; }



        /// <summary>
        /// The structure for any SCO associated with this step
        /// </summary>
        /// <value>The structure for any SCO associated with this step</value>
        [DataMember(Name="structure", EmitDefaultValue=false)]
        public List<LearningModulePreviewGetScoStructure> Structure { get; private set; }







        /// <summary>
        /// The completion percentage for this step
        /// </summary>
        /// <value>The completion percentage for this step</value>
        [DataMember(Name="completionPercentage", EmitDefaultValue=false)]
        public float? CompletionPercentage { get; set; }



        /// <summary>
        /// The percentage score for this step
        /// </summary>
        /// <value>The percentage score for this step</value>
        [DataMember(Name="percentageScore", EmitDefaultValue=false)]
        public float? PercentageScore { get; private set; }



        /// <summary>
        /// The signed cookie information needed to access the content of this step (if required)
        /// </summary>
        /// <value>The signed cookie information needed to access the content of this step (if required)</value>
        [DataMember(Name="signedCookie", EmitDefaultValue=false)]
        public LearningAssignmentStepSignedCookie SignedCookie { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningModulePreviewGetResponseStep {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModuleStep: ").Append(ModuleStep).Append("\n");
            sb.Append("  Structure: ").Append(Structure).Append("\n");
            sb.Append("  SuccessStatus: ").Append(SuccessStatus).Append("\n");
            sb.Append("  CompletionStatus: ").Append(CompletionStatus).Append("\n");
            sb.Append("  CompletionPercentage: ").Append(CompletionPercentage).Append("\n");
            sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
            sb.Append("  SignedCookie: ").Append(SignedCookie).Append("\n");
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
            return this.Equals(obj as LearningModulePreviewGetResponseStep);
        }

        /// <summary>
        /// Returns true if LearningModulePreviewGetResponseStep instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModulePreviewGetResponseStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModulePreviewGetResponseStep other)
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
                    this.ModuleStep == other.ModuleStep ||
                    this.ModuleStep != null &&
                    this.ModuleStep.Equals(other.ModuleStep)
                ) &&
                (
                    this.Structure == other.Structure ||
                    this.Structure != null &&
                    this.Structure.SequenceEqual(other.Structure)
                ) &&
                (
                    this.SuccessStatus == other.SuccessStatus ||
                    this.SuccessStatus != null &&
                    this.SuccessStatus.Equals(other.SuccessStatus)
                ) &&
                (
                    this.CompletionStatus == other.CompletionStatus ||
                    this.CompletionStatus != null &&
                    this.CompletionStatus.Equals(other.CompletionStatus)
                ) &&
                (
                    this.CompletionPercentage == other.CompletionPercentage ||
                    this.CompletionPercentage != null &&
                    this.CompletionPercentage.Equals(other.CompletionPercentage)
                ) &&
                (
                    this.PercentageScore == other.PercentageScore ||
                    this.PercentageScore != null &&
                    this.PercentageScore.Equals(other.PercentageScore)
                ) &&
                (
                    this.SignedCookie == other.SignedCookie ||
                    this.SignedCookie != null &&
                    this.SignedCookie.Equals(other.SignedCookie)
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

                if (this.ModuleStep != null)
                    hash = hash * 59 + this.ModuleStep.GetHashCode();

                if (this.Structure != null)
                    hash = hash * 59 + this.Structure.GetHashCode();

                if (this.SuccessStatus != null)
                    hash = hash * 59 + this.SuccessStatus.GetHashCode();

                if (this.CompletionStatus != null)
                    hash = hash * 59 + this.CompletionStatus.GetHashCode();

                if (this.CompletionPercentage != null)
                    hash = hash * 59 + this.CompletionPercentage.GetHashCode();

                if (this.PercentageScore != null)
                    hash = hash * 59 + this.PercentageScore.GetHashCode();

                if (this.SignedCookie != null)
                    hash = hash * 59 + this.SignedCookie.GetHashCode();

                return hash;
            }
        }
    }

}
