using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationKnowledgeArticleSuggestionsTopicSuggestedArticle
	/// </summary>
	[DataContract]
	public partial class ConversationKnowledgeArticleSuggestionsTopicSuggestedArticle : IEquatable<ConversationKnowledgeArticleSuggestionsTopicSuggestedArticle>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationKnowledgeArticleSuggestionsTopicSuggestedArticle" /> class.
		/// </summary>
		/// <param name="Title">Title.</param>
		/// <param name="Uri">Uri.</param>
		/// <param name="Snippets">Snippets.</param>
		/// <param name="Metadata">Metadata.</param>
		/// <param name="DocumentId">DocumentId.</param>
		/// <param name="VersionId">VersionId.</param>
		/// <param name="VariationIds">VariationIds.</param>
		/// <param name="KnowledgeAnswer">KnowledgeAnswer.</param>
		public ConversationKnowledgeArticleSuggestionsTopicSuggestedArticle(string Title = null, string Uri = null, List<string> Snippets = null, Dictionary<string, string> Metadata = null, Guid? DocumentId = null, Guid? VersionId = null, List<Guid?> VariationIds = null, ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer KnowledgeAnswer = null)
		{
			this.Title = Title;
			this.Uri = Uri;
			this.Snippets = Snippets;
			this.Metadata = Metadata;
			this.DocumentId = DocumentId;
			this.VersionId = VersionId;
			this.VariationIds = VariationIds;
			this.KnowledgeAnswer = KnowledgeAnswer;

		}



		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Gets or Sets Uri
		/// </summary>
		[DataMember(Name = "uri", EmitDefaultValue = false)]
		public string Uri { get; set; }



		/// <summary>
		/// Gets or Sets Snippets
		/// </summary>
		[DataMember(Name = "snippets", EmitDefaultValue = false)]
		public List<string> Snippets { get; set; }



		/// <summary>
		/// Gets or Sets Metadata
		/// </summary>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public Dictionary<string, string> Metadata { get; set; }



		/// <summary>
		/// Gets or Sets DocumentId
		/// </summary>
		[DataMember(Name = "documentId", EmitDefaultValue = false)]
		public Guid? DocumentId { get; set; }



		/// <summary>
		/// Gets or Sets VersionId
		/// </summary>
		[DataMember(Name = "versionId", EmitDefaultValue = false)]
		public Guid? VersionId { get; set; }



		/// <summary>
		/// Gets or Sets VariationIds
		/// </summary>
		[DataMember(Name = "variationIds", EmitDefaultValue = false)]
		public List<Guid?> VariationIds { get; set; }



		/// <summary>
		/// Gets or Sets KnowledgeAnswer
		/// </summary>
		[DataMember(Name = "knowledgeAnswer", EmitDefaultValue = false)]
		public ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer KnowledgeAnswer { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationKnowledgeArticleSuggestionsTopicSuggestedArticle {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Uri: ").Append(Uri).Append("\n");
			sb.Append("  Snippets: ").Append(Snippets).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
			sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
			sb.Append("  VersionId: ").Append(VersionId).Append("\n");
			sb.Append("  VariationIds: ").Append(VariationIds).Append("\n");
			sb.Append("  KnowledgeAnswer: ").Append(KnowledgeAnswer).Append("\n");
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
			return this.Equals(obj as ConversationKnowledgeArticleSuggestionsTopicSuggestedArticle);
		}

		/// <summary>
		/// Returns true if ConversationKnowledgeArticleSuggestionsTopicSuggestedArticle instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationKnowledgeArticleSuggestionsTopicSuggestedArticle to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationKnowledgeArticleSuggestionsTopicSuggestedArticle other)
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
					this.Snippets == other.Snippets ||
					this.Snippets != null &&
					this.Snippets.SequenceEqual(other.Snippets)
				) &&
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.SequenceEqual(other.Metadata)
				) &&
				(
					this.DocumentId == other.DocumentId ||
					this.DocumentId != null &&
					this.DocumentId.Equals(other.DocumentId)
				) &&
				(
					this.VersionId == other.VersionId ||
					this.VersionId != null &&
					this.VersionId.Equals(other.VersionId)
				) &&
				(
					this.VariationIds == other.VariationIds ||
					this.VariationIds != null &&
					this.VariationIds.SequenceEqual(other.VariationIds)
				) &&
				(
					this.KnowledgeAnswer == other.KnowledgeAnswer ||
					this.KnowledgeAnswer != null &&
					this.KnowledgeAnswer.Equals(other.KnowledgeAnswer)
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

				if (this.Snippets != null)
					hash = hash * 59 + this.Snippets.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.DocumentId != null)
					hash = hash * 59 + this.DocumentId.GetHashCode();

				if (this.VersionId != null)
					hash = hash * 59 + this.VersionId.GetHashCode();

				if (this.VariationIds != null)
					hash = hash * 59 + this.VariationIds.GetHashCode();

				if (this.KnowledgeAnswer != null)
					hash = hash * 59 + this.KnowledgeAnswer.GetHashCode();

				return hash;
			}
		}
	}

}
