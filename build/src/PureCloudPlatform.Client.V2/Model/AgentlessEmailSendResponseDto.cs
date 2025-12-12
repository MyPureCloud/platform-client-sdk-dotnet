using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentlessEmailSendResponseDto
	/// </summary>
	[DataContract]
	public partial class AgentlessEmailSendResponseDto : IEquatable<AgentlessEmailSendResponseDto>
	{
		/// <summary>
		/// The identifier of the external participant of the given conversation.
		/// </summary>
		/// <value>The identifier of the external participant of the given conversation.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SenderTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Outbound for "Outbound"
			/// </summary>
			[EnumMember(Value = "Outbound")]
			Outbound,

			/// <summary>
			/// Enum Inbound for "Inbound"
			/// </summary>
			[EnumMember(Value = "Inbound")]
			Inbound,

			/// <summary>
			/// Enum Integration for "Integration"
			/// </summary>
			[EnumMember(Value = "Integration")]
			Integration
		}
		/// <summary>
		/// The identifier of the external participant of the given conversation.
		/// </summary>
		/// <value>The identifier of the external participant of the given conversation.</value>
		[DataMember(Name = "senderType", EmitDefaultValue = false)]
		public SenderTypeEnum? SenderType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="AgentlessEmailSendResponseDto" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AgentlessEmailSendResponseDto() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentlessEmailSendResponseDto" /> class.
		/// </summary>
		/// <param name="ConversationId">The identifier of the conversation. (required).</param>
		/// <param name="SenderType">The identifier of the external participant of the given conversation. (required).</param>
		/// <param name="FromAddress">The sender of the message. (required).</param>
		/// <param name="ToAddresses">The recipient of the message. We currently support one recipient only. (required).</param>
		/// <param name="ReplyToAddress">The address to use for reply..</param>
		/// <param name="Subject">The subject of the message..</param>
		/// <param name="DateCreated">The message creation timestamp. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		public AgentlessEmailSendResponseDto(string ConversationId = null, SenderTypeEnum? SenderType = null, EmailAddress FromAddress = null, List<EmailAddress> ToAddresses = null, EmailAddress ReplyToAddress = null, string Subject = null, DateTime? DateCreated = null)
		{
			this.ConversationId = ConversationId;
			this.SenderType = SenderType;
			this.FromAddress = FromAddress;
			this.ToAddresses = ToAddresses;
			this.ReplyToAddress = ReplyToAddress;
			this.Subject = Subject;
			this.DateCreated = DateCreated;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The identifier of the conversation.
		/// </summary>
		/// <value>The identifier of the conversation.</value>
		[DataMember(Name = "conversationId", EmitDefaultValue = false)]
		public string ConversationId { get; set; }





		/// <summary>
		/// The sender of the message.
		/// </summary>
		/// <value>The sender of the message.</value>
		[DataMember(Name = "fromAddress", EmitDefaultValue = false)]
		public EmailAddress FromAddress { get; set; }



		/// <summary>
		/// The recipient of the message. We currently support one recipient only.
		/// </summary>
		/// <value>The recipient of the message. We currently support one recipient only.</value>
		[DataMember(Name = "toAddresses", EmitDefaultValue = false)]
		public List<EmailAddress> ToAddresses { get; set; }



		/// <summary>
		/// The address to use for reply.
		/// </summary>
		/// <value>The address to use for reply.</value>
		[DataMember(Name = "replyToAddress", EmitDefaultValue = false)]
		public EmailAddress ReplyToAddress { get; set; }



		/// <summary>
		/// The subject of the message.
		/// </summary>
		/// <value>The subject of the message.</value>
		[DataMember(Name = "subject", EmitDefaultValue = false)]
		public string Subject { get; set; }



		/// <summary>
		/// The message creation timestamp. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The message creation timestamp. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



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
			sb.Append("class AgentlessEmailSendResponseDto {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  SenderType: ").Append(SenderType).Append("\n");
			sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
			sb.Append("  ToAddresses: ").Append(ToAddresses).Append("\n");
			sb.Append("  ReplyToAddress: ").Append(ReplyToAddress).Append("\n");
			sb.Append("  Subject: ").Append(Subject).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
			return this.Equals(obj as AgentlessEmailSendResponseDto);
		}

		/// <summary>
		/// Returns true if AgentlessEmailSendResponseDto instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentlessEmailSendResponseDto to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentlessEmailSendResponseDto other)
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
					this.ConversationId == other.ConversationId ||
					this.ConversationId != null &&
					this.ConversationId.Equals(other.ConversationId)
				) &&
				(
					this.SenderType == other.SenderType ||
					this.SenderType != null &&
					this.SenderType.Equals(other.SenderType)
				) &&
				(
					this.FromAddress == other.FromAddress ||
					this.FromAddress != null &&
					this.FromAddress.Equals(other.FromAddress)
				) &&
				(
					this.ToAddresses == other.ToAddresses ||
					this.ToAddresses != null &&
					this.ToAddresses.SequenceEqual(other.ToAddresses)
				) &&
				(
					this.ReplyToAddress == other.ReplyToAddress ||
					this.ReplyToAddress != null &&
					this.ReplyToAddress.Equals(other.ReplyToAddress)
				) &&
				(
					this.Subject == other.Subject ||
					this.Subject != null &&
					this.Subject.Equals(other.Subject)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
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

				if (this.ConversationId != null)
					hash = hash * 59 + this.ConversationId.GetHashCode();

				if (this.SenderType != null)
					hash = hash * 59 + this.SenderType.GetHashCode();

				if (this.FromAddress != null)
					hash = hash * 59 + this.FromAddress.GetHashCode();

				if (this.ToAddresses != null)
					hash = hash * 59 + this.ToAddresses.GetHashCode();

				if (this.ReplyToAddress != null)
					hash = hash * 59 + this.ReplyToAddress.GetHashCode();

				if (this.Subject != null)
					hash = hash * 59 + this.Subject.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
