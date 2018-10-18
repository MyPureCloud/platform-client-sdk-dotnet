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
    /// WfmAgentScheduleUpdateNotificationNotificationFullDayTimeOffMarkers
    /// </summary>
    [DataContract]
    public partial class WfmAgentScheduleUpdateNotificationNotificationFullDayTimeOffMarkers :  IEquatable<WfmAgentScheduleUpdateNotificationNotificationFullDayTimeOffMarkers>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAgentScheduleUpdateNotificationNotificationFullDayTimeOffMarkers" /> class.
        /// </summary>
        /// <param name="TimeOffRequestId">TimeOffRequestId.</param>
        /// <param name="ManagementUnitDate">ManagementUnitDate.</param>
        /// <param name="ActivityCodeId">ActivityCodeId.</param>
        /// <param name="IsPaid">IsPaid.</param>
        /// <param name="LengthInMinutes">LengthInMinutes.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Paid">Paid.</param>
        public WfmAgentScheduleUpdateNotificationNotificationFullDayTimeOffMarkers(string TimeOffRequestId = null, string ManagementUnitDate = null, string ActivityCodeId = null, bool? IsPaid = null, int? LengthInMinutes = null, string Description = null, bool? Paid = null)
        {
            this.TimeOffRequestId = TimeOffRequestId;
            this.ManagementUnitDate = ManagementUnitDate;
            this.ActivityCodeId = ActivityCodeId;
            this.IsPaid = IsPaid;
            this.LengthInMinutes = LengthInMinutes;
            this.Description = Description;
            this.Paid = Paid;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets TimeOffRequestId
        /// </summary>
        [DataMember(Name="timeOffRequestId", EmitDefaultValue=false)]
        public string TimeOffRequestId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ManagementUnitDate
        /// </summary>
        [DataMember(Name="managementUnitDate", EmitDefaultValue=false)]
        public string ManagementUnitDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ActivityCodeId
        /// </summary>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IsPaid
        /// </summary>
        [DataMember(Name="isPaid", EmitDefaultValue=false)]
        public bool? IsPaid { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LengthInMinutes
        /// </summary>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Paid
        /// </summary>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public bool? Paid { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmAgentScheduleUpdateNotificationNotificationFullDayTimeOffMarkers {\n");
            
            sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
            sb.Append("  ManagementUnitDate: ").Append(ManagementUnitDate).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  IsPaid: ").Append(IsPaid).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WfmAgentScheduleUpdateNotificationNotificationFullDayTimeOffMarkers);
        }

        /// <summary>
        /// Returns true if WfmAgentScheduleUpdateNotificationNotificationFullDayTimeOffMarkers instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmAgentScheduleUpdateNotificationNotificationFullDayTimeOffMarkers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmAgentScheduleUpdateNotificationNotificationFullDayTimeOffMarkers other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeOffRequestId == other.TimeOffRequestId ||
                    this.TimeOffRequestId != null &&
                    this.TimeOffRequestId.Equals(other.TimeOffRequestId)
                ) &&
                (
                    this.ManagementUnitDate == other.ManagementUnitDate ||
                    this.ManagementUnitDate != null &&
                    this.ManagementUnitDate.Equals(other.ManagementUnitDate)
                ) &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.IsPaid == other.IsPaid ||
                    this.IsPaid != null &&
                    this.IsPaid.Equals(other.IsPaid)
                ) &&
                (
                    this.LengthInMinutes == other.LengthInMinutes ||
                    this.LengthInMinutes != null &&
                    this.LengthInMinutes.Equals(other.LengthInMinutes)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Paid == other.Paid ||
                    this.Paid != null &&
                    this.Paid.Equals(other.Paid)
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
                
                if (this.TimeOffRequestId != null)
                    hash = hash * 59 + this.TimeOffRequestId.GetHashCode();
                
                if (this.ManagementUnitDate != null)
                    hash = hash * 59 + this.ManagementUnitDate.GetHashCode();
                
                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();
                
                if (this.IsPaid != null)
                    hash = hash * 59 + this.IsPaid.GetHashCode();
                
                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();
                
                return hash;
            }
        }
    }

}
