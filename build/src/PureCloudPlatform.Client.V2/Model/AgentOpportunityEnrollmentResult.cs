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
    /// AgentOpportunityEnrollmentResult
    /// </summary>
    [DataContract]
    public partial class AgentOpportunityEnrollmentResult :  IEquatable<AgentOpportunityEnrollmentResult>
    {
        /// <summary>
        /// The current status of the enrollment
        /// </summary>
        /// <value>The current status of the enrollment</value>
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
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
            /// Enum Withdrawn for "Withdrawn"
            /// </summary>
            [EnumMember(Value = "Withdrawn")]
            Withdrawn,
            
            /// <summary>
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing
        }
        /// <summary>
        /// The system-generated message code about enrollment processing results or failures
        /// </summary>
        /// <value>The system-generated message code about enrollment processing results or failures</value>
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
        /// The denial code
        /// </summary>
        /// <value>The denial code</value>
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
        /// The current status of the enrollment
        /// </summary>
        /// <value>The current status of the enrollment</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The system-generated message code about enrollment processing results or failures
        /// </summary>
        /// <value>The system-generated message code about enrollment processing results or failures</value>
        [DataMember(Name="systemMessageCode", EmitDefaultValue=false)]
        public SystemMessageCodeEnum? SystemMessageCode { get; set; }
        /// <summary>
        /// The denial code
        /// </summary>
        /// <value>The denial code</value>
        [DataMember(Name="denialCode", EmitDefaultValue=false)]
        public DenialCodeEnum? DenialCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOpportunityEnrollmentResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentOpportunityEnrollmentResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOpportunityEnrollmentResult" /> class.
        /// </summary>
        /// <param name="Status">The current status of the enrollment (required).</param>
        /// <param name="Schedule">The schedule on which the enrollment was added when this enrollment was approved.</param>
        /// <param name="SystemMessageCode">The system-generated message code about enrollment processing results or failures.</param>
        /// <param name="ReviewNote">Supervisor&#39;s note explaining the agent&#39;s enrollment status change.</param>
        /// <param name="DenialCode">The denial code.</param>
        /// <param name="Metadata">The metadata for the enrollment (required).</param>
        public AgentOpportunityEnrollmentResult(StatusEnum? Status = null, BuScheduleReference Schedule = null, SystemMessageCodeEnum? SystemMessageCode = null, string ReviewNote = null, DenialCodeEnum? DenialCode = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Status = Status;
            this.Schedule = Schedule;
            this.SystemMessageCode = SystemMessageCode;
            this.ReviewNote = ReviewNote;
            this.DenialCode = DenialCode;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// The schedule on which the enrollment was added when this enrollment was approved
        /// </summary>
        /// <value>The schedule on which the enrollment was added when this enrollment was approved</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public BuScheduleReference Schedule { get; set; }





        /// <summary>
        /// Supervisor&#39;s note explaining the agent&#39;s enrollment status change
        /// </summary>
        /// <value>Supervisor&#39;s note explaining the agent&#39;s enrollment status change</value>
        [DataMember(Name="reviewNote", EmitDefaultValue=false)]
        public string ReviewNote { get; set; }





        /// <summary>
        /// The metadata for the enrollment
        /// </summary>
        /// <value>The metadata for the enrollment</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentOpportunityEnrollmentResult {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  SystemMessageCode: ").Append(SystemMessageCode).Append("\n");
            sb.Append("  ReviewNote: ").Append(ReviewNote).Append("\n");
            sb.Append("  DenialCode: ").Append(DenialCode).Append("\n");
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
            return this.Equals(obj as AgentOpportunityEnrollmentResult);
        }

        /// <summary>
        /// Returns true if AgentOpportunityEnrollmentResult instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentOpportunityEnrollmentResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentOpportunityEnrollmentResult other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.SystemMessageCode == other.SystemMessageCode ||
                    this.SystemMessageCode != null &&
                    this.SystemMessageCode.Equals(other.SystemMessageCode)
                ) &&
                (
                    this.ReviewNote == other.ReviewNote ||
                    this.ReviewNote != null &&
                    this.ReviewNote.Equals(other.ReviewNote)
                ) &&
                (
                    this.DenialCode == other.DenialCode ||
                    this.DenialCode != null &&
                    this.DenialCode.Equals(other.DenialCode)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.SystemMessageCode != null)
                    hash = hash * 59 + this.SystemMessageCode.GetHashCode();

                if (this.ReviewNote != null)
                    hash = hash * 59 + this.ReviewNote.GetHashCode();

                if (this.DenialCode != null)
                    hash = hash * 59 + this.DenialCode.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
