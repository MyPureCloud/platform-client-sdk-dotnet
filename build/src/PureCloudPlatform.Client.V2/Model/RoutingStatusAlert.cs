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
    /// RoutingStatusAlert
    /// </summary>
    [DataContract]
    public partial class RoutingStatusAlert :  IEquatable<RoutingStatusAlert>
    {
        /// <summary>
        /// The routing status on which to alert.
        /// </summary>
        /// <value>The routing status on which to alert.</value>
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
        /// Gets or Sets AlertTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AlertTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "SMS"
            /// </summary>
            [EnumMember(Value = "SMS")]
            Sms,
            
            /// <summary>
            /// Enum Device for "DEVICE"
            /// </summary>
            [EnumMember(Value = "DEVICE")]
            Device,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email
        }
        /// <summary>
        /// The routing status on which to alert.
        /// </summary>
        /// <value>The routing status on which to alert.</value>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatusEnum? RoutingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingStatusAlert" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoutingStatusAlert() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingStatusAlert" /> class.
        /// </summary>
        /// <param name="Name">Name of the rule (required).</param>
        /// <param name="Agent">The agent whose routing status will be watched. (required).</param>
        /// <param name="RoutingStatus">The routing status on which to alert. (required).</param>
        /// <param name="RoutingLimitInSeconds">The number of seconds to wait before alerting based upon the agent&#39;s routing status. (required).</param>
        /// <param name="NotificationUsers">The ids of users who were notified of alarm state change. (required).</param>
        /// <param name="AlertTypes">A collection of notification methods. (required).</param>
        public RoutingStatusAlert(string Name = null, User Agent = null, RoutingStatusEnum? RoutingStatus = null, int? RoutingLimitInSeconds = null, List<User> NotificationUsers = null, List<AlertTypesEnum> AlertTypes = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for RoutingStatusAlert and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Agent" is required (not null)
            if (Agent == null)
            {
                throw new InvalidDataException("Agent is a required property for RoutingStatusAlert and cannot be null");
            }
            else
            {
                this.Agent = Agent;
            }
            // to ensure "RoutingStatus" is required (not null)
            if (RoutingStatus == null)
            {
                throw new InvalidDataException("RoutingStatus is a required property for RoutingStatusAlert and cannot be null");
            }
            else
            {
                this.RoutingStatus = RoutingStatus;
            }
            // to ensure "RoutingLimitInSeconds" is required (not null)
            if (RoutingLimitInSeconds == null)
            {
                throw new InvalidDataException("RoutingLimitInSeconds is a required property for RoutingStatusAlert and cannot be null");
            }
            else
            {
                this.RoutingLimitInSeconds = RoutingLimitInSeconds;
            }
            // to ensure "NotificationUsers" is required (not null)
            if (NotificationUsers == null)
            {
                throw new InvalidDataException("NotificationUsers is a required property for RoutingStatusAlert and cannot be null");
            }
            else
            {
                this.NotificationUsers = NotificationUsers;
            }
            // to ensure "AlertTypes" is required (not null)
            if (AlertTypes == null)
            {
                throw new InvalidDataException("AlertTypes is a required property for RoutingStatusAlert and cannot be null");
            }
            else
            {
                this.AlertTypes = AlertTypes;
            }
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Name of the rule
        /// </summary>
        /// <value>Name of the rule</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The agent whose routing status will be watched.
        /// </summary>
        /// <value>The agent whose routing status will be watched.</value>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public User Agent { get; set; }
        /// <summary>
        /// The number of seconds to wait before alerting based upon the agent&#39;s routing status.
        /// </summary>
        /// <value>The number of seconds to wait before alerting based upon the agent&#39;s routing status.</value>
        [DataMember(Name="routingLimitInSeconds", EmitDefaultValue=false)]
        public int? RoutingLimitInSeconds { get; set; }
        /// <summary>
        /// The id of the rule.
        /// </summary>
        /// <value>The id of the rule.</value>
        [DataMember(Name="ruleId", EmitDefaultValue=false)]
        public string RuleId { get; private set; }
        /// <summary>
        /// The date/time the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date/time the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; private set; }
        /// <summary>
        /// The date/time the owning rule exiting in alarm status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date/time the owning rule exiting in alarm status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; private set; }
        /// <summary>
        /// The ids of users who were notified of alarm state change.
        /// </summary>
        /// <value>The ids of users who were notified of alarm state change.</value>
        [DataMember(Name="notificationUsers", EmitDefaultValue=false)]
        public List<User> NotificationUsers { get; set; }
        /// <summary>
        /// A collection of notification methods.
        /// </summary>
        /// <value>A collection of notification methods.</value>
        [DataMember(Name="alertTypes", EmitDefaultValue=false)]
        public List<AlertTypesEnum> AlertTypes { get; set; }
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingStatusAlert {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
            sb.Append("  RoutingLimitInSeconds: ").Append(RoutingLimitInSeconds).Append("\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  NotificationUsers: ").Append(NotificationUsers).Append("\n");
            sb.Append("  AlertTypes: ").Append(AlertTypes).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as RoutingStatusAlert);
        }

        /// <summary>
        /// Returns true if RoutingStatusAlert instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutingStatusAlert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingStatusAlert other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
                ) &&
                (
                    this.RoutingLimitInSeconds == other.RoutingLimitInSeconds ||
                    this.RoutingLimitInSeconds != null &&
                    this.RoutingLimitInSeconds.Equals(other.RoutingLimitInSeconds)
                ) &&
                (
                    this.RuleId == other.RuleId ||
                    this.RuleId != null &&
                    this.RuleId.Equals(other.RuleId)
                ) &&
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
                    this.NotificationUsers == other.NotificationUsers ||
                    this.NotificationUsers != null &&
                    this.NotificationUsers.SequenceEqual(other.NotificationUsers)
                ) &&
                (
                    this.AlertTypes == other.AlertTypes ||
                    this.AlertTypes != null &&
                    this.AlertTypes.SequenceEqual(other.AlertTypes)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();
                if (this.RoutingStatus != null)
                    hash = hash * 59 + this.RoutingStatus.GetHashCode();
                if (this.RoutingLimitInSeconds != null)
                    hash = hash * 59 + this.RoutingLimitInSeconds.GetHashCode();
                if (this.RuleId != null)
                    hash = hash * 59 + this.RuleId.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.NotificationUsers != null)
                    hash = hash * 59 + this.NotificationUsers.GetHashCode();
                if (this.AlertTypes != null)
                    hash = hash * 59 + this.AlertTypes.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
