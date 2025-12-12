using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CallbackDisconnectIdentifier
	/// </summary>
	[DataContract]
	public partial class CallbackDisconnectIdentifier : IEquatable<CallbackDisconnectIdentifier>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CallbackDisconnectIdentifier" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CallbackDisconnectIdentifier() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CallbackDisconnectIdentifier" /> class.
		/// </summary>
		/// <param name="ConversationId">The Conversation Id. (required).</param>
		/// <param name="CallbackId">The callback id. (required).</param>
		public CallbackDisconnectIdentifier(string ConversationId = null, string CallbackId = null)
		{
			this.ConversationId = ConversationId;
			this.CallbackId = CallbackId;

		}



		/// <summary>
		/// The Conversation Id.
		/// </summary>
		/// <value>The Conversation Id.</value>
		[DataMember(Name = "conversationId", EmitDefaultValue = false)]
		public string ConversationId { get; set; }



		/// <summary>
		/// The callback id.
		/// </summary>
		/// <value>The callback id.</value>
		[DataMember(Name = "callbackId", EmitDefaultValue = false)]
		public string CallbackId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CallbackDisconnectIdentifier {\n");

			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  CallbackId: ").Append(CallbackId).Append("\n");
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
			return this.Equals(obj as CallbackDisconnectIdentifier);
		}

		/// <summary>
		/// Returns true if CallbackDisconnectIdentifier instances are equal
		/// </summary>
		/// <param name="other">Instance of CallbackDisconnectIdentifier to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CallbackDisconnectIdentifier other)
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
					this.CallbackId == other.CallbackId ||
					this.CallbackId != null &&
					this.CallbackId.Equals(other.CallbackId)
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

				if (this.CallbackId != null)
					hash = hash * 59 + this.CallbackId.GetHashCode();

				return hash;
			}
		}
	}

}
