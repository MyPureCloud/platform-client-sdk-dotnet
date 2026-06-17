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
    /// ScheduleBiddingAdminNotificationTopicScheduleBiddingNotification
    /// </summary>
    [DataContract]
    public partial class ScheduleBiddingAdminNotificationTopicScheduleBiddingNotification :  IEquatable<ScheduleBiddingAdminNotificationTopicScheduleBiddingNotification>
    {
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
            /// Enum Locked for "Locked"
            /// </summary>
            [EnumMember(Value = "Locked")]
            Locked,
            
            /// <summary>
            /// Enum Scheduled for "Scheduled"
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Optimized for "Optimized"
            /// </summary>
            [EnumMember(Value = "Optimized")]
            Optimized,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed,
            
            /// <summary>
            /// Enum Processed for "Processed"
            /// </summary>
            [EnumMember(Value = "Processed")]
            Processed,
            
            /// <summary>
            /// Enum Published for "Published"
            /// </summary>
            [EnumMember(Value = "Published")]
            Published
        }
        /// <summary>
        /// Gets or Sets BidType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BidTypeEnum
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
            /// Enum Workplanbid for "WorkPlanBid"
            /// </summary>
            [EnumMember(Value = "WorkPlanBid")]
            Workplanbid,
            
            /// <summary>
            /// Enum Schedulebid for "ScheduleBid"
            /// </summary>
            [EnumMember(Value = "ScheduleBid")]
            Schedulebid
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets BidType
        /// </summary>
        [DataMember(Name="bidType", EmitDefaultValue=false)]
        public BidTypeEnum? BidType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBiddingAdminNotificationTopicScheduleBiddingNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="BuId">BuId.</param>
        /// <param name="Status">Status.</param>
        /// <param name="BidType">BidType.</param>
        public ScheduleBiddingAdminNotificationTopicScheduleBiddingNotification(string Id = null, string BuId = null, StatusEnum? Status = null, BidTypeEnum? BidType = null)
        {
            this.Id = Id;
            this.BuId = BuId;
            this.Status = Status;
            this.BidType = BidType;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets BuId
        /// </summary>
        [DataMember(Name="buId", EmitDefaultValue=false)]
        public string BuId { get; set; }






        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleBiddingAdminNotificationTopicScheduleBiddingNotification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BuId: ").Append(BuId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BidType: ").Append(BidType).Append("\n");
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
            return this.Equals(obj as ScheduleBiddingAdminNotificationTopicScheduleBiddingNotification);
        }

        /// <summary>
        /// Returns true if ScheduleBiddingAdminNotificationTopicScheduleBiddingNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleBiddingAdminNotificationTopicScheduleBiddingNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleBiddingAdminNotificationTopicScheduleBiddingNotification other)
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
                    this.BuId == other.BuId ||
                    this.BuId != null &&
                    this.BuId.Equals(other.BuId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.BidType == other.BidType ||
                    this.BidType != null &&
                    this.BidType.Equals(other.BidType)
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

                if (this.BuId != null)
                    hash = hash * 59 + this.BuId.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.BidType != null)
                    hash = hash * 59 + this.BidType.GetHashCode();

                return hash;
            }
        }
    }

}
