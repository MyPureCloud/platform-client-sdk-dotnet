using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// InsightsDetailsOverallItem
	/// </summary>
	[DataContract]
	public partial class InsightsDetailsOverallItem : IEquatable<InsightsDetailsOverallItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InsightsDetailsOverallItem" /> class.
		/// </summary>
		/// <param name="ComparativePeriod">Insights data in the comparative period.</param>
		/// <param name="PrimaryPeriod">Insights data in the primary period.</param>
		/// <param name="PercentOfGoalChange">Percent of goal change.</param>
		public InsightsDetailsOverallItem(InsightsDetailsOverallPeriodPoints ComparativePeriod = null, InsightsDetailsOverallPeriodPoints PrimaryPeriod = null, double? PercentOfGoalChange = null)
		{
			this.ComparativePeriod = ComparativePeriod;
			this.PrimaryPeriod = PrimaryPeriod;
			this.PercentOfGoalChange = PercentOfGoalChange;

		}



		/// <summary>
		/// Insights data in the comparative period
		/// </summary>
		/// <value>Insights data in the comparative period</value>
		[DataMember(Name = "comparativePeriod", EmitDefaultValue = false)]
		public InsightsDetailsOverallPeriodPoints ComparativePeriod { get; set; }



		/// <summary>
		/// Insights data in the primary period
		/// </summary>
		/// <value>Insights data in the primary period</value>
		[DataMember(Name = "primaryPeriod", EmitDefaultValue = false)]
		public InsightsDetailsOverallPeriodPoints PrimaryPeriod { get; set; }



		/// <summary>
		/// Percent of goal change
		/// </summary>
		/// <value>Percent of goal change</value>
		[DataMember(Name = "percentOfGoalChange", EmitDefaultValue = false)]
		public double? PercentOfGoalChange { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InsightsDetailsOverallItem {\n");

			sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
			sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
			sb.Append("  PercentOfGoalChange: ").Append(PercentOfGoalChange).Append("\n");
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
			return this.Equals(obj as InsightsDetailsOverallItem);
		}

		/// <summary>
		/// Returns true if InsightsDetailsOverallItem instances are equal
		/// </summary>
		/// <param name="other">Instance of InsightsDetailsOverallItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InsightsDetailsOverallItem other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
				if (this.ComparativePeriod != null)
					hash = hash * 59 + this.ComparativePeriod.GetHashCode();

				if (this.PrimaryPeriod != null)
					hash = hash * 59 + this.PrimaryPeriod.GetHashCode();

				if (this.PercentOfGoalChange != null)
					hash = hash * 59 + this.PercentOfGoalChange.GetHashCode();

				return hash;
			}
		}
	}

}
