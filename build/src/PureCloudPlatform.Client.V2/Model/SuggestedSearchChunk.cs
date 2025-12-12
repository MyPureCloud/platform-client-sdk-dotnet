using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SuggestedSearchChunk
	/// </summary>
	[DataContract]
	public partial class SuggestedSearchChunk : IEquatable<SuggestedSearchChunk>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SuggestedSearchChunk" /> class.
		/// </summary>
		public SuggestedSearchChunk()
		{

		}



		/// <summary>
		/// The document title.
		/// </summary>
		/// <value>The document title.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; private set; }



		/// <summary>
		/// The document uri.
		/// </summary>
		/// <value>The document uri.</value>
		[DataMember(Name = "uri", EmitDefaultValue = false)]
		public string Uri { get; private set; }



		/// <summary>
		/// The chunk ID.
		/// </summary>
		/// <value>The chunk ID.</value>
		[DataMember(Name = "chunkId", EmitDefaultValue = false)]
		public string ChunkId { get; private set; }



		/// <summary>
		/// The text of the knowledge chunk.
		/// </summary>
		/// <value>The text of the knowledge chunk.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; private set; }



		/// <summary>
		/// Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all.
		/// </summary>
		/// <value>Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all.</value>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public float? Confidence { get; private set; }



		/// <summary>
		/// The article.
		/// </summary>
		/// <value>The article.</value>
		[DataMember(Name = "document", EmitDefaultValue = false)]
		public AddressableEntityRef Document { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SuggestedSearchChunk {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Uri: ").Append(Uri).Append("\n");
			sb.Append("  ChunkId: ").Append(ChunkId).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Confidence: ").Append(Confidence).Append("\n");
			sb.Append("  Document: ").Append(Document).Append("\n");
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
			return this.Equals(obj as SuggestedSearchChunk);
		}

		/// <summary>
		/// Returns true if SuggestedSearchChunk instances are equal
		/// </summary>
		/// <param name="other">Instance of SuggestedSearchChunk to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SuggestedSearchChunk other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Uri == other.Uri ||
					this.Uri != null &&
					this.Uri.Equals(other.Uri)
				) &&
				(
					this.ChunkId == other.ChunkId ||
					this.ChunkId != null &&
					this.ChunkId.Equals(other.ChunkId)
				) &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.Confidence == other.Confidence ||
					this.Confidence != null &&
					this.Confidence.Equals(other.Confidence)
				) &&
				(
					this.Document == other.Document ||
					this.Document != null &&
					this.Document.Equals(other.Document)
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
				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Uri != null)
					hash = hash * 59 + this.Uri.GetHashCode();

				if (this.ChunkId != null)
					hash = hash * 59 + this.ChunkId.GetHashCode();

				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.Confidence != null)
					hash = hash * 59 + this.Confidence.GetHashCode();

				if (this.Document != null)
					hash = hash * 59 + this.Document.GetHashCode();

				return hash;
			}
		}
	}

}
