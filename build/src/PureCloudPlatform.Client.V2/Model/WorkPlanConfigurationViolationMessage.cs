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
    /// WorkPlanConfigurationViolationMessage
    /// </summary>
    [DataContract]
    public partial class WorkPlanConfigurationViolationMessage :  IEquatable<WorkPlanConfigurationViolationMessage>
    {
        /// <summary>
        /// Type of configuration violation message for this work plan
        /// </summary>
        /// <value>Type of configuration violation message for this work plan</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Activitiesoverlap for "ActivitiesOverlap"
            /// </summary>
            [EnumMember(Value = "ActivitiesOverlap")]
            Activitiesoverlap,
            
            /// <summary>
            /// Enum Activityendgreaterthanshiftstop for "ActivityEndGreaterThanShiftStop"
            /// </summary>
            [EnumMember(Value = "ActivityEndGreaterThanShiftStop")]
            Activityendgreaterthanshiftstop,
            
            /// <summary>
            /// Enum Activitypaidtimegreaterthanshiftpaidtime for "ActivityPaidTimeGreaterThanShiftPaidTime"
            /// </summary>
            [EnumMember(Value = "ActivityPaidTimeGreaterThanShiftPaidTime")]
            Activitypaidtimegreaterthanshiftpaidtime,
            
            /// <summary>
            /// Enum Activitystartbeforeshiftstart for "ActivityStartBeforeShiftStart"
            /// </summary>
            [EnumMember(Value = "ActivityStartBeforeShiftStart")]
            Activitystartbeforeshiftstart,
            
            /// <summary>
            /// Enum Activitystartgreaterthanequaltoshiftstop for "ActivityStartGreaterThanEqualToShiftStop"
            /// </summary>
            [EnumMember(Value = "ActivityStartGreaterThanEqualToShiftStop")]
            Activitystartgreaterthanequaltoshiftstop,
            
            /// <summary>
            /// Enum Activitystartincrementminutesnotdivisiblebyscheduleintervalminutes for "ActivityStartIncrementMinutesNotDivisibleByScheduleIntervalMinutes"
            /// </summary>
            [EnumMember(Value = "ActivityStartIncrementMinutesNotDivisibleByScheduleIntervalMinutes")]
            Activitystartincrementminutesnotdivisiblebyscheduleintervalminutes,
            
            /// <summary>
            /// Enum Dailyexactpaidminutes for "DailyExactPaidMinutes"
            /// </summary>
            [EnumMember(Value = "DailyExactPaidMinutes")]
            Dailyexactpaidminutes,
            
            /// <summary>
            /// Enum Dailymaxtotallessthanweeklymin for "DailyMaxTotalLessThanWeeklyMin"
            /// </summary>
            [EnumMember(Value = "DailyMaxTotalLessThanWeeklyMin")]
            Dailymaxtotallessthanweeklymin,
            
            /// <summary>
            /// Enum Dailymaxtotallessthanweeklyminwithoptional for "DailyMaxTotalLessThanWeeklyMinWithOptional"
            /// </summary>
            [EnumMember(Value = "DailyMaxTotalLessThanWeeklyMinWithOptional")]
            Dailymaxtotallessthanweeklyminwithoptional,
            
            /// <summary>
            /// Enum Dailymaxtotallessthanweeklyminwithoutoptional for "DailyMaxTotalLessThanWeeklyMinWithoutOptional"
            /// </summary>
            [EnumMember(Value = "DailyMaxTotalLessThanWeeklyMinWithoutOptional")]
            Dailymaxtotallessthanweeklyminwithoutoptional,
            
            /// <summary>
            /// Enum Dailymintotalgreaterthanweeklymax for "DailyMinTotalGreaterThanWeeklyMax"
            /// </summary>
            [EnumMember(Value = "DailyMinTotalGreaterThanWeeklyMax")]
            Dailymintotalgreaterthanweeklymax,
            
            /// <summary>
            /// Enum Dailymintotalgreaterthanweeklymaxwithoptional for "DailyMinTotalGreaterThanWeeklyMaxWithOptional"
            /// </summary>
            [EnumMember(Value = "DailyMinTotalGreaterThanWeeklyMaxWithOptional")]
            Dailymintotalgreaterthanweeklymaxwithoptional,
            
            /// <summary>
            /// Enum Dailymintotalgreaterthanweeklymaxwithoutoptional for "DailyMinTotalGreaterThanWeeklyMaxWithoutOptional"
            /// </summary>
            [EnumMember(Value = "DailyMinTotalGreaterThanWeeklyMaxWithoutOptional")]
            Dailymintotalgreaterthanweeklymaxwithoutoptional,
            
            /// <summary>
            /// Enum Dailyrequireddaysgreaterthanweeklymaxdays for "DailyRequiredDaysGreaterThanWeeklyMaxDays"
            /// </summary>
            [EnumMember(Value = "DailyRequiredDaysGreaterThanWeeklyMaxDays")]
            Dailyrequireddaysgreaterthanweeklymaxdays,
            
            /// <summary>
            /// Enum Dailyshifthasnodaysselected for "DailyShiftHasNoDaysSelected"
            /// </summary>
            [EnumMember(Value = "DailyShiftHasNoDaysSelected")]
            Dailyshifthasnodaysselected,
            
            /// <summary>
            /// Enum Dailyshiftmaxpossibilitiesviolated for "DailyShiftMaxPossibilitiesViolated"
            /// </summary>
            [EnumMember(Value = "DailyShiftMaxPossibilitiesViolated")]
            Dailyshiftmaxpossibilitiesviolated,
            
            /// <summary>
            /// Enum Earliestshiftstopistoolate for "EarliestShiftStopIsTooLate"
            /// </summary>
            [EnumMember(Value = "EarliestShiftStopIsTooLate")]
            Earliestshiftstopistoolate,
            
            /// <summary>
            /// Enum Exactpaidtimenotdivisiblebygranularity for "ExactPaidTimeNotDivisibleByGranularity"
            /// </summary>
            [EnumMember(Value = "ExactPaidTimeNotDivisibleByGranularity")]
            Exactpaidtimenotdivisiblebygranularity,
            
            /// <summary>
            /// Enum Maxconsecutiveworkingdaysnomorethandoublemaxworkingdaysperweek for "MaxConsecutiveWorkingDaysNoMoreThanDoubleMaxWorkingDaysPerWeek"
            /// </summary>
            [EnumMember(Value = "MaxConsecutiveWorkingDaysNoMoreThanDoubleMaxWorkingDaysPerWeek")]
            Maxconsecutiveworkingdaysnomorethandoublemaxworkingdaysperweek,
            
            /// <summary>
            /// Enum Maxdaysoffperplanningperiodnotcorrect for "MaxDaysOffPerPlanningPeriodNotCorrect"
            /// </summary>
            [EnumMember(Value = "MaxDaysOffPerPlanningPeriodNotCorrect")]
            Maxdaysoffperplanningperiodnotcorrect,
            
            /// <summary>
            /// Enum Maxpaidtimeismorethanshiftlength for "MaxPaidTimeIsMoreThanShiftLength"
            /// </summary>
            [EnumMember(Value = "MaxPaidTimeIsMoreThanShiftLength")]
            Maxpaidtimeismorethanshiftlength,
            
            /// <summary>
            /// Enum Maxpaidtimenotdivisiblebygranularity for "MaxPaidTimeNotDivisibleByGranularity"
            /// </summary>
            [EnumMember(Value = "MaxPaidTimeNotDivisibleByGranularity")]
            Maxpaidtimenotdivisiblebygranularity,
            
            /// <summary>
            /// Enum Maxpaidtimepermonthlyplanningperiod for "MaxPaidTimePerMonthlyPlanningPeriod"
            /// </summary>
            [EnumMember(Value = "MaxPaidTimePerMonthlyPlanningPeriod")]
            Maxpaidtimepermonthlyplanningperiod,
            
            /// <summary>
            /// Enum Maxpaidtimeperplanningperiod for "MaxPaidTimePerPlanningPeriod"
            /// </summary>
            [EnumMember(Value = "MaxPaidTimePerPlanningPeriod")]
            Maxpaidtimeperplanningperiod,
            
            /// <summary>
            /// Enum Maxshifts for "MaxShifts"
            /// </summary>
            [EnumMember(Value = "MaxShifts")]
            Maxshifts,
            
            /// <summary>
            /// Enum Minpaidtimenotdivisiblebygranularity for "MinPaidTimeNotDivisibleByGranularity"
            /// </summary>
            [EnumMember(Value = "MinPaidTimeNotDivisibleByGranularity")]
            Minpaidtimenotdivisiblebygranularity,
            
            /// <summary>
            /// Enum Minpaidtimepermonthlyplanningperiod for "MinPaidTimePerMonthlyPlanningPeriod"
            /// </summary>
            [EnumMember(Value = "MinPaidTimePerMonthlyPlanningPeriod")]
            Minpaidtimepermonthlyplanningperiod,
            
            /// <summary>
            /// Enum Minpaidtimeperplanningperiod for "MinPaidTimePerPlanningPeriod"
            /// </summary>
            [EnumMember(Value = "MinPaidTimePerPlanningPeriod")]
            Minpaidtimeperplanningperiod,
            
            /// <summary>
            /// Enum Noshifts for "NoShifts"
            /// </summary>
            [EnumMember(Value = "NoShifts")]
            Noshifts,
            
            /// <summary>
            /// Enum Paidtimegreaterthanmaxworktime for "PaidTimeGreaterThanMaxWorkTime"
            /// </summary>
            [EnumMember(Value = "PaidTimeGreaterThanMaxWorkTime")]
            Paidtimegreaterthanmaxworktime,
            
            /// <summary>
            /// Enum Paidtimelessthanminworktime for "PaidTimeLessThanMinWorkTime"
            /// </summary>
            [EnumMember(Value = "PaidTimeLessThanMinWorkTime")]
            Paidtimelessthanminworktime,
            
            /// <summary>
            /// Enum Paidtimenotmetbyshiftstartstop for "PaidTimeNotMetByShiftStartStop"
            /// </summary>
            [EnumMember(Value = "PaidTimeNotMetByShiftStartStop")]
            Paidtimenotmetbyshiftstartstop,
            
            /// <summary>
            /// Enum Planningperiodmaxworkingweekendscannotbemet for "PlanningPeriodMaxWorkingWeekendsCannotBeMet"
            /// </summary>
            [EnumMember(Value = "PlanningPeriodMaxWorkingWeekendsCannotBeMet")]
            Planningperiodmaxworkingweekendscannotbemet,
            
            /// <summary>
            /// Enum Shiftdaysselectmorethanminworkingdays for "ShiftDaysSelectMoreThanMinWorkingDays"
            /// </summary>
            [EnumMember(Value = "ShiftDaysSelectMoreThanMinWorkingDays")]
            Shiftdaysselectmorethanminworkingdays,
            
            /// <summary>
            /// Enum Shiftstopearlierthanstart for "ShiftStopEarlierThanStart"
            /// </summary>
            [EnumMember(Value = "ShiftStopEarlierThanStart")]
            Shiftstopearlierthanstart,
            
            /// <summary>
            /// Enum Shiftmaxcountperplanningperiodcannotbemet for "ShiftMaxCountPerPlanningPeriodCannotBeMet"
            /// </summary>
            [EnumMember(Value = "ShiftMaxCountPerPlanningPeriodCannotBeMet")]
            Shiftmaxcountperplanningperiodcannotbemet,
            
            /// <summary>
            /// Enum Shiftmincountperplanningperiodcannotbemet for "ShiftMinCountPerPlanningPeriodCannotBeMet"
            /// </summary>
            [EnumMember(Value = "ShiftMinCountPerPlanningPeriodCannotBeMet")]
            Shiftmincountperplanningperiodcannotbemet,
            
            /// <summary>
            /// Enum Shiftvariancecannotbemet for "ShiftVarianceCannotBeMet"
            /// </summary>
            [EnumMember(Value = "ShiftVarianceCannotBeMet")]
            Shiftvariancecannotbemet,
            
            /// <summary>
            /// Enum Weeklyexactpaidminutes for "WeeklyExactPaidMinutes"
            /// </summary>
            [EnumMember(Value = "WeeklyExactPaidMinutes")]
            Weeklyexactpaidminutes
        }
        /// <summary>
        /// Severity of the message. A message with Error severity indicates the scheduler won't be able to produce schedules and thus the work plan is invalid.
        /// </summary>
        /// <value>Severity of the message. A message with Error severity indicates the scheduler won't be able to produce schedules and thus the work plan is invalid.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SeverityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Information for "Information"
            /// </summary>
            [EnumMember(Value = "Information")]
            Information,
            
            /// <summary>
            /// Enum Warning for "Warning"
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Type of configuration violation message for this work plan
        /// </summary>
        /// <value>Type of configuration violation message for this work plan</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Severity of the message. A message with Error severity indicates the scheduler won't be able to produce schedules and thus the work plan is invalid.
        /// </summary>
        /// <value>Severity of the message. A message with Error severity indicates the scheduler won't be able to produce schedules and thus the work plan is invalid.</value>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public SeverityEnum? Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanConfigurationViolationMessage" /> class.
        /// </summary>
        /// <param name="Type">Type of configuration violation message for this work plan.</param>
        /// <param name="Arguments">Arguments of the message that provide information about the misconfigured value or the threshold that is exceeded by the misconfigured value.</param>
        /// <param name="Severity">Severity of the message. A message with Error severity indicates the scheduler won&#39;t be able to produce schedules and thus the work plan is invalid..</param>
        public WorkPlanConfigurationViolationMessage(TypeEnum? Type = null, List<WorkPlanValidationMessageArgument> Arguments = null, SeverityEnum? Severity = null)
        {
            this.Type = Type;
            this.Arguments = Arguments;
            this.Severity = Severity;
            
        }
        




        /// <summary>
        /// Arguments of the message that provide information about the misconfigured value or the threshold that is exceeded by the misconfigured value
        /// </summary>
        /// <value>Arguments of the message that provide information about the misconfigured value or the threshold that is exceeded by the misconfigured value</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public List<WorkPlanValidationMessageArgument> Arguments { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanConfigurationViolationMessage {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
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
            return this.Equals(obj as WorkPlanConfigurationViolationMessage);
        }

        /// <summary>
        /// Returns true if WorkPlanConfigurationViolationMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanConfigurationViolationMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanConfigurationViolationMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Arguments == other.Arguments ||
                    this.Arguments != null &&
                    this.Arguments.SequenceEqual(other.Arguments)
                ) &&
                (
                    this.Severity == other.Severity ||
                    this.Severity != null &&
                    this.Severity.Equals(other.Severity)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Arguments != null)
                    hash = hash * 59 + this.Arguments.GetHashCode();

                if (this.Severity != null)
                    hash = hash * 59 + this.Severity.GetHashCode();

                return hash;
            }
        }
    }

}
