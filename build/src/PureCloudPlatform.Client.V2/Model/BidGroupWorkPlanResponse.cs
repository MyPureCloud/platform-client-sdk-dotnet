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
    /// BidGroupWorkPlanResponse
    /// </summary>
    [DataContract]
    public partial class BidGroupWorkPlanResponse :  IEquatable<BidGroupWorkPlanResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BidGroupWorkPlanResponse" /> class.
        /// </summary>
        /// <param name="ManagementUnit">The management unit to which this work plan belongs.  Nullable in some routes.</param>
        /// <param name="OverrideAgentCount">The modified agent count for this work plan.</param>
        public BidGroupWorkPlanResponse(ManagementUnitReference ManagementUnit = null, int? OverrideAgentCount = null)
        {
            this.ManagementUnit = ManagementUnit;
            this.OverrideAgentCount = OverrideAgentCount;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The management unit to which this work plan belongs.  Nullable in some routes
        /// </summary>
        /// <value>The management unit to which this work plan belongs.  Nullable in some routes</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }



        /// <summary>
        /// The modified agent count for this work plan
        /// </summary>
        /// <value>The modified agent count for this work plan</value>
        [DataMember(Name="overrideAgentCount", EmitDefaultValue=false)]
        public int? OverrideAgentCount { get; set; }



        /// <summary>
        /// The number of agents needed for this work plan to produce the optimal schedule
        /// </summary>
        /// <value>The number of agents needed for this work plan to produce the optimal schedule</value>
        [DataMember(Name="suggestedAgentCount", EmitDefaultValue=false)]
        public int? SuggestedAgentCount { get; private set; }



        /// <summary>
        /// The range of agent slot count per work plan. The suggested slot count must be in agent count range
        /// </summary>
        /// <value>The range of agent slot count per work plan. The suggested slot count must be in agent count range</value>
        [DataMember(Name="agentCountRange", EmitDefaultValue=false)]
        public AgentCountRange AgentCountRange { get; private set; }



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
            sb.Append("class BidGroupWorkPlanResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  OverrideAgentCount: ").Append(OverrideAgentCount).Append("\n");
            sb.Append("  SuggestedAgentCount: ").Append(SuggestedAgentCount).Append("\n");
            sb.Append("  AgentCountRange: ").Append(AgentCountRange).Append("\n");
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
            return this.Equals(obj as BidGroupWorkPlanResponse);
        }

        /// <summary>
        /// Returns true if BidGroupWorkPlanResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BidGroupWorkPlanResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BidGroupWorkPlanResponse other)
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
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.OverrideAgentCount == other.OverrideAgentCount ||
                    this.OverrideAgentCount != null &&
                    this.OverrideAgentCount.Equals(other.OverrideAgentCount)
                ) &&
                (
                    this.SuggestedAgentCount == other.SuggestedAgentCount ||
                    this.SuggestedAgentCount != null &&
                    this.SuggestedAgentCount.Equals(other.SuggestedAgentCount)
                ) &&
                (
                    this.AgentCountRange == other.AgentCountRange ||
                    this.AgentCountRange != null &&
                    this.AgentCountRange.Equals(other.AgentCountRange)
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

                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();

                if (this.OverrideAgentCount != null)
                    hash = hash * 59 + this.OverrideAgentCount.GetHashCode();

                if (this.SuggestedAgentCount != null)
                    hash = hash * 59 + this.SuggestedAgentCount.GetHashCode();

                if (this.AgentCountRange != null)
                    hash = hash * 59 + this.AgentCountRange.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
