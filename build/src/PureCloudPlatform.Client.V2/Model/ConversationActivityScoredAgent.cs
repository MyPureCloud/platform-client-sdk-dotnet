using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationActivityScoredAgent
	/// </summary>
	[DataContract]
	public partial class ConversationActivityScoredAgent : IEquatable<ConversationActivityScoredAgent>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationActivityScoredAgent" /> class.
		/// </summary>
		/// <param name="AgentScore">Assigned agent score for this conversation (0 - 100, higher being better).</param>
		/// <param name="ScoredAgentId">Unique identifier for the agent that was scored for this conversation.</param>
		public ConversationActivityScoredAgent(int? AgentScore = null, string ScoredAgentId = null)
		{
			this.AgentScore = AgentScore;
			this.ScoredAgentId = ScoredAgentId;

		}



		/// <summary>
		/// Assigned agent score for this conversation (0 - 100, higher being better)
		/// </summary>
		/// <value>Assigned agent score for this conversation (0 - 100, higher being better)</value>
		[DataMember(Name = "agentScore", EmitDefaultValue = false)]
		public int? AgentScore { get; set; }



		/// <summary>
		/// Unique identifier for the agent that was scored for this conversation
		/// </summary>
		/// <value>Unique identifier for the agent that was scored for this conversation</value>
		[DataMember(Name = "scoredAgentId", EmitDefaultValue = false)]
		public string ScoredAgentId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationActivityScoredAgent {\n");

			sb.Append("  AgentScore: ").Append(AgentScore).Append("\n");
			sb.Append("  ScoredAgentId: ").Append(ScoredAgentId).Append("\n");
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
			return this.Equals(obj as ConversationActivityScoredAgent);
		}

		/// <summary>
		/// Returns true if ConversationActivityScoredAgent instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationActivityScoredAgent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationActivityScoredAgent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AgentScore == other.AgentScore ||
					this.AgentScore != null &&
					this.AgentScore.Equals(other.AgentScore)
				) &&
				(
					this.ScoredAgentId == other.ScoredAgentId ||
					this.ScoredAgentId != null &&
					this.ScoredAgentId.Equals(other.ScoredAgentId)
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
				if (this.AgentScore != null)
					hash = hash * 59 + this.AgentScore.GetHashCode();

				if (this.ScoredAgentId != null)
					hash = hash * 59 + this.ScoredAgentId.GetHashCode();

				return hash;
			}
		}
	}

}
