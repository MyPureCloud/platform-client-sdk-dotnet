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
    /// WorkPlanBidGroup
    /// </summary>
    [DataContract]
    public partial class WorkPlanBidGroup :  IEquatable<WorkPlanBidGroup>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanBidGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkPlanBidGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanBidGroup" /> class.
        /// </summary>
        /// <param name="Name">The name of the work plan bid group (required).</param>
        /// <param name="ManagementUnit">The management unit this bid group belongs to (required).</param>
        /// <param name="Agents">The list of agents who participate in this bid group (required).</param>
        /// <param name="WorkPlans">The list of work plans used in this bid group (required).</param>
        /// <param name="PlanningGroups">The list of planning groups selected in this bid group (required).</param>
        public WorkPlanBidGroup(string Name = null, ManagementUnitReference ManagementUnit = null, List<UserReference> Agents = null, List<BidGroupWorkPlanResponse> WorkPlans = null, List<PlanningGroupReference> PlanningGroups = null)
        {
            this.Name = Name;
            this.ManagementUnit = ManagementUnit;
            this.Agents = Agents;
            this.WorkPlans = WorkPlans;
            this.PlanningGroups = PlanningGroups;
            
        }
        


        /// <summary>
        /// The name of the work plan bid group
        /// </summary>
        /// <value>The name of the work plan bid group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The management unit this bid group belongs to
        /// </summary>
        /// <value>The management unit this bid group belongs to</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }



        /// <summary>
        /// The list of agents who participate in this bid group
        /// </summary>
        /// <value>The list of agents who participate in this bid group</value>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<UserReference> Agents { get; set; }



        /// <summary>
        /// The list of work plans used in this bid group
        /// </summary>
        /// <value>The list of work plans used in this bid group</value>
        [DataMember(Name="workPlans", EmitDefaultValue=false)]
        public List<BidGroupWorkPlanResponse> WorkPlans { get; set; }



        /// <summary>
        /// The list of planning groups selected in this bid group
        /// </summary>
        /// <value>The list of planning groups selected in this bid group</value>
        [DataMember(Name="planningGroups", EmitDefaultValue=false)]
        public List<PlanningGroupReference> PlanningGroups { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanBidGroup {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
            sb.Append("  WorkPlans: ").Append(WorkPlans).Append("\n");
            sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
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
            return this.Equals(obj as WorkPlanBidGroup);
        }

        /// <summary>
        /// Returns true if WorkPlanBidGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanBidGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanBidGroup other)
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
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.Agents == other.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(other.Agents)
                ) &&
                (
                    this.WorkPlans == other.WorkPlans ||
                    this.WorkPlans != null &&
                    this.WorkPlans.SequenceEqual(other.WorkPlans)
                ) &&
                (
                    this.PlanningGroups == other.PlanningGroups ||
                    this.PlanningGroups != null &&
                    this.PlanningGroups.SequenceEqual(other.PlanningGroups)
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

                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();

                if (this.Agents != null)
                    hash = hash * 59 + this.Agents.GetHashCode();

                if (this.WorkPlans != null)
                    hash = hash * 59 + this.WorkPlans.GetHashCode();

                if (this.PlanningGroups != null)
                    hash = hash * 59 + this.PlanningGroups.GetHashCode();

                return hash;
            }
        }
    }

}
