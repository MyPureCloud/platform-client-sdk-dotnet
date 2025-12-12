using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// External metric data write response
	/// </summary>
	[DataContract]
	public partial class ExternalMetricDataWriteResponse : IEquatable<ExternalMetricDataWriteResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExternalMetricDataWriteResponse" /> class.
		/// </summary>
		/// <param name="ProcessedEntities">The list of processed entities.</param>
		/// <param name="UnprocessedEntities">The list of unprocessed entities.</param>
		public ExternalMetricDataWriteResponse(List<ExternalMetricDataProcessedItem> ProcessedEntities = null, List<ExternalMetricDataUnprocessedItem> UnprocessedEntities = null)
		{
			this.ProcessedEntities = ProcessedEntities;
			this.UnprocessedEntities = UnprocessedEntities;

		}



		/// <summary>
		/// The list of processed entities
		/// </summary>
		/// <value>The list of processed entities</value>
		[DataMember(Name = "processedEntities", EmitDefaultValue = false)]
		public List<ExternalMetricDataProcessedItem> ProcessedEntities { get; set; }



		/// <summary>
		/// The list of unprocessed entities
		/// </summary>
		/// <value>The list of unprocessed entities</value>
		[DataMember(Name = "unprocessedEntities", EmitDefaultValue = false)]
		public List<ExternalMetricDataUnprocessedItem> UnprocessedEntities { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ExternalMetricDataWriteResponse {\n");

			sb.Append("  ProcessedEntities: ").Append(ProcessedEntities).Append("\n");
			sb.Append("  UnprocessedEntities: ").Append(UnprocessedEntities).Append("\n");
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
			return this.Equals(obj as ExternalMetricDataWriteResponse);
		}

		/// <summary>
		/// Returns true if ExternalMetricDataWriteResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ExternalMetricDataWriteResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ExternalMetricDataWriteResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ProcessedEntities == other.ProcessedEntities ||
					this.ProcessedEntities != null &&
					this.ProcessedEntities.SequenceEqual(other.ProcessedEntities)
				) &&
				(
					this.UnprocessedEntities == other.UnprocessedEntities ||
					this.UnprocessedEntities != null &&
					this.UnprocessedEntities.SequenceEqual(other.UnprocessedEntities)
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
				if (this.ProcessedEntities != null)
					hash = hash * 59 + this.ProcessedEntities.GetHashCode();

				if (this.UnprocessedEntities != null)
					hash = hash * 59 + this.UnprocessedEntities.GetHashCode();

				return hash;
			}
		}
	}

}
