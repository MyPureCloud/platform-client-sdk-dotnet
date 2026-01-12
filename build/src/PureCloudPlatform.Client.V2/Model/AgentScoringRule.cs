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
    /// AgentScoringRule
    /// </summary>
    [DataContract]
    public partial class AgentScoringRule :  IEquatable<AgentScoringRule>
    {
        /// <summary>
        /// Sampling type setting. Valid values: All, Percentage
        /// </summary>
        /// <value>Sampling type setting. Valid values: All, Percentage</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SamplingTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All,
            
            /// <summary>
            /// Enum Percentage for "Percentage"
            /// </summary>
            [EnumMember(Value = "Percentage")]
            Percentage
        }
        /// <summary>
        /// Submission type for evaluations. Valid values: Automated, Manual
        /// </summary>
        /// <value>Submission type for evaluations. Valid values: Automated, Manual</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SubmissionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Automated for "Automated"
            /// </summary>
            [EnumMember(Value = "Automated")]
            Automated,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual
        }
        /// <summary>
        /// Sampling type setting. Valid values: All, Percentage
        /// </summary>
        /// <value>Sampling type setting. Valid values: All, Percentage</value>
        [DataMember(Name="samplingType", EmitDefaultValue=false)]
        public SamplingTypeEnum? SamplingType { get; set; }
        /// <summary>
        /// Submission type for evaluations. Valid values: Automated, Manual
        /// </summary>
        /// <value>Submission type for evaluations. Valid values: Automated, Manual</value>
        [DataMember(Name="submissionType", EmitDefaultValue=false)]
        public SubmissionTypeEnum? SubmissionType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScoringRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentScoringRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScoringRule" /> class.
        /// </summary>
        /// <param name="SamplingType">Sampling type setting. Valid values: All, Percentage (required).</param>
        /// <param name="SamplingPercentage">Percentage of interactions to evaluate (0.01-100.00). Required when samplingType is Percentage, null when All..</param>
        /// <param name="SubmissionType">Submission type for evaluations. Valid values: Automated, Manual (required).</param>
        /// <param name="EvaluationFormContextId">The evaluation form contextID to use for scoring. (required).</param>
        /// <param name="Enabled">Whether the rule is enabled. (required).</param>
        /// <param name="Evaluator">The evaluator for evaluations created by this rule..</param>
        public AgentScoringRule(SamplingTypeEnum? SamplingType = null, double? SamplingPercentage = null, SubmissionTypeEnum? SubmissionType = null, string EvaluationFormContextId = null, bool? Enabled = null, AddressableEntityRef Evaluator = null)
        {
            this.SamplingType = SamplingType;
            this.SamplingPercentage = SamplingPercentage;
            this.SubmissionType = SubmissionType;
            this.EvaluationFormContextId = EvaluationFormContextId;
            this.Enabled = Enabled;
            this.Evaluator = Evaluator;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The program ID that this rule belongs to. When provided in request body, this value is ignored in favor of the path parameter.
        /// </summary>
        /// <value>The program ID that this rule belongs to. When provided in request body, this value is ignored in favor of the path parameter.</value>
        [DataMember(Name="programId", EmitDefaultValue=false)]
        public string ProgramId { get; private set; }





        /// <summary>
        /// Percentage of interactions to evaluate (0.01-100.00). Required when samplingType is Percentage, null when All.
        /// </summary>
        /// <value>Percentage of interactions to evaluate (0.01-100.00). Required when samplingType is Percentage, null when All.</value>
        [DataMember(Name="samplingPercentage", EmitDefaultValue=false)]
        public double? SamplingPercentage { get; set; }





        /// <summary>
        /// The evaluation form contextID to use for scoring.
        /// </summary>
        /// <value>The evaluation form contextID to use for scoring.</value>
        [DataMember(Name="evaluationFormContextId", EmitDefaultValue=false)]
        public string EvaluationFormContextId { get; set; }



        /// <summary>
        /// Whether the rule is enabled.
        /// </summary>
        /// <value>Whether the rule is enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Whether the rule is published.
        /// </summary>
        /// <value>Whether the rule is published.</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; private set; }



        /// <summary>
        /// The evaluator for evaluations created by this rule.
        /// </summary>
        /// <value>The evaluator for evaluations created by this rule.</value>
        [DataMember(Name="evaluator", EmitDefaultValue=false)]
        public AddressableEntityRef Evaluator { get; set; }



        /// <summary>
        /// Date when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Date when the rule was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the rule was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentScoringRule {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  SamplingType: ").Append(SamplingType).Append("\n");
            sb.Append("  SamplingPercentage: ").Append(SamplingPercentage).Append("\n");
            sb.Append("  SubmissionType: ").Append(SubmissionType).Append("\n");
            sb.Append("  EvaluationFormContextId: ").Append(EvaluationFormContextId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as AgentScoringRule);
        }

        /// <summary>
        /// Returns true if AgentScoringRule instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentScoringRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentScoringRule other)
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
                    this.ProgramId == other.ProgramId ||
                    this.ProgramId != null &&
                    this.ProgramId.Equals(other.ProgramId)
                ) &&
                (
                    this.SamplingType == other.SamplingType ||
                    this.SamplingType != null &&
                    this.SamplingType.Equals(other.SamplingType)
                ) &&
                (
                    this.SamplingPercentage == other.SamplingPercentage ||
                    this.SamplingPercentage != null &&
                    this.SamplingPercentage.Equals(other.SamplingPercentage)
                ) &&
                (
                    this.SubmissionType == other.SubmissionType ||
                    this.SubmissionType != null &&
                    this.SubmissionType.Equals(other.SubmissionType)
                ) &&
                (
                    this.EvaluationFormContextId == other.EvaluationFormContextId ||
                    this.EvaluationFormContextId != null &&
                    this.EvaluationFormContextId.Equals(other.EvaluationFormContextId)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.Evaluator == other.Evaluator ||
                    this.Evaluator != null &&
                    this.Evaluator.Equals(other.Evaluator)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.ProgramId != null)
                    hash = hash * 59 + this.ProgramId.GetHashCode();

                if (this.SamplingType != null)
                    hash = hash * 59 + this.SamplingType.GetHashCode();

                if (this.SamplingPercentage != null)
                    hash = hash * 59 + this.SamplingPercentage.GetHashCode();

                if (this.SubmissionType != null)
                    hash = hash * 59 + this.SubmissionType.GetHashCode();

                if (this.EvaluationFormContextId != null)
                    hash = hash * 59 + this.EvaluationFormContextId.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();

                if (this.Evaluator != null)
                    hash = hash * 59 + this.Evaluator.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
