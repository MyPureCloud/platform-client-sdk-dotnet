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
    /// AlternativeShiftTradeBulkUpdateTemplateItem
    /// </summary>
    [DataContract]
    public partial class AlternativeShiftTradeBulkUpdateTemplateItem :  IEquatable<AlternativeShiftTradeBulkUpdateTemplateItem>
    {
        /// <summary>
        /// The current state of this alternative shift trade request
        /// </summary>
        /// <value>The current state of this alternative shift trade request</value>
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
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
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
            /// Enum Submitted for "Submitted"
            /// </summary>
            [EnumMember(Value = "Submitted")]
            Submitted,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved
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
            /// Enum Transitionnotallowed for "TransitionNotAllowed"
            /// </summary>
            [EnumMember(Value = "TransitionNotAllowed")]
            Transitionnotallowed,
            
            /// <summary>
            /// Enum Notauthorized for "NotAuthorized"
            /// </summary>
            [EnumMember(Value = "NotAuthorized")]
            Notauthorized
        }
        /// <summary>
        /// The current state of this alternative shift trade request
        /// </summary>
        /// <value>The current state of this alternative shift trade request</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// The reason the update failed, if applicable
        /// </summary>
        /// <value>The reason the update failed, if applicable</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReasonEnum? FailureReason { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeShiftTradeBulkUpdateTemplateItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlternativeShiftTradeBulkUpdateTemplateItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeShiftTradeBulkUpdateTemplateItem" /> class.
        /// </summary>
        /// <param name="TradeId">The ID of this alternative shift trade (required).</param>
        /// <param name="State">The current state of this alternative shift trade request (required).</param>
        /// <param name="FailureReason">The reason the update failed, if applicable.</param>
        /// <param name="AdminDateReviewed">The timestamp of when the trade request was manually reviewed by an admin in ISO-8601 format.</param>
        /// <param name="AdminReviewedBy">The admin who manually reviewed this alternative shift trade after system denial.</param>
        /// <param name="Metadata">Version metadata for this alternative shift trade (required).</param>
        public AlternativeShiftTradeBulkUpdateTemplateItem(string TradeId = null, StateEnum? State = null, FailureReasonEnum? FailureReason = null, DateTime? AdminDateReviewed = null, UserReference AdminReviewedBy = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.TradeId = TradeId;
            this.State = State;
            this.FailureReason = FailureReason;
            this.AdminDateReviewed = AdminDateReviewed;
            this.AdminReviewedBy = AdminReviewedBy;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The ID of this alternative shift trade
        /// </summary>
        /// <value>The ID of this alternative shift trade</value>
        [DataMember(Name="tradeId", EmitDefaultValue=false)]
        public string TradeId { get; set; }







        /// <summary>
        /// The timestamp of when the trade request was manually reviewed by an admin in ISO-8601 format
        /// </summary>
        /// <value>The timestamp of when the trade request was manually reviewed by an admin in ISO-8601 format</value>
        [DataMember(Name="adminDateReviewed", EmitDefaultValue=false)]
        public DateTime? AdminDateReviewed { get; set; }



        /// <summary>
        /// The admin who manually reviewed this alternative shift trade after system denial
        /// </summary>
        /// <value>The admin who manually reviewed this alternative shift trade after system denial</value>
        [DataMember(Name="adminReviewedBy", EmitDefaultValue=false)]
        public UserReference AdminReviewedBy { get; set; }



        /// <summary>
        /// Version metadata for this alternative shift trade
        /// </summary>
        /// <value>Version metadata for this alternative shift trade</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlternativeShiftTradeBulkUpdateTemplateItem {\n");

            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  AdminDateReviewed: ").Append(AdminDateReviewed).Append("\n");
            sb.Append("  AdminReviewedBy: ").Append(AdminReviewedBy).Append("\n");
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
            return this.Equals(obj as AlternativeShiftTradeBulkUpdateTemplateItem);
        }

        /// <summary>
        /// Returns true if AlternativeShiftTradeBulkUpdateTemplateItem instances are equal
        /// </summary>
        /// <param name="other">Instance of AlternativeShiftTradeBulkUpdateTemplateItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlternativeShiftTradeBulkUpdateTemplateItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TradeId == other.TradeId ||
                    this.TradeId != null &&
                    this.TradeId.Equals(other.TradeId)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
                ) &&
                (
                    this.AdminDateReviewed == other.AdminDateReviewed ||
                    this.AdminDateReviewed != null &&
                    this.AdminDateReviewed.Equals(other.AdminDateReviewed)
                ) &&
                (
                    this.AdminReviewedBy == other.AdminReviewedBy ||
                    this.AdminReviewedBy != null &&
                    this.AdminReviewedBy.Equals(other.AdminReviewedBy)
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
                if (this.TradeId != null)
                    hash = hash * 59 + this.TradeId.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();

                if (this.AdminDateReviewed != null)
                    hash = hash * 59 + this.AdminDateReviewed.GetHashCode();

                if (this.AdminReviewedBy != null)
                    hash = hash * 59 + this.AdminReviewedBy.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
