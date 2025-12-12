using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeDocumentCreateRequest
	/// </summary>
	[DataContract]
	public partial class KnowledgeDocumentCreateRequest : IEquatable<KnowledgeDocumentCreateRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeDocumentCreateRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected KnowledgeDocumentCreateRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeDocumentCreateRequest" /> class.
		/// </summary>
		/// <param name="Title">Document title. (required).</param>
		/// <param name="Visible">Indicates if the knowledge document should be included in search results..</param>
		/// <param name="Alternatives">List of alternate phrases related to the title which improves search results..</param>
		/// <param name="CategoryId">The category associated with the document..</param>
		/// <param name="LabelIds">The ids of labels associated with the document..</param>
		/// <param name="ExternalId">The external id associated with the document..</param>
		/// <param name="ExternalUrl">The URL to external document..</param>
		public KnowledgeDocumentCreateRequest(string Title = null, bool? Visible = null, List<KnowledgeDocumentAlternative> Alternatives = null, string CategoryId = null, List<string> LabelIds = null, string ExternalId = null, string ExternalUrl = null)
		{
			this.Title = Title;
			this.Visible = Visible;
			this.Alternatives = Alternatives;
			this.CategoryId = CategoryId;
			this.LabelIds = LabelIds;
			this.ExternalId = ExternalId;
			this.ExternalUrl = ExternalUrl;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Document title.
		/// </summary>
		/// <value>Document title.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Indicates if the knowledge document should be included in search results.
		/// </summary>
		/// <value>Indicates if the knowledge document should be included in search results.</value>
		[DataMember(Name = "visible", EmitDefaultValue = false)]
		public bool? Visible { get; set; }



		/// <summary>
		/// List of alternate phrases related to the title which improves search results.
		/// </summary>
		/// <value>List of alternate phrases related to the title which improves search results.</value>
		[DataMember(Name = "alternatives", EmitDefaultValue = false)]
		public List<KnowledgeDocumentAlternative> Alternatives { get; set; }



		/// <summary>
		/// The category associated with the document.
		/// </summary>
		/// <value>The category associated with the document.</value>
		[DataMember(Name = "categoryId", EmitDefaultValue = false)]
		public string CategoryId { get; set; }



		/// <summary>
		/// The ids of labels associated with the document.
		/// </summary>
		/// <value>The ids of labels associated with the document.</value>
		[DataMember(Name = "labelIds", EmitDefaultValue = false)]
		public List<string> LabelIds { get; set; }



		/// <summary>
		/// The external id associated with the document.
		/// </summary>
		/// <value>The external id associated with the document.</value>
		[DataMember(Name = "externalId", EmitDefaultValue = false)]
		public string ExternalId { get; set; }



		/// <summary>
		/// The URL to external document.
		/// </summary>
		/// <value>The URL to external document.</value>
		[DataMember(Name = "externalUrl", EmitDefaultValue = false)]
		public string ExternalUrl { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeDocumentCreateRequest {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Visible: ").Append(Visible).Append("\n");
			sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
			sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
			sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
			sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
			sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as KnowledgeDocumentCreateRequest);
		}

		/// <summary>
		/// Returns true if KnowledgeDocumentCreateRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeDocumentCreateRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeDocumentCreateRequest other)
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
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Visible == other.Visible ||
					this.Visible != null &&
					this.Visible.Equals(other.Visible)
				) &&
				(
					this.Alternatives == other.Alternatives ||
					this.Alternatives != null &&
					this.Alternatives.SequenceEqual(other.Alternatives)
				) &&
				(
					this.CategoryId == other.CategoryId ||
					this.CategoryId != null &&
					this.CategoryId.Equals(other.CategoryId)
				) &&
				(
					this.LabelIds == other.LabelIds ||
					this.LabelIds != null &&
					this.LabelIds.SequenceEqual(other.LabelIds)
				) &&
				(
					this.ExternalId == other.ExternalId ||
					this.ExternalId != null &&
					this.ExternalId.Equals(other.ExternalId)
				) &&
				(
					this.ExternalUrl == other.ExternalUrl ||
					this.ExternalUrl != null &&
					this.ExternalUrl.Equals(other.ExternalUrl)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Visible != null)
					hash = hash * 59 + this.Visible.GetHashCode();

				if (this.Alternatives != null)
					hash = hash * 59 + this.Alternatives.GetHashCode();

				if (this.CategoryId != null)
					hash = hash * 59 + this.CategoryId.GetHashCode();

				if (this.LabelIds != null)
					hash = hash * 59 + this.LabelIds.GetHashCode();

				if (this.ExternalId != null)
					hash = hash * 59 + this.ExternalId.GetHashCode();

				if (this.ExternalUrl != null)
					hash = hash * 59 + this.ExternalUrl.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
