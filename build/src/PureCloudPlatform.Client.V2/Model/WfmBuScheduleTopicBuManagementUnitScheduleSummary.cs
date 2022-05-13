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
    /// WfmBuScheduleTopicBuManagementUnitScheduleSummary
    /// </summary>
    [DataContract]
    public partial class WfmBuScheduleTopicBuManagementUnitScheduleSummary :  IEquatable<WfmBuScheduleTopicBuManagementUnitScheduleSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuScheduleTopicBuManagementUnitScheduleSummary" /> class.
        /// </summary>
        /// <param name="ManagementUnit">ManagementUnit.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Agents">Agents.</param>
        /// <param name="AgentCount">AgentCount.</param>
        public WfmBuScheduleTopicBuManagementUnitScheduleSummary(WfmBuScheduleTopicManagementUnit ManagementUnit = null, DateTime? StartDate = null, DateTime? EndDate = null, List<WfmBuScheduleTopicUserReference> Agents = null, int? AgentCount = null)
        {
            this.ManagementUnit = ManagementUnit;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Agents = Agents;
            this.AgentCount = AgentCount;
            
        }
        


        /// <summary>
        /// Gets or Sets ManagementUnit
        /// </summary>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public WfmBuScheduleTopicManagementUnit ManagementUnit { get; set; }



        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }



        /// <summary>
        /// Gets or Sets Agents
        /// </summary>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<WfmBuScheduleTopicUserReference> Agents { get; set; }



        /// <summary>
        /// Gets or Sets AgentCount
        /// </summary>
        [DataMember(Name="agentCount", EmitDefaultValue=false)]
        public int? AgentCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuScheduleTopicBuManagementUnitScheduleSummary {\n");

            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
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
            return this.Equals(obj as WfmBuScheduleTopicBuManagementUnitScheduleSummary);
        }

        /// <summary>
        /// Returns true if WfmBuScheduleTopicBuManagementUnitScheduleSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuScheduleTopicBuManagementUnitScheduleSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuScheduleTopicBuManagementUnitScheduleSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.Agents == other.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(other.Agents)
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
                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.Agents != null)
                    hash = hash * 59 + this.Agents.GetHashCode();

                if (this.AgentCount != null)
                    hash = hash * 59 + this.AgentCount.GetHashCode();

                return hash;
            }
        }
    }

}
