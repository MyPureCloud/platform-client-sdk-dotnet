using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// InternalMessageData
	/// </summary>
	[DataContract]
	public partial class InternalMessageData : IEquatable<InternalMessageData>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="InternalMessageData" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected InternalMessageData() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="InternalMessageData" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Conversation">The conversation of this message..</param>
		/// <param name="CommunicationId">The id of the communication of this message..</param>
		/// <param name="Timestamp">The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="Sender">The sender of the text message..</param>
		/// <param name="Recipient">The recipient of the text message..</param>
		public InternalMessageData(string Name = null, AddressableEntityRef Conversation = null, string CommunicationId = null, DateTime? Timestamp = null, UserReference Sender = null, UserReference Recipient = null)
		{
			this.Name = Name;
			this.Conversation = Conversation;
			this.CommunicationId = CommunicationId;
			this.Timestamp = Timestamp;
			this.Sender = Sender;
			this.Recipient = Recipient;

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
		/// The conversation of this message.
		/// </summary>
		/// <value>The conversation of this message.</value>
		[DataMember(Name = "conversation", EmitDefaultValue = false)]
		public AddressableEntityRef Conversation { get; set; }



		/// <summary>
		/// The id of the communication of this message.
		/// </summary>
		/// <value>The id of the communication of this message.</value>
		[DataMember(Name = "communicationId", EmitDefaultValue = false)]
		public string CommunicationId { get; set; }



		/// <summary>
		/// The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "timestamp", EmitDefaultValue = false)]
		public DateTime? Timestamp { get; set; }



		/// <summary>
		/// The sender of the text message.
		/// </summary>
		/// <value>The sender of the text message.</value>
		[DataMember(Name = "sender", EmitDefaultValue = false)]
		public UserReference Sender { get; set; }



		/// <summary>
		/// The recipient of the text message.
		/// </summary>
		/// <value>The recipient of the text message.</value>
		[DataMember(Name = "recipient", EmitDefaultValue = false)]
		public UserReference Recipient { get; set; }



		/// <summary>
		/// The message into normalized format
		/// </summary>
		/// <value>The message into normalized format</value>
		[DataMember(Name = "normalizedMessage", EmitDefaultValue = false)]
		public ConversationNormalizedMessage NormalizedMessage { get; private set; }



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
			sb.Append("class InternalMessageData {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Conversation: ").Append(Conversation).Append("\n");
			sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
			sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
			sb.Append("  Sender: ").Append(Sender).Append("\n");
			sb.Append("  Recipient: ").Append(Recipient).Append("\n");
			sb.Append("  NormalizedMessage: ").Append(NormalizedMessage).Append("\n");
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
			return this.Equals(obj as InternalMessageData);
		}

		/// <summary>
		/// Returns true if InternalMessageData instances are equal
		/// </summary>
		/// <param name="other">Instance of InternalMessageData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InternalMessageData other)
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
					this.Conversation == other.Conversation ||
					this.Conversation != null &&
					this.Conversation.Equals(other.Conversation)
				) &&
				(
					this.CommunicationId == other.CommunicationId ||
					this.CommunicationId != null &&
					this.CommunicationId.Equals(other.CommunicationId)
				) &&
				(
					this.Timestamp == other.Timestamp ||
					this.Timestamp != null &&
					this.Timestamp.Equals(other.Timestamp)
				) &&
				(
					this.Sender == other.Sender ||
					this.Sender != null &&
					this.Sender.Equals(other.Sender)
				) &&
				(
					this.Recipient == other.Recipient ||
					this.Recipient != null &&
					this.Recipient.Equals(other.Recipient)
				) &&
				(
					this.NormalizedMessage == other.NormalizedMessage ||
					this.NormalizedMessage != null &&
					this.NormalizedMessage.Equals(other.NormalizedMessage)
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

				if (this.Conversation != null)
					hash = hash * 59 + this.Conversation.GetHashCode();

				if (this.CommunicationId != null)
					hash = hash * 59 + this.CommunicationId.GetHashCode();

				if (this.Timestamp != null)
					hash = hash * 59 + this.Timestamp.GetHashCode();

				if (this.Sender != null)
					hash = hash * 59 + this.Sender.GetHashCode();

				if (this.Recipient != null)
					hash = hash * 59 + this.Recipient.GetHashCode();

				if (this.NormalizedMessage != null)
					hash = hash * 59 + this.NormalizedMessage.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
