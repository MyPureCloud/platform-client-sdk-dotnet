using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmTimeOffBalanceJobTopicTimeOffBalance
	/// </summary>
	[DataContract]
	public partial class WfmTimeOffBalanceJobTopicTimeOffBalance : IEquatable<WfmTimeOffBalanceJobTopicTimeOffBalance>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmTimeOffBalanceJobTopicTimeOffBalance" /> class.
		/// </summary>
		/// <param name="ActivityCodeId">ActivityCodeId.</param>
		/// <param name="HrisTimeOffTypeId">HrisTimeOffTypeId.</param>
		/// <param name="HrisTimeOffTypeSecondaryId">HrisTimeOffTypeSecondaryId.</param>
		/// <param name="StartDate">StartDate.</param>
		/// <param name="BalanceMinutesPerDay">BalanceMinutesPerDay.</param>
		public WfmTimeOffBalanceJobTopicTimeOffBalance(string ActivityCodeId = null, string HrisTimeOffTypeId = null, string HrisTimeOffTypeSecondaryId = null, DateTime? StartDate = null, List<long?> BalanceMinutesPerDay = null)
		{
			this.ActivityCodeId = ActivityCodeId;
			this.HrisTimeOffTypeId = HrisTimeOffTypeId;
			this.HrisTimeOffTypeSecondaryId = HrisTimeOffTypeSecondaryId;
			this.StartDate = StartDate;
			this.BalanceMinutesPerDay = BalanceMinutesPerDay;

		}



		/// <summary>
		/// Gets or Sets ActivityCodeId
		/// </summary>
		[DataMember(Name = "activityCodeId", EmitDefaultValue = false)]
		public string ActivityCodeId { get; set; }



		/// <summary>
		/// Gets or Sets HrisTimeOffTypeId
		/// </summary>
		[DataMember(Name = "hrisTimeOffTypeId", EmitDefaultValue = false)]
		public string HrisTimeOffTypeId { get; set; }



		/// <summary>
		/// Gets or Sets HrisTimeOffTypeSecondaryId
		/// </summary>
		[DataMember(Name = "hrisTimeOffTypeSecondaryId", EmitDefaultValue = false)]
		public string HrisTimeOffTypeSecondaryId { get; set; }



		/// <summary>
		/// Gets or Sets StartDate
		/// </summary>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }



		/// <summary>
		/// Gets or Sets BalanceMinutesPerDay
		/// </summary>
		[DataMember(Name = "balanceMinutesPerDay", EmitDefaultValue = false)]
		public List<long?> BalanceMinutesPerDay { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmTimeOffBalanceJobTopicTimeOffBalance {\n");

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
			return this.Equals(obj as WfmTimeOffBalanceJobTopicTimeOffBalance);
		}

		/// <summary>
		/// Returns true if WfmTimeOffBalanceJobTopicTimeOffBalance instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmTimeOffBalanceJobTopicTimeOffBalance to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmTimeOffBalanceJobTopicTimeOffBalance other)
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
