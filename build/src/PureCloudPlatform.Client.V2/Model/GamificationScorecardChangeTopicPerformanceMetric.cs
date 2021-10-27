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
    /// GamificationScorecardChangeTopicPerformanceMetric
    /// </summary>
    [DataContract]
    public partial class GamificationScorecardChangeTopicPerformanceMetric :  IEquatable<GamificationScorecardChangeTopicPerformanceMetric>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationScorecardChangeTopicPerformanceMetric" /> class.
        /// </summary>
        /// <param name="Metric">Metric.</param>
        /// <param name="Points">Points.</param>
        /// <param name="Value">Value.</param>
        /// <param name="PunctualityEvents">PunctualityEvents.</param>
        public GamificationScorecardChangeTopicPerformanceMetric(GamificationScorecardChangeTopicMetric Metric = null, int? Points = null, double? Value = null, List<GamificationScorecardChangeTopicPunctualityEvent> PunctualityEvents = null)
        {
            this.Metric = Metric;
            this.Points = Points;
            this.Value = Value;
            this.PunctualityEvents = PunctualityEvents;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public GamificationScorecardChangeTopicMetric Metric { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PunctualityEvents
        /// </summary>
        [DataMember(Name="punctualityEvents", EmitDefaultValue=false)]
        public List<GamificationScorecardChangeTopicPunctualityEvent> PunctualityEvents { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GamificationScorecardChangeTopicPerformanceMetric {\n");
            
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  PunctualityEvents: ").Append(PunctualityEvents).Append("\n");
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
            return this.Equals(obj as GamificationScorecardChangeTopicPerformanceMetric);
        }

        /// <summary>
        /// Returns true if GamificationScorecardChangeTopicPerformanceMetric instances are equal
        /// </summary>
        /// <param name="other">Instance of GamificationScorecardChangeTopicPerformanceMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GamificationScorecardChangeTopicPerformanceMetric other)
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
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.Equals(other.Points)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.PunctualityEvents == other.PunctualityEvents ||
                    this.PunctualityEvents != null &&
                    this.PunctualityEvents.SequenceEqual(other.PunctualityEvents)
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
                
                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.PunctualityEvents != null)
                    hash = hash * 59 + this.PunctualityEvents.GetHashCode();
                
                return hash;
            }
        }
    }

}
