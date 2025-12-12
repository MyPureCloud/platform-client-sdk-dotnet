using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WebChatTyping
	/// </summary>
	[DataContract]
	public partial class WebChatTyping : IEquatable<WebChatTyping>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="WebChatTyping" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WebChatTyping() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WebChatTyping" /> class.
		/// </summary>
		/// <param name="Id">The event identifier of this typing indicator event (useful to guard against event re-delivery (required).</param>
		/// <param name="Conversation">The identifier of the conversation (required).</param>
		/// <param name="Sender">The member who sent the message (required).</param>
		/// <param name="Timestamp">The timestamp of the message, in ISO-8601 format (required).</param>
		public WebChatTyping(string Id = null, WebChatConversation Conversation = null, WebChatMemberInfo Sender = null, DateTime? Timestamp = null)
		{
			this.Id = Id;
			this.Conversation = Conversation;
			this.Sender = Sender;
			this.Timestamp = Timestamp;

		}



		/// <summary>
		/// The event identifier of this typing indicator event (useful to guard against event re-delivery
		/// </summary>
		/// <value>The event identifier of this typing indicator event (useful to guard against event re-delivery</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The identifier of the conversation
		/// </summary>
		/// <value>The identifier of the conversation</value>
		[DataMember(Name = "conversation", EmitDefaultValue = false)]
		public WebChatConversation Conversation { get; set; }



		/// <summary>
		/// The member who sent the message
		/// </summary>
		/// <value>The member who sent the message</value>
		[DataMember(Name = "sender", EmitDefaultValue = false)]
		public WebChatMemberInfo Sender { get; set; }



		/// <summary>
		/// The timestamp of the message, in ISO-8601 format
		/// </summary>
		/// <value>The timestamp of the message, in ISO-8601 format</value>
		[DataMember(Name = "timestamp", EmitDefaultValue = false)]
		public DateTime? Timestamp { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WebChatTyping {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Conversation: ").Append(Conversation).Append("\n");
			sb.Append("  Sender: ").Append(Sender).Append("\n");
			sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
			return this.Equals(obj as WebChatTyping);
		}

		/// <summary>
		/// Returns true if WebChatTyping instances are equal
		/// </summary>
		/// <param name="other">Instance of WebChatTyping to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WebChatTyping other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Conversation == other.Conversation ||
					this.Conversation != null &&
					this.Conversation.Equals(other.Conversation)
				) &&
				(
					this.Sender == other.Sender ||
					this.Sender != null &&
					this.Sender.Equals(other.Sender)
				) &&
				(
					this.Timestamp == other.Timestamp ||
					this.Timestamp != null &&
					this.Timestamp.Equals(other.Timestamp)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Conversation != null)
					hash = hash * 59 + this.Conversation.GetHashCode();

				if (this.Sender != null)
					hash = hash * 59 + this.Sender.GetHashCode();

				if (this.Timestamp != null)
					hash = hash * 59 + this.Timestamp.GetHashCode();

				return hash;
			}
		}
	}

}
