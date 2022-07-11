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
    /// WorkPlanActivity
    /// </summary>
    [DataContract]
    public partial class WorkPlanActivity :  IEquatable<WorkPlanActivity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanActivity" /> class.
        /// </summary>
        /// <param name="ActivityCodeId">ID of the activity code associated with this activity.</param>
        /// <param name="Description">Description of the activity.</param>
        /// <param name="LengthMinutes">Length of the activity in minutes.</param>
        /// <param name="StartTimeIsRelativeToShiftStart">Whether the start time of the activity is relative to the start time of the shift it belongs to.</param>
        /// <param name="FlexibleStartTime">Whether the start time of the activity is flexible.</param>
        /// <param name="EarliestStartTimeMinutes">Earliest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == true.</param>
        /// <param name="LatestStartTimeMinutes">Latest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == true.</param>
        /// <param name="ExactStartTimeMinutes">Exact activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == false.</param>
        /// <param name="StartTimeIncrementMinutes">Increment in offset minutes that would contribute to different possible start times for the activity.</param>
        /// <param name="CountsAsPaidTime">Whether the activity is paid.</param>
        /// <param name="CountsAsContiguousWorkTime">Whether the activity duration is counted towards contiguous work time.</param>
        /// <param name="MinimumLengthFromShiftStartMinutes">The minimum duration between shift start and shift item (e.g., break or meal) start in minutes.</param>
        /// <param name="MinimumLengthFromShiftEndMinutes">The minimum duration between shift item (e.g., break or meal) end and shift end in minutes.</param>
        /// <param name="Id">ID of the activity. This is required only for the case of updating an existing activity.</param>
        /// <param name="Delete">If marked true for updating an existing activity, the activity will be permanently deleted.</param>
        /// <param name="ValidationId">ID of the activity in the context of work plan validation.</param>
        public WorkPlanActivity(string ActivityCodeId = null, string Description = null, int? LengthMinutes = null, bool? StartTimeIsRelativeToShiftStart = null, bool? FlexibleStartTime = null, int? EarliestStartTimeMinutes = null, int? LatestStartTimeMinutes = null, int? ExactStartTimeMinutes = null, int? StartTimeIncrementMinutes = null, bool? CountsAsPaidTime = null, bool? CountsAsContiguousWorkTime = null, int? MinimumLengthFromShiftStartMinutes = null, int? MinimumLengthFromShiftEndMinutes = null, string Id = null, bool? Delete = null, string ValidationId = null)
        {
            this.ActivityCodeId = ActivityCodeId;
            this.Description = Description;
            this.LengthMinutes = LengthMinutes;
            this.StartTimeIsRelativeToShiftStart = StartTimeIsRelativeToShiftStart;
            this.FlexibleStartTime = FlexibleStartTime;
            this.EarliestStartTimeMinutes = EarliestStartTimeMinutes;
            this.LatestStartTimeMinutes = LatestStartTimeMinutes;
            this.ExactStartTimeMinutes = ExactStartTimeMinutes;
            this.StartTimeIncrementMinutes = StartTimeIncrementMinutes;
            this.CountsAsPaidTime = CountsAsPaidTime;
            this.CountsAsContiguousWorkTime = CountsAsContiguousWorkTime;
            this.MinimumLengthFromShiftStartMinutes = MinimumLengthFromShiftStartMinutes;
            this.MinimumLengthFromShiftEndMinutes = MinimumLengthFromShiftEndMinutes;
            this.Id = Id;
            this.Delete = Delete;
            this.ValidationId = ValidationId;
            
        }
        


        /// <summary>
        /// ID of the activity code associated with this activity
        /// </summary>
        /// <value>ID of the activity code associated with this activity</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// Description of the activity
        /// </summary>
        /// <value>Description of the activity</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Length of the activity in minutes
        /// </summary>
        /// <value>Length of the activity in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// Whether the start time of the activity is relative to the start time of the shift it belongs to
        /// </summary>
        /// <value>Whether the start time of the activity is relative to the start time of the shift it belongs to</value>
        [DataMember(Name="startTimeIsRelativeToShiftStart", EmitDefaultValue=false)]
        public bool? StartTimeIsRelativeToShiftStart { get; set; }



        /// <summary>
        /// Whether the start time of the activity is flexible
        /// </summary>
        /// <value>Whether the start time of the activity is flexible</value>
        [DataMember(Name="flexibleStartTime", EmitDefaultValue=false)]
        public bool? FlexibleStartTime { get; set; }



        /// <summary>
        /// Earliest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == true
        /// </summary>
        /// <value>Earliest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == true</value>
        [DataMember(Name="earliestStartTimeMinutes", EmitDefaultValue=false)]
        public int? EarliestStartTimeMinutes { get; set; }



        /// <summary>
        /// Latest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == true
        /// </summary>
        /// <value>Latest activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == true</value>
        [DataMember(Name="latestStartTimeMinutes", EmitDefaultValue=false)]
        public int? LatestStartTimeMinutes { get; set; }



        /// <summary>
        /// Exact activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == false
        /// </summary>
        /// <value>Exact activity start in offset minutes relative to shift start time if startTimeIsRelativeToShiftStart == true else its based on midnight. Used if flexibleStartTime == false</value>
        [DataMember(Name="exactStartTimeMinutes", EmitDefaultValue=false)]
        public int? ExactStartTimeMinutes { get; set; }



        /// <summary>
        /// Increment in offset minutes that would contribute to different possible start times for the activity
        /// </summary>
        /// <value>Increment in offset minutes that would contribute to different possible start times for the activity</value>
        [DataMember(Name="startTimeIncrementMinutes", EmitDefaultValue=false)]
        public int? StartTimeIncrementMinutes { get; set; }



        /// <summary>
        /// Whether the activity is paid
        /// </summary>
        /// <value>Whether the activity is paid</value>
        [DataMember(Name="countsAsPaidTime", EmitDefaultValue=false)]
        public bool? CountsAsPaidTime { get; set; }



        /// <summary>
        /// Whether the activity duration is counted towards contiguous work time
        /// </summary>
        /// <value>Whether the activity duration is counted towards contiguous work time</value>
        [DataMember(Name="countsAsContiguousWorkTime", EmitDefaultValue=false)]
        public bool? CountsAsContiguousWorkTime { get; set; }



        /// <summary>
        /// The minimum duration between shift start and shift item (e.g., break or meal) start in minutes
        /// </summary>
        /// <value>The minimum duration between shift start and shift item (e.g., break or meal) start in minutes</value>
        [DataMember(Name="minimumLengthFromShiftStartMinutes", EmitDefaultValue=false)]
        public int? MinimumLengthFromShiftStartMinutes { get; set; }



        /// <summary>
        /// The minimum duration between shift item (e.g., break or meal) end and shift end in minutes
        /// </summary>
        /// <value>The minimum duration between shift item (e.g., break or meal) end and shift end in minutes</value>
        [DataMember(Name="minimumLengthFromShiftEndMinutes", EmitDefaultValue=false)]
        public int? MinimumLengthFromShiftEndMinutes { get; set; }



        /// <summary>
        /// ID of the activity. This is required only for the case of updating an existing activity
        /// </summary>
        /// <value>ID of the activity. This is required only for the case of updating an existing activity</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// If marked true for updating an existing activity, the activity will be permanently deleted
        /// </summary>
        /// <value>If marked true for updating an existing activity, the activity will be permanently deleted</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }



        /// <summary>
        /// ID of the activity in the context of work plan validation
        /// </summary>
        /// <value>ID of the activity in the context of work plan validation</value>
        [DataMember(Name="validationId", EmitDefaultValue=false)]
        public string ValidationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanActivity {\n");

            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  StartTimeIsRelativeToShiftStart: ").Append(StartTimeIsRelativeToShiftStart).Append("\n");
            sb.Append("  FlexibleStartTime: ").Append(FlexibleStartTime).Append("\n");
            sb.Append("  EarliestStartTimeMinutes: ").Append(EarliestStartTimeMinutes).Append("\n");
            sb.Append("  LatestStartTimeMinutes: ").Append(LatestStartTimeMinutes).Append("\n");
            sb.Append("  ExactStartTimeMinutes: ").Append(ExactStartTimeMinutes).Append("\n");
            sb.Append("  StartTimeIncrementMinutes: ").Append(StartTimeIncrementMinutes).Append("\n");
            sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
            sb.Append("  CountsAsContiguousWorkTime: ").Append(CountsAsContiguousWorkTime).Append("\n");
            sb.Append("  MinimumLengthFromShiftStartMinutes: ").Append(MinimumLengthFromShiftStartMinutes).Append("\n");
            sb.Append("  MinimumLengthFromShiftEndMinutes: ").Append(MinimumLengthFromShiftEndMinutes).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("  ValidationId: ").Append(ValidationId).Append("\n");
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
            return this.Equals(obj as WorkPlanActivity);
        }

        /// <summary>
        /// Returns true if WorkPlanActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanActivity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.StartTimeIsRelativeToShiftStart == other.StartTimeIsRelativeToShiftStart ||
                    this.StartTimeIsRelativeToShiftStart != null &&
                    this.StartTimeIsRelativeToShiftStart.Equals(other.StartTimeIsRelativeToShiftStart)
                ) &&
                (
                    this.FlexibleStartTime == other.FlexibleStartTime ||
                    this.FlexibleStartTime != null &&
                    this.FlexibleStartTime.Equals(other.FlexibleStartTime)
                ) &&
                (
                    this.EarliestStartTimeMinutes == other.EarliestStartTimeMinutes ||
                    this.EarliestStartTimeMinutes != null &&
                    this.EarliestStartTimeMinutes.Equals(other.EarliestStartTimeMinutes)
                ) &&
                (
                    this.LatestStartTimeMinutes == other.LatestStartTimeMinutes ||
                    this.LatestStartTimeMinutes != null &&
                    this.LatestStartTimeMinutes.Equals(other.LatestStartTimeMinutes)
                ) &&
                (
                    this.ExactStartTimeMinutes == other.ExactStartTimeMinutes ||
                    this.ExactStartTimeMinutes != null &&
                    this.ExactStartTimeMinutes.Equals(other.ExactStartTimeMinutes)
                ) &&
                (
                    this.StartTimeIncrementMinutes == other.StartTimeIncrementMinutes ||
                    this.StartTimeIncrementMinutes != null &&
                    this.StartTimeIncrementMinutes.Equals(other.StartTimeIncrementMinutes)
                ) &&
                (
                    this.CountsAsPaidTime == other.CountsAsPaidTime ||
                    this.CountsAsPaidTime != null &&
                    this.CountsAsPaidTime.Equals(other.CountsAsPaidTime)
                ) &&
                (
                    this.CountsAsContiguousWorkTime == other.CountsAsContiguousWorkTime ||
                    this.CountsAsContiguousWorkTime != null &&
                    this.CountsAsContiguousWorkTime.Equals(other.CountsAsContiguousWorkTime)
                ) &&
                (
                    this.MinimumLengthFromShiftStartMinutes == other.MinimumLengthFromShiftStartMinutes ||
                    this.MinimumLengthFromShiftStartMinutes != null &&
                    this.MinimumLengthFromShiftStartMinutes.Equals(other.MinimumLengthFromShiftStartMinutes)
                ) &&
                (
                    this.MinimumLengthFromShiftEndMinutes == other.MinimumLengthFromShiftEndMinutes ||
                    this.MinimumLengthFromShiftEndMinutes != null &&
                    this.MinimumLengthFromShiftEndMinutes.Equals(other.MinimumLengthFromShiftEndMinutes)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Delete == other.Delete ||
                    this.Delete != null &&
                    this.Delete.Equals(other.Delete)
                ) &&
                (
                    this.ValidationId == other.ValidationId ||
                    this.ValidationId != null &&
                    this.ValidationId.Equals(other.ValidationId)
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
                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.StartTimeIsRelativeToShiftStart != null)
                    hash = hash * 59 + this.StartTimeIsRelativeToShiftStart.GetHashCode();

                if (this.FlexibleStartTime != null)
                    hash = hash * 59 + this.FlexibleStartTime.GetHashCode();

                if (this.EarliestStartTimeMinutes != null)
                    hash = hash * 59 + this.EarliestStartTimeMinutes.GetHashCode();

                if (this.LatestStartTimeMinutes != null)
                    hash = hash * 59 + this.LatestStartTimeMinutes.GetHashCode();

                if (this.ExactStartTimeMinutes != null)
                    hash = hash * 59 + this.ExactStartTimeMinutes.GetHashCode();

                if (this.StartTimeIncrementMinutes != null)
                    hash = hash * 59 + this.StartTimeIncrementMinutes.GetHashCode();

                if (this.CountsAsPaidTime != null)
                    hash = hash * 59 + this.CountsAsPaidTime.GetHashCode();

                if (this.CountsAsContiguousWorkTime != null)
                    hash = hash * 59 + this.CountsAsContiguousWorkTime.GetHashCode();

                if (this.MinimumLengthFromShiftStartMinutes != null)
                    hash = hash * 59 + this.MinimumLengthFromShiftStartMinutes.GetHashCode();

                if (this.MinimumLengthFromShiftEndMinutes != null)
                    hash = hash * 59 + this.MinimumLengthFromShiftEndMinutes.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();

                if (this.ValidationId != null)
                    hash = hash * 59 + this.ValidationId.GetHashCode();

                return hash;
            }
        }
    }

}
