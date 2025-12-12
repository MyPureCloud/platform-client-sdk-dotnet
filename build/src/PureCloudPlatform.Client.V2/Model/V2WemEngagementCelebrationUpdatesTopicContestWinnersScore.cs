using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2WemEngagementCelebrationUpdatesTopicContestWinnersScore
	/// </summary>
	[DataContract]
	public partial class V2WemEngagementCelebrationUpdatesTopicContestWinnersScore : IEquatable<V2WemEngagementCelebrationUpdatesTopicContestWinnersScore>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicContestWinnersScore" /> class.
		/// </summary>
		/// <param name="Score">Score.</param>
		public V2WemEngagementCelebrationUpdatesTopicContestWinnersScore(double? Score = null)
		{
			this.Score = Score;

		}



		/// <summary>
		/// Gets or Sets Score
		/// </summary>
		[DataMember(Name = "score", EmitDefaultValue = false)]
		public double? Score { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2WemEngagementCelebrationUpdatesTopicContestWinnersScore {\n");

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
			return this.Equals(obj as V2WemEngagementCelebrationUpdatesTopicContestWinnersScore);
		}

		/// <summary>
		/// Returns true if V2WemEngagementCelebrationUpdatesTopicContestWinnersScore instances are equal
		/// </summary>
		/// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicContestWinnersScore to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2WemEngagementCelebrationUpdatesTopicContestWinnersScore other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
				if (this.Score != null)
					hash = hash * 59 + this.Score.GetHashCode();

				return hash;
			}
		}
	}

}
