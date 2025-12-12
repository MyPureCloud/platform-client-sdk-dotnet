using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ReverseWhitepagesLookupResult
	/// </summary>
	[DataContract]
	public partial class ReverseWhitepagesLookupResult : IEquatable<ReverseWhitepagesLookupResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ReverseWhitepagesLookupResult" /> class.
		/// </summary>
		/// <param name="Contacts">Contacts.</param>
		public ReverseWhitepagesLookupResult(List<ExternalContact> Contacts = null)
		{
			this.Contacts = Contacts;

		}



		/// <summary>
		/// Gets or Sets Contacts
		/// </summary>
		[DataMember(Name = "contacts", EmitDefaultValue = false)]
		public List<ExternalContact> Contacts { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ReverseWhitepagesLookupResult {\n");

			sb.Append("  Contacts: ").Append(Contacts).Append("\n");
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
			return this.Equals(obj as ReverseWhitepagesLookupResult);
		}

		/// <summary>
		/// Returns true if ReverseWhitepagesLookupResult instances are equal
		/// </summary>
		/// <param name="other">Instance of ReverseWhitepagesLookupResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ReverseWhitepagesLookupResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Contacts == other.Contacts ||
					this.Contacts != null &&
					this.Contacts.SequenceEqual(other.Contacts)
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
				if (this.Contacts != null)
					hash = hash * 59 + this.Contacts.GetHashCode();

				return hash;
			}
		}
	}

}
