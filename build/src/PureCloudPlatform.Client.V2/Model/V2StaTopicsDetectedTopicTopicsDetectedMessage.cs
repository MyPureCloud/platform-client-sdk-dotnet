using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2StaTopicsDetectedTopicTopicsDetectedMessage
	/// </summary>
	[DataContract]
	public partial class V2StaTopicsDetectedTopicTopicsDetectedMessage : IEquatable<V2StaTopicsDetectedTopicTopicsDetectedMessage>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2StaTopicsDetectedTopicTopicsDetectedMessage" /> class.
		/// </summary>
		/// <param name="ConversationId">ConversationId.</param>
		/// <param name="CommunicationId">CommunicationId.</param>
		/// <param name="RecordingId">RecordingId.</param>
		/// <param name="TranscriptId">TranscriptId.</param>
		/// <param name="MediaType">MediaType.</param>
		/// <param name="ProgramId">ProgramId.</param>
		/// <param name="Topics">Topics.</param>
		/// <param name="Participants">Participants.</param>
		public V2StaTopicsDetectedTopicTopicsDetectedMessage(string ConversationId = null, string CommunicationId = null, string RecordingId = null, string TranscriptId = null, string MediaType = null, string ProgramId = null, List<V2StaTopicsDetectedTopicTopicDetected> Topics = null, List<V2StaTopicsDetectedTopicParticipant> Participants = null)
		{
			this.ConversationId = ConversationId;
			this.CommunicationId = CommunicationId;
			this.RecordingId = RecordingId;
			this.TranscriptId = TranscriptId;
			this.MediaType = MediaType;
			this.ProgramId = ProgramId;
			this.Topics = Topics;
			this.Participants = Participants;

		}



		/// <summary>
		/// Gets or Sets ConversationId
		/// </summary>
		[DataMember(Name = "conversationId", EmitDefaultValue = false)]
		public string ConversationId { get; set; }



		/// <summary>
		/// Gets or Sets CommunicationId
		/// </summary>
		[DataMember(Name = "communicationId", EmitDefaultValue = false)]
		public string CommunicationId { get; set; }



		/// <summary>
		/// Gets or Sets RecordingId
		/// </summary>
		[DataMember(Name = "recordingId", EmitDefaultValue = false)]
		public string RecordingId { get; set; }



		/// <summary>
		/// Gets or Sets TranscriptId
		/// </summary>
		[DataMember(Name = "transcriptId", EmitDefaultValue = false)]
		public string TranscriptId { get; set; }



		/// <summary>
		/// Gets or Sets MediaType
		/// </summary>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public string MediaType { get; set; }



		/// <summary>
		/// Gets or Sets ProgramId
		/// </summary>
		[DataMember(Name = "programId", EmitDefaultValue = false)]
		public string ProgramId { get; set; }



		/// <summary>
		/// Gets or Sets Topics
		/// </summary>
		[DataMember(Name = "topics", EmitDefaultValue = false)]
		public List<V2StaTopicsDetectedTopicTopicDetected> Topics { get; set; }



		/// <summary>
		/// Gets or Sets Participants
		/// </summary>
		[DataMember(Name = "participants", EmitDefaultValue = false)]
		public List<V2StaTopicsDetectedTopicParticipant> Participants { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2StaTopicsDetectedTopicTopicsDetectedMessage {\n");

			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
			sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
			sb.Append("  TranscriptId: ").Append(TranscriptId).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
			sb.Append("  Topics: ").Append(Topics).Append("\n");
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
			return this.Equals(obj as V2StaTopicsDetectedTopicTopicsDetectedMessage);
		}

		/// <summary>
		/// Returns true if V2StaTopicsDetectedTopicTopicsDetectedMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of V2StaTopicsDetectedTopicTopicsDetectedMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2StaTopicsDetectedTopicTopicsDetectedMessage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
					this.RecordingId == other.RecordingId ||
					this.RecordingId != null &&
					this.RecordingId.Equals(other.RecordingId)
				) &&
				(
					this.TranscriptId == other.TranscriptId ||
					this.TranscriptId != null &&
					this.TranscriptId.Equals(other.TranscriptId)
				) &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.ProgramId == other.ProgramId ||
					this.ProgramId != null &&
					this.ProgramId.Equals(other.ProgramId)
				) &&
				(
					this.Topics == other.Topics ||
					this.Topics != null &&
					this.Topics.SequenceEqual(other.Topics)
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
				if (this.ConversationId != null)
					hash = hash * 59 + this.ConversationId.GetHashCode();

				if (this.CommunicationId != null)
					hash = hash * 59 + this.CommunicationId.GetHashCode();

				if (this.RecordingId != null)
					hash = hash * 59 + this.RecordingId.GetHashCode();

				if (this.TranscriptId != null)
					hash = hash * 59 + this.TranscriptId.GetHashCode();

				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.ProgramId != null)
					hash = hash * 59 + this.ProgramId.GetHashCode();

				if (this.Topics != null)
					hash = hash * 59 + this.Topics.GetHashCode();

				if (this.Participants != null)
					hash = hash * 59 + this.Participants.GetHashCode();

				return hash;
			}
		}
	}

}
