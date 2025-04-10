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
    /// ContestScoresAgents
    /// </summary>
    [DataContract]
    public partial class ContestScoresAgents :  IEquatable<ContestScoresAgents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestScoresAgents" /> class.
        /// </summary>
        /// <param name="ContestScore">The Contest score.</param>
        /// <param name="MetricScores">The Contest metric scores.</param>
        /// <param name="Disqualified">Indicates whether an agent is disqualified or not.</param>
        /// <param name="User">The Contest Scores Leaderboard user.</param>
        public ContestScoresAgents(ContestScoreRanked ContestScore = null, List<ContestMetricScoreRanked> MetricScores = null, bool? Disqualified = null, UserReference User = null)
        {
            this.ContestScore = ContestScore;
            this.MetricScores = MetricScores;
            this.Disqualified = Disqualified;
            this.User = User;
            
        }
        


        /// <summary>
        /// The Contest score
        /// </summary>
        /// <value>The Contest score</value>
        [DataMember(Name="contestScore", EmitDefaultValue=false)]
        public ContestScoreRanked ContestScore { get; set; }



        /// <summary>
        /// The Contest metric scores
        /// </summary>
        /// <value>The Contest metric scores</value>
        [DataMember(Name="metricScores", EmitDefaultValue=false)]
        public List<ContestMetricScoreRanked> MetricScores { get; set; }



        /// <summary>
        /// Indicates whether an agent is disqualified or not
        /// </summary>
        /// <value>Indicates whether an agent is disqualified or not</value>
        [DataMember(Name="disqualified", EmitDefaultValue=false)]
        public bool? Disqualified { get; set; }



        /// <summary>
        /// The Contest Scores Leaderboard user
        /// </summary>
        /// <value>The Contest Scores Leaderboard user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestScoresAgents {\n");

            sb.Append("  ContestScore: ").Append(ContestScore).Append("\n");
            sb.Append("  MetricScores: ").Append(MetricScores).Append("\n");
            sb.Append("  Disqualified: ").Append(Disqualified).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as ContestScoresAgents);
        }

        /// <summary>
        /// Returns true if ContestScoresAgents instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestScoresAgents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestScoresAgents other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContestScore == other.ContestScore ||
                    this.ContestScore != null &&
                    this.ContestScore.Equals(other.ContestScore)
                ) &&
                (
                    this.MetricScores == other.MetricScores ||
                    this.MetricScores != null &&
                    this.MetricScores.SequenceEqual(other.MetricScores)
                ) &&
                (
                    this.Disqualified == other.Disqualified ||
                    this.Disqualified != null &&
                    this.Disqualified.Equals(other.Disqualified)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.ContestScore != null)
                    hash = hash * 59 + this.ContestScore.GetHashCode();

                if (this.MetricScores != null)
                    hash = hash * 59 + this.MetricScores.GetHashCode();

                if (this.Disqualified != null)
                    hash = hash * 59 + this.Disqualified.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                return hash;
            }
        }
    }

}
