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
    /// UnavailableTimesViolationMessageArgument
    /// </summary>
    [DataContract]
    public partial class UnavailableTimesViolationMessageArgument :  IEquatable<UnavailableTimesViolationMessageArgument>
    {
        /// <summary>
        /// Argument type
        /// </summary>
        /// <value>Argument type</value>
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
            /// Enum Planningperiodtype for "PlanningPeriodType"
            /// </summary>
            [EnumMember(Value = "PlanningPeriodType")]
            Planningperiodtype,
            
            /// <summary>
            /// Enum Minutes for "Minutes"
            /// </summary>
            [EnumMember(Value = "Minutes")]
            Minutes,
            
            /// <summary>
            /// Enum Date for "Date"
            /// </summary>
            [EnumMember(Value = "Date")]
            Date,
            
            /// <summary>
            /// Enum Seconddate for "SecondDate"
            /// </summary>
            [EnumMember(Value = "SecondDate")]
            Seconddate,
            
            /// <summary>
            /// Enum Secondcount for "SecondCount"
            /// </summary>
            [EnumMember(Value = "SecondCount")]
            Secondcount,
            
            /// <summary>
            /// Enum Count for "Count"
            /// </summary>
            [EnumMember(Value = "Count")]
            Count
        }
        /// <summary>
        /// Argument type
        /// </summary>
        /// <value>Argument type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableTimesViolationMessageArgument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnavailableTimesViolationMessageArgument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableTimesViolationMessageArgument" /> class.
        /// </summary>
        /// <param name="Type">Argument type (required).</param>
        /// <param name="Value">Value of argument (required).</param>
        public UnavailableTimesViolationMessageArgument(TypeEnum? Type = null, string Value = null)
        {
            this.Type = Type;
            this.Value = Value;
            
        }
        




        /// <summary>
        /// Value of argument
        /// </summary>
        /// <value>Value of argument</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnavailableTimesViolationMessageArgument {\n");

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
            return this.Equals(obj as UnavailableTimesViolationMessageArgument);
        }

        /// <summary>
        /// Returns true if UnavailableTimesViolationMessageArgument instances are equal
        /// </summary>
        /// <param name="other">Instance of UnavailableTimesViolationMessageArgument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnavailableTimesViolationMessageArgument other)
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
