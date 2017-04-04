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
    /// IntradayDataUpdateNotificationMetrics
    /// </summary>
    [DataContract]
    public partial class IntradayDataUpdateNotificationMetrics :  IEquatable<IntradayDataUpdateNotificationMetrics>
    {
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum HistoricalQueueData for "HISTORICAL_QUEUE_DATA"
            /// </summary>
            [EnumMember(Value = "HISTORICAL_QUEUE_DATA")]
            HistoricalQueueData,
            
            /// <summary>
            /// Enum HistoricalAgentData for "HISTORICAL_AGENT_DATA"
            /// </summary>
            [EnumMember(Value = "HISTORICAL_AGENT_DATA")]
            HistoricalAgentData,
            
            /// <summary>
            /// Enum ForecastData for "FORECAST_DATA"
            /// </summary>
            [EnumMember(Value = "FORECAST_DATA")]
            ForecastData,
            
            /// <summary>
            /// Enum ScheduleData for "SCHEDULE_DATA"
            /// </summary>
            [EnumMember(Value = "SCHEDULE_DATA")]
            ScheduleData,
            
            /// <summary>
            /// Enum PerformancePredictionAgentData for "PERFORMANCE_PREDICTION_AGENT_DATA"
            /// </summary>
            [EnumMember(Value = "PERFORMANCE_PREDICTION_AGENT_DATA")]
            PerformancePredictionAgentData,
            
            /// <summary>
            /// Enum PerformancePredictionQueueData for "PERFORMANCE_PREDICTION_QUEUE_DATA"
            /// </summary>
            [EnumMember(Value = "PERFORMANCE_PREDICTION_QUEUE_DATA")]
            PerformancePredictionQueueData
        }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayDataUpdateNotificationMetrics" /> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        /// <param name="Version">Version.</param>
        public IntradayDataUpdateNotificationMetrics(CategoryEnum? Category = null, string Version = null)
        {
            this.Category = Category;
            this.Version = Version;
        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayDataUpdateNotificationMetrics {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as IntradayDataUpdateNotificationMetrics);
        }

        /// <summary>
        /// Returns true if IntradayDataUpdateNotificationMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayDataUpdateNotificationMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayDataUpdateNotificationMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }
    }

}
