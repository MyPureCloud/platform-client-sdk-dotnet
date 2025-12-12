using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2SessionConversationsSummarySettingsPreviewEventConversationSummarySettingsPreviewMessage
	/// </summary>
	[DataContract]
	public partial class V2SessionConversationsSummarySettingsPreviewEventConversationSummarySettingsPreviewMessage : IEquatable<V2SessionConversationsSummarySettingsPreviewEventConversationSummarySettingsPreviewMessage>
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
			/// Enum Message for "MESSAGE"
			/// </summary>
			[EnumMember(Value = "MESSAGE")]
			Message,

			/// <summary>
			/// Enum Call for "CALL"
			/// </summary>
			[EnumMember(Value = "CALL")]
			Call,

			/// <summary>
			/// Enum Email for "EMAIL"
			/// </summary>
			[EnumMember(Value = "EMAIL")]
			Email
		}
		/// <summary>
		/// Gets or Sets ErrorType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ErrorTypeEnum
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
			/// Enum ConversationTooLong for "CONVERSATION_TOO_LONG"
			/// </summary>
			[EnumMember(Value = "CONVERSATION_TOO_LONG")]
			ConversationTooLong,

			/// <summary>
			/// Enum ConversationTooShort for "CONVERSATION_TOO_SHORT"
			/// </summary>
			[EnumMember(Value = "CONVERSATION_TOO_SHORT")]
			ConversationTooShort,

			/// <summary>
			/// Enum RateLimited for "RATE_LIMITED"
			/// </summary>
			[EnumMember(Value = "RATE_LIMITED")]
			RateLimited
		}
		/// <summary>
		/// Gets or Sets MediaType
		/// </summary>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public MediaTypeEnum? MediaType { get; set; }
		/// <summary>
		/// Gets or Sets ErrorType
		/// </summary>
		[DataMember(Name = "errorType", EmitDefaultValue = false)]
		public ErrorTypeEnum? ErrorType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="V2SessionConversationsSummarySettingsPreviewEventConversationSummarySettingsPreviewMessage" /> class.
		/// </summary>
		/// <param name="CreatedDate">CreatedDate.</param>
		/// <param name="SummaryId">SummaryId.</param>
		/// <param name="SessionId">SessionId.</param>
		/// <param name="UserId">UserId.</param>
		/// <param name="SummarySettingsId">SummarySettingsId.</param>
		/// <param name="Language">Language.</param>
		/// <param name="MediaType">MediaType.</param>
		/// <param name="Summary">Summary.</param>
		/// <param name="Reason">Reason.</param>
		/// <param name="Resolution">Resolution.</param>
		/// <param name="FollowupActions">FollowupActions.</param>
		/// <param name="ExtractedEntities">ExtractedEntities.</param>
		/// <param name="ErrorType">ErrorType.</param>
		/// <param name="DurationMs">DurationMs.</param>
		public V2SessionConversationsSummarySettingsPreviewEventConversationSummarySettingsPreviewMessage(DateTime? CreatedDate = null, Guid? SummaryId = null, Guid? SessionId = null, Guid? UserId = null, Guid? SummarySettingsId = null, string Language = null, MediaTypeEnum? MediaType = null, V2SessionConversationsSummarySettingsPreviewEventConversationSummaryMessage Summary = null, V2SessionConversationsSummarySettingsPreviewEventConversationReasonMessage Reason = null, V2SessionConversationsSummarySettingsPreviewEventConversationResolutionMessage Resolution = null, List<V2SessionConversationsSummarySettingsPreviewEventConversationFollowupAction> FollowupActions = null, List<V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity> ExtractedEntities = null, ErrorTypeEnum? ErrorType = null, long? DurationMs = null)
		{
			this.CreatedDate = CreatedDate;
			this.SummaryId = SummaryId;
			this.SessionId = SessionId;
			this.UserId = UserId;
			this.SummarySettingsId = SummarySettingsId;
			this.Language = Language;
			this.MediaType = MediaType;
			this.Summary = Summary;
			this.Reason = Reason;
			this.Resolution = Resolution;
			this.FollowupActions = FollowupActions;
			this.ExtractedEntities = ExtractedEntities;
			this.ErrorType = ErrorType;
			this.DurationMs = DurationMs;

		}



		/// <summary>
		/// Gets or Sets CreatedDate
		/// </summary>
		[DataMember(Name = "createdDate", EmitDefaultValue = false)]
		public DateTime? CreatedDate { get; set; }



		/// <summary>
		/// Gets or Sets SummaryId
		/// </summary>
		[DataMember(Name = "summaryId", EmitDefaultValue = false)]
		public Guid? SummaryId { get; set; }



		/// <summary>
		/// Gets or Sets SessionId
		/// </summary>
		[DataMember(Name = "sessionId", EmitDefaultValue = false)]
		public Guid? SessionId { get; set; }



		/// <summary>
		/// Gets or Sets UserId
		/// </summary>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public Guid? UserId { get; set; }



		/// <summary>
		/// Gets or Sets SummarySettingsId
		/// </summary>
		[DataMember(Name = "summarySettingsId", EmitDefaultValue = false)]
		public Guid? SummarySettingsId { get; set; }



		/// <summary>
		/// Gets or Sets Language
		/// </summary>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public string Language { get; set; }





		/// <summary>
		/// Gets or Sets Summary
		/// </summary>
		[DataMember(Name = "summary", EmitDefaultValue = false)]
		public V2SessionConversationsSummarySettingsPreviewEventConversationSummaryMessage Summary { get; set; }



		/// <summary>
		/// Gets or Sets Reason
		/// </summary>
		[DataMember(Name = "reason", EmitDefaultValue = false)]
		public V2SessionConversationsSummarySettingsPreviewEventConversationReasonMessage Reason { get; set; }



		/// <summary>
		/// Gets or Sets Resolution
		/// </summary>
		[DataMember(Name = "resolution", EmitDefaultValue = false)]
		public V2SessionConversationsSummarySettingsPreviewEventConversationResolutionMessage Resolution { get; set; }



		/// <summary>
		/// Gets or Sets FollowupActions
		/// </summary>
		[DataMember(Name = "followupActions", EmitDefaultValue = false)]
		public List<V2SessionConversationsSummarySettingsPreviewEventConversationFollowupAction> FollowupActions { get; set; }



		/// <summary>
		/// Gets or Sets ExtractedEntities
		/// </summary>
		[DataMember(Name = "extractedEntities", EmitDefaultValue = false)]
		public List<V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity> ExtractedEntities { get; set; }





		/// <summary>
		/// Gets or Sets DurationMs
		/// </summary>
		[DataMember(Name = "durationMs", EmitDefaultValue = false)]
		public long? DurationMs { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2SessionConversationsSummarySettingsPreviewEventConversationSummarySettingsPreviewMessage {\n");

			sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
			sb.Append("  SummaryId: ").Append(SummaryId).Append("\n");
			sb.Append("  SessionId: ").Append(SessionId).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  SummarySettingsId: ").Append(SummarySettingsId).Append("\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  Summary: ").Append(Summary).Append("\n");
			sb.Append("  Reason: ").Append(Reason).Append("\n");
			sb.Append("  Resolution: ").Append(Resolution).Append("\n");
			sb.Append("  FollowupActions: ").Append(FollowupActions).Append("\n");
			sb.Append("  ExtractedEntities: ").Append(ExtractedEntities).Append("\n");
			sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
			sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
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
			return this.Equals(obj as V2SessionConversationsSummarySettingsPreviewEventConversationSummarySettingsPreviewMessage);
		}

		/// <summary>
		/// Returns true if V2SessionConversationsSummarySettingsPreviewEventConversationSummarySettingsPreviewMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of V2SessionConversationsSummarySettingsPreviewEventConversationSummarySettingsPreviewMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2SessionConversationsSummarySettingsPreviewEventConversationSummarySettingsPreviewMessage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.CreatedDate == other.CreatedDate ||
					this.CreatedDate != null &&
					this.CreatedDate.Equals(other.CreatedDate)
				) &&
				(
					this.SummaryId == other.SummaryId ||
					this.SummaryId != null &&
					this.SummaryId.Equals(other.SummaryId)
				) &&
				(
					this.SessionId == other.SessionId ||
					this.SessionId != null &&
					this.SessionId.Equals(other.SessionId)
				) &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
				) &&
				(
					this.SummarySettingsId == other.SummarySettingsId ||
					this.SummarySettingsId != null &&
					this.SummarySettingsId.Equals(other.SummarySettingsId)
				) &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
				) &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.Summary == other.Summary ||
					this.Summary != null &&
					this.Summary.Equals(other.Summary)
				) &&
				(
					this.Reason == other.Reason ||
					this.Reason != null &&
					this.Reason.Equals(other.Reason)
				) &&
				(
					this.Resolution == other.Resolution ||
					this.Resolution != null &&
					this.Resolution.Equals(other.Resolution)
				) &&
				(
					this.FollowupActions == other.FollowupActions ||
					this.FollowupActions != null &&
					this.FollowupActions.SequenceEqual(other.FollowupActions)
				) &&
				(
					this.ExtractedEntities == other.ExtractedEntities ||
					this.ExtractedEntities != null &&
					this.ExtractedEntities.SequenceEqual(other.ExtractedEntities)
				) &&
				(
					this.ErrorType == other.ErrorType ||
					this.ErrorType != null &&
					this.ErrorType.Equals(other.ErrorType)
				) &&
				(
					this.DurationMs == other.DurationMs ||
					this.DurationMs != null &&
					this.DurationMs.Equals(other.DurationMs)
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
				if (this.CreatedDate != null)
					hash = hash * 59 + this.CreatedDate.GetHashCode();

				if (this.SummaryId != null)
					hash = hash * 59 + this.SummaryId.GetHashCode();

				if (this.SessionId != null)
					hash = hash * 59 + this.SessionId.GetHashCode();

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				if (this.SummarySettingsId != null)
					hash = hash * 59 + this.SummarySettingsId.GetHashCode();

				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.Summary != null)
					hash = hash * 59 + this.Summary.GetHashCode();

				if (this.Reason != null)
					hash = hash * 59 + this.Reason.GetHashCode();

				if (this.Resolution != null)
					hash = hash * 59 + this.Resolution.GetHashCode();

				if (this.FollowupActions != null)
					hash = hash * 59 + this.FollowupActions.GetHashCode();

				if (this.ExtractedEntities != null)
					hash = hash * 59 + this.ExtractedEntities.GetHashCode();

				if (this.ErrorType != null)
					hash = hash * 59 + this.ErrorType.GetHashCode();

				if (this.DurationMs != null)
					hash = hash * 59 + this.DurationMs.GetHashCode();

				return hash;
			}
		}
	}

}
