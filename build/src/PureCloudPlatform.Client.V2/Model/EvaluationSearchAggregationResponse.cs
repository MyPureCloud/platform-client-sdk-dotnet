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
    /// EvaluationSearchAggregationResponse
    /// </summary>
    [DataContract]
    public partial class EvaluationSearchAggregationResponse :  IEquatable<EvaluationSearchAggregationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSearchAggregationResponse" /> class.
        /// </summary>
        /// <param name="Value">Simple aggregation value (for SUM, COUNT, AVERAGE, etc.).</param>
        /// <param name="Count">Count of documents.</param>
        /// <param name="Minimum">Minimum value.</param>
        /// <param name="Maximum">Maximum value.</param>
        /// <param name="Average">Average value.</param>
        /// <param name="Sum">Total Sum.</param>
        /// <param name="DocumentCountErrorUpperBound">Upper bound estimate of the error in document count for this aggregation.</param>
        /// <param name="SumOtherDocumentCount">Total document count for buckets not included in the response due to size limits.</param>
        /// <param name="Buckets">List of aggregation buckets.</param>
        public EvaluationSearchAggregationResponse(double? Value = null, long? Count = null, double? Minimum = null, double? Maximum = null, double? Average = null, double? Sum = null, long? DocumentCountErrorUpperBound = null, long? SumOtherDocumentCount = null, List<EvaluationSearchAggregationBucket> Buckets = null)
        {
            this.Value = Value;
            this.Count = Count;
            this.Minimum = Minimum;
            this.Maximum = Maximum;
            this.Average = Average;
            this.Sum = Sum;
            this.DocumentCountErrorUpperBound = DocumentCountErrorUpperBound;
            this.SumOtherDocumentCount = SumOtherDocumentCount;
            this.Buckets = Buckets;
            
        }
        


        /// <summary>
        /// Simple aggregation value (for SUM, COUNT, AVERAGE, etc.)
        /// </summary>
        /// <value>Simple aggregation value (for SUM, COUNT, AVERAGE, etc.)</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }



        /// <summary>
        /// Count of documents
        /// </summary>
        /// <value>Count of documents</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }



        /// <summary>
        /// Minimum value
        /// </summary>
        /// <value>Minimum value</value>
        [DataMember(Name="minimum", EmitDefaultValue=false)]
        public double? Minimum { get; set; }



        /// <summary>
        /// Maximum value
        /// </summary>
        /// <value>Maximum value</value>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public double? Maximum { get; set; }



        /// <summary>
        /// Average value
        /// </summary>
        /// <value>Average value</value>
        [DataMember(Name="average", EmitDefaultValue=false)]
        public double? Average { get; set; }



        /// <summary>
        /// Total Sum
        /// </summary>
        /// <value>Total Sum</value>
        [DataMember(Name="sum", EmitDefaultValue=false)]
        public double? Sum { get; set; }



        /// <summary>
        /// Upper bound estimate of the error in document count for this aggregation
        /// </summary>
        /// <value>Upper bound estimate of the error in document count for this aggregation</value>
        [DataMember(Name="documentCountErrorUpperBound", EmitDefaultValue=false)]
        public long? DocumentCountErrorUpperBound { get; set; }



        /// <summary>
        /// Total document count for buckets not included in the response due to size limits
        /// </summary>
        /// <value>Total document count for buckets not included in the response due to size limits</value>
        [DataMember(Name="sumOtherDocumentCount", EmitDefaultValue=false)]
        public long? SumOtherDocumentCount { get; set; }



        /// <summary>
        /// List of aggregation buckets
        /// </summary>
        /// <value>List of aggregation buckets</value>
        [DataMember(Name="buckets", EmitDefaultValue=false)]
        public List<EvaluationSearchAggregationBucket> Buckets { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationSearchAggregationResponse {\n");

            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
            sb.Append("  DocumentCountErrorUpperBound: ").Append(DocumentCountErrorUpperBound).Append("\n");
            sb.Append("  SumOtherDocumentCount: ").Append(SumOtherDocumentCount).Append("\n");
            sb.Append("  Buckets: ").Append(Buckets).Append("\n");
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
            return this.Equals(obj as EvaluationSearchAggregationResponse);
        }

        /// <summary>
        /// Returns true if EvaluationSearchAggregationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationSearchAggregationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationSearchAggregationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.DocumentCountErrorUpperBound == other.DocumentCountErrorUpperBound ||
                    this.DocumentCountErrorUpperBound != null &&
                    this.DocumentCountErrorUpperBound.Equals(other.DocumentCountErrorUpperBound)
                ) &&
                (
                    this.SumOtherDocumentCount == other.SumOtherDocumentCount ||
                    this.SumOtherDocumentCount != null &&
                    this.SumOtherDocumentCount.Equals(other.SumOtherDocumentCount)
                ) &&
                (
                    this.Buckets == other.Buckets ||
                    this.Buckets != null &&
                    this.Buckets.SequenceEqual(other.Buckets)
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

                if (this.DocumentCountErrorUpperBound != null)
                    hash = hash * 59 + this.DocumentCountErrorUpperBound.GetHashCode();

                if (this.SumOtherDocumentCount != null)
                    hash = hash * 59 + this.SumOtherDocumentCount.GetHashCode();

                if (this.Buckets != null)
                    hash = hash * 59 + this.Buckets.GetHashCode();

                return hash;
            }
        }
    }

}
