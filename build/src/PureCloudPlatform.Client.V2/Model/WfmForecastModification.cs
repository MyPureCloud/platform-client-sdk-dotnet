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
    /// A modification to a short term forecast
    /// </summary>
    [DataContract]
    public partial class WfmForecastModification :  IEquatable<WfmForecastModification>
    {
        
        
        /// <summary>
        /// The type of the modification
        /// </summary>
        /// <value>The type of the modification</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Minimumperinterval for "MinimumPerInterval"
            /// </summary>
            [EnumMember(Value = "MinimumPerInterval")]
            Minimumperinterval,
            
            /// <summary>
            /// Enum Maximumperinterval for "MaximumPerInterval"
            /// </summary>
            [EnumMember(Value = "MaximumPerInterval")]
            Maximumperinterval,
            
            /// <summary>
            /// Enum Setvalueperinterval for "SetValuePerInterval"
            /// </summary>
            [EnumMember(Value = "SetValuePerInterval")]
            Setvalueperinterval,
            
            /// <summary>
            /// Enum Changevalueperinterval for "ChangeValuePerInterval"
            /// </summary>
            [EnumMember(Value = "ChangeValuePerInterval")]
            Changevalueperinterval,
            
            /// <summary>
            /// Enum Changepercentperinterval for "ChangePercentPerInterval"
            /// </summary>
            [EnumMember(Value = "ChangePercentPerInterval")]
            Changepercentperinterval,
            
            /// <summary>
            /// Enum Setvalueoverrange for "SetValueOverRange"
            /// </summary>
            [EnumMember(Value = "SetValueOverRange")]
            Setvalueoverrange,
            
            /// <summary>
            /// Enum Changevalueoverrange for "ChangeValueOverRange"
            /// </summary>
            [EnumMember(Value = "ChangeValueOverRange")]
            Changevalueoverrange,
            
            /// <summary>
            /// Enum Setvaluesforintervalset for "SetValuesForIntervalSet"
            /// </summary>
            [EnumMember(Value = "SetValuesForIntervalSet")]
            Setvaluesforintervalset
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The metric to which this modification applies
        /// </summary>
        /// <value>The metric to which this modification applies</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Offered for "Offered"
            /// </summary>
            [EnumMember(Value = "Offered")]
            Offered,
            
            /// <summary>
            /// Enum Averagetalktimeseconds for "AverageTalkTimeSeconds"
            /// </summary>
            [EnumMember(Value = "AverageTalkTimeSeconds")]
            Averagetalktimeseconds,
            
            /// <summary>
            /// Enum Averageaftercallworktimeseconds for "AverageAfterCallWorkTimeSeconds"
            /// </summary>
            [EnumMember(Value = "AverageAfterCallWorkTimeSeconds")]
            Averageaftercallworktimeseconds,
            
            /// <summary>
            /// Enum Averagehandletimeseconds for "AverageHandleTimeSeconds"
            /// </summary>
            [EnumMember(Value = "AverageHandleTimeSeconds")]
            Averagehandletimeseconds
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of the modification
        /// </summary>
        /// <value>The type of the modification</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// The metric to which this modification applies
        /// </summary>
        /// <value>The metric to which this modification applies</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmForecastModification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmForecastModification() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmForecastModification" /> class.
        /// </summary>
        /// <param name="Type">The type of the modification (required).</param>
        /// <param name="StartIntervalIndex">The number of 15 minute intervals past referenceStartDate representing the first interval to which to apply this modification. Must be null if values is populated.</param>
        /// <param name="EndIntervalIndex">The number of 15 minute intervals past referenceStartDate representing the last interval to which to apply this modification.  Must be null if values is populated.</param>
        /// <param name="Metric">The metric to which this modification applies (required).</param>
        /// <param name="Value">The value of the modification.  Must be null if \&quot;values\&quot; is populated.</param>
        /// <param name="Values">The list of values to update.  Only applicable for grid-type modifications. Must be null if \&quot;value\&quot; is populated.</param>
        /// <param name="Enabled">Whether the modification is enabled for the forecast (required).</param>
        /// <param name="Attributes">The attributes defining how this modification applies to the forecast (required).</param>
        public WfmForecastModification(TypeEnum? Type = null, int? StartIntervalIndex = null, int? EndIntervalIndex = null, MetricEnum? Metric = null, double? Value = null, List<WfmForecastModificationIntervalOffsetValue> Values = null, bool? Enabled = null, WfmForecastModificationAttributes Attributes = null)
        {
            this.Type = Type;
            this.StartIntervalIndex = StartIntervalIndex;
            this.EndIntervalIndex = EndIntervalIndex;
            this.Metric = Metric;
            this.Value = Value;
            this.Values = Values;
            this.Enabled = Enabled;
            this.Attributes = Attributes;
            
        }
        
        
        
        
        
        /// <summary>
        /// The number of 15 minute intervals past referenceStartDate representing the first interval to which to apply this modification. Must be null if values is populated
        /// </summary>
        /// <value>The number of 15 minute intervals past referenceStartDate representing the first interval to which to apply this modification. Must be null if values is populated</value>
        [DataMember(Name="startIntervalIndex", EmitDefaultValue=false)]
        public int? StartIntervalIndex { get; set; }
        
        
        
        /// <summary>
        /// The number of 15 minute intervals past referenceStartDate representing the last interval to which to apply this modification.  Must be null if values is populated
        /// </summary>
        /// <value>The number of 15 minute intervals past referenceStartDate representing the last interval to which to apply this modification.  Must be null if values is populated</value>
        [DataMember(Name="endIntervalIndex", EmitDefaultValue=false)]
        public int? EndIntervalIndex { get; set; }
        
        
        
        
        
        /// <summary>
        /// The value of the modification.  Must be null if \&quot;values\&quot; is populated
        /// </summary>
        /// <value>The value of the modification.  Must be null if \&quot;values\&quot; is populated</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }
        
        
        
        /// <summary>
        /// The list of values to update.  Only applicable for grid-type modifications. Must be null if \&quot;value\&quot; is populated
        /// </summary>
        /// <value>The list of values to update.  Only applicable for grid-type modifications. Must be null if \&quot;value\&quot; is populated</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<WfmForecastModificationIntervalOffsetValue> Values { get; set; }
        
        
        
        /// <summary>
        /// Whether the modification is enabled for the forecast
        /// </summary>
        /// <value>Whether the modification is enabled for the forecast</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// The attributes defining how this modification applies to the forecast
        /// </summary>
        /// <value>The attributes defining how this modification applies to the forecast</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public WfmForecastModificationAttributes Attributes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmForecastModification {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartIntervalIndex: ").Append(StartIntervalIndex).Append("\n");
            sb.Append("  EndIntervalIndex: ").Append(EndIntervalIndex).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(obj as WfmForecastModification);
        }

        /// <summary>
        /// Returns true if WfmForecastModification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmForecastModification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmForecastModification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.StartIntervalIndex == other.StartIntervalIndex ||
                    this.StartIntervalIndex != null &&
                    this.StartIntervalIndex.Equals(other.StartIntervalIndex)
                ) &&
                (
                    this.EndIntervalIndex == other.EndIntervalIndex ||
                    this.EndIntervalIndex != null &&
                    this.EndIntervalIndex.Equals(other.EndIntervalIndex)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.Equals(other.Attributes)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.StartIntervalIndex != null)
                    hash = hash * 59 + this.StartIntervalIndex.GetHashCode();
                
                if (this.EndIntervalIndex != null)
                    hash = hash * 59 + this.EndIntervalIndex.GetHashCode();
                
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                
                return hash;
            }
        }
    }

}
