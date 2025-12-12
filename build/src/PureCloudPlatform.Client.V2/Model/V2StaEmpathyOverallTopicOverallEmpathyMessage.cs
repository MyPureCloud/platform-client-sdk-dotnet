using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2StaEmpathyOverallTopicOverallEmpathyMessage
	/// </summary>
	[DataContract]
	public partial class V2StaEmpathyOverallTopicOverallEmpathyMessage : IEquatable<V2StaEmpathyOverallTopicOverallEmpathyMessage>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2StaEmpathyOverallTopicOverallEmpathyMessage" /> class.
		/// </summary>
		/// <param name="ConversationId">ConversationId.</param>
		/// <param name="QueueIds">QueueIds.</param>
		/// <param name="DivisionIds">DivisionIds.</param>
		/// <param name="FlowIds">FlowIds.</param>
		/// <param name="Agents">Agents.</param>
		public V2StaEmpathyOverallTopicOverallEmpathyMessage(string ConversationId = null, List<string> QueueIds = null, List<string> DivisionIds = null, List<string> FlowIds = null, List<V2StaEmpathyOverallTopicAgentEmpathyScore> Agents = null)
		{
			this.ConversationId = ConversationId;
			this.QueueIds = QueueIds;
			this.DivisionIds = DivisionIds;
			this.FlowIds = FlowIds;
			this.Agents = Agents;

		}



		/// <summary>
		/// Gets or Sets ConversationId
		/// </summary>
		[DataMember(Name = "conversationId", EmitDefaultValue = false)]
		public string ConversationId { get; set; }



		/// <summary>
		/// Gets or Sets QueueIds
		/// </summary>
		[DataMember(Name = "queueIds", EmitDefaultValue = false)]
		public List<string> QueueIds { get; set; }



		/// <summary>
		/// Gets or Sets DivisionIds
		/// </summary>
		[DataMember(Name = "divisionIds", EmitDefaultValue = false)]
		public List<string> DivisionIds { get; set; }



		/// <summary>
		/// Gets or Sets FlowIds
		/// </summary>
		[DataMember(Name = "flowIds", EmitDefaultValue = false)]
		public List<string> FlowIds { get; set; }



		/// <summary>
		/// Gets or Sets Agents
		/// </summary>
		[DataMember(Name = "agents", EmitDefaultValue = false)]
		public List<V2StaEmpathyOverallTopicAgentEmpathyScore> Agents { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2StaEmpathyOverallTopicOverallEmpathyMessage {\n");

			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
			sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
			sb.Append("  FlowIds: ").Append(FlowIds).Append("\n");
			sb.Append("  Agents: ").Append(Agents).Append("\n");
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
			return this.Equals(obj as V2StaEmpathyOverallTopicOverallEmpathyMessage);
		}

		/// <summary>
		/// Returns true if V2StaEmpathyOverallTopicOverallEmpathyMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of V2StaEmpathyOverallTopicOverallEmpathyMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2StaEmpathyOverallTopicOverallEmpathyMessage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ConversationId == other.ConversationId ||
					this.ConversationId != null &&
					this.ConversationId.Equals(other.ConversationId)
				) &&
				(
					this.QueueIds == other.QueueIds ||
					this.QueueIds != null &&
					this.QueueIds.SequenceEqual(other.QueueIds)
				) &&
				(
					this.DivisionIds == other.DivisionIds ||
					this.DivisionIds != null &&
					this.DivisionIds.SequenceEqual(other.DivisionIds)
				) &&
				(
					this.FlowIds == other.FlowIds ||
					this.FlowIds != null &&
					this.FlowIds.SequenceEqual(other.FlowIds)
				) &&
				(
					this.Agents == other.Agents ||
					this.Agents != null &&
					this.Agents.SequenceEqual(other.Agents)
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
				if (this.ConversationId != null)
					hash = hash * 59 + this.ConversationId.GetHashCode();

				if (this.QueueIds != null)
					hash = hash * 59 + this.QueueIds.GetHashCode();

				if (this.DivisionIds != null)
					hash = hash * 59 + this.DivisionIds.GetHashCode();

				if (this.FlowIds != null)
					hash = hash * 59 + this.FlowIds.GetHashCode();

				if (this.Agents != null)
					hash = hash * 59 + this.Agents.GetHashCode();

				return hash;
			}
		}
	}

}
