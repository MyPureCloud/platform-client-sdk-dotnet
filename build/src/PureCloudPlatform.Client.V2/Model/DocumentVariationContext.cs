using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DocumentVariationContext
	/// </summary>
	[DataContract]
	public partial class DocumentVariationContext : IEquatable<DocumentVariationContext>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentVariationContext" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DocumentVariationContext() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentVariationContext" /> class.
		/// </summary>
		/// <param name="Context">The knowledge context associated with the variation. (required).</param>
		/// <param name="Values">The list of knowledge context values associated with the variation. (required).</param>
		public DocumentVariationContext(KnowledgeContextReference Context = null, List<KnowledgeContextValueReference> Values = null)
		{
			this.Context = Context;
			this.Values = Values;

		}



		/// <summary>
		/// The knowledge context associated with the variation.
		/// </summary>
		/// <value>The knowledge context associated with the variation.</value>
		[DataMember(Name = "context", EmitDefaultValue = false)]
		public KnowledgeContextReference Context { get; set; }



		/// <summary>
		/// The list of knowledge context values associated with the variation.
		/// </summary>
		/// <value>The list of knowledge context values associated with the variation.</value>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<KnowledgeContextValueReference> Values { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentVariationContext {\n");

			sb.Append("  Context: ").Append(Context).Append("\n");
			sb.Append("  Values: ").Append(Values).Append("\n");
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
			return this.Equals(obj as DocumentVariationContext);
		}

		/// <summary>
		/// Returns true if DocumentVariationContext instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentVariationContext to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentVariationContext other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Context == other.Context ||
					this.Context != null &&
					this.Context.Equals(other.Context)
				) &&
				(
					this.Values == other.Values ||
					this.Values != null &&
					this.Values.SequenceEqual(other.Values)
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
				if (this.Context != null)
					hash = hash * 59 + this.Context.GetHashCode();

				if (this.Values != null)
					hash = hash * 59 + this.Values.GetHashCode();

				return hash;
			}
		}
	}

}
