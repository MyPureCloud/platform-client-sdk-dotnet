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
    /// ReschedulingOptionsResponse
    /// </summary>
    [DataContract]
    public partial class ReschedulingOptionsResponse :  IEquatable<ReschedulingOptionsResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReschedulingOptionsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReschedulingOptionsResponse() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReschedulingOptionsResponse" /> class.
        /// </summary>
        /// <param name="StartDate">The start date of the range to reschedule in ISO-8601 format (required).</param>
        /// <param name="EndDate">The end date of the range to reschedule in ISO-8601 format (required).</param>
        /// <param name="AgentIds">The IDs of the agents to reschedule.  Null or empty means all agents on the schedule.</param>
        /// <param name="ActivityCodeIds">The IDs of the activity codes to reschedule. Null or empty means all activity codes will be considered.</param>
        /// <param name="DoNotChangeWeeklyPaidTime">Whether to prevent changes to weekly paid time (required).</param>
        /// <param name="DoNotChangeDailyPaidTime">Whether to prevent changes to daily paid time (required).</param>
        /// <param name="DoNotChangeShiftStartTimes">Whether to prevent changes to shift start times (required).</param>
        /// <param name="DoNotChangeManuallyEditedShifts">Whether to prevent changes to manually edited shifts (required).</param>
        /// <param name="ExistingScheduleId">The schedule ID of the schedule to which the results will be applied.</param>
        /// <param name="ExistingScheduleVersion">The version of the schedule at the time the rescheduling was initiated.</param>
        public ReschedulingOptionsResponse(DateTime? StartDate = null, DateTime? EndDate = null, List<string> AgentIds = null, List<string> ActivityCodeIds = null, bool? DoNotChangeWeeklyPaidTime = null, bool? DoNotChangeDailyPaidTime = null, bool? DoNotChangeShiftStartTimes = null, bool? DoNotChangeManuallyEditedShifts = null, string ExistingScheduleId = null, int? ExistingScheduleVersion = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.AgentIds = AgentIds;
            this.ActivityCodeIds = ActivityCodeIds;
            this.DoNotChangeWeeklyPaidTime = DoNotChangeWeeklyPaidTime;
            this.DoNotChangeDailyPaidTime = DoNotChangeDailyPaidTime;
            this.DoNotChangeShiftStartTimes = DoNotChangeShiftStartTimes;
            this.DoNotChangeManuallyEditedShifts = DoNotChangeManuallyEditedShifts;
            this.ExistingScheduleId = ExistingScheduleId;
            this.ExistingScheduleVersion = ExistingScheduleVersion;
            
        }
        
        
        
        /// <summary>
        /// The start date of the range to reschedule in ISO-8601 format
        /// </summary>
        /// <value>The start date of the range to reschedule in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        
        
        
        /// <summary>
        /// The end date of the range to reschedule in ISO-8601 format
        /// </summary>
        /// <value>The end date of the range to reschedule in ISO-8601 format</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        
        
        
        /// <summary>
        /// The IDs of the agents to reschedule.  Null or empty means all agents on the schedule
        /// </summary>
        /// <value>The IDs of the agents to reschedule.  Null or empty means all agents on the schedule</value>
        [DataMember(Name="agentIds", EmitDefaultValue=false)]
        public List<string> AgentIds { get; set; }
        
        
        
        /// <summary>
        /// The IDs of the activity codes to reschedule. Null or empty means all activity codes will be considered
        /// </summary>
        /// <value>The IDs of the activity codes to reschedule. Null or empty means all activity codes will be considered</value>
        [DataMember(Name="activityCodeIds", EmitDefaultValue=false)]
        public List<string> ActivityCodeIds { get; set; }
        
        
        
        /// <summary>
        /// Whether to prevent changes to weekly paid time
        /// </summary>
        /// <value>Whether to prevent changes to weekly paid time</value>
        [DataMember(Name="doNotChangeWeeklyPaidTime", EmitDefaultValue=false)]
        public bool? DoNotChangeWeeklyPaidTime { get; set; }
        
        
        
        /// <summary>
        /// Whether to prevent changes to daily paid time
        /// </summary>
        /// <value>Whether to prevent changes to daily paid time</value>
        [DataMember(Name="doNotChangeDailyPaidTime", EmitDefaultValue=false)]
        public bool? DoNotChangeDailyPaidTime { get; set; }
        
        
        
        /// <summary>
        /// Whether to prevent changes to shift start times
        /// </summary>
        /// <value>Whether to prevent changes to shift start times</value>
        [DataMember(Name="doNotChangeShiftStartTimes", EmitDefaultValue=false)]
        public bool? DoNotChangeShiftStartTimes { get; set; }
        
        
        
        /// <summary>
        /// Whether to prevent changes to manually edited shifts
        /// </summary>
        /// <value>Whether to prevent changes to manually edited shifts</value>
        [DataMember(Name="doNotChangeManuallyEditedShifts", EmitDefaultValue=false)]
        public bool? DoNotChangeManuallyEditedShifts { get; set; }
        
        
        
        /// <summary>
        /// The schedule ID of the schedule to which the results will be applied
        /// </summary>
        /// <value>The schedule ID of the schedule to which the results will be applied</value>
        [DataMember(Name="existingScheduleId", EmitDefaultValue=false)]
        public string ExistingScheduleId { get; set; }
        
        
        
        /// <summary>
        /// The version of the schedule at the time the rescheduling was initiated
        /// </summary>
        /// <value>The version of the schedule at the time the rescheduling was initiated</value>
        [DataMember(Name="existingScheduleVersion", EmitDefaultValue=false)]
        public int? ExistingScheduleVersion { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReschedulingOptionsResponse {\n");
            
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
            sb.Append("  ActivityCodeIds: ").Append(ActivityCodeIds).Append("\n");
            sb.Append("  DoNotChangeWeeklyPaidTime: ").Append(DoNotChangeWeeklyPaidTime).Append("\n");
            sb.Append("  DoNotChangeDailyPaidTime: ").Append(DoNotChangeDailyPaidTime).Append("\n");
            sb.Append("  DoNotChangeShiftStartTimes: ").Append(DoNotChangeShiftStartTimes).Append("\n");
            sb.Append("  DoNotChangeManuallyEditedShifts: ").Append(DoNotChangeManuallyEditedShifts).Append("\n");
            sb.Append("  ExistingScheduleId: ").Append(ExistingScheduleId).Append("\n");
            sb.Append("  ExistingScheduleVersion: ").Append(ExistingScheduleVersion).Append("\n");
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
            return this.Equals(obj as ReschedulingOptionsResponse);
        }

        /// <summary>
        /// Returns true if ReschedulingOptionsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ReschedulingOptionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReschedulingOptionsResponse other)
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
                    this.ExistingScheduleId == other.ExistingScheduleId ||
                    this.ExistingScheduleId != null &&
                    this.ExistingScheduleId.Equals(other.ExistingScheduleId)
                ) &&
                (
                    this.ExistingScheduleVersion == other.ExistingScheduleVersion ||
                    this.ExistingScheduleVersion != null &&
                    this.ExistingScheduleVersion.Equals(other.ExistingScheduleVersion)
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
                
                if (this.DoNotChangeWeeklyPaidTime != null)
                    hash = hash * 59 + this.DoNotChangeWeeklyPaidTime.GetHashCode();
                
                if (this.DoNotChangeDailyPaidTime != null)
                    hash = hash * 59 + this.DoNotChangeDailyPaidTime.GetHashCode();
                
                if (this.DoNotChangeShiftStartTimes != null)
                    hash = hash * 59 + this.DoNotChangeShiftStartTimes.GetHashCode();
                
                if (this.DoNotChangeManuallyEditedShifts != null)
                    hash = hash * 59 + this.DoNotChangeManuallyEditedShifts.GetHashCode();
                
                if (this.ExistingScheduleId != null)
                    hash = hash * 59 + this.ExistingScheduleId.GetHashCode();
                
                if (this.ExistingScheduleVersion != null)
                    hash = hash * 59 + this.ExistingScheduleVersion.GetHashCode();
                
                return hash;
            }
        }
    }

}
