using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuScheduleListItem
	/// </summary>
	[DataContract]
	public partial class BuScheduleListItem : IEquatable<BuScheduleListItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BuScheduleListItem" /> class.
		/// </summary>
		/// <param name="Id">The ID of the schedule.</param>
		/// <param name="WeekDate">The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="WeekCount">The number of weeks spanned by this schedule.</param>
		/// <param name="Description">The description of this schedule.</param>
		/// <param name="Published">Whether this schedule is published.</param>
		/// <param name="ShortTermForecast">The forecast used for this schedule, if applicable.</param>
		/// <param name="GenerationResults">Generation result summary for this schedule, if applicable.</param>
		/// <param name="Metadata">Version metadata for this schedule.</param>
		public BuScheduleListItem(string Id = null, String WeekDate = null, int? WeekCount = null, string Description = null, bool? Published = null, BuShortTermForecastReference ShortTermForecast = null, ScheduleGenerationResultSummary GenerationResults = null, WfmVersionedEntityMetadata Metadata = null)
		{
			this.Id = Id;
			this.WeekDate = WeekDate;
			this.WeekCount = WeekCount;
			this.Description = Description;
			this.Published = Published;
			this.ShortTermForecast = ShortTermForecast;
			this.GenerationResults = GenerationResults;
			this.Metadata = Metadata;

		}



		/// <summary>
		/// The ID of the schedule
		/// </summary>
		/// <value>The ID of the schedule</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "weekDate", EmitDefaultValue = false)]
		public String WeekDate { get; set; }



		/// <summary>
		/// The number of weeks spanned by this schedule
		/// </summary>
		/// <value>The number of weeks spanned by this schedule</value>
		[DataMember(Name = "weekCount", EmitDefaultValue = false)]
		public int? WeekCount { get; set; }



		/// <summary>
		/// The description of this schedule
		/// </summary>
		/// <value>The description of this schedule</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Whether this schedule is published
		/// </summary>
		/// <value>Whether this schedule is published</value>
		[DataMember(Name = "published", EmitDefaultValue = false)]
		public bool? Published { get; set; }



		/// <summary>
		/// The forecast used for this schedule, if applicable
		/// </summary>
		/// <value>The forecast used for this schedule, if applicable</value>
		[DataMember(Name = "shortTermForecast", EmitDefaultValue = false)]
		public BuShortTermForecastReference ShortTermForecast { get; set; }



		/// <summary>
		/// Generation result summary for this schedule, if applicable
		/// </summary>
		/// <value>Generation result summary for this schedule, if applicable</value>
		[DataMember(Name = "generationResults", EmitDefaultValue = false)]
		public ScheduleGenerationResultSummary GenerationResults { get; set; }



		/// <summary>
		/// Version metadata for this schedule
		/// </summary>
		/// <value>Version metadata for this schedule</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public WfmVersionedEntityMetadata Metadata { get; set; }



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
			sb.Append("class BuScheduleListItem {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
			sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Published: ").Append(Published).Append("\n");
			sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
			sb.Append("  GenerationResults: ").Append(GenerationResults).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
			return this.Equals(obj as BuScheduleListItem);
		}

		/// <summary>
		/// Returns true if BuScheduleListItem instances are equal
		/// </summary>
		/// <param name="other">Instance of BuScheduleListItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuScheduleListItem other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Published == other.Published ||
					this.Published != null &&
					this.Published.Equals(other.Published)
				) &&
				(
					this.ShortTermForecast == other.ShortTermForecast ||
					this.ShortTermForecast != null &&
					this.ShortTermForecast.Equals(other.ShortTermForecast)
				) &&
				(
					this.GenerationResults == other.GenerationResults ||
					this.GenerationResults != null &&
					this.GenerationResults.Equals(other.GenerationResults)
				) &&
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.Equals(other.Metadata)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Published != null)
					hash = hash * 59 + this.Published.GetHashCode();

				if (this.ShortTermForecast != null)
					hash = hash * 59 + this.ShortTermForecast.GetHashCode();

				if (this.GenerationResults != null)
					hash = hash * 59 + this.GenerationResults.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
