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
    /// IntradayDataUpdateNotificationIntradayDataGroupings
    /// </summary>
    [DataContract]
    public partial class IntradayDataUpdateNotificationIntradayDataGroupings :  IEquatable<IntradayDataUpdateNotificationIntradayDataGroupings>
    {
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "VOICE"
            /// </summary>
            [EnumMember(Value = "VOICE")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "CHAT"
            /// </summary>
            [EnumMember(Value = "CHAT")]
            Chat,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email
        }
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayDataUpdateNotificationIntradayDataGroupings" /> class.
        /// </summary>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="ForecastDataPerInterval">ForecastDataPerInterval.</param>
        /// <param name="ScheduleDataPerInterval">ScheduleDataPerInterval.</param>
        /// <param name="HistoricalAgentDataPerInterval">HistoricalAgentDataPerInterval.</param>
        /// <param name="HistoricalQueueDataPerInterval">HistoricalQueueDataPerInterval.</param>
        /// <param name="PerformancePredictionAgentDataPerInterval">PerformancePredictionAgentDataPerInterval.</param>
        /// <param name="PerformancePredictionQueueDataPerInterval">PerformancePredictionQueueDataPerInterval.</param>
        public IntradayDataUpdateNotificationIntradayDataGroupings(MediaTypeEnum? MediaType = null, List<IntradayDataUpdateNotificationForecastDataPerInterval> ForecastDataPerInterval = null, List<IntradayDataUpdateNotificationScheduleDataPerInterval> ScheduleDataPerInterval = null, List<IntradayDataUpdateNotificationHistoricalAgentDataPerInterval> HistoricalAgentDataPerInterval = null, List<IntradayDataUpdateNotificationHistoricalQueueDataPerInterval> HistoricalQueueDataPerInterval = null, List<IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval> PerformancePredictionAgentDataPerInterval = null, List<IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval> PerformancePredictionQueueDataPerInterval = null)
        {
            this.MediaType = MediaType;
            this.ForecastDataPerInterval = ForecastDataPerInterval;
            this.ScheduleDataPerInterval = ScheduleDataPerInterval;
            this.HistoricalAgentDataPerInterval = HistoricalAgentDataPerInterval;
            this.HistoricalQueueDataPerInterval = HistoricalQueueDataPerInterval;
            this.PerformancePredictionAgentDataPerInterval = PerformancePredictionAgentDataPerInterval;
            this.PerformancePredictionQueueDataPerInterval = PerformancePredictionQueueDataPerInterval;
        }
        
        /// <summary>
        /// Gets or Sets ForecastDataPerInterval
        /// </summary>
        [DataMember(Name="forecastDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayDataUpdateNotificationForecastDataPerInterval> ForecastDataPerInterval { get; set; }
        /// <summary>
        /// Gets or Sets ScheduleDataPerInterval
        /// </summary>
        [DataMember(Name="scheduleDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayDataUpdateNotificationScheduleDataPerInterval> ScheduleDataPerInterval { get; set; }
        /// <summary>
        /// Gets or Sets HistoricalAgentDataPerInterval
        /// </summary>
        [DataMember(Name="historicalAgentDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayDataUpdateNotificationHistoricalAgentDataPerInterval> HistoricalAgentDataPerInterval { get; set; }
        /// <summary>
        /// Gets or Sets HistoricalQueueDataPerInterval
        /// </summary>
        [DataMember(Name="historicalQueueDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayDataUpdateNotificationHistoricalQueueDataPerInterval> HistoricalQueueDataPerInterval { get; set; }
        /// <summary>
        /// Gets or Sets PerformancePredictionAgentDataPerInterval
        /// </summary>
        [DataMember(Name="performancePredictionAgentDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval> PerformancePredictionAgentDataPerInterval { get; set; }
        /// <summary>
        /// Gets or Sets PerformancePredictionQueueDataPerInterval
        /// </summary>
        [DataMember(Name="performancePredictionQueueDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval> PerformancePredictionQueueDataPerInterval { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayDataUpdateNotificationIntradayDataGroupings {\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  ForecastDataPerInterval: ").Append(ForecastDataPerInterval).Append("\n");
            sb.Append("  ScheduleDataPerInterval: ").Append(ScheduleDataPerInterval).Append("\n");
            sb.Append("  HistoricalAgentDataPerInterval: ").Append(HistoricalAgentDataPerInterval).Append("\n");
            sb.Append("  HistoricalQueueDataPerInterval: ").Append(HistoricalQueueDataPerInterval).Append("\n");
            sb.Append("  PerformancePredictionAgentDataPerInterval: ").Append(PerformancePredictionAgentDataPerInterval).Append("\n");
            sb.Append("  PerformancePredictionQueueDataPerInterval: ").Append(PerformancePredictionQueueDataPerInterval).Append("\n");
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
            return this.Equals(obj as IntradayDataUpdateNotificationIntradayDataGroupings);
        }

        /// <summary>
        /// Returns true if IntradayDataUpdateNotificationIntradayDataGroupings instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayDataUpdateNotificationIntradayDataGroupings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayDataUpdateNotificationIntradayDataGroupings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.ForecastDataPerInterval == other.ForecastDataPerInterval ||
                    this.ForecastDataPerInterval != null &&
                    this.ForecastDataPerInterval.SequenceEqual(other.ForecastDataPerInterval)
                ) &&
                (
                    this.ScheduleDataPerInterval == other.ScheduleDataPerInterval ||
                    this.ScheduleDataPerInterval != null &&
                    this.ScheduleDataPerInterval.SequenceEqual(other.ScheduleDataPerInterval)
                ) &&
                (
                    this.HistoricalAgentDataPerInterval == other.HistoricalAgentDataPerInterval ||
                    this.HistoricalAgentDataPerInterval != null &&
                    this.HistoricalAgentDataPerInterval.SequenceEqual(other.HistoricalAgentDataPerInterval)
                ) &&
                (
                    this.HistoricalQueueDataPerInterval == other.HistoricalQueueDataPerInterval ||
                    this.HistoricalQueueDataPerInterval != null &&
                    this.HistoricalQueueDataPerInterval.SequenceEqual(other.HistoricalQueueDataPerInterval)
                ) &&
                (
                    this.PerformancePredictionAgentDataPerInterval == other.PerformancePredictionAgentDataPerInterval ||
                    this.PerformancePredictionAgentDataPerInterval != null &&
                    this.PerformancePredictionAgentDataPerInterval.SequenceEqual(other.PerformancePredictionAgentDataPerInterval)
                ) &&
                (
                    this.PerformancePredictionQueueDataPerInterval == other.PerformancePredictionQueueDataPerInterval ||
                    this.PerformancePredictionQueueDataPerInterval != null &&
                    this.PerformancePredictionQueueDataPerInterval.SequenceEqual(other.PerformancePredictionQueueDataPerInterval)
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
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                if (this.ForecastDataPerInterval != null)
                    hash = hash * 59 + this.ForecastDataPerInterval.GetHashCode();
                if (this.ScheduleDataPerInterval != null)
                    hash = hash * 59 + this.ScheduleDataPerInterval.GetHashCode();
                if (this.HistoricalAgentDataPerInterval != null)
                    hash = hash * 59 + this.HistoricalAgentDataPerInterval.GetHashCode();
                if (this.HistoricalQueueDataPerInterval != null)
                    hash = hash * 59 + this.HistoricalQueueDataPerInterval.GetHashCode();
                if (this.PerformancePredictionAgentDataPerInterval != null)
                    hash = hash * 59 + this.PerformancePredictionAgentDataPerInterval.GetHashCode();
                if (this.PerformancePredictionQueueDataPerInterval != null)
                    hash = hash * 59 + this.PerformancePredictionQueueDataPerInterval.GetHashCode();
                return hash;
            }
        }
    }

}
