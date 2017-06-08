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
    /// ContactListFilterNotificationFilterPredicate
    /// </summary>
    [DataContract]
    public partial class ContactListFilterNotificationFilterPredicate :  IEquatable<ContactListFilterNotificationFilterPredicate>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ColumnType
        /// </summary>
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
            /// Enum Numeric for "NUMERIC"
            /// </summary>
            [EnumMember(Value = "NUMERIC")]
            Numeric,
            
            /// <summary>
            /// Enum Alphabetic for "ALPHABETIC"
            /// </summary>
            [EnumMember(Value = "ALPHABETIC")]
            Alphabetic
        }
        
        
        
        
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
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
        /// Gets or Sets ColumnType
        /// </summary>
        [DataMember(Name="columnType", EmitDefaultValue=false)]
        public ColumnTypeEnum? ColumnType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListFilterNotificationFilterPredicate" /> class.
        /// </summary>
        
        
        /// <param name="Column">Column.</param>
        
        
        
        /// <param name="ColumnType">ColumnType.</param>
        
        
        
        /// <param name="_Operator">_Operator.</param>
        
        
        
        /// <param name="Value">Value.</param>
        
        
        
        /// <param name="Range">Range.</param>
        
        
        
        /// <param name="Inverted">Inverted.</param>
        
        
        
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        
        
        public ContactListFilterNotificationFilterPredicate(string Column = null, ColumnTypeEnum? ColumnType = null, OperatorEnum? _Operator = null, string Value = null, ContactListFilterNotificationRange Range = null, bool? Inverted = null, Object AdditionalProperties = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Column = Column;
            
            
            
            
            
            
            
            
this.ColumnType = ColumnType;
            
            
            
            
            
            
            
            
this._Operator = _Operator;
            
            
            
            
            
            
            
            
this.Value = Value;
            
            
            
            
            
            
            
            
this.Range = Range;
            
            
            
            
            
            
            
            
this.Inverted = Inverted;
            
            
            
            
            
            
            
            
this.AdditionalProperties = AdditionalProperties;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Column
        /// </summary>
        [DataMember(Name="column", EmitDefaultValue=false)]
        public string Column { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public ContactListFilterNotificationRange Range { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Inverted
        /// </summary>
        [DataMember(Name="inverted", EmitDefaultValue=false)]
        public bool? Inverted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListFilterNotificationFilterPredicate {\n");
            
            sb.Append("  Column: ").Append(Column).Append("\n");
            
            sb.Append("  ColumnType: ").Append(ColumnType).Append("\n");
            
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            
            sb.Append("  Value: ").Append(Value).Append("\n");
            
            sb.Append("  Range: ").Append(Range).Append("\n");
            
            sb.Append("  Inverted: ").Append(Inverted).Append("\n");
            
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            
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
            return this.Equals(obj as ContactListFilterNotificationFilterPredicate);
        }

        /// <summary>
        /// Returns true if ContactListFilterNotificationFilterPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactListFilterNotificationFilterPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListFilterNotificationFilterPredicate other)
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
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
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
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();
                
                if (this.Inverted != null)
                    hash = hash * 59 + this.Inverted.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
