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
    /// BulkUpdateShiftTradeStateResultItem
    /// </summary>
    [DataContract]
    public partial class BulkUpdateShiftTradeStateResultItem :  IEquatable<BulkUpdateShiftTradeStateResultItem>
    {
        
        
        
        
        
        /// <summary>
        /// The state of the shift trade after the update request is processed
        /// </summary>
        /// <value>The state of the shift trade after the update request is processed</value>
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
        /// The reason the update failed, if applicable
        /// </summary>
        /// <value>The reason the update failed, if applicable</value>
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
            /// Enum Initiatingagentshifthasexternalactivities for "InitiatingAgentShiftHasExternalActivities"
            /// </summary>
            [EnumMember(Value = "InitiatingAgentShiftHasExternalActivities")]
            Initiatingagentshifthasexternalactivities,
            
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
            /// Enum Receivingagentshifthasexternalactivities for "ReceivingAgentShiftHasExternalActivities"
            /// </summary>
            [EnumMember(Value = "ReceivingAgentShiftHasExternalActivities")]
            Receivingagentshifthasexternalactivities,
            
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
        /// The state of the shift trade after the update request is processed
        /// </summary>
        /// <value>The state of the shift trade after the update request is processed</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// The reason the update failed, if applicable
        /// </summary>
        /// <value>The reason the update failed, if applicable</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReasonEnum? FailureReason { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateShiftTradeStateResultItem" /> class.
        /// </summary>
        /// <param name="State">The state of the shift trade after the update request is processed.</param>
        /// <param name="ReviewedBy">The user who reviewed the request, if applicable.</param>
        /// <param name="ReviewedDate">The date the request was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="FailureReason">The reason the update failed, if applicable.</param>
        /// <param name="Metadata">Version metadata for the shift trade.</param>
        public BulkUpdateShiftTradeStateResultItem(StateEnum? State = null, UserReference ReviewedBy = null, DateTime? ReviewedDate = null, FailureReasonEnum? FailureReason = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.State = State;
            this.ReviewedBy = ReviewedBy;
            this.ReviewedDate = ReviewedDate;
            this.FailureReason = FailureReason;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        
        
        /// <summary>
        /// The user who reviewed the request, if applicable
        /// </summary>
        /// <value>The user who reviewed the request, if applicable</value>
        [DataMember(Name="reviewedBy", EmitDefaultValue=false)]
        public UserReference ReviewedBy { get; set; }
        
        
        
        /// <summary>
        /// The date the request was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the request was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="reviewedDate", EmitDefaultValue=false)]
        public DateTime? ReviewedDate { get; set; }
        
        
        
        
        
        /// <summary>
        /// Version metadata for the shift trade
        /// </summary>
        /// <value>Version metadata for the shift trade</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpdateShiftTradeStateResultItem {\n");
            
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BulkUpdateShiftTradeStateResultItem);
        }

        /// <summary>
        /// Returns true if BulkUpdateShiftTradeStateResultItem instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkUpdateShiftTradeStateResultItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkUpdateShiftTradeStateResultItem other)
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
