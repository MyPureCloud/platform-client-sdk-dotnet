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
    /// AgentWorkPlanShift
    /// </summary>
    [DataContract]
    public partial class AgentWorkPlanShift :  IEquatable<AgentWorkPlanShift>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkPlanShift" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentWorkPlanShift() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkPlanShift" /> class.
        /// </summary>
        /// <param name="Days">Days of the week applicable for this shift (required).</param>
        /// <param name="FlexibleStartTime">Whether the start time of the shift is flexible (required).</param>
        /// <param name="ExactStartTimeMinutesFromMidnight">Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == false (required).</param>
        /// <param name="EarliestStartTimeMinutesFromMidnight">Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == true (required).</param>
        /// <param name="LatestStartTimeMinutesFromMidnight">Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime == true (required).</param>
        /// <param name="EarliestStopTimeMinutesFromMidnight">This is the earliest time a shift can end (required).</param>
        /// <param name="ConstrainLatestStopTime">Whether the latest stop time constraint for the shift is enabled (required).</param>
        /// <param name="LatestStopTimeMinutesFromMidnight">Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime == true (required).</param>
        /// <param name="FlexiblePaidTime">Whether the paid time setting for the shift is flexible (required).</param>
        /// <param name="ExactPaidTimeMinutes">Exact paid time in minutes configured for the shift. Used if flexiblePaidTime == false (required).</param>
        /// <param name="MinimumPaidTimeMinutes">Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime == true (required).</param>
        /// <param name="MaximumPaidTimeMinutes">Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime == true (required).</param>
        /// <param name="Activities">Activities configured for this shift (required).</param>
        public AgentWorkPlanShift(SetWrapperDayOfWeek Days = null, bool? FlexibleStartTime = null, int? ExactStartTimeMinutesFromMidnight = null, int? EarliestStartTimeMinutesFromMidnight = null, int? LatestStartTimeMinutesFromMidnight = null, int? EarliestStopTimeMinutesFromMidnight = null, bool? ConstrainLatestStopTime = null, int? LatestStopTimeMinutesFromMidnight = null, bool? FlexiblePaidTime = null, int? ExactPaidTimeMinutes = null, int? MinimumPaidTimeMinutes = null, int? MaximumPaidTimeMinutes = null, List<AgentWorkPlanActivity> Activities = null)
        {
            this.Days = Days;
            this.FlexibleStartTime = FlexibleStartTime;
            this.ExactStartTimeMinutesFromMidnight = ExactStartTimeMinutesFromMidnight;
            this.EarliestStartTimeMinutesFromMidnight = EarliestStartTimeMinutesFromMidnight;
            this.LatestStartTimeMinutesFromMidnight = LatestStartTimeMinutesFromMidnight;
            this.EarliestStopTimeMinutesFromMidnight = EarliestStopTimeMinutesFromMidnight;
            this.ConstrainLatestStopTime = ConstrainLatestStopTime;
            this.LatestStopTimeMinutesFromMidnight = LatestStopTimeMinutesFromMidnight;
            this.FlexiblePaidTime = FlexiblePaidTime;
            this.ExactPaidTimeMinutes = ExactPaidTimeMinutes;
            this.MinimumPaidTimeMinutes = MinimumPaidTimeMinutes;
            this.MaximumPaidTimeMinutes = MaximumPaidTimeMinutes;
            this.Activities = Activities;
            
        }
        


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
        /// This is the earliest time a shift can end
        /// </summary>
        /// <value>This is the earliest time a shift can end</value>
        [DataMember(Name="earliestStopTimeMinutesFromMidnight", EmitDefaultValue=false)]
        public int? EarliestStopTimeMinutesFromMidnight { get; set; }



        /// <summary>
        /// Whether the latest stop time constraint for the shift is enabled
        /// </summary>
        /// <value>Whether the latest stop time constraint for the shift is enabled</value>
        [DataMember(Name="constrainLatestStopTime", EmitDefaultValue=false)]
        public bool? ConstrainLatestStopTime { get; set; }



        /// <summary>
        /// Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime == true
        /// </summary>
        /// <value>Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime == true</value>
        [DataMember(Name="latestStopTimeMinutesFromMidnight", EmitDefaultValue=false)]
        public int? LatestStopTimeMinutesFromMidnight { get; set; }



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
        /// Activities configured for this shift
        /// </summary>
        /// <value>Activities configured for this shift</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<AgentWorkPlanActivity> Activities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentWorkPlanShift {\n");

            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  FlexibleStartTime: ").Append(FlexibleStartTime).Append("\n");
            sb.Append("  ExactStartTimeMinutesFromMidnight: ").Append(ExactStartTimeMinutesFromMidnight).Append("\n");
            sb.Append("  EarliestStartTimeMinutesFromMidnight: ").Append(EarliestStartTimeMinutesFromMidnight).Append("\n");
            sb.Append("  LatestStartTimeMinutesFromMidnight: ").Append(LatestStartTimeMinutesFromMidnight).Append("\n");
            sb.Append("  EarliestStopTimeMinutesFromMidnight: ").Append(EarliestStopTimeMinutesFromMidnight).Append("\n");
            sb.Append("  ConstrainLatestStopTime: ").Append(ConstrainLatestStopTime).Append("\n");
            sb.Append("  LatestStopTimeMinutesFromMidnight: ").Append(LatestStopTimeMinutesFromMidnight).Append("\n");
            sb.Append("  FlexiblePaidTime: ").Append(FlexiblePaidTime).Append("\n");
            sb.Append("  ExactPaidTimeMinutes: ").Append(ExactPaidTimeMinutes).Append("\n");
            sb.Append("  MinimumPaidTimeMinutes: ").Append(MinimumPaidTimeMinutes).Append("\n");
            sb.Append("  MaximumPaidTimeMinutes: ").Append(MaximumPaidTimeMinutes).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
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
            return this.Equals(obj as AgentWorkPlanShift);
        }

        /// <summary>
        /// Returns true if AgentWorkPlanShift instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentWorkPlanShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentWorkPlanShift other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.EarliestStopTimeMinutesFromMidnight == other.EarliestStopTimeMinutesFromMidnight ||
                    this.EarliestStopTimeMinutesFromMidnight != null &&
                    this.EarliestStopTimeMinutesFromMidnight.Equals(other.EarliestStopTimeMinutesFromMidnight)
                ) &&
                (
                    this.ConstrainLatestStopTime == other.ConstrainLatestStopTime ||
                    this.ConstrainLatestStopTime != null &&
                    this.ConstrainLatestStopTime.Equals(other.ConstrainLatestStopTime)
                ) &&
                (
                    this.LatestStopTimeMinutesFromMidnight == other.LatestStopTimeMinutesFromMidnight ||
                    this.LatestStopTimeMinutesFromMidnight != null &&
                    this.LatestStopTimeMinutesFromMidnight.Equals(other.LatestStopTimeMinutesFromMidnight)
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
                    this.Activities == other.Activities ||
                    this.Activities != null &&
                    this.Activities.SequenceEqual(other.Activities)
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

                if (this.EarliestStopTimeMinutesFromMidnight != null)
                    hash = hash * 59 + this.EarliestStopTimeMinutesFromMidnight.GetHashCode();

                if (this.ConstrainLatestStopTime != null)
                    hash = hash * 59 + this.ConstrainLatestStopTime.GetHashCode();

                if (this.LatestStopTimeMinutesFromMidnight != null)
                    hash = hash * 59 + this.LatestStopTimeMinutesFromMidnight.GetHashCode();

                if (this.FlexiblePaidTime != null)
                    hash = hash * 59 + this.FlexiblePaidTime.GetHashCode();

                if (this.ExactPaidTimeMinutes != null)
                    hash = hash * 59 + this.ExactPaidTimeMinutes.GetHashCode();

                if (this.MinimumPaidTimeMinutes != null)
                    hash = hash * 59 + this.MinimumPaidTimeMinutes.GetHashCode();

                if (this.MaximumPaidTimeMinutes != null)
                    hash = hash * 59 + this.MaximumPaidTimeMinutes.GetHashCode();

                if (this.Activities != null)
                    hash = hash * 59 + this.Activities.GetHashCode();

                return hash;
            }
        }
    }

}
