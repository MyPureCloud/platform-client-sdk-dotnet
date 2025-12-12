using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BillingCharge
	/// </summary>
	[DataContract]
	public partial class BillingCharge : IEquatable<BillingCharge>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BillingCharge" /> class.
		/// </summary>
		/// <param name="Product">Represents the details of a product..</param>
		/// <param name="Organizations">List of plans within the organization..</param>
		/// <param name="PrepaidQuantity">The quantity of usage that is prepaid..</param>
		/// <param name="FairuseQuantity">The quantity of usage allowed under fair use policies..</param>
		/// <param name="ActualQuantity">The actual quantity of usage..</param>
		/// <param name="OverageQuantity">The quantity of usage that exceeds prepaid or fair use limits..</param>
		/// <param name="OverageRate">The rate charged per unit of overage..</param>
		/// <param name="OverageCharge">The total charge for overage usage..</param>
		/// <param name="OverageCurrency">The currency in which the overage charge is billed..</param>
		public BillingCharge(BillingProduct Product = null, List<NamedEntity> Organizations = null, int? PrepaidQuantity = null, int? FairuseQuantity = null, int? ActualQuantity = null, int? OverageQuantity = null, double? OverageRate = null, double? OverageCharge = null, string OverageCurrency = null)
		{
			this.Product = Product;
			this.Organizations = Organizations;
			this.PrepaidQuantity = PrepaidQuantity;
			this.FairuseQuantity = FairuseQuantity;
			this.ActualQuantity = ActualQuantity;
			this.OverageQuantity = OverageQuantity;
			this.OverageRate = OverageRate;
			this.OverageCharge = OverageCharge;
			this.OverageCurrency = OverageCurrency;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Represents the details of a product.
		/// </summary>
		/// <value>Represents the details of a product.</value>
		[DataMember(Name = "product", EmitDefaultValue = false)]
		public BillingProduct Product { get; set; }



		/// <summary>
		/// List of plans within the organization.
		/// </summary>
		/// <value>List of plans within the organization.</value>
		[DataMember(Name = "organizations", EmitDefaultValue = false)]
		public List<NamedEntity> Organizations { get; set; }



		/// <summary>
		/// The quantity of usage that is prepaid.
		/// </summary>
		/// <value>The quantity of usage that is prepaid.</value>
		[DataMember(Name = "prepaidQuantity", EmitDefaultValue = false)]
		public int? PrepaidQuantity { get; set; }



		/// <summary>
		/// The quantity of usage allowed under fair use policies.
		/// </summary>
		/// <value>The quantity of usage allowed under fair use policies.</value>
		[DataMember(Name = "fairuseQuantity", EmitDefaultValue = false)]
		public int? FairuseQuantity { get; set; }



		/// <summary>
		/// The actual quantity of usage.
		/// </summary>
		/// <value>The actual quantity of usage.</value>
		[DataMember(Name = "actualQuantity", EmitDefaultValue = false)]
		public int? ActualQuantity { get; set; }



		/// <summary>
		/// The quantity of usage that exceeds prepaid or fair use limits.
		/// </summary>
		/// <value>The quantity of usage that exceeds prepaid or fair use limits.</value>
		[DataMember(Name = "overageQuantity", EmitDefaultValue = false)]
		public int? OverageQuantity { get; set; }



		/// <summary>
		/// The rate charged per unit of overage.
		/// </summary>
		/// <value>The rate charged per unit of overage.</value>
		[DataMember(Name = "overageRate", EmitDefaultValue = false)]
		public double? OverageRate { get; set; }



		/// <summary>
		/// The total charge for overage usage.
		/// </summary>
		/// <value>The total charge for overage usage.</value>
		[DataMember(Name = "overageCharge", EmitDefaultValue = false)]
		public double? OverageCharge { get; set; }



		/// <summary>
		/// The currency in which the overage charge is billed.
		/// </summary>
		/// <value>The currency in which the overage charge is billed.</value>
		[DataMember(Name = "overageCurrency", EmitDefaultValue = false)]
		public string OverageCurrency { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BillingCharge {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Product: ").Append(Product).Append("\n");
			sb.Append("  Organizations: ").Append(Organizations).Append("\n");
			sb.Append("  PrepaidQuantity: ").Append(PrepaidQuantity).Append("\n");
			sb.Append("  FairuseQuantity: ").Append(FairuseQuantity).Append("\n");
			sb.Append("  ActualQuantity: ").Append(ActualQuantity).Append("\n");
			sb.Append("  OverageQuantity: ").Append(OverageQuantity).Append("\n");
			sb.Append("  OverageRate: ").Append(OverageRate).Append("\n");
			sb.Append("  OverageCharge: ").Append(OverageCharge).Append("\n");
			sb.Append("  OverageCurrency: ").Append(OverageCurrency).Append("\n");
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
			return this.Equals(obj as BillingCharge);
		}

		/// <summary>
		/// Returns true if BillingCharge instances are equal
		/// </summary>
		/// <param name="other">Instance of BillingCharge to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BillingCharge other)
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
					this.Product == other.Product ||
					this.Product != null &&
					this.Product.Equals(other.Product)
				) &&
				(
					this.Organizations == other.Organizations ||
					this.Organizations != null &&
					this.Organizations.SequenceEqual(other.Organizations)
				) &&
				(
					this.PrepaidQuantity == other.PrepaidQuantity ||
					this.PrepaidQuantity != null &&
					this.PrepaidQuantity.Equals(other.PrepaidQuantity)
				) &&
				(
					this.FairuseQuantity == other.FairuseQuantity ||
					this.FairuseQuantity != null &&
					this.FairuseQuantity.Equals(other.FairuseQuantity)
				) &&
				(
					this.ActualQuantity == other.ActualQuantity ||
					this.ActualQuantity != null &&
					this.ActualQuantity.Equals(other.ActualQuantity)
				) &&
				(
					this.OverageQuantity == other.OverageQuantity ||
					this.OverageQuantity != null &&
					this.OverageQuantity.Equals(other.OverageQuantity)
				) &&
				(
					this.OverageRate == other.OverageRate ||
					this.OverageRate != null &&
					this.OverageRate.Equals(other.OverageRate)
				) &&
				(
					this.OverageCharge == other.OverageCharge ||
					this.OverageCharge != null &&
					this.OverageCharge.Equals(other.OverageCharge)
				) &&
				(
					this.OverageCurrency == other.OverageCurrency ||
					this.OverageCurrency != null &&
					this.OverageCurrency.Equals(other.OverageCurrency)
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

				if (this.Product != null)
					hash = hash * 59 + this.Product.GetHashCode();

				if (this.Organizations != null)
					hash = hash * 59 + this.Organizations.GetHashCode();

				if (this.PrepaidQuantity != null)
					hash = hash * 59 + this.PrepaidQuantity.GetHashCode();

				if (this.FairuseQuantity != null)
					hash = hash * 59 + this.FairuseQuantity.GetHashCode();

				if (this.ActualQuantity != null)
					hash = hash * 59 + this.ActualQuantity.GetHashCode();

				if (this.OverageQuantity != null)
					hash = hash * 59 + this.OverageQuantity.GetHashCode();

				if (this.OverageRate != null)
					hash = hash * 59 + this.OverageRate.GetHashCode();

				if (this.OverageCharge != null)
					hash = hash * 59 + this.OverageCharge.GetHashCode();

				if (this.OverageCurrency != null)
					hash = hash * 59 + this.OverageCurrency.GetHashCode();

				return hash;
			}
		}
	}

}
