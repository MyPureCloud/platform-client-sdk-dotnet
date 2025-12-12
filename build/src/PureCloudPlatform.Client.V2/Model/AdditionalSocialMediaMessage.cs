using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AdditionalSocialMediaMessage
	/// </summary>
	[DataContract]
	public partial class AdditionalSocialMediaMessage : IEquatable<AdditionalSocialMediaMessage>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AdditionalSocialMediaMessage" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AdditionalSocialMediaMessage() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AdditionalSocialMediaMessage" /> class.
		/// </summary>
		/// <param name="TextBody">The body of the text message.  Maximum character count is 2000 characters..</param>
		/// <param name="MediaIds">The media ids associated with the text message. See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage..</param>
		/// <param name="InReplyToMessageId">The ID of the message to which this request is replying. (required).</param>
		public AdditionalSocialMediaMessage(string TextBody = null, List<string> MediaIds = null, string InReplyToMessageId = null)
		{
			this.TextBody = TextBody;
			this.MediaIds = MediaIds;
			this.InReplyToMessageId = InReplyToMessageId;

		}



		/// <summary>
		/// The body of the text message.  Maximum character count is 2000 characters.
		/// </summary>
		/// <value>The body of the text message.  Maximum character count is 2000 characters.</value>
		[DataMember(Name = "textBody", EmitDefaultValue = false)]
		public string TextBody { get; set; }



		/// <summary>
		/// The media ids associated with the text message. See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage.
		/// </summary>
		/// <value>The media ids associated with the text message. See https://developer.genesys.cloud/api/rest/v2/conversations/messaging-media-upload for example usage.</value>
		[DataMember(Name = "mediaIds", EmitDefaultValue = false)]
		public List<string> MediaIds { get; set; }



		/// <summary>
		/// The ID of the message to which this request is replying.
		/// </summary>
		/// <value>The ID of the message to which this request is replying.</value>
		[DataMember(Name = "inReplyToMessageId", EmitDefaultValue = false)]
		public string InReplyToMessageId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AdditionalSocialMediaMessage {\n");

			sb.Append("  TextBody: ").Append(TextBody).Append("\n");
			sb.Append("  MediaIds: ").Append(MediaIds).Append("\n");
			sb.Append("  InReplyToMessageId: ").Append(InReplyToMessageId).Append("\n");
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
			return this.Equals(obj as AdditionalSocialMediaMessage);
		}

		/// <summary>
		/// Returns true if AdditionalSocialMediaMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of AdditionalSocialMediaMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AdditionalSocialMediaMessage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TextBody == other.TextBody ||
					this.TextBody != null &&
					this.TextBody.Equals(other.TextBody)
				) &&
				(
					this.MediaIds == other.MediaIds ||
					this.MediaIds != null &&
					this.MediaIds.SequenceEqual(other.MediaIds)
				) &&
				(
					this.InReplyToMessageId == other.InReplyToMessageId ||
					this.InReplyToMessageId != null &&
					this.InReplyToMessageId.Equals(other.InReplyToMessageId)
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
				if (this.TextBody != null)
					hash = hash * 59 + this.TextBody.GetHashCode();

				if (this.MediaIds != null)
					hash = hash * 59 + this.MediaIds.GetHashCode();

				if (this.InReplyToMessageId != null)
					hash = hash * 59 + this.InReplyToMessageId.GetHashCode();

				return hash;
			}
		}
	}

}
