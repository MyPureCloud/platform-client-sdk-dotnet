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
    /// WfmBuScheduleRunTopicBuScheduleRun
    /// </summary>
    [DataContract]
    public partial class WfmBuScheduleRunTopicBuScheduleRun :  IEquatable<WfmBuScheduleRunTopicBuScheduleRun>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
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
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuScheduleRunTopicBuScheduleRun" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="PercentComplete">PercentComplete.</param>
        /// <param name="IntradayRescheduling">IntradayRescheduling.</param>
        /// <param name="State">State.</param>
        /// <param name="WeekCount">WeekCount.</param>
        /// <param name="Schedule">Schedule.</param>
        /// <param name="SchedulingCanceledBy">SchedulingCanceledBy.</param>
        /// <param name="SchedulingCompletedTime">SchedulingCompletedTime.</param>
        /// <param name="MessageCount">MessageCount.</param>
        /// <param name="MessageSeverityCounts">MessageSeverityCounts.</param>
        public WfmBuScheduleRunTopicBuScheduleRun(string Id = null, double? PercentComplete = null, bool? IntradayRescheduling = null, StateEnum? State = null, long? WeekCount = null, WfmBuScheduleRunTopicBuScheduleReference Schedule = null, WfmBuScheduleRunTopicUserReference SchedulingCanceledBy = null, string SchedulingCompletedTime = null, long? MessageCount = null, List<WfmBuScheduleRunTopicSchedulerMessageSeverityCount> MessageSeverityCounts = null)
        {
            this.Id = Id;
            this.PercentComplete = PercentComplete;
            this.IntradayRescheduling = IntradayRescheduling;
            this.State = State;
            this.WeekCount = WeekCount;
            this.Schedule = Schedule;
            this.SchedulingCanceledBy = SchedulingCanceledBy;
            this.SchedulingCompletedTime = SchedulingCompletedTime;
            this.MessageCount = MessageCount;
            this.MessageSeverityCounts = MessageSeverityCounts;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets PercentComplete
        /// </summary>
        [DataMember(Name="percentComplete", EmitDefaultValue=false)]
        public double? PercentComplete { get; set; }



        /// <summary>
        /// Gets or Sets IntradayRescheduling
        /// </summary>
        [DataMember(Name="intradayRescheduling", EmitDefaultValue=false)]
        public bool? IntradayRescheduling { get; set; }





        /// <summary>
        /// Gets or Sets WeekCount
        /// </summary>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public long? WeekCount { get; set; }



        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public WfmBuScheduleRunTopicBuScheduleReference Schedule { get; set; }



        /// <summary>
        /// Gets or Sets SchedulingCanceledBy
        /// </summary>
        [DataMember(Name="schedulingCanceledBy", EmitDefaultValue=false)]
        public WfmBuScheduleRunTopicUserReference SchedulingCanceledBy { get; set; }



        /// <summary>
        /// Gets or Sets SchedulingCompletedTime
        /// </summary>
        [DataMember(Name="schedulingCompletedTime", EmitDefaultValue=false)]
        public string SchedulingCompletedTime { get; set; }



        /// <summary>
        /// Gets or Sets MessageCount
        /// </summary>
        [DataMember(Name="messageCount", EmitDefaultValue=false)]
        public long? MessageCount { get; set; }



        /// <summary>
        /// Gets or Sets MessageSeverityCounts
        /// </summary>
        [DataMember(Name="messageSeverityCounts", EmitDefaultValue=false)]
        public List<WfmBuScheduleRunTopicSchedulerMessageSeverityCount> MessageSeverityCounts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuScheduleRunTopicBuScheduleRun {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
            sb.Append("  IntradayRescheduling: ").Append(IntradayRescheduling).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  SchedulingCanceledBy: ").Append(SchedulingCanceledBy).Append("\n");
            sb.Append("  SchedulingCompletedTime: ").Append(SchedulingCompletedTime).Append("\n");
            sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
            sb.Append("  MessageSeverityCounts: ").Append(MessageSeverityCounts).Append("\n");
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
            return this.Equals(obj as WfmBuScheduleRunTopicBuScheduleRun);
        }

        /// <summary>
        /// Returns true if WfmBuScheduleRunTopicBuScheduleRun instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuScheduleRunTopicBuScheduleRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuScheduleRunTopicBuScheduleRun other)
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
                    this.PercentComplete == other.PercentComplete ||
                    this.PercentComplete != null &&
                    this.PercentComplete.Equals(other.PercentComplete)
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
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
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

                if (this.PercentComplete != null)
                    hash = hash * 59 + this.PercentComplete.GetHashCode();

                if (this.IntradayRescheduling != null)
                    hash = hash * 59 + this.IntradayRescheduling.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.SchedulingCanceledBy != null)
                    hash = hash * 59 + this.SchedulingCanceledBy.GetHashCode();

                if (this.SchedulingCompletedTime != null)
                    hash = hash * 59 + this.SchedulingCompletedTime.GetHashCode();

                if (this.MessageCount != null)
                    hash = hash * 59 + this.MessageCount.GetHashCode();

                if (this.MessageSeverityCounts != null)
                    hash = hash * 59 + this.MessageSeverityCounts.GetHashCode();

                return hash;
            }
        }
    }

}
