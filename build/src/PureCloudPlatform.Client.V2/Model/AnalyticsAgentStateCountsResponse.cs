using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AnalyticsAgentStateCountsResponse
	/// </summary>
	[DataContract]
	public partial class AnalyticsAgentStateCountsResponse : IEquatable<AnalyticsAgentStateCountsResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AnalyticsAgentStateCountsResponse" /> class.
		/// </summary>
		/// <param name="SegmentCounts">List of count by segment types.</param>
		public AnalyticsAgentStateCountsResponse(List<AgentStateSegmentTypeCount> SegmentCounts = null)
		{
			this.SegmentCounts = SegmentCounts;

		}



		/// <summary>
		/// List of count by segment types
		/// </summary>
		/// <value>List of count by segment types</value>
		[DataMember(Name = "segmentCounts", EmitDefaultValue = false)]
		public List<AgentStateSegmentTypeCount> SegmentCounts { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AnalyticsAgentStateCountsResponse {\n");

			sb.Append("  SegmentCounts: ").Append(SegmentCounts).Append("\n");
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
			return this.Equals(obj as AnalyticsAgentStateCountsResponse);
		}

		/// <summary>
		/// Returns true if AnalyticsAgentStateCountsResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of AnalyticsAgentStateCountsResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AnalyticsAgentStateCountsResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SegmentCounts == other.SegmentCounts ||
					this.SegmentCounts != null &&
					this.SegmentCounts.SequenceEqual(other.SegmentCounts)
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
				if (this.SegmentCounts != null)
					hash = hash * 59 + this.SegmentCounts.GetHashCode();

				return hash;
			}
		}
	}

}
