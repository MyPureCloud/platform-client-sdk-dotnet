using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationChecklistTopicAgentChecklistRuntimeEventBody
	/// </summary>
	[DataContract]
	public partial class ConversationChecklistTopicAgentChecklistRuntimeEventBody : IEquatable<ConversationChecklistTopicAgentChecklistRuntimeEventBody>
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
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Voice for "Voice"
			/// </summary>
			[EnumMember(Value = "Voice")]
			Voice,

			/// <summary>
			/// Enum Message for "Message"
			/// </summary>
			[EnumMember(Value = "Message")]
			Message,

			/// <summary>
			/// Enum Email for "Email"
			/// </summary>
			[EnumMember(Value = "Email")]
			Email
		}
		/// <summary>
		/// Gets or Sets Direction
		/// </summary>
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
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

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
		/// Gets or Sets Status
		/// </summary>
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
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Evaluationstarted for "EvaluationStarted"
			/// </summary>
			[EnumMember(Value = "EvaluationStarted")]
			Evaluationstarted,

			/// <summary>
			/// Enum Evaluationinprogress for "EvaluationInProgress"
			/// </summary>
			[EnumMember(Value = "EvaluationInProgress")]
			Evaluationinprogress,

			/// <summary>
			/// Enum Evaluationfinalized for "EvaluationFinalized"
			/// </summary>
			[EnumMember(Value = "EvaluationFinalized")]
			Evaluationfinalized,

			/// <summary>
			/// Enum Evaluationfinalizedwithacw for "EvaluationFinalizedWithAcw"
			/// </summary>
			[EnumMember(Value = "EvaluationFinalizedWithAcw")]
			Evaluationfinalizedwithacw
		}
		/// <summary>
		/// Gets or Sets MediaType
		/// </summary>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public MediaTypeEnum? MediaType { get; set; }
		/// <summary>
		/// Gets or Sets Direction
		/// </summary>
		[DataMember(Name = "direction", EmitDefaultValue = false)]
		public DirectionEnum? Direction { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationChecklistTopicAgentChecklistRuntimeEventBody" /> class.
		/// </summary>
		/// <param name="EvaluationStartDate">EvaluationStartDate.</param>
		/// <param name="EvaluationLastModifiedDate">EvaluationLastModifiedDate.</param>
		/// <param name="EvaluationFinalizedDate">EvaluationFinalizedDate.</param>
		/// <param name="EvaluationFinalizedWithAcwDate">EvaluationFinalizedWithAcwDate.</param>
		/// <param name="ConversationId">ConversationId.</param>
		/// <param name="CommunicationId">CommunicationId.</param>
		/// <param name="AgentChecklistId">AgentChecklistId.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Language">Language.</param>
		/// <param name="AgentId">AgentId.</param>
		/// <param name="ParticipantId">ParticipantId.</param>
		/// <param name="QueueId">QueueId.</param>
		/// <param name="AssistantId">AssistantId.</param>
		/// <param name="MediaType">MediaType.</param>
		/// <param name="Direction">Direction.</param>
		/// <param name="Status">Status.</param>
		/// <param name="ExitReason">ExitReason.</param>
		/// <param name="ActivationTriggers">ActivationTriggers.</param>
		/// <param name="ConversationContext">ConversationContext.</param>
		/// <param name="AgentChecklistItems">AgentChecklistItems.</param>
		public ConversationChecklistTopicAgentChecklistRuntimeEventBody(DateTime? EvaluationStartDate = null, DateTime? EvaluationLastModifiedDate = null, DateTime? EvaluationFinalizedDate = null, DateTime? EvaluationFinalizedWithAcwDate = null, Guid? ConversationId = null, Guid? CommunicationId = null, Guid? AgentChecklistId = null, string Name = null, string Language = null, string AgentId = null, string ParticipantId = null, Guid? QueueId = null, Guid? AssistantId = null, MediaTypeEnum? MediaType = null, DirectionEnum? Direction = null, StatusEnum? Status = null, string ExitReason = null, List<ConversationChecklistTopicAgentChecklistActivationTrigger> ActivationTriggers = null, List<ConversationChecklistTopicConversationContextTurnInfo> ConversationContext = null, List<ConversationChecklistTopicAgentChecklistItemState> AgentChecklistItems = null)
		{
			this.EvaluationStartDate = EvaluationStartDate;
			this.EvaluationLastModifiedDate = EvaluationLastModifiedDate;
			this.EvaluationFinalizedDate = EvaluationFinalizedDate;
			this.EvaluationFinalizedWithAcwDate = EvaluationFinalizedWithAcwDate;
			this.ConversationId = ConversationId;
			this.CommunicationId = CommunicationId;
			this.AgentChecklistId = AgentChecklistId;
			this.Name = Name;
			this.Language = Language;
			this.AgentId = AgentId;
			this.ParticipantId = ParticipantId;
			this.QueueId = QueueId;
			this.AssistantId = AssistantId;
			this.MediaType = MediaType;
			this.Direction = Direction;
			this.Status = Status;
			this.ExitReason = ExitReason;
			this.ActivationTriggers = ActivationTriggers;
			this.ConversationContext = ConversationContext;
			this.AgentChecklistItems = AgentChecklistItems;

		}



		/// <summary>
		/// Gets or Sets EvaluationStartDate
		/// </summary>
		[DataMember(Name = "evaluationStartDate", EmitDefaultValue = false)]
		public DateTime? EvaluationStartDate { get; set; }



		/// <summary>
		/// Gets or Sets EvaluationLastModifiedDate
		/// </summary>
		[DataMember(Name = "evaluationLastModifiedDate", EmitDefaultValue = false)]
		public DateTime? EvaluationLastModifiedDate { get; set; }



		/// <summary>
		/// Gets or Sets EvaluationFinalizedDate
		/// </summary>
		[DataMember(Name = "evaluationFinalizedDate", EmitDefaultValue = false)]
		public DateTime? EvaluationFinalizedDate { get; set; }



		/// <summary>
		/// Gets or Sets EvaluationFinalizedWithAcwDate
		/// </summary>
		[DataMember(Name = "evaluationFinalizedWithAcwDate", EmitDefaultValue = false)]
		public DateTime? EvaluationFinalizedWithAcwDate { get; set; }



		/// <summary>
		/// Gets or Sets ConversationId
		/// </summary>
		[DataMember(Name = "conversationId", EmitDefaultValue = false)]
		public Guid? ConversationId { get; set; }



		/// <summary>
		/// Gets or Sets CommunicationId
		/// </summary>
		[DataMember(Name = "communicationId", EmitDefaultValue = false)]
		public Guid? CommunicationId { get; set; }



		/// <summary>
		/// Gets or Sets AgentChecklistId
		/// </summary>
		[DataMember(Name = "agentChecklistId", EmitDefaultValue = false)]
		public Guid? AgentChecklistId { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets Language
		/// </summary>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public string Language { get; set; }



		/// <summary>
		/// Gets or Sets AgentId
		/// </summary>
		[DataMember(Name = "agentId", EmitDefaultValue = false)]
		public string AgentId { get; set; }



		/// <summary>
		/// Gets or Sets ParticipantId
		/// </summary>
		[DataMember(Name = "participantId", EmitDefaultValue = false)]
		public string ParticipantId { get; set; }



		/// <summary>
		/// Gets or Sets QueueId
		/// </summary>
		[DataMember(Name = "queueId", EmitDefaultValue = false)]
		public Guid? QueueId { get; set; }



		/// <summary>
		/// Gets or Sets AssistantId
		/// </summary>
		[DataMember(Name = "assistantId", EmitDefaultValue = false)]
		public Guid? AssistantId { get; set; }









		/// <summary>
		/// Gets or Sets ExitReason
		/// </summary>
		[DataMember(Name = "exitReason", EmitDefaultValue = false)]
		public string ExitReason { get; set; }



		/// <summary>
		/// Gets or Sets ActivationTriggers
		/// </summary>
		[DataMember(Name = "activationTriggers", EmitDefaultValue = false)]
		public List<ConversationChecklistTopicAgentChecklistActivationTrigger> ActivationTriggers { get; set; }



		/// <summary>
		/// Gets or Sets ConversationContext
		/// </summary>
		[DataMember(Name = "conversationContext", EmitDefaultValue = false)]
		public List<ConversationChecklistTopicConversationContextTurnInfo> ConversationContext { get; set; }



		/// <summary>
		/// Gets or Sets AgentChecklistItems
		/// </summary>
		[DataMember(Name = "agentChecklistItems", EmitDefaultValue = false)]
		public List<ConversationChecklistTopicAgentChecklistItemState> AgentChecklistItems { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationChecklistTopicAgentChecklistRuntimeEventBody {\n");

			sb.Append("  EvaluationStartDate: ").Append(EvaluationStartDate).Append("\n");
			sb.Append("  EvaluationLastModifiedDate: ").Append(EvaluationLastModifiedDate).Append("\n");
			sb.Append("  EvaluationFinalizedDate: ").Append(EvaluationFinalizedDate).Append("\n");
			sb.Append("  EvaluationFinalizedWithAcwDate: ").Append(EvaluationFinalizedWithAcwDate).Append("\n");
			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
			sb.Append("  AgentChecklistId: ").Append(AgentChecklistId).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  AgentId: ").Append(AgentId).Append("\n");
			sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
			sb.Append("  QueueId: ").Append(QueueId).Append("\n");
			sb.Append("  AssistantId: ").Append(AssistantId).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  Direction: ").Append(Direction).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  ExitReason: ").Append(ExitReason).Append("\n");
			sb.Append("  ActivationTriggers: ").Append(ActivationTriggers).Append("\n");
			sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
			sb.Append("  AgentChecklistItems: ").Append(AgentChecklistItems).Append("\n");
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
			return this.Equals(obj as ConversationChecklistTopicAgentChecklistRuntimeEventBody);
		}

		/// <summary>
		/// Returns true if ConversationChecklistTopicAgentChecklistRuntimeEventBody instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationChecklistTopicAgentChecklistRuntimeEventBody to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationChecklistTopicAgentChecklistRuntimeEventBody other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EvaluationStartDate == other.EvaluationStartDate ||
					this.EvaluationStartDate != null &&
					this.EvaluationStartDate.Equals(other.EvaluationStartDate)
				) &&
				(
					this.EvaluationLastModifiedDate == other.EvaluationLastModifiedDate ||
					this.EvaluationLastModifiedDate != null &&
					this.EvaluationLastModifiedDate.Equals(other.EvaluationLastModifiedDate)
				) &&
				(
					this.EvaluationFinalizedDate == other.EvaluationFinalizedDate ||
					this.EvaluationFinalizedDate != null &&
					this.EvaluationFinalizedDate.Equals(other.EvaluationFinalizedDate)
				) &&
				(
					this.EvaluationFinalizedWithAcwDate == other.EvaluationFinalizedWithAcwDate ||
					this.EvaluationFinalizedWithAcwDate != null &&
					this.EvaluationFinalizedWithAcwDate.Equals(other.EvaluationFinalizedWithAcwDate)
				) &&
				(
					this.ConversationId == other.ConversationId ||
					this.ConversationId != null &&
					this.ConversationId.Equals(other.ConversationId)
				) &&
				(
					this.CommunicationId == other.CommunicationId ||
					this.CommunicationId != null &&
					this.CommunicationId.Equals(other.CommunicationId)
				) &&
				(
					this.AgentChecklistId == other.AgentChecklistId ||
					this.AgentChecklistId != null &&
					this.AgentChecklistId.Equals(other.AgentChecklistId)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
				) &&
				(
					this.AgentId == other.AgentId ||
					this.AgentId != null &&
					this.AgentId.Equals(other.AgentId)
				) &&
				(
					this.ParticipantId == other.ParticipantId ||
					this.ParticipantId != null &&
					this.ParticipantId.Equals(other.ParticipantId)
				) &&
				(
					this.QueueId == other.QueueId ||
					this.QueueId != null &&
					this.QueueId.Equals(other.QueueId)
				) &&
				(
					this.AssistantId == other.AssistantId ||
					this.AssistantId != null &&
					this.AssistantId.Equals(other.AssistantId)
				) &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.Direction == other.Direction ||
					this.Direction != null &&
					this.Direction.Equals(other.Direction)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.ExitReason == other.ExitReason ||
					this.ExitReason != null &&
					this.ExitReason.Equals(other.ExitReason)
				) &&
				(
					this.ActivationTriggers == other.ActivationTriggers ||
					this.ActivationTriggers != null &&
					this.ActivationTriggers.SequenceEqual(other.ActivationTriggers)
				) &&
				(
					this.ConversationContext == other.ConversationContext ||
					this.ConversationContext != null &&
					this.ConversationContext.SequenceEqual(other.ConversationContext)
				) &&
				(
					this.AgentChecklistItems == other.AgentChecklistItems ||
					this.AgentChecklistItems != null &&
					this.AgentChecklistItems.SequenceEqual(other.AgentChecklistItems)
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
				if (this.EvaluationStartDate != null)
					hash = hash * 59 + this.EvaluationStartDate.GetHashCode();

				if (this.EvaluationLastModifiedDate != null)
					hash = hash * 59 + this.EvaluationLastModifiedDate.GetHashCode();

				if (this.EvaluationFinalizedDate != null)
					hash = hash * 59 + this.EvaluationFinalizedDate.GetHashCode();

				if (this.EvaluationFinalizedWithAcwDate != null)
					hash = hash * 59 + this.EvaluationFinalizedWithAcwDate.GetHashCode();

				if (this.ConversationId != null)
					hash = hash * 59 + this.ConversationId.GetHashCode();

				if (this.CommunicationId != null)
					hash = hash * 59 + this.CommunicationId.GetHashCode();

				if (this.AgentChecklistId != null)
					hash = hash * 59 + this.AgentChecklistId.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				if (this.AgentId != null)
					hash = hash * 59 + this.AgentId.GetHashCode();

				if (this.ParticipantId != null)
					hash = hash * 59 + this.ParticipantId.GetHashCode();

				if (this.QueueId != null)
					hash = hash * 59 + this.QueueId.GetHashCode();

				if (this.AssistantId != null)
					hash = hash * 59 + this.AssistantId.GetHashCode();

				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.Direction != null)
					hash = hash * 59 + this.Direction.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.ExitReason != null)
					hash = hash * 59 + this.ExitReason.GetHashCode();

				if (this.ActivationTriggers != null)
					hash = hash * 59 + this.ActivationTriggers.GetHashCode();

				if (this.ConversationContext != null)
					hash = hash * 59 + this.ConversationContext.GetHashCode();

				if (this.AgentChecklistItems != null)
					hash = hash * 59 + this.AgentChecklistItems.GetHashCode();

				return hash;
			}
		}
	}

}
