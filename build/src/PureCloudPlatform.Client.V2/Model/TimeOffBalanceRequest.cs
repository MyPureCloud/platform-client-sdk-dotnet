using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TimeOffBalanceRequest
	/// </summary>
	[DataContract]
	public partial class TimeOffBalanceRequest : IEquatable<TimeOffBalanceRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TimeOffBalanceRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TimeOffBalanceRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TimeOffBalanceRequest" /> class.
		/// </summary>
		/// <param name="ActivityCodeIds">The set of activity code IDs for which to query available time off balances (required).</param>
		/// <param name="DateRanges">The list of date ranges for which to query time off balance.</param>
		public TimeOffBalanceRequest(List<string> ActivityCodeIds = null, List<LocalDateRange> DateRanges = null)
		{
			this.ActivityCodeIds = ActivityCodeIds;
			this.DateRanges = DateRanges;

		}



		/// <summary>
		/// The set of activity code IDs for which to query available time off balances
		/// </summary>
		/// <value>The set of activity code IDs for which to query available time off balances</value>
		[DataMember(Name = "activityCodeIds", EmitDefaultValue = false)]
		public List<string> ActivityCodeIds { get; set; }



		/// <summary>
		/// The list of date ranges for which to query time off balance
		/// </summary>
		/// <value>The list of date ranges for which to query time off balance</value>
		[DataMember(Name = "dateRanges", EmitDefaultValue = false)]
		public List<LocalDateRange> DateRanges { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TimeOffBalanceRequest {\n");

			sb.Append("  ActivityCodeIds: ").Append(ActivityCodeIds).Append("\n");
			sb.Append("  DateRanges: ").Append(DateRanges).Append("\n");
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
			return this.Equals(obj as TimeOffBalanceRequest);
		}

		/// <summary>
		/// Returns true if TimeOffBalanceRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of TimeOffBalanceRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TimeOffBalanceRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ActivityCodeIds == other.ActivityCodeIds ||
					this.ActivityCodeIds != null &&
					this.ActivityCodeIds.SequenceEqual(other.ActivityCodeIds)
				) &&
				(
					this.DateRanges == other.DateRanges ||
					this.DateRanges != null &&
					this.DateRanges.SequenceEqual(other.DateRanges)
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
				if (this.ActivityCodeIds != null)
					hash = hash * 59 + this.ActivityCodeIds.GetHashCode();

				if (this.DateRanges != null)
					hash = hash * 59 + this.DateRanges.GetHashCode();

				return hash;
			}
		}
	}

}
