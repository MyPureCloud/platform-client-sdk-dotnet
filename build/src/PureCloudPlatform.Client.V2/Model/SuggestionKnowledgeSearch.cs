using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SuggestionKnowledgeSearch
	/// </summary>
	[DataContract]
	public partial class SuggestionKnowledgeSearch : IEquatable<SuggestionKnowledgeSearch>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SuggestionKnowledgeSearch" /> class.
		/// </summary>
		public SuggestionKnowledgeSearch()
		{

		}



		/// <summary>
		/// The article title.
		/// </summary>
		/// <value>The article title.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; private set; }



		/// <summary>
		/// Snippets of text from the article matching the query.
		/// </summary>
		/// <value>Snippets of text from the article matching the query.</value>
		[DataMember(Name = "snippets", EmitDefaultValue = false)]
		public List<string> Snippets { get; private set; }



		/// <summary>
		/// Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all.
		/// </summary>
		/// <value>Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all.</value>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public float? Confidence { get; private set; }



		/// <summary>
		/// The search id.
		/// </summary>
		/// <value>The search id.</value>
		[DataMember(Name = "searchId", EmitDefaultValue = false)]
		public string SearchId { get; private set; }



		/// <summary>
		/// The article matching the query.
		/// </summary>
		/// <value>The article matching the query.</value>
		[DataMember(Name = "document", EmitDefaultValue = false)]
		public AddressableEntityRef Document { get; private set; }



		/// <summary>
		/// The version of the article.
		/// </summary>
		/// <value>The version of the article.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public AddressableEntityRef Version { get; private set; }



		/// <summary>
		/// The most relevant answer within a searched article for the searched query
		/// </summary>
		/// <value>The most relevant answer within a searched article for the searched query</value>
		[DataMember(Name = "knowledgeAnswer", EmitDefaultValue = false)]
		public SuggestionKnowledgeAnswer KnowledgeAnswer { get; private set; }



		/// <summary>
		/// Variations of the article.
		/// </summary>
		/// <value>Variations of the article.</value>
		[DataMember(Name = "variations", EmitDefaultValue = false)]
		public List<AddressableEntityRef> Variations { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SuggestionKnowledgeSearch {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Snippets: ").Append(Snippets).Append("\n");
			sb.Append("  Confidence: ").Append(Confidence).Append("\n");
			sb.Append("  SearchId: ").Append(SearchId).Append("\n");
			sb.Append("  Document: ").Append(Document).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  KnowledgeAnswer: ").Append(KnowledgeAnswer).Append("\n");
			sb.Append("  Variations: ").Append(Variations).Append("\n");
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
			return this.Equals(obj as SuggestionKnowledgeSearch);
		}

		/// <summary>
		/// Returns true if SuggestionKnowledgeSearch instances are equal
		/// </summary>
		/// <param name="other">Instance of SuggestionKnowledgeSearch to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SuggestionKnowledgeSearch other)
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
					this.Snippets == other.Snippets ||
					this.Snippets != null &&
					this.Snippets.SequenceEqual(other.Snippets)
				) &&
				(
					this.Confidence == other.Confidence ||
					this.Confidence != null &&
					this.Confidence.Equals(other.Confidence)
				) &&
				(
					this.SearchId == other.SearchId ||
					this.SearchId != null &&
					this.SearchId.Equals(other.SearchId)
				) &&
				(
					this.Document == other.Document ||
					this.Document != null &&
					this.Document.Equals(other.Document)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.KnowledgeAnswer == other.KnowledgeAnswer ||
					this.KnowledgeAnswer != null &&
					this.KnowledgeAnswer.Equals(other.KnowledgeAnswer)
				) &&
				(
					this.Variations == other.Variations ||
					this.Variations != null &&
					this.Variations.SequenceEqual(other.Variations)
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

				if (this.Snippets != null)
					hash = hash * 59 + this.Snippets.GetHashCode();

				if (this.Confidence != null)
					hash = hash * 59 + this.Confidence.GetHashCode();

				if (this.SearchId != null)
					hash = hash * 59 + this.SearchId.GetHashCode();

				if (this.Document != null)
					hash = hash * 59 + this.Document.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.KnowledgeAnswer != null)
					hash = hash * 59 + this.KnowledgeAnswer.GetHashCode();

				if (this.Variations != null)
					hash = hash * 59 + this.Variations.GetHashCode();

				return hash;
			}
		}
	}

}
