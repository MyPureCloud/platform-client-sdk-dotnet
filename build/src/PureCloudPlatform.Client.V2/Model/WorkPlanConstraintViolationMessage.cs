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
    /// WorkPlanConstraintViolationMessage
    /// </summary>
    [DataContract]
    public partial class WorkPlanConstraintViolationMessage :  IEquatable<WorkPlanConstraintViolationMessage>
    {
        /// <summary>
        /// Type of the work plan constraint in this message.
        /// </summary>
        /// <value>Type of the work plan constraint in this message.</value>
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
            /// Enum Minimumweeklyworkdays for "MinimumWeeklyWorkDays"
            /// </summary>
            [EnumMember(Value = "MinimumWeeklyWorkDays")]
            Minimumweeklyworkdays,
            
            /// <summary>
            /// Enum Minimumweeklypaidtime for "MinimumWeeklyPaidTime"
            /// </summary>
            [EnumMember(Value = "MinimumWeeklyPaidTime")]
            Minimumweeklypaidtime,
            
            /// <summary>
            /// Enum Requiredshift for "RequiredShift"
            /// </summary>
            [EnumMember(Value = "RequiredShift")]
            Requiredshift,
            
            /// <summary>
            /// Enum Maximumdaysoffperplanningperiod for "MaximumDaysOffPerPlanningPeriod"
            /// </summary>
            [EnumMember(Value = "MaximumDaysOffPerPlanningPeriod")]
            Maximumdaysoffperplanningperiod,
            
            /// <summary>
            /// Enum Minimumpaidtimeperplanningperiod for "MinimumPaidTimePerPlanningPeriod"
            /// </summary>
            [EnumMember(Value = "MinimumPaidTimePerPlanningPeriod")]
            Minimumpaidtimeperplanningperiod,
            
            /// <summary>
            /// Enum Minimumshiftcountperplanningperiod for "MinimumShiftCountPerPlanningPeriod"
            /// </summary>
            [EnumMember(Value = "MinimumShiftCountPerPlanningPeriod")]
            Minimumshiftcountperplanningperiod
        }
        /// <summary>
        /// Type of the work plan constraint in this message.
        /// </summary>
        /// <value>Type of the work plan constraint in this message.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanConstraintViolationMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkPlanConstraintViolationMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanConstraintViolationMessage" /> class.
        /// </summary>
        /// <param name="Type">Type of the work plan constraint in this message. (required).</param>
        /// <param name="Arguments">Arguments of the message that provide information about the constraint that is being conflicted with such as the value of the constraint. (required).</param>
        public WorkPlanConstraintViolationMessage(TypeEnum? Type = null, List<UnavailableTimesViolationMessageArgument> Arguments = null)
        {
            this.Type = Type;
            this.Arguments = Arguments;
            
        }
        




        /// <summary>
        /// Arguments of the message that provide information about the constraint that is being conflicted with such as the value of the constraint.
        /// </summary>
        /// <value>Arguments of the message that provide information about the constraint that is being conflicted with such as the value of the constraint.</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public List<UnavailableTimesViolationMessageArgument> Arguments { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanConstraintViolationMessage {\n");

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
            return this.Equals(obj as WorkPlanConstraintViolationMessage);
        }

        /// <summary>
        /// Returns true if WorkPlanConstraintViolationMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanConstraintViolationMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanConstraintViolationMessage other)
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
