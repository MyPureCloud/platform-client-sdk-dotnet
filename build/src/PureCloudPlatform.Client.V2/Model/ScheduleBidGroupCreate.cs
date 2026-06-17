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
    /// ScheduleBidGroupCreate
    /// </summary>
    [DataContract]
    public partial class ScheduleBidGroupCreate :  IEquatable<ScheduleBidGroupCreate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidGroupCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleBidGroupCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidGroupCreate" /> class.
        /// </summary>
        /// <param name="Name">The name of the schedule bid group (required).</param>
        /// <param name="ManagementUnitId">The ID of the management unit to which this bid group belongs (required).</param>
        /// <param name="AgentIds">The IDs of the agents who participate in this bid group (required).</param>
        /// <param name="WorkPlanIds">The IDs of the work plans used in this bid group.</param>
        /// <param name="WorkPlanRotations">The work plan rotations used in this bid group.</param>
        /// <param name="PlanningGroupIds">The IDs of the planning groups selected in this bid group (required).</param>
        public ScheduleBidGroupCreate(string Name = null, string ManagementUnitId = null, List<string> AgentIds = null, List<string> WorkPlanIds = null, List<BidGroupWorkPlanRotationRequest> WorkPlanRotations = null, List<string> PlanningGroupIds = null)
        {
            this.Name = Name;
            this.ManagementUnitId = ManagementUnitId;
            this.AgentIds = AgentIds;
            this.WorkPlanIds = WorkPlanIds;
            this.WorkPlanRotations = WorkPlanRotations;
            this.PlanningGroupIds = PlanningGroupIds;
            
        }
        


        /// <summary>
        /// The name of the schedule bid group
        /// </summary>
        /// <value>The name of the schedule bid group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The ID of the management unit to which this bid group belongs
        /// </summary>
        /// <value>The ID of the management unit to which this bid group belongs</value>
        [DataMember(Name="managementUnitId", EmitDefaultValue=false)]
        public string ManagementUnitId { get; set; }



        /// <summary>
        /// The IDs of the agents who participate in this bid group
        /// </summary>
        /// <value>The IDs of the agents who participate in this bid group</value>
        [DataMember(Name="agentIds", EmitDefaultValue=false)]
        public List<string> AgentIds { get; set; }



        /// <summary>
        /// The IDs of the work plans used in this bid group
        /// </summary>
        /// <value>The IDs of the work plans used in this bid group</value>
        [DataMember(Name="workPlanIds", EmitDefaultValue=false)]
        public List<string> WorkPlanIds { get; set; }



        /// <summary>
        /// The work plan rotations used in this bid group
        /// </summary>
        /// <value>The work plan rotations used in this bid group</value>
        [DataMember(Name="workPlanRotations", EmitDefaultValue=false)]
        public List<BidGroupWorkPlanRotationRequest> WorkPlanRotations { get; set; }



        /// <summary>
        /// The IDs of the planning groups selected in this bid group
        /// </summary>
        /// <value>The IDs of the planning groups selected in this bid group</value>
        [DataMember(Name="planningGroupIds", EmitDefaultValue=false)]
        public List<string> PlanningGroupIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleBidGroupCreate {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
            sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
            sb.Append("  WorkPlanIds: ").Append(WorkPlanIds).Append("\n");
            sb.Append("  WorkPlanRotations: ").Append(WorkPlanRotations).Append("\n");
            sb.Append("  PlanningGroupIds: ").Append(PlanningGroupIds).Append("\n");
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
            return this.Equals(obj as ScheduleBidGroupCreate);
        }

        /// <summary>
        /// Returns true if ScheduleBidGroupCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleBidGroupCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleBidGroupCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ManagementUnitId == other.ManagementUnitId ||
                    this.ManagementUnitId != null &&
                    this.ManagementUnitId.Equals(other.ManagementUnitId)
                ) &&
                (
                    this.AgentIds == other.AgentIds ||
                    this.AgentIds != null &&
                    this.AgentIds.SequenceEqual(other.AgentIds)
                ) &&
                (
                    this.WorkPlanIds == other.WorkPlanIds ||
                    this.WorkPlanIds != null &&
                    this.WorkPlanIds.SequenceEqual(other.WorkPlanIds)
                ) &&
                (
                    this.WorkPlanRotations == other.WorkPlanRotations ||
                    this.WorkPlanRotations != null &&
                    this.WorkPlanRotations.SequenceEqual(other.WorkPlanRotations)
                ) &&
                (
                    this.PlanningGroupIds == other.PlanningGroupIds ||
                    this.PlanningGroupIds != null &&
                    this.PlanningGroupIds.SequenceEqual(other.PlanningGroupIds)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ManagementUnitId != null)
                    hash = hash * 59 + this.ManagementUnitId.GetHashCode();

                if (this.AgentIds != null)
                    hash = hash * 59 + this.AgentIds.GetHashCode();

                if (this.WorkPlanIds != null)
                    hash = hash * 59 + this.WorkPlanIds.GetHashCode();

                if (this.WorkPlanRotations != null)
                    hash = hash * 59 + this.WorkPlanRotations.GetHashCode();

                if (this.PlanningGroupIds != null)
                    hash = hash * 59 + this.PlanningGroupIds.GetHashCode();

                return hash;
            }
        }
    }

}
