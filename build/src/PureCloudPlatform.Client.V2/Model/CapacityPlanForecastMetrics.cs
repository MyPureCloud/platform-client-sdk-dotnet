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
    /// CapacityPlanForecastMetrics
    /// </summary>
    [DataContract]
    public partial class CapacityPlanForecastMetrics :  IEquatable<CapacityPlanForecastMetrics>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastMetrics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanForecastMetrics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanForecastMetrics" /> class.
        /// </summary>
        /// <param name="Volume">Forecast offered counts per requested granularity interval (required).</param>
        /// <param name="AverageHandleTime">Average handle time in seconds per requested granularity interval (required).</param>
        public CapacityPlanForecastMetrics(List<double?> Volume = null, List<double?> AverageHandleTime = null)
        {
            this.Volume = Volume;
            this.AverageHandleTime = AverageHandleTime;
            
        }
        


        /// <summary>
        /// Forecast offered counts per requested granularity interval
        /// </summary>
        /// <value>Forecast offered counts per requested granularity interval</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public List<double?> Volume { get; set; }



        /// <summary>
        /// Average handle time in seconds per requested granularity interval
        /// </summary>
        /// <value>Average handle time in seconds per requested granularity interval</value>
        [DataMember(Name="averageHandleTime", EmitDefaultValue=false)]
        public List<double?> AverageHandleTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanForecastMetrics {\n");

            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  AverageHandleTime: ").Append(AverageHandleTime).Append("\n");
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
            return this.Equals(obj as CapacityPlanForecastMetrics);
        }

        /// <summary>
        /// Returns true if CapacityPlanForecastMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanForecastMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanForecastMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Volume == other.Volume ||
                    this.Volume != null &&
                    this.Volume.SequenceEqual(other.Volume)
                ) &&
                (
                    this.AverageHandleTime == other.AverageHandleTime ||
                    this.AverageHandleTime != null &&
                    this.AverageHandleTime.SequenceEqual(other.AverageHandleTime)
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
                if (this.Volume != null)
                    hash = hash * 59 + this.Volume.GetHashCode();

                if (this.AverageHandleTime != null)
                    hash = hash * 59 + this.AverageHandleTime.GetHashCode();

                return hash;
            }
        }
    }

}
