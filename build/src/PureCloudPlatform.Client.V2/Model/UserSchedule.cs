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
    /// A schedule for a single user over a given time range
    /// </summary>
    [DataContract]
    public partial class UserSchedule :  IEquatable<UserSchedule>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSchedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSchedule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSchedule" /> class.
        /// </summary>
        /// <param name="Shifts">The shifts that belong to this schedule.</param>
        /// <param name="FullDayTimeOffMarkers">Markers to indicate a full day time off request, relative to the management unit time zone.</param>
        /// <param name="Delete">If marked true for updating an existing user schedule, it will be deleted.</param>
        /// <param name="Metadata">Version metadata for this schedule (required).</param>
        public UserSchedule(List<UserScheduleShift> Shifts = null, List<UserScheduleFullDayTimeOffMarker> FullDayTimeOffMarkers = null, bool? Delete = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Shifts = Shifts;
            this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;
            this.Delete = Delete;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The shifts that belong to this schedule
        /// </summary>
        /// <value>The shifts that belong to this schedule</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<UserScheduleShift> Shifts { get; set; }



        /// <summary>
        /// Markers to indicate a full day time off request, relative to the management unit time zone
        /// </summary>
        /// <value>Markers to indicate a full day time off request, relative to the management unit time zone</value>
        [DataMember(Name="fullDayTimeOffMarkers", EmitDefaultValue=false)]
        public List<UserScheduleFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }



        /// <summary>
        /// If marked true for updating an existing user schedule, it will be deleted
        /// </summary>
        /// <value>If marked true for updating an existing user schedule, it will be deleted</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }



        /// <summary>
        /// Version metadata for this schedule
        /// </summary>
        /// <value>Version metadata for this schedule</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }



        /// <summary>
        /// ID of the work plan associated with the user during schedule creation
        /// </summary>
        /// <value>ID of the work plan associated with the user during schedule creation</value>
        [DataMember(Name="workPlanId", EmitDefaultValue=false)]
        public string WorkPlanId { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSchedule {\n");

            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
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
            return this.Equals(obj as UserSchedule);
        }

        /// <summary>
        /// Returns true if UserSchedule instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSchedule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Delete == other.Delete ||
                    this.Delete != null &&
                    this.Delete.Equals(other.Delete)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.WorkPlanId == other.WorkPlanId ||
                    this.WorkPlanId != null &&
                    this.WorkPlanId.Equals(other.WorkPlanId)
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
                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();

                if (this.FullDayTimeOffMarkers != null)
                    hash = hash * 59 + this.FullDayTimeOffMarkers.GetHashCode();

                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.WorkPlanId != null)
                    hash = hash * 59 + this.WorkPlanId.GetHashCode();

                return hash;
            }
        }
    }

}
