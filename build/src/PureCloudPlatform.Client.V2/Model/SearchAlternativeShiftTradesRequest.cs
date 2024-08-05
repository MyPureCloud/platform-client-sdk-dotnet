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
    /// SearchAlternativeShiftTradesRequest
    /// </summary>
    [DataContract]
    public partial class SearchAlternativeShiftTradesRequest :  IEquatable<SearchAlternativeShiftTradesRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAlternativeShiftTradesRequest" /> class.
        /// </summary>
        /// <param name="ManagementUnitIds">The list of management unit IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required.</param>
        /// <param name="AgentIds">The list of agent IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required.</param>
        public SearchAlternativeShiftTradesRequest(List<string> ManagementUnitIds = null, List<string> AgentIds = null)
        {
            this.ManagementUnitIds = ManagementUnitIds;
            this.AgentIds = AgentIds;
            
        }
        


        /// <summary>
        /// The list of management unit IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required
        /// </summary>
        /// <value>The list of management unit IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required</value>
        [DataMember(Name="managementUnitIds", EmitDefaultValue=false)]
        public List<string> ManagementUnitIds { get; set; }



        /// <summary>
        /// The list of agent IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required
        /// </summary>
        /// <value>The list of agent IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required</value>
        [DataMember(Name="agentIds", EmitDefaultValue=false)]
        public List<string> AgentIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchAlternativeShiftTradesRequest {\n");

            sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
            sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
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
            return this.Equals(obj as SearchAlternativeShiftTradesRequest);
        }

        /// <summary>
        /// Returns true if SearchAlternativeShiftTradesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchAlternativeShiftTradesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchAlternativeShiftTradesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnitIds == other.ManagementUnitIds ||
                    this.ManagementUnitIds != null &&
                    this.ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
                ) &&
                (
                    this.AgentIds == other.AgentIds ||
                    this.AgentIds != null &&
                    this.AgentIds.SequenceEqual(other.AgentIds)
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
                if (this.ManagementUnitIds != null)
                    hash = hash * 59 + this.ManagementUnitIds.GetHashCode();

                if (this.AgentIds != null)
                    hash = hash * 59 + this.AgentIds.GetHashCode();

                return hash;
            }
        }
    }

}
