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
    /// ReportingTurnGuardrailEvent
    /// </summary>
    [DataContract]
    public partial class ReportingTurnGuardrailEvent :  IEquatable<ReportingTurnGuardrailEvent>
    {
        /// <summary>
        /// The type of guardrail violation
        /// </summary>
        /// <value>The type of guardrail violation</value>
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
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom,
            
            /// <summary>
            /// Enum Jailbreak for "Jailbreak"
            /// </summary>
            [EnumMember(Value = "Jailbreak")]
            Jailbreak,
            
            /// <summary>
            /// Enum Harmful for "Harmful"
            /// </summary>
            [EnumMember(Value = "Harmful")]
            Harmful,
            
            /// <summary>
            /// Enum Inappropriate for "Inappropriate"
            /// </summary>
            [EnumMember(Value = "Inappropriate")]
            Inappropriate,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The type of guardrail violation
        /// </summary>
        /// <value>The type of guardrail violation</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurnGuardrailEvent" /> class.
        /// </summary>
        /// <param name="Type">The type of guardrail violation.</param>
        /// <param name="Instruction">The attached instruction to the guardrail.</param>
        /// <param name="ViolationsThreshold">The number of violations allowed before an exit occurs..</param>
        /// <param name="ViolationsTriggered">The current amount of violations that have been triggered in the current action..</param>
        public ReportingTurnGuardrailEvent(TypeEnum? Type = null, string Instruction = null, int? ViolationsThreshold = null, int? ViolationsTriggered = null)
        {
            this.Type = Type;
            this.Instruction = Instruction;
            this.ViolationsThreshold = ViolationsThreshold;
            this.ViolationsTriggered = ViolationsTriggered;
            
        }
        




        /// <summary>
        /// The attached instruction to the guardrail
        /// </summary>
        /// <value>The attached instruction to the guardrail</value>
        [DataMember(Name="instruction", EmitDefaultValue=false)]
        public string Instruction { get; set; }



        /// <summary>
        /// The number of violations allowed before an exit occurs.
        /// </summary>
        /// <value>The number of violations allowed before an exit occurs.</value>
        [DataMember(Name="violationsThreshold", EmitDefaultValue=false)]
        public int? ViolationsThreshold { get; set; }



        /// <summary>
        /// The current amount of violations that have been triggered in the current action.
        /// </summary>
        /// <value>The current amount of violations that have been triggered in the current action.</value>
        [DataMember(Name="violationsTriggered", EmitDefaultValue=false)]
        public int? ViolationsTriggered { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurnGuardrailEvent {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
            sb.Append("  ViolationsThreshold: ").Append(ViolationsThreshold).Append("\n");
            sb.Append("  ViolationsTriggered: ").Append(ViolationsTriggered).Append("\n");
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
            return this.Equals(obj as ReportingTurnGuardrailEvent);
        }

        /// <summary>
        /// Returns true if ReportingTurnGuardrailEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurnGuardrailEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurnGuardrailEvent other)
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
                    this.Instruction == other.Instruction ||
                    this.Instruction != null &&
                    this.Instruction.Equals(other.Instruction)
                ) &&
                (
                    this.ViolationsThreshold == other.ViolationsThreshold ||
                    this.ViolationsThreshold != null &&
                    this.ViolationsThreshold.Equals(other.ViolationsThreshold)
                ) &&
                (
                    this.ViolationsTriggered == other.ViolationsTriggered ||
                    this.ViolationsTriggered != null &&
                    this.ViolationsTriggered.Equals(other.ViolationsTriggered)
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

                if (this.Instruction != null)
                    hash = hash * 59 + this.Instruction.GetHashCode();

                if (this.ViolationsThreshold != null)
                    hash = hash * 59 + this.ViolationsThreshold.GetHashCode();

                if (this.ViolationsTriggered != null)
                    hash = hash * 59 + this.ViolationsTriggered.GetHashCode();

                return hash;
            }
        }
    }

}
