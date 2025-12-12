using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CriteriaCategoryInfo
	/// </summary>
	[DataContract]
	public partial class CriteriaCategoryInfo : IEquatable<CriteriaCategoryInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CriteriaCategoryInfo" /> class.
		/// </summary>
		/// <param name="CategoryId">CategoryId.</param>
		/// <param name="DisplayOrder">DisplayOrder.</param>
		public CriteriaCategoryInfo(string CategoryId = null, int? DisplayOrder = null)
		{
			this.CategoryId = CategoryId;
			this.DisplayOrder = DisplayOrder;

		}



		/// <summary>
		/// Gets or Sets CategoryId
		/// </summary>
		[DataMember(Name = "categoryId", EmitDefaultValue = false)]
		public string CategoryId { get; set; }



		/// <summary>
		/// Gets or Sets DisplayOrder
		/// </summary>
		[DataMember(Name = "displayOrder", EmitDefaultValue = false)]
		public int? DisplayOrder { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CriteriaCategoryInfo {\n");

			sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
			sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
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
			return this.Equals(obj as CriteriaCategoryInfo);
		}

		/// <summary>
		/// Returns true if CriteriaCategoryInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of CriteriaCategoryInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CriteriaCategoryInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.CategoryId == other.CategoryId ||
					this.CategoryId != null &&
					this.CategoryId.Equals(other.CategoryId)
				) &&
				(
					this.DisplayOrder == other.DisplayOrder ||
					this.DisplayOrder != null &&
					this.DisplayOrder.Equals(other.DisplayOrder)
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
				if (this.CategoryId != null)
					hash = hash * 59 + this.CategoryId.GetHashCode();

				if (this.DisplayOrder != null)
					hash = hash * 59 + this.DisplayOrder.GetHashCode();

				return hash;
			}
		}
	}

}
