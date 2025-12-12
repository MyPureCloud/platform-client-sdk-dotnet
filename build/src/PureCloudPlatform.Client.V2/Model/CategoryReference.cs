using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CategoryReference
	/// </summary>
	[DataContract]
	public partial class CategoryReference : IEquatable<CategoryReference>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CategoryReference" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CategoryReference() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CategoryReference" /> class.
		/// </summary>
		/// <param name="Id">The globally unique identifier for the category. (required).</param>
		/// <param name="Name">Category name..</param>
		/// <param name="ParentCategory">The reference to category to which this category belongs to..</param>
		public CategoryReference(string Id = null, string Name = null, CategoryReference ParentCategory = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.ParentCategory = ParentCategory;

		}



		/// <summary>
		/// The globally unique identifier for the category.
		/// </summary>
		/// <value>The globally unique identifier for the category.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Category name.
		/// </summary>
		/// <value>Category name.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The reference to category to which this category belongs to.
		/// </summary>
		/// <value>The reference to category to which this category belongs to.</value>
		[DataMember(Name = "parentCategory", EmitDefaultValue = false)]
		public CategoryReference ParentCategory { get; set; }



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
			sb.Append("class CategoryReference {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ParentCategory: ").Append(ParentCategory).Append("\n");
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
			return this.Equals(obj as CategoryReference);
		}

		/// <summary>
		/// Returns true if CategoryReference instances are equal
		/// </summary>
		/// <param name="other">Instance of CategoryReference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CategoryReference other)
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
					this.ParentCategory == other.ParentCategory ||
					this.ParentCategory != null &&
					this.ParentCategory.Equals(other.ParentCategory)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.ParentCategory != null)
					hash = hash * 59 + this.ParentCategory.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
