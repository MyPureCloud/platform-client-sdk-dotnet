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
    /// CapacityPlanForecastActualValues
    /// </summary>
    [DataContract]
    public partial class CapacityPlanForecastActualValues :  IEquatable<CapacityPlanForecastActualValues>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastActualValues" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanForecastActualValues() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastActualValues" /> class.
        /// </summary>
        /// <param name="OfferedPerInterval">Forecast offered counts per interval, ordered by the granularity, starting from the business unit&#39;s start day of the week (required).</param>
        /// <param name="AverageHandleTimeSecondsPerInterval">Forecast average handle time in seconds per interval, ordered by the granularity, starting from the business unit&#39;s start day of the week (required).</param>
        public CapacityPlanForecastActualValues(List<double?> OfferedPerInterval = null, List<double?> AverageHandleTimeSecondsPerInterval = null)
        {
            this.OfferedPerInterval = OfferedPerInterval;
            this.AverageHandleTimeSecondsPerInterval = AverageHandleTimeSecondsPerInterval;
            
        }
        


        /// <summary>
        /// Forecast offered counts per interval, ordered by the granularity, starting from the business unit&#39;s start day of the week
        /// </summary>
        /// <value>Forecast offered counts per interval, ordered by the granularity, starting from the business unit&#39;s start day of the week</value>
        [DataMember(Name="offeredPerInterval", EmitDefaultValue=false)]
        public List<double?> OfferedPerInterval { get; set; }



        /// <summary>
        /// Forecast average handle time in seconds per interval, ordered by the granularity, starting from the business unit&#39;s start day of the week
        /// </summary>
        /// <value>Forecast average handle time in seconds per interval, ordered by the granularity, starting from the business unit&#39;s start day of the week</value>
        [DataMember(Name="averageHandleTimeSecondsPerInterval", EmitDefaultValue=false)]
        public List<double?> AverageHandleTimeSecondsPerInterval { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanForecastActualValues {\n");

            sb.Append("  OfferedPerInterval: ").Append(OfferedPerInterval).Append("\n");
            sb.Append("  AverageHandleTimeSecondsPerInterval: ").Append(AverageHandleTimeSecondsPerInterval).Append("\n");
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
            return this.Equals(obj as CapacityPlanForecastActualValues);
        }

        /// <summary>
        /// Returns true if CapacityPlanForecastActualValues instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanForecastActualValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanForecastActualValues other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OfferedPerInterval == other.OfferedPerInterval ||
                    this.OfferedPerInterval != null &&
                    this.OfferedPerInterval.SequenceEqual(other.OfferedPerInterval)
                ) &&
                (
                    this.AverageHandleTimeSecondsPerInterval == other.AverageHandleTimeSecondsPerInterval ||
                    this.AverageHandleTimeSecondsPerInterval != null &&
                    this.AverageHandleTimeSecondsPerInterval.SequenceEqual(other.AverageHandleTimeSecondsPerInterval)
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
                if (this.OfferedPerInterval != null)
                    hash = hash * 59 + this.OfferedPerInterval.GetHashCode();

                if (this.AverageHandleTimeSecondsPerInterval != null)
                    hash = hash * 59 + this.AverageHandleTimeSecondsPerInterval.GetHashCode();

                return hash;
            }
        }
    }

}
