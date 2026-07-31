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
    /// V2WfmOpportunityTopicOpportunityNotification
    /// </summary>
    [DataContract]
    public partial class V2WfmOpportunityTopicOpportunityNotification :  IEquatable<V2WfmOpportunityTopicOpportunityNotification>
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
            /// Enum Published for "Published"
            /// </summary>
            [EnumMember(Value = "Published")]
            Published,
            
            /// <summary>
            /// Enum Created for "Created"
            /// </summary>
            [EnumMember(Value = "Created")]
            Created,
            
            /// <summary>
            /// Enum Updated for "Updated"
            /// </summary>
            [EnumMember(Value = "Updated")]
            Updated,
            
            /// <summary>
            /// Enum Opened for "Opened"
            /// </summary>
            [EnumMember(Value = "Opened")]
            Opened,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed,
            
            /// <summary>
            /// Enum Deadlinedatepassed for "DeadlineDatePassed"
            /// </summary>
            [EnumMember(Value = "DeadlineDatePassed")]
            Deadlinedatepassed
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
        /// Initializes a new instance of the <see cref="V2WfmOpportunityTopicOpportunityNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="BusinessUnitId">BusinessUnitId.</param>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="OpportunityStartDate">OpportunityStartDate.</param>
        /// <param name="OpportunityEndDate">OpportunityEndDate.</param>
        /// <param name="OpenDate">OpenDate.</param>
        /// <param name="ApprovalType">ApprovalType.</param>
        /// <param name="LengthMinutes">LengthMinutes.</param>
        /// <param name="DeadlineDate">DeadlineDate.</param>
        /// <param name="ActivityCodeId">ActivityCodeId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="PublishedDate">PublishedDate.</param>
        /// <param name="ClosedDate">ClosedDate.</param>
        /// <param name="Status">Status.</param>
        /// <param name="EventType">EventType.</param>
        /// <param name="PendingCount">PendingCount.</param>
        /// <param name="WithdrawnCount">WithdrawnCount.</param>
        /// <param name="ApprovedCount">ApprovedCount.</param>
        /// <param name="DeniedCount">DeniedCount.</param>
        /// <param name="RemainingSpaces">RemainingSpaces.</param>
        public V2WfmOpportunityTopicOpportunityNotification(string Id = null, string BusinessUnitId = null, string OrganizationId = null, string OpportunityStartDate = null, string OpportunityEndDate = null, string OpenDate = null, ApprovalTypeEnum? ApprovalType = null, long? LengthMinutes = null, string DeadlineDate = null, string ActivityCodeId = null, string Name = null, string Description = null, string CreatedDate = null, string PublishedDate = null, string ClosedDate = null, StatusEnum? Status = null, EventTypeEnum? EventType = null, long? PendingCount = null, long? WithdrawnCount = null, long? ApprovedCount = null, long? DeniedCount = null, long? RemainingSpaces = null)
        {
            this.Id = Id;
            this.BusinessUnitId = BusinessUnitId;
            this.OrganizationId = OrganizationId;
            this.OpportunityStartDate = OpportunityStartDate;
            this.OpportunityEndDate = OpportunityEndDate;
            this.OpenDate = OpenDate;
            this.ApprovalType = ApprovalType;
            this.LengthMinutes = LengthMinutes;
            this.DeadlineDate = DeadlineDate;
            this.ActivityCodeId = ActivityCodeId;
            this.Name = Name;
            this.Description = Description;
            this.CreatedDate = CreatedDate;
            this.PublishedDate = PublishedDate;
            this.ClosedDate = ClosedDate;
            this.Status = Status;
            this.EventType = EventType;
            this.PendingCount = PendingCount;
            this.WithdrawnCount = WithdrawnCount;
            this.ApprovedCount = ApprovedCount;
            this.DeniedCount = DeniedCount;
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
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public string CreatedDate { get; set; }



        /// <summary>
        /// Gets or Sets PublishedDate
        /// </summary>
        [DataMember(Name="publishedDate", EmitDefaultValue=false)]
        public string PublishedDate { get; set; }



        /// <summary>
        /// Gets or Sets ClosedDate
        /// </summary>
        [DataMember(Name="closedDate", EmitDefaultValue=false)]
        public string ClosedDate { get; set; }







        /// <summary>
        /// Gets or Sets PendingCount
        /// </summary>
        [DataMember(Name="pendingCount", EmitDefaultValue=false)]
        public long? PendingCount { get; set; }



        /// <summary>
        /// Gets or Sets WithdrawnCount
        /// </summary>
        [DataMember(Name="withdrawnCount", EmitDefaultValue=false)]
        public long? WithdrawnCount { get; set; }



        /// <summary>
        /// Gets or Sets ApprovedCount
        /// </summary>
        [DataMember(Name="approvedCount", EmitDefaultValue=false)]
        public long? ApprovedCount { get; set; }



        /// <summary>
        /// Gets or Sets DeniedCount
        /// </summary>
        [DataMember(Name="deniedCount", EmitDefaultValue=false)]
        public long? DeniedCount { get; set; }



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
            sb.Append("class V2WfmOpportunityTopicOpportunityNotification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  OpportunityStartDate: ").Append(OpportunityStartDate).Append("\n");
            sb.Append("  OpportunityEndDate: ").Append(OpportunityEndDate).Append("\n");
            sb.Append("  OpenDate: ").Append(OpenDate).Append("\n");
            sb.Append("  ApprovalType: ").Append(ApprovalType).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  DeadlineDate: ").Append(DeadlineDate).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
            sb.Append("  ClosedDate: ").Append(ClosedDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  PendingCount: ").Append(PendingCount).Append("\n");
            sb.Append("  WithdrawnCount: ").Append(WithdrawnCount).Append("\n");
            sb.Append("  ApprovedCount: ").Append(ApprovedCount).Append("\n");
            sb.Append("  DeniedCount: ").Append(DeniedCount).Append("\n");
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
            return this.Equals(obj as V2WfmOpportunityTopicOpportunityNotification);
        }

        /// <summary>
        /// Returns true if V2WfmOpportunityTopicOpportunityNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of V2WfmOpportunityTopicOpportunityNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2WfmOpportunityTopicOpportunityNotification other)
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
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
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
                    this.PendingCount == other.PendingCount ||
                    this.PendingCount != null &&
                    this.PendingCount.Equals(other.PendingCount)
                ) &&
                (
                    this.WithdrawnCount == other.WithdrawnCount ||
                    this.WithdrawnCount != null &&
                    this.WithdrawnCount.Equals(other.WithdrawnCount)
                ) &&
                (
                    this.ApprovedCount == other.ApprovedCount ||
                    this.ApprovedCount != null &&
                    this.ApprovedCount.Equals(other.ApprovedCount)
                ) &&
                (
                    this.DeniedCount == other.DeniedCount ||
                    this.DeniedCount != null &&
                    this.DeniedCount.Equals(other.DeniedCount)
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

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                if (this.PublishedDate != null)
                    hash = hash * 59 + this.PublishedDate.GetHashCode();

                if (this.ClosedDate != null)
                    hash = hash * 59 + this.ClosedDate.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();

                if (this.PendingCount != null)
                    hash = hash * 59 + this.PendingCount.GetHashCode();

                if (this.WithdrawnCount != null)
                    hash = hash * 59 + this.WithdrawnCount.GetHashCode();

                if (this.ApprovedCount != null)
                    hash = hash * 59 + this.ApprovedCount.GetHashCode();

                if (this.DeniedCount != null)
                    hash = hash * 59 + this.DeniedCount.GetHashCode();

                if (this.RemainingSpaces != null)
                    hash = hash * 59 + this.RemainingSpaces.GetHashCode();

                return hash;
            }
        }
    }

}
