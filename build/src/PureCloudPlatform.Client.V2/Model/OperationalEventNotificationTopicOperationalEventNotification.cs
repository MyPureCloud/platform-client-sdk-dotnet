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
        /// <param name="PreviousValue">PreviousValue.</param>
        /// <param name="CurrentValue">CurrentValue.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="Version">Version.</param>
        /// <param name="ParentEntity">ParentEntity.</param>
        /// <param name="EntityType">EntityType.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="Timestamp">Timestamp.</param>
        public OperationalEventNotificationTopicOperationalEventNotification(OperationalEventNotificationTopicEventEntity EventEntity = null, string EntityId = null, string EntityName = null, string PreviousValue = null, string CurrentValue = null, string ErrorCode = null, string Version = null, string ParentEntity = null, string EntityType = null, string ConversationId = null, int? Timestamp = null)
        {
            this.EventEntity = EventEntity;
            this.EntityId = EntityId;
            this.EntityName = EntityName;
            this.PreviousValue = PreviousValue;
            this.CurrentValue = CurrentValue;
            this.ErrorCode = ErrorCode;
            this.Version = Version;
            this.ParentEntity = ParentEntity;
            this.EntityType = EntityType;
            this.ConversationId = ConversationId;
            this.Timestamp = Timestamp;
            
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
        /// Gets or Sets PreviousValue
        /// </summary>
        [DataMember(Name="previousValue", EmitDefaultValue=false)]
        public string PreviousValue { get; set; }



        /// <summary>
        /// Gets or Sets CurrentValue
        /// </summary>
        [DataMember(Name="currentValue", EmitDefaultValue=false)]
        public string CurrentValue { get; set; }



        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }



        /// <summary>
        /// Gets or Sets ParentEntity
        /// </summary>
        [DataMember(Name="parentEntity", EmitDefaultValue=false)]
        public string ParentEntity { get; set; }



        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }



        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }


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
            sb.Append("  PreviousValue: ").Append(PreviousValue).Append("\n");
            sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ParentEntity: ").Append(ParentEntity).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
                ) &&
                (
                    this.PreviousValue == other.PreviousValue ||
                    this.PreviousValue != null &&
                    this.PreviousValue.Equals(other.PreviousValue)
                ) &&
                (
                    this.CurrentValue == other.CurrentValue ||
                    this.CurrentValue != null &&
                    this.CurrentValue.Equals(other.CurrentValue)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.ParentEntity == other.ParentEntity ||
                    this.ParentEntity != null &&
                    this.ParentEntity.Equals(other.ParentEntity)
                ) &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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

                if (this.PreviousValue != null)
                    hash = hash * 59 + this.PreviousValue.GetHashCode();

                if (this.CurrentValue != null)
                    hash = hash * 59 + this.CurrentValue.GetHashCode();

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.ParentEntity != null)
                    hash = hash * 59 + this.ParentEntity.GetHashCode();

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();

                return hash;
            }
        }
    }

}
