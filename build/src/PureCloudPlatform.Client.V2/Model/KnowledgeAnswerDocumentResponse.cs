using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeAnswerDocumentResponse
	/// </summary>
	[DataContract]
	public partial class KnowledgeAnswerDocumentResponse : IEquatable<KnowledgeAnswerDocumentResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeAnswerDocumentResponse" /> class.
		/// </summary>
		/// <param name="Id">The document id..</param>
		/// <param name="Title">The document title..</param>
		/// <param name="Answer">The answer found inside a variationContent..</param>
		/// <param name="Variation">The variation with the answer&#39;s highlight data..</param>
		public KnowledgeAnswerDocumentResponse(string Id = null, string Title = null, string Answer = null, DocumentVariationAnswer Variation = null)
		{
			this.Id = Id;
			this.Title = Title;
			this.Answer = Answer;
			this.Variation = Variation;

		}



		/// <summary>
		/// The document id.
		/// </summary>
		/// <value>The document id.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The document title.
		/// </summary>
		/// <value>The document title.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// The answer found inside a variationContent.
		/// </summary>
		/// <value>The answer found inside a variationContent.</value>
		[DataMember(Name = "answer", EmitDefaultValue = false)]
		public string Answer { get; set; }



		/// <summary>
		/// The variation with the answer&#39;s highlight data.
		/// </summary>
		/// <value>The variation with the answer&#39;s highlight data.</value>
		[DataMember(Name = "variation", EmitDefaultValue = false)]
		public DocumentVariationAnswer Variation { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeAnswerDocumentResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Answer: ").Append(Answer).Append("\n");
			sb.Append("  Variation: ").Append(Variation).Append("\n");
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
			return this.Equals(obj as KnowledgeAnswerDocumentResponse);
		}

		/// <summary>
		/// Returns true if KnowledgeAnswerDocumentResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeAnswerDocumentResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeAnswerDocumentResponse other)
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
					this.Answer == other.Answer ||
					this.Answer != null &&
					this.Answer.Equals(other.Answer)
				) &&
				(
					this.Variation == other.Variation ||
					this.Variation != null &&
					this.Variation.Equals(other.Variation)
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

				if (this.Answer != null)
					hash = hash * 59 + this.Answer.GetHashCode();

				if (this.Variation != null)
					hash = hash * 59 + this.Variation.GetHashCode();

				return hash;
			}
		}
	}

}
