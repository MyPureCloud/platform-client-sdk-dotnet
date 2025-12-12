using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FacetKeyAttribute
	/// </summary>
	[DataContract]
	public partial class FacetKeyAttribute : IEquatable<FacetKeyAttribute>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FacetKeyAttribute" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Count">Count.</param>
		public FacetKeyAttribute(string Id = null, string Name = null, int? Count = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Count = Count;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets Count
		/// </summary>
		[DataMember(Name = "count", EmitDefaultValue = false)]
		public int? Count { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FacetKeyAttribute {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Count: ").Append(Count).Append("\n");
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
			return this.Equals(obj as FacetKeyAttribute);
		}

		/// <summary>
		/// Returns true if FacetKeyAttribute instances are equal
		/// </summary>
		/// <param name="other">Instance of FacetKeyAttribute to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FacetKeyAttribute other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Count == other.Count ||
					this.Count != null &&
					this.Count.Equals(other.Count)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Count != null)
					hash = hash * 59 + this.Count.GetHashCode();

				return hash;
			}
		}
	}

}
