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
    /// IntradayDataGroup
    /// </summary>
    [DataContract]
    public partial class IntradayDataGroup :  IEquatable<IntradayDataGroup>
    {
        
        
        /// <summary>
        /// The media type associated with this intraday group
        /// </summary>
        /// <value>The media type associated with this intraday group</value>
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
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The media type associated with this intraday group
        /// </summary>
        /// <value>The media type associated with this intraday group</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayDataGroup" /> class.
        /// </summary>
        
        
        /// <param name="MediaType">The media type associated with this intraday group.</param>
        
        
        
        /// <param name="ForecastDataPerInterval">Forecast data for this date range.</param>
        
        
        
        /// <param name="ScheduleDataPerInterval">Schedule data for this date range.</param>
        
        
        
        /// <param name="HistoricalAgentDataPerInterval">Historical agent data for this date range.</param>
        
        
        
        /// <param name="HistoricalQueueDataPerInterval">Historical queue data for this date range.</param>
        
        
        
        /// <param name="PerformancePredictionAgentDataPerInterval">Performance prediction data for this date range.</param>
        
        
        
        /// <param name="PerformancePredictionQueueDataPerInterval">Performance prediction data for this date range.</param>
        
        
        public IntradayDataGroup(MediaTypeEnum? MediaType = null, List<IntradayForecastData> ForecastDataPerInterval = null, List<IntradayScheduleData> ScheduleDataPerInterval = null, List<IntradayHistoricalAgentData> HistoricalAgentDataPerInterval = null, List<IntradayHistoricalQueueData> HistoricalQueueDataPerInterval = null, List<IntradayPerformancePredictionAgentData> PerformancePredictionAgentDataPerInterval = null, List<IntradayPerformancePredictionQueueData> PerformancePredictionQueueDataPerInterval = null)
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
        /// Forecast data for this date range
        /// </summary>
        /// <value>Forecast data for this date range</value>
        [DataMember(Name="forecastDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayForecastData> ForecastDataPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Schedule data for this date range
        /// </summary>
        /// <value>Schedule data for this date range</value>
        [DataMember(Name="scheduleDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayScheduleData> ScheduleDataPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Historical agent data for this date range
        /// </summary>
        /// <value>Historical agent data for this date range</value>
        [DataMember(Name="historicalAgentDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayHistoricalAgentData> HistoricalAgentDataPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Historical queue data for this date range
        /// </summary>
        /// <value>Historical queue data for this date range</value>
        [DataMember(Name="historicalQueueDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayHistoricalQueueData> HistoricalQueueDataPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Performance prediction data for this date range
        /// </summary>
        /// <value>Performance prediction data for this date range</value>
        [DataMember(Name="performancePredictionAgentDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayPerformancePredictionAgentData> PerformancePredictionAgentDataPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Performance prediction data for this date range
        /// </summary>
        /// <value>Performance prediction data for this date range</value>
        [DataMember(Name="performancePredictionQueueDataPerInterval", EmitDefaultValue=false)]
        public List<IntradayPerformancePredictionQueueData> PerformancePredictionQueueDataPerInterval { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayDataGroup {\n");
            
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
            return this.Equals(obj as IntradayDataGroup);
        }

        /// <summary>
        /// Returns true if IntradayDataGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayDataGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayDataGroup other)
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
