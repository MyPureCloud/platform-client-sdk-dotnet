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
    /// Marker to indicate an approved full day time off request
    /// </summary>
    [DataContract]
    public partial class UserScheduleFullDayTimeOffMarker :  IEquatable<UserScheduleFullDayTimeOffMarker>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserScheduleFullDayTimeOffMarker" /> class.
        /// </summary>
        /// <param name="ManagementUnitDate">The date associated with the time off request that this marker corresponds to.  Date only, in ISO-8601 format..</param>
        /// <param name="ActivityCodeId">The id for the activity code.  Look up a map of activity codes with the activities route.</param>
        /// <param name="IsPaid">Whether this is paid time off.</param>
        /// <param name="LengthInMinutes">The length in minutes of this time off marker.</param>
        /// <param name="Description">The description associated with the time off request that this marker corresponds to.</param>
        /// <param name="Delete">If marked true for updating an existing full day time off marker, it will be deleted.</param>
        public UserScheduleFullDayTimeOffMarker(string ManagementUnitDate = null, string ActivityCodeId = null, bool? IsPaid = null, int? LengthInMinutes = null, string Description = null, bool? Delete = null)
        {
            this.ManagementUnitDate = ManagementUnitDate;
            this.ActivityCodeId = ActivityCodeId;
            this.IsPaid = IsPaid;
            this.LengthInMinutes = LengthInMinutes;
            this.Description = Description;
            this.Delete = Delete;
            
        }
        
        
        
        /// <summary>
        /// The date associated with the time off request that this marker corresponds to.  Date only, in ISO-8601 format.
        /// </summary>
        /// <value>The date associated with the time off request that this marker corresponds to.  Date only, in ISO-8601 format.</value>
        [DataMember(Name="managementUnitDate", EmitDefaultValue=false)]
        public string ManagementUnitDate { get; set; }
        
        
        
        /// <summary>
        /// The id for the activity code.  Look up a map of activity codes with the activities route
        /// </summary>
        /// <value>The id for the activity code.  Look up a map of activity codes with the activities route</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }
        
        
        
        /// <summary>
        /// Whether this is paid time off
        /// </summary>
        /// <value>Whether this is paid time off</value>
        [DataMember(Name="isPaid", EmitDefaultValue=false)]
        public bool? IsPaid { get; set; }
        
        
        
        /// <summary>
        /// The length in minutes of this time off marker
        /// </summary>
        /// <value>The length in minutes of this time off marker</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }
        
        
        
        /// <summary>
        /// The description associated with the time off request that this marker corresponds to
        /// </summary>
        /// <value>The description associated with the time off request that this marker corresponds to</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// If marked true for updating an existing full day time off marker, it will be deleted
        /// </summary>
        /// <value>If marked true for updating an existing full day time off marker, it will be deleted</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserScheduleFullDayTimeOffMarker {\n");
            
            sb.Append("  ManagementUnitDate: ").Append(ManagementUnitDate).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  IsPaid: ").Append(IsPaid).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
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
            return this.Equals(obj as UserScheduleFullDayTimeOffMarker);
        }

        /// <summary>
        /// Returns true if UserScheduleFullDayTimeOffMarker instances are equal
        /// </summary>
        /// <param name="other">Instance of UserScheduleFullDayTimeOffMarker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserScheduleFullDayTimeOffMarker other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Delete == other.Delete ||
                    this.Delete != null &&
                    this.Delete.Equals(other.Delete)
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
                
                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();
                
                return hash;
            }
        }
    }

}
