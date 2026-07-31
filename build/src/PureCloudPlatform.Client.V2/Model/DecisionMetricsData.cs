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
    /// DecisionMetricsData
    /// </summary>
    [DataContract]
    public partial class DecisionMetricsData :  IEquatable<DecisionMetricsData>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionMetricsData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecisionMetricsData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionMetricsData" /> class.
        /// </summary>
        /// <param name="User">The user associated with the decision metrics (required).</param>
        /// <param name="PerformanceRank">The performance ranking value of the user for decision metrics. The value ranges from 0 to 9999, with the highest value indicating the best performer.</param>
        /// <param name="TieBreakerValue">A numeric tie-breaker value used to resolve ties in performance rankings. Values are sorted in ascending order, with lower values taking precedence.</param>
        /// <param name="Metadata">The metadata associated to the users decision metric, which will be null if the user has no associated decision metrics.</param>
        public DecisionMetricsData(UserReference User = null, int? PerformanceRank = null, int? TieBreakerValue = null, WfmEntityMetadata Metadata = null)
        {
            this.User = User;
            this.PerformanceRank = PerformanceRank;
            this.TieBreakerValue = TieBreakerValue;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The user associated with the decision metrics
        /// </summary>
        /// <value>The user associated with the decision metrics</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The performance ranking value of the user for decision metrics. The value ranges from 0 to 9999, with the highest value indicating the best performer
        /// </summary>
        /// <value>The performance ranking value of the user for decision metrics. The value ranges from 0 to 9999, with the highest value indicating the best performer</value>
        [DataMember(Name="performanceRank", EmitDefaultValue=false)]
        public int? PerformanceRank { get; set; }



        /// <summary>
        /// A numeric tie-breaker value used to resolve ties in performance rankings. Values are sorted in ascending order, with lower values taking precedence
        /// </summary>
        /// <value>A numeric tie-breaker value used to resolve ties in performance rankings. Values are sorted in ascending order, with lower values taking precedence</value>
        [DataMember(Name="tieBreakerValue", EmitDefaultValue=false)]
        public int? TieBreakerValue { get; set; }



        /// <summary>
        /// The metadata associated to the users decision metric, which will be null if the user has no associated decision metrics
        /// </summary>
        /// <value>The metadata associated to the users decision metric, which will be null if the user has no associated decision metrics</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionMetricsData {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  PerformanceRank: ").Append(PerformanceRank).Append("\n");
            sb.Append("  TieBreakerValue: ").Append(TieBreakerValue).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as DecisionMetricsData);
        }

        /// <summary>
        /// Returns true if DecisionMetricsData instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionMetricsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionMetricsData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.PerformanceRank != null)
                    hash = hash * 59 + this.PerformanceRank.GetHashCode();

                if (this.TieBreakerValue != null)
                    hash = hash * 59 + this.TieBreakerValue.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
