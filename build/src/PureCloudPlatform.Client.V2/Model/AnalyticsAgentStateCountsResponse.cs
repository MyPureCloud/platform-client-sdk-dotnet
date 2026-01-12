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
    /// AnalyticsAgentStateCountsResponse
    /// </summary>
    [DataContract]
    public partial class AnalyticsAgentStateCountsResponse :  IEquatable<AnalyticsAgentStateCountsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsAgentStateCountsResponse" /> class.
        /// </summary>
        /// <param name="SegmentCounts">List of count by segment types.</param>
        /// <param name="PresenceCounts">List of count by presences.</param>
        /// <param name="RoutingStatusCounts">List of count by routing statuses.</param>
        /// <param name="IsOutOfOfficeCounts">List of count by out of office states.</param>
        public AnalyticsAgentStateCountsResponse(List<AgentStateSegmentTypeCount> SegmentCounts = null, List<AgentStatePresenceCount> PresenceCounts = null, List<AgentStateRoutingStatusCount> RoutingStatusCounts = null, List<AgentStateIsOutOfOfficeCount> IsOutOfOfficeCounts = null)
        {
            this.SegmentCounts = SegmentCounts;
            this.PresenceCounts = PresenceCounts;
            this.RoutingStatusCounts = RoutingStatusCounts;
            this.IsOutOfOfficeCounts = IsOutOfOfficeCounts;
            
        }
        


        /// <summary>
        /// List of count by segment types
        /// </summary>
        /// <value>List of count by segment types</value>
        [DataMember(Name="segmentCounts", EmitDefaultValue=false)]
        public List<AgentStateSegmentTypeCount> SegmentCounts { get; set; }



        /// <summary>
        /// List of count by presences
        /// </summary>
        /// <value>List of count by presences</value>
        [DataMember(Name="presenceCounts", EmitDefaultValue=false)]
        public List<AgentStatePresenceCount> PresenceCounts { get; set; }



        /// <summary>
        /// List of count by routing statuses
        /// </summary>
        /// <value>List of count by routing statuses</value>
        [DataMember(Name="routingStatusCounts", EmitDefaultValue=false)]
        public List<AgentStateRoutingStatusCount> RoutingStatusCounts { get; set; }



        /// <summary>
        /// List of count by out of office states
        /// </summary>
        /// <value>List of count by out of office states</value>
        [DataMember(Name="isOutOfOfficeCounts", EmitDefaultValue=false)]
        public List<AgentStateIsOutOfOfficeCount> IsOutOfOfficeCounts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsAgentStateCountsResponse {\n");

            sb.Append("  SegmentCounts: ").Append(SegmentCounts).Append("\n");
            sb.Append("  PresenceCounts: ").Append(PresenceCounts).Append("\n");
            sb.Append("  RoutingStatusCounts: ").Append(RoutingStatusCounts).Append("\n");
            sb.Append("  IsOutOfOfficeCounts: ").Append(IsOutOfOfficeCounts).Append("\n");
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
            return this.Equals(obj as AnalyticsAgentStateCountsResponse);
        }

        /// <summary>
        /// Returns true if AnalyticsAgentStateCountsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsAgentStateCountsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsAgentStateCountsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SegmentCounts == other.SegmentCounts ||
                    this.SegmentCounts != null &&
                    this.SegmentCounts.SequenceEqual(other.SegmentCounts)
                ) &&
                (
                    this.PresenceCounts == other.PresenceCounts ||
                    this.PresenceCounts != null &&
                    this.PresenceCounts.SequenceEqual(other.PresenceCounts)
                ) &&
                (
                    this.RoutingStatusCounts == other.RoutingStatusCounts ||
                    this.RoutingStatusCounts != null &&
                    this.RoutingStatusCounts.SequenceEqual(other.RoutingStatusCounts)
                ) &&
                (
                    this.IsOutOfOfficeCounts == other.IsOutOfOfficeCounts ||
                    this.IsOutOfOfficeCounts != null &&
                    this.IsOutOfOfficeCounts.SequenceEqual(other.IsOutOfOfficeCounts)
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
                if (this.SegmentCounts != null)
                    hash = hash * 59 + this.SegmentCounts.GetHashCode();

                if (this.PresenceCounts != null)
                    hash = hash * 59 + this.PresenceCounts.GetHashCode();

                if (this.RoutingStatusCounts != null)
                    hash = hash * 59 + this.RoutingStatusCounts.GetHashCode();

                if (this.IsOutOfOfficeCounts != null)
                    hash = hash * 59 + this.IsOutOfOfficeCounts.GetHashCode();

                return hash;
            }
        }
    }

}
