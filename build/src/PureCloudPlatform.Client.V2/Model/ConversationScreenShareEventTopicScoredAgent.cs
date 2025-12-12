using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationScreenShareEventTopicScoredAgent
	/// </summary>
	[DataContract]
	public partial class ConversationScreenShareEventTopicScoredAgent : IEquatable<ConversationScreenShareEventTopicScoredAgent>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationScreenShareEventTopicScoredAgent" /> class.
		/// </summary>
		/// <param name="Agent">A UriReference for a resource.</param>
		/// <param name="Score">Agent&#39;s score for the current conversation, from 0 - 100, higher being better.</param>
		public ConversationScreenShareEventTopicScoredAgent(ConversationScreenShareEventTopicUriReference Agent = null, long? Score = null)
		{
			this.Agent = Agent;
			this.Score = Score;

		}



		/// <summary>
		/// A UriReference for a resource
		/// </summary>
		/// <value>A UriReference for a resource</value>
		[DataMember(Name = "agent", EmitDefaultValue = false)]
		public ConversationScreenShareEventTopicUriReference Agent { get; set; }



		/// <summary>
		/// Agent&#39;s score for the current conversation, from 0 - 100, higher being better
		/// </summary>
		/// <value>Agent&#39;s score for the current conversation, from 0 - 100, higher being better</value>
		[DataMember(Name = "score", EmitDefaultValue = false)]
		public long? Score { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationScreenShareEventTopicScoredAgent {\n");

			sb.Append("  Agent: ").Append(Agent).Append("\n");
			sb.Append("  Score: ").Append(Score).Append("\n");
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
			return this.Equals(obj as ConversationScreenShareEventTopicScoredAgent);
		}

		/// <summary>
		/// Returns true if ConversationScreenShareEventTopicScoredAgent instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationScreenShareEventTopicScoredAgent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationScreenShareEventTopicScoredAgent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Agent == other.Agent ||
					this.Agent != null &&
					this.Agent.Equals(other.Agent)
				) &&
				(
					this.Score == other.Score ||
					this.Score != null &&
					this.Score.Equals(other.Score)
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
				if (this.Agent != null)
					hash = hash * 59 + this.Agent.GetHashCode();

				if (this.Score != null)
					hash = hash * 59 + this.Score.GetHashCode();

				return hash;
			}
		}
	}

}
