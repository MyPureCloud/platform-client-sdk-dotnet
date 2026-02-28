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
    /// OrganizationCallMetrics
    /// </summary>
    [DataContract]
    public partial class OrganizationCallMetrics :  IEquatable<OrganizationCallMetrics>
    {
        /// <summary>
        /// The current compute intensity of the organization's call capacity.
        /// </summary>
        /// <value>The current compute intensity of the organization's call capacity.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CpuIntensityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Low for "Low"
            /// </summary>
            [EnumMember(Value = "Low")]
            Low,
            
            /// <summary>
            /// Enum Medium for "Medium"
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium,
            
            /// <summary>
            /// Enum High for "High"
            /// </summary>
            [EnumMember(Value = "High")]
            High,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The current memory intensity of the organization's call capacity.
        /// </summary>
        /// <value>The current memory intensity of the organization's call capacity.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MemoryIntensityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Low for "Low"
            /// </summary>
            [EnumMember(Value = "Low")]
            Low,
            
            /// <summary>
            /// Enum Medium for "Medium"
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium,
            
            /// <summary>
            /// Enum High for "High"
            /// </summary>
            [EnumMember(Value = "High")]
            High,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The autoscaling status of the organization's call capacity.
        /// </summary>
        /// <value>The autoscaling status of the organization's call capacity.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AutoScaleInProgressEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Up for "Up"
            /// </summary>
            [EnumMember(Value = "Up")]
            Up,
            
            /// <summary>
            /// Enum Down for "Down"
            /// </summary>
            [EnumMember(Value = "Down")]
            Down,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The current compute intensity of the organization's call capacity.
        /// </summary>
        /// <value>The current compute intensity of the organization's call capacity.</value>
        [DataMember(Name="cpuIntensity", EmitDefaultValue=false)]
        public CpuIntensityEnum? CpuIntensity { get; set; }
        /// <summary>
        /// The current memory intensity of the organization's call capacity.
        /// </summary>
        /// <value>The current memory intensity of the organization's call capacity.</value>
        [DataMember(Name="memoryIntensity", EmitDefaultValue=false)]
        public MemoryIntensityEnum? MemoryIntensity { get; set; }
        /// <summary>
        /// The autoscaling status of the organization's call capacity.
        /// </summary>
        /// <value>The autoscaling status of the organization's call capacity.</value>
        [DataMember(Name="autoScaleInProgress", EmitDefaultValue=false)]
        public AutoScaleInProgressEnum? AutoScaleInProgress { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCallMetrics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationCallMetrics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCallMetrics" /> class.
        /// </summary>
        /// <param name="Usage">The current usage percentage of the organization&#39;s call capacity. (required).</param>
        /// <param name="AutoScalingTriggerPercentage">The autoscaling trigger percentage of the organization&#39;s call capacity. (required).</param>
        /// <param name="CpuIntensity">The current compute intensity of the organization&#39;s call capacity. (required).</param>
        /// <param name="MemoryIntensity">The current memory intensity of the organization&#39;s call capacity. (required).</param>
        /// <param name="ConcurrentCallCount">The current number of concurrent calls in the organization. (required).</param>
        /// <param name="ConcurrentCallSessionCount">The current number of concurrent call sessions in the organization. (required).</param>
        /// <param name="MaxCallCapacity">The maximum number of concurrent calls allowed in the organization. (required).</param>
        /// <param name="MaxCallSessionCapacity">The maximum number of concurrent call sessions allowed in the organization. (required).</param>
        /// <param name="AutoScaleInProgress">The autoscaling status of the organization&#39;s call capacity. (required).</param>
        public OrganizationCallMetrics(double? Usage = null, double? AutoScalingTriggerPercentage = null, CpuIntensityEnum? CpuIntensity = null, MemoryIntensityEnum? MemoryIntensity = null, int? ConcurrentCallCount = null, int? ConcurrentCallSessionCount = null, int? MaxCallCapacity = null, int? MaxCallSessionCapacity = null, AutoScaleInProgressEnum? AutoScaleInProgress = null)
        {
            this.Usage = Usage;
            this.AutoScalingTriggerPercentage = AutoScalingTriggerPercentage;
            this.CpuIntensity = CpuIntensity;
            this.MemoryIntensity = MemoryIntensity;
            this.ConcurrentCallCount = ConcurrentCallCount;
            this.ConcurrentCallSessionCount = ConcurrentCallSessionCount;
            this.MaxCallCapacity = MaxCallCapacity;
            this.MaxCallSessionCapacity = MaxCallSessionCapacity;
            this.AutoScaleInProgress = AutoScaleInProgress;
            
        }
        


        /// <summary>
        /// The current usage percentage of the organization&#39;s call capacity.
        /// </summary>
        /// <value>The current usage percentage of the organization&#39;s call capacity.</value>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        public double? Usage { get; set; }



        /// <summary>
        /// The autoscaling trigger percentage of the organization&#39;s call capacity.
        /// </summary>
        /// <value>The autoscaling trigger percentage of the organization&#39;s call capacity.</value>
        [DataMember(Name="autoScalingTriggerPercentage", EmitDefaultValue=false)]
        public double? AutoScalingTriggerPercentage { get; set; }







        /// <summary>
        /// The current number of concurrent calls in the organization.
        /// </summary>
        /// <value>The current number of concurrent calls in the organization.</value>
        [DataMember(Name="concurrentCallCount", EmitDefaultValue=false)]
        public int? ConcurrentCallCount { get; set; }



        /// <summary>
        /// The current number of concurrent call sessions in the organization.
        /// </summary>
        /// <value>The current number of concurrent call sessions in the organization.</value>
        [DataMember(Name="concurrentCallSessionCount", EmitDefaultValue=false)]
        public int? ConcurrentCallSessionCount { get; set; }



        /// <summary>
        /// The maximum number of concurrent calls allowed in the organization.
        /// </summary>
        /// <value>The maximum number of concurrent calls allowed in the organization.</value>
        [DataMember(Name="maxCallCapacity", EmitDefaultValue=false)]
        public int? MaxCallCapacity { get; set; }



        /// <summary>
        /// The maximum number of concurrent call sessions allowed in the organization.
        /// </summary>
        /// <value>The maximum number of concurrent call sessions allowed in the organization.</value>
        [DataMember(Name="maxCallSessionCapacity", EmitDefaultValue=false)]
        public int? MaxCallSessionCapacity { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationCallMetrics {\n");

            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  AutoScalingTriggerPercentage: ").Append(AutoScalingTriggerPercentage).Append("\n");
            sb.Append("  CpuIntensity: ").Append(CpuIntensity).Append("\n");
            sb.Append("  MemoryIntensity: ").Append(MemoryIntensity).Append("\n");
            sb.Append("  ConcurrentCallCount: ").Append(ConcurrentCallCount).Append("\n");
            sb.Append("  ConcurrentCallSessionCount: ").Append(ConcurrentCallSessionCount).Append("\n");
            sb.Append("  MaxCallCapacity: ").Append(MaxCallCapacity).Append("\n");
            sb.Append("  MaxCallSessionCapacity: ").Append(MaxCallSessionCapacity).Append("\n");
            sb.Append("  AutoScaleInProgress: ").Append(AutoScaleInProgress).Append("\n");
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
            return this.Equals(obj as OrganizationCallMetrics);
        }

        /// <summary>
        /// Returns true if OrganizationCallMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationCallMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationCallMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Usage == other.Usage ||
                    this.Usage != null &&
                    this.Usage.Equals(other.Usage)
                ) &&
                (
                    this.AutoScalingTriggerPercentage == other.AutoScalingTriggerPercentage ||
                    this.AutoScalingTriggerPercentage != null &&
                    this.AutoScalingTriggerPercentage.Equals(other.AutoScalingTriggerPercentage)
                ) &&
                (
                    this.CpuIntensity == other.CpuIntensity ||
                    this.CpuIntensity != null &&
                    this.CpuIntensity.Equals(other.CpuIntensity)
                ) &&
                (
                    this.MemoryIntensity == other.MemoryIntensity ||
                    this.MemoryIntensity != null &&
                    this.MemoryIntensity.Equals(other.MemoryIntensity)
                ) &&
                (
                    this.ConcurrentCallCount == other.ConcurrentCallCount ||
                    this.ConcurrentCallCount != null &&
                    this.ConcurrentCallCount.Equals(other.ConcurrentCallCount)
                ) &&
                (
                    this.ConcurrentCallSessionCount == other.ConcurrentCallSessionCount ||
                    this.ConcurrentCallSessionCount != null &&
                    this.ConcurrentCallSessionCount.Equals(other.ConcurrentCallSessionCount)
                ) &&
                (
                    this.MaxCallCapacity == other.MaxCallCapacity ||
                    this.MaxCallCapacity != null &&
                    this.MaxCallCapacity.Equals(other.MaxCallCapacity)
                ) &&
                (
                    this.MaxCallSessionCapacity == other.MaxCallSessionCapacity ||
                    this.MaxCallSessionCapacity != null &&
                    this.MaxCallSessionCapacity.Equals(other.MaxCallSessionCapacity)
                ) &&
                (
                    this.AutoScaleInProgress == other.AutoScaleInProgress ||
                    this.AutoScaleInProgress != null &&
                    this.AutoScaleInProgress.Equals(other.AutoScaleInProgress)
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
                if (this.Usage != null)
                    hash = hash * 59 + this.Usage.GetHashCode();

                if (this.AutoScalingTriggerPercentage != null)
                    hash = hash * 59 + this.AutoScalingTriggerPercentage.GetHashCode();

                if (this.CpuIntensity != null)
                    hash = hash * 59 + this.CpuIntensity.GetHashCode();

                if (this.MemoryIntensity != null)
                    hash = hash * 59 + this.MemoryIntensity.GetHashCode();

                if (this.ConcurrentCallCount != null)
                    hash = hash * 59 + this.ConcurrentCallCount.GetHashCode();

                if (this.ConcurrentCallSessionCount != null)
                    hash = hash * 59 + this.ConcurrentCallSessionCount.GetHashCode();

                if (this.MaxCallCapacity != null)
                    hash = hash * 59 + this.MaxCallCapacity.GetHashCode();

                if (this.MaxCallSessionCapacity != null)
                    hash = hash * 59 + this.MaxCallSessionCapacity.GetHashCode();

                if (this.AutoScaleInProgress != null)
                    hash = hash * 59 + this.AutoScaleInProgress.GetHashCode();

                return hash;
            }
        }
    }

}
