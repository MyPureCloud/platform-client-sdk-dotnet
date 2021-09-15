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
    /// DevelopmentActivityAggregateQueryResponseStatistics
    /// </summary>
    [DataContract]
    public partial class DevelopmentActivityAggregateQueryResponseStatistics :  IEquatable<DevelopmentActivityAggregateQueryResponseStatistics>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DevelopmentActivityAggregateQueryResponseStatistics" /> class.
        /// </summary>
        /// <param name="Count">The count for this metric.</param>
        /// <param name="Min">The minimum value in this metric.</param>
        /// <param name="Max">The maximum value in this metric.</param>
        /// <param name="Sum">The total of the values for this metric.</param>
        public DevelopmentActivityAggregateQueryResponseStatistics(int? Count = null, double? Min = null, double? Max = null, double? Sum = null)
        {
            this.Count = Count;
            this.Min = Min;
            this.Max = Max;
            this.Sum = Sum;
            
        }
        
        
        
        /// <summary>
        /// The count for this metric
        /// </summary>
        /// <value>The count for this metric</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        
        
        
        /// <summary>
        /// The minimum value in this metric
        /// </summary>
        /// <value>The minimum value in this metric</value>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public double? Min { get; set; }
        
        
        
        /// <summary>
        /// The maximum value in this metric
        /// </summary>
        /// <value>The maximum value in this metric</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public double? Max { get; set; }
        
        
        
        /// <summary>
        /// The total of the values for this metric
        /// </summary>
        /// <value>The total of the values for this metric</value>
        [DataMember(Name="sum", EmitDefaultValue=false)]
        public double? Sum { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevelopmentActivityAggregateQueryResponseStatistics {\n");
            
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
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
            return this.Equals(obj as DevelopmentActivityAggregateQueryResponseStatistics);
        }

        /// <summary>
        /// Returns true if DevelopmentActivityAggregateQueryResponseStatistics instances are equal
        /// </summary>
        /// <param name="other">Instance of DevelopmentActivityAggregateQueryResponseStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DevelopmentActivityAggregateQueryResponseStatistics other)
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
                    this.Min == other.Min ||
                    this.Min != null &&
                    this.Min.Equals(other.Min)
                ) &&
                (
                    this.Max == other.Max ||
                    this.Max != null &&
                    this.Max.Equals(other.Max)
                ) &&
                (
                    this.Sum == other.Sum ||
                    this.Sum != null &&
                    this.Sum.Equals(other.Sum)
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
                
                if (this.Min != null)
                    hash = hash * 59 + this.Min.GetHashCode();
                
                if (this.Max != null)
                    hash = hash * 59 + this.Max.GetHashCode();
                
                if (this.Sum != null)
                    hash = hash * 59 + this.Sum.GetHashCode();
                
                return hash;
            }
        }
    }

}
