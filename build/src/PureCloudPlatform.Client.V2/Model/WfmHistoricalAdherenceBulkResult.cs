using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmHistoricalAdherenceBulkResult
	/// </summary>
	[DataContract]
	public partial class WfmHistoricalAdherenceBulkResult : IEquatable<WfmHistoricalAdherenceBulkResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkResult" /> class.
		/// </summary>
		/// <param name="StartDate">Beginning of the date range for this result in ISO-8601 format.</param>
		/// <param name="EndDate">End of the date range for this result in ISO-8601 format.</param>
		/// <param name="ManagementUnitId">The ID of the management unit for this result.</param>
		/// <param name="UserResults">The individual results for each user.</param>
		/// <param name="LookupIdToSecondaryPresenceId">Map of secondary presence lookup ID to corresponding secondary presence ID.</param>
		public WfmHistoricalAdherenceBulkResult(DateTime? StartDate = null, DateTime? EndDate = null, string ManagementUnitId = null, List<WfmHistoricalAdherenceBulkUserResult> UserResults = null, Dictionary<string, string> LookupIdToSecondaryPresenceId = null)
		{
			this.StartDate = StartDate;
			this.EndDate = EndDate;
			this.ManagementUnitId = ManagementUnitId;
			this.UserResults = UserResults;
			this.LookupIdToSecondaryPresenceId = LookupIdToSecondaryPresenceId;

		}



		/// <summary>
		/// Beginning of the date range for this result in ISO-8601 format
		/// </summary>
		/// <value>Beginning of the date range for this result in ISO-8601 format</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }



		/// <summary>
		/// End of the date range for this result in ISO-8601 format
		/// </summary>
		/// <value>End of the date range for this result in ISO-8601 format</value>
		[DataMember(Name = "endDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }



		/// <summary>
		/// The ID of the management unit for this result
		/// </summary>
		/// <value>The ID of the management unit for this result</value>
		[DataMember(Name = "managementUnitId", EmitDefaultValue = false)]
		public string ManagementUnitId { get; set; }



		/// <summary>
		/// The individual results for each user
		/// </summary>
		/// <value>The individual results for each user</value>
		[DataMember(Name = "userResults", EmitDefaultValue = false)]
		public List<WfmHistoricalAdherenceBulkUserResult> UserResults { get; set; }



		/// <summary>
		/// Map of secondary presence lookup ID to corresponding secondary presence ID
		/// </summary>
		/// <value>Map of secondary presence lookup ID to corresponding secondary presence ID</value>
		[DataMember(Name = "lookupIdToSecondaryPresenceId", EmitDefaultValue = false)]
		public Dictionary<string, string> LookupIdToSecondaryPresenceId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmHistoricalAdherenceBulkResult {\n");

			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  EndDate: ").Append(EndDate).Append("\n");
			sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
			sb.Append("  UserResults: ").Append(UserResults).Append("\n");
			sb.Append("  LookupIdToSecondaryPresenceId: ").Append(LookupIdToSecondaryPresenceId).Append("\n");
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
			return this.Equals(obj as WfmHistoricalAdherenceBulkResult);
		}

		/// <summary>
		/// Returns true if WfmHistoricalAdherenceBulkResult instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmHistoricalAdherenceBulkResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmHistoricalAdherenceBulkResult other)
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
					this.ManagementUnitId == other.ManagementUnitId ||
					this.ManagementUnitId != null &&
					this.ManagementUnitId.Equals(other.ManagementUnitId)
				) &&
				(
					this.UserResults == other.UserResults ||
					this.UserResults != null &&
					this.UserResults.SequenceEqual(other.UserResults)
				) &&
				(
					this.LookupIdToSecondaryPresenceId == other.LookupIdToSecondaryPresenceId ||
					this.LookupIdToSecondaryPresenceId != null &&
					this.LookupIdToSecondaryPresenceId.SequenceEqual(other.LookupIdToSecondaryPresenceId)
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

				if (this.ManagementUnitId != null)
					hash = hash * 59 + this.ManagementUnitId.GetHashCode();

				if (this.UserResults != null)
					hash = hash * 59 + this.UserResults.GetHashCode();

				if (this.LookupIdToSecondaryPresenceId != null)
					hash = hash * 59 + this.LookupIdToSecondaryPresenceId.GetHashCode();

				return hash;
			}
		}
	}

}
