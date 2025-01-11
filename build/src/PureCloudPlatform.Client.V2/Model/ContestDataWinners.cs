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
    /// ContestDataWinners
    /// </summary>
    [DataContract]
    public partial class ContestDataWinners :  IEquatable<ContestDataWinners>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestDataWinners" /> class.
        /// </summary>
        /// <param name="Tier">Tier of the winners.</param>
        /// <param name="WinnersCount">Number of winners in this tier.</param>
        /// <param name="ContestScore">Number of winners in this tier.</param>
        /// <param name="Users">List of users in this tier.</param>
        public ContestDataWinners(int? Tier = null, int? WinnersCount = null, ContestCompleteDataScore ContestScore = null, List<ContestDataWinnersUsers> Users = null)
        {
            this.Tier = Tier;
            this.WinnersCount = WinnersCount;
            this.ContestScore = ContestScore;
            this.Users = Users;
            
        }
        


        /// <summary>
        /// Tier of the winners
        /// </summary>
        /// <value>Tier of the winners</value>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public int? Tier { get; set; }



        /// <summary>
        /// Number of winners in this tier
        /// </summary>
        /// <value>Number of winners in this tier</value>
        [DataMember(Name="winnersCount", EmitDefaultValue=false)]
        public int? WinnersCount { get; set; }



        /// <summary>
        /// Number of winners in this tier
        /// </summary>
        /// <value>Number of winners in this tier</value>
        [DataMember(Name="contestScore", EmitDefaultValue=false)]
        public ContestCompleteDataScore ContestScore { get; set; }



        /// <summary>
        /// List of users in this tier
        /// </summary>
        /// <value>List of users in this tier</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<ContestDataWinnersUsers> Users { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestDataWinners {\n");

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
            return this.Equals(obj as ContestDataWinners);
        }

        /// <summary>
        /// Returns true if ContestDataWinners instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestDataWinners to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestDataWinners other)
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
