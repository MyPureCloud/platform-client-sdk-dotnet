using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SurveyAggregationSort
	/// </summary>
	[DataContract]
	public partial class SurveyAggregationSort : IEquatable<SurveyAggregationSort>
	{
		/// <summary>
		/// Name of the metric used for sorting values.
		/// </summary>
		/// <value>Name of the metric used for sorting values.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum NameEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Nsurveyerrors for "nSurveyErrors"
			/// </summary>
			[EnumMember(Value = "nSurveyErrors")]
			Nsurveyerrors,

			/// <summary>
			/// Enum Nsurveyfullresponses for "nSurveyFullResponses"
			/// </summary>
			[EnumMember(Value = "nSurveyFullResponses")]
			Nsurveyfullresponses,

			/// <summary>
			/// Enum Nsurveynpsdetractors for "nSurveyNpsDetractors"
			/// </summary>
			[EnumMember(Value = "nSurveyNpsDetractors")]
			Nsurveynpsdetractors,

			/// <summary>
			/// Enum Nsurveynpspromoters for "nSurveyNpsPromoters"
			/// </summary>
			[EnumMember(Value = "nSurveyNpsPromoters")]
			Nsurveynpspromoters,

			/// <summary>
			/// Enum Nsurveynpsresponses for "nSurveyNpsResponses"
			/// </summary>
			[EnumMember(Value = "nSurveyNpsResponses")]
			Nsurveynpsresponses,

			/// <summary>
			/// Enum Nsurveypartialresponses for "nSurveyPartialResponses"
			/// </summary>
			[EnumMember(Value = "nSurveyPartialResponses")]
			Nsurveypartialresponses,

			/// <summary>
			/// Enum Nsurveyquestiongroupresponses for "nSurveyQuestionGroupResponses"
			/// </summary>
			[EnumMember(Value = "nSurveyQuestionGroupResponses")]
			Nsurveyquestiongroupresponses,

			/// <summary>
			/// Enum Nsurveyquestionresponses for "nSurveyQuestionResponses"
			/// </summary>
			[EnumMember(Value = "nSurveyQuestionResponses")]
			Nsurveyquestionresponses,

			/// <summary>
			/// Enum Nsurveyresponses for "nSurveyResponses"
			/// </summary>
			[EnumMember(Value = "nSurveyResponses")]
			Nsurveyresponses,

			/// <summary>
			/// Enum Nsurveysabandoned for "nSurveysAbandoned"
			/// </summary>
			[EnumMember(Value = "nSurveysAbandoned")]
			Nsurveysabandoned,

			/// <summary>
			/// Enum Nsurveysdeleted for "nSurveysDeleted"
			/// </summary>
			[EnumMember(Value = "nSurveysDeleted")]
			Nsurveysdeleted,

			/// <summary>
			/// Enum Nsurveysexpired for "nSurveysExpired"
			/// </summary>
			[EnumMember(Value = "nSurveysExpired")]
			Nsurveysexpired,

			/// <summary>
			/// Enum Nsurveyssent for "nSurveysSent"
			/// </summary>
			[EnumMember(Value = "nSurveysSent")]
			Nsurveyssent,

			/// <summary>
			/// Enum Nsurveysstarted for "nSurveysStarted"
			/// </summary>
			[EnumMember(Value = "nSurveysStarted")]
			Nsurveysstarted,

			/// <summary>
			/// Enum Nvoicesurveys for "nVoiceSurveys"
			/// </summary>
			[EnumMember(Value = "nVoiceSurveys")]
			Nvoicesurveys,

			/// <summary>
			/// Enum Nwebsurveys for "nWebSurveys"
			/// </summary>
			[EnumMember(Value = "nWebSurveys")]
			Nwebsurveys,

			/// <summary>
			/// Enum Osurveyquestiongroupscore for "oSurveyQuestionGroupScore"
			/// </summary>
			[EnumMember(Value = "oSurveyQuestionGroupScore")]
			Osurveyquestiongroupscore,

			/// <summary>
			/// Enum Osurveyquestionscore for "oSurveyQuestionScore"
			/// </summary>
			[EnumMember(Value = "oSurveyQuestionScore")]
			Osurveyquestionscore,

			/// <summary>
			/// Enum Osurveytotalscore for "oSurveyTotalScore"
			/// </summary>
			[EnumMember(Value = "oSurveyTotalScore")]
			Osurveytotalscore
		}
		/// <summary>
		/// Aggregation function used for the sort metric.
		/// </summary>
		/// <value>Aggregation function used for the sort metric.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum FunctionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Average for "average"
			/// </summary>
			[EnumMember(Value = "average")]
			Average,

			/// <summary>
			/// Enum Count for "count"
			/// </summary>
			[EnumMember(Value = "count")]
			Count,

			/// <summary>
			/// Enum Max for "max"
			/// </summary>
			[EnumMember(Value = "max")]
			Max,

			/// <summary>
			/// Enum Min for "min"
			/// </summary>
			[EnumMember(Value = "min")]
			Min,

			/// <summary>
			/// Enum Sum for "sum"
			/// </summary>
			[EnumMember(Value = "sum")]
			Sum
		}
		/// <summary>
		/// Name of the metric used for sorting values.
		/// </summary>
		/// <value>Name of the metric used for sorting values.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public NameEnum? Name { get; set; }
		/// <summary>
		/// Aggregation function used for the sort metric.
		/// </summary>
		/// <value>Aggregation function used for the sort metric.</value>
		[DataMember(Name = "function", EmitDefaultValue = false)]
		public FunctionEnum? Function { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="SurveyAggregationSort" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SurveyAggregationSort() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SurveyAggregationSort" /> class.
		/// </summary>
		/// <param name="Name">Name of the metric used for sorting values. (required).</param>
		/// <param name="Function">Aggregation function used for the sort metric. (required).</param>
		public SurveyAggregationSort(NameEnum? Name = null, FunctionEnum? Function = null)
		{
			this.Name = Name;
			this.Function = Function;

		}






		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SurveyAggregationSort {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Function: ").Append(Function).Append("\n");
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
			return this.Equals(obj as SurveyAggregationSort);
		}

		/// <summary>
		/// Returns true if SurveyAggregationSort instances are equal
		/// </summary>
		/// <param name="other">Instance of SurveyAggregationSort to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SurveyAggregationSort other)
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
					this.Function == other.Function ||
					this.Function != null &&
					this.Function.Equals(other.Function)
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

				if (this.Function != null)
					hash = hash * 59 + this.Function.GetHashCode();

				return hash;
			}
		}
	}

}
