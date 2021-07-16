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
    /// WfmUserNotificationTopicTimeOffRequestNotification
    /// </summary>
    [DataContract]
    public partial class WfmUserNotificationTopicTimeOffRequestNotification :  IEquatable<WfmUserNotificationTopicTimeOffRequestNotification>
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
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending,
            
            /// <summary>
            /// Enum Approved for "APPROVED"
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            Approved,
            
            /// <summary>
            /// Enum Denied for "DENIED"
            /// </summary>
            [EnumMember(Value = "DENIED")]
            Denied,
            
            /// <summary>
            /// Enum Canceled for "CANCELED"
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            Canceled
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmUserNotificationTopicTimeOffRequestNotification" /> class.
        /// </summary>
        /// <param name="TimeOffRequestId">TimeOffRequestId.</param>
        /// <param name="User">User.</param>
        /// <param name="IsFullDayRequest">IsFullDayRequest.</param>
        /// <param name="Status">Status.</param>
        /// <param name="PartialDayStartDateTimes">PartialDayStartDateTimes.</param>
        /// <param name="FullDayManagementUnitDates">FullDayManagementUnitDates.</param>
        public WfmUserNotificationTopicTimeOffRequestNotification(string TimeOffRequestId = null, WfmUserNotificationTopicUserReference User = null, bool? IsFullDayRequest = null, StatusEnum? Status = null, List<DateTime?> PartialDayStartDateTimes = null, List<string> FullDayManagementUnitDates = null)
        {
            this.TimeOffRequestId = TimeOffRequestId;
            this.User = User;
            this.IsFullDayRequest = IsFullDayRequest;
            this.Status = Status;
            this.PartialDayStartDateTimes = PartialDayStartDateTimes;
            this.FullDayManagementUnitDates = FullDayManagementUnitDates;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets TimeOffRequestId
        /// </summary>
        [DataMember(Name="timeOffRequestId", EmitDefaultValue=false)]
        public string TimeOffRequestId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public WfmUserNotificationTopicUserReference User { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IsFullDayRequest
        /// </summary>
        [DataMember(Name="isFullDayRequest", EmitDefaultValue=false)]
        public bool? IsFullDayRequest { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets PartialDayStartDateTimes
        /// </summary>
        [DataMember(Name="partialDayStartDateTimes", EmitDefaultValue=false)]
        public List<DateTime?> PartialDayStartDateTimes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FullDayManagementUnitDates
        /// </summary>
        [DataMember(Name="fullDayManagementUnitDates", EmitDefaultValue=false)]
        public List<string> FullDayManagementUnitDates { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmUserNotificationTopicTimeOffRequestNotification {\n");
            
            sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  IsFullDayRequest: ").Append(IsFullDayRequest).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PartialDayStartDateTimes: ").Append(PartialDayStartDateTimes).Append("\n");
            sb.Append("  FullDayManagementUnitDates: ").Append(FullDayManagementUnitDates).Append("\n");
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
            return this.Equals(obj as WfmUserNotificationTopicTimeOffRequestNotification);
        }

        /// <summary>
        /// Returns true if WfmUserNotificationTopicTimeOffRequestNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmUserNotificationTopicTimeOffRequestNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmUserNotificationTopicTimeOffRequestNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeOffRequestId == other.TimeOffRequestId ||
                    this.TimeOffRequestId != null &&
                    this.TimeOffRequestId.Equals(other.TimeOffRequestId)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.IsFullDayRequest == other.IsFullDayRequest ||
                    this.IsFullDayRequest != null &&
                    this.IsFullDayRequest.Equals(other.IsFullDayRequest)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.PartialDayStartDateTimes == other.PartialDayStartDateTimes ||
                    this.PartialDayStartDateTimes != null &&
                    this.PartialDayStartDateTimes.SequenceEqual(other.PartialDayStartDateTimes)
                ) &&
                (
                    this.FullDayManagementUnitDates == other.FullDayManagementUnitDates ||
                    this.FullDayManagementUnitDates != null &&
                    this.FullDayManagementUnitDates.SequenceEqual(other.FullDayManagementUnitDates)
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
                
                if (this.TimeOffRequestId != null)
                    hash = hash * 59 + this.TimeOffRequestId.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.IsFullDayRequest != null)
                    hash = hash * 59 + this.IsFullDayRequest.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.PartialDayStartDateTimes != null)
                    hash = hash * 59 + this.PartialDayStartDateTimes.GetHashCode();
                
                if (this.FullDayManagementUnitDates != null)
                    hash = hash * 59 + this.FullDayManagementUnitDates.GetHashCode();
                
                return hash;
            }
        }
    }

}
