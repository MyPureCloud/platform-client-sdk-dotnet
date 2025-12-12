using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmBuShortTermForecastImportCompleteTopicBuForecastModification
	/// </summary>
	[DataContract]
	public partial class WfmBuShortTermForecastImportCompleteTopicBuForecastModification : IEquatable<WfmBuShortTermForecastImportCompleteTopicBuForecastModification>
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Minimumperinterval for "MinimumPerInterval"
			/// </summary>
			[EnumMember(Value = "MinimumPerInterval")]
			Minimumperinterval,

			/// <summary>
			/// Enum Maximumperinterval for "MaximumPerInterval"
			/// </summary>
			[EnumMember(Value = "MaximumPerInterval")]
			Maximumperinterval,

			/// <summary>
			/// Enum Setvalueperinterval for "SetValuePerInterval"
			/// </summary>
			[EnumMember(Value = "SetValuePerInterval")]
			Setvalueperinterval,

			/// <summary>
			/// Enum Changevalueperinterval for "ChangeValuePerInterval"
			/// </summary>
			[EnumMember(Value = "ChangeValuePerInterval")]
			Changevalueperinterval,

			/// <summary>
			/// Enum Changepercentperinterval for "ChangePercentPerInterval"
			/// </summary>
			[EnumMember(Value = "ChangePercentPerInterval")]
			Changepercentperinterval,

			/// <summary>
			/// Enum Setvalueoverrange for "SetValueOverRange"
			/// </summary>
			[EnumMember(Value = "SetValueOverRange")]
			Setvalueoverrange,

			/// <summary>
			/// Enum Changevalueoverrange for "ChangeValueOverRange"
			/// </summary>
			[EnumMember(Value = "ChangeValueOverRange")]
			Changevalueoverrange,

			/// <summary>
			/// Enum Setvaluesforintervalset for "SetValuesForIntervalSet"
			/// </summary>
			[EnumMember(Value = "SetValuesForIntervalSet")]
			Setvaluesforintervalset,

			/// <summary>
			/// Enum Setmultigranularityvaluesforintervalset for "SetMultiGranularityValuesForIntervalSet"
			/// </summary>
			[EnumMember(Value = "SetMultiGranularityValuesForIntervalSet")]
			Setmultigranularityvaluesforintervalset
		}
		/// <summary>
		/// Gets or Sets Metric
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum MetricEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Offered for "Offered"
			/// </summary>
			[EnumMember(Value = "Offered")]
			Offered,

			/// <summary>
			/// Enum Averagehandletimeseconds for "AverageHandleTimeSeconds"
			/// </summary>
			[EnumMember(Value = "AverageHandleTimeSeconds")]
			Averagehandletimeseconds
		}
		/// <summary>
		/// Gets or Sets LegacyMetric
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum LegacyMetricEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Averageaftercallworktimeseconds for "AverageAfterCallWorkTimeSeconds"
			/// </summary>
			[EnumMember(Value = "AverageAfterCallWorkTimeSeconds")]
			Averageaftercallworktimeseconds,

			/// <summary>
			/// Enum Averagehandletimeseconds for "AverageHandleTimeSeconds"
			/// </summary>
			[EnumMember(Value = "AverageHandleTimeSeconds")]
			Averagehandletimeseconds,

			/// <summary>
			/// Enum Averagetalktimeseconds for "AverageTalkTimeSeconds"
			/// </summary>
			[EnumMember(Value = "AverageTalkTimeSeconds")]
			Averagetalktimeseconds,

			/// <summary>
			/// Enum Offered for "Offered"
			/// </summary>
			[EnumMember(Value = "Offered")]
			Offered
		}
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Gets or Sets Metric
		/// </summary>
		[DataMember(Name = "metric", EmitDefaultValue = false)]
		public MetricEnum? Metric { get; set; }
		/// <summary>
		/// Gets or Sets LegacyMetric
		/// </summary>
		[DataMember(Name = "legacyMetric", EmitDefaultValue = false)]
		public LegacyMetricEnum? LegacyMetric { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmBuShortTermForecastImportCompleteTopicBuForecastModification" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="StartIntervalIndex">StartIntervalIndex.</param>
		/// <param name="EndIntervalIndex">EndIntervalIndex.</param>
		/// <param name="Metric">Metric.</param>
		/// <param name="LegacyMetric">LegacyMetric.</param>
		/// <param name="Value">Value.</param>
		/// <param name="Values">Values.</param>
		/// <param name="SecondaryValues">SecondaryValues.</param>
		/// <param name="Enabled">Enabled.</param>
		/// <param name="Granularity">Granularity.</param>
		/// <param name="SecondaryGranularity">SecondaryGranularity.</param>
		/// <param name="DisplayGranularity">DisplayGranularity.</param>
		/// <param name="PlanningGroupIds">PlanningGroupIds.</param>
		public WfmBuShortTermForecastImportCompleteTopicBuForecastModification(TypeEnum? Type = null, long? StartIntervalIndex = null, long? EndIntervalIndex = null, MetricEnum? Metric = null, LegacyMetricEnum? LegacyMetric = null, double? Value = null, List<WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue> Values = null, List<WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue> SecondaryValues = null, bool? Enabled = null, string Granularity = null, string SecondaryGranularity = null, string DisplayGranularity = null, List<string> PlanningGroupIds = null)
		{
			this.Type = Type;
			this.StartIntervalIndex = StartIntervalIndex;
			this.EndIntervalIndex = EndIntervalIndex;
			this.Metric = Metric;
			this.LegacyMetric = LegacyMetric;
			this.Value = Value;
			this.Values = Values;
			this.SecondaryValues = SecondaryValues;
			this.Enabled = Enabled;
			this.Granularity = Granularity;
			this.SecondaryGranularity = SecondaryGranularity;
			this.DisplayGranularity = DisplayGranularity;
			this.PlanningGroupIds = PlanningGroupIds;

		}





		/// <summary>
		/// Gets or Sets StartIntervalIndex
		/// </summary>
		[DataMember(Name = "startIntervalIndex", EmitDefaultValue = false)]
		public long? StartIntervalIndex { get; set; }



		/// <summary>
		/// Gets or Sets EndIntervalIndex
		/// </summary>
		[DataMember(Name = "endIntervalIndex", EmitDefaultValue = false)]
		public long? EndIntervalIndex { get; set; }







		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public double? Value { get; set; }



		/// <summary>
		/// Gets or Sets Values
		/// </summary>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue> Values { get; set; }



		/// <summary>
		/// Gets or Sets SecondaryValues
		/// </summary>
		[DataMember(Name = "secondaryValues", EmitDefaultValue = false)]
		public List<WfmBuShortTermForecastImportCompleteTopicModificationIntervalOffsetValue> SecondaryValues { get; set; }



		/// <summary>
		/// Gets or Sets Enabled
		/// </summary>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }



		/// <summary>
		/// Gets or Sets Granularity
		/// </summary>
		[DataMember(Name = "granularity", EmitDefaultValue = false)]
		public string Granularity { get; set; }



		/// <summary>
		/// Gets or Sets SecondaryGranularity
		/// </summary>
		[DataMember(Name = "secondaryGranularity", EmitDefaultValue = false)]
		public string SecondaryGranularity { get; set; }



		/// <summary>
		/// Gets or Sets DisplayGranularity
		/// </summary>
		[DataMember(Name = "displayGranularity", EmitDefaultValue = false)]
		public string DisplayGranularity { get; set; }



		/// <summary>
		/// Gets or Sets PlanningGroupIds
		/// </summary>
		[DataMember(Name = "planningGroupIds", EmitDefaultValue = false)]
		public List<string> PlanningGroupIds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmBuShortTermForecastImportCompleteTopicBuForecastModification {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  StartIntervalIndex: ").Append(StartIntervalIndex).Append("\n");
			sb.Append("  EndIntervalIndex: ").Append(EndIntervalIndex).Append("\n");
			sb.Append("  Metric: ").Append(Metric).Append("\n");
			sb.Append("  LegacyMetric: ").Append(LegacyMetric).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("  Values: ").Append(Values).Append("\n");
			sb.Append("  SecondaryValues: ").Append(SecondaryValues).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  Granularity: ").Append(Granularity).Append("\n");
			sb.Append("  SecondaryGranularity: ").Append(SecondaryGranularity).Append("\n");
			sb.Append("  DisplayGranularity: ").Append(DisplayGranularity).Append("\n");
			sb.Append("  PlanningGroupIds: ").Append(PlanningGroupIds).Append("\n");
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
			return this.Equals(obj as WfmBuShortTermForecastImportCompleteTopicBuForecastModification);
		}

		/// <summary>
		/// Returns true if WfmBuShortTermForecastImportCompleteTopicBuForecastModification instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmBuShortTermForecastImportCompleteTopicBuForecastModification to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmBuShortTermForecastImportCompleteTopicBuForecastModification other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.StartIntervalIndex == other.StartIntervalIndex ||
					this.StartIntervalIndex != null &&
					this.StartIntervalIndex.Equals(other.StartIntervalIndex)
				) &&
				(
					this.EndIntervalIndex == other.EndIntervalIndex ||
					this.EndIntervalIndex != null &&
					this.EndIntervalIndex.Equals(other.EndIntervalIndex)
				) &&
				(
					this.Metric == other.Metric ||
					this.Metric != null &&
					this.Metric.Equals(other.Metric)
				) &&
				(
					this.LegacyMetric == other.LegacyMetric ||
					this.LegacyMetric != null &&
					this.LegacyMetric.Equals(other.LegacyMetric)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
				) &&
				(
					this.Values == other.Values ||
					this.Values != null &&
					this.Values.SequenceEqual(other.Values)
				) &&
				(
					this.SecondaryValues == other.SecondaryValues ||
					this.SecondaryValues != null &&
					this.SecondaryValues.SequenceEqual(other.SecondaryValues)
				) &&
				(
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
				) &&
				(
					this.Granularity == other.Granularity ||
					this.Granularity != null &&
					this.Granularity.Equals(other.Granularity)
				) &&
				(
					this.SecondaryGranularity == other.SecondaryGranularity ||
					this.SecondaryGranularity != null &&
					this.SecondaryGranularity.Equals(other.SecondaryGranularity)
				) &&
				(
					this.DisplayGranularity == other.DisplayGranularity ||
					this.DisplayGranularity != null &&
					this.DisplayGranularity.Equals(other.DisplayGranularity)
				) &&
				(
					this.PlanningGroupIds == other.PlanningGroupIds ||
					this.PlanningGroupIds != null &&
					this.PlanningGroupIds.SequenceEqual(other.PlanningGroupIds)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.StartIntervalIndex != null)
					hash = hash * 59 + this.StartIntervalIndex.GetHashCode();

				if (this.EndIntervalIndex != null)
					hash = hash * 59 + this.EndIntervalIndex.GetHashCode();

				if (this.Metric != null)
					hash = hash * 59 + this.Metric.GetHashCode();

				if (this.LegacyMetric != null)
					hash = hash * 59 + this.LegacyMetric.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				if (this.Values != null)
					hash = hash * 59 + this.Values.GetHashCode();

				if (this.SecondaryValues != null)
					hash = hash * 59 + this.SecondaryValues.GetHashCode();

				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				if (this.Granularity != null)
					hash = hash * 59 + this.Granularity.GetHashCode();

				if (this.SecondaryGranularity != null)
					hash = hash * 59 + this.SecondaryGranularity.GetHashCode();

				if (this.DisplayGranularity != null)
					hash = hash * 59 + this.DisplayGranularity.GetHashCode();

				if (this.PlanningGroupIds != null)
					hash = hash * 59 + this.PlanningGroupIds.GetHashCode();

				return hash;
			}
		}
	}

}
