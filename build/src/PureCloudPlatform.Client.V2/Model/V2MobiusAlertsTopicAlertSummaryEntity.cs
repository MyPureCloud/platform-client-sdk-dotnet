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
    /// V2MobiusAlertsTopicAlertSummaryEntity
    /// </summary>
    [DataContract]
    public partial class V2MobiusAlertsTopicAlertSummaryEntity :  IEquatable<V2MobiusAlertsTopicAlertSummaryEntity>
    {
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
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
            /// Enum Organization for "Organization"
            /// </summary>
            [EnumMember(Value = "Organization")]
            Organization,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Queue for "Queue"
            /// </summary>
            [EnumMember(Value = "Queue")]
            Queue,
            
            /// <summary>
            /// Enum Group for "Group"
            /// </summary>
            [EnumMember(Value = "Group")]
            Group,
            
            /// <summary>
            /// Enum Edge for "Edge"
            /// </summary>
            [EnumMember(Value = "Edge")]
            Edge,
            
            /// <summary>
            /// Enum Team for "Team"
            /// </summary>
            [EnumMember(Value = "Team")]
            Team,
            
            /// <summary>
            /// Enum Teammembers for "TeamMembers"
            /// </summary>
            [EnumMember(Value = "TeamMembers")]
            Teammembers
        }
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2MobiusAlertsTopicAlertSummaryEntity" /> class.
        /// </summary>
        /// <param name="EntityType">EntityType.</param>
        /// <param name="User">User.</param>
        /// <param name="Group">Group.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="Team">Team.</param>
        /// <param name="Alerting">Alerting.</param>
        public V2MobiusAlertsTopicAlertSummaryEntity(EntityTypeEnum? EntityType = null, V2MobiusAlertsTopicAlertingAddressableEntityRef User = null, V2MobiusAlertsTopicAlertingAddressableEntityRef Group = null, V2MobiusAlertsTopicAlertingAddressableEntityRef Queue = null, V2MobiusAlertsTopicAlertingAddressableEntityRef Team = null, bool? Alerting = null)
        {
            this.EntityType = EntityType;
            this.User = User;
            this.Group = Group;
            this.Queue = Queue;
            this.Team = Team;
            this.Alerting = Alerting;
            
        }
        




        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public V2MobiusAlertsTopicAlertingAddressableEntityRef User { get; set; }



        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public V2MobiusAlertsTopicAlertingAddressableEntityRef Group { get; set; }



        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public V2MobiusAlertsTopicAlertingAddressableEntityRef Queue { get; set; }



        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public V2MobiusAlertsTopicAlertingAddressableEntityRef Team { get; set; }



        /// <summary>
        /// Gets or Sets Alerting
        /// </summary>
        [DataMember(Name="alerting", EmitDefaultValue=false)]
        public bool? Alerting { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2MobiusAlertsTopicAlertSummaryEntity {\n");

            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Alerting: ").Append(Alerting).Append("\n");
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
            return this.Equals(obj as V2MobiusAlertsTopicAlertSummaryEntity);
        }

        /// <summary>
        /// Returns true if V2MobiusAlertsTopicAlertSummaryEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of V2MobiusAlertsTopicAlertSummaryEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2MobiusAlertsTopicAlertSummaryEntity other)
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
                ) &&
                (
                    this.Alerting == other.Alerting ||
                    this.Alerting != null &&
                    this.Alerting.Equals(other.Alerting)
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

                if (this.Alerting != null)
                    hash = hash * 59 + this.Alerting.GetHashCode();

                return hash;
            }
        }
    }

}
