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
    /// CommonRule
    /// </summary>
    [DataContract]
    public partial class CommonRule :  IEquatable<CommonRule>
    {
        /// <summary>
        /// The type of the rule.
        /// </summary>
        /// <value>The type of the rule.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Conversationmetrics for "ConversationMetrics"
            /// </summary>
            [EnumMember(Value = "ConversationMetrics")]
            Conversationmetrics,
            
            /// <summary>
            /// Enum Userpresence for "UserPresence"
            /// </summary>
            [EnumMember(Value = "UserPresence")]
            Userpresence,
            
            /// <summary>
            /// Enum Workforcemanagement for "WorkforceManagement"
            /// </summary>
            [EnumMember(Value = "WorkforceManagement")]
            Workforcemanagement,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The type of the rule.
        /// </summary>
        /// <value>The type of the rule.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRule" /> class.
        /// </summary>
        /// <param name="Name">Name of the rule (required).</param>
        /// <param name="Description">The description of the rule..</param>
        /// <param name="Enabled">Indicates if the rule is enabled..</param>
        /// <param name="Notifications">The alert notification types to trigger when alarm state changes as well as the users they will be sent to..</param>
        /// <param name="SendExitingAlarmNotifications">Indicates if the alert will send a notification when it is closed..</param>
        /// <param name="WaitBetweenNotificationMs">The amount of time in milliseconds to wait between notification..</param>
        /// <param name="Conditions">The set of metric conditions that would trigger an alert..</param>
        /// <param name="Type">The type of the rule. (required).</param>
        /// <param name="InAlarm">Indicates if the rule is in alarm state..</param>
        /// <param name="User">The entity that created the rule..</param>
        /// <param name="Version">The current version number of the rule..</param>
        /// <param name="DateCreated">The creation date of the rule when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateLastModified">The timestamp of the last update to the rule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public CommonRule(string Name = null, string Description = null, bool? Enabled = null, List<AlertNotification> Notifications = null, bool? SendExitingAlarmNotifications = null, long? WaitBetweenNotificationMs = null, CommonRuleConditions Conditions = null, TypeEnum? Type = null, bool? InAlarm = null, UserReference User = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateLastModified = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Enabled = Enabled;
            this.Notifications = Notifications;
            this.SendExitingAlarmNotifications = SendExitingAlarmNotifications;
            this.WaitBetweenNotificationMs = WaitBetweenNotificationMs;
            this.Conditions = Conditions;
            this.Type = Type;
            this.InAlarm = InAlarm;
            this.User = User;
            this.Version = Version;
            this.DateCreated = DateCreated;
            this.DateLastModified = DateLastModified;
            
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
        /// The description of the rule.
        /// </summary>
        /// <value>The description of the rule.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Indicates if the rule is enabled.
        /// </summary>
        /// <value>Indicates if the rule is enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The alert notification types to trigger when alarm state changes as well as the users they will be sent to.
        /// </summary>
        /// <value>The alert notification types to trigger when alarm state changes as well as the users they will be sent to.</value>
        [DataMember(Name="notifications", EmitDefaultValue=false)]
        public List<AlertNotification> Notifications { get; set; }



        /// <summary>
        /// Indicates if the alert will send a notification when it is closed.
        /// </summary>
        /// <value>Indicates if the alert will send a notification when it is closed.</value>
        [DataMember(Name="sendExitingAlarmNotifications", EmitDefaultValue=false)]
        public bool? SendExitingAlarmNotifications { get; set; }



        /// <summary>
        /// The amount of time in milliseconds to wait between notification.
        /// </summary>
        /// <value>The amount of time in milliseconds to wait between notification.</value>
        [DataMember(Name="waitBetweenNotificationMs", EmitDefaultValue=false)]
        public long? WaitBetweenNotificationMs { get; set; }



        /// <summary>
        /// The set of metric conditions that would trigger an alert.
        /// </summary>
        /// <value>The set of metric conditions that would trigger an alert.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public CommonRuleConditions Conditions { get; set; }





        /// <summary>
        /// Indicates if the rule is in alarm state.
        /// </summary>
        /// <value>Indicates if the rule is in alarm state.</value>
        [DataMember(Name="inAlarm", EmitDefaultValue=false)]
        public bool? InAlarm { get; set; }



        /// <summary>
        /// The entity that created the rule.
        /// </summary>
        /// <value>The entity that created the rule.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The current version number of the rule.
        /// </summary>
        /// <value>The current version number of the rule.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The creation date of the rule when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The creation date of the rule when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The timestamp of the last update to the rule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp of the last update to the rule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateLastModified", EmitDefaultValue=false)]
        public DateTime? DateLastModified { get; set; }



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
            sb.Append("class CommonRule {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            sb.Append("  SendExitingAlarmNotifications: ").Append(SendExitingAlarmNotifications).Append("\n");
            sb.Append("  WaitBetweenNotificationMs: ").Append(WaitBetweenNotificationMs).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InAlarm: ").Append(InAlarm).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateLastModified: ").Append(DateLastModified).Append("\n");
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
            return this.Equals(obj as CommonRule);
        }

        /// <summary>
        /// Returns true if CommonRule instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonRule other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Notifications == other.Notifications ||
                    this.Notifications != null &&
                    this.Notifications.SequenceEqual(other.Notifications)
                ) &&
                (
                    this.SendExitingAlarmNotifications == other.SendExitingAlarmNotifications ||
                    this.SendExitingAlarmNotifications != null &&
                    this.SendExitingAlarmNotifications.Equals(other.SendExitingAlarmNotifications)
                ) &&
                (
                    this.WaitBetweenNotificationMs == other.WaitBetweenNotificationMs ||
                    this.WaitBetweenNotificationMs != null &&
                    this.WaitBetweenNotificationMs.Equals(other.WaitBetweenNotificationMs)
                ) &&
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.Equals(other.Conditions)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.InAlarm == other.InAlarm ||
                    this.InAlarm != null &&
                    this.InAlarm.Equals(other.InAlarm)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateLastModified == other.DateLastModified ||
                    this.DateLastModified != null &&
                    this.DateLastModified.Equals(other.DateLastModified)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Notifications != null)
                    hash = hash * 59 + this.Notifications.GetHashCode();

                if (this.SendExitingAlarmNotifications != null)
                    hash = hash * 59 + this.SendExitingAlarmNotifications.GetHashCode();

                if (this.WaitBetweenNotificationMs != null)
                    hash = hash * 59 + this.WaitBetweenNotificationMs.GetHashCode();

                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.InAlarm != null)
                    hash = hash * 59 + this.InAlarm.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateLastModified != null)
                    hash = hash * 59 + this.DateLastModified.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
