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
    /// Information containing details of a schedule run
    /// </summary>
    [DataContract]
    public partial class SchedulingRunResponse :  IEquatable<SchedulingRunResponse>
    {
        
        
        
        
        
        /// <summary>
        /// Status of the schedule run
        /// </summary>
        /// <value>Status of the schedule run</value>
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
        /// Status of the schedule run
        /// </summary>
        /// <value>Status of the schedule run</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingRunResponse" /> class.
        /// </summary>
        /// <param name="RunId">ID of the schedule run.</param>
        /// <param name="State">Status of the schedule run.</param>
        /// <param name="PercentComplete">Completion percentage of the schedule run.</param>
        /// <param name="TargetWeek">The start date of the week for which the scheduling is done in yyyy-MM-dd format.</param>
        /// <param name="ScheduleId">ID of the schedule.</param>
        /// <param name="ScheduleDescription">Description of the schedule run.</param>
        /// <param name="SchedulingStartTime">Start time of the schedule run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="SchedulingStartedBy">User that started the schedule run.</param>
        /// <param name="SchedulingCanceledBy">User that canceled the schedule run.</param>
        /// <param name="SchedulingCompletedTime">Time at which the scheduling run was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public SchedulingRunResponse(string RunId = null, StateEnum? State = null, double? PercentComplete = null, string TargetWeek = null, string ScheduleId = null, string ScheduleDescription = null, DateTime? SchedulingStartTime = null, UserReference SchedulingStartedBy = null, UserReference SchedulingCanceledBy = null, DateTime? SchedulingCompletedTime = null)
        {
            this.RunId = RunId;
            this.State = State;
            this.PercentComplete = PercentComplete;
            this.TargetWeek = TargetWeek;
            this.ScheduleId = ScheduleId;
            this.ScheduleDescription = ScheduleDescription;
            this.SchedulingStartTime = SchedulingStartTime;
            this.SchedulingStartedBy = SchedulingStartedBy;
            this.SchedulingCanceledBy = SchedulingCanceledBy;
            this.SchedulingCompletedTime = SchedulingCompletedTime;
            
        }
        
        
        
        /// <summary>
        /// ID of the schedule run
        /// </summary>
        /// <value>ID of the schedule run</value>
        [DataMember(Name="runId", EmitDefaultValue=false)]
        public string RunId { get; set; }
        
        
        
        
        
        /// <summary>
        /// Completion percentage of the schedule run
        /// </summary>
        /// <value>Completion percentage of the schedule run</value>
        [DataMember(Name="percentComplete", EmitDefaultValue=false)]
        public double? PercentComplete { get; set; }
        
        
        
        /// <summary>
        /// The start date of the week for which the scheduling is done in yyyy-MM-dd format
        /// </summary>
        /// <value>The start date of the week for which the scheduling is done in yyyy-MM-dd format</value>
        [DataMember(Name="targetWeek", EmitDefaultValue=false)]
        public string TargetWeek { get; set; }
        
        
        
        /// <summary>
        /// ID of the schedule
        /// </summary>
        /// <value>ID of the schedule</value>
        [DataMember(Name="scheduleId", EmitDefaultValue=false)]
        public string ScheduleId { get; set; }
        
        
        
        /// <summary>
        /// Description of the schedule run
        /// </summary>
        /// <value>Description of the schedule run</value>
        [DataMember(Name="scheduleDescription", EmitDefaultValue=false)]
        public string ScheduleDescription { get; set; }
        
        
        
        /// <summary>
        /// Start time of the schedule run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Start time of the schedule run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="schedulingStartTime", EmitDefaultValue=false)]
        public DateTime? SchedulingStartTime { get; set; }
        
        
        
        /// <summary>
        /// User that started the schedule run
        /// </summary>
        /// <value>User that started the schedule run</value>
        [DataMember(Name="schedulingStartedBy", EmitDefaultValue=false)]
        public UserReference SchedulingStartedBy { get; set; }
        
        
        
        /// <summary>
        /// User that canceled the schedule run
        /// </summary>
        /// <value>User that canceled the schedule run</value>
        [DataMember(Name="schedulingCanceledBy", EmitDefaultValue=false)]
        public UserReference SchedulingCanceledBy { get; set; }
        
        
        
        /// <summary>
        /// Time at which the scheduling run was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Time at which the scheduling run was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="schedulingCompletedTime", EmitDefaultValue=false)]
        public DateTime? SchedulingCompletedTime { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulingRunResponse {\n");
            
            sb.Append("  RunId: ").Append(RunId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
            sb.Append("  TargetWeek: ").Append(TargetWeek).Append("\n");
            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("  ScheduleDescription: ").Append(ScheduleDescription).Append("\n");
            sb.Append("  SchedulingStartTime: ").Append(SchedulingStartTime).Append("\n");
            sb.Append("  SchedulingStartedBy: ").Append(SchedulingStartedBy).Append("\n");
            sb.Append("  SchedulingCanceledBy: ").Append(SchedulingCanceledBy).Append("\n");
            sb.Append("  SchedulingCompletedTime: ").Append(SchedulingCompletedTime).Append("\n");
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
            return this.Equals(obj as SchedulingRunResponse);
        }

        /// <summary>
        /// Returns true if SchedulingRunResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SchedulingRunResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingRunResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RunId == other.RunId ||
                    this.RunId != null &&
                    this.RunId.Equals(other.RunId)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                    this.ScheduleId == other.ScheduleId ||
                    this.ScheduleId != null &&
                    this.ScheduleId.Equals(other.ScheduleId)
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
                
                if (this.RunId != null)
                    hash = hash * 59 + this.RunId.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.PercentComplete != null)
                    hash = hash * 59 + this.PercentComplete.GetHashCode();
                
                if (this.TargetWeek != null)
                    hash = hash * 59 + this.TargetWeek.GetHashCode();
                
                if (this.ScheduleId != null)
                    hash = hash * 59 + this.ScheduleId.GetHashCode();
                
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
                
                return hash;
            }
        }
    }

}
