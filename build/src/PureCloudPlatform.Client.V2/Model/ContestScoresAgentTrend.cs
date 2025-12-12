using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContestScoresAgentTrend
	/// </summary>
	[DataContract]
	public partial class ContestScoresAgentTrend : IEquatable<ContestScoresAgentTrend>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContestScoresAgentTrend" /> class.
		/// </summary>
		/// <param name="ContestScore">The Contest score.</param>
		/// <param name="MetricScores">The Contest metric scores.</param>
		/// <param name="Disqualified">Indicates whether an agent is disqualified or not.</param>
		/// <param name="DateWorkday">Workday of the contest scores leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		public ContestScoresAgentTrend(ContestScoreRanked ContestScore = null, List<ContestMetricScoreRanked> MetricScores = null, bool? Disqualified = null, String DateWorkday = null)
		{
			this.ContestScore = ContestScore;
			this.MetricScores = MetricScores;
			this.Disqualified = Disqualified;
			this.DateWorkday = DateWorkday;

		}



		/// <summary>
		/// The Contest score
		/// </summary>
		/// <value>The Contest score</value>
		[DataMember(Name = "contestScore", EmitDefaultValue = false)]
		public ContestScoreRanked ContestScore { get; set; }



		/// <summary>
		/// The Contest metric scores
		/// </summary>
		/// <value>The Contest metric scores</value>
		[DataMember(Name = "metricScores", EmitDefaultValue = false)]
		public List<ContestMetricScoreRanked> MetricScores { get; set; }



		/// <summary>
		/// Indicates whether an agent is disqualified or not
		/// </summary>
		/// <value>Indicates whether an agent is disqualified or not</value>
		[DataMember(Name = "disqualified", EmitDefaultValue = false)]
		public bool? Disqualified { get; set; }



		/// <summary>
		/// Workday of the contest scores leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Workday of the contest scores leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateWorkday", EmitDefaultValue = false)]
		public String DateWorkday { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContestScoresAgentTrend {\n");

			sb.Append("  ContestScore: ").Append(ContestScore).Append("\n");
			sb.Append("  MetricScores: ").Append(MetricScores).Append("\n");
			sb.Append("  Disqualified: ").Append(Disqualified).Append("\n");
			sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
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
			return this.Equals(obj as ContestScoresAgentTrend);
		}

		/// <summary>
		/// Returns true if ContestScoresAgentTrend instances are equal
		/// </summary>
		/// <param name="other">Instance of ContestScoresAgentTrend to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContestScoresAgentTrend other)
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
					this.DateWorkday == other.DateWorkday ||
					this.DateWorkday != null &&
					this.DateWorkday.Equals(other.DateWorkday)
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

				if (this.DateWorkday != null)
					hash = hash * 59 + this.DateWorkday.GetHashCode();

				return hash;
			}
		}
	}

}
