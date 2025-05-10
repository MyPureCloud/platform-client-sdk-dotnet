using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// BillingCharge
    /// </summary>
    [DataContract]
    public partial class BillingCharge :  IEquatable<BillingCharge>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCharge" /> class.
        /// </summary>
        /// <param name="Product">Represents the details of a product..</param>
        /// <param name="Organizations">List of plans within the organization..</param>
        /// <param name="GetprepaidQuantity">The quantity of usage that is prepaid..</param>
        /// <param name="GetfairuseQuantity">The quantity of usage allowed under fair use policies..</param>
        /// <param name="GetactualQuantity">The actual quantity of usage..</param>
        /// <param name="GetoverageQuantity">The quantity of usage that exceeds prepaid or fair use limits..</param>
        /// <param name="OverageRate">The rate charged per unit of overage..</param>
        /// <param name="OverageCharge">The total charge for overage usage..</param>
        /// <param name="OverageCurrency">The currency in which the overage charge is billed..</param>
        public BillingCharge(BillingProduct Product = null, List<NamedEntity> Organizations = null, int? GetprepaidQuantity = null, int? GetfairuseQuantity = null, int? GetactualQuantity = null, int? GetoverageQuantity = null, double? OverageRate = null, double? OverageCharge = null, string OverageCurrency = null)
        {
            this.Product = Product;
            this.Organizations = Organizations;
            this.GetprepaidQuantity = GetprepaidQuantity;
            this.GetfairuseQuantity = GetfairuseQuantity;
            this.GetactualQuantity = GetactualQuantity;
            this.GetoverageQuantity = GetoverageQuantity;
            this.OverageRate = OverageRate;
            this.OverageCharge = OverageCharge;
            this.OverageCurrency = OverageCurrency;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Represents the details of a product.
        /// </summary>
        /// <value>Represents the details of a product.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public BillingProduct Product { get; set; }



        /// <summary>
        /// List of plans within the organization.
        /// </summary>
        /// <value>List of plans within the organization.</value>
        [DataMember(Name="organizations", EmitDefaultValue=false)]
        public List<NamedEntity> Organizations { get; set; }



        /// <summary>
        /// The quantity of usage that is prepaid.
        /// </summary>
        /// <value>The quantity of usage that is prepaid.</value>
        [DataMember(Name="getprepaidQuantity", EmitDefaultValue=false)]
        public int? GetprepaidQuantity { get; set; }



        /// <summary>
        /// The quantity of usage allowed under fair use policies.
        /// </summary>
        /// <value>The quantity of usage allowed under fair use policies.</value>
        [DataMember(Name="getfairuseQuantity", EmitDefaultValue=false)]
        public int? GetfairuseQuantity { get; set; }



        /// <summary>
        /// The actual quantity of usage.
        /// </summary>
        /// <value>The actual quantity of usage.</value>
        [DataMember(Name="getactualQuantity", EmitDefaultValue=false)]
        public int? GetactualQuantity { get; set; }



        /// <summary>
        /// The quantity of usage that exceeds prepaid or fair use limits.
        /// </summary>
        /// <value>The quantity of usage that exceeds prepaid or fair use limits.</value>
        [DataMember(Name="getoverageQuantity", EmitDefaultValue=false)]
        public int? GetoverageQuantity { get; set; }



        /// <summary>
        /// The rate charged per unit of overage.
        /// </summary>
        /// <value>The rate charged per unit of overage.</value>
        [DataMember(Name="overageRate", EmitDefaultValue=false)]
        public double? OverageRate { get; set; }



        /// <summary>
        /// The total charge for overage usage.
        /// </summary>
        /// <value>The total charge for overage usage.</value>
        [DataMember(Name="overageCharge", EmitDefaultValue=false)]
        public double? OverageCharge { get; set; }



        /// <summary>
        /// The currency in which the overage charge is billed.
        /// </summary>
        /// <value>The currency in which the overage charge is billed.</value>
        [DataMember(Name="overageCurrency", EmitDefaultValue=false)]
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
            sb.Append("  GetprepaidQuantity: ").Append(GetprepaidQuantity).Append("\n");
            sb.Append("  GetfairuseQuantity: ").Append(GetfairuseQuantity).Append("\n");
            sb.Append("  GetactualQuantity: ").Append(GetactualQuantity).Append("\n");
            sb.Append("  GetoverageQuantity: ").Append(GetoverageQuantity).Append("\n");
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
                    this.GetprepaidQuantity == other.GetprepaidQuantity ||
                    this.GetprepaidQuantity != null &&
                    this.GetprepaidQuantity.Equals(other.GetprepaidQuantity)
                ) &&
                (
                    this.GetfairuseQuantity == other.GetfairuseQuantity ||
                    this.GetfairuseQuantity != null &&
                    this.GetfairuseQuantity.Equals(other.GetfairuseQuantity)
                ) &&
                (
                    this.GetactualQuantity == other.GetactualQuantity ||
                    this.GetactualQuantity != null &&
                    this.GetactualQuantity.Equals(other.GetactualQuantity)
                ) &&
                (
                    this.GetoverageQuantity == other.GetoverageQuantity ||
                    this.GetoverageQuantity != null &&
                    this.GetoverageQuantity.Equals(other.GetoverageQuantity)
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

                if (this.GetprepaidQuantity != null)
                    hash = hash * 59 + this.GetprepaidQuantity.GetHashCode();

                if (this.GetfairuseQuantity != null)
                    hash = hash * 59 + this.GetfairuseQuantity.GetHashCode();

                if (this.GetactualQuantity != null)
                    hash = hash * 59 + this.GetactualQuantity.GetHashCode();

                if (this.GetoverageQuantity != null)
                    hash = hash * 59 + this.GetoverageQuantity.GetHashCode();

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
