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
    /// BulkOpportunitiesError
    /// </summary>
    [DataContract]
    public partial class BulkOpportunitiesError :  IEquatable<BulkOpportunitiesError>
    {
        /// <summary>
        /// The error code for the failed operation
        /// </summary>
        /// <value>The error code for the failed operation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ErrorCodeEnum
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
        /// The error code for the failed operation
        /// </summary>
        /// <value>The error code for the failed operation</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOpportunitiesError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkOpportunitiesError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOpportunitiesError" /> class.
        /// </summary>
        /// <param name="ErrorCode">The error code for the failed operation (required).</param>
        public BulkOpportunitiesError(ErrorCodeEnum? ErrorCode = null)
        {
            this.ErrorCode = ErrorCode;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkOpportunitiesError {\n");

            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
            return this.Equals(obj as BulkOpportunitiesError);
        }

        /// <summary>
        /// Returns true if BulkOpportunitiesError instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkOpportunitiesError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkOpportunitiesError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
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
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                return hash;
            }
        }
    }

}
