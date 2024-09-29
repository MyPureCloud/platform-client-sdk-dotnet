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
    /// A singular criteria used to query executionData.
    /// </summary>
    [DataContract]
    public partial class CriteriaItem :  IEquatable<CriteriaItem>
    {
        /// <summary>
        /// The id of the criteria to be checked.
        /// </summary>
        /// <value>The id of the criteria to be checked.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum KeyEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Flowstartdatetime for "FlowStartDateTime"
            /// </summary>
            [EnumMember(Value = "FlowStartDateTime")]
            Flowstartdatetime,
            
            /// <summary>
            /// Enum Flowenddatetime for "FlowEndDateTime"
            /// </summary>
            [EnumMember(Value = "FlowEndDateTime")]
            Flowenddatetime,
            
            /// <summary>
            /// Enum Conversationid for "ConversationId"
            /// </summary>
            [EnumMember(Value = "ConversationId")]
            Conversationid,
            
            /// <summary>
            /// Enum Workitemid for "WorkitemId"
            /// </summary>
            [EnumMember(Value = "WorkitemId")]
            Workitemid,
            
            /// <summary>
            /// Enum Flowtype for "FlowType"
            /// </summary>
            [EnumMember(Value = "FlowType")]
            Flowtype,
            
            /// <summary>
            /// Enum Flowid for "FlowId"
            /// </summary>
            [EnumMember(Value = "FlowId")]
            Flowid,
            
            /// <summary>
            /// Enum Flowerrorreason for "FlowErrorReason"
            /// </summary>
            [EnumMember(Value = "FlowErrorReason")]
            Flowerrorreason,
            
            /// <summary>
            /// Enum Flowwarningreason for "FlowWarningReason"
            /// </summary>
            [EnumMember(Value = "FlowWarningReason")]
            Flowwarningreason,
            
            /// <summary>
            /// Enum Flowalternateexecutionid for "FlowAlternateExecutionId"
            /// </summary>
            [EnumMember(Value = "FlowAlternateExecutionId")]
            Flowalternateexecutionid,
            
            /// <summary>
            /// Enum Flowobjectexecutionid for "FlowObjectExecutionId"
            /// </summary>
            [EnumMember(Value = "FlowObjectExecutionId")]
            Flowobjectexecutionid,
            
            /// <summary>
            /// Enum Flowactionid for "FlowActionId"
            /// </summary>
            [EnumMember(Value = "FlowActionId")]
            Flowactionid,
            
            /// <summary>
            /// Enum Flowactiontype for "FlowActionType"
            /// </summary>
            [EnumMember(Value = "FlowActionType")]
            Flowactiontype,
            
            /// <summary>
            /// Enum Flowactionoutputpathid for "FlowActionOutputPathId"
            /// </summary>
            [EnumMember(Value = "FlowActionOutputPathId")]
            Flowactionoutputpathid,
            
            /// <summary>
            /// Enum Flowactionoutputpathname for "FlowActionOutputPathName"
            /// </summary>
            [EnumMember(Value = "FlowActionOutputPathName")]
            Flowactionoutputpathname,
            
            /// <summary>
            /// Enum Flowactionidoutputpathid for "FlowActionIdOutputPathId"
            /// </summary>
            [EnumMember(Value = "FlowActionIdOutputPathId")]
            Flowactionidoutputpathid,
            
            /// <summary>
            /// Enum Flowactionidoutputpathname for "FlowActionIdOutputPathName"
            /// </summary>
            [EnumMember(Value = "FlowActionIdOutputPathName")]
            Flowactionidoutputpathname,
            
            /// <summary>
            /// Enum Flowactiontypeoutputpathid for "FlowActionTypeOutputPathId"
            /// </summary>
            [EnumMember(Value = "FlowActionTypeOutputPathId")]
            Flowactiontypeoutputpathid,
            
            /// <summary>
            /// Enum Flowactiontypeoutputpathname for "FlowActionTypeOutputPathName"
            /// </summary>
            [EnumMember(Value = "FlowActionTypeOutputPathName")]
            Flowactiontypeoutputpathname,
            
            /// <summary>
            /// Enum Botid for "BotId"
            /// </summary>
            [EnumMember(Value = "BotId")]
            Botid,
            
            /// <summary>
            /// Enum Boterrorreason for "BotErrorReason"
            /// </summary>
            [EnumMember(Value = "BotErrorReason")]
            Boterrorreason,
            
            /// <summary>
            /// Enum Botflowexecutionid for "BotFlowExecutionId"
            /// </summary>
            [EnumMember(Value = "BotFlowExecutionId")]
            Botflowexecutionid,
            
            /// <summary>
            /// Enum Botobjectexecutionid for "BotObjectExecutionId"
            /// </summary>
            [EnumMember(Value = "BotObjectExecutionId")]
            Botobjectexecutionid
        }
        /// <summary>
        /// The operator used to check on the criteria id.
        /// </summary>
        /// <value>The operator used to check on the criteria id.</value>
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
            /// Enum Eq for "eq"
            /// </summary>
            [EnumMember(Value = "eq")]
            Eq,
            
            /// <summary>
            /// Enum Gt for "gt"
            /// </summary>
            [EnumMember(Value = "gt")]
            Gt,
            
            /// <summary>
            /// Enum Gte for "gte"
            /// </summary>
            [EnumMember(Value = "gte")]
            Gte,
            
            /// <summary>
            /// Enum Lt for "lt"
            /// </summary>
            [EnumMember(Value = "lt")]
            Lt,
            
            /// <summary>
            /// Enum Lte for "lte"
            /// </summary>
            [EnumMember(Value = "lte")]
            Lte,
            
            /// <summary>
            /// Enum Not for "not"
            /// </summary>
            [EnumMember(Value = "not")]
            Not,
            
            /// <summary>
            /// Enum Begins for "begins"
            /// </summary>
            [EnumMember(Value = "begins")]
            Begins,
            
            /// <summary>
            /// Enum NotNull for "not_null"
            /// </summary>
            [EnumMember(Value = "not_null")]
            NotNull
        }
        /// <summary>
        /// The id of the criteria to be checked.
        /// </summary>
        /// <value>The id of the criteria to be checked.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public KeyEnum? Key { get; set; }
        /// <summary>
        /// The operator used to check on the criteria id.
        /// </summary>
        /// <value>The operator used to check on the criteria id.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CriteriaItem" /> class.
        /// </summary>
        /// <param name="Key">The id of the criteria to be checked..</param>
        /// <param name="Operator">The operator used to check on the criteria id..</param>
        /// <param name="Value">The target value used to query on..</param>
        public CriteriaItem(KeyEnum? Key = null, OperatorEnum? Operator = null, string Value = null)
        {
            this.Key = Key;
            this.Operator = Operator;
            this.Value = Value;
            
        }
        






        /// <summary>
        /// The target value used to query on.
        /// </summary>
        /// <value>The target value used to query on.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CriteriaItem {\n");

            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as CriteriaItem);
        }

        /// <summary>
        /// Returns true if CriteriaItem instances are equal
        /// </summary>
        /// <param name="other">Instance of CriteriaItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CriteriaItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
