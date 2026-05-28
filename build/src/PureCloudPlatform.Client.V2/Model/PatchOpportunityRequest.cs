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
    /// PatchOpportunityRequest
    /// </summary>
    [DataContract]
    public partial class PatchOpportunityRequest :  IEquatable<PatchOpportunityRequest>
    {
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
        /// The approval type for enrollments
        /// </summary>
        /// <value>The approval type for enrollments</value>
        [DataMember(Name="approvalType", EmitDefaultValue=false)]
        public ApprovalTypeEnum? ApprovalType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOpportunityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatchOpportunityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOpportunityRequest" /> class.
        /// </summary>
        /// <param name="StartDate">The start date and time of the opportunity in ISO-8601 format.</param>
        /// <param name="EndDate">The end date and time of the opportunity in ISO-8601 format.</param>
        /// <param name="OpenDate">The date and time when the opportunity opens for enrollment in ISO-8601 format. If not provided or in the past, it will be automatically updated to the current time when the opportunity is published.</param>
        /// <param name="DeadlineDate">The deadline date and time for enrollment in the opportunity in ISO-8601 format.</param>
        /// <param name="Name">The name of the opportunity.</param>
        /// <param name="Description">Additional details describing the purpose or context of this opportunity.</param>
        /// <param name="ActivityCodeId">The ID of the activity code associated with the opportunity.</param>
        /// <param name="ApprovalType">The approval type for enrollments.</param>
        /// <param name="Capacity">The maximum capacity (enrollment slots) for this opportunity.</param>
        /// <param name="AgentIds">The IDs of the agents that are invited to the opportunity.</param>
        /// <param name="Metadata">The metadata for the opportunity (required).</param>
        public PatchOpportunityRequest(DateTime? StartDate = null, DateTime? EndDate = null, ValueWrapperInstant OpenDate = null, DateTime? DeadlineDate = null, string Name = null, ValueWrapperString Description = null, string ActivityCodeId = null, ApprovalTypeEnum? ApprovalType = null, int? Capacity = null, ListWrapperString AgentIds = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.OpenDate = OpenDate;
            this.DeadlineDate = DeadlineDate;
            this.Name = Name;
            this.Description = Description;
            this.ActivityCodeId = ActivityCodeId;
            this.ApprovalType = ApprovalType;
            this.Capacity = Capacity;
            this.AgentIds = AgentIds;
            this.Metadata = Metadata;
            
        }
        


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
        public ValueWrapperInstant OpenDate { get; set; }



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
        public ValueWrapperString Description { get; set; }



        /// <summary>
        /// The ID of the activity code associated with the opportunity
        /// </summary>
        /// <value>The ID of the activity code associated with the opportunity</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }





        /// <summary>
        /// The maximum capacity (enrollment slots) for this opportunity
        /// </summary>
        /// <value>The maximum capacity (enrollment slots) for this opportunity</value>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public int? Capacity { get; set; }



        /// <summary>
        /// The IDs of the agents that are invited to the opportunity
        /// </summary>
        /// <value>The IDs of the agents that are invited to the opportunity</value>
        [DataMember(Name="agentIds", EmitDefaultValue=false)]
        public ListWrapperString AgentIds { get; set; }



        /// <summary>
        /// The metadata for the opportunity
        /// </summary>
        /// <value>The metadata for the opportunity</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchOpportunityRequest {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  OpenDate: ").Append(OpenDate).Append("\n");
            sb.Append("  DeadlineDate: ").Append(DeadlineDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  ApprovalType: ").Append(ApprovalType).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as PatchOpportunityRequest);
        }

        /// <summary>
        /// Returns true if PatchOpportunityRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchOpportunityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchOpportunityRequest other)
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
                    this.Capacity == other.Capacity ||
                    this.Capacity != null &&
                    this.Capacity.Equals(other.Capacity)
                ) &&
                (
                    this.AgentIds == other.AgentIds ||
                    this.AgentIds != null &&
                    this.AgentIds.Equals(other.AgentIds)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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

                if (this.Capacity != null)
                    hash = hash * 59 + this.Capacity.GetHashCode();

                if (this.AgentIds != null)
                    hash = hash * 59 + this.AgentIds.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
