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
    /// ConversationMetricsTopicConversationProposedAgent
    /// </summary>
    [DataContract]
    public partial class ConversationMetricsTopicConversationProposedAgent :  IEquatable<ConversationMetricsTopicConversationProposedAgent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMetricsTopicConversationProposedAgent" /> class.
        /// </summary>
        /// <param name="AgentRank">Proposed agent rank for this conversation from predictive routing (lower is better).</param>
        /// <param name="ProposedAgentId">Unique identifier for the agent that was proposed by predictive routing.</param>
        public ConversationMetricsTopicConversationProposedAgent(int? AgentRank = null, string ProposedAgentId = null)
        {
            this.AgentRank = AgentRank;
            this.ProposedAgentId = ProposedAgentId;
            
        }
        


        /// <summary>
        /// Proposed agent rank for this conversation from predictive routing (lower is better)
        /// </summary>
        /// <value>Proposed agent rank for this conversation from predictive routing (lower is better)</value>
        [DataMember(Name="agentRank", EmitDefaultValue=false)]
        public int? AgentRank { get; set; }



        /// <summary>
        /// Unique identifier for the agent that was proposed by predictive routing
        /// </summary>
        /// <value>Unique identifier for the agent that was proposed by predictive routing</value>
        [DataMember(Name="proposedAgentId", EmitDefaultValue=false)]
        public string ProposedAgentId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationMetricsTopicConversationProposedAgent {\n");

            sb.Append("  AgentRank: ").Append(AgentRank).Append("\n");
            sb.Append("  ProposedAgentId: ").Append(ProposedAgentId).Append("\n");
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
            return this.Equals(obj as ConversationMetricsTopicConversationProposedAgent);
        }

        /// <summary>
        /// Returns true if ConversationMetricsTopicConversationProposedAgent instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationMetricsTopicConversationProposedAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationMetricsTopicConversationProposedAgent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentRank == other.AgentRank ||
                    this.AgentRank != null &&
                    this.AgentRank.Equals(other.AgentRank)
                ) &&
                (
                    this.ProposedAgentId == other.ProposedAgentId ||
                    this.ProposedAgentId != null &&
                    this.ProposedAgentId.Equals(other.ProposedAgentId)
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
                if (this.AgentRank != null)
                    hash = hash * 59 + this.AgentRank.GetHashCode();

                if (this.ProposedAgentId != null)
                    hash = hash * 59 + this.ProposedAgentId.GetHashCode();

                return hash;
            }
        }
    }

}
