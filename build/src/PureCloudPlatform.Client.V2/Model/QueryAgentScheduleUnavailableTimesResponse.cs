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
    /// QueryAgentScheduleUnavailableTimesResponse
    /// </summary>
    [DataContract]
    public partial class QueryAgentScheduleUnavailableTimesResponse :  IEquatable<QueryAgentScheduleUnavailableTimesResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAgentScheduleUnavailableTimesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryAgentScheduleUnavailableTimesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAgentScheduleUnavailableTimesResponse" /> class.
        /// </summary>
        /// <param name="ConsideredInScheduleGeneration">Indicates whether the unavailability times were considered in schedule generation. Returns false when no schedule exists (required).</param>
        /// <param name="ScheduleGenerationUnavailableTimes">List of the unavailable times used in schedule generation (required).</param>
        public QueryAgentScheduleUnavailableTimesResponse(bool? ConsideredInScheduleGeneration = null, List<AgentScheduleUnavailableTime> ScheduleGenerationUnavailableTimes = null)
        {
            this.ConsideredInScheduleGeneration = ConsideredInScheduleGeneration;
            this.ScheduleGenerationUnavailableTimes = ScheduleGenerationUnavailableTimes;
            
        }
        


        /// <summary>
        /// Indicates whether the unavailability times were considered in schedule generation. Returns false when no schedule exists
        /// </summary>
        /// <value>Indicates whether the unavailability times were considered in schedule generation. Returns false when no schedule exists</value>
        [DataMember(Name="consideredInScheduleGeneration", EmitDefaultValue=false)]
        public bool? ConsideredInScheduleGeneration { get; set; }



        /// <summary>
        /// List of the unavailable times used in schedule generation
        /// </summary>
        /// <value>List of the unavailable times used in schedule generation</value>
        [DataMember(Name="scheduleGenerationUnavailableTimes", EmitDefaultValue=false)]
        public List<AgentScheduleUnavailableTime> ScheduleGenerationUnavailableTimes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAgentScheduleUnavailableTimesResponse {\n");

            sb.Append("  ConsideredInScheduleGeneration: ").Append(ConsideredInScheduleGeneration).Append("\n");
            sb.Append("  ScheduleGenerationUnavailableTimes: ").Append(ScheduleGenerationUnavailableTimes).Append("\n");
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
            return this.Equals(obj as QueryAgentScheduleUnavailableTimesResponse);
        }

        /// <summary>
        /// Returns true if QueryAgentScheduleUnavailableTimesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryAgentScheduleUnavailableTimesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryAgentScheduleUnavailableTimesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConsideredInScheduleGeneration == other.ConsideredInScheduleGeneration ||
                    this.ConsideredInScheduleGeneration != null &&
                    this.ConsideredInScheduleGeneration.Equals(other.ConsideredInScheduleGeneration)
                ) &&
                (
                    this.ScheduleGenerationUnavailableTimes == other.ScheduleGenerationUnavailableTimes ||
                    this.ScheduleGenerationUnavailableTimes != null &&
                    this.ScheduleGenerationUnavailableTimes.SequenceEqual(other.ScheduleGenerationUnavailableTimes)
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
                if (this.ConsideredInScheduleGeneration != null)
                    hash = hash * 59 + this.ConsideredInScheduleGeneration.GetHashCode();

                if (this.ScheduleGenerationUnavailableTimes != null)
                    hash = hash * 59 + this.ScheduleGenerationUnavailableTimes.GetHashCode();

                return hash;
            }
        }
    }

}
