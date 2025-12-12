using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ModifiableRuleProperties
	/// </summary>
	[DataContract]
	public partial class ModifiableRuleProperties : IEquatable<ModifiableRuleProperties>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ModifiableRuleProperties" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ModifiableRuleProperties() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ModifiableRuleProperties" /> class.
		/// </summary>
		/// <param name="Name">Name of the rule (required).</param>
		/// <param name="Description">The description of the rule..</param>
		/// <param name="Enabled">Indicates if the rule is enabled..</param>
		/// <param name="Notifications">The alert notification types to trigger when alarm state changes as well as the users they will be sent to..</param>
		/// <param name="SendExitingAlarmNotifications">Indicates if the alert will send a notification when it is closed..</param>
		/// <param name="WaitBetweenNotificationMs">The amount of time in milliseconds to wait between notification..</param>
		/// <param name="Conditions">The set of metric conditions that would trigger an alert..</param>
		public ModifiableRuleProperties(string Name = null, string Description = null, bool? Enabled = null, List<AlertNotification> Notifications = null, bool? SendExitingAlarmNotifications = null, long? WaitBetweenNotificationMs = null, CommonRuleConditions Conditions = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.Enabled = Enabled;
			this.Notifications = Notifications;
			this.SendExitingAlarmNotifications = SendExitingAlarmNotifications;
			this.WaitBetweenNotificationMs = WaitBetweenNotificationMs;
			this.Conditions = Conditions;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Name of the rule
		/// </summary>
		/// <value>Name of the rule</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The description of the rule.
		/// </summary>
		/// <value>The description of the rule.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Indicates if the rule is enabled.
		/// </summary>
		/// <value>Indicates if the rule is enabled.</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }



		/// <summary>
		/// The alert notification types to trigger when alarm state changes as well as the users they will be sent to.
		/// </summary>
		/// <value>The alert notification types to trigger when alarm state changes as well as the users they will be sent to.</value>
		[DataMember(Name = "notifications", EmitDefaultValue = false)]
		public List<AlertNotification> Notifications { get; set; }



		/// <summary>
		/// Indicates if the alert will send a notification when it is closed.
		/// </summary>
		/// <value>Indicates if the alert will send a notification when it is closed.</value>
		[DataMember(Name = "sendExitingAlarmNotifications", EmitDefaultValue = false)]
		public bool? SendExitingAlarmNotifications { get; set; }



		/// <summary>
		/// The amount of time in milliseconds to wait between notification.
		/// </summary>
		/// <value>The amount of time in milliseconds to wait between notification.</value>
		[DataMember(Name = "waitBetweenNotificationMs", EmitDefaultValue = false)]
		public long? WaitBetweenNotificationMs { get; set; }



		/// <summary>
		/// The set of metric conditions that would trigger an alert.
		/// </summary>
		/// <value>The set of metric conditions that would trigger an alert.</value>
		[DataMember(Name = "conditions", EmitDefaultValue = false)]
		public CommonRuleConditions Conditions { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ModifiableRuleProperties {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  Notifications: ").Append(Notifications).Append("\n");
			sb.Append("  SendExitingAlarmNotifications: ").Append(SendExitingAlarmNotifications).Append("\n");
			sb.Append("  WaitBetweenNotificationMs: ").Append(WaitBetweenNotificationMs).Append("\n");
			sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
			return this.Equals(obj as ModifiableRuleProperties);
		}

		/// <summary>
		/// Returns true if ModifiableRuleProperties instances are equal
		/// </summary>
		/// <param name="other">Instance of ModifiableRuleProperties to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ModifiableRuleProperties other)
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

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
