using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeDocumentSuggestionResult
	/// </summary>
	[DataContract]
	public partial class KnowledgeDocumentSuggestionResult : IEquatable<KnowledgeDocumentSuggestionResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeDocumentSuggestionResult" /> class.
		/// </summary>
		/// <param name="MatchedPhrase">Matched phrase to the autocomplete suggestions query..</param>
		/// <param name="Document">Document.</param>
		public KnowledgeDocumentSuggestionResult(string MatchedPhrase = null, KnowledgeDocumentSuggestionResultDocument Document = null)
		{
			this.MatchedPhrase = MatchedPhrase;
			this.Document = Document;

		}



		/// <summary>
		/// Matched phrase to the autocomplete suggestions query.
		/// </summary>
		/// <value>Matched phrase to the autocomplete suggestions query.</value>
		[DataMember(Name = "matchedPhrase", EmitDefaultValue = false)]
		public string MatchedPhrase { get; set; }



		/// <summary>
		/// Gets or Sets Document
		/// </summary>
		[DataMember(Name = "document", EmitDefaultValue = false)]
		public KnowledgeDocumentSuggestionResultDocument Document { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeDocumentSuggestionResult {\n");

			sb.Append("  MatchedPhrase: ").Append(MatchedPhrase).Append("\n");
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
			return this.Equals(obj as KnowledgeDocumentSuggestionResult);
		}

		/// <summary>
		/// Returns true if KnowledgeDocumentSuggestionResult instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeDocumentSuggestionResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeDocumentSuggestionResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MatchedPhrase == other.MatchedPhrase ||
					this.MatchedPhrase != null &&
					this.MatchedPhrase.Equals(other.MatchedPhrase)
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
				if (this.MatchedPhrase != null)
					hash = hash * 59 + this.MatchedPhrase.GetHashCode();

				if (this.Document != null)
					hash = hash * 59 + this.Document.GetHashCode();

				return hash;
			}
		}
	}

}
