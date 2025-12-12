using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SendMessageBody
	/// </summary>
	[DataContract]
	public partial class SendMessageBody : IEquatable<SendMessageBody>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SendMessageBody" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SendMessageBody() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SendMessageBody" /> class.
		/// </summary>
		/// <param name="Message">The body of the message (required).</param>
		/// <param name="Mentions">user ids to be notified.</param>
		/// <param name="ThreadId">The thread id of the message.</param>
		public SendMessageBody(string Message = null, List<string> Mentions = null, string ThreadId = null)
		{
			this.Message = Message;
			this.Mentions = Mentions;
			this.ThreadId = ThreadId;

		}



		/// <summary>
		/// The body of the message
		/// </summary>
		/// <value>The body of the message</value>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; set; }



		/// <summary>
		/// user ids to be notified
		/// </summary>
		/// <value>user ids to be notified</value>
		[DataMember(Name = "mentions", EmitDefaultValue = false)]
		public List<string> Mentions { get; set; }



		/// <summary>
		/// The thread id of the message
		/// </summary>
		/// <value>The thread id of the message</value>
		[DataMember(Name = "threadId", EmitDefaultValue = false)]
		public string ThreadId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SendMessageBody {\n");

			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("  Mentions: ").Append(Mentions).Append("\n");
			sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
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
			return this.Equals(obj as SendMessageBody);
		}

		/// <summary>
		/// Returns true if SendMessageBody instances are equal
		/// </summary>
		/// <param name="other">Instance of SendMessageBody to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SendMessageBody other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Message == other.Message ||
					this.Message != null &&
					this.Message.Equals(other.Message)
				) &&
				(
					this.Mentions == other.Mentions ||
					this.Mentions != null &&
					this.Mentions.SequenceEqual(other.Mentions)
				) &&
				(
					this.ThreadId == other.ThreadId ||
					this.ThreadId != null &&
					this.ThreadId.Equals(other.ThreadId)
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
				if (this.Message != null)
					hash = hash * 59 + this.Message.GetHashCode();

				if (this.Mentions != null)
					hash = hash * 59 + this.Mentions.GetHashCode();

				if (this.ThreadId != null)
					hash = hash * 59 + this.ThreadId.GetHashCode();

				return hash;
			}
		}
	}

}
