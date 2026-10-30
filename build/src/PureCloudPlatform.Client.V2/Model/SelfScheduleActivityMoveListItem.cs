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
    /// SelfScheduleActivityMoveListItem
    /// </summary>
    [DataContract]
    public partial class SelfScheduleActivityMoveListItem :  IEquatable<SelfScheduleActivityMoveListItem>
    {
        /// <summary>
        /// The state of the self-schedule operation
        /// </summary>
        /// <value>The state of the self-schedule operation</value>
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
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Denied for "Denied"
            /// </summary>
            [EnumMember(Value = "Denied")]
            Denied,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending
        }
        /// <summary>
        /// The processing status of this self-schedule operation
        /// </summary>
        /// <value>The processing status of this self-schedule operation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum WorkflowStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Reviewing for "Reviewing"
            /// </summary>
            [EnumMember(Value = "Reviewing")]
            Reviewing,
            
            /// <summary>
            /// Enum Scheduleupdated for "ScheduleUpdated"
            /// </summary>
            [EnumMember(Value = "ScheduleUpdated")]
            Scheduleupdated,
            
            /// <summary>
            /// Enum Scheduleupdating for "ScheduleUpdating"
            /// </summary>
            [EnumMember(Value = "ScheduleUpdating")]
            Scheduleupdating,
            
            /// <summary>
            /// Enum Waitingforreview for "WaitingForReview"
            /// </summary>
            [EnumMember(Value = "WaitingForReview")]
            Waitingforreview,
            
            /// <summary>
            /// Enum Waitingforscheduleupdate for "WaitingForScheduleUpdate"
            /// </summary>
            [EnumMember(Value = "WaitingForScheduleUpdate")]
            Waitingforscheduleupdate
        }
        /// <summary>
        /// The state of the self-schedule operation
        /// </summary>
        /// <value>The state of the self-schedule operation</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// The processing status of this self-schedule operation
        /// </summary>
        /// <value>The processing status of this self-schedule operation</value>
        [DataMember(Name="workflowStatus", EmitDefaultValue=false)]
        public WorkflowStatusEnum? WorkflowStatus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleActivityMoveListItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelfScheduleActivityMoveListItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleActivityMoveListItem" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="Schedule">The schedule to which the shift and activity are associated (required).</param>
        /// <param name="ShiftId">The ID of the shift to which this activity is associated (required).</param>
        /// <param name="State">The state of the self-schedule operation (required).</param>
        /// <param name="WorkflowStatus">The processing status of this self-schedule operation.</param>
        /// <param name="StartDate">The original start date of this activity in ISO-8601 format (required).</param>
        /// <param name="NewDate">The new start date of this activity in ISO-8601 format (required).</param>
        /// <param name="LengthMinutes">The length of this activity in minutes (required).</param>
        /// <param name="ActivityCode">The activity code related to this shift (required).</param>
        public SelfScheduleActivityMoveListItem(string Id = null, BuScheduleReference Schedule = null, string ShiftId = null, StateEnum? State = null, WorkflowStatusEnum? WorkflowStatus = null, DateTime? StartDate = null, DateTime? NewDate = null, int? LengthMinutes = null, ActivityCodeReference ActivityCode = null)
        {
            this.Id = Id;
            this.Schedule = Schedule;
            this.ShiftId = ShiftId;
            this.State = State;
            this.WorkflowStatus = WorkflowStatus;
            this.StartDate = StartDate;
            this.NewDate = NewDate;
            this.LengthMinutes = LengthMinutes;
            this.ActivityCode = ActivityCode;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The schedule to which the shift and activity are associated
        /// </summary>
        /// <value>The schedule to which the shift and activity are associated</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public BuScheduleReference Schedule { get; set; }



        /// <summary>
        /// The ID of the shift to which this activity is associated
        /// </summary>
        /// <value>The ID of the shift to which this activity is associated</value>
        [DataMember(Name="shiftId", EmitDefaultValue=false)]
        public string ShiftId { get; set; }







        /// <summary>
        /// The original start date of this activity in ISO-8601 format
        /// </summary>
        /// <value>The original start date of this activity in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The new start date of this activity in ISO-8601 format
        /// </summary>
        /// <value>The new start date of this activity in ISO-8601 format</value>
        [DataMember(Name="newDate", EmitDefaultValue=false)]
        public DateTime? NewDate { get; set; }



        /// <summary>
        /// The length of this activity in minutes
        /// </summary>
        /// <value>The length of this activity in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// The activity code related to this shift
        /// </summary>
        /// <value>The activity code related to this shift</value>
        [DataMember(Name="activityCode", EmitDefaultValue=false)]
        public ActivityCodeReference ActivityCode { get; set; }



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
            sb.Append("class SelfScheduleActivityMoveListItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  ShiftId: ").Append(ShiftId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  WorkflowStatus: ").Append(WorkflowStatus).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  NewDate: ").Append(NewDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
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
            return this.Equals(obj as SelfScheduleActivityMoveListItem);
        }

        /// <summary>
        /// Returns true if SelfScheduleActivityMoveListItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SelfScheduleActivityMoveListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelfScheduleActivityMoveListItem other)
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
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.ShiftId == other.ShiftId ||
                    this.ShiftId != null &&
                    this.ShiftId.Equals(other.ShiftId)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.WorkflowStatus == other.WorkflowStatus ||
                    this.WorkflowStatus != null &&
                    this.WorkflowStatus.Equals(other.WorkflowStatus)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.NewDate == other.NewDate ||
                    this.NewDate != null &&
                    this.NewDate.Equals(other.NewDate)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.ActivityCode == other.ActivityCode ||
                    this.ActivityCode != null &&
                    this.ActivityCode.Equals(other.ActivityCode)
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

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.ShiftId != null)
                    hash = hash * 59 + this.ShiftId.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.WorkflowStatus != null)
                    hash = hash * 59 + this.WorkflowStatus.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.NewDate != null)
                    hash = hash * 59 + this.NewDate.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.ActivityCode != null)
                    hash = hash * 59 + this.ActivityCode.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
