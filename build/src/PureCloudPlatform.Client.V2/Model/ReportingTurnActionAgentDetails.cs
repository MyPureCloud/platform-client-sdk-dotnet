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
    /// ReportingTurnActionAgentDetails
    /// </summary>
    [DataContract]
    public partial class ReportingTurnActionAgentDetails :  IEquatable<ReportingTurnActionAgentDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurnActionAgentDetails" /> class.
        /// </summary>
        /// <param name="AgentId">The agent ID used in an action..</param>
        /// <param name="AgentName">The agent name used in an action..</param>
        /// <param name="AgentVersion">The agent version used in an action..</param>
        public ReportingTurnActionAgentDetails(string AgentId = null, string AgentName = null, string AgentVersion = null)
        {
            this.AgentId = AgentId;
            this.AgentName = AgentName;
            this.AgentVersion = AgentVersion;
            
        }
        


        /// <summary>
        /// The agent ID used in an action.
        /// </summary>
        /// <value>The agent ID used in an action.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// The agent name used in an action.
        /// </summary>
        /// <value>The agent name used in an action.</value>
        [DataMember(Name="agentName", EmitDefaultValue=false)]
        public string AgentName { get; set; }



        /// <summary>
        /// The agent version used in an action.
        /// </summary>
        /// <value>The agent version used in an action.</value>
        [DataMember(Name="agentVersion", EmitDefaultValue=false)]
        public string AgentVersion { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurnActionAgentDetails {\n");

            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  AgentName: ").Append(AgentName).Append("\n");
            sb.Append("  AgentVersion: ").Append(AgentVersion).Append("\n");
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
            return this.Equals(obj as ReportingTurnActionAgentDetails);
        }

        /// <summary>
        /// Returns true if ReportingTurnActionAgentDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurnActionAgentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurnActionAgentDetails other)
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
                    this.AgentName == other.AgentName ||
                    this.AgentName != null &&
                    this.AgentName.Equals(other.AgentName)
                ) &&
                (
                    this.AgentVersion == other.AgentVersion ||
                    this.AgentVersion != null &&
                    this.AgentVersion.Equals(other.AgentVersion)
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

                if (this.AgentName != null)
                    hash = hash * 59 + this.AgentName.GetHashCode();

                if (this.AgentVersion != null)
                    hash = hash * 59 + this.AgentVersion.GetHashCode();

                return hash;
            }
        }
    }

}
