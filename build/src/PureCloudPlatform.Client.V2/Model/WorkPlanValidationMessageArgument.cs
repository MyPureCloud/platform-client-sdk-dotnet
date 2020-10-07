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
    /// WorkPlanValidationMessageArgument
    /// </summary>
    [DataContract]
    public partial class WorkPlanValidationMessageArgument :  IEquatable<WorkPlanValidationMessageArgument>
    {
        
        
        /// <summary>
        /// The type of the argument associated with violation messages
        /// </summary>
        /// <value>The type of the argument associated with violation messages</value>
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
            /// Enum Count for "Count"
            /// </summary>
            [EnumMember(Value = "Count")]
            Count,
            
            /// <summary>
            /// Enum Maxshiftcount for "MaxShiftCount"
            /// </summary>
            [EnumMember(Value = "MaxShiftCount")]
            Maxshiftcount,
            
            /// <summary>
            /// Enum Minutes for "Minutes"
            /// </summary>
            [EnumMember(Value = "Minutes")]
            Minutes,
            
            /// <summary>
            /// Enum Shiftid for "ShiftId"
            /// </summary>
            [EnumMember(Value = "ShiftId")]
            Shiftid
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of the argument associated with violation messages
        /// </summary>
        /// <value>The type of the argument associated with violation messages</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanValidationMessageArgument" /> class.
        /// </summary>
        /// <param name="Type">The type of the argument associated with violation messages.</param>
        /// <param name="Value">The value of the argument.</param>
        public WorkPlanValidationMessageArgument(TypeEnum? Type = null, string Value = null)
        {
            this.Type = Type;
            this.Value = Value;
            
        }
        
        
        
        
        
        /// <summary>
        /// The value of the argument
        /// </summary>
        /// <value>The value of the argument</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanValidationMessageArgument {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as WorkPlanValidationMessageArgument);
        }

        /// <summary>
        /// Returns true if WorkPlanValidationMessageArgument instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanValidationMessageArgument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanValidationMessageArgument other)
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
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                return hash;
            }
        }
    }

}
