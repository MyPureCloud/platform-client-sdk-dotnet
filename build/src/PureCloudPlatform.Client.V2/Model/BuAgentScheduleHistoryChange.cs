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
    /// BuAgentScheduleHistoryChange
    /// </summary>
    [DataContract]
    public partial class BuAgentScheduleHistoryChange :  IEquatable<BuAgentScheduleHistoryChange>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuAgentScheduleHistoryChange" /> class.
        /// </summary>
        /// <param name="Metadata">The metadata of the change, including who and when the change was made.</param>
        /// <param name="Shifts">The list of changed shifts.</param>
        /// <param name="FullDayTimeOffMarkers">The list of changed full day time off markers.</param>
        /// <param name="Deletes">The deleted shifts, full day time off markers, or the entire agent schedule.</param>
        public BuAgentScheduleHistoryChange(BuAgentScheduleHistoryChangeMetadata Metadata = null, List<BuAgentScheduleShift> Shifts = null, List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers = null, BuAgentScheduleHistoryDeletedChange Deletes = null)
        {
            this.Metadata = Metadata;
            this.Shifts = Shifts;
            this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;
            this.Deletes = Deletes;
            
        }
        
        
        
        /// <summary>
        /// The metadata of the change, including who and when the change was made
        /// </summary>
        /// <value>The metadata of the change, including who and when the change was made</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public BuAgentScheduleHistoryChangeMetadata Metadata { get; set; }
        
        
        
        /// <summary>
        /// The list of changed shifts
        /// </summary>
        /// <value>The list of changed shifts</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<BuAgentScheduleShift> Shifts { get; set; }
        
        
        
        /// <summary>
        /// The list of changed full day time off markers
        /// </summary>
        /// <value>The list of changed full day time off markers</value>
        [DataMember(Name="fullDayTimeOffMarkers", EmitDefaultValue=false)]
        public List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }
        
        
        
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
            sb.Append("class BuAgentScheduleHistoryChange {\n");
            
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
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
            return this.Equals(obj as BuAgentScheduleHistoryChange);
        }

        /// <summary>
        /// Returns true if BuAgentScheduleHistoryChange instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAgentScheduleHistoryChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAgentScheduleHistoryChange other)
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
                    this.Shifts == other.Shifts ||
                    this.Shifts != null &&
                    this.Shifts.SequenceEqual(other.Shifts)
                ) &&
                (
                    this.FullDayTimeOffMarkers == other.FullDayTimeOffMarkers ||
                    this.FullDayTimeOffMarkers != null &&
                    this.FullDayTimeOffMarkers.SequenceEqual(other.FullDayTimeOffMarkers)
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
                
                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();
                
                if (this.FullDayTimeOffMarkers != null)
                    hash = hash * 59 + this.FullDayTimeOffMarkers.GetHashCode();
                
                if (this.Deletes != null)
                    hash = hash * 59 + this.Deletes.GetHashCode();
                
                return hash;
            }
        }
    }

}
