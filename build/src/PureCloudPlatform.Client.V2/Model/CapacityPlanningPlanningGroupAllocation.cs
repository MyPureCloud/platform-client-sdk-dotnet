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
    /// CapacityPlanningPlanningGroupAllocation
    /// </summary>
    [DataContract]
    public partial class CapacityPlanningPlanningGroupAllocation :  IEquatable<CapacityPlanningPlanningGroupAllocation>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanningPlanningGroupAllocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanningPlanningGroupAllocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanningPlanningGroupAllocation" /> class.
        /// </summary>
        /// <param name="PlanningGroupId">The planning group ID to which the capacity planning allocations apply (required).</param>
        /// <param name="RequiredStaffFullTimeEquivalentCount">The weekly required staff to this planning group (required).</param>
        /// <param name="StaffingGroupFullTimeEquivalentContributions">The weekly planned full time equivalent contributions from associated staffing groups (required).</param>
        /// <param name="TotalPlannedFullTimeEquivalentCount">The total weekly full time equivalent planned for this planning group, based on the associated staffing groups (required).</param>
        /// <param name="OverUnderFullTimeEquivalentCount">The weekly difference between the total planned full time equivalent and the required staff (required).</param>
        public CapacityPlanningPlanningGroupAllocation(string PlanningGroupId = null, List<double?> RequiredStaffFullTimeEquivalentCount = null, List<StaffingGroupFullTimeEquivalentContribution> StaffingGroupFullTimeEquivalentContributions = null, List<double?> TotalPlannedFullTimeEquivalentCount = null, List<double?> OverUnderFullTimeEquivalentCount = null)
        {
            this.PlanningGroupId = PlanningGroupId;
            this.RequiredStaffFullTimeEquivalentCount = RequiredStaffFullTimeEquivalentCount;
            this.StaffingGroupFullTimeEquivalentContributions = StaffingGroupFullTimeEquivalentContributions;
            this.TotalPlannedFullTimeEquivalentCount = TotalPlannedFullTimeEquivalentCount;
            this.OverUnderFullTimeEquivalentCount = OverUnderFullTimeEquivalentCount;
            
        }
        


        /// <summary>
        /// The planning group ID to which the capacity planning allocations apply
        /// </summary>
        /// <value>The planning group ID to which the capacity planning allocations apply</value>
        [DataMember(Name="planningGroupId", EmitDefaultValue=false)]
        public string PlanningGroupId { get; set; }



        /// <summary>
        /// The weekly required staff to this planning group
        /// </summary>
        /// <value>The weekly required staff to this planning group</value>
        [DataMember(Name="requiredStaffFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> RequiredStaffFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The weekly planned full time equivalent contributions from associated staffing groups
        /// </summary>
        /// <value>The weekly planned full time equivalent contributions from associated staffing groups</value>
        [DataMember(Name="staffingGroupFullTimeEquivalentContributions", EmitDefaultValue=false)]
        public List<StaffingGroupFullTimeEquivalentContribution> StaffingGroupFullTimeEquivalentContributions { get; set; }



        /// <summary>
        /// The total weekly full time equivalent planned for this planning group, based on the associated staffing groups
        /// </summary>
        /// <value>The total weekly full time equivalent planned for this planning group, based on the associated staffing groups</value>
        [DataMember(Name="totalPlannedFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> TotalPlannedFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The weekly difference between the total planned full time equivalent and the required staff
        /// </summary>
        /// <value>The weekly difference between the total planned full time equivalent and the required staff</value>
        [DataMember(Name="overUnderFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> OverUnderFullTimeEquivalentCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanningPlanningGroupAllocation {\n");

            sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
            sb.Append("  RequiredStaffFullTimeEquivalentCount: ").Append(RequiredStaffFullTimeEquivalentCount).Append("\n");
            sb.Append("  StaffingGroupFullTimeEquivalentContributions: ").Append(StaffingGroupFullTimeEquivalentContributions).Append("\n");
            sb.Append("  TotalPlannedFullTimeEquivalentCount: ").Append(TotalPlannedFullTimeEquivalentCount).Append("\n");
            sb.Append("  OverUnderFullTimeEquivalentCount: ").Append(OverUnderFullTimeEquivalentCount).Append("\n");
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
            return this.Equals(obj as CapacityPlanningPlanningGroupAllocation);
        }

        /// <summary>
        /// Returns true if CapacityPlanningPlanningGroupAllocation instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanningPlanningGroupAllocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanningPlanningGroupAllocation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PlanningGroupId == other.PlanningGroupId ||
                    this.PlanningGroupId != null &&
                    this.PlanningGroupId.Equals(other.PlanningGroupId)
                ) &&
                (
                    this.RequiredStaffFullTimeEquivalentCount == other.RequiredStaffFullTimeEquivalentCount ||
                    this.RequiredStaffFullTimeEquivalentCount != null &&
                    this.RequiredStaffFullTimeEquivalentCount.SequenceEqual(other.RequiredStaffFullTimeEquivalentCount)
                ) &&
                (
                    this.StaffingGroupFullTimeEquivalentContributions == other.StaffingGroupFullTimeEquivalentContributions ||
                    this.StaffingGroupFullTimeEquivalentContributions != null &&
                    this.StaffingGroupFullTimeEquivalentContributions.SequenceEqual(other.StaffingGroupFullTimeEquivalentContributions)
                ) &&
                (
                    this.TotalPlannedFullTimeEquivalentCount == other.TotalPlannedFullTimeEquivalentCount ||
                    this.TotalPlannedFullTimeEquivalentCount != null &&
                    this.TotalPlannedFullTimeEquivalentCount.SequenceEqual(other.TotalPlannedFullTimeEquivalentCount)
                ) &&
                (
                    this.OverUnderFullTimeEquivalentCount == other.OverUnderFullTimeEquivalentCount ||
                    this.OverUnderFullTimeEquivalentCount != null &&
                    this.OverUnderFullTimeEquivalentCount.SequenceEqual(other.OverUnderFullTimeEquivalentCount)
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
                if (this.PlanningGroupId != null)
                    hash = hash * 59 + this.PlanningGroupId.GetHashCode();

                if (this.RequiredStaffFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.RequiredStaffFullTimeEquivalentCount.GetHashCode();

                if (this.StaffingGroupFullTimeEquivalentContributions != null)
                    hash = hash * 59 + this.StaffingGroupFullTimeEquivalentContributions.GetHashCode();

                if (this.TotalPlannedFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.TotalPlannedFullTimeEquivalentCount.GetHashCode();

                if (this.OverUnderFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.OverUnderFullTimeEquivalentCount.GetHashCode();

                return hash;
            }
        }
    }

}
