using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OutcomePercentileCondition
	/// </summary>
	[DataContract]
	public partial class OutcomePercentileCondition : IEquatable<OutcomePercentileCondition>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="OutcomePercentileCondition" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected OutcomePercentileCondition() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="OutcomePercentileCondition" /> class.
		/// </summary>
		/// <param name="OutcomeId">The outcome ID. (required).</param>
		/// <param name="MaximumPercentile">Percentile value for the selected outcome, at or above which the action map will trigger. (required).</param>
		/// <param name="FallbackPercentile">Additional percentile condition, where if set, the action map will trigger if the current outcome percentile is lower or equal to the value..</param>
		public OutcomePercentileCondition(string OutcomeId = null, float? MaximumPercentile = null, float? FallbackPercentile = null)
		{
			this.OutcomeId = OutcomeId;
			this.MaximumPercentile = MaximumPercentile;
			this.FallbackPercentile = FallbackPercentile;

		}



		/// <summary>
		/// The outcome ID.
		/// </summary>
		/// <value>The outcome ID.</value>
		[DataMember(Name = "outcomeId", EmitDefaultValue = false)]
		public string OutcomeId { get; set; }



		/// <summary>
		/// Percentile value for the selected outcome, at or above which the action map will trigger.
		/// </summary>
		/// <value>Percentile value for the selected outcome, at or above which the action map will trigger.</value>
		[DataMember(Name = "maximumPercentile", EmitDefaultValue = false)]
		public float? MaximumPercentile { get; set; }



		/// <summary>
		/// Additional percentile condition, where if set, the action map will trigger if the current outcome percentile is lower or equal to the value.
		/// </summary>
		/// <value>Additional percentile condition, where if set, the action map will trigger if the current outcome percentile is lower or equal to the value.</value>
		[DataMember(Name = "fallbackPercentile", EmitDefaultValue = false)]
		public float? FallbackPercentile { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutcomePercentileCondition {\n");

			sb.Append("  OutcomeId: ").Append(OutcomeId).Append("\n");
			sb.Append("  MaximumPercentile: ").Append(MaximumPercentile).Append("\n");
			sb.Append("  FallbackPercentile: ").Append(FallbackPercentile).Append("\n");
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
			return this.Equals(obj as OutcomePercentileCondition);
		}

		/// <summary>
		/// Returns true if OutcomePercentileCondition instances are equal
		/// </summary>
		/// <param name="other">Instance of OutcomePercentileCondition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutcomePercentileCondition other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.OutcomeId == other.OutcomeId ||
					this.OutcomeId != null &&
					this.OutcomeId.Equals(other.OutcomeId)
				) &&
				(
					this.MaximumPercentile == other.MaximumPercentile ||
					this.MaximumPercentile != null &&
					this.MaximumPercentile.Equals(other.MaximumPercentile)
				) &&
				(
					this.FallbackPercentile == other.FallbackPercentile ||
					this.FallbackPercentile != null &&
					this.FallbackPercentile.Equals(other.FallbackPercentile)
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
				if (this.OutcomeId != null)
					hash = hash * 59 + this.OutcomeId.GetHashCode();

				if (this.MaximumPercentile != null)
					hash = hash * 59 + this.MaximumPercentile.GetHashCode();

				if (this.FallbackPercentile != null)
					hash = hash * 59 + this.FallbackPercentile.GetHashCode();

				return hash;
			}
		}
	}

}
