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
    /// UserPresenceRule
    /// </summary>
    [DataContract]
    public partial class UserPresenceRule :  IEquatable<UserPresenceRule>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates to which presence type the presence value belongs.
        /// </summary>
        /// <value>Indicates to which presence type the presence value belongs.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PresenceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum System for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            System,
            
            /// <summary>
            /// Enum Organization for "ORGANIZATION"
            /// </summary>
            [EnumMember(Value = "ORGANIZATION")]
            Organization
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
        /// Indicates to which presence type the presence value belongs.
        /// </summary>
        /// <value>Indicates to which presence type the presence value belongs.</value>
        [DataMember(Name="presenceType", EmitDefaultValue=false)]
        public PresenceTypeEnum? PresenceType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPresenceRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserPresenceRule() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPresenceRule" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name of the rule (required).</param>
        
        
        
        /// <param name="PresenceUser">The user whose presence will be watched. (required).</param>
        
        
        
        /// <param name="PresenceType">Indicates to which presence type the presence value belongs. (required).</param>
        
        
        
        /// <param name="PresenceValue">The Org&#39;s UUID or Systems enum constance indicating the presence of concern. (required).</param>
        
        
        
        /// <param name="PresenceLimitInSeconds">The number of seconds to wait before alerting based upon the user&#39;s presence. (required).</param>
        
        
        
        /// <param name="Enabled">Indicates if the rule is enabled. (required).</param>
        
        
        
        
        
        /// <param name="NotificationUsers">The ids of users who will be notified of alarm state change. (required).</param>
        
        
        
        /// <param name="AlertTypes">A collection of notification methods. (required).</param>
        
        
        
        
        public UserPresenceRule(string Name = null, User PresenceUser = null, PresenceTypeEnum? PresenceType = null, string PresenceValue = null, int? PresenceLimitInSeconds = null, bool? Enabled = null, List<User> NotificationUsers = null, List<AlertTypesEnum> AlertTypes = null)
        {
            
            
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for UserPresenceRule and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            // to ensure "PresenceUser" is required (not null)
            if (PresenceUser == null)
            {
                throw new InvalidDataException("PresenceUser is a required property for UserPresenceRule and cannot be null");
            }
            else
            {
                this.PresenceUser = PresenceUser;
            }
            
            
            
            
            
            // to ensure "PresenceType" is required (not null)
            if (PresenceType == null)
            {
                throw new InvalidDataException("PresenceType is a required property for UserPresenceRule and cannot be null");
            }
            else
            {
                this.PresenceType = PresenceType;
            }
            
            
            
            
            
            // to ensure "PresenceValue" is required (not null)
            if (PresenceValue == null)
            {
                throw new InvalidDataException("PresenceValue is a required property for UserPresenceRule and cannot be null");
            }
            else
            {
                this.PresenceValue = PresenceValue;
            }
            
            
            
            
            
            // to ensure "PresenceLimitInSeconds" is required (not null)
            if (PresenceLimitInSeconds == null)
            {
                throw new InvalidDataException("PresenceLimitInSeconds is a required property for UserPresenceRule and cannot be null");
            }
            else
            {
                this.PresenceLimitInSeconds = PresenceLimitInSeconds;
            }
            
            
            
            
            
            // to ensure "Enabled" is required (not null)
            if (Enabled == null)
            {
                throw new InvalidDataException("Enabled is a required property for UserPresenceRule and cannot be null");
            }
            else
            {
                this.Enabled = Enabled;
            }
            
            
            
            
            
            
            
            // to ensure "NotificationUsers" is required (not null)
            if (NotificationUsers == null)
            {
                throw new InvalidDataException("NotificationUsers is a required property for UserPresenceRule and cannot be null");
            }
            else
            {
                this.NotificationUsers = NotificationUsers;
            }
            
            
            
            
            
            // to ensure "AlertTypes" is required (not null)
            if (AlertTypes == null)
            {
                throw new InvalidDataException("AlertTypes is a required property for UserPresenceRule and cannot be null");
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
        /// The user whose presence will be watched.
        /// </summary>
        /// <value>The user whose presence will be watched.</value>
        [DataMember(Name="presenceUser", EmitDefaultValue=false)]
        public User PresenceUser { get; set; }
        
        
        
        
        
        /// <summary>
        /// The Org&#39;s UUID or Systems enum constance indicating the presence of concern.
        /// </summary>
        /// <value>The Org&#39;s UUID or Systems enum constance indicating the presence of concern.</value>
        [DataMember(Name="presenceValue", EmitDefaultValue=false)]
        public string PresenceValue { get; set; }
        
        
        
        /// <summary>
        /// The number of seconds to wait before alerting based upon the user&#39;s presence.
        /// </summary>
        /// <value>The number of seconds to wait before alerting based upon the user&#39;s presence.</value>
        [DataMember(Name="presenceLimitInSeconds", EmitDefaultValue=false)]
        public int? PresenceLimitInSeconds { get; set; }
        
        
        
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
            sb.Append("class UserPresenceRule {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  PresenceUser: ").Append(PresenceUser).Append("\n");
            
            sb.Append("  PresenceType: ").Append(PresenceType).Append("\n");
            
            sb.Append("  PresenceValue: ").Append(PresenceValue).Append("\n");
            
            sb.Append("  PresenceLimitInSeconds: ").Append(PresenceLimitInSeconds).Append("\n");
            
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
            return this.Equals(obj as UserPresenceRule);
        }

        /// <summary>
        /// Returns true if UserPresenceRule instances are equal
        /// </summary>
        /// <param name="other">Instance of UserPresenceRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPresenceRule other)
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
                    this.PresenceUser == other.PresenceUser ||
                    this.PresenceUser != null &&
                    this.PresenceUser.Equals(other.PresenceUser)
                ) &&
                (
                    this.PresenceType == other.PresenceType ||
                    this.PresenceType != null &&
                    this.PresenceType.Equals(other.PresenceType)
                ) &&
                (
                    this.PresenceValue == other.PresenceValue ||
                    this.PresenceValue != null &&
                    this.PresenceValue.Equals(other.PresenceValue)
                ) &&
                (
                    this.PresenceLimitInSeconds == other.PresenceLimitInSeconds ||
                    this.PresenceLimitInSeconds != null &&
                    this.PresenceLimitInSeconds.Equals(other.PresenceLimitInSeconds)
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
                
                if (this.PresenceUser != null)
                    hash = hash * 59 + this.PresenceUser.GetHashCode();
                
                if (this.PresenceType != null)
                    hash = hash * 59 + this.PresenceType.GetHashCode();
                
                if (this.PresenceValue != null)
                    hash = hash * 59 + this.PresenceValue.GetHashCode();
                
                if (this.PresenceLimitInSeconds != null)
                    hash = hash * 59 + this.PresenceLimitInSeconds.GetHashCode();
                
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
