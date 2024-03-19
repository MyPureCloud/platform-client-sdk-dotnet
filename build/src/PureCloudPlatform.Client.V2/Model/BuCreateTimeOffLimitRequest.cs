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
    /// BuCreateTimeOffLimitRequest
    /// </summary>
    [DataContract]
    public partial class BuCreateTimeOffLimitRequest :  IEquatable<BuCreateTimeOffLimitRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuCreateTimeOffLimitRequest" /> class.
        /// </summary>
        /// <param name="StaffingGroupId">The ID of the staffing group to which this time-off limit is associated. It can be either management unit or business unit level staffing group. One of managementUnitId or staffingGroupId must be set. This must not be set if managementUnitId has value.</param>
        /// <param name="ManagementUnitId">The ID of the management unit to which this time-off limit is associated. One of managementUnitId or staffingGroupId must be set. This must not be set if staffingGroupId has value.</param>
        public BuCreateTimeOffLimitRequest(string StaffingGroupId = null, string ManagementUnitId = null)
        {
            this.StaffingGroupId = StaffingGroupId;
            this.ManagementUnitId = ManagementUnitId;
            
        }
        


        /// <summary>
        /// The ID of the staffing group to which this time-off limit is associated. It can be either management unit or business unit level staffing group. One of managementUnitId or staffingGroupId must be set. This must not be set if managementUnitId has value
        /// </summary>
        /// <value>The ID of the staffing group to which this time-off limit is associated. It can be either management unit or business unit level staffing group. One of managementUnitId or staffingGroupId must be set. This must not be set if managementUnitId has value</value>
        [DataMember(Name="staffingGroupId", EmitDefaultValue=false)]
        public string StaffingGroupId { get; set; }



        /// <summary>
        /// The ID of the management unit to which this time-off limit is associated. One of managementUnitId or staffingGroupId must be set. This must not be set if staffingGroupId has value
        /// </summary>
        /// <value>The ID of the management unit to which this time-off limit is associated. One of managementUnitId or staffingGroupId must be set. This must not be set if staffingGroupId has value</value>
        [DataMember(Name="managementUnitId", EmitDefaultValue=false)]
        public string ManagementUnitId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuCreateTimeOffLimitRequest {\n");

            sb.Append("  StaffingGroupId: ").Append(StaffingGroupId).Append("\n");
            sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
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
            return this.Equals(obj as BuCreateTimeOffLimitRequest);
        }

        /// <summary>
        /// Returns true if BuCreateTimeOffLimitRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BuCreateTimeOffLimitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuCreateTimeOffLimitRequest other)
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
                    this.ManagementUnitId == other.ManagementUnitId ||
                    this.ManagementUnitId != null &&
                    this.ManagementUnitId.Equals(other.ManagementUnitId)
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

                if (this.ManagementUnitId != null)
                    hash = hash * 59 + this.ManagementUnitId.GetHashCode();

                return hash;
            }
        }
    }

}
