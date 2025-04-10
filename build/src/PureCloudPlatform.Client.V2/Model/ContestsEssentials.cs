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
    /// ContestsEssentials
    /// </summary>
    [DataContract]
    public partial class ContestsEssentials :  IEquatable<ContestsEssentials>
    {
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
        /// The Contest status
        /// </summary>
        /// <value>The Contest status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContestsEssentials" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContestsEssentials() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestsEssentials" /> class.
        /// </summary>
        /// <param name="Title">The Contest title (required).</param>
        /// <param name="Status">The Contest status.</param>
        /// <param name="DateStart">Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="DateEnd">End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="Profile">The performance profile.</param>
        /// <param name="ParticipantCount">The Number of participants in the contest.</param>
        /// <param name="DateAnnounced">The Contest&#39;s Announcement datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="DateFinalized">The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateCancelled">The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateScoresModified">The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Metrics">The Contest&#39;s Metrics (required).</param>
        /// <param name="RequestingParticipantContestInfo">The Most Recent Contest Info for the requesting participant.</param>
        public ContestsEssentials(string Title = null, StatusEnum? Status = null, String DateStart = null, String DateEnd = null, ContestProfile Profile = null, int? ParticipantCount = null, DateTime? DateAnnounced = null, DateTime? DateFinalized = null, DateTime? DateCancelled = null, DateTime? DateModified = null, DateTime? DateScoresModified = null, List<ContestMetrics> Metrics = null, ContestRequesingParticipantDailyInfo RequestingParticipantContestInfo = null)
        {
            this.Title = Title;
            this.Status = Status;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.Profile = Profile;
            this.ParticipantCount = ParticipantCount;
            this.DateAnnounced = DateAnnounced;
            this.DateFinalized = DateFinalized;
            this.DateCancelled = DateCancelled;
            this.DateModified = DateModified;
            this.DateScoresModified = DateScoresModified;
            this.Metrics = Metrics;
            this.RequestingParticipantContestInfo = RequestingParticipantContestInfo;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The Contest title
        /// </summary>
        /// <value>The Contest title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }





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
        /// The performance profile
        /// </summary>
        /// <value>The performance profile</value>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public ContestProfile Profile { get; set; }



        /// <summary>
        /// The Number of participants in the contest
        /// </summary>
        /// <value>The Number of participants in the contest</value>
        [DataMember(Name="participantCount", EmitDefaultValue=false)]
        public int? ParticipantCount { get; set; }



        /// <summary>
        /// The Contest&#39;s Announcement datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The Contest&#39;s Announcement datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateAnnounced", EmitDefaultValue=false)]
        public DateTime? DateAnnounced { get; set; }



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
        /// The Contest&#39;s Metrics
        /// </summary>
        /// <value>The Contest&#39;s Metrics</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<ContestMetrics> Metrics { get; set; }



        /// <summary>
        /// The Most Recent Contest Info for the requesting participant
        /// </summary>
        /// <value>The Most Recent Contest Info for the requesting participant</value>
        [DataMember(Name="requestingParticipantContestInfo", EmitDefaultValue=false)]
        public ContestRequesingParticipantDailyInfo RequestingParticipantContestInfo { get; set; }



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
            sb.Append("class ContestsEssentials {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  ParticipantCount: ").Append(ParticipantCount).Append("\n");
            sb.Append("  DateAnnounced: ").Append(DateAnnounced).Append("\n");
            sb.Append("  DateFinalized: ").Append(DateFinalized).Append("\n");
            sb.Append("  DateCancelled: ").Append(DateCancelled).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DateScoresModified: ").Append(DateScoresModified).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  RequestingParticipantContestInfo: ").Append(RequestingParticipantContestInfo).Append("\n");
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
            return this.Equals(obj as ContestsEssentials);
        }

        /// <summary>
        /// Returns true if ContestsEssentials instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestsEssentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestsEssentials other)
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
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
                ) &&
                (
                    this.ParticipantCount == other.ParticipantCount ||
                    this.ParticipantCount != null &&
                    this.ParticipantCount.Equals(other.ParticipantCount)
                ) &&
                (
                    this.DateAnnounced == other.DateAnnounced ||
                    this.DateAnnounced != null &&
                    this.DateAnnounced.Equals(other.DateAnnounced)
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
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.RequestingParticipantContestInfo == other.RequestingParticipantContestInfo ||
                    this.RequestingParticipantContestInfo != null &&
                    this.RequestingParticipantContestInfo.Equals(other.RequestingParticipantContestInfo)
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

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();

                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();

                if (this.ParticipantCount != null)
                    hash = hash * 59 + this.ParticipantCount.GetHashCode();

                if (this.DateAnnounced != null)
                    hash = hash * 59 + this.DateAnnounced.GetHashCode();

                if (this.DateFinalized != null)
                    hash = hash * 59 + this.DateFinalized.GetHashCode();

                if (this.DateCancelled != null)
                    hash = hash * 59 + this.DateCancelled.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DateScoresModified != null)
                    hash = hash * 59 + this.DateScoresModified.GetHashCode();

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.RequestingParticipantContestInfo != null)
                    hash = hash * 59 + this.RequestingParticipantContestInfo.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
