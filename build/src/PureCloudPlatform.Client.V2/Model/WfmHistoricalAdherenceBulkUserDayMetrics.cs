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
    /// WfmHistoricalAdherenceBulkUserDayMetrics
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceBulkUserDayMetrics :  IEquatable<WfmHistoricalAdherenceBulkUserDayMetrics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkUserDayMetrics" /> class.
        /// </summary>
        /// <param name="DayStartOffsetSeconds">Start of day offset in seconds relative to query start time.</param>
        /// <param name="AdherenceScheduleSeconds">Duration of schedule in seconds included for adherence percentage calculation.</param>
        /// <param name="ConformanceScheduleSeconds">Total scheduled duration in seconds for OnQueue activities.</param>
        /// <param name="ConformanceActualSeconds">Total actually worked duration in seconds for OnQueue activities.</param>
        /// <param name="ExceptionCount">Total number of adherence exceptions for this user.</param>
        /// <param name="ExceptionDurationSeconds">Total duration in seconds of adherence exceptions for this user.</param>
        /// <param name="ImpactSeconds">The impact duration in seconds of current adherence state for this user.</param>
        /// <param name="ScheduleLengthSeconds">Total duration in seconds for all scheduled activities.</param>
        /// <param name="ActualLengthSeconds">Total duration in seconds for all actually worked activities.</param>
        /// <param name="AdherencePercentage">Total adherence percentage for this user, in the scale of 0 - 100.</param>
        /// <param name="ConformancePercentage">Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period..</param>
        public WfmHistoricalAdherenceBulkUserDayMetrics(int? DayStartOffsetSeconds = null, int? AdherenceScheduleSeconds = null, int? ConformanceScheduleSeconds = null, int? ConformanceActualSeconds = null, int? ExceptionCount = null, int? ExceptionDurationSeconds = null, int? ImpactSeconds = null, int? ScheduleLengthSeconds = null, int? ActualLengthSeconds = null, double? AdherencePercentage = null, double? ConformancePercentage = null)
        {
            this.DayStartOffsetSeconds = DayStartOffsetSeconds;
            this.AdherenceScheduleSeconds = AdherenceScheduleSeconds;
            this.ConformanceScheduleSeconds = ConformanceScheduleSeconds;
            this.ConformanceActualSeconds = ConformanceActualSeconds;
            this.ExceptionCount = ExceptionCount;
            this.ExceptionDurationSeconds = ExceptionDurationSeconds;
            this.ImpactSeconds = ImpactSeconds;
            this.ScheduleLengthSeconds = ScheduleLengthSeconds;
            this.ActualLengthSeconds = ActualLengthSeconds;
            this.AdherencePercentage = AdherencePercentage;
            this.ConformancePercentage = ConformancePercentage;
            
        }
        


        /// <summary>
        /// Start of day offset in seconds relative to query start time
        /// </summary>
        /// <value>Start of day offset in seconds relative to query start time</value>
        [DataMember(Name="dayStartOffsetSeconds", EmitDefaultValue=false)]
        public int? DayStartOffsetSeconds { get; set; }



        /// <summary>
        /// Duration of schedule in seconds included for adherence percentage calculation
        /// </summary>
        /// <value>Duration of schedule in seconds included for adherence percentage calculation</value>
        [DataMember(Name="adherenceScheduleSeconds", EmitDefaultValue=false)]
        public int? AdherenceScheduleSeconds { get; set; }



        /// <summary>
        /// Total scheduled duration in seconds for OnQueue activities
        /// </summary>
        /// <value>Total scheduled duration in seconds for OnQueue activities</value>
        [DataMember(Name="conformanceScheduleSeconds", EmitDefaultValue=false)]
        public int? ConformanceScheduleSeconds { get; set; }



        /// <summary>
        /// Total actually worked duration in seconds for OnQueue activities
        /// </summary>
        /// <value>Total actually worked duration in seconds for OnQueue activities</value>
        [DataMember(Name="conformanceActualSeconds", EmitDefaultValue=false)]
        public int? ConformanceActualSeconds { get; set; }



        /// <summary>
        /// Total number of adherence exceptions for this user
        /// </summary>
        /// <value>Total number of adherence exceptions for this user</value>
        [DataMember(Name="exceptionCount", EmitDefaultValue=false)]
        public int? ExceptionCount { get; set; }



        /// <summary>
        /// Total duration in seconds of adherence exceptions for this user
        /// </summary>
        /// <value>Total duration in seconds of adherence exceptions for this user</value>
        [DataMember(Name="exceptionDurationSeconds", EmitDefaultValue=false)]
        public int? ExceptionDurationSeconds { get; set; }



        /// <summary>
        /// The impact duration in seconds of current adherence state for this user
        /// </summary>
        /// <value>The impact duration in seconds of current adherence state for this user</value>
        [DataMember(Name="impactSeconds", EmitDefaultValue=false)]
        public int? ImpactSeconds { get; set; }



        /// <summary>
        /// Total duration in seconds for all scheduled activities
        /// </summary>
        /// <value>Total duration in seconds for all scheduled activities</value>
        [DataMember(Name="scheduleLengthSeconds", EmitDefaultValue=false)]
        public int? ScheduleLengthSeconds { get; set; }



        /// <summary>
        /// Total duration in seconds for all actually worked activities
        /// </summary>
        /// <value>Total duration in seconds for all actually worked activities</value>
        [DataMember(Name="actualLengthSeconds", EmitDefaultValue=false)]
        public int? ActualLengthSeconds { get; set; }



        /// <summary>
        /// Total adherence percentage for this user, in the scale of 0 - 100
        /// </summary>
        /// <value>Total adherence percentage for this user, in the scale of 0 - 100</value>
        [DataMember(Name="adherencePercentage", EmitDefaultValue=false)]
        public double? AdherencePercentage { get; set; }



        /// <summary>
        /// Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.
        /// </summary>
        /// <value>Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.</value>
        [DataMember(Name="conformancePercentage", EmitDefaultValue=false)]
        public double? ConformancePercentage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceBulkUserDayMetrics {\n");

            sb.Append("  DayStartOffsetSeconds: ").Append(DayStartOffsetSeconds).Append("\n");
            sb.Append("  AdherenceScheduleSeconds: ").Append(AdherenceScheduleSeconds).Append("\n");
            sb.Append("  ConformanceScheduleSeconds: ").Append(ConformanceScheduleSeconds).Append("\n");
            sb.Append("  ConformanceActualSeconds: ").Append(ConformanceActualSeconds).Append("\n");
            sb.Append("  ExceptionCount: ").Append(ExceptionCount).Append("\n");
            sb.Append("  ExceptionDurationSeconds: ").Append(ExceptionDurationSeconds).Append("\n");
            sb.Append("  ImpactSeconds: ").Append(ImpactSeconds).Append("\n");
            sb.Append("  ScheduleLengthSeconds: ").Append(ScheduleLengthSeconds).Append("\n");
            sb.Append("  ActualLengthSeconds: ").Append(ActualLengthSeconds).Append("\n");
            sb.Append("  AdherencePercentage: ").Append(AdherencePercentage).Append("\n");
            sb.Append("  ConformancePercentage: ").Append(ConformancePercentage).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceBulkUserDayMetrics);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceBulkUserDayMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceBulkUserDayMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceBulkUserDayMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DayStartOffsetSeconds == other.DayStartOffsetSeconds ||
                    this.DayStartOffsetSeconds != null &&
                    this.DayStartOffsetSeconds.Equals(other.DayStartOffsetSeconds)
                ) &&
                (
                    this.AdherenceScheduleSeconds == other.AdherenceScheduleSeconds ||
                    this.AdherenceScheduleSeconds != null &&
                    this.AdherenceScheduleSeconds.Equals(other.AdherenceScheduleSeconds)
                ) &&
                (
                    this.ConformanceScheduleSeconds == other.ConformanceScheduleSeconds ||
                    this.ConformanceScheduleSeconds != null &&
                    this.ConformanceScheduleSeconds.Equals(other.ConformanceScheduleSeconds)
                ) &&
                (
                    this.ConformanceActualSeconds == other.ConformanceActualSeconds ||
                    this.ConformanceActualSeconds != null &&
                    this.ConformanceActualSeconds.Equals(other.ConformanceActualSeconds)
                ) &&
                (
                    this.ExceptionCount == other.ExceptionCount ||
                    this.ExceptionCount != null &&
                    this.ExceptionCount.Equals(other.ExceptionCount)
                ) &&
                (
                    this.ExceptionDurationSeconds == other.ExceptionDurationSeconds ||
                    this.ExceptionDurationSeconds != null &&
                    this.ExceptionDurationSeconds.Equals(other.ExceptionDurationSeconds)
                ) &&
                (
                    this.ImpactSeconds == other.ImpactSeconds ||
                    this.ImpactSeconds != null &&
                    this.ImpactSeconds.Equals(other.ImpactSeconds)
                ) &&
                (
                    this.ScheduleLengthSeconds == other.ScheduleLengthSeconds ||
                    this.ScheduleLengthSeconds != null &&
                    this.ScheduleLengthSeconds.Equals(other.ScheduleLengthSeconds)
                ) &&
                (
                    this.ActualLengthSeconds == other.ActualLengthSeconds ||
                    this.ActualLengthSeconds != null &&
                    this.ActualLengthSeconds.Equals(other.ActualLengthSeconds)
                ) &&
                (
                    this.AdherencePercentage == other.AdherencePercentage ||
                    this.AdherencePercentage != null &&
                    this.AdherencePercentage.Equals(other.AdherencePercentage)
                ) &&
                (
                    this.ConformancePercentage == other.ConformancePercentage ||
                    this.ConformancePercentage != null &&
                    this.ConformancePercentage.Equals(other.ConformancePercentage)
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
                if (this.DayStartOffsetSeconds != null)
                    hash = hash * 59 + this.DayStartOffsetSeconds.GetHashCode();

                if (this.AdherenceScheduleSeconds != null)
                    hash = hash * 59 + this.AdherenceScheduleSeconds.GetHashCode();

                if (this.ConformanceScheduleSeconds != null)
                    hash = hash * 59 + this.ConformanceScheduleSeconds.GetHashCode();

                if (this.ConformanceActualSeconds != null)
                    hash = hash * 59 + this.ConformanceActualSeconds.GetHashCode();

                if (this.ExceptionCount != null)
                    hash = hash * 59 + this.ExceptionCount.GetHashCode();

                if (this.ExceptionDurationSeconds != null)
                    hash = hash * 59 + this.ExceptionDurationSeconds.GetHashCode();

                if (this.ImpactSeconds != null)
                    hash = hash * 59 + this.ImpactSeconds.GetHashCode();

                if (this.ScheduleLengthSeconds != null)
                    hash = hash * 59 + this.ScheduleLengthSeconds.GetHashCode();

                if (this.ActualLengthSeconds != null)
                    hash = hash * 59 + this.ActualLengthSeconds.GetHashCode();

                if (this.AdherencePercentage != null)
                    hash = hash * 59 + this.AdherencePercentage.GetHashCode();

                if (this.ConformancePercentage != null)
                    hash = hash * 59 + this.ConformancePercentage.GetHashCode();

                return hash;
            }
        }
    }

}
