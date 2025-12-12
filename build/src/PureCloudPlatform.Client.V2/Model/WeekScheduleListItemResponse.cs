using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WeekScheduleListItemResponse
	/// </summary>
	[DataContract]
	public partial class WeekScheduleListItemResponse : IEquatable<WeekScheduleListItemResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WeekScheduleListItemResponse" /> class.
		/// </summary>
		/// <param name="WeekDate">First day of this week schedule in yyyy-MM-dd format.</param>
		/// <param name="Description">Description of the week schedule.</param>
		/// <param name="Published">Whether the week schedule is published.</param>
		/// <param name="GenerationResults">Summary of the results from the schedule run.</param>
		/// <param name="ShortTermForecast">Short term forecast associated with this schedule.</param>
		/// <param name="Metadata">Version metadata for this work plan.</param>
		public WeekScheduleListItemResponse(string WeekDate = null, string Description = null, bool? Published = null, WeekScheduleGenerationResult GenerationResults = null, ShortTermForecastReference ShortTermForecast = null, WfmVersionedEntityMetadata Metadata = null)
		{
			this.WeekDate = WeekDate;
			this.Description = Description;
			this.Published = Published;
			this.GenerationResults = GenerationResults;
			this.ShortTermForecast = ShortTermForecast;
			this.Metadata = Metadata;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }



		/// <summary>
		/// First day of this week schedule in yyyy-MM-dd format
		/// </summary>
		/// <value>First day of this week schedule in yyyy-MM-dd format</value>
		[DataMember(Name = "weekDate", EmitDefaultValue = false)]
		public string WeekDate { get; set; }



		/// <summary>
		/// Description of the week schedule
		/// </summary>
		/// <value>Description of the week schedule</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Whether the week schedule is published
		/// </summary>
		/// <value>Whether the week schedule is published</value>
		[DataMember(Name = "published", EmitDefaultValue = false)]
		public bool? Published { get; set; }



		/// <summary>
		/// Summary of the results from the schedule run
		/// </summary>
		/// <value>Summary of the results from the schedule run</value>
		[DataMember(Name = "generationResults", EmitDefaultValue = false)]
		public WeekScheduleGenerationResult GenerationResults { get; set; }



		/// <summary>
		/// Short term forecast associated with this schedule
		/// </summary>
		/// <value>Short term forecast associated with this schedule</value>
		[DataMember(Name = "shortTermForecast", EmitDefaultValue = false)]
		public ShortTermForecastReference ShortTermForecast { get; set; }



		/// <summary>
		/// Version metadata for this work plan
		/// </summary>
		/// <value>Version metadata for this work plan</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public WfmVersionedEntityMetadata Metadata { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WeekScheduleListItemResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
			sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Published: ").Append(Published).Append("\n");
			sb.Append("  GenerationResults: ").Append(GenerationResults).Append("\n");
			sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
			return this.Equals(obj as WeekScheduleListItemResponse);
		}

		/// <summary>
		/// Returns true if WeekScheduleListItemResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of WeekScheduleListItemResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WeekScheduleListItemResponse other)
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
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
				) &&
				(
					this.WeekDate == other.WeekDate ||
					this.WeekDate != null &&
					this.WeekDate.Equals(other.WeekDate)
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
					this.GenerationResults == other.GenerationResults ||
					this.GenerationResults != null &&
					this.GenerationResults.Equals(other.GenerationResults)
				) &&
				(
					this.ShortTermForecast == other.ShortTermForecast ||
					this.ShortTermForecast != null &&
					this.ShortTermForecast.Equals(other.ShortTermForecast)
				) &&
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.Equals(other.Metadata)
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

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				if (this.WeekDate != null)
					hash = hash * 59 + this.WeekDate.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Published != null)
					hash = hash * 59 + this.Published.GetHashCode();

				if (this.GenerationResults != null)
					hash = hash * 59 + this.GenerationResults.GetHashCode();

				if (this.ShortTermForecast != null)
					hash = hash * 59 + this.ShortTermForecast.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				return hash;
			}
		}
	}

}
