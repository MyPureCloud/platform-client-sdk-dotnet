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
    /// MessagingRoutingTransferEvent
    /// </summary>
    [DataContract]
    public partial class MessagingRoutingTransferEvent :  IEquatable<MessagingRoutingTransferEvent>
    {
        /// <summary>
        /// Indicates the desired type of transfer.
        /// </summary>
        /// <value>Indicates the desired type of transfer.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TransferTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Attended for "Attended"
            /// </summary>
            [EnumMember(Value = "Attended")]
            Attended,
            
            /// <summary>
            /// Enum Unattended for "Unattended"
            /// </summary>
            [EnumMember(Value = "Unattended")]
            Unattended
        }
        /// <summary>
        /// Indicates the desired type of transfer.
        /// </summary>
        /// <value>Indicates the desired type of transfer.</value>
        [DataMember(Name="transferType", EmitDefaultValue=false)]
        public TransferTypeEnum? TransferType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingRoutingTransferEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagingRoutingTransferEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingRoutingTransferEvent" /> class.
        /// </summary>
        /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
        /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
        /// <param name="TransferType">Indicates the desired type of transfer. (required).</param>
        /// <param name="CommandId">The id (V4 UUID) used by the external platform to refer to the transfer in subsequent *Transfer events. (required).</param>
        /// <param name="InitiatingCommunicationId">Indicates the desired type of transfer. (required).</param>
        /// <param name="TargetCommunicationId">The id (V4 UUID) of the communication that is being transferred away from. In many cases this will be the same as the `initiatingCommunicationId`. (required).</param>
        /// <param name="ObjectCommunicationId">The id (V4 UUID) of the communication that is being transferred. (required).</param>
        /// <param name="DestinationQueueId">The id (V4 UUID) of the desired destination queue that the object communication should be transferred to. (required).</param>
        /// <param name="LanguageId">The unique identifier (V4 UUID) for the language that should be used to determine the destination for the conversation..</param>
        /// <param name="SkillIds">The unique identifiers (V4 UUID) for the skills that should be used to determine the destination for the conversation..</param>
        public MessagingRoutingTransferEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, TransferTypeEnum? TransferType = null, string CommandId = null, string InitiatingCommunicationId = null, string TargetCommunicationId = null, string ObjectCommunicationId = null, string DestinationQueueId = null, string LanguageId = null, List<string> SkillIds = null)
        {
            this.EventId = EventId;
            this.EventDateTime = EventDateTime;
            this.ConversationId = ConversationId;
            this.TransferType = TransferType;
            this.CommandId = CommandId;
            this.InitiatingCommunicationId = InitiatingCommunicationId;
            this.TargetCommunicationId = TargetCommunicationId;
            this.ObjectCommunicationId = ObjectCommunicationId;
            this.DestinationQueueId = DestinationQueueId;
            this.LanguageId = LanguageId;
            this.SkillIds = SkillIds;
            
        }
        


        /// <summary>
        /// A unique (V4 UUID) eventId for this event
        /// </summary>
        /// <value>A unique (V4 UUID) eventId for this event</value>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public string EventId { get; set; }



        /// <summary>
        /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventDateTime", EmitDefaultValue=false)]
        public DateTime? EventDateTime { get; set; }



        /// <summary>
        /// A unique Id (V4 UUID) identifying this conversation
        /// </summary>
        /// <value>A unique Id (V4 UUID) identifying this conversation</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }





        /// <summary>
        /// The id (V4 UUID) used by the external platform to refer to the transfer in subsequent *Transfer events.
        /// </summary>
        /// <value>The id (V4 UUID) used by the external platform to refer to the transfer in subsequent *Transfer events.</value>
        [DataMember(Name="commandId", EmitDefaultValue=false)]
        public string CommandId { get; set; }



        /// <summary>
        /// Indicates the desired type of transfer.
        /// </summary>
        /// <value>Indicates the desired type of transfer.</value>
        [DataMember(Name="initiatingCommunicationId", EmitDefaultValue=false)]
        public string InitiatingCommunicationId { get; set; }



        /// <summary>
        /// The id (V4 UUID) of the communication that is being transferred away from. In many cases this will be the same as the `initiatingCommunicationId`.
        /// </summary>
        /// <value>The id (V4 UUID) of the communication that is being transferred away from. In many cases this will be the same as the `initiatingCommunicationId`.</value>
        [DataMember(Name="targetCommunicationId", EmitDefaultValue=false)]
        public string TargetCommunicationId { get; set; }



        /// <summary>
        /// The id (V4 UUID) of the communication that is being transferred.
        /// </summary>
        /// <value>The id (V4 UUID) of the communication that is being transferred.</value>
        [DataMember(Name="objectCommunicationId", EmitDefaultValue=false)]
        public string ObjectCommunicationId { get; set; }



        /// <summary>
        /// The id (V4 UUID) of the desired destination queue that the object communication should be transferred to.
        /// </summary>
        /// <value>The id (V4 UUID) of the desired destination queue that the object communication should be transferred to.</value>
        [DataMember(Name="destinationQueueId", EmitDefaultValue=false)]
        public string DestinationQueueId { get; set; }



        /// <summary>
        /// The unique identifier (V4 UUID) for the language that should be used to determine the destination for the conversation.
        /// </summary>
        /// <value>The unique identifier (V4 UUID) for the language that should be used to determine the destination for the conversation.</value>
        [DataMember(Name="languageId", EmitDefaultValue=false)]
        public string LanguageId { get; set; }



        /// <summary>
        /// The unique identifiers (V4 UUID) for the skills that should be used to determine the destination for the conversation.
        /// </summary>
        /// <value>The unique identifiers (V4 UUID) for the skills that should be used to determine the destination for the conversation.</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingRoutingTransferEvent {\n");

            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  TransferType: ").Append(TransferType).Append("\n");
            sb.Append("  CommandId: ").Append(CommandId).Append("\n");
            sb.Append("  InitiatingCommunicationId: ").Append(InitiatingCommunicationId).Append("\n");
            sb.Append("  TargetCommunicationId: ").Append(TargetCommunicationId).Append("\n");
            sb.Append("  ObjectCommunicationId: ").Append(ObjectCommunicationId).Append("\n");
            sb.Append("  DestinationQueueId: ").Append(DestinationQueueId).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
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
            return this.Equals(obj as MessagingRoutingTransferEvent);
        }

        /// <summary>
        /// Returns true if MessagingRoutingTransferEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingRoutingTransferEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingRoutingTransferEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventId == other.EventId ||
                    this.EventId != null &&
                    this.EventId.Equals(other.EventId)
                ) &&
                (
                    this.EventDateTime == other.EventDateTime ||
                    this.EventDateTime != null &&
                    this.EventDateTime.Equals(other.EventDateTime)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.TransferType == other.TransferType ||
                    this.TransferType != null &&
                    this.TransferType.Equals(other.TransferType)
                ) &&
                (
                    this.CommandId == other.CommandId ||
                    this.CommandId != null &&
                    this.CommandId.Equals(other.CommandId)
                ) &&
                (
                    this.InitiatingCommunicationId == other.InitiatingCommunicationId ||
                    this.InitiatingCommunicationId != null &&
                    this.InitiatingCommunicationId.Equals(other.InitiatingCommunicationId)
                ) &&
                (
                    this.TargetCommunicationId == other.TargetCommunicationId ||
                    this.TargetCommunicationId != null &&
                    this.TargetCommunicationId.Equals(other.TargetCommunicationId)
                ) &&
                (
                    this.ObjectCommunicationId == other.ObjectCommunicationId ||
                    this.ObjectCommunicationId != null &&
                    this.ObjectCommunicationId.Equals(other.ObjectCommunicationId)
                ) &&
                (
                    this.DestinationQueueId == other.DestinationQueueId ||
                    this.DestinationQueueId != null &&
                    this.DestinationQueueId.Equals(other.DestinationQueueId)
                ) &&
                (
                    this.LanguageId == other.LanguageId ||
                    this.LanguageId != null &&
                    this.LanguageId.Equals(other.LanguageId)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
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
                if (this.EventId != null)
                    hash = hash * 59 + this.EventId.GetHashCode();

                if (this.EventDateTime != null)
                    hash = hash * 59 + this.EventDateTime.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.TransferType != null)
                    hash = hash * 59 + this.TransferType.GetHashCode();

                if (this.CommandId != null)
                    hash = hash * 59 + this.CommandId.GetHashCode();

                if (this.InitiatingCommunicationId != null)
                    hash = hash * 59 + this.InitiatingCommunicationId.GetHashCode();

                if (this.TargetCommunicationId != null)
                    hash = hash * 59 + this.TargetCommunicationId.GetHashCode();

                if (this.ObjectCommunicationId != null)
                    hash = hash * 59 + this.ObjectCommunicationId.GetHashCode();

                if (this.DestinationQueueId != null)
                    hash = hash * 59 + this.DestinationQueueId.GetHashCode();

                if (this.LanguageId != null)
                    hash = hash * 59 + this.LanguageId.GetHashCode();

                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();

                return hash;
            }
        }
    }

}
