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
    /// StaffingGroupFullTimeEquivalentContribution
    /// </summary>
    [DataContract]
    public partial class StaffingGroupFullTimeEquivalentContribution :  IEquatable<StaffingGroupFullTimeEquivalentContribution>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StaffingGroupFullTimeEquivalentContribution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaffingGroupFullTimeEquivalentContribution() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffingGroupFullTimeEquivalentContribution" /> class.
        /// </summary>
        /// <param name="StaffingGroupId">The staffing group ID receiving full time equivalent agents from the planning group (required).</param>
        /// <param name="PlannedFullTimeEquivalentContribution">The weekly planned full time contribution from the planning group to this staffing group (required).</param>
        public StaffingGroupFullTimeEquivalentContribution(string StaffingGroupId = null, List<double?> PlannedFullTimeEquivalentContribution = null)
        {
            this.StaffingGroupId = StaffingGroupId;
            this.PlannedFullTimeEquivalentContribution = PlannedFullTimeEquivalentContribution;
            
        }
        


        /// <summary>
        /// The staffing group ID receiving full time equivalent agents from the planning group
        /// </summary>
        /// <value>The staffing group ID receiving full time equivalent agents from the planning group</value>
        [DataMember(Name="staffingGroupId", EmitDefaultValue=false)]
        public string StaffingGroupId { get; set; }



        /// <summary>
        /// The weekly planned full time contribution from the planning group to this staffing group
        /// </summary>
        /// <value>The weekly planned full time contribution from the planning group to this staffing group</value>
        [DataMember(Name="plannedFullTimeEquivalentContribution", EmitDefaultValue=false)]
        public List<double?> PlannedFullTimeEquivalentContribution { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffingGroupFullTimeEquivalentContribution {\n");

            sb.Append("  StaffingGroupId: ").Append(StaffingGroupId).Append("\n");
            sb.Append("  PlannedFullTimeEquivalentContribution: ").Append(PlannedFullTimeEquivalentContribution).Append("\n");
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
            return this.Equals(obj as StaffingGroupFullTimeEquivalentContribution);
        }

        /// <summary>
        /// Returns true if StaffingGroupFullTimeEquivalentContribution instances are equal
        /// </summary>
        /// <param name="other">Instance of StaffingGroupFullTimeEquivalentContribution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffingGroupFullTimeEquivalentContribution other)
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
                    this.PlannedFullTimeEquivalentContribution == other.PlannedFullTimeEquivalentContribution ||
                    this.PlannedFullTimeEquivalentContribution != null &&
                    this.PlannedFullTimeEquivalentContribution.SequenceEqual(other.PlannedFullTimeEquivalentContribution)
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

                if (this.PlannedFullTimeEquivalentContribution != null)
                    hash = hash * 59 + this.PlannedFullTimeEquivalentContribution.GetHashCode();

                return hash;
            }
        }
    }

}
