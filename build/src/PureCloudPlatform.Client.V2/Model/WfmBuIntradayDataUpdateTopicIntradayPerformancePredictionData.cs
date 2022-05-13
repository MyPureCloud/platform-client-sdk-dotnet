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
    /// WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData
    /// </summary>
    [DataContract]
    public partial class WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData :  IEquatable<WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData" /> class.
        /// </summary>
        /// <param name="ServiceLevelPercent">ServiceLevelPercent.</param>
        /// <param name="AverageSpeedOfAnswerSeconds">AverageSpeedOfAnswerSeconds.</param>
        /// <param name="OccupancyPercent">OccupancyPercent.</param>
        public WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData(double? ServiceLevelPercent = null, double? AverageSpeedOfAnswerSeconds = null, double? OccupancyPercent = null)
        {
            this.ServiceLevelPercent = ServiceLevelPercent;
            this.AverageSpeedOfAnswerSeconds = AverageSpeedOfAnswerSeconds;
            this.OccupancyPercent = OccupancyPercent;
            
        }
        


        /// <summary>
        /// Gets or Sets ServiceLevelPercent
        /// </summary>
        [DataMember(Name="serviceLevelPercent", EmitDefaultValue=false)]
        public double? ServiceLevelPercent { get; set; }



        /// <summary>
        /// Gets or Sets AverageSpeedOfAnswerSeconds
        /// </summary>
        [DataMember(Name="averageSpeedOfAnswerSeconds", EmitDefaultValue=false)]
        public double? AverageSpeedOfAnswerSeconds { get; set; }



        /// <summary>
        /// Gets or Sets OccupancyPercent
        /// </summary>
        [DataMember(Name="occupancyPercent", EmitDefaultValue=false)]
        public double? OccupancyPercent { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData {\n");

            sb.Append("  ServiceLevelPercent: ").Append(ServiceLevelPercent).Append("\n");
            sb.Append("  AverageSpeedOfAnswerSeconds: ").Append(AverageSpeedOfAnswerSeconds).Append("\n");
            sb.Append("  OccupancyPercent: ").Append(OccupancyPercent).Append("\n");
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
            return this.Equals(obj as WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData);
        }

        /// <summary>
        /// Returns true if WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ServiceLevelPercent == other.ServiceLevelPercent ||
                    this.ServiceLevelPercent != null &&
                    this.ServiceLevelPercent.Equals(other.ServiceLevelPercent)
                ) &&
                (
                    this.AverageSpeedOfAnswerSeconds == other.AverageSpeedOfAnswerSeconds ||
                    this.AverageSpeedOfAnswerSeconds != null &&
                    this.AverageSpeedOfAnswerSeconds.Equals(other.AverageSpeedOfAnswerSeconds)
                ) &&
                (
                    this.OccupancyPercent == other.OccupancyPercent ||
                    this.OccupancyPercent != null &&
                    this.OccupancyPercent.Equals(other.OccupancyPercent)
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
                if (this.ServiceLevelPercent != null)
                    hash = hash * 59 + this.ServiceLevelPercent.GetHashCode();

                if (this.AverageSpeedOfAnswerSeconds != null)
                    hash = hash * 59 + this.AverageSpeedOfAnswerSeconds.GetHashCode();

                if (this.OccupancyPercent != null)
                    hash = hash * 59 + this.OccupancyPercent.GetHashCode();

                return hash;
            }
        }
    }

}
