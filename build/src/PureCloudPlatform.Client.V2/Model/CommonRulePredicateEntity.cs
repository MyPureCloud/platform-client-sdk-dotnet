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
    /// CommonRulePredicateEntity
    /// </summary>
    [DataContract]
    public partial class CommonRulePredicateEntity :  IEquatable<CommonRulePredicateEntity>
    {
        /// <summary>
        /// Specifies the type of entity being evaluated
        /// </summary>
        /// <value>Specifies the type of entity being evaluated</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EntityTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Group for "Group"
            /// </summary>
            [EnumMember(Value = "Group")]
            Group,
            
            /// <summary>
            /// Enum Queue for "Queue"
            /// </summary>
            [EnumMember(Value = "Queue")]
            Queue,
            
            /// <summary>
            /// Enum Team for "Team"
            /// </summary>
            [EnumMember(Value = "Team")]
            Team,
            
            /// <summary>
            /// Enum Teammembers for "TeamMembers"
            /// </summary>
            [EnumMember(Value = "TeamMembers")]
            Teammembers,
            
            /// <summary>
            /// Enum Organization for "Organization"
            /// </summary>
            [EnumMember(Value = "Organization")]
            Organization
        }
        /// <summary>
        /// Specifies the type of entity being evaluated
        /// </summary>
        /// <value>Specifies the type of entity being evaluated</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRulePredicateEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonRulePredicateEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRulePredicateEntity" /> class.
        /// </summary>
        /// <param name="EntityType">Specifies the type of entity being evaluated (required).</param>
        /// <param name="User">User id of the entity being monitored.</param>
        /// <param name="Group">Group id of the entity being monitored.</param>
        /// <param name="Queue">Queue id of the entity being monitored.</param>
        /// <param name="Team">Team id of the entity being monitored.</param>
        public CommonRulePredicateEntity(EntityTypeEnum? EntityType = null, AddressableEntityRef User = null, AddressableEntityRef Group = null, AddressableEntityRef Queue = null, AddressableEntityRef Team = null)
        {
            this.EntityType = EntityType;
            this.User = User;
            this.Group = Group;
            this.Queue = Queue;
            this.Team = Team;
            
        }
        




        /// <summary>
        /// User id of the entity being monitored
        /// </summary>
        /// <value>User id of the entity being monitored</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public AddressableEntityRef User { get; set; }



        /// <summary>
        /// Group id of the entity being monitored
        /// </summary>
        /// <value>Group id of the entity being monitored</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public AddressableEntityRef Group { get; set; }



        /// <summary>
        /// Queue id of the entity being monitored
        /// </summary>
        /// <value>Queue id of the entity being monitored</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public AddressableEntityRef Queue { get; set; }



        /// <summary>
        /// Team id of the entity being monitored
        /// </summary>
        /// <value>Team id of the entity being monitored</value>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public AddressableEntityRef Team { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonRulePredicateEntity {\n");

            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
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
            return this.Equals(obj as CommonRulePredicateEntity);
        }

        /// <summary>
        /// Returns true if CommonRulePredicateEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonRulePredicateEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonRulePredicateEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
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
                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();

                return hash;
            }
        }
    }

}
