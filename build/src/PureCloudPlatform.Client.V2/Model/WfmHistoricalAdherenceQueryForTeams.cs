using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmHistoricalAdherenceQueryForTeams
	/// </summary>
	[DataContract]
	public partial class WfmHistoricalAdherenceQueryForTeams : IEquatable<WfmHistoricalAdherenceQueryForTeams>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="WfmHistoricalAdherenceQueryForTeams" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WfmHistoricalAdherenceQueryForTeams() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmHistoricalAdherenceQueryForTeams" /> class.
		/// </summary>
		/// <param name="StartDate">Beginning of the date range to query in ISO-8601 format (required).</param>
		/// <param name="EndDate">End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time.</param>
		/// <param name="TimeZone">The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input. (required).</param>
		/// <param name="UserIds">The userIds to report on. If null or not set, adherence will be computed for all the users in management unit or requested teamIds.</param>
		/// <param name="IncludeExceptions">Whether user exceptions should be returned as part of the results.</param>
		public WfmHistoricalAdherenceQueryForTeams(DateTime? StartDate = null, DateTime? EndDate = null, string TimeZone = null, List<string> UserIds = null, bool? IncludeExceptions = null)
		{
			this.StartDate = StartDate;
			this.EndDate = EndDate;
			this.TimeZone = TimeZone;
			this.UserIds = UserIds;
			this.IncludeExceptions = IncludeExceptions;

		}



		/// <summary>
		/// Beginning of the date range to query in ISO-8601 format
		/// </summary>
		/// <value>Beginning of the date range to query in ISO-8601 format</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }



		/// <summary>
		/// End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time
		/// </summary>
		/// <value>End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time</value>
		[DataMember(Name = "endDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }



		/// <summary>
		/// The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input.
		/// </summary>
		/// <value>The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input.</value>
		[DataMember(Name = "timeZone", EmitDefaultValue = false)]
		public string TimeZone { get; set; }



		/// <summary>
		/// The userIds to report on. If null or not set, adherence will be computed for all the users in management unit or requested teamIds
		/// </summary>
		/// <value>The userIds to report on. If null or not set, adherence will be computed for all the users in management unit or requested teamIds</value>
		[DataMember(Name = "userIds", EmitDefaultValue = false)]
		public List<string> UserIds { get; set; }



		/// <summary>
		/// Whether user exceptions should be returned as part of the results
		/// </summary>
		/// <value>Whether user exceptions should be returned as part of the results</value>
		[DataMember(Name = "includeExceptions", EmitDefaultValue = false)]
		public bool? IncludeExceptions { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmHistoricalAdherenceQueryForTeams {\n");

			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  EndDate: ").Append(EndDate).Append("\n");
			sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
			sb.Append("  UserIds: ").Append(UserIds).Append("\n");
			sb.Append("  IncludeExceptions: ").Append(IncludeExceptions).Append("\n");
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
			return this.Equals(obj as WfmHistoricalAdherenceQueryForTeams);
		}

		/// <summary>
		/// Returns true if WfmHistoricalAdherenceQueryForTeams instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmHistoricalAdherenceQueryForTeams to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmHistoricalAdherenceQueryForTeams other)
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
					this.EndDate == other.EndDate ||
					this.EndDate != null &&
					this.EndDate.Equals(other.EndDate)
				) &&
				(
					this.TimeZone == other.TimeZone ||
					this.TimeZone != null &&
					this.TimeZone.Equals(other.TimeZone)
				) &&
				(
					this.UserIds == other.UserIds ||
					this.UserIds != null &&
					this.UserIds.SequenceEqual(other.UserIds)
				) &&
				(
					this.IncludeExceptions == other.IncludeExceptions ||
					this.IncludeExceptions != null &&
					this.IncludeExceptions.Equals(other.IncludeExceptions)
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

				if (this.EndDate != null)
					hash = hash * 59 + this.EndDate.GetHashCode();

				if (this.TimeZone != null)
					hash = hash * 59 + this.TimeZone.GetHashCode();

				if (this.UserIds != null)
					hash = hash * 59 + this.UserIds.GetHashCode();

				if (this.IncludeExceptions != null)
					hash = hash * 59 + this.IncludeExceptions.GetHashCode();

				return hash;
			}
		}
	}

}
