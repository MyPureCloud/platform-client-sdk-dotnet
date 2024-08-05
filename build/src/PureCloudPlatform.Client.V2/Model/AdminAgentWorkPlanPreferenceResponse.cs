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
    /// AdminAgentWorkPlanPreferenceResponse
    /// </summary>
    [DataContract]
    public partial class AdminAgentWorkPlanPreferenceResponse :  IEquatable<AdminAgentWorkPlanPreferenceResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAgentWorkPlanPreferenceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdminAgentWorkPlanPreferenceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAgentWorkPlanPreferenceResponse" /> class.
        /// </summary>
        /// <param name="WorkPlans">The list of work plans that belong to this bid group (required).</param>
        /// <param name="AgentWorkPlanBidPreferences">The list of agents work plan bidding preferences (required).</param>
        public AdminAgentWorkPlanPreferenceResponse(List<WorkPlanReference> WorkPlans = null, List<AdminAgentWorkPlanBiddingPreference> AgentWorkPlanBidPreferences = null)
        {
            this.WorkPlans = WorkPlans;
            this.AgentWorkPlanBidPreferences = AgentWorkPlanBidPreferences;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The list of work plans that belong to this bid group
        /// </summary>
        /// <value>The list of work plans that belong to this bid group</value>
        [DataMember(Name="workPlans", EmitDefaultValue=false)]
        public List<WorkPlanReference> WorkPlans { get; set; }



        /// <summary>
        /// The list of agents work plan bidding preferences
        /// </summary>
        /// <value>The list of agents work plan bidding preferences</value>
        [DataMember(Name="agentWorkPlanBidPreferences", EmitDefaultValue=false)]
        public List<AdminAgentWorkPlanBiddingPreference> AgentWorkPlanBidPreferences { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminAgentWorkPlanPreferenceResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WorkPlans: ").Append(WorkPlans).Append("\n");
            sb.Append("  AgentWorkPlanBidPreferences: ").Append(AgentWorkPlanBidPreferences).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as AdminAgentWorkPlanPreferenceResponse);
        }

        /// <summary>
        /// Returns true if AdminAgentWorkPlanPreferenceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminAgentWorkPlanPreferenceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminAgentWorkPlanPreferenceResponse other)
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
                    this.WorkPlans == other.WorkPlans ||
                    this.WorkPlans != null &&
                    this.WorkPlans.SequenceEqual(other.WorkPlans)
                ) &&
                (
                    this.AgentWorkPlanBidPreferences == other.AgentWorkPlanBidPreferences ||
                    this.AgentWorkPlanBidPreferences != null &&
                    this.AgentWorkPlanBidPreferences.SequenceEqual(other.AgentWorkPlanBidPreferences)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.WorkPlans != null)
                    hash = hash * 59 + this.WorkPlans.GetHashCode();

                if (this.AgentWorkPlanBidPreferences != null)
                    hash = hash * 59 + this.AgentWorkPlanBidPreferences.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
