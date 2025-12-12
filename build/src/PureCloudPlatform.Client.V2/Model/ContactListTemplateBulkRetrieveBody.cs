using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactListTemplateBulkRetrieveBody
	/// </summary>
	[DataContract]
	public partial class ContactListTemplateBulkRetrieveBody : IEquatable<ContactListTemplateBulkRetrieveBody>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactListTemplateBulkRetrieveBody" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContactListTemplateBulkRetrieveBody() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactListTemplateBulkRetrieveBody" /> class.
		/// </summary>
		/// <param name="Ids">The IDs of the Contact List Templates to retrieve. (required).</param>
		public ContactListTemplateBulkRetrieveBody(List<string> Ids = null)
		{
			this.Ids = Ids;

		}



		/// <summary>
		/// The IDs of the Contact List Templates to retrieve.
		/// </summary>
		/// <value>The IDs of the Contact List Templates to retrieve.</value>
		[DataMember(Name = "ids", EmitDefaultValue = false)]
		public List<string> Ids { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContactListTemplateBulkRetrieveBody {\n");

			sb.Append("  Ids: ").Append(Ids).Append("\n");
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
			return this.Equals(obj as ContactListTemplateBulkRetrieveBody);
		}

		/// <summary>
		/// Returns true if ContactListTemplateBulkRetrieveBody instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactListTemplateBulkRetrieveBody to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactListTemplateBulkRetrieveBody other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Ids == other.Ids ||
					this.Ids != null &&
					this.Ids.SequenceEqual(other.Ids)
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
				if (this.Ids != null)
					hash = hash * 59 + this.Ids.GetHashCode();

				return hash;
			}
		}
	}

}
