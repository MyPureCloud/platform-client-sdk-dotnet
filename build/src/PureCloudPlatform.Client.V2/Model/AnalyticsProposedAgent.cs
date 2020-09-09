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
    /// AnalyticsProposedAgent
    /// </summary>
    [DataContract]
    public partial class AnalyticsProposedAgent :  IEquatable<AnalyticsProposedAgent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsProposedAgent" /> class.
        /// </summary>
        /// <param name="ProposedAgentId">Unique identifier of an agent that was proposed by predictive routing.</param>
        /// <param name="AgentRank">Proposed agent rank for this conversation from predictive routing (lower is better).</param>
        public AnalyticsProposedAgent(string ProposedAgentId = null, int? AgentRank = null)
        {
            this.ProposedAgentId = ProposedAgentId;
            this.AgentRank = AgentRank;
            
        }
        
        
        
        /// <summary>
        /// Unique identifier of an agent that was proposed by predictive routing
        /// </summary>
        /// <value>Unique identifier of an agent that was proposed by predictive routing</value>
        [DataMember(Name="proposedAgentId", EmitDefaultValue=false)]
        public string ProposedAgentId { get; set; }
        
        
        
        /// <summary>
        /// Proposed agent rank for this conversation from predictive routing (lower is better)
        /// </summary>
        /// <value>Proposed agent rank for this conversation from predictive routing (lower is better)</value>
        [DataMember(Name="agentRank", EmitDefaultValue=false)]
        public int? AgentRank { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsProposedAgent {\n");
            
            sb.Append("  ProposedAgentId: ").Append(ProposedAgentId).Append("\n");
            sb.Append("  AgentRank: ").Append(AgentRank).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AnalyticsProposedAgent);
        }

        /// <summary>
        /// Returns true if AnalyticsProposedAgent instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsProposedAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsProposedAgent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ProposedAgentId == other.ProposedAgentId ||
                    this.ProposedAgentId != null &&
                    this.ProposedAgentId.Equals(other.ProposedAgentId)
                ) &&
                (
                    this.AgentRank == other.AgentRank ||
                    this.AgentRank != null &&
                    this.AgentRank.Equals(other.AgentRank)
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
                
                if (this.ProposedAgentId != null)
                    hash = hash * 59 + this.ProposedAgentId.GetHashCode();
                
                if (this.AgentRank != null)
                    hash = hash * 59 + this.AgentRank.GetHashCode();
                
                return hash;
            }
        }
    }

}
