using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CoachingScheduleSlotsJobSchedule
	/// </summary>
	[DataContract]
	public partial class CoachingScheduleSlotsJobSchedule : IEquatable<CoachingScheduleSlotsJobSchedule>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CoachingScheduleSlotsJobSchedule" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="SelfUri">SelfUri.</param>
		/// <param name="WeekDate">The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="WeekCount">The number of weeks in this schedule.</param>
		public CoachingScheduleSlotsJobSchedule(string Id = null, string SelfUri = null, String WeekDate = null, int? WeekCount = null)
		{
			this.Id = Id;
			this.SelfUri = SelfUri;
			this.WeekDate = WeekDate;
			this.WeekCount = WeekCount;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets SelfUri
		/// </summary>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; set; }



		/// <summary>
		/// The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "weekDate", EmitDefaultValue = false)]
		public String WeekDate { get; set; }



		/// <summary>
		/// The number of weeks in this schedule
		/// </summary>
		/// <value>The number of weeks in this schedule</value>
		[DataMember(Name = "weekCount", EmitDefaultValue = false)]
		public int? WeekCount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CoachingScheduleSlotsJobSchedule {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
			sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
			sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
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
			return this.Equals(obj as CoachingScheduleSlotsJobSchedule);
		}

		/// <summary>
		/// Returns true if CoachingScheduleSlotsJobSchedule instances are equal
		/// </summary>
		/// <param name="other">Instance of CoachingScheduleSlotsJobSchedule to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CoachingScheduleSlotsJobSchedule other)
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
					this.WeekCount == other.WeekCount ||
					this.WeekCount != null &&
					this.WeekCount.Equals(other.WeekCount)
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

				if (this.WeekCount != null)
					hash = hash * 59 + this.WeekCount.GetHashCode();

				return hash;
			}
		}
	}

}
