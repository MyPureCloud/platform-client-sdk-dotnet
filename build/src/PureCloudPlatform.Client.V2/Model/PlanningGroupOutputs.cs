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
    /// PlanningGroupOutputs
    /// </summary>
    [DataContract]
    public partial class PlanningGroupOutputs :  IEquatable<PlanningGroupOutputs>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanningGroupOutputs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlanningGroupOutputs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanningGroupOutputs" /> class.
        /// </summary>
        /// <param name="PlanningGroupId">The ID for for the associated planning group result (required).</param>
        /// <param name="ServiceLevelPerInterval">List of Service Level percentage (0.0-100.0) results per interval (required).</param>
        /// <param name="OccupancyPerInterval">List of Occupancy percentage (0.0-100.0) results per interval (required).</param>
        /// <param name="AverageSpeedOfAnswerSecondsPerInterval">List of Average Speed of Answer (in seconds) results per interval (required).</param>
        /// <param name="AbandonRatePerInterval">List of Abandon rate percentage (0.0-100.0) results per interval (required).</param>
        public PlanningGroupOutputs(string PlanningGroupId = null, List<double?> ServiceLevelPerInterval = null, List<double?> OccupancyPerInterval = null, List<double?> AverageSpeedOfAnswerSecondsPerInterval = null, List<double?> AbandonRatePerInterval = null)
        {
            this.PlanningGroupId = PlanningGroupId;
            this.ServiceLevelPerInterval = ServiceLevelPerInterval;
            this.OccupancyPerInterval = OccupancyPerInterval;
            this.AverageSpeedOfAnswerSecondsPerInterval = AverageSpeedOfAnswerSecondsPerInterval;
            this.AbandonRatePerInterval = AbandonRatePerInterval;
            
        }
        


        /// <summary>
        /// The ID for for the associated planning group result
        /// </summary>
        /// <value>The ID for for the associated planning group result</value>
        [DataMember(Name="planningGroupId", EmitDefaultValue=false)]
        public string PlanningGroupId { get; set; }



        /// <summary>
        /// List of Service Level percentage (0.0-100.0) results per interval
        /// </summary>
        /// <value>List of Service Level percentage (0.0-100.0) results per interval</value>
        [DataMember(Name="serviceLevelPerInterval", EmitDefaultValue=false)]
        public List<double?> ServiceLevelPerInterval { get; set; }



        /// <summary>
        /// List of Occupancy percentage (0.0-100.0) results per interval
        /// </summary>
        /// <value>List of Occupancy percentage (0.0-100.0) results per interval</value>
        [DataMember(Name="occupancyPerInterval", EmitDefaultValue=false)]
        public List<double?> OccupancyPerInterval { get; set; }



        /// <summary>
        /// List of Average Speed of Answer (in seconds) results per interval
        /// </summary>
        /// <value>List of Average Speed of Answer (in seconds) results per interval</value>
        [DataMember(Name="averageSpeedOfAnswerSecondsPerInterval", EmitDefaultValue=false)]
        public List<double?> AverageSpeedOfAnswerSecondsPerInterval { get; set; }



        /// <summary>
        /// List of Abandon rate percentage (0.0-100.0) results per interval
        /// </summary>
        /// <value>List of Abandon rate percentage (0.0-100.0) results per interval</value>
        [DataMember(Name="abandonRatePerInterval", EmitDefaultValue=false)]
        public List<double?> AbandonRatePerInterval { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanningGroupOutputs {\n");

            sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
            sb.Append("  ServiceLevelPerInterval: ").Append(ServiceLevelPerInterval).Append("\n");
            sb.Append("  OccupancyPerInterval: ").Append(OccupancyPerInterval).Append("\n");
            sb.Append("  AverageSpeedOfAnswerSecondsPerInterval: ").Append(AverageSpeedOfAnswerSecondsPerInterval).Append("\n");
            sb.Append("  AbandonRatePerInterval: ").Append(AbandonRatePerInterval).Append("\n");
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
            return this.Equals(obj as PlanningGroupOutputs);
        }

        /// <summary>
        /// Returns true if PlanningGroupOutputs instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanningGroupOutputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanningGroupOutputs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PlanningGroupId == other.PlanningGroupId ||
                    this.PlanningGroupId != null &&
                    this.PlanningGroupId.Equals(other.PlanningGroupId)
                ) &&
                (
                    this.ServiceLevelPerInterval == other.ServiceLevelPerInterval ||
                    this.ServiceLevelPerInterval != null &&
                    this.ServiceLevelPerInterval.SequenceEqual(other.ServiceLevelPerInterval)
                ) &&
                (
                    this.OccupancyPerInterval == other.OccupancyPerInterval ||
                    this.OccupancyPerInterval != null &&
                    this.OccupancyPerInterval.SequenceEqual(other.OccupancyPerInterval)
                ) &&
                (
                    this.AverageSpeedOfAnswerSecondsPerInterval == other.AverageSpeedOfAnswerSecondsPerInterval ||
                    this.AverageSpeedOfAnswerSecondsPerInterval != null &&
                    this.AverageSpeedOfAnswerSecondsPerInterval.SequenceEqual(other.AverageSpeedOfAnswerSecondsPerInterval)
                ) &&
                (
                    this.AbandonRatePerInterval == other.AbandonRatePerInterval ||
                    this.AbandonRatePerInterval != null &&
                    this.AbandonRatePerInterval.SequenceEqual(other.AbandonRatePerInterval)
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
                if (this.PlanningGroupId != null)
                    hash = hash * 59 + this.PlanningGroupId.GetHashCode();

                if (this.ServiceLevelPerInterval != null)
                    hash = hash * 59 + this.ServiceLevelPerInterval.GetHashCode();

                if (this.OccupancyPerInterval != null)
                    hash = hash * 59 + this.OccupancyPerInterval.GetHashCode();

                if (this.AverageSpeedOfAnswerSecondsPerInterval != null)
                    hash = hash * 59 + this.AverageSpeedOfAnswerSecondsPerInterval.GetHashCode();

                if (this.AbandonRatePerInterval != null)
                    hash = hash * 59 + this.AbandonRatePerInterval.GetHashCode();

                return hash;
            }
        }
    }

}
