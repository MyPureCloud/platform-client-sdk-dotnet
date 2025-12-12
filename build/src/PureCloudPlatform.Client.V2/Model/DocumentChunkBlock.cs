using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DocumentChunkBlock
	/// </summary>
	[DataContract]
	public partial class DocumentChunkBlock : IEquatable<DocumentChunkBlock>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentChunkBlock" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DocumentChunkBlock() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentChunkBlock" /> class.
		/// </summary>
		/// <param name="Id">The globally unique identifier for the chunk. (required).</param>
		/// <param name="Text">The chunk text associated with the variation. (required).</param>
		/// <param name="Confidence">The confidence associated with a chunk with respect to a search query..</param>
		/// <param name="Document">Reference to document associated with a chunk.</param>
		public DocumentChunkBlock(string Id = null, string Text = null, float? Confidence = null, DocumentChunkReference Document = null)
		{
			this.Id = Id;
			this.Text = Text;
			this.Confidence = Confidence;
			this.Document = Document;

		}



		/// <summary>
		/// The globally unique identifier for the chunk.
		/// </summary>
		/// <value>The globally unique identifier for the chunk.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The chunk text associated with the variation.
		/// </summary>
		/// <value>The chunk text associated with the variation.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }



		/// <summary>
		/// The confidence associated with a chunk with respect to a search query.
		/// </summary>
		/// <value>The confidence associated with a chunk with respect to a search query.</value>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public float? Confidence { get; set; }



		/// <summary>
		/// Reference to document associated with a chunk
		/// </summary>
		/// <value>Reference to document associated with a chunk</value>
		[DataMember(Name = "document", EmitDefaultValue = false)]
		public DocumentChunkReference Document { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentChunkBlock {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
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
			return this.Equals(obj as DocumentChunkBlock);
		}

		/// <summary>
		/// Returns true if DocumentChunkBlock instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentChunkBlock to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentChunkBlock other)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

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
