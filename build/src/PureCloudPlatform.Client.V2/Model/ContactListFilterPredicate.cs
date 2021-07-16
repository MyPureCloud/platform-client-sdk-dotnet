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
    /// ContactListFilterPredicate
    /// </summary>
    [DataContract]
    public partial class ContactListFilterPredicate :  IEquatable<ContactListFilterPredicate>
    {
        
        
        
        
        
        /// <summary>
        /// The type of data in the contact column.
        /// </summary>
        /// <value>The type of data in the contact column.</value>
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
        /// The operator for this ContactListFilterPredicate.
        /// </summary>
        /// <value>The operator for this ContactListFilterPredicate.</value>
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
        /// The type of data in the contact column.
        /// </summary>
        /// <value>The type of data in the contact column.</value>
        [DataMember(Name="columnType", EmitDefaultValue=false)]
        public ColumnTypeEnum? ColumnType { get; set; }
        
        
        
        /// <summary>
        /// The operator for this ContactListFilterPredicate.
        /// </summary>
        /// <value>The operator for this ContactListFilterPredicate.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListFilterPredicate" /> class.
        /// </summary>
        /// <param name="Column">Contact list column from the ContactListFilter&#39;s contactList..</param>
        /// <param name="ColumnType">The type of data in the contact column..</param>
        /// <param name="_Operator">The operator for this ContactListFilterPredicate..</param>
        /// <param name="Value">Value with which to compare the contact&#39;s data. This could be text, a number, or a relative time. A value for relative time should follow the format PxxDTyyHzzM, where xx, yy, and zz specify the days, hours and minutes. For example, a value of P01DT08H30M corresponds to 1 day, 8 hours, and 30 minutes from now. To specify a time in the past, include a negative sign before each numeric value. For example, a value of P-01DT-08H-30M corresponds to 1 day, 8 hours, and 30 minutes in the past. You can also do things like P01DT00H-30M, which would correspond to 23 hours and 30 minutes from now (1 day - 30 minutes)..</param>
        /// <param name="Range">A range of values. Required for operators BETWEEN and IN..</param>
        /// <param name="Inverted">Inverts the result of the predicate (i.e., if the predicate returns true, inverting it will return false)..</param>
        public ContactListFilterPredicate(string Column = null, ColumnTypeEnum? ColumnType = null, OperatorEnum? _Operator = null, string Value = null, ContactListFilterRange Range = null, bool? Inverted = null)
        {
            this.Column = Column;
            this.ColumnType = ColumnType;
            this._Operator = _Operator;
            this.Value = Value;
            this.Range = Range;
            this.Inverted = Inverted;
            
        }
        
        
        
        /// <summary>
        /// Contact list column from the ContactListFilter&#39;s contactList.
        /// </summary>
        /// <value>Contact list column from the ContactListFilter&#39;s contactList.</value>
        [DataMember(Name="column", EmitDefaultValue=false)]
        public string Column { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Value with which to compare the contact&#39;s data. This could be text, a number, or a relative time. A value for relative time should follow the format PxxDTyyHzzM, where xx, yy, and zz specify the days, hours and minutes. For example, a value of P01DT08H30M corresponds to 1 day, 8 hours, and 30 minutes from now. To specify a time in the past, include a negative sign before each numeric value. For example, a value of P-01DT-08H-30M corresponds to 1 day, 8 hours, and 30 minutes in the past. You can also do things like P01DT00H-30M, which would correspond to 23 hours and 30 minutes from now (1 day - 30 minutes).
        /// </summary>
        /// <value>Value with which to compare the contact&#39;s data. This could be text, a number, or a relative time. A value for relative time should follow the format PxxDTyyHzzM, where xx, yy, and zz specify the days, hours and minutes. For example, a value of P01DT08H30M corresponds to 1 day, 8 hours, and 30 minutes from now. To specify a time in the past, include a negative sign before each numeric value. For example, a value of P-01DT-08H-30M corresponds to 1 day, 8 hours, and 30 minutes in the past. You can also do things like P01DT00H-30M, which would correspond to 23 hours and 30 minutes from now (1 day - 30 minutes).</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// A range of values. Required for operators BETWEEN and IN.
        /// </summary>
        /// <value>A range of values. Required for operators BETWEEN and IN.</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public ContactListFilterRange Range { get; set; }
        
        
        
        /// <summary>
        /// Inverts the result of the predicate (i.e., if the predicate returns true, inverting it will return false).
        /// </summary>
        /// <value>Inverts the result of the predicate (i.e., if the predicate returns true, inverting it will return false).</value>
        [DataMember(Name="inverted", EmitDefaultValue=false)]
        public bool? Inverted { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListFilterPredicate {\n");
            
            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  ColumnType: ").Append(ColumnType).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Inverted: ").Append(Inverted).Append("\n");
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
            return this.Equals(obj as ContactListFilterPredicate);
        }

        /// <summary>
        /// Returns true if ContactListFilterPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactListFilterPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListFilterPredicate other)
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
                
                return hash;
            }
        }
    }

}
