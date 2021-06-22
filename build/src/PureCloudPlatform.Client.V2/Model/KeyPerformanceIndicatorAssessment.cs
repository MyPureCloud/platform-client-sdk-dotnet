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
    /// KeyPerformanceIndicatorAssessment
    /// </summary>
    [DataContract]
    public partial class KeyPerformanceIndicatorAssessment :  IEquatable<KeyPerformanceIndicatorAssessment>
    {
        
        
        
        
        
        /// <summary>
        /// The overall result of the assessment for a key performance indicator.
        /// </summary>
        /// <value>The overall result of the assessment for a key performance indicator.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AssessmentResultEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Notsupported for "NotSupported"
            /// </summary>
            [EnumMember(Value = "NotSupported")]
            Notsupported,
            
            /// <summary>
            /// Enum High for "High"
            /// </summary>
            [EnumMember(Value = "High")]
            High,
            
            /// <summary>
            /// Enum Low for "Low"
            /// </summary>
            [EnumMember(Value = "Low")]
            Low,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The overall result of the assessment for a key performance indicator.
        /// </summary>
        /// <value>The overall result of the assessment for a key performance indicator.</value>
        [DataMember(Name="assessmentResult", EmitDefaultValue=false)]
        public AssessmentResultEnum? AssessmentResult { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPerformanceIndicatorAssessment" /> class.
        /// </summary>
        /// <param name="Checks">Set of checks executed as part of an assessment..</param>
        public KeyPerformanceIndicatorAssessment(List<Check> Checks = null)
        {
            this.Checks = Checks;
            
        }
        
        
        
        /// <summary>
        /// Name of the key performance indicator assessed.
        /// </summary>
        /// <value>Name of the key performance indicator assessed.</value>
        [DataMember(Name="kpi", EmitDefaultValue=false)]
        public string Kpi { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Set of checks executed as part of an assessment.
        /// </summary>
        /// <value>Set of checks executed as part of an assessment.</value>
        [DataMember(Name="checks", EmitDefaultValue=false)]
        public List<Check> Checks { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyPerformanceIndicatorAssessment {\n");
            
            sb.Append("  Kpi: ").Append(Kpi).Append("\n");
            sb.Append("  AssessmentResult: ").Append(AssessmentResult).Append("\n");
            sb.Append("  Checks: ").Append(Checks).Append("\n");
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
            return this.Equals(obj as KeyPerformanceIndicatorAssessment);
        }

        /// <summary>
        /// Returns true if KeyPerformanceIndicatorAssessment instances are equal
        /// </summary>
        /// <param name="other">Instance of KeyPerformanceIndicatorAssessment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyPerformanceIndicatorAssessment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Kpi == other.Kpi ||
                    this.Kpi != null &&
                    this.Kpi.Equals(other.Kpi)
                ) &&
                (
                    this.AssessmentResult == other.AssessmentResult ||
                    this.AssessmentResult != null &&
                    this.AssessmentResult.Equals(other.AssessmentResult)
                ) &&
                (
                    this.Checks == other.Checks ||
                    this.Checks != null &&
                    this.Checks.SequenceEqual(other.Checks)
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
                
                if (this.Kpi != null)
                    hash = hash * 59 + this.Kpi.GetHashCode();
                
                if (this.AssessmentResult != null)
                    hash = hash * 59 + this.AssessmentResult.GetHashCode();
                
                if (this.Checks != null)
                    hash = hash * 59 + this.Checks.GetHashCode();
                
                return hash;
            }
        }
    }

}
