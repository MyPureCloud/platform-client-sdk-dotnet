using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DataIngestionRulesMetadata
	/// </summary>
	[DataContract]
	public partial class DataIngestionRulesMetadata : IEquatable<DataIngestionRulesMetadata>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DataIngestionRulesMetadata" /> class.
		/// </summary>
		/// <param name="CountByStatus">Count of data ingestion rules by status.</param>
		/// <param name="Platform">The platform for which the data ingestion rules are available.</param>
		/// <param name="TotalCount">The total count of data ingestion rule.</param>
		public DataIngestionRulesMetadata(Dictionary<string, int?> CountByStatus = null, string Platform = null, int? TotalCount = null)
		{
			this.CountByStatus = CountByStatus;
			this.Platform = Platform;
			this.TotalCount = TotalCount;

		}



		/// <summary>
		/// Count of data ingestion rules by status
		/// </summary>
		/// <value>Count of data ingestion rules by status</value>
		[DataMember(Name = "countByStatus", EmitDefaultValue = false)]
		public Dictionary<string, int?> CountByStatus { get; set; }



		/// <summary>
		/// The platform for which the data ingestion rules are available
		/// </summary>
		/// <value>The platform for which the data ingestion rules are available</value>
		[DataMember(Name = "platform", EmitDefaultValue = false)]
		public string Platform { get; set; }



		/// <summary>
		/// The total count of data ingestion rule
		/// </summary>
		/// <value>The total count of data ingestion rule</value>
		[DataMember(Name = "totalCount", EmitDefaultValue = false)]
		public int? TotalCount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DataIngestionRulesMetadata {\n");

			sb.Append("  CountByStatus: ").Append(CountByStatus).Append("\n");
			sb.Append("  Platform: ").Append(Platform).Append("\n");
			sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
			return this.Equals(obj as DataIngestionRulesMetadata);
		}

		/// <summary>
		/// Returns true if DataIngestionRulesMetadata instances are equal
		/// </summary>
		/// <param name="other">Instance of DataIngestionRulesMetadata to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DataIngestionRulesMetadata other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.CountByStatus == other.CountByStatus ||
					this.CountByStatus != null &&
					this.CountByStatus.SequenceEqual(other.CountByStatus)
				) &&
				(
					this.Platform == other.Platform ||
					this.Platform != null &&
					this.Platform.Equals(other.Platform)
				) &&
				(
					this.TotalCount == other.TotalCount ||
					this.TotalCount != null &&
					this.TotalCount.Equals(other.TotalCount)
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
				if (this.CountByStatus != null)
					hash = hash * 59 + this.CountByStatus.GetHashCode();

				if (this.Platform != null)
					hash = hash * 59 + this.Platform.GetHashCode();

				if (this.TotalCount != null)
					hash = hash * 59 + this.TotalCount.GetHashCode();

				return hash;
			}
		}
	}

}
