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
    /// V2WfmAgentOpportunityTopicAgentOpportunityNotification
    /// </summary>
    [DataContract]
    public partial class V2WfmAgentOpportunityTopicAgentOpportunityNotification :  IEquatable<V2WfmAgentOpportunityTopicAgentOpportunityNotification>
    {
        /// <summary>
        /// Gets or Sets ApprovalType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ApprovalTypeEnum
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
            /// Enum Automatic for "Automatic"
            /// </summary>
            [EnumMember(Value = "Automatic")]
            Automatic,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed
        }
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EventTypeEnum
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
            /// Enum Opened for "Opened"
            /// </summary>
            [EnumMember(Value = "Opened")]
            Opened,
            
            /// <summary>
            /// Enum Signedup for "SignedUp"
            /// </summary>
            [EnumMember(Value = "SignedUp")]
            Signedup,
            
            /// <summary>
            /// Enum Approvedautomatically for "ApprovedAutomatically"
            /// </summary>
            [EnumMember(Value = "ApprovedAutomatically")]
            Approvedautomatically,
            
            /// <summary>
            /// Enum Approvedmanually for "ApprovedManually"
            /// </summary>
            [EnumMember(Value = "ApprovedManually")]
            Approvedmanually,
            
            /// <summary>
            /// Enum Withdrawn for "Withdrawn"
            /// </summary>
            [EnumMember(Value = "Withdrawn")]
            Withdrawn,
            
            /// <summary>
            /// Enum Denied for "Denied"
            /// </summary>
            [EnumMember(Value = "Denied")]
            Denied
        }
        /// <summary>
        /// Gets or Sets DenialCode
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DenialCodeEnum
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
            /// Enum Manuallydenied for "ManuallyDenied"
            /// </summary>
            [EnumMember(Value = "ManuallyDenied")]
            Manuallydenied,
            
            /// <summary>
            /// Enum Automaticallyclosed for "AutomaticallyClosed"
            /// </summary>
            [EnumMember(Value = "AutomaticallyClosed")]
            Automaticallyclosed,
            
            /// <summary>
            /// Enum Manuallyclosed for "ManuallyClosed"
            /// </summary>
            [EnumMember(Value = "ManuallyClosed")]
            Manuallyclosed,
            
            /// <summary>
            /// Enum Capacityfull for "CapacityFull"
            /// </summary>
            [EnumMember(Value = "CapacityFull")]
            Capacityfull,
            
            /// <summary>
            /// Enum Scheduleconflict for "ScheduleConflict"
            /// </summary>
            [EnumMember(Value = "ScheduleConflict")]
            Scheduleconflict
        }
        /// <summary>
        /// Gets or Sets ApprovalType
        /// </summary>
        [DataMember(Name="approvalType", EmitDefaultValue=false)]
        public ApprovalTypeEnum? ApprovalType { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Gets or Sets DenialCode
        /// </summary>
        [DataMember(Name="denialCode", EmitDefaultValue=false)]
        public DenialCodeEnum? DenialCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2WfmAgentOpportunityTopicAgentOpportunityNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="BusinessUnitId">BusinessUnitId.</param>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="AgentIds">AgentIds.</param>
        /// <param name="OpportunityStartDate">OpportunityStartDate.</param>
        /// <param name="OpportunityEndDate">OpportunityEndDate.</param>
        /// <param name="OpenDate">OpenDate.</param>
        /// <param name="ApprovalType">ApprovalType.</param>
        /// <param name="LengthMinutes">LengthMinutes.</param>
        /// <param name="DeadlineDate">DeadlineDate.</param>
        /// <param name="ActivityCodeId">ActivityCodeId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="ClosedDate">ClosedDate.</param>
        /// <param name="Status">Status.</param>
        /// <param name="EventType">EventType.</param>
        /// <param name="DenialCode">DenialCode.</param>
        /// <param name="ReviewNote">ReviewNote.</param>
        /// <param name="RemainingSpaces">RemainingSpaces.</param>
        public V2WfmAgentOpportunityTopicAgentOpportunityNotification(string Id = null, string BusinessUnitId = null, string OrganizationId = null, List<string> AgentIds = null, string OpportunityStartDate = null, string OpportunityEndDate = null, string OpenDate = null, ApprovalTypeEnum? ApprovalType = null, long? LengthMinutes = null, string DeadlineDate = null, string ActivityCodeId = null, string Name = null, string Description = null, string ClosedDate = null, StatusEnum? Status = null, EventTypeEnum? EventType = null, DenialCodeEnum? DenialCode = null, string ReviewNote = null, long? RemainingSpaces = null)
        {
            this.Id = Id;
            this.BusinessUnitId = BusinessUnitId;
            this.OrganizationId = OrganizationId;
            this.AgentIds = AgentIds;
            this.OpportunityStartDate = OpportunityStartDate;
            this.OpportunityEndDate = OpportunityEndDate;
            this.OpenDate = OpenDate;
            this.ApprovalType = ApprovalType;
            this.LengthMinutes = LengthMinutes;
            this.DeadlineDate = DeadlineDate;
            this.ActivityCodeId = ActivityCodeId;
            this.Name = Name;
            this.Description = Description;
            this.ClosedDate = ClosedDate;
            this.Status = Status;
            this.EventType = EventType;
            this.DenialCode = DenialCode;
            this.ReviewNote = ReviewNote;
            this.RemainingSpaces = RemainingSpaces;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets BusinessUnitId
        /// </summary>
        [DataMember(Name="businessUnitId", EmitDefaultValue=false)]
        public string BusinessUnitId { get; set; }



        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }



        /// <summary>
        /// Gets or Sets AgentIds
        /// </summary>
        [DataMember(Name="agentIds", EmitDefaultValue=false)]
        public List<string> AgentIds { get; set; }



        /// <summary>
        /// Gets or Sets OpportunityStartDate
        /// </summary>
        [DataMember(Name="opportunityStartDate", EmitDefaultValue=false)]
        public string OpportunityStartDate { get; set; }



        /// <summary>
        /// Gets or Sets OpportunityEndDate
        /// </summary>
        [DataMember(Name="opportunityEndDate", EmitDefaultValue=false)]
        public string OpportunityEndDate { get; set; }



        /// <summary>
        /// Gets or Sets OpenDate
        /// </summary>
        [DataMember(Name="openDate", EmitDefaultValue=false)]
        public string OpenDate { get; set; }





        /// <summary>
        /// Gets or Sets LengthMinutes
        /// </summary>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public long? LengthMinutes { get; set; }



        /// <summary>
        /// Gets or Sets DeadlineDate
        /// </summary>
        [DataMember(Name="deadlineDate", EmitDefaultValue=false)]
        public string DeadlineDate { get; set; }



        /// <summary>
        /// Gets or Sets ActivityCodeId
        /// </summary>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Gets or Sets ClosedDate
        /// </summary>
        [DataMember(Name="closedDate", EmitDefaultValue=false)]
        public string ClosedDate { get; set; }









        /// <summary>
        /// Gets or Sets ReviewNote
        /// </summary>
        [DataMember(Name="reviewNote", EmitDefaultValue=false)]
        public string ReviewNote { get; set; }



        /// <summary>
        /// Gets or Sets RemainingSpaces
        /// </summary>
        [DataMember(Name="remainingSpaces", EmitDefaultValue=false)]
        public long? RemainingSpaces { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2WfmAgentOpportunityTopicAgentOpportunityNotification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
            sb.Append("  OpportunityStartDate: ").Append(OpportunityStartDate).Append("\n");
            sb.Append("  OpportunityEndDate: ").Append(OpportunityEndDate).Append("\n");
            sb.Append("  OpenDate: ").Append(OpenDate).Append("\n");
            sb.Append("  ApprovalType: ").Append(ApprovalType).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  DeadlineDate: ").Append(DeadlineDate).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ClosedDate: ").Append(ClosedDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  DenialCode: ").Append(DenialCode).Append("\n");
            sb.Append("  ReviewNote: ").Append(ReviewNote).Append("\n");
            sb.Append("  RemainingSpaces: ").Append(RemainingSpaces).Append("\n");
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
            return this.Equals(obj as V2WfmAgentOpportunityTopicAgentOpportunityNotification);
        }

        /// <summary>
        /// Returns true if V2WfmAgentOpportunityTopicAgentOpportunityNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of V2WfmAgentOpportunityTopicAgentOpportunityNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2WfmAgentOpportunityTopicAgentOpportunityNotification other)
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
                    this.BusinessUnitId == other.BusinessUnitId ||
                    this.BusinessUnitId != null &&
                    this.BusinessUnitId.Equals(other.BusinessUnitId)
                ) &&
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) &&
                (
                    this.AgentIds == other.AgentIds ||
                    this.AgentIds != null &&
                    this.AgentIds.SequenceEqual(other.AgentIds)
                ) &&
                (
                    this.OpportunityStartDate == other.OpportunityStartDate ||
                    this.OpportunityStartDate != null &&
                    this.OpportunityStartDate.Equals(other.OpportunityStartDate)
                ) &&
                (
                    this.OpportunityEndDate == other.OpportunityEndDate ||
                    this.OpportunityEndDate != null &&
                    this.OpportunityEndDate.Equals(other.OpportunityEndDate)
                ) &&
                (
                    this.OpenDate == other.OpenDate ||
                    this.OpenDate != null &&
                    this.OpenDate.Equals(other.OpenDate)
                ) &&
                (
                    this.ApprovalType == other.ApprovalType ||
                    this.ApprovalType != null &&
                    this.ApprovalType.Equals(other.ApprovalType)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.DeadlineDate == other.DeadlineDate ||
                    this.DeadlineDate != null &&
                    this.DeadlineDate.Equals(other.DeadlineDate)
                ) &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.ClosedDate == other.ClosedDate ||
                    this.ClosedDate != null &&
                    this.ClosedDate.Equals(other.ClosedDate)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) &&
                (
                    this.DenialCode == other.DenialCode ||
                    this.DenialCode != null &&
                    this.DenialCode.Equals(other.DenialCode)
                ) &&
                (
                    this.ReviewNote == other.ReviewNote ||
                    this.ReviewNote != null &&
                    this.ReviewNote.Equals(other.ReviewNote)
                ) &&
                (
                    this.RemainingSpaces == other.RemainingSpaces ||
                    this.RemainingSpaces != null &&
                    this.RemainingSpaces.Equals(other.RemainingSpaces)
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

                if (this.BusinessUnitId != null)
                    hash = hash * 59 + this.BusinessUnitId.GetHashCode();

                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();

                if (this.AgentIds != null)
                    hash = hash * 59 + this.AgentIds.GetHashCode();

                if (this.OpportunityStartDate != null)
                    hash = hash * 59 + this.OpportunityStartDate.GetHashCode();

                if (this.OpportunityEndDate != null)
                    hash = hash * 59 + this.OpportunityEndDate.GetHashCode();

                if (this.OpenDate != null)
                    hash = hash * 59 + this.OpenDate.GetHashCode();

                if (this.ApprovalType != null)
                    hash = hash * 59 + this.ApprovalType.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.DeadlineDate != null)
                    hash = hash * 59 + this.DeadlineDate.GetHashCode();

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.ClosedDate != null)
                    hash = hash * 59 + this.ClosedDate.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();

                if (this.DenialCode != null)
                    hash = hash * 59 + this.DenialCode.GetHashCode();

                if (this.ReviewNote != null)
                    hash = hash * 59 + this.ReviewNote.GetHashCode();

                if (this.RemainingSpaces != null)
                    hash = hash * 59 + this.RemainingSpaces.GetHashCode();

                return hash;
            }
        }
    }

}
