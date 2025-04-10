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
    /// WorkPlanConstraintMessage
    /// </summary>
    [DataContract]
    public partial class WorkPlanConstraintMessage :  IEquatable<WorkPlanConstraintMessage>
    {
        /// <summary>
        /// Type of the work plan constraint in this message
        /// </summary>
        /// <value>Type of the work plan constraint in this message</value>
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
            /// Enum Activityearlieststarttimeminutesfrommidnight for "ActivityEarliestStartTimeMinutesFromMidnight"
            /// </summary>
            [EnumMember(Value = "ActivityEarliestStartTimeMinutesFromMidnight")]
            Activityearlieststarttimeminutesfrommidnight,
            
            /// <summary>
            /// Enum Activityearlieststarttimeminutesfromshiftstart for "ActivityEarliestStartTimeMinutesFromShiftStart"
            /// </summary>
            [EnumMember(Value = "ActivityEarliestStartTimeMinutesFromShiftStart")]
            Activityearlieststarttimeminutesfromshiftstart,
            
            /// <summary>
            /// Enum Activitylateststarttimeminutesfrommidnight for "ActivityLatestStartTimeMinutesFromMidnight"
            /// </summary>
            [EnumMember(Value = "ActivityLatestStartTimeMinutesFromMidnight")]
            Activitylateststarttimeminutesfrommidnight,
            
            /// <summary>
            /// Enum Activitylateststarttimeminutesfromshiftstart for "ActivityLatestStartTimeMinutesFromShiftStart"
            /// </summary>
            [EnumMember(Value = "ActivityLatestStartTimeMinutesFromShiftStart")]
            Activitylateststarttimeminutesfromshiftstart,
            
            /// <summary>
            /// Enum Activityminimumlengthfromshiftendminutes for "ActivityMinimumLengthFromShiftEndMinutes"
            /// </summary>
            [EnumMember(Value = "ActivityMinimumLengthFromShiftEndMinutes")]
            Activityminimumlengthfromshiftendminutes,
            
            /// <summary>
            /// Enum Activityminimumlengthfromshiftstartminutes for "ActivityMinimumLengthFromShiftStartMinutes"
            /// </summary>
            [EnumMember(Value = "ActivityMinimumLengthFromShiftStartMinutes")]
            Activityminimumlengthfromshiftstartminutes,
            
            /// <summary>
            /// Enum Activitystarttimeincrementinminutes for "ActivityStartTimeIncrementInMinutes"
            /// </summary>
            [EnumMember(Value = "ActivityStartTimeIncrementInMinutes")]
            Activitystarttimeincrementinminutes,
            
            /// <summary>
            /// Enum Planningperiodmaximumdaysoff for "PlanningPeriodMaximumDaysOff"
            /// </summary>
            [EnumMember(Value = "PlanningPeriodMaximumDaysOff")]
            Planningperiodmaximumdaysoff,
            
            /// <summary>
            /// Enum Planningperiodmaximumpaidtimeminutes for "PlanningPeriodMaximumPaidTimeMinutes"
            /// </summary>
            [EnumMember(Value = "PlanningPeriodMaximumPaidTimeMinutes")]
            Planningperiodmaximumpaidtimeminutes,
            
            /// <summary>
            /// Enum Planningperiodmaximumworkingweekends for "PlanningPeriodMaximumWorkingWeekends"
            /// </summary>
            [EnumMember(Value = "PlanningPeriodMaximumWorkingWeekends")]
            Planningperiodmaximumworkingweekends,
            
            /// <summary>
            /// Enum Planningperiodminimumdaysoff for "PlanningPeriodMinimumDaysOff"
            /// </summary>
            [EnumMember(Value = "PlanningPeriodMinimumDaysOff")]
            Planningperiodminimumdaysoff,
            
            /// <summary>
            /// Enum Planningperiodminimumpaidtimeminutes for "PlanningPeriodMinimumPaidTimeMinutes"
            /// </summary>
            [EnumMember(Value = "PlanningPeriodMinimumPaidTimeMinutes")]
            Planningperiodminimumpaidtimeminutes,
            
            /// <summary>
            /// Enum Shiftdayoffrule for "ShiftDayOffRule"
            /// </summary>
            [EnumMember(Value = "ShiftDayOffRule")]
            Shiftdayoffrule,
            
            /// <summary>
            /// Enum Shiftearlieststarttimeminutesfrommidnight for "ShiftEarliestStartTimeMinutesFromMidnight"
            /// </summary>
            [EnumMember(Value = "ShiftEarliestStartTimeMinutesFromMidnight")]
            Shiftearlieststarttimeminutesfrommidnight,
            
            /// <summary>
            /// Enum Shiftearlieststoptimeminutesfrommidnight for "ShiftEarliestStopTimeMinutesFromMidnight"
            /// </summary>
            [EnumMember(Value = "ShiftEarliestStopTimeMinutesFromMidnight")]
            Shiftearlieststoptimeminutesfrommidnight,
            
            /// <summary>
            /// Enum Shiftlateststarttimeminutesfrommidnight for "ShiftLatestStartTimeMinutesFromMidnight"
            /// </summary>
            [EnumMember(Value = "ShiftLatestStartTimeMinutesFromMidnight")]
            Shiftlateststarttimeminutesfrommidnight,
            
            /// <summary>
            /// Enum Shiftlateststoptimeminutesfrommidnight for "ShiftLatestStopTimeMinutesFromMidnight"
            /// </summary>
            [EnumMember(Value = "ShiftLatestStopTimeMinutesFromMidnight")]
            Shiftlateststoptimeminutesfrommidnight,
            
            /// <summary>
            /// Enum Shiftmaximumcontiguoustimeminutes for "ShiftMaximumContiguousTimeMinutes"
            /// </summary>
            [EnumMember(Value = "ShiftMaximumContiguousTimeMinutes")]
            Shiftmaximumcontiguoustimeminutes,
            
            /// <summary>
            /// Enum Shiftmaximumcountperplanningperiod for "ShiftMaximumCountPerPlanningPeriod"
            /// </summary>
            [EnumMember(Value = "ShiftMaximumCountPerPlanningPeriod")]
            Shiftmaximumcountperplanningperiod,
            
            /// <summary>
            /// Enum Shiftmaximumpaidtimeminutes for "ShiftMaximumPaidTimeMinutes"
            /// </summary>
            [EnumMember(Value = "ShiftMaximumPaidTimeMinutes")]
            Shiftmaximumpaidtimeminutes,
            
            /// <summary>
            /// Enum Shiftminimumcontiguoustimeminutes for "ShiftMinimumContiguousTimeMinutes"
            /// </summary>
            [EnumMember(Value = "ShiftMinimumContiguousTimeMinutes")]
            Shiftminimumcontiguoustimeminutes,
            
            /// <summary>
            /// Enum Shiftminimumcountperplanningperiod for "ShiftMinimumCountPerPlanningPeriod"
            /// </summary>
            [EnumMember(Value = "ShiftMinimumCountPerPlanningPeriod")]
            Shiftminimumcountperplanningperiod,
            
            /// <summary>
            /// Enum Shiftminimumpaidtimeminutes for "ShiftMinimumPaidTimeMinutes"
            /// </summary>
            [EnumMember(Value = "ShiftMinimumPaidTimeMinutes")]
            Shiftminimumpaidtimeminutes,
            
            /// <summary>
            /// Enum Shiftstarttimeincrementinminutes for "ShiftStartTimeIncrementInMinutes"
            /// </summary>
            [EnumMember(Value = "ShiftStartTimeIncrementInMinutes")]
            Shiftstarttimeincrementinminutes,
            
            /// <summary>
            /// Enum Shiftstartvariancemaximumvarianceminutes for "ShiftStartVarianceMaximumVarianceMinutes"
            /// </summary>
            [EnumMember(Value = "ShiftStartVarianceMaximumVarianceMinutes")]
            Shiftstartvariancemaximumvarianceminutes,
            
            /// <summary>
            /// Enum Shiftstartvariancepaidduration for "ShiftStartVariancePaidDuration"
            /// </summary>
            [EnumMember(Value = "ShiftStartVariancePaidDuration")]
            Shiftstartvariancepaidduration,
            
            /// <summary>
            /// Enum Workplanmaximumconsecutiveworkingdays for "WorkPlanMaximumConsecutiveWorkingDays"
            /// </summary>
            [EnumMember(Value = "WorkPlanMaximumConsecutiveWorkingDays")]
            Workplanmaximumconsecutiveworkingdays,
            
            /// <summary>
            /// Enum Workplanmaximumconsecutiveworkingweekends for "WorkPlanMaximumConsecutiveWorkingWeekends"
            /// </summary>
            [EnumMember(Value = "WorkPlanMaximumConsecutiveWorkingWeekends")]
            Workplanmaximumconsecutiveworkingweekends,
            
            /// <summary>
            /// Enum Workplanmaximumweeklypaidtimeminutes for "WorkPlanMaximumWeeklyPaidTimeMinutes"
            /// </summary>
            [EnumMember(Value = "WorkPlanMaximumWeeklyPaidTimeMinutes")]
            Workplanmaximumweeklypaidtimeminutes,
            
            /// <summary>
            /// Enum Workplanmaximumworkingdaysperweek for "WorkPlanMaximumWorkingDaysPerWeek"
            /// </summary>
            [EnumMember(Value = "WorkPlanMaximumWorkingDaysPerWeek")]
            Workplanmaximumworkingdaysperweek,
            
            /// <summary>
            /// Enum Workplanminimumconsecutivenonworkingtimeperweekminutes for "WorkPlanMinimumConsecutiveNonWorkingTimePerWeekMinutes"
            /// </summary>
            [EnumMember(Value = "WorkPlanMinimumConsecutiveNonWorkingTimePerWeekMinutes")]
            Workplanminimumconsecutivenonworkingtimeperweekminutes,
            
            /// <summary>
            /// Enum Workplanminimumintershifttimeminutes for "WorkPlanMinimumInterShiftTimeMinutes"
            /// </summary>
            [EnumMember(Value = "WorkPlanMinimumInterShiftTimeMinutes")]
            Workplanminimumintershifttimeminutes,
            
            /// <summary>
            /// Enum Workplanminimumshiftstartdistanceminutes for "WorkPlanMinimumShiftStartDistanceMinutes"
            /// </summary>
            [EnumMember(Value = "WorkPlanMinimumShiftStartDistanceMinutes")]
            Workplanminimumshiftstartdistanceminutes,
            
            /// <summary>
            /// Enum Workplanminimumweeklypaidtimeminutes for "WorkPlanMinimumWeeklyPaidTimeMinutes"
            /// </summary>
            [EnumMember(Value = "WorkPlanMinimumWeeklyPaidTimeMinutes")]
            Workplanminimumweeklypaidtimeminutes,
            
            /// <summary>
            /// Enum Workplanminimumworkingdaysperweek for "WorkPlanMinimumWorkingDaysPerWeek"
            /// </summary>
            [EnumMember(Value = "WorkPlanMinimumWorkingDaysPerWeek")]
            Workplanminimumworkingdaysperweek,
            
            /// <summary>
            /// Enum Workplanoptionaldays for "WorkPlanOptionalDays"
            /// </summary>
            [EnumMember(Value = "WorkPlanOptionalDays")]
            Workplanoptionaldays,
            
            /// <summary>
            /// Enum Workplanpaidtimegranularityminutes for "WorkPlanPaidTimeGranularityMinutes"
            /// </summary>
            [EnumMember(Value = "WorkPlanPaidTimeGranularityMinutes")]
            Workplanpaidtimegranularityminutes
        }
        /// <summary>
        /// Type of the work plan constraint in this message
        /// </summary>
        /// <value>Type of the work plan constraint in this message</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanConstraintMessage" /> class.
        /// </summary>
        /// <param name="Type">Type of the work plan constraint in this message.</param>
        /// <param name="Arguments">Arguments of the message that provide information about the constraint that is being conflicted with, such as the value of the constraint.</param>
        public WorkPlanConstraintMessage(TypeEnum? Type = null, List<WorkPlanValidationMessageArgument> Arguments = null)
        {
            this.Type = Type;
            this.Arguments = Arguments;
            
        }
        




        /// <summary>
        /// Arguments of the message that provide information about the constraint that is being conflicted with, such as the value of the constraint
        /// </summary>
        /// <value>Arguments of the message that provide information about the constraint that is being conflicted with, such as the value of the constraint</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public List<WorkPlanValidationMessageArgument> Arguments { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanConstraintMessage {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
            return this.Equals(obj as WorkPlanConstraintMessage);
        }

        /// <summary>
        /// Returns true if WorkPlanConstraintMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanConstraintMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanConstraintMessage other)
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

                return hash;
            }
        }
    }

}
