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
    /// Users query rule request
    /// </summary>
    [DataContract]
    public partial class UsersRulesQueryRuleRequest :  IEquatable<UsersRulesQueryRuleRequest>
    {
        /// <summary>
        /// The type of the rule
        /// </summary>
        /// <value>The type of the rule</value>
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
            /// Enum Learning for "Learning"
            /// </summary>
            [EnumMember(Value = "Learning")]
            Learning
        }
        /// <summary>
        /// The type of the rule
        /// </summary>
        /// <value>The type of the rule</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRulesQueryRuleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsersRulesQueryRuleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRulesQueryRuleRequest" /> class.
        /// </summary>
        /// <param name="Type">The type of the rule (required).</param>
        /// <param name="Criteria">The criteria of the rule (required).</param>
        /// <param name="UserIds">The user ids to query (required).</param>
        public UsersRulesQueryRuleRequest(TypeEnum? Type = null, List<UsersRulesCriteria> Criteria = null, List<string> UserIds = null)
        {
            this.Type = Type;
            this.Criteria = Criteria;
            this.UserIds = UserIds;
            
        }
        




        /// <summary>
        /// The criteria of the rule
        /// </summary>
        /// <value>The criteria of the rule</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public List<UsersRulesCriteria> Criteria { get; set; }



        /// <summary>
        /// The user ids to query
        /// </summary>
        /// <value>The user ids to query</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersRulesQueryRuleRequest {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
            return this.Equals(obj as UsersRulesQueryRuleRequest);
        }

        /// <summary>
        /// Returns true if UsersRulesQueryRuleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UsersRulesQueryRuleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersRulesQueryRuleRequest other)
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
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.SequenceEqual(other.Criteria)
                ) &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
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

                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();

                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();

                return hash;
            }
        }
    }

}
