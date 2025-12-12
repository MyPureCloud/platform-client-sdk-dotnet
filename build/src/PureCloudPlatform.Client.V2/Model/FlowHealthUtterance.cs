using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FlowHealthUtterance
	/// </summary>
	[DataContract]
	public partial class FlowHealthUtterance : IEquatable<FlowHealthUtterance>
	{
		/// <summary>
		/// Language provided for this utterance's health.
		/// </summary>
		/// <value>Language provided for this utterance's health.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum LanguageEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Enus for "en-us"
			/// </summary>
			[EnumMember(Value = "en-us")]
			Enus,

			/// <summary>
			/// Enum Engb for "en-gb"
			/// </summary>
			[EnumMember(Value = "en-gb")]
			Engb,

			/// <summary>
			/// Enum Enau for "en-au"
			/// </summary>
			[EnumMember(Value = "en-au")]
			Enau,

			/// <summary>
			/// Enum Enza for "en-za"
			/// </summary>
			[EnumMember(Value = "en-za")]
			Enza,

			/// <summary>
			/// Enum Ennz for "en-nz"
			/// </summary>
			[EnumMember(Value = "en-nz")]
			Ennz,

			/// <summary>
			/// Enum Enie for "en-ie"
			/// </summary>
			[EnumMember(Value = "en-ie")]
			Enie,

			/// <summary>
			/// Enum Frca for "fr-ca"
			/// </summary>
			[EnumMember(Value = "fr-ca")]
			Frca,

			/// <summary>
			/// Enum Frfr for "fr-fr"
			/// </summary>
			[EnumMember(Value = "fr-fr")]
			Frfr,

			/// <summary>
			/// Enum Esus for "es-us"
			/// </summary>
			[EnumMember(Value = "es-us")]
			Esus,

			/// <summary>
			/// Enum Eses for "es-es"
			/// </summary>
			[EnumMember(Value = "es-es")]
			Eses,

			/// <summary>
			/// Enum Esmx for "es-mx"
			/// </summary>
			[EnumMember(Value = "es-mx")]
			Esmx,

			/// <summary>
			/// Enum Dede for "de-de"
			/// </summary>
			[EnumMember(Value = "de-de")]
			Dede,

			/// <summary>
			/// Enum Itit for "it-it"
			/// </summary>
			[EnumMember(Value = "it-it")]
			Itit,

			/// <summary>
			/// Enum Ptbr for "pt-br"
			/// </summary>
			[EnumMember(Value = "pt-br")]
			Ptbr,

			/// <summary>
			/// Enum Ptpt for "pt-pt"
			/// </summary>
			[EnumMember(Value = "pt-pt")]
			Ptpt,

			/// <summary>
			/// Enum Nlnl for "nl-nl"
			/// </summary>
			[EnumMember(Value = "nl-nl")]
			Nlnl
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
		/// Language provided for this utterance's health.
		/// </summary>
		/// <value>Language provided for this utterance's health.</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public LanguageEnum? Language { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="FlowHealthUtterance" /> class.
		/// </summary>
		/// <param name="Text">Utterance Text..</param>
		/// <param name="IssueCount">Number of issues found for this utterance..</param>
		/// <param name="Language">Language provided for this utterance&#39;s health..</param>
		/// <param name="StaticValidationResults">Validation results for the utterance..</param>
		/// <param name="OutlierInfo">Details about this utterance being an outlier or not..</param>
		/// <param name="ConfusionInfo">Confusion details with other utterances..</param>
		public FlowHealthUtterance(string Text = null, long? IssueCount = null, LanguageEnum? Language = null, List<StaticValidationResultsEnum> StaticValidationResults = null, OutlierInfo OutlierInfo = null, ConfusionDetails ConfusionInfo = null)
		{
			this.Text = Text;
			this.IssueCount = IssueCount;
			this.Language = Language;
			this.StaticValidationResults = StaticValidationResults;
			this.OutlierInfo = OutlierInfo;
			this.ConfusionInfo = ConfusionInfo;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Utterance Text.
		/// </summary>
		/// <value>Utterance Text.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }



		/// <summary>
		/// Number of issues found for this utterance.
		/// </summary>
		/// <value>Number of issues found for this utterance.</value>
		[DataMember(Name = "issueCount", EmitDefaultValue = false)]
		public long? IssueCount { get; set; }





		/// <summary>
		/// Validation results for the utterance.
		/// </summary>
		/// <value>Validation results for the utterance.</value>
		[DataMember(Name = "staticValidationResults", EmitDefaultValue = false)]
		public List<StaticValidationResultsEnum> StaticValidationResults { get; set; }



		/// <summary>
		/// Details about this utterance being an outlier or not.
		/// </summary>
		/// <value>Details about this utterance being an outlier or not.</value>
		[DataMember(Name = "outlierInfo", EmitDefaultValue = false)]
		public OutlierInfo OutlierInfo { get; set; }



		/// <summary>
		/// Confusion details with other utterances.
		/// </summary>
		/// <value>Confusion details with other utterances.</value>
		[DataMember(Name = "confusionInfo", EmitDefaultValue = false)]
		public ConfusionDetails ConfusionInfo { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FlowHealthUtterance {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  IssueCount: ").Append(IssueCount).Append("\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  StaticValidationResults: ").Append(StaticValidationResults).Append("\n");
			sb.Append("  OutlierInfo: ").Append(OutlierInfo).Append("\n");
			sb.Append("  ConfusionInfo: ").Append(ConfusionInfo).Append("\n");
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
			return this.Equals(obj as FlowHealthUtterance);
		}

		/// <summary>
		/// Returns true if FlowHealthUtterance instances are equal
		/// </summary>
		/// <param name="other">Instance of FlowHealthUtterance to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FlowHealthUtterance other)
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
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
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

				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.IssueCount != null)
					hash = hash * 59 + this.IssueCount.GetHashCode();

				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				if (this.StaticValidationResults != null)
					hash = hash * 59 + this.StaticValidationResults.GetHashCode();

				if (this.OutlierInfo != null)
					hash = hash * 59 + this.OutlierInfo.GetHashCode();

				if (this.ConfusionInfo != null)
					hash = hash * 59 + this.ConfusionInfo.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
