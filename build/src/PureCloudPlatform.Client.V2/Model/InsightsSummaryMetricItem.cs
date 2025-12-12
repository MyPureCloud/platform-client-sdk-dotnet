using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// InsightsSummaryMetricItem
	/// </summary>
	[DataContract]
	public partial class InsightsSummaryMetricItem : IEquatable<InsightsSummaryMetricItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InsightsSummaryMetricItem" /> class.
		/// </summary>
		/// <param name="Metric">The gamification metric for the data.</param>
		/// <param name="ComparativePeriod">Insights data in the comparative period.</param>
		/// <param name="PrimaryPeriod">Insights data in the primary period.</param>
		/// <param name="PercentOfGoalChange">Percent of goal change.</param>
		/// <param name="ValueChange">Value change.</param>
		public InsightsSummaryMetricItem(AddressableEntityRef Metric = null, InsightsSummaryMetricPeriodPoints ComparativePeriod = null, InsightsSummaryMetricPeriodPoints PrimaryPeriod = null, double? PercentOfGoalChange = null, double? ValueChange = null)
		{
			this.Metric = Metric;
			this.ComparativePeriod = ComparativePeriod;
			this.PrimaryPeriod = PrimaryPeriod;
			this.PercentOfGoalChange = PercentOfGoalChange;
			this.ValueChange = ValueChange;

		}



		/// <summary>
		/// The gamification metric for the data
		/// </summary>
		/// <value>The gamification metric for the data</value>
		[DataMember(Name = "metric", EmitDefaultValue = false)]
		public AddressableEntityRef Metric { get; set; }



		/// <summary>
		/// Insights data in the comparative period
		/// </summary>
		/// <value>Insights data in the comparative period</value>
		[DataMember(Name = "comparativePeriod", EmitDefaultValue = false)]
		public InsightsSummaryMetricPeriodPoints ComparativePeriod { get; set; }



		/// <summary>
		/// Insights data in the primary period
		/// </summary>
		/// <value>Insights data in the primary period</value>
		[DataMember(Name = "primaryPeriod", EmitDefaultValue = false)]
		public InsightsSummaryMetricPeriodPoints PrimaryPeriod { get; set; }



		/// <summary>
		/// Percent of goal change
		/// </summary>
		/// <value>Percent of goal change</value>
		[DataMember(Name = "percentOfGoalChange", EmitDefaultValue = false)]
		public double? PercentOfGoalChange { get; set; }



		/// <summary>
		/// Value change
		/// </summary>
		/// <value>Value change</value>
		[DataMember(Name = "valueChange", EmitDefaultValue = false)]
		public double? ValueChange { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InsightsSummaryMetricItem {\n");

			sb.Append("  Metric: ").Append(Metric).Append("\n");
			sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
			sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
			sb.Append("  PercentOfGoalChange: ").Append(PercentOfGoalChange).Append("\n");
			sb.Append("  ValueChange: ").Append(ValueChange).Append("\n");
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
			return this.Equals(obj as InsightsSummaryMetricItem);
		}

		/// <summary>
		/// Returns true if InsightsSummaryMetricItem instances are equal
		/// </summary>
		/// <param name="other">Instance of InsightsSummaryMetricItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InsightsSummaryMetricItem other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Metric == other.Metric ||
					this.Metric != null &&
					this.Metric.Equals(other.Metric)
				) &&
				(
					this.ComparativePeriod == other.ComparativePeriod ||
					this.ComparativePeriod != null &&
					this.ComparativePeriod.Equals(other.ComparativePeriod)
				) &&
				(
					this.PrimaryPeriod == other.PrimaryPeriod ||
					this.PrimaryPeriod != null &&
					this.PrimaryPeriod.Equals(other.PrimaryPeriod)
				) &&
				(
					this.PercentOfGoalChange == other.PercentOfGoalChange ||
					this.PercentOfGoalChange != null &&
					this.PercentOfGoalChange.Equals(other.PercentOfGoalChange)
				) &&
				(
					this.ValueChange == other.ValueChange ||
					this.ValueChange != null &&
					this.ValueChange.Equals(other.ValueChange)
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
				if (this.Metric != null)
					hash = hash * 59 + this.Metric.GetHashCode();

				if (this.ComparativePeriod != null)
					hash = hash * 59 + this.ComparativePeriod.GetHashCode();

				if (this.PrimaryPeriod != null)
					hash = hash * 59 + this.PrimaryPeriod.GetHashCode();

				if (this.PercentOfGoalChange != null)
					hash = hash * 59 + this.PercentOfGoalChange.GetHashCode();

				if (this.ValueChange != null)
					hash = hash * 59 + this.ValueChange.GetHashCode();

				return hash;
			}
		}
	}

}
