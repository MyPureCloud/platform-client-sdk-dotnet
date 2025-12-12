using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Metadata enrichments provided by the platform.
	/// </summary>
	[DataContract]
	public partial class ConversationEnrichment : IEquatable<ConversationEnrichment>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEnrichment" /> class.
		/// </summary>
		/// <param name="Language">Detected language of this message..</param>
		/// <param name="SentimentV2">Detected sentiment of this message..</param>
		public ConversationEnrichment(ConversationEnrichmentLanguage Language = null, ConversationEnrichmentSentimentV2 SentimentV2 = null)
		{
			this.Language = Language;
			this.SentimentV2 = SentimentV2;

		}



		/// <summary>
		/// Detected language of this message.
		/// </summary>
		/// <value>Detected language of this message.</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public ConversationEnrichmentLanguage Language { get; set; }



		/// <summary>
		/// Detected sentiment of this message.
		/// </summary>
		/// <value>Detected sentiment of this message.</value>
		[DataMember(Name = "sentimentV2", EmitDefaultValue = false)]
		public ConversationEnrichmentSentimentV2 SentimentV2 { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationEnrichment {\n");

			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  SentimentV2: ").Append(SentimentV2).Append("\n");
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
			return this.Equals(obj as ConversationEnrichment);
		}

		/// <summary>
		/// Returns true if ConversationEnrichment instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationEnrichment to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationEnrichment other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
				) &&
				(
					this.SentimentV2 == other.SentimentV2 ||
					this.SentimentV2 != null &&
					this.SentimentV2.Equals(other.SentimentV2)
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
				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				if (this.SentimentV2 != null)
					hash = hash * 59 + this.SentimentV2.GetHashCode();

				return hash;
			}
		}
	}

}
