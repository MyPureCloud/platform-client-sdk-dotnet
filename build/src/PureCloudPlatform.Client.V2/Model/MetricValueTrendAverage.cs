using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MetricValueTrendAverage
	/// </summary>
	[DataContract]
	public partial class MetricValueTrendAverage : IEquatable<MetricValueTrendAverage>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MetricValueTrendAverage" /> class.
		/// </summary>
		public MetricValueTrendAverage()
		{

		}



		/// <summary>
		/// The targeted start workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The targeted start workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateStartWorkday", EmitDefaultValue = false)]
		public String DateStartWorkday { get; private set; }



		/// <summary>
		/// The targeted end workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The targeted end workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateEndWorkday", EmitDefaultValue = false)]
		public String DateEndWorkday { get; private set; }



		/// <summary>
		/// The targeted reference workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The targeted reference workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateReferenceWorkday", EmitDefaultValue = false)]
		public String DateReferenceWorkday { get; private set; }



		/// <summary>
		/// The targeted division for the metrics
		/// </summary>
		/// <value>The targeted division for the metrics</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public Division Division { get; private set; }



		/// <summary>
		/// The targeted user for the metrics
		/// </summary>
		/// <value>The targeted user for the metrics</value>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public UserReference User { get; private set; }



		/// <summary>
		/// The time zone used for aggregating metric values
		/// </summary>
		/// <value>The time zone used for aggregating metric values</value>
		[DataMember(Name = "timezone", EmitDefaultValue = false)]
		public string Timezone { get; private set; }



		/// <summary>
		/// The metric value trend and average
		/// </summary>
		/// <value>The metric value trend and average</value>
		[DataMember(Name = "result", EmitDefaultValue = false)]
		public WorkdayValuesMetricItem Result { get; private set; }



		/// <summary>
		/// The targeted performance profile for the average points
		/// </summary>
		/// <value>The targeted performance profile for the average points</value>
		[DataMember(Name = "performanceProfile", EmitDefaultValue = false)]
		public AddressableEntityRef PerformanceProfile { get; private set; }



		/// <summary>
		/// The targeted performance profile for the average points
		/// </summary>
		/// <value>The targeted performance profile for the average points</value>
		[DataMember(Name = "metric", EmitDefaultValue = false)]
		public AddressableEntityRef Metric { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MetricValueTrendAverage {\n");

			sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
			sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
			sb.Append("  DateReferenceWorkday: ").Append(DateReferenceWorkday).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  User: ").Append(User).Append("\n");
			sb.Append("  Timezone: ").Append(Timezone).Append("\n");
			sb.Append("  Result: ").Append(Result).Append("\n");
			sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
			sb.Append("  Metric: ").Append(Metric).Append("\n");
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
			return this.Equals(obj as MetricValueTrendAverage);
		}

		/// <summary>
		/// Returns true if MetricValueTrendAverage instances are equal
		/// </summary>
		/// <param name="other">Instance of MetricValueTrendAverage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MetricValueTrendAverage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DateStartWorkday == other.DateStartWorkday ||
					this.DateStartWorkday != null &&
					this.DateStartWorkday.Equals(other.DateStartWorkday)
				) &&
				(
					this.DateEndWorkday == other.DateEndWorkday ||
					this.DateEndWorkday != null &&
					this.DateEndWorkday.Equals(other.DateEndWorkday)
				) &&
				(
					this.DateReferenceWorkday == other.DateReferenceWorkday ||
					this.DateReferenceWorkday != null &&
					this.DateReferenceWorkday.Equals(other.DateReferenceWorkday)
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.User == other.User ||
					this.User != null &&
					this.User.Equals(other.User)
				) &&
				(
					this.Timezone == other.Timezone ||
					this.Timezone != null &&
					this.Timezone.Equals(other.Timezone)
				) &&
				(
					this.Result == other.Result ||
					this.Result != null &&
					this.Result.Equals(other.Result)
				) &&
				(
					this.PerformanceProfile == other.PerformanceProfile ||
					this.PerformanceProfile != null &&
					this.PerformanceProfile.Equals(other.PerformanceProfile)
				) &&
				(
					this.Metric == other.Metric ||
					this.Metric != null &&
					this.Metric.Equals(other.Metric)
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
				if (this.DateStartWorkday != null)
					hash = hash * 59 + this.DateStartWorkday.GetHashCode();

				if (this.DateEndWorkday != null)
					hash = hash * 59 + this.DateEndWorkday.GetHashCode();

				if (this.DateReferenceWorkday != null)
					hash = hash * 59 + this.DateReferenceWorkday.GetHashCode();

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.User != null)
					hash = hash * 59 + this.User.GetHashCode();

				if (this.Timezone != null)
					hash = hash * 59 + this.Timezone.GetHashCode();

				if (this.Result != null)
					hash = hash * 59 + this.Result.GetHashCode();

				if (this.PerformanceProfile != null)
					hash = hash * 59 + this.PerformanceProfile.GetHashCode();

				if (this.Metric != null)
					hash = hash * 59 + this.Metric.GetHashCode();

				return hash;
			}
		}
	}

}
