using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeGuestDocumentPresentation
	/// </summary>
	[DataContract]
	public partial class KnowledgeGuestDocumentPresentation : IEquatable<KnowledgeGuestDocumentPresentation>
	{
		/// <summary>
		/// The type of the query that surfaced the documents.
		/// </summary>
		/// <value>The type of the query that surfaced the documents.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum QueryTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Article for "Article"
			/// </summary>
			[EnumMember(Value = "Article")]
			Article,

			/// <summary>
			/// Enum Autosearch for "AutoSearch"
			/// </summary>
			[EnumMember(Value = "AutoSearch")]
			Autosearch,

			/// <summary>
			/// Enum Category for "Category"
			/// </summary>
			[EnumMember(Value = "Category")]
			Category,

			/// <summary>
			/// Enum Manualsearch for "ManualSearch"
			/// </summary>
			[EnumMember(Value = "ManualSearch")]
			Manualsearch,

			/// <summary>
			/// Enum Recommendation for "Recommendation"
			/// </summary>
			[EnumMember(Value = "Recommendation")]
			Recommendation,

			/// <summary>
			/// Enum Suggestion for "Suggestion"
			/// </summary>
			[EnumMember(Value = "Suggestion")]
			Suggestion,

			/// <summary>
			/// Enum Expandedarticle for "ExpandedArticle"
			/// </summary>
			[EnumMember(Value = "ExpandedArticle")]
			Expandedarticle
		}
		/// <summary>
		/// The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown.
		/// </summary>
		/// <value>The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SurfacingMethodEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Article for "Article"
			/// </summary>
			[EnumMember(Value = "Article")]
			Article,

			/// <summary>
			/// Enum Snippet for "Snippet"
			/// </summary>
			[EnumMember(Value = "Snippet")]
			Snippet,

			/// <summary>
			/// Enum Highlight for "Highlight"
			/// </summary>
			[EnumMember(Value = "Highlight")]
			Highlight,

			/// <summary>
			/// Enum Generative for "Generative"
			/// </summary>
			[EnumMember(Value = "Generative")]
			Generative
		}
		/// <summary>
		/// The type of the query that surfaced the documents.
		/// </summary>
		/// <value>The type of the query that surfaced the documents.</value>
		[DataMember(Name = "queryType", EmitDefaultValue = false)]
		public QueryTypeEnum? QueryType { get; set; }
		/// <summary>
		/// The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown.
		/// </summary>
		/// <value>The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown.</value>
		[DataMember(Name = "surfacingMethod", EmitDefaultValue = false)]
		public SurfacingMethodEnum? SurfacingMethod { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeGuestDocumentPresentation" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected KnowledgeGuestDocumentPresentation() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeGuestDocumentPresentation" /> class.
		/// </summary>
		/// <param name="Documents">The presented documents (required).</param>
		/// <param name="SearchId">The search that surfaced the documents that were presented..</param>
		/// <param name="QueryType">The type of the query that surfaced the documents..</param>
		/// <param name="SurfacingMethod">The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown..</param>
		public KnowledgeGuestDocumentPresentation(List<PresentedKnowledgeDocument> Documents = null, string SearchId = null, QueryTypeEnum? QueryType = null, SurfacingMethodEnum? SurfacingMethod = null)
		{
			this.Documents = Documents;
			this.SearchId = SearchId;
			this.QueryType = QueryType;
			this.SurfacingMethod = SurfacingMethod;

		}



		/// <summary>
		/// The presented documents
		/// </summary>
		/// <value>The presented documents</value>
		[DataMember(Name = "documents", EmitDefaultValue = false)]
		public List<PresentedKnowledgeDocument> Documents { get; set; }



		/// <summary>
		/// The search that surfaced the documents that were presented.
		/// </summary>
		/// <value>The search that surfaced the documents that were presented.</value>
		[DataMember(Name = "searchId", EmitDefaultValue = false)]
		public string SearchId { get; set; }







		/// <summary>
		/// Knowledge session ID.
		/// </summary>
		/// <value>Knowledge session ID.</value>
		[DataMember(Name = "sessionId", EmitDefaultValue = false)]
		public string SessionId { get; private set; }



		/// <summary>
		/// The client application in which the documents were presented.
		/// </summary>
		/// <value>The client application in which the documents were presented.</value>
		[DataMember(Name = "application", EmitDefaultValue = false)]
		public KnowledgeGuestSearchClientApplication Application { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeGuestDocumentPresentation {\n");

			sb.Append("  Documents: ").Append(Documents).Append("\n");
			sb.Append("  SearchId: ").Append(SearchId).Append("\n");
			sb.Append("  QueryType: ").Append(QueryType).Append("\n");
			sb.Append("  SurfacingMethod: ").Append(SurfacingMethod).Append("\n");
			sb.Append("  SessionId: ").Append(SessionId).Append("\n");
			sb.Append("  Application: ").Append(Application).Append("\n");
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
			return this.Equals(obj as KnowledgeGuestDocumentPresentation);
		}

		/// <summary>
		/// Returns true if KnowledgeGuestDocumentPresentation instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeGuestDocumentPresentation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeGuestDocumentPresentation other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Documents == other.Documents ||
					this.Documents != null &&
					this.Documents.SequenceEqual(other.Documents)
				) &&
				(
					this.SearchId == other.SearchId ||
					this.SearchId != null &&
					this.SearchId.Equals(other.SearchId)
				) &&
				(
					this.QueryType == other.QueryType ||
					this.QueryType != null &&
					this.QueryType.Equals(other.QueryType)
				) &&
				(
					this.SurfacingMethod == other.SurfacingMethod ||
					this.SurfacingMethod != null &&
					this.SurfacingMethod.Equals(other.SurfacingMethod)
				) &&
				(
					this.SessionId == other.SessionId ||
					this.SessionId != null &&
					this.SessionId.Equals(other.SessionId)
				) &&
				(
					this.Application == other.Application ||
					this.Application != null &&
					this.Application.Equals(other.Application)
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
				if (this.Documents != null)
					hash = hash * 59 + this.Documents.GetHashCode();

				if (this.SearchId != null)
					hash = hash * 59 + this.SearchId.GetHashCode();

				if (this.QueryType != null)
					hash = hash * 59 + this.QueryType.GetHashCode();

				if (this.SurfacingMethod != null)
					hash = hash * 59 + this.SurfacingMethod.GetHashCode();

				if (this.SessionId != null)
					hash = hash * 59 + this.SessionId.GetHashCode();

				if (this.Application != null)
					hash = hash * 59 + this.Application.GetHashCode();

				return hash;
			}
		}
	}

}
