using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AnalyticsDataRetentionResponse
	/// </summary>
	[DataContract]
	public partial class AnalyticsDataRetentionResponse : IEquatable<AnalyticsDataRetentionResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AnalyticsDataRetentionResponse" /> class.
		/// </summary>
		/// <param name="RetentionDays">Analytics data retention period in days for the organization..</param>
		/// <param name="DateCreated">Date and time when the analytics data retention was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateModified">Date and time when the analytics data retention was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public AnalyticsDataRetentionResponse(int? RetentionDays = null, DateTime? DateCreated = null, DateTime? DateModified = null)
		{
			this.RetentionDays = RetentionDays;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;

		}



		/// <summary>
		/// Analytics data retention period in days for the organization.
		/// </summary>
		/// <value>Analytics data retention period in days for the organization.</value>
		[DataMember(Name = "retentionDays", EmitDefaultValue = false)]
		public int? RetentionDays { get; set; }



		/// <summary>
		/// Date and time when the analytics data retention was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date and time when the analytics data retention was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Date and time when the analytics data retention was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date and time when the analytics data retention was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AnalyticsDataRetentionResponse {\n");

			sb.Append("  RetentionDays: ").Append(RetentionDays).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
			return this.Equals(obj as AnalyticsDataRetentionResponse);
		}

		/// <summary>
		/// Returns true if AnalyticsDataRetentionResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of AnalyticsDataRetentionResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AnalyticsDataRetentionResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RetentionDays == other.RetentionDays ||
					this.RetentionDays != null &&
					this.RetentionDays.Equals(other.RetentionDays)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
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
				if (this.RetentionDays != null)
					hash = hash * 59 + this.RetentionDays.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				return hash;
			}
		}
	}

}
