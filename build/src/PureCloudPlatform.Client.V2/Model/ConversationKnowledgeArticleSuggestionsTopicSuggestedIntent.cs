using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationKnowledgeArticleSuggestionsTopicSuggestedIntent
	/// </summary>
	[DataContract]
	public partial class ConversationKnowledgeArticleSuggestionsTopicSuggestedIntent : IEquatable<ConversationKnowledgeArticleSuggestionsTopicSuggestedIntent>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationKnowledgeArticleSuggestionsTopicSuggestedIntent" /> class.
		/// </summary>
		/// <param name="Intent">Intent.</param>
		/// <param name="IntentId">IntentId.</param>
		/// <param name="Confidence">Confidence.</param>
		/// <param name="DetectedSlots">DetectedSlots.</param>
		public ConversationKnowledgeArticleSuggestionsTopicSuggestedIntent(string Intent = null, string IntentId = null, double? Confidence = null, List<ConversationKnowledgeArticleSuggestionsTopicSuggestedIntentSlot> DetectedSlots = null)
		{
			this.Intent = Intent;
			this.IntentId = IntentId;
			this.Confidence = Confidence;
			this.DetectedSlots = DetectedSlots;

		}



		/// <summary>
		/// Gets or Sets Intent
		/// </summary>
		[DataMember(Name = "intent", EmitDefaultValue = false)]
		public string Intent { get; set; }



		/// <summary>
		/// Gets or Sets IntentId
		/// </summary>
		[DataMember(Name = "intentId", EmitDefaultValue = false)]
		public string IntentId { get; set; }



		/// <summary>
		/// Gets or Sets Confidence
		/// </summary>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public double? Confidence { get; set; }



		/// <summary>
		/// Gets or Sets DetectedSlots
		/// </summary>
		[DataMember(Name = "detectedSlots", EmitDefaultValue = false)]
		public List<ConversationKnowledgeArticleSuggestionsTopicSuggestedIntentSlot> DetectedSlots { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationKnowledgeArticleSuggestionsTopicSuggestedIntent {\n");

			sb.Append("  Intent: ").Append(Intent).Append("\n");
			sb.Append("  IntentId: ").Append(IntentId).Append("\n");
			sb.Append("  Confidence: ").Append(Confidence).Append("\n");
			sb.Append("  DetectedSlots: ").Append(DetectedSlots).Append("\n");
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
			return this.Equals(obj as ConversationKnowledgeArticleSuggestionsTopicSuggestedIntent);
		}

		/// <summary>
		/// Returns true if ConversationKnowledgeArticleSuggestionsTopicSuggestedIntent instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationKnowledgeArticleSuggestionsTopicSuggestedIntent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationKnowledgeArticleSuggestionsTopicSuggestedIntent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Intent == other.Intent ||
					this.Intent != null &&
					this.Intent.Equals(other.Intent)
				) &&
				(
					this.IntentId == other.IntentId ||
					this.IntentId != null &&
					this.IntentId.Equals(other.IntentId)
				) &&
				(
					this.Confidence == other.Confidence ||
					this.Confidence != null &&
					this.Confidence.Equals(other.Confidence)
				) &&
				(
					this.DetectedSlots == other.DetectedSlots ||
					this.DetectedSlots != null &&
					this.DetectedSlots.SequenceEqual(other.DetectedSlots)
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
				if (this.Intent != null)
					hash = hash * 59 + this.Intent.GetHashCode();

				if (this.IntentId != null)
					hash = hash * 59 + this.IntentId.GetHashCode();

				if (this.Confidence != null)
					hash = hash * 59 + this.Confidence.GetHashCode();

				if (this.DetectedSlots != null)
					hash = hash * 59 + this.DetectedSlots.GetHashCode();

				return hash;
			}
		}
	}

}
