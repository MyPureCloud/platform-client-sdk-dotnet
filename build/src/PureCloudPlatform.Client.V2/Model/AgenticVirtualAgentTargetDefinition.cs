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
    /// Target definition for input or output data type properties
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentTargetDefinition :  IEquatable<AgenticVirtualAgentTargetDefinition>
    {
        /// <summary>
        /// The type of target.
        /// </summary>
        /// <value>The type of target.</value>
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
            /// Enum Request for "Request"
            /// </summary>
            [EnumMember(Value = "Request")]
            Request,
            
            /// <summary>
            /// Enum Response for "Response"
            /// </summary>
            [EnumMember(Value = "Response")]
            Response,
            
            /// <summary>
            /// Enum Customconversationattributes for "CustomConversationAttributes"
            /// </summary>
            [EnumMember(Value = "CustomConversationAttributes")]
            Customconversationattributes
        }
        /// <summary>
        /// The type of target.
        /// </summary>
        /// <value>The type of target.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentTargetDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgenticVirtualAgentTargetDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentTargetDefinition" /> class.
        /// </summary>
        /// <param name="Type">The type of target. (required).</param>
        /// <param name="Target">The reference target object. Contains information on the Conversation Attributes schema..</param>
        public AgenticVirtualAgentTargetDefinition(TypeEnum? Type = null, AgenticVirtualAgentTargetReferenceDefinition Target = null)
        {
            this.Type = Type;
            this.Target = Target;
            
        }
        




        /// <summary>
        /// The reference target object. Contains information on the Conversation Attributes schema.
        /// </summary>
        /// <value>The reference target object. Contains information on the Conversation Attributes schema.</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public AgenticVirtualAgentTargetReferenceDefinition Target { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentTargetDefinition {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentTargetDefinition);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentTargetDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentTargetDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentTargetDefinition other)
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
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
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

                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

                return hash;
            }
        }
    }

}
