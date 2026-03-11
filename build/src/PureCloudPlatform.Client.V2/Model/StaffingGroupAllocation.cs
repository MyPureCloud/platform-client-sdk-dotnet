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
        /// <param name="BaseStartingFullTimeEquivalentCount">The weekly calculated starting full time equivalent count.</param>
        /// <param name="AttritionFullTimeEquivalentCount">The weekly projected attrition full time equivalent count.</param>
        /// <param name="StaffingGroupPlannedFullTimeEquivalentCount">The weekly calculated staffing group full time equivalent count.</param>
        /// <param name="EndOfMonthPlannedFullTimeEquivalentCount">The end of month planned full time equivalent count of this staffing group.</param>
        /// <param name="ShrinkageFullTimeEquivalentCount">The weekly projected shrinkage full time equivalent count of this staffing group.</param>
        /// <param name="NetFullTimeEquivalentCount">The weekly net full time equivalent count of this staffing group.</param>
        /// <param name="ExtraTimeUnderTimeFullTimeEquivalentCount">The weekly projected extra or under full time equivalent to the staffing group.</param>
        /// <param name="TransfersFullTimeEquivalentCount">The weekly projected full time equivalent transfers of agents into or out of this staffing group.</param>
        public StaffingGroupAllocation(string StaffingGroupId = null, List<double?> ShrinkagePercentages = null, List<double?> AttritionPercentages = null, List<double?> NewHiresFullTimeEquivalentCount = null, double? StartingWeeklyFullTimeEquivalentCount = null, List<string> PlanningGroupIds = null, List<double?> BaseStartingFullTimeEquivalentCount = null, List<double?> AttritionFullTimeEquivalentCount = null, List<double?> StaffingGroupPlannedFullTimeEquivalentCount = null, List<double?> EndOfMonthPlannedFullTimeEquivalentCount = null, List<double?> ShrinkageFullTimeEquivalentCount = null, List<double?> NetFullTimeEquivalentCount = null, List<double?> ExtraTimeUnderTimeFullTimeEquivalentCount = null, List<double?> TransfersFullTimeEquivalentCount = null)
        {
            this.StaffingGroupId = StaffingGroupId;
            this.ShrinkagePercentages = ShrinkagePercentages;
            this.AttritionPercentages = AttritionPercentages;
            this.NewHiresFullTimeEquivalentCount = NewHiresFullTimeEquivalentCount;
            this.StartingWeeklyFullTimeEquivalentCount = StartingWeeklyFullTimeEquivalentCount;
            this.PlanningGroupIds = PlanningGroupIds;
            this.BaseStartingFullTimeEquivalentCount = BaseStartingFullTimeEquivalentCount;
            this.AttritionFullTimeEquivalentCount = AttritionFullTimeEquivalentCount;
            this.StaffingGroupPlannedFullTimeEquivalentCount = StaffingGroupPlannedFullTimeEquivalentCount;
            this.EndOfMonthPlannedFullTimeEquivalentCount = EndOfMonthPlannedFullTimeEquivalentCount;
            this.ShrinkageFullTimeEquivalentCount = ShrinkageFullTimeEquivalentCount;
            this.NetFullTimeEquivalentCount = NetFullTimeEquivalentCount;
            this.ExtraTimeUnderTimeFullTimeEquivalentCount = ExtraTimeUnderTimeFullTimeEquivalentCount;
            this.TransfersFullTimeEquivalentCount = TransfersFullTimeEquivalentCount;
            
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
        /// The weekly calculated starting full time equivalent count
        /// </summary>
        /// <value>The weekly calculated starting full time equivalent count</value>
        [DataMember(Name="baseStartingFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> BaseStartingFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The weekly projected attrition full time equivalent count
        /// </summary>
        /// <value>The weekly projected attrition full time equivalent count</value>
        [DataMember(Name="attritionFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> AttritionFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The weekly calculated staffing group full time equivalent count
        /// </summary>
        /// <value>The weekly calculated staffing group full time equivalent count</value>
        [DataMember(Name="staffingGroupPlannedFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> StaffingGroupPlannedFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The end of month planned full time equivalent count of this staffing group
        /// </summary>
        /// <value>The end of month planned full time equivalent count of this staffing group</value>
        [DataMember(Name="endOfMonthPlannedFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> EndOfMonthPlannedFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The weekly projected shrinkage full time equivalent count of this staffing group
        /// </summary>
        /// <value>The weekly projected shrinkage full time equivalent count of this staffing group</value>
        [DataMember(Name="shrinkageFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> ShrinkageFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The weekly net full time equivalent count of this staffing group
        /// </summary>
        /// <value>The weekly net full time equivalent count of this staffing group</value>
        [DataMember(Name="netFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> NetFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The weekly projected extra or under full time equivalent to the staffing group
        /// </summary>
        /// <value>The weekly projected extra or under full time equivalent to the staffing group</value>
        [DataMember(Name="extraTimeUnderTimeFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> ExtraTimeUnderTimeFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The weekly projected full time equivalent transfers of agents into or out of this staffing group
        /// </summary>
        /// <value>The weekly projected full time equivalent transfers of agents into or out of this staffing group</value>
        [DataMember(Name="transfersFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> TransfersFullTimeEquivalentCount { get; set; }


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
            sb.Append("  BaseStartingFullTimeEquivalentCount: ").Append(BaseStartingFullTimeEquivalentCount).Append("\n");
            sb.Append("  AttritionFullTimeEquivalentCount: ").Append(AttritionFullTimeEquivalentCount).Append("\n");
            sb.Append("  StaffingGroupPlannedFullTimeEquivalentCount: ").Append(StaffingGroupPlannedFullTimeEquivalentCount).Append("\n");
            sb.Append("  EndOfMonthPlannedFullTimeEquivalentCount: ").Append(EndOfMonthPlannedFullTimeEquivalentCount).Append("\n");
            sb.Append("  ShrinkageFullTimeEquivalentCount: ").Append(ShrinkageFullTimeEquivalentCount).Append("\n");
            sb.Append("  NetFullTimeEquivalentCount: ").Append(NetFullTimeEquivalentCount).Append("\n");
            sb.Append("  ExtraTimeUnderTimeFullTimeEquivalentCount: ").Append(ExtraTimeUnderTimeFullTimeEquivalentCount).Append("\n");
            sb.Append("  TransfersFullTimeEquivalentCount: ").Append(TransfersFullTimeEquivalentCount).Append("\n");
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
                ) &&
                (
                    this.BaseStartingFullTimeEquivalentCount == other.BaseStartingFullTimeEquivalentCount ||
                    this.BaseStartingFullTimeEquivalentCount != null &&
                    this.BaseStartingFullTimeEquivalentCount.SequenceEqual(other.BaseStartingFullTimeEquivalentCount)
                ) &&
                (
                    this.AttritionFullTimeEquivalentCount == other.AttritionFullTimeEquivalentCount ||
                    this.AttritionFullTimeEquivalentCount != null &&
                    this.AttritionFullTimeEquivalentCount.SequenceEqual(other.AttritionFullTimeEquivalentCount)
                ) &&
                (
                    this.StaffingGroupPlannedFullTimeEquivalentCount == other.StaffingGroupPlannedFullTimeEquivalentCount ||
                    this.StaffingGroupPlannedFullTimeEquivalentCount != null &&
                    this.StaffingGroupPlannedFullTimeEquivalentCount.SequenceEqual(other.StaffingGroupPlannedFullTimeEquivalentCount)
                ) &&
                (
                    this.EndOfMonthPlannedFullTimeEquivalentCount == other.EndOfMonthPlannedFullTimeEquivalentCount ||
                    this.EndOfMonthPlannedFullTimeEquivalentCount != null &&
                    this.EndOfMonthPlannedFullTimeEquivalentCount.SequenceEqual(other.EndOfMonthPlannedFullTimeEquivalentCount)
                ) &&
                (
                    this.ShrinkageFullTimeEquivalentCount == other.ShrinkageFullTimeEquivalentCount ||
                    this.ShrinkageFullTimeEquivalentCount != null &&
                    this.ShrinkageFullTimeEquivalentCount.SequenceEqual(other.ShrinkageFullTimeEquivalentCount)
                ) &&
                (
                    this.NetFullTimeEquivalentCount == other.NetFullTimeEquivalentCount ||
                    this.NetFullTimeEquivalentCount != null &&
                    this.NetFullTimeEquivalentCount.SequenceEqual(other.NetFullTimeEquivalentCount)
                ) &&
                (
                    this.ExtraTimeUnderTimeFullTimeEquivalentCount == other.ExtraTimeUnderTimeFullTimeEquivalentCount ||
                    this.ExtraTimeUnderTimeFullTimeEquivalentCount != null &&
                    this.ExtraTimeUnderTimeFullTimeEquivalentCount.SequenceEqual(other.ExtraTimeUnderTimeFullTimeEquivalentCount)
                ) &&
                (
                    this.TransfersFullTimeEquivalentCount == other.TransfersFullTimeEquivalentCount ||
                    this.TransfersFullTimeEquivalentCount != null &&
                    this.TransfersFullTimeEquivalentCount.SequenceEqual(other.TransfersFullTimeEquivalentCount)
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

                if (this.BaseStartingFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.BaseStartingFullTimeEquivalentCount.GetHashCode();

                if (this.AttritionFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.AttritionFullTimeEquivalentCount.GetHashCode();

                if (this.StaffingGroupPlannedFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.StaffingGroupPlannedFullTimeEquivalentCount.GetHashCode();

                if (this.EndOfMonthPlannedFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.EndOfMonthPlannedFullTimeEquivalentCount.GetHashCode();

                if (this.ShrinkageFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.ShrinkageFullTimeEquivalentCount.GetHashCode();

                if (this.NetFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.NetFullTimeEquivalentCount.GetHashCode();

                if (this.ExtraTimeUnderTimeFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.ExtraTimeUnderTimeFullTimeEquivalentCount.GetHashCode();

                if (this.TransfersFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.TransfersFullTimeEquivalentCount.GetHashCode();

                return hash;
            }
        }
    }

}
