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
    /// HealthInfo
    /// </summary>
    [DataContract]
    public partial class HealthInfo :  IEquatable<HealthInfo>
    {
        /// <summary>
        /// Status of health computation for this intent.
        /// </summary>
        /// <value>Status of health computation for this intent.</value>
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
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Gets or Sets StaticValidationResults
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StaticValidationResultsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Toofewutterances for "TooFewUtterances"
            /// </summary>
            [EnumMember(Value = "TooFewUtterances")]
            Toofewutterances,
            
            /// <summary>
            /// Enum Toomanyutterances for "TooManyUtterances"
            /// </summary>
            [EnumMember(Value = "TooManyUtterances")]
            Toomanyutterances,
            
            /// <summary>
            /// Enum Utterancetooshort for "UtteranceTooShort"
            /// </summary>
            [EnumMember(Value = "UtteranceTooShort")]
            Utterancetooshort,
            
            /// <summary>
            /// Enum Utterancetoolong for "UtteranceTooLong"
            /// </summary>
            [EnumMember(Value = "UtteranceTooLong")]
            Utterancetoolong
        }
        /// <summary>
        /// Status of health computation for this intent.
        /// </summary>
        /// <value>Status of health computation for this intent.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthInfo" /> class.
        /// </summary>
        /// <param name="Status">Status of health computation for this intent..</param>
        /// <param name="ErrorInfo">Error details for the intent, if any..</param>
        /// <param name="OverallScore">Overall health score for the intent ranged between 0 and 100 as 100 is the perfect health score..</param>
        /// <param name="IssueCount">Number of issues found in the intent..</param>
        /// <param name="StaticValidationResults">Validation results for the intent..</param>
        /// <param name="Utterances">Utterances for this intent..</param>
        public HealthInfo(StatusEnum? Status = null, FlowHealthErrorInfo ErrorInfo = null, float? OverallScore = null, long? IssueCount = null, List<StaticValidationResultsEnum> StaticValidationResults = null, List<FlowHealthIntentUtterance> Utterances = null)
        {
            this.Status = Status;
            this.ErrorInfo = ErrorInfo;
            this.OverallScore = OverallScore;
            this.IssueCount = IssueCount;
            this.StaticValidationResults = StaticValidationResults;
            this.Utterances = Utterances;
            
        }
        




        /// <summary>
        /// Error details for the intent, if any.
        /// </summary>
        /// <value>Error details for the intent, if any.</value>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public FlowHealthErrorInfo ErrorInfo { get; set; }



        /// <summary>
        /// Overall health score for the intent ranged between 0 and 100 as 100 is the perfect health score.
        /// </summary>
        /// <value>Overall health score for the intent ranged between 0 and 100 as 100 is the perfect health score.</value>
        [DataMember(Name="overallScore", EmitDefaultValue=false)]
        public float? OverallScore { get; set; }



        /// <summary>
        /// Number of issues found in the intent.
        /// </summary>
        /// <value>Number of issues found in the intent.</value>
        [DataMember(Name="issueCount", EmitDefaultValue=false)]
        public long? IssueCount { get; set; }



        /// <summary>
        /// Validation results for the intent.
        /// </summary>
        /// <value>Validation results for the intent.</value>
        [DataMember(Name="staticValidationResults", EmitDefaultValue=false)]
        public List<StaticValidationResultsEnum> StaticValidationResults { get; set; }



        /// <summary>
        /// Utterances for this intent.
        /// </summary>
        /// <value>Utterances for this intent.</value>
        [DataMember(Name="utterances", EmitDefaultValue=false)]
        public List<FlowHealthIntentUtterance> Utterances { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HealthInfo {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  OverallScore: ").Append(OverallScore).Append("\n");
            sb.Append("  IssueCount: ").Append(IssueCount).Append("\n");
            sb.Append("  StaticValidationResults: ").Append(StaticValidationResults).Append("\n");
            sb.Append("  Utterances: ").Append(Utterances).Append("\n");
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
            return this.Equals(obj as HealthInfo);
        }

        /// <summary>
        /// Returns true if HealthInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of HealthInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
                ) &&
                (
                    this.OverallScore == other.OverallScore ||
                    this.OverallScore != null &&
                    this.OverallScore.Equals(other.OverallScore)
                ) &&
                (
                    this.IssueCount == other.IssueCount ||
                    this.IssueCount != null &&
                    this.IssueCount.Equals(other.IssueCount)
                ) &&
                (
                    this.StaticValidationResults == other.StaticValidationResults ||
                    this.StaticValidationResults != null &&
                    this.StaticValidationResults.SequenceEqual(other.StaticValidationResults)
                ) &&
                (
                    this.Utterances == other.Utterances ||
                    this.Utterances != null &&
                    this.Utterances.SequenceEqual(other.Utterances)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();

                if (this.OverallScore != null)
                    hash = hash * 59 + this.OverallScore.GetHashCode();

                if (this.IssueCount != null)
                    hash = hash * 59 + this.IssueCount.GetHashCode();

                if (this.StaticValidationResults != null)
                    hash = hash * 59 + this.StaticValidationResults.GetHashCode();

                if (this.Utterances != null)
                    hash = hash * 59 + this.Utterances.GetHashCode();

                return hash;
            }
        }
    }

}
