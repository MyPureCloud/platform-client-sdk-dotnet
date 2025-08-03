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
    /// StaffingGroupAllocation
    /// </summary>
    [DataContract]
    public partial class StaffingGroupAllocation :  IEquatable<StaffingGroupAllocation>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StaffingGroupAllocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaffingGroupAllocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffingGroupAllocation" /> class.
        /// </summary>
        /// <param name="StaffingGroupId">The staffing group to which the result allocation belongs (required).</param>
        /// <param name="ShrinkagePercentages">The weekly projected shrinkage percentage of staffing group, in the scale of 0 - 100 (required).</param>
        /// <param name="AttritionPercentages">The weekly projected attrition percentage of the staffing group, in the scale of 0 - 100 (required).</param>
        /// <param name="NewHiresFullTimeEquivalentCount">The weekly projected full time equivalent agents of new hire agents added to the staffing group.</param>
        /// <param name="StartingWeeklyFullTimeEquivalentCount">The weekly count of full time equivalent agents that can be used for the first week of the capacity plan (required).</param>
        /// <param name="PlanningGroupIds">The IDs of the planning groups associated with this staffing group.</param>
        public StaffingGroupAllocation(string StaffingGroupId = null, List<double?> ShrinkagePercentages = null, List<double?> AttritionPercentages = null, List<double?> NewHiresFullTimeEquivalentCount = null, double? StartingWeeklyFullTimeEquivalentCount = null, List<string> PlanningGroupIds = null)
        {
            this.StaffingGroupId = StaffingGroupId;
            this.ShrinkagePercentages = ShrinkagePercentages;
            this.AttritionPercentages = AttritionPercentages;
            this.NewHiresFullTimeEquivalentCount = NewHiresFullTimeEquivalentCount;
            this.StartingWeeklyFullTimeEquivalentCount = StartingWeeklyFullTimeEquivalentCount;
            this.PlanningGroupIds = PlanningGroupIds;
            
        }
        


        /// <summary>
        /// The staffing group to which the result allocation belongs
        /// </summary>
        /// <value>The staffing group to which the result allocation belongs</value>
        [DataMember(Name="staffingGroupId", EmitDefaultValue=false)]
        public string StaffingGroupId { get; set; }



        /// <summary>
        /// The weekly projected shrinkage percentage of staffing group, in the scale of 0 - 100
        /// </summary>
        /// <value>The weekly projected shrinkage percentage of staffing group, in the scale of 0 - 100</value>
        [DataMember(Name="shrinkagePercentages", EmitDefaultValue=false)]
        public List<double?> ShrinkagePercentages { get; set; }



        /// <summary>
        /// The weekly projected attrition percentage of the staffing group, in the scale of 0 - 100
        /// </summary>
        /// <value>The weekly projected attrition percentage of the staffing group, in the scale of 0 - 100</value>
        [DataMember(Name="attritionPercentages", EmitDefaultValue=false)]
        public List<double?> AttritionPercentages { get; set; }



        /// <summary>
        /// The weekly projected full time equivalent agents of new hire agents added to the staffing group
        /// </summary>
        /// <value>The weekly projected full time equivalent agents of new hire agents added to the staffing group</value>
        [DataMember(Name="newHiresFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> NewHiresFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The weekly count of full time equivalent agents that can be used for the first week of the capacity plan
        /// </summary>
        /// <value>The weekly count of full time equivalent agents that can be used for the first week of the capacity plan</value>
        [DataMember(Name="startingWeeklyFullTimeEquivalentCount", EmitDefaultValue=false)]
        public double? StartingWeeklyFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The IDs of the planning groups associated with this staffing group
        /// </summary>
        /// <value>The IDs of the planning groups associated with this staffing group</value>
        [DataMember(Name="planningGroupIds", EmitDefaultValue=false)]
        public List<string> PlanningGroupIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffingGroupAllocation {\n");

            sb.Append("  StaffingGroupId: ").Append(StaffingGroupId).Append("\n");
            sb.Append("  ShrinkagePercentages: ").Append(ShrinkagePercentages).Append("\n");
            sb.Append("  AttritionPercentages: ").Append(AttritionPercentages).Append("\n");
            sb.Append("  NewHiresFullTimeEquivalentCount: ").Append(NewHiresFullTimeEquivalentCount).Append("\n");
            sb.Append("  StartingWeeklyFullTimeEquivalentCount: ").Append(StartingWeeklyFullTimeEquivalentCount).Append("\n");
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
            return this.Equals(obj as StaffingGroupAllocation);
        }

        /// <summary>
        /// Returns true if StaffingGroupAllocation instances are equal
        /// </summary>
        /// <param name="other">Instance of StaffingGroupAllocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffingGroupAllocation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StaffingGroupId == other.StaffingGroupId ||
                    this.StaffingGroupId != null &&
                    this.StaffingGroupId.Equals(other.StaffingGroupId)
                ) &&
                (
                    this.ShrinkagePercentages == other.ShrinkagePercentages ||
                    this.ShrinkagePercentages != null &&
                    this.ShrinkagePercentages.SequenceEqual(other.ShrinkagePercentages)
                ) &&
                (
                    this.AttritionPercentages == other.AttritionPercentages ||
                    this.AttritionPercentages != null &&
                    this.AttritionPercentages.SequenceEqual(other.AttritionPercentages)
                ) &&
                (
                    this.NewHiresFullTimeEquivalentCount == other.NewHiresFullTimeEquivalentCount ||
                    this.NewHiresFullTimeEquivalentCount != null &&
                    this.NewHiresFullTimeEquivalentCount.SequenceEqual(other.NewHiresFullTimeEquivalentCount)
                ) &&
                (
                    this.StartingWeeklyFullTimeEquivalentCount == other.StartingWeeklyFullTimeEquivalentCount ||
                    this.StartingWeeklyFullTimeEquivalentCount != null &&
                    this.StartingWeeklyFullTimeEquivalentCount.Equals(other.StartingWeeklyFullTimeEquivalentCount)
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
                if (this.StaffingGroupId != null)
                    hash = hash * 59 + this.StaffingGroupId.GetHashCode();

                if (this.ShrinkagePercentages != null)
                    hash = hash * 59 + this.ShrinkagePercentages.GetHashCode();

                if (this.AttritionPercentages != null)
                    hash = hash * 59 + this.AttritionPercentages.GetHashCode();

                if (this.NewHiresFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.NewHiresFullTimeEquivalentCount.GetHashCode();

                if (this.StartingWeeklyFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.StartingWeeklyFullTimeEquivalentCount.GetHashCode();

                if (this.PlanningGroupIds != null)
                    hash = hash * 59 + this.PlanningGroupIds.GetHashCode();

                return hash;
            }
        }
    }

}
