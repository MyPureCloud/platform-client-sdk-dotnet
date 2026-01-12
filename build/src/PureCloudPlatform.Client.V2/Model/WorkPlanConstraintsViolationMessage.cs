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
    /// WorkPlanConstraintsViolationMessage
    /// </summary>
    [DataContract]
    public partial class WorkPlanConstraintsViolationMessage :  IEquatable<WorkPlanConstraintsViolationMessage>
    {
        /// <summary>
        /// Message for how to resolve a set of conflicted work plan constraints
        /// </summary>
        /// <value>Message for how to resolve a set of conflicted work plan constraints</value>
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
            /// Enum Constraintconflictwithpotentialfixes for "ConstraintConflictWithPotentialFixes"
            /// </summary>
            [EnumMember(Value = "ConstraintConflictWithPotentialFixes")]
            Constraintconflictwithpotentialfixes,
            
            /// <summary>
            /// Enum Constraintconflictunknownfix for "ConstraintConflictUnknownFix"
            /// </summary>
            [EnumMember(Value = "ConstraintConflictUnknownFix")]
            Constraintconflictunknownfix
        }
        /// <summary>
        /// Message for how to resolve a set of conflicted work plan constraints
        /// </summary>
        /// <value>Message for how to resolve a set of conflicted work plan constraints</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanConstraintsViolationMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkPlanConstraintsViolationMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanConstraintsViolationMessage" /> class.
        /// </summary>
        /// <param name="Type">Message for how to resolve a set of conflicted work plan constraints (required).</param>
        /// <param name="FixableConstraintsMessages">If type &#x3D;&#x3D; &#39;ConstraintConflictWithPotentialFixes&#39;, messages for the set of conflicted work plan constraints. Each element indicates the message of potential fix to unavailable times to resolve work plan constraints (required).</param>
        public WorkPlanConstraintsViolationMessage(TypeEnum? Type = null, List<WorkPlanConstraintViolationMessage> FixableConstraintsMessages = null)
        {
            this.Type = Type;
            this.FixableConstraintsMessages = FixableConstraintsMessages;
            
        }
        




        /// <summary>
        /// If type &#x3D;&#x3D; &#39;ConstraintConflictWithPotentialFixes&#39;, messages for the set of conflicted work plan constraints. Each element indicates the message of potential fix to unavailable times to resolve work plan constraints
        /// </summary>
        /// <value>If type &#x3D;&#x3D; &#39;ConstraintConflictWithPotentialFixes&#39;, messages for the set of conflicted work plan constraints. Each element indicates the message of potential fix to unavailable times to resolve work plan constraints</value>
        [DataMember(Name="fixableConstraintsMessages", EmitDefaultValue=false)]
        public List<WorkPlanConstraintViolationMessage> FixableConstraintsMessages { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanConstraintsViolationMessage {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FixableConstraintsMessages: ").Append(FixableConstraintsMessages).Append("\n");
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
            return this.Equals(obj as WorkPlanConstraintsViolationMessage);
        }

        /// <summary>
        /// Returns true if WorkPlanConstraintsViolationMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanConstraintsViolationMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanConstraintsViolationMessage other)
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
                    this.FixableConstraintsMessages == other.FixableConstraintsMessages ||
                    this.FixableConstraintsMessages != null &&
                    this.FixableConstraintsMessages.SequenceEqual(other.FixableConstraintsMessages)
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

                if (this.FixableConstraintsMessages != null)
                    hash = hash * 59 + this.FixableConstraintsMessages.GetHashCode();

                return hash;
            }
        }
    }

}
