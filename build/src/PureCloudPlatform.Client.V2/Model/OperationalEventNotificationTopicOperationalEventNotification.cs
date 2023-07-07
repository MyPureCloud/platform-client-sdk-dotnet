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
    /// OperationalEventNotificationTopicOperationalEventNotification
    /// </summary>
    [DataContract]
    public partial class OperationalEventNotificationTopicOperationalEventNotification :  IEquatable<OperationalEventNotificationTopicOperationalEventNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationalEventNotificationTopicOperationalEventNotification" /> class.
        /// </summary>
        /// <param name="EventEntity">EventEntity.</param>
        /// <param name="EntityId">EntityId.</param>
        /// <param name="EntityName">EntityName.</param>
        public OperationalEventNotificationTopicOperationalEventNotification(OperationalEventNotificationTopicEventEntity EventEntity = null, string EntityId = null, string EntityName = null)
        {
            this.EventEntity = EventEntity;
            this.EntityId = EntityId;
            this.EntityName = EntityName;
            
        }
        


        /// <summary>
        /// Gets or Sets EventEntity
        /// </summary>
        [DataMember(Name="eventEntity", EmitDefaultValue=false)]
        public OperationalEventNotificationTopicEventEntity EventEntity { get; set; }



        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }



        /// <summary>
        /// Gets or Sets EntityName
        /// </summary>
        [DataMember(Name="entityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationalEventNotificationTopicOperationalEventNotification {\n");

            sb.Append("  EventEntity: ").Append(EventEntity).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
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
            return this.Equals(obj as OperationalEventNotificationTopicOperationalEventNotification);
        }

        /// <summary>
        /// Returns true if OperationalEventNotificationTopicOperationalEventNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of OperationalEventNotificationTopicOperationalEventNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationalEventNotificationTopicOperationalEventNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventEntity == other.EventEntity ||
                    this.EventEntity != null &&
                    this.EventEntity.Equals(other.EventEntity)
                ) &&
                (
                    this.EntityId == other.EntityId ||
                    this.EntityId != null &&
                    this.EntityId.Equals(other.EntityId)
                ) &&
                (
                    this.EntityName == other.EntityName ||
                    this.EntityName != null &&
                    this.EntityName.Equals(other.EntityName)
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
                if (this.EventEntity != null)
                    hash = hash * 59 + this.EventEntity.GetHashCode();

                if (this.EntityId != null)
                    hash = hash * 59 + this.EntityId.GetHashCode();

                if (this.EntityName != null)
                    hash = hash * 59 + this.EntityName.GetHashCode();

                return hash;
            }
        }
    }

}
