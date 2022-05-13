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
    /// GamificationScorecardChangeTopicScorecardChange
    /// </summary>
    [DataContract]
    public partial class GamificationScorecardChangeTopicScorecardChange :  IEquatable<GamificationScorecardChangeTopicScorecardChange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationScorecardChangeTopicScorecardChange" /> class.
        /// </summary>
        /// <param name="Workday">Workday.</param>
        /// <param name="DivisionId">DivisionId.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="PerformanceProfileId">PerformanceProfileId.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="PerformanceMetrics">PerformanceMetrics.</param>
        public GamificationScorecardChangeTopicScorecardChange(string Workday = null, string DivisionId = null, string TeamId = null, string PerformanceProfileId = null, string UserId = null, List<GamificationScorecardChangeTopicPerformanceMetric> PerformanceMetrics = null)
        {
            this.Workday = Workday;
            this.DivisionId = DivisionId;
            this.TeamId = TeamId;
            this.PerformanceProfileId = PerformanceProfileId;
            this.UserId = UserId;
            this.PerformanceMetrics = PerformanceMetrics;
            
        }
        


        /// <summary>
        /// Gets or Sets Workday
        /// </summary>
        [DataMember(Name="workday", EmitDefaultValue=false)]
        public string Workday { get; set; }



        /// <summary>
        /// Gets or Sets DivisionId
        /// </summary>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }



        /// <summary>
        /// Gets or Sets PerformanceProfileId
        /// </summary>
        [DataMember(Name="performanceProfileId", EmitDefaultValue=false)]
        public string PerformanceProfileId { get; set; }



        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Gets or Sets PerformanceMetrics
        /// </summary>
        [DataMember(Name="performanceMetrics", EmitDefaultValue=false)]
        public List<GamificationScorecardChangeTopicPerformanceMetric> PerformanceMetrics { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GamificationScorecardChangeTopicScorecardChange {\n");

            sb.Append("  Workday: ").Append(Workday).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  PerformanceProfileId: ").Append(PerformanceProfileId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PerformanceMetrics: ").Append(PerformanceMetrics).Append("\n");
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
            return this.Equals(obj as GamificationScorecardChangeTopicScorecardChange);
        }

        /// <summary>
        /// Returns true if GamificationScorecardChangeTopicScorecardChange instances are equal
        /// </summary>
        /// <param name="other">Instance of GamificationScorecardChangeTopicScorecardChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GamificationScorecardChangeTopicScorecardChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Workday == other.Workday ||
                    this.Workday != null &&
                    this.Workday.Equals(other.Workday)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) &&
                (
                    this.PerformanceProfileId == other.PerformanceProfileId ||
                    this.PerformanceProfileId != null &&
                    this.PerformanceProfileId.Equals(other.PerformanceProfileId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.PerformanceMetrics == other.PerformanceMetrics ||
                    this.PerformanceMetrics != null &&
                    this.PerformanceMetrics.SequenceEqual(other.PerformanceMetrics)
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
                if (this.Workday != null)
                    hash = hash * 59 + this.Workday.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();

                if (this.PerformanceProfileId != null)
                    hash = hash * 59 + this.PerformanceProfileId.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.PerformanceMetrics != null)
                    hash = hash * 59 + this.PerformanceMetrics.GetHashCode();

                return hash;
            }
        }
    }

}
