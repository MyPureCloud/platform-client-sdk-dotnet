using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LearningAssignmentAggregateQueryResponseData
	/// </summary>
	[DataContract]
	public partial class LearningAssignmentAggregateQueryResponseData : IEquatable<LearningAssignmentAggregateQueryResponseData>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningAssignmentAggregateQueryResponseData" /> class.
		/// </summary>
		/// <param name="Interval">Specifies the range of due dates to be used for filtering. A maximum of 1 year can be specified in the range. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
		/// <param name="Metrics">The list of aggregated metrics.</param>
		public LearningAssignmentAggregateQueryResponseData(string Interval = null, List<LearningAssignmentAggregateQueryResponseMetric> Metrics = null)
		{
			this.Interval = Interval;
			this.Metrics = Metrics;

		}



		/// <summary>
		/// Specifies the range of due dates to be used for filtering. A maximum of 1 year can be specified in the range. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
		/// </summary>
		/// <value>Specifies the range of due dates to be used for filtering. A maximum of 1 year can be specified in the range. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }



		/// <summary>
		/// The list of aggregated metrics
		/// </summary>
		/// <value>The list of aggregated metrics</value>
		[DataMember(Name = "metrics", EmitDefaultValue = false)]
		public List<LearningAssignmentAggregateQueryResponseMetric> Metrics { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningAssignmentAggregateQueryResponseData {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  Metrics: ").Append(Metrics).Append("\n");
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
			return this.Equals(obj as LearningAssignmentAggregateQueryResponseData);
		}

		/// <summary>
		/// Returns true if LearningAssignmentAggregateQueryResponseData instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningAssignmentAggregateQueryResponseData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningAssignmentAggregateQueryResponseData other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Interval == other.Interval ||
					this.Interval != null &&
					this.Interval.Equals(other.Interval)
				) &&
				(
					this.Metrics == other.Metrics ||
					this.Metrics != null &&
					this.Metrics.SequenceEqual(other.Metrics)
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
				if (this.Interval != null)
					hash = hash * 59 + this.Interval.GetHashCode();

				if (this.Metrics != null)
					hash = hash * 59 + this.Metrics.GetHashCode();

				return hash;
			}
		}
	}

}
