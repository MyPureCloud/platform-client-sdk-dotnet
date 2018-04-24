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
    /// Represents a pricing option for an AppFoundry listing
    /// </summary>
    [DataContract]
    public partial class PricingOption :  IEquatable<PricingOption>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PricingOption() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingOption" /> class.
        /// </summary>
        
        
        /// <param name="Price">The price (required).</param>
        
        
        
        /// <param name="Description">Description explaining pricing option.</param>
        
        
        public PricingOption(LocalizedField Price = null, LocalizedField Description = null)
        {
            
            
            
            // to ensure "Price" is required (not null)
            if (Price == null)
            {
                throw new InvalidDataException("Price is a required property for PricingOption and cannot be null");
            }
            else
            {
                this.Price = Price;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Description = Description;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The price
        /// </summary>
        /// <value>The price</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public LocalizedField Price { get; set; }
        
        
        
        /// <summary>
        /// Description explaining pricing option
        /// </summary>
        /// <value>Description explaining pricing option</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public LocalizedField Description { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PricingOption {\n");
            
            sb.Append("  Price: ").Append(Price).Append("\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            
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
            return this.Equals(obj as PricingOption);
        }

        /// <summary>
        /// Returns true if PricingOption instances are equal
        /// </summary>
        /// <param name="other">Instance of PricingOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PricingOption other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                return hash;
            }
        }
    }

}
