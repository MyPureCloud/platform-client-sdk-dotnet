using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationSummary
	/// </summary>
	[DataContract]
	public partial class ConversationSummary : IEquatable<ConversationSummary>
	{
		/// <summary>
		/// The status of the conversation summary.
		/// </summary>
		/// <value>The status of the conversation summary.</value>
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
			/// Enum Pending for "Pending"
			/// </summary>
			[EnumMember(Value = "Pending")]
			Pending,

			/// <summary>
			/// Enum Queued for "Queued"
			/// </summary>
			[EnumMember(Value = "Queued")]
			Queued,

			/// <summary>
			/// Enum Started for "Started"
			/// </summary>
			[EnumMember(Value = "Started")]
			Started,

			/// <summary>
			/// Enum Completed for "Completed"
			/// </summary>
			[EnumMember(Value = "Completed")]
			Completed,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error,

			/// <summary>
			/// Enum Processing for "Processing"
			/// </summary>
			[EnumMember(Value = "Processing")]
			Processing
		}
		/// <summary>
		/// The media type of the conversation.
		/// </summary>
		/// <value>The media type of the conversation.</value>
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
			/// Enum Email for "Email"
			/// </summary>
			[EnumMember(Value = "Email")]
			Email,

			/// <summary>
			/// Enum Call for "Call"
			/// </summary>
			[EnumMember(Value = "Call")]
			Call,

			/// <summary>
			/// Enum Chat for "Chat"
			/// </summary>
			[EnumMember(Value = "Chat")]
			Chat,

			/// <summary>
			/// Enum Message for "Message"
			/// </summary>
			[EnumMember(Value = "Message")]
			Message,

			/// <summary>
			/// Enum Webmessaging for "Webmessaging"
			/// </summary>
			[EnumMember(Value = "Webmessaging")]
			Webmessaging,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// The status of the conversation summary.
		/// </summary>
		/// <value>The status of the conversation summary.</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// The media type of the conversation.
		/// </summary>
		/// <value>The media type of the conversation.</value>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public MediaTypeEnum? MediaType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationSummary" /> class.
		/// </summary>
		/// <param name="Text">The text of the summary..</param>
		/// <param name="Status">The status of the conversation summary..</param>
		/// <param name="MediaType">The media type of the conversation..</param>
		/// <param name="Language">The language of the conversation..</param>
		/// <param name="PredictedWrapupCodes">The wrapup codes of the conversation summary..</param>
		/// <param name="EditedSummary">The edited summary of the conversation..</param>
		/// <param name="Reason">The reason of the conversation summary..</param>
		/// <param name="Followup">The followup of the conversation summary..</param>
		/// <param name="Resolution">The resolution of the conversation summary..</param>
		/// <param name="DateCreated">The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Participants">The list of participants..</param>
		public ConversationSummary(string Text = null, StatusEnum? Status = null, MediaTypeEnum? MediaType = null, string Language = null, List<ConversationSummaryWrapupCode> PredictedWrapupCodes = null, ConversationEditedInput EditedSummary = null, ConversationSummaryReason Reason = null, ConversationSummaryFollowup Followup = null, ConversationSummaryResolution Resolution = null, DateTime? DateCreated = null, List<AddressableEntityRef> Participants = null)
		{
			this.Text = Text;
			this.Status = Status;
			this.MediaType = MediaType;
			this.Language = Language;
			this.PredictedWrapupCodes = PredictedWrapupCodes;
			this.EditedSummary = EditedSummary;
			this.Reason = Reason;
			this.Followup = Followup;
			this.Resolution = Resolution;
			this.DateCreated = DateCreated;
			this.Participants = Participants;

		}



		/// <summary>
		/// The text of the summary.
		/// </summary>
		/// <value>The text of the summary.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }







		/// <summary>
		/// The language of the conversation.
		/// </summary>
		/// <value>The language of the conversation.</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public string Language { get; set; }



		/// <summary>
		/// The wrapup codes of the conversation summary.
		/// </summary>
		/// <value>The wrapup codes of the conversation summary.</value>
		[DataMember(Name = "predictedWrapupCodes", EmitDefaultValue = false)]
		public List<ConversationSummaryWrapupCode> PredictedWrapupCodes { get; set; }



		/// <summary>
		/// The edited summary of the conversation.
		/// </summary>
		/// <value>The edited summary of the conversation.</value>
		[DataMember(Name = "editedSummary", EmitDefaultValue = false)]
		public ConversationEditedInput EditedSummary { get; set; }



		/// <summary>
		/// The reason of the conversation summary.
		/// </summary>
		/// <value>The reason of the conversation summary.</value>
		[DataMember(Name = "reason", EmitDefaultValue = false)]
		public ConversationSummaryReason Reason { get; set; }



		/// <summary>
		/// The followup of the conversation summary.
		/// </summary>
		/// <value>The followup of the conversation summary.</value>
		[DataMember(Name = "followup", EmitDefaultValue = false)]
		public ConversationSummaryFollowup Followup { get; set; }



		/// <summary>
		/// The resolution of the conversation summary.
		/// </summary>
		/// <value>The resolution of the conversation summary.</value>
		[DataMember(Name = "resolution", EmitDefaultValue = false)]
		public ConversationSummaryResolution Resolution { get; set; }



		/// <summary>
		/// The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// The id of the summary.
		/// </summary>
		/// <value>The id of the summary.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The AI confidence value.
		/// </summary>
		/// <value>The AI confidence value.</value>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public float? Confidence { get; private set; }



		/// <summary>
		/// The list of participants.
		/// </summary>
		/// <value>The list of participants.</value>
		[DataMember(Name = "participants", EmitDefaultValue = false)]
		public List<AddressableEntityRef> Participants { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationSummary {\n");

			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  PredictedWrapupCodes: ").Append(PredictedWrapupCodes).Append("\n");
			sb.Append("  EditedSummary: ").Append(EditedSummary).Append("\n");
			sb.Append("  Reason: ").Append(Reason).Append("\n");
			sb.Append("  Followup: ").Append(Followup).Append("\n");
			sb.Append("  Resolution: ").Append(Resolution).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Confidence: ").Append(Confidence).Append("\n");
			sb.Append("  Participants: ").Append(Participants).Append("\n");
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
			return this.Equals(obj as ConversationSummary);
		}

		/// <summary>
		/// Returns true if ConversationSummary instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationSummary other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
				) &&
				(
					this.PredictedWrapupCodes == other.PredictedWrapupCodes ||
					this.PredictedWrapupCodes != null &&
					this.PredictedWrapupCodes.SequenceEqual(other.PredictedWrapupCodes)
				) &&
				(
					this.EditedSummary == other.EditedSummary ||
					this.EditedSummary != null &&
					this.EditedSummary.Equals(other.EditedSummary)
				) &&
				(
					this.Reason == other.Reason ||
					this.Reason != null &&
					this.Reason.Equals(other.Reason)
				) &&
				(
					this.Followup == other.Followup ||
					this.Followup != null &&
					this.Followup.Equals(other.Followup)
				) &&
				(
					this.Resolution == other.Resolution ||
					this.Resolution != null &&
					this.Resolution.Equals(other.Resolution)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Confidence == other.Confidence ||
					this.Confidence != null &&
					this.Confidence.Equals(other.Confidence)
				) &&
				(
					this.Participants == other.Participants ||
					this.Participants != null &&
					this.Participants.SequenceEqual(other.Participants)
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
				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				if (this.PredictedWrapupCodes != null)
					hash = hash * 59 + this.PredictedWrapupCodes.GetHashCode();

				if (this.EditedSummary != null)
					hash = hash * 59 + this.EditedSummary.GetHashCode();

				if (this.Reason != null)
					hash = hash * 59 + this.Reason.GetHashCode();

				if (this.Followup != null)
					hash = hash * 59 + this.Followup.GetHashCode();

				if (this.Resolution != null)
					hash = hash * 59 + this.Resolution.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Confidence != null)
					hash = hash * 59 + this.Confidence.GetHashCode();

				if (this.Participants != null)
					hash = hash * 59 + this.Participants.GetHashCode();

				return hash;
			}
		}
	}

}
