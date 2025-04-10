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
    /// ContestScoresGroupTrend
    /// </summary>
    [DataContract]
    public partial class ContestScoresGroupTrend :  IEquatable<ContestScoresGroupTrend>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestScoresGroupTrend" /> class.
        /// </summary>
        /// <param name="DateWorkday">Workday of the contest score. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="ContestScore">The Contest score.</param>
        /// <param name="MetricScores">The Contest metric scores.</param>
        public ContestScoresGroupTrend(String DateWorkday = null, ContestScore ContestScore = null, List<ContestMetricScore> MetricScores = null)
        {
            this.DateWorkday = DateWorkday;
            this.ContestScore = ContestScore;
            this.MetricScores = MetricScores;
            
        }
        


        /// <summary>
        /// Workday of the contest score. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Workday of the contest score. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateWorkday", EmitDefaultValue=false)]
        public String DateWorkday { get; set; }



        /// <summary>
        /// The Contest score
        /// </summary>
        /// <value>The Contest score</value>
        [DataMember(Name="contestScore", EmitDefaultValue=false)]
        public ContestScore ContestScore { get; set; }



        /// <summary>
        /// The Contest metric scores
        /// </summary>
        /// <value>The Contest metric scores</value>
        [DataMember(Name="metricScores", EmitDefaultValue=false)]
        public List<ContestMetricScore> MetricScores { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestScoresGroupTrend {\n");

            sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
            sb.Append("  ContestScore: ").Append(ContestScore).Append("\n");
            sb.Append("  MetricScores: ").Append(MetricScores).Append("\n");
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
            return this.Equals(obj as ContestScoresGroupTrend);
        }

        /// <summary>
        /// Returns true if ContestScoresGroupTrend instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestScoresGroupTrend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestScoresGroupTrend other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateWorkday == other.DateWorkday ||
                    this.DateWorkday != null &&
                    this.DateWorkday.Equals(other.DateWorkday)
                ) &&
                (
                    this.ContestScore == other.ContestScore ||
                    this.ContestScore != null &&
                    this.ContestScore.Equals(other.ContestScore)
                ) &&
                (
                    this.MetricScores == other.MetricScores ||
                    this.MetricScores != null &&
                    this.MetricScores.SequenceEqual(other.MetricScores)
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
                if (this.DateWorkday != null)
                    hash = hash * 59 + this.DateWorkday.GetHashCode();

                if (this.ContestScore != null)
                    hash = hash * 59 + this.ContestScore.GetHashCode();

                if (this.MetricScores != null)
                    hash = hash * 59 + this.MetricScores.GetHashCode();

                return hash;
            }
        }
    }

}
