using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PublishProgramTestTopicPhraseResults
	/// </summary>
	[DataContract]
	public partial class PublishProgramTestTopicPhraseResults : IEquatable<PublishProgramTestTopicPhraseResults>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PublishProgramTestTopicPhraseResults" /> class.
		/// </summary>
		/// <param name="ProcessedTranscriptsCount">ProcessedTranscriptsCount.</param>
		/// <param name="MatchedTranscriptsCount">MatchedTranscriptsCount.</param>
		/// <param name="MatchedTranscripts">MatchedTranscripts.</param>
		public PublishProgramTestTopicPhraseResults(long? ProcessedTranscriptsCount = null, long? MatchedTranscriptsCount = null, List<PublishProgramTestPhraseMatchedTranscript> MatchedTranscripts = null)
		{
			this.ProcessedTranscriptsCount = ProcessedTranscriptsCount;
			this.MatchedTranscriptsCount = MatchedTranscriptsCount;
			this.MatchedTranscripts = MatchedTranscripts;

		}



		/// <summary>
		/// Gets or Sets ProcessedTranscriptsCount
		/// </summary>
		[DataMember(Name = "processedTranscriptsCount", EmitDefaultValue = false)]
		public long? ProcessedTranscriptsCount { get; set; }



		/// <summary>
		/// Gets or Sets MatchedTranscriptsCount
		/// </summary>
		[DataMember(Name = "matchedTranscriptsCount", EmitDefaultValue = false)]
		public long? MatchedTranscriptsCount { get; set; }



		/// <summary>
		/// Gets or Sets MatchedTranscripts
		/// </summary>
		[DataMember(Name = "matchedTranscripts", EmitDefaultValue = false)]
		public List<PublishProgramTestPhraseMatchedTranscript> MatchedTranscripts { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PublishProgramTestTopicPhraseResults {\n");

			sb.Append("  ProcessedTranscriptsCount: ").Append(ProcessedTranscriptsCount).Append("\n");
			sb.Append("  MatchedTranscriptsCount: ").Append(MatchedTranscriptsCount).Append("\n");
			sb.Append("  MatchedTranscripts: ").Append(MatchedTranscripts).Append("\n");
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
			return this.Equals(obj as PublishProgramTestTopicPhraseResults);
		}

		/// <summary>
		/// Returns true if PublishProgramTestTopicPhraseResults instances are equal
		/// </summary>
		/// <param name="other">Instance of PublishProgramTestTopicPhraseResults to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PublishProgramTestTopicPhraseResults other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ProcessedTranscriptsCount == other.ProcessedTranscriptsCount ||
					this.ProcessedTranscriptsCount != null &&
					this.ProcessedTranscriptsCount.Equals(other.ProcessedTranscriptsCount)
				) &&
				(
					this.MatchedTranscriptsCount == other.MatchedTranscriptsCount ||
					this.MatchedTranscriptsCount != null &&
					this.MatchedTranscriptsCount.Equals(other.MatchedTranscriptsCount)
				) &&
				(
					this.MatchedTranscripts == other.MatchedTranscripts ||
					this.MatchedTranscripts != null &&
					this.MatchedTranscripts.SequenceEqual(other.MatchedTranscripts)
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
				if (this.ProcessedTranscriptsCount != null)
					hash = hash * 59 + this.ProcessedTranscriptsCount.GetHashCode();

				if (this.MatchedTranscriptsCount != null)
					hash = hash * 59 + this.MatchedTranscriptsCount.GetHashCode();

				if (this.MatchedTranscripts != null)
					hash = hash * 59 + this.MatchedTranscripts.GetHashCode();

				return hash;
			}
		}
	}

}
