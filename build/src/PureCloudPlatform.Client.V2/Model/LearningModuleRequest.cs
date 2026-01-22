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
        /// The type for the learning module. Informational, AssessedContent and Assessment are deprecated
        /// </summary>
        /// <value>The type for the learning module. Informational, AssessedContent and Assessment are deprecated</value>
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
            /// Enum Assessment for "Assessment"
            /// </summary>
            [EnumMember(Value = "Assessment")]
            Assessment,
            
            /// <summary>
            /// Enum External for "External"
            /// </summary>
            [EnumMember(Value = "External")]
            External,
            
            /// <summary>
            /// Enum Native for "Native"
            /// </summary>
            [EnumMember(Value = "Native")]
            Native
        }
        /// <summary>
        /// The type for the learning module. Informational, AssessedContent and Assessment are deprecated
        /// </summary>
        /// <value>The type for the learning module. Informational, AssessedContent and Assessment are deprecated</value>
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
        /// <param name="Type">The type for the learning module. Informational, AssessedContent and Assessment are deprecated.</param>
        /// <param name="AssessmentForm">The assessment form for learning module.</param>
        /// <param name="CoverArt">The cover art for the learning module.</param>
        /// <param name="LengthInMinutes">The recommended time in minutes to complete the module.</param>
        /// <param name="ExcludedFromCatalog">If true, learning module is excluded when retrieving modules for manual assignment.</param>
        /// <param name="ExternalId">The external ID of the learning module. Maximum length: 50 characters..</param>
        /// <param name="EnforceContentOrder">If true, learning module content should be viewed one by one in order.</param>
        /// <param name="ReviewAssessmentResults">Allows to view Assessment results in detail.</param>
        /// <param name="AutoAssign">The configuration for linking a module to a rule.</param>
        public LearningModuleRequest(string Name = null, string Description = null, int? CompletionTimeInDays = null, List<LearningModuleInformStepRequest> InformSteps = null, TypeEnum? Type = null, AssessmentForm AssessmentForm = null, LearningModuleCoverArtRequest CoverArt = null, int? LengthInMinutes = null, bool? ExcludedFromCatalog = null, string ExternalId = null, bool? EnforceContentOrder = null, ReviewAssessmentResults ReviewAssessmentResults = null, LearningModuleAutoAssignRequest AutoAssign = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.CompletionTimeInDays = CompletionTimeInDays;
            this.InformSteps = InformSteps;
            this.Type = Type;
            this.AssessmentForm = AssessmentForm;
            this.CoverArt = CoverArt;
            this.LengthInMinutes = LengthInMinutes;
            this.ExcludedFromCatalog = ExcludedFromCatalog;
            this.ExternalId = ExternalId;
            this.EnforceContentOrder = EnforceContentOrder;
            this.ReviewAssessmentResults = ReviewAssessmentResults;
            this.AutoAssign = AutoAssign;
            
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
        /// The cover art for the learning module
        /// </summary>
        /// <value>The cover art for the learning module</value>
        [DataMember(Name="coverArt", EmitDefaultValue=false)]
        public LearningModuleCoverArtRequest CoverArt { get; set; }



        /// <summary>
        /// The recommended time in minutes to complete the module
        /// </summary>
        /// <value>The recommended time in minutes to complete the module</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }



        /// <summary>
        /// If true, learning module is excluded when retrieving modules for manual assignment
        /// </summary>
        /// <value>If true, learning module is excluded when retrieving modules for manual assignment</value>
        [DataMember(Name="excludedFromCatalog", EmitDefaultValue=false)]
        public bool? ExcludedFromCatalog { get; set; }



        /// <summary>
        /// The external ID of the learning module. Maximum length: 50 characters.
        /// </summary>
        /// <value>The external ID of the learning module. Maximum length: 50 characters.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }



        /// <summary>
        /// If true, learning module content should be viewed one by one in order
        /// </summary>
        /// <value>If true, learning module content should be viewed one by one in order</value>
        [DataMember(Name="enforceContentOrder", EmitDefaultValue=false)]
        public bool? EnforceContentOrder { get; set; }



        /// <summary>
        /// Allows to view Assessment results in detail
        /// </summary>
        /// <value>Allows to view Assessment results in detail</value>
        [DataMember(Name="reviewAssessmentResults", EmitDefaultValue=false)]
        public ReviewAssessmentResults ReviewAssessmentResults { get; set; }



        /// <summary>
        /// The configuration for linking a module to a rule
        /// </summary>
        /// <value>The configuration for linking a module to a rule</value>
        [DataMember(Name="autoAssign", EmitDefaultValue=false)]
        public LearningModuleAutoAssignRequest AutoAssign { get; set; }


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
            sb.Append("  CoverArt: ").Append(CoverArt).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  ExcludedFromCatalog: ").Append(ExcludedFromCatalog).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  EnforceContentOrder: ").Append(EnforceContentOrder).Append("\n");
            sb.Append("  ReviewAssessmentResults: ").Append(ReviewAssessmentResults).Append("\n");
            sb.Append("  AutoAssign: ").Append(AutoAssign).Append("\n");
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
                ) &&
                (
                    this.CoverArt == other.CoverArt ||
                    this.CoverArt != null &&
                    this.CoverArt.Equals(other.CoverArt)
                ) &&
                (
                    this.LengthInMinutes == other.LengthInMinutes ||
                    this.LengthInMinutes != null &&
                    this.LengthInMinutes.Equals(other.LengthInMinutes)
                ) &&
                (
                    this.ExcludedFromCatalog == other.ExcludedFromCatalog ||
                    this.ExcludedFromCatalog != null &&
                    this.ExcludedFromCatalog.Equals(other.ExcludedFromCatalog)
                ) &&
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) &&
                (
                    this.EnforceContentOrder == other.EnforceContentOrder ||
                    this.EnforceContentOrder != null &&
                    this.EnforceContentOrder.Equals(other.EnforceContentOrder)
                ) &&
                (
                    this.ReviewAssessmentResults == other.ReviewAssessmentResults ||
                    this.ReviewAssessmentResults != null &&
                    this.ReviewAssessmentResults.Equals(other.ReviewAssessmentResults)
                ) &&
                (
                    this.AutoAssign == other.AutoAssign ||
                    this.AutoAssign != null &&
                    this.AutoAssign.Equals(other.AutoAssign)
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

                if (this.CoverArt != null)
                    hash = hash * 59 + this.CoverArt.GetHashCode();

                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();

                if (this.ExcludedFromCatalog != null)
                    hash = hash * 59 + this.ExcludedFromCatalog.GetHashCode();

                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();

                if (this.EnforceContentOrder != null)
                    hash = hash * 59 + this.EnforceContentOrder.GetHashCode();

                if (this.ReviewAssessmentResults != null)
                    hash = hash * 59 + this.ReviewAssessmentResults.GetHashCode();

                if (this.AutoAssign != null)
                    hash = hash * 59 + this.AutoAssign.GetHashCode();

                return hash;
            }
        }
    }

}
