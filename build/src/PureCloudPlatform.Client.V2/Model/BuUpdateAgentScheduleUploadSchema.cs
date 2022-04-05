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
    /// BuUpdateAgentScheduleUploadSchema
    /// </summary>
    [DataContract]
    public partial class BuUpdateAgentScheduleUploadSchema :  IEquatable<BuUpdateAgentScheduleUploadSchema>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuUpdateAgentScheduleUploadSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuUpdateAgentScheduleUploadSchema() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuUpdateAgentScheduleUploadSchema" /> class.
        /// </summary>
        /// <param name="UserId">The ID of the user to whom this agent schedule applies (required).</param>
        /// <param name="WorkPlanId">The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek.</param>
        /// <param name="WorkPlanIdsPerWeek">The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId.</param>
        /// <param name="Shifts">The shift definitions for this agent schedule.</param>
        /// <param name="FullDayTimeOffMarkers">Any full day time off markers that apply to this agent schedule.</param>
        /// <param name="Metadata">Version metadata for this agent schedule. Required if updating or deleting an existing agent schedule, otherwise should be omitted.</param>
        /// <param name="Delete">Whether to delete this agent&#39;s schedule. Defaults to false if not set.</param>
        public BuUpdateAgentScheduleUploadSchema(string UserId = null, ValueWrapperString WorkPlanId = null, ListWrapperString WorkPlanIdsPerWeek = null, List<BuAgentScheduleShift> Shifts = null, List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers = null, WfmVersionedEntityMetadata Metadata = null, bool? Delete = null)
        {
            this.UserId = UserId;
            this.WorkPlanId = WorkPlanId;
            this.WorkPlanIdsPerWeek = WorkPlanIdsPerWeek;
            this.Shifts = Shifts;
            this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;
            this.Metadata = Metadata;
            this.Delete = Delete;
            
        }
        
        
        
        /// <summary>
        /// The ID of the user to whom this agent schedule applies
        /// </summary>
        /// <value>The ID of the user to whom this agent schedule applies</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        /// <summary>
        /// The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek
        /// </summary>
        /// <value>The ID of the work plan for this user.  Mutually exclusive with workPlanIdsPerWeek</value>
        [DataMember(Name="workPlanId", EmitDefaultValue=false)]
        public ValueWrapperString WorkPlanId { get; set; }
        
        
        
        /// <summary>
        /// The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId
        /// </summary>
        /// <value>The IDs of the work plans per week for this user.  Mutually exclusive with workPlanId</value>
        [DataMember(Name="workPlanIdsPerWeek", EmitDefaultValue=false)]
        public ListWrapperString WorkPlanIdsPerWeek { get; set; }
        
        
        
        /// <summary>
        /// The shift definitions for this agent schedule
        /// </summary>
        /// <value>The shift definitions for this agent schedule</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<BuAgentScheduleShift> Shifts { get; set; }
        
        
        
        /// <summary>
        /// Any full day time off markers that apply to this agent schedule
        /// </summary>
        /// <value>Any full day time off markers that apply to this agent schedule</value>
        [DataMember(Name="fullDayTimeOffMarkers", EmitDefaultValue=false)]
        public List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }
        
        
        
        /// <summary>
        /// Version metadata for this agent schedule. Required if updating or deleting an existing agent schedule, otherwise should be omitted
        /// </summary>
        /// <value>Version metadata for this agent schedule. Required if updating or deleting an existing agent schedule, otherwise should be omitted</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        
        /// <summary>
        /// Whether to delete this agent&#39;s schedule. Defaults to false if not set
        /// </summary>
        /// <value>Whether to delete this agent&#39;s schedule. Defaults to false if not set</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuUpdateAgentScheduleUploadSchema {\n");
            
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
            sb.Append("  WorkPlanIdsPerWeek: ").Append(WorkPlanIdsPerWeek).Append("\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as BuUpdateAgentScheduleUploadSchema);
        }

        /// <summary>
        /// Returns true if BuUpdateAgentScheduleUploadSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of BuUpdateAgentScheduleUploadSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuUpdateAgentScheduleUploadSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.WorkPlanId == other.WorkPlanId ||
                    this.WorkPlanId != null &&
                    this.WorkPlanId.Equals(other.WorkPlanId)
                ) &&
                (
                    this.WorkPlanIdsPerWeek == other.WorkPlanIdsPerWeek ||
                    this.WorkPlanIdsPerWeek != null &&
                    this.WorkPlanIdsPerWeek.Equals(other.WorkPlanIdsPerWeek)
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
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.WorkPlanId != null)
                    hash = hash * 59 + this.WorkPlanId.GetHashCode();
                
                if (this.WorkPlanIdsPerWeek != null)
                    hash = hash * 59 + this.WorkPlanIdsPerWeek.GetHashCode();
                
                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();
                
                if (this.FullDayTimeOffMarkers != null)
                    hash = hash * 59 + this.FullDayTimeOffMarkers.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();
                
                return hash;
            }
        }
    }

}
