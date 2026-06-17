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
    /// AgentsBidAssignedScheduleSetOverrideRequest
    /// </summary>
    [DataContract]
    public partial class AgentsBidAssignedScheduleSetOverrideRequest :  IEquatable<AgentsBidAssignedScheduleSetOverrideRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsBidAssignedScheduleSetOverrideRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentsBidAssignedScheduleSetOverrideRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsBidAssignedScheduleSetOverrideRequest" /> class.
        /// </summary>
        /// <param name="AgentScheduleSetOverrides">The agent schedule set overrides (required).</param>
        public AgentsBidAssignedScheduleSetOverrideRequest(List<AgentBidScheduleSetOverrideRequest> AgentScheduleSetOverrides = null)
        {
            this.AgentScheduleSetOverrides = AgentScheduleSetOverrides;
            
        }
        


        /// <summary>
        /// The agent schedule set overrides
        /// </summary>
        /// <value>The agent schedule set overrides</value>
        [DataMember(Name="agentScheduleSetOverrides", EmitDefaultValue=false)]
        public List<AgentBidScheduleSetOverrideRequest> AgentScheduleSetOverrides { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentsBidAssignedScheduleSetOverrideRequest {\n");

            sb.Append("  AgentScheduleSetOverrides: ").Append(AgentScheduleSetOverrides).Append("\n");
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
            return this.Equals(obj as AgentsBidAssignedScheduleSetOverrideRequest);
        }

        /// <summary>
        /// Returns true if AgentsBidAssignedScheduleSetOverrideRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentsBidAssignedScheduleSetOverrideRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentsBidAssignedScheduleSetOverrideRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentScheduleSetOverrides == other.AgentScheduleSetOverrides ||
                    this.AgentScheduleSetOverrides != null &&
                    this.AgentScheduleSetOverrides.SequenceEqual(other.AgentScheduleSetOverrides)
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
                if (this.AgentScheduleSetOverrides != null)
                    hash = hash * 59 + this.AgentScheduleSetOverrides.GetHashCode();

                return hash;
            }
        }
    }

}
