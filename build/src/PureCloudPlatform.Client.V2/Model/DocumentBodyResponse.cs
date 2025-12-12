using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DocumentBodyResponse
	/// </summary>
	[DataContract]
	public partial class DocumentBodyResponse : IEquatable<DocumentBodyResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentBodyResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DocumentBodyResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentBodyResponse" /> class.
		/// </summary>
		/// <param name="Blocks">The list of building blocks for the document body. (required).</param>
		public DocumentBodyResponse(List<DocumentBodyBlock> Blocks = null)
		{
			this.Blocks = Blocks;

		}



		/// <summary>
		/// The list of building blocks for the document body.
		/// </summary>
		/// <value>The list of building blocks for the document body.</value>
		[DataMember(Name = "blocks", EmitDefaultValue = false)]
		public List<DocumentBodyBlock> Blocks { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentBodyResponse {\n");

			sb.Append("  Blocks: ").Append(Blocks).Append("\n");
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
			return this.Equals(obj as DocumentBodyResponse);
		}

		/// <summary>
		/// Returns true if DocumentBodyResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentBodyResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentBodyResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Blocks == other.Blocks ||
					this.Blocks != null &&
					this.Blocks.SequenceEqual(other.Blocks)
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
				if (this.Blocks != null)
					hash = hash * 59 + this.Blocks.GetHashCode();

				return hash;
			}
		}
	}

}
