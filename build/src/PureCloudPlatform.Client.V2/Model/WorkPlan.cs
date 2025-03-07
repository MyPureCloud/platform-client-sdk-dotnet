using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// WorkPlan
    /// </summary>
    [DataContract]
    public partial class WorkPlan :  IEquatable<WorkPlan>
    {
        /// <summary>
        /// This constraint ensures that an agent starts each workday within a user-defined time threshold
        /// </summary>
        /// <value>This constraint ensures that an agent starts each workday within a user-defined time threshold</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ShiftStartVarianceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Shiftstart for "ShiftStart"
            /// </summary>
            [EnumMember(Value = "ShiftStart")]
            Shiftstart,
            
            /// <summary>
            /// Enum Shiftstartandpaidduration for "ShiftStartAndPaidDuration"
            /// </summary>
            [EnumMember(Value = "ShiftStartAndPaidDuration")]
            Shiftstartandpaidduration
        }
        /// <summary>
        /// This constraint ensures that an agent starts each workday within a user-defined time threshold
        /// </summary>
        /// <value>This constraint ensures that an agent starts each workday within a user-defined time threshold</value>
        [DataMember(Name="shiftStartVarianceType", EmitDefaultValue=false)]
        public ShiftStartVarianceTypeEnum? ShiftStartVarianceType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlan" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Enabled">Whether the work plan is enabled for scheduling.</param>
        /// <param name="ConstrainWeeklyPaidTime">Whether the weekly paid time constraint is enabled for this work plan.</param>
        /// <param name="FlexibleWeeklyPaidTime">Whether the weekly paid time constraint is flexible for this work plan.</param>
        /// <param name="WeeklyExactPaidMinutes">Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false.</param>
        /// <param name="WeeklyMinimumPaidMinutes">Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true.</param>
        /// <param name="WeeklyMaximumPaidMinutes">Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true.</param>
        /// <param name="ConstrainPaidTimeGranularity">Whether paid time granularity is constrained for this work plan.</param>
        /// <param name="PaidTimeGranularityMinutes">Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity &#x3D;&#x3D; true.</param>
        /// <param name="ConstrainMinimumTimeBetweenShifts">Whether the minimum time between shifts constraint is enabled for this work plan.</param>
        /// <param name="MinimumTimeBetweenShiftsMinutes">Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts &#x3D;&#x3D; true.</param>
        /// <param name="MaximumDays">Maximum number days in a week allowed to be scheduled for this work plan.</param>
        /// <param name="MinimumConsecutiveNonWorkingMinutesPerWeek">Minimum amount of consecutive non working minutes per week that agents who are assigned this work plan are allowed to have off.</param>
        /// <param name="ConstrainMaximumConsecutiveWorkingWeekends">Whether to constrain the maximum consecutive working weekends.</param>
        /// <param name="MaximumConsecutiveWorkingWeekends">The maximum number of consecutive weekends that agents who are assigned to this work plan are allowed to work.</param>
        /// <param name="MinimumWorkingDaysPerWeek">The minimum number of days that agents assigned to a work plan must work per week.</param>
        /// <param name="ConstrainMaximumConsecutiveWorkingDays">Whether to constrain the maximum consecutive working days.</param>
        /// <param name="MaximumConsecutiveWorkingDays">The maximum number of consecutive days that agents assigned to this work plan are allowed to work. Used if constrainMaximumConsecutiveWorkingDays &#x3D;&#x3D; true.</param>
        /// <param name="MinimumShiftStartDistanceMinutes">The time period in minutes for the duration between the start times of two consecutive working days.</param>
        /// <param name="MinimumDaysOffPerPlanningPeriod">Minimum days off in the planning period.</param>
        /// <param name="MaximumDaysOffPerPlanningPeriod">Maximum days off in the planning period.</param>
        /// <param name="MinimumPaidMinutesPerPlanningPeriod">Minimum paid minutes in the planning period.</param>
        /// <param name="MaximumPaidMinutesPerPlanningPeriod">Maximum paid minutes in the planning period.</param>
        /// <param name="OptionalDays">Optional days to schedule for this work plan.</param>
        /// <param name="ShiftStartVarianceType">This constraint ensures that an agent starts each workday within a user-defined time threshold.</param>
        /// <param name="ShiftStartVariances">Variance in minutes among start times of shifts in this work plan.</param>
        /// <param name="Shifts">Shifts in this work plan.</param>
        /// <param name="Agents">Agents in this work plan.</param>
        /// <param name="AgentCount">Number of agents in this work plan.</param>
        /// <param name="Metadata">Version metadata for this work plan (required).</param>
        public WorkPlan(string Name = null, bool? Enabled = null, bool? ConstrainWeeklyPaidTime = null, bool? FlexibleWeeklyPaidTime = null, int? WeeklyExactPaidMinutes = null, int? WeeklyMinimumPaidMinutes = null, int? WeeklyMaximumPaidMinutes = null, bool? ConstrainPaidTimeGranularity = null, int? PaidTimeGranularityMinutes = null, bool? ConstrainMinimumTimeBetweenShifts = null, int? MinimumTimeBetweenShiftsMinutes = null, int? MaximumDays = null, int? MinimumConsecutiveNonWorkingMinutesPerWeek = null, bool? ConstrainMaximumConsecutiveWorkingWeekends = null, int? MaximumConsecutiveWorkingWeekends = null, int? MinimumWorkingDaysPerWeek = null, bool? ConstrainMaximumConsecutiveWorkingDays = null, int? MaximumConsecutiveWorkingDays = null, int? MinimumShiftStartDistanceMinutes = null, int? MinimumDaysOffPerPlanningPeriod = null, int? MaximumDaysOffPerPlanningPeriod = null, int? MinimumPaidMinutesPerPlanningPeriod = null, int? MaximumPaidMinutesPerPlanningPeriod = null, SetWrapperDayOfWeek OptionalDays = null, ShiftStartVarianceTypeEnum? ShiftStartVarianceType = null, ListWrapperShiftStartVariance ShiftStartVariances = null, List<WorkPlanShift> Shifts = null, List<DeletableUserReference> Agents = null, int? AgentCount = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Name = Name;
            this.Enabled = Enabled;
            this.ConstrainWeeklyPaidTime = ConstrainWeeklyPaidTime;
            this.FlexibleWeeklyPaidTime = FlexibleWeeklyPaidTime;
            this.WeeklyExactPaidMinutes = WeeklyExactPaidMinutes;
            this.WeeklyMinimumPaidMinutes = WeeklyMinimumPaidMinutes;
            this.WeeklyMaximumPaidMinutes = WeeklyMaximumPaidMinutes;
            this.ConstrainPaidTimeGranularity = ConstrainPaidTimeGranularity;
            this.PaidTimeGranularityMinutes = PaidTimeGranularityMinutes;
            this.ConstrainMinimumTimeBetweenShifts = ConstrainMinimumTimeBetweenShifts;
            this.MinimumTimeBetweenShiftsMinutes = MinimumTimeBetweenShiftsMinutes;
            this.MaximumDays = MaximumDays;
            this.MinimumConsecutiveNonWorkingMinutesPerWeek = MinimumConsecutiveNonWorkingMinutesPerWeek;
            this.ConstrainMaximumConsecutiveWorkingWeekends = ConstrainMaximumConsecutiveWorkingWeekends;
            this.MaximumConsecutiveWorkingWeekends = MaximumConsecutiveWorkingWeekends;
            this.MinimumWorkingDaysPerWeek = MinimumWorkingDaysPerWeek;
            this.ConstrainMaximumConsecutiveWorkingDays = ConstrainMaximumConsecutiveWorkingDays;
            this.MaximumConsecutiveWorkingDays = MaximumConsecutiveWorkingDays;
            this.MinimumShiftStartDistanceMinutes = MinimumShiftStartDistanceMinutes;
            this.MinimumDaysOffPerPlanningPeriod = MinimumDaysOffPerPlanningPeriod;
            this.MaximumDaysOffPerPlanningPeriod = MaximumDaysOffPerPlanningPeriod;
            this.MinimumPaidMinutesPerPlanningPeriod = MinimumPaidMinutesPerPlanningPeriod;
            this.MaximumPaidMinutesPerPlanningPeriod = MaximumPaidMinutesPerPlanningPeriod;
            this.OptionalDays = OptionalDays;
            this.ShiftStartVarianceType = ShiftStartVarianceType;
            this.ShiftStartVariances = ShiftStartVariances;
            this.Shifts = Shifts;
            this.Agents = Agents;
            this.AgentCount = AgentCount;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Whether the work plan is enabled for scheduling
        /// </summary>
        /// <value>Whether the work plan is enabled for scheduling</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Whether the work plan is valid or not
        /// </summary>
        /// <value>Whether the work plan is valid or not</value>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public bool? Valid { get; private set; }



        /// <summary>
        /// Whether the weekly paid time constraint is enabled for this work plan
        /// </summary>
        /// <value>Whether the weekly paid time constraint is enabled for this work plan</value>
        [DataMember(Name="constrainWeeklyPaidTime", EmitDefaultValue=false)]
        public bool? ConstrainWeeklyPaidTime { get; set; }



        /// <summary>
        /// Whether the weekly paid time constraint is flexible for this work plan
        /// </summary>
        /// <value>Whether the weekly paid time constraint is flexible for this work plan</value>
        [DataMember(Name="flexibleWeeklyPaidTime", EmitDefaultValue=false)]
        public bool? FlexibleWeeklyPaidTime { get; set; }



        /// <summary>
        /// Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false
        /// </summary>
        /// <value>Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false</value>
        [DataMember(Name="weeklyExactPaidMinutes", EmitDefaultValue=false)]
        public int? WeeklyExactPaidMinutes { get; set; }



        /// <summary>
        /// Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true
        /// </summary>
        /// <value>Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true</value>
        [DataMember(Name="weeklyMinimumPaidMinutes", EmitDefaultValue=false)]
        public int? WeeklyMinimumPaidMinutes { get; set; }



        /// <summary>
        /// Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true
        /// </summary>
        /// <value>Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true</value>
        [DataMember(Name="weeklyMaximumPaidMinutes", EmitDefaultValue=false)]
        public int? WeeklyMaximumPaidMinutes { get; set; }



        /// <summary>
        /// Whether paid time granularity is constrained for this work plan
        /// </summary>
        /// <value>Whether paid time granularity is constrained for this work plan</value>
        [DataMember(Name="constrainPaidTimeGranularity", EmitDefaultValue=false)]
        public bool? ConstrainPaidTimeGranularity { get; set; }



        /// <summary>
        /// Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity &#x3D;&#x3D; true
        /// </summary>
        /// <value>Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity &#x3D;&#x3D; true</value>
        [DataMember(Name="paidTimeGranularityMinutes", EmitDefaultValue=false)]
        public int? PaidTimeGranularityMinutes { get; set; }



        /// <summary>
        /// Whether the minimum time between shifts constraint is enabled for this work plan
        /// </summary>
        /// <value>Whether the minimum time between shifts constraint is enabled for this work plan</value>
        [DataMember(Name="constrainMinimumTimeBetweenShifts", EmitDefaultValue=false)]
        public bool? ConstrainMinimumTimeBetweenShifts { get; set; }



        /// <summary>
        /// Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts &#x3D;&#x3D; true
        /// </summary>
        /// <value>Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts &#x3D;&#x3D; true</value>
        [DataMember(Name="minimumTimeBetweenShiftsMinutes", EmitDefaultValue=false)]
        public int? MinimumTimeBetweenShiftsMinutes { get; set; }



        /// <summary>
        /// Maximum number days in a week allowed to be scheduled for this work plan
        /// </summary>
        /// <value>Maximum number days in a week allowed to be scheduled for this work plan</value>
        [DataMember(Name="maximumDays", EmitDefaultValue=false)]
        public int? MaximumDays { get; set; }



        /// <summary>
        /// Minimum amount of consecutive non working minutes per week that agents who are assigned this work plan are allowed to have off
        /// </summary>
        /// <value>Minimum amount of consecutive non working minutes per week that agents who are assigned this work plan are allowed to have off</value>
        [DataMember(Name="minimumConsecutiveNonWorkingMinutesPerWeek", EmitDefaultValue=false)]
        public int? MinimumConsecutiveNonWorkingMinutesPerWeek { get; set; }



        /// <summary>
        /// Whether to constrain the maximum consecutive working weekends
        /// </summary>
        /// <value>Whether to constrain the maximum consecutive working weekends</value>
        [DataMember(Name="constrainMaximumConsecutiveWorkingWeekends", EmitDefaultValue=false)]
        public bool? ConstrainMaximumConsecutiveWorkingWeekends { get; set; }



        /// <summary>
        /// The maximum number of consecutive weekends that agents who are assigned to this work plan are allowed to work
        /// </summary>
        /// <value>The maximum number of consecutive weekends that agents who are assigned to this work plan are allowed to work</value>
        [DataMember(Name="maximumConsecutiveWorkingWeekends", EmitDefaultValue=false)]
        public int? MaximumConsecutiveWorkingWeekends { get; set; }



        /// <summary>
        /// The minimum number of days that agents assigned to a work plan must work per week
        /// </summary>
        /// <value>The minimum number of days that agents assigned to a work plan must work per week</value>
        [DataMember(Name="minimumWorkingDaysPerWeek", EmitDefaultValue=false)]
        public int? MinimumWorkingDaysPerWeek { get; set; }



        /// <summary>
        /// Whether to constrain the maximum consecutive working days
        /// </summary>
        /// <value>Whether to constrain the maximum consecutive working days</value>
        [DataMember(Name="constrainMaximumConsecutiveWorkingDays", EmitDefaultValue=false)]
        public bool? ConstrainMaximumConsecutiveWorkingDays { get; set; }



        /// <summary>
        /// The maximum number of consecutive days that agents assigned to this work plan are allowed to work. Used if constrainMaximumConsecutiveWorkingDays &#x3D;&#x3D; true
        /// </summary>
        /// <value>The maximum number of consecutive days that agents assigned to this work plan are allowed to work. Used if constrainMaximumConsecutiveWorkingDays &#x3D;&#x3D; true</value>
        [DataMember(Name="maximumConsecutiveWorkingDays", EmitDefaultValue=false)]
        public int? MaximumConsecutiveWorkingDays { get; set; }



        /// <summary>
        /// The time period in minutes for the duration between the start times of two consecutive working days
        /// </summary>
        /// <value>The time period in minutes for the duration between the start times of two consecutive working days</value>
        [DataMember(Name="minimumShiftStartDistanceMinutes", EmitDefaultValue=false)]
        public int? MinimumShiftStartDistanceMinutes { get; set; }



        /// <summary>
        /// Minimum days off in the planning period
        /// </summary>
        /// <value>Minimum days off in the planning period</value>
        [DataMember(Name="minimumDaysOffPerPlanningPeriod", EmitDefaultValue=false)]
        public int? MinimumDaysOffPerPlanningPeriod { get; set; }



        /// <summary>
        /// Maximum days off in the planning period
        /// </summary>
        /// <value>Maximum days off in the planning period</value>
        [DataMember(Name="maximumDaysOffPerPlanningPeriod", EmitDefaultValue=false)]
        public int? MaximumDaysOffPerPlanningPeriod { get; set; }



        /// <summary>
        /// Minimum paid minutes in the planning period
        /// </summary>
        /// <value>Minimum paid minutes in the planning period</value>
        [DataMember(Name="minimumPaidMinutesPerPlanningPeriod", EmitDefaultValue=false)]
        public int? MinimumPaidMinutesPerPlanningPeriod { get; set; }



        /// <summary>
        /// Maximum paid minutes in the planning period
        /// </summary>
        /// <value>Maximum paid minutes in the planning period</value>
        [DataMember(Name="maximumPaidMinutesPerPlanningPeriod", EmitDefaultValue=false)]
        public int? MaximumPaidMinutesPerPlanningPeriod { get; set; }



        /// <summary>
        /// Optional days to schedule for this work plan
        /// </summary>
        /// <value>Optional days to schedule for this work plan</value>
        [DataMember(Name="optionalDays", EmitDefaultValue=false)]
        public SetWrapperDayOfWeek OptionalDays { get; set; }





        /// <summary>
        /// Variance in minutes among start times of shifts in this work plan
        /// </summary>
        /// <value>Variance in minutes among start times of shifts in this work plan</value>
        [DataMember(Name="shiftStartVariances", EmitDefaultValue=false)]
        public ListWrapperShiftStartVariance ShiftStartVariances { get; set; }



        /// <summary>
        /// Shifts in this work plan
        /// </summary>
        /// <value>Shifts in this work plan</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<WorkPlanShift> Shifts { get; set; }



        /// <summary>
        /// Agents in this work plan
        /// </summary>
        /// <value>Agents in this work plan</value>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<DeletableUserReference> Agents { get; set; }



        /// <summary>
        /// Number of agents in this work plan
        /// </summary>
        /// <value>Number of agents in this work plan</value>
        [DataMember(Name="agentCount", EmitDefaultValue=false)]
        public int? AgentCount { get; set; }



        /// <summary>
        /// Version metadata for this work plan
        /// </summary>
        /// <value>Version metadata for this work plan</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlan {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  ConstrainWeeklyPaidTime: ").Append(ConstrainWeeklyPaidTime).Append("\n");
            sb.Append("  FlexibleWeeklyPaidTime: ").Append(FlexibleWeeklyPaidTime).Append("\n");
            sb.Append("  WeeklyExactPaidMinutes: ").Append(WeeklyExactPaidMinutes).Append("\n");
            sb.Append("  WeeklyMinimumPaidMinutes: ").Append(WeeklyMinimumPaidMinutes).Append("\n");
            sb.Append("  WeeklyMaximumPaidMinutes: ").Append(WeeklyMaximumPaidMinutes).Append("\n");
            sb.Append("  ConstrainPaidTimeGranularity: ").Append(ConstrainPaidTimeGranularity).Append("\n");
            sb.Append("  PaidTimeGranularityMinutes: ").Append(PaidTimeGranularityMinutes).Append("\n");
            sb.Append("  ConstrainMinimumTimeBetweenShifts: ").Append(ConstrainMinimumTimeBetweenShifts).Append("\n");
            sb.Append("  MinimumTimeBetweenShiftsMinutes: ").Append(MinimumTimeBetweenShiftsMinutes).Append("\n");
            sb.Append("  MaximumDays: ").Append(MaximumDays).Append("\n");
            sb.Append("  MinimumConsecutiveNonWorkingMinutesPerWeek: ").Append(MinimumConsecutiveNonWorkingMinutesPerWeek).Append("\n");
            sb.Append("  ConstrainMaximumConsecutiveWorkingWeekends: ").Append(ConstrainMaximumConsecutiveWorkingWeekends).Append("\n");
            sb.Append("  MaximumConsecutiveWorkingWeekends: ").Append(MaximumConsecutiveWorkingWeekends).Append("\n");
            sb.Append("  MinimumWorkingDaysPerWeek: ").Append(MinimumWorkingDaysPerWeek).Append("\n");
            sb.Append("  ConstrainMaximumConsecutiveWorkingDays: ").Append(ConstrainMaximumConsecutiveWorkingDays).Append("\n");
            sb.Append("  MaximumConsecutiveWorkingDays: ").Append(MaximumConsecutiveWorkingDays).Append("\n");
            sb.Append("  MinimumShiftStartDistanceMinutes: ").Append(MinimumShiftStartDistanceMinutes).Append("\n");
            sb.Append("  MinimumDaysOffPerPlanningPeriod: ").Append(MinimumDaysOffPerPlanningPeriod).Append("\n");
            sb.Append("  MaximumDaysOffPerPlanningPeriod: ").Append(MaximumDaysOffPerPlanningPeriod).Append("\n");
            sb.Append("  MinimumPaidMinutesPerPlanningPeriod: ").Append(MinimumPaidMinutesPerPlanningPeriod).Append("\n");
            sb.Append("  MaximumPaidMinutesPerPlanningPeriod: ").Append(MaximumPaidMinutesPerPlanningPeriod).Append("\n");
            sb.Append("  OptionalDays: ").Append(OptionalDays).Append("\n");
            sb.Append("  ShiftStartVarianceType: ").Append(ShiftStartVarianceType).Append("\n");
            sb.Append("  ShiftStartVariances: ").Append(ShiftStartVariances).Append("\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
            sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
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
            return this.Equals(obj as WorkPlan);
        }

        /// <summary>
        /// Returns true if WorkPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlan other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Valid == other.Valid ||
                    this.Valid != null &&
                    this.Valid.Equals(other.Valid)
                ) &&
                (
                    this.ConstrainWeeklyPaidTime == other.ConstrainWeeklyPaidTime ||
                    this.ConstrainWeeklyPaidTime != null &&
                    this.ConstrainWeeklyPaidTime.Equals(other.ConstrainWeeklyPaidTime)
                ) &&
                (
                    this.FlexibleWeeklyPaidTime == other.FlexibleWeeklyPaidTime ||
                    this.FlexibleWeeklyPaidTime != null &&
                    this.FlexibleWeeklyPaidTime.Equals(other.FlexibleWeeklyPaidTime)
                ) &&
                (
                    this.WeeklyExactPaidMinutes == other.WeeklyExactPaidMinutes ||
                    this.WeeklyExactPaidMinutes != null &&
                    this.WeeklyExactPaidMinutes.Equals(other.WeeklyExactPaidMinutes)
                ) &&
                (
                    this.WeeklyMinimumPaidMinutes == other.WeeklyMinimumPaidMinutes ||
                    this.WeeklyMinimumPaidMinutes != null &&
                    this.WeeklyMinimumPaidMinutes.Equals(other.WeeklyMinimumPaidMinutes)
                ) &&
                (
                    this.WeeklyMaximumPaidMinutes == other.WeeklyMaximumPaidMinutes ||
                    this.WeeklyMaximumPaidMinutes != null &&
                    this.WeeklyMaximumPaidMinutes.Equals(other.WeeklyMaximumPaidMinutes)
                ) &&
                (
                    this.ConstrainPaidTimeGranularity == other.ConstrainPaidTimeGranularity ||
                    this.ConstrainPaidTimeGranularity != null &&
                    this.ConstrainPaidTimeGranularity.Equals(other.ConstrainPaidTimeGranularity)
                ) &&
                (
                    this.PaidTimeGranularityMinutes == other.PaidTimeGranularityMinutes ||
                    this.PaidTimeGranularityMinutes != null &&
                    this.PaidTimeGranularityMinutes.Equals(other.PaidTimeGranularityMinutes)
                ) &&
                (
                    this.ConstrainMinimumTimeBetweenShifts == other.ConstrainMinimumTimeBetweenShifts ||
                    this.ConstrainMinimumTimeBetweenShifts != null &&
                    this.ConstrainMinimumTimeBetweenShifts.Equals(other.ConstrainMinimumTimeBetweenShifts)
                ) &&
                (
                    this.MinimumTimeBetweenShiftsMinutes == other.MinimumTimeBetweenShiftsMinutes ||
                    this.MinimumTimeBetweenShiftsMinutes != null &&
                    this.MinimumTimeBetweenShiftsMinutes.Equals(other.MinimumTimeBetweenShiftsMinutes)
                ) &&
                (
                    this.MaximumDays == other.MaximumDays ||
                    this.MaximumDays != null &&
                    this.MaximumDays.Equals(other.MaximumDays)
                ) &&
                (
                    this.MinimumConsecutiveNonWorkingMinutesPerWeek == other.MinimumConsecutiveNonWorkingMinutesPerWeek ||
                    this.MinimumConsecutiveNonWorkingMinutesPerWeek != null &&
                    this.MinimumConsecutiveNonWorkingMinutesPerWeek.Equals(other.MinimumConsecutiveNonWorkingMinutesPerWeek)
                ) &&
                (
                    this.ConstrainMaximumConsecutiveWorkingWeekends == other.ConstrainMaximumConsecutiveWorkingWeekends ||
                    this.ConstrainMaximumConsecutiveWorkingWeekends != null &&
                    this.ConstrainMaximumConsecutiveWorkingWeekends.Equals(other.ConstrainMaximumConsecutiveWorkingWeekends)
                ) &&
                (
                    this.MaximumConsecutiveWorkingWeekends == other.MaximumConsecutiveWorkingWeekends ||
                    this.MaximumConsecutiveWorkingWeekends != null &&
                    this.MaximumConsecutiveWorkingWeekends.Equals(other.MaximumConsecutiveWorkingWeekends)
                ) &&
                (
                    this.MinimumWorkingDaysPerWeek == other.MinimumWorkingDaysPerWeek ||
                    this.MinimumWorkingDaysPerWeek != null &&
                    this.MinimumWorkingDaysPerWeek.Equals(other.MinimumWorkingDaysPerWeek)
                ) &&
                (
                    this.ConstrainMaximumConsecutiveWorkingDays == other.ConstrainMaximumConsecutiveWorkingDays ||
                    this.ConstrainMaximumConsecutiveWorkingDays != null &&
                    this.ConstrainMaximumConsecutiveWorkingDays.Equals(other.ConstrainMaximumConsecutiveWorkingDays)
                ) &&
                (
                    this.MaximumConsecutiveWorkingDays == other.MaximumConsecutiveWorkingDays ||
                    this.MaximumConsecutiveWorkingDays != null &&
                    this.MaximumConsecutiveWorkingDays.Equals(other.MaximumConsecutiveWorkingDays)
                ) &&
                (
                    this.MinimumShiftStartDistanceMinutes == other.MinimumShiftStartDistanceMinutes ||
                    this.MinimumShiftStartDistanceMinutes != null &&
                    this.MinimumShiftStartDistanceMinutes.Equals(other.MinimumShiftStartDistanceMinutes)
                ) &&
                (
                    this.MinimumDaysOffPerPlanningPeriod == other.MinimumDaysOffPerPlanningPeriod ||
                    this.MinimumDaysOffPerPlanningPeriod != null &&
                    this.MinimumDaysOffPerPlanningPeriod.Equals(other.MinimumDaysOffPerPlanningPeriod)
                ) &&
                (
                    this.MaximumDaysOffPerPlanningPeriod == other.MaximumDaysOffPerPlanningPeriod ||
                    this.MaximumDaysOffPerPlanningPeriod != null &&
                    this.MaximumDaysOffPerPlanningPeriod.Equals(other.MaximumDaysOffPerPlanningPeriod)
                ) &&
                (
                    this.MinimumPaidMinutesPerPlanningPeriod == other.MinimumPaidMinutesPerPlanningPeriod ||
                    this.MinimumPaidMinutesPerPlanningPeriod != null &&
                    this.MinimumPaidMinutesPerPlanningPeriod.Equals(other.MinimumPaidMinutesPerPlanningPeriod)
                ) &&
                (
                    this.MaximumPaidMinutesPerPlanningPeriod == other.MaximumPaidMinutesPerPlanningPeriod ||
                    this.MaximumPaidMinutesPerPlanningPeriod != null &&
                    this.MaximumPaidMinutesPerPlanningPeriod.Equals(other.MaximumPaidMinutesPerPlanningPeriod)
                ) &&
                (
                    this.OptionalDays == other.OptionalDays ||
                    this.OptionalDays != null &&
                    this.OptionalDays.Equals(other.OptionalDays)
                ) &&
                (
                    this.ShiftStartVarianceType == other.ShiftStartVarianceType ||
                    this.ShiftStartVarianceType != null &&
                    this.ShiftStartVarianceType.Equals(other.ShiftStartVarianceType)
                ) &&
                (
                    this.ShiftStartVariances == other.ShiftStartVariances ||
                    this.ShiftStartVariances != null &&
                    this.ShiftStartVariances.Equals(other.ShiftStartVariances)
                ) &&
                (
                    this.Shifts == other.Shifts ||
                    this.Shifts != null &&
                    this.Shifts.SequenceEqual(other.Shifts)
                ) &&
                (
                    this.Agents == other.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(other.Agents)
                ) &&
                (
                    this.AgentCount == other.AgentCount ||
                    this.AgentCount != null &&
                    this.AgentCount.Equals(other.AgentCount)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Valid != null)
                    hash = hash * 59 + this.Valid.GetHashCode();

                if (this.ConstrainWeeklyPaidTime != null)
                    hash = hash * 59 + this.ConstrainWeeklyPaidTime.GetHashCode();

                if (this.FlexibleWeeklyPaidTime != null)
                    hash = hash * 59 + this.FlexibleWeeklyPaidTime.GetHashCode();

                if (this.WeeklyExactPaidMinutes != null)
                    hash = hash * 59 + this.WeeklyExactPaidMinutes.GetHashCode();

                if (this.WeeklyMinimumPaidMinutes != null)
                    hash = hash * 59 + this.WeeklyMinimumPaidMinutes.GetHashCode();

                if (this.WeeklyMaximumPaidMinutes != null)
                    hash = hash * 59 + this.WeeklyMaximumPaidMinutes.GetHashCode();

                if (this.ConstrainPaidTimeGranularity != null)
                    hash = hash * 59 + this.ConstrainPaidTimeGranularity.GetHashCode();

                if (this.PaidTimeGranularityMinutes != null)
                    hash = hash * 59 + this.PaidTimeGranularityMinutes.GetHashCode();

                if (this.ConstrainMinimumTimeBetweenShifts != null)
                    hash = hash * 59 + this.ConstrainMinimumTimeBetweenShifts.GetHashCode();

                if (this.MinimumTimeBetweenShiftsMinutes != null)
                    hash = hash * 59 + this.MinimumTimeBetweenShiftsMinutes.GetHashCode();

                if (this.MaximumDays != null)
                    hash = hash * 59 + this.MaximumDays.GetHashCode();

                if (this.MinimumConsecutiveNonWorkingMinutesPerWeek != null)
                    hash = hash * 59 + this.MinimumConsecutiveNonWorkingMinutesPerWeek.GetHashCode();

                if (this.ConstrainMaximumConsecutiveWorkingWeekends != null)
                    hash = hash * 59 + this.ConstrainMaximumConsecutiveWorkingWeekends.GetHashCode();

                if (this.MaximumConsecutiveWorkingWeekends != null)
                    hash = hash * 59 + this.MaximumConsecutiveWorkingWeekends.GetHashCode();

                if (this.MinimumWorkingDaysPerWeek != null)
                    hash = hash * 59 + this.MinimumWorkingDaysPerWeek.GetHashCode();

                if (this.ConstrainMaximumConsecutiveWorkingDays != null)
                    hash = hash * 59 + this.ConstrainMaximumConsecutiveWorkingDays.GetHashCode();

                if (this.MaximumConsecutiveWorkingDays != null)
                    hash = hash * 59 + this.MaximumConsecutiveWorkingDays.GetHashCode();

                if (this.MinimumShiftStartDistanceMinutes != null)
                    hash = hash * 59 + this.MinimumShiftStartDistanceMinutes.GetHashCode();

                if (this.MinimumDaysOffPerPlanningPeriod != null)
                    hash = hash * 59 + this.MinimumDaysOffPerPlanningPeriod.GetHashCode();

                if (this.MaximumDaysOffPerPlanningPeriod != null)
                    hash = hash * 59 + this.MaximumDaysOffPerPlanningPeriod.GetHashCode();

                if (this.MinimumPaidMinutesPerPlanningPeriod != null)
                    hash = hash * 59 + this.MinimumPaidMinutesPerPlanningPeriod.GetHashCode();

                if (this.MaximumPaidMinutesPerPlanningPeriod != null)
                    hash = hash * 59 + this.MaximumPaidMinutesPerPlanningPeriod.GetHashCode();

                if (this.OptionalDays != null)
                    hash = hash * 59 + this.OptionalDays.GetHashCode();

                if (this.ShiftStartVarianceType != null)
                    hash = hash * 59 + this.ShiftStartVarianceType.GetHashCode();

                if (this.ShiftStartVariances != null)
                    hash = hash * 59 + this.ShiftStartVariances.GetHashCode();

                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();

                if (this.Agents != null)
                    hash = hash * 59 + this.Agents.GetHashCode();

                if (this.AgentCount != null)
                    hash = hash * 59 + this.AgentCount.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
