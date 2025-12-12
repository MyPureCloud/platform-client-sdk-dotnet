using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentPossibleWorkShiftsResponse
	/// </summary>
	[DataContract]
	public partial class AgentPossibleWorkShiftsResponse : IEquatable<AgentPossibleWorkShiftsResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentPossibleWorkShiftsResponse" /> class.
		/// </summary>
		/// <param name="WeekStartDate">Start date of requested effective work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="Pattern">Each element is the ID of an effective work plan for a specific week.</param>
		/// <param name="WeeklyPossibleWorkShifts">Each element is a weekly effective work plan that can be used for multiple weeks.</param>
		/// <param name="SchedulerIntervalLengthMinutes">Number of minutes in each interval in the intervalScheduleProbabilities.</param>
		/// <param name="TimeZone">The time zone of the business unit.</param>
		public AgentPossibleWorkShiftsResponse(String WeekStartDate = null, List<int?> Pattern = null, List<PossibleWorkShiftsForWeek> WeeklyPossibleWorkShifts = null, int? SchedulerIntervalLengthMinutes = null, string TimeZone = null)
		{
			this.WeekStartDate = WeekStartDate;
			this.Pattern = Pattern;
			this.WeeklyPossibleWorkShifts = WeeklyPossibleWorkShifts;
			this.SchedulerIntervalLengthMinutes = SchedulerIntervalLengthMinutes;
			this.TimeZone = TimeZone;

		}



		/// <summary>
		/// Start date of requested effective work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Start date of requested effective work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "weekStartDate", EmitDefaultValue = false)]
		public String WeekStartDate { get; set; }



		/// <summary>
		/// Each element is the ID of an effective work plan for a specific week
		/// </summary>
		/// <value>Each element is the ID of an effective work plan for a specific week</value>
		[DataMember(Name = "pattern", EmitDefaultValue = false)]
		public List<int?> Pattern { get; set; }



		/// <summary>
		/// Each element is a weekly effective work plan that can be used for multiple weeks
		/// </summary>
		/// <value>Each element is a weekly effective work plan that can be used for multiple weeks</value>
		[DataMember(Name = "weeklyPossibleWorkShifts", EmitDefaultValue = false)]
		public List<PossibleWorkShiftsForWeek> WeeklyPossibleWorkShifts { get; set; }



		/// <summary>
		/// Number of minutes in each interval in the intervalScheduleProbabilities
		/// </summary>
		/// <value>Number of minutes in each interval in the intervalScheduleProbabilities</value>
		[DataMember(Name = "schedulerIntervalLengthMinutes", EmitDefaultValue = false)]
		public int? SchedulerIntervalLengthMinutes { get; set; }



		/// <summary>
		/// The time zone of the business unit
		/// </summary>
		/// <value>The time zone of the business unit</value>
		[DataMember(Name = "timeZone", EmitDefaultValue = false)]
		public string TimeZone { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AgentPossibleWorkShiftsResponse {\n");

			sb.Append("  WeekStartDate: ").Append(WeekStartDate).Append("\n");
			sb.Append("  Pattern: ").Append(Pattern).Append("\n");
			sb.Append("  WeeklyPossibleWorkShifts: ").Append(WeeklyPossibleWorkShifts).Append("\n");
			sb.Append("  SchedulerIntervalLengthMinutes: ").Append(SchedulerIntervalLengthMinutes).Append("\n");
			sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
			return this.Equals(obj as AgentPossibleWorkShiftsResponse);
		}

		/// <summary>
		/// Returns true if AgentPossibleWorkShiftsResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentPossibleWorkShiftsResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentPossibleWorkShiftsResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.WeekStartDate == other.WeekStartDate ||
					this.WeekStartDate != null &&
					this.WeekStartDate.Equals(other.WeekStartDate)
				) &&
				(
					this.Pattern == other.Pattern ||
					this.Pattern != null &&
					this.Pattern.SequenceEqual(other.Pattern)
				) &&
				(
					this.WeeklyPossibleWorkShifts == other.WeeklyPossibleWorkShifts ||
					this.WeeklyPossibleWorkShifts != null &&
					this.WeeklyPossibleWorkShifts.SequenceEqual(other.WeeklyPossibleWorkShifts)
				) &&
				(
					this.SchedulerIntervalLengthMinutes == other.SchedulerIntervalLengthMinutes ||
					this.SchedulerIntervalLengthMinutes != null &&
					this.SchedulerIntervalLengthMinutes.Equals(other.SchedulerIntervalLengthMinutes)
				) &&
				(
					this.TimeZone == other.TimeZone ||
					this.TimeZone != null &&
					this.TimeZone.Equals(other.TimeZone)
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
				if (this.WeekStartDate != null)
					hash = hash * 59 + this.WeekStartDate.GetHashCode();

				if (this.Pattern != null)
					hash = hash * 59 + this.Pattern.GetHashCode();

				if (this.WeeklyPossibleWorkShifts != null)
					hash = hash * 59 + this.WeeklyPossibleWorkShifts.GetHashCode();

				if (this.SchedulerIntervalLengthMinutes != null)
					hash = hash * 59 + this.SchedulerIntervalLengthMinutes.GetHashCode();

				if (this.TimeZone != null)
					hash = hash * 59 + this.TimeZone.GetHashCode();

				return hash;
			}
		}
	}

}
