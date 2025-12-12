using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationKnowledgeArticleSuggestionsTopicSuggestionContext
	/// </summary>
	[DataContract]
	public partial class ConversationKnowledgeArticleSuggestionsTopicSuggestionContext : IEquatable<ConversationKnowledgeArticleSuggestionsTopicSuggestionContext>
	{
		/// <summary>
		/// Gets or Sets MediaType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum MediaTypeEnum
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
			/// Enum Voice for "VOICE"
			/// </summary>
			[EnumMember(Value = "VOICE")]
			Voice,

			/// <summary>
			/// Enum Message for "MESSAGE"
			/// </summary>
			[EnumMember(Value = "MESSAGE")]
			Message,

			/// <summary>
			/// Enum Email for "EMAIL"
			/// </summary>
			[EnumMember(Value = "EMAIL")]
			Email
		}
		/// <summary>
		/// Gets or Sets MediaType
		/// </summary>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public MediaTypeEnum? MediaType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationKnowledgeArticleSuggestionsTopicSuggestionContext" /> class.
		/// </summary>
		/// <param name="QueueId">QueueId.</param>
		/// <param name="MediaType">MediaType.</param>
		/// <param name="UserId">UserId.</param>
		/// <param name="ExternalContactId">ExternalContactId.</param>
		/// <param name="AssistantId">AssistantId.</param>
		/// <param name="UtteranceId">UtteranceId.</param>
		/// <param name="MessageId">MessageId.</param>
		/// <param name="QueryStatement">QueryStatement.</param>
		/// <param name="Language">Language.</param>
		public ConversationKnowledgeArticleSuggestionsTopicSuggestionContext(Guid? QueueId = null, MediaTypeEnum? MediaType = null, Guid? UserId = null, Guid? ExternalContactId = null, Guid? AssistantId = null, Guid? UtteranceId = null, string MessageId = null, string QueryStatement = null, string Language = null)
		{
			this.QueueId = QueueId;
			this.MediaType = MediaType;
			this.UserId = UserId;
			this.ExternalContactId = ExternalContactId;
			this.AssistantId = AssistantId;
			this.UtteranceId = UtteranceId;
			this.MessageId = MessageId;
			this.QueryStatement = QueryStatement;
			this.Language = Language;

		}



		/// <summary>
		/// Gets or Sets QueueId
		/// </summary>
		[DataMember(Name = "queueId", EmitDefaultValue = false)]
		public Guid? QueueId { get; set; }





		/// <summary>
		/// Gets or Sets UserId
		/// </summary>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public Guid? UserId { get; set; }



		/// <summary>
		/// Gets or Sets ExternalContactId
		/// </summary>
		[DataMember(Name = "externalContactId", EmitDefaultValue = false)]
		public Guid? ExternalContactId { get; set; }



		/// <summary>
		/// Gets or Sets AssistantId
		/// </summary>
		[DataMember(Name = "assistantId", EmitDefaultValue = false)]
		public Guid? AssistantId { get; set; }



		/// <summary>
		/// Gets or Sets UtteranceId
		/// </summary>
		[DataMember(Name = "utteranceId", EmitDefaultValue = false)]
		public Guid? UtteranceId { get; set; }



		/// <summary>
		/// Gets or Sets MessageId
		/// </summary>
		[DataMember(Name = "messageId", EmitDefaultValue = false)]
		public string MessageId { get; set; }



		/// <summary>
		/// Gets or Sets QueryStatement
		/// </summary>
		[DataMember(Name = "queryStatement", EmitDefaultValue = false)]
		public string QueryStatement { get; set; }



		/// <summary>
		/// Gets or Sets Language
		/// </summary>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public string Language { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationKnowledgeArticleSuggestionsTopicSuggestionContext {\n");

			sb.Append("  QueueId: ").Append(QueueId).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
			sb.Append("  AssistantId: ").Append(AssistantId).Append("\n");
			sb.Append("  UtteranceId: ").Append(UtteranceId).Append("\n");
			sb.Append("  MessageId: ").Append(MessageId).Append("\n");
			sb.Append("  QueryStatement: ").Append(QueryStatement).Append("\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
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
			return this.Equals(obj as ConversationKnowledgeArticleSuggestionsTopicSuggestionContext);
		}

		/// <summary>
		/// Returns true if ConversationKnowledgeArticleSuggestionsTopicSuggestionContext instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationKnowledgeArticleSuggestionsTopicSuggestionContext to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationKnowledgeArticleSuggestionsTopicSuggestionContext other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.QueueId == other.QueueId ||
					this.QueueId != null &&
					this.QueueId.Equals(other.QueueId)
				) &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
				) &&
				(
					this.ExternalContactId == other.ExternalContactId ||
					this.ExternalContactId != null &&
					this.ExternalContactId.Equals(other.ExternalContactId)
				) &&
				(
					this.AssistantId == other.AssistantId ||
					this.AssistantId != null &&
					this.AssistantId.Equals(other.AssistantId)
				) &&
				(
					this.UtteranceId == other.UtteranceId ||
					this.UtteranceId != null &&
					this.UtteranceId.Equals(other.UtteranceId)
				) &&
				(
					this.MessageId == other.MessageId ||
					this.MessageId != null &&
					this.MessageId.Equals(other.MessageId)
				) &&
				(
					this.QueryStatement == other.QueryStatement ||
					this.QueryStatement != null &&
					this.QueryStatement.Equals(other.QueryStatement)
				) &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
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
				if (this.QueueId != null)
					hash = hash * 59 + this.QueueId.GetHashCode();

				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				if (this.ExternalContactId != null)
					hash = hash * 59 + this.ExternalContactId.GetHashCode();

				if (this.AssistantId != null)
					hash = hash * 59 + this.AssistantId.GetHashCode();

				if (this.UtteranceId != null)
					hash = hash * 59 + this.UtteranceId.GetHashCode();

				if (this.MessageId != null)
					hash = hash * 59 + this.MessageId.GetHashCode();

				if (this.QueryStatement != null)
					hash = hash * 59 + this.QueryStatement.GetHashCode();

				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				return hash;
			}
		}
	}

}
