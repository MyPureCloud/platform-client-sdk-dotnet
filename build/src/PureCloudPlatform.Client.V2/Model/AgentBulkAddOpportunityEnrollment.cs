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
    /// AgentBulkAddOpportunityEnrollment
    /// </summary>
    [DataContract]
    public partial class AgentBulkAddOpportunityEnrollment :  IEquatable<AgentBulkAddOpportunityEnrollment>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBulkAddOpportunityEnrollment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentBulkAddOpportunityEnrollment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBulkAddOpportunityEnrollment" /> class.
        /// </summary>
        /// <param name="OpportunityId">The ID of the opportunity in which the agent was enrolled (required).</param>
        public AgentBulkAddOpportunityEnrollment(string OpportunityId = null)
        {
            this.OpportunityId = OpportunityId;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The ID of the opportunity in which the agent was enrolled
        /// </summary>
        /// <value>The ID of the opportunity in which the agent was enrolled</value>
        [DataMember(Name="opportunityId", EmitDefaultValue=false)]
        public string OpportunityId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentBulkAddOpportunityEnrollment {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OpportunityId: ").Append(OpportunityId).Append("\n");
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
            return this.Equals(obj as AgentBulkAddOpportunityEnrollment);
        }

        /// <summary>
        /// Returns true if AgentBulkAddOpportunityEnrollment instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentBulkAddOpportunityEnrollment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentBulkAddOpportunityEnrollment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.OpportunityId == other.OpportunityId ||
                    this.OpportunityId != null &&
                    this.OpportunityId.Equals(other.OpportunityId)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.OpportunityId != null)
                    hash = hash * 59 + this.OpportunityId.GetHashCode();

                return hash;
            }
        }
    }

}
