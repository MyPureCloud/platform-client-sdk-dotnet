using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MessagingCampaign
	/// </summary>
	[DataContract]
	public partial class MessagingCampaign : IEquatable<MessagingCampaign>
	{
		/// <summary>
		/// The current status of the messaging campaign. A messaging campaign may be turned 'on' or 'off'.
		/// </summary>
		/// <value>The current status of the messaging campaign. A messaging campaign may be turned 'on' or 'off'.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum CampaignStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum On for "on"
			/// </summary>
			[EnumMember(Value = "on")]
			On,

			/// <summary>
			/// Enum Stopping for "stopping"
			/// </summary>
			[EnumMember(Value = "stopping")]
			Stopping,

			/// <summary>
			/// Enum Off for "off"
			/// </summary>
			[EnumMember(Value = "off")]
			Off,

			/// <summary>
			/// Enum Complete for "complete"
			/// </summary>
			[EnumMember(Value = "complete")]
			Complete,

			/// <summary>
			/// Enum Invalid for "invalid"
			/// </summary>
			[EnumMember(Value = "invalid")]
			Invalid,

			/// <summary>
			/// Enum ForcedOff for "forced_off"
			/// </summary>
			[EnumMember(Value = "forced_off")]
			ForcedOff,

			/// <summary>
			/// Enum ForcedStopping for "forced_stopping"
			/// </summary>
			[EnumMember(Value = "forced_stopping")]
			ForcedStopping
		}
		/// <summary>
		/// The current status of the messaging campaign. A messaging campaign may be turned 'on' or 'off'.
		/// </summary>
		/// <value>The current status of the messaging campaign. A messaging campaign may be turned 'on' or 'off'.</value>
		[DataMember(Name = "campaignStatus", EmitDefaultValue = false)]
		public CampaignStatusEnum? CampaignStatus { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="MessagingCampaign" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected MessagingCampaign() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="MessagingCampaign" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
		/// <param name="Division">The division this entity belongs to..</param>
		/// <param name="CampaignStatus">The current status of the messaging campaign. A messaging campaign may be turned &#39;on&#39; or &#39;off&#39;..</param>
		/// <param name="CallableTimeSet">The callable time set for this messaging campaign..</param>
		/// <param name="ContactList">The contact list that this messaging campaign will send messages for. (required).</param>
		/// <param name="DncLists">The dnc lists to check before sending a message for this messaging campaign..</param>
		/// <param name="AlwaysRunning">Whether this messaging campaign is always running.</param>
		/// <param name="ContactSorts">The order in which to sort contacts for dialing, based on up to four columns..</param>
		/// <param name="MessagesPerMinute">How many messages this messaging campaign will send per minute. (required).</param>
		/// <param name="RuleSets">Rule Sets to be applied while this campaign is sending messages.</param>
		/// <param name="ContactListFilters">The contact list filter to check before sending a message for this messaging campaign..</param>
		/// <param name="Errors">A list of current error conditions associated with this messaging campaign..</param>
		/// <param name="DynamicContactQueueingSettings">Indicates (when true) that the campaign supports dynamic queueing of the contact list at the time of a request for contacts..</param>
		/// <param name="EmailConfig">Configuration for this messaging campaign to send Email messages..</param>
		/// <param name="SmsConfig">Configuration for this messaging campaign to send SMS messages..</param>
		/// <param name="WhatsAppConfig">Configuration for this messaging campaign to send WhatsApp messages..</param>
		public MessagingCampaign(string Name = null, int? Version = null, DomainEntityRef Division = null, CampaignStatusEnum? CampaignStatus = null, DomainEntityRef CallableTimeSet = null, DomainEntityRef ContactList = null, List<DomainEntityRef> DncLists = null, bool? AlwaysRunning = null, List<ContactSort> ContactSorts = null, int? MessagesPerMinute = null, List<DomainEntityRef> RuleSets = null, List<DomainEntityRef> ContactListFilters = null, List<RestErrorDetail> Errors = null, DynamicContactQueueingSettings DynamicContactQueueingSettings = null, EmailConfig EmailConfig = null, SmsConfig SmsConfig = null, WhatsAppConfig WhatsAppConfig = null)
		{
			this.Name = Name;
			this.Version = Version;
			this.Division = Division;
			this.CampaignStatus = CampaignStatus;
			this.CallableTimeSet = CallableTimeSet;
			this.ContactList = ContactList;
			this.DncLists = DncLists;
			this.AlwaysRunning = AlwaysRunning;
			this.ContactSorts = ContactSorts;
			this.MessagesPerMinute = MessagesPerMinute;
			this.RuleSets = RuleSets;
			this.ContactListFilters = ContactListFilters;
			this.Errors = Errors;
			this.DynamicContactQueueingSettings = DynamicContactQueueingSettings;
			this.EmailConfig = EmailConfig;
			this.SmsConfig = SmsConfig;
			this.WhatsAppConfig = WhatsAppConfig;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



		/// <summary>
		/// Required for updates, must match the version number of the most recent update
		/// </summary>
		/// <value>Required for updates, must match the version number of the most recent update</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? Version { get; set; }



		/// <summary>
		/// The division this entity belongs to.
		/// </summary>
		/// <value>The division this entity belongs to.</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public DomainEntityRef Division { get; set; }





		/// <summary>
		/// The callable time set for this messaging campaign.
		/// </summary>
		/// <value>The callable time set for this messaging campaign.</value>
		[DataMember(Name = "callableTimeSet", EmitDefaultValue = false)]
		public DomainEntityRef CallableTimeSet { get; set; }



		/// <summary>
		/// The contact list that this messaging campaign will send messages for.
		/// </summary>
		/// <value>The contact list that this messaging campaign will send messages for.</value>
		[DataMember(Name = "contactList", EmitDefaultValue = false)]
		public DomainEntityRef ContactList { get; set; }



		/// <summary>
		/// The dnc lists to check before sending a message for this messaging campaign.
		/// </summary>
		/// <value>The dnc lists to check before sending a message for this messaging campaign.</value>
		[DataMember(Name = "dncLists", EmitDefaultValue = false)]
		public List<DomainEntityRef> DncLists { get; set; }



		/// <summary>
		/// Whether this messaging campaign is always running
		/// </summary>
		/// <value>Whether this messaging campaign is always running</value>
		[DataMember(Name = "alwaysRunning", EmitDefaultValue = false)]
		public bool? AlwaysRunning { get; set; }



		/// <summary>
		/// The order in which to sort contacts for dialing, based on up to four columns.
		/// </summary>
		/// <value>The order in which to sort contacts for dialing, based on up to four columns.</value>
		[DataMember(Name = "contactSorts", EmitDefaultValue = false)]
		public List<ContactSort> ContactSorts { get; set; }



		/// <summary>
		/// How many messages this messaging campaign will send per minute.
		/// </summary>
		/// <value>How many messages this messaging campaign will send per minute.</value>
		[DataMember(Name = "messagesPerMinute", EmitDefaultValue = false)]
		public int? MessagesPerMinute { get; set; }



		/// <summary>
		/// Rule Sets to be applied while this campaign is sending messages
		/// </summary>
		/// <value>Rule Sets to be applied while this campaign is sending messages</value>
		[DataMember(Name = "ruleSets", EmitDefaultValue = false)]
		public List<DomainEntityRef> RuleSets { get; set; }



		/// <summary>
		/// The contact list filter to check before sending a message for this messaging campaign.
		/// </summary>
		/// <value>The contact list filter to check before sending a message for this messaging campaign.</value>
		[DataMember(Name = "contactListFilters", EmitDefaultValue = false)]
		public List<DomainEntityRef> ContactListFilters { get; set; }



		/// <summary>
		/// A list of current error conditions associated with this messaging campaign.
		/// </summary>
		/// <value>A list of current error conditions associated with this messaging campaign.</value>
		[DataMember(Name = "errors", EmitDefaultValue = false)]
		public List<RestErrorDetail> Errors { get; set; }



		/// <summary>
		/// Indicates (when true) that the campaign supports dynamic queueing of the contact list at the time of a request for contacts.
		/// </summary>
		/// <value>Indicates (when true) that the campaign supports dynamic queueing of the contact list at the time of a request for contacts.</value>
		[DataMember(Name = "dynamicContactQueueingSettings", EmitDefaultValue = false)]
		public DynamicContactQueueingSettings DynamicContactQueueingSettings { get; set; }



		/// <summary>
		/// Configuration for this messaging campaign to send Email messages.
		/// </summary>
		/// <value>Configuration for this messaging campaign to send Email messages.</value>
		[DataMember(Name = "emailConfig", EmitDefaultValue = false)]
		public EmailConfig EmailConfig { get; set; }



		/// <summary>
		/// Configuration for this messaging campaign to send SMS messages.
		/// </summary>
		/// <value>Configuration for this messaging campaign to send SMS messages.</value>
		[DataMember(Name = "smsConfig", EmitDefaultValue = false)]
		public SmsConfig SmsConfig { get; set; }



		/// <summary>
		/// Configuration for this messaging campaign to send WhatsApp messages.
		/// </summary>
		/// <value>Configuration for this messaging campaign to send WhatsApp messages.</value>
		[DataMember(Name = "whatsAppConfig", EmitDefaultValue = false)]
		public WhatsAppConfig WhatsAppConfig { get; set; }



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
			sb.Append("class MessagingCampaign {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
			sb.Append("  CallableTimeSet: ").Append(CallableTimeSet).Append("\n");
			sb.Append("  ContactList: ").Append(ContactList).Append("\n");
			sb.Append("  DncLists: ").Append(DncLists).Append("\n");
			sb.Append("  AlwaysRunning: ").Append(AlwaysRunning).Append("\n");
			sb.Append("  ContactSorts: ").Append(ContactSorts).Append("\n");
			sb.Append("  MessagesPerMinute: ").Append(MessagesPerMinute).Append("\n");
			sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
			sb.Append("  ContactListFilters: ").Append(ContactListFilters).Append("\n");
			sb.Append("  Errors: ").Append(Errors).Append("\n");
			sb.Append("  DynamicContactQueueingSettings: ").Append(DynamicContactQueueingSettings).Append("\n");
			sb.Append("  EmailConfig: ").Append(EmailConfig).Append("\n");
			sb.Append("  SmsConfig: ").Append(SmsConfig).Append("\n");
			sb.Append("  WhatsAppConfig: ").Append(WhatsAppConfig).Append("\n");
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
			return this.Equals(obj as MessagingCampaign);
		}

		/// <summary>
		/// Returns true if MessagingCampaign instances are equal
		/// </summary>
		/// <param name="other">Instance of MessagingCampaign to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MessagingCampaign other)
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
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.CampaignStatus == other.CampaignStatus ||
					this.CampaignStatus != null &&
					this.CampaignStatus.Equals(other.CampaignStatus)
				) &&
				(
					this.CallableTimeSet == other.CallableTimeSet ||
					this.CallableTimeSet != null &&
					this.CallableTimeSet.Equals(other.CallableTimeSet)
				) &&
				(
					this.ContactList == other.ContactList ||
					this.ContactList != null &&
					this.ContactList.Equals(other.ContactList)
				) &&
				(
					this.DncLists == other.DncLists ||
					this.DncLists != null &&
					this.DncLists.SequenceEqual(other.DncLists)
				) &&
				(
					this.AlwaysRunning == other.AlwaysRunning ||
					this.AlwaysRunning != null &&
					this.AlwaysRunning.Equals(other.AlwaysRunning)
				) &&
				(
					this.ContactSorts == other.ContactSorts ||
					this.ContactSorts != null &&
					this.ContactSorts.SequenceEqual(other.ContactSorts)
				) &&
				(
					this.MessagesPerMinute == other.MessagesPerMinute ||
					this.MessagesPerMinute != null &&
					this.MessagesPerMinute.Equals(other.MessagesPerMinute)
				) &&
				(
					this.RuleSets == other.RuleSets ||
					this.RuleSets != null &&
					this.RuleSets.SequenceEqual(other.RuleSets)
				) &&
				(
					this.ContactListFilters == other.ContactListFilters ||
					this.ContactListFilters != null &&
					this.ContactListFilters.SequenceEqual(other.ContactListFilters)
				) &&
				(
					this.Errors == other.Errors ||
					this.Errors != null &&
					this.Errors.SequenceEqual(other.Errors)
				) &&
				(
					this.DynamicContactQueueingSettings == other.DynamicContactQueueingSettings ||
					this.DynamicContactQueueingSettings != null &&
					this.DynamicContactQueueingSettings.Equals(other.DynamicContactQueueingSettings)
				) &&
				(
					this.EmailConfig == other.EmailConfig ||
					this.EmailConfig != null &&
					this.EmailConfig.Equals(other.EmailConfig)
				) &&
				(
					this.SmsConfig == other.SmsConfig ||
					this.SmsConfig != null &&
					this.SmsConfig.Equals(other.SmsConfig)
				) &&
				(
					this.WhatsAppConfig == other.WhatsAppConfig ||
					this.WhatsAppConfig != null &&
					this.WhatsAppConfig.Equals(other.WhatsAppConfig)
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

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.CampaignStatus != null)
					hash = hash * 59 + this.CampaignStatus.GetHashCode();

				if (this.CallableTimeSet != null)
					hash = hash * 59 + this.CallableTimeSet.GetHashCode();

				if (this.ContactList != null)
					hash = hash * 59 + this.ContactList.GetHashCode();

				if (this.DncLists != null)
					hash = hash * 59 + this.DncLists.GetHashCode();

				if (this.AlwaysRunning != null)
					hash = hash * 59 + this.AlwaysRunning.GetHashCode();

				if (this.ContactSorts != null)
					hash = hash * 59 + this.ContactSorts.GetHashCode();

				if (this.MessagesPerMinute != null)
					hash = hash * 59 + this.MessagesPerMinute.GetHashCode();

				if (this.RuleSets != null)
					hash = hash * 59 + this.RuleSets.GetHashCode();

				if (this.ContactListFilters != null)
					hash = hash * 59 + this.ContactListFilters.GetHashCode();

				if (this.Errors != null)
					hash = hash * 59 + this.Errors.GetHashCode();

				if (this.DynamicContactQueueingSettings != null)
					hash = hash * 59 + this.DynamicContactQueueingSettings.GetHashCode();

				if (this.EmailConfig != null)
					hash = hash * 59 + this.EmailConfig.GetHashCode();

				if (this.SmsConfig != null)
					hash = hash * 59 + this.SmsConfig.GetHashCode();

				if (this.WhatsAppConfig != null)
					hash = hash * 59 + this.WhatsAppConfig.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
