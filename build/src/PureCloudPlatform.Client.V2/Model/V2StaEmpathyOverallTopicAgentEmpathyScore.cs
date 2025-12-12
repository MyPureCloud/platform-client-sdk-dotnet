using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2StaEmpathyOverallTopicAgentEmpathyScore
	/// </summary>
	[DataContract]
	public partial class V2StaEmpathyOverallTopicAgentEmpathyScore : IEquatable<V2StaEmpathyOverallTopicAgentEmpathyScore>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2StaEmpathyOverallTopicAgentEmpathyScore" /> class.
		/// </summary>
		/// <param name="AgentId">AgentId.</param>
		/// <param name="OverallEmpathyScore">OverallEmpathyScore.</param>
		public V2StaEmpathyOverallTopicAgentEmpathyScore(string AgentId = null, double? OverallEmpathyScore = null)
		{
			this.AgentId = AgentId;
			this.OverallEmpathyScore = OverallEmpathyScore;

		}



		/// <summary>
		/// Gets or Sets AgentId
		/// </summary>
		[DataMember(Name = "agentId", EmitDefaultValue = false)]
		public string AgentId { get; set; }



		/// <summary>
		/// Gets or Sets OverallEmpathyScore
		/// </summary>
		[DataMember(Name = "overallEmpathyScore", EmitDefaultValue = false)]
		public double? OverallEmpathyScore { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2StaEmpathyOverallTopicAgentEmpathyScore {\n");

			sb.Append("  AgentId: ").Append(AgentId).Append("\n");
			sb.Append("  OverallEmpathyScore: ").Append(OverallEmpathyScore).Append("\n");
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
			return this.Equals(obj as V2StaEmpathyOverallTopicAgentEmpathyScore);
		}

		/// <summary>
		/// Returns true if V2StaEmpathyOverallTopicAgentEmpathyScore instances are equal
		/// </summary>
		/// <param name="other">Instance of V2StaEmpathyOverallTopicAgentEmpathyScore to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2StaEmpathyOverallTopicAgentEmpathyScore other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AgentId == other.AgentId ||
					this.AgentId != null &&
					this.AgentId.Equals(other.AgentId)
				) &&
				(
					this.OverallEmpathyScore == other.OverallEmpathyScore ||
					this.OverallEmpathyScore != null &&
					this.OverallEmpathyScore.Equals(other.OverallEmpathyScore)
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
				if (this.AgentId != null)
					hash = hash * 59 + this.AgentId.GetHashCode();

				if (this.OverallEmpathyScore != null)
					hash = hash * 59 + this.OverallEmpathyScore.GetHashCode();

				return hash;
			}
		}
	}

}
