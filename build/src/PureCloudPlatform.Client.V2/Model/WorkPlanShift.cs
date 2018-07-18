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
    /// Shift in a work plan
    /// </summary>
    [DataContract]
    public partial class WorkPlanShift :  IEquatable<WorkPlanShift>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanShift" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkPlanShift() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanShift" /> class.
        /// </summary>
        /// <param name="Name">Name of the shift (required).</param>
        /// <param name="Days">Days of the week applicable for this shift.</param>
        /// <param name="FlexibleStartTime">Whether the start time of the shift is flexible.</param>
        /// <param name="ExactStartTimeMinutesFromMidnight">Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == false.</param>
        /// <param name="EarliestStartTimeMinutesFromMidnight">Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == true.</param>
        /// <param name="LatestStartTimeMinutesFromMidnight">Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == true.</param>
        /// <param name="ConstrainStopTime">Whether the latest stop time constraint for the shift is enabled.</param>
        /// <param name="LatestStopTimeMinutesFromMidnight">Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime == true.</param>
        /// <param name="StartIncrementMinutes">Increment in offset minutes that would contribute to different possible start times for the shift. Used if flexibleStartTime == true.</param>
        /// <param name="FlexiblePaidTime">Whether the paid time setting for the shift is flexible.</param>
        /// <param name="ExactPaidTimeMinutes">Exact paid time in minutes configured for the shift. Used if flexiblePaidTime == false.</param>
        /// <param name="MinimumPaidTimeMinutes">Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime == true.</param>
        /// <param name="MaximumPaidTimeMinutes">Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime == true.</param>
        /// <param name="ConstrainContiguousWorkTime">Whether the contiguous time constraint for the shift is enabled.</param>
        /// <param name="MinimumContiguousWorkTimeMinutes">Minimum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime == true.</param>
        /// <param name="MaximumContiguousWorkTimeMinutes">Maximum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime == true.</param>
        /// <param name="Activities">Activities configured for this shift.</param>
        /// <param name="Id">ID of the shift. This is required only for the case of updating an existing shift.</param>
        /// <param name="Delete">If marked true for updating an existing shift, the shift will be permanently deleted.</param>
        public WorkPlanShift(string Name = null, SetWrapperDayOfWeek Days = null, bool? FlexibleStartTime = null, int? ExactStartTimeMinutesFromMidnight = null, int? EarliestStartTimeMinutesFromMidnight = null, int? LatestStartTimeMinutesFromMidnight = null, bool? ConstrainStopTime = null, int? LatestStopTimeMinutesFromMidnight = null, int? StartIncrementMinutes = null, bool? FlexiblePaidTime = null, int? ExactPaidTimeMinutes = null, int? MinimumPaidTimeMinutes = null, int? MaximumPaidTimeMinutes = null, bool? ConstrainContiguousWorkTime = null, int? MinimumContiguousWorkTimeMinutes = null, int? MaximumContiguousWorkTimeMinutes = null, List<WorkPlanActivity> Activities = null, string Id = null, bool? Delete = null)
        {
            this.Name = Name;
            this.Days = Days;
            this.FlexibleStartTime = FlexibleStartTime;
            this.ExactStartTimeMinutesFromMidnight = ExactStartTimeMinutesFromMidnight;
            this.EarliestStartTimeMinutesFromMidnight = EarliestStartTimeMinutesFromMidnight;
            this.LatestStartTimeMinutesFromMidnight = LatestStartTimeMinutesFromMidnight;
            this.ConstrainStopTime = ConstrainStopTime;
            this.LatestStopTimeMinutesFromMidnight = LatestStopTimeMinutesFromMidnight;
            this.StartIncrementMinutes = StartIncrementMinutes;
            this.FlexiblePaidTime = FlexiblePaidTime;
            this.ExactPaidTimeMinutes = ExactPaidTimeMinutes;
            this.MinimumPaidTimeMinutes = MinimumPaidTimeMinutes;
            this.MaximumPaidTimeMinutes = MaximumPaidTimeMinutes;
            this.ConstrainContiguousWorkTime = ConstrainContiguousWorkTime;
            this.MinimumContiguousWorkTimeMinutes = MinimumContiguousWorkTimeMinutes;
            this.MaximumContiguousWorkTimeMinutes = MaximumContiguousWorkTimeMinutes;
            this.Activities = Activities;
            this.Id = Id;
            this.Delete = Delete;
            
        }
        
        
        
        /// <summary>
        /// Name of the shift
        /// </summary>
        /// <value>Name of the shift</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Days of the week applicable for this shift
        /// </summary>
        /// <value>Days of the week applicable for this shift</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public SetWrapperDayOfWeek Days { get; set; }
        
        
        
        /// <summary>
        /// Whether the start time of the shift is flexible
        /// </summary>
        /// <value>Whether the start time of the shift is flexible</value>
        [DataMember(Name="flexibleStartTime", EmitDefaultValue=false)]
        public bool? FlexibleStartTime { get; set; }
        
        
        
        /// <summary>
        /// Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == false
        /// </summary>
        /// <value>Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == false</value>
        [DataMember(Name="exactStartTimeMinutesFromMidnight", EmitDefaultValue=false)]
        public int? ExactStartTimeMinutesFromMidnight { get; set; }
        
        
        
        /// <summary>
        /// Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == true
        /// </summary>
        /// <value>Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == true</value>
        [DataMember(Name="earliestStartTimeMinutesFromMidnight", EmitDefaultValue=false)]
        public int? EarliestStartTimeMinutesFromMidnight { get; set; }
        
        
        
        /// <summary>
        /// Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == true
        /// </summary>
        /// <value>Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == true</value>
        [DataMember(Name="latestStartTimeMinutesFromMidnight", EmitDefaultValue=false)]
        public int? LatestStartTimeMinutesFromMidnight { get; set; }
        
        
        
        /// <summary>
        /// Whether the latest stop time constraint for the shift is enabled
        /// </summary>
        /// <value>Whether the latest stop time constraint for the shift is enabled</value>
        [DataMember(Name="constrainStopTime", EmitDefaultValue=false)]
        public bool? ConstrainStopTime { get; set; }
        
        
        
        /// <summary>
        /// Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime == true
        /// </summary>
        /// <value>Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime == true</value>
        [DataMember(Name="latestStopTimeMinutesFromMidnight", EmitDefaultValue=false)]
        public int? LatestStopTimeMinutesFromMidnight { get; set; }
        
        
        
        /// <summary>
        /// Increment in offset minutes that would contribute to different possible start times for the shift. Used if flexibleStartTime == true
        /// </summary>
        /// <value>Increment in offset minutes that would contribute to different possible start times for the shift. Used if flexibleStartTime == true</value>
        [DataMember(Name="startIncrementMinutes", EmitDefaultValue=false)]
        public int? StartIncrementMinutes { get; set; }
        
        
        
        /// <summary>
        /// Whether the paid time setting for the shift is flexible
        /// </summary>
        /// <value>Whether the paid time setting for the shift is flexible</value>
        [DataMember(Name="flexiblePaidTime", EmitDefaultValue=false)]
        public bool? FlexiblePaidTime { get; set; }
        
        
        
        /// <summary>
        /// Exact paid time in minutes configured for the shift. Used if flexiblePaidTime == false
        /// </summary>
        /// <value>Exact paid time in minutes configured for the shift. Used if flexiblePaidTime == false</value>
        [DataMember(Name="exactPaidTimeMinutes", EmitDefaultValue=false)]
        public int? ExactPaidTimeMinutes { get; set; }
        
        
        
        /// <summary>
        /// Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime == true
        /// </summary>
        /// <value>Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime == true</value>
        [DataMember(Name="minimumPaidTimeMinutes", EmitDefaultValue=false)]
        public int? MinimumPaidTimeMinutes { get; set; }
        
        
        
        /// <summary>
        /// Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime == true
        /// </summary>
        /// <value>Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime == true</value>
        [DataMember(Name="maximumPaidTimeMinutes", EmitDefaultValue=false)]
        public int? MaximumPaidTimeMinutes { get; set; }
        
        
        
        /// <summary>
        /// Whether the contiguous time constraint for the shift is enabled
        /// </summary>
        /// <value>Whether the contiguous time constraint for the shift is enabled</value>
        [DataMember(Name="constrainContiguousWorkTime", EmitDefaultValue=false)]
        public bool? ConstrainContiguousWorkTime { get; set; }
        
        
        
        /// <summary>
        /// Minimum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime == true
        /// </summary>
        /// <value>Minimum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime == true</value>
        [DataMember(Name="minimumContiguousWorkTimeMinutes", EmitDefaultValue=false)]
        public int? MinimumContiguousWorkTimeMinutes { get; set; }
        
        
        
        /// <summary>
        /// Maximum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime == true
        /// </summary>
        /// <value>Maximum contiguous time in minutes configured for the shift. Used if constrainContiguousWorkTime == true</value>
        [DataMember(Name="maximumContiguousWorkTimeMinutes", EmitDefaultValue=false)]
        public int? MaximumContiguousWorkTimeMinutes { get; set; }
        
        
        
        /// <summary>
        /// Activities configured for this shift
        /// </summary>
        /// <value>Activities configured for this shift</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<WorkPlanActivity> Activities { get; set; }
        
        
        
        /// <summary>
        /// ID of the shift. This is required only for the case of updating an existing shift
        /// </summary>
        /// <value>ID of the shift. This is required only for the case of updating an existing shift</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// If marked true for updating an existing shift, the shift will be permanently deleted
        /// </summary>
        /// <value>If marked true for updating an existing shift, the shift will be permanently deleted</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanShift {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  FlexibleStartTime: ").Append(FlexibleStartTime).Append("\n");
            sb.Append("  ExactStartTimeMinutesFromMidnight: ").Append(ExactStartTimeMinutesFromMidnight).Append("\n");
            sb.Append("  EarliestStartTimeMinutesFromMidnight: ").Append(EarliestStartTimeMinutesFromMidnight).Append("\n");
            sb.Append("  LatestStartTimeMinutesFromMidnight: ").Append(LatestStartTimeMinutesFromMidnight).Append("\n");
            sb.Append("  ConstrainStopTime: ").Append(ConstrainStopTime).Append("\n");
            sb.Append("  LatestStopTimeMinutesFromMidnight: ").Append(LatestStopTimeMinutesFromMidnight).Append("\n");
            sb.Append("  StartIncrementMinutes: ").Append(StartIncrementMinutes).Append("\n");
            sb.Append("  FlexiblePaidTime: ").Append(FlexiblePaidTime).Append("\n");
            sb.Append("  ExactPaidTimeMinutes: ").Append(ExactPaidTimeMinutes).Append("\n");
            sb.Append("  MinimumPaidTimeMinutes: ").Append(MinimumPaidTimeMinutes).Append("\n");
            sb.Append("  MaximumPaidTimeMinutes: ").Append(MaximumPaidTimeMinutes).Append("\n");
            sb.Append("  ConstrainContiguousWorkTime: ").Append(ConstrainContiguousWorkTime).Append("\n");
            sb.Append("  MinimumContiguousWorkTimeMinutes: ").Append(MinimumContiguousWorkTimeMinutes).Append("\n");
            sb.Append("  MaximumContiguousWorkTimeMinutes: ").Append(MaximumContiguousWorkTimeMinutes).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as WorkPlanShift);
        }

        /// <summary>
        /// Returns true if WorkPlanShift instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanShift other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Days == other.Days ||
                    this.Days != null &&
                    this.Days.Equals(other.Days)
                ) &&
                (
                    this.FlexibleStartTime == other.FlexibleStartTime ||
                    this.FlexibleStartTime != null &&
                    this.FlexibleStartTime.Equals(other.FlexibleStartTime)
                ) &&
                (
                    this.ExactStartTimeMinutesFromMidnight == other.ExactStartTimeMinutesFromMidnight ||
                    this.ExactStartTimeMinutesFromMidnight != null &&
                    this.ExactStartTimeMinutesFromMidnight.Equals(other.ExactStartTimeMinutesFromMidnight)
                ) &&
                (
                    this.EarliestStartTimeMinutesFromMidnight == other.EarliestStartTimeMinutesFromMidnight ||
                    this.EarliestStartTimeMinutesFromMidnight != null &&
                    this.EarliestStartTimeMinutesFromMidnight.Equals(other.EarliestStartTimeMinutesFromMidnight)
                ) &&
                (
                    this.LatestStartTimeMinutesFromMidnight == other.LatestStartTimeMinutesFromMidnight ||
                    this.LatestStartTimeMinutesFromMidnight != null &&
                    this.LatestStartTimeMinutesFromMidnight.Equals(other.LatestStartTimeMinutesFromMidnight)
                ) &&
                (
                    this.ConstrainStopTime == other.ConstrainStopTime ||
                    this.ConstrainStopTime != null &&
                    this.ConstrainStopTime.Equals(other.ConstrainStopTime)
                ) &&
                (
                    this.LatestStopTimeMinutesFromMidnight == other.LatestStopTimeMinutesFromMidnight ||
                    this.LatestStopTimeMinutesFromMidnight != null &&
                    this.LatestStopTimeMinutesFromMidnight.Equals(other.LatestStopTimeMinutesFromMidnight)
                ) &&
                (
                    this.StartIncrementMinutes == other.StartIncrementMinutes ||
                    this.StartIncrementMinutes != null &&
                    this.StartIncrementMinutes.Equals(other.StartIncrementMinutes)
                ) &&
                (
                    this.FlexiblePaidTime == other.FlexiblePaidTime ||
                    this.FlexiblePaidTime != null &&
                    this.FlexiblePaidTime.Equals(other.FlexiblePaidTime)
                ) &&
                (
                    this.ExactPaidTimeMinutes == other.ExactPaidTimeMinutes ||
                    this.ExactPaidTimeMinutes != null &&
                    this.ExactPaidTimeMinutes.Equals(other.ExactPaidTimeMinutes)
                ) &&
                (
                    this.MinimumPaidTimeMinutes == other.MinimumPaidTimeMinutes ||
                    this.MinimumPaidTimeMinutes != null &&
                    this.MinimumPaidTimeMinutes.Equals(other.MinimumPaidTimeMinutes)
                ) &&
                (
                    this.MaximumPaidTimeMinutes == other.MaximumPaidTimeMinutes ||
                    this.MaximumPaidTimeMinutes != null &&
                    this.MaximumPaidTimeMinutes.Equals(other.MaximumPaidTimeMinutes)
                ) &&
                (
                    this.ConstrainContiguousWorkTime == other.ConstrainContiguousWorkTime ||
                    this.ConstrainContiguousWorkTime != null &&
                    this.ConstrainContiguousWorkTime.Equals(other.ConstrainContiguousWorkTime)
                ) &&
                (
                    this.MinimumContiguousWorkTimeMinutes == other.MinimumContiguousWorkTimeMinutes ||
                    this.MinimumContiguousWorkTimeMinutes != null &&
                    this.MinimumContiguousWorkTimeMinutes.Equals(other.MinimumContiguousWorkTimeMinutes)
                ) &&
                (
                    this.MaximumContiguousWorkTimeMinutes == other.MaximumContiguousWorkTimeMinutes ||
                    this.MaximumContiguousWorkTimeMinutes != null &&
                    this.MaximumContiguousWorkTimeMinutes.Equals(other.MaximumContiguousWorkTimeMinutes)
                ) &&
                (
                    this.Activities == other.Activities ||
                    this.Activities != null &&
                    this.Activities.SequenceEqual(other.Activities)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Days != null)
                    hash = hash * 59 + this.Days.GetHashCode();
                
                if (this.FlexibleStartTime != null)
                    hash = hash * 59 + this.FlexibleStartTime.GetHashCode();
                
                if (this.ExactStartTimeMinutesFromMidnight != null)
                    hash = hash * 59 + this.ExactStartTimeMinutesFromMidnight.GetHashCode();
                
                if (this.EarliestStartTimeMinutesFromMidnight != null)
                    hash = hash * 59 + this.EarliestStartTimeMinutesFromMidnight.GetHashCode();
                
                if (this.LatestStartTimeMinutesFromMidnight != null)
                    hash = hash * 59 + this.LatestStartTimeMinutesFromMidnight.GetHashCode();
                
                if (this.ConstrainStopTime != null)
                    hash = hash * 59 + this.ConstrainStopTime.GetHashCode();
                
                if (this.LatestStopTimeMinutesFromMidnight != null)
                    hash = hash * 59 + this.LatestStopTimeMinutesFromMidnight.GetHashCode();
                
                if (this.StartIncrementMinutes != null)
                    hash = hash * 59 + this.StartIncrementMinutes.GetHashCode();
                
                if (this.FlexiblePaidTime != null)
                    hash = hash * 59 + this.FlexiblePaidTime.GetHashCode();
                
                if (this.ExactPaidTimeMinutes != null)
                    hash = hash * 59 + this.ExactPaidTimeMinutes.GetHashCode();
                
                if (this.MinimumPaidTimeMinutes != null)
                    hash = hash * 59 + this.MinimumPaidTimeMinutes.GetHashCode();
                
                if (this.MaximumPaidTimeMinutes != null)
                    hash = hash * 59 + this.MaximumPaidTimeMinutes.GetHashCode();
                
                if (this.ConstrainContiguousWorkTime != null)
                    hash = hash * 59 + this.ConstrainContiguousWorkTime.GetHashCode();
                
                if (this.MinimumContiguousWorkTimeMinutes != null)
                    hash = hash * 59 + this.MinimumContiguousWorkTimeMinutes.GetHashCode();
                
                if (this.MaximumContiguousWorkTimeMinutes != null)
                    hash = hash * 59 + this.MaximumContiguousWorkTimeMinutes.GetHashCode();
                
                if (this.Activities != null)
                    hash = hash * 59 + this.Activities.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();
                
                return hash;
            }
        }
    }

}
