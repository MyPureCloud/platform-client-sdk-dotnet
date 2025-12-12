using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2MobiusAlertsTopicAlert
	/// </summary>
	[DataContract]
	public partial class V2MobiusAlertsTopicAlert : IEquatable<V2MobiusAlertsTopicAlert>
	{
		/// <summary>
		/// Gets or Sets Action
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActionEnum
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
			/// Enum Create for "CREATE"
			/// </summary>
			[EnumMember(Value = "CREATE")]
			Create,

			/// <summary>
			/// Enum Update for "UPDATE"
			/// </summary>
			[EnumMember(Value = "UPDATE")]
			Update,

			/// <summary>
			/// Enum Delete for "DELETE"
			/// </summary>
			[EnumMember(Value = "DELETE")]
			Delete,

			/// <summary>
			/// Enum Close for "CLOSE"
			/// </summary>
			[EnumMember(Value = "CLOSE")]
			Close,

			/// <summary>
			/// Enum Renotify for "RENOTIFY"
			/// </summary>
			[EnumMember(Value = "RENOTIFY")]
			Renotify,

			/// <summary>
			/// Enum BulkDelete for "BULK_DELETE"
			/// </summary>
			[EnumMember(Value = "BULK_DELETE")]
			BulkDelete,

			/// <summary>
			/// Enum BulkUpdate for "BULK_UPDATE"
			/// </summary>
			[EnumMember(Value = "BULK_UPDATE")]
			BulkUpdate,

			/// <summary>
			/// Enum UnreadCountUpdate for "UNREAD_COUNT_UPDATE"
			/// </summary>
			[EnumMember(Value = "UNREAD_COUNT_UPDATE")]
			UnreadCountUpdate
		}
		/// <summary>
		/// Gets or Sets Action
		/// </summary>
		[DataMember(Name = "action", EmitDefaultValue = false)]
		public ActionEnum? Action { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="V2MobiusAlertsTopicAlert" /> class.
		/// </summary>
		/// <param name="Rule">Rule.</param>
		/// <param name="Id">Id.</param>
		/// <param name="UserId">UserId.</param>
		/// <param name="Notifications">Notifications.</param>
		/// <param name="DateStart">DateStart.</param>
		/// <param name="DateEnd">DateEnd.</param>
		/// <param name="Conditions">Conditions.</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="Active">Active.</param>
		/// <param name="Unread">Unread.</param>
		/// <param name="Muted">Muted.</param>
		/// <param name="Snoozed">Snoozed.</param>
		/// <param name="DateMutedUntil">DateMutedUntil.</param>
		/// <param name="DateSnoozedUntil">DateSnoozedUntil.</param>
		/// <param name="Action">Action.</param>
		/// <param name="AlertSummary">AlertSummary.</param>
		/// <param name="SendExitingAlarmNotification">SendExitingAlarmNotification.</param>
		public V2MobiusAlertsTopicAlert(V2MobiusAlertsTopicAlertRuleProperties Rule = null, Guid? Id = null, Guid? UserId = null, List<V2MobiusAlertsTopicAlertNotification> Notifications = null, DateTime? DateStart = null, DateTime? DateEnd = null, V2MobiusAlertsTopicCondition Conditions = null, Dictionary<string, string> AdditionalProperties = null, bool? Active = null, bool? Unread = null, bool? Muted = null, bool? Snoozed = null, DateTime? DateMutedUntil = null, DateTime? DateSnoozedUntil = null, ActionEnum? Action = null, V2MobiusAlertsTopicAlertSummary AlertSummary = null, bool? SendExitingAlarmNotification = null)
		{
			this.Rule = Rule;
			this.Id = Id;
			this.UserId = UserId;
			this.Notifications = Notifications;
			this.DateStart = DateStart;
			this.DateEnd = DateEnd;
			this.Conditions = Conditions;
			this.AdditionalProperties = AdditionalProperties;
			this.Active = Active;
			this.Unread = Unread;
			this.Muted = Muted;
			this.Snoozed = Snoozed;
			this.DateMutedUntil = DateMutedUntil;
			this.DateSnoozedUntil = DateSnoozedUntil;
			this.Action = Action;
			this.AlertSummary = AlertSummary;
			this.SendExitingAlarmNotification = SendExitingAlarmNotification;

		}



		/// <summary>
		/// Gets or Sets Rule
		/// </summary>
		[DataMember(Name = "rule", EmitDefaultValue = false)]
		public V2MobiusAlertsTopicAlertRuleProperties Rule { get; set; }



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public Guid? Id { get; set; }



		/// <summary>
		/// Gets or Sets UserId
		/// </summary>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public Guid? UserId { get; set; }



		/// <summary>
		/// Gets or Sets Notifications
		/// </summary>
		[DataMember(Name = "notifications", EmitDefaultValue = false)]
		public List<V2MobiusAlertsTopicAlertNotification> Notifications { get; set; }



		/// <summary>
		/// Gets or Sets DateStart
		/// </summary>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public DateTime? DateStart { get; set; }



		/// <summary>
		/// Gets or Sets DateEnd
		/// </summary>
		[DataMember(Name = "dateEnd", EmitDefaultValue = false)]
		public DateTime? DateEnd { get; set; }



		/// <summary>
		/// Gets or Sets Conditions
		/// </summary>
		[DataMember(Name = "conditions", EmitDefaultValue = false)]
		public V2MobiusAlertsTopicCondition Conditions { get; set; }



		/// <summary>
		/// Gets or Sets AdditionalProperties
		/// </summary>
		[DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, string> AdditionalProperties { get; set; }



		/// <summary>
		/// Gets or Sets Active
		/// </summary>
		[DataMember(Name = "active", EmitDefaultValue = false)]
		public bool? Active { get; set; }



		/// <summary>
		/// Gets or Sets Unread
		/// </summary>
		[DataMember(Name = "unread", EmitDefaultValue = false)]
		public bool? Unread { get; set; }



		/// <summary>
		/// Gets or Sets Muted
		/// </summary>
		[DataMember(Name = "muted", EmitDefaultValue = false)]
		public bool? Muted { get; set; }



		/// <summary>
		/// Gets or Sets Snoozed
		/// </summary>
		[DataMember(Name = "snoozed", EmitDefaultValue = false)]
		public bool? Snoozed { get; set; }



		/// <summary>
		/// Gets or Sets DateMutedUntil
		/// </summary>
		[DataMember(Name = "dateMutedUntil", EmitDefaultValue = false)]
		public DateTime? DateMutedUntil { get; set; }



		/// <summary>
		/// Gets or Sets DateSnoozedUntil
		/// </summary>
		[DataMember(Name = "dateSnoozedUntil", EmitDefaultValue = false)]
		public DateTime? DateSnoozedUntil { get; set; }





		/// <summary>
		/// Gets or Sets AlertSummary
		/// </summary>
		[DataMember(Name = "alertSummary", EmitDefaultValue = false)]
		public V2MobiusAlertsTopicAlertSummary AlertSummary { get; set; }



		/// <summary>
		/// Gets or Sets SendExitingAlarmNotification
		/// </summary>
		[DataMember(Name = "sendExitingAlarmNotification", EmitDefaultValue = false)]
		public bool? SendExitingAlarmNotification { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2MobiusAlertsTopicAlert {\n");

			sb.Append("  Rule: ").Append(Rule).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  Notifications: ").Append(Notifications).Append("\n");
			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
			sb.Append("  Conditions: ").Append(Conditions).Append("\n");
			sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
			sb.Append("  Active: ").Append(Active).Append("\n");
			sb.Append("  Unread: ").Append(Unread).Append("\n");
			sb.Append("  Muted: ").Append(Muted).Append("\n");
			sb.Append("  Snoozed: ").Append(Snoozed).Append("\n");
			sb.Append("  DateMutedUntil: ").Append(DateMutedUntil).Append("\n");
			sb.Append("  DateSnoozedUntil: ").Append(DateSnoozedUntil).Append("\n");
			sb.Append("  Action: ").Append(Action).Append("\n");
			sb.Append("  AlertSummary: ").Append(AlertSummary).Append("\n");
			sb.Append("  SendExitingAlarmNotification: ").Append(SendExitingAlarmNotification).Append("\n");
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
			return this.Equals(obj as V2MobiusAlertsTopicAlert);
		}

		/// <summary>
		/// Returns true if V2MobiusAlertsTopicAlert instances are equal
		/// </summary>
		/// <param name="other">Instance of V2MobiusAlertsTopicAlert to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2MobiusAlertsTopicAlert other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Rule == other.Rule ||
					this.Rule != null &&
					this.Rule.Equals(other.Rule)
				) &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
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
					this.Conditions == other.Conditions ||
					this.Conditions != null &&
					this.Conditions.Equals(other.Conditions)
				) &&
				(
					this.AdditionalProperties == other.AdditionalProperties ||
					this.AdditionalProperties != null &&
					this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
					this.Action == other.Action ||
					this.Action != null &&
					this.Action.Equals(other.Action)
				) &&
				(
					this.AlertSummary == other.AlertSummary ||
					this.AlertSummary != null &&
					this.AlertSummary.Equals(other.AlertSummary)
				) &&
				(
					this.SendExitingAlarmNotification == other.SendExitingAlarmNotification ||
					this.SendExitingAlarmNotification != null &&
					this.SendExitingAlarmNotification.Equals(other.SendExitingAlarmNotification)
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
				if (this.Rule != null)
					hash = hash * 59 + this.Rule.GetHashCode();

				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				if (this.Notifications != null)
					hash = hash * 59 + this.Notifications.GetHashCode();

				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.DateEnd != null)
					hash = hash * 59 + this.DateEnd.GetHashCode();

				if (this.Conditions != null)
					hash = hash * 59 + this.Conditions.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.Active != null)
					hash = hash * 59 + this.Active.GetHashCode();

				if (this.Unread != null)
					hash = hash * 59 + this.Unread.GetHashCode();

				if (this.Muted != null)
					hash = hash * 59 + this.Muted.GetHashCode();

				if (this.Snoozed != null)
					hash = hash * 59 + this.Snoozed.GetHashCode();

				if (this.DateMutedUntil != null)
					hash = hash * 59 + this.DateMutedUntil.GetHashCode();

				if (this.DateSnoozedUntil != null)
					hash = hash * 59 + this.DateSnoozedUntil.GetHashCode();

				if (this.Action != null)
					hash = hash * 59 + this.Action.GetHashCode();

				if (this.AlertSummary != null)
					hash = hash * 59 + this.AlertSummary.GetHashCode();

				if (this.SendExitingAlarmNotification != null)
					hash = hash * 59 + this.SendExitingAlarmNotification.GetHashCode();

				return hash;
			}
		}
	}

}
