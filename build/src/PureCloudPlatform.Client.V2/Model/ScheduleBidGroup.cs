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
    /// ScheduleBidGroup
    /// </summary>
    [DataContract]
    public partial class ScheduleBidGroup :  IEquatable<ScheduleBidGroup>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleBidGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidGroup" /> class.
        /// </summary>
        /// <param name="Name">The name of the schedule bid group (required).</param>
        /// <param name="ManagementUnit">The management unit to which this bid group belongs (required).</param>
        /// <param name="Agents">The agents who participate in this bid group (required).</param>
        /// <param name="WorkPlans">The work plans used in this bid group.</param>
        /// <param name="WorkPlanRotations">The work plan rotations used in this bid group.</param>
        /// <param name="PlanningGroups">The planning groups selected in this bid group (required).</param>
        /// <param name="DownloadUrl">The downloadUrl to fetch Schedule sets. It will be populated if the status of this bid is &#39;Optimized&#39;.</param>
        /// <param name="DownloadTemplate">Schedule sets always come through downloadUrl, the schema included here is just for documentation.</param>
        public ScheduleBidGroup(string Name = null, ManagementUnitReference ManagementUnit = null, List<UserReference> Agents = null, List<WorkPlanReference> WorkPlans = null, List<BidGroupWorkPlanRotationResponse> WorkPlanRotations = null, List<PlanningGroupReference> PlanningGroups = null, string DownloadUrl = null, BidGroupScheduleSet DownloadTemplate = null)
        {
            this.Name = Name;
            this.ManagementUnit = ManagementUnit;
            this.Agents = Agents;
            this.WorkPlans = WorkPlans;
            this.WorkPlanRotations = WorkPlanRotations;
            this.PlanningGroups = PlanningGroups;
            this.DownloadUrl = DownloadUrl;
            this.DownloadTemplate = DownloadTemplate;
            
        }
        


        /// <summary>
        /// The name of the schedule bid group
        /// </summary>
        /// <value>The name of the schedule bid group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The management unit to which this bid group belongs
        /// </summary>
        /// <value>The management unit to which this bid group belongs</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }



        /// <summary>
        /// The agents who participate in this bid group
        /// </summary>
        /// <value>The agents who participate in this bid group</value>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<UserReference> Agents { get; set; }



        /// <summary>
        /// The work plans used in this bid group
        /// </summary>
        /// <value>The work plans used in this bid group</value>
        [DataMember(Name="workPlans", EmitDefaultValue=false)]
        public List<WorkPlanReference> WorkPlans { get; set; }



        /// <summary>
        /// The work plan rotations used in this bid group
        /// </summary>
        /// <value>The work plan rotations used in this bid group</value>
        [DataMember(Name="workPlanRotations", EmitDefaultValue=false)]
        public List<BidGroupWorkPlanRotationResponse> WorkPlanRotations { get; set; }



        /// <summary>
        /// The planning groups selected in this bid group
        /// </summary>
        /// <value>The planning groups selected in this bid group</value>
        [DataMember(Name="planningGroups", EmitDefaultValue=false)]
        public List<PlanningGroupReference> PlanningGroups { get; set; }



        /// <summary>
        /// The downloadUrl to fetch Schedule sets. It will be populated if the status of this bid is &#39;Optimized&#39;
        /// </summary>
        /// <value>The downloadUrl to fetch Schedule sets. It will be populated if the status of this bid is &#39;Optimized&#39;</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Schedule sets always come through downloadUrl, the schema included here is just for documentation
        /// </summary>
        /// <value>Schedule sets always come through downloadUrl, the schema included here is just for documentation</value>
        [DataMember(Name="downloadTemplate", EmitDefaultValue=false)]
        public BidGroupScheduleSet DownloadTemplate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleBidGroup {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
            sb.Append("  WorkPlans: ").Append(WorkPlans).Append("\n");
            sb.Append("  WorkPlanRotations: ").Append(WorkPlanRotations).Append("\n");
            sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  DownloadTemplate: ").Append(DownloadTemplate).Append("\n");
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
            return this.Equals(obj as ScheduleBidGroup);
        }

        /// <summary>
        /// Returns true if ScheduleBidGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleBidGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleBidGroup other)
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
                    this.WorkPlanRotations == other.WorkPlanRotations ||
                    this.WorkPlanRotations != null &&
                    this.WorkPlanRotations.SequenceEqual(other.WorkPlanRotations)
                ) &&
                (
                    this.PlanningGroups == other.PlanningGroups ||
                    this.PlanningGroups != null &&
                    this.PlanningGroups.SequenceEqual(other.PlanningGroups)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.DownloadTemplate == other.DownloadTemplate ||
                    this.DownloadTemplate != null &&
                    this.DownloadTemplate.Equals(other.DownloadTemplate)
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

                if (this.WorkPlanRotations != null)
                    hash = hash * 59 + this.WorkPlanRotations.GetHashCode();

                if (this.PlanningGroups != null)
                    hash = hash * 59 + this.PlanningGroups.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.DownloadTemplate != null)
                    hash = hash * 59 + this.DownloadTemplate.GetHashCode();

                return hash;
            }
        }
    }

}
