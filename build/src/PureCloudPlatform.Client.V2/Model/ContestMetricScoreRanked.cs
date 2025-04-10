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
    /// ContestMetricScoreRanked
    /// </summary>
    [DataContract]
    public partial class ContestMetricScoreRanked :  IEquatable<ContestMetricScoreRanked>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestMetricScoreRanked" /> class.
        /// </summary>
        /// <param name="Metric">The gamification metric for the data.</param>
        /// <param name="Score">The Contest Metric score.</param>
        /// <param name="TotalPoints">The Contest Metric totalPoints.</param>
        /// <param name="PercentOfGoal">The Contest Metric percentOfGoal.</param>
        /// <param name="Rank">The Contest Score rank, a lower rank is better (1 is the best).</param>
        public ContestMetricScoreRanked(AddressableEntityRef Metric = null, double? Score = null, double? TotalPoints = null, double? PercentOfGoal = null, int? Rank = null)
        {
            this.Metric = Metric;
            this.Score = Score;
            this.TotalPoints = TotalPoints;
            this.PercentOfGoal = PercentOfGoal;
            this.Rank = Rank;
            
        }
        


        /// <summary>
        /// The gamification metric for the data
        /// </summary>
        /// <value>The gamification metric for the data</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public AddressableEntityRef Metric { get; set; }



        /// <summary>
        /// The Contest Metric score
        /// </summary>
        /// <value>The Contest Metric score</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }



        /// <summary>
        /// The Contest Metric totalPoints
        /// </summary>
        /// <value>The Contest Metric totalPoints</value>
        [DataMember(Name="totalPoints", EmitDefaultValue=false)]
        public double? TotalPoints { get; set; }



        /// <summary>
        /// The Contest Metric percentOfGoal
        /// </summary>
        /// <value>The Contest Metric percentOfGoal</value>
        [DataMember(Name="percentOfGoal", EmitDefaultValue=false)]
        public double? PercentOfGoal { get; set; }



        /// <summary>
        /// The Contest Score rank, a lower rank is better (1 is the best)
        /// </summary>
        /// <value>The Contest Score rank, a lower rank is better (1 is the best)</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestMetricScoreRanked {\n");

            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  TotalPoints: ").Append(TotalPoints).Append("\n");
            sb.Append("  PercentOfGoal: ").Append(PercentOfGoal).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
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
            return this.Equals(obj as ContestMetricScoreRanked);
        }

        /// <summary>
        /// Returns true if ContestMetricScoreRanked instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestMetricScoreRanked to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestMetricScoreRanked other)
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
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) &&
                (
                    this.TotalPoints == other.TotalPoints ||
                    this.TotalPoints != null &&
                    this.TotalPoints.Equals(other.TotalPoints)
                ) &&
                (
                    this.PercentOfGoal == other.PercentOfGoal ||
                    this.PercentOfGoal != null &&
                    this.PercentOfGoal.Equals(other.PercentOfGoal)
                ) &&
                (
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
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

                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();

                if (this.TotalPoints != null)
                    hash = hash * 59 + this.TotalPoints.GetHashCode();

                if (this.PercentOfGoal != null)
                    hash = hash * 59 + this.PercentOfGoal.GetHashCode();

                if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();

                return hash;
            }
        }
    }

}
