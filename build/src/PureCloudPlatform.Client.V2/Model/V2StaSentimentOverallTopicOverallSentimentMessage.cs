using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2StaSentimentOverallTopicOverallSentimentMessage
	/// </summary>
	[DataContract]
	public partial class V2StaSentimentOverallTopicOverallSentimentMessage : IEquatable<V2StaSentimentOverallTopicOverallSentimentMessage>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2StaSentimentOverallTopicOverallSentimentMessage" /> class.
		/// </summary>
		/// <param name="ConversationId">ConversationId.</param>
		/// <param name="SentimentOverallScore">SentimentOverallScore.</param>
		/// <param name="SentimentTrendScore">SentimentTrendScore.</param>
		/// <param name="QueueIds">QueueIds.</param>
		/// <param name="DivisionIds">DivisionIds.</param>
		/// <param name="FlowIds">FlowIds.</param>
		public V2StaSentimentOverallTopicOverallSentimentMessage(string ConversationId = null, double? SentimentOverallScore = null, double? SentimentTrendScore = null, List<string> QueueIds = null, List<string> DivisionIds = null, List<string> FlowIds = null)
		{
			this.ConversationId = ConversationId;
			this.SentimentOverallScore = SentimentOverallScore;
			this.SentimentTrendScore = SentimentTrendScore;
			this.QueueIds = QueueIds;
			this.DivisionIds = DivisionIds;
			this.FlowIds = FlowIds;

		}



		/// <summary>
		/// Gets or Sets ConversationId
		/// </summary>
		[DataMember(Name = "conversationId", EmitDefaultValue = false)]
		public string ConversationId { get; set; }



		/// <summary>
		/// Gets or Sets SentimentOverallScore
		/// </summary>
		[DataMember(Name = "sentimentOverallScore", EmitDefaultValue = false)]
		public double? SentimentOverallScore { get; set; }



		/// <summary>
		/// Gets or Sets SentimentTrendScore
		/// </summary>
		[DataMember(Name = "sentimentTrendScore", EmitDefaultValue = false)]
		public double? SentimentTrendScore { get; set; }



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
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2StaSentimentOverallTopicOverallSentimentMessage {\n");

			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  SentimentOverallScore: ").Append(SentimentOverallScore).Append("\n");
			sb.Append("  SentimentTrendScore: ").Append(SentimentTrendScore).Append("\n");
			sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
			sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
			sb.Append("  FlowIds: ").Append(FlowIds).Append("\n");
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
			return this.Equals(obj as V2StaSentimentOverallTopicOverallSentimentMessage);
		}

		/// <summary>
		/// Returns true if V2StaSentimentOverallTopicOverallSentimentMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of V2StaSentimentOverallTopicOverallSentimentMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2StaSentimentOverallTopicOverallSentimentMessage other)
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
					this.SentimentOverallScore == other.SentimentOverallScore ||
					this.SentimentOverallScore != null &&
					this.SentimentOverallScore.Equals(other.SentimentOverallScore)
				) &&
				(
					this.SentimentTrendScore == other.SentimentTrendScore ||
					this.SentimentTrendScore != null &&
					this.SentimentTrendScore.Equals(other.SentimentTrendScore)
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

				if (this.SentimentOverallScore != null)
					hash = hash * 59 + this.SentimentOverallScore.GetHashCode();

				if (this.SentimentTrendScore != null)
					hash = hash * 59 + this.SentimentTrendScore.GetHashCode();

				if (this.QueueIds != null)
					hash = hash * 59 + this.QueueIds.GetHashCode();

				if (this.DivisionIds != null)
					hash = hash * 59 + this.DivisionIds.GetHashCode();

				if (this.FlowIds != null)
					hash = hash * 59 + this.FlowIds.GetHashCode();

				return hash;
			}
		}
	}

}
