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
    /// TimeOffPlanBusinessUnitAssociation
    /// </summary>
    [DataContract]
    public partial class TimeOffPlanBusinessUnitAssociation :  IEquatable<TimeOffPlanBusinessUnitAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffPlanBusinessUnitAssociation" /> class.
        /// </summary>
        /// <param name="ManagementUnits">Management units to which this time-off plan applies. This must not be set if staffingGroups is populated.</param>
        /// <param name="StaffingGroups">Staffing groups to which this time-off plan applies. This must not be set if managementUnits is populated.</param>
        public TimeOffPlanBusinessUnitAssociation(List<ManagementUnitReference> ManagementUnits = null, List<StaffingGroupReference> StaffingGroups = null)
        {
            this.ManagementUnits = ManagementUnits;
            this.StaffingGroups = StaffingGroups;
            
        }
        


        /// <summary>
        /// Management units to which this time-off plan applies. This must not be set if staffingGroups is populated
        /// </summary>
        /// <value>Management units to which this time-off plan applies. This must not be set if staffingGroups is populated</value>
        [DataMember(Name="managementUnits", EmitDefaultValue=false)]
        public List<ManagementUnitReference> ManagementUnits { get; set; }



        /// <summary>
        /// Staffing groups to which this time-off plan applies. This must not be set if managementUnits is populated
        /// </summary>
        /// <value>Staffing groups to which this time-off plan applies. This must not be set if managementUnits is populated</value>
        [DataMember(Name="staffingGroups", EmitDefaultValue=false)]
        public List<StaffingGroupReference> StaffingGroups { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeOffPlanBusinessUnitAssociation {\n");

            sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
            sb.Append("  StaffingGroups: ").Append(StaffingGroups).Append("\n");
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
            return this.Equals(obj as TimeOffPlanBusinessUnitAssociation);
        }

        /// <summary>
        /// Returns true if TimeOffPlanBusinessUnitAssociation instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeOffPlanBusinessUnitAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOffPlanBusinessUnitAssociation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnits == other.ManagementUnits ||
                    this.ManagementUnits != null &&
                    this.ManagementUnits.SequenceEqual(other.ManagementUnits)
                ) &&
                (
                    this.StaffingGroups == other.StaffingGroups ||
                    this.StaffingGroups != null &&
                    this.StaffingGroups.SequenceEqual(other.StaffingGroups)
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
                if (this.ManagementUnits != null)
                    hash = hash * 59 + this.ManagementUnits.GetHashCode();

                if (this.StaffingGroups != null)
                    hash = hash * 59 + this.StaffingGroups.GetHashCode();

                return hash;
            }
        }
    }

}
