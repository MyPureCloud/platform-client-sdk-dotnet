using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WeekShiftTradeMatchesSummaryResponse
	/// </summary>
	[DataContract]
	public partial class WeekShiftTradeMatchesSummaryResponse : IEquatable<WeekShiftTradeMatchesSummaryResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WeekShiftTradeMatchesSummaryResponse" /> class.
		/// </summary>
		/// <param name="WeekDate">The schedule week date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="Count">The number of trades in the &#39;Matched&#39; state with the initiating shift in the given week.</param>
		/// <param name="CrossWeekReceivingCount">The number of cross-week trades in the &#39;Matched&#39; state with the receiving shift for the given week.</param>
		public WeekShiftTradeMatchesSummaryResponse(String WeekDate = null, int? Count = null, int? CrossWeekReceivingCount = null)
		{
			this.WeekDate = WeekDate;
			this.Count = Count;
			this.CrossWeekReceivingCount = CrossWeekReceivingCount;

		}



		/// <summary>
		/// The schedule week date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The schedule week date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "weekDate", EmitDefaultValue = false)]
		public String WeekDate { get; set; }



		/// <summary>
		/// The number of trades in the &#39;Matched&#39; state with the initiating shift in the given week
		/// </summary>
		/// <value>The number of trades in the &#39;Matched&#39; state with the initiating shift in the given week</value>
		[DataMember(Name = "count", EmitDefaultValue = false)]
		public int? Count { get; set; }



		/// <summary>
		/// The number of cross-week trades in the &#39;Matched&#39; state with the receiving shift for the given week
		/// </summary>
		/// <value>The number of cross-week trades in the &#39;Matched&#39; state with the receiving shift for the given week</value>
		[DataMember(Name = "crossWeekReceivingCount", EmitDefaultValue = false)]
		public int? CrossWeekReceivingCount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WeekShiftTradeMatchesSummaryResponse {\n");

			sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
			sb.Append("  Count: ").Append(Count).Append("\n");
			sb.Append("  CrossWeekReceivingCount: ").Append(CrossWeekReceivingCount).Append("\n");
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
			return this.Equals(obj as WeekShiftTradeMatchesSummaryResponse);
		}

		/// <summary>
		/// Returns true if WeekShiftTradeMatchesSummaryResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of WeekShiftTradeMatchesSummaryResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WeekShiftTradeMatchesSummaryResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.WeekDate == other.WeekDate ||
					this.WeekDate != null &&
					this.WeekDate.Equals(other.WeekDate)
				) &&
				(
					this.Count == other.Count ||
					this.Count != null &&
					this.Count.Equals(other.Count)
				) &&
				(
					this.CrossWeekReceivingCount == other.CrossWeekReceivingCount ||
					this.CrossWeekReceivingCount != null &&
					this.CrossWeekReceivingCount.Equals(other.CrossWeekReceivingCount)
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
				if (this.WeekDate != null)
					hash = hash * 59 + this.WeekDate.GetHashCode();

				if (this.Count != null)
					hash = hash * 59 + this.Count.GetHashCode();

				if (this.CrossWeekReceivingCount != null)
					hash = hash * 59 + this.CrossWeekReceivingCount.GetHashCode();

				return hash;
			}
		}
	}

}
