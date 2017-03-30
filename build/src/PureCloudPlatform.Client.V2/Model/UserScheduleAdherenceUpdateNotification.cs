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
    /// UserScheduleAdherenceUpdateNotification
    /// </summary>
    [DataContract]
    public partial class UserScheduleAdherenceUpdateNotification :  IEquatable<UserScheduleAdherenceUpdateNotification>
    {
        /// <summary>
        /// Gets or Sets RoutingStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RoutingStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Empty for "__EMPTY__"
            /// </summary>
            [EnumMember(Value = "__EMPTY__")]
            Empty,
            
            /// <summary>
            /// Enum OffQueue for "OFF_QUEUE"
            /// </summary>
            [EnumMember(Value = "OFF_QUEUE")]
            OffQueue,
            
            /// <summary>
            /// Enum Idle for "IDLE"
            /// </summary>
            [EnumMember(Value = "IDLE")]
            Idle,
            
            /// <summary>
            /// Enum Interacting for "INTERACTING"
            /// </summary>
            [EnumMember(Value = "INTERACTING")]
            Interacting,
            
            /// <summary>
            /// Enum NotResponding for "NOT_RESPONDING"
            /// </summary>
            [EnumMember(Value = "NOT_RESPONDING")]
            NotResponding,
            
            /// <summary>
            /// Enum Communicating for "COMMUNICATING"
            /// </summary>
            [EnumMember(Value = "COMMUNICATING")]
            Communicating,
            
            /// <summary>
            /// Enum Offline for "OFFLINE"
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            Offline
        }
        /// <summary>
        /// Gets or Sets RoutingStatus
        /// </summary>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatusEnum? RoutingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserScheduleAdherenceUpdateNotification" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="ManagementUnitId">ManagementUnitId.</param>
        /// <param name="ScheduledActivityCategory">ScheduledActivityCategory.</param>
        /// <param name="SystemPresence">SystemPresence.</param>
        /// <param name="RoutingStatus">RoutingStatus.</param>
        /// <param name="ActualActivityCategory">ActualActivityCategory.</param>
        /// <param name="IsOutOfOffice">IsOutOfOffice.</param>
        /// <param name="AdherenceState">AdherenceState.</param>
        /// <param name="Impact">Impact.</param>
        /// <param name="AdherenceChangeTime">AdherenceChangeTime.</param>
        public UserScheduleAdherenceUpdateNotification(DocumentDataV2NotificationWorkspace User = null, string ManagementUnitId = null, string ScheduledActivityCategory = null, string SystemPresence = null, RoutingStatusEnum? RoutingStatus = null, string ActualActivityCategory = null, bool? IsOutOfOffice = null, string AdherenceState = null, string Impact = null, string AdherenceChangeTime = null)
        {
            this.User = User;
            this.ManagementUnitId = ManagementUnitId;
            this.ScheduledActivityCategory = ScheduledActivityCategory;
            this.SystemPresence = SystemPresence;
            this.RoutingStatus = RoutingStatus;
            this.ActualActivityCategory = ActualActivityCategory;
            this.IsOutOfOffice = IsOutOfOffice;
            this.AdherenceState = AdherenceState;
            this.Impact = Impact;
            this.AdherenceChangeTime = AdherenceChangeTime;
        }
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public DocumentDataV2NotificationWorkspace User { get; set; }
        /// <summary>
        /// Gets or Sets ManagementUnitId
        /// </summary>
        [DataMember(Name="managementUnitId", EmitDefaultValue=false)]
        public string ManagementUnitId { get; set; }
        /// <summary>
        /// Gets or Sets ScheduledActivityCategory
        /// </summary>
        [DataMember(Name="scheduledActivityCategory", EmitDefaultValue=false)]
        public string ScheduledActivityCategory { get; set; }
        /// <summary>
        /// Gets or Sets SystemPresence
        /// </summary>
        [DataMember(Name="systemPresence", EmitDefaultValue=false)]
        public string SystemPresence { get; set; }
        /// <summary>
        /// Gets or Sets ActualActivityCategory
        /// </summary>
        [DataMember(Name="actualActivityCategory", EmitDefaultValue=false)]
        public string ActualActivityCategory { get; set; }
        /// <summary>
        /// Gets or Sets IsOutOfOffice
        /// </summary>
        [DataMember(Name="isOutOfOffice", EmitDefaultValue=false)]
        public bool? IsOutOfOffice { get; set; }
        /// <summary>
        /// Gets or Sets AdherenceState
        /// </summary>
        [DataMember(Name="adherenceState", EmitDefaultValue=false)]
        public string AdherenceState { get; set; }
        /// <summary>
        /// Gets or Sets Impact
        /// </summary>
        [DataMember(Name="impact", EmitDefaultValue=false)]
        public string Impact { get; set; }
        /// <summary>
        /// Gets or Sets AdherenceChangeTime
        /// </summary>
        [DataMember(Name="adherenceChangeTime", EmitDefaultValue=false)]
        public string AdherenceChangeTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserScheduleAdherenceUpdateNotification {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
            sb.Append("  ScheduledActivityCategory: ").Append(ScheduledActivityCategory).Append("\n");
            sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
            sb.Append("  ActualActivityCategory: ").Append(ActualActivityCategory).Append("\n");
            sb.Append("  IsOutOfOffice: ").Append(IsOutOfOffice).Append("\n");
            sb.Append("  AdherenceState: ").Append(AdherenceState).Append("\n");
            sb.Append("  Impact: ").Append(Impact).Append("\n");
            sb.Append("  AdherenceChangeTime: ").Append(AdherenceChangeTime).Append("\n");
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
            return this.Equals(obj as UserScheduleAdherenceUpdateNotification);
        }

        /// <summary>
        /// Returns true if UserScheduleAdherenceUpdateNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of UserScheduleAdherenceUpdateNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserScheduleAdherenceUpdateNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.ManagementUnitId == other.ManagementUnitId ||
                    this.ManagementUnitId != null &&
                    this.ManagementUnitId.Equals(other.ManagementUnitId)
                ) &&
                (
                    this.ScheduledActivityCategory == other.ScheduledActivityCategory ||
                    this.ScheduledActivityCategory != null &&
                    this.ScheduledActivityCategory.Equals(other.ScheduledActivityCategory)
                ) &&
                (
                    this.SystemPresence == other.SystemPresence ||
                    this.SystemPresence != null &&
                    this.SystemPresence.Equals(other.SystemPresence)
                ) &&
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
                ) &&
                (
                    this.ActualActivityCategory == other.ActualActivityCategory ||
                    this.ActualActivityCategory != null &&
                    this.ActualActivityCategory.Equals(other.ActualActivityCategory)
                ) &&
                (
                    this.IsOutOfOffice == other.IsOutOfOffice ||
                    this.IsOutOfOffice != null &&
                    this.IsOutOfOffice.Equals(other.IsOutOfOffice)
                ) &&
                (
                    this.AdherenceState == other.AdherenceState ||
                    this.AdherenceState != null &&
                    this.AdherenceState.Equals(other.AdherenceState)
                ) &&
                (
                    this.Impact == other.Impact ||
                    this.Impact != null &&
                    this.Impact.Equals(other.Impact)
                ) &&
                (
                    this.AdherenceChangeTime == other.AdherenceChangeTime ||
                    this.AdherenceChangeTime != null &&
                    this.AdherenceChangeTime.Equals(other.AdherenceChangeTime)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.ManagementUnitId != null)
                    hash = hash * 59 + this.ManagementUnitId.GetHashCode();
                if (this.ScheduledActivityCategory != null)
                    hash = hash * 59 + this.ScheduledActivityCategory.GetHashCode();
                if (this.SystemPresence != null)
                    hash = hash * 59 + this.SystemPresence.GetHashCode();
                if (this.RoutingStatus != null)
                    hash = hash * 59 + this.RoutingStatus.GetHashCode();
                if (this.ActualActivityCategory != null)
                    hash = hash * 59 + this.ActualActivityCategory.GetHashCode();
                if (this.IsOutOfOffice != null)
                    hash = hash * 59 + this.IsOutOfOffice.GetHashCode();
                if (this.AdherenceState != null)
                    hash = hash * 59 + this.AdherenceState.GetHashCode();
                if (this.Impact != null)
                    hash = hash * 59 + this.Impact.GetHashCode();
                if (this.AdherenceChangeTime != null)
                    hash = hash * 59 + this.AdherenceChangeTime.GetHashCode();
                return hash;
            }
        }
    }

}
