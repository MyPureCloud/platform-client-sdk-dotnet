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
    /// DurationCondition
    /// </summary>
    [DataContract]
    public partial class DurationCondition :  IEquatable<DurationCondition>
    {
        
        
        /// <summary>
        /// Gets or Sets DurationTarget
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DurationTargetEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Duration for "DURATION"
            /// </summary>
            [EnumMember(Value = "DURATION")]
            Duration,
            
            /// <summary>
            /// Enum DurationRange for "DURATION_RANGE"
            /// </summary>
            [EnumMember(Value = "DURATION_RANGE")]
            DurationRange
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DurationMode
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DurationModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Between for "Between"
            /// </summary>
            [EnumMember(Value = "Between")]
            Between,
            
            /// <summary>
            /// Enum Over for "Over"
            /// </summary>
            [EnumMember(Value = "Over")]
            Over,
            
            /// <summary>
            /// Enum Under for "Under"
            /// </summary>
            [EnumMember(Value = "Under")]
            Under
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DurationTarget
        /// </summary>
        [DataMember(Name="durationTarget", EmitDefaultValue=false)]
        public DurationTargetEnum? DurationTarget { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DurationMode
        /// </summary>
        [DataMember(Name="durationMode", EmitDefaultValue=false)]
        public DurationModeEnum? DurationMode { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DurationCondition" /> class.
        /// </summary>
        /// <param name="DurationTarget">DurationTarget.</param>
        /// <param name="DurationOperator">DurationOperator.</param>
        /// <param name="DurationRange">DurationRange.</param>
        /// <param name="DurationMode">DurationMode.</param>
        public DurationCondition(DurationTargetEnum? DurationTarget = null, string DurationOperator = null, string DurationRange = null, DurationModeEnum? DurationMode = null)
        {
            this.DurationTarget = DurationTarget;
            this.DurationOperator = DurationOperator;
            this.DurationRange = DurationRange;
            this.DurationMode = DurationMode;
            
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DurationOperator
        /// </summary>
        [DataMember(Name="durationOperator", EmitDefaultValue=false)]
        public string DurationOperator { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DurationRange
        /// </summary>
        [DataMember(Name="durationRange", EmitDefaultValue=false)]
        public string DurationRange { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DurationCondition {\n");
            
            sb.Append("  DurationTarget: ").Append(DurationTarget).Append("\n");
            sb.Append("  DurationOperator: ").Append(DurationOperator).Append("\n");
            sb.Append("  DurationRange: ").Append(DurationRange).Append("\n");
            sb.Append("  DurationMode: ").Append(DurationMode).Append("\n");
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
            return this.Equals(obj as DurationCondition);
        }

        /// <summary>
        /// Returns true if DurationCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of DurationCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DurationCondition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DurationTarget == other.DurationTarget ||
                    this.DurationTarget != null &&
                    this.DurationTarget.Equals(other.DurationTarget)
                ) &&
                (
                    this.DurationOperator == other.DurationOperator ||
                    this.DurationOperator != null &&
                    this.DurationOperator.Equals(other.DurationOperator)
                ) &&
                (
                    this.DurationRange == other.DurationRange ||
                    this.DurationRange != null &&
                    this.DurationRange.Equals(other.DurationRange)
                ) &&
                (
                    this.DurationMode == other.DurationMode ||
                    this.DurationMode != null &&
                    this.DurationMode.Equals(other.DurationMode)
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
                
                if (this.DurationTarget != null)
                    hash = hash * 59 + this.DurationTarget.GetHashCode();
                
                if (this.DurationOperator != null)
                    hash = hash * 59 + this.DurationOperator.GetHashCode();
                
                if (this.DurationRange != null)
                    hash = hash * 59 + this.DurationRange.GetHashCode();
                
                if (this.DurationMode != null)
                    hash = hash * 59 + this.DurationMode.GetHashCode();
                
                return hash;
            }
        }
    }

}
