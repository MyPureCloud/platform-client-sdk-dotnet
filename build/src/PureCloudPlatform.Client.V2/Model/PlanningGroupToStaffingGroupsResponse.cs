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
    /// PlanningGroupToStaffingGroupsResponse
    /// </summary>
    [DataContract]
    public partial class PlanningGroupToStaffingGroupsResponse :  IEquatable<PlanningGroupToStaffingGroupsResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanningGroupToStaffingGroupsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlanningGroupToStaffingGroupsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanningGroupToStaffingGroupsResponse" /> class.
        /// </summary>
        /// <param name="PlanningGroup">The ID of the planning group (required).</param>
        /// <param name="StaffingGroups">The list of staffing groups that are associated with the planning group.</param>
        public PlanningGroupToStaffingGroupsResponse(PlanningGroupReference PlanningGroup = null, List<StaffingGroupReference> StaffingGroups = null)
        {
            this.PlanningGroup = PlanningGroup;
            this.StaffingGroups = StaffingGroups;
            
        }
        


        /// <summary>
        /// The ID of the planning group
        /// </summary>
        /// <value>The ID of the planning group</value>
        [DataMember(Name="planningGroup", EmitDefaultValue=false)]
        public PlanningGroupReference PlanningGroup { get; set; }



        /// <summary>
        /// The list of staffing groups that are associated with the planning group
        /// </summary>
        /// <value>The list of staffing groups that are associated with the planning group</value>
        [DataMember(Name="staffingGroups", EmitDefaultValue=false)]
        public List<StaffingGroupReference> StaffingGroups { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanningGroupToStaffingGroupsResponse {\n");

            sb.Append("  PlanningGroup: ").Append(PlanningGroup).Append("\n");
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
            return this.Equals(obj as PlanningGroupToStaffingGroupsResponse);
        }

        /// <summary>
        /// Returns true if PlanningGroupToStaffingGroupsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanningGroupToStaffingGroupsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanningGroupToStaffingGroupsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PlanningGroup == other.PlanningGroup ||
                    this.PlanningGroup != null &&
                    this.PlanningGroup.Equals(other.PlanningGroup)
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
                if (this.PlanningGroup != null)
                    hash = hash * 59 + this.PlanningGroup.GetHashCode();

                if (this.StaffingGroups != null)
                    hash = hash * 59 + this.StaffingGroups.GetHashCode();

                return hash;
            }
        }
    }

}
