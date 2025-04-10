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
    /// ContestScore
    /// </summary>
    [DataContract]
    public partial class ContestScore :  IEquatable<ContestScore>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestScore" /> class.
        /// </summary>
        /// <param name="Score">The Contest score.</param>
        /// <param name="TotalPoints">The Contest totalPoints.</param>
        /// <param name="PercentOfGoal">The Contest percentOfGoal.</param>
        public ContestScore(double? Score = null, double? TotalPoints = null, double? PercentOfGoal = null)
        {
            this.Score = Score;
            this.TotalPoints = TotalPoints;
            this.PercentOfGoal = PercentOfGoal;
            
        }
        


        /// <summary>
        /// The Contest score
        /// </summary>
        /// <value>The Contest score</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }



        /// <summary>
        /// The Contest totalPoints
        /// </summary>
        /// <value>The Contest totalPoints</value>
        [DataMember(Name="totalPoints", EmitDefaultValue=false)]
        public double? TotalPoints { get; set; }



        /// <summary>
        /// The Contest percentOfGoal
        /// </summary>
        /// <value>The Contest percentOfGoal</value>
        [DataMember(Name="percentOfGoal", EmitDefaultValue=false)]
        public double? PercentOfGoal { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestScore {\n");

            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  TotalPoints: ").Append(TotalPoints).Append("\n");
            sb.Append("  PercentOfGoal: ").Append(PercentOfGoal).Append("\n");
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
            return this.Equals(obj as ContestScore);
        }

        /// <summary>
        /// Returns true if ContestScore instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestScore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) &&
                (
                    this.TotalPoints == other.TotalPoints ||
                    this.TotalPoints != null &&
                    this.TotalPoints.Equals(other.TotalPoints)
                ) &&
                (
                    this.PercentOfGoal == other.PercentOfGoal ||
                    this.PercentOfGoal != null &&
                    this.PercentOfGoal.Equals(other.PercentOfGoal)
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
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();

                if (this.TotalPoints != null)
                    hash = hash * 59 + this.TotalPoints.GetHashCode();

                if (this.PercentOfGoal != null)
                    hash = hash * 59 + this.PercentOfGoal.GetHashCode();

                return hash;
            }
        }
    }

}
