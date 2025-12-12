using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// General rich media message structure with normalized feature support across many messaging channels.
	/// </summary>
	[DataContract]
	public partial class ConversationNormalizedMessage : IEquatable<ConversationNormalizedMessage>
	{
		/// <summary>
		/// Message type.
		/// </summary>
		/// <value>Message type.</value>
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
			/// Enum Text for "Text"
			/// </summary>
			[EnumMember(Value = "Text")]
			Text,

			/// <summary>
			/// Enum Structured for "Structured"
			/// </summary>
			[EnumMember(Value = "Structured")]
			Structured,

			/// <summary>
			/// Enum Receipt for "Receipt"
			/// </summary>
			[EnumMember(Value = "Receipt")]
			Receipt,

			/// <summary>
			/// Enum Event for "Event"
			/// </summary>
			[EnumMember(Value = "Event")]
			Event,

			/// <summary>
			/// Enum Message for "Message"
			/// </summary>
			[EnumMember(Value = "Message")]
			Message,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// Message receipt status, only used with type Receipt.
		/// </summary>
		/// <value>Message receipt status, only used with type Receipt.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Sent for "Sent"
			/// </summary>
			[EnumMember(Value = "Sent")]
			Sent,

			/// <summary>
			/// Enum Delivered for "Delivered"
			/// </summary>
			[EnumMember(Value = "Delivered")]
			Delivered,

			/// <summary>
			/// Enum Read for "Read"
			/// </summary>
			[EnumMember(Value = "Read")]
			Read,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed,

			/// <summary>
			/// Enum Published for "Published"
			/// </summary>
			[EnumMember(Value = "Published")]
			Published,

			/// <summary>
			/// Enum Removed for "Removed"
			/// </summary>
			[EnumMember(Value = "Removed")]
			Removed
		}
		/// <summary>
		/// Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies.
		/// </summary>
		/// <value>Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OriginatingEntityEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Human for "Human"
			/// </summary>
			[EnumMember(Value = "Human")]
			Human,

			/// <summary>
			/// Enum Bot for "Bot"
			/// </summary>
			[EnumMember(Value = "Bot")]
			Bot
		}
		/// <summary>
		/// The direction of the message.
		/// </summary>
		/// <value>The direction of the message.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DirectionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Inbound for "Inbound"
			/// </summary>
			[EnumMember(Value = "Inbound")]
			Inbound,

			/// <summary>
			/// Enum Outbound for "Outbound"
			/// </summary>
			[EnumMember(Value = "Outbound")]
			Outbound
		}
		/// <summary>
		/// Message type.
		/// </summary>
		/// <value>Message type.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Message receipt status, only used with type Receipt.
		/// </summary>
		/// <value>Message receipt status, only used with type Receipt.</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; private set; }
		/// <summary>
		/// Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies.
		/// </summary>
		/// <value>Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies.</value>
		[DataMember(Name = "originatingEntity", EmitDefaultValue = false)]
		public OriginatingEntityEnum? OriginatingEntity { get; set; }
		/// <summary>
		/// The direction of the message.
		/// </summary>
		/// <value>The direction of the message.</value>
		[DataMember(Name = "direction", EmitDefaultValue = false)]
		public DirectionEnum? Direction { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationNormalizedMessage" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationNormalizedMessage() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationNormalizedMessage" /> class.
		/// </summary>
		/// <param name="Type">Message type. (required).</param>
		/// <param name="Text">Message text..</param>
		/// <param name="Content">List of content elements..</param>
		/// <param name="Events">List of event elements..</param>
		/// <param name="OriginatingEntity">Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies..</param>
		/// <param name="RelatedMessages">A list of messages related to this one..</param>
		/// <param name="Metadata">Additional metadata about this message..</param>
		/// <param name="Enrichment">Metadata enrichments provided by the platform..</param>
		/// <param name="ByoSmsIntegrationId">The internal id representing the customer supplied sms integration message..</param>
		public ConversationNormalizedMessage(TypeEnum? Type = null, string Text = null, List<ConversationMessageContent> Content = null, List<ConversationMessageEvent> Events = null, OriginatingEntityEnum? OriginatingEntity = null, List<ConversationNormalizedMessage> RelatedMessages = null, Dictionary<string, string> Metadata = null, ConversationEnrichment Enrichment = null, string ByoSmsIntegrationId = null)
		{
			this.Type = Type;
			this.Text = Text;
			this.Content = Content;
			this.Events = Events;
			this.OriginatingEntity = OriginatingEntity;
			this.RelatedMessages = RelatedMessages;
			this.Metadata = Metadata;
			this.Enrichment = Enrichment;
			this.ByoSmsIntegrationId = ByoSmsIntegrationId;

		}



		/// <summary>
		/// Unique ID of the message. Message receipts will have the same ID as the message they reference.
		/// </summary>
		/// <value>Unique ID of the message. Message receipts will have the same ID as the message they reference.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Channel-specific information that describes the message and the message channel/provider.
		/// </summary>
		/// <value>Channel-specific information that describes the message and the message channel/provider.</value>
		[DataMember(Name = "channel", EmitDefaultValue = false)]
		public ConversationMessagingChannel Channel { get; private set; }





		/// <summary>
		/// Message text.
		/// </summary>
		/// <value>Message text.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }



		/// <summary>
		/// List of content elements.
		/// </summary>
		/// <value>List of content elements.</value>
		[DataMember(Name = "content", EmitDefaultValue = false)]
		public List<ConversationMessageContent> Content { get; set; }



		/// <summary>
		/// List of event elements.
		/// </summary>
		/// <value>List of event elements.</value>
		[DataMember(Name = "events", EmitDefaultValue = false)]
		public List<ConversationMessageEvent> Events { get; set; }





		/// <summary>
		/// List of reasons for a message receipt that indicates the message has failed. Only used with Failed status.
		/// </summary>
		/// <value>List of reasons for a message receipt that indicates the message has failed. Only used with Failed status.</value>
		[DataMember(Name = "reasons", EmitDefaultValue = false)]
		public List<ConversationReason> Reasons { get; private set; }





		/// <summary>
		/// Indicates if this is the last message receipt for this message, or if another message receipt can be expected.
		/// </summary>
		/// <value>Indicates if this is the last message receipt for this message, or if another message receipt can be expected.</value>
		[DataMember(Name = "isFinalReceipt", EmitDefaultValue = false)]
		public bool? IsFinalReceipt { get; private set; }





		/// <summary>
		/// A list of messages related to this one.
		/// </summary>
		/// <value>A list of messages related to this one.</value>
		[DataMember(Name = "relatedMessages", EmitDefaultValue = false)]
		public List<ConversationNormalizedMessage> RelatedMessages { get; set; }



		/// <summary>
		/// Additional metadata about this message.
		/// </summary>
		/// <value>Additional metadata about this message.</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public Dictionary<string, string> Metadata { get; set; }



		/// <summary>
		/// Metadata enrichments provided by the platform.
		/// </summary>
		/// <value>Metadata enrichments provided by the platform.</value>
		[DataMember(Name = "enrichment", EmitDefaultValue = false)]
		public ConversationEnrichment Enrichment { get; set; }



		/// <summary>
		/// The internal id representing the customer supplied sms integration message.
		/// </summary>
		/// <value>The internal id representing the customer supplied sms integration message.</value>
		[DataMember(Name = "byoSmsIntegrationId", EmitDefaultValue = false)]
		public string ByoSmsIntegrationId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationNormalizedMessage {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Channel: ").Append(Channel).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Content: ").Append(Content).Append("\n");
			sb.Append("  Events: ").Append(Events).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Reasons: ").Append(Reasons).Append("\n");
			sb.Append("  OriginatingEntity: ").Append(OriginatingEntity).Append("\n");
			sb.Append("  IsFinalReceipt: ").Append(IsFinalReceipt).Append("\n");
			sb.Append("  Direction: ").Append(Direction).Append("\n");
			sb.Append("  RelatedMessages: ").Append(RelatedMessages).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
			sb.Append("  Enrichment: ").Append(Enrichment).Append("\n");
			sb.Append("  ByoSmsIntegrationId: ").Append(ByoSmsIntegrationId).Append("\n");
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
			return this.Equals(obj as ConversationNormalizedMessage);
		}

		/// <summary>
		/// Returns true if ConversationNormalizedMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationNormalizedMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationNormalizedMessage other)
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
					this.Channel == other.Channel ||
					this.Channel != null &&
					this.Channel.Equals(other.Channel)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.Content == other.Content ||
					this.Content != null &&
					this.Content.SequenceEqual(other.Content)
				) &&
				(
					this.Events == other.Events ||
					this.Events != null &&
					this.Events.SequenceEqual(other.Events)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Reasons == other.Reasons ||
					this.Reasons != null &&
					this.Reasons.SequenceEqual(other.Reasons)
				) &&
				(
					this.OriginatingEntity == other.OriginatingEntity ||
					this.OriginatingEntity != null &&
					this.OriginatingEntity.Equals(other.OriginatingEntity)
				) &&
				(
					this.IsFinalReceipt == other.IsFinalReceipt ||
					this.IsFinalReceipt != null &&
					this.IsFinalReceipt.Equals(other.IsFinalReceipt)
				) &&
				(
					this.Direction == other.Direction ||
					this.Direction != null &&
					this.Direction.Equals(other.Direction)
				) &&
				(
					this.RelatedMessages == other.RelatedMessages ||
					this.RelatedMessages != null &&
					this.RelatedMessages.SequenceEqual(other.RelatedMessages)
				) &&
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.SequenceEqual(other.Metadata)
				) &&
				(
					this.Enrichment == other.Enrichment ||
					this.Enrichment != null &&
					this.Enrichment.Equals(other.Enrichment)
				) &&
				(
					this.ByoSmsIntegrationId == other.ByoSmsIntegrationId ||
					this.ByoSmsIntegrationId != null &&
					this.ByoSmsIntegrationId.Equals(other.ByoSmsIntegrationId)
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

				if (this.Channel != null)
					hash = hash * 59 + this.Channel.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.Content != null)
					hash = hash * 59 + this.Content.GetHashCode();

				if (this.Events != null)
					hash = hash * 59 + this.Events.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Reasons != null)
					hash = hash * 59 + this.Reasons.GetHashCode();

				if (this.OriginatingEntity != null)
					hash = hash * 59 + this.OriginatingEntity.GetHashCode();

				if (this.IsFinalReceipt != null)
					hash = hash * 59 + this.IsFinalReceipt.GetHashCode();

				if (this.Direction != null)
					hash = hash * 59 + this.Direction.GetHashCode();

				if (this.RelatedMessages != null)
					hash = hash * 59 + this.RelatedMessages.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.Enrichment != null)
					hash = hash * 59 + this.Enrichment.GetHashCode();

				if (this.ByoSmsIntegrationId != null)
					hash = hash * 59 + this.ByoSmsIntegrationId.GetHashCode();

				return hash;
			}
		}
	}

}
