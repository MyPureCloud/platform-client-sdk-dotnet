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
    /// WorkdayMetric
    /// </summary>
    [DataContract]
    public partial class WorkdayMetric :  IEquatable<WorkdayMetric>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkdayMetric" /> class.
        /// </summary>
        public WorkdayMetric()
        {
            
        }
        


        /// <summary>
        /// Gamification metric
        /// </summary>
        /// <value>Gamification metric</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public Metric Metric { get; private set; }



        /// <summary>
        /// Current objective for this metric
        /// </summary>
        /// <value>Current objective for this metric</value>
        [DataMember(Name="objective", EmitDefaultValue=false)]
        public Objective Objective { get; private set; }



        /// <summary>
        /// Gamification points earned for this metric
        /// </summary>
        /// <value>Gamification points earned for this metric</value>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; private set; }



        /// <summary>
        /// The maximum Gamification points a user may earn for this metric
        /// </summary>
        /// <value>The maximum Gamification points a user may earn for this metric</value>
        [DataMember(Name="maxPoints", EmitDefaultValue=false)]
        public int? MaxPoints { get; private set; }



        /// <summary>
        /// Value of this metric
        /// </summary>
        /// <value>Value of this metric</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; private set; }



        /// <summary>
        /// List of schedule activity events for punctuality metrics
        /// </summary>
        /// <value>List of schedule activity events for punctuality metrics</value>
        [DataMember(Name="punctualityEvents", EmitDefaultValue=false)]
        public List<PunctualityEvent> PunctualityEvents { get; private set; }



        /// <summary>
        /// List of evaluations for quality evaluation score metrics
        /// </summary>
        /// <value>List of evaluations for quality evaluation score metrics</value>
        [DataMember(Name="evaluationDetails", EmitDefaultValue=false)]
        public List<QualityEvaluationScoreItem> EvaluationDetails { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkdayMetric {\n");

            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  PunctualityEvents: ").Append(PunctualityEvents).Append("\n");
            sb.Append("  EvaluationDetails: ").Append(EvaluationDetails).Append("\n");
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
            return this.Equals(obj as WorkdayMetric);
        }

        /// <summary>
        /// Returns true if WorkdayMetric instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkdayMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkdayMetric other)
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
                    this.Objective == other.Objective ||
                    this.Objective != null &&
                    this.Objective.Equals(other.Objective)
                ) &&
                (
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.Equals(other.Points)
                ) &&
                (
                    this.MaxPoints == other.MaxPoints ||
                    this.MaxPoints != null &&
                    this.MaxPoints.Equals(other.MaxPoints)
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
                ) &&
                (
                    this.EvaluationDetails == other.EvaluationDetails ||
                    this.EvaluationDetails != null &&
                    this.EvaluationDetails.SequenceEqual(other.EvaluationDetails)
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

                if (this.Objective != null)
                    hash = hash * 59 + this.Objective.GetHashCode();

                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();

                if (this.MaxPoints != null)
                    hash = hash * 59 + this.MaxPoints.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.PunctualityEvents != null)
                    hash = hash * 59 + this.PunctualityEvents.GetHashCode();

                if (this.EvaluationDetails != null)
                    hash = hash * 59 + this.EvaluationDetails.GetHashCode();

                return hash;
            }
        }
    }

}
