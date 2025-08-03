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
    /// DialerContactlistfilterConfigChangeFilterPredicate
    /// </summary>
    [DataContract]
    public partial class DialerContactlistfilterConfigChangeFilterPredicate :  IEquatable<DialerContactlistfilterConfigChangeFilterPredicate>
    {
        /// <summary>
        /// Whether a contact column is numeric or alphabetic
        /// </summary>
        /// <value>Whether a contact column is numeric or alphabetic</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ColumnTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Numeric for "numeric"
            /// </summary>
            [EnumMember(Value = "numeric")]
            Numeric,
            
            /// <summary>
            /// Enum Alphabetic for "alphabetic"
            /// </summary>
            [EnumMember(Value = "alphabetic")]
            Alphabetic
        }
        /// <summary>
        /// The comparison operator
        /// </summary>
        /// <value>The comparison operator</value>
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
            /// Enum Equals for "EQUALS"
            /// </summary>
            [EnumMember(Value = "EQUALS")]
            Equals,
            
            /// <summary>
            /// Enum LessThan for "LESS_THAN"
            /// </summary>
            [EnumMember(Value = "LESS_THAN")]
            LessThan,
            
            /// <summary>
            /// Enum LessThanEquals for "LESS_THAN_EQUALS"
            /// </summary>
            [EnumMember(Value = "LESS_THAN_EQUALS")]
            LessThanEquals,
            
            /// <summary>
            /// Enum GreaterThan for "GREATER_THAN"
            /// </summary>
            [EnumMember(Value = "GREATER_THAN")]
            GreaterThan,
            
            /// <summary>
            /// Enum GreaterThanEquals for "GREATER_THAN_EQUALS"
            /// </summary>
            [EnumMember(Value = "GREATER_THAN_EQUALS")]
            GreaterThanEquals,
            
            /// <summary>
            /// Enum Contains for "CONTAINS"
            /// </summary>
            [EnumMember(Value = "CONTAINS")]
            Contains,
            
            /// <summary>
            /// Enum BeginsWith for "BEGINS_WITH"
            /// </summary>
            [EnumMember(Value = "BEGINS_WITH")]
            BeginsWith,
            
            /// <summary>
            /// Enum EndsWith for "ENDS_WITH"
            /// </summary>
            [EnumMember(Value = "ENDS_WITH")]
            EndsWith,
            
            /// <summary>
            /// Enum Before for "BEFORE"
            /// </summary>
            [EnumMember(Value = "BEFORE")]
            Before,
            
            /// <summary>
            /// Enum After for "AFTER"
            /// </summary>
            [EnumMember(Value = "AFTER")]
            After,
            
            /// <summary>
            /// Enum Between for "BETWEEN"
            /// </summary>
            [EnumMember(Value = "BETWEEN")]
            Between,
            
            /// <summary>
            /// Enum In for "IN"
            /// </summary>
            [EnumMember(Value = "IN")]
            In
        }
        /// <summary>
        /// Whether a contact column is numeric or alphabetic
        /// </summary>
        /// <value>Whether a contact column is numeric or alphabetic</value>
        [DataMember(Name="columnType", EmitDefaultValue=false)]
        public ColumnTypeEnum? ColumnType { get; set; }
        /// <summary>
        /// The comparison operator
        /// </summary>
        /// <value>The comparison operator</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerContactlistfilterConfigChangeFilterPredicate" /> class.
        /// </summary>
        /// <param name="Column">The contact list column.</param>
        /// <param name="ColumnType">Whether a contact column is numeric or alphabetic.</param>
        /// <param name="Operator">The comparison operator.</param>
        /// <param name="Value">The value the predicate applies to.</param>
        /// <param name="Range">Range.</param>
        /// <param name="Inverted">Whether or not to invert to result of evaluating the predicate.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
        public DialerContactlistfilterConfigChangeFilterPredicate(string Column = null, ColumnTypeEnum? ColumnType = null, OperatorEnum? Operator = null, string Value = null, DialerContactlistfilterConfigChangeFilterRange Range = null, bool? Inverted = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
        {
            this.Column = Column;
            this.ColumnType = ColumnType;
            this.Operator = Operator;
            this.Value = Value;
            this.Range = Range;
            this.Inverted = Inverted;
            this.AdditionalProperties = AdditionalProperties;
            this.GetAdditionalProperties = GetAdditionalProperties;
            
        }
        


        /// <summary>
        /// The contact list column
        /// </summary>
        /// <value>The contact list column</value>
        [DataMember(Name="column", EmitDefaultValue=false)]
        public string Column { get; set; }







        /// <summary>
        /// The value the predicate applies to
        /// </summary>
        /// <value>The value the predicate applies to</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }



        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public DialerContactlistfilterConfigChangeFilterRange Range { get; set; }



        /// <summary>
        /// Whether or not to invert to result of evaluating the predicate
        /// </summary>
        /// <value>Whether or not to invert to result of evaluating the predicate</value>
        [DataMember(Name="inverted", EmitDefaultValue=false)]
        public bool? Inverted { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }



        /// <summary>
        /// Gets or Sets GetAdditionalProperties
        /// </summary>
        [DataMember(Name="getAdditionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> GetAdditionalProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerContactlistfilterConfigChangeFilterPredicate {\n");

            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  ColumnType: ").Append(ColumnType).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Inverted: ").Append(Inverted).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
            return this.Equals(obj as DialerContactlistfilterConfigChangeFilterPredicate);
        }

        /// <summary>
        /// Returns true if DialerContactlistfilterConfigChangeFilterPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerContactlistfilterConfigChangeFilterPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerContactlistfilterConfigChangeFilterPredicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Column == other.Column ||
                    this.Column != null &&
                    this.Column.Equals(other.Column)
                ) &&
                (
                    this.ColumnType == other.ColumnType ||
                    this.ColumnType != null &&
                    this.ColumnType.Equals(other.ColumnType)
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
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
                ) &&
                (
                    this.Inverted == other.Inverted ||
                    this.Inverted != null &&
                    this.Inverted.Equals(other.Inverted)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) &&
                (
                    this.GetAdditionalProperties == other.GetAdditionalProperties ||
                    this.GetAdditionalProperties != null &&
                    this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
                if (this.Column != null)
                    hash = hash * 59 + this.Column.GetHashCode();

                if (this.ColumnType != null)
                    hash = hash * 59 + this.ColumnType.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();

                if (this.Inverted != null)
                    hash = hash * 59 + this.Inverted.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                if (this.GetAdditionalProperties != null)
                    hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

                return hash;
            }
        }
    }

}
