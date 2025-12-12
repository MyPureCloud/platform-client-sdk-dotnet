using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeDocumentSuggestion
	/// </summary>
	[DataContract]
	public partial class KnowledgeDocumentSuggestion : IEquatable<KnowledgeDocumentSuggestion>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeDocumentSuggestion" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected KnowledgeDocumentSuggestion() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeDocumentSuggestion" /> class.
		/// </summary>
		/// <param name="Query">Query to get autocomplete suggestions for the matching knowledge documents. (required).</param>
		/// <param name="PageSize">Page size of the returned results..</param>
		public KnowledgeDocumentSuggestion(string Query = null, int? PageSize = null)
		{
			this.Query = Query;
			this.PageSize = PageSize;

		}



		/// <summary>
		/// Query to get autocomplete suggestions for the matching knowledge documents.
		/// </summary>
		/// <value>Query to get autocomplete suggestions for the matching knowledge documents.</value>
		[DataMember(Name = "query", EmitDefaultValue = false)]
		public string Query { get; set; }



		/// <summary>
		/// Page size of the returned results.
		/// </summary>
		/// <value>Page size of the returned results.</value>
		[DataMember(Name = "pageSize", EmitDefaultValue = false)]
		public int? PageSize { get; set; }



		/// <summary>
		/// Documents matching to the autocomplete suggestions query.
		/// </summary>
		/// <value>Documents matching to the autocomplete suggestions query.</value>
		[DataMember(Name = "results", EmitDefaultValue = false)]
		public List<KnowledgeDocumentSuggestionResult> Results { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeDocumentSuggestion {\n");

			sb.Append("  Query: ").Append(Query).Append("\n");
			sb.Append("  PageSize: ").Append(PageSize).Append("\n");
			sb.Append("  Results: ").Append(Results).Append("\n");
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
			return this.Equals(obj as KnowledgeDocumentSuggestion);
		}

		/// <summary>
		/// Returns true if KnowledgeDocumentSuggestion instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeDocumentSuggestion to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeDocumentSuggestion other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Query == other.Query ||
					this.Query != null &&
					this.Query.Equals(other.Query)
				) &&
				(
					this.PageSize == other.PageSize ||
					this.PageSize != null &&
					this.PageSize.Equals(other.PageSize)
				) &&
				(
					this.Results == other.Results ||
					this.Results != null &&
					this.Results.SequenceEqual(other.Results)
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
				if (this.Query != null)
					hash = hash * 59 + this.Query.GetHashCode();

				if (this.PageSize != null)
					hash = hash * 59 + this.PageSize.GetHashCode();

				if (this.Results != null)
					hash = hash * 59 + this.Results.GetHashCode();

				return hash;
			}
		}
	}

}
