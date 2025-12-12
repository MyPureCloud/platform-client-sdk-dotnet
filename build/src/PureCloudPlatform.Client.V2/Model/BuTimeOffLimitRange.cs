using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuTimeOffLimitRange
	/// </summary>
	[DataContract]
	public partial class BuTimeOffLimitRange : IEquatable<BuTimeOffLimitRange>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="BuTimeOffLimitRange" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BuTimeOffLimitRange() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BuTimeOffLimitRange" /> class.
		/// </summary>
		/// <param name="StartDate">Start date of the range. The end date is determined by the size of &#39;limitMinutesPerDay&#39;. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="LimitMinutesPerDay">The list of time-off limit values in minutes per day. If &#39;null&#39; is specified, then the day-specific value is cleared. Such a day will have a value of 0 (required).</param>
		public BuTimeOffLimitRange(String StartDate = null, List<int?> LimitMinutesPerDay = null)
		{
			this.StartDate = StartDate;
			this.LimitMinutesPerDay = LimitMinutesPerDay;

		}



		/// <summary>
		/// Start date of the range. The end date is determined by the size of &#39;limitMinutesPerDay&#39;. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Start date of the range. The end date is determined by the size of &#39;limitMinutesPerDay&#39;. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public String StartDate { get; set; }



		/// <summary>
		/// The list of time-off limit values in minutes per day. If &#39;null&#39; is specified, then the day-specific value is cleared. Such a day will have a value of 0
		/// </summary>
		/// <value>The list of time-off limit values in minutes per day. If &#39;null&#39; is specified, then the day-specific value is cleared. Such a day will have a value of 0</value>
		[DataMember(Name = "limitMinutesPerDay", EmitDefaultValue = false)]
		public List<int?> LimitMinutesPerDay { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuTimeOffLimitRange {\n");

			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  LimitMinutesPerDay: ").Append(LimitMinutesPerDay).Append("\n");
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
			return this.Equals(obj as BuTimeOffLimitRange);
		}

		/// <summary>
		/// Returns true if BuTimeOffLimitRange instances are equal
		/// </summary>
		/// <param name="other">Instance of BuTimeOffLimitRange to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuTimeOffLimitRange other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StartDate == other.StartDate ||
					this.StartDate != null &&
					this.StartDate.Equals(other.StartDate)
				) &&
				(
					this.LimitMinutesPerDay == other.LimitMinutesPerDay ||
					this.LimitMinutesPerDay != null &&
					this.LimitMinutesPerDay.SequenceEqual(other.LimitMinutesPerDay)
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
				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				if (this.LimitMinutesPerDay != null)
					hash = hash * 59 + this.LimitMinutesPerDay.GetHashCode();

				return hash;
			}
		}
	}

}
