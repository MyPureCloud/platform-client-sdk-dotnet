using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserActivityQueryMetric
	/// </summary>
	[DataContract]
	public partial class UserActivityQueryMetric : IEquatable<UserActivityQueryMetric>
	{
		/// <summary>
		/// The requested metric
		/// </summary>
		/// <value>The requested metric</value>
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
			/// Enum Oactivequeues for "oActiveQueues"
			/// </summary>
			[EnumMember(Value = "oActiveQueues")]
			Oactivequeues,

			/// <summary>
			/// Enum Omemberqueues for "oMemberQueues"
			/// </summary>
			[EnumMember(Value = "oMemberQueues")]
			Omemberqueues
		}
		/// <summary>
		/// The requested metric
		/// </summary>
		/// <value>The requested metric</value>
		[DataMember(Name = "metric", EmitDefaultValue = false)]
		public MetricEnum? Metric { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="UserActivityQueryMetric" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UserActivityQueryMetric() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UserActivityQueryMetric" /> class.
		/// </summary>
		/// <param name="Metric">The requested metric (required).</param>
		/// <param name="Details">Flag for including observation details for this metric in the response.</param>
		public UserActivityQueryMetric(MetricEnum? Metric = null, bool? Details = null)
		{
			this.Metric = Metric;
			this.Details = Details;

		}





		/// <summary>
		/// Flag for including observation details for this metric in the response
		/// </summary>
		/// <value>Flag for including observation details for this metric in the response</value>
		[DataMember(Name = "details", EmitDefaultValue = false)]
		public bool? Details { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserActivityQueryMetric {\n");

			sb.Append("  Metric: ").Append(Metric).Append("\n");
			sb.Append("  Details: ").Append(Details).Append("\n");
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
			return this.Equals(obj as UserActivityQueryMetric);
		}

		/// <summary>
		/// Returns true if UserActivityQueryMetric instances are equal
		/// </summary>
		/// <param name="other">Instance of UserActivityQueryMetric to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserActivityQueryMetric other)
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
					this.Details == other.Details ||
					this.Details != null &&
					this.Details.Equals(other.Details)
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

				if (this.Details != null)
					hash = hash * 59 + this.Details.GetHashCode();

				return hash;
			}
		}
	}

}
