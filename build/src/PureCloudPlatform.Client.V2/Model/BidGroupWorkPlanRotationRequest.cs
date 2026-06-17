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
    /// BidGroupWorkPlanRotationRequest
    /// </summary>
    [DataContract]
    public partial class BidGroupWorkPlanRotationRequest :  IEquatable<BidGroupWorkPlanRotationRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BidGroupWorkPlanRotationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BidGroupWorkPlanRotationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BidGroupWorkPlanRotationRequest" /> class.
        /// </summary>
        /// <param name="WorkPlanRotationId">The ID of the work plan rotation used in the bid group (required).</param>
        /// <param name="AgentCount">The count of agents that can be assigned to this work plan rotation (required).</param>
        public BidGroupWorkPlanRotationRequest(string WorkPlanRotationId = null, int? AgentCount = null)
        {
            this.WorkPlanRotationId = WorkPlanRotationId;
            this.AgentCount = AgentCount;
            
        }
        


        /// <summary>
        /// The ID of the work plan rotation used in the bid group
        /// </summary>
        /// <value>The ID of the work plan rotation used in the bid group</value>
        [DataMember(Name="workPlanRotationId", EmitDefaultValue=false)]
        public string WorkPlanRotationId { get; set; }



        /// <summary>
        /// The count of agents that can be assigned to this work plan rotation
        /// </summary>
        /// <value>The count of agents that can be assigned to this work plan rotation</value>
        [DataMember(Name="agentCount", EmitDefaultValue=false)]
        public int? AgentCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BidGroupWorkPlanRotationRequest {\n");

            sb.Append("  WorkPlanRotationId: ").Append(WorkPlanRotationId).Append("\n");
            sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
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
            return this.Equals(obj as BidGroupWorkPlanRotationRequest);
        }

        /// <summary>
        /// Returns true if BidGroupWorkPlanRotationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BidGroupWorkPlanRotationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BidGroupWorkPlanRotationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WorkPlanRotationId == other.WorkPlanRotationId ||
                    this.WorkPlanRotationId != null &&
                    this.WorkPlanRotationId.Equals(other.WorkPlanRotationId)
                ) &&
                (
                    this.AgentCount == other.AgentCount ||
                    this.AgentCount != null &&
                    this.AgentCount.Equals(other.AgentCount)
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
                if (this.WorkPlanRotationId != null)
                    hash = hash * 59 + this.WorkPlanRotationId.GetHashCode();

                if (this.AgentCount != null)
                    hash = hash * 59 + this.AgentCount.GetHashCode();

                return hash;
            }
        }
    }

}
