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
    /// UserTrendData
    /// </summary>
    [DataContract]
    public partial class UserTrendData :  IEquatable<UserTrendData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTrendData" /> class.
        /// </summary>
        /// <param name="DateStartWorkday">Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="DateEndWorkday">End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="PercentOfGoal">Percent of goal.</param>
        /// <param name="AverageValue">Average metric value.</param>
        /// <param name="RankTotalPoints">Rank, ordered by total points.</param>
        /// <param name="RankPercentagePoints">Rank, ordered by percentage of points.</param>
        public UserTrendData(String DateStartWorkday = null, String DateEndWorkday = null, double? PercentOfGoal = null, double? AverageValue = null, int? RankTotalPoints = null, int? RankPercentagePoints = null)
        {
            this.DateStartWorkday = DateStartWorkday;
            this.DateEndWorkday = DateEndWorkday;
            this.PercentOfGoal = PercentOfGoal;
            this.AverageValue = AverageValue;
            this.RankTotalPoints = RankTotalPoints;
            this.RankPercentagePoints = RankPercentagePoints;
            
        }
        


        /// <summary>
        /// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateStartWorkday", EmitDefaultValue=false)]
        public String DateStartWorkday { get; set; }



        /// <summary>
        /// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEndWorkday", EmitDefaultValue=false)]
        public String DateEndWorkday { get; set; }



        /// <summary>
        /// Percent of goal
        /// </summary>
        /// <value>Percent of goal</value>
        [DataMember(Name="percentOfGoal", EmitDefaultValue=false)]
        public double? PercentOfGoal { get; set; }



        /// <summary>
        /// Average metric value
        /// </summary>
        /// <value>Average metric value</value>
        [DataMember(Name="averageValue", EmitDefaultValue=false)]
        public double? AverageValue { get; set; }



        /// <summary>
        /// Rank, ordered by total points
        /// </summary>
        /// <value>Rank, ordered by total points</value>
        [DataMember(Name="rankTotalPoints", EmitDefaultValue=false)]
        public int? RankTotalPoints { get; set; }



        /// <summary>
        /// Rank, ordered by percentage of points
        /// </summary>
        /// <value>Rank, ordered by percentage of points</value>
        [DataMember(Name="rankPercentagePoints", EmitDefaultValue=false)]
        public int? RankPercentagePoints { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserTrendData {\n");

            sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
            sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
            sb.Append("  PercentOfGoal: ").Append(PercentOfGoal).Append("\n");
            sb.Append("  AverageValue: ").Append(AverageValue).Append("\n");
            sb.Append("  RankTotalPoints: ").Append(RankTotalPoints).Append("\n");
            sb.Append("  RankPercentagePoints: ").Append(RankPercentagePoints).Append("\n");
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
            return this.Equals(obj as UserTrendData);
        }

        /// <summary>
        /// Returns true if UserTrendData instances are equal
        /// </summary>
        /// <param name="other">Instance of UserTrendData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserTrendData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.PercentOfGoal == other.PercentOfGoal ||
                    this.PercentOfGoal != null &&
                    this.PercentOfGoal.Equals(other.PercentOfGoal)
                ) &&
                (
                    this.AverageValue == other.AverageValue ||
                    this.AverageValue != null &&
                    this.AverageValue.Equals(other.AverageValue)
                ) &&
                (
                    this.RankTotalPoints == other.RankTotalPoints ||
                    this.RankTotalPoints != null &&
                    this.RankTotalPoints.Equals(other.RankTotalPoints)
                ) &&
                (
                    this.RankPercentagePoints == other.RankPercentagePoints ||
                    this.RankPercentagePoints != null &&
                    this.RankPercentagePoints.Equals(other.RankPercentagePoints)
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
                if (this.DateStartWorkday != null)
                    hash = hash * 59 + this.DateStartWorkday.GetHashCode();

                if (this.DateEndWorkday != null)
                    hash = hash * 59 + this.DateEndWorkday.GetHashCode();

                if (this.PercentOfGoal != null)
                    hash = hash * 59 + this.PercentOfGoal.GetHashCode();

                if (this.AverageValue != null)
                    hash = hash * 59 + this.AverageValue.GetHashCode();

                if (this.RankTotalPoints != null)
                    hash = hash * 59 + this.RankTotalPoints.GetHashCode();

                if (this.RankPercentagePoints != null)
                    hash = hash * 59 + this.RankPercentagePoints.GetHashCode();

                return hash;
            }
        }
    }

}
