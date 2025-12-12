using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// InteractiveApplication content object.
	/// </summary>
	[DataContract]
	public partial class ConversationContentInteractiveApplication : IEquatable<ConversationContentInteractiveApplication>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentInteractiveApplication" /> class.
		/// </summary>
		/// <param name="Name">The name of the message app..</param>
		/// <param name="Url">Contains the data that is sent to the message app..</param>
		/// <param name="ReceivedMessage">The message displayed in the received message bubble..</param>
		/// <param name="ReplyMessage">The message displayed in the reply message bubble..</param>
		public ConversationContentInteractiveApplication(string Name = null, string Url = null, ConversationContentReceivedReplyMessage ReceivedMessage = null, ConversationContentReceivedReplyMessage ReplyMessage = null)
		{
			this.Name = Name;
			this.Url = Url;
			this.ReceivedMessage = ReceivedMessage;
			this.ReplyMessage = ReplyMessage;

		}



		/// <summary>
		/// The name of the message app.
		/// </summary>
		/// <value>The name of the message app.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Contains the data that is sent to the message app.
		/// </summary>
		/// <value>Contains the data that is sent to the message app.</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }



		/// <summary>
		/// The message displayed in the received message bubble.
		/// </summary>
		/// <value>The message displayed in the received message bubble.</value>
		[DataMember(Name = "receivedMessage", EmitDefaultValue = false)]
		public ConversationContentReceivedReplyMessage ReceivedMessage { get; set; }



		/// <summary>
		/// The message displayed in the reply message bubble.
		/// </summary>
		/// <value>The message displayed in the reply message bubble.</value>
		[DataMember(Name = "replyMessage", EmitDefaultValue = false)]
		public ConversationContentReceivedReplyMessage ReplyMessage { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentInteractiveApplication {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  ReceivedMessage: ").Append(ReceivedMessage).Append("\n");
			sb.Append("  ReplyMessage: ").Append(ReplyMessage).Append("\n");
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
			return this.Equals(obj as ConversationContentInteractiveApplication);
		}

		/// <summary>
		/// Returns true if ConversationContentInteractiveApplication instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentInteractiveApplication to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentInteractiveApplication other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
				) &&
				(
					this.ReceivedMessage == other.ReceivedMessage ||
					this.ReceivedMessage != null &&
					this.ReceivedMessage.Equals(other.ReceivedMessage)
				) &&
				(
					this.ReplyMessage == other.ReplyMessage ||
					this.ReplyMessage != null &&
					this.ReplyMessage.Equals(other.ReplyMessage)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				if (this.ReceivedMessage != null)
					hash = hash * 59 + this.ReceivedMessage.GetHashCode();

				if (this.ReplyMessage != null)
					hash = hash * 59 + this.ReplyMessage.GetHashCode();

				return hash;
			}
		}
	}

}
