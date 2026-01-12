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
    /// AnalyticsAgentStateAgentResponse
    /// </summary>
    [DataContract]
    public partial class AnalyticsAgentStateAgentResponse :  IEquatable<AnalyticsAgentStateAgentResponse>
    {
        /// <summary>
        /// The user's system presence
        /// </summary>
        /// <value>The user's system presence</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SystemPresenceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Available for "AVAILABLE"
            /// </summary>
            [EnumMember(Value = "AVAILABLE")]
            Available,
            
            /// <summary>
            /// Enum Away for "AWAY"
            /// </summary>
            [EnumMember(Value = "AWAY")]
            Away,
            
            /// <summary>
            /// Enum Busy for "BUSY"
            /// </summary>
            [EnumMember(Value = "BUSY")]
            Busy,
            
            /// <summary>
            /// Enum Offline for "OFFLINE"
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            Offline,
            
            /// <summary>
            /// Enum Idle for "IDLE"
            /// </summary>
            [EnumMember(Value = "IDLE")]
            Idle,
            
            /// <summary>
            /// Enum OnQueue for "ON_QUEUE"
            /// </summary>
            [EnumMember(Value = "ON_QUEUE")]
            OnQueue,
            
            /// <summary>
            /// Enum Meal for "MEAL"
            /// </summary>
            [EnumMember(Value = "MEAL")]
            Meal,
            
            /// <summary>
            /// Enum Training for "TRAINING"
            /// </summary>
            [EnumMember(Value = "TRAINING")]
            Training,
            
            /// <summary>
            /// Enum Meeting for "MEETING"
            /// </summary>
            [EnumMember(Value = "MEETING")]
            Meeting,
            
            /// <summary>
            /// Enum Break for "BREAK"
            /// </summary>
            [EnumMember(Value = "BREAK")]
            Break
        }
        /// <summary>
        /// The user's routing status
        /// </summary>
        /// <value>The user's routing status</value>
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
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
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
            Communicating
        }
        /// <summary>
        /// The user's system presence
        /// </summary>
        /// <value>The user's system presence</value>
        [DataMember(Name="systemPresence", EmitDefaultValue=false)]
        public SystemPresenceEnum? SystemPresence { get; set; }
        /// <summary>
        /// The user's routing status
        /// </summary>
        /// <value>The user's routing status</value>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatusEnum? RoutingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsAgentStateAgentResponse" /> class.
        /// </summary>
        /// <param name="UserId">User Id - only returned if division is covered by agentStateNames permission.</param>
        /// <param name="DivisionId">Division Id.</param>
        /// <param name="UserName">User name - only returned if division is covered by agentStateNames permission.</param>
        /// <param name="ManagerId">The user that this user reports to.</param>
        /// <param name="SessionCount">The count of sessions.</param>
        /// <param name="Sessions">List of sessions.</param>
        /// <param name="SystemPresence">The user&#39;s system presence.</param>
        /// <param name="OrganizationPresenceId">The identifier for the user&#39;s organization presence.</param>
        /// <param name="PresenceDate">The timestamp for when the user&#39;s presence began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="RoutingStatus">The user&#39;s routing status.</param>
        /// <param name="RoutingStatusDate">The timestamp for when the user&#39;s routing status began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="IsOutOfOffice">Whether the user is out of office.</param>
        public AnalyticsAgentStateAgentResponse(string UserId = null, string DivisionId = null, string UserName = null, string ManagerId = null, int? SessionCount = null, List<AnalyticsAgentStateAgentSessionResult> Sessions = null, SystemPresenceEnum? SystemPresence = null, string OrganizationPresenceId = null, DateTime? PresenceDate = null, RoutingStatusEnum? RoutingStatus = null, DateTime? RoutingStatusDate = null, bool? IsOutOfOffice = null)
        {
            this.UserId = UserId;
            this.DivisionId = DivisionId;
            this.UserName = UserName;
            this.ManagerId = ManagerId;
            this.SessionCount = SessionCount;
            this.Sessions = Sessions;
            this.SystemPresence = SystemPresence;
            this.OrganizationPresenceId = OrganizationPresenceId;
            this.PresenceDate = PresenceDate;
            this.RoutingStatus = RoutingStatus;
            this.RoutingStatusDate = RoutingStatusDate;
            this.IsOutOfOffice = IsOutOfOffice;
            
        }
        


        /// <summary>
        /// User Id - only returned if division is covered by agentStateNames permission
        /// </summary>
        /// <value>User Id - only returned if division is covered by agentStateNames permission</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Division Id
        /// </summary>
        /// <value>Division Id</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// User name - only returned if division is covered by agentStateNames permission
        /// </summary>
        /// <value>User name - only returned if division is covered by agentStateNames permission</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }



        /// <summary>
        /// The user that this user reports to
        /// </summary>
        /// <value>The user that this user reports to</value>
        [DataMember(Name="managerId", EmitDefaultValue=false)]
        public string ManagerId { get; set; }



        /// <summary>
        /// The count of sessions
        /// </summary>
        /// <value>The count of sessions</value>
        [DataMember(Name="sessionCount", EmitDefaultValue=false)]
        public int? SessionCount { get; set; }



        /// <summary>
        /// List of sessions
        /// </summary>
        /// <value>List of sessions</value>
        [DataMember(Name="sessions", EmitDefaultValue=false)]
        public List<AnalyticsAgentStateAgentSessionResult> Sessions { get; set; }





        /// <summary>
        /// The identifier for the user&#39;s organization presence
        /// </summary>
        /// <value>The identifier for the user&#39;s organization presence</value>
        [DataMember(Name="organizationPresenceId", EmitDefaultValue=false)]
        public string OrganizationPresenceId { get; set; }



        /// <summary>
        /// The timestamp for when the user&#39;s presence began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp for when the user&#39;s presence began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="presenceDate", EmitDefaultValue=false)]
        public DateTime? PresenceDate { get; set; }





        /// <summary>
        /// The timestamp for when the user&#39;s routing status began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp for when the user&#39;s routing status began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="routingStatusDate", EmitDefaultValue=false)]
        public DateTime? RoutingStatusDate { get; set; }



        /// <summary>
        /// Whether the user is out of office
        /// </summary>
        /// <value>Whether the user is out of office</value>
        [DataMember(Name="isOutOfOffice", EmitDefaultValue=false)]
        public bool? IsOutOfOffice { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsAgentStateAgentResponse {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  ManagerId: ").Append(ManagerId).Append("\n");
            sb.Append("  SessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
            sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
            sb.Append("  OrganizationPresenceId: ").Append(OrganizationPresenceId).Append("\n");
            sb.Append("  PresenceDate: ").Append(PresenceDate).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
            sb.Append("  RoutingStatusDate: ").Append(RoutingStatusDate).Append("\n");
            sb.Append("  IsOutOfOffice: ").Append(IsOutOfOffice).Append("\n");
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
            return this.Equals(obj as AnalyticsAgentStateAgentResponse);
        }

        /// <summary>
        /// Returns true if AnalyticsAgentStateAgentResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsAgentStateAgentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsAgentStateAgentResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) &&
                (
                    this.ManagerId == other.ManagerId ||
                    this.ManagerId != null &&
                    this.ManagerId.Equals(other.ManagerId)
                ) &&
                (
                    this.SessionCount == other.SessionCount ||
                    this.SessionCount != null &&
                    this.SessionCount.Equals(other.SessionCount)
                ) &&
                (
                    this.Sessions == other.Sessions ||
                    this.Sessions != null &&
                    this.Sessions.SequenceEqual(other.Sessions)
                ) &&
                (
                    this.SystemPresence == other.SystemPresence ||
                    this.SystemPresence != null &&
                    this.SystemPresence.Equals(other.SystemPresence)
                ) &&
                (
                    this.OrganizationPresenceId == other.OrganizationPresenceId ||
                    this.OrganizationPresenceId != null &&
                    this.OrganizationPresenceId.Equals(other.OrganizationPresenceId)
                ) &&
                (
                    this.PresenceDate == other.PresenceDate ||
                    this.PresenceDate != null &&
                    this.PresenceDate.Equals(other.PresenceDate)
                ) &&
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
                ) &&
                (
                    this.RoutingStatusDate == other.RoutingStatusDate ||
                    this.RoutingStatusDate != null &&
                    this.RoutingStatusDate.Equals(other.RoutingStatusDate)
                ) &&
                (
                    this.IsOutOfOffice == other.IsOutOfOffice ||
                    this.IsOutOfOffice != null &&
                    this.IsOutOfOffice.Equals(other.IsOutOfOffice)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();

                if (this.ManagerId != null)
                    hash = hash * 59 + this.ManagerId.GetHashCode();

                if (this.SessionCount != null)
                    hash = hash * 59 + this.SessionCount.GetHashCode();

                if (this.Sessions != null)
                    hash = hash * 59 + this.Sessions.GetHashCode();

                if (this.SystemPresence != null)
                    hash = hash * 59 + this.SystemPresence.GetHashCode();

                if (this.OrganizationPresenceId != null)
                    hash = hash * 59 + this.OrganizationPresenceId.GetHashCode();

                if (this.PresenceDate != null)
                    hash = hash * 59 + this.PresenceDate.GetHashCode();

                if (this.RoutingStatus != null)
                    hash = hash * 59 + this.RoutingStatus.GetHashCode();

                if (this.RoutingStatusDate != null)
                    hash = hash * 59 + this.RoutingStatusDate.GetHashCode();

                if (this.IsOutOfOffice != null)
                    hash = hash * 59 + this.IsOutOfOffice.GetHashCode();

                return hash;
            }
        }
    }

}
