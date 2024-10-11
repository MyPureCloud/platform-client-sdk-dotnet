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
    /// WorkitemOnAttributeChangeCondition
    /// </summary>
    [DataContract]
    public partial class WorkitemOnAttributeChangeCondition :  IEquatable<WorkitemOnAttributeChangeCondition>
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
            Statusid
        }
        /// <summary>
        /// The name of the workitem attribute whose change will be evaluated as part of the rule.
        /// </summary>
        /// <value>The name of the workitem attribute whose change will be evaluated as part of the rule.</value>
        [DataMember(Name="attribute", EmitDefaultValue=false)]
        public AttributeEnum? Attribute { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeCondition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkitemOnAttributeChangeCondition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeCondition" /> class.
        /// </summary>
        /// <param name="Attribute">The name of the workitem attribute whose change will be evaluated as part of the rule. (required).</param>
        /// <param name="NewValue">The new value of the attribute. If the attribute is updated to this value this part of the condition will be met. (required).</param>
        /// <param name="OldValue">The old value of the attribute. If the attribute was updated from this value this part of the condition will be met..</param>
        public WorkitemOnAttributeChangeCondition(AttributeEnum? Attribute = null, string NewValue = null, string OldValue = null)
        {
            this.Attribute = Attribute;
            this.NewValue = NewValue;
            this.OldValue = OldValue;
            
        }
        




        /// <summary>
        /// The new value of the attribute. If the attribute is updated to this value this part of the condition will be met.
        /// </summary>
        /// <value>The new value of the attribute. If the attribute is updated to this value this part of the condition will be met.</value>
        [DataMember(Name="newValue", EmitDefaultValue=false)]
        public string NewValue { get; set; }



        /// <summary>
        /// The old value of the attribute. If the attribute was updated from this value this part of the condition will be met.
        /// </summary>
        /// <value>The old value of the attribute. If the attribute was updated from this value this part of the condition will be met.</value>
        [DataMember(Name="oldValue", EmitDefaultValue=false)]
        public string OldValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemOnAttributeChangeCondition {\n");

            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
            sb.Append("  OldValue: ").Append(OldValue).Append("\n");
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
            return this.Equals(obj as WorkitemOnAttributeChangeCondition);
        }

        /// <summary>
        /// Returns true if WorkitemOnAttributeChangeCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemOnAttributeChangeCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemOnAttributeChangeCondition other)
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

                return hash;
            }
        }
    }

}
