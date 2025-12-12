using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactEnrichOptions
	/// </summary>
	[DataContract]
	public partial class ContactEnrichOptions : IEquatable<ContactEnrichOptions>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactEnrichOptions" /> class.
		/// </summary>
		/// <param name="Promote">If true, any matched contact will have its type updated to Curated. If false, any matched contact will keep its original type in the operation..</param>
		public ContactEnrichOptions(bool? Promote = null)
		{
			this.Promote = Promote;

		}



		/// <summary>
		/// If true, any matched contact will have its type updated to Curated. If false, any matched contact will keep its original type in the operation.
		/// </summary>
		/// <value>If true, any matched contact will have its type updated to Curated. If false, any matched contact will keep its original type in the operation.</value>
		[DataMember(Name = "promote", EmitDefaultValue = false)]
		public bool? Promote { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContactEnrichOptions {\n");

			sb.Append("  Promote: ").Append(Promote).Append("\n");
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
			return this.Equals(obj as ContactEnrichOptions);
		}

		/// <summary>
		/// Returns true if ContactEnrichOptions instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactEnrichOptions to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactEnrichOptions other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Promote == other.Promote ||
					this.Promote != null &&
					this.Promote.Equals(other.Promote)
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
				if (this.Promote != null)
					hash = hash * 59 + this.Promote.GetHashCode();

				return hash;
			}
		}
	}

}
