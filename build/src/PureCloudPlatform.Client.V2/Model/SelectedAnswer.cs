using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SelectedAnswer
	/// </summary>
	[DataContract]
	public partial class SelectedAnswer : IEquatable<SelectedAnswer>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SelectedAnswer" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SelectedAnswer() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SelectedAnswer" /> class.
		/// </summary>
		/// <param name="Document">The search result document chosen as the answer. (required).</param>
		public SelectedAnswer(AddressableEntityRef Document = null)
		{
			this.Document = Document;

		}



		/// <summary>
		/// The search result document chosen as the answer.
		/// </summary>
		/// <value>The search result document chosen as the answer.</value>
		[DataMember(Name = "document", EmitDefaultValue = false)]
		public AddressableEntityRef Document { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SelectedAnswer {\n");

			sb.Append("  Document: ").Append(Document).Append("\n");
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
			return this.Equals(obj as SelectedAnswer);
		}

		/// <summary>
		/// Returns true if SelectedAnswer instances are equal
		/// </summary>
		/// <param name="other">Instance of SelectedAnswer to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SelectedAnswer other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Document == other.Document ||
					this.Document != null &&
					this.Document.Equals(other.Document)
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
				if (this.Document != null)
					hash = hash * 59 + this.Document.GetHashCode();

				return hash;
			}
		}
	}

}
