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
    /// ActionMapEstimateResult
    /// </summary>
    [DataContract]
    public partial class ActionMapEstimateResult :  IEquatable<ActionMapEstimateResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionMapEstimateResult" /> class.
        /// </summary>
        /// <param name="QualifiedSessionCount">Number of sessions qualified for Action map..</param>
        /// <param name="TotalSessionCount">Total number of sessions..</param>
        /// <param name="PerSegmentCounts">Number of sessions qualified for Action map per segment..</param>
        /// <param name="OutcomesScoresCount">Difference made by outcome criteria to number of sessions qualified for Action map..</param>
        public ActionMapEstimateResult(int? QualifiedSessionCount = null, int? TotalSessionCount = null, List<SegmentEstimateCount> PerSegmentCounts = null, int? OutcomesScoresCount = null)
        {
            this.QualifiedSessionCount = QualifiedSessionCount;
            this.TotalSessionCount = TotalSessionCount;
            this.PerSegmentCounts = PerSegmentCounts;
            this.OutcomesScoresCount = OutcomesScoresCount;
            
        }
        


        /// <summary>
        /// Number of sessions qualified for Action map.
        /// </summary>
        /// <value>Number of sessions qualified for Action map.</value>
        [DataMember(Name="qualifiedSessionCount", EmitDefaultValue=false)]
        public int? QualifiedSessionCount { get; set; }



        /// <summary>
        /// Total number of sessions.
        /// </summary>
        /// <value>Total number of sessions.</value>
        [DataMember(Name="totalSessionCount", EmitDefaultValue=false)]
        public int? TotalSessionCount { get; set; }



        /// <summary>
        /// Number of sessions qualified for Action map per segment.
        /// </summary>
        /// <value>Number of sessions qualified for Action map per segment.</value>
        [DataMember(Name="perSegmentCounts", EmitDefaultValue=false)]
        public List<SegmentEstimateCount> PerSegmentCounts { get; set; }



        /// <summary>
        /// Difference made by outcome criteria to number of sessions qualified for Action map.
        /// </summary>
        /// <value>Difference made by outcome criteria to number of sessions qualified for Action map.</value>
        [DataMember(Name="outcomesScoresCount", EmitDefaultValue=false)]
        public int? OutcomesScoresCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionMapEstimateResult {\n");

            sb.Append("  QualifiedSessionCount: ").Append(QualifiedSessionCount).Append("\n");
            sb.Append("  TotalSessionCount: ").Append(TotalSessionCount).Append("\n");
            sb.Append("  PerSegmentCounts: ").Append(PerSegmentCounts).Append("\n");
            sb.Append("  OutcomesScoresCount: ").Append(OutcomesScoresCount).Append("\n");
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
            return this.Equals(obj as ActionMapEstimateResult);
        }

        /// <summary>
        /// Returns true if ActionMapEstimateResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionMapEstimateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionMapEstimateResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QualifiedSessionCount == other.QualifiedSessionCount ||
                    this.QualifiedSessionCount != null &&
                    this.QualifiedSessionCount.Equals(other.QualifiedSessionCount)
                ) &&
                (
                    this.TotalSessionCount == other.TotalSessionCount ||
                    this.TotalSessionCount != null &&
                    this.TotalSessionCount.Equals(other.TotalSessionCount)
                ) &&
                (
                    this.PerSegmentCounts == other.PerSegmentCounts ||
                    this.PerSegmentCounts != null &&
                    this.PerSegmentCounts.SequenceEqual(other.PerSegmentCounts)
                ) &&
                (
                    this.OutcomesScoresCount == other.OutcomesScoresCount ||
                    this.OutcomesScoresCount != null &&
                    this.OutcomesScoresCount.Equals(other.OutcomesScoresCount)
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
                if (this.QualifiedSessionCount != null)
                    hash = hash * 59 + this.QualifiedSessionCount.GetHashCode();

                if (this.TotalSessionCount != null)
                    hash = hash * 59 + this.TotalSessionCount.GetHashCode();

                if (this.PerSegmentCounts != null)
                    hash = hash * 59 + this.PerSegmentCounts.GetHashCode();

                if (this.OutcomesScoresCount != null)
                    hash = hash * 59 + this.OutcomesScoresCount.GetHashCode();

                return hash;
            }
        }
    }

}
