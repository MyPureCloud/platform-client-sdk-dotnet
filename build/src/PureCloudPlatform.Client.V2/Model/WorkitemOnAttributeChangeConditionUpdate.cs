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
    /// WorkitemOnAttributeChangeConditionUpdate
    /// </summary>
    [DataContract]
    public partial class WorkitemOnAttributeChangeConditionUpdate :  IEquatable<WorkitemOnAttributeChangeConditionUpdate>
    {
        /// <summary>
        /// The name of the workitem attribute whose change will be evaluated as part of the rule.
        /// </summary>
        /// <value>The name of the workitem attribute whose change will be evaluated as part of the rule.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AttributeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Statusid for "statusId"
            /// </summary>
            [EnumMember(Value = "statusId")]
            Statusid,
            
            /// <summary>
            /// Enum Priority for "priority"
            /// </summary>
            [EnumMember(Value = "priority")]
            Priority,
            
            /// <summary>
            /// Enum Queueid for "queueId"
            /// </summary>
            [EnumMember(Value = "queueId")]
            Queueid,
            
            /// <summary>
            /// Enum Assigneeid for "assigneeId"
            /// </summary>
            [EnumMember(Value = "assigneeId")]
            Assigneeid,
            
            /// <summary>
            /// Enum Assignmentstate for "assignmentState"
            /// </summary>
            [EnumMember(Value = "assignmentState")]
            Assignmentstate,
            
            /// <summary>
            /// Enum Languageid for "languageId"
            /// </summary>
            [EnumMember(Value = "languageId")]
            Languageid,
            
            /// <summary>
            /// Enum Externaltag for "externalTag"
            /// </summary>
            [EnumMember(Value = "externalTag")]
            Externaltag
        }
        /// <summary>
        /// How the attribute's new value is compared against newValue. Only supported for the priority attribute.
        /// </summary>
        /// <value>How the attribute's new value is compared against newValue. Only supported for the priority attribute.</value>
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
            /// Enum Eq for "EQ"
            /// </summary>
            [EnumMember(Value = "EQ")]
            Eq,
            
            /// <summary>
            /// Enum Gt for "GT"
            /// </summary>
            [EnumMember(Value = "GT")]
            Gt,
            
            /// <summary>
            /// Enum Lt for "LT"
            /// </summary>
            [EnumMember(Value = "LT")]
            Lt,
            
            /// <summary>
            /// Enum Gte for "GTE"
            /// </summary>
            [EnumMember(Value = "GTE")]
            Gte,
            
            /// <summary>
            /// Enum Lte for "LTE"
            /// </summary>
            [EnumMember(Value = "LTE")]
            Lte
        }
        /// <summary>
        /// The name of the workitem attribute whose change will be evaluated as part of the rule.
        /// </summary>
        /// <value>The name of the workitem attribute whose change will be evaluated as part of the rule.</value>
        [DataMember(Name="attribute", EmitDefaultValue=false)]
        public AttributeEnum? Attribute { get; set; }
        /// <summary>
        /// How the attribute's new value is compared against newValue. Only supported for the priority attribute.
        /// </summary>
        /// <value>How the attribute's new value is compared against newValue. Only supported for the priority attribute.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeConditionUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkitemOnAttributeChangeConditionUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeConditionUpdate" /> class.
        /// </summary>
        /// <param name="Attribute">The name of the workitem attribute whose change will be evaluated as part of the rule. (required).</param>
        /// <param name="NewValue">The value the attribute&#39;s new value is compared against. Compared for equality unless an operator is supplied. Null matches the attribute having been cleared, on clearable attributes..</param>
        /// <param name="OldValue">The value the attribute is transitioning from. Not permitted for the priority attribute. Omitted or null matches any previous value..</param>
        /// <param name="Operator">How the attribute&#39;s new value is compared against newValue. Only supported for the priority attribute..</param>
        public WorkitemOnAttributeChangeConditionUpdate(AttributeEnum? Attribute = null, string NewValue = null, string OldValue = null, OperatorEnum? Operator = null)
        {
            this.Attribute = Attribute;
            this.NewValue = NewValue;
            this.OldValue = OldValue;
            this.Operator = Operator;
            
        }
        




        /// <summary>
        /// The value the attribute&#39;s new value is compared against. Compared for equality unless an operator is supplied. Null matches the attribute having been cleared, on clearable attributes.
        /// </summary>
        /// <value>The value the attribute&#39;s new value is compared against. Compared for equality unless an operator is supplied. Null matches the attribute having been cleared, on clearable attributes.</value>
        [DataMember(Name="newValue", EmitDefaultValue=false)]
        public string NewValue { get; set; }



        /// <summary>
        /// The value the attribute is transitioning from. Not permitted for the priority attribute. Omitted or null matches any previous value.
        /// </summary>
        /// <value>The value the attribute is transitioning from. Not permitted for the priority attribute. Omitted or null matches any previous value.</value>
        [DataMember(Name="oldValue", EmitDefaultValue=false)]
        public string OldValue { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemOnAttributeChangeConditionUpdate {\n");

            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
            sb.Append("  OldValue: ").Append(OldValue).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(obj as WorkitemOnAttributeChangeConditionUpdate);
        }

        /// <summary>
        /// Returns true if WorkitemOnAttributeChangeConditionUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemOnAttributeChangeConditionUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemOnAttributeChangeConditionUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Attribute == other.Attribute ||
                    this.Attribute != null &&
                    this.Attribute.Equals(other.Attribute)
                ) &&
                (
                    this.NewValue == other.NewValue ||
                    this.NewValue != null &&
                    this.NewValue.Equals(other.NewValue)
                ) &&
                (
                    this.OldValue == other.OldValue ||
                    this.OldValue != null &&
                    this.OldValue.Equals(other.OldValue)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
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
                if (this.Attribute != null)
                    hash = hash * 59 + this.Attribute.GetHashCode();

                if (this.NewValue != null)
                    hash = hash * 59 + this.NewValue.GetHashCode();

                if (this.OldValue != null)
                    hash = hash * 59 + this.OldValue.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                return hash;
            }
        }
    }

}
