using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ContestsResponse
    /// </summary>
    [DataContract]
    public partial class ContestsResponse :  IEquatable<ContestsResponse>
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
        /// The Contest status
        /// </summary>
        /// <value>The Contest status</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Upcoming for "Upcoming"
            /// </summary>
            [EnumMember(Value = "Upcoming")]
            Upcoming,
            
            /// <summary>
            /// Enum Ongoing for "Ongoing"
            /// </summary>
            [EnumMember(Value = "Ongoing")]
            Ongoing,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Recentlycompleted for "RecentlyCompleted"
            /// </summary>
            [EnumMember(Value = "RecentlyCompleted")]
            Recentlycompleted,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Cancelled for "Cancelled"
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled
        }
        /// <summary>
        /// The Contest winning criteria
        /// </summary>
        /// <value>The Contest winning criteria</value>
        [DataMember(Name="winningCriteria", EmitDefaultValue=false)]
        public WinningCriteriaEnum? WinningCriteria { get; set; }
        /// <summary>
        /// The Contest anonymization
        /// </summary>
        /// <value>The Contest anonymization</value>
        [DataMember(Name="anonymization", EmitDefaultValue=false)]
        public AnonymizationEnum? Anonymization { get; set; }
        /// <summary>
        /// The Contest status
        /// </summary>
        /// <value>The Contest status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContestsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContestsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestsResponse" /> class.
        /// </summary>
        /// <param name="Division">The division for this performance profile associate to.</param>
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
        /// <param name="Version">The Contest Version.</param>
        /// <param name="CreatedBy">The creator of the contest.</param>
        /// <param name="Profile">The performance profile.</param>
        /// <param name="Participants">The Contest&#39;s participants.</param>
        /// <param name="Status">The Contest status.</param>
        /// <param name="ParticipantCount">The Number of participants in the contest.</param>
        /// <param name="DateFinalized">The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateCancelled">The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateScoresModified">The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Winners">The Contest Winners.</param>
        /// <param name="DisqualifiedAgents">The Contest&#39;s disqualified agents, returned when a contest is complete.</param>
        public ContestsResponse(WritableDivision Division = null, string Title = null, string Description = null, String DateStart = null, String DateEnd = null, WinningCriteriaEnum? WinningCriteria = null, DateTime? DateAnnounced = null, string AnnouncementTimezone = null, AnonymizationEnum? Anonymization = null, List<ContestMetrics> Metrics = null, List<ContestPrizes> Prizes = null, int? Version = null, UserReference CreatedBy = null, ContestProfile Profile = null, List<UserReference> Participants = null, StatusEnum? Status = null, int? ParticipantCount = null, DateTime? DateFinalized = null, DateTime? DateCancelled = null, DateTime? DateModified = null, DateTime? DateScoresModified = null, List<ContestWinners> Winners = null, List<ContestDisqualifiedAgents> DisqualifiedAgents = null)
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
            this.Version = Version;
            this.CreatedBy = CreatedBy;
            this.Profile = Profile;
            this.Participants = Participants;
            this.Status = Status;
            this.ParticipantCount = ParticipantCount;
            this.DateFinalized = DateFinalized;
            this.DateCancelled = DateCancelled;
            this.DateModified = DateModified;
            this.DateScoresModified = DateScoresModified;
            this.Winners = Winners;
            this.DisqualifiedAgents = DisqualifiedAgents;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The division for this performance profile associate to
        /// </summary>
        /// <value>The division for this performance profile associate to</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableDivision Division { get; set; }



        /// <summary>
        /// The Contest title
        /// </summary>
        /// <value>The Contest title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// The Contest description
        /// </summary>
        /// <value>The Contest description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public String DateStart { get; set; }



        /// <summary>
        /// End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public String DateEnd { get; set; }





        /// <summary>
        /// The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateAnnounced", EmitDefaultValue=false)]
        public DateTime? DateAnnounced { get; set; }



        /// <summary>
        /// The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
        /// </summary>
        /// <value>The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
        [DataMember(Name="announcementTimezone", EmitDefaultValue=false)]
        public string AnnouncementTimezone { get; set; }





        /// <summary>
        /// The Contest&#39;s Metrics
        /// </summary>
        /// <value>The Contest&#39;s Metrics</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<ContestMetrics> Metrics { get; set; }



        /// <summary>
        /// The Contest Prizes
        /// </summary>
        /// <value>The Contest Prizes</value>
        [DataMember(Name="prizes", EmitDefaultValue=false)]
        public List<ContestPrizes> Prizes { get; set; }



        /// <summary>
        /// The Contest Version
        /// </summary>
        /// <value>The Contest Version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The creator of the contest
        /// </summary>
        /// <value>The creator of the contest</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; set; }



        /// <summary>
        /// The performance profile
        /// </summary>
        /// <value>The performance profile</value>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public ContestProfile Profile { get; set; }



        /// <summary>
        /// The Contest&#39;s participants
        /// </summary>
        /// <value>The Contest&#39;s participants</value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<UserReference> Participants { get; set; }





        /// <summary>
        /// The Number of participants in the contest
        /// </summary>
        /// <value>The Number of participants in the contest</value>
        [DataMember(Name="participantCount", EmitDefaultValue=false)]
        public int? ParticipantCount { get; set; }



        /// <summary>
        /// The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateFinalized", EmitDefaultValue=false)]
        public DateTime? DateFinalized { get; set; }



        /// <summary>
        /// The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCancelled", EmitDefaultValue=false)]
        public DateTime? DateCancelled { get; set; }



        /// <summary>
        /// The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateScoresModified", EmitDefaultValue=false)]
        public DateTime? DateScoresModified { get; set; }



        /// <summary>
        /// The Contest Winners
        /// </summary>
        /// <value>The Contest Winners</value>
        [DataMember(Name="winners", EmitDefaultValue=false)]
        public List<ContestWinners> Winners { get; set; }



        /// <summary>
        /// The Contest&#39;s disqualified agents, returned when a contest is complete
        /// </summary>
        /// <value>The Contest&#39;s disqualified agents, returned when a contest is complete</value>
        [DataMember(Name="disqualifiedAgents", EmitDefaultValue=false)]
        public List<ContestDisqualifiedAgents> DisqualifiedAgents { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestsResponse {\n");

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
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ParticipantCount: ").Append(ParticipantCount).Append("\n");
            sb.Append("  DateFinalized: ").Append(DateFinalized).Append("\n");
            sb.Append("  DateCancelled: ").Append(DateCancelled).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DateScoresModified: ").Append(DateScoresModified).Append("\n");
            sb.Append("  Winners: ").Append(Winners).Append("\n");
            sb.Append("  DisqualifiedAgents: ").Append(DisqualifiedAgents).Append("\n");
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
            return this.Equals(obj as ContestsResponse);
        }

        /// <summary>
        /// Returns true if ContestsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestsResponse other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
                ) &&
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ParticipantCount == other.ParticipantCount ||
                    this.ParticipantCount != null &&
                    this.ParticipantCount.Equals(other.ParticipantCount)
                ) &&
                (
                    this.DateFinalized == other.DateFinalized ||
                    this.DateFinalized != null &&
                    this.DateFinalized.Equals(other.DateFinalized)
                ) &&
                (
                    this.DateCancelled == other.DateCancelled ||
                    this.DateCancelled != null &&
                    this.DateCancelled.Equals(other.DateCancelled)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.DateScoresModified == other.DateScoresModified ||
                    this.DateScoresModified != null &&
                    this.DateScoresModified.Equals(other.DateScoresModified)
                ) &&
                (
                    this.Winners == other.Winners ||
                    this.Winners != null &&
                    this.Winners.SequenceEqual(other.Winners)
                ) &&
                (
                    this.DisqualifiedAgents == other.DisqualifiedAgents ||
                    this.DisqualifiedAgents != null &&
                    this.DisqualifiedAgents.SequenceEqual(other.DisqualifiedAgents)
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

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ParticipantCount != null)
                    hash = hash * 59 + this.ParticipantCount.GetHashCode();

                if (this.DateFinalized != null)
                    hash = hash * 59 + this.DateFinalized.GetHashCode();

                if (this.DateCancelled != null)
                    hash = hash * 59 + this.DateCancelled.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DateScoresModified != null)
                    hash = hash * 59 + this.DateScoresModified.GetHashCode();

                if (this.Winners != null)
                    hash = hash * 59 + this.Winners.GetHashCode();

                if (this.DisqualifiedAgents != null)
                    hash = hash * 59 + this.DisqualifiedAgents.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
