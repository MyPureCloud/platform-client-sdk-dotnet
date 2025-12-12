using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreateWorkPlanShift
	/// </summary>
	[DataContract]
	public partial class CreateWorkPlanShift : IEquatable<CreateWorkPlanShift>
	{
		/// <summary>
		/// The day off rule for agents to have next day off or previous day off. used if constrainDayOff = true
		/// </summary>
		/// <value>The day off rule for agents to have next day off or previous day off. used if constrainDayOff = true</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DayOffRuleEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Nextdayoff for "NextDayOff"
			/// </summary>
			[EnumMember(Value = "NextDayOff")]
			Nextdayoff,

			/// <summary>
			/// Enum Previousdayoff for "PreviousDayOff"
			/// </summary>
			[EnumMember(Value = "PreviousDayOff")]
			Previousdayoff
		}
		/// <summary>
		/// The day off rule for agents to have next day off or previous day off. used if constrainDayOff = true
		/// </summary>
		/// <value>The day off rule for agents to have next day off or previous day off. used if constrainDayOff = true</value>
		[DataMember(Name = "dayOffRule", EmitDefaultValue = false)]
		public DayOffRuleEnum? DayOffRule { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateWorkPlanShift" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CreateWorkPlanShift() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateWorkPlanShift" /> class.
		/// </summary>
		/// <param name="Name">Name of the shift (required).</param>
		/// <param name="Days">Days of the week applicable for this shift.</param>
		/// <param name="FlexibleStartTime">Whether the start time of the shift is flexible.</param>
		/// <param name="ExactStartTimeMinutesFromMidnight">Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; false.</param>
		/// <param name="EarliestStartTimeMinutesFromMidnight">Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true.</param>
		/// <param name="LatestStartTimeMinutesFromMidnight">Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true.</param>
		/// <param name="ConstrainStopTime">Whether the latest stop time constraint for the shift is enabled.  Deprecated, use constrainLatestStopTime instead.</param>
		/// <param name="ConstrainLatestStopTime">Whether the latest stop time constraint for the shift is enabled.</param>
		/// <param name="LatestStopTimeMinutesFromMidnight">Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime &#x3D;&#x3D; true.</param>
		/// <param name="ConstrainEarliestStopTime">Whether the earliest stop time constraint for the shift is enabled.</param>
		/// <param name="EarliestStopTimeMinutesFromMidnight">This is the earliest time a shift can end.</param>
		/// <param name="StartIncrementMinutes">Increment in offset minutes that would contribute to different possible start times for the shift. Used if flexibleStartTime &#x3D;&#x3D; true.</param>
		/// <param name="FlexiblePaidTime">Whether the paid time setting for the shift is flexible.</param>
		/// <param name="ExactPaidTimeMinutes">Exact paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; false.</param>
		/// <param name="MinimumPaidTimeMinutes">Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true.</param>
		/// <param name="MaximumPaidTimeMinutes">Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true.</param>
		/// <param name="ConstrainContiguousWorkTime">Whether the contiguous time constraint for the shift is enabled.</param>
		/// <param name="MinimumContiguousWorkTimeMinutes">Minimum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true.</param>
		/// <param name="MaximumContiguousWorkTimeMinutes">Maximum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true.</param>
		/// <param name="ConstrainDayOff">Whether day off rule is enabled.</param>
		/// <param name="DayOffRule">The day off rule for agents to have next day off or previous day off. used if constrainDayOff &#x3D; true.</param>
		/// <param name="PlanningPeriodConstraints">Planning period constraints.</param>
		/// <param name="Activities">Activities configured for this shift.</param>
		public CreateWorkPlanShift(string Name = null, SetWrapperDayOfWeek Days = null, bool? FlexibleStartTime = null, int? ExactStartTimeMinutesFromMidnight = null, int? EarliestStartTimeMinutesFromMidnight = null, int? LatestStartTimeMinutesFromMidnight = null, bool? ConstrainStopTime = null, bool? ConstrainLatestStopTime = null, int? LatestStopTimeMinutesFromMidnight = null, bool? ConstrainEarliestStopTime = null, int? EarliestStopTimeMinutesFromMidnight = null, int? StartIncrementMinutes = null, bool? FlexiblePaidTime = null, int? ExactPaidTimeMinutes = null, int? MinimumPaidTimeMinutes = null, int? MaximumPaidTimeMinutes = null, bool? ConstrainContiguousWorkTime = null, int? MinimumContiguousWorkTimeMinutes = null, int? MaximumContiguousWorkTimeMinutes = null, bool? ConstrainDayOff = null, DayOffRuleEnum? DayOffRule = null, PlanningPeriodShiftConstraints PlanningPeriodConstraints = null, List<CreateWorkPlanActivity> Activities = null)
		{
			this.Name = Name;
			this.Days = Days;
			this.FlexibleStartTime = FlexibleStartTime;
			this.ExactStartTimeMinutesFromMidnight = ExactStartTimeMinutesFromMidnight;
			this.EarliestStartTimeMinutesFromMidnight = EarliestStartTimeMinutesFromMidnight;
			this.LatestStartTimeMinutesFromMidnight = LatestStartTimeMinutesFromMidnight;
			this.ConstrainStopTime = ConstrainStopTime;
			this.ConstrainLatestStopTime = ConstrainLatestStopTime;
			this.LatestStopTimeMinutesFromMidnight = LatestStopTimeMinutesFromMidnight;
			this.ConstrainEarliestStopTime = ConstrainEarliestStopTime;
			this.EarliestStopTimeMinutesFromMidnight = EarliestStopTimeMinutesFromMidnight;
			this.StartIncrementMinutes = StartIncrementMinutes;
			this.FlexiblePaidTime = FlexiblePaidTime;
			this.ExactPaidTimeMinutes = ExactPaidTimeMinutes;
			this.MinimumPaidTimeMinutes = MinimumPaidTimeMinutes;
			this.MaximumPaidTimeMinutes = MaximumPaidTimeMinutes;
			this.ConstrainContiguousWorkTime = ConstrainContiguousWorkTime;
			this.MinimumContiguousWorkTimeMinutes = MinimumContiguousWorkTimeMinutes;
			this.MaximumContiguousWorkTimeMinutes = MaximumContiguousWorkTimeMinutes;
			this.ConstrainDayOff = ConstrainDayOff;
			this.DayOffRule = DayOffRule;
			this.PlanningPeriodConstraints = PlanningPeriodConstraints;
			this.Activities = Activities;

		}



		/// <summary>
		/// Name of the shift
		/// </summary>
		/// <value>Name of the shift</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Days of the week applicable for this shift
		/// </summary>
		/// <value>Days of the week applicable for this shift</value>
		[DataMember(Name = "days", EmitDefaultValue = false)]
		public SetWrapperDayOfWeek Days { get; set; }



		/// <summary>
		/// Whether the start time of the shift is flexible
		/// </summary>
		/// <value>Whether the start time of the shift is flexible</value>
		[DataMember(Name = "flexibleStartTime", EmitDefaultValue = false)]
		public bool? FlexibleStartTime { get; set; }



		/// <summary>
		/// Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; false
		/// </summary>
		/// <value>Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; false</value>
		[DataMember(Name = "exactStartTimeMinutesFromMidnight", EmitDefaultValue = false)]
		public int? ExactStartTimeMinutesFromMidnight { get; set; }



		/// <summary>
		/// Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true
		/// </summary>
		/// <value>Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true</value>
		[DataMember(Name = "earliestStartTimeMinutesFromMidnight", EmitDefaultValue = false)]
		public int? EarliestStartTimeMinutesFromMidnight { get; set; }



		/// <summary>
		/// Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true
		/// </summary>
		/// <value>Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true</value>
		[DataMember(Name = "latestStartTimeMinutesFromMidnight", EmitDefaultValue = false)]
		public int? LatestStartTimeMinutesFromMidnight { get; set; }



		/// <summary>
		/// Whether the latest stop time constraint for the shift is enabled.  Deprecated, use constrainLatestStopTime instead
		/// </summary>
		/// <value>Whether the latest stop time constraint for the shift is enabled.  Deprecated, use constrainLatestStopTime instead</value>
		[DataMember(Name = "constrainStopTime", EmitDefaultValue = false)]
		public bool? ConstrainStopTime { get; set; }



		/// <summary>
		/// Whether the latest stop time constraint for the shift is enabled
		/// </summary>
		/// <value>Whether the latest stop time constraint for the shift is enabled</value>
		[DataMember(Name = "constrainLatestStopTime", EmitDefaultValue = false)]
		public bool? ConstrainLatestStopTime { get; set; }



		/// <summary>
		/// Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime &#x3D;&#x3D; true
		/// </summary>
		/// <value>Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime &#x3D;&#x3D; true</value>
		[DataMember(Name = "latestStopTimeMinutesFromMidnight", EmitDefaultValue = false)]
		public int? LatestStopTimeMinutesFromMidnight { get; set; }



		/// <summary>
		/// Whether the earliest stop time constraint for the shift is enabled
		/// </summary>
		/// <value>Whether the earliest stop time constraint for the shift is enabled</value>
		[DataMember(Name = "constrainEarliestStopTime", EmitDefaultValue = false)]
		public bool? ConstrainEarliestStopTime { get; set; }



		/// <summary>
		/// This is the earliest time a shift can end
		/// </summary>
		/// <value>This is the earliest time a shift can end</value>
		[DataMember(Name = "earliestStopTimeMinutesFromMidnight", EmitDefaultValue = false)]
		public int? EarliestStopTimeMinutesFromMidnight { get; set; }



		/// <summary>
		/// Increment in offset minutes that would contribute to different possible start times for the shift. Used if flexibleStartTime &#x3D;&#x3D; true
		/// </summary>
		/// <value>Increment in offset minutes that would contribute to different possible start times for the shift. Used if flexibleStartTime &#x3D;&#x3D; true</value>
		[DataMember(Name = "startIncrementMinutes", EmitDefaultValue = false)]
		public int? StartIncrementMinutes { get; set; }



		/// <summary>
		/// Whether the paid time setting for the shift is flexible
		/// </summary>
		/// <value>Whether the paid time setting for the shift is flexible</value>
		[DataMember(Name = "flexiblePaidTime", EmitDefaultValue = false)]
		public bool? FlexiblePaidTime { get; set; }



		/// <summary>
		/// Exact paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; false
		/// </summary>
		/// <value>Exact paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; false</value>
		[DataMember(Name = "exactPaidTimeMinutes", EmitDefaultValue = false)]
		public int? ExactPaidTimeMinutes { get; set; }



		/// <summary>
		/// Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true
		/// </summary>
		/// <value>Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true</value>
		[DataMember(Name = "minimumPaidTimeMinutes", EmitDefaultValue = false)]
		public int? MinimumPaidTimeMinutes { get; set; }



		/// <summary>
		/// Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true
		/// </summary>
		/// <value>Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true</value>
		[DataMember(Name = "maximumPaidTimeMinutes", EmitDefaultValue = false)]
		public int? MaximumPaidTimeMinutes { get; set; }



		/// <summary>
		/// Whether the contiguous time constraint for the shift is enabled
		/// </summary>
		/// <value>Whether the contiguous time constraint for the shift is enabled</value>
		[DataMember(Name = "constrainContiguousWorkTime", EmitDefaultValue = false)]
		public bool? ConstrainContiguousWorkTime { get; set; }



		/// <summary>
		/// Minimum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true
		/// </summary>
		/// <value>Minimum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true</value>
		[DataMember(Name = "minimumContiguousWorkTimeMinutes", EmitDefaultValue = false)]
		public int? MinimumContiguousWorkTimeMinutes { get; set; }



		/// <summary>
		/// Maximum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true
		/// </summary>
		/// <value>Maximum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime &#x3D;&#x3D; true</value>
		[DataMember(Name = "maximumContiguousWorkTimeMinutes", EmitDefaultValue = false)]
		public int? MaximumContiguousWorkTimeMinutes { get; set; }



		/// <summary>
		/// Whether day off rule is enabled
		/// </summary>
		/// <value>Whether day off rule is enabled</value>
		[DataMember(Name = "constrainDayOff", EmitDefaultValue = false)]
		public bool? ConstrainDayOff { get; set; }





		/// <summary>
		/// Planning period constraints
		/// </summary>
		/// <value>Planning period constraints</value>
		[DataMember(Name = "planningPeriodConstraints", EmitDefaultValue = false)]
		public PlanningPeriodShiftConstraints PlanningPeriodConstraints { get; set; }



		/// <summary>
		/// Activities configured for this shift
		/// </summary>
		/// <value>Activities configured for this shift</value>
		[DataMember(Name = "activities", EmitDefaultValue = false)]
		public List<CreateWorkPlanActivity> Activities { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateWorkPlanShift {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Days: ").Append(Days).Append("\n");
			sb.Append("  FlexibleStartTime: ").Append(FlexibleStartTime).Append("\n");
			sb.Append("  ExactStartTimeMinutesFromMidnight: ").Append(ExactStartTimeMinutesFromMidnight).Append("\n");
			sb.Append("  EarliestStartTimeMinutesFromMidnight: ").Append(EarliestStartTimeMinutesFromMidnight).Append("\n");
			sb.Append("  LatestStartTimeMinutesFromMidnight: ").Append(LatestStartTimeMinutesFromMidnight).Append("\n");
			sb.Append("  ConstrainStopTime: ").Append(ConstrainStopTime).Append("\n");
			sb.Append("  ConstrainLatestStopTime: ").Append(ConstrainLatestStopTime).Append("\n");
			sb.Append("  LatestStopTimeMinutesFromMidnight: ").Append(LatestStopTimeMinutesFromMidnight).Append("\n");
			sb.Append("  ConstrainEarliestStopTime: ").Append(ConstrainEarliestStopTime).Append("\n");
			sb.Append("  EarliestStopTimeMinutesFromMidnight: ").Append(EarliestStopTimeMinutesFromMidnight).Append("\n");
			sb.Append("  StartIncrementMinutes: ").Append(StartIncrementMinutes).Append("\n");
			sb.Append("  FlexiblePaidTime: ").Append(FlexiblePaidTime).Append("\n");
			sb.Append("  ExactPaidTimeMinutes: ").Append(ExactPaidTimeMinutes).Append("\n");
			sb.Append("  MinimumPaidTimeMinutes: ").Append(MinimumPaidTimeMinutes).Append("\n");
			sb.Append("  MaximumPaidTimeMinutes: ").Append(MaximumPaidTimeMinutes).Append("\n");
			sb.Append("  ConstrainContiguousWorkTime: ").Append(ConstrainContiguousWorkTime).Append("\n");
			sb.Append("  MinimumContiguousWorkTimeMinutes: ").Append(MinimumContiguousWorkTimeMinutes).Append("\n");
			sb.Append("  MaximumContiguousWorkTimeMinutes: ").Append(MaximumContiguousWorkTimeMinutes).Append("\n");
			sb.Append("  ConstrainDayOff: ").Append(ConstrainDayOff).Append("\n");
			sb.Append("  DayOffRule: ").Append(DayOffRule).Append("\n");
			sb.Append("  PlanningPeriodConstraints: ").Append(PlanningPeriodConstraints).Append("\n");
			sb.Append("  Activities: ").Append(Activities).Append("\n");
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
			return this.Equals(obj as CreateWorkPlanShift);
		}

		/// <summary>
		/// Returns true if CreateWorkPlanShift instances are equal
		/// </summary>
		/// <param name="other">Instance of CreateWorkPlanShift to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreateWorkPlanShift other)
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
					this.Days == other.Days ||
					this.Days != null &&
					this.Days.Equals(other.Days)
				) &&
				(
					this.FlexibleStartTime == other.FlexibleStartTime ||
					this.FlexibleStartTime != null &&
					this.FlexibleStartTime.Equals(other.FlexibleStartTime)
				) &&
				(
					this.ExactStartTimeMinutesFromMidnight == other.ExactStartTimeMinutesFromMidnight ||
					this.ExactStartTimeMinutesFromMidnight != null &&
					this.ExactStartTimeMinutesFromMidnight.Equals(other.ExactStartTimeMinutesFromMidnight)
				) &&
				(
					this.EarliestStartTimeMinutesFromMidnight == other.EarliestStartTimeMinutesFromMidnight ||
					this.EarliestStartTimeMinutesFromMidnight != null &&
					this.EarliestStartTimeMinutesFromMidnight.Equals(other.EarliestStartTimeMinutesFromMidnight)
				) &&
				(
					this.LatestStartTimeMinutesFromMidnight == other.LatestStartTimeMinutesFromMidnight ||
					this.LatestStartTimeMinutesFromMidnight != null &&
					this.LatestStartTimeMinutesFromMidnight.Equals(other.LatestStartTimeMinutesFromMidnight)
				) &&
				(
					this.ConstrainStopTime == other.ConstrainStopTime ||
					this.ConstrainStopTime != null &&
					this.ConstrainStopTime.Equals(other.ConstrainStopTime)
				) &&
				(
					this.ConstrainLatestStopTime == other.ConstrainLatestStopTime ||
					this.ConstrainLatestStopTime != null &&
					this.ConstrainLatestStopTime.Equals(other.ConstrainLatestStopTime)
				) &&
				(
					this.LatestStopTimeMinutesFromMidnight == other.LatestStopTimeMinutesFromMidnight ||
					this.LatestStopTimeMinutesFromMidnight != null &&
					this.LatestStopTimeMinutesFromMidnight.Equals(other.LatestStopTimeMinutesFromMidnight)
				) &&
				(
					this.ConstrainEarliestStopTime == other.ConstrainEarliestStopTime ||
					this.ConstrainEarliestStopTime != null &&
					this.ConstrainEarliestStopTime.Equals(other.ConstrainEarliestStopTime)
				) &&
				(
					this.EarliestStopTimeMinutesFromMidnight == other.EarliestStopTimeMinutesFromMidnight ||
					this.EarliestStopTimeMinutesFromMidnight != null &&
					this.EarliestStopTimeMinutesFromMidnight.Equals(other.EarliestStopTimeMinutesFromMidnight)
				) &&
				(
					this.StartIncrementMinutes == other.StartIncrementMinutes ||
					this.StartIncrementMinutes != null &&
					this.StartIncrementMinutes.Equals(other.StartIncrementMinutes)
				) &&
				(
					this.FlexiblePaidTime == other.FlexiblePaidTime ||
					this.FlexiblePaidTime != null &&
					this.FlexiblePaidTime.Equals(other.FlexiblePaidTime)
				) &&
				(
					this.ExactPaidTimeMinutes == other.ExactPaidTimeMinutes ||
					this.ExactPaidTimeMinutes != null &&
					this.ExactPaidTimeMinutes.Equals(other.ExactPaidTimeMinutes)
				) &&
				(
					this.MinimumPaidTimeMinutes == other.MinimumPaidTimeMinutes ||
					this.MinimumPaidTimeMinutes != null &&
					this.MinimumPaidTimeMinutes.Equals(other.MinimumPaidTimeMinutes)
				) &&
				(
					this.MaximumPaidTimeMinutes == other.MaximumPaidTimeMinutes ||
					this.MaximumPaidTimeMinutes != null &&
					this.MaximumPaidTimeMinutes.Equals(other.MaximumPaidTimeMinutes)
				) &&
				(
					this.ConstrainContiguousWorkTime == other.ConstrainContiguousWorkTime ||
					this.ConstrainContiguousWorkTime != null &&
					this.ConstrainContiguousWorkTime.Equals(other.ConstrainContiguousWorkTime)
				) &&
				(
					this.MinimumContiguousWorkTimeMinutes == other.MinimumContiguousWorkTimeMinutes ||
					this.MinimumContiguousWorkTimeMinutes != null &&
					this.MinimumContiguousWorkTimeMinutes.Equals(other.MinimumContiguousWorkTimeMinutes)
				) &&
				(
					this.MaximumContiguousWorkTimeMinutes == other.MaximumContiguousWorkTimeMinutes ||
					this.MaximumContiguousWorkTimeMinutes != null &&
					this.MaximumContiguousWorkTimeMinutes.Equals(other.MaximumContiguousWorkTimeMinutes)
				) &&
				(
					this.ConstrainDayOff == other.ConstrainDayOff ||
					this.ConstrainDayOff != null &&
					this.ConstrainDayOff.Equals(other.ConstrainDayOff)
				) &&
				(
					this.DayOffRule == other.DayOffRule ||
					this.DayOffRule != null &&
					this.DayOffRule.Equals(other.DayOffRule)
				) &&
				(
					this.PlanningPeriodConstraints == other.PlanningPeriodConstraints ||
					this.PlanningPeriodConstraints != null &&
					this.PlanningPeriodConstraints.Equals(other.PlanningPeriodConstraints)
				) &&
				(
					this.Activities == other.Activities ||
					this.Activities != null &&
					this.Activities.SequenceEqual(other.Activities)
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

				if (this.Days != null)
					hash = hash * 59 + this.Days.GetHashCode();

				if (this.FlexibleStartTime != null)
					hash = hash * 59 + this.FlexibleStartTime.GetHashCode();

				if (this.ExactStartTimeMinutesFromMidnight != null)
					hash = hash * 59 + this.ExactStartTimeMinutesFromMidnight.GetHashCode();

				if (this.EarliestStartTimeMinutesFromMidnight != null)
					hash = hash * 59 + this.EarliestStartTimeMinutesFromMidnight.GetHashCode();

				if (this.LatestStartTimeMinutesFromMidnight != null)
					hash = hash * 59 + this.LatestStartTimeMinutesFromMidnight.GetHashCode();

				if (this.ConstrainStopTime != null)
					hash = hash * 59 + this.ConstrainStopTime.GetHashCode();

				if (this.ConstrainLatestStopTime != null)
					hash = hash * 59 + this.ConstrainLatestStopTime.GetHashCode();

				if (this.LatestStopTimeMinutesFromMidnight != null)
					hash = hash * 59 + this.LatestStopTimeMinutesFromMidnight.GetHashCode();

				if (this.ConstrainEarliestStopTime != null)
					hash = hash * 59 + this.ConstrainEarliestStopTime.GetHashCode();

				if (this.EarliestStopTimeMinutesFromMidnight != null)
					hash = hash * 59 + this.EarliestStopTimeMinutesFromMidnight.GetHashCode();

				if (this.StartIncrementMinutes != null)
					hash = hash * 59 + this.StartIncrementMinutes.GetHashCode();

				if (this.FlexiblePaidTime != null)
					hash = hash * 59 + this.FlexiblePaidTime.GetHashCode();

				if (this.ExactPaidTimeMinutes != null)
					hash = hash * 59 + this.ExactPaidTimeMinutes.GetHashCode();

				if (this.MinimumPaidTimeMinutes != null)
					hash = hash * 59 + this.MinimumPaidTimeMinutes.GetHashCode();

				if (this.MaximumPaidTimeMinutes != null)
					hash = hash * 59 + this.MaximumPaidTimeMinutes.GetHashCode();

				if (this.ConstrainContiguousWorkTime != null)
					hash = hash * 59 + this.ConstrainContiguousWorkTime.GetHashCode();

				if (this.MinimumContiguousWorkTimeMinutes != null)
					hash = hash * 59 + this.MinimumContiguousWorkTimeMinutes.GetHashCode();

				if (this.MaximumContiguousWorkTimeMinutes != null)
					hash = hash * 59 + this.MaximumContiguousWorkTimeMinutes.GetHashCode();

				if (this.ConstrainDayOff != null)
					hash = hash * 59 + this.ConstrainDayOff.GetHashCode();

				if (this.DayOffRule != null)
					hash = hash * 59 + this.DayOffRule.GetHashCode();

				if (this.PlanningPeriodConstraints != null)
					hash = hash * 59 + this.PlanningPeriodConstraints.GetHashCode();

				if (this.Activities != null)
					hash = hash * 59 + this.Activities.GetHashCode();

				return hash;
			}
		}
	}

}
