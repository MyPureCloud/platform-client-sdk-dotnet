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
    /// StaffingRequirementsPlanningGroupData
    /// </summary>
    [DataContract]
    public partial class StaffingRequirementsPlanningGroupData :  IEquatable<StaffingRequirementsPlanningGroupData>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StaffingRequirementsPlanningGroupData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaffingRequirementsPlanningGroupData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffingRequirementsPlanningGroupData" /> class.
        /// </summary>
        /// <param name="PlanningGroupId">The ID of the planning group to which this data applies (required).</param>
        /// <param name="StaffingRequirementsPerInterval">Staffing requirements per interval for this week forecast (required).</param>
        /// <param name="MinimumStaffPerInterval">Minimum Staff per interval for this week forecast.</param>
        /// <param name="EffectiveStaffPerInterval">Effective Staff per interval for this week forecast.</param>
        public StaffingRequirementsPlanningGroupData(string PlanningGroupId = null, List<double?> StaffingRequirementsPerInterval = null, List<double?> MinimumStaffPerInterval = null, List<double?> EffectiveStaffPerInterval = null)
        {
            this.PlanningGroupId = PlanningGroupId;
            this.StaffingRequirementsPerInterval = StaffingRequirementsPerInterval;
            this.MinimumStaffPerInterval = MinimumStaffPerInterval;
            this.EffectiveStaffPerInterval = EffectiveStaffPerInterval;
            
        }
        


        /// <summary>
        /// The ID of the planning group to which this data applies
        /// </summary>
        /// <value>The ID of the planning group to which this data applies</value>
        [DataMember(Name="planningGroupId", EmitDefaultValue=false)]
        public string PlanningGroupId { get; set; }



        /// <summary>
        /// Staffing requirements per interval for this week forecast
        /// </summary>
        /// <value>Staffing requirements per interval for this week forecast</value>
        [DataMember(Name="staffingRequirementsPerInterval", EmitDefaultValue=false)]
        public List<double?> StaffingRequirementsPerInterval { get; set; }



        /// <summary>
        /// Minimum Staff per interval for this week forecast
        /// </summary>
        /// <value>Minimum Staff per interval for this week forecast</value>
        [DataMember(Name="minimumStaffPerInterval", EmitDefaultValue=false)]
        public List<double?> MinimumStaffPerInterval { get; set; }



        /// <summary>
        /// Effective Staff per interval for this week forecast
        /// </summary>
        /// <value>Effective Staff per interval for this week forecast</value>
        [DataMember(Name="effectiveStaffPerInterval", EmitDefaultValue=false)]
        public List<double?> EffectiveStaffPerInterval { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffingRequirementsPlanningGroupData {\n");

            sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
            sb.Append("  StaffingRequirementsPerInterval: ").Append(StaffingRequirementsPerInterval).Append("\n");
            sb.Append("  MinimumStaffPerInterval: ").Append(MinimumStaffPerInterval).Append("\n");
            sb.Append("  EffectiveStaffPerInterval: ").Append(EffectiveStaffPerInterval).Append("\n");
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
            return this.Equals(obj as StaffingRequirementsPlanningGroupData);
        }

        /// <summary>
        /// Returns true if StaffingRequirementsPlanningGroupData instances are equal
        /// </summary>
        /// <param name="other">Instance of StaffingRequirementsPlanningGroupData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffingRequirementsPlanningGroupData other)
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
                    this.StaffingRequirementsPerInterval == other.StaffingRequirementsPerInterval ||
                    this.StaffingRequirementsPerInterval != null &&
                    this.StaffingRequirementsPerInterval.SequenceEqual(other.StaffingRequirementsPerInterval)
                ) &&
                (
                    this.MinimumStaffPerInterval == other.MinimumStaffPerInterval ||
                    this.MinimumStaffPerInterval != null &&
                    this.MinimumStaffPerInterval.SequenceEqual(other.MinimumStaffPerInterval)
                ) &&
                (
                    this.EffectiveStaffPerInterval == other.EffectiveStaffPerInterval ||
                    this.EffectiveStaffPerInterval != null &&
                    this.EffectiveStaffPerInterval.SequenceEqual(other.EffectiveStaffPerInterval)
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

                if (this.StaffingRequirementsPerInterval != null)
                    hash = hash * 59 + this.StaffingRequirementsPerInterval.GetHashCode();

                if (this.MinimumStaffPerInterval != null)
                    hash = hash * 59 + this.MinimumStaffPerInterval.GetHashCode();

                if (this.EffectiveStaffPerInterval != null)
                    hash = hash * 59 + this.EffectiveStaffPerInterval.GetHashCode();

                return hash;
            }
        }
    }

}
