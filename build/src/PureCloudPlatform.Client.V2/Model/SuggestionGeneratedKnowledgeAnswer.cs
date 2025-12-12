using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SuggestionGeneratedKnowledgeAnswer
	/// </summary>
	[DataContract]
	public partial class SuggestionGeneratedKnowledgeAnswer : IEquatable<SuggestionGeneratedKnowledgeAnswer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SuggestionGeneratedKnowledgeAnswer" /> class.
		/// </summary>
		public SuggestionGeneratedKnowledgeAnswer()
		{

		}



		/// <summary>
		/// The search id.
		/// </summary>
		/// <value>The search id.</value>
		[DataMember(Name = "searchId", EmitDefaultValue = false)]
		public string SearchId { get; private set; }



		/// <summary>
		/// The knowledge answer generated.
		/// </summary>
		/// <value>The knowledge answer generated.</value>
		[DataMember(Name = "knowledgeAnswerGenerated", EmitDefaultValue = false)]
		public string KnowledgeAnswerGenerated { get; private set; }



		/// <summary>
		/// The suggested search chunks.
		/// </summary>
		/// <value>The suggested search chunks.</value>
		[DataMember(Name = "suggestedSearchChunks", EmitDefaultValue = false)]
		public List<SuggestedSearchChunk> SuggestedSearchChunks { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SuggestionGeneratedKnowledgeAnswer {\n");

			sb.Append("  SearchId: ").Append(SearchId).Append("\n");
			sb.Append("  KnowledgeAnswerGenerated: ").Append(KnowledgeAnswerGenerated).Append("\n");
			sb.Append("  SuggestedSearchChunks: ").Append(SuggestedSearchChunks).Append("\n");
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
			return this.Equals(obj as SuggestionGeneratedKnowledgeAnswer);
		}

		/// <summary>
		/// Returns true if SuggestionGeneratedKnowledgeAnswer instances are equal
		/// </summary>
		/// <param name="other">Instance of SuggestionGeneratedKnowledgeAnswer to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SuggestionGeneratedKnowledgeAnswer other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SearchId == other.SearchId ||
					this.SearchId != null &&
					this.SearchId.Equals(other.SearchId)
				) &&
				(
					this.KnowledgeAnswerGenerated == other.KnowledgeAnswerGenerated ||
					this.KnowledgeAnswerGenerated != null &&
					this.KnowledgeAnswerGenerated.Equals(other.KnowledgeAnswerGenerated)
				) &&
				(
					this.SuggestedSearchChunks == other.SuggestedSearchChunks ||
					this.SuggestedSearchChunks != null &&
					this.SuggestedSearchChunks.SequenceEqual(other.SuggestedSearchChunks)
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
				if (this.SearchId != null)
					hash = hash * 59 + this.SearchId.GetHashCode();

				if (this.KnowledgeAnswerGenerated != null)
					hash = hash * 59 + this.KnowledgeAnswerGenerated.GetHashCode();

				if (this.SuggestedSearchChunks != null)
					hash = hash * 59 + this.SuggestedSearchChunks.GetHashCode();

				return hash;
			}
		}
	}

}
