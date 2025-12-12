using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MessagingExternalEstablishedEvent
	/// </summary>
	[DataContract]
	public partial class MessagingExternalEstablishedEvent : IEquatable<MessagingExternalEstablishedEvent>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="MessagingExternalEstablishedEvent" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected MessagingExternalEstablishedEvent() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="MessagingExternalEstablishedEvent" /> class.
		/// </summary>
		/// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
		/// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
		/// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication. (required).</param>
		/// <param name="DisplayName">A name for the participant if it is available for this conversation..</param>
		/// <param name="InitialConfiguration">Metadata about this communication. (required).</param>
		/// <param name="SourceConfiguration">Metadata about the source of this communication&#39;s interaction. (required).</param>
		public MessagingExternalEstablishedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string DisplayName = null, MessagingInitialConfiguration InitialConfiguration = null, SourceConfiguration SourceConfiguration = null)
		{
			this.EventId = EventId;
			this.EventDateTime = EventDateTime;
			this.ConversationId = ConversationId;
			this.CommunicationId = CommunicationId;
			this.DisplayName = DisplayName;
			this.InitialConfiguration = InitialConfiguration;
			this.SourceConfiguration = SourceConfiguration;

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
		/// A unique Id (V4 UUID) identifying this communication.
		/// </summary>
		/// <value>A unique Id (V4 UUID) identifying this communication.</value>
		[DataMember(Name = "communicationId", EmitDefaultValue = false)]
		public string CommunicationId { get; set; }



		/// <summary>
		/// A name for the participant if it is available for this conversation.
		/// </summary>
		/// <value>A name for the participant if it is available for this conversation.</value>
		[DataMember(Name = "displayName", EmitDefaultValue = false)]
		public string DisplayName { get; set; }



		/// <summary>
		/// Metadata about this communication.
		/// </summary>
		/// <value>Metadata about this communication.</value>
		[DataMember(Name = "initialConfiguration", EmitDefaultValue = false)]
		public MessagingInitialConfiguration InitialConfiguration { get; set; }



		/// <summary>
		/// Metadata about the source of this communication&#39;s interaction.
		/// </summary>
		/// <value>Metadata about the source of this communication&#39;s interaction.</value>
		[DataMember(Name = "sourceConfiguration", EmitDefaultValue = false)]
		public SourceConfiguration SourceConfiguration { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MessagingExternalEstablishedEvent {\n");

			sb.Append("  EventId: ").Append(EventId).Append("\n");
			sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  InitialConfiguration: ").Append(InitialConfiguration).Append("\n");
			sb.Append("  SourceConfiguration: ").Append(SourceConfiguration).Append("\n");
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
			return this.Equals(obj as MessagingExternalEstablishedEvent);
		}

		/// <summary>
		/// Returns true if MessagingExternalEstablishedEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of MessagingExternalEstablishedEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MessagingExternalEstablishedEvent other)
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
					this.DisplayName == other.DisplayName ||
					this.DisplayName != null &&
					this.DisplayName.Equals(other.DisplayName)
				) &&
				(
					this.InitialConfiguration == other.InitialConfiguration ||
					this.InitialConfiguration != null &&
					this.InitialConfiguration.Equals(other.InitialConfiguration)
				) &&
				(
					this.SourceConfiguration == other.SourceConfiguration ||
					this.SourceConfiguration != null &&
					this.SourceConfiguration.Equals(other.SourceConfiguration)
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

				if (this.DisplayName != null)
					hash = hash * 59 + this.DisplayName.GetHashCode();

				if (this.InitialConfiguration != null)
					hash = hash * 59 + this.InitialConfiguration.GetHashCode();

				if (this.SourceConfiguration != null)
					hash = hash * 59 + this.SourceConfiguration.GetHashCode();

				return hash;
			}
		}
	}

}
