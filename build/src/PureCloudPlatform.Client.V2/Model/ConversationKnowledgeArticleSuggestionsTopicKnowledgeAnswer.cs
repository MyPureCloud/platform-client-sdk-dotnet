using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer
	/// </summary>
	[DataContract]
	public partial class ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer : IEquatable<ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer" /> class.
		/// </summary>
		/// <param name="Answer">Answer.</param>
		/// <param name="StartIndex">StartIndex.</param>
		/// <param name="EndIndex">EndIndex.</param>
		public ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer(string Answer = null, long? StartIndex = null, long? EndIndex = null)
		{
			this.Answer = Answer;
			this.StartIndex = StartIndex;
			this.EndIndex = EndIndex;

		}



		/// <summary>
		/// Gets or Sets Answer
		/// </summary>
		[DataMember(Name = "answer", EmitDefaultValue = false)]
		public string Answer { get; set; }



		/// <summary>
		/// Gets or Sets StartIndex
		/// </summary>
		[DataMember(Name = "startIndex", EmitDefaultValue = false)]
		public long? StartIndex { get; set; }



		/// <summary>
		/// Gets or Sets EndIndex
		/// </summary>
		[DataMember(Name = "endIndex", EmitDefaultValue = false)]
		public long? EndIndex { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer {\n");

			sb.Append("  Answer: ").Append(Answer).Append("\n");
			sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
			sb.Append("  EndIndex: ").Append(EndIndex).Append("\n");
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
			return this.Equals(obj as ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer);
		}

		/// <summary>
		/// Returns true if ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationKnowledgeArticleSuggestionsTopicKnowledgeAnswer other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Answer == other.Answer ||
					this.Answer != null &&
					this.Answer.Equals(other.Answer)
				) &&
				(
					this.StartIndex == other.StartIndex ||
					this.StartIndex != null &&
					this.StartIndex.Equals(other.StartIndex)
				) &&
				(
					this.EndIndex == other.EndIndex ||
					this.EndIndex != null &&
					this.EndIndex.Equals(other.EndIndex)
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
				if (this.Answer != null)
					hash = hash * 59 + this.Answer.GetHashCode();

				if (this.StartIndex != null)
					hash = hash * 59 + this.StartIndex.GetHashCode();

				if (this.EndIndex != null)
					hash = hash * 59 + this.EndIndex.GetHashCode();

				return hash;
			}
		}
	}

}
