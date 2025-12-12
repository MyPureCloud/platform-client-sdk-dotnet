using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast
	/// </summary>
	[DataContract]
	public partial class WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast : IEquatable<WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast>
	{
		/// <summary>
		/// Gets or Sets CreationMethod
		/// </summary>
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
		/// Gets or Sets CreationMethod
		/// </summary>
		[DataMember(Name = "creationMethod", EmitDefaultValue = false)]
		public CreationMethodEnum? CreationMethod { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="WeekDate">WeekDate.</param>
		/// <param name="CreationMethod">CreationMethod.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Legacy">Legacy.</param>
		/// <param name="ReferenceStartDate">ReferenceStartDate.</param>
		/// <param name="SourceDays">SourceDays.</param>
		/// <param name="Modifications">Modifications.</param>
		/// <param name="TimeZone">TimeZone.</param>
		/// <param name="PlanningGroupsVersion">PlanningGroupsVersion.</param>
		/// <param name="WeekCount">WeekCount.</param>
		/// <param name="Metadata">Metadata.</param>
		/// <param name="CanUseForScheduling">CanUseForScheduling.</param>
		public WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast(string Id = null, string WeekDate = null, CreationMethodEnum? CreationMethod = null, string Description = null, bool? Legacy = null, DateTime? ReferenceStartDate = null, List<WfmBuShortTermForecastImportCompleteTopicForecastSourceDayPointer> SourceDays = null, List<WfmBuShortTermForecastImportCompleteTopicBuForecastModification> Modifications = null, string TimeZone = null, long? PlanningGroupsVersion = null, long? WeekCount = null, WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata Metadata = null, bool? CanUseForScheduling = null)
		{
			this.Id = Id;
			this.WeekDate = WeekDate;
			this.CreationMethod = CreationMethod;
			this.Description = Description;
			this.Legacy = Legacy;
			this.ReferenceStartDate = ReferenceStartDate;
			this.SourceDays = SourceDays;
			this.Modifications = Modifications;
			this.TimeZone = TimeZone;
			this.PlanningGroupsVersion = PlanningGroupsVersion;
			this.WeekCount = WeekCount;
			this.Metadata = Metadata;
			this.CanUseForScheduling = CanUseForScheduling;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets WeekDate
		/// </summary>
		[DataMember(Name = "weekDate", EmitDefaultValue = false)]
		public string WeekDate { get; set; }





		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Gets or Sets Legacy
		/// </summary>
		[DataMember(Name = "legacy", EmitDefaultValue = false)]
		public bool? Legacy { get; set; }



		/// <summary>
		/// Gets or Sets ReferenceStartDate
		/// </summary>
		[DataMember(Name = "referenceStartDate", EmitDefaultValue = false)]
		public DateTime? ReferenceStartDate { get; set; }



		/// <summary>
		/// Gets or Sets SourceDays
		/// </summary>
		[DataMember(Name = "sourceDays", EmitDefaultValue = false)]
		public List<WfmBuShortTermForecastImportCompleteTopicForecastSourceDayPointer> SourceDays { get; set; }



		/// <summary>
		/// Gets or Sets Modifications
		/// </summary>
		[DataMember(Name = "modifications", EmitDefaultValue = false)]
		public List<WfmBuShortTermForecastImportCompleteTopicBuForecastModification> Modifications { get; set; }



		/// <summary>
		/// Gets or Sets TimeZone
		/// </summary>
		[DataMember(Name = "timeZone", EmitDefaultValue = false)]
		public string TimeZone { get; set; }



		/// <summary>
		/// Gets or Sets PlanningGroupsVersion
		/// </summary>
		[DataMember(Name = "planningGroupsVersion", EmitDefaultValue = false)]
		public long? PlanningGroupsVersion { get; set; }



		/// <summary>
		/// Gets or Sets WeekCount
		/// </summary>
		[DataMember(Name = "weekCount", EmitDefaultValue = false)]
		public long? WeekCount { get; set; }



		/// <summary>
		/// Gets or Sets Metadata
		/// </summary>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata Metadata { get; set; }



		/// <summary>
		/// Gets or Sets CanUseForScheduling
		/// </summary>
		[DataMember(Name = "canUseForScheduling", EmitDefaultValue = false)]
		public bool? CanUseForScheduling { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
			sb.Append("  CreationMethod: ").Append(CreationMethod).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Legacy: ").Append(Legacy).Append("\n");
			sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
			sb.Append("  SourceDays: ").Append(SourceDays).Append("\n");
			sb.Append("  Modifications: ").Append(Modifications).Append("\n");
			sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
			sb.Append("  PlanningGroupsVersion: ").Append(PlanningGroupsVersion).Append("\n");
			sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
			sb.Append("  CanUseForScheduling: ").Append(CanUseForScheduling).Append("\n");
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
			return this.Equals(obj as WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast);
		}

		/// <summary>
		/// Returns true if WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmBuShortTermForecastImportCompleteTopicBuShortTermForecast other)
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
					this.WeekCount == other.WeekCount ||
					this.WeekCount != null &&
					this.WeekCount.Equals(other.WeekCount)
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

				if (this.CreationMethod != null)
					hash = hash * 59 + this.CreationMethod.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Legacy != null)
					hash = hash * 59 + this.Legacy.GetHashCode();

				if (this.ReferenceStartDate != null)
					hash = hash * 59 + this.ReferenceStartDate.GetHashCode();

				if (this.SourceDays != null)
					hash = hash * 59 + this.SourceDays.GetHashCode();

				if (this.Modifications != null)
					hash = hash * 59 + this.Modifications.GetHashCode();

				if (this.TimeZone != null)
					hash = hash * 59 + this.TimeZone.GetHashCode();

				if (this.PlanningGroupsVersion != null)
					hash = hash * 59 + this.PlanningGroupsVersion.GetHashCode();

				if (this.WeekCount != null)
					hash = hash * 59 + this.WeekCount.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.CanUseForScheduling != null)
					hash = hash * 59 + this.CanUseForScheduling.GetHashCode();

				return hash;
			}
		}
	}

}
