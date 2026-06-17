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
    /// AgentScheduleBiddingPreferencePriority
    /// </summary>
    [DataContract]
    public partial class AgentScheduleBiddingPreferencePriority :  IEquatable<AgentScheduleBiddingPreferencePriority>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleBiddingPreferencePriority" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentScheduleBiddingPreferencePriority() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleBiddingPreferencePriority" /> class.
        /// </summary>
        /// <param name="ScheduleSetId">The ID of the schedule set that belongs to agent&#39;s bid group (required).</param>
        /// <param name="Priority">The agent&#39;s priority for this schedule set. Lower numbers indicate higher priority, with 1 being the highest priority. Minimum value is 1. Null if priority is not set for the schedule set.</param>
        public AgentScheduleBiddingPreferencePriority(string ScheduleSetId = null, int? Priority = null)
        {
            this.ScheduleSetId = ScheduleSetId;
            this.Priority = Priority;
            
        }
        


        /// <summary>
        /// The ID of the schedule set that belongs to agent&#39;s bid group
        /// </summary>
        /// <value>The ID of the schedule set that belongs to agent&#39;s bid group</value>
        [DataMember(Name="scheduleSetId", EmitDefaultValue=false)]
        public string ScheduleSetId { get; set; }



        /// <summary>
        /// The agent&#39;s priority for this schedule set. Lower numbers indicate higher priority, with 1 being the highest priority. Minimum value is 1. Null if priority is not set for the schedule set
        /// </summary>
        /// <value>The agent&#39;s priority for this schedule set. Lower numbers indicate higher priority, with 1 being the highest priority. Minimum value is 1. Null if priority is not set for the schedule set</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentScheduleBiddingPreferencePriority {\n");

            sb.Append("  ScheduleSetId: ").Append(ScheduleSetId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(obj as AgentScheduleBiddingPreferencePriority);
        }

        /// <summary>
        /// Returns true if AgentScheduleBiddingPreferencePriority instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentScheduleBiddingPreferencePriority to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentScheduleBiddingPreferencePriority other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ScheduleSetId == other.ScheduleSetId ||
                    this.ScheduleSetId != null &&
                    this.ScheduleSetId.Equals(other.ScheduleSetId)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
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
                if (this.ScheduleSetId != null)
                    hash = hash * 59 + this.ScheduleSetId.GetHashCode();

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                return hash;
            }
        }
    }

}
