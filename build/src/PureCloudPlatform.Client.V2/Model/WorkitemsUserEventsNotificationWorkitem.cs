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
    /// WorkitemsUserEventsNotificationWorkitem
    /// </summary>
    [DataContract]
    public partial class WorkitemsUserEventsNotificationWorkitem :  IEquatable<WorkitemsUserEventsNotificationWorkitem>
    {
        /// <summary>
        /// Gets or Sets StatusCategory
        /// </summary>
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
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
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
            Closed
        }
        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperationEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Add for "add"
            /// </summary>
            [EnumMember(Value = "add")]
            Add,
            
            /// <summary>
            /// Enum Edit for "edit"
            /// </summary>
            [EnumMember(Value = "edit")]
            Edit,
            
            /// <summary>
            /// Enum Delete for "delete"
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete,
            
            /// <summary>
            /// Enum View for "view"
            /// </summary>
            [EnumMember(Value = "view")]
            View,
            
            /// <summary>
            /// Enum Upload for "upload"
            /// </summary>
            [EnumMember(Value = "upload")]
            Upload,
            
            /// <summary>
            /// Enum Download for "download"
            /// </summary>
            [EnumMember(Value = "download")]
            Download,
            
            /// <summary>
            /// Enum Activate for "activate"
            /// </summary>
            [EnumMember(Value = "activate")]
            Activate,
            
            /// <summary>
            /// Enum Deactivate for "deactivate"
            /// </summary>
            [EnumMember(Value = "deactivate")]
            Deactivate,
            
            /// <summary>
            /// Enum Purge for "purge"
            /// </summary>
            [EnumMember(Value = "purge")]
            Purge,
            
            /// <summary>
            /// Enum Processed for "processed"
            /// </summary>
            [EnumMember(Value = "processed")]
            Processed,
            
            /// <summary>
            /// Enum Published for "published"
            /// </summary>
            [EnumMember(Value = "published")]
            Published,
            
            /// <summary>
            /// Enum Assigned for "assigned"
            /// </summary>
            [EnumMember(Value = "assigned")]
            Assigned,
            
            /// <summary>
            /// Enum Unassigned for "unassigned"
            /// </summary>
            [EnumMember(Value = "unassigned")]
            Unassigned,
            
            /// <summary>
            /// Enum Reset for "reset"
            /// </summary>
            [EnumMember(Value = "reset")]
            Reset,
            
            /// <summary>
            /// Enum Reassigned for "reassigned"
            /// </summary>
            [EnumMember(Value = "reassigned")]
            Reassigned,
            
            /// <summary>
            /// Enum Reassign for "reassign"
            /// </summary>
            [EnumMember(Value = "reassign")]
            Reassign,
            
            /// <summary>
            /// Enum Archive for "archive"
            /// </summary>
            [EnumMember(Value = "archive")]
            Archive,
            
            /// <summary>
            /// Enum Unarchive for "unarchive"
            /// </summary>
            [EnumMember(Value = "unarchive")]
            Unarchive,
            
            /// <summary>
            /// Enum Reschedule for "reschedule"
            /// </summary>
            [EnumMember(Value = "reschedule")]
            Reschedule
        }
        /// <summary>
        /// Gets or Sets AssignmentState
        /// </summary>
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
            /// Enum Idle for "Idle"
            /// </summary>
            [EnumMember(Value = "Idle")]
            Idle,
            
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
            /// Enum Acdexpired for "AcdExpired"
            /// </summary>
            [EnumMember(Value = "AcdExpired")]
            Acdexpired
        }
        /// <summary>
        /// Gets or Sets StatusCategory
        /// </summary>
        [DataMember(Name="statusCategory", EmitDefaultValue=false)]
        public StatusCategoryEnum? StatusCategory { get; set; }
        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }
        /// <summary>
        /// Gets or Sets AssignmentState
        /// </summary>
        [DataMember(Name="assignmentState", EmitDefaultValue=false)]
        public AssignmentStateEnum? AssignmentState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemsUserEventsNotificationWorkitem" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="TypeId">TypeId.</param>
        /// <param name="Description">Description.</param>
        /// <param name="LanguageId">LanguageId.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="DateDue">DateDue.</param>
        /// <param name="DateExpires">DateExpires.</param>
        /// <param name="DurationSeconds">DurationSeconds.</param>
        /// <param name="Ttl">Ttl.</param>
        /// <param name="StatusId">StatusId.</param>
        /// <param name="StatusCategory">StatusCategory.</param>
        /// <param name="DateClosed">DateClosed.</param>
        /// <param name="WorkbinId">WorkbinId.</param>
        /// <param name="ReporterId">ReporterId.</param>
        /// <param name="AssigneeId">AssigneeId.</param>
        /// <param name="ExternalContactId">ExternalContactId.</param>
        /// <param name="ExternalTag">ExternalTag.</param>
        /// <param name="WrapupId">WrapupId.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="Operation">Operation.</param>
        /// <param name="Changes">Changes.</param>
        /// <param name="AssignmentState">AssignmentState.</param>
        /// <param name="AssignmentId">AssignmentId.</param>
        /// <param name="AlertTimeoutSeconds">AlertTimeoutSeconds.</param>
        /// <param name="QueueId">QueueId.</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="Wrapup">Wrapup.</param>
        public WorkitemsUserEventsNotificationWorkitem(string Id = null, string Name = null, string TypeId = null, string Description = null, string LanguageId = null, int? Priority = null, string DateCreated = null, string DateModified = null, string DateDue = null, string DateExpires = null, int? DurationSeconds = null, int? Ttl = null, string StatusId = null, StatusCategoryEnum? StatusCategory = null, string DateClosed = null, string WorkbinId = null, string ReporterId = null, string AssigneeId = null, string ExternalContactId = null, string ExternalTag = null, string WrapupId = null, string ModifiedBy = null, OperationEnum? Operation = null, List<WorkitemsUserEventsNotificationDelta> Changes = null, AssignmentStateEnum? AssignmentState = null, string AssignmentId = null, int? AlertTimeoutSeconds = null, string QueueId = null, Dictionary<string, WorkitemsUserEventsNotificationCustomAttribute> CustomFields = null, WorkitemsUserEventsNotificationWrapup Wrapup = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.TypeId = TypeId;
            this.Description = Description;
            this.LanguageId = LanguageId;
            this.Priority = Priority;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.DateDue = DateDue;
            this.DateExpires = DateExpires;
            this.DurationSeconds = DurationSeconds;
            this.Ttl = Ttl;
            this.StatusId = StatusId;
            this.StatusCategory = StatusCategory;
            this.DateClosed = DateClosed;
            this.WorkbinId = WorkbinId;
            this.ReporterId = ReporterId;
            this.AssigneeId = AssigneeId;
            this.ExternalContactId = ExternalContactId;
            this.ExternalTag = ExternalTag;
            this.WrapupId = WrapupId;
            this.ModifiedBy = ModifiedBy;
            this.Operation = Operation;
            this.Changes = Changes;
            this.AssignmentState = AssignmentState;
            this.AssignmentId = AssignmentId;
            this.AlertTimeoutSeconds = AlertTimeoutSeconds;
            this.QueueId = QueueId;
            this.CustomFields = CustomFields;
            this.Wrapup = Wrapup;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name="typeId", EmitDefaultValue=false)]
        public string TypeId { get; set; }



        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name="languageId", EmitDefaultValue=false)]
        public string LanguageId { get; set; }



        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }



        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public string DateCreated { get; set; }



        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public string DateModified { get; set; }



        /// <summary>
        /// Gets or Sets DateDue
        /// </summary>
        [DataMember(Name="dateDue", EmitDefaultValue=false)]
        public string DateDue { get; set; }



        /// <summary>
        /// Gets or Sets DateExpires
        /// </summary>
        [DataMember(Name="dateExpires", EmitDefaultValue=false)]
        public string DateExpires { get; set; }



        /// <summary>
        /// Gets or Sets DurationSeconds
        /// </summary>
        [DataMember(Name="durationSeconds", EmitDefaultValue=false)]
        public int? DurationSeconds { get; set; }



        /// <summary>
        /// Gets or Sets Ttl
        /// </summary>
        [DataMember(Name="ttl", EmitDefaultValue=false)]
        public int? Ttl { get; set; }



        /// <summary>
        /// Gets or Sets StatusId
        /// </summary>
        [DataMember(Name="statusId", EmitDefaultValue=false)]
        public string StatusId { get; set; }





        /// <summary>
        /// Gets or Sets DateClosed
        /// </summary>
        [DataMember(Name="dateClosed", EmitDefaultValue=false)]
        public string DateClosed { get; set; }



        /// <summary>
        /// Gets or Sets WorkbinId
        /// </summary>
        [DataMember(Name="workbinId", EmitDefaultValue=false)]
        public string WorkbinId { get; set; }



        /// <summary>
        /// Gets or Sets ReporterId
        /// </summary>
        [DataMember(Name="reporterId", EmitDefaultValue=false)]
        public string ReporterId { get; set; }



        /// <summary>
        /// Gets or Sets AssigneeId
        /// </summary>
        [DataMember(Name="assigneeId", EmitDefaultValue=false)]
        public string AssigneeId { get; set; }



        /// <summary>
        /// Gets or Sets ExternalContactId
        /// </summary>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }



        /// <summary>
        /// Gets or Sets ExternalTag
        /// </summary>
        [DataMember(Name="externalTag", EmitDefaultValue=false)]
        public string ExternalTag { get; set; }



        /// <summary>
        /// Gets or Sets WrapupId
        /// </summary>
        [DataMember(Name="wrapupId", EmitDefaultValue=false)]
        public string WrapupId { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }





        /// <summary>
        /// Gets or Sets Changes
        /// </summary>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public List<WorkitemsUserEventsNotificationDelta> Changes { get; set; }





        /// <summary>
        /// Gets or Sets AssignmentId
        /// </summary>
        [DataMember(Name="assignmentId", EmitDefaultValue=false)]
        public string AssignmentId { get; set; }



        /// <summary>
        /// Gets or Sets AlertTimeoutSeconds
        /// </summary>
        [DataMember(Name="alertTimeoutSeconds", EmitDefaultValue=false)]
        public int? AlertTimeoutSeconds { get; set; }



        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, WorkitemsUserEventsNotificationCustomAttribute> CustomFields { get; set; }



        /// <summary>
        /// Gets or Sets Wrapup
        /// </summary>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public WorkitemsUserEventsNotificationWrapup Wrapup { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemsUserEventsNotificationWorkitem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DateDue: ").Append(DateDue).Append("\n");
            sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
            sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  StatusCategory: ").Append(StatusCategory).Append("\n");
            sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
            sb.Append("  WorkbinId: ").Append(WorkbinId).Append("\n");
            sb.Append("  ReporterId: ").Append(ReporterId).Append("\n");
            sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
            sb.Append("  WrapupId: ").Append(WrapupId).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  AssignmentState: ").Append(AssignmentState).Append("\n");
            sb.Append("  AssignmentId: ").Append(AssignmentId).Append("\n");
            sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
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
            return this.Equals(obj as WorkitemsUserEventsNotificationWorkitem);
        }

        /// <summary>
        /// Returns true if WorkitemsUserEventsNotificationWorkitem instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemsUserEventsNotificationWorkitem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemsUserEventsNotificationWorkitem other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.TypeId == other.TypeId ||
                    this.TypeId != null &&
                    this.TypeId.Equals(other.TypeId)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.LanguageId == other.LanguageId ||
                    this.LanguageId != null &&
                    this.LanguageId.Equals(other.LanguageId)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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
                    this.DurationSeconds == other.DurationSeconds ||
                    this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(other.DurationSeconds)
                ) &&
                (
                    this.Ttl == other.Ttl ||
                    this.Ttl != null &&
                    this.Ttl.Equals(other.Ttl)
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
                    this.DateClosed == other.DateClosed ||
                    this.DateClosed != null &&
                    this.DateClosed.Equals(other.DateClosed)
                ) &&
                (
                    this.WorkbinId == other.WorkbinId ||
                    this.WorkbinId != null &&
                    this.WorkbinId.Equals(other.WorkbinId)
                ) &&
                (
                    this.ReporterId == other.ReporterId ||
                    this.ReporterId != null &&
                    this.ReporterId.Equals(other.ReporterId)
                ) &&
                (
                    this.AssigneeId == other.AssigneeId ||
                    this.AssigneeId != null &&
                    this.AssigneeId.Equals(other.AssigneeId)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.ExternalTag == other.ExternalTag ||
                    this.ExternalTag != null &&
                    this.ExternalTag.Equals(other.ExternalTag)
                ) &&
                (
                    this.WrapupId == other.WrapupId ||
                    this.WrapupId != null &&
                    this.WrapupId.Equals(other.WrapupId)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
                ) &&
                (
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
                ) &&
                (
                    this.AssignmentState == other.AssignmentState ||
                    this.AssignmentState != null &&
                    this.AssignmentState.Equals(other.AssignmentState)
                ) &&
                (
                    this.AssignmentId == other.AssignmentId ||
                    this.AssignmentId != null &&
                    this.AssignmentId.Equals(other.AssignmentId)
                ) &&
                (
                    this.AlertTimeoutSeconds == other.AlertTimeoutSeconds ||
                    this.AlertTimeoutSeconds != null &&
                    this.AlertTimeoutSeconds.Equals(other.AlertTimeoutSeconds)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) &&
                (
                    this.Wrapup == other.Wrapup ||
                    this.Wrapup != null &&
                    this.Wrapup.Equals(other.Wrapup)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.TypeId != null)
                    hash = hash * 59 + this.TypeId.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.LanguageId != null)
                    hash = hash * 59 + this.LanguageId.GetHashCode();

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DateDue != null)
                    hash = hash * 59 + this.DateDue.GetHashCode();

                if (this.DateExpires != null)
                    hash = hash * 59 + this.DateExpires.GetHashCode();

                if (this.DurationSeconds != null)
                    hash = hash * 59 + this.DurationSeconds.GetHashCode();

                if (this.Ttl != null)
                    hash = hash * 59 + this.Ttl.GetHashCode();

                if (this.StatusId != null)
                    hash = hash * 59 + this.StatusId.GetHashCode();

                if (this.StatusCategory != null)
                    hash = hash * 59 + this.StatusCategory.GetHashCode();

                if (this.DateClosed != null)
                    hash = hash * 59 + this.DateClosed.GetHashCode();

                if (this.WorkbinId != null)
                    hash = hash * 59 + this.WorkbinId.GetHashCode();

                if (this.ReporterId != null)
                    hash = hash * 59 + this.ReporterId.GetHashCode();

                if (this.AssigneeId != null)
                    hash = hash * 59 + this.AssigneeId.GetHashCode();

                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                if (this.ExternalTag != null)
                    hash = hash * 59 + this.ExternalTag.GetHashCode();

                if (this.WrapupId != null)
                    hash = hash * 59 + this.WrapupId.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();

                if (this.Changes != null)
                    hash = hash * 59 + this.Changes.GetHashCode();

                if (this.AssignmentState != null)
                    hash = hash * 59 + this.AssignmentState.GetHashCode();

                if (this.AssignmentId != null)
                    hash = hash * 59 + this.AssignmentId.GetHashCode();

                if (this.AlertTimeoutSeconds != null)
                    hash = hash * 59 + this.AlertTimeoutSeconds.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();

                if (this.Wrapup != null)
                    hash = hash * 59 + this.Wrapup.GetHashCode();

                return hash;
            }
        }
    }

}
