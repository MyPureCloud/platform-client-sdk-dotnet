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
    /// HistoricalAdherenceDayMetrics
    /// </summary>
    [DataContract]
    public partial class HistoricalAdherenceDayMetrics :  IEquatable<HistoricalAdherenceDayMetrics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalAdherenceDayMetrics" /> class.
        /// </summary>
        /// <param name="DayStartOffsetSecs">Start of day offset in seconds relative to query start time.</param>
        /// <param name="AdherenceScheduleSecs">Duration of schedule in seconds included for adherence percentage calculation.</param>
        /// <param name="ConformanceScheduleSecs">Total scheduled duration in seconds for OnQueue activities.</param>
        /// <param name="ConformanceActualSecs">Total actually worked duration in seconds for OnQueue activities.</param>
        /// <param name="ExceptionCount">Total number of adherence exceptions for this user.</param>
        /// <param name="ExceptionDurationSecs">Total duration in seconds of adherence exceptions for this user.</param>
        /// <param name="ImpactSeconds">The impact duration in seconds of current adherence state for this user.</param>
        /// <param name="ScheduleLengthSecs">Total duration in seconds for all scheduled activities.</param>
        /// <param name="ActualLengthSecs">Total duration in seconds for all actually worked activities.</param>
        /// <param name="AdherencePercentage">Total adherence percentage for this user, in the scale of 0 - 100.</param>
        /// <param name="ConformancePercentage">Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on-queue time is greater than the scheduled on-queue time for the same period..</param>
        public HistoricalAdherenceDayMetrics(int? DayStartOffsetSecs = null, int? AdherenceScheduleSecs = null, int? ConformanceScheduleSecs = null, int? ConformanceActualSecs = null, int? ExceptionCount = null, int? ExceptionDurationSecs = null, int? ImpactSeconds = null, int? ScheduleLengthSecs = null, int? ActualLengthSecs = null, double? AdherencePercentage = null, double? ConformancePercentage = null)
        {
            this.DayStartOffsetSecs = DayStartOffsetSecs;
            this.AdherenceScheduleSecs = AdherenceScheduleSecs;
            this.ConformanceScheduleSecs = ConformanceScheduleSecs;
            this.ConformanceActualSecs = ConformanceActualSecs;
            this.ExceptionCount = ExceptionCount;
            this.ExceptionDurationSecs = ExceptionDurationSecs;
            this.ImpactSeconds = ImpactSeconds;
            this.ScheduleLengthSecs = ScheduleLengthSecs;
            this.ActualLengthSecs = ActualLengthSecs;
            this.AdherencePercentage = AdherencePercentage;
            this.ConformancePercentage = ConformancePercentage;
            
        }
        


        /// <summary>
        /// Start of day offset in seconds relative to query start time
        /// </summary>
        /// <value>Start of day offset in seconds relative to query start time</value>
        [DataMember(Name="dayStartOffsetSecs", EmitDefaultValue=false)]
        public int? DayStartOffsetSecs { get; set; }



        /// <summary>
        /// Duration of schedule in seconds included for adherence percentage calculation
        /// </summary>
        /// <value>Duration of schedule in seconds included for adherence percentage calculation</value>
        [DataMember(Name="adherenceScheduleSecs", EmitDefaultValue=false)]
        public int? AdherenceScheduleSecs { get; set; }



        /// <summary>
        /// Total scheduled duration in seconds for OnQueue activities
        /// </summary>
        /// <value>Total scheduled duration in seconds for OnQueue activities</value>
        [DataMember(Name="conformanceScheduleSecs", EmitDefaultValue=false)]
        public int? ConformanceScheduleSecs { get; set; }



        /// <summary>
        /// Total actually worked duration in seconds for OnQueue activities
        /// </summary>
        /// <value>Total actually worked duration in seconds for OnQueue activities</value>
        [DataMember(Name="conformanceActualSecs", EmitDefaultValue=false)]
        public int? ConformanceActualSecs { get; set; }



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
        [DataMember(Name="exceptionDurationSecs", EmitDefaultValue=false)]
        public int? ExceptionDurationSecs { get; set; }



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
        [DataMember(Name="scheduleLengthSecs", EmitDefaultValue=false)]
        public int? ScheduleLengthSecs { get; set; }



        /// <summary>
        /// Total duration in seconds for all actually worked activities
        /// </summary>
        /// <value>Total duration in seconds for all actually worked activities</value>
        [DataMember(Name="actualLengthSecs", EmitDefaultValue=false)]
        public int? ActualLengthSecs { get; set; }



        /// <summary>
        /// Total adherence percentage for this user, in the scale of 0 - 100
        /// </summary>
        /// <value>Total adherence percentage for this user, in the scale of 0 - 100</value>
        [DataMember(Name="adherencePercentage", EmitDefaultValue=false)]
        public double? AdherencePercentage { get; set; }



        /// <summary>
        /// Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on-queue time is greater than the scheduled on-queue time for the same period.
        /// </summary>
        /// <value>Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on-queue time is greater than the scheduled on-queue time for the same period.</value>
        [DataMember(Name="conformancePercentage", EmitDefaultValue=false)]
        public double? ConformancePercentage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricalAdherenceDayMetrics {\n");

            sb.Append("  DayStartOffsetSecs: ").Append(DayStartOffsetSecs).Append("\n");
            sb.Append("  AdherenceScheduleSecs: ").Append(AdherenceScheduleSecs).Append("\n");
            sb.Append("  ConformanceScheduleSecs: ").Append(ConformanceScheduleSecs).Append("\n");
            sb.Append("  ConformanceActualSecs: ").Append(ConformanceActualSecs).Append("\n");
            sb.Append("  ExceptionCount: ").Append(ExceptionCount).Append("\n");
            sb.Append("  ExceptionDurationSecs: ").Append(ExceptionDurationSecs).Append("\n");
            sb.Append("  ImpactSeconds: ").Append(ImpactSeconds).Append("\n");
            sb.Append("  ScheduleLengthSecs: ").Append(ScheduleLengthSecs).Append("\n");
            sb.Append("  ActualLengthSecs: ").Append(ActualLengthSecs).Append("\n");
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
            return this.Equals(obj as HistoricalAdherenceDayMetrics);
        }

        /// <summary>
        /// Returns true if HistoricalAdherenceDayMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricalAdherenceDayMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalAdherenceDayMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DayStartOffsetSecs == other.DayStartOffsetSecs ||
                    this.DayStartOffsetSecs != null &&
                    this.DayStartOffsetSecs.Equals(other.DayStartOffsetSecs)
                ) &&
                (
                    this.AdherenceScheduleSecs == other.AdherenceScheduleSecs ||
                    this.AdherenceScheduleSecs != null &&
                    this.AdherenceScheduleSecs.Equals(other.AdherenceScheduleSecs)
                ) &&
                (
                    this.ConformanceScheduleSecs == other.ConformanceScheduleSecs ||
                    this.ConformanceScheduleSecs != null &&
                    this.ConformanceScheduleSecs.Equals(other.ConformanceScheduleSecs)
                ) &&
                (
                    this.ConformanceActualSecs == other.ConformanceActualSecs ||
                    this.ConformanceActualSecs != null &&
                    this.ConformanceActualSecs.Equals(other.ConformanceActualSecs)
                ) &&
                (
                    this.ExceptionCount == other.ExceptionCount ||
                    this.ExceptionCount != null &&
                    this.ExceptionCount.Equals(other.ExceptionCount)
                ) &&
                (
                    this.ExceptionDurationSecs == other.ExceptionDurationSecs ||
                    this.ExceptionDurationSecs != null &&
                    this.ExceptionDurationSecs.Equals(other.ExceptionDurationSecs)
                ) &&
                (
                    this.ImpactSeconds == other.ImpactSeconds ||
                    this.ImpactSeconds != null &&
                    this.ImpactSeconds.Equals(other.ImpactSeconds)
                ) &&
                (
                    this.ScheduleLengthSecs == other.ScheduleLengthSecs ||
                    this.ScheduleLengthSecs != null &&
                    this.ScheduleLengthSecs.Equals(other.ScheduleLengthSecs)
                ) &&
                (
                    this.ActualLengthSecs == other.ActualLengthSecs ||
                    this.ActualLengthSecs != null &&
                    this.ActualLengthSecs.Equals(other.ActualLengthSecs)
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
                if (this.DayStartOffsetSecs != null)
                    hash = hash * 59 + this.DayStartOffsetSecs.GetHashCode();

                if (this.AdherenceScheduleSecs != null)
                    hash = hash * 59 + this.AdherenceScheduleSecs.GetHashCode();

                if (this.ConformanceScheduleSecs != null)
                    hash = hash * 59 + this.ConformanceScheduleSecs.GetHashCode();

                if (this.ConformanceActualSecs != null)
                    hash = hash * 59 + this.ConformanceActualSecs.GetHashCode();

                if (this.ExceptionCount != null)
                    hash = hash * 59 + this.ExceptionCount.GetHashCode();

                if (this.ExceptionDurationSecs != null)
                    hash = hash * 59 + this.ExceptionDurationSecs.GetHashCode();

                if (this.ImpactSeconds != null)
                    hash = hash * 59 + this.ImpactSeconds.GetHashCode();

                if (this.ScheduleLengthSecs != null)
                    hash = hash * 59 + this.ScheduleLengthSecs.GetHashCode();

                if (this.ActualLengthSecs != null)
                    hash = hash * 59 + this.ActualLengthSecs.GetHashCode();

                if (this.AdherencePercentage != null)
                    hash = hash * 59 + this.AdherencePercentage.GetHashCode();

                if (this.ConformancePercentage != null)
                    hash = hash * 59 + this.ConformancePercentage.GetHashCode();

                return hash;
            }
        }
    }

}
