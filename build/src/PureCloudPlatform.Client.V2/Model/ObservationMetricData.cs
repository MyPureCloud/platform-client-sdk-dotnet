using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ObservationMetricData
	/// </summary>
	[DataContract]
	public partial class ObservationMetricData : IEquatable<ObservationMetricData>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ObservationMetricData" /> class.
		/// </summary>
		/// <param name="Metric">Metric.</param>
		/// <param name="Qualifier">Qualifier.</param>
		/// <param name="Stats">Stats.</param>
		/// <param name="Truncated">Flag for a truncated list of observations. If truncated, the first half of the list of observations will contain the oldest observations and the second half the newest observations..</param>
		/// <param name="Observations">List of observations sorted by timestamp in ascending order. This list may be truncated..</param>
		public ObservationMetricData(string Metric = null, string Qualifier = null, StatisticalSummary Stats = null, bool? Truncated = null, List<ObservationValue> Observations = null)
		{
			this.Metric = Metric;
			this.Qualifier = Qualifier;
			this.Stats = Stats;
			this.Truncated = Truncated;
			this.Observations = Observations;

		}



		/// <summary>
		/// Gets or Sets Metric
		/// </summary>
		[DataMember(Name = "metric", EmitDefaultValue = false)]
		public string Metric { get; set; }



		/// <summary>
		/// Gets or Sets Qualifier
		/// </summary>
		[DataMember(Name = "qualifier", EmitDefaultValue = false)]
		public string Qualifier { get; set; }



		/// <summary>
		/// Gets or Sets Stats
		/// </summary>
		[DataMember(Name = "stats", EmitDefaultValue = false)]
		public StatisticalSummary Stats { get; set; }



		/// <summary>
		/// Flag for a truncated list of observations. If truncated, the first half of the list of observations will contain the oldest observations and the second half the newest observations.
		/// </summary>
		/// <value>Flag for a truncated list of observations. If truncated, the first half of the list of observations will contain the oldest observations and the second half the newest observations.</value>
		[DataMember(Name = "truncated", EmitDefaultValue = false)]
		public bool? Truncated { get; set; }



		/// <summary>
		/// List of observations sorted by timestamp in ascending order. This list may be truncated.
		/// </summary>
		/// <value>List of observations sorted by timestamp in ascending order. This list may be truncated.</value>
		[DataMember(Name = "observations", EmitDefaultValue = false)]
		public List<ObservationValue> Observations { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ObservationMetricData {\n");

			sb.Append("  Metric: ").Append(Metric).Append("\n");
			sb.Append("  Qualifier: ").Append(Qualifier).Append("\n");
			sb.Append("  Stats: ").Append(Stats).Append("\n");
			sb.Append("  Truncated: ").Append(Truncated).Append("\n");
			sb.Append("  Observations: ").Append(Observations).Append("\n");
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
			return this.Equals(obj as ObservationMetricData);
		}

		/// <summary>
		/// Returns true if ObservationMetricData instances are equal
		/// </summary>
		/// <param name="other">Instance of ObservationMetricData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ObservationMetricData other)
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
					this.Qualifier == other.Qualifier ||
					this.Qualifier != null &&
					this.Qualifier.Equals(other.Qualifier)
				) &&
				(
					this.Stats == other.Stats ||
					this.Stats != null &&
					this.Stats.Equals(other.Stats)
				) &&
				(
					this.Truncated == other.Truncated ||
					this.Truncated != null &&
					this.Truncated.Equals(other.Truncated)
				) &&
				(
					this.Observations == other.Observations ||
					this.Observations != null &&
					this.Observations.SequenceEqual(other.Observations)
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

				if (this.Qualifier != null)
					hash = hash * 59 + this.Qualifier.GetHashCode();

				if (this.Stats != null)
					hash = hash * 59 + this.Stats.GetHashCode();

				if (this.Truncated != null)
					hash = hash * 59 + this.Truncated.GetHashCode();

				if (this.Observations != null)
					hash = hash * 59 + this.Observations.GetHashCode();

				return hash;
			}
		}
	}

}
