using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody
	/// </summary>
	[DataContract]
	public partial class V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody : IEquatable<V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody" /> class.
		/// </summary>
		/// <param name="ConversationId">ConversationId.</param>
		/// <param name="DeploymentId">DeploymentId.</param>
		/// <param name="ParticipantId">ParticipantId.</param>
		/// <param name="ExternalContactId">ExternalContactId.</param>
		/// <param name="CommunicationId">CommunicationId.</param>
		/// <param name="SessionExpiry">SessionExpiry.</param>
		/// <param name="Messages">Messages.</param>
		/// <param name="EventTimeMs">EventTimeMs.</param>
		public V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody(string ConversationId = null, string DeploymentId = null, string ParticipantId = null, string ExternalContactId = null, string CommunicationId = null, long? SessionExpiry = null, List<V2WebMessagingUndeliveredMessageTopicMessage> Messages = null, long? EventTimeMs = null)
		{
			this.ConversationId = ConversationId;
			this.DeploymentId = DeploymentId;
			this.ParticipantId = ParticipantId;
			this.ExternalContactId = ExternalContactId;
			this.CommunicationId = CommunicationId;
			this.SessionExpiry = SessionExpiry;
			this.Messages = Messages;
			this.EventTimeMs = EventTimeMs;

		}



		/// <summary>
		/// Gets or Sets ConversationId
		/// </summary>
		[DataMember(Name = "conversationId", EmitDefaultValue = false)]
		public string ConversationId { get; set; }



		/// <summary>
		/// Gets or Sets DeploymentId
		/// </summary>
		[DataMember(Name = "deploymentId", EmitDefaultValue = false)]
		public string DeploymentId { get; set; }



		/// <summary>
		/// Gets or Sets ParticipantId
		/// </summary>
		[DataMember(Name = "participantId", EmitDefaultValue = false)]
		public string ParticipantId { get; set; }



		/// <summary>
		/// Gets or Sets ExternalContactId
		/// </summary>
		[DataMember(Name = "externalContactId", EmitDefaultValue = false)]
		public string ExternalContactId { get; set; }



		/// <summary>
		/// Gets or Sets CommunicationId
		/// </summary>
		[DataMember(Name = "communicationId", EmitDefaultValue = false)]
		public string CommunicationId { get; set; }



		/// <summary>
		/// Gets or Sets SessionExpiry
		/// </summary>
		[DataMember(Name = "sessionExpiry", EmitDefaultValue = false)]
		public long? SessionExpiry { get; set; }



		/// <summary>
		/// Gets or Sets Messages
		/// </summary>
		[DataMember(Name = "messages", EmitDefaultValue = false)]
		public List<V2WebMessagingUndeliveredMessageTopicMessage> Messages { get; set; }



		/// <summary>
		/// Gets or Sets EventTimeMs
		/// </summary>
		[DataMember(Name = "eventTimeMs", EmitDefaultValue = false)]
		public long? EventTimeMs { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody {\n");

			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
			sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
			sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
			sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
			sb.Append("  SessionExpiry: ").Append(SessionExpiry).Append("\n");
			sb.Append("  Messages: ").Append(Messages).Append("\n");
			sb.Append("  EventTimeMs: ").Append(EventTimeMs).Append("\n");
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
			return this.Equals(obj as V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody);
		}

		/// <summary>
		/// Returns true if V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody instances are equal
		/// </summary>
		/// <param name="other">Instance of V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody other)
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
					this.DeploymentId == other.DeploymentId ||
					this.DeploymentId != null &&
					this.DeploymentId.Equals(other.DeploymentId)
				) &&
				(
					this.ParticipantId == other.ParticipantId ||
					this.ParticipantId != null &&
					this.ParticipantId.Equals(other.ParticipantId)
				) &&
				(
					this.ExternalContactId == other.ExternalContactId ||
					this.ExternalContactId != null &&
					this.ExternalContactId.Equals(other.ExternalContactId)
				) &&
				(
					this.CommunicationId == other.CommunicationId ||
					this.CommunicationId != null &&
					this.CommunicationId.Equals(other.CommunicationId)
				) &&
				(
					this.SessionExpiry == other.SessionExpiry ||
					this.SessionExpiry != null &&
					this.SessionExpiry.Equals(other.SessionExpiry)
				) &&
				(
					this.Messages == other.Messages ||
					this.Messages != null &&
					this.Messages.SequenceEqual(other.Messages)
				) &&
				(
					this.EventTimeMs == other.EventTimeMs ||
					this.EventTimeMs != null &&
					this.EventTimeMs.Equals(other.EventTimeMs)
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

				if (this.DeploymentId != null)
					hash = hash * 59 + this.DeploymentId.GetHashCode();

				if (this.ParticipantId != null)
					hash = hash * 59 + this.ParticipantId.GetHashCode();

				if (this.ExternalContactId != null)
					hash = hash * 59 + this.ExternalContactId.GetHashCode();

				if (this.CommunicationId != null)
					hash = hash * 59 + this.CommunicationId.GetHashCode();

				if (this.SessionExpiry != null)
					hash = hash * 59 + this.SessionExpiry.GetHashCode();

				if (this.Messages != null)
					hash = hash * 59 + this.Messages.GetHashCode();

				if (this.EventTimeMs != null)
					hash = hash * 59 + this.EventTimeMs.GetHashCode();

				return hash;
			}
		}
	}

}
