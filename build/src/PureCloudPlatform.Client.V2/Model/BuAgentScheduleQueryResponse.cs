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
    /// BuAgentScheduleQueryResponse
    /// </summary>
    [DataContract]
    public partial class BuAgentScheduleQueryResponse :  IEquatable<BuAgentScheduleQueryResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuAgentScheduleQueryResponse" /> class.
        /// </summary>
        /// <param name="User">The user to whom this agent schedule applies.</param>
        /// <param name="Shifts">The shift definitions for this agent schedule.</param>
        /// <param name="FullDayTimeOffMarkers">Full day time off markers which apply to this agent schedule.</param>
        /// <param name="WorkPlan">The work plan for this user.</param>
        /// <param name="Metadata">Versioned entity metadata for this agent schedule.</param>
        public BuAgentScheduleQueryResponse(UserReference User = null, List<BuAgentScheduleShift> Shifts = null, List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers = null, WorkPlanReference WorkPlan = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.User = User;
            this.Shifts = Shifts;
            this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;
            this.WorkPlan = WorkPlan;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// The user to whom this agent schedule applies
        /// </summary>
        /// <value>The user to whom this agent schedule applies</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }
        
        
        
        /// <summary>
        /// The shift definitions for this agent schedule
        /// </summary>
        /// <value>The shift definitions for this agent schedule</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<BuAgentScheduleShift> Shifts { get; set; }
        
        
        
        /// <summary>
        /// Full day time off markers which apply to this agent schedule
        /// </summary>
        /// <value>Full day time off markers which apply to this agent schedule</value>
        [DataMember(Name="fullDayTimeOffMarkers", EmitDefaultValue=false)]
        public List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }
        
        
        
        /// <summary>
        /// The work plan for this user
        /// </summary>
        /// <value>The work plan for this user</value>
        [DataMember(Name="workPlan", EmitDefaultValue=false)]
        public WorkPlanReference WorkPlan { get; set; }
        
        
        
        /// <summary>
        /// Versioned entity metadata for this agent schedule
        /// </summary>
        /// <value>Versioned entity metadata for this agent schedule</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuAgentScheduleQueryResponse {\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
            sb.Append("  WorkPlan: ").Append(WorkPlan).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as BuAgentScheduleQueryResponse);
        }

        /// <summary>
        /// Returns true if BuAgentScheduleQueryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAgentScheduleQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAgentScheduleQueryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                    this.WorkPlan == other.WorkPlan ||
                    this.WorkPlan != null &&
                    this.WorkPlan.Equals(other.WorkPlan)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();
                
                if (this.FullDayTimeOffMarkers != null)
                    hash = hash * 59 + this.FullDayTimeOffMarkers.GetHashCode();
                
                if (this.WorkPlan != null)
                    hash = hash * 59 + this.WorkPlan.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                return hash;
            }
        }
    }

}
