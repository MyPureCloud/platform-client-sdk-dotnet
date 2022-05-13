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
    /// LearningModuleRuleParts
    /// </summary>
    [DataContract]
    public partial class LearningModuleRuleParts :  IEquatable<LearningModuleRuleParts>
    {
        /// <summary>
        /// The learning module rule operation
        /// </summary>
        /// <value>The learning module rule operation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperationEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Include for "Include"
            /// </summary>
            [EnumMember(Value = "Include")]
            Include,
            
            /// <summary>
            /// Enum Exclude for "Exclude"
            /// </summary>
            [EnumMember(Value = "Exclude")]
            Exclude
        }
        /// <summary>
        /// The learning module rule selector
        /// </summary>
        /// <value>The learning module rule selector</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SelectorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Acdskills for "AcdSkills"
            /// </summary>
            [EnumMember(Value = "AcdSkills")]
            Acdskills,
            
            /// <summary>
            /// Enum Agentname for "AgentName"
            /// </summary>
            [EnumMember(Value = "AgentName")]
            Agentname,
            
            /// <summary>
            /// Enum Division for "Division"
            /// </summary>
            [EnumMember(Value = "Division")]
            Division,
            
            /// <summary>
            /// Enum Group for "Group"
            /// </summary>
            [EnumMember(Value = "Group")]
            Group,
            
            /// <summary>
            /// Enum Location for "Location"
            /// </summary>
            [EnumMember(Value = "Location")]
            Location,
            
            /// <summary>
            /// Enum Queue for "Queue"
            /// </summary>
            [EnumMember(Value = "Queue")]
            Queue,
            
            /// <summary>
            /// Enum Role for "Role"
            /// </summary>
            [EnumMember(Value = "Role")]
            Role,
            
            /// <summary>
            /// Enum Team for "Team"
            /// </summary>
            [EnumMember(Value = "Team")]
            Team
        }
        /// <summary>
        /// The learning module rule operation
        /// </summary>
        /// <value>The learning module rule operation</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }
        /// <summary>
        /// The learning module rule selector
        /// </summary>
        /// <value>The learning module rule selector</value>
        [DataMember(Name="selector", EmitDefaultValue=false)]
        public SelectorEnum? Selector { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleRuleParts" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningModuleRuleParts() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleRuleParts" /> class.
        /// </summary>
        /// <param name="Operation">The learning module rule operation (required).</param>
        /// <param name="Selector">The learning module rule selector (required).</param>
        /// <param name="Value">The value of rules (required).</param>
        /// <param name="Order">The order of rules in learning module rule (required).</param>
        public LearningModuleRuleParts(OperationEnum? Operation = null, SelectorEnum? Selector = null, List<string> Value = null, int? Order = null)
        {
            this.Operation = Operation;
            this.Selector = Selector;
            this.Value = Value;
            this.Order = Order;
            
        }
        






        /// <summary>
        /// The value of rules
        /// </summary>
        /// <value>The value of rules</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public List<string> Value { get; set; }



        /// <summary>
        /// The order of rules in learning module rule
        /// </summary>
        /// <value>The order of rules in learning module rule</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningModuleRuleParts {\n");

            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Selector: ").Append(Selector).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(obj as LearningModuleRuleParts);
        }

        /// <summary>
        /// Returns true if LearningModuleRuleParts instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModuleRuleParts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModuleRuleParts other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
                ) &&
                (
                    this.Selector == other.Selector ||
                    this.Selector != null &&
                    this.Selector.Equals(other.Selector)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.SequenceEqual(other.Value)
                ) &&
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();

                if (this.Selector != null)
                    hash = hash * 59 + this.Selector.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();

                return hash;
            }
        }
    }

}
