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
    /// AnalyticsQueryAggregation
    /// </summary>
    [DataContract]
    public partial class AnalyticsQueryAggregation :  IEquatable<AnalyticsQueryAggregation>
    {
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Termfrequency for "termFrequency"
            /// </summary>
            [EnumMember(Value = "termFrequency")]
            Termfrequency,
            
            /// <summary>
            /// Enum Numericrange for "numericRange"
            /// </summary>
            [EnumMember(Value = "numericRange")]
            Numericrange
        }
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryAggregation" /> class.
        /// </summary>
        /// <param name="Type">Optional type, can usually be inferred.</param>
        /// <param name="Dimension">For use with termFrequency aggregations.</param>
        /// <param name="Metric">For use with numericRange aggregations.</param>
        /// <param name="Size">For use with termFrequency aggregations.</param>
        /// <param name="Ranges">For use with numericRange aggregations.</param>
        public AnalyticsQueryAggregation(TypeEnum? Type = null, string Dimension = null, string Metric = null, int? Size = null, List<AggregationRange> Ranges = null)
        {
            this.Type = Type;
            this.Dimension = Dimension;
            this.Metric = Metric;
            this.Size = Size;
            this.Ranges = Ranges;
            
        }
        




        /// <summary>
        /// For use with termFrequency aggregations
        /// </summary>
        /// <value>For use with termFrequency aggregations</value>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public string Dimension { get; set; }



        /// <summary>
        /// For use with numericRange aggregations
        /// </summary>
        /// <value>For use with numericRange aggregations</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public string Metric { get; set; }



        /// <summary>
        /// For use with termFrequency aggregations
        /// </summary>
        /// <value>For use with termFrequency aggregations</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }



        /// <summary>
        /// For use with numericRange aggregations
        /// </summary>
        /// <value>For use with numericRange aggregations</value>
        [DataMember(Name="ranges", EmitDefaultValue=false)]
        public List<AggregationRange> Ranges { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsQueryAggregation {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
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
            return this.Equals(obj as AnalyticsQueryAggregation);
        }

        /// <summary>
        /// Returns true if AnalyticsQueryAggregation instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsQueryAggregation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsQueryAggregation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) &&
                (
                    this.Ranges == other.Ranges ||
                    this.Ranges != null &&
                    this.Ranges.SequenceEqual(other.Ranges)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Dimension != null)
                    hash = hash * 59 + this.Dimension.GetHashCode();

                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();

                if (this.Ranges != null)
                    hash = hash * 59 + this.Ranges.GetHashCode();

                return hash;
            }
        }
    }

}
