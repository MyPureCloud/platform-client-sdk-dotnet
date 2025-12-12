using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AnalyticsFlowOutcome
	/// </summary>
	[DataContract]
	public partial class AnalyticsFlowOutcome : IEquatable<AnalyticsFlowOutcome>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AnalyticsFlowOutcome" /> class.
		/// </summary>
		/// <param name="FlowOutcome">Combination of unique flow outcome identifier and its value separated by colon.</param>
		/// <param name="FlowOutcomeEndTimestamp">The outcome ending timestamp in ISO 8601 format. This may be null if the outcome did not succeed..</param>
		/// <param name="FlowOutcomeId">Unique identifier of a flow outcome.</param>
		/// <param name="FlowOutcomeStartTimestamp">The outcome starting timestamp in ISO 8601 format.</param>
		/// <param name="FlowOutcomeValue">Flow outcome value, e.g. SUCCESS.</param>
		public AnalyticsFlowOutcome(string FlowOutcome = null, DateTime? FlowOutcomeEndTimestamp = null, string FlowOutcomeId = null, DateTime? FlowOutcomeStartTimestamp = null, string FlowOutcomeValue = null)
		{
			this.FlowOutcome = FlowOutcome;
			this.FlowOutcomeEndTimestamp = FlowOutcomeEndTimestamp;
			this.FlowOutcomeId = FlowOutcomeId;
			this.FlowOutcomeStartTimestamp = FlowOutcomeStartTimestamp;
			this.FlowOutcomeValue = FlowOutcomeValue;

		}



		/// <summary>
		/// Combination of unique flow outcome identifier and its value separated by colon
		/// </summary>
		/// <value>Combination of unique flow outcome identifier and its value separated by colon</value>
		[DataMember(Name = "flowOutcome", EmitDefaultValue = false)]
		public string FlowOutcome { get; set; }



		/// <summary>
		/// The outcome ending timestamp in ISO 8601 format. This may be null if the outcome did not succeed.
		/// </summary>
		/// <value>The outcome ending timestamp in ISO 8601 format. This may be null if the outcome did not succeed.</value>
		[DataMember(Name = "flowOutcomeEndTimestamp", EmitDefaultValue = false)]
		public DateTime? FlowOutcomeEndTimestamp { get; set; }



		/// <summary>
		/// Unique identifier of a flow outcome
		/// </summary>
		/// <value>Unique identifier of a flow outcome</value>
		[DataMember(Name = "flowOutcomeId", EmitDefaultValue = false)]
		public string FlowOutcomeId { get; set; }



		/// <summary>
		/// The outcome starting timestamp in ISO 8601 format
		/// </summary>
		/// <value>The outcome starting timestamp in ISO 8601 format</value>
		[DataMember(Name = "flowOutcomeStartTimestamp", EmitDefaultValue = false)]
		public DateTime? FlowOutcomeStartTimestamp { get; set; }



		/// <summary>
		/// Flow outcome value, e.g. SUCCESS
		/// </summary>
		/// <value>Flow outcome value, e.g. SUCCESS</value>
		[DataMember(Name = "flowOutcomeValue", EmitDefaultValue = false)]
		public string FlowOutcomeValue { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AnalyticsFlowOutcome {\n");

			sb.Append("  FlowOutcome: ").Append(FlowOutcome).Append("\n");
			sb.Append("  FlowOutcomeEndTimestamp: ").Append(FlowOutcomeEndTimestamp).Append("\n");
			sb.Append("  FlowOutcomeId: ").Append(FlowOutcomeId).Append("\n");
			sb.Append("  FlowOutcomeStartTimestamp: ").Append(FlowOutcomeStartTimestamp).Append("\n");
			sb.Append("  FlowOutcomeValue: ").Append(FlowOutcomeValue).Append("\n");
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
			return this.Equals(obj as AnalyticsFlowOutcome);
		}

		/// <summary>
		/// Returns true if AnalyticsFlowOutcome instances are equal
		/// </summary>
		/// <param name="other">Instance of AnalyticsFlowOutcome to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AnalyticsFlowOutcome other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FlowOutcome == other.FlowOutcome ||
					this.FlowOutcome != null &&
					this.FlowOutcome.Equals(other.FlowOutcome)
				) &&
				(
					this.FlowOutcomeEndTimestamp == other.FlowOutcomeEndTimestamp ||
					this.FlowOutcomeEndTimestamp != null &&
					this.FlowOutcomeEndTimestamp.Equals(other.FlowOutcomeEndTimestamp)
				) &&
				(
					this.FlowOutcomeId == other.FlowOutcomeId ||
					this.FlowOutcomeId != null &&
					this.FlowOutcomeId.Equals(other.FlowOutcomeId)
				) &&
				(
					this.FlowOutcomeStartTimestamp == other.FlowOutcomeStartTimestamp ||
					this.FlowOutcomeStartTimestamp != null &&
					this.FlowOutcomeStartTimestamp.Equals(other.FlowOutcomeStartTimestamp)
				) &&
				(
					this.FlowOutcomeValue == other.FlowOutcomeValue ||
					this.FlowOutcomeValue != null &&
					this.FlowOutcomeValue.Equals(other.FlowOutcomeValue)
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
				if (this.FlowOutcome != null)
					hash = hash * 59 + this.FlowOutcome.GetHashCode();

				if (this.FlowOutcomeEndTimestamp != null)
					hash = hash * 59 + this.FlowOutcomeEndTimestamp.GetHashCode();

				if (this.FlowOutcomeId != null)
					hash = hash * 59 + this.FlowOutcomeId.GetHashCode();

				if (this.FlowOutcomeStartTimestamp != null)
					hash = hash * 59 + this.FlowOutcomeStartTimestamp.GetHashCode();

				if (this.FlowOutcomeValue != null)
					hash = hash * 59 + this.FlowOutcomeValue.GetHashCode();

				return hash;
			}
		}
	}

}
