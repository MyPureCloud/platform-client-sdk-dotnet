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
    /// CommonAlert
    /// </summary>
    [DataContract]
    public partial class CommonAlert :  IEquatable<CommonAlert>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAlert" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonAlert() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAlert" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="User">The user who created the rule that triggered the alert. (required).</param>
        /// <param name="Rule">The properties of the rule that triggered the alert. (required).</param>
        /// <param name="Notifications">The collection of notification methods and the ids of users who were notified by those methods. (required).</param>
        /// <param name="DateStart">The timestamp of when the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="DateEnd">The timestamp of when the alert ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Active">Indicates if an alert is currently active. (required).</param>
        /// <param name="Unread">Indicates if an alert has not been read. (required).</param>
        /// <param name="WaitBetweenNotificationMs">The amount of time to wait between notification. Time is in milliseconds. (required).</param>
        /// <param name="Muted">Flag indicating if the alert is in a muted state. (required).</param>
        /// <param name="Snoozed">Flag indicating if the alert is in a snoozed state. (required).</param>
        /// <param name="DateMutedUntil">Timestamp of when the mute status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="DateSnoozedUntil">Timestamp of when the snooze status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="Conditions">The conditions that make up the rule. (required).</param>
        /// <param name="ConversationId">The id of the conversation instance that caused the alert to trigger..</param>
        /// <param name="AlertSummary">Summary of the alert status of the entities defined in the conditions.  Is set when rule has instance-based or team member based rule predicates.</param>
        /// <param name="RuleUri">RuleUri.</param>
        public CommonAlert(string Name = null, UserReference User = null, AlertRuleProperties Rule = null, List<AlertNotification> Notifications = null, DateTime? DateStart = null, DateTime? DateEnd = null, bool? Active = null, bool? Unread = null, long? WaitBetweenNotificationMs = null, bool? Muted = null, bool? Snoozed = null, DateTime? DateMutedUntil = null, DateTime? DateSnoozedUntil = null, CommonRuleConditions Conditions = null, string ConversationId = null, AlertSummary AlertSummary = null, string RuleUri = null)
        {
            this.Name = Name;
            this.User = User;
            this.Rule = Rule;
            this.Notifications = Notifications;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.Active = Active;
            this.Unread = Unread;
            this.WaitBetweenNotificationMs = WaitBetweenNotificationMs;
            this.Muted = Muted;
            this.Snoozed = Snoozed;
            this.DateMutedUntil = DateMutedUntil;
            this.DateSnoozedUntil = DateSnoozedUntil;
            this.Conditions = Conditions;
            this.ConversationId = ConversationId;
            this.AlertSummary = AlertSummary;
            this.RuleUri = RuleUri;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The user who created the rule that triggered the alert.
        /// </summary>
        /// <value>The user who created the rule that triggered the alert.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The properties of the rule that triggered the alert.
        /// </summary>
        /// <value>The properties of the rule that triggered the alert.</value>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public AlertRuleProperties Rule { get; set; }



        /// <summary>
        /// The collection of notification methods and the ids of users who were notified by those methods.
        /// </summary>
        /// <value>The collection of notification methods and the ids of users who were notified by those methods.</value>
        [DataMember(Name="notifications", EmitDefaultValue=false)]
        public List<AlertNotification> Notifications { get; set; }



        /// <summary>
        /// The timestamp of when the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp of when the alert was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }



        /// <summary>
        /// The timestamp of when the alert ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp of when the alert ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public DateTime? DateEnd { get; set; }



        /// <summary>
        /// Indicates if an alert is currently active.
        /// </summary>
        /// <value>Indicates if an alert is currently active.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }



        /// <summary>
        /// Indicates if an alert has not been read.
        /// </summary>
        /// <value>Indicates if an alert has not been read.</value>
        [DataMember(Name="unread", EmitDefaultValue=false)]
        public bool? Unread { get; set; }



        /// <summary>
        /// The amount of time to wait between notification. Time is in milliseconds.
        /// </summary>
        /// <value>The amount of time to wait between notification. Time is in milliseconds.</value>
        [DataMember(Name="waitBetweenNotificationMs", EmitDefaultValue=false)]
        public long? WaitBetweenNotificationMs { get; set; }



        /// <summary>
        /// Flag indicating if the alert is in a muted state.
        /// </summary>
        /// <value>Flag indicating if the alert is in a muted state.</value>
        [DataMember(Name="muted", EmitDefaultValue=false)]
        public bool? Muted { get; set; }



        /// <summary>
        /// Flag indicating if the alert is in a snoozed state.
        /// </summary>
        /// <value>Flag indicating if the alert is in a snoozed state.</value>
        [DataMember(Name="snoozed", EmitDefaultValue=false)]
        public bool? Snoozed { get; set; }



        /// <summary>
        /// Timestamp of when the mute status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp of when the mute status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateMutedUntil", EmitDefaultValue=false)]
        public DateTime? DateMutedUntil { get; set; }



        /// <summary>
        /// Timestamp of when the snooze status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp of when the snooze status of the alert should end. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateSnoozedUntil", EmitDefaultValue=false)]
        public DateTime? DateSnoozedUntil { get; set; }



        /// <summary>
        /// The conditions that make up the rule.
        /// </summary>
        /// <value>The conditions that make up the rule.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public CommonRuleConditions Conditions { get; set; }



        /// <summary>
        /// The id of the conversation instance that caused the alert to trigger.
        /// </summary>
        /// <value>The id of the conversation instance that caused the alert to trigger.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// Summary of the alert status of the entities defined in the conditions.  Is set when rule has instance-based or team member based rule predicates
        /// </summary>
        /// <value>Summary of the alert status of the entities defined in the conditions.  Is set when rule has instance-based or team member based rule predicates</value>
        [DataMember(Name="alertSummary", EmitDefaultValue=false)]
        public AlertSummary AlertSummary { get; set; }



        /// <summary>
        /// Gets or Sets RuleUri
        /// </summary>
        [DataMember(Name="ruleUri", EmitDefaultValue=false)]
        public string RuleUri { get; set; }



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
            sb.Append("class CommonAlert {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Unread: ").Append(Unread).Append("\n");
            sb.Append("  WaitBetweenNotificationMs: ").Append(WaitBetweenNotificationMs).Append("\n");
            sb.Append("  Muted: ").Append(Muted).Append("\n");
            sb.Append("  Snoozed: ").Append(Snoozed).Append("\n");
            sb.Append("  DateMutedUntil: ").Append(DateMutedUntil).Append("\n");
            sb.Append("  DateSnoozedUntil: ").Append(DateSnoozedUntil).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  AlertSummary: ").Append(AlertSummary).Append("\n");
            sb.Append("  RuleUri: ").Append(RuleUri).Append("\n");
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
            return this.Equals(obj as CommonAlert);
        }

        /// <summary>
        /// Returns true if CommonAlert instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonAlert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonAlert other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Rule == other.Rule ||
                    this.Rule != null &&
                    this.Rule.Equals(other.Rule)
                ) &&
                (
                    this.Notifications == other.Notifications ||
                    this.Notifications != null &&
                    this.Notifications.SequenceEqual(other.Notifications)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
                ) &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.Unread == other.Unread ||
                    this.Unread != null &&
                    this.Unread.Equals(other.Unread)
                ) &&
                (
                    this.WaitBetweenNotificationMs == other.WaitBetweenNotificationMs ||
                    this.WaitBetweenNotificationMs != null &&
                    this.WaitBetweenNotificationMs.Equals(other.WaitBetweenNotificationMs)
                ) &&
                (
                    this.Muted == other.Muted ||
                    this.Muted != null &&
                    this.Muted.Equals(other.Muted)
                ) &&
                (
                    this.Snoozed == other.Snoozed ||
                    this.Snoozed != null &&
                    this.Snoozed.Equals(other.Snoozed)
                ) &&
                (
                    this.DateMutedUntil == other.DateMutedUntil ||
                    this.DateMutedUntil != null &&
                    this.DateMutedUntil.Equals(other.DateMutedUntil)
                ) &&
                (
                    this.DateSnoozedUntil == other.DateSnoozedUntil ||
                    this.DateSnoozedUntil != null &&
                    this.DateSnoozedUntil.Equals(other.DateSnoozedUntil)
                ) &&
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.Equals(other.Conditions)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.AlertSummary == other.AlertSummary ||
                    this.AlertSummary != null &&
                    this.AlertSummary.Equals(other.AlertSummary)
                ) &&
                (
                    this.RuleUri == other.RuleUri ||
                    this.RuleUri != null &&
                    this.RuleUri.Equals(other.RuleUri)
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

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Rule != null)
                    hash = hash * 59 + this.Rule.GetHashCode();

                if (this.Notifications != null)
                    hash = hash * 59 + this.Notifications.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();

                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();

                if (this.Unread != null)
                    hash = hash * 59 + this.Unread.GetHashCode();

                if (this.WaitBetweenNotificationMs != null)
                    hash = hash * 59 + this.WaitBetweenNotificationMs.GetHashCode();

                if (this.Muted != null)
                    hash = hash * 59 + this.Muted.GetHashCode();

                if (this.Snoozed != null)
                    hash = hash * 59 + this.Snoozed.GetHashCode();

                if (this.DateMutedUntil != null)
                    hash = hash * 59 + this.DateMutedUntil.GetHashCode();

                if (this.DateSnoozedUntil != null)
                    hash = hash * 59 + this.DateSnoozedUntil.GetHashCode();

                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.AlertSummary != null)
                    hash = hash * 59 + this.AlertSummary.GetHashCode();

                if (this.RuleUri != null)
                    hash = hash * 59 + this.RuleUri.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
