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
    /// EvaluationFormResponse
    /// </summary>
    [DataContract]
    public partial class EvaluationFormResponse :  IEquatable<EvaluationFormResponse>
    {
        /// <summary>
        /// Mode for evaluation form weight
        /// </summary>
        /// <value>Mode for evaluation form weight</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum WeightModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Scaled for "SCALED"
            /// </summary>
            [EnumMember(Value = "SCALED")]
            Scaled,
            
            /// <summary>
            /// Enum Off for "OFF"
            /// </summary>
            [EnumMember(Value = "OFF")]
            Off
        }
        /// <summary>
        /// Mode for evaluation form weight
        /// </summary>
        /// <value>Mode for evaluation form weight</value>
        [DataMember(Name="weightMode", EmitDefaultValue=false)]
        public WeightModeEnum? WeightMode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationFormResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvaluationFormResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationFormResponse" /> class.
        /// </summary>
        /// <param name="Name">The evaluation form name (required).</param>
        /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Published">Published.</param>
        /// <param name="ContextId">ContextId.</param>
        /// <param name="QuestionGroups">A list of question groups.</param>
        /// <param name="WeightMode">Mode for evaluation form weight.</param>
        /// <param name="EvaluationSettings">Settings for evaluations associated with this form.</param>
        /// <param name="PublishedVersions">A list of the published versions of this form. Not populated by default, its availability depends on the endpoint. Use the &#39;expand&#x3D;publishHistory&#39; query parameter to retrieve this data where applicable (refer to the endpoint description to see if it is applicable)..</param>
        /// <param name="LatestVersionFormName">The name of the form&#39;s most recently published version.</param>
        public EvaluationFormResponse(string Name = null, DateTime? ModifiedDate = null, bool? Published = null, string ContextId = null, List<EvaluationQuestionGroup> QuestionGroups = null, WeightModeEnum? WeightMode = null, EvaluationSettings EvaluationSettings = null, DomainEntityListingEvaluationForm PublishedVersions = null, string LatestVersionFormName = null)
        {
            this.Name = Name;
            this.ModifiedDate = ModifiedDate;
            this.Published = Published;
            this.ContextId = ContextId;
            this.QuestionGroups = QuestionGroups;
            this.WeightMode = WeightMode;
            this.EvaluationSettings = EvaluationSettings;
            this.PublishedVersions = PublishedVersions;
            this.LatestVersionFormName = LatestVersionFormName;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The evaluation form name
        /// </summary>
        /// <value>The evaluation form name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }



        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }



        /// <summary>
        /// Gets or Sets ContextId
        /// </summary>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }



        /// <summary>
        /// A list of question groups
        /// </summary>
        /// <value>A list of question groups</value>
        [DataMember(Name="questionGroups", EmitDefaultValue=false)]
        public List<EvaluationQuestionGroup> QuestionGroups { get; set; }





        /// <summary>
        /// Settings for evaluations associated with this form
        /// </summary>
        /// <value>Settings for evaluations associated with this form</value>
        [DataMember(Name="evaluationSettings", EmitDefaultValue=false)]
        public EvaluationSettings EvaluationSettings { get; set; }



        /// <summary>
        /// A list of the published versions of this form. Not populated by default, its availability depends on the endpoint. Use the &#39;expand&#x3D;publishHistory&#39; query parameter to retrieve this data where applicable (refer to the endpoint description to see if it is applicable).
        /// </summary>
        /// <value>A list of the published versions of this form. Not populated by default, its availability depends on the endpoint. Use the &#39;expand&#x3D;publishHistory&#39; query parameter to retrieve this data where applicable (refer to the endpoint description to see if it is applicable).</value>
        [DataMember(Name="publishedVersions", EmitDefaultValue=false)]
        public DomainEntityListingEvaluationForm PublishedVersions { get; set; }



        /// <summary>
        /// The name of the form&#39;s most recently published version
        /// </summary>
        /// <value>The name of the form&#39;s most recently published version</value>
        [DataMember(Name="latestVersionFormName", EmitDefaultValue=false)]
        public string LatestVersionFormName { get; set; }



        /// <summary>
        /// AI scoring settings for the evaluation form.
        /// </summary>
        /// <value>AI scoring settings for the evaluation form.</value>
        [DataMember(Name="aiScoring", EmitDefaultValue=false)]
        public AiScoringSettings AiScoring { get; private set; }



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
            sb.Append("class EvaluationFormResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  QuestionGroups: ").Append(QuestionGroups).Append("\n");
            sb.Append("  WeightMode: ").Append(WeightMode).Append("\n");
            sb.Append("  EvaluationSettings: ").Append(EvaluationSettings).Append("\n");
            sb.Append("  PublishedVersions: ").Append(PublishedVersions).Append("\n");
            sb.Append("  LatestVersionFormName: ").Append(LatestVersionFormName).Append("\n");
            sb.Append("  AiScoring: ").Append(AiScoring).Append("\n");
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
            return this.Equals(obj as EvaluationFormResponse);
        }

        /// <summary>
        /// Returns true if EvaluationFormResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationFormResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationFormResponse other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) &&
                (
                    this.QuestionGroups == other.QuestionGroups ||
                    this.QuestionGroups != null &&
                    this.QuestionGroups.SequenceEqual(other.QuestionGroups)
                ) &&
                (
                    this.WeightMode == other.WeightMode ||
                    this.WeightMode != null &&
                    this.WeightMode.Equals(other.WeightMode)
                ) &&
                (
                    this.EvaluationSettings == other.EvaluationSettings ||
                    this.EvaluationSettings != null &&
                    this.EvaluationSettings.Equals(other.EvaluationSettings)
                ) &&
                (
                    this.PublishedVersions == other.PublishedVersions ||
                    this.PublishedVersions != null &&
                    this.PublishedVersions.Equals(other.PublishedVersions)
                ) &&
                (
                    this.LatestVersionFormName == other.LatestVersionFormName ||
                    this.LatestVersionFormName != null &&
                    this.LatestVersionFormName.Equals(other.LatestVersionFormName)
                ) &&
                (
                    this.AiScoring == other.AiScoring ||
                    this.AiScoring != null &&
                    this.AiScoring.Equals(other.AiScoring)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();

                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();

                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();

                if (this.QuestionGroups != null)
                    hash = hash * 59 + this.QuestionGroups.GetHashCode();

                if (this.WeightMode != null)
                    hash = hash * 59 + this.WeightMode.GetHashCode();

                if (this.EvaluationSettings != null)
                    hash = hash * 59 + this.EvaluationSettings.GetHashCode();

                if (this.PublishedVersions != null)
                    hash = hash * 59 + this.PublishedVersions.GetHashCode();

                if (this.LatestVersionFormName != null)
                    hash = hash * 59 + this.LatestVersionFormName.GetHashCode();

                if (this.AiScoring != null)
                    hash = hash * 59 + this.AiScoring.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
