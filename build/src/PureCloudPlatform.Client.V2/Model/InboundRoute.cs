using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// InboundRoute
	/// </summary>
	[DataContract]
	public partial class InboundRoute : IEquatable<InboundRoute>
	{
		/// <summary>
		/// The configuration to indicate how the history of a conversation has to be included in a draft
		/// </summary>
		/// <value>The configuration to indicate how the history of a conversation has to be included in a draft</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum HistoryInclusionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Include for "Include"
			/// </summary>
			[EnumMember(Value = "Include")]
			Include,

			/// <summary>
			/// Enum Exclude for "Exclude"
			/// </summary>
			[EnumMember(Value = "Exclude")]
			Exclude,

			/// <summary>
			/// Enum Optional for "Optional"
			/// </summary>
			[EnumMember(Value = "Optional")]
			Optional
		}
		/// <summary>
		/// The configuration to indicate how the history of a conversation has to be included in a draft
		/// </summary>
		/// <value>The configuration to indicate how the history of a conversation has to be included in a draft</value>
		[DataMember(Name = "historyInclusion", EmitDefaultValue = false)]
		public HistoryInclusionEnum? HistoryInclusion { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="InboundRoute" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected InboundRoute() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="InboundRoute" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Pattern">The search pattern that the mailbox name should match. (required).</param>
		/// <param name="Queue">The queue to route the emails to..</param>
		/// <param name="Priority">The priority to use for routing..</param>
		/// <param name="Skills">The skills to use for routing..</param>
		/// <param name="Language">The language to use for routing..</param>
		/// <param name="FromName">The sender name to use for outgoing replies. (required).</param>
		/// <param name="FromEmail">The sender email to use for outgoing replies..</param>
		/// <param name="Flow">The flow to use for processing the email..</param>
		/// <param name="ReplyEmailAddress">The route to use for email replies..</param>
		/// <param name="AutoBcc">The recipients that should be automatically blind copied on outbound emails associated with this InboundRoute..</param>
		/// <param name="SpamFlow">The flow to use for processing inbound emails that have been marked as spam..</param>
		/// <param name="Signature">The configuration for the canned response signature that will be appended to outbound emails sent via this route.</param>
		/// <param name="HistoryInclusion">The configuration to indicate how the history of a conversation has to be included in a draft.</param>
		/// <param name="AllowMultipleActions">Control if multiple actions are allowed on this route. When true the disconnect has to be done manually. When false a conversation will be disconnected by the system after every action.</param>
		public InboundRoute(string Name = null, string Pattern = null, DomainEntityRef Queue = null, int? Priority = null, List<DomainEntityRef> Skills = null, DomainEntityRef Language = null, string FromName = null, string FromEmail = null, DomainEntityRef Flow = null, QueueEmailAddress ReplyEmailAddress = null, List<EmailAddress> AutoBcc = null, DomainEntityRef SpamFlow = null, Signature Signature = null, HistoryInclusionEnum? HistoryInclusion = null, bool? AllowMultipleActions = null)
		{
			this.Name = Name;
			this.Pattern = Pattern;
			this.Queue = Queue;
			this.Priority = Priority;
			this.Skills = Skills;
			this.Language = Language;
			this.FromName = FromName;
			this.FromEmail = FromEmail;
			this.Flow = Flow;
			this.ReplyEmailAddress = ReplyEmailAddress;
			this.AutoBcc = AutoBcc;
			this.SpamFlow = SpamFlow;
			this.Signature = Signature;
			this.HistoryInclusion = HistoryInclusion;
			this.AllowMultipleActions = AllowMultipleActions;

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
		/// The search pattern that the mailbox name should match.
		/// </summary>
		/// <value>The search pattern that the mailbox name should match.</value>
		[DataMember(Name = "pattern", EmitDefaultValue = false)]
		public string Pattern { get; set; }



		/// <summary>
		/// The queue to route the emails to.
		/// </summary>
		/// <value>The queue to route the emails to.</value>
		[DataMember(Name = "queue", EmitDefaultValue = false)]
		public DomainEntityRef Queue { get; set; }



		/// <summary>
		/// The priority to use for routing.
		/// </summary>
		/// <value>The priority to use for routing.</value>
		[DataMember(Name = "priority", EmitDefaultValue = false)]
		public int? Priority { get; set; }



		/// <summary>
		/// The skills to use for routing.
		/// </summary>
		/// <value>The skills to use for routing.</value>
		[DataMember(Name = "skills", EmitDefaultValue = false)]
		public List<DomainEntityRef> Skills { get; set; }



		/// <summary>
		/// The language to use for routing.
		/// </summary>
		/// <value>The language to use for routing.</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public DomainEntityRef Language { get; set; }



		/// <summary>
		/// The sender name to use for outgoing replies.
		/// </summary>
		/// <value>The sender name to use for outgoing replies.</value>
		[DataMember(Name = "fromName", EmitDefaultValue = false)]
		public string FromName { get; set; }



		/// <summary>
		/// The sender email to use for outgoing replies.
		/// </summary>
		/// <value>The sender email to use for outgoing replies.</value>
		[DataMember(Name = "fromEmail", EmitDefaultValue = false)]
		public string FromEmail { get; set; }



		/// <summary>
		/// The flow to use for processing the email.
		/// </summary>
		/// <value>The flow to use for processing the email.</value>
		[DataMember(Name = "flow", EmitDefaultValue = false)]
		public DomainEntityRef Flow { get; set; }



		/// <summary>
		/// The route to use for email replies.
		/// </summary>
		/// <value>The route to use for email replies.</value>
		[DataMember(Name = "replyEmailAddress", EmitDefaultValue = false)]
		public QueueEmailAddress ReplyEmailAddress { get; set; }



		/// <summary>
		/// The recipients that should be automatically blind copied on outbound emails associated with this InboundRoute.
		/// </summary>
		/// <value>The recipients that should be automatically blind copied on outbound emails associated with this InboundRoute.</value>
		[DataMember(Name = "autoBcc", EmitDefaultValue = false)]
		public List<EmailAddress> AutoBcc { get; set; }



		/// <summary>
		/// The flow to use for processing inbound emails that have been marked as spam.
		/// </summary>
		/// <value>The flow to use for processing inbound emails that have been marked as spam.</value>
		[DataMember(Name = "spamFlow", EmitDefaultValue = false)]
		public DomainEntityRef SpamFlow { get; set; }



		/// <summary>
		/// The configuration for the canned response signature that will be appended to outbound emails sent via this route
		/// </summary>
		/// <value>The configuration for the canned response signature that will be appended to outbound emails sent via this route</value>
		[DataMember(Name = "signature", EmitDefaultValue = false)]
		public Signature Signature { get; set; }





		/// <summary>
		/// Control if multiple actions are allowed on this route. When true the disconnect has to be done manually. When false a conversation will be disconnected by the system after every action
		/// </summary>
		/// <value>Control if multiple actions are allowed on this route. When true the disconnect has to be done manually. When false a conversation will be disconnected by the system after every action</value>
		[DataMember(Name = "allowMultipleActions", EmitDefaultValue = false)]
		public bool? AllowMultipleActions { get; set; }



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
			sb.Append("class InboundRoute {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Pattern: ").Append(Pattern).Append("\n");
			sb.Append("  Queue: ").Append(Queue).Append("\n");
			sb.Append("  Priority: ").Append(Priority).Append("\n");
			sb.Append("  Skills: ").Append(Skills).Append("\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  FromName: ").Append(FromName).Append("\n");
			sb.Append("  FromEmail: ").Append(FromEmail).Append("\n");
			sb.Append("  Flow: ").Append(Flow).Append("\n");
			sb.Append("  ReplyEmailAddress: ").Append(ReplyEmailAddress).Append("\n");
			sb.Append("  AutoBcc: ").Append(AutoBcc).Append("\n");
			sb.Append("  SpamFlow: ").Append(SpamFlow).Append("\n");
			sb.Append("  Signature: ").Append(Signature).Append("\n");
			sb.Append("  HistoryInclusion: ").Append(HistoryInclusion).Append("\n");
			sb.Append("  AllowMultipleActions: ").Append(AllowMultipleActions).Append("\n");
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
			return this.Equals(obj as InboundRoute);
		}

		/// <summary>
		/// Returns true if InboundRoute instances are equal
		/// </summary>
		/// <param name="other">Instance of InboundRoute to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InboundRoute other)
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
					this.Pattern == other.Pattern ||
					this.Pattern != null &&
					this.Pattern.Equals(other.Pattern)
				) &&
				(
					this.Queue == other.Queue ||
					this.Queue != null &&
					this.Queue.Equals(other.Queue)
				) &&
				(
					this.Priority == other.Priority ||
					this.Priority != null &&
					this.Priority.Equals(other.Priority)
				) &&
				(
					this.Skills == other.Skills ||
					this.Skills != null &&
					this.Skills.SequenceEqual(other.Skills)
				) &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
				) &&
				(
					this.FromName == other.FromName ||
					this.FromName != null &&
					this.FromName.Equals(other.FromName)
				) &&
				(
					this.FromEmail == other.FromEmail ||
					this.FromEmail != null &&
					this.FromEmail.Equals(other.FromEmail)
				) &&
				(
					this.Flow == other.Flow ||
					this.Flow != null &&
					this.Flow.Equals(other.Flow)
				) &&
				(
					this.ReplyEmailAddress == other.ReplyEmailAddress ||
					this.ReplyEmailAddress != null &&
					this.ReplyEmailAddress.Equals(other.ReplyEmailAddress)
				) &&
				(
					this.AutoBcc == other.AutoBcc ||
					this.AutoBcc != null &&
					this.AutoBcc.SequenceEqual(other.AutoBcc)
				) &&
				(
					this.SpamFlow == other.SpamFlow ||
					this.SpamFlow != null &&
					this.SpamFlow.Equals(other.SpamFlow)
				) &&
				(
					this.Signature == other.Signature ||
					this.Signature != null &&
					this.Signature.Equals(other.Signature)
				) &&
				(
					this.HistoryInclusion == other.HistoryInclusion ||
					this.HistoryInclusion != null &&
					this.HistoryInclusion.Equals(other.HistoryInclusion)
				) &&
				(
					this.AllowMultipleActions == other.AllowMultipleActions ||
					this.AllowMultipleActions != null &&
					this.AllowMultipleActions.Equals(other.AllowMultipleActions)
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

				if (this.Pattern != null)
					hash = hash * 59 + this.Pattern.GetHashCode();

				if (this.Queue != null)
					hash = hash * 59 + this.Queue.GetHashCode();

				if (this.Priority != null)
					hash = hash * 59 + this.Priority.GetHashCode();

				if (this.Skills != null)
					hash = hash * 59 + this.Skills.GetHashCode();

				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				if (this.FromName != null)
					hash = hash * 59 + this.FromName.GetHashCode();

				if (this.FromEmail != null)
					hash = hash * 59 + this.FromEmail.GetHashCode();

				if (this.Flow != null)
					hash = hash * 59 + this.Flow.GetHashCode();

				if (this.ReplyEmailAddress != null)
					hash = hash * 59 + this.ReplyEmailAddress.GetHashCode();

				if (this.AutoBcc != null)
					hash = hash * 59 + this.AutoBcc.GetHashCode();

				if (this.SpamFlow != null)
					hash = hash * 59 + this.SpamFlow.GetHashCode();

				if (this.Signature != null)
					hash = hash * 59 + this.Signature.GetHashCode();

				if (this.HistoryInclusion != null)
					hash = hash * 59 + this.HistoryInclusion.GetHashCode();

				if (this.AllowMultipleActions != null)
					hash = hash * 59 + this.AllowMultipleActions.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
