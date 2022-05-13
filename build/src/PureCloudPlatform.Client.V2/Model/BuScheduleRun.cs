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
    /// BuScheduleRun
    /// </summary>
    [DataContract]
    public partial class BuScheduleRun :  IEquatable<BuScheduleRun>
    {
        /// <summary>
        /// The state of the generation run
        /// </summary>
        /// <value>The state of the generation run</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Queued for "Queued"
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued,
            
            /// <summary>
            /// Enum Scheduling for "Scheduling"
            /// </summary>
            [EnumMember(Value = "Scheduling")]
            Scheduling,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete
        }
        /// <summary>
        /// The state of the generation run
        /// </summary>
        /// <value>The state of the generation run</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuScheduleRun" /> class.
        /// </summary>
        /// <param name="SchedulerRunId">The scheduler run ID.  Reference this value for support.</param>
        /// <param name="IntradayRescheduling">Whether this is an intraday rescheduling run.</param>
        /// <param name="State">The state of the generation run.</param>
        /// <param name="WeekCount">The number of weeks spanned by the schedule.</param>
        /// <param name="PercentComplete">Percent completion of the schedule run.</param>
        /// <param name="TargetWeek">The start date of the target week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="Schedule">The generated schedule.  Null unless the schedule run is complete.</param>
        /// <param name="ScheduleDescription">The description of the generated schedule.</param>
        /// <param name="SchedulingStartTime">When the schedule generation run started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="SchedulingStartedBy">The user who started the scheduling run.</param>
        /// <param name="SchedulingCanceledBy">The user who canceled the scheduling run, if applicable.</param>
        /// <param name="SchedulingCompletedTime">When the scheduling run was completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="MessageCount">The number of schedule generation messages for this schedule generation run.</param>
        /// <param name="MessageSeverityCounts">The list of schedule generation message counts by severity for this schedule generation run.</param>
        /// <param name="ReschedulingOptions">Rescheduling options for this run.  Null unless intradayRescheduling is true.</param>
        /// <param name="ReschedulingResultExpiration">When the reschedule result will expire.  Null unless intradayRescheduling is true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public BuScheduleRun(string SchedulerRunId = null, bool? IntradayRescheduling = null, StateEnum? State = null, int? WeekCount = null, double? PercentComplete = null, String TargetWeek = null, BuScheduleReference Schedule = null, string ScheduleDescription = null, DateTime? SchedulingStartTime = null, UserReference SchedulingStartedBy = null, UserReference SchedulingCanceledBy = null, DateTime? SchedulingCompletedTime = null, int? MessageCount = null, List<SchedulerMessageSeverityCount> MessageSeverityCounts = null, ReschedulingOptionsRunResponse ReschedulingOptions = null, DateTime? ReschedulingResultExpiration = null)
        {
            this.SchedulerRunId = SchedulerRunId;
            this.IntradayRescheduling = IntradayRescheduling;
            this.State = State;
            this.WeekCount = WeekCount;
            this.PercentComplete = PercentComplete;
            this.TargetWeek = TargetWeek;
            this.Schedule = Schedule;
            this.ScheduleDescription = ScheduleDescription;
            this.SchedulingStartTime = SchedulingStartTime;
            this.SchedulingStartedBy = SchedulingStartedBy;
            this.SchedulingCanceledBy = SchedulingCanceledBy;
            this.SchedulingCompletedTime = SchedulingCompletedTime;
            this.MessageCount = MessageCount;
            this.MessageSeverityCounts = MessageSeverityCounts;
            this.ReschedulingOptions = ReschedulingOptions;
            this.ReschedulingResultExpiration = ReschedulingResultExpiration;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The scheduler run ID.  Reference this value for support
        /// </summary>
        /// <value>The scheduler run ID.  Reference this value for support</value>
        [DataMember(Name="schedulerRunId", EmitDefaultValue=false)]
        public string SchedulerRunId { get; set; }



        /// <summary>
        /// Whether this is an intraday rescheduling run
        /// </summary>
        /// <value>Whether this is an intraday rescheduling run</value>
        [DataMember(Name="intradayRescheduling", EmitDefaultValue=false)]
        public bool? IntradayRescheduling { get; set; }





        /// <summary>
        /// The number of weeks spanned by the schedule
        /// </summary>
        /// <value>The number of weeks spanned by the schedule</value>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public int? WeekCount { get; set; }



        /// <summary>
        /// Percent completion of the schedule run
        /// </summary>
        /// <value>Percent completion of the schedule run</value>
        [DataMember(Name="percentComplete", EmitDefaultValue=false)]
        public double? PercentComplete { get; set; }



        /// <summary>
        /// The start date of the target week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start date of the target week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="targetWeek", EmitDefaultValue=false)]
        public String TargetWeek { get; set; }



        /// <summary>
        /// The generated schedule.  Null unless the schedule run is complete
        /// </summary>
        /// <value>The generated schedule.  Null unless the schedule run is complete</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public BuScheduleReference Schedule { get; set; }



        /// <summary>
        /// The description of the generated schedule
        /// </summary>
        /// <value>The description of the generated schedule</value>
        [DataMember(Name="scheduleDescription", EmitDefaultValue=false)]
        public string ScheduleDescription { get; set; }



        /// <summary>
        /// When the schedule generation run started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>When the schedule generation run started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="schedulingStartTime", EmitDefaultValue=false)]
        public DateTime? SchedulingStartTime { get; set; }



        /// <summary>
        /// The user who started the scheduling run
        /// </summary>
        /// <value>The user who started the scheduling run</value>
        [DataMember(Name="schedulingStartedBy", EmitDefaultValue=false)]
        public UserReference SchedulingStartedBy { get; set; }



        /// <summary>
        /// The user who canceled the scheduling run, if applicable
        /// </summary>
        /// <value>The user who canceled the scheduling run, if applicable</value>
        [DataMember(Name="schedulingCanceledBy", EmitDefaultValue=false)]
        public UserReference SchedulingCanceledBy { get; set; }



        /// <summary>
        /// When the scheduling run was completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>When the scheduling run was completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="schedulingCompletedTime", EmitDefaultValue=false)]
        public DateTime? SchedulingCompletedTime { get; set; }



        /// <summary>
        /// The number of schedule generation messages for this schedule generation run
        /// </summary>
        /// <value>The number of schedule generation messages for this schedule generation run</value>
        [DataMember(Name="messageCount", EmitDefaultValue=false)]
        public int? MessageCount { get; set; }



        /// <summary>
        /// The list of schedule generation message counts by severity for this schedule generation run
        /// </summary>
        /// <value>The list of schedule generation message counts by severity for this schedule generation run</value>
        [DataMember(Name="messageSeverityCounts", EmitDefaultValue=false)]
        public List<SchedulerMessageSeverityCount> MessageSeverityCounts { get; set; }



        /// <summary>
        /// Rescheduling options for this run.  Null unless intradayRescheduling is true
        /// </summary>
        /// <value>Rescheduling options for this run.  Null unless intradayRescheduling is true</value>
        [DataMember(Name="reschedulingOptions", EmitDefaultValue=false)]
        public ReschedulingOptionsRunResponse ReschedulingOptions { get; set; }



        /// <summary>
        /// When the reschedule result will expire.  Null unless intradayRescheduling is true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>When the reschedule result will expire.  Null unless intradayRescheduling is true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="reschedulingResultExpiration", EmitDefaultValue=false)]
        public DateTime? ReschedulingResultExpiration { get; set; }



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
            sb.Append("class BuScheduleRun {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SchedulerRunId: ").Append(SchedulerRunId).Append("\n");
            sb.Append("  IntradayRescheduling: ").Append(IntradayRescheduling).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
            sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
            sb.Append("  TargetWeek: ").Append(TargetWeek).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  ScheduleDescription: ").Append(ScheduleDescription).Append("\n");
            sb.Append("  SchedulingStartTime: ").Append(SchedulingStartTime).Append("\n");
            sb.Append("  SchedulingStartedBy: ").Append(SchedulingStartedBy).Append("\n");
            sb.Append("  SchedulingCanceledBy: ").Append(SchedulingCanceledBy).Append("\n");
            sb.Append("  SchedulingCompletedTime: ").Append(SchedulingCompletedTime).Append("\n");
            sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
            sb.Append("  MessageSeverityCounts: ").Append(MessageSeverityCounts).Append("\n");
            sb.Append("  ReschedulingOptions: ").Append(ReschedulingOptions).Append("\n");
            sb.Append("  ReschedulingResultExpiration: ").Append(ReschedulingResultExpiration).Append("\n");
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
            return this.Equals(obj as BuScheduleRun);
        }

        /// <summary>
        /// Returns true if BuScheduleRun instances are equal
        /// </summary>
        /// <param name="other">Instance of BuScheduleRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuScheduleRun other)
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
                    this.SchedulerRunId == other.SchedulerRunId ||
                    this.SchedulerRunId != null &&
                    this.SchedulerRunId.Equals(other.SchedulerRunId)
                ) &&
                (
                    this.IntradayRescheduling == other.IntradayRescheduling ||
                    this.IntradayRescheduling != null &&
                    this.IntradayRescheduling.Equals(other.IntradayRescheduling)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.WeekCount == other.WeekCount ||
                    this.WeekCount != null &&
                    this.WeekCount.Equals(other.WeekCount)
                ) &&
                (
                    this.PercentComplete == other.PercentComplete ||
                    this.PercentComplete != null &&
                    this.PercentComplete.Equals(other.PercentComplete)
                ) &&
                (
                    this.TargetWeek == other.TargetWeek ||
                    this.TargetWeek != null &&
                    this.TargetWeek.Equals(other.TargetWeek)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.ScheduleDescription == other.ScheduleDescription ||
                    this.ScheduleDescription != null &&
                    this.ScheduleDescription.Equals(other.ScheduleDescription)
                ) &&
                (
                    this.SchedulingStartTime == other.SchedulingStartTime ||
                    this.SchedulingStartTime != null &&
                    this.SchedulingStartTime.Equals(other.SchedulingStartTime)
                ) &&
                (
                    this.SchedulingStartedBy == other.SchedulingStartedBy ||
                    this.SchedulingStartedBy != null &&
                    this.SchedulingStartedBy.Equals(other.SchedulingStartedBy)
                ) &&
                (
                    this.SchedulingCanceledBy == other.SchedulingCanceledBy ||
                    this.SchedulingCanceledBy != null &&
                    this.SchedulingCanceledBy.Equals(other.SchedulingCanceledBy)
                ) &&
                (
                    this.SchedulingCompletedTime == other.SchedulingCompletedTime ||
                    this.SchedulingCompletedTime != null &&
                    this.SchedulingCompletedTime.Equals(other.SchedulingCompletedTime)
                ) &&
                (
                    this.MessageCount == other.MessageCount ||
                    this.MessageCount != null &&
                    this.MessageCount.Equals(other.MessageCount)
                ) &&
                (
                    this.MessageSeverityCounts == other.MessageSeverityCounts ||
                    this.MessageSeverityCounts != null &&
                    this.MessageSeverityCounts.SequenceEqual(other.MessageSeverityCounts)
                ) &&
                (
                    this.ReschedulingOptions == other.ReschedulingOptions ||
                    this.ReschedulingOptions != null &&
                    this.ReschedulingOptions.Equals(other.ReschedulingOptions)
                ) &&
                (
                    this.ReschedulingResultExpiration == other.ReschedulingResultExpiration ||
                    this.ReschedulingResultExpiration != null &&
                    this.ReschedulingResultExpiration.Equals(other.ReschedulingResultExpiration)
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

                if (this.SchedulerRunId != null)
                    hash = hash * 59 + this.SchedulerRunId.GetHashCode();

                if (this.IntradayRescheduling != null)
                    hash = hash * 59 + this.IntradayRescheduling.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();

                if (this.PercentComplete != null)
                    hash = hash * 59 + this.PercentComplete.GetHashCode();

                if (this.TargetWeek != null)
                    hash = hash * 59 + this.TargetWeek.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.ScheduleDescription != null)
                    hash = hash * 59 + this.ScheduleDescription.GetHashCode();

                if (this.SchedulingStartTime != null)
                    hash = hash * 59 + this.SchedulingStartTime.GetHashCode();

                if (this.SchedulingStartedBy != null)
                    hash = hash * 59 + this.SchedulingStartedBy.GetHashCode();

                if (this.SchedulingCanceledBy != null)
                    hash = hash * 59 + this.SchedulingCanceledBy.GetHashCode();

                if (this.SchedulingCompletedTime != null)
                    hash = hash * 59 + this.SchedulingCompletedTime.GetHashCode();

                if (this.MessageCount != null)
                    hash = hash * 59 + this.MessageCount.GetHashCode();

                if (this.MessageSeverityCounts != null)
                    hash = hash * 59 + this.MessageSeverityCounts.GetHashCode();

                if (this.ReschedulingOptions != null)
                    hash = hash * 59 + this.ReschedulingOptions.GetHashCode();

                if (this.ReschedulingResultExpiration != null)
                    hash = hash * 59 + this.ReschedulingResultExpiration.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
