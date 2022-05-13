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
    /// Leaderboard
    /// </summary>
    [DataContract]
    public partial class Leaderboard :  IEquatable<Leaderboard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaderboard" /> class.
        /// </summary>
        public Leaderboard()
        {
            
        }
        


        /// <summary>
        /// The targeted division for this leaderboard
        /// </summary>
        /// <value>The targeted division for this leaderboard</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public Division Division { get; private set; }



        /// <summary>
        /// The metric id if the leaderboard is about a specific metric
        /// </summary>
        /// <value>The metric id if the leaderboard is about a specific metric</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public AddressableEntityRef Metric { get; private set; }



        /// <summary>
        /// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateStartWorkday", EmitDefaultValue=false)]
        public String DateStartWorkday { get; private set; }



        /// <summary>
        /// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEndWorkday", EmitDefaultValue=false)]
        public String DateEndWorkday { get; private set; }



        /// <summary>
        /// The list of leaders generated.
        /// </summary>
        /// <value>The list of leaders generated.</value>
        [DataMember(Name="leaders", EmitDefaultValue=false)]
        public List<LeaderboardItem> Leaders { get; private set; }



        /// <summary>
        /// The requesting user's rank
        /// </summary>
        /// <value>The requesting user's rank</value>
        [DataMember(Name="userRank", EmitDefaultValue=false)]
        public LeaderboardItem UserRank { get; private set; }



        /// <summary>
        /// The targeted performance profile for the average points
        /// </summary>
        /// <value>The targeted performance profile for the average points</value>
        [DataMember(Name="performanceProfile", EmitDefaultValue=false)]
        public AddressableEntityRef PerformanceProfile { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Leaderboard {\n");

            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
            sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
            sb.Append("  Leaders: ").Append(Leaders).Append("\n");
            sb.Append("  UserRank: ").Append(UserRank).Append("\n");
            sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
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
            return this.Equals(obj as Leaderboard);
        }

        /// <summary>
        /// Returns true if Leaderboard instances are equal
        /// </summary>
        /// <param name="other">Instance of Leaderboard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Leaderboard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.DateStartWorkday == other.DateStartWorkday ||
                    this.DateStartWorkday != null &&
                    this.DateStartWorkday.Equals(other.DateStartWorkday)
                ) &&
                (
                    this.DateEndWorkday == other.DateEndWorkday ||
                    this.DateEndWorkday != null &&
                    this.DateEndWorkday.Equals(other.DateEndWorkday)
                ) &&
                (
                    this.Leaders == other.Leaders ||
                    this.Leaders != null &&
                    this.Leaders.SequenceEqual(other.Leaders)
                ) &&
                (
                    this.UserRank == other.UserRank ||
                    this.UserRank != null &&
                    this.UserRank.Equals(other.UserRank)
                ) &&
                (
                    this.PerformanceProfile == other.PerformanceProfile ||
                    this.PerformanceProfile != null &&
                    this.PerformanceProfile.Equals(other.PerformanceProfile)
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
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                if (this.DateStartWorkday != null)
                    hash = hash * 59 + this.DateStartWorkday.GetHashCode();

                if (this.DateEndWorkday != null)
                    hash = hash * 59 + this.DateEndWorkday.GetHashCode();

                if (this.Leaders != null)
                    hash = hash * 59 + this.Leaders.GetHashCode();

                if (this.UserRank != null)
                    hash = hash * 59 + this.UserRank.GetHashCode();

                if (this.PerformanceProfile != null)
                    hash = hash * 59 + this.PerformanceProfile.GetHashCode();

                return hash;
            }
        }
    }

}
