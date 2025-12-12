using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Faq
	/// </summary>
	[DataContract]
	public partial class Faq : IEquatable<Faq>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Faq" /> class.
		/// </summary>
		public Faq()
		{

		}



		/// <summary>
		/// Question from the knowledge base that was matched to user request.
		/// </summary>
		/// <value>Question from the knowledge base that was matched to user request.</value>
		[DataMember(Name = "question", EmitDefaultValue = false)]
		public string Question { get; private set; }



		/// <summary>
		/// Answer from the knowledge base corresponding to the identified question.
		/// </summary>
		/// <value>Answer from the knowledge base corresponding to the identified question.</value>
		[DataMember(Name = "answer", EmitDefaultValue = false)]
		public string Answer { get; private set; }



		/// <summary>
		/// A URI uniquely identifying the document, e.g. projects/acme-inc/knowledgeBases/MTAyNjgxNDU1Nzc3NTM1NzU0MjQ/documents/MTI5ODc3NzQzOTQ5MTc5NzgxMTI.
		/// </summary>
		/// <value>A URI uniquely identifying the document, e.g. projects/acme-inc/knowledgeBases/MTAyNjgxNDU1Nzc3NTM1NzU0MjQ/documents/MTI5ODc3NzQzOTQ5MTc5NzgxMTI.</value>
		[DataMember(Name = "sourceUri", EmitDefaultValue = false)]
		public string SourceUri { get; private set; }



		/// <summary>
		/// URL pointing to a web page if document was sourced from a URL.
		/// </summary>
		/// <value>URL pointing to a web page if document was sourced from a URL.</value>
		[DataMember(Name = "documentUrl", EmitDefaultValue = false)]
		public string DocumentUrl { get; private set; }



		/// <summary>
		/// A human-readable description of the document, e.g. &#39;Sample store FAQ&#39;
		/// </summary>
		/// <value>A human-readable description of the document, e.g. &#39;Sample store FAQ&#39;</value>
		[DataMember(Name = "documentDisplayName", EmitDefaultValue = false)]
		public string DocumentDisplayName { get; private set; }



		/// <summary>
		/// Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all
		/// </summary>
		/// <value>Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all</value>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public float? Confidence { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Faq {\n");

			sb.Append("  Question: ").Append(Question).Append("\n");
			sb.Append("  Answer: ").Append(Answer).Append("\n");
			sb.Append("  SourceUri: ").Append(SourceUri).Append("\n");
			sb.Append("  DocumentUrl: ").Append(DocumentUrl).Append("\n");
			sb.Append("  DocumentDisplayName: ").Append(DocumentDisplayName).Append("\n");
			sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
			return this.Equals(obj as Faq);
		}

		/// <summary>
		/// Returns true if Faq instances are equal
		/// </summary>
		/// <param name="other">Instance of Faq to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Faq other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Question == other.Question ||
					this.Question != null &&
					this.Question.Equals(other.Question)
				) &&
				(
					this.Answer == other.Answer ||
					this.Answer != null &&
					this.Answer.Equals(other.Answer)
				) &&
				(
					this.SourceUri == other.SourceUri ||
					this.SourceUri != null &&
					this.SourceUri.Equals(other.SourceUri)
				) &&
				(
					this.DocumentUrl == other.DocumentUrl ||
					this.DocumentUrl != null &&
					this.DocumentUrl.Equals(other.DocumentUrl)
				) &&
				(
					this.DocumentDisplayName == other.DocumentDisplayName ||
					this.DocumentDisplayName != null &&
					this.DocumentDisplayName.Equals(other.DocumentDisplayName)
				) &&
				(
					this.Confidence == other.Confidence ||
					this.Confidence != null &&
					this.Confidence.Equals(other.Confidence)
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
				if (this.Question != null)
					hash = hash * 59 + this.Question.GetHashCode();

				if (this.Answer != null)
					hash = hash * 59 + this.Answer.GetHashCode();

				if (this.SourceUri != null)
					hash = hash * 59 + this.SourceUri.GetHashCode();

				if (this.DocumentUrl != null)
					hash = hash * 59 + this.DocumentUrl.GetHashCode();

				if (this.DocumentDisplayName != null)
					hash = hash * 59 + this.DocumentDisplayName.GetHashCode();

				if (this.Confidence != null)
					hash = hash * 59 + this.Confidence.GetHashCode();

				return hash;
			}
		}
	}

}
