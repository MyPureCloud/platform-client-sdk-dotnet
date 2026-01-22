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
    /// EvaluationSearchAggregationBucket
    /// </summary>
    [DataContract]
    public partial class EvaluationSearchAggregationBucket :  IEquatable<EvaluationSearchAggregationBucket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSearchAggregationBucket" /> class.
        /// </summary>
        /// <param name="Key">The key for this bucket.</param>
        /// <param name="KeyAsString">The key as a string representation.</param>
        /// <param name="DocumentCount">Number of documents in this bucket.</param>
        /// <param name="KeyValue">Numeric key value for date histograms.</param>
        /// <param name="From">Lower bound for range buckets.</param>
        /// <param name="To">Upper bound for range buckets.</param>
        /// <param name="Value">Simple aggregation value.</param>
        /// <param name="Count">Count of documents.</param>
        /// <param name="Minimum">Minimum value in the aggregation.</param>
        /// <param name="Maximum">Maximum value in the aggregation.</param>
        /// <param name="Average">Average value in the aggregation.</param>
        /// <param name="Sum">Sum of values in the aggregation.</param>
        /// <param name="SubAggregations">Nested sub-aggregations.</param>
        public EvaluationSearchAggregationBucket(string Key = null, string KeyAsString = null, long? DocumentCount = null, long? KeyValue = null, double? From = null, double? To = null, double? Value = null, long? Count = null, double? Minimum = null, double? Maximum = null, double? Average = null, double? Sum = null, Dictionary<string, EvaluationSearchAggregationResponse> SubAggregations = null)
        {
            this.Key = Key;
            this.KeyAsString = KeyAsString;
            this.DocumentCount = DocumentCount;
            this.KeyValue = KeyValue;
            this.From = From;
            this.To = To;
            this.Value = Value;
            this.Count = Count;
            this.Minimum = Minimum;
            this.Maximum = Maximum;
            this.Average = Average;
            this.Sum = Sum;
            this.SubAggregations = SubAggregations;
            
        }
        


        /// <summary>
        /// The key for this bucket
        /// </summary>
        /// <value>The key for this bucket</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }



        /// <summary>
        /// The key as a string representation
        /// </summary>
        /// <value>The key as a string representation</value>
        [DataMember(Name="keyAsString", EmitDefaultValue=false)]
        public string KeyAsString { get; set; }



        /// <summary>
        /// Number of documents in this bucket
        /// </summary>
        /// <value>Number of documents in this bucket</value>
        [DataMember(Name="documentCount", EmitDefaultValue=false)]
        public long? DocumentCount { get; set; }



        /// <summary>
        /// Numeric key value for date histograms
        /// </summary>
        /// <value>Numeric key value for date histograms</value>
        [DataMember(Name="keyValue", EmitDefaultValue=false)]
        public long? KeyValue { get; set; }



        /// <summary>
        /// Lower bound for range buckets
        /// </summary>
        /// <value>Lower bound for range buckets</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public double? From { get; set; }



        /// <summary>
        /// Upper bound for range buckets
        /// </summary>
        /// <value>Upper bound for range buckets</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public double? To { get; set; }



        /// <summary>
        /// Simple aggregation value
        /// </summary>
        /// <value>Simple aggregation value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }



        /// <summary>
        /// Count of documents
        /// </summary>
        /// <value>Count of documents</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }



        /// <summary>
        /// Minimum value in the aggregation
        /// </summary>
        /// <value>Minimum value in the aggregation</value>
        [DataMember(Name="minimum", EmitDefaultValue=false)]
        public double? Minimum { get; set; }



        /// <summary>
        /// Maximum value in the aggregation
        /// </summary>
        /// <value>Maximum value in the aggregation</value>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public double? Maximum { get; set; }



        /// <summary>
        /// Average value in the aggregation
        /// </summary>
        /// <value>Average value in the aggregation</value>
        [DataMember(Name="average", EmitDefaultValue=false)]
        public double? Average { get; set; }



        /// <summary>
        /// Sum of values in the aggregation
        /// </summary>
        /// <value>Sum of values in the aggregation</value>
        [DataMember(Name="sum", EmitDefaultValue=false)]
        public double? Sum { get; set; }



        /// <summary>
        /// Nested sub-aggregations
        /// </summary>
        /// <value>Nested sub-aggregations</value>
        [DataMember(Name="subAggregations", EmitDefaultValue=false)]
        public Dictionary<string, EvaluationSearchAggregationResponse> SubAggregations { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationSearchAggregationBucket {\n");

            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  KeyAsString: ").Append(KeyAsString).Append("\n");
            sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
            sb.Append("  KeyValue: ").Append(KeyValue).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
            sb.Append("  SubAggregations: ").Append(SubAggregations).Append("\n");
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
            return this.Equals(obj as EvaluationSearchAggregationBucket);
        }

        /// <summary>
        /// Returns true if EvaluationSearchAggregationBucket instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationSearchAggregationBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationSearchAggregationBucket other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) &&
                (
                    this.KeyAsString == other.KeyAsString ||
                    this.KeyAsString != null &&
                    this.KeyAsString.Equals(other.KeyAsString)
                ) &&
                (
                    this.DocumentCount == other.DocumentCount ||
                    this.DocumentCount != null &&
                    this.DocumentCount.Equals(other.DocumentCount)
                ) &&
                (
                    this.KeyValue == other.KeyValue ||
                    this.KeyValue != null &&
                    this.KeyValue.Equals(other.KeyValue)
                ) &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) &&
                (
                    this.Minimum == other.Minimum ||
                    this.Minimum != null &&
                    this.Minimum.Equals(other.Minimum)
                ) &&
                (
                    this.Maximum == other.Maximum ||
                    this.Maximum != null &&
                    this.Maximum.Equals(other.Maximum)
                ) &&
                (
                    this.Average == other.Average ||
                    this.Average != null &&
                    this.Average.Equals(other.Average)
                ) &&
                (
                    this.Sum == other.Sum ||
                    this.Sum != null &&
                    this.Sum.Equals(other.Sum)
                ) &&
                (
                    this.SubAggregations == other.SubAggregations ||
                    this.SubAggregations != null &&
                    this.SubAggregations.SequenceEqual(other.SubAggregations)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();

                if (this.KeyAsString != null)
                    hash = hash * 59 + this.KeyAsString.GetHashCode();

                if (this.DocumentCount != null)
                    hash = hash * 59 + this.DocumentCount.GetHashCode();

                if (this.KeyValue != null)
                    hash = hash * 59 + this.KeyValue.GetHashCode();

                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();

                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                if (this.Minimum != null)
                    hash = hash * 59 + this.Minimum.GetHashCode();

                if (this.Maximum != null)
                    hash = hash * 59 + this.Maximum.GetHashCode();

                if (this.Average != null)
                    hash = hash * 59 + this.Average.GetHashCode();

                if (this.Sum != null)
                    hash = hash * 59 + this.Sum.GetHashCode();

                if (this.SubAggregations != null)
                    hash = hash * 59 + this.SubAggregations.GetHashCode();

                return hash;
            }
        }
    }

}
