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
    /// A group of structured tool-output rules or nested groups.
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentStructuredOutputConditionGroupAllOf :  IEquatable<AgenticVirtualAgentStructuredOutputConditionGroupAllOf>
    {
        /// <summary>
        /// Logical operator used to combine the rules in this group.
        /// </summary>
        /// <value>Logical operator used to combine the rules in this group.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GroupEnum
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
        /// Logical operator used to combine the rules in this group.
        /// </summary>
        /// <value>Logical operator used to combine the rules in this group.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public GroupEnum? Group { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentStructuredOutputConditionGroupAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgenticVirtualAgentStructuredOutputConditionGroupAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentStructuredOutputConditionGroupAllOf" /> class.
        /// </summary>
        /// <param name="Group">Logical operator used to combine the rules in this group. (required).</param>
        /// <param name="Rules">Structured output rules or nested condition groups in this group. (required).</param>
        public AgenticVirtualAgentStructuredOutputConditionGroupAllOf(GroupEnum? Group = null, List<Object> Rules = null)
        {
            this.Group = Group;
            this.Rules = Rules;
            
        }
        




        /// <summary>
        /// Structured output rules or nested condition groups in this group.
        /// </summary>
        /// <value>Structured output rules or nested condition groups in this group.</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<Object> Rules { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentStructuredOutputConditionGroupAllOf {\n");

            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentStructuredOutputConditionGroupAllOf);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentStructuredOutputConditionGroupAllOf instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentStructuredOutputConditionGroupAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentStructuredOutputConditionGroupAllOf other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) &&
                (
                    this.Rules == other.Rules ||
                    this.Rules != null &&
                    this.Rules.SequenceEqual(other.Rules)
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
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();

                if (this.Rules != null)
                    hash = hash * 59 + this.Rules.GetHashCode();

                return hash;
            }
        }
    }

}
