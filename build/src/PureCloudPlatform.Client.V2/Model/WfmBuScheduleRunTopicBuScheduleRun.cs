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
        /// Initializes a new instance of the <see cref="WfmBuScheduleRunTopicBuScheduleRun" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="WeekCount">WeekCount.</param>
        /// <param name="Schedule">Schedule.</param>
        /// <param name="SchedulingCanceledByUser">SchedulingCanceledByUser.</param>
        /// <param name="SchedulingCompletedTime">SchedulingCompletedTime.</param>
        /// <param name="MessageCount">MessageCount.</param>
        public WfmBuScheduleRunTopicBuScheduleRun(string Id = null, int? WeekCount = null, WfmBuScheduleRunTopicBuScheduleReference Schedule = null, WfmBuScheduleRunTopicUserReference SchedulingCanceledByUser = null, string SchedulingCompletedTime = null, int? MessageCount = null)
        {
            this.Id = Id;
            this.WeekCount = WeekCount;
            this.Schedule = Schedule;
            this.SchedulingCanceledByUser = SchedulingCanceledByUser;
            this.SchedulingCompletedTime = SchedulingCompletedTime;
            this.MessageCount = MessageCount;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets WeekCount
        /// </summary>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public int? WeekCount { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public WfmBuScheduleRunTopicBuScheduleReference Schedule { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SchedulingCanceledByUser
        /// </summary>
        [DataMember(Name="schedulingCanceledByUser", EmitDefaultValue=false)]
        public WfmBuScheduleRunTopicUserReference SchedulingCanceledByUser { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SchedulingCompletedTime
        /// </summary>
        [DataMember(Name="schedulingCompletedTime", EmitDefaultValue=false)]
        public string SchedulingCompletedTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessageCount
        /// </summary>
        [DataMember(Name="messageCount", EmitDefaultValue=false)]
        public int? MessageCount { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuScheduleRunTopicBuScheduleRun {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  SchedulingCanceledByUser: ").Append(SchedulingCanceledByUser).Append("\n");
            sb.Append("  SchedulingCompletedTime: ").Append(SchedulingCompletedTime).Append("\n");
            sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                    this.SchedulingCanceledByUser == other.SchedulingCanceledByUser ||
                    this.SchedulingCanceledByUser != null &&
                    this.SchedulingCanceledByUser.Equals(other.SchedulingCanceledByUser)
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
                
                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();
                
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                
                if (this.SchedulingCanceledByUser != null)
                    hash = hash * 59 + this.SchedulingCanceledByUser.GetHashCode();
                
                if (this.SchedulingCompletedTime != null)
                    hash = hash * 59 + this.SchedulingCompletedTime.GetHashCode();
                
                if (this.MessageCount != null)
                    hash = hash * 59 + this.MessageCount.GetHashCode();
                
                return hash;
            }
        }
    }

}
