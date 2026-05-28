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
    /// OpportunityResultWithAgentIds
    /// </summary>
    [DataContract]
    public partial class OpportunityResultWithAgentIds :  IEquatable<OpportunityResultWithAgentIds>
    {
        /// <summary>
        /// The current status of the opportunity
        /// </summary>
        /// <value>The current status of the opportunity</value>
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
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Published for "Published"
            /// </summary>
            [EnumMember(Value = "Published")]
            Published,
            
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
        /// The approval type for enrollments
        /// </summary>
        /// <value>The approval type for enrollments</value>
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
        /// The system-generated message code about opportunity processing issues or validation failures
        /// </summary>
        /// <value>The system-generated message code about opportunity processing issues or validation failures</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SystemMessageCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Activitychanged for "ActivityChanged"
            /// </summary>
            [EnumMember(Value = "ActivityChanged")]
            Activitychanged,
            
            /// <summary>
            /// Enum Agentenrollmentshourlylimitexceeded for "AgentEnrollmentsHourlyLimitExceeded"
            /// </summary>
            [EnumMember(Value = "AgentEnrollmentsHourlyLimitExceeded")]
            Agentenrollmentshourlylimitexceeded,
            
            /// <summary>
            /// Enum Batchlimitexceeded for "BatchLimitExceeded"
            /// </summary>
            [EnumMember(Value = "BatchLimitExceeded")]
            Batchlimitexceeded,
            
            /// <summary>
            /// Enum Businessunitenrollmentshourlylimitexceeded for "BusinessUnitEnrollmentsHourlyLimitExceeded"
            /// </summary>
            [EnumMember(Value = "BusinessUnitEnrollmentsHourlyLimitExceeded")]
            Businessunitenrollmentshourlylimitexceeded,
            
            /// <summary>
            /// Enum Businessunitnotfound for "BusinessUnitNotFound"
            /// </summary>
            [EnumMember(Value = "BusinessUnitNotFound")]
            Businessunitnotfound,
            
            /// <summary>
            /// Enum Businessunitopportunityhourlylimitexceeded for "BusinessUnitOpportunityHourlyLimitExceeded"
            /// </summary>
            [EnumMember(Value = "BusinessUnitOpportunityHourlyLimitExceeded")]
            Businessunitopportunityhourlylimitexceeded,
            
            /// <summary>
            /// Enum Capacityfull for "CapacityFull"
            /// </summary>
            [EnumMember(Value = "CapacityFull")]
            Capacityfull,
            
            /// <summary>
            /// Enum Conflict for "Conflict"
            /// </summary>
            [EnumMember(Value = "Conflict")]
            Conflict,
            
            /// <summary>
            /// Enum Datemustbeinfuture for "DateMustBeInFuture"
            /// </summary>
            [EnumMember(Value = "DateMustBeInFuture")]
            Datemustbeinfuture,
            
            /// <summary>
            /// Enum Deadlinemustbeafteropentime for "DeadlineMustBeAfterOpenTime"
            /// </summary>
            [EnumMember(Value = "DeadlineMustBeAfterOpenTime")]
            Deadlinemustbeafteropentime,
            
            /// <summary>
            /// Enum Deadlinemustbebeforeorequaltostarttime for "DeadlineMustBeBeforeOrEqualToStartTime"
            /// </summary>
            [EnumMember(Value = "DeadlineMustBeBeforeOrEqualToStartTime")]
            Deadlinemustbebeforeorequaltostarttime,
            
            /// <summary>
            /// Enum Endtimemustbeafterstarttime for "EndTimeMustBeAfterStartTime"
            /// </summary>
            [EnumMember(Value = "EndTimeMustBeAfterStartTime")]
            Endtimemustbeafterstarttime,
            
            /// <summary>
            /// Enum Enrollmentnotfound for "EnrollmentNotFound"
            /// </summary>
            [EnumMember(Value = "EnrollmentNotFound")]
            Enrollmentnotfound,
            
            /// <summary>
            /// Enum Internalerror for "InternalError"
            /// </summary>
            [EnumMember(Value = "InternalError")]
            Internalerror,
            
            /// <summary>
            /// Enum Internalerrorautoapproval for "InternalErrorAutoApproval"
            /// </summary>
            [EnumMember(Value = "InternalErrorAutoApproval")]
            Internalerrorautoapproval,
            
            /// <summary>
            /// Enum Internalerrordenial for "InternalErrorDenial"
            /// </summary>
            [EnumMember(Value = "InternalErrorDenial")]
            Internalerrordenial,
            
            /// <summary>
            /// Enum Internalerrorscheduleupdate for "InternalErrorScheduleUpdate"
            /// </summary>
            [EnumMember(Value = "InternalErrorScheduleUpdate")]
            Internalerrorscheduleupdate,
            
            /// <summary>
            /// Enum Invalidopportunitylength for "InvalidOpportunityLength"
            /// </summary>
            [EnumMember(Value = "InvalidOpportunityLength")]
            Invalidopportunitylength,
            
            /// <summary>
            /// Enum Invalidopportunitystatus for "InvalidOpportunityStatus"
            /// </summary>
            [EnumMember(Value = "InvalidOpportunityStatus")]
            Invalidopportunitystatus,
            
            /// <summary>
            /// Enum Invalidrequest for "InvalidRequest"
            /// </summary>
            [EnumMember(Value = "InvalidRequest")]
            Invalidrequest,
            
            /// <summary>
            /// Enum Invalidstatustransition for "InvalidStatusTransition"
            /// </summary>
            [EnumMember(Value = "InvalidStatusTransition")]
            Invalidstatustransition,
            
            /// <summary>
            /// Enum Invalidtime for "InvalidTime"
            /// </summary>
            [EnumMember(Value = "InvalidTime")]
            Invalidtime,
            
            /// <summary>
            /// Enum Noinvitationsforpublish for "NoInvitationsForPublish"
            /// </summary>
            [EnumMember(Value = "NoInvitationsForPublish")]
            Noinvitationsforpublish,
            
            /// <summary>
            /// Enum Opentimemustbebeforestarttime for "OpenTimeMustBeBeforeStartTime"
            /// </summary>
            [EnumMember(Value = "OpenTimeMustBeBeforeStartTime")]
            Opentimemustbebeforestarttime,
            
            /// <summary>
            /// Enum Opportunityclosed for "OpportunityClosed"
            /// </summary>
            [EnumMember(Value = "OpportunityClosed")]
            Opportunityclosed,
            
            /// <summary>
            /// Enum Opportunitynotfound for "OpportunityNotFound"
            /// </summary>
            [EnumMember(Value = "OpportunityNotFound")]
            Opportunitynotfound,
            
            /// <summary>
            /// Enum Opportunitynotopen for "OpportunityNotOpen"
            /// </summary>
            [EnumMember(Value = "OpportunityNotOpen")]
            Opportunitynotopen,
            
            /// <summary>
            /// Enum Scheduleconflict for "ScheduleConflict"
            /// </summary>
            [EnumMember(Value = "ScheduleConflict")]
            Scheduleconflict,
            
            /// <summary>
            /// Enum Schedulenotfound for "ScheduleNotFound"
            /// </summary>
            [EnumMember(Value = "ScheduleNotFound")]
            Schedulenotfound,
            
            /// <summary>
            /// Enum Serviceunavailable for "ServiceUnavailable"
            /// </summary>
            [EnumMember(Value = "ServiceUnavailable")]
            Serviceunavailable,
            
            /// <summary>
            /// Enum Starttimemustbewithinoneyear for "StartTimeMustBeWithinOneYear"
            /// </summary>
            [EnumMember(Value = "StartTimeMustBeWithinOneYear")]
            Starttimemustbewithinoneyear,
            
            /// <summary>
            /// Enum Statusnotdraft for "StatusNotDraft"
            /// </summary>
            [EnumMember(Value = "StatusNotDraft")]
            Statusnotdraft
        }
        /// <summary>
        /// The current status of the opportunity
        /// </summary>
        /// <value>The current status of the opportunity</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The approval type for enrollments
        /// </summary>
        /// <value>The approval type for enrollments</value>
        [DataMember(Name="approvalType", EmitDefaultValue=false)]
        public ApprovalTypeEnum? ApprovalType { get; set; }
        /// <summary>
        /// The system-generated message code about opportunity processing issues or validation failures
        /// </summary>
        /// <value>The system-generated message code about opportunity processing issues or validation failures</value>
        [DataMember(Name="systemMessageCode", EmitDefaultValue=false)]
        public SystemMessageCodeEnum? SystemMessageCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunityResultWithAgentIds" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpportunityResultWithAgentIds() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunityResultWithAgentIds" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="StartDate">The start date and time of the opportunity in ISO-8601 format (required).</param>
        /// <param name="EndDate">The end date and time of the opportunity in ISO-8601 format (required).</param>
        /// <param name="Status">The current status of the opportunity (required).</param>
        /// <param name="OpenDate">The date and time when the opportunity opens for enrollment in ISO-8601 format. If not provided or in the past, it will be automatically updated to the current time when the opportunity is published.</param>
        /// <param name="DeadlineDate">The deadline date and time for enrollment in the opportunity in ISO-8601 format (required).</param>
        /// <param name="Name">The name of the opportunity (required).</param>
        /// <param name="Description">Additional details describing the purpose or context of this opportunity.</param>
        /// <param name="ActivityCodeId">The ID of the activity code associated with the opportunity (required).</param>
        /// <param name="ApprovalType">The approval type for enrollments (required).</param>
        /// <param name="AgentCount">The total number of agents invited to this opportunity (required).</param>
        /// <param name="Capacity">The maximum capacity (enrollment slots) for this opportunity (required).</param>
        /// <param name="EnrollmentProcessingCount">The number of enrollments currently being processed (required).</param>
        /// <param name="EnrollmentCounts">The counts for enrollment statuses (required).</param>
        /// <param name="PublishedDate">The date and time when the opportunity was published in ISO-8601 format.</param>
        /// <param name="ClosedDate">The date and time when the opportunity was closed in ISO-8601 format.</param>
        /// <param name="SystemMessageCode">The system-generated message code about opportunity processing issues or validation failures.</param>
        /// <param name="Metadata">The metadata for the opportunity (required).</param>
        /// <param name="AgentIds">The IDs of the agents that are invited to the opportunity.</param>
        public OpportunityResultWithAgentIds(string Id = null, DateTime? StartDate = null, DateTime? EndDate = null, StatusEnum? Status = null, DateTime? OpenDate = null, DateTime? DeadlineDate = null, string Name = null, string Description = null, string ActivityCodeId = null, ApprovalTypeEnum? ApprovalType = null, int? AgentCount = null, int? Capacity = null, int? EnrollmentProcessingCount = null, OpportunityEnrollmentCounts EnrollmentCounts = null, DateTime? PublishedDate = null, DateTime? ClosedDate = null, SystemMessageCodeEnum? SystemMessageCode = null, WfmVersionedEntityMetadata Metadata = null, List<string> AgentIds = null)
        {
            this.Id = Id;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Status = Status;
            this.OpenDate = OpenDate;
            this.DeadlineDate = DeadlineDate;
            this.Name = Name;
            this.Description = Description;
            this.ActivityCodeId = ActivityCodeId;
            this.ApprovalType = ApprovalType;
            this.AgentCount = AgentCount;
            this.Capacity = Capacity;
            this.EnrollmentProcessingCount = EnrollmentProcessingCount;
            this.EnrollmentCounts = EnrollmentCounts;
            this.PublishedDate = PublishedDate;
            this.ClosedDate = ClosedDate;
            this.SystemMessageCode = SystemMessageCode;
            this.Metadata = Metadata;
            this.AgentIds = AgentIds;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The start date and time of the opportunity in ISO-8601 format
        /// </summary>
        /// <value>The start date and time of the opportunity in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The end date and time of the opportunity in ISO-8601 format
        /// </summary>
        /// <value>The end date and time of the opportunity in ISO-8601 format</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }





        /// <summary>
        /// The date and time when the opportunity opens for enrollment in ISO-8601 format. If not provided or in the past, it will be automatically updated to the current time when the opportunity is published
        /// </summary>
        /// <value>The date and time when the opportunity opens for enrollment in ISO-8601 format. If not provided or in the past, it will be automatically updated to the current time when the opportunity is published</value>
        [DataMember(Name="openDate", EmitDefaultValue=false)]
        public DateTime? OpenDate { get; set; }



        /// <summary>
        /// The deadline date and time for enrollment in the opportunity in ISO-8601 format
        /// </summary>
        /// <value>The deadline date and time for enrollment in the opportunity in ISO-8601 format</value>
        [DataMember(Name="deadlineDate", EmitDefaultValue=false)]
        public DateTime? DeadlineDate { get; set; }



        /// <summary>
        /// The name of the opportunity
        /// </summary>
        /// <value>The name of the opportunity</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Additional details describing the purpose or context of this opportunity
        /// </summary>
        /// <value>Additional details describing the purpose or context of this opportunity</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The ID of the activity code associated with the opportunity
        /// </summary>
        /// <value>The ID of the activity code associated with the opportunity</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }





        /// <summary>
        /// The total number of agents invited to this opportunity
        /// </summary>
        /// <value>The total number of agents invited to this opportunity</value>
        [DataMember(Name="agentCount", EmitDefaultValue=false)]
        public int? AgentCount { get; set; }



        /// <summary>
        /// The maximum capacity (enrollment slots) for this opportunity
        /// </summary>
        /// <value>The maximum capacity (enrollment slots) for this opportunity</value>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public int? Capacity { get; set; }



        /// <summary>
        /// The number of enrollments currently being processed
        /// </summary>
        /// <value>The number of enrollments currently being processed</value>
        [DataMember(Name="enrollmentProcessingCount", EmitDefaultValue=false)]
        public int? EnrollmentProcessingCount { get; set; }



        /// <summary>
        /// The counts for enrollment statuses
        /// </summary>
        /// <value>The counts for enrollment statuses</value>
        [DataMember(Name="enrollmentCounts", EmitDefaultValue=false)]
        public OpportunityEnrollmentCounts EnrollmentCounts { get; set; }



        /// <summary>
        /// The date and time when the opportunity was published in ISO-8601 format
        /// </summary>
        /// <value>The date and time when the opportunity was published in ISO-8601 format</value>
        [DataMember(Name="publishedDate", EmitDefaultValue=false)]
        public DateTime? PublishedDate { get; set; }



        /// <summary>
        /// The date and time when the opportunity was closed in ISO-8601 format
        /// </summary>
        /// <value>The date and time when the opportunity was closed in ISO-8601 format</value>
        [DataMember(Name="closedDate", EmitDefaultValue=false)]
        public DateTime? ClosedDate { get; set; }





        /// <summary>
        /// The metadata for the opportunity
        /// </summary>
        /// <value>The metadata for the opportunity</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }



        /// <summary>
        /// The IDs of the agents that are invited to the opportunity
        /// </summary>
        /// <value>The IDs of the agents that are invited to the opportunity</value>
        [DataMember(Name="agentIds", EmitDefaultValue=false)]
        public List<string> AgentIds { get; set; }



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
            sb.Append("class OpportunityResultWithAgentIds {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  OpenDate: ").Append(OpenDate).Append("\n");
            sb.Append("  DeadlineDate: ").Append(DeadlineDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  ApprovalType: ").Append(ApprovalType).Append("\n");
            sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  EnrollmentProcessingCount: ").Append(EnrollmentProcessingCount).Append("\n");
            sb.Append("  EnrollmentCounts: ").Append(EnrollmentCounts).Append("\n");
            sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
            sb.Append("  ClosedDate: ").Append(ClosedDate).Append("\n");
            sb.Append("  SystemMessageCode: ").Append(SystemMessageCode).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
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
            return this.Equals(obj as OpportunityResultWithAgentIds);
        }

        /// <summary>
        /// Returns true if OpportunityResultWithAgentIds instances are equal
        /// </summary>
        /// <param name="other">Instance of OpportunityResultWithAgentIds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpportunityResultWithAgentIds other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.OpenDate == other.OpenDate ||
                    this.OpenDate != null &&
                    this.OpenDate.Equals(other.OpenDate)
                ) &&
                (
                    this.DeadlineDate == other.DeadlineDate ||
                    this.DeadlineDate != null &&
                    this.DeadlineDate.Equals(other.DeadlineDate)
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
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.ApprovalType == other.ApprovalType ||
                    this.ApprovalType != null &&
                    this.ApprovalType.Equals(other.ApprovalType)
                ) &&
                (
                    this.AgentCount == other.AgentCount ||
                    this.AgentCount != null &&
                    this.AgentCount.Equals(other.AgentCount)
                ) &&
                (
                    this.Capacity == other.Capacity ||
                    this.Capacity != null &&
                    this.Capacity.Equals(other.Capacity)
                ) &&
                (
                    this.EnrollmentProcessingCount == other.EnrollmentProcessingCount ||
                    this.EnrollmentProcessingCount != null &&
                    this.EnrollmentProcessingCount.Equals(other.EnrollmentProcessingCount)
                ) &&
                (
                    this.EnrollmentCounts == other.EnrollmentCounts ||
                    this.EnrollmentCounts != null &&
                    this.EnrollmentCounts.Equals(other.EnrollmentCounts)
                ) &&
                (
                    this.PublishedDate == other.PublishedDate ||
                    this.PublishedDate != null &&
                    this.PublishedDate.Equals(other.PublishedDate)
                ) &&
                (
                    this.ClosedDate == other.ClosedDate ||
                    this.ClosedDate != null &&
                    this.ClosedDate.Equals(other.ClosedDate)
                ) &&
                (
                    this.SystemMessageCode == other.SystemMessageCode ||
                    this.SystemMessageCode != null &&
                    this.SystemMessageCode.Equals(other.SystemMessageCode)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.AgentIds == other.AgentIds ||
                    this.AgentIds != null &&
                    this.AgentIds.SequenceEqual(other.AgentIds)
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

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.OpenDate != null)
                    hash = hash * 59 + this.OpenDate.GetHashCode();

                if (this.DeadlineDate != null)
                    hash = hash * 59 + this.DeadlineDate.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.ApprovalType != null)
                    hash = hash * 59 + this.ApprovalType.GetHashCode();

                if (this.AgentCount != null)
                    hash = hash * 59 + this.AgentCount.GetHashCode();

                if (this.Capacity != null)
                    hash = hash * 59 + this.Capacity.GetHashCode();

                if (this.EnrollmentProcessingCount != null)
                    hash = hash * 59 + this.EnrollmentProcessingCount.GetHashCode();

                if (this.EnrollmentCounts != null)
                    hash = hash * 59 + this.EnrollmentCounts.GetHashCode();

                if (this.PublishedDate != null)
                    hash = hash * 59 + this.PublishedDate.GetHashCode();

                if (this.ClosedDate != null)
                    hash = hash * 59 + this.ClosedDate.GetHashCode();

                if (this.SystemMessageCode != null)
                    hash = hash * 59 + this.SystemMessageCode.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.AgentIds != null)
                    hash = hash * 59 + this.AgentIds.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
