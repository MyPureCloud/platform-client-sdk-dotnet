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
    /// WorkdayValuesMetricItem
    /// </summary>
    [DataContract]
    public partial class WorkdayValuesMetricItem :  IEquatable<WorkdayValuesMetricItem>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// The unit type of the metric value
        /// </summary>
        /// <value>The unit type of the metric value</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UnitTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Percent for "Percent"
            /// </summary>
            [EnumMember(Value = "Percent")]
            Percent,
            
            /// <summary>
            /// Enum Seconds for "Seconds"
            /// </summary>
            [EnumMember(Value = "Seconds")]
            Seconds,
            
            /// <summary>
            /// Enum Number for "Number"
            /// </summary>
            [EnumMember(Value = "Number")]
            Number,
            
            /// <summary>
            /// Enum Attendancestatus for "AttendanceStatus"
            /// </summary>
            [EnumMember(Value = "AttendanceStatus")]
            Attendancestatus,
            
            /// <summary>
            /// Enum Unit for "Unit"
            /// </summary>
            [EnumMember(Value = "Unit")]
            Unit
        }
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The unit type of the metric value
        /// </summary>
        /// <value>The unit type of the metric value</value>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public UnitTypeEnum? UnitType { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkdayValuesMetricItem" /> class.
        /// </summary>
        /// <param name="MetricDefinition">Gamification metric for the average and the trend.</param>
        /// <param name="Trend">The metric value trend.</param>
        public WorkdayValuesMetricItem(MetricDefinition MetricDefinition = null, List<WorkdayValuesTrendItem> Trend = null)
        {
            this.MetricDefinition = MetricDefinition;
            this.Trend = Trend;
            
        }
        
        
        
        /// <summary>
        /// Gamification metric for the average and the trend
        /// </summary>
        /// <value>Gamification metric for the average and the trend</value>
        [DataMember(Name="metricDefinition", EmitDefaultValue=false)]
        public MetricDefinition MetricDefinition { get; set; }
        
        
        
        /// <summary>
        /// The average value of the metric
        /// </summary>
        /// <value>The average value of the metric</value>
        [DataMember(Name="average", EmitDefaultValue=false)]
        public double? Average { get; private set; }
        
        
        
        
        
        /// <summary>
        /// The metric value trend
        /// </summary>
        /// <value>The metric value trend</value>
        [DataMember(Name="trend", EmitDefaultValue=false)]
        public List<WorkdayValuesTrendItem> Trend { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkdayValuesMetricItem {\n");
            
            sb.Append("  MetricDefinition: ").Append(MetricDefinition).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  Trend: ").Append(Trend).Append("\n");
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
            return this.Equals(obj as WorkdayValuesMetricItem);
        }

        /// <summary>
        /// Returns true if WorkdayValuesMetricItem instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkdayValuesMetricItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkdayValuesMetricItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MetricDefinition == other.MetricDefinition ||
                    this.MetricDefinition != null &&
                    this.MetricDefinition.Equals(other.MetricDefinition)
                ) &&
                (
                    this.Average == other.Average ||
                    this.Average != null &&
                    this.Average.Equals(other.Average)
                ) &&
                (
                    this.UnitType == other.UnitType ||
                    this.UnitType != null &&
                    this.UnitType.Equals(other.UnitType)
                ) &&
                (
                    this.Trend == other.Trend ||
                    this.Trend != null &&
                    this.Trend.SequenceEqual(other.Trend)
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
                
                if (this.MetricDefinition != null)
                    hash = hash * 59 + this.MetricDefinition.GetHashCode();
                
                if (this.Average != null)
                    hash = hash * 59 + this.Average.GetHashCode();
                
                if (this.UnitType != null)
                    hash = hash * 59 + this.UnitType.GetHashCode();
                
                if (this.Trend != null)
                    hash = hash * 59 + this.Trend.GetHashCode();
                
                return hash;
            }
        }
    }

}
