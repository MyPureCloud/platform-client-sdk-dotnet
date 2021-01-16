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
    /// BuAgentScheduleHistoryDroppedChange
    /// </summary>
    [DataContract]
    public partial class BuAgentScheduleHistoryDroppedChange :  IEquatable<BuAgentScheduleHistoryDroppedChange>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuAgentScheduleHistoryDroppedChange" /> class.
        /// </summary>
        /// <param name="Metadata">The metadata of the change, including who and when the change was made.</param>
        /// <param name="ShiftIds">The IDs of deleted shifts.</param>
        /// <param name="FullDayTimeOffMarkerDates">The dates of any deleted full day time off markers.</param>
        /// <param name="Deletes">The deleted shifts, full day time off markers, or the entire agent schedule.</param>
        public BuAgentScheduleHistoryDroppedChange(BuAgentScheduleHistoryChangeMetadata Metadata = null, List<string> ShiftIds = null, List<String> FullDayTimeOffMarkerDates = null, BuAgentScheduleHistoryDeletedChange Deletes = null)
        {
            this.Metadata = Metadata;
            this.ShiftIds = ShiftIds;
            this.FullDayTimeOffMarkerDates = FullDayTimeOffMarkerDates;
            this.Deletes = Deletes;
            
        }
        
        
        
        /// <summary>
        /// The metadata of the change, including who and when the change was made
        /// </summary>
        /// <value>The metadata of the change, including who and when the change was made</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public BuAgentScheduleHistoryChangeMetadata Metadata { get; set; }
        
        
        
        /// <summary>
        /// The IDs of deleted shifts
        /// </summary>
        /// <value>The IDs of deleted shifts</value>
        [DataMember(Name="shiftIds", EmitDefaultValue=false)]
        public List<string> ShiftIds { get; set; }
        
        
        
        /// <summary>
        /// The dates of any deleted full day time off markers
        /// </summary>
        /// <value>The dates of any deleted full day time off markers</value>
        [DataMember(Name="fullDayTimeOffMarkerDates", EmitDefaultValue=false)]
        public List<String> FullDayTimeOffMarkerDates { get; set; }
        
        
        
        /// <summary>
        /// The deleted shifts, full day time off markers, or the entire agent schedule
        /// </summary>
        /// <value>The deleted shifts, full day time off markers, or the entire agent schedule</value>
        [DataMember(Name="deletes", EmitDefaultValue=false)]
        public BuAgentScheduleHistoryDeletedChange Deletes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuAgentScheduleHistoryDroppedChange {\n");
            
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ShiftIds: ").Append(ShiftIds).Append("\n");
            sb.Append("  FullDayTimeOffMarkerDates: ").Append(FullDayTimeOffMarkerDates).Append("\n");
            sb.Append("  Deletes: ").Append(Deletes).Append("\n");
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
            return this.Equals(obj as BuAgentScheduleHistoryDroppedChange);
        }

        /// <summary>
        /// Returns true if BuAgentScheduleHistoryDroppedChange instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAgentScheduleHistoryDroppedChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAgentScheduleHistoryDroppedChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.ShiftIds == other.ShiftIds ||
                    this.ShiftIds != null &&
                    this.ShiftIds.SequenceEqual(other.ShiftIds)
                ) &&
                (
                    this.FullDayTimeOffMarkerDates == other.FullDayTimeOffMarkerDates ||
                    this.FullDayTimeOffMarkerDates != null &&
                    this.FullDayTimeOffMarkerDates.SequenceEqual(other.FullDayTimeOffMarkerDates)
                ) &&
                (
                    this.Deletes == other.Deletes ||
                    this.Deletes != null &&
                    this.Deletes.Equals(other.Deletes)
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
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                if (this.ShiftIds != null)
                    hash = hash * 59 + this.ShiftIds.GetHashCode();
                
                if (this.FullDayTimeOffMarkerDates != null)
                    hash = hash * 59 + this.FullDayTimeOffMarkerDates.GetHashCode();
                
                if (this.Deletes != null)
                    hash = hash * 59 + this.Deletes.GetHashCode();
                
                return hash;
            }
        }
    }

}
