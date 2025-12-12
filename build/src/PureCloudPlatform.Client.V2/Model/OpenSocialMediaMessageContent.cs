using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Message content element.
	/// </summary>
	[DataContract]
	public partial class OpenSocialMediaMessageContent : IEquatable<OpenSocialMediaMessageContent>
	{
		/// <summary>
		/// Type of this content element.
		/// </summary>
		/// <value>Type of this content element.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ContentTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Attachment for "Attachment"
			/// </summary>
			[EnumMember(Value = "Attachment")]
			Attachment,

			/// <summary>
			/// Enum Reactions for "Reactions"
			/// </summary>
			[EnumMember(Value = "Reactions")]
			Reactions,

			/// <summary>
			/// Enum Text for "Text"
			/// </summary>
			[EnumMember(Value = "Text")]
			Text
		}
		/// <summary>
		/// Type of this content element.
		/// </summary>
		/// <value>Type of this content element.</value>
		[DataMember(Name = "contentType", EmitDefaultValue = false)]
		public ContentTypeEnum? ContentType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="OpenSocialMediaMessageContent" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected OpenSocialMediaMessageContent() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="OpenSocialMediaMessageContent" /> class.
		/// </summary>
		/// <param name="ContentType">Type of this content element. (required).</param>
		/// <param name="Attachment">Attachment content..</param>
		/// <param name="Text">A content type containing text..</param>
		/// <param name="Reaction">A set of reactions to a message..</param>
		public OpenSocialMediaMessageContent(ContentTypeEnum? ContentType = null, ConversationContentAttachment Attachment = null, ConversationContentText Text = null, ConversationContentReaction Reaction = null)
		{
			this.ContentType = ContentType;
			this.Attachment = Attachment;
			this.Text = Text;
			this.Reaction = Reaction;

		}





		/// <summary>
		/// Attachment content.
		/// </summary>
		/// <value>Attachment content.</value>
		[DataMember(Name = "attachment", EmitDefaultValue = false)]
		public ConversationContentAttachment Attachment { get; set; }



		/// <summary>
		/// A content type containing text.
		/// </summary>
		/// <value>A content type containing text.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public ConversationContentText Text { get; set; }



		/// <summary>
		/// A set of reactions to a message.
		/// </summary>
		/// <value>A set of reactions to a message.</value>
		[DataMember(Name = "reaction", EmitDefaultValue = false)]
		public ConversationContentReaction Reaction { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OpenSocialMediaMessageContent {\n");

			sb.Append("  ContentType: ").Append(ContentType).Append("\n");
			sb.Append("  Attachment: ").Append(Attachment).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Reaction: ").Append(Reaction).Append("\n");
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
			return this.Equals(obj as OpenSocialMediaMessageContent);
		}

		/// <summary>
		/// Returns true if OpenSocialMediaMessageContent instances are equal
		/// </summary>
		/// <param name="other">Instance of OpenSocialMediaMessageContent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OpenSocialMediaMessageContent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ContentType == other.ContentType ||
					this.ContentType != null &&
					this.ContentType.Equals(other.ContentType)
				) &&
				(
					this.Attachment == other.Attachment ||
					this.Attachment != null &&
					this.Attachment.Equals(other.Attachment)
				) &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.Reaction == other.Reaction ||
					this.Reaction != null &&
					this.Reaction.Equals(other.Reaction)
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
				if (this.ContentType != null)
					hash = hash * 59 + this.ContentType.GetHashCode();

				if (this.Attachment != null)
					hash = hash * 59 + this.Attachment.GetHashCode();

				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.Reaction != null)
					hash = hash * 59 + this.Reaction.GetHashCode();

				return hash;
			}
		}
	}

}
