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
    /// V2MobiusAlertsTopicEntityProperties
    /// </summary>
    [DataContract]
    public partial class V2MobiusAlertsTopicEntityProperties :  IEquatable<V2MobiusAlertsTopicEntityProperties>
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
            Edge
        }
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2MobiusAlertsTopicEntityProperties" /> class.
        /// </summary>
        /// <param name="EntityType">EntityType.</param>
        /// <param name="UserDisplayName">UserDisplayName.</param>
        /// <param name="GroupDisplayName">GroupDisplayName.</param>
        /// <param name="QueueDisplayName">QueueDisplayName.</param>
        public V2MobiusAlertsTopicEntityProperties(EntityTypeEnum? EntityType = null, string UserDisplayName = null, string GroupDisplayName = null, string QueueDisplayName = null)
        {
            this.EntityType = EntityType;
            this.UserDisplayName = UserDisplayName;
            this.GroupDisplayName = GroupDisplayName;
            this.QueueDisplayName = QueueDisplayName;
            
        }
        




        /// <summary>
        /// Gets or Sets UserDisplayName
        /// </summary>
        [DataMember(Name="userDisplayName", EmitDefaultValue=false)]
        public string UserDisplayName { get; set; }



        /// <summary>
        /// Gets or Sets GroupDisplayName
        /// </summary>
        [DataMember(Name="groupDisplayName", EmitDefaultValue=false)]
        public string GroupDisplayName { get; set; }



        /// <summary>
        /// Gets or Sets QueueDisplayName
        /// </summary>
        [DataMember(Name="queueDisplayName", EmitDefaultValue=false)]
        public string QueueDisplayName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2MobiusAlertsTopicEntityProperties {\n");

            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
            sb.Append("  GroupDisplayName: ").Append(GroupDisplayName).Append("\n");
            sb.Append("  QueueDisplayName: ").Append(QueueDisplayName).Append("\n");
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
            return this.Equals(obj as V2MobiusAlertsTopicEntityProperties);
        }

        /// <summary>
        /// Returns true if V2MobiusAlertsTopicEntityProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of V2MobiusAlertsTopicEntityProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2MobiusAlertsTopicEntityProperties other)
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
                    this.UserDisplayName == other.UserDisplayName ||
                    this.UserDisplayName != null &&
                    this.UserDisplayName.Equals(other.UserDisplayName)
                ) &&
                (
                    this.GroupDisplayName == other.GroupDisplayName ||
                    this.GroupDisplayName != null &&
                    this.GroupDisplayName.Equals(other.GroupDisplayName)
                ) &&
                (
                    this.QueueDisplayName == other.QueueDisplayName ||
                    this.QueueDisplayName != null &&
                    this.QueueDisplayName.Equals(other.QueueDisplayName)
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

                if (this.UserDisplayName != null)
                    hash = hash * 59 + this.UserDisplayName.GetHashCode();

                if (this.GroupDisplayName != null)
                    hash = hash * 59 + this.GroupDisplayName.GetHashCode();

                if (this.QueueDisplayName != null)
                    hash = hash * 59 + this.QueueDisplayName.GetHashCode();

                return hash;
            }
        }
    }

}
