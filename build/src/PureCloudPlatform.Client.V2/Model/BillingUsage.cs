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
    /// BillingUsage
    /// </summary>
    [DataContract]
    public partial class BillingUsage :  IEquatable<BillingUsage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingUsage() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsage" /> class.
        /// </summary>
        
        
        /// <param name="Name">Identifies the billable usage. (required).</param>
        
        
        
        /// <param name="TotalUsage">The total amount of usage, expressed as a decimal number in string format. (required).</param>
        
        
        
        /// <param name="Resources">The resources for which usage was observed (e.g. license users, devices). (required).</param>
        
        
        public BillingUsage(string Name = null, string TotalUsage = null, List<BillingUsageResource> Resources = null)
        {
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for BillingUsage and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            // to ensure "TotalUsage" is required (not null)
            if (TotalUsage == null)
            {
                throw new InvalidDataException("TotalUsage is a required property for BillingUsage and cannot be null");
            }
            else
            {
                this.TotalUsage = TotalUsage;
            }
            
            
            
            
            
            // to ensure "Resources" is required (not null)
            if (Resources == null)
            {
                throw new InvalidDataException("Resources is a required property for BillingUsage and cannot be null");
            }
            else
            {
                this.Resources = Resources;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Identifies the billable usage.
        /// </summary>
        /// <value>Identifies the billable usage.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The total amount of usage, expressed as a decimal number in string format.
        /// </summary>
        /// <value>The total amount of usage, expressed as a decimal number in string format.</value>
        [DataMember(Name="totalUsage", EmitDefaultValue=false)]
        public string TotalUsage { get; set; }
        
        
        
        /// <summary>
        /// The resources for which usage was observed (e.g. license users, devices).
        /// </summary>
        /// <value>The resources for which usage was observed (e.g. license users, devices).</value>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public List<BillingUsageResource> Resources { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingUsage {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  TotalUsage: ").Append(TotalUsage).Append("\n");
            
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            
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
            return this.Equals(obj as BillingUsage);
        }

        /// <summary>
        /// Returns true if BillingUsage instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingUsage other)
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
                    this.TotalUsage == other.TotalUsage ||
                    this.TotalUsage != null &&
                    this.TotalUsage.Equals(other.TotalUsage)
                ) &&
                (
                    this.Resources == other.Resources ||
                    this.Resources != null &&
                    this.Resources.SequenceEqual(other.Resources)
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
                
                if (this.TotalUsage != null)
                    hash = hash * 59 + this.TotalUsage.GetHashCode();
                
                if (this.Resources != null)
                    hash = hash * 59 + this.Resources.GetHashCode();
                
                return hash;
            }
        }
    }

}
