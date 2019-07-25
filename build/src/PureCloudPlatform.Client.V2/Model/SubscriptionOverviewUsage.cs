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
    /// SubscriptionOverviewUsage
    /// </summary>
    [DataContract]
    public partial class SubscriptionOverviewUsage :  IEquatable<SubscriptionOverviewUsage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOverviewUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionOverviewUsage() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOverviewUsage" /> class.
        /// </summary>
        /// <param name="Name">Product charge name (required).</param>
        /// <param name="PartNumber">Product part number (required).</param>
        /// <param name="Grouping">UI grouping key (required).</param>
        /// <param name="UnitOfMeasureType">UI unit of measure (required).</param>
        /// <param name="UsageQuantity">Usage count for specified period (required).</param>
        /// <param name="OveragePrice">Price for usage / overage charge.</param>
        /// <param name="PrepayQuantity">Items prepaid for specified period (required).</param>
        /// <param name="PrepayPrice">Price for prepay charge.</param>
        /// <param name="UsageNotes">Notes about the usage/charge item.</param>
        /// <param name="IsCancellable">Indicates whether the item is cancellable.</param>
        public SubscriptionOverviewUsage(string Name = null, string PartNumber = null, string Grouping = null, string UnitOfMeasureType = null, string UsageQuantity = null, string OveragePrice = null, string PrepayQuantity = null, string PrepayPrice = null, string UsageNotes = null, bool? IsCancellable = null)
        {
            this.Name = Name;
            this.PartNumber = PartNumber;
            this.Grouping = Grouping;
            this.UnitOfMeasureType = UnitOfMeasureType;
            this.UsageQuantity = UsageQuantity;
            this.OveragePrice = OveragePrice;
            this.PrepayQuantity = PrepayQuantity;
            this.PrepayPrice = PrepayPrice;
            this.UsageNotes = UsageNotes;
            this.IsCancellable = IsCancellable;
            
        }
        
        
        
        /// <summary>
        /// Product charge name
        /// </summary>
        /// <value>Product charge name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Product part number
        /// </summary>
        /// <value>Product part number</value>
        [DataMember(Name="partNumber", EmitDefaultValue=false)]
        public string PartNumber { get; set; }
        
        
        
        /// <summary>
        /// UI grouping key
        /// </summary>
        /// <value>UI grouping key</value>
        [DataMember(Name="grouping", EmitDefaultValue=false)]
        public string Grouping { get; set; }
        
        
        
        /// <summary>
        /// UI unit of measure
        /// </summary>
        /// <value>UI unit of measure</value>
        [DataMember(Name="unitOfMeasureType", EmitDefaultValue=false)]
        public string UnitOfMeasureType { get; set; }
        
        
        
        /// <summary>
        /// Usage count for specified period
        /// </summary>
        /// <value>Usage count for specified period</value>
        [DataMember(Name="usageQuantity", EmitDefaultValue=false)]
        public string UsageQuantity { get; set; }
        
        
        
        /// <summary>
        /// Price for usage / overage charge
        /// </summary>
        /// <value>Price for usage / overage charge</value>
        [DataMember(Name="overagePrice", EmitDefaultValue=false)]
        public string OveragePrice { get; set; }
        
        
        
        /// <summary>
        /// Items prepaid for specified period
        /// </summary>
        /// <value>Items prepaid for specified period</value>
        [DataMember(Name="prepayQuantity", EmitDefaultValue=false)]
        public string PrepayQuantity { get; set; }
        
        
        
        /// <summary>
        /// Price for prepay charge
        /// </summary>
        /// <value>Price for prepay charge</value>
        [DataMember(Name="prepayPrice", EmitDefaultValue=false)]
        public string PrepayPrice { get; set; }
        
        
        
        /// <summary>
        /// Notes about the usage/charge item
        /// </summary>
        /// <value>Notes about the usage/charge item</value>
        [DataMember(Name="usageNotes", EmitDefaultValue=false)]
        public string UsageNotes { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether the item is cancellable
        /// </summary>
        /// <value>Indicates whether the item is cancellable</value>
        [DataMember(Name="isCancellable", EmitDefaultValue=false)]
        public bool? IsCancellable { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionOverviewUsage {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
            sb.Append("  Grouping: ").Append(Grouping).Append("\n");
            sb.Append("  UnitOfMeasureType: ").Append(UnitOfMeasureType).Append("\n");
            sb.Append("  UsageQuantity: ").Append(UsageQuantity).Append("\n");
            sb.Append("  OveragePrice: ").Append(OveragePrice).Append("\n");
            sb.Append("  PrepayQuantity: ").Append(PrepayQuantity).Append("\n");
            sb.Append("  PrepayPrice: ").Append(PrepayPrice).Append("\n");
            sb.Append("  UsageNotes: ").Append(UsageNotes).Append("\n");
            sb.Append("  IsCancellable: ").Append(IsCancellable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SubscriptionOverviewUsage);
        }

        /// <summary>
        /// Returns true if SubscriptionOverviewUsage instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionOverviewUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionOverviewUsage other)
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
                    this.PartNumber == other.PartNumber ||
                    this.PartNumber != null &&
                    this.PartNumber.Equals(other.PartNumber)
                ) &&
                (
                    this.Grouping == other.Grouping ||
                    this.Grouping != null &&
                    this.Grouping.Equals(other.Grouping)
                ) &&
                (
                    this.UnitOfMeasureType == other.UnitOfMeasureType ||
                    this.UnitOfMeasureType != null &&
                    this.UnitOfMeasureType.Equals(other.UnitOfMeasureType)
                ) &&
                (
                    this.UsageQuantity == other.UsageQuantity ||
                    this.UsageQuantity != null &&
                    this.UsageQuantity.Equals(other.UsageQuantity)
                ) &&
                (
                    this.OveragePrice == other.OveragePrice ||
                    this.OveragePrice != null &&
                    this.OveragePrice.Equals(other.OveragePrice)
                ) &&
                (
                    this.PrepayQuantity == other.PrepayQuantity ||
                    this.PrepayQuantity != null &&
                    this.PrepayQuantity.Equals(other.PrepayQuantity)
                ) &&
                (
                    this.PrepayPrice == other.PrepayPrice ||
                    this.PrepayPrice != null &&
                    this.PrepayPrice.Equals(other.PrepayPrice)
                ) &&
                (
                    this.UsageNotes == other.UsageNotes ||
                    this.UsageNotes != null &&
                    this.UsageNotes.Equals(other.UsageNotes)
                ) &&
                (
                    this.IsCancellable == other.IsCancellable ||
                    this.IsCancellable != null &&
                    this.IsCancellable.Equals(other.IsCancellable)
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
                
                if (this.PartNumber != null)
                    hash = hash * 59 + this.PartNumber.GetHashCode();
                
                if (this.Grouping != null)
                    hash = hash * 59 + this.Grouping.GetHashCode();
                
                if (this.UnitOfMeasureType != null)
                    hash = hash * 59 + this.UnitOfMeasureType.GetHashCode();
                
                if (this.UsageQuantity != null)
                    hash = hash * 59 + this.UsageQuantity.GetHashCode();
                
                if (this.OveragePrice != null)
                    hash = hash * 59 + this.OveragePrice.GetHashCode();
                
                if (this.PrepayQuantity != null)
                    hash = hash * 59 + this.PrepayQuantity.GetHashCode();
                
                if (this.PrepayPrice != null)
                    hash = hash * 59 + this.PrepayPrice.GetHashCode();
                
                if (this.UsageNotes != null)
                    hash = hash * 59 + this.UsageNotes.GetHashCode();
                
                if (this.IsCancellable != null)
                    hash = hash * 59 + this.IsCancellable.GetHashCode();
                
                return hash;
            }
        }
    }

}
