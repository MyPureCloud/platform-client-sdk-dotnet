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
    /// RoutingStatusRule
    /// </summary>
    [DataContract]
    public partial class RoutingStatusRule :  IEquatable<RoutingStatusRule>
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
        /// Initializes a new instance of the <see cref="RoutingStatusRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoutingStatusRule() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingStatusRule" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name of the rule (required).</param>
        
        
        
        /// <param name="Agent">The agent whose routing status will be watched. (required).</param>
        
        
        
        /// <param name="RoutingStatus">The routing status on which to alert. (required).</param>
        
        
        
        /// <param name="RoutingLimitInSeconds">The number of seconds to wait before alerting based upon the agent&#39;s routing status. (required).</param>
        
        
        
        /// <param name="Enabled">Indicates if the rule is enabled. (required).</param>
        
        
        
        
        
        /// <param name="NotificationUsers">The ids of users who will be notified of alarm state change. (required).</param>
        
        
        
        /// <param name="AlertTypes">A collection of notification methods. (required).</param>
        
        
        
        
        public RoutingStatusRule(string Name = null, User Agent = null, RoutingStatusEnum? RoutingStatus = null, int? RoutingLimitInSeconds = null, bool? Enabled = null, List<User> NotificationUsers = null, List<AlertTypesEnum> AlertTypes = null)
        {
            
            
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for RoutingStatusRule and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            // to ensure "Agent" is required (not null)
            if (Agent == null)
            {
                throw new InvalidDataException("Agent is a required property for RoutingStatusRule and cannot be null");
            }
            else
            {
                this.Agent = Agent;
            }
            
            
            
            
            
            // to ensure "RoutingStatus" is required (not null)
            if (RoutingStatus == null)
            {
                throw new InvalidDataException("RoutingStatus is a required property for RoutingStatusRule and cannot be null");
            }
            else
            {
                this.RoutingStatus = RoutingStatus;
            }
            
            
            
            
            
            // to ensure "RoutingLimitInSeconds" is required (not null)
            if (RoutingLimitInSeconds == null)
            {
                throw new InvalidDataException("RoutingLimitInSeconds is a required property for RoutingStatusRule and cannot be null");
            }
            else
            {
                this.RoutingLimitInSeconds = RoutingLimitInSeconds;
            }
            
            
            
            
            
            // to ensure "Enabled" is required (not null)
            if (Enabled == null)
            {
                throw new InvalidDataException("Enabled is a required property for RoutingStatusRule and cannot be null");
            }
            else
            {
                this.Enabled = Enabled;
            }
            
            
            
            
            
            
            
            // to ensure "NotificationUsers" is required (not null)
            if (NotificationUsers == null)
            {
                throw new InvalidDataException("NotificationUsers is a required property for RoutingStatusRule and cannot be null");
            }
            else
            {
                this.NotificationUsers = NotificationUsers;
            }
            
            
            
            
            
            // to ensure "AlertTypes" is required (not null)
            if (AlertTypes == null)
            {
                throw new InvalidDataException("AlertTypes is a required property for RoutingStatusRule and cannot be null");
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
        /// Indicates if the rule is enabled.
        /// </summary>
        /// <value>Indicates if the rule is enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// Indicates if the rule is in alarm state.
        /// </summary>
        /// <value>Indicates if the rule is in alarm state.</value>
        [DataMember(Name="inAlarm", EmitDefaultValue=false)]
        public bool? InAlarm { get; private set; }
        
        
        
        /// <summary>
        /// The ids of users who will be notified of alarm state change.
        /// </summary>
        /// <value>The ids of users who will be notified of alarm state change.</value>
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
            sb.Append("class RoutingStatusRule {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
            
            sb.Append("  RoutingLimitInSeconds: ").Append(RoutingLimitInSeconds).Append("\n");
            
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            
            sb.Append("  InAlarm: ").Append(InAlarm).Append("\n");
            
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
            return this.Equals(obj as RoutingStatusRule);
        }

        /// <summary>
        /// Returns true if RoutingStatusRule instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutingStatusRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingStatusRule other)
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
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.InAlarm == other.InAlarm ||
                    this.InAlarm != null &&
                    this.InAlarm.Equals(other.InAlarm)
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
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.InAlarm != null)
                    hash = hash * 59 + this.InAlarm.GetHashCode();
                
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
