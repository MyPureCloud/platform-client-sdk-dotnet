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
    /// AggregationResultEntry
    /// </summary>
    [DataContract]
    public partial class AggregationResultEntry :  IEquatable<AggregationResultEntry>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationResultEntry" /> class.
        /// </summary>
        /// <param name="Count">Count.</param>
        /// <param name="Value">For termFrequency aggregations.</param>
        /// <param name="Gte">For numericRange aggregations.</param>
        /// <param name="Lt">For numericRange aggregations.</param>
        public AggregationResultEntry(long? Count = null, string Value = null, double? Gte = null, double? Lt = null)
        {
            this.Count = Count;
            this.Value = Value;
            this.Gte = Gte;
            this.Lt = Lt;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }
        
        
        
        /// <summary>
        /// For termFrequency aggregations
        /// </summary>
        /// <value>For termFrequency aggregations</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// For numericRange aggregations
        /// </summary>
        /// <value>For numericRange aggregations</value>
        [DataMember(Name="gte", EmitDefaultValue=false)]
        public double? Gte { get; set; }
        
        
        
        /// <summary>
        /// For numericRange aggregations
        /// </summary>
        /// <value>For numericRange aggregations</value>
        [DataMember(Name="lt", EmitDefaultValue=false)]
        public double? Lt { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregationResultEntry {\n");
            
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Gte: ").Append(Gte).Append("\n");
            sb.Append("  Lt: ").Append(Lt).Append("\n");
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
            return this.Equals(obj as AggregationResultEntry);
        }

        /// <summary>
        /// Returns true if AggregationResultEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of AggregationResultEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregationResultEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Gte == other.Gte ||
                    this.Gte != null &&
                    this.Gte.Equals(other.Gte)
                ) &&
                (
                    this.Lt == other.Lt ||
                    this.Lt != null &&
                    this.Lt.Equals(other.Lt)
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
                
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.Gte != null)
                    hash = hash * 59 + this.Gte.GetHashCode();
                
                if (this.Lt != null)
                    hash = hash * 59 + this.Lt.GetHashCode();
                
                return hash;
            }
        }
    }

}
