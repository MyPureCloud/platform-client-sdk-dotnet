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
    /// AnalyticsAgentStateAgentWorkitemResult
    /// </summary>
    [DataContract]
    public partial class AnalyticsAgentStateAgentWorkitemResult :  IEquatable<AnalyticsAgentStateAgentWorkitemResult>
    {
        /// <summary>
        /// The category of the current status of the workitem
        /// </summary>
        /// <value>The category of the current status of the workitem</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Waiting for "Waiting"
            /// </summary>
            [EnumMember(Value = "Waiting")]
            Waiting,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Assignment state of the workitem
        /// </summary>
        /// <value>Assignment state of the workitem</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AssignmentStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Acdstarted for "AcdStarted"
            /// </summary>
            [EnumMember(Value = "AcdStarted")]
            Acdstarted,
            
            /// <summary>
            /// Enum Alerting for "Alerting"
            /// </summary>
            [EnumMember(Value = "Alerting")]
            Alerting,
            
            /// <summary>
            /// Enum Alerttimeout for "AlertTimeout"
            /// </summary>
            [EnumMember(Value = "AlertTimeout")]
            Alerttimeout,
            
            /// <summary>
            /// Enum Acdcancelled for "AcdCancelled"
            /// </summary>
            [EnumMember(Value = "AcdCancelled")]
            Acdcancelled,
            
            /// <summary>
            /// Enum Terminated for "Terminated"
            /// </summary>
            [EnumMember(Value = "Terminated")]
            Terminated,
            
            /// <summary>
            /// Enum Idle for "Idle"
            /// </summary>
            [EnumMember(Value = "Idle")]
            Idle,
            
            /// <summary>
            /// Enum Declined for "Declined"
            /// </summary>
            [EnumMember(Value = "Declined")]
            Declined,
            
            /// <summary>
            /// Enum Connected for "Connected"
            /// </summary>
            [EnumMember(Value = "Connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "Disconnected"
            /// </summary>
            [EnumMember(Value = "Disconnected")]
            Disconnected,
            
            /// <summary>
            /// Enum Parked for "Parked"
            /// </summary>
            [EnumMember(Value = "Parked")]
            Parked,
            
            /// <summary>
            /// Enum Held for "Held"
            /// </summary>
            [EnumMember(Value = "Held")]
            Held,
            
            /// <summary>
            /// Enum Acdexpired for "AcdExpired"
            /// </summary>
            [EnumMember(Value = "AcdExpired")]
            Acdexpired
        }
        /// <summary>
        /// The category of the current status of the workitem
        /// </summary>
        /// <value>The category of the current status of the workitem</value>
        [DataMember(Name="statusCategory", EmitDefaultValue=false)]
        public StatusCategoryEnum? StatusCategory { get; set; }
        /// <summary>
        /// Assignment state of the workitem
        /// </summary>
        /// <value>Assignment state of the workitem</value>
        [DataMember(Name="assignmentState", EmitDefaultValue=false)]
        public AssignmentStateEnum? AssignmentState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsAgentStateAgentWorkitemResult" /> class.
        /// </summary>
        /// <param name="Id">Workitem Id.</param>
        /// <param name="QueueId">The Id of the queue used for routing the workitem.</param>
        /// <param name="DivisionId">The Id of the division the workitem belongs to.</param>
        /// <param name="TypeId">The Id of the worktype of the workitem.</param>
        /// <param name="WorkbinId">The Id of the workbin the workitem is placed in.</param>
        /// <param name="DateDue">Due datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateExpires">Expiry datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="StatusId">The Id of the current status of the workitem.</param>
        /// <param name="StatusCategory">The category of the current status of the workitem.</param>
        /// <param name="DateStatusChanged">Datetime the status of the workitem last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Priority">Priority of the workitem.</param>
        /// <param name="AssignmentState">Assignment state of the workitem.</param>
        /// <param name="DateAssignmentStateChanged">Datetime the assignment state of the workitem last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateCreated">Creation datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public AnalyticsAgentStateAgentWorkitemResult(string Id = null, string QueueId = null, string DivisionId = null, string TypeId = null, string WorkbinId = null, DateTime? DateDue = null, DateTime? DateExpires = null, string StatusId = null, StatusCategoryEnum? StatusCategory = null, DateTime? DateStatusChanged = null, int? Priority = null, AssignmentStateEnum? AssignmentState = null, DateTime? DateAssignmentStateChanged = null, DateTime? DateCreated = null)
        {
            this.Id = Id;
            this.QueueId = QueueId;
            this.DivisionId = DivisionId;
            this.TypeId = TypeId;
            this.WorkbinId = WorkbinId;
            this.DateDue = DateDue;
            this.DateExpires = DateExpires;
            this.StatusId = StatusId;
            this.StatusCategory = StatusCategory;
            this.DateStatusChanged = DateStatusChanged;
            this.Priority = Priority;
            this.AssignmentState = AssignmentState;
            this.DateAssignmentStateChanged = DateAssignmentStateChanged;
            this.DateCreated = DateCreated;
            
        }
        


        /// <summary>
        /// Workitem Id
        /// </summary>
        /// <value>Workitem Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The Id of the queue used for routing the workitem
        /// </summary>
        /// <value>The Id of the queue used for routing the workitem</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// The Id of the division the workitem belongs to
        /// </summary>
        /// <value>The Id of the division the workitem belongs to</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// The Id of the worktype of the workitem
        /// </summary>
        /// <value>The Id of the worktype of the workitem</value>
        [DataMember(Name="typeId", EmitDefaultValue=false)]
        public string TypeId { get; set; }



        /// <summary>
        /// The Id of the workbin the workitem is placed in
        /// </summary>
        /// <value>The Id of the workbin the workitem is placed in</value>
        [DataMember(Name="workbinId", EmitDefaultValue=false)]
        public string WorkbinId { get; set; }



        /// <summary>
        /// Due datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Due datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateDue", EmitDefaultValue=false)]
        public DateTime? DateDue { get; set; }



        /// <summary>
        /// Expiry datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Expiry datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateExpires", EmitDefaultValue=false)]
        public DateTime? DateExpires { get; set; }



        /// <summary>
        /// The Id of the current status of the workitem
        /// </summary>
        /// <value>The Id of the current status of the workitem</value>
        [DataMember(Name="statusId", EmitDefaultValue=false)]
        public string StatusId { get; set; }





        /// <summary>
        /// Datetime the status of the workitem last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Datetime the status of the workitem last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStatusChanged", EmitDefaultValue=false)]
        public DateTime? DateStatusChanged { get; set; }



        /// <summary>
        /// Priority of the workitem
        /// </summary>
        /// <value>Priority of the workitem</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }





        /// <summary>
        /// Datetime the assignment state of the workitem last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Datetime the assignment state of the workitem last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateAssignmentStateChanged", EmitDefaultValue=false)]
        public DateTime? DateAssignmentStateChanged { get; set; }



        /// <summary>
        /// Creation datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Creation datetime of the workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsAgentStateAgentWorkitemResult {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  WorkbinId: ").Append(WorkbinId).Append("\n");
            sb.Append("  DateDue: ").Append(DateDue).Append("\n");
            sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  StatusCategory: ").Append(StatusCategory).Append("\n");
            sb.Append("  DateStatusChanged: ").Append(DateStatusChanged).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  AssignmentState: ").Append(AssignmentState).Append("\n");
            sb.Append("  DateAssignmentStateChanged: ").Append(DateAssignmentStateChanged).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
            return this.Equals(obj as AnalyticsAgentStateAgentWorkitemResult);
        }

        /// <summary>
        /// Returns true if AnalyticsAgentStateAgentWorkitemResult instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsAgentStateAgentWorkitemResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsAgentStateAgentWorkitemResult other)
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
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.TypeId == other.TypeId ||
                    this.TypeId != null &&
                    this.TypeId.Equals(other.TypeId)
                ) &&
                (
                    this.WorkbinId == other.WorkbinId ||
                    this.WorkbinId != null &&
                    this.WorkbinId.Equals(other.WorkbinId)
                ) &&
                (
                    this.DateDue == other.DateDue ||
                    this.DateDue != null &&
                    this.DateDue.Equals(other.DateDue)
                ) &&
                (
                    this.DateExpires == other.DateExpires ||
                    this.DateExpires != null &&
                    this.DateExpires.Equals(other.DateExpires)
                ) &&
                (
                    this.StatusId == other.StatusId ||
                    this.StatusId != null &&
                    this.StatusId.Equals(other.StatusId)
                ) &&
                (
                    this.StatusCategory == other.StatusCategory ||
                    this.StatusCategory != null &&
                    this.StatusCategory.Equals(other.StatusCategory)
                ) &&
                (
                    this.DateStatusChanged == other.DateStatusChanged ||
                    this.DateStatusChanged != null &&
                    this.DateStatusChanged.Equals(other.DateStatusChanged)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.AssignmentState == other.AssignmentState ||
                    this.AssignmentState != null &&
                    this.AssignmentState.Equals(other.AssignmentState)
                ) &&
                (
                    this.DateAssignmentStateChanged == other.DateAssignmentStateChanged ||
                    this.DateAssignmentStateChanged != null &&
                    this.DateAssignmentStateChanged.Equals(other.DateAssignmentStateChanged)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
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

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.TypeId != null)
                    hash = hash * 59 + this.TypeId.GetHashCode();

                if (this.WorkbinId != null)
                    hash = hash * 59 + this.WorkbinId.GetHashCode();

                if (this.DateDue != null)
                    hash = hash * 59 + this.DateDue.GetHashCode();

                if (this.DateExpires != null)
                    hash = hash * 59 + this.DateExpires.GetHashCode();

                if (this.StatusId != null)
                    hash = hash * 59 + this.StatusId.GetHashCode();

                if (this.StatusCategory != null)
                    hash = hash * 59 + this.StatusCategory.GetHashCode();

                if (this.DateStatusChanged != null)
                    hash = hash * 59 + this.DateStatusChanged.GetHashCode();

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.AssignmentState != null)
                    hash = hash * 59 + this.AssignmentState.GetHashCode();

                if (this.DateAssignmentStateChanged != null)
                    hash = hash * 59 + this.DateAssignmentStateChanged.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                return hash;
            }
        }
    }

}
