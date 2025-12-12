using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkdayValuesMetricItem
	/// </summary>
	[DataContract]
	public partial class WorkdayValuesMetricItem : IEquatable<WorkdayValuesMetricItem>
	{
		/// <summary>
		/// The unit type of the metric value
		/// </summary>
		/// <value>The unit type of the metric value</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum UnitTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum None for "None"
			/// </summary>
			[EnumMember(Value = "None")]
			None,

			/// <summary>
			/// Enum Percent for "Percent"
			/// </summary>
			[EnumMember(Value = "Percent")]
			Percent,

			/// <summary>
			/// Enum Currency for "Currency"
			/// </summary>
			[EnumMember(Value = "Currency")]
			Currency,

			/// <summary>
			/// Enum Seconds for "Seconds"
			/// </summary>
			[EnumMember(Value = "Seconds")]
			Seconds,

			/// <summary>
			/// Enum Number for "Number"
			/// </summary>
			[EnumMember(Value = "Number")]
			Number,

			/// <summary>
			/// Enum Attendancestatus for "AttendanceStatus"
			/// </summary>
			[EnumMember(Value = "AttendanceStatus")]
			Attendancestatus,

			/// <summary>
			/// Enum Unit for "Unit"
			/// </summary>
			[EnumMember(Value = "Unit")]
			Unit
		}
		/// <summary>
		/// The unit type of the metric value
		/// </summary>
		/// <value>The unit type of the metric value</value>
		[DataMember(Name = "unitType", EmitDefaultValue = false)]
		public UnitTypeEnum? UnitType { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkdayValuesMetricItem" /> class.
		/// </summary>
		public WorkdayValuesMetricItem()
		{

		}



		/// <summary>
		/// Gamification metric for the average and the trend
		/// </summary>
		/// <value>Gamification metric for the average and the trend</value>
		[DataMember(Name = "metric", EmitDefaultValue = false)]
		public AddressableEntityRef Metric { get; private set; }



		/// <summary>
		/// Gamification metric definition for the average and the trend
		/// </summary>
		/// <value>Gamification metric definition for the average and the trend</value>
		[DataMember(Name = "metricDefinition", EmitDefaultValue = false)]
		public DomainEntityRef MetricDefinition { get; private set; }



		/// <summary>
		/// The average value of the metric
		/// </summary>
		/// <value>The average value of the metric</value>
		[DataMember(Name = "average", EmitDefaultValue = false)]
		public double? Average { get; private set; }





		/// <summary>
		/// The metric value trend
		/// </summary>
		/// <value>The metric value trend</value>
		[DataMember(Name = "trend", EmitDefaultValue = false)]
		public List<WorkdayValuesTrendItem> Trend { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkdayValuesMetricItem {\n");

			sb.Append("  Metric: ").Append(Metric).Append("\n");
			sb.Append("  MetricDefinition: ").Append(MetricDefinition).Append("\n");
			sb.Append("  Average: ").Append(Average).Append("\n");
			sb.Append("  UnitType: ").Append(UnitType).Append("\n");
			sb.Append("  Trend: ").Append(Trend).Append("\n");
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
			return this.Equals(obj as WorkdayValuesMetricItem);
		}

		/// <summary>
		/// Returns true if WorkdayValuesMetricItem instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkdayValuesMetricItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkdayValuesMetricItem other)
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
					this.MetricDefinition == other.MetricDefinition ||
					this.MetricDefinition != null &&
					this.MetricDefinition.Equals(other.MetricDefinition)
				) &&
				(
					this.Average == other.Average ||
					this.Average != null &&
					this.Average.Equals(other.Average)
				) &&
				(
					this.UnitType == other.UnitType ||
					this.UnitType != null &&
					this.UnitType.Equals(other.UnitType)
				) &&
				(
					this.Trend == other.Trend ||
					this.Trend != null &&
					this.Trend.SequenceEqual(other.Trend)
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

				if (this.MetricDefinition != null)
					hash = hash * 59 + this.MetricDefinition.GetHashCode();

				if (this.Average != null)
					hash = hash * 59 + this.Average.GetHashCode();

				if (this.UnitType != null)
					hash = hash * 59 + this.UnitType.GetHashCode();

				if (this.Trend != null)
					hash = hash * 59 + this.Trend.GetHashCode();

				return hash;
			}
		}
	}

}
