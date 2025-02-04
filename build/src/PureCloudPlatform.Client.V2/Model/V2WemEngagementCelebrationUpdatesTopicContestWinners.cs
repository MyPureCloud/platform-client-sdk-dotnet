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
    /// V2WemEngagementCelebrationUpdatesTopicContestWinners
    /// </summary>
    [DataContract]
    public partial class V2WemEngagementCelebrationUpdatesTopicContestWinners :  IEquatable<V2WemEngagementCelebrationUpdatesTopicContestWinners>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicContestWinners" /> class.
        /// </summary>
        /// <param name="Tier">Tier.</param>
        /// <param name="WinnersCount">WinnersCount.</param>
        /// <param name="ContestScore">ContestScore.</param>
        /// <param name="Users">Users.</param>
        public V2WemEngagementCelebrationUpdatesTopicContestWinners(int? Tier = null, int? WinnersCount = null, V2WemEngagementCelebrationUpdatesTopicContestWinnersScore ContestScore = null, List<V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers> Users = null)
        {
            this.Tier = Tier;
            this.WinnersCount = WinnersCount;
            this.ContestScore = ContestScore;
            this.Users = Users;
            
        }
        


        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public int? Tier { get; set; }



        /// <summary>
        /// Gets or Sets WinnersCount
        /// </summary>
        [DataMember(Name="winnersCount", EmitDefaultValue=false)]
        public int? WinnersCount { get; set; }



        /// <summary>
        /// Gets or Sets ContestScore
        /// </summary>
        [DataMember(Name="contestScore", EmitDefaultValue=false)]
        public V2WemEngagementCelebrationUpdatesTopicContestWinnersScore ContestScore { get; set; }



        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers> Users { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2WemEngagementCelebrationUpdatesTopicContestWinners {\n");

            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  WinnersCount: ").Append(WinnersCount).Append("\n");
            sb.Append("  ContestScore: ").Append(ContestScore).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as V2WemEngagementCelebrationUpdatesTopicContestWinners);
        }

        /// <summary>
        /// Returns true if V2WemEngagementCelebrationUpdatesTopicContestWinners instances are equal
        /// </summary>
        /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicContestWinners to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2WemEngagementCelebrationUpdatesTopicContestWinners other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
                ) &&
                (
                    this.WinnersCount == other.WinnersCount ||
                    this.WinnersCount != null &&
                    this.WinnersCount.Equals(other.WinnersCount)
                ) &&
                (
                    this.ContestScore == other.ContestScore ||
                    this.ContestScore != null &&
                    this.ContestScore.Equals(other.ContestScore)
                ) &&
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();

                if (this.WinnersCount != null)
                    hash = hash * 59 + this.WinnersCount.GetHashCode();

                if (this.ContestScore != null)
                    hash = hash * 59 + this.ContestScore.GetHashCode();

                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();

                return hash;
            }
        }
    }

}
