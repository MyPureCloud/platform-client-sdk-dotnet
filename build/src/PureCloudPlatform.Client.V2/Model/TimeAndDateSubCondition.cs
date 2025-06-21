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
    /// TimeAndDateSubCondition
    /// </summary>
    [DataContract]
    public partial class TimeAndDateSubCondition :  IEquatable<TimeAndDateSubCondition>
    {
        /// <summary>
        /// The type of time/date sub-condition.
        /// </summary>
        /// <value>The type of time/date sub-condition.</value>
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
            /// Enum Timeofday for "timeOfDay"
            /// </summary>
            [EnumMember(Value = "timeOfDay")]
            Timeofday,
            
            /// <summary>
            /// Enum Dayofweek for "dayOfWeek"
            /// </summary>
            [EnumMember(Value = "dayOfWeek")]
            Dayofweek,
            
            /// <summary>
            /// Enum Dayofmonth for "dayOfMonth"
            /// </summary>
            [EnumMember(Value = "dayOfMonth")]
            Dayofmonth,
            
            /// <summary>
            /// Enum Specificdate for "specificDate"
            /// </summary>
            [EnumMember(Value = "specificDate")]
            Specificdate
        }
        /// <summary>
        /// The operator to use for comparison.
        /// </summary>
        /// <value>The operator to use for comparison.</value>
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
            /// Enum In for "IN"
            /// </summary>
            [EnumMember(Value = "IN")]
            In,
            
            /// <summary>
            /// Enum Between for "BETWEEN"
            /// </summary>
            [EnumMember(Value = "BETWEEN")]
            Between
        }
        /// <summary>
        /// The type of time/date sub-condition.
        /// </summary>
        /// <value>The type of time/date sub-condition.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The operator to use for comparison.
        /// </summary>
        /// <value>The operator to use for comparison.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeAndDateSubCondition" /> class.
        /// </summary>
        /// <param name="Type">The type of time/date sub-condition..</param>
        /// <param name="Operator">The operator to use for comparison..</param>
        /// <param name="Inverted">If true, inverts the result of evaluating this sub-condition. Default is false..</param>
        /// <param name="IncludeYear">If true, includes year in date comparison for specificDate type. When false, only month and day are compared. Default is true. Only applicable for specificDate type..</param>
        /// <param name="ThresholdValue">Threshold value for BEFORE or AFTER operators. Format depends on type: timeOfDay: HH:mm, dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31 and/ or LAST_DAY, ODD_DAY, EVEN_DAY, specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false). For single-value comparison, use a list with one element..</param>
        /// <param name="Range">A range of values for BETWEEN and IN operators. Format follows the same rules as &#39;thresholdValue&#39;..</param>
        public TimeAndDateSubCondition(TypeEnum? Type = null, OperatorEnum? Operator = null, bool? Inverted = null, bool? IncludeYear = null, string ThresholdValue = null, TimeAndDateSubConditionRange Range = null)
        {
            this.Type = Type;
            this.Operator = Operator;
            this.Inverted = Inverted;
            this.IncludeYear = IncludeYear;
            this.ThresholdValue = ThresholdValue;
            this.Range = Range;
            
        }
        






        /// <summary>
        /// If true, inverts the result of evaluating this sub-condition. Default is false.
        /// </summary>
        /// <value>If true, inverts the result of evaluating this sub-condition. Default is false.</value>
        [DataMember(Name="inverted", EmitDefaultValue=false)]
        public bool? Inverted { get; set; }



        /// <summary>
        /// If true, includes year in date comparison for specificDate type. When false, only month and day are compared. Default is true. Only applicable for specificDate type.
        /// </summary>
        /// <value>If true, includes year in date comparison for specificDate type. When false, only month and day are compared. Default is true. Only applicable for specificDate type.</value>
        [DataMember(Name="includeYear", EmitDefaultValue=false)]
        public bool? IncludeYear { get; set; }



        /// <summary>
        /// Threshold value for BEFORE or AFTER operators. Format depends on type: timeOfDay: HH:mm, dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31 and/ or LAST_DAY, ODD_DAY, EVEN_DAY, specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false). For single-value comparison, use a list with one element.
        /// </summary>
        /// <value>Threshold value for BEFORE or AFTER operators. Format depends on type: timeOfDay: HH:mm, dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31 and/ or LAST_DAY, ODD_DAY, EVEN_DAY, specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false). For single-value comparison, use a list with one element.</value>
        [DataMember(Name="thresholdValue", EmitDefaultValue=false)]
        public string ThresholdValue { get; set; }



        /// <summary>
        /// A range of values for BETWEEN and IN operators. Format follows the same rules as &#39;thresholdValue&#39;.
        /// </summary>
        /// <value>A range of values for BETWEEN and IN operators. Format follows the same rules as &#39;thresholdValue&#39;.</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public TimeAndDateSubConditionRange Range { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeAndDateSubCondition {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Inverted: ").Append(Inverted).Append("\n");
            sb.Append("  IncludeYear: ").Append(IncludeYear).Append("\n");
            sb.Append("  ThresholdValue: ").Append(ThresholdValue).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(obj as TimeAndDateSubCondition);
        }

        /// <summary>
        /// Returns true if TimeAndDateSubCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeAndDateSubCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeAndDateSubCondition other)
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
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Inverted == other.Inverted ||
                    this.Inverted != null &&
                    this.Inverted.Equals(other.Inverted)
                ) &&
                (
                    this.IncludeYear == other.IncludeYear ||
                    this.IncludeYear != null &&
                    this.IncludeYear.Equals(other.IncludeYear)
                ) &&
                (
                    this.ThresholdValue == other.ThresholdValue ||
                    this.ThresholdValue != null &&
                    this.ThresholdValue.Equals(other.ThresholdValue)
                ) &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
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

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Inverted != null)
                    hash = hash * 59 + this.Inverted.GetHashCode();

                if (this.IncludeYear != null)
                    hash = hash * 59 + this.IncludeYear.GetHashCode();

                if (this.ThresholdValue != null)
                    hash = hash * 59 + this.ThresholdValue.GetHashCode();

                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();

                return hash;
            }
        }
    }

}
