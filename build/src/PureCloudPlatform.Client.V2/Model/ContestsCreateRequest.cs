using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContestsCreateRequest
	/// </summary>
	[DataContract]
	public partial class ContestsCreateRequest : IEquatable<ContestsCreateRequest>
	{
		/// <summary>
		/// The Contest winning criteria
		/// </summary>
		/// <value>The Contest winning criteria</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum WinningCriteriaEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Highestoverallscore for "HighestOverallScore"
			/// </summary>
			[EnumMember(Value = "HighestOverallScore")]
			Highestoverallscore,

			/// <summary>
			/// Enum Highestoverallpercentofgoal for "HighestOverallPercentOfGoal"
			/// </summary>
			[EnumMember(Value = "HighestOverallPercentOfGoal")]
			Highestoverallpercentofgoal
		}
		/// <summary>
		/// The Contest anonymization
		/// </summary>
		/// <value>The Contest anonymization</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AnonymizationEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Noanonymization for "NoAnonymization"
			/// </summary>
			[EnumMember(Value = "NoAnonymization")]
			Noanonymization,

			/// <summary>
			/// Enum All for "All"
			/// </summary>
			[EnumMember(Value = "All")]
			All,

			/// <summary>
			/// Enum Allexcepttop for "AllExceptTop"
			/// </summary>
			[EnumMember(Value = "AllExceptTop")]
			Allexcepttop
		}
		/// <summary>
		/// The Contest winning criteria
		/// </summary>
		/// <value>The Contest winning criteria</value>
		[DataMember(Name = "winningCriteria", EmitDefaultValue = false)]
		public WinningCriteriaEnum? WinningCriteria { get; set; }
		/// <summary>
		/// The Contest anonymization
		/// </summary>
		/// <value>The Contest anonymization</value>
		[DataMember(Name = "anonymization", EmitDefaultValue = false)]
		public AnonymizationEnum? Anonymization { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ContestsCreateRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContestsCreateRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContestsCreateRequest" /> class.
		/// </summary>
		/// <param name="Division">The division for this performance profile associate to. Only set for DEFAULT profile..</param>
		/// <param name="Title">The Contest title (required).</param>
		/// <param name="Description">The Contest description (required).</param>
		/// <param name="DateStart">Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="DateEnd">End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="WinningCriteria">The Contest winning criteria (required).</param>
		/// <param name="DateAnnounced">The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="AnnouncementTimezone">The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London (required).</param>
		/// <param name="Anonymization">The Contest anonymization (required).</param>
		/// <param name="Metrics">The Contest&#39;s Metrics (required).</param>
		/// <param name="Prizes">The Contest Prizes (required).</param>
		/// <param name="ProfileId">The Contest profile (required).</param>
		/// <param name="ParticipantIds">The Contest&#39;s participants (required).</param>
		public ContestsCreateRequest(WritableDivision Division = null, string Title = null, string Description = null, String DateStart = null, String DateEnd = null, WinningCriteriaEnum? WinningCriteria = null, DateTime? DateAnnounced = null, string AnnouncementTimezone = null, AnonymizationEnum? Anonymization = null, List<ContestMetrics> Metrics = null, List<ContestPrizes> Prizes = null, string ProfileId = null, List<string> ParticipantIds = null)
		{
			this.Division = Division;
			this.Title = Title;
			this.Description = Description;
			this.DateStart = DateStart;
			this.DateEnd = DateEnd;
			this.WinningCriteria = WinningCriteria;
			this.DateAnnounced = DateAnnounced;
			this.AnnouncementTimezone = AnnouncementTimezone;
			this.Anonymization = Anonymization;
			this.Metrics = Metrics;
			this.Prizes = Prizes;
			this.ProfileId = ProfileId;
			this.ParticipantIds = ParticipantIds;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The division for this performance profile associate to. Only set for DEFAULT profile.
		/// </summary>
		/// <value>The division for this performance profile associate to. Only set for DEFAULT profile.</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public WritableDivision Division { get; set; }



		/// <summary>
		/// The Contest title
		/// </summary>
		/// <value>The Contest title</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// The Contest description
		/// </summary>
		/// <value>The Contest description</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public String DateStart { get; set; }



		/// <summary>
		/// End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateEnd", EmitDefaultValue = false)]
		public String DateEnd { get; set; }





		/// <summary>
		/// The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateAnnounced", EmitDefaultValue = false)]
		public DateTime? DateAnnounced { get; set; }



		/// <summary>
		/// The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
		/// </summary>
		/// <value>The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
		[DataMember(Name = "announcementTimezone", EmitDefaultValue = false)]
		public string AnnouncementTimezone { get; set; }





		/// <summary>
		/// The Contest&#39;s Metrics
		/// </summary>
		/// <value>The Contest&#39;s Metrics</value>
		[DataMember(Name = "metrics", EmitDefaultValue = false)]
		public List<ContestMetrics> Metrics { get; set; }



		/// <summary>
		/// The Contest Prizes
		/// </summary>
		/// <value>The Contest Prizes</value>
		[DataMember(Name = "prizes", EmitDefaultValue = false)]
		public List<ContestPrizes> Prizes { get; set; }



		/// <summary>
		/// The Contest profile
		/// </summary>
		/// <value>The Contest profile</value>
		[DataMember(Name = "profileId", EmitDefaultValue = false)]
		public string ProfileId { get; set; }



		/// <summary>
		/// The Contest&#39;s participants
		/// </summary>
		/// <value>The Contest&#39;s participants</value>
		[DataMember(Name = "participantIds", EmitDefaultValue = false)]
		public List<string> ParticipantIds { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContestsCreateRequest {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
			sb.Append("  WinningCriteria: ").Append(WinningCriteria).Append("\n");
			sb.Append("  DateAnnounced: ").Append(DateAnnounced).Append("\n");
			sb.Append("  AnnouncementTimezone: ").Append(AnnouncementTimezone).Append("\n");
			sb.Append("  Anonymization: ").Append(Anonymization).Append("\n");
			sb.Append("  Metrics: ").Append(Metrics).Append("\n");
			sb.Append("  Prizes: ").Append(Prizes).Append("\n");
			sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
			sb.Append("  ParticipantIds: ").Append(ParticipantIds).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as ContestsCreateRequest);
		}

		/// <summary>
		/// Returns true if ContestsCreateRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ContestsCreateRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContestsCreateRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.DateStart == other.DateStart ||
					this.DateStart != null &&
					this.DateStart.Equals(other.DateStart)
				) &&
				(
					this.DateEnd == other.DateEnd ||
					this.DateEnd != null &&
					this.DateEnd.Equals(other.DateEnd)
				) &&
				(
					this.WinningCriteria == other.WinningCriteria ||
					this.WinningCriteria != null &&
					this.WinningCriteria.Equals(other.WinningCriteria)
				) &&
				(
					this.DateAnnounced == other.DateAnnounced ||
					this.DateAnnounced != null &&
					this.DateAnnounced.Equals(other.DateAnnounced)
				) &&
				(
					this.AnnouncementTimezone == other.AnnouncementTimezone ||
					this.AnnouncementTimezone != null &&
					this.AnnouncementTimezone.Equals(other.AnnouncementTimezone)
				) &&
				(
					this.Anonymization == other.Anonymization ||
					this.Anonymization != null &&
					this.Anonymization.Equals(other.Anonymization)
				) &&
				(
					this.Metrics == other.Metrics ||
					this.Metrics != null &&
					this.Metrics.SequenceEqual(other.Metrics)
				) &&
				(
					this.Prizes == other.Prizes ||
					this.Prizes != null &&
					this.Prizes.SequenceEqual(other.Prizes)
				) &&
				(
					this.ProfileId == other.ProfileId ||
					this.ProfileId != null &&
					this.ProfileId.Equals(other.ProfileId)
				) &&
				(
					this.ParticipantIds == other.ParticipantIds ||
					this.ParticipantIds != null &&
					this.ParticipantIds.SequenceEqual(other.ParticipantIds)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.DateEnd != null)
					hash = hash * 59 + this.DateEnd.GetHashCode();

				if (this.WinningCriteria != null)
					hash = hash * 59 + this.WinningCriteria.GetHashCode();

				if (this.DateAnnounced != null)
					hash = hash * 59 + this.DateAnnounced.GetHashCode();

				if (this.AnnouncementTimezone != null)
					hash = hash * 59 + this.AnnouncementTimezone.GetHashCode();

				if (this.Anonymization != null)
					hash = hash * 59 + this.Anonymization.GetHashCode();

				if (this.Metrics != null)
					hash = hash * 59 + this.Metrics.GetHashCode();

				if (this.Prizes != null)
					hash = hash * 59 + this.Prizes.GetHashCode();

				if (this.ProfileId != null)
					hash = hash * 59 + this.ProfileId.GetHashCode();

				if (this.ParticipantIds != null)
					hash = hash * 59 + this.ParticipantIds.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
