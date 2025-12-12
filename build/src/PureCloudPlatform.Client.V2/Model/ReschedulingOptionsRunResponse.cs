using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ReschedulingOptionsRunResponse
	/// </summary>
	[DataContract]
	public partial class ReschedulingOptionsRunResponse : IEquatable<ReschedulingOptionsRunResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ReschedulingOptionsRunResponse" /> class.
		/// </summary>
		/// <param name="ExistingSchedule">The existing schedule to which this reschedule run applies.</param>
		/// <param name="StartDate">The start date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="EndDate">The end date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="ManagementUnits">Per-management unit rescheduling options.</param>
		/// <param name="AgentCount">The number of agents to be considered in the reschedule.</param>
		/// <param name="ActivityCodeIds">The IDs of the activity codes being considered for reschedule.</param>
		/// <param name="DoNotChangeWeeklyPaidTime">Whether weekly paid time is allowed to be changed.</param>
		/// <param name="DoNotChangeDailyPaidTime">Whether daily paid time is allowed to be changed.</param>
		/// <param name="DoNotChangeShiftStartTimes">Whether shift start times are allowed to be changed.</param>
		/// <param name="DoNotChangeManuallyEditedShifts">Whether manually edited shifts are allowed to be changed.</param>
		public ReschedulingOptionsRunResponse(BuScheduleReference ExistingSchedule = null, DateTime? StartDate = null, DateTime? EndDate = null, List<ReschedulingManagementUnitResponse> ManagementUnits = null, int? AgentCount = null, List<string> ActivityCodeIds = null, bool? DoNotChangeWeeklyPaidTime = null, bool? DoNotChangeDailyPaidTime = null, bool? DoNotChangeShiftStartTimes = null, bool? DoNotChangeManuallyEditedShifts = null)
		{
			this.ExistingSchedule = ExistingSchedule;
			this.StartDate = StartDate;
			this.EndDate = EndDate;
			this.ManagementUnits = ManagementUnits;
			this.AgentCount = AgentCount;
			this.ActivityCodeIds = ActivityCodeIds;
			this.DoNotChangeWeeklyPaidTime = DoNotChangeWeeklyPaidTime;
			this.DoNotChangeDailyPaidTime = DoNotChangeDailyPaidTime;
			this.DoNotChangeShiftStartTimes = DoNotChangeShiftStartTimes;
			this.DoNotChangeManuallyEditedShifts = DoNotChangeManuallyEditedShifts;

		}



		/// <summary>
		/// The existing schedule to which this reschedule run applies
		/// </summary>
		/// <value>The existing schedule to which this reschedule run applies</value>
		[DataMember(Name = "existingSchedule", EmitDefaultValue = false)]
		public BuScheduleReference ExistingSchedule { get; set; }



		/// <summary>
		/// The start date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The start date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }



		/// <summary>
		/// The end date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The end date of the period to reschedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "endDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }



		/// <summary>
		/// Per-management unit rescheduling options
		/// </summary>
		/// <value>Per-management unit rescheduling options</value>
		[DataMember(Name = "managementUnits", EmitDefaultValue = false)]
		public List<ReschedulingManagementUnitResponse> ManagementUnits { get; set; }



		/// <summary>
		/// The number of agents to be considered in the reschedule
		/// </summary>
		/// <value>The number of agents to be considered in the reschedule</value>
		[DataMember(Name = "agentCount", EmitDefaultValue = false)]
		public int? AgentCount { get; set; }



		/// <summary>
		/// The IDs of the activity codes being considered for reschedule
		/// </summary>
		/// <value>The IDs of the activity codes being considered for reschedule</value>
		[DataMember(Name = "activityCodeIds", EmitDefaultValue = false)]
		public List<string> ActivityCodeIds { get; set; }



		/// <summary>
		/// Whether weekly paid time is allowed to be changed
		/// </summary>
		/// <value>Whether weekly paid time is allowed to be changed</value>
		[DataMember(Name = "doNotChangeWeeklyPaidTime", EmitDefaultValue = false)]
		public bool? DoNotChangeWeeklyPaidTime { get; set; }



		/// <summary>
		/// Whether daily paid time is allowed to be changed
		/// </summary>
		/// <value>Whether daily paid time is allowed to be changed</value>
		[DataMember(Name = "doNotChangeDailyPaidTime", EmitDefaultValue = false)]
		public bool? DoNotChangeDailyPaidTime { get; set; }



		/// <summary>
		/// Whether shift start times are allowed to be changed
		/// </summary>
		/// <value>Whether shift start times are allowed to be changed</value>
		[DataMember(Name = "doNotChangeShiftStartTimes", EmitDefaultValue = false)]
		public bool? DoNotChangeShiftStartTimes { get; set; }



		/// <summary>
		/// Whether manually edited shifts are allowed to be changed
		/// </summary>
		/// <value>Whether manually edited shifts are allowed to be changed</value>
		[DataMember(Name = "doNotChangeManuallyEditedShifts", EmitDefaultValue = false)]
		public bool? DoNotChangeManuallyEditedShifts { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ReschedulingOptionsRunResponse {\n");

			sb.Append("  ExistingSchedule: ").Append(ExistingSchedule).Append("\n");
			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  EndDate: ").Append(EndDate).Append("\n");
			sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
			sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
			sb.Append("  ActivityCodeIds: ").Append(ActivityCodeIds).Append("\n");
			sb.Append("  DoNotChangeWeeklyPaidTime: ").Append(DoNotChangeWeeklyPaidTime).Append("\n");
			sb.Append("  DoNotChangeDailyPaidTime: ").Append(DoNotChangeDailyPaidTime).Append("\n");
			sb.Append("  DoNotChangeShiftStartTimes: ").Append(DoNotChangeShiftStartTimes).Append("\n");
			sb.Append("  DoNotChangeManuallyEditedShifts: ").Append(DoNotChangeManuallyEditedShifts).Append("\n");
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
			return this.Equals(obj as ReschedulingOptionsRunResponse);
		}

		/// <summary>
		/// Returns true if ReschedulingOptionsRunResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ReschedulingOptionsRunResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ReschedulingOptionsRunResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ExistingSchedule == other.ExistingSchedule ||
					this.ExistingSchedule != null &&
					this.ExistingSchedule.Equals(other.ExistingSchedule)
				) &&
				(
					this.StartDate == other.StartDate ||
					this.StartDate != null &&
					this.StartDate.Equals(other.StartDate)
				) &&
				(
					this.EndDate == other.EndDate ||
					this.EndDate != null &&
					this.EndDate.Equals(other.EndDate)
				) &&
				(
					this.ManagementUnits == other.ManagementUnits ||
					this.ManagementUnits != null &&
					this.ManagementUnits.SequenceEqual(other.ManagementUnits)
				) &&
				(
					this.AgentCount == other.AgentCount ||
					this.AgentCount != null &&
					this.AgentCount.Equals(other.AgentCount)
				) &&
				(
					this.ActivityCodeIds == other.ActivityCodeIds ||
					this.ActivityCodeIds != null &&
					this.ActivityCodeIds.SequenceEqual(other.ActivityCodeIds)
				) &&
				(
					this.DoNotChangeWeeklyPaidTime == other.DoNotChangeWeeklyPaidTime ||
					this.DoNotChangeWeeklyPaidTime != null &&
					this.DoNotChangeWeeklyPaidTime.Equals(other.DoNotChangeWeeklyPaidTime)
				) &&
				(
					this.DoNotChangeDailyPaidTime == other.DoNotChangeDailyPaidTime ||
					this.DoNotChangeDailyPaidTime != null &&
					this.DoNotChangeDailyPaidTime.Equals(other.DoNotChangeDailyPaidTime)
				) &&
				(
					this.DoNotChangeShiftStartTimes == other.DoNotChangeShiftStartTimes ||
					this.DoNotChangeShiftStartTimes != null &&
					this.DoNotChangeShiftStartTimes.Equals(other.DoNotChangeShiftStartTimes)
				) &&
				(
					this.DoNotChangeManuallyEditedShifts == other.DoNotChangeManuallyEditedShifts ||
					this.DoNotChangeManuallyEditedShifts != null &&
					this.DoNotChangeManuallyEditedShifts.Equals(other.DoNotChangeManuallyEditedShifts)
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
				if (this.ExistingSchedule != null)
					hash = hash * 59 + this.ExistingSchedule.GetHashCode();

				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				if (this.EndDate != null)
					hash = hash * 59 + this.EndDate.GetHashCode();

				if (this.ManagementUnits != null)
					hash = hash * 59 + this.ManagementUnits.GetHashCode();

				if (this.AgentCount != null)
					hash = hash * 59 + this.AgentCount.GetHashCode();

				if (this.ActivityCodeIds != null)
					hash = hash * 59 + this.ActivityCodeIds.GetHashCode();

				if (this.DoNotChangeWeeklyPaidTime != null)
					hash = hash * 59 + this.DoNotChangeWeeklyPaidTime.GetHashCode();

				if (this.DoNotChangeDailyPaidTime != null)
					hash = hash * 59 + this.DoNotChangeDailyPaidTime.GetHashCode();

				if (this.DoNotChangeShiftStartTimes != null)
					hash = hash * 59 + this.DoNotChangeShiftStartTimes.GetHashCode();

				if (this.DoNotChangeManuallyEditedShifts != null)
					hash = hash * 59 + this.DoNotChangeManuallyEditedShifts.GetHashCode();

				return hash;
			}
		}
	}

}
