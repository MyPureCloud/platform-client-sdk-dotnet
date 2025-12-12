using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FlowAggregationSort
	/// </summary>
	[DataContract]
	public partial class FlowAggregationSort : IEquatable<FlowAggregationSort>
	{
		/// <summary>
		/// Name of the metric used for sorting values.
		/// </summary>
		/// <value>Name of the metric used for sorting values.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum NameEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Nflow for "nFlow"
			/// </summary>
			[EnumMember(Value = "nFlow")]
			Nflow,

			/// <summary>
			/// Enum Nflowmilestone for "nFlowMilestone"
			/// </summary>
			[EnumMember(Value = "nFlowMilestone")]
			Nflowmilestone,

			/// <summary>
			/// Enum Nflowoutcome for "nFlowOutcome"
			/// </summary>
			[EnumMember(Value = "nFlowOutcome")]
			Nflowoutcome,

			/// <summary>
			/// Enum Nflowoutcomefailed for "nFlowOutcomeFailed"
			/// </summary>
			[EnumMember(Value = "nFlowOutcomeFailed")]
			Nflowoutcomefailed,

			/// <summary>
			/// Enum Oflowmilestone for "oFlowMilestone"
			/// </summary>
			[EnumMember(Value = "oFlowMilestone")]
			Oflowmilestone,

			/// <summary>
			/// Enum Tflow for "tFlow"
			/// </summary>
			[EnumMember(Value = "tFlow")]
			Tflow,

			/// <summary>
			/// Enum Tflowdisconnect for "tFlowDisconnect"
			/// </summary>
			[EnumMember(Value = "tFlowDisconnect")]
			Tflowdisconnect,

			/// <summary>
			/// Enum Tflowexit for "tFlowExit"
			/// </summary>
			[EnumMember(Value = "tFlowExit")]
			Tflowexit,

			/// <summary>
			/// Enum Tflowoutcome for "tFlowOutcome"
			/// </summary>
			[EnumMember(Value = "tFlowOutcome")]
			Tflowoutcome
		}
		/// <summary>
		/// Aggregation function used for the sort metric.
		/// </summary>
		/// <value>Aggregation function used for the sort metric.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum FunctionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Average for "average"
			/// </summary>
			[EnumMember(Value = "average")]
			Average,

			/// <summary>
			/// Enum Count for "count"
			/// </summary>
			[EnumMember(Value = "count")]
			Count,

			/// <summary>
			/// Enum Max for "max"
			/// </summary>
			[EnumMember(Value = "max")]
			Max,

			/// <summary>
			/// Enum Min for "min"
			/// </summary>
			[EnumMember(Value = "min")]
			Min,

			/// <summary>
			/// Enum Sum for "sum"
			/// </summary>
			[EnumMember(Value = "sum")]
			Sum
		}
		/// <summary>
		/// Name of the metric used for sorting values.
		/// </summary>
		/// <value>Name of the metric used for sorting values.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public NameEnum? Name { get; set; }
		/// <summary>
		/// Aggregation function used for the sort metric.
		/// </summary>
		/// <value>Aggregation function used for the sort metric.</value>
		[DataMember(Name = "function", EmitDefaultValue = false)]
		public FunctionEnum? Function { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="FlowAggregationSort" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected FlowAggregationSort() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="FlowAggregationSort" /> class.
		/// </summary>
		/// <param name="Name">Name of the metric used for sorting values. (required).</param>
		/// <param name="Function">Aggregation function used for the sort metric. (required).</param>
		public FlowAggregationSort(NameEnum? Name = null, FunctionEnum? Function = null)
		{
			this.Name = Name;
			this.Function = Function;

		}






		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FlowAggregationSort {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Function: ").Append(Function).Append("\n");
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
			return this.Equals(obj as FlowAggregationSort);
		}

		/// <summary>
		/// Returns true if FlowAggregationSort instances are equal
		/// </summary>
		/// <param name="other">Instance of FlowAggregationSort to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FlowAggregationSort other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Function == other.Function ||
					this.Function != null &&
					this.Function.Equals(other.Function)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Function != null)
					hash = hash * 59 + this.Function.GetHashCode();

				return hash;
			}
		}
	}

}
