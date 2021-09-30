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
    /// SchedulerMessageTypeSeverity
    /// </summary>
    [DataContract]
    public partial class SchedulerMessageTypeSeverity :  IEquatable<SchedulerMessageTypeSeverity>
    {
        
        
        /// <summary>
        /// The type of the message
        /// </summary>
        /// <value>The type of the message</value>
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
            /// Enum Agentnotfound for "AgentNotFound"
            /// </summary>
            [EnumMember(Value = "AgentNotFound")]
            Agentnotfound,
            
            /// <summary>
            /// Enum Agentnotinselectedmanagementunit for "AgentNotInSelectedManagementUnit"
            /// </summary>
            [EnumMember(Value = "AgentNotInSelectedManagementUnit")]
            Agentnotinselectedmanagementunit,
            
            /// <summary>
            /// Enum Agentnotlicensed for "AgentNotLicensed"
            /// </summary>
            [EnumMember(Value = "AgentNotLicensed")]
            Agentnotlicensed,
            
            /// <summary>
            /// Enum Agentwithoutworkplan for "AgentWithoutWorkPlan"
            /// </summary>
            [EnumMember(Value = "AgentWithoutWorkPlan")]
            Agentwithoutworkplan,
            
            /// <summary>
            /// Enum Workplannotenabled for "WorkPlanNotEnabled"
            /// </summary>
            [EnumMember(Value = "WorkPlanNotEnabled")]
            Workplannotenabled,
            
            /// <summary>
            /// Enum Workplannotfound for "WorkPlanNotFound"
            /// </summary>
            [EnumMember(Value = "WorkPlanNotFound")]
            Workplannotfound,
            
            /// <summary>
            /// Enum Agentwithoutcapability for "AgentWithoutCapability"
            /// </summary>
            [EnumMember(Value = "AgentWithoutCapability")]
            Agentwithoutcapability,
            
            /// <summary>
            /// Enum Noneeddays for "NoNeedDays"
            /// </summary>
            [EnumMember(Value = "NoNeedDays")]
            Noneeddays,
            
            /// <summary>
            /// Enum Unabletoproduceagentschedule for "UnableToProduceAgentSchedule"
            /// </summary>
            [EnumMember(Value = "UnableToProduceAgentSchedule")]
            Unabletoproduceagentschedule,
            
            /// <summary>
            /// Enum Unabletoschedulemaxconsecutiveworkingdays for "UnableToScheduleMaxConsecutiveWorkingDays"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMaxConsecutiveWorkingDays")]
            Unabletoschedulemaxconsecutiveworkingdays,
            
            /// <summary>
            /// Enum Unabletoschedulemaxconsecutiveworkingweekends for "UnableToScheduleMaxConsecutiveWorkingWeekends"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMaxConsecutiveWorkingWeekends")]
            Unabletoschedulemaxconsecutiveworkingweekends,
            
            /// <summary>
            /// Enum Unabletoschedulemaxweeklypaidtime for "UnableToScheduleMaxWeeklyPaidTime"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMaxWeeklyPaidTime")]
            Unabletoschedulemaxweeklypaidtime,
            
            /// <summary>
            /// Enum Unabletoschedulemaxweeklyworkdays for "UnableToScheduleMaxWeeklyWorkDays"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMaxWeeklyWorkDays")]
            Unabletoschedulemaxweeklyworkdays,
            
            /// <summary>
            /// Enum Unabletoschedulemaxworkdaypaidtime for "UnableToScheduleMaxWorkDayPaidTime"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMaxWorkDayPaidTime")]
            Unabletoschedulemaxworkdaypaidtime,
            
            /// <summary>
            /// Enum Unabletoscheduleminconsecutivenonworkingtimeperweek for "UnableToScheduleMinConsecutiveNonWorkingTimePerWeek"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMinConsecutiveNonWorkingTimePerWeek")]
            Unabletoscheduleminconsecutivenonworkingtimeperweek,
            
            /// <summary>
            /// Enum Unabletoscheduleminintershifttime for "UnableToScheduleMinIntershiftTime"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMinIntershiftTime")]
            Unabletoscheduleminintershifttime,
            
            /// <summary>
            /// Enum Unabletoscheduleminshiftstartdistance for "UnableToScheduleMinShiftStartDistance"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMinShiftStartDistance")]
            Unabletoscheduleminshiftstartdistance,
            
            /// <summary>
            /// Enum Unabletoscheduleminweeklypaidtime for "UnableToScheduleMinWeeklyPaidTime"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMinWeeklyPaidTime")]
            Unabletoscheduleminweeklypaidtime,
            
            /// <summary>
            /// Enum Unabletoscheduleminweeklyworkdays for "UnableToScheduleMinWeeklyWorkDays"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMinWeeklyWorkDays")]
            Unabletoscheduleminweeklyworkdays,
            
            /// <summary>
            /// Enum Unabletoscheduleminworkdaypaidtime for "UnableToScheduleMinWorkDayPaidTime"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleMinWorkDayPaidTime")]
            Unabletoscheduleminworkdaypaidtime,
            
            /// <summary>
            /// Enum Unabletoscheduleplanningperiodmaxdaysoff for "UnableToSchedulePlanningPeriodMaxDaysOff"
            /// </summary>
            [EnumMember(Value = "UnableToSchedulePlanningPeriodMaxDaysOff")]
            Unabletoscheduleplanningperiodmaxdaysoff,
            
            /// <summary>
            /// Enum Unabletoscheduleplanningperiodmaxpaidtime for "UnableToSchedulePlanningPeriodMaxPaidTime"
            /// </summary>
            [EnumMember(Value = "UnableToSchedulePlanningPeriodMaxPaidTime")]
            Unabletoscheduleplanningperiodmaxpaidtime,
            
            /// <summary>
            /// Enum Unabletoscheduleplanningperiodmindaysoff for "UnableToSchedulePlanningPeriodMinDaysOff"
            /// </summary>
            [EnumMember(Value = "UnableToSchedulePlanningPeriodMinDaysOff")]
            Unabletoscheduleplanningperiodmindaysoff,
            
            /// <summary>
            /// Enum Unabletoscheduleplanningperiodminpaidtime for "UnableToSchedulePlanningPeriodMinPaidTime"
            /// </summary>
            [EnumMember(Value = "UnableToSchedulePlanningPeriodMinPaidTime")]
            Unabletoscheduleplanningperiodminpaidtime,
            
            /// <summary>
            /// Enum Unabletoscheduleshiftvariance for "UnableToScheduleShiftVariance"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleShiftVariance")]
            Unabletoscheduleshiftvariance,
            
            /// <summary>
            /// Enum Unabletoscheduleworkday for "UnableToScheduleWorkDay"
            /// </summary>
            [EnumMember(Value = "UnableToScheduleWorkDay")]
            Unabletoscheduleworkday
        }
        
        
        
        
        /// <summary>
        /// The severity of the message
        /// </summary>
        /// <value>The severity of the message</value>
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
            /// Enum Ignore for "Ignore"
            /// </summary>
            [EnumMember(Value = "Ignore")]
            Ignore,
            
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
        /// The type of the message
        /// </summary>
        /// <value>The type of the message</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        /// <summary>
        /// The severity of the message
        /// </summary>
        /// <value>The severity of the message</value>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public SeverityEnum? Severity { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerMessageTypeSeverity" /> class.
        /// </summary>
        /// <param name="Type">The type of the message.</param>
        /// <param name="Severity">The severity of the message.</param>
        public SchedulerMessageTypeSeverity(TypeEnum? Type = null, SeverityEnum? Severity = null)
        {
            this.Type = Type;
            this.Severity = Severity;
            
        }
        
        
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulerMessageTypeSeverity {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as SchedulerMessageTypeSeverity);
        }

        /// <summary>
        /// Returns true if SchedulerMessageTypeSeverity instances are equal
        /// </summary>
        /// <param name="other">Instance of SchedulerMessageTypeSeverity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulerMessageTypeSeverity other)
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
                
                if (this.Severity != null)
                    hash = hash * 59 + this.Severity.GetHashCode();
                
                return hash;
            }
        }
    }

}
