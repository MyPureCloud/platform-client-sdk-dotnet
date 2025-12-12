using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeDocumentReference
	/// </summary>
	[DataContract]
	public partial class KnowledgeDocumentReference : IEquatable<KnowledgeDocumentReference>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeDocumentReference" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected KnowledgeDocumentReference() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeDocumentReference" /> class.
		/// </summary>
		/// <param name="Id">The globally unique identifier for the document. (required).</param>
		/// <param name="KnowledgeBase">The knowledge base that the document belongs to. (required).</param>
		public KnowledgeDocumentReference(string Id = null, KnowledgeBaseReference KnowledgeBase = null)
		{
			this.Id = Id;
			this.KnowledgeBase = KnowledgeBase;

		}



		/// <summary>
		/// The globally unique identifier for the document.
		/// </summary>
		/// <value>The globally unique identifier for the document.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The knowledge base that the document belongs to.
		/// </summary>
		/// <value>The knowledge base that the document belongs to.</value>
		[DataMember(Name = "knowledgeBase", EmitDefaultValue = false)]
		public KnowledgeBaseReference KnowledgeBase { get; set; }



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
			sb.Append("class KnowledgeDocumentReference {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
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
			return this.Equals(obj as KnowledgeDocumentReference);
		}

		/// <summary>
		/// Returns true if KnowledgeDocumentReference instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeDocumentReference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeDocumentReference other)
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
					this.KnowledgeBase == other.KnowledgeBase ||
					this.KnowledgeBase != null &&
					this.KnowledgeBase.Equals(other.KnowledgeBase)
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

				if (this.KnowledgeBase != null)
					hash = hash * 59 + this.KnowledgeBase.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
