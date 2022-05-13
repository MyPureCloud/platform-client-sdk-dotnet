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
    /// WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult
    /// </summary>
    [DataContract]
    public partial class WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult :  IEquatable<WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
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
            /// Enum Unmatched for "Unmatched"
            /// </summary>
            [EnumMember(Value = "Unmatched")]
            Unmatched,
            
            /// <summary>
            /// Enum Matched for "Matched"
            /// </summary>
            [EnumMember(Value = "Matched")]
            Matched,
            
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
            /// Enum Expired for "Expired"
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled
        }
        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FailureReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Initiatingagentschedulenotfound for "InitiatingAgentScheduleNotFound"
            /// </summary>
            [EnumMember(Value = "InitiatingAgentScheduleNotFound")]
            Initiatingagentschedulenotfound,
            
            /// <summary>
            /// Enum Initiatingagentshiftnotfound for "InitiatingAgentShiftNotFound"
            /// </summary>
            [EnumMember(Value = "InitiatingAgentShiftNotFound")]
            Initiatingagentshiftnotfound,
            
            /// <summary>
            /// Enum Receivingagentnotfound for "ReceivingAgentNotFound"
            /// </summary>
            [EnumMember(Value = "ReceivingAgentNotFound")]
            Receivingagentnotfound,
            
            /// <summary>
            /// Enum Receivingagentschedulenotfound for "ReceivingAgentScheduleNotFound"
            /// </summary>
            [EnumMember(Value = "ReceivingAgentScheduleNotFound")]
            Receivingagentschedulenotfound,
            
            /// <summary>
            /// Enum Receivingagentshiftnotfound for "ReceivingAgentShiftNotFound"
            /// </summary>
            [EnumMember(Value = "ReceivingAgentShiftNotFound")]
            Receivingagentshiftnotfound,
            
            /// <summary>
            /// Enum Schedulenotpublished for "ScheduleNotPublished"
            /// </summary>
            [EnumMember(Value = "ScheduleNotPublished")]
            Schedulenotpublished,
            
            /// <summary>
            /// Enum Transitionnotallowed for "TransitionNotAllowed"
            /// </summary>
            [EnumMember(Value = "TransitionNotAllowed")]
            Transitionnotallowed
        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReasonEnum? FailureReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="State">State.</param>
        /// <param name="ReviewedBy">ReviewedBy.</param>
        /// <param name="ReviewedDate">ReviewedDate.</param>
        /// <param name="FailureReason">FailureReason.</param>
        /// <param name="Metadata">Metadata.</param>
        public WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult(string Id = null, StateEnum? State = null, WfmBulkShiftTradeStateUpdateNotificationTopicUserReference ReviewedBy = null, DateTime? ReviewedDate = null, FailureReasonEnum? FailureReason = null, WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata Metadata = null)
        {
            this.Id = Id;
            this.State = State;
            this.ReviewedBy = ReviewedBy;
            this.ReviewedDate = ReviewedDate;
            this.FailureReason = FailureReason;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// Gets or Sets ReviewedBy
        /// </summary>
        [DataMember(Name="reviewedBy", EmitDefaultValue=false)]
        public WfmBulkShiftTradeStateUpdateNotificationTopicUserReference ReviewedBy { get; set; }



        /// <summary>
        /// Gets or Sets ReviewedDate
        /// </summary>
        [DataMember(Name="reviewedDate", EmitDefaultValue=false)]
        public DateTime? ReviewedDate { get; set; }





        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
            sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
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
            return this.Equals(obj as WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult);
        }

        /// <summary>
        /// Returns true if WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateResult other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ReviewedBy == other.ReviewedBy ||
                    this.ReviewedBy != null &&
                    this.ReviewedBy.Equals(other.ReviewedBy)
                ) &&
                (
                    this.ReviewedDate == other.ReviewedDate ||
                    this.ReviewedDate != null &&
                    this.ReviewedDate.Equals(other.ReviewedDate)
                ) &&
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
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

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.ReviewedBy != null)
                    hash = hash * 59 + this.ReviewedBy.GetHashCode();

                if (this.ReviewedDate != null)
                    hash = hash * 59 + this.ReviewedDate.GetHashCode();

                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
