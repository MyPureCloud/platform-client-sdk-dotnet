using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AuditQuerySort
	/// </summary>
	[DataContract]
	public partial class AuditQuerySort : IEquatable<AuditQuerySort>
	{
		/// <summary>
		/// Name of the property to sort.
		/// </summary>
		/// <value>Name of the property to sort.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum NameEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Timestamp for "Timestamp"
			/// </summary>
			[EnumMember(Value = "Timestamp")]
			Timestamp
		}
		/// <summary>
		/// Sort Order
		/// </summary>
		/// <value>Sort Order</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SortOrderEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Ascending for "ascending"
			/// </summary>
			[EnumMember(Value = "ascending")]
			Ascending,

			/// <summary>
			/// Enum Descending for "descending"
			/// </summary>
			[EnumMember(Value = "descending")]
			Descending
		}
		/// <summary>
		/// Name of the property to sort.
		/// </summary>
		/// <value>Name of the property to sort.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public NameEnum? Name { get; set; }
		/// <summary>
		/// Sort Order
		/// </summary>
		/// <value>Sort Order</value>
		[DataMember(Name = "sortOrder", EmitDefaultValue = false)]
		public SortOrderEnum? SortOrder { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="AuditQuerySort" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AuditQuerySort() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AuditQuerySort" /> class.
		/// </summary>
		/// <param name="Name">Name of the property to sort. (required).</param>
		/// <param name="SortOrder">Sort Order (required).</param>
		public AuditQuerySort(NameEnum? Name = null, SortOrderEnum? SortOrder = null)
		{
			this.Name = Name;
			this.SortOrder = SortOrder;

		}






		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AuditQuerySort {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
			return this.Equals(obj as AuditQuerySort);
		}

		/// <summary>
		/// Returns true if AuditQuerySort instances are equal
		/// </summary>
		/// <param name="other">Instance of AuditQuerySort to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AuditQuerySort other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.SortOrder == other.SortOrder ||
					this.SortOrder != null &&
					this.SortOrder.Equals(other.SortOrder)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.SortOrder != null)
					hash = hash * 59 + this.SortOrder.GetHashCode();

				return hash;
			}
		}
	}

}
