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
    /// IntradayPerformancePredictionData
    /// </summary>
    [DataContract]
    public partial class IntradayPerformancePredictionData :  IEquatable<IntradayPerformancePredictionData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayPerformancePredictionData" /> class.
        /// </summary>
        /// <param name="ServiceLevelPercent">Percentage of interactions that meets service level target as defined in the matching service goal templates.</param>
        /// <param name="AverageSpeedOfAnswerSeconds">Predicted average time in seconds it takes to answer an interaction once the interaction becomes available to be routed.</param>
        /// <param name="OccupancyPercent">Percentage of on-queue time for all agents in this group that are occupied handling interactions.</param>
        public IntradayPerformancePredictionData(double? ServiceLevelPercent = null, double? AverageSpeedOfAnswerSeconds = null, double? OccupancyPercent = null)
        {
            this.ServiceLevelPercent = ServiceLevelPercent;
            this.AverageSpeedOfAnswerSeconds = AverageSpeedOfAnswerSeconds;
            this.OccupancyPercent = OccupancyPercent;
            
        }
        


        /// <summary>
        /// Percentage of interactions that meets service level target as defined in the matching service goal templates
        /// </summary>
        /// <value>Percentage of interactions that meets service level target as defined in the matching service goal templates</value>
        [DataMember(Name="serviceLevelPercent", EmitDefaultValue=false)]
        public double? ServiceLevelPercent { get; set; }



        /// <summary>
        /// Predicted average time in seconds it takes to answer an interaction once the interaction becomes available to be routed
        /// </summary>
        /// <value>Predicted average time in seconds it takes to answer an interaction once the interaction becomes available to be routed</value>
        [DataMember(Name="averageSpeedOfAnswerSeconds", EmitDefaultValue=false)]
        public double? AverageSpeedOfAnswerSeconds { get; set; }



        /// <summary>
        /// Percentage of on-queue time for all agents in this group that are occupied handling interactions
        /// </summary>
        /// <value>Percentage of on-queue time for all agents in this group that are occupied handling interactions</value>
        [DataMember(Name="occupancyPercent", EmitDefaultValue=false)]
        public double? OccupancyPercent { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayPerformancePredictionData {\n");

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
            return this.Equals(obj as IntradayPerformancePredictionData);
        }

        /// <summary>
        /// Returns true if IntradayPerformancePredictionData instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayPerformancePredictionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayPerformancePredictionData other)
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
