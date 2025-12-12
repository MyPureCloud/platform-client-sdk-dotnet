using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PresentedKnowledgeDocument
	/// </summary>
	[DataContract]
	public partial class PresentedKnowledgeDocument : IEquatable<PresentedKnowledgeDocument>
	{
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
		/// The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown.
		/// </summary>
		/// <value>The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown.</value>
		[DataMember(Name = "surfacingMethod", EmitDefaultValue = false)]
		public SurfacingMethodEnum? SurfacingMethod { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="PresentedKnowledgeDocument" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected PresentedKnowledgeDocument() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="PresentedKnowledgeDocument" /> class.
		/// </summary>
		/// <param name="DocumentId">The ID of the document. (required).</param>
		/// <param name="DocumentVariationId">The variation of the document. (required).</param>
		/// <param name="DocumentVersionId">The version of the document. (required).</param>
		/// <param name="SurfacingMethod">The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown..</param>
		public PresentedKnowledgeDocument(string DocumentId = null, string DocumentVariationId = null, string DocumentVersionId = null, SurfacingMethodEnum? SurfacingMethod = null)
		{
			this.DocumentId = DocumentId;
			this.DocumentVariationId = DocumentVariationId;
			this.DocumentVersionId = DocumentVersionId;
			this.SurfacingMethod = SurfacingMethod;

		}



		/// <summary>
		/// The ID of the document.
		/// </summary>
		/// <value>The ID of the document.</value>
		[DataMember(Name = "documentId", EmitDefaultValue = false)]
		public string DocumentId { get; set; }



		/// <summary>
		/// The variation of the document.
		/// </summary>
		/// <value>The variation of the document.</value>
		[DataMember(Name = "documentVariationId", EmitDefaultValue = false)]
		public string DocumentVariationId { get; set; }



		/// <summary>
		/// The version of the document.
		/// </summary>
		/// <value>The version of the document.</value>
		[DataMember(Name = "documentVersionId", EmitDefaultValue = false)]
		public string DocumentVersionId { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PresentedKnowledgeDocument {\n");

			sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
			sb.Append("  DocumentVariationId: ").Append(DocumentVariationId).Append("\n");
			sb.Append("  DocumentVersionId: ").Append(DocumentVersionId).Append("\n");
			sb.Append("  SurfacingMethod: ").Append(SurfacingMethod).Append("\n");
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
			return this.Equals(obj as PresentedKnowledgeDocument);
		}

		/// <summary>
		/// Returns true if PresentedKnowledgeDocument instances are equal
		/// </summary>
		/// <param name="other">Instance of PresentedKnowledgeDocument to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PresentedKnowledgeDocument other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DocumentId == other.DocumentId ||
					this.DocumentId != null &&
					this.DocumentId.Equals(other.DocumentId)
				) &&
				(
					this.DocumentVariationId == other.DocumentVariationId ||
					this.DocumentVariationId != null &&
					this.DocumentVariationId.Equals(other.DocumentVariationId)
				) &&
				(
					this.DocumentVersionId == other.DocumentVersionId ||
					this.DocumentVersionId != null &&
					this.DocumentVersionId.Equals(other.DocumentVersionId)
				) &&
				(
					this.SurfacingMethod == other.SurfacingMethod ||
					this.SurfacingMethod != null &&
					this.SurfacingMethod.Equals(other.SurfacingMethod)
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
				if (this.DocumentId != null)
					hash = hash * 59 + this.DocumentId.GetHashCode();

				if (this.DocumentVariationId != null)
					hash = hash * 59 + this.DocumentVariationId.GetHashCode();

				if (this.DocumentVersionId != null)
					hash = hash * 59 + this.DocumentVersionId.GetHashCode();

				if (this.SurfacingMethod != null)
					hash = hash * 59 + this.SurfacingMethod.GetHashCode();

				return hash;
			}
		}
	}

}
