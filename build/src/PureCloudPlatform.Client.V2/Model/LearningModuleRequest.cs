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
    /// Learning module request
    /// </summary>
    [DataContract]
    public partial class LearningModuleRequest :  IEquatable<LearningModuleRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type for the learning module
        /// </summary>
        /// <value>The type for the learning module</value>
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
            /// Enum Informational for "Informational"
            /// </summary>
            [EnumMember(Value = "Informational")]
            Informational,
            
            /// <summary>
            /// Enum Assessedcontent for "AssessedContent"
            /// </summary>
            [EnumMember(Value = "AssessedContent")]
            Assessedcontent,
            
            /// <summary>
            /// Enum Questionnaire for "Questionnaire"
            /// </summary>
            [EnumMember(Value = "Questionnaire")]
            Questionnaire,
            
            /// <summary>
            /// Enum Assessment for "Assessment"
            /// </summary>
            [EnumMember(Value = "Assessment")]
            Assessment
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type for the learning module
        /// </summary>
        /// <value>The type for the learning module</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningModuleRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of learning module (required).</param>
        /// <param name="Description">The description of learning module.</param>
        /// <param name="CompletionTimeInDays">The completion time of learning module in days (required).</param>
        /// <param name="InformSteps">The list of inform steps in a learning module.</param>
        /// <param name="Type">The type for the learning module.</param>
        /// <param name="AssessmentForm">The assessment form for learning module.</param>
        public LearningModuleRequest(string Name = null, string Description = null, int? CompletionTimeInDays = null, List<LearningModuleInformStepRequest> InformSteps = null, TypeEnum? Type = null, AssessmentForm AssessmentForm = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.CompletionTimeInDays = CompletionTimeInDays;
            this.InformSteps = InformSteps;
            this.Type = Type;
            this.AssessmentForm = AssessmentForm;
            
        }
        
        
        
        /// <summary>
        /// The name of learning module
        /// </summary>
        /// <value>The name of learning module</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The description of learning module
        /// </summary>
        /// <value>The description of learning module</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The completion time of learning module in days
        /// </summary>
        /// <value>The completion time of learning module in days</value>
        [DataMember(Name="completionTimeInDays", EmitDefaultValue=false)]
        public int? CompletionTimeInDays { get; set; }
        
        
        
        /// <summary>
        /// The list of inform steps in a learning module
        /// </summary>
        /// <value>The list of inform steps in a learning module</value>
        [DataMember(Name="informSteps", EmitDefaultValue=false)]
        public List<LearningModuleInformStepRequest> InformSteps { get; set; }
        
        
        
        
        
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
            sb.Append("class LearningModuleRequest {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CompletionTimeInDays: ").Append(CompletionTimeInDays).Append("\n");
            sb.Append("  InformSteps: ").Append(InformSteps).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as LearningModuleRequest);
        }

        /// <summary>
        /// Returns true if LearningModuleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModuleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModuleRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.CompletionTimeInDays == other.CompletionTimeInDays ||
                    this.CompletionTimeInDays != null &&
                    this.CompletionTimeInDays.Equals(other.CompletionTimeInDays)
                ) &&
                (
                    this.InformSteps == other.InformSteps ||
                    this.InformSteps != null &&
                    this.InformSteps.SequenceEqual(other.InformSteps)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.CompletionTimeInDays != null)
                    hash = hash * 59 + this.CompletionTimeInDays.GetHashCode();
                
                if (this.InformSteps != null)
                    hash = hash * 59 + this.InformSteps.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.AssessmentForm != null)
                    hash = hash * 59 + this.AssessmentForm.GetHashCode();
                
                return hash;
            }
        }
    }

}
