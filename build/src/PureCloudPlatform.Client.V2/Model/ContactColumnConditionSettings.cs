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
    /// ContactColumnConditionSettings
    /// </summary>
    [DataContract]
    public partial class ContactColumnConditionSettings :  IEquatable<ContactColumnConditionSettings>
    {
        /// <summary>
        /// The operator to use when comparing values.
        /// </summary>
        /// <value>The operator to use when comparing values.</value>
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
            /// Enum Equals for "Equals"
            /// </summary>
            [EnumMember(Value = "Equals")]
            Equals,
            
            /// <summary>
            /// Enum Lessthan for "LessThan"
            /// </summary>
            [EnumMember(Value = "LessThan")]
            Lessthan,
            
            /// <summary>
            /// Enum Lessthanequals for "LessThanEquals"
            /// </summary>
            [EnumMember(Value = "LessThanEquals")]
            Lessthanequals,
            
            /// <summary>
            /// Enum Greaterthan for "GreaterThan"
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            Greaterthan,
            
            /// <summary>
            /// Enum Greaterthanequals for "GreaterThanEquals"
            /// </summary>
            [EnumMember(Value = "GreaterThanEquals")]
            Greaterthanequals,
            
            /// <summary>
            /// Enum Contains for "Contains"
            /// </summary>
            [EnumMember(Value = "Contains")]
            Contains,
            
            /// <summary>
            /// Enum Beginswith for "BeginsWith"
            /// </summary>
            [EnumMember(Value = "BeginsWith")]
            Beginswith,
            
            /// <summary>
            /// Enum Endswith for "EndsWith"
            /// </summary>
            [EnumMember(Value = "EndsWith")]
            Endswith,
            
            /// <summary>
            /// Enum Before for "Before"
            /// </summary>
            [EnumMember(Value = "Before")]
            Before,
            
            /// <summary>
            /// Enum After for "After"
            /// </summary>
            [EnumMember(Value = "After")]
            After
        }
        /// <summary>
        /// The data type the value should be treated as.
        /// </summary>
        /// <value>The data type the value should be treated as.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ValueTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Datetime for "DateTime"
            /// </summary>
            [EnumMember(Value = "DateTime")]
            Datetime,
            
            /// <summary>
            /// Enum Numeric for "Numeric"
            /// </summary>
            [EnumMember(Value = "Numeric")]
            Numeric,
            
            /// <summary>
            /// Enum Period for "Period"
            /// </summary>
            [EnumMember(Value = "Period")]
            Period,
            
            /// <summary>
            /// Enum String for "String"
            /// </summary>
            [EnumMember(Value = "String")]
            String
        }
        /// <summary>
        /// The operator to use when comparing values.
        /// </summary>
        /// <value>The operator to use when comparing values.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// The data type the value should be treated as.
        /// </summary>
        /// <value>The data type the value should be treated as.</value>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public ValueTypeEnum? ValueType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactColumnConditionSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactColumnConditionSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactColumnConditionSettings" /> class.
        /// </summary>
        /// <param name="ColumnName">The name of the contact list column to evaluate. (required).</param>
        /// <param name="Operator">The operator to use when comparing values. (required).</param>
        /// <param name="Value">The value to compare against the contact's data. (required).</param>
        /// <param name="ValueType">The data type the value should be treated as. (required).</param>
        public ContactColumnConditionSettings(string ColumnName = null, OperatorEnum? Operator = null, string Value = null, ValueTypeEnum? ValueType = null)
        {
            this.ColumnName = ColumnName;
            this.Operator = Operator;
            this.Value = Value;
            this.ValueType = ValueType;
            
        }
        


        /// <summary>
        /// The name of the contact list column to evaluate.
        /// </summary>
        /// <value>The name of the contact list column to evaluate.</value>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; set; }





        /// <summary>
        /// The value to compare against the contact's data.
        /// </summary>
        /// <value>The value to compare against the contact's data.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactColumnConditionSettings {\n");

            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
            return this.Equals(obj as ContactColumnConditionSettings);
        }

        /// <summary>
        /// Returns true if ContactColumnConditionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactColumnConditionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactColumnConditionSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ColumnName == other.ColumnName ||
                    this.ColumnName != null &&
                    this.ColumnName.Equals(other.ColumnName)
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
                    this.ValueType == other.ValueType ||
                    this.ValueType != null &&
                    this.ValueType.Equals(other.ValueType)
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
                if (this.ColumnName != null)
                    hash = hash * 59 + this.ColumnName.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.ValueType != null)
                    hash = hash * 59 + this.ValueType.GetHashCode();

                return hash;
            }
        }
    }

}
