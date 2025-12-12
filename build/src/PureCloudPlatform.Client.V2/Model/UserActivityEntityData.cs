using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserActivityEntityData
	/// </summary>
	[DataContract]
	public partial class UserActivityEntityData : IEquatable<UserActivityEntityData>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UserActivityEntityData" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UserActivityEntityData() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UserActivityEntityData" /> class.
		/// </summary>
		/// <param name="ActivityDate">The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="OrganizationPresenceId">Organization presence identifier.</param>
		/// <param name="PresenceDate">Date of the latest presence change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="QueueId">Queue identifier.</param>
		/// <param name="QueueMembershipStatus">Queue membership status (e.g. active or inactive).</param>
		/// <param name="RoutingStatus">Agent routing status.</param>
		/// <param name="RoutingStatusDate">Date of the latest routing status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="SystemPresence">System presence.</param>
		/// <param name="TeamId">The team ID the user is a member of.</param>
		/// <param name="UserId">Unique identifier for the user.</param>
		public UserActivityEntityData(DateTime? ActivityDate = null, string OrganizationPresenceId = null, DateTime? PresenceDate = null, string QueueId = null, string QueueMembershipStatus = null, string RoutingStatus = null, DateTime? RoutingStatusDate = null, string SystemPresence = null, string TeamId = null, string UserId = null)
		{
			this.ActivityDate = ActivityDate;
			this.OrganizationPresenceId = OrganizationPresenceId;
			this.PresenceDate = PresenceDate;
			this.QueueId = QueueId;
			this.QueueMembershipStatus = QueueMembershipStatus;
			this.RoutingStatus = RoutingStatus;
			this.RoutingStatusDate = RoutingStatusDate;
			this.SystemPresence = SystemPresence;
			this.TeamId = TeamId;
			this.UserId = UserId;

		}



		/// <summary>
		/// The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "activityDate", EmitDefaultValue = false)]
		public DateTime? ActivityDate { get; set; }



		/// <summary>
		/// Organization presence identifier
		/// </summary>
		/// <value>Organization presence identifier</value>
		[DataMember(Name = "organizationPresenceId", EmitDefaultValue = false)]
		public string OrganizationPresenceId { get; set; }



		/// <summary>
		/// Date of the latest presence change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date of the latest presence change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "presenceDate", EmitDefaultValue = false)]
		public DateTime? PresenceDate { get; set; }



		/// <summary>
		/// Queue identifier
		/// </summary>
		/// <value>Queue identifier</value>
		[DataMember(Name = "queueId", EmitDefaultValue = false)]
		public string QueueId { get; set; }



		/// <summary>
		/// Queue membership status (e.g. active or inactive)
		/// </summary>
		/// <value>Queue membership status (e.g. active or inactive)</value>
		[DataMember(Name = "queueMembershipStatus", EmitDefaultValue = false)]
		public string QueueMembershipStatus { get; set; }



		/// <summary>
		/// Agent routing status
		/// </summary>
		/// <value>Agent routing status</value>
		[DataMember(Name = "routingStatus", EmitDefaultValue = false)]
		public string RoutingStatus { get; set; }



		/// <summary>
		/// Date of the latest routing status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date of the latest routing status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "routingStatusDate", EmitDefaultValue = false)]
		public DateTime? RoutingStatusDate { get; set; }



		/// <summary>
		/// System presence
		/// </summary>
		/// <value>System presence</value>
		[DataMember(Name = "systemPresence", EmitDefaultValue = false)]
		public string SystemPresence { get; set; }



		/// <summary>
		/// The team ID the user is a member of
		/// </summary>
		/// <value>The team ID the user is a member of</value>
		[DataMember(Name = "teamId", EmitDefaultValue = false)]
		public string TeamId { get; set; }



		/// <summary>
		/// Unique identifier for the user
		/// </summary>
		/// <value>Unique identifier for the user</value>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserActivityEntityData {\n");

			sb.Append("  ActivityDate: ").Append(ActivityDate).Append("\n");
			sb.Append("  OrganizationPresenceId: ").Append(OrganizationPresenceId).Append("\n");
			sb.Append("  PresenceDate: ").Append(PresenceDate).Append("\n");
			sb.Append("  QueueId: ").Append(QueueId).Append("\n");
			sb.Append("  QueueMembershipStatus: ").Append(QueueMembershipStatus).Append("\n");
			sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
			sb.Append("  RoutingStatusDate: ").Append(RoutingStatusDate).Append("\n");
			sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
			sb.Append("  TeamId: ").Append(TeamId).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
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
			return this.Equals(obj as UserActivityEntityData);
		}

		/// <summary>
		/// Returns true if UserActivityEntityData instances are equal
		/// </summary>
		/// <param name="other">Instance of UserActivityEntityData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserActivityEntityData other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ActivityDate == other.ActivityDate ||
					this.ActivityDate != null &&
					this.ActivityDate.Equals(other.ActivityDate)
				) &&
				(
					this.OrganizationPresenceId == other.OrganizationPresenceId ||
					this.OrganizationPresenceId != null &&
					this.OrganizationPresenceId.Equals(other.OrganizationPresenceId)
				) &&
				(
					this.PresenceDate == other.PresenceDate ||
					this.PresenceDate != null &&
					this.PresenceDate.Equals(other.PresenceDate)
				) &&
				(
					this.QueueId == other.QueueId ||
					this.QueueId != null &&
					this.QueueId.Equals(other.QueueId)
				) &&
				(
					this.QueueMembershipStatus == other.QueueMembershipStatus ||
					this.QueueMembershipStatus != null &&
					this.QueueMembershipStatus.Equals(other.QueueMembershipStatus)
				) &&
				(
					this.RoutingStatus == other.RoutingStatus ||
					this.RoutingStatus != null &&
					this.RoutingStatus.Equals(other.RoutingStatus)
				) &&
				(
					this.RoutingStatusDate == other.RoutingStatusDate ||
					this.RoutingStatusDate != null &&
					this.RoutingStatusDate.Equals(other.RoutingStatusDate)
				) &&
				(
					this.SystemPresence == other.SystemPresence ||
					this.SystemPresence != null &&
					this.SystemPresence.Equals(other.SystemPresence)
				) &&
				(
					this.TeamId == other.TeamId ||
					this.TeamId != null &&
					this.TeamId.Equals(other.TeamId)
				) &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
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
				if (this.ActivityDate != null)
					hash = hash * 59 + this.ActivityDate.GetHashCode();

				if (this.OrganizationPresenceId != null)
					hash = hash * 59 + this.OrganizationPresenceId.GetHashCode();

				if (this.PresenceDate != null)
					hash = hash * 59 + this.PresenceDate.GetHashCode();

				if (this.QueueId != null)
					hash = hash * 59 + this.QueueId.GetHashCode();

				if (this.QueueMembershipStatus != null)
					hash = hash * 59 + this.QueueMembershipStatus.GetHashCode();

				if (this.RoutingStatus != null)
					hash = hash * 59 + this.RoutingStatus.GetHashCode();

				if (this.RoutingStatusDate != null)
					hash = hash * 59 + this.RoutingStatusDate.GetHashCode();

				if (this.SystemPresence != null)
					hash = hash * 59 + this.SystemPresence.GetHashCode();

				if (this.TeamId != null)
					hash = hash * 59 + this.TeamId.GetHashCode();

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				return hash;
			}
		}
	}

}
