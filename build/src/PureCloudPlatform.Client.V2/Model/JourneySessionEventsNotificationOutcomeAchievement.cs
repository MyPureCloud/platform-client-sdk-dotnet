using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneySessionEventsNotificationOutcomeAchievement
	/// </summary>
	[DataContract]
	public partial class JourneySessionEventsNotificationOutcomeAchievement : IEquatable<JourneySessionEventsNotificationOutcomeAchievement>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneySessionEventsNotificationOutcomeAchievement" /> class.
		/// </summary>
		/// <param name="Outcome">Outcome.</param>
		/// <param name="AchievedDate">AchievedDate.</param>
		public JourneySessionEventsNotificationOutcomeAchievement(JourneySessionEventsNotificationOutcome Outcome = null, DateTime? AchievedDate = null)
		{
			this.Outcome = Outcome;
			this.AchievedDate = AchievedDate;

		}



		/// <summary>
		/// Gets or Sets Outcome
		/// </summary>
		[DataMember(Name = "outcome", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationOutcome Outcome { get; set; }



		/// <summary>
		/// Gets or Sets AchievedDate
		/// </summary>
		[DataMember(Name = "achievedDate", EmitDefaultValue = false)]
		public DateTime? AchievedDate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneySessionEventsNotificationOutcomeAchievement {\n");

			sb.Append("  Outcome: ").Append(Outcome).Append("\n");
			sb.Append("  AchievedDate: ").Append(AchievedDate).Append("\n");
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
			return this.Equals(obj as JourneySessionEventsNotificationOutcomeAchievement);
		}

		/// <summary>
		/// Returns true if JourneySessionEventsNotificationOutcomeAchievement instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneySessionEventsNotificationOutcomeAchievement to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneySessionEventsNotificationOutcomeAchievement other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Outcome == other.Outcome ||
					this.Outcome != null &&
					this.Outcome.Equals(other.Outcome)
				) &&
				(
					this.AchievedDate == other.AchievedDate ||
					this.AchievedDate != null &&
					this.AchievedDate.Equals(other.AchievedDate)
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
				if (this.Outcome != null)
					hash = hash * 59 + this.Outcome.GetHashCode();

				if (this.AchievedDate != null)
					hash = hash * 59 + this.AchievedDate.GetHashCode();

				return hash;
			}
		}
	}

}
