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
    /// Condition
    /// </summary>
    [DataContract]
    public partial class Condition :  IEquatable<Condition>
    {
        
        
        /// <summary>
        /// The type of the condition.
        /// </summary>
        /// <value>The type of the condition.</value>
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
            /// Enum Wrapupcondition for "wrapupCondition"
            /// </summary>
            [EnumMember(Value = "wrapupCondition")]
            Wrapupcondition,
            
            /// <summary>
            /// Enum Contactattributecondition for "contactAttributeCondition"
            /// </summary>
            [EnumMember(Value = "contactAttributeCondition")]
            Contactattributecondition,
            
            /// <summary>
            /// Enum Phonenumbercondition for "phoneNumberCondition"
            /// </summary>
            [EnumMember(Value = "phoneNumberCondition")]
            Phonenumbercondition,
            
            /// <summary>
            /// Enum Phonenumbertypecondition for "phoneNumberTypeCondition"
            /// </summary>
            [EnumMember(Value = "phoneNumberTypeCondition")]
            Phonenumbertypecondition,
            
            /// <summary>
            /// Enum Callanalysiscondition for "callAnalysisCondition"
            /// </summary>
            [EnumMember(Value = "callAnalysisCondition")]
            Callanalysiscondition,
            
            /// <summary>
            /// Enum Contactpropertycondition for "contactPropertyCondition"
            /// </summary>
            [EnumMember(Value = "contactPropertyCondition")]
            Contactpropertycondition,
            
            /// <summary>
            /// Enum Dataactioncondition for "dataActionCondition"
            /// </summary>
            [EnumMember(Value = "dataActionCondition")]
            Dataactioncondition
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of the value associated with this Condition. Not used for a DataActionCondition.
        /// </summary>
        /// <value>The type of the value associated with this Condition. Not used for a DataActionCondition.</value>
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
            /// Enum String for "STRING"
            /// </summary>
            [EnumMember(Value = "STRING")]
            String,
            
            /// <summary>
            /// Enum Numeric for "NUMERIC"
            /// </summary>
            [EnumMember(Value = "NUMERIC")]
            Numeric,
            
            /// <summary>
            /// Enum Datetime for "DATETIME"
            /// </summary>
            [EnumMember(Value = "DATETIME")]
            Datetime,
            
            /// <summary>
            /// Enum Period for "PERIOD"
            /// </summary>
            [EnumMember(Value = "PERIOD")]
            Period
        }
        
        
        
        
        /// <summary>
        /// An operation with which to evaluate the Condition. Not used for a DataActionCondition.
        /// </summary>
        /// <value>An operation with which to evaluate the Condition. Not used for a DataActionCondition.</value>
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
            In
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of the property associated with this Condition. Required for a contactPropertyCondition.
        /// </summary>
        /// <value>The type of the property associated with this Condition. Required for a contactPropertyCondition.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PropertyTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum LastAttemptByColumn for "LAST_ATTEMPT_BY_COLUMN"
            /// </summary>
            [EnumMember(Value = "LAST_ATTEMPT_BY_COLUMN")]
            LastAttemptByColumn,
            
            /// <summary>
            /// Enum LastAttemptOverall for "LAST_ATTEMPT_OVERALL"
            /// </summary>
            [EnumMember(Value = "LAST_ATTEMPT_OVERALL")]
            LastAttemptOverall,
            
            /// <summary>
            /// Enum LastWrapupByColumn for "LAST_WRAPUP_BY_COLUMN"
            /// </summary>
            [EnumMember(Value = "LAST_WRAPUP_BY_COLUMN")]
            LastWrapupByColumn,
            
            /// <summary>
            /// Enum LastWrapupOverall for "LAST_WRAPUP_OVERALL"
            /// </summary>
            [EnumMember(Value = "LAST_WRAPUP_OVERALL")]
            LastWrapupOverall
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of the condition.
        /// </summary>
        /// <value>The type of the condition.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of the value associated with this Condition. Not used for a DataActionCondition.
        /// </summary>
        /// <value>The type of the value associated with this Condition. Not used for a DataActionCondition.</value>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public ValueTypeEnum? ValueType { get; set; }
        
        
        
        /// <summary>
        /// An operation with which to evaluate the Condition. Not used for a DataActionCondition.
        /// </summary>
        /// <value>An operation with which to evaluate the Condition. Not used for a DataActionCondition.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// The type of the property associated with this Condition. Required for a contactPropertyCondition.
        /// </summary>
        /// <value>The type of the property associated with this Condition. Required for a contactPropertyCondition.</value>
        [DataMember(Name="propertyType", EmitDefaultValue=false)]
        public PropertyTypeEnum? PropertyType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        /// <param name="Type">The type of the condition..</param>
        /// <param name="Inverted">If true, inverts the result of evaluating this Condition. Default is false..</param>
        /// <param name="AttributeName">An attribute name associated with this Condition. Required for a contactAttributeCondition..</param>
        /// <param name="Value">A value associated with this Condition. This could be text, a number, or a relative time. Not used for a DataActionCondition..</param>
        /// <param name="ValueType">The type of the value associated with this Condition. Not used for a DataActionCondition..</param>
        /// <param name="_Operator">An operation with which to evaluate the Condition. Not used for a DataActionCondition..</param>
        /// <param name="Codes">List of wrap-up code identifiers. Required for a wrapupCondition..</param>
        /// <param name="Property">A value associated with the property type of this Condition. Required for a contactPropertyCondition..</param>
        /// <param name="PropertyType">The type of the property associated with this Condition. Required for a contactPropertyCondition..</param>
        /// <param name="DataAction">The Data Action to use for this condition. Required for a dataActionCondition..</param>
        /// <param name="DataNotFoundResolution">The result of this condition if the data action returns a result indicating there was no data. Required for a DataActionCondition..</param>
        /// <param name="ContactIdField">The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionCondition..</param>
        /// <param name="CallAnalysisResultField">The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionCondition..</param>
        /// <param name="AgentWrapupField">The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionCondition..</param>
        /// <param name="ContactColumnToDataActionFieldMappings">A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionCondition..</param>
        /// <param name="Predicates">A list of predicates defining the comparisons to use for this condition. Required for a dataActionCondition..</param>
        public Condition(TypeEnum? Type = null, bool? Inverted = null, string AttributeName = null, string Value = null, ValueTypeEnum? ValueType = null, OperatorEnum? _Operator = null, List<string> Codes = null, string Property = null, PropertyTypeEnum? PropertyType = null, DomainEntityRef DataAction = null, bool? DataNotFoundResolution = null, string ContactIdField = null, string CallAnalysisResultField = null, string AgentWrapupField = null, List<ContactColumnToDataActionFieldMapping> ContactColumnToDataActionFieldMappings = null, List<DataActionConditionPredicate> Predicates = null)
        {
            this.Type = Type;
            this.Inverted = Inverted;
            this.AttributeName = AttributeName;
            this.Value = Value;
            this.ValueType = ValueType;
            this._Operator = _Operator;
            this.Codes = Codes;
            this.Property = Property;
            this.PropertyType = PropertyType;
            this.DataAction = DataAction;
            this.DataNotFoundResolution = DataNotFoundResolution;
            this.ContactIdField = ContactIdField;
            this.CallAnalysisResultField = CallAnalysisResultField;
            this.AgentWrapupField = AgentWrapupField;
            this.ContactColumnToDataActionFieldMappings = ContactColumnToDataActionFieldMappings;
            this.Predicates = Predicates;
            
        }
        
        
        
        
        
        /// <summary>
        /// If true, inverts the result of evaluating this Condition. Default is false.
        /// </summary>
        /// <value>If true, inverts the result of evaluating this Condition. Default is false.</value>
        [DataMember(Name="inverted", EmitDefaultValue=false)]
        public bool? Inverted { get; set; }
        
        
        
        /// <summary>
        /// An attribute name associated with this Condition. Required for a contactAttributeCondition.
        /// </summary>
        /// <value>An attribute name associated with this Condition. Required for a contactAttributeCondition.</value>
        [DataMember(Name="attributeName", EmitDefaultValue=false)]
        public string AttributeName { get; set; }
        
        
        
        /// <summary>
        /// A value associated with this Condition. This could be text, a number, or a relative time. Not used for a DataActionCondition.
        /// </summary>
        /// <value>A value associated with this Condition. This could be text, a number, or a relative time. Not used for a DataActionCondition.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// List of wrap-up code identifiers. Required for a wrapupCondition.
        /// </summary>
        /// <value>List of wrap-up code identifiers. Required for a wrapupCondition.</value>
        [DataMember(Name="codes", EmitDefaultValue=false)]
        public List<string> Codes { get; set; }
        
        
        
        /// <summary>
        /// A value associated with the property type of this Condition. Required for a contactPropertyCondition.
        /// </summary>
        /// <value>A value associated with the property type of this Condition. Required for a contactPropertyCondition.</value>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
        
        
        
        
        
        /// <summary>
        /// The Data Action to use for this condition. Required for a dataActionCondition.
        /// </summary>
        /// <value>The Data Action to use for this condition. Required for a dataActionCondition.</value>
        [DataMember(Name="dataAction", EmitDefaultValue=false)]
        public DomainEntityRef DataAction { get; set; }
        
        
        
        /// <summary>
        /// The result of this condition if the data action returns a result indicating there was no data. Required for a DataActionCondition.
        /// </summary>
        /// <value>The result of this condition if the data action returns a result indicating there was no data. Required for a DataActionCondition.</value>
        [DataMember(Name="dataNotFoundResolution", EmitDefaultValue=false)]
        public bool? DataNotFoundResolution { get; set; }
        
        
        
        /// <summary>
        /// The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionCondition.
        /// </summary>
        /// <value>The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionCondition.</value>
        [DataMember(Name="contactIdField", EmitDefaultValue=false)]
        public string ContactIdField { get; set; }
        
        
        
        /// <summary>
        /// The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionCondition.
        /// </summary>
        /// <value>The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionCondition.</value>
        [DataMember(Name="callAnalysisResultField", EmitDefaultValue=false)]
        public string CallAnalysisResultField { get; set; }
        
        
        
        /// <summary>
        /// The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionCondition.
        /// </summary>
        /// <value>The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionCondition.</value>
        [DataMember(Name="agentWrapupField", EmitDefaultValue=false)]
        public string AgentWrapupField { get; set; }
        
        
        
        /// <summary>
        /// A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionCondition.
        /// </summary>
        /// <value>A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionCondition.</value>
        [DataMember(Name="contactColumnToDataActionFieldMappings", EmitDefaultValue=false)]
        public List<ContactColumnToDataActionFieldMapping> ContactColumnToDataActionFieldMappings { get; set; }
        
        
        
        /// <summary>
        /// A list of predicates defining the comparisons to use for this condition. Required for a dataActionCondition.
        /// </summary>
        /// <value>A list of predicates defining the comparisons to use for this condition. Required for a dataActionCondition.</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<DataActionConditionPredicate> Predicates { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Condition {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Inverted: ").Append(Inverted).Append("\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  DataAction: ").Append(DataAction).Append("\n");
            sb.Append("  DataNotFoundResolution: ").Append(DataNotFoundResolution).Append("\n");
            sb.Append("  ContactIdField: ").Append(ContactIdField).Append("\n");
            sb.Append("  CallAnalysisResultField: ").Append(CallAnalysisResultField).Append("\n");
            sb.Append("  AgentWrapupField: ").Append(AgentWrapupField).Append("\n");
            sb.Append("  ContactColumnToDataActionFieldMappings: ").Append(ContactColumnToDataActionFieldMappings).Append("\n");
            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
            return this.Equals(obj as Condition);
        }

        /// <summary>
        /// Returns true if Condition instances are equal
        /// </summary>
        /// <param name="other">Instance of Condition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Condition other)
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
                    this.Inverted == other.Inverted ||
                    this.Inverted != null &&
                    this.Inverted.Equals(other.Inverted)
                ) &&
                (
                    this.AttributeName == other.AttributeName ||
                    this.AttributeName != null &&
                    this.AttributeName.Equals(other.AttributeName)
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
                ) &&
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Codes == other.Codes ||
                    this.Codes != null &&
                    this.Codes.SequenceEqual(other.Codes)
                ) &&
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) &&
                (
                    this.PropertyType == other.PropertyType ||
                    this.PropertyType != null &&
                    this.PropertyType.Equals(other.PropertyType)
                ) &&
                (
                    this.DataAction == other.DataAction ||
                    this.DataAction != null &&
                    this.DataAction.Equals(other.DataAction)
                ) &&
                (
                    this.DataNotFoundResolution == other.DataNotFoundResolution ||
                    this.DataNotFoundResolution != null &&
                    this.DataNotFoundResolution.Equals(other.DataNotFoundResolution)
                ) &&
                (
                    this.ContactIdField == other.ContactIdField ||
                    this.ContactIdField != null &&
                    this.ContactIdField.Equals(other.ContactIdField)
                ) &&
                (
                    this.CallAnalysisResultField == other.CallAnalysisResultField ||
                    this.CallAnalysisResultField != null &&
                    this.CallAnalysisResultField.Equals(other.CallAnalysisResultField)
                ) &&
                (
                    this.AgentWrapupField == other.AgentWrapupField ||
                    this.AgentWrapupField != null &&
                    this.AgentWrapupField.Equals(other.AgentWrapupField)
                ) &&
                (
                    this.ContactColumnToDataActionFieldMappings == other.ContactColumnToDataActionFieldMappings ||
                    this.ContactColumnToDataActionFieldMappings != null &&
                    this.ContactColumnToDataActionFieldMappings.SequenceEqual(other.ContactColumnToDataActionFieldMappings)
                ) &&
                (
                    this.Predicates == other.Predicates ||
                    this.Predicates != null &&
                    this.Predicates.SequenceEqual(other.Predicates)
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
                
                if (this.Inverted != null)
                    hash = hash * 59 + this.Inverted.GetHashCode();
                
                if (this.AttributeName != null)
                    hash = hash * 59 + this.AttributeName.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.ValueType != null)
                    hash = hash * 59 + this.ValueType.GetHashCode();
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Codes != null)
                    hash = hash * 59 + this.Codes.GetHashCode();
                
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                
                if (this.PropertyType != null)
                    hash = hash * 59 + this.PropertyType.GetHashCode();
                
                if (this.DataAction != null)
                    hash = hash * 59 + this.DataAction.GetHashCode();
                
                if (this.DataNotFoundResolution != null)
                    hash = hash * 59 + this.DataNotFoundResolution.GetHashCode();
                
                if (this.ContactIdField != null)
                    hash = hash * 59 + this.ContactIdField.GetHashCode();
                
                if (this.CallAnalysisResultField != null)
                    hash = hash * 59 + this.CallAnalysisResultField.GetHashCode();
                
                if (this.AgentWrapupField != null)
                    hash = hash * 59 + this.AgentWrapupField.GetHashCode();
                
                if (this.ContactColumnToDataActionFieldMappings != null)
                    hash = hash * 59 + this.ContactColumnToDataActionFieldMappings.GetHashCode();
                
                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();
                
                return hash;
            }
        }
    }

}
