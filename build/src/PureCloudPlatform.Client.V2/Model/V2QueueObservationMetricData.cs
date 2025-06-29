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
    /// Observation data for one metric
    /// </summary>
    [DataContract]
    public partial class V2QueueObservationMetricData :  IEquatable<V2QueueObservationMetricData>
    {
        /// <summary>
        /// The observation metric
        /// </summary>
        /// <value>The observation metric</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Oalerting for "oAlerting"
            /// </summary>
            [EnumMember(Value = "oAlerting")]
            Oalerting,
            
            /// <summary>
            /// Enum Ointeracting for "oInteracting"
            /// </summary>
            [EnumMember(Value = "oInteracting")]
            Ointeracting,
            
            /// <summary>
            /// Enum Owaiting for "oWaiting"
            /// </summary>
            [EnumMember(Value = "oWaiting")]
            Owaiting,
            
            /// <summary>
            /// Enum Oflow for "oFlow"
            /// </summary>
            [EnumMember(Value = "oFlow")]
            Oflow,
            
            /// <summary>
            /// Enum Olongestwaiting for "oLongestWaiting"
            /// </summary>
            [EnumMember(Value = "oLongestWaiting")]
            Olongestwaiting,
            
            /// <summary>
            /// Enum Olongestinteracting for "oLongestInteracting"
            /// </summary>
            [EnumMember(Value = "oLongestInteracting")]
            Olongestinteracting
        }
        /// <summary>
        /// The observation metric
        /// </summary>
        /// <value>The observation metric</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2QueueObservationMetricData" /> class.
        /// </summary>
        /// <param name="Metric">The observation metric.</param>
        /// <param name="Observations">List of observations sorted by timestamp in ascending order. This list may be truncated..</param>
        /// <param name="Truncated">Flag indicating whether the list of observations was truncated or not.</param>
        /// <param name="Stats">Stats.</param>
        public V2QueueObservationMetricData(MetricEnum? Metric = null, List<V2QueueObservationObservation> Observations = null, bool? Truncated = null, V2QueueObservationMetricStats Stats = null)
        {
            this.Metric = Metric;
            this.Observations = Observations;
            this.Truncated = Truncated;
            this.Stats = Stats;
            
        }
        




        /// <summary>
        /// List of observations sorted by timestamp in ascending order. This list may be truncated.
        /// </summary>
        /// <value>List of observations sorted by timestamp in ascending order. This list may be truncated.</value>
        [DataMember(Name="observations", EmitDefaultValue=false)]
        public List<V2QueueObservationObservation> Observations { get; set; }



        /// <summary>
        /// Flag indicating whether the list of observations was truncated or not
        /// </summary>
        /// <value>Flag indicating whether the list of observations was truncated or not</value>
        [DataMember(Name="truncated", EmitDefaultValue=false)]
        public bool? Truncated { get; set; }



        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public V2QueueObservationMetricStats Stats { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2QueueObservationMetricData {\n");

            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Observations: ").Append(Observations).Append("\n");
            sb.Append("  Truncated: ").Append(Truncated).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
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
            return this.Equals(obj as V2QueueObservationMetricData);
        }

        /// <summary>
        /// Returns true if V2QueueObservationMetricData instances are equal
        /// </summary>
        /// <param name="other">Instance of V2QueueObservationMetricData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2QueueObservationMetricData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.Observations == other.Observations ||
                    this.Observations != null &&
                    this.Observations.SequenceEqual(other.Observations)
                ) &&
                (
                    this.Truncated == other.Truncated ||
                    this.Truncated != null &&
                    this.Truncated.Equals(other.Truncated)
                ) &&
                (
                    this.Stats == other.Stats ||
                    this.Stats != null &&
                    this.Stats.Equals(other.Stats)
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
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                if (this.Observations != null)
                    hash = hash * 59 + this.Observations.GetHashCode();

                if (this.Truncated != null)
                    hash = hash * 59 + this.Truncated.GetHashCode();

                if (this.Stats != null)
                    hash = hash * 59 + this.Stats.GetHashCode();

                return hash;
            }
        }
    }

}
