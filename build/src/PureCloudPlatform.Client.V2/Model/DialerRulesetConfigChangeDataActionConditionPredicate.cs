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
    /// DialerRulesetConfigChangeDataActionConditionPredicate
    /// </summary>
    [DataContract]
    public partial class DialerRulesetConfigChangeDataActionConditionPredicate :  IEquatable<DialerRulesetConfigChangeDataActionConditionPredicate>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets OutputOperator
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OutputOperatorEnum
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
            After
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets OutputOperator
        /// </summary>
        [DataMember(Name="outputOperator", EmitDefaultValue=false)]
        public OutputOperatorEnum? OutputOperator { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerRulesetConfigChangeDataActionConditionPredicate" /> class.
        /// </summary>
        /// <param name="OutputField">OutputField.</param>
        /// <param name="OutputOperator">OutputOperator.</param>
        /// <param name="ComparisonValue">ComparisonValue.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public DialerRulesetConfigChangeDataActionConditionPredicate(string OutputField = null, OutputOperatorEnum? OutputOperator = null, string ComparisonValue = null, Object AdditionalProperties = null)
        {
            this.OutputField = OutputField;
            this.OutputOperator = OutputOperator;
            this.ComparisonValue = ComparisonValue;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets OutputField
        /// </summary>
        [DataMember(Name="outputField", EmitDefaultValue=false)]
        public string OutputField { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ComparisonValue
        /// </summary>
        [DataMember(Name="comparisonValue", EmitDefaultValue=false)]
        public string ComparisonValue { get; set; }
        
        
        
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
            sb.Append("class DialerRulesetConfigChangeDataActionConditionPredicate {\n");
            
            sb.Append("  OutputField: ").Append(OutputField).Append("\n");
            sb.Append("  OutputOperator: ").Append(OutputOperator).Append("\n");
            sb.Append("  ComparisonValue: ").Append(ComparisonValue).Append("\n");
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
            return this.Equals(obj as DialerRulesetConfigChangeDataActionConditionPredicate);
        }

        /// <summary>
        /// Returns true if DialerRulesetConfigChangeDataActionConditionPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerRulesetConfigChangeDataActionConditionPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerRulesetConfigChangeDataActionConditionPredicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OutputField == other.OutputField ||
                    this.OutputField != null &&
                    this.OutputField.Equals(other.OutputField)
                ) &&
                (
                    this.OutputOperator == other.OutputOperator ||
                    this.OutputOperator != null &&
                    this.OutputOperator.Equals(other.OutputOperator)
                ) &&
                (
                    this.ComparisonValue == other.ComparisonValue ||
                    this.ComparisonValue != null &&
                    this.ComparisonValue.Equals(other.ComparisonValue)
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
                
                if (this.OutputField != null)
                    hash = hash * 59 + this.OutputField.GetHashCode();
                
                if (this.OutputOperator != null)
                    hash = hash * 59 + this.OutputOperator.GetHashCode();
                
                if (this.ComparisonValue != null)
                    hash = hash * 59 + this.ComparisonValue.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
