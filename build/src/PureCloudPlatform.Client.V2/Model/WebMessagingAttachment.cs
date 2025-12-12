using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Attachment object.
	/// </summary>
	[DataContract]
	public partial class WebMessagingAttachment : IEquatable<WebMessagingAttachment>
	{
		/// <summary>
		/// The type of attachment this instance represents.
		/// </summary>
		/// <value>The type of attachment this instance represents.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum MediaTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Image for "Image"
			/// </summary>
			[EnumMember(Value = "Image")]
			Image,

			/// <summary>
			/// Enum Video for "Video"
			/// </summary>
			[EnumMember(Value = "Video")]
			Video,

			/// <summary>
			/// Enum Audio for "Audio"
			/// </summary>
			[EnumMember(Value = "Audio")]
			Audio,

			/// <summary>
			/// Enum File for "File"
			/// </summary>
			[EnumMember(Value = "File")]
			File,

			/// <summary>
			/// Enum Link for "Link"
			/// </summary>
			[EnumMember(Value = "Link")]
			Link
		}
		/// <summary>
		/// The type of attachment this instance represents.
		/// </summary>
		/// <value>The type of attachment this instance represents.</value>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public MediaTypeEnum? MediaType { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WebMessagingAttachment" /> class.
		/// </summary>
		public WebMessagingAttachment()
		{

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }





		/// <summary>
		/// URL of the attachment.
		/// </summary>
		/// <value>URL of the attachment.</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; private set; }



		/// <summary>
		/// Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).
		/// </summary>
		/// <value>Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).</value>
		[DataMember(Name = "mime", EmitDefaultValue = false)]
		public string Mime { get; private set; }



		/// <summary>
		/// Text associated with attachment such as an image caption.
		/// </summary>
		/// <value>Text associated with attachment such as an image caption.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; private set; }



		/// <summary>
		/// Secure hash of the attachment content.
		/// </summary>
		/// <value>Secure hash of the attachment content.</value>
		[DataMember(Name = "sha256", EmitDefaultValue = false)]
		public string Sha256 { get; private set; }



		/// <summary>
		/// Suggested file name for attachment.
		/// </summary>
		/// <value>Suggested file name for attachment.</value>
		[DataMember(Name = "filename", EmitDefaultValue = false)]
		public string Filename { get; private set; }



		/// <summary>
		/// The file size associated with the file
		/// </summary>
		/// <value>The file size associated with the file</value>
		[DataMember(Name = "fileSize", EmitDefaultValue = false)]
		public int? FileSize { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WebMessagingAttachment {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  Mime: ").Append(Mime).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Sha256: ").Append(Sha256).Append("\n");
			sb.Append("  Filename: ").Append(Filename).Append("\n");
			sb.Append("  FileSize: ").Append(FileSize).Append("\n");
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
			return this.Equals(obj as WebMessagingAttachment);
		}

		/// <summary>
		/// Returns true if WebMessagingAttachment instances are equal
		/// </summary>
		/// <param name="other">Instance of WebMessagingAttachment to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WebMessagingAttachment other)
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
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
				) &&
				(
					this.Mime == other.Mime ||
					this.Mime != null &&
					this.Mime.Equals(other.Mime)
				) &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.Sha256 == other.Sha256 ||
					this.Sha256 != null &&
					this.Sha256.Equals(other.Sha256)
				) &&
				(
					this.Filename == other.Filename ||
					this.Filename != null &&
					this.Filename.Equals(other.Filename)
				) &&
				(
					this.FileSize == other.FileSize ||
					this.FileSize != null &&
					this.FileSize.Equals(other.FileSize)
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

				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				if (this.Mime != null)
					hash = hash * 59 + this.Mime.GetHashCode();

				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.Sha256 != null)
					hash = hash * 59 + this.Sha256.GetHashCode();

				if (this.Filename != null)
					hash = hash * 59 + this.Filename.GetHashCode();

				if (this.FileSize != null)
					hash = hash * 59 + this.FileSize.GetHashCode();

				return hash;
			}
		}
	}

}
