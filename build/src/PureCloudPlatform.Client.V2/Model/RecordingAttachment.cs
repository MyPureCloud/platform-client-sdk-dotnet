using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RecordingAttachment
	/// </summary>
	[DataContract]
	public partial class RecordingAttachment : IEquatable<RecordingAttachment>
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
		public MediaTypeEnum? MediaType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingAttachment" /> class.
		/// </summary>
		/// <param name="MediaType">The type of attachment this instance represents..</param>
		/// <param name="Url">URL of the attachment..</param>
		/// <param name="Mime">Attachment mime type..</param>
		/// <param name="Text">Text associated with attachment such as an image caption..</param>
		/// <param name="FileName">Suggested file name for attachment..</param>
		public RecordingAttachment(MediaTypeEnum? MediaType = null, string Url = null, string Mime = null, string Text = null, string FileName = null)
		{
			this.MediaType = MediaType;
			this.Url = Url;
			this.Mime = Mime;
			this.Text = Text;
			this.FileName = FileName;

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
		public string Url { get; set; }



		/// <summary>
		/// Attachment mime type.
		/// </summary>
		/// <value>Attachment mime type.</value>
		[DataMember(Name = "mime", EmitDefaultValue = false)]
		public string Mime { get; set; }



		/// <summary>
		/// Text associated with attachment such as an image caption.
		/// </summary>
		/// <value>Text associated with attachment such as an image caption.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }



		/// <summary>
		/// Suggested file name for attachment.
		/// </summary>
		/// <value>Suggested file name for attachment.</value>
		[DataMember(Name = "fileName", EmitDefaultValue = false)]
		public string FileName { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecordingAttachment {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  Mime: ").Append(Mime).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  FileName: ").Append(FileName).Append("\n");
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
			return this.Equals(obj as RecordingAttachment);
		}

		/// <summary>
		/// Returns true if RecordingAttachment instances are equal
		/// </summary>
		/// <param name="other">Instance of RecordingAttachment to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecordingAttachment other)
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
					this.FileName == other.FileName ||
					this.FileName != null &&
					this.FileName.Equals(other.FileName)
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

				if (this.FileName != null)
					hash = hash * 59 + this.FileName.GetHashCode();

				return hash;
			}
		}
	}

}
