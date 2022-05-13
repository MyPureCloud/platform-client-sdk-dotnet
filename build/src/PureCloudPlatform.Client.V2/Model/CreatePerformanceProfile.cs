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
    /// CreatePerformanceProfile
    /// </summary>
    [DataContract]
    public partial class CreatePerformanceProfile :  IEquatable<CreatePerformanceProfile>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePerformanceProfile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePerformanceProfile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePerformanceProfile" /> class.
        /// </summary>
        /// <param name="Name">A name for this performance profile (required).</param>
        /// <param name="Division">The associated division for this Performance Profile (required).</param>
        /// <param name="Description">A description about this performance profile (required).</param>
        /// <param name="ReportingIntervals">The reporting interval periods for this performance profile (required).</param>
        /// <param name="Active">The flag for active profiles (required).</param>
        /// <param name="MaxLeaderboardRankSize">The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries (required).</param>
        public CreatePerformanceProfile(string Name = null, WritableDivision Division = null, string Description = null, List<ReportingInterval> ReportingIntervals = null, bool? Active = null, int? MaxLeaderboardRankSize = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.Description = Description;
            this.ReportingIntervals = ReportingIntervals;
            this.Active = Active;
            this.MaxLeaderboardRankSize = MaxLeaderboardRankSize;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// A name for this performance profile
        /// </summary>
        /// <value>A name for this performance profile</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The associated division for this Performance Profile
        /// </summary>
        /// <value>The associated division for this Performance Profile</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableDivision Division { get; set; }



        /// <summary>
        /// A description about this performance profile
        /// </summary>
        /// <value>A description about this performance profile</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Order of the associated metrics. The list should contain valid ids for metrics
        /// </summary>
        /// <value>Order of the associated metrics. The list should contain valid ids for metrics</value>
        [DataMember(Name="metricOrders", EmitDefaultValue=false)]
        public List<string> MetricOrders { get; private set; }



        /// <summary>
        /// Creation date for this performance profile. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Creation date for this performance profile. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The reporting interval periods for this performance profile
        /// </summary>
        /// <value>The reporting interval periods for this performance profile</value>
        [DataMember(Name="reportingIntervals", EmitDefaultValue=false)]
        public List<ReportingInterval> ReportingIntervals { get; set; }



        /// <summary>
        /// The flag for active profiles
        /// </summary>
        /// <value>The flag for active profiles</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }



        /// <summary>
        /// The number of members in this performance profile
        /// </summary>
        /// <value>The number of members in this performance profile</value>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public int? MemberCount { get; private set; }



        /// <summary>
        /// The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries
        /// </summary>
        /// <value>The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries</value>
        [DataMember(Name="maxLeaderboardRankSize", EmitDefaultValue=false)]
        public int? MaxLeaderboardRankSize { get; set; }



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
            sb.Append("class CreatePerformanceProfile {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MetricOrders: ").Append(MetricOrders).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ReportingIntervals: ").Append(ReportingIntervals).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  MaxLeaderboardRankSize: ").Append(MaxLeaderboardRankSize).Append("\n");
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
            return this.Equals(obj as CreatePerformanceProfile);
        }

        /// <summary>
        /// Returns true if CreatePerformanceProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePerformanceProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePerformanceProfile other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.MetricOrders == other.MetricOrders ||
                    this.MetricOrders != null &&
                    this.MetricOrders.SequenceEqual(other.MetricOrders)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.ReportingIntervals == other.ReportingIntervals ||
                    this.ReportingIntervals != null &&
                    this.ReportingIntervals.SequenceEqual(other.ReportingIntervals)
                ) &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
                ) &&
                (
                    this.MaxLeaderboardRankSize == other.MaxLeaderboardRankSize ||
                    this.MaxLeaderboardRankSize != null &&
                    this.MaxLeaderboardRankSize.Equals(other.MaxLeaderboardRankSize)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.MetricOrders != null)
                    hash = hash * 59 + this.MetricOrders.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.ReportingIntervals != null)
                    hash = hash * 59 + this.ReportingIntervals.GetHashCode();

                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();

                if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();

                if (this.MaxLeaderboardRankSize != null)
                    hash = hash * 59 + this.MaxLeaderboardRankSize.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
