using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// NluQualityReportSummary
	/// </summary>
	[DataContract]
	public partial class NluQualityReportSummary : IEquatable<NluQualityReportSummary>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="NluQualityReportSummary" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected NluQualityReportSummary() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="NluQualityReportSummary" /> class.
		/// </summary>
		/// <param name="Metrics">The list of metrics in the summary (required).</param>
		public NluQualityReportSummary(List<NluQualityReportSummaryMetric> Metrics = null)
		{
			this.Metrics = Metrics;

		}



		/// <summary>
		/// The list of metrics in the summary
		/// </summary>
		/// <value>The list of metrics in the summary</value>
		[DataMember(Name = "metrics", EmitDefaultValue = false)]
		public List<NluQualityReportSummaryMetric> Metrics { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NluQualityReportSummary {\n");

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
			return this.Equals(obj as NluQualityReportSummary);
		}

		/// <summary>
		/// Returns true if NluQualityReportSummary instances are equal
		/// </summary>
		/// <param name="other">Instance of NluQualityReportSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NluQualityReportSummary other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
				if (this.Metrics != null)
					hash = hash * 59 + this.Metrics.GetHashCode();

				return hash;
			}
		}
	}

}
