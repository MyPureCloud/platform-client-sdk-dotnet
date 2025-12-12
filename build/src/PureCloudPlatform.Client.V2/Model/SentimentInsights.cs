using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SentimentInsights
	/// </summary>
	[DataContract]
	public partial class SentimentInsights : IEquatable<SentimentInsights>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SentimentInsights" /> class.
		/// </summary>
		/// <param name="PositiveSentimentReasons">The reasons for positive sentiment found in the conversation.</param>
		/// <param name="NegativeSentimentReasons">The reasons for negative sentiment found in the conversation.</param>
		public SentimentInsights(List<SentimentInsightEntry> PositiveSentimentReasons = null, List<SentimentInsightEntry> NegativeSentimentReasons = null)
		{
			this.PositiveSentimentReasons = PositiveSentimentReasons;
			this.NegativeSentimentReasons = NegativeSentimentReasons;

		}



		/// <summary>
		/// The reasons for positive sentiment found in the conversation
		/// </summary>
		/// <value>The reasons for positive sentiment found in the conversation</value>
		[DataMember(Name = "positiveSentimentReasons", EmitDefaultValue = false)]
		public List<SentimentInsightEntry> PositiveSentimentReasons { get; set; }



		/// <summary>
		/// The reasons for negative sentiment found in the conversation
		/// </summary>
		/// <value>The reasons for negative sentiment found in the conversation</value>
		[DataMember(Name = "negativeSentimentReasons", EmitDefaultValue = false)]
		public List<SentimentInsightEntry> NegativeSentimentReasons { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SentimentInsights {\n");

			sb.Append("  PositiveSentimentReasons: ").Append(PositiveSentimentReasons).Append("\n");
			sb.Append("  NegativeSentimentReasons: ").Append(NegativeSentimentReasons).Append("\n");
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
			return this.Equals(obj as SentimentInsights);
		}

		/// <summary>
		/// Returns true if SentimentInsights instances are equal
		/// </summary>
		/// <param name="other">Instance of SentimentInsights to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SentimentInsights other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.PositiveSentimentReasons == other.PositiveSentimentReasons ||
					this.PositiveSentimentReasons != null &&
					this.PositiveSentimentReasons.SequenceEqual(other.PositiveSentimentReasons)
				) &&
				(
					this.NegativeSentimentReasons == other.NegativeSentimentReasons ||
					this.NegativeSentimentReasons != null &&
					this.NegativeSentimentReasons.SequenceEqual(other.NegativeSentimentReasons)
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
				if (this.PositiveSentimentReasons != null)
					hash = hash * 59 + this.PositiveSentimentReasons.GetHashCode();

				if (this.NegativeSentimentReasons != null)
					hash = hash * 59 + this.NegativeSentimentReasons.GetHashCode();

				return hash;
			}
		}
	}

}
