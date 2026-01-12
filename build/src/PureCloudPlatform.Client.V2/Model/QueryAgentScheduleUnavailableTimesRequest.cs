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
    /// QueryAgentScheduleUnavailableTimesRequest
    /// </summary>
    [DataContract]
    public partial class QueryAgentScheduleUnavailableTimesRequest :  IEquatable<QueryAgentScheduleUnavailableTimesRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAgentScheduleUnavailableTimesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryAgentScheduleUnavailableTimesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAgentScheduleUnavailableTimesRequest" /> class.
        /// </summary>
        /// <param name="AgentId">The ID of the agent for whom to fetch unavailable times (required).</param>
        /// <param name="Schedule">The schedule for which to fetch unavailable times for the agent (required).</param>
        public QueryAgentScheduleUnavailableTimesRequest(string AgentId = null, BuScheduleReference Schedule = null)
        {
            this.AgentId = AgentId;
            this.Schedule = Schedule;
            
        }
        


        /// <summary>
        /// The ID of the agent for whom to fetch unavailable times
        /// </summary>
        /// <value>The ID of the agent for whom to fetch unavailable times</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// The schedule for which to fetch unavailable times for the agent
        /// </summary>
        /// <value>The schedule for which to fetch unavailable times for the agent</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public BuScheduleReference Schedule { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAgentScheduleUnavailableTimesRequest {\n");

            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(obj as QueryAgentScheduleUnavailableTimesRequest);
        }

        /// <summary>
        /// Returns true if QueryAgentScheduleUnavailableTimesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryAgentScheduleUnavailableTimesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryAgentScheduleUnavailableTimesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
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
                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                return hash;
            }
        }
    }

}
