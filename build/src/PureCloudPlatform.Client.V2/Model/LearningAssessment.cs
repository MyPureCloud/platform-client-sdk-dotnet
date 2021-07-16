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
    /// LearningAssessment
    /// </summary>
    [DataContract]
    public partial class LearningAssessment :  IEquatable<LearningAssessment>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Status of the assessment
        /// </summary>
        /// <value>Status of the assessment</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Finished for "Finished"
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Status of the assessment
        /// </summary>
        /// <value>Status of the assessment</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssessment" /> class.
        /// </summary>
        /// <param name="Answers">Answers for the assessment.</param>
        public LearningAssessment(AssessmentScoringSet Answers = null)
        {
            this.Answers = Answers;
            
        }
        
        
        
        /// <summary>
        /// The Id of the assessment
        /// </summary>
        /// <value>The Id of the assessment</value>
        [DataMember(Name="assessmentId", EmitDefaultValue=false)]
        public string AssessmentId { get; private set; }
        
        
        
        /// <summary>
        /// The context Id of the related assessment form
        /// </summary>
        /// <value>The context Id of the related assessment form</value>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; private set; }
        
        
        
        /// <summary>
        /// The Id of the related assessment form
        /// </summary>
        /// <value>The Id of the related assessment form</value>
        [DataMember(Name="assessmentFormId", EmitDefaultValue=false)]
        public string AssessmentFormId { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Answers for the assessment
        /// </summary>
        /// <value>Answers for the assessment</value>
        [DataMember(Name="answers", EmitDefaultValue=false)]
        public AssessmentScoringSet Answers { get; set; }
        
        
        
        /// <summary>
        /// Date the assessment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date the assessment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Date the assessment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date the assessment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// Date the assessment was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date the assessment was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateSubmitted", EmitDefaultValue=false)]
        public DateTime? DateSubmitted { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssessment {\n");
            
            sb.Append("  AssessmentId: ").Append(AssessmentId).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  AssessmentFormId: ").Append(AssessmentFormId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Answers: ").Append(Answers).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DateSubmitted: ").Append(DateSubmitted).Append("\n");
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
            return this.Equals(obj as LearningAssessment);
        }

        /// <summary>
        /// Returns true if LearningAssessment instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssessment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssessment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AssessmentId == other.AssessmentId ||
                    this.AssessmentId != null &&
                    this.AssessmentId.Equals(other.AssessmentId)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) &&
                (
                    this.AssessmentFormId == other.AssessmentFormId ||
                    this.AssessmentFormId != null &&
                    this.AssessmentFormId.Equals(other.AssessmentFormId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Answers == other.Answers ||
                    this.Answers != null &&
                    this.Answers.Equals(other.Answers)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.DateSubmitted == other.DateSubmitted ||
                    this.DateSubmitted != null &&
                    this.DateSubmitted.Equals(other.DateSubmitted)
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
                
                if (this.AssessmentId != null)
                    hash = hash * 59 + this.AssessmentId.GetHashCode();
                
                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();
                
                if (this.AssessmentFormId != null)
                    hash = hash * 59 + this.AssessmentFormId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Answers != null)
                    hash = hash * 59 + this.Answers.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.DateSubmitted != null)
                    hash = hash * 59 + this.DateSubmitted.GetHashCode();
                
                return hash;
            }
        }
    }

}
