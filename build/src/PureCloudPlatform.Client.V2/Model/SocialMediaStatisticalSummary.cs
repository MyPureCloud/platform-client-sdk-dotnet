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
    /// SocialMediaStatisticalSummary
    /// </summary>
    [DataContract]
    public partial class SocialMediaStatisticalSummary :  IEquatable<SocialMediaStatisticalSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaStatisticalSummary" /> class.
        /// </summary>
        /// <param name="Max">Max.</param>
        /// <param name="Min">Min.</param>
        /// <param name="Count">Count.</param>
        /// <param name="CountNegative">CountNegative.</param>
        /// <param name="CountPositive">CountPositive.</param>
        /// <param name="CountNeutral">CountNeutral.</param>
        /// <param name="CountUnknown">CountUnknown.</param>
        /// <param name="Sum">Sum.</param>
        /// <param name="Average">Average.</param>
        /// <param name="Current">Current.</param>
        /// <param name="Ratio">Ratio.</param>
        /// <param name="Numerator">Numerator.</param>
        /// <param name="Denominator">Denominator.</param>
        /// <param name="Target">Target.</param>
        /// <param name="P95">P95.</param>
        /// <param name="P99">P99.</param>
        public SocialMediaStatisticalSummary(double? Max = null, double? Min = null, long? Count = null, long? CountNegative = null, long? CountPositive = null, long? CountNeutral = null, long? CountUnknown = null, double? Sum = null, double? Average = null, double? Current = null, double? Ratio = null, double? Numerator = null, double? Denominator = null, double? Target = null, long? P95 = null, long? P99 = null)
        {
            this.Max = Max;
            this.Min = Min;
            this.Count = Count;
            this.CountNegative = CountNegative;
            this.CountPositive = CountPositive;
            this.CountNeutral = CountNeutral;
            this.CountUnknown = CountUnknown;
            this.Sum = Sum;
            this.Average = Average;
            this.Current = Current;
            this.Ratio = Ratio;
            this.Numerator = Numerator;
            this.Denominator = Denominator;
            this.Target = Target;
            this.P95 = P95;
            this.P99 = P99;
            
        }
        


        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public double? Max { get; set; }



        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public double? Min { get; set; }



        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }



        /// <summary>
        /// Gets or Sets CountNegative
        /// </summary>
        [DataMember(Name="countNegative", EmitDefaultValue=false)]
        public long? CountNegative { get; set; }



        /// <summary>
        /// Gets or Sets CountPositive
        /// </summary>
        [DataMember(Name="countPositive", EmitDefaultValue=false)]
        public long? CountPositive { get; set; }



        /// <summary>
        /// Gets or Sets CountNeutral
        /// </summary>
        [DataMember(Name="countNeutral", EmitDefaultValue=false)]
        public long? CountNeutral { get; set; }



        /// <summary>
        /// Gets or Sets CountUnknown
        /// </summary>
        [DataMember(Name="countUnknown", EmitDefaultValue=false)]
        public long? CountUnknown { get; set; }



        /// <summary>
        /// Gets or Sets Sum
        /// </summary>
        [DataMember(Name="sum", EmitDefaultValue=false)]
        public double? Sum { get; set; }



        /// <summary>
        /// Gets or Sets Average
        /// </summary>
        [DataMember(Name="average", EmitDefaultValue=false)]
        public double? Average { get; set; }



        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public double? Current { get; set; }



        /// <summary>
        /// Gets or Sets Ratio
        /// </summary>
        [DataMember(Name="ratio", EmitDefaultValue=false)]
        public double? Ratio { get; set; }



        /// <summary>
        /// Gets or Sets Numerator
        /// </summary>
        [DataMember(Name="numerator", EmitDefaultValue=false)]
        public double? Numerator { get; set; }



        /// <summary>
        /// Gets or Sets Denominator
        /// </summary>
        [DataMember(Name="denominator", EmitDefaultValue=false)]
        public double? Denominator { get; set; }



        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public double? Target { get; set; }



        /// <summary>
        /// Gets or Sets P95
        /// </summary>
        [DataMember(Name="p95", EmitDefaultValue=false)]
        public long? P95 { get; set; }



        /// <summary>
        /// Gets or Sets P99
        /// </summary>
        [DataMember(Name="p99", EmitDefaultValue=false)]
        public long? P99 { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialMediaStatisticalSummary {\n");

            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  CountNegative: ").Append(CountNegative).Append("\n");
            sb.Append("  CountPositive: ").Append(CountPositive).Append("\n");
            sb.Append("  CountNeutral: ").Append(CountNeutral).Append("\n");
            sb.Append("  CountUnknown: ").Append(CountUnknown).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  Ratio: ").Append(Ratio).Append("\n");
            sb.Append("  Numerator: ").Append(Numerator).Append("\n");
            sb.Append("  Denominator: ").Append(Denominator).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  P95: ").Append(P95).Append("\n");
            sb.Append("  P99: ").Append(P99).Append("\n");
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
            return this.Equals(obj as SocialMediaStatisticalSummary);
        }

        /// <summary>
        /// Returns true if SocialMediaStatisticalSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialMediaStatisticalSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialMediaStatisticalSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Max == other.Max ||
                    this.Max != null &&
                    this.Max.Equals(other.Max)
                ) &&
                (
                    this.Min == other.Min ||
                    this.Min != null &&
                    this.Min.Equals(other.Min)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) &&
                (
                    this.CountNegative == other.CountNegative ||
                    this.CountNegative != null &&
                    this.CountNegative.Equals(other.CountNegative)
                ) &&
                (
                    this.CountPositive == other.CountPositive ||
                    this.CountPositive != null &&
                    this.CountPositive.Equals(other.CountPositive)
                ) &&
                (
                    this.CountNeutral == other.CountNeutral ||
                    this.CountNeutral != null &&
                    this.CountNeutral.Equals(other.CountNeutral)
                ) &&
                (
                    this.CountUnknown == other.CountUnknown ||
                    this.CountUnknown != null &&
                    this.CountUnknown.Equals(other.CountUnknown)
                ) &&
                (
                    this.Sum == other.Sum ||
                    this.Sum != null &&
                    this.Sum.Equals(other.Sum)
                ) &&
                (
                    this.Average == other.Average ||
                    this.Average != null &&
                    this.Average.Equals(other.Average)
                ) &&
                (
                    this.Current == other.Current ||
                    this.Current != null &&
                    this.Current.Equals(other.Current)
                ) &&
                (
                    this.Ratio == other.Ratio ||
                    this.Ratio != null &&
                    this.Ratio.Equals(other.Ratio)
                ) &&
                (
                    this.Numerator == other.Numerator ||
                    this.Numerator != null &&
                    this.Numerator.Equals(other.Numerator)
                ) &&
                (
                    this.Denominator == other.Denominator ||
                    this.Denominator != null &&
                    this.Denominator.Equals(other.Denominator)
                ) &&
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) &&
                (
                    this.P95 == other.P95 ||
                    this.P95 != null &&
                    this.P95.Equals(other.P95)
                ) &&
                (
                    this.P99 == other.P99 ||
                    this.P99 != null &&
                    this.P99.Equals(other.P99)
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
                if (this.Max != null)
                    hash = hash * 59 + this.Max.GetHashCode();

                if (this.Min != null)
                    hash = hash * 59 + this.Min.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                if (this.CountNegative != null)
                    hash = hash * 59 + this.CountNegative.GetHashCode();

                if (this.CountPositive != null)
                    hash = hash * 59 + this.CountPositive.GetHashCode();

                if (this.CountNeutral != null)
                    hash = hash * 59 + this.CountNeutral.GetHashCode();

                if (this.CountUnknown != null)
                    hash = hash * 59 + this.CountUnknown.GetHashCode();

                if (this.Sum != null)
                    hash = hash * 59 + this.Sum.GetHashCode();

                if (this.Average != null)
                    hash = hash * 59 + this.Average.GetHashCode();

                if (this.Current != null)
                    hash = hash * 59 + this.Current.GetHashCode();

                if (this.Ratio != null)
                    hash = hash * 59 + this.Ratio.GetHashCode();

                if (this.Numerator != null)
                    hash = hash * 59 + this.Numerator.GetHashCode();

                if (this.Denominator != null)
                    hash = hash * 59 + this.Denominator.GetHashCode();

                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

                if (this.P95 != null)
                    hash = hash * 59 + this.P95.GetHashCode();

                if (this.P99 != null)
                    hash = hash * 59 + this.P99.GetHashCode();

                return hash;
            }
        }
    }

}
