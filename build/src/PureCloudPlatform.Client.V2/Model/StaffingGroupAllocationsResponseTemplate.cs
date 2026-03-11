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
    /// StaffingGroupAllocationsResponseTemplate
    /// </summary>
    [DataContract]
    public partial class StaffingGroupAllocationsResponseTemplate :  IEquatable<StaffingGroupAllocationsResponseTemplate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StaffingGroupAllocationsResponseTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaffingGroupAllocationsResponseTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffingGroupAllocationsResponseTemplate" /> class.
        /// </summary>
        /// <param name="StaffingGroupAllocations">List of staffing group allocations (required).</param>
        /// <param name="Months">The list of months covered by this capacity plan, formatted as yyyy-MM.</param>
        /// <param name="PlanningGroupAllocations">The planning group allocations.</param>
        /// <param name="CapacityPlanMetricsSummary">The total summary of staffing allocation metrics for this capacity plan, for the selected granularity.</param>
        public StaffingGroupAllocationsResponseTemplate(List<StaffingGroupAllocation> StaffingGroupAllocations = null, List<YearMonth> Months = null, List<CapacityPlanningPlanningGroupAllocation> PlanningGroupAllocations = null, CapacityPlanMetricsSummary CapacityPlanMetricsSummary = null)
        {
            this.StaffingGroupAllocations = StaffingGroupAllocations;
            this.Months = Months;
            this.PlanningGroupAllocations = PlanningGroupAllocations;
            this.CapacityPlanMetricsSummary = CapacityPlanMetricsSummary;
            
        }
        


        /// <summary>
        /// List of staffing group allocations
        /// </summary>
        /// <value>List of staffing group allocations</value>
        [DataMember(Name="staffingGroupAllocations", EmitDefaultValue=false)]
        public List<StaffingGroupAllocation> StaffingGroupAllocations { get; set; }



        /// <summary>
        /// The list of months covered by this capacity plan, formatted as yyyy-MM
        /// </summary>
        /// <value>The list of months covered by this capacity plan, formatted as yyyy-MM</value>
        [DataMember(Name="months", EmitDefaultValue=false)]
        public List<YearMonth> Months { get; set; }



        /// <summary>
        /// The planning group allocations
        /// </summary>
        /// <value>The planning group allocations</value>
        [DataMember(Name="planningGroupAllocations", EmitDefaultValue=false)]
        public List<CapacityPlanningPlanningGroupAllocation> PlanningGroupAllocations { get; set; }



        /// <summary>
        /// The total summary of staffing allocation metrics for this capacity plan, for the selected granularity
        /// </summary>
        /// <value>The total summary of staffing allocation metrics for this capacity plan, for the selected granularity</value>
        [DataMember(Name="capacityPlanMetricsSummary", EmitDefaultValue=false)]
        public CapacityPlanMetricsSummary CapacityPlanMetricsSummary { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffingGroupAllocationsResponseTemplate {\n");

            sb.Append("  StaffingGroupAllocations: ").Append(StaffingGroupAllocations).Append("\n");
            sb.Append("  Months: ").Append(Months).Append("\n");
            sb.Append("  PlanningGroupAllocations: ").Append(PlanningGroupAllocations).Append("\n");
            sb.Append("  CapacityPlanMetricsSummary: ").Append(CapacityPlanMetricsSummary).Append("\n");
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
            return this.Equals(obj as StaffingGroupAllocationsResponseTemplate);
        }

        /// <summary>
        /// Returns true if StaffingGroupAllocationsResponseTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of StaffingGroupAllocationsResponseTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffingGroupAllocationsResponseTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StaffingGroupAllocations == other.StaffingGroupAllocations ||
                    this.StaffingGroupAllocations != null &&
                    this.StaffingGroupAllocations.SequenceEqual(other.StaffingGroupAllocations)
                ) &&
                (
                    this.Months == other.Months ||
                    this.Months != null &&
                    this.Months.SequenceEqual(other.Months)
                ) &&
                (
                    this.PlanningGroupAllocations == other.PlanningGroupAllocations ||
                    this.PlanningGroupAllocations != null &&
                    this.PlanningGroupAllocations.SequenceEqual(other.PlanningGroupAllocations)
                ) &&
                (
                    this.CapacityPlanMetricsSummary == other.CapacityPlanMetricsSummary ||
                    this.CapacityPlanMetricsSummary != null &&
                    this.CapacityPlanMetricsSummary.Equals(other.CapacityPlanMetricsSummary)
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
                if (this.StaffingGroupAllocations != null)
                    hash = hash * 59 + this.StaffingGroupAllocations.GetHashCode();

                if (this.Months != null)
                    hash = hash * 59 + this.Months.GetHashCode();

                if (this.PlanningGroupAllocations != null)
                    hash = hash * 59 + this.PlanningGroupAllocations.GetHashCode();

                if (this.CapacityPlanMetricsSummary != null)
                    hash = hash * 59 + this.CapacityPlanMetricsSummary.GetHashCode();

                return hash;
            }
        }
    }

}
