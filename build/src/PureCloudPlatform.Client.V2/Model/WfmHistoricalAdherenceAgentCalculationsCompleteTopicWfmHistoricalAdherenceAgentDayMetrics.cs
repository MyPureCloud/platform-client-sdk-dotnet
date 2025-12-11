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
    /// WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics :  IEquatable<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics" /> class.
        /// </summary>
        /// <param name="DayStartOffsetSeconds">DayStartOffsetSeconds.</param>
        /// <param name="AdherenceScheduleSeconds">AdherenceScheduleSeconds.</param>
        /// <param name="ConformanceScheduleSeconds">ConformanceScheduleSeconds.</param>
        /// <param name="ConformanceActualSeconds">ConformanceActualSeconds.</param>
        /// <param name="ExceptionCount">ExceptionCount.</param>
        /// <param name="ExceptionDurationSeconds">ExceptionDurationSeconds.</param>
        /// <param name="ActualLengthSeconds">ActualLengthSeconds.</param>
        /// <param name="ScheduleLengthSeconds">ScheduleLengthSeconds.</param>
        /// <param name="ImpactSeconds">ImpactSeconds.</param>
        /// <param name="AdherencePercentage">AdherencePercentage.</param>
        /// <param name="ConformancePercentage">ConformancePercentage.</param>
        public WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics(long? DayStartOffsetSeconds = null, long? AdherenceScheduleSeconds = null, long? ConformanceScheduleSeconds = null, long? ConformanceActualSeconds = null, long? ExceptionCount = null, long? ExceptionDurationSeconds = null, long? ActualLengthSeconds = null, long? ScheduleLengthSeconds = null, long? ImpactSeconds = null, double? AdherencePercentage = null, double? ConformancePercentage = null)
        {
            this.DayStartOffsetSeconds = DayStartOffsetSeconds;
            this.AdherenceScheduleSeconds = AdherenceScheduleSeconds;
            this.ConformanceScheduleSeconds = ConformanceScheduleSeconds;
            this.ConformanceActualSeconds = ConformanceActualSeconds;
            this.ExceptionCount = ExceptionCount;
            this.ExceptionDurationSeconds = ExceptionDurationSeconds;
            this.ActualLengthSeconds = ActualLengthSeconds;
            this.ScheduleLengthSeconds = ScheduleLengthSeconds;
            this.ImpactSeconds = ImpactSeconds;
            this.AdherencePercentage = AdherencePercentage;
            this.ConformancePercentage = ConformancePercentage;
            
        }
        


        /// <summary>
        /// Gets or Sets DayStartOffsetSeconds
        /// </summary>
        [DataMember(Name="dayStartOffsetSeconds", EmitDefaultValue=false)]
        public long? DayStartOffsetSeconds { get; set; }



        /// <summary>
        /// Gets or Sets AdherenceScheduleSeconds
        /// </summary>
        [DataMember(Name="adherenceScheduleSeconds", EmitDefaultValue=false)]
        public long? AdherenceScheduleSeconds { get; set; }



        /// <summary>
        /// Gets or Sets ConformanceScheduleSeconds
        /// </summary>
        [DataMember(Name="conformanceScheduleSeconds", EmitDefaultValue=false)]
        public long? ConformanceScheduleSeconds { get; set; }



        /// <summary>
        /// Gets or Sets ConformanceActualSeconds
        /// </summary>
        [DataMember(Name="conformanceActualSeconds", EmitDefaultValue=false)]
        public long? ConformanceActualSeconds { get; set; }



        /// <summary>
        /// Gets or Sets ExceptionCount
        /// </summary>
        [DataMember(Name="exceptionCount", EmitDefaultValue=false)]
        public long? ExceptionCount { get; set; }



        /// <summary>
        /// Gets or Sets ExceptionDurationSeconds
        /// </summary>
        [DataMember(Name="exceptionDurationSeconds", EmitDefaultValue=false)]
        public long? ExceptionDurationSeconds { get; set; }



        /// <summary>
        /// Gets or Sets ActualLengthSeconds
        /// </summary>
        [DataMember(Name="actualLengthSeconds", EmitDefaultValue=false)]
        public long? ActualLengthSeconds { get; set; }



        /// <summary>
        /// Gets or Sets ScheduleLengthSeconds
        /// </summary>
        [DataMember(Name="scheduleLengthSeconds", EmitDefaultValue=false)]
        public long? ScheduleLengthSeconds { get; set; }



        /// <summary>
        /// Gets or Sets ImpactSeconds
        /// </summary>
        [DataMember(Name="impactSeconds", EmitDefaultValue=false)]
        public long? ImpactSeconds { get; set; }



        /// <summary>
        /// Gets or Sets AdherencePercentage
        /// </summary>
        [DataMember(Name="adherencePercentage", EmitDefaultValue=false)]
        public double? AdherencePercentage { get; set; }



        /// <summary>
        /// Gets or Sets ConformancePercentage
        /// </summary>
        [DataMember(Name="conformancePercentage", EmitDefaultValue=false)]
        public double? ConformancePercentage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics {\n");

            sb.Append("  DayStartOffsetSeconds: ").Append(DayStartOffsetSeconds).Append("\n");
            sb.Append("  AdherenceScheduleSeconds: ").Append(AdherenceScheduleSeconds).Append("\n");
            sb.Append("  ConformanceScheduleSeconds: ").Append(ConformanceScheduleSeconds).Append("\n");
            sb.Append("  ConformanceActualSeconds: ").Append(ConformanceActualSeconds).Append("\n");
            sb.Append("  ExceptionCount: ").Append(ExceptionCount).Append("\n");
            sb.Append("  ExceptionDurationSeconds: ").Append(ExceptionDurationSeconds).Append("\n");
            sb.Append("  ActualLengthSeconds: ").Append(ActualLengthSeconds).Append("\n");
            sb.Append("  ScheduleLengthSeconds: ").Append(ScheduleLengthSeconds).Append("\n");
            sb.Append("  ImpactSeconds: ").Append(ImpactSeconds).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics other)
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
                    this.ActualLengthSeconds == other.ActualLengthSeconds ||
                    this.ActualLengthSeconds != null &&
                    this.ActualLengthSeconds.Equals(other.ActualLengthSeconds)
                ) &&
                (
                    this.ScheduleLengthSeconds == other.ScheduleLengthSeconds ||
                    this.ScheduleLengthSeconds != null &&
                    this.ScheduleLengthSeconds.Equals(other.ScheduleLengthSeconds)
                ) &&
                (
                    this.ImpactSeconds == other.ImpactSeconds ||
                    this.ImpactSeconds != null &&
                    this.ImpactSeconds.Equals(other.ImpactSeconds)
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

                if (this.ActualLengthSeconds != null)
                    hash = hash * 59 + this.ActualLengthSeconds.GetHashCode();

                if (this.ScheduleLengthSeconds != null)
                    hash = hash * 59 + this.ScheduleLengthSeconds.GetHashCode();

                if (this.ImpactSeconds != null)
                    hash = hash * 59 + this.ImpactSeconds.GetHashCode();

                if (this.AdherencePercentage != null)
                    hash = hash * 59 + this.AdherencePercentage.GetHashCode();

                if (this.ConformancePercentage != null)
                    hash = hash * 59 + this.ConformancePercentage.GetHashCode();

                return hash;
            }
        }
    }

}
