using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AnalyticsUserDetailsQueryResponse
	/// </summary>
	[DataContract]
	public partial class AnalyticsUserDetailsQueryResponse : IEquatable<AnalyticsUserDetailsQueryResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AnalyticsUserDetailsQueryResponse" /> class.
		/// </summary>
		/// <param name="UserDetails">UserDetails.</param>
		/// <param name="Aggregations">Aggregations.</param>
		/// <param name="TotalHits">TotalHits.</param>
		public AnalyticsUserDetailsQueryResponse(List<AnalyticsUserDetail> UserDetails = null, List<AggregationResult> Aggregations = null, int? TotalHits = null)
		{
			this.UserDetails = UserDetails;
			this.Aggregations = Aggregations;
			this.TotalHits = TotalHits;

		}



		/// <summary>
		/// Gets or Sets UserDetails
		/// </summary>
		[DataMember(Name = "userDetails", EmitDefaultValue = false)]
		public List<AnalyticsUserDetail> UserDetails { get; set; }



		/// <summary>
		/// Gets or Sets Aggregations
		/// </summary>
		[DataMember(Name = "aggregations", EmitDefaultValue = false)]
		public List<AggregationResult> Aggregations { get; set; }



		/// <summary>
		/// Gets or Sets TotalHits
		/// </summary>
		[DataMember(Name = "totalHits", EmitDefaultValue = false)]
		public int? TotalHits { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AnalyticsUserDetailsQueryResponse {\n");

			sb.Append("  UserDetails: ").Append(UserDetails).Append("\n");
			sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
			sb.Append("  TotalHits: ").Append(TotalHits).Append("\n");
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
			return this.Equals(obj as AnalyticsUserDetailsQueryResponse);
		}

		/// <summary>
		/// Returns true if AnalyticsUserDetailsQueryResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of AnalyticsUserDetailsQueryResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AnalyticsUserDetailsQueryResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.UserDetails == other.UserDetails ||
					this.UserDetails != null &&
					this.UserDetails.SequenceEqual(other.UserDetails)
				) &&
				(
					this.Aggregations == other.Aggregations ||
					this.Aggregations != null &&
					this.Aggregations.SequenceEqual(other.Aggregations)
				) &&
				(
					this.TotalHits == other.TotalHits ||
					this.TotalHits != null &&
					this.TotalHits.Equals(other.TotalHits)
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
				if (this.UserDetails != null)
					hash = hash * 59 + this.UserDetails.GetHashCode();

				if (this.Aggregations != null)
					hash = hash * 59 + this.Aggregations.GetHashCode();

				if (this.TotalHits != null)
					hash = hash * 59 + this.TotalHits.GetHashCode();

				return hash;
			}
		}
	}

}
