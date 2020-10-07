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
    /// WorkPlanConfigurationViolationMessage
    /// </summary>
    [DataContract]
    public partial class WorkPlanConfigurationViolationMessage :  IEquatable<WorkPlanConfigurationViolationMessage>
    {
        
        
        /// <summary>
        /// Type of configuration violation message for this work plan
        /// </summary>
        /// <value>Type of configuration violation message for this work plan</value>
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
            /// Enum Dailyexactpaidminutes for "DailyExactPaidMinutes"
            /// </summary>
            [EnumMember(Value = "DailyExactPaidMinutes")]
            Dailyexactpaidminutes,
            
            /// <summary>
            /// Enum Dailyshiftmaximumpossibilitiesviolated for "DailyShiftMaximumPossibilitiesViolated"
            /// </summary>
            [EnumMember(Value = "DailyShiftMaximumPossibilitiesViolated")]
            Dailyshiftmaximumpossibilitiesviolated,
            
            /// <summary>
            /// Enum Maxshifts for "MaxShifts"
            /// </summary>
            [EnumMember(Value = "MaxShifts")]
            Maxshifts,
            
            /// <summary>
            /// Enum Noshifts for "NoShifts"
            /// </summary>
            [EnumMember(Value = "NoShifts")]
            Noshifts,
            
            /// <summary>
            /// Enum Weeklyexactpaidminutes for "WeeklyExactPaidMinutes"
            /// </summary>
            [EnumMember(Value = "WeeklyExactPaidMinutes")]
            Weeklyexactpaidminutes
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// Type of configuration violation message for this work plan
        /// </summary>
        /// <value>Type of configuration violation message for this work plan</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanConfigurationViolationMessage" /> class.
        /// </summary>
        /// <param name="Type">Type of configuration violation message for this work plan.</param>
        /// <param name="Arguments">Arguments of the message that provide information about the misconfigured value or the threshold that is exceeded by the misconfigured value.</param>
        public WorkPlanConfigurationViolationMessage(TypeEnum? Type = null, List<WorkPlanValidationMessageArgument> Arguments = null)
        {
            this.Type = Type;
            this.Arguments = Arguments;
            
        }
        
        
        
        
        
        /// <summary>
        /// Arguments of the message that provide information about the misconfigured value or the threshold that is exceeded by the misconfigured value
        /// </summary>
        /// <value>Arguments of the message that provide information about the misconfigured value or the threshold that is exceeded by the misconfigured value</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public List<WorkPlanValidationMessageArgument> Arguments { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanConfigurationViolationMessage {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
            return this.Equals(obj as WorkPlanConfigurationViolationMessage);
        }

        /// <summary>
        /// Returns true if WorkPlanConfigurationViolationMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanConfigurationViolationMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanConfigurationViolationMessage other)
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
                    this.Arguments == other.Arguments ||
                    this.Arguments != null &&
                    this.Arguments.SequenceEqual(other.Arguments)
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
                
                if (this.Arguments != null)
                    hash = hash * 59 + this.Arguments.GetHashCode();
                
                return hash;
            }
        }
    }

}
