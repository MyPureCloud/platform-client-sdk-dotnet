using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Information about a public message.
	/// </summary>
	[DataContract]
	public partial class ConversationPublicMetadata : IEquatable<ConversationPublicMetadata>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationPublicMetadata" /> class.
		/// </summary>
		/// <param name="RootId">The id of the root public message..</param>
		/// <param name="ReplyToId">The id of the message this public message is replying to..</param>
		/// <param name="Url">The URL of the social post on the native platform..</param>
		public ConversationPublicMetadata(string RootId = null, string ReplyToId = null, string Url = null)
		{
			this.RootId = RootId;
			this.ReplyToId = ReplyToId;
			this.Url = Url;

		}



		/// <summary>
		/// The id of the root public message.
		/// </summary>
		/// <value>The id of the root public message.</value>
		[DataMember(Name = "rootId", EmitDefaultValue = false)]
		public string RootId { get; set; }



		/// <summary>
		/// The id of the message this public message is replying to.
		/// </summary>
		/// <value>The id of the message this public message is replying to.</value>
		[DataMember(Name = "replyToId", EmitDefaultValue = false)]
		public string ReplyToId { get; set; }



		/// <summary>
		/// The URL of the social post on the native platform.
		/// </summary>
		/// <value>The URL of the social post on the native platform.</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationPublicMetadata {\n");

			sb.Append("  RootId: ").Append(RootId).Append("\n");
			sb.Append("  ReplyToId: ").Append(ReplyToId).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
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
			return this.Equals(obj as ConversationPublicMetadata);
		}

		/// <summary>
		/// Returns true if ConversationPublicMetadata instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationPublicMetadata to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationPublicMetadata other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RootId == other.RootId ||
					this.RootId != null &&
					this.RootId.Equals(other.RootId)
				) &&
				(
					this.ReplyToId == other.ReplyToId ||
					this.ReplyToId != null &&
					this.ReplyToId.Equals(other.ReplyToId)
				) &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
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
				if (this.RootId != null)
					hash = hash * 59 + this.RootId.GetHashCode();

				if (this.ReplyToId != null)
					hash = hash * 59 + this.ReplyToId.GetHashCode();

				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				return hash;
			}
		}
	}

}
