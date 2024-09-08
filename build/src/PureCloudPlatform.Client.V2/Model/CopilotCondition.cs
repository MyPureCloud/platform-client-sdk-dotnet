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
    /// CopilotCondition
    /// </summary>
    [DataContract]
    public partial class CopilotCondition :  IEquatable<CopilotCondition>
    {
        /// <summary>
        /// Type of condition.
        /// </summary>
        /// <value>Type of condition.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ConditionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Intent for "Intent"
            /// </summary>
            [EnumMember(Value = "Intent")]
            Intent,
            
            /// <summary>
            /// Enum Conversationstart for "ConversationStart"
            /// </summary>
            [EnumMember(Value = "ConversationStart")]
            Conversationstart,
            
            /// <summary>
            /// Enum Conversationtransfer for "ConversationTransfer"
            /// </summary>
            [EnumMember(Value = "ConversationTransfer")]
            Conversationtransfer,
            
            /// <summary>
            /// Enum Conversationend for "ConversationEnd"
            /// </summary>
            [EnumMember(Value = "ConversationEnd")]
            Conversationend
        }
        /// <summary>
        /// Type of condition.
        /// </summary>
        /// <value>Type of condition.</value>
        [DataMember(Name="conditionType", EmitDefaultValue=false)]
        public ConditionTypeEnum? ConditionType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotCondition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CopilotCondition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotCondition" /> class.
        /// </summary>
        /// <param name="ConditionType">Type of condition. (required).</param>
        /// <param name="ConditionValues">Condition values. (required).</param>
        public CopilotCondition(ConditionTypeEnum? ConditionType = null, List<string> ConditionValues = null)
        {
            this.ConditionType = ConditionType;
            this.ConditionValues = ConditionValues;
            
        }
        




        /// <summary>
        /// Condition values.
        /// </summary>
        /// <value>Condition values.</value>
        [DataMember(Name="conditionValues", EmitDefaultValue=false)]
        public List<string> ConditionValues { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopilotCondition {\n");

            sb.Append("  ConditionType: ").Append(ConditionType).Append("\n");
            sb.Append("  ConditionValues: ").Append(ConditionValues).Append("\n");
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
            return this.Equals(obj as CopilotCondition);
        }

        /// <summary>
        /// Returns true if CopilotCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of CopilotCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopilotCondition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConditionType == other.ConditionType ||
                    this.ConditionType != null &&
                    this.ConditionType.Equals(other.ConditionType)
                ) &&
                (
                    this.ConditionValues == other.ConditionValues ||
                    this.ConditionValues != null &&
                    this.ConditionValues.SequenceEqual(other.ConditionValues)
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
                if (this.ConditionType != null)
                    hash = hash * 59 + this.ConditionType.GetHashCode();

                if (this.ConditionValues != null)
                    hash = hash * 59 + this.ConditionValues.GetHashCode();

                return hash;
            }
        }
    }

}
