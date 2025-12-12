using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TimeOffBalanceResponse
	/// </summary>
	[DataContract]
	public partial class TimeOffBalanceResponse : IEquatable<TimeOffBalanceResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TimeOffBalanceResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TimeOffBalanceResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TimeOffBalanceResponse" /> class.
		/// </summary>
		/// <param name="ActivityCodeId">The ID for activity code associated with time off balance (required).</param>
		/// <param name="HrisTimeOffTypeId">The ID of the time off type configured in HRIS integration (required).</param>
		/// <param name="HrisTimeOffTypeSecondaryId">The secondary ID of the time off type configured in HRIS integration.</param>
		/// <param name="StartDate">The Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="BalanceMinutesPerDay">The list of available time off balance values in minutes for each day.</param>
		public TimeOffBalanceResponse(string ActivityCodeId = null, string HrisTimeOffTypeId = null, string HrisTimeOffTypeSecondaryId = null, String StartDate = null, List<int?> BalanceMinutesPerDay = null)
		{
			this.ActivityCodeId = ActivityCodeId;
			this.HrisTimeOffTypeId = HrisTimeOffTypeId;
			this.HrisTimeOffTypeSecondaryId = HrisTimeOffTypeSecondaryId;
			this.StartDate = StartDate;
			this.BalanceMinutesPerDay = BalanceMinutesPerDay;

		}



		/// <summary>
		/// The ID for activity code associated with time off balance
		/// </summary>
		/// <value>The ID for activity code associated with time off balance</value>
		[DataMember(Name = "activityCodeId", EmitDefaultValue = false)]
		public string ActivityCodeId { get; set; }



		/// <summary>
		/// The ID of the time off type configured in HRIS integration
		/// </summary>
		/// <value>The ID of the time off type configured in HRIS integration</value>
		[DataMember(Name = "hrisTimeOffTypeId", EmitDefaultValue = false)]
		public string HrisTimeOffTypeId { get; set; }



		/// <summary>
		/// The secondary ID of the time off type configured in HRIS integration
		/// </summary>
		/// <value>The secondary ID of the time off type configured in HRIS integration</value>
		[DataMember(Name = "hrisTimeOffTypeSecondaryId", EmitDefaultValue = false)]
		public string HrisTimeOffTypeSecondaryId { get; set; }



		/// <summary>
		/// The Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public String StartDate { get; set; }



		/// <summary>
		/// The list of available time off balance values in minutes for each day
		/// </summary>
		/// <value>The list of available time off balance values in minutes for each day</value>
		[DataMember(Name = "balanceMinutesPerDay", EmitDefaultValue = false)]
		public List<int?> BalanceMinutesPerDay { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TimeOffBalanceResponse {\n");

			sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
			sb.Append("  HrisTimeOffTypeId: ").Append(HrisTimeOffTypeId).Append("\n");
			sb.Append("  HrisTimeOffTypeSecondaryId: ").Append(HrisTimeOffTypeSecondaryId).Append("\n");
			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  BalanceMinutesPerDay: ").Append(BalanceMinutesPerDay).Append("\n");
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
			return this.Equals(obj as TimeOffBalanceResponse);
		}

		/// <summary>
		/// Returns true if TimeOffBalanceResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of TimeOffBalanceResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TimeOffBalanceResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ActivityCodeId == other.ActivityCodeId ||
					this.ActivityCodeId != null &&
					this.ActivityCodeId.Equals(other.ActivityCodeId)
				) &&
				(
					this.HrisTimeOffTypeId == other.HrisTimeOffTypeId ||
					this.HrisTimeOffTypeId != null &&
					this.HrisTimeOffTypeId.Equals(other.HrisTimeOffTypeId)
				) &&
				(
					this.HrisTimeOffTypeSecondaryId == other.HrisTimeOffTypeSecondaryId ||
					this.HrisTimeOffTypeSecondaryId != null &&
					this.HrisTimeOffTypeSecondaryId.Equals(other.HrisTimeOffTypeSecondaryId)
				) &&
				(
					this.StartDate == other.StartDate ||
					this.StartDate != null &&
					this.StartDate.Equals(other.StartDate)
				) &&
				(
					this.BalanceMinutesPerDay == other.BalanceMinutesPerDay ||
					this.BalanceMinutesPerDay != null &&
					this.BalanceMinutesPerDay.SequenceEqual(other.BalanceMinutesPerDay)
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
				if (this.ActivityCodeId != null)
					hash = hash * 59 + this.ActivityCodeId.GetHashCode();

				if (this.HrisTimeOffTypeId != null)
					hash = hash * 59 + this.HrisTimeOffTypeId.GetHashCode();

				if (this.HrisTimeOffTypeSecondaryId != null)
					hash = hash * 59 + this.HrisTimeOffTypeSecondaryId.GetHashCode();

				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				if (this.BalanceMinutesPerDay != null)
					hash = hash * 59 + this.BalanceMinutesPerDay.GetHashCode();

				return hash;
			}
		}
	}

}
