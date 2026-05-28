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
    /// BulkAddOpportunitiesRequest
    /// </summary>
    [DataContract]
    public partial class BulkAddOpportunitiesRequest :  IEquatable<BulkAddOpportunitiesRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddOpportunitiesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkAddOpportunitiesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddOpportunitiesRequest" /> class.
        /// </summary>
        /// <param name="Opportunities">The opportunities to add (required).</param>
        /// <param name="AgentIds">The IDs of the agents who are invited to the opportunities being added.</param>
        public BulkAddOpportunitiesRequest(List<AddOpportunityBody> Opportunities = null, List<string> AgentIds = null)
        {
            this.Opportunities = Opportunities;
            this.AgentIds = AgentIds;
            
        }
        


        /// <summary>
        /// The opportunities to add
        /// </summary>
        /// <value>The opportunities to add</value>
        [DataMember(Name="opportunities", EmitDefaultValue=false)]
        public List<AddOpportunityBody> Opportunities { get; set; }



        /// <summary>
        /// The IDs of the agents who are invited to the opportunities being added
        /// </summary>
        /// <value>The IDs of the agents who are invited to the opportunities being added</value>
        [DataMember(Name="agentIds", EmitDefaultValue=false)]
        public List<string> AgentIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkAddOpportunitiesRequest {\n");

            sb.Append("  Opportunities: ").Append(Opportunities).Append("\n");
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
            return this.Equals(obj as BulkAddOpportunitiesRequest);
        }

        /// <summary>
        /// Returns true if BulkAddOpportunitiesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkAddOpportunitiesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkAddOpportunitiesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Opportunities == other.Opportunities ||
                    this.Opportunities != null &&
                    this.Opportunities.SequenceEqual(other.Opportunities)
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
                if (this.Opportunities != null)
                    hash = hash * 59 + this.Opportunities.GetHashCode();

                if (this.AgentIds != null)
                    hash = hash * 59 + this.AgentIds.GetHashCode();

                return hash;
            }
        }
    }

}
