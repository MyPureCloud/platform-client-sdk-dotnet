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
    /// BillingPlan
    /// </summary>
    [DataContract]
    public partial class BillingPlan :  IEquatable<BillingPlan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlan" /> class.
        /// </summary>
        /// <param name="Organizations">List of organizations for the plan..</param>
        /// <param name="Product">Represents the details of a product..</param>
        /// <param name="Items">List of items for the plan..</param>
        public BillingPlan(List<NamedEntity> Organizations = null, BillingProduct Product = null, List<BillingPlanItem> Items = null)
        {
            this.Organizations = Organizations;
            this.Product = Product;
            this.Items = Items;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the object.
        /// </summary>
        /// <value>The name of the object.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }



        /// <summary>
        /// List of organizations for the plan.
        /// </summary>
        /// <value>List of organizations for the plan.</value>
        [DataMember(Name="organizations", EmitDefaultValue=false)]
        public List<NamedEntity> Organizations { get; set; }



        /// <summary>
        /// Represents the details of a product.
        /// </summary>
        /// <value>Represents the details of a product.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public BillingProduct Product { get; set; }



        /// <summary>
        /// List of items for the plan.
        /// </summary>
        /// <value>List of items for the plan.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<BillingPlanItem> Items { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPlan {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Organizations: ").Append(Organizations).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(obj as BillingPlan);
        }

        /// <summary>
        /// Returns true if BillingPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPlan other)
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
                    this.Organizations == other.Organizations ||
                    this.Organizations != null &&
                    this.Organizations.SequenceEqual(other.Organizations)
                ) &&
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) &&
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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

                if (this.Organizations != null)
                    hash = hash * 59 + this.Organizations.GetHashCode();

                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();

                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();

                return hash;
            }
        }
    }

}
