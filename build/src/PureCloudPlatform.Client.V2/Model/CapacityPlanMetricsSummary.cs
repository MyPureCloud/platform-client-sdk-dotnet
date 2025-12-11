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
    /// CapacityPlanMetricsSummary
    /// </summary>
    [DataContract]
    public partial class CapacityPlanMetricsSummary :  IEquatable<CapacityPlanMetricsSummary>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanMetricsSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanMetricsSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanMetricsSummary" /> class.
        /// </summary>
        /// <param name="RequiredStaffFullTimeEquivalentCount">The total staff requirements for all planning groups in the capacity plan, aggregated by the selected time granularity (required).</param>
        /// <param name="PlannedFullTimeEquivalentCount">The planned full time equivalent for all staffing groups in the capacity plan, aggregated by the selected time granularity (required).</param>
        /// <param name="StaffingOverUnderFullTimeEquivalentCount">The difference between the summary of planning group required full time equivalent and planned full time equivalent, aggregated by the selected time granularity (required).</param>
        /// <param name="StartingFullTimeEquivalentCount">The total starting full time equivalent for all staffing groups in the capacity plan, aggregated by the selected time granularity (required).</param>
        /// <param name="AttritionFullTimeEquivalentCount">The sum of all staffing group attrition full time equivalent in the capacity plan, aggregated by the selected time granularity (required).</param>
        /// <param name="AttritionPercentage">The total attrition percentage of staffing groups in the capacity plan in the scale of 0.0-100.0, aggregated by the selected time granularity (required).</param>
        /// <param name="NewHireFullTimeEquivalentCount">The sum of all staffing group new hire full time equivalent in the capacity plan, aggregated by the selected time granularity (required).</param>
        /// <param name="TransfersFullTimeEquivalentCount">The sum of all staffing group projected transfers of agents into or out of this capacity plan, aggregated by the selected time granularity (required).</param>
        /// <param name="ExtraTimeUnderTimeFullTimeEquivalentCount">The sum of all staffing group extra or under time full time equivalent count in the capacity plan, aggregated by the selected time granularity (required).</param>
        /// <param name="ShrinkageFullTimeEquivalentCount">The sum of all staffing groups shrinkage full time equivalent, aggregated by the selected time granularity (required).</param>
        /// <param name="ShrinkagePercentage">The total shrinkage percentage of all staffing groups in the capacity plan in the scale of 0.0-100.0, aggregated by the selected time granularity (required).</param>
        /// <param name="EndOfMonthPlannedFullTimeEquivalentCount">The total sum of all staffing group end of month planned full time equivalent for this capacity plan, aggregated by the selected time granularity.</param>
        /// <param name="NetFullTimeEquivalentCount">The sum of all staffing groups net full time equivalent in the capacity plan, aggregated by the selected time granularity (required).</param>
        public CapacityPlanMetricsSummary(List<double?> RequiredStaffFullTimeEquivalentCount = null, List<double?> PlannedFullTimeEquivalentCount = null, List<double?> StaffingOverUnderFullTimeEquivalentCount = null, List<double?> StartingFullTimeEquivalentCount = null, List<double?> AttritionFullTimeEquivalentCount = null, List<double?> AttritionPercentage = null, List<double?> NewHireFullTimeEquivalentCount = null, List<double?> TransfersFullTimeEquivalentCount = null, List<double?> ExtraTimeUnderTimeFullTimeEquivalentCount = null, List<double?> ShrinkageFullTimeEquivalentCount = null, List<double?> ShrinkagePercentage = null, List<double?> EndOfMonthPlannedFullTimeEquivalentCount = null, List<double?> NetFullTimeEquivalentCount = null)
        {
            this.RequiredStaffFullTimeEquivalentCount = RequiredStaffFullTimeEquivalentCount;
            this.PlannedFullTimeEquivalentCount = PlannedFullTimeEquivalentCount;
            this.StaffingOverUnderFullTimeEquivalentCount = StaffingOverUnderFullTimeEquivalentCount;
            this.StartingFullTimeEquivalentCount = StartingFullTimeEquivalentCount;
            this.AttritionFullTimeEquivalentCount = AttritionFullTimeEquivalentCount;
            this.AttritionPercentage = AttritionPercentage;
            this.NewHireFullTimeEquivalentCount = NewHireFullTimeEquivalentCount;
            this.TransfersFullTimeEquivalentCount = TransfersFullTimeEquivalentCount;
            this.ExtraTimeUnderTimeFullTimeEquivalentCount = ExtraTimeUnderTimeFullTimeEquivalentCount;
            this.ShrinkageFullTimeEquivalentCount = ShrinkageFullTimeEquivalentCount;
            this.ShrinkagePercentage = ShrinkagePercentage;
            this.EndOfMonthPlannedFullTimeEquivalentCount = EndOfMonthPlannedFullTimeEquivalentCount;
            this.NetFullTimeEquivalentCount = NetFullTimeEquivalentCount;
            
        }
        


        /// <summary>
        /// The total staff requirements for all planning groups in the capacity plan, aggregated by the selected time granularity
        /// </summary>
        /// <value>The total staff requirements for all planning groups in the capacity plan, aggregated by the selected time granularity</value>
        [DataMember(Name="requiredStaffFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> RequiredStaffFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The planned full time equivalent for all staffing groups in the capacity plan, aggregated by the selected time granularity
        /// </summary>
        /// <value>The planned full time equivalent for all staffing groups in the capacity plan, aggregated by the selected time granularity</value>
        [DataMember(Name="plannedFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> PlannedFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The difference between the summary of planning group required full time equivalent and planned full time equivalent, aggregated by the selected time granularity
        /// </summary>
        /// <value>The difference between the summary of planning group required full time equivalent and planned full time equivalent, aggregated by the selected time granularity</value>
        [DataMember(Name="staffingOverUnderFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> StaffingOverUnderFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The total starting full time equivalent for all staffing groups in the capacity plan, aggregated by the selected time granularity
        /// </summary>
        /// <value>The total starting full time equivalent for all staffing groups in the capacity plan, aggregated by the selected time granularity</value>
        [DataMember(Name="startingFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> StartingFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The sum of all staffing group attrition full time equivalent in the capacity plan, aggregated by the selected time granularity
        /// </summary>
        /// <value>The sum of all staffing group attrition full time equivalent in the capacity plan, aggregated by the selected time granularity</value>
        [DataMember(Name="attritionFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> AttritionFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The total attrition percentage of staffing groups in the capacity plan in the scale of 0.0-100.0, aggregated by the selected time granularity
        /// </summary>
        /// <value>The total attrition percentage of staffing groups in the capacity plan in the scale of 0.0-100.0, aggregated by the selected time granularity</value>
        [DataMember(Name="attritionPercentage", EmitDefaultValue=false)]
        public List<double?> AttritionPercentage { get; set; }



        /// <summary>
        /// The sum of all staffing group new hire full time equivalent in the capacity plan, aggregated by the selected time granularity
        /// </summary>
        /// <value>The sum of all staffing group new hire full time equivalent in the capacity plan, aggregated by the selected time granularity</value>
        [DataMember(Name="newHireFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> NewHireFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The sum of all staffing group projected transfers of agents into or out of this capacity plan, aggregated by the selected time granularity
        /// </summary>
        /// <value>The sum of all staffing group projected transfers of agents into or out of this capacity plan, aggregated by the selected time granularity</value>
        [DataMember(Name="transfersFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> TransfersFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The sum of all staffing group extra or under time full time equivalent count in the capacity plan, aggregated by the selected time granularity
        /// </summary>
        /// <value>The sum of all staffing group extra or under time full time equivalent count in the capacity plan, aggregated by the selected time granularity</value>
        [DataMember(Name="extraTimeUnderTimeFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> ExtraTimeUnderTimeFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The sum of all staffing groups shrinkage full time equivalent, aggregated by the selected time granularity
        /// </summary>
        /// <value>The sum of all staffing groups shrinkage full time equivalent, aggregated by the selected time granularity</value>
        [DataMember(Name="shrinkageFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> ShrinkageFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The total shrinkage percentage of all staffing groups in the capacity plan in the scale of 0.0-100.0, aggregated by the selected time granularity
        /// </summary>
        /// <value>The total shrinkage percentage of all staffing groups in the capacity plan in the scale of 0.0-100.0, aggregated by the selected time granularity</value>
        [DataMember(Name="shrinkagePercentage", EmitDefaultValue=false)]
        public List<double?> ShrinkagePercentage { get; set; }



        /// <summary>
        /// The total sum of all staffing group end of month planned full time equivalent for this capacity plan, aggregated by the selected time granularity
        /// </summary>
        /// <value>The total sum of all staffing group end of month planned full time equivalent for this capacity plan, aggregated by the selected time granularity</value>
        [DataMember(Name="endOfMonthPlannedFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> EndOfMonthPlannedFullTimeEquivalentCount { get; set; }



        /// <summary>
        /// The sum of all staffing groups net full time equivalent in the capacity plan, aggregated by the selected time granularity
        /// </summary>
        /// <value>The sum of all staffing groups net full time equivalent in the capacity plan, aggregated by the selected time granularity</value>
        [DataMember(Name="netFullTimeEquivalentCount", EmitDefaultValue=false)]
        public List<double?> NetFullTimeEquivalentCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanMetricsSummary {\n");

            sb.Append("  RequiredStaffFullTimeEquivalentCount: ").Append(RequiredStaffFullTimeEquivalentCount).Append("\n");
            sb.Append("  PlannedFullTimeEquivalentCount: ").Append(PlannedFullTimeEquivalentCount).Append("\n");
            sb.Append("  StaffingOverUnderFullTimeEquivalentCount: ").Append(StaffingOverUnderFullTimeEquivalentCount).Append("\n");
            sb.Append("  StartingFullTimeEquivalentCount: ").Append(StartingFullTimeEquivalentCount).Append("\n");
            sb.Append("  AttritionFullTimeEquivalentCount: ").Append(AttritionFullTimeEquivalentCount).Append("\n");
            sb.Append("  AttritionPercentage: ").Append(AttritionPercentage).Append("\n");
            sb.Append("  NewHireFullTimeEquivalentCount: ").Append(NewHireFullTimeEquivalentCount).Append("\n");
            sb.Append("  TransfersFullTimeEquivalentCount: ").Append(TransfersFullTimeEquivalentCount).Append("\n");
            sb.Append("  ExtraTimeUnderTimeFullTimeEquivalentCount: ").Append(ExtraTimeUnderTimeFullTimeEquivalentCount).Append("\n");
            sb.Append("  ShrinkageFullTimeEquivalentCount: ").Append(ShrinkageFullTimeEquivalentCount).Append("\n");
            sb.Append("  ShrinkagePercentage: ").Append(ShrinkagePercentage).Append("\n");
            sb.Append("  EndOfMonthPlannedFullTimeEquivalentCount: ").Append(EndOfMonthPlannedFullTimeEquivalentCount).Append("\n");
            sb.Append("  NetFullTimeEquivalentCount: ").Append(NetFullTimeEquivalentCount).Append("\n");
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
            return this.Equals(obj as CapacityPlanMetricsSummary);
        }

        /// <summary>
        /// Returns true if CapacityPlanMetricsSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanMetricsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanMetricsSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RequiredStaffFullTimeEquivalentCount == other.RequiredStaffFullTimeEquivalentCount ||
                    this.RequiredStaffFullTimeEquivalentCount != null &&
                    this.RequiredStaffFullTimeEquivalentCount.SequenceEqual(other.RequiredStaffFullTimeEquivalentCount)
                ) &&
                (
                    this.PlannedFullTimeEquivalentCount == other.PlannedFullTimeEquivalentCount ||
                    this.PlannedFullTimeEquivalentCount != null &&
                    this.PlannedFullTimeEquivalentCount.SequenceEqual(other.PlannedFullTimeEquivalentCount)
                ) &&
                (
                    this.StaffingOverUnderFullTimeEquivalentCount == other.StaffingOverUnderFullTimeEquivalentCount ||
                    this.StaffingOverUnderFullTimeEquivalentCount != null &&
                    this.StaffingOverUnderFullTimeEquivalentCount.SequenceEqual(other.StaffingOverUnderFullTimeEquivalentCount)
                ) &&
                (
                    this.StartingFullTimeEquivalentCount == other.StartingFullTimeEquivalentCount ||
                    this.StartingFullTimeEquivalentCount != null &&
                    this.StartingFullTimeEquivalentCount.SequenceEqual(other.StartingFullTimeEquivalentCount)
                ) &&
                (
                    this.AttritionFullTimeEquivalentCount == other.AttritionFullTimeEquivalentCount ||
                    this.AttritionFullTimeEquivalentCount != null &&
                    this.AttritionFullTimeEquivalentCount.SequenceEqual(other.AttritionFullTimeEquivalentCount)
                ) &&
                (
                    this.AttritionPercentage == other.AttritionPercentage ||
                    this.AttritionPercentage != null &&
                    this.AttritionPercentage.SequenceEqual(other.AttritionPercentage)
                ) &&
                (
                    this.NewHireFullTimeEquivalentCount == other.NewHireFullTimeEquivalentCount ||
                    this.NewHireFullTimeEquivalentCount != null &&
                    this.NewHireFullTimeEquivalentCount.SequenceEqual(other.NewHireFullTimeEquivalentCount)
                ) &&
                (
                    this.TransfersFullTimeEquivalentCount == other.TransfersFullTimeEquivalentCount ||
                    this.TransfersFullTimeEquivalentCount != null &&
                    this.TransfersFullTimeEquivalentCount.SequenceEqual(other.TransfersFullTimeEquivalentCount)
                ) &&
                (
                    this.ExtraTimeUnderTimeFullTimeEquivalentCount == other.ExtraTimeUnderTimeFullTimeEquivalentCount ||
                    this.ExtraTimeUnderTimeFullTimeEquivalentCount != null &&
                    this.ExtraTimeUnderTimeFullTimeEquivalentCount.SequenceEqual(other.ExtraTimeUnderTimeFullTimeEquivalentCount)
                ) &&
                (
                    this.ShrinkageFullTimeEquivalentCount == other.ShrinkageFullTimeEquivalentCount ||
                    this.ShrinkageFullTimeEquivalentCount != null &&
                    this.ShrinkageFullTimeEquivalentCount.SequenceEqual(other.ShrinkageFullTimeEquivalentCount)
                ) &&
                (
                    this.ShrinkagePercentage == other.ShrinkagePercentage ||
                    this.ShrinkagePercentage != null &&
                    this.ShrinkagePercentage.SequenceEqual(other.ShrinkagePercentage)
                ) &&
                (
                    this.EndOfMonthPlannedFullTimeEquivalentCount == other.EndOfMonthPlannedFullTimeEquivalentCount ||
                    this.EndOfMonthPlannedFullTimeEquivalentCount != null &&
                    this.EndOfMonthPlannedFullTimeEquivalentCount.SequenceEqual(other.EndOfMonthPlannedFullTimeEquivalentCount)
                ) &&
                (
                    this.NetFullTimeEquivalentCount == other.NetFullTimeEquivalentCount ||
                    this.NetFullTimeEquivalentCount != null &&
                    this.NetFullTimeEquivalentCount.SequenceEqual(other.NetFullTimeEquivalentCount)
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
                if (this.RequiredStaffFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.RequiredStaffFullTimeEquivalentCount.GetHashCode();

                if (this.PlannedFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.PlannedFullTimeEquivalentCount.GetHashCode();

                if (this.StaffingOverUnderFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.StaffingOverUnderFullTimeEquivalentCount.GetHashCode();

                if (this.StartingFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.StartingFullTimeEquivalentCount.GetHashCode();

                if (this.AttritionFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.AttritionFullTimeEquivalentCount.GetHashCode();

                if (this.AttritionPercentage != null)
                    hash = hash * 59 + this.AttritionPercentage.GetHashCode();

                if (this.NewHireFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.NewHireFullTimeEquivalentCount.GetHashCode();

                if (this.TransfersFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.TransfersFullTimeEquivalentCount.GetHashCode();

                if (this.ExtraTimeUnderTimeFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.ExtraTimeUnderTimeFullTimeEquivalentCount.GetHashCode();

                if (this.ShrinkageFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.ShrinkageFullTimeEquivalentCount.GetHashCode();

                if (this.ShrinkagePercentage != null)
                    hash = hash * 59 + this.ShrinkagePercentage.GetHashCode();

                if (this.EndOfMonthPlannedFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.EndOfMonthPlannedFullTimeEquivalentCount.GetHashCode();

                if (this.NetFullTimeEquivalentCount != null)
                    hash = hash * 59 + this.NetFullTimeEquivalentCount.GetHashCode();

                return hash;
            }
        }
    }

}
