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
    /// TranscriptSearchCriteria
    /// </summary>
    [DataContract]
    public partial class TranscriptSearchCriteria :  IEquatable<TranscriptSearchCriteria>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// How to apply this search criteria against other criteria
        /// </summary>
        /// <value>How to apply this search criteria against other criteria</value>
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
            /// Enum And for "AND"
            /// </summary>
            [EnumMember(Value = "AND")]
            And,
            
            /// <summary>
            /// Enum Or for "OR"
            /// </summary>
            [EnumMember(Value = "OR")]
            Or,
            
            /// <summary>
            /// Enum Not for "NOT"
            /// </summary>
            [EnumMember(Value = "NOT")]
            Not
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum Exact for "EXACT"
            /// </summary>
            [EnumMember(Value = "EXACT")]
            Exact,
            
            /// <summary>
            /// Enum ExactPhrase for "EXACT_PHRASE"
            /// </summary>
            [EnumMember(Value = "EXACT_PHRASE")]
            ExactPhrase,
            
            /// <summary>
            /// Enum Phrase for "PHRASE"
            /// </summary>
            [EnumMember(Value = "PHRASE")]
            Phrase,
            
            /// <summary>
            /// Enum DateRange for "DATE_RANGE"
            /// </summary>
            [EnumMember(Value = "DATE_RANGE")]
            DateRange,
            
            /// <summary>
            /// Enum Range for "RANGE"
            /// </summary>
            [EnumMember(Value = "RANGE")]
            Range,
            
            /// <summary>
            /// Enum GreaterThan for "GREATER_THAN"
            /// </summary>
            [EnumMember(Value = "GREATER_THAN")]
            GreaterThan,
            
            /// <summary>
            /// Enum LessThan for "LESS_THAN"
            /// </summary>
            [EnumMember(Value = "LESS_THAN")]
            LessThan
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// How to apply this search criteria against other criteria
        /// </summary>
        /// <value>How to apply this search criteria against other criteria</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptSearchCriteria" /> class.
        /// </summary>
        /// <param name="EndValue">The end value of the range. This field is used for range search types..</param>
        /// <param name="Values">A list of values for the search to match against.</param>
        /// <param name="StartValue">The start value of the range. This field is used for range search types..</param>
        /// <param name="Fields">Field names to search against.</param>
        /// <param name="Value">A value for the search to match against.</param>
        /// <param name="_Operator">How to apply this search criteria against other criteria.</param>
        /// <param name="Group">Groups multiple conditions.</param>
        /// <param name="DateFormat">Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX..</param>
        /// <param name="Type">Type.</param>
        public TranscriptSearchCriteria(string EndValue = null, List<string> Values = null, string StartValue = null, List<string> Fields = null, string Value = null, OperatorEnum? _Operator = null, List<TranscriptSearchCriteria> Group = null, string DateFormat = null, TypeEnum? Type = null)
        {
            this.EndValue = EndValue;
            this.Values = Values;
            this.StartValue = StartValue;
            this.Fields = Fields;
            this.Value = Value;
            this._Operator = _Operator;
            this.Group = Group;
            this.DateFormat = DateFormat;
            this.Type = Type;
            
        }
        
        
        
        /// <summary>
        /// The end value of the range. This field is used for range search types.
        /// </summary>
        /// <value>The end value of the range. This field is used for range search types.</value>
        [DataMember(Name="endValue", EmitDefaultValue=false)]
        public string EndValue { get; set; }
        
        
        
        /// <summary>
        /// A list of values for the search to match against
        /// </summary>
        /// <value>A list of values for the search to match against</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
        
        
        
        /// <summary>
        /// The start value of the range. This field is used for range search types.
        /// </summary>
        /// <value>The start value of the range. This field is used for range search types.</value>
        [DataMember(Name="startValue", EmitDefaultValue=false)]
        public string StartValue { get; set; }
        
        
        
        /// <summary>
        /// Field names to search against
        /// </summary>
        /// <value>Field names to search against</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }
        
        
        
        /// <summary>
        /// A value for the search to match against
        /// </summary>
        /// <value>A value for the search to match against</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        
        
        /// <summary>
        /// Groups multiple conditions
        /// </summary>
        /// <value>Groups multiple conditions</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public List<TranscriptSearchCriteria> Group { get; set; }
        
        
        
        /// <summary>
        /// Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX.
        /// </summary>
        /// <value>Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX.</value>
        [DataMember(Name="dateFormat", EmitDefaultValue=false)]
        public string DateFormat { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptSearchCriteria {\n");
            
            sb.Append("  EndValue: ").Append(EndValue).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  StartValue: ").Append(StartValue).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as TranscriptSearchCriteria);
        }

        /// <summary>
        /// Returns true if TranscriptSearchCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptSearchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptSearchCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EndValue == other.EndValue ||
                    this.EndValue != null &&
                    this.EndValue.Equals(other.EndValue)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) &&
                (
                    this.StartValue == other.StartValue ||
                    this.StartValue != null &&
                    this.StartValue.Equals(other.StartValue)
                ) &&
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.SequenceEqual(other.Group)
                ) &&
                (
                    this.DateFormat == other.DateFormat ||
                    this.DateFormat != null &&
                    this.DateFormat.Equals(other.DateFormat)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.EndValue != null)
                    hash = hash * 59 + this.EndValue.GetHashCode();
                
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                
                if (this.StartValue != null)
                    hash = hash * 59 + this.StartValue.GetHashCode();
                
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                
                if (this.DateFormat != null)
                    hash = hash * 59 + this.DateFormat.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }
    }

}
