using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationEventTopicMessageSticker
	/// </summary>
	[DataContract]
	public partial class ConversationEventTopicMessageSticker : IEquatable<ConversationEventTopicMessageSticker>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEventTopicMessageSticker" /> class.
		/// </summary>
		/// <param name="Url">The location of the sticker, useful for retrieving it.</param>
		/// <param name="Id">The unique id of the the sticker object..</param>
		public ConversationEventTopicMessageSticker(string Url = null, string Id = null)
		{
			this.Url = Url;
			this.Id = Id;

		}



		/// <summary>
		/// The location of the sticker, useful for retrieving it
		/// </summary>
		/// <value>The location of the sticker, useful for retrieving it</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }



		/// <summary>
		/// The unique id of the the sticker object.
		/// </summary>
		/// <value>The unique id of the the sticker object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationEventTopicMessageSticker {\n");

			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
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
			return this.Equals(obj as ConversationEventTopicMessageSticker);
		}

		/// <summary>
		/// Returns true if ConversationEventTopicMessageSticker instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationEventTopicMessageSticker to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationEventTopicMessageSticker other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
				) &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
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
				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				return hash;
			}
		}
	}

}
