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
    /// Defines a simple matching condition
    /// </summary>
    [DataContract]
    public partial class MatchCriteria :  IEquatable<MatchCriteria>
    {
        /// <summary>
        /// The type of operation to perform for matching check
        /// </summary>
        /// <value>The type of operation to perform for matching check</value>
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
            /// Enum Greaterthanorequal for "GreaterThanOrEqual"
            /// </summary>
            [EnumMember(Value = "GreaterThanOrEqual")]
            Greaterthanorequal,
            
            /// <summary>
            /// Enum Lessthanorequal for "LessThanOrEqual"
            /// </summary>
            [EnumMember(Value = "LessThanOrEqual")]
            Lessthanorequal,
            
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
            /// Enum Greaterthan for "GreaterThan"
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            Greaterthan,
            
            /// <summary>
            /// Enum Notin for "NotIn"
            /// </summary>
            [EnumMember(Value = "NotIn")]
            Notin,
            
            /// <summary>
            /// Enum In for "In"
            /// </summary>
            [EnumMember(Value = "In")]
            In,
            
            /// <summary>
            /// Enum Contains for "Contains"
            /// </summary>
            [EnumMember(Value = "Contains")]
            Contains,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All,
            
            /// <summary>
            /// Enum Exists for "Exists"
            /// </summary>
            [EnumMember(Value = "Exists")]
            Exists,
            
            /// <summary>
            /// Enum Size for "Size"
            /// </summary>
            [EnumMember(Value = "Size")]
            Size
        }
        /// <summary>
        /// The type of operation to perform for matching check
        /// </summary>
        /// <value>The type of operation to perform for matching check</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchCriteria" /> class.
        /// </summary>
        /// <param name="JsonPath">The Goessner json path of the field to match.</param>
        /// <param name="Operator">The type of operation to perform for matching check.</param>
        /// <param name="Value">The value to match on. Only one of value and values can be included.</param>
        /// <param name="Values">The list of values to match on. Only one of value and values can be included.</param>
        public MatchCriteria(string JsonPath = null, OperatorEnum? Operator = null, Object Value = null, List<Object> Values = null)
        {
            this.JsonPath = JsonPath;
            this.Operator = Operator;
            this.Value = Value;
            this.Values = Values;
            
        }
        


        /// <summary>
        /// The Goessner json path of the field to match
        /// </summary>
        /// <value>The Goessner json path of the field to match</value>
        [DataMember(Name="jsonPath", EmitDefaultValue=false)]
        public string JsonPath { get; set; }





        /// <summary>
        /// The value to match on. Only one of value and values can be included
        /// </summary>
        /// <value>The value to match on. Only one of value and values can be included</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }



        /// <summary>
        /// The list of values to match on. Only one of value and values can be included
        /// </summary>
        /// <value>The list of values to match on. Only one of value and values can be included</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<Object> Values { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchCriteria {\n");

            sb.Append("  JsonPath: ").Append(JsonPath).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as MatchCriteria);
        }

        /// <summary>
        /// Returns true if MatchCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of MatchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.JsonPath == other.JsonPath ||
                    this.JsonPath != null &&
                    this.JsonPath.Equals(other.JsonPath)
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
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                if (this.JsonPath != null)
                    hash = hash * 59 + this.JsonPath.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                return hash;
            }
        }
    }

}
