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
    /// ReportingInterval
    /// </summary>
    [DataContract]
    public partial class ReportingInterval :  IEquatable<ReportingInterval>
    {
        
        
        /// <summary>
        /// The granularity of the reporting interval period
        /// </summary>
        /// <value>The granularity of the reporting interval period</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum IntervalTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Day for "Day"
            /// </summary>
            [EnumMember(Value = "Day")]
            Day,
            
            /// <summary>
            /// Enum Week for "Week"
            /// </summary>
            [EnumMember(Value = "Week")]
            Week,
            
            /// <summary>
            /// Enum Month for "Month"
            /// </summary>
            [EnumMember(Value = "Month")]
            Month
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// The granularity of the reporting interval period
        /// </summary>
        /// <value>The granularity of the reporting interval period</value>
        [DataMember(Name="intervalType", EmitDefaultValue=false)]
        public IntervalTypeEnum? IntervalType { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingInterval" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportingInterval() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingInterval" /> class.
        /// </summary>
        /// <param name="IntervalType">The granularity of the reporting interval period (required).</param>
        /// <param name="IntervalValue">The value of the reporting interval period for a given interval type (required).</param>
        public ReportingInterval(IntervalTypeEnum? IntervalType = null, int? IntervalValue = null)
        {
            this.IntervalType = IntervalType;
            this.IntervalValue = IntervalValue;
            
        }
        
        
        
        
        
        /// <summary>
        /// The value of the reporting interval period for a given interval type
        /// </summary>
        /// <value>The value of the reporting interval period for a given interval type</value>
        [DataMember(Name="intervalValue", EmitDefaultValue=false)]
        public int? IntervalValue { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingInterval {\n");
            
            sb.Append("  IntervalType: ").Append(IntervalType).Append("\n");
            sb.Append("  IntervalValue: ").Append(IntervalValue).Append("\n");
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
            return this.Equals(obj as ReportingInterval);
        }

        /// <summary>
        /// Returns true if ReportingInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingInterval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IntervalType == other.IntervalType ||
                    this.IntervalType != null &&
                    this.IntervalType.Equals(other.IntervalType)
                ) &&
                (
                    this.IntervalValue == other.IntervalValue ||
                    this.IntervalValue != null &&
                    this.IntervalValue.Equals(other.IntervalValue)
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
                
                if (this.IntervalType != null)
                    hash = hash * 59 + this.IntervalType.GetHashCode();
                
                if (this.IntervalValue != null)
                    hash = hash * 59 + this.IntervalValue.GetHashCode();
                
                return hash;
            }
        }
    }

}
