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
    /// CapacityPlanForecastDistributionValues
    /// </summary>
    [DataContract]
    public partial class CapacityPlanForecastDistributionValues :  IEquatable<CapacityPlanForecastDistributionValues>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastDistributionValues" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanForecastDistributionValues() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastDistributionValues" /> class.
        /// </summary>
        /// <param name="OfferedDistributions">Hourly distribution of forecast offered volume for the forecast week, with one entry per day of the week. Each value is a proportional weight between 0.0 to 1.0. Each day&#39;s 24 values must sum to approximately 1.0 (0.999 to 1.001 to allow for rounding) (required).</param>
        /// <param name="AverageHandleTimeDistributions">Hourly distribution of forecast average handle time for the forecast week, with one entry per day of the week. Each value is a weighting factor relative to the daily average handle time. Each day&#39;s 24 values must average to approximately 1.0 (0.999 to 1.001 to allow for rounding) (required).</param>
        public CapacityPlanForecastDistributionValues(List<CapacityPlanForecastDistribution> OfferedDistributions = null, List<CapacityPlanForecastDistribution> AverageHandleTimeDistributions = null)
        {
            this.OfferedDistributions = OfferedDistributions;
            this.AverageHandleTimeDistributions = AverageHandleTimeDistributions;
            
        }
        


        /// <summary>
        /// Hourly distribution of forecast offered volume for the forecast week, with one entry per day of the week. Each value is a proportional weight between 0.0 to 1.0. Each day&#39;s 24 values must sum to approximately 1.0 (0.999 to 1.001 to allow for rounding)
        /// </summary>
        /// <value>Hourly distribution of forecast offered volume for the forecast week, with one entry per day of the week. Each value is a proportional weight between 0.0 to 1.0. Each day&#39;s 24 values must sum to approximately 1.0 (0.999 to 1.001 to allow for rounding)</value>
        [DataMember(Name="offeredDistributions", EmitDefaultValue=false)]
        public List<CapacityPlanForecastDistribution> OfferedDistributions { get; set; }



        /// <summary>
        /// Hourly distribution of forecast average handle time for the forecast week, with one entry per day of the week. Each value is a weighting factor relative to the daily average handle time. Each day&#39;s 24 values must average to approximately 1.0 (0.999 to 1.001 to allow for rounding)
        /// </summary>
        /// <value>Hourly distribution of forecast average handle time for the forecast week, with one entry per day of the week. Each value is a weighting factor relative to the daily average handle time. Each day&#39;s 24 values must average to approximately 1.0 (0.999 to 1.001 to allow for rounding)</value>
        [DataMember(Name="averageHandleTimeDistributions", EmitDefaultValue=false)]
        public List<CapacityPlanForecastDistribution> AverageHandleTimeDistributions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanForecastDistributionValues {\n");

            sb.Append("  OfferedDistributions: ").Append(OfferedDistributions).Append("\n");
            sb.Append("  AverageHandleTimeDistributions: ").Append(AverageHandleTimeDistributions).Append("\n");
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
            return this.Equals(obj as CapacityPlanForecastDistributionValues);
        }

        /// <summary>
        /// Returns true if CapacityPlanForecastDistributionValues instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanForecastDistributionValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanForecastDistributionValues other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OfferedDistributions == other.OfferedDistributions ||
                    this.OfferedDistributions != null &&
                    this.OfferedDistributions.SequenceEqual(other.OfferedDistributions)
                ) &&
                (
                    this.AverageHandleTimeDistributions == other.AverageHandleTimeDistributions ||
                    this.AverageHandleTimeDistributions != null &&
                    this.AverageHandleTimeDistributions.SequenceEqual(other.AverageHandleTimeDistributions)
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
                if (this.OfferedDistributions != null)
                    hash = hash * 59 + this.OfferedDistributions.GetHashCode();

                if (this.AverageHandleTimeDistributions != null)
                    hash = hash * 59 + this.AverageHandleTimeDistributions.GetHashCode();

                return hash;
            }
        }
    }

}
