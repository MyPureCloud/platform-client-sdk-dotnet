using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuShortTermForecast
	/// </summary>
	[DataContract]
	public partial class BuShortTermForecast : IEquatable<BuShortTermForecast>
	{
		/// <summary>
		/// The method by which this forecast was created
		/// </summary>
		/// <value>The method by which this forecast was created</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum CreationMethodEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Import for "Import"
			/// </summary>
			[EnumMember(Value = "Import")]
			Import,

			/// <summary>
			/// Enum Importedhistoricalweightedaverage for "ImportedHistoricalWeightedAverage"
			/// </summary>
			[EnumMember(Value = "ImportedHistoricalWeightedAverage")]
			Importedhistoricalweightedaverage,

			/// <summary>
			/// Enum Historicalweightedaverage for "HistoricalWeightedAverage"
			/// </summary>
			[EnumMember(Value = "HistoricalWeightedAverage")]
			Historicalweightedaverage,

			/// <summary>
			/// Enum Advanced for "Advanced"
			/// </summary>
			[EnumMember(Value = "Advanced")]
			Advanced
		}
		/// <summary>
		/// The method by which this forecast was created
		/// </summary>
		/// <value>The method by which this forecast was created</value>
		[DataMember(Name = "creationMethod", EmitDefaultValue = false)]
		public CreationMethodEnum? CreationMethod { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="BuShortTermForecast" /> class.
		/// </summary>
		/// <param name="WeekDate">The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="WeekCount">The number of weeks this forecast covers.</param>
		/// <param name="CreationMethod">The method by which this forecast was created.</param>
		/// <param name="Description">The description of this forecast.</param>
		/// <param name="Metadata">Metadata for this forecast.</param>
		/// <param name="CanUseForScheduling">Whether this forecast can be used for scheduling.</param>
		/// <param name="ReferenceStartDate">The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="SourceDays">The source day pointers for this forecast.</param>
		/// <param name="Modifications">Any manual modifications applied to this forecast.</param>
		/// <param name="GenerationResults">Generation result metadata.</param>
		/// <param name="TimeZone">The time zone for this forecast.</param>
		/// <param name="PlanningGroupsVersion">The version of the planning groups that was used for this forecast.</param>
		/// <param name="PlanningGroups">A snapshot of the planning groups used for this forecast as of the version number indicated.</param>
		public BuShortTermForecast(String WeekDate = null, int? WeekCount = null, CreationMethodEnum? CreationMethod = null, string Description = null, WfmVersionedEntityMetadata Metadata = null, bool? CanUseForScheduling = null, DateTime? ReferenceStartDate = null, List<ForecastSourceDayPointer> SourceDays = null, List<BuForecastModificationResponse> Modifications = null, BuForecastGenerationResult GenerationResults = null, string TimeZone = null, int? PlanningGroupsVersion = null, ForecastPlanningGroupsResponse PlanningGroups = null)
		{
			this.WeekDate = WeekDate;
			this.WeekCount = WeekCount;
			this.CreationMethod = CreationMethod;
			this.Description = Description;
			this.Metadata = Metadata;
			this.CanUseForScheduling = CanUseForScheduling;
			this.ReferenceStartDate = ReferenceStartDate;
			this.SourceDays = SourceDays;
			this.Modifications = Modifications;
			this.GenerationResults = GenerationResults;
			this.TimeZone = TimeZone;
			this.PlanningGroupsVersion = PlanningGroupsVersion;
			this.PlanningGroups = PlanningGroups;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "weekDate", EmitDefaultValue = false)]
		public String WeekDate { get; set; }



		/// <summary>
		/// The number of weeks this forecast covers
		/// </summary>
		/// <value>The number of weeks this forecast covers</value>
		[DataMember(Name = "weekCount", EmitDefaultValue = false)]
		public int? WeekCount { get; set; }





		/// <summary>
		/// The description of this forecast
		/// </summary>
		/// <value>The description of this forecast</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Whether this forecast contains modifications on legacy metrics
		/// </summary>
		/// <value>Whether this forecast contains modifications on legacy metrics</value>
		[DataMember(Name = "legacy", EmitDefaultValue = false)]
		public bool? Legacy { get; private set; }



		/// <summary>
		/// Metadata for this forecast
		/// </summary>
		/// <value>Metadata for this forecast</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public WfmVersionedEntityMetadata Metadata { get; set; }



		/// <summary>
		/// Whether this forecast can be used for scheduling
		/// </summary>
		/// <value>Whether this forecast can be used for scheduling</value>
		[DataMember(Name = "canUseForScheduling", EmitDefaultValue = false)]
		public bool? CanUseForScheduling { get; set; }



		/// <summary>
		/// The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "referenceStartDate", EmitDefaultValue = false)]
		public DateTime? ReferenceStartDate { get; set; }



		/// <summary>
		/// The source day pointers for this forecast
		/// </summary>
		/// <value>The source day pointers for this forecast</value>
		[DataMember(Name = "sourceDays", EmitDefaultValue = false)]
		public List<ForecastSourceDayPointer> SourceDays { get; set; }



		/// <summary>
		/// Any manual modifications applied to this forecast
		/// </summary>
		/// <value>Any manual modifications applied to this forecast</value>
		[DataMember(Name = "modifications", EmitDefaultValue = false)]
		public List<BuForecastModificationResponse> Modifications { get; set; }



		/// <summary>
		/// Generation result metadata
		/// </summary>
		/// <value>Generation result metadata</value>
		[DataMember(Name = "generationResults", EmitDefaultValue = false)]
		public BuForecastGenerationResult GenerationResults { get; set; }



		/// <summary>
		/// The time zone for this forecast
		/// </summary>
		/// <value>The time zone for this forecast</value>
		[DataMember(Name = "timeZone", EmitDefaultValue = false)]
		public string TimeZone { get; set; }



		/// <summary>
		/// The version of the planning groups that was used for this forecast
		/// </summary>
		/// <value>The version of the planning groups that was used for this forecast</value>
		[DataMember(Name = "planningGroupsVersion", EmitDefaultValue = false)]
		public int? PlanningGroupsVersion { get; set; }



		/// <summary>
		/// A snapshot of the planning groups used for this forecast as of the version number indicated
		/// </summary>
		/// <value>A snapshot of the planning groups used for this forecast as of the version number indicated</value>
		[DataMember(Name = "planningGroups", EmitDefaultValue = false)]
		public ForecastPlanningGroupsResponse PlanningGroups { get; set; }



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
			sb.Append("class BuShortTermForecast {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
			sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
			sb.Append("  CreationMethod: ").Append(CreationMethod).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Legacy: ").Append(Legacy).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
			sb.Append("  CanUseForScheduling: ").Append(CanUseForScheduling).Append("\n");
			sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
			sb.Append("  SourceDays: ").Append(SourceDays).Append("\n");
			sb.Append("  Modifications: ").Append(Modifications).Append("\n");
			sb.Append("  GenerationResults: ").Append(GenerationResults).Append("\n");
			sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
			sb.Append("  PlanningGroupsVersion: ").Append(PlanningGroupsVersion).Append("\n");
			sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
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
			return this.Equals(obj as BuShortTermForecast);
		}

		/// <summary>
		/// Returns true if BuShortTermForecast instances are equal
		/// </summary>
		/// <param name="other">Instance of BuShortTermForecast to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuShortTermForecast other)
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
					this.WeekDate == other.WeekDate ||
					this.WeekDate != null &&
					this.WeekDate.Equals(other.WeekDate)
				) &&
				(
					this.WeekCount == other.WeekCount ||
					this.WeekCount != null &&
					this.WeekCount.Equals(other.WeekCount)
				) &&
				(
					this.CreationMethod == other.CreationMethod ||
					this.CreationMethod != null &&
					this.CreationMethod.Equals(other.CreationMethod)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Legacy == other.Legacy ||
					this.Legacy != null &&
					this.Legacy.Equals(other.Legacy)
				) &&
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.Equals(other.Metadata)
				) &&
				(
					this.CanUseForScheduling == other.CanUseForScheduling ||
					this.CanUseForScheduling != null &&
					this.CanUseForScheduling.Equals(other.CanUseForScheduling)
				) &&
				(
					this.ReferenceStartDate == other.ReferenceStartDate ||
					this.ReferenceStartDate != null &&
					this.ReferenceStartDate.Equals(other.ReferenceStartDate)
				) &&
				(
					this.SourceDays == other.SourceDays ||
					this.SourceDays != null &&
					this.SourceDays.SequenceEqual(other.SourceDays)
				) &&
				(
					this.Modifications == other.Modifications ||
					this.Modifications != null &&
					this.Modifications.SequenceEqual(other.Modifications)
				) &&
				(
					this.GenerationResults == other.GenerationResults ||
					this.GenerationResults != null &&
					this.GenerationResults.Equals(other.GenerationResults)
				) &&
				(
					this.TimeZone == other.TimeZone ||
					this.TimeZone != null &&
					this.TimeZone.Equals(other.TimeZone)
				) &&
				(
					this.PlanningGroupsVersion == other.PlanningGroupsVersion ||
					this.PlanningGroupsVersion != null &&
					this.PlanningGroupsVersion.Equals(other.PlanningGroupsVersion)
				) &&
				(
					this.PlanningGroups == other.PlanningGroups ||
					this.PlanningGroups != null &&
					this.PlanningGroups.Equals(other.PlanningGroups)
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

				if (this.WeekDate != null)
					hash = hash * 59 + this.WeekDate.GetHashCode();

				if (this.WeekCount != null)
					hash = hash * 59 + this.WeekCount.GetHashCode();

				if (this.CreationMethod != null)
					hash = hash * 59 + this.CreationMethod.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Legacy != null)
					hash = hash * 59 + this.Legacy.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.CanUseForScheduling != null)
					hash = hash * 59 + this.CanUseForScheduling.GetHashCode();

				if (this.ReferenceStartDate != null)
					hash = hash * 59 + this.ReferenceStartDate.GetHashCode();

				if (this.SourceDays != null)
					hash = hash * 59 + this.SourceDays.GetHashCode();

				if (this.Modifications != null)
					hash = hash * 59 + this.Modifications.GetHashCode();

				if (this.GenerationResults != null)
					hash = hash * 59 + this.GenerationResults.GetHashCode();

				if (this.TimeZone != null)
					hash = hash * 59 + this.TimeZone.GetHashCode();

				if (this.PlanningGroupsVersion != null)
					hash = hash * 59 + this.PlanningGroupsVersion.GetHashCode();

				if (this.PlanningGroups != null)
					hash = hash * 59 + this.PlanningGroups.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
