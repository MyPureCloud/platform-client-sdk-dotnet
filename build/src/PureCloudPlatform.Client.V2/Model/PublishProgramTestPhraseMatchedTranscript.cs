using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PublishProgramTestPhraseMatchedTranscript
	/// </summary>
	[DataContract]
	public partial class PublishProgramTestPhraseMatchedTranscript : IEquatable<PublishProgramTestPhraseMatchedTranscript>
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
			/// Enum Unknown for "unknown"
			/// </summary>
			[EnumMember(Value = "unknown")]
			Unknown,

			/// <summary>
			/// Enum Call for "call"
			/// </summary>
			[EnumMember(Value = "call")]
			Call,

			/// <summary>
			/// Enum Message for "message"
			/// </summary>
			[EnumMember(Value = "message")]
			Message,

			/// <summary>
			/// Enum Email for "email"
			/// </summary>
			[EnumMember(Value = "email")]
			Email,

			/// <summary>
			/// Enum Chat for "chat"
			/// </summary>
			[EnumMember(Value = "chat")]
			Chat,

			/// <summary>
			/// Enum Callback for "callback"
			/// </summary>
			[EnumMember(Value = "callback")]
			Callback,

			/// <summary>
			/// Enum All for "all"
			/// </summary>
			[EnumMember(Value = "all")]
			All
		}
		/// <summary>
		/// Gets or Sets MediaType
		/// </summary>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public MediaTypeEnum? MediaType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="PublishProgramTestPhraseMatchedTranscript" /> class.
		/// </summary>
		/// <param name="Timestamp">Timestamp.</param>
		/// <param name="TranscriptId">TranscriptId.</param>
		/// <param name="CommunicationId">CommunicationId.</param>
		/// <param name="ConversationId">ConversationId.</param>
		/// <param name="MediaType">MediaType.</param>
		/// <param name="DetectedPhrases">DetectedPhrases.</param>
		public PublishProgramTestPhraseMatchedTranscript(long? Timestamp = null, string TranscriptId = null, string CommunicationId = null, string ConversationId = null, MediaTypeEnum? MediaType = null, List<PublishProgramTestPhraseDetectedPhrase> DetectedPhrases = null)
		{
			this.Timestamp = Timestamp;
			this.TranscriptId = TranscriptId;
			this.CommunicationId = CommunicationId;
			this.ConversationId = ConversationId;
			this.MediaType = MediaType;
			this.DetectedPhrases = DetectedPhrases;

		}



		/// <summary>
		/// Gets or Sets Timestamp
		/// </summary>
		[DataMember(Name = "timestamp", EmitDefaultValue = false)]
		public long? Timestamp { get; set; }



		/// <summary>
		/// Gets or Sets TranscriptId
		/// </summary>
		[DataMember(Name = "transcriptId", EmitDefaultValue = false)]
		public string TranscriptId { get; set; }



		/// <summary>
		/// Gets or Sets CommunicationId
		/// </summary>
		[DataMember(Name = "communicationId", EmitDefaultValue = false)]
		public string CommunicationId { get; set; }



		/// <summary>
		/// Gets or Sets ConversationId
		/// </summary>
		[DataMember(Name = "conversationId", EmitDefaultValue = false)]
		public string ConversationId { get; set; }





		/// <summary>
		/// Gets or Sets DetectedPhrases
		/// </summary>
		[DataMember(Name = "detectedPhrases", EmitDefaultValue = false)]
		public List<PublishProgramTestPhraseDetectedPhrase> DetectedPhrases { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PublishProgramTestPhraseMatchedTranscript {\n");

			sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
			sb.Append("  TranscriptId: ").Append(TranscriptId).Append("\n");
			sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  DetectedPhrases: ").Append(DetectedPhrases).Append("\n");
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
			return this.Equals(obj as PublishProgramTestPhraseMatchedTranscript);
		}

		/// <summary>
		/// Returns true if PublishProgramTestPhraseMatchedTranscript instances are equal
		/// </summary>
		/// <param name="other">Instance of PublishProgramTestPhraseMatchedTranscript to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PublishProgramTestPhraseMatchedTranscript other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Timestamp == other.Timestamp ||
					this.Timestamp != null &&
					this.Timestamp.Equals(other.Timestamp)
				) &&
				(
					this.TranscriptId == other.TranscriptId ||
					this.TranscriptId != null &&
					this.TranscriptId.Equals(other.TranscriptId)
				) &&
				(
					this.CommunicationId == other.CommunicationId ||
					this.CommunicationId != null &&
					this.CommunicationId.Equals(other.CommunicationId)
				) &&
				(
					this.ConversationId == other.ConversationId ||
					this.ConversationId != null &&
					this.ConversationId.Equals(other.ConversationId)
				) &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.DetectedPhrases == other.DetectedPhrases ||
					this.DetectedPhrases != null &&
					this.DetectedPhrases.SequenceEqual(other.DetectedPhrases)
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
				if (this.Timestamp != null)
					hash = hash * 59 + this.Timestamp.GetHashCode();

				if (this.TranscriptId != null)
					hash = hash * 59 + this.TranscriptId.GetHashCode();

				if (this.CommunicationId != null)
					hash = hash * 59 + this.CommunicationId.GetHashCode();

				if (this.ConversationId != null)
					hash = hash * 59 + this.ConversationId.GetHashCode();

				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.DetectedPhrases != null)
					hash = hash * 59 + this.DetectedPhrases.GetHashCode();

				return hash;
			}
		}
	}

}
