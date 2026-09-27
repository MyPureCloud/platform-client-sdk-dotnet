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
    /// A single structured tool-output rule. The mapping is a path into the tool output type.
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentStructuredOutputRuleAllOf :  IEquatable<AgenticVirtualAgentStructuredOutputRuleAllOf>
    {
        /// <summary>
        /// Operator to apply to the value at the mapped path.
        /// </summary>
        /// <value>Operator to apply to the value at the mapped path.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Isnull for "IsNull"
            /// </summary>
            [EnumMember(Value = "IsNull")]
            Isnull,
            
            /// <summary>
            /// Enum Isnotnull for "IsNotNull"
            /// </summary>
            [EnumMember(Value = "IsNotNull")]
            Isnotnull,
            
            /// <summary>
            /// Enum Isempty for "IsEmpty"
            /// </summary>
            [EnumMember(Value = "IsEmpty")]
            Isempty,
            
            /// <summary>
            /// Enum Isnotempty for "IsNotEmpty"
            /// </summary>
            [EnumMember(Value = "IsNotEmpty")]
            Isnotempty,
            
            /// <summary>
            /// Enum Equal for "Equal"
            /// </summary>
            [EnumMember(Value = "Equal")]
            Equal,
            
            /// <summary>
            /// Enum Notequal for "NotEqual"
            /// </summary>
            [EnumMember(Value = "NotEqual")]
            Notequal,
            
            /// <summary>
            /// Enum Lessthan for "LessThan"
            /// </summary>
            [EnumMember(Value = "LessThan")]
            Lessthan,
            
            /// <summary>
            /// Enum Lessthanorequal for "LessThanOrEqual"
            /// </summary>
            [EnumMember(Value = "LessThanOrEqual")]
            Lessthanorequal,
            
            /// <summary>
            /// Enum Greaterthan for "GreaterThan"
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            Greaterthan,
            
            /// <summary>
            /// Enum Greaterthanorequal for "GreaterThanOrEqual"
            /// </summary>
            [EnumMember(Value = "GreaterThanOrEqual")]
            Greaterthanorequal,
            
            /// <summary>
            /// Enum In for "In"
            /// </summary>
            [EnumMember(Value = "In")]
            In,
            
            /// <summary>
            /// Enum Notin for "NotIn"
            /// </summary>
            [EnumMember(Value = "NotIn")]
            Notin,
            
            /// <summary>
            /// Enum Contains for "Contains"
            /// </summary>
            [EnumMember(Value = "Contains")]
            Contains,
            
            /// <summary>
            /// Enum Doesntcontain for "DoesntContain"
            /// </summary>
            [EnumMember(Value = "DoesntContain")]
            Doesntcontain,
            
            /// <summary>
            /// Enum Beginswith for "BeginsWith"
            /// </summary>
            [EnumMember(Value = "BeginsWith")]
            Beginswith,
            
            /// <summary>
            /// Enum Endswith for "EndsWith"
            /// </summary>
            [EnumMember(Value = "EndsWith")]
            Endswith
        }
        /// <summary>
        /// Operator to apply to the value at the mapped path.
        /// </summary>
        /// <value>Operator to apply to the value at the mapped path.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentStructuredOutputRuleAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgenticVirtualAgentStructuredOutputRuleAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentStructuredOutputRuleAllOf" /> class.
        /// </summary>
        /// <param name="Mapping">Path into the tool output type this rule applies to. Each element is a field name (string) or an array index (integer). (required).</param>
        /// <param name="Operator">Operator to apply to the value at the mapped path. (required).</param>
        /// <param name="Value">Value to compare against. May be a string, integer, number, boolean, or null. Not required for &#39;IsNull&#39;, &#39;IsNotNull&#39;, &#39;IsEmpty&#39;, or &#39;IsNotEmpty&#39; operators..</param>
        public AgenticVirtualAgentStructuredOutputRuleAllOf(List<Object> Mapping = null, OperatorEnum? Operator = null, Object Value = null)
        {
            this.Mapping = Mapping;
            this.Operator = Operator;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// Path into the tool output type this rule applies to. Each element is a field name (string) or an array index (integer).
        /// </summary>
        /// <value>Path into the tool output type this rule applies to. Each element is a field name (string) or an array index (integer).</value>
        [DataMember(Name="mapping", EmitDefaultValue=false)]
        public List<Object> Mapping { get; set; }





        /// <summary>
        /// Value to compare against. May be a string, integer, number, boolean, or null. Not required for &#39;IsNull&#39;, &#39;IsNotNull&#39;, &#39;IsEmpty&#39;, or &#39;IsNotEmpty&#39; operators.
        /// </summary>
        /// <value>Value to compare against. May be a string, integer, number, boolean, or null. Not required for &#39;IsNull&#39;, &#39;IsNotNull&#39;, &#39;IsEmpty&#39;, or &#39;IsNotEmpty&#39; operators.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentStructuredOutputRuleAllOf {\n");

            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentStructuredOutputRuleAllOf);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentStructuredOutputRuleAllOf instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentStructuredOutputRuleAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentStructuredOutputRuleAllOf other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Mapping == other.Mapping ||
                    this.Mapping != null &&
                    this.Mapping.SequenceEqual(other.Mapping)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
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
                if (this.Mapping != null)
                    hash = hash * 59 + this.Mapping.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
