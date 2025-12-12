using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeGuestDocumentSuggestionResult
	/// </summary>
	[DataContract]
	public partial class KnowledgeGuestDocumentSuggestionResult : IEquatable<KnowledgeGuestDocumentSuggestionResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeGuestDocumentSuggestionResult" /> class.
		/// </summary>
		/// <param name="MatchedPhrase">Matched phrase to the autocomplete suggestions query..</param>
		public KnowledgeGuestDocumentSuggestionResult(string MatchedPhrase = null)
		{
			this.MatchedPhrase = MatchedPhrase;

		}



		/// <summary>
		/// Matched phrase to the autocomplete suggestions query.
		/// </summary>
		/// <value>Matched phrase to the autocomplete suggestions query.</value>
		[DataMember(Name = "matchedPhrase", EmitDefaultValue = false)]
		public string MatchedPhrase { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeGuestDocumentSuggestionResult {\n");

			sb.Append("  MatchedPhrase: ").Append(MatchedPhrase).Append("\n");
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
			return this.Equals(obj as KnowledgeGuestDocumentSuggestionResult);
		}

		/// <summary>
		/// Returns true if KnowledgeGuestDocumentSuggestionResult instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeGuestDocumentSuggestionResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeGuestDocumentSuggestionResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MatchedPhrase == other.MatchedPhrase ||
					this.MatchedPhrase != null &&
					this.MatchedPhrase.Equals(other.MatchedPhrase)
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

				return hash;
			}
		}
	}

}
