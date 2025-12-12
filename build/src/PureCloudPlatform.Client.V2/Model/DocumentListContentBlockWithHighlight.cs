using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DocumentListContentBlockWithHighlight
	/// </summary>
	[DataContract]
	public partial class DocumentListContentBlockWithHighlight : IEquatable<DocumentListContentBlockWithHighlight>
	{
		/// <summary>
		/// The type of the list block.
		/// </summary>
		/// <value>The type of the list block.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Text for "Text"
			/// </summary>
			[EnumMember(Value = "Text")]
			Text,

			/// <summary>
			/// Enum Image for "Image"
			/// </summary>
			[EnumMember(Value = "Image")]
			Image,

			/// <summary>
			/// Enum Orderedlist for "OrderedList"
			/// </summary>
			[EnumMember(Value = "OrderedList")]
			Orderedlist,

			/// <summary>
			/// Enum Unorderedlist for "UnorderedList"
			/// </summary>
			[EnumMember(Value = "UnorderedList")]
			Unorderedlist,

			/// <summary>
			/// Enum Video for "Video"
			/// </summary>
			[EnumMember(Value = "Video")]
			Video
		}
		/// <summary>
		/// The type of the list block.
		/// </summary>
		/// <value>The type of the list block.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentListContentBlockWithHighlight" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DocumentListContentBlockWithHighlight() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentListContentBlockWithHighlight" /> class.
		/// </summary>
		/// <param name="Type">The type of the list block. (required).</param>
		/// <param name="Text">Text. It must contain a value if the type of the block is Text..</param>
		/// <param name="Image">Image. It must contain a value if the type of the block is Image..</param>
		/// <param name="Video">Video. It must contain a value if the type of the block is Video..</param>
		/// <param name="List">List. It must contain a value if the type of the block is UnorderedList or OrderedList..</param>
		/// <param name="AnswerHighlight">The block highlight data..</param>
		public DocumentListContentBlockWithHighlight(TypeEnum? Type = null, DocumentText Text = null, DocumentBodyImage Image = null, DocumentBodyVideo Video = null, DocumentBodyListWithHighlight List = null, DocumentContentHighlightIndex AnswerHighlight = null)
		{
			this.Type = Type;
			this.Text = Text;
			this.Image = Image;
			this.Video = Video;
			this.List = List;
			this.AnswerHighlight = AnswerHighlight;

		}





		/// <summary>
		/// Text. It must contain a value if the type of the block is Text.
		/// </summary>
		/// <value>Text. It must contain a value if the type of the block is Text.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public DocumentText Text { get; set; }



		/// <summary>
		/// Image. It must contain a value if the type of the block is Image.
		/// </summary>
		/// <value>Image. It must contain a value if the type of the block is Image.</value>
		[DataMember(Name = "image", EmitDefaultValue = false)]
		public DocumentBodyImage Image { get; set; }



		/// <summary>
		/// Video. It must contain a value if the type of the block is Video.
		/// </summary>
		/// <value>Video. It must contain a value if the type of the block is Video.</value>
		[DataMember(Name = "video", EmitDefaultValue = false)]
		public DocumentBodyVideo Video { get; set; }



		/// <summary>
		/// List. It must contain a value if the type of the block is UnorderedList or OrderedList.
		/// </summary>
		/// <value>List. It must contain a value if the type of the block is UnorderedList or OrderedList.</value>
		[DataMember(Name = "list", EmitDefaultValue = false)]
		public DocumentBodyListWithHighlight List { get; set; }



		/// <summary>
		/// The block highlight data.
		/// </summary>
		/// <value>The block highlight data.</value>
		[DataMember(Name = "answerHighlight", EmitDefaultValue = false)]
		public DocumentContentHighlightIndex AnswerHighlight { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentListContentBlockWithHighlight {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Image: ").Append(Image).Append("\n");
			sb.Append("  Video: ").Append(Video).Append("\n");
			sb.Append("  List: ").Append(List).Append("\n");
			sb.Append("  AnswerHighlight: ").Append(AnswerHighlight).Append("\n");
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
			return this.Equals(obj as DocumentListContentBlockWithHighlight);
		}

		/// <summary>
		/// Returns true if DocumentListContentBlockWithHighlight instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentListContentBlockWithHighlight to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentListContentBlockWithHighlight other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.Image == other.Image ||
					this.Image != null &&
					this.Image.Equals(other.Image)
				) &&
				(
					this.Video == other.Video ||
					this.Video != null &&
					this.Video.Equals(other.Video)
				) &&
				(
					this.List == other.List ||
					this.List != null &&
					this.List.Equals(other.List)
				) &&
				(
					this.AnswerHighlight == other.AnswerHighlight ||
					this.AnswerHighlight != null &&
					this.AnswerHighlight.Equals(other.AnswerHighlight)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.Image != null)
					hash = hash * 59 + this.Image.GetHashCode();

				if (this.Video != null)
					hash = hash * 59 + this.Video.GetHashCode();

				if (this.List != null)
					hash = hash * 59 + this.List.GetHashCode();

				if (this.AnswerHighlight != null)
					hash = hash * 59 + this.AnswerHighlight.GetHashCode();

				return hash;
			}
		}
	}

}
