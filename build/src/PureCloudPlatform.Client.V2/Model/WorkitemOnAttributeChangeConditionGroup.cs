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
    /// WorkitemOnAttributeChangeConditionGroup
    /// </summary>
    [DataContract]
    public partial class WorkitemOnAttributeChangeConditionGroup :  IEquatable<WorkitemOnAttributeChangeConditionGroup>
    {
        /// <summary>
        /// How the conditions in this group are combined.
        /// </summary>
        /// <value>How the conditions in this group are combined.</value>
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
            /// Enum And for "And"
            /// </summary>
            [EnumMember(Value = "And")]
            And,
            
            /// <summary>
            /// Enum Or for "Or"
            /// </summary>
            [EnumMember(Value = "Or")]
            Or
        }
        /// <summary>
        /// How the conditions in this group are combined.
        /// </summary>
        /// <value>How the conditions in this group are combined.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeConditionGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkitemOnAttributeChangeConditionGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeConditionGroup" /> class.
        /// </summary>
        /// <param name="Operator">How the conditions in this group are combined. (required).</param>
        /// <param name="Conditions">The conditions to evaluate. Between 1 and 5 conditions are permitted per group. (required).</param>
        public WorkitemOnAttributeChangeConditionGroup(OperatorEnum? Operator = null, List<WorkitemOnAttributeChangeCondition> Conditions = null)
        {
            this.Operator = Operator;
            this.Conditions = Conditions;
            
        }
        




        /// <summary>
        /// The conditions to evaluate. Between 1 and 5 conditions are permitted per group.
        /// </summary>
        /// <value>The conditions to evaluate. Between 1 and 5 conditions are permitted per group.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<WorkitemOnAttributeChangeCondition> Conditions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemOnAttributeChangeConditionGroup {\n");

            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
            return this.Equals(obj as WorkitemOnAttributeChangeConditionGroup);
        }

        /// <summary>
        /// Returns true if WorkitemOnAttributeChangeConditionGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemOnAttributeChangeConditionGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemOnAttributeChangeConditionGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(other.Conditions)
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
                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();

                return hash;
            }
        }
    }

}
