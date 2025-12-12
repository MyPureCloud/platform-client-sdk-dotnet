using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MessagingCommunicationDispositionAppliedEvent
	/// </summary>
	[DataContract]
	public partial class MessagingCommunicationDispositionAppliedEvent : IEquatable<MessagingCommunicationDispositionAppliedEvent>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="MessagingCommunicationDispositionAppliedEvent" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected MessagingCommunicationDispositionAppliedEvent() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="MessagingCommunicationDispositionAppliedEvent" /> class.
		/// </summary>
		/// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
		/// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
		/// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication (required).</param>
		/// <param name="Code">The wrapup-code (V4 UUID) used to disposition this interaction. If this value is not provided the disposition is considered skipped..</param>
		/// <param name="Notes">Text entered by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped..</param>
		/// <param name="Tags">The list of tags selected by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped..</param>
		public MessagingCommunicationDispositionAppliedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string Code = null, string Notes = null, List<string> Tags = null)
		{
			this.EventId = EventId;
			this.EventDateTime = EventDateTime;
			this.ConversationId = ConversationId;
			this.CommunicationId = CommunicationId;
			this.Code = Code;
			this.Notes = Notes;
			this.Tags = Tags;

		}



		/// <summary>
		/// A unique (V4 UUID) eventId for this event
		/// </summary>
		/// <value>A unique (V4 UUID) eventId for this event</value>
		[DataMember(Name = "eventId", EmitDefaultValue = false)]
		public string EventId { get; set; }



		/// <summary>
		/// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "eventDateTime", EmitDefaultValue = false)]
		public DateTime? EventDateTime { get; set; }



		/// <summary>
		/// A unique Id (V4 UUID) identifying this conversation
		/// </summary>
		/// <value>A unique Id (V4 UUID) identifying this conversation</value>
		[DataMember(Name = "conversationId", EmitDefaultValue = false)]
		public string ConversationId { get; set; }



		/// <summary>
		/// A unique Id (V4 UUID) identifying this communication
		/// </summary>
		/// <value>A unique Id (V4 UUID) identifying this communication</value>
		[DataMember(Name = "communicationId", EmitDefaultValue = false)]
		public string CommunicationId { get; set; }



		/// <summary>
		/// The wrapup-code (V4 UUID) used to disposition this interaction. If this value is not provided the disposition is considered skipped.
		/// </summary>
		/// <value>The wrapup-code (V4 UUID) used to disposition this interaction. If this value is not provided the disposition is considered skipped.</value>
		[DataMember(Name = "code", EmitDefaultValue = false)]
		public string Code { get; set; }



		/// <summary>
		/// Text entered by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.
		/// </summary>
		/// <value>Text entered by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.</value>
		[DataMember(Name = "notes", EmitDefaultValue = false)]
		public string Notes { get; set; }



		/// <summary>
		/// The list of tags selected by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.
		/// </summary>
		/// <value>The list of tags selected by the agent to describe the interaction or disposition. Ignored if the disposition is considered skipped.</value>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public List<string> Tags { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MessagingCommunicationDispositionAppliedEvent {\n");

			sb.Append("  EventId: ").Append(EventId).Append("\n");
			sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
			sb.Append("  Code: ").Append(Code).Append("\n");
			sb.Append("  Notes: ").Append(Notes).Append("\n");
			sb.Append("  Tags: ").Append(Tags).Append("\n");
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
			return this.Equals(obj as MessagingCommunicationDispositionAppliedEvent);
		}

		/// <summary>
		/// Returns true if MessagingCommunicationDispositionAppliedEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of MessagingCommunicationDispositionAppliedEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MessagingCommunicationDispositionAppliedEvent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EventId == other.EventId ||
					this.EventId != null &&
					this.EventId.Equals(other.EventId)
				) &&
				(
					this.EventDateTime == other.EventDateTime ||
					this.EventDateTime != null &&
					this.EventDateTime.Equals(other.EventDateTime)
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
					this.Code == other.Code ||
					this.Code != null &&
					this.Code.Equals(other.Code)
				) &&
				(
					this.Notes == other.Notes ||
					this.Notes != null &&
					this.Notes.Equals(other.Notes)
				) &&
				(
					this.Tags == other.Tags ||
					this.Tags != null &&
					this.Tags.SequenceEqual(other.Tags)
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
				if (this.EventId != null)
					hash = hash * 59 + this.EventId.GetHashCode();

				if (this.EventDateTime != null)
					hash = hash * 59 + this.EventDateTime.GetHashCode();

				if (this.ConversationId != null)
					hash = hash * 59 + this.ConversationId.GetHashCode();

				if (this.CommunicationId != null)
					hash = hash * 59 + this.CommunicationId.GetHashCode();

				if (this.Code != null)
					hash = hash * 59 + this.Code.GetHashCode();

				if (this.Notes != null)
					hash = hash * 59 + this.Notes.GetHashCode();

				if (this.Tags != null)
					hash = hash * 59 + this.Tags.GetHashCode();

				return hash;
			}
		}
	}

}
