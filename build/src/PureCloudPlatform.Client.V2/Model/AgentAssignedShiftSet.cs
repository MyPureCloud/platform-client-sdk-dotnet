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
    /// AgentAssignedShiftSet
    /// </summary>
    [DataContract]
    public partial class AgentAssignedShiftSet :  IEquatable<AgentAssignedShiftSet>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAssignedShiftSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentAssignedShiftSet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAssignedShiftSet" /> class.
        /// </summary>
        /// <param name="Id">The ID of the shift set (required).</param>
        /// <param name="EffectiveWorkPlan">The work plan or work plan rotation used for generating the shift set (required).</param>
        /// <param name="Shifts">The scheduled shifts (required).</param>
        /// <param name="Agents">The details of the agents assigned to this shift set (required).</param>
        public AgentAssignedShiftSet(string Id = null, ShiftSetEffectiveWorkPlan EffectiveWorkPlan = null, List<ScheduleBidScheduledShift> Shifts = null, List<AssignedAgentDetails> Agents = null)
        {
            this.Id = Id;
            this.EffectiveWorkPlan = EffectiveWorkPlan;
            this.Shifts = Shifts;
            this.Agents = Agents;
            
        }
        


        /// <summary>
        /// The ID of the shift set
        /// </summary>
        /// <value>The ID of the shift set</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The work plan or work plan rotation used for generating the shift set
        /// </summary>
        /// <value>The work plan or work plan rotation used for generating the shift set</value>
        [DataMember(Name="effectiveWorkPlan", EmitDefaultValue=false)]
        public ShiftSetEffectiveWorkPlan EffectiveWorkPlan { get; set; }



        /// <summary>
        /// The scheduled shifts
        /// </summary>
        /// <value>The scheduled shifts</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<ScheduleBidScheduledShift> Shifts { get; set; }



        /// <summary>
        /// The details of the agents assigned to this shift set
        /// </summary>
        /// <value>The details of the agents assigned to this shift set</value>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<AssignedAgentDetails> Agents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentAssignedShiftSet {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EffectiveWorkPlan: ").Append(EffectiveWorkPlan).Append("\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
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
            return this.Equals(obj as AgentAssignedShiftSet);
        }

        /// <summary>
        /// Returns true if AgentAssignedShiftSet instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentAssignedShiftSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentAssignedShiftSet other)
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
                    this.EffectiveWorkPlan == other.EffectiveWorkPlan ||
                    this.EffectiveWorkPlan != null &&
                    this.EffectiveWorkPlan.Equals(other.EffectiveWorkPlan)
                ) &&
                (
                    this.Shifts == other.Shifts ||
                    this.Shifts != null &&
                    this.Shifts.SequenceEqual(other.Shifts)
                ) &&
                (
                    this.Agents == other.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(other.Agents)
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

                if (this.EffectiveWorkPlan != null)
                    hash = hash * 59 + this.EffectiveWorkPlan.GetHashCode();

                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();

                if (this.Agents != null)
                    hash = hash * 59 + this.Agents.GetHashCode();

                return hash;
            }
        }
    }

}
