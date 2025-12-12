using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationEventTopicInternalMessageDetails
	/// </summary>
	[DataContract]
	public partial class ConversationEventTopicInternalMessageDetails : IEquatable<ConversationEventTopicInternalMessageDetails>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEventTopicInternalMessageDetails" /> class.
		/// </summary>
		/// <param name="MessageId">UUID identifying the internal message media..</param>
		/// <param name="MessageTime">The time when the internal message was sent or received..</param>
		public ConversationEventTopicInternalMessageDetails(string MessageId = null, DateTime? MessageTime = null)
		{
			this.MessageId = MessageId;
			this.MessageTime = MessageTime;

		}



		/// <summary>
		/// UUID identifying the internal message media.
		/// </summary>
		/// <value>UUID identifying the internal message media.</value>
		[DataMember(Name = "messageId", EmitDefaultValue = false)]
		public string MessageId { get; set; }



		/// <summary>
		/// The time when the internal message was sent or received.
		/// </summary>
		/// <value>The time when the internal message was sent or received.</value>
		[DataMember(Name = "messageTime", EmitDefaultValue = false)]
		public DateTime? MessageTime { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationEventTopicInternalMessageDetails {\n");

			sb.Append("  MessageId: ").Append(MessageId).Append("\n");
			sb.Append("  MessageTime: ").Append(MessageTime).Append("\n");
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
			return this.Equals(obj as ConversationEventTopicInternalMessageDetails);
		}

		/// <summary>
		/// Returns true if ConversationEventTopicInternalMessageDetails instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationEventTopicInternalMessageDetails to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationEventTopicInternalMessageDetails other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MessageId == other.MessageId ||
					this.MessageId != null &&
					this.MessageId.Equals(other.MessageId)
				) &&
				(
					this.MessageTime == other.MessageTime ||
					this.MessageTime != null &&
					this.MessageTime.Equals(other.MessageTime)
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
				if (this.MessageId != null)
					hash = hash * 59 + this.MessageId.GetHashCode();

				if (this.MessageTime != null)
					hash = hash * 59 + this.MessageTime.GetHashCode();

				return hash;
			}
		}
	}

}
