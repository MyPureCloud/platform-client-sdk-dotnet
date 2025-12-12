using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConditionalGroupActivationSimpleMetric
	/// </summary>
	[DataContract]
	public partial class ConditionalGroupActivationSimpleMetric : IEquatable<ConditionalGroupActivationSimpleMetric>
	{
		/// <summary>
		/// The queue metric being evaluated
		/// </summary>
		/// <value>The queue metric being evaluated</value>
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
			/// Enum Estimatedwaittime for "EstimatedWaitTime"
			/// </summary>
			[EnumMember(Value = "EstimatedWaitTime")]
			Estimatedwaittime,

			/// <summary>
			/// Enum Idleagentcount for "IdleAgentCount"
			/// </summary>
			[EnumMember(Value = "IdleAgentCount")]
			Idleagentcount,

			/// <summary>
			/// Enum Servicelevel for "ServiceLevel"
			/// </summary>
			[EnumMember(Value = "ServiceLevel")]
			Servicelevel
		}
		/// <summary>
		/// The queue metric being evaluated
		/// </summary>
		/// <value>The queue metric being evaluated</value>
		[DataMember(Name = "metric", EmitDefaultValue = false)]
		public MetricEnum? Metric { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConditionalGroupActivationSimpleMetric" /> class.
		/// </summary>
		/// <param name="Metric">The queue metric being evaluated.</param>
		/// <param name="Queue">The queue being evaluated for this rule.  If null, the current queue will be used..</param>
		public ConditionalGroupActivationSimpleMetric(MetricEnum? Metric = null, DomainEntityRef Queue = null)
		{
			this.Metric = Metric;
			this.Queue = Queue;

		}





		/// <summary>
		/// The queue being evaluated for this rule.  If null, the current queue will be used.
		/// </summary>
		/// <value>The queue being evaluated for this rule.  If null, the current queue will be used.</value>
		[DataMember(Name = "queue", EmitDefaultValue = false)]
		public DomainEntityRef Queue { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConditionalGroupActivationSimpleMetric {\n");

			sb.Append("  Metric: ").Append(Metric).Append("\n");
			sb.Append("  Queue: ").Append(Queue).Append("\n");
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
			return this.Equals(obj as ConditionalGroupActivationSimpleMetric);
		}

		/// <summary>
		/// Returns true if ConditionalGroupActivationSimpleMetric instances are equal
		/// </summary>
		/// <param name="other">Instance of ConditionalGroupActivationSimpleMetric to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConditionalGroupActivationSimpleMetric other)
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
					this.Queue == other.Queue ||
					this.Queue != null &&
					this.Queue.Equals(other.Queue)
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

				if (this.Queue != null)
					hash = hash * 59 + this.Queue.GetHashCode();

				return hash;
			}
		}
	}

}
