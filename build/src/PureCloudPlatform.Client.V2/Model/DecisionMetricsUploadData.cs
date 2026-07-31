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
    /// DecisionMetricsUploadData
    /// </summary>
    [DataContract]
    public partial class DecisionMetricsUploadData :  IEquatable<DecisionMetricsUploadData>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionMetricsUploadData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecisionMetricsUploadData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionMetricsUploadData" /> class.
        /// </summary>
        /// <param name="UserId">The ID of the user associated with this decision metrics data (required).</param>
        /// <param name="PerformanceRank">The performance ranking value of the user for decision metrics. The value ranges from 0 to 9999, with the highest value indicating the best performer.</param>
        /// <param name="TieBreakerValue">A numeric tie-breaker value used to resolve ties in performance rankings. Values are sorted in ascending order, with lower values taking precedence.</param>
        public DecisionMetricsUploadData(string UserId = null, ValueWrapperInteger PerformanceRank = null, ValueWrapperInteger TieBreakerValue = null)
        {
            this.UserId = UserId;
            this.PerformanceRank = PerformanceRank;
            this.TieBreakerValue = TieBreakerValue;
            
        }
        


        /// <summary>
        /// The ID of the user associated with this decision metrics data
        /// </summary>
        /// <value>The ID of the user associated with this decision metrics data</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// The performance ranking value of the user for decision metrics. The value ranges from 0 to 9999, with the highest value indicating the best performer
        /// </summary>
        /// <value>The performance ranking value of the user for decision metrics. The value ranges from 0 to 9999, with the highest value indicating the best performer</value>
        [DataMember(Name="performanceRank", EmitDefaultValue=false)]
        public ValueWrapperInteger PerformanceRank { get; set; }



        /// <summary>
        /// A numeric tie-breaker value used to resolve ties in performance rankings. Values are sorted in ascending order, with lower values taking precedence
        /// </summary>
        /// <value>A numeric tie-breaker value used to resolve ties in performance rankings. Values are sorted in ascending order, with lower values taking precedence</value>
        [DataMember(Name="tieBreakerValue", EmitDefaultValue=false)]
        public ValueWrapperInteger TieBreakerValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionMetricsUploadData {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PerformanceRank: ").Append(PerformanceRank).Append("\n");
            sb.Append("  TieBreakerValue: ").Append(TieBreakerValue).Append("\n");
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
            return this.Equals(obj as DecisionMetricsUploadData);
        }

        /// <summary>
        /// Returns true if DecisionMetricsUploadData instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionMetricsUploadData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionMetricsUploadData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.PerformanceRank == other.PerformanceRank ||
                    this.PerformanceRank != null &&
                    this.PerformanceRank.Equals(other.PerformanceRank)
                ) &&
                (
                    this.TieBreakerValue == other.TieBreakerValue ||
                    this.TieBreakerValue != null &&
                    this.TieBreakerValue.Equals(other.TieBreakerValue)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.PerformanceRank != null)
                    hash = hash * 59 + this.PerformanceRank.GetHashCode();

                if (this.TieBreakerValue != null)
                    hash = hash * 59 + this.TieBreakerValue.GetHashCode();

                return hash;
            }
        }
    }

}
