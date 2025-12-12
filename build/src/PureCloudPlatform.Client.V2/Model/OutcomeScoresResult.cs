using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OutcomeScoresResult
	/// </summary>
	[DataContract]
	public partial class OutcomeScoresResult : IEquatable<OutcomeScoresResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OutcomeScoresResult" /> class.
		/// </summary>
		/// <param name="OutcomeScores">List of scored outcomes in the session..</param>
		public OutcomeScoresResult(List<OutcomeScore> OutcomeScores = null)
		{
			this.OutcomeScores = OutcomeScores;

		}



		/// <summary>
		/// List of scored outcomes in the session.
		/// </summary>
		/// <value>List of scored outcomes in the session.</value>
		[DataMember(Name = "outcomeScores", EmitDefaultValue = false)]
		public List<OutcomeScore> OutcomeScores { get; set; }



		/// <summary>
		/// Timestamp indicating the last time that the event was scored. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Timestamp indicating the last time that the event was scored. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
		public DateTime? ModifiedDate { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutcomeScoresResult {\n");

			sb.Append("  OutcomeScores: ").Append(OutcomeScores).Append("\n");
			sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
			return this.Equals(obj as OutcomeScoresResult);
		}

		/// <summary>
		/// Returns true if OutcomeScoresResult instances are equal
		/// </summary>
		/// <param name="other">Instance of OutcomeScoresResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutcomeScoresResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.OutcomeScores == other.OutcomeScores ||
					this.OutcomeScores != null &&
					this.OutcomeScores.SequenceEqual(other.OutcomeScores)
				) &&
				(
					this.ModifiedDate == other.ModifiedDate ||
					this.ModifiedDate != null &&
					this.ModifiedDate.Equals(other.ModifiedDate)
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
				if (this.OutcomeScores != null)
					hash = hash * 59 + this.OutcomeScores.GetHashCode();

				if (this.ModifiedDate != null)
					hash = hash * 59 + this.ModifiedDate.GetHashCode();

				return hash;
			}
		}
	}

}
