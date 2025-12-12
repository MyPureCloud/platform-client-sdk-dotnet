using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuRescheduleRequest
	/// </summary>
	[DataContract]
	public partial class BuRescheduleRequest : IEquatable<BuRescheduleRequest>
	{
		/// <summary>
		/// Overrides the default BU level activity smoothing type for this reschedule run
		/// </summary>
		/// <value>Overrides the default BU level activity smoothing type for this reschedule run</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActivitySmoothingTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Reduceconcurrentactivitiesacrossbu for "ReduceConcurrentActivitiesAcrossBu"
			/// </summary>
			[EnumMember(Value = "ReduceConcurrentActivitiesAcrossBu")]
			Reduceconcurrentactivitiesacrossbu,

			/// <summary>
			/// Enum Reduceconcurrentactivitiesacrossmu for "ReduceConcurrentActivitiesAcrossMu"
			/// </summary>
			[EnumMember(Value = "ReduceConcurrentActivitiesAcrossMu")]
			Reduceconcurrentactivitiesacrossmu,

			/// <summary>
			/// Enum Consistentservicelevel for "ConsistentServiceLevel"
			/// </summary>
			[EnumMember(Value = "ConsistentServiceLevel")]
			Consistentservicelevel
		}
		/// <summary>
		/// Overrides the default BU level activity smoothing type for this reschedule run
		/// </summary>
		/// <value>Overrides the default BU level activity smoothing type for this reschedule run</value>
		[DataMember(Name = "activitySmoothingType", EmitDefaultValue = false)]
		public ActivitySmoothingTypeEnum? ActivitySmoothingType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="BuRescheduleRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BuRescheduleRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BuRescheduleRequest" /> class.
		/// </summary>
		/// <param name="StartDate">The start of the range to reschedule.  Defaults to the beginning of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="EndDate">The end of the range to reschedule.  Defaults the the end of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="AgentIds">The IDs of the agents to consider for rescheduling.  Omit to consider all agents in the specified management units.Agents not in the specified management units will be ignored.</param>
		/// <param name="ActivityCodeIds">The IDs of the activity codes to consider for rescheduling.  Omit to consider all activity codes.</param>
		/// <param name="ManagementUnitIds">The IDs of the management units to reschedule (required).</param>
		/// <param name="DoNotChangeWeeklyPaidTime">Instructs the scheduler whether it is allowed to change weekly paid time (required).</param>
		/// <param name="DoNotChangeDailyPaidTime">Instructs the scheduler whether it is allowed to change daily paid time (required).</param>
		/// <param name="DoNotChangeShiftStartTimes">Instructs the scheduler whether it is allowed to change shift start times (required).</param>
		/// <param name="DoNotChangeManuallyEditedShifts">Instructs the scheduler whether it is allowed to change manually edited shifts (required).</param>
		/// <param name="ActivitySmoothingType">Overrides the default BU level activity smoothing type for this reschedule run.</param>
		/// <param name="InduceScheduleVariability">Overrides the default BU level induce schedule variability setting for this reschedule run.</param>
		public BuRescheduleRequest(DateTime? StartDate = null, DateTime? EndDate = null, List<string> AgentIds = null, List<string> ActivityCodeIds = null, List<string> ManagementUnitIds = null, bool? DoNotChangeWeeklyPaidTime = null, bool? DoNotChangeDailyPaidTime = null, bool? DoNotChangeShiftStartTimes = null, bool? DoNotChangeManuallyEditedShifts = null, ActivitySmoothingTypeEnum? ActivitySmoothingType = null, bool? InduceScheduleVariability = null)
		{
			this.StartDate = StartDate;
			this.EndDate = EndDate;
			this.AgentIds = AgentIds;
			this.ActivityCodeIds = ActivityCodeIds;
			this.ManagementUnitIds = ManagementUnitIds;
			this.DoNotChangeWeeklyPaidTime = DoNotChangeWeeklyPaidTime;
			this.DoNotChangeDailyPaidTime = DoNotChangeDailyPaidTime;
			this.DoNotChangeShiftStartTimes = DoNotChangeShiftStartTimes;
			this.DoNotChangeManuallyEditedShifts = DoNotChangeManuallyEditedShifts;
			this.ActivitySmoothingType = ActivitySmoothingType;
			this.InduceScheduleVariability = InduceScheduleVariability;

		}



		/// <summary>
		/// The start of the range to reschedule.  Defaults to the beginning of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The start of the range to reschedule.  Defaults to the beginning of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }



		/// <summary>
		/// The end of the range to reschedule.  Defaults the the end of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The end of the range to reschedule.  Defaults the the end of the schedule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "endDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }



		/// <summary>
		/// The IDs of the agents to consider for rescheduling.  Omit to consider all agents in the specified management units.Agents not in the specified management units will be ignored
		/// </summary>
		/// <value>The IDs of the agents to consider for rescheduling.  Omit to consider all agents in the specified management units.Agents not in the specified management units will be ignored</value>
		[DataMember(Name = "agentIds", EmitDefaultValue = false)]
		public List<string> AgentIds { get; set; }



		/// <summary>
		/// The IDs of the activity codes to consider for rescheduling.  Omit to consider all activity codes
		/// </summary>
		/// <value>The IDs of the activity codes to consider for rescheduling.  Omit to consider all activity codes</value>
		[DataMember(Name = "activityCodeIds", EmitDefaultValue = false)]
		public List<string> ActivityCodeIds { get; set; }



		/// <summary>
		/// The IDs of the management units to reschedule
		/// </summary>
		/// <value>The IDs of the management units to reschedule</value>
		[DataMember(Name = "managementUnitIds", EmitDefaultValue = false)]
		public List<string> ManagementUnitIds { get; set; }



		/// <summary>
		/// Instructs the scheduler whether it is allowed to change weekly paid time
		/// </summary>
		/// <value>Instructs the scheduler whether it is allowed to change weekly paid time</value>
		[DataMember(Name = "doNotChangeWeeklyPaidTime", EmitDefaultValue = false)]
		public bool? DoNotChangeWeeklyPaidTime { get; set; }



		/// <summary>
		/// Instructs the scheduler whether it is allowed to change daily paid time
		/// </summary>
		/// <value>Instructs the scheduler whether it is allowed to change daily paid time</value>
		[DataMember(Name = "doNotChangeDailyPaidTime", EmitDefaultValue = false)]
		public bool? DoNotChangeDailyPaidTime { get; set; }



		/// <summary>
		/// Instructs the scheduler whether it is allowed to change shift start times
		/// </summary>
		/// <value>Instructs the scheduler whether it is allowed to change shift start times</value>
		[DataMember(Name = "doNotChangeShiftStartTimes", EmitDefaultValue = false)]
		public bool? DoNotChangeShiftStartTimes { get; set; }



		/// <summary>
		/// Instructs the scheduler whether it is allowed to change manually edited shifts
		/// </summary>
		/// <value>Instructs the scheduler whether it is allowed to change manually edited shifts</value>
		[DataMember(Name = "doNotChangeManuallyEditedShifts", EmitDefaultValue = false)]
		public bool? DoNotChangeManuallyEditedShifts { get; set; }





		/// <summary>
		/// Overrides the default BU level induce schedule variability setting for this reschedule run
		/// </summary>
		/// <value>Overrides the default BU level induce schedule variability setting for this reschedule run</value>
		[DataMember(Name = "induceScheduleVariability", EmitDefaultValue = false)]
		public bool? InduceScheduleVariability { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuRescheduleRequest {\n");

			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  EndDate: ").Append(EndDate).Append("\n");
			sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
			sb.Append("  ActivityCodeIds: ").Append(ActivityCodeIds).Append("\n");
			sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
			sb.Append("  DoNotChangeWeeklyPaidTime: ").Append(DoNotChangeWeeklyPaidTime).Append("\n");
			sb.Append("  DoNotChangeDailyPaidTime: ").Append(DoNotChangeDailyPaidTime).Append("\n");
			sb.Append("  DoNotChangeShiftStartTimes: ").Append(DoNotChangeShiftStartTimes).Append("\n");
			sb.Append("  DoNotChangeManuallyEditedShifts: ").Append(DoNotChangeManuallyEditedShifts).Append("\n");
			sb.Append("  ActivitySmoothingType: ").Append(ActivitySmoothingType).Append("\n");
			sb.Append("  InduceScheduleVariability: ").Append(InduceScheduleVariability).Append("\n");
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
			return this.Equals(obj as BuRescheduleRequest);
		}

		/// <summary>
		/// Returns true if BuRescheduleRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of BuRescheduleRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuRescheduleRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
					this.AgentIds == other.AgentIds ||
					this.AgentIds != null &&
					this.AgentIds.SequenceEqual(other.AgentIds)
				) &&
				(
					this.ActivityCodeIds == other.ActivityCodeIds ||
					this.ActivityCodeIds != null &&
					this.ActivityCodeIds.SequenceEqual(other.ActivityCodeIds)
				) &&
				(
					this.ManagementUnitIds == other.ManagementUnitIds ||
					this.ManagementUnitIds != null &&
					this.ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
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
				) &&
				(
					this.ActivitySmoothingType == other.ActivitySmoothingType ||
					this.ActivitySmoothingType != null &&
					this.ActivitySmoothingType.Equals(other.ActivitySmoothingType)
				) &&
				(
					this.InduceScheduleVariability == other.InduceScheduleVariability ||
					this.InduceScheduleVariability != null &&
					this.InduceScheduleVariability.Equals(other.InduceScheduleVariability)
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
				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				if (this.EndDate != null)
					hash = hash * 59 + this.EndDate.GetHashCode();

				if (this.AgentIds != null)
					hash = hash * 59 + this.AgentIds.GetHashCode();

				if (this.ActivityCodeIds != null)
					hash = hash * 59 + this.ActivityCodeIds.GetHashCode();

				if (this.ManagementUnitIds != null)
					hash = hash * 59 + this.ManagementUnitIds.GetHashCode();

				if (this.DoNotChangeWeeklyPaidTime != null)
					hash = hash * 59 + this.DoNotChangeWeeklyPaidTime.GetHashCode();

				if (this.DoNotChangeDailyPaidTime != null)
					hash = hash * 59 + this.DoNotChangeDailyPaidTime.GetHashCode();

				if (this.DoNotChangeShiftStartTimes != null)
					hash = hash * 59 + this.DoNotChangeShiftStartTimes.GetHashCode();

				if (this.DoNotChangeManuallyEditedShifts != null)
					hash = hash * 59 + this.DoNotChangeManuallyEditedShifts.GetHashCode();

				if (this.ActivitySmoothingType != null)
					hash = hash * 59 + this.ActivitySmoothingType.GetHashCode();

				if (this.InduceScheduleVariability != null)
					hash = hash * 59 + this.InduceScheduleVariability.GetHashCode();

				return hash;
			}
		}
	}

}
