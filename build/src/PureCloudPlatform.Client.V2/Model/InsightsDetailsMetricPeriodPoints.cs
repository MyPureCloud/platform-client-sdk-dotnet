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
    /// InsightsDetailsMetricPeriodPoints
    /// </summary>
    [DataContract]
    public partial class InsightsDetailsMetricPeriodPoints :  IEquatable<InsightsDetailsMetricPeriodPoints>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsDetailsMetricPeriodPoints" /> class.
        /// </summary>
        /// <param name="Points">Points scored.</param>
        /// <param name="MaxPoints">Max possible points.</param>
        /// <param name="DataPointCount">Number of data points.</param>
        /// <param name="PercentOfGoal">Percentage of the goal.</param>
        /// <param name="RankTotalPoints">The agent's rank in leader board for points on this metric.</param>
        /// <param name="RankPercentagePoints">The agent's rank in leader board for percentage on this metric.</param>
        /// <param name="Value">Average value.</param>
        public InsightsDetailsMetricPeriodPoints(int? Points = null, int? MaxPoints = null, int? DataPointCount = null, double? PercentOfGoal = null, int? RankTotalPoints = null, int? RankPercentagePoints = null, double? Value = null)
        {
            this.Points = Points;
            this.MaxPoints = MaxPoints;
            this.DataPointCount = DataPointCount;
            this.PercentOfGoal = PercentOfGoal;
            this.RankTotalPoints = RankTotalPoints;
            this.RankPercentagePoints = RankPercentagePoints;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// Points scored
        /// </summary>
        /// <value>Points scored</value>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; set; }



        /// <summary>
        /// Max possible points
        /// </summary>
        /// <value>Max possible points</value>
        [DataMember(Name="maxPoints", EmitDefaultValue=false)]
        public int? MaxPoints { get; set; }



        /// <summary>
        /// Number of data points
        /// </summary>
        /// <value>Number of data points</value>
        [DataMember(Name="dataPointCount", EmitDefaultValue=false)]
        public int? DataPointCount { get; set; }



        /// <summary>
        /// Percentage of the goal
        /// </summary>
        /// <value>Percentage of the goal</value>
        [DataMember(Name="percentOfGoal", EmitDefaultValue=false)]
        public double? PercentOfGoal { get; set; }



        /// <summary>
        /// The agent's rank in leader board for points on this metric
        /// </summary>
        /// <value>The agent's rank in leader board for points on this metric</value>
        [DataMember(Name="rankTotalPoints", EmitDefaultValue=false)]
        public int? RankTotalPoints { get; set; }



        /// <summary>
        /// The agent's rank in leader board for percentage on this metric
        /// </summary>
        /// <value>The agent's rank in leader board for percentage on this metric</value>
        [DataMember(Name="rankPercentagePoints", EmitDefaultValue=false)]
        public int? RankPercentagePoints { get; set; }



        /// <summary>
        /// Average value
        /// </summary>
        /// <value>Average value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsightsDetailsMetricPeriodPoints {\n");

            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
            sb.Append("  DataPointCount: ").Append(DataPointCount).Append("\n");
            sb.Append("  PercentOfGoal: ").Append(PercentOfGoal).Append("\n");
            sb.Append("  RankTotalPoints: ").Append(RankTotalPoints).Append("\n");
            sb.Append("  RankPercentagePoints: ").Append(RankPercentagePoints).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as InsightsDetailsMetricPeriodPoints);
        }

        /// <summary>
        /// Returns true if InsightsDetailsMetricPeriodPoints instances are equal
        /// </summary>
        /// <param name="other">Instance of InsightsDetailsMetricPeriodPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsDetailsMetricPeriodPoints other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.DataPointCount == other.DataPointCount ||
                    this.DataPointCount != null &&
                    this.DataPointCount.Equals(other.DataPointCount)
                ) &&
                (
                    this.PercentOfGoal == other.PercentOfGoal ||
                    this.PercentOfGoal != null &&
                    this.PercentOfGoal.Equals(other.PercentOfGoal)
                ) &&
                (
                    this.RankTotalPoints == other.RankTotalPoints ||
                    this.RankTotalPoints != null &&
                    this.RankTotalPoints.Equals(other.RankTotalPoints)
                ) &&
                (
                    this.RankPercentagePoints == other.RankPercentagePoints ||
                    this.RankPercentagePoints != null &&
                    this.RankPercentagePoints.Equals(other.RankPercentagePoints)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();

                if (this.MaxPoints != null)
                    hash = hash * 59 + this.MaxPoints.GetHashCode();

                if (this.DataPointCount != null)
                    hash = hash * 59 + this.DataPointCount.GetHashCode();

                if (this.PercentOfGoal != null)
                    hash = hash * 59 + this.PercentOfGoal.GetHashCode();

                if (this.RankTotalPoints != null)
                    hash = hash * 59 + this.RankTotalPoints.GetHashCode();

                if (this.RankPercentagePoints != null)
                    hash = hash * 59 + this.RankPercentagePoints.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
