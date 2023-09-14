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
    /// FlowHealthIntentUtterance
    /// </summary>
    [DataContract]
    public partial class FlowHealthIntentUtterance :  IEquatable<FlowHealthIntentUtterance>
    {
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
        /// Initializes a new instance of the <see cref="FlowHealthIntentUtterance" /> class.
        /// </summary>
        /// <param name="Text">Utterance Text..</param>
        /// <param name="IssueCount">Number of issues found for this utterance..</param>
        /// <param name="StaticValidationResults">Validation results for this utterance..</param>
        /// <param name="OutlierInfo">Details about this utterance being an outlier or not..</param>
        /// <param name="ConfusionInfo">Confusion details with other utterances..</param>
        public FlowHealthIntentUtterance(string Text = null, long? IssueCount = null, List<StaticValidationResultsEnum> StaticValidationResults = null, OutlierInfo OutlierInfo = null, ConfusionInfo ConfusionInfo = null)
        {
            this.Text = Text;
            this.IssueCount = IssueCount;
            this.StaticValidationResults = StaticValidationResults;
            this.OutlierInfo = OutlierInfo;
            this.ConfusionInfo = ConfusionInfo;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Utterance Text.
        /// </summary>
        /// <value>Utterance Text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Number of issues found for this utterance.
        /// </summary>
        /// <value>Number of issues found for this utterance.</value>
        [DataMember(Name="issueCount", EmitDefaultValue=false)]
        public long? IssueCount { get; set; }



        /// <summary>
        /// Validation results for this utterance.
        /// </summary>
        /// <value>Validation results for this utterance.</value>
        [DataMember(Name="staticValidationResults", EmitDefaultValue=false)]
        public List<StaticValidationResultsEnum> StaticValidationResults { get; set; }



        /// <summary>
        /// Details about this utterance being an outlier or not.
        /// </summary>
        /// <value>Details about this utterance being an outlier or not.</value>
        [DataMember(Name="outlierInfo", EmitDefaultValue=false)]
        public OutlierInfo OutlierInfo { get; set; }



        /// <summary>
        /// Confusion details with other utterances.
        /// </summary>
        /// <value>Confusion details with other utterances.</value>
        [DataMember(Name="confusionInfo", EmitDefaultValue=false)]
        public ConfusionInfo ConfusionInfo { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowHealthIntentUtterance {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  IssueCount: ").Append(IssueCount).Append("\n");
            sb.Append("  StaticValidationResults: ").Append(StaticValidationResults).Append("\n");
            sb.Append("  OutlierInfo: ").Append(OutlierInfo).Append("\n");
            sb.Append("  ConfusionInfo: ").Append(ConfusionInfo).Append("\n");
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
            return this.Equals(obj as FlowHealthIntentUtterance);
        }

        /// <summary>
        /// Returns true if FlowHealthIntentUtterance instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowHealthIntentUtterance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowHealthIntentUtterance other)
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
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                    this.OutlierInfo == other.OutlierInfo ||
                    this.OutlierInfo != null &&
                    this.OutlierInfo.Equals(other.OutlierInfo)
                ) &&
                (
                    this.ConfusionInfo == other.ConfusionInfo ||
                    this.ConfusionInfo != null &&
                    this.ConfusionInfo.Equals(other.ConfusionInfo)
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

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.IssueCount != null)
                    hash = hash * 59 + this.IssueCount.GetHashCode();

                if (this.StaticValidationResults != null)
                    hash = hash * 59 + this.StaticValidationResults.GetHashCode();

                if (this.OutlierInfo != null)
                    hash = hash * 59 + this.OutlierInfo.GetHashCode();

                if (this.ConfusionInfo != null)
                    hash = hash * 59 + this.ConfusionInfo.GetHashCode();

                return hash;
            }
        }
    }

}
