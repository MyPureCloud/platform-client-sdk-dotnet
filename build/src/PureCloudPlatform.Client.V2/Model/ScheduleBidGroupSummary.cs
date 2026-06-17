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
    /// ScheduleBidGroupSummary
    /// </summary>
    [DataContract]
    public partial class ScheduleBidGroupSummary :  IEquatable<ScheduleBidGroupSummary>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidGroupSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleBidGroupSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidGroupSummary" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="Name">The name assigned to this bid group (required).</param>
        /// <param name="ManagementUnit">The management unit to which this bid group belongs (required).</param>
        /// <param name="AgentCount">The number of agents in this bid group (required).</param>
        /// <param name="WorkPlanCount">The number of work plans in this bid group or the number of work plans in rotations (required).</param>
        /// <param name="WorkPlanRotationCount">The number of work plan rotations used in this bid group (required).</param>
        /// <param name="PlanningGroupCount">The number of planning groups in this bid group (required).</param>
        /// <param name="ScheduleSetError">Schedule set optimization error details for this bid group. Present only when optimization fails.</param>
        public ScheduleBidGroupSummary(string Id = null, string Name = null, ManagementUnitReference ManagementUnit = null, int? AgentCount = null, int? WorkPlanCount = null, int? WorkPlanRotationCount = null, int? PlanningGroupCount = null, ScheduleSetError ScheduleSetError = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.ManagementUnit = ManagementUnit;
            this.AgentCount = AgentCount;
            this.WorkPlanCount = WorkPlanCount;
            this.WorkPlanRotationCount = WorkPlanRotationCount;
            this.PlanningGroupCount = PlanningGroupCount;
            this.ScheduleSetError = ScheduleSetError;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The name assigned to this bid group
        /// </summary>
        /// <value>The name assigned to this bid group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The management unit to which this bid group belongs
        /// </summary>
        /// <value>The management unit to which this bid group belongs</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }



        /// <summary>
        /// The number of agents in this bid group
        /// </summary>
        /// <value>The number of agents in this bid group</value>
        [DataMember(Name="agentCount", EmitDefaultValue=false)]
        public int? AgentCount { get; set; }



        /// <summary>
        /// The number of work plans in this bid group or the number of work plans in rotations
        /// </summary>
        /// <value>The number of work plans in this bid group or the number of work plans in rotations</value>
        [DataMember(Name="workPlanCount", EmitDefaultValue=false)]
        public int? WorkPlanCount { get; set; }



        /// <summary>
        /// The number of work plan rotations used in this bid group
        /// </summary>
        /// <value>The number of work plan rotations used in this bid group</value>
        [DataMember(Name="workPlanRotationCount", EmitDefaultValue=false)]
        public int? WorkPlanRotationCount { get; set; }



        /// <summary>
        /// The number of planning groups in this bid group
        /// </summary>
        /// <value>The number of planning groups in this bid group</value>
        [DataMember(Name="planningGroupCount", EmitDefaultValue=false)]
        public int? PlanningGroupCount { get; set; }



        /// <summary>
        /// Schedule set optimization error details for this bid group. Present only when optimization fails
        /// </summary>
        /// <value>Schedule set optimization error details for this bid group. Present only when optimization fails</value>
        [DataMember(Name="scheduleSetError", EmitDefaultValue=false)]
        public ScheduleSetError ScheduleSetError { get; set; }



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
            sb.Append("class ScheduleBidGroupSummary {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
            sb.Append("  WorkPlanCount: ").Append(WorkPlanCount).Append("\n");
            sb.Append("  WorkPlanRotationCount: ").Append(WorkPlanRotationCount).Append("\n");
            sb.Append("  PlanningGroupCount: ").Append(PlanningGroupCount).Append("\n");
            sb.Append("  ScheduleSetError: ").Append(ScheduleSetError).Append("\n");
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
            return this.Equals(obj as ScheduleBidGroupSummary);
        }

        /// <summary>
        /// Returns true if ScheduleBidGroupSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleBidGroupSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleBidGroupSummary other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.AgentCount == other.AgentCount ||
                    this.AgentCount != null &&
                    this.AgentCount.Equals(other.AgentCount)
                ) &&
                (
                    this.WorkPlanCount == other.WorkPlanCount ||
                    this.WorkPlanCount != null &&
                    this.WorkPlanCount.Equals(other.WorkPlanCount)
                ) &&
                (
                    this.WorkPlanRotationCount == other.WorkPlanRotationCount ||
                    this.WorkPlanRotationCount != null &&
                    this.WorkPlanRotationCount.Equals(other.WorkPlanRotationCount)
                ) &&
                (
                    this.PlanningGroupCount == other.PlanningGroupCount ||
                    this.PlanningGroupCount != null &&
                    this.PlanningGroupCount.Equals(other.PlanningGroupCount)
                ) &&
                (
                    this.ScheduleSetError == other.ScheduleSetError ||
                    this.ScheduleSetError != null &&
                    this.ScheduleSetError.Equals(other.ScheduleSetError)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();

                if (this.AgentCount != null)
                    hash = hash * 59 + this.AgentCount.GetHashCode();

                if (this.WorkPlanCount != null)
                    hash = hash * 59 + this.WorkPlanCount.GetHashCode();

                if (this.WorkPlanRotationCount != null)
                    hash = hash * 59 + this.WorkPlanRotationCount.GetHashCode();

                if (this.PlanningGroupCount != null)
                    hash = hash * 59 + this.PlanningGroupCount.GetHashCode();

                if (this.ScheduleSetError != null)
                    hash = hash * 59 + this.ScheduleSetError.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
