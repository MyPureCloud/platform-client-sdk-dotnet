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
    /// BuForecastModificationResponse
    /// </summary>
    [DataContract]
    public partial class BuForecastModificationResponse :  IEquatable<BuForecastModificationResponse>
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
            Setvaluesforintervalset,
            
            /// <summary>
            /// Enum Setmultigranularityvaluesforintervalset for "SetMultiGranularityValuesForIntervalSet"
            /// </summary>
            [EnumMember(Value = "SetMultiGranularityValuesForIntervalSet")]
            Setmultigranularityvaluesforintervalset
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
            /// Enum Averagehandletimeseconds for "AverageHandleTimeSeconds"
            /// </summary>
            [EnumMember(Value = "AverageHandleTimeSeconds")]
            Averagehandletimeseconds
        }
        /// <summary>
        /// The legacy metric to which this modification applies if applicable
        /// </summary>
        /// <value>The legacy metric to which this modification applies if applicable</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LegacyMetricEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Averageaftercallworktimeseconds for "AverageAfterCallWorkTimeSeconds"
            /// </summary>
            [EnumMember(Value = "AverageAfterCallWorkTimeSeconds")]
            Averageaftercallworktimeseconds,
            
            /// <summary>
            /// Enum Averagehandletimeseconds for "AverageHandleTimeSeconds"
            /// </summary>
            [EnumMember(Value = "AverageHandleTimeSeconds")]
            Averagehandletimeseconds,
            
            /// <summary>
            /// Enum Averagetalktimeseconds for "AverageTalkTimeSeconds"
            /// </summary>
            [EnumMember(Value = "AverageTalkTimeSeconds")]
            Averagetalktimeseconds,
            
            /// <summary>
            /// Enum Offered for "Offered"
            /// </summary>
            [EnumMember(Value = "Offered")]
            Offered
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
        /// The legacy metric to which this modification applies if applicable
        /// </summary>
        /// <value>The legacy metric to which this modification applies if applicable</value>
        [DataMember(Name="legacyMetric", EmitDefaultValue=false)]
        public LegacyMetricEnum? LegacyMetric { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuForecastModificationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuForecastModificationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuForecastModificationResponse" /> class.
        /// </summary>
        /// <param name="Type">The type of the modification (required).</param>
        /// <param name="StartIntervalIndex">The number of intervals past referenceStartDate representing the first interval to which this modification applies.</param>
        /// <param name="EndIntervalIndex">The number of intervals past referenceStartDate representing the last interval to which this modification applies.</param>
        /// <param name="Metric">The metric to which this modification applies (required).</param>
        /// <param name="LegacyMetric">The legacy metric to which this modification applies if applicable.</param>
        /// <param name="Value">The value of the modification.</param>
        /// <param name="Values">The list of modification values. Only applicable for grid-type modifications (required).</param>
        /// <param name="SecondaryValues">The list of modification secondary values. Only applicable for multi granularity modifications.</param>
        /// <param name="DisplayGranularity">The client side display granularity of the modification, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H (required).</param>
        /// <param name="Granularity">The actual granularity of the modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H (required).</param>
        /// <param name="SecondaryGranularity">The granularity of the &#39;secondaryValues&#39; modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
        /// <param name="Enabled">Whether the modification is enabled for the forecast (required).</param>
        /// <param name="PlanningGroupIds">The IDs of the planning groups to which this forecast modification applies (required).</param>
        public BuForecastModificationResponse(TypeEnum? Type = null, int? StartIntervalIndex = null, int? EndIntervalIndex = null, MetricEnum? Metric = null, LegacyMetricEnum? LegacyMetric = null, double? Value = null, List<WfmForecastModificationIntervalOffsetValue> Values = null, List<WfmForecastModificationIntervalOffsetValue> SecondaryValues = null, string DisplayGranularity = null, string Granularity = null, string SecondaryGranularity = null, bool? Enabled = null, List<string> PlanningGroupIds = null)
        {
            this.Type = Type;
            this.StartIntervalIndex = StartIntervalIndex;
            this.EndIntervalIndex = EndIntervalIndex;
            this.Metric = Metric;
            this.LegacyMetric = LegacyMetric;
            this.Value = Value;
            this.Values = Values;
            this.SecondaryValues = SecondaryValues;
            this.DisplayGranularity = DisplayGranularity;
            this.Granularity = Granularity;
            this.SecondaryGranularity = SecondaryGranularity;
            this.Enabled = Enabled;
            this.PlanningGroupIds = PlanningGroupIds;
            
        }
        




        /// <summary>
        /// The number of intervals past referenceStartDate representing the first interval to which this modification applies
        /// </summary>
        /// <value>The number of intervals past referenceStartDate representing the first interval to which this modification applies</value>
        [DataMember(Name="startIntervalIndex", EmitDefaultValue=false)]
        public int? StartIntervalIndex { get; set; }



        /// <summary>
        /// The number of intervals past referenceStartDate representing the last interval to which this modification applies
        /// </summary>
        /// <value>The number of intervals past referenceStartDate representing the last interval to which this modification applies</value>
        [DataMember(Name="endIntervalIndex", EmitDefaultValue=false)]
        public int? EndIntervalIndex { get; set; }







        /// <summary>
        /// The value of the modification
        /// </summary>
        /// <value>The value of the modification</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }



        /// <summary>
        /// The list of modification values. Only applicable for grid-type modifications
        /// </summary>
        /// <value>The list of modification values. Only applicable for grid-type modifications</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<WfmForecastModificationIntervalOffsetValue> Values { get; set; }



        /// <summary>
        /// The list of modification secondary values. Only applicable for multi granularity modifications
        /// </summary>
        /// <value>The list of modification secondary values. Only applicable for multi granularity modifications</value>
        [DataMember(Name="secondaryValues", EmitDefaultValue=false)]
        public List<WfmForecastModificationIntervalOffsetValue> SecondaryValues { get; set; }



        /// <summary>
        /// The client side display granularity of the modification, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
        /// </summary>
        /// <value>The client side display granularity of the modification, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
        [DataMember(Name="displayGranularity", EmitDefaultValue=false)]
        public string DisplayGranularity { get; set; }



        /// <summary>
        /// The actual granularity of the modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
        /// </summary>
        /// <value>The actual granularity of the modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public string Granularity { get; set; }



        /// <summary>
        /// The granularity of the &#39;secondaryValues&#39; modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
        /// </summary>
        /// <value>The granularity of the &#39;secondaryValues&#39; modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
        [DataMember(Name="secondaryGranularity", EmitDefaultValue=false)]
        public string SecondaryGranularity { get; set; }



        /// <summary>
        /// Whether the modification is enabled for the forecast
        /// </summary>
        /// <value>Whether the modification is enabled for the forecast</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The IDs of the planning groups to which this forecast modification applies
        /// </summary>
        /// <value>The IDs of the planning groups to which this forecast modification applies</value>
        [DataMember(Name="planningGroupIds", EmitDefaultValue=false)]
        public List<string> PlanningGroupIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuForecastModificationResponse {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartIntervalIndex: ").Append(StartIntervalIndex).Append("\n");
            sb.Append("  EndIntervalIndex: ").Append(EndIntervalIndex).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  LegacyMetric: ").Append(LegacyMetric).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  SecondaryValues: ").Append(SecondaryValues).Append("\n");
            sb.Append("  DisplayGranularity: ").Append(DisplayGranularity).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  SecondaryGranularity: ").Append(SecondaryGranularity).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  PlanningGroupIds: ").Append(PlanningGroupIds).Append("\n");
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
            return this.Equals(obj as BuForecastModificationResponse);
        }

        /// <summary>
        /// Returns true if BuForecastModificationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuForecastModificationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuForecastModificationResponse other)
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
                    this.LegacyMetric == other.LegacyMetric ||
                    this.LegacyMetric != null &&
                    this.LegacyMetric.Equals(other.LegacyMetric)
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
                    this.SecondaryValues == other.SecondaryValues ||
                    this.SecondaryValues != null &&
                    this.SecondaryValues.SequenceEqual(other.SecondaryValues)
                ) &&
                (
                    this.DisplayGranularity == other.DisplayGranularity ||
                    this.DisplayGranularity != null &&
                    this.DisplayGranularity.Equals(other.DisplayGranularity)
                ) &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.SecondaryGranularity == other.SecondaryGranularity ||
                    this.SecondaryGranularity != null &&
                    this.SecondaryGranularity.Equals(other.SecondaryGranularity)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.PlanningGroupIds == other.PlanningGroupIds ||
                    this.PlanningGroupIds != null &&
                    this.PlanningGroupIds.SequenceEqual(other.PlanningGroupIds)
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

                if (this.LegacyMetric != null)
                    hash = hash * 59 + this.LegacyMetric.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                if (this.SecondaryValues != null)
                    hash = hash * 59 + this.SecondaryValues.GetHashCode();

                if (this.DisplayGranularity != null)
                    hash = hash * 59 + this.DisplayGranularity.GetHashCode();

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.SecondaryGranularity != null)
                    hash = hash * 59 + this.SecondaryGranularity.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.PlanningGroupIds != null)
                    hash = hash * 59 + this.PlanningGroupIds.GetHashCode();

                return hash;
            }
        }
    }

}
