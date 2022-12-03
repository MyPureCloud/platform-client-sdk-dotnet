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
    /// RoutingEstablishedEvent
    /// </summary>
    [DataContract]
    public partial class RoutingEstablishedEvent :  IEquatable<RoutingEstablishedEvent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingEstablishedEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoutingEstablishedEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingEstablishedEvent" /> class.
        /// </summary>
        /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
        /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
        /// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication (required).</param>
        /// <param name="PhoneNumber">Identifies the phone number used to reach this queue if it is different from the information that would be accessed by queueId..</param>
        /// <param name="QueueId">The id (V4 UUID) of the queue that is routing this conversation. (required).</param>
        /// <param name="Ani">The automatic number identification if it is available for this conversation..</param>
        /// <param name="Dnis">The dialed number identification if it is available for this conversation..</param>
        /// <param name="SkillIds">The unique identifiers (V4 UUID) for the skills that should be used to determine the destination for the conversation..</param>
        /// <param name="LanguageId">The unique identifier (V4 UUID) for the language that should be used to determine the destination for the conversation..</param>
        /// <param name="InitialConfiguration">Metadata about this communication. (required).</param>
        /// <param name="SourceConfiguration">Metadata about the source of this communication's interaction. (required).</param>
        public RoutingEstablishedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string PhoneNumber = null, string QueueId = null, string Ani = null, string Dnis = null, List<string> SkillIds = null, string LanguageId = null, InitialConfiguration InitialConfiguration = null, SourceConfiguration SourceConfiguration = null)
        {
            this.EventId = EventId;
            this.EventDateTime = EventDateTime;
            this.ConversationId = ConversationId;
            this.CommunicationId = CommunicationId;
            this.PhoneNumber = PhoneNumber;
            this.QueueId = QueueId;
            this.Ani = Ani;
            this.Dnis = Dnis;
            this.SkillIds = SkillIds;
            this.LanguageId = LanguageId;
            this.InitialConfiguration = InitialConfiguration;
            this.SourceConfiguration = SourceConfiguration;
            
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
        /// A unique Id (V4 UUID) identifying this communication
        /// </summary>
        /// <value>A unique Id (V4 UUID) identifying this communication</value>
        [DataMember(Name="communicationId", EmitDefaultValue=false)]
        public string CommunicationId { get; set; }



        /// <summary>
        /// Identifies the phone number used to reach this queue if it is different from the information that would be accessed by queueId.
        /// </summary>
        /// <value>Identifies the phone number used to reach this queue if it is different from the information that would be accessed by queueId.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }



        /// <summary>
        /// The id (V4 UUID) of the queue that is routing this conversation.
        /// </summary>
        /// <value>The id (V4 UUID) of the queue that is routing this conversation.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// The automatic number identification if it is available for this conversation.
        /// </summary>
        /// <value>The automatic number identification if it is available for this conversation.</value>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }



        /// <summary>
        /// The dialed number identification if it is available for this conversation.
        /// </summary>
        /// <value>The dialed number identification if it is available for this conversation.</value>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }



        /// <summary>
        /// The unique identifiers (V4 UUID) for the skills that should be used to determine the destination for the conversation.
        /// </summary>
        /// <value>The unique identifiers (V4 UUID) for the skills that should be used to determine the destination for the conversation.</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }



        /// <summary>
        /// The unique identifier (V4 UUID) for the language that should be used to determine the destination for the conversation.
        /// </summary>
        /// <value>The unique identifier (V4 UUID) for the language that should be used to determine the destination for the conversation.</value>
        [DataMember(Name="languageId", EmitDefaultValue=false)]
        public string LanguageId { get; set; }



        /// <summary>
        /// Metadata about this communication.
        /// </summary>
        /// <value>Metadata about this communication.</value>
        [DataMember(Name="initialConfiguration", EmitDefaultValue=false)]
        public InitialConfiguration InitialConfiguration { get; set; }



        /// <summary>
        /// Metadata about the source of this communication's interaction.
        /// </summary>
        /// <value>Metadata about the source of this communication's interaction.</value>
        [DataMember(Name="sourceConfiguration", EmitDefaultValue=false)]
        public SourceConfiguration SourceConfiguration { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingEstablishedEvent {\n");

            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  InitialConfiguration: ").Append(InitialConfiguration).Append("\n");
            sb.Append("  SourceConfiguration: ").Append(SourceConfiguration).Append("\n");
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
            return this.Equals(obj as RoutingEstablishedEvent);
        }

        /// <summary>
        /// Returns true if RoutingEstablishedEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutingEstablishedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingEstablishedEvent other)
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
                    this.CommunicationId == other.CommunicationId ||
                    this.CommunicationId != null &&
                    this.CommunicationId.Equals(other.CommunicationId)
                ) &&
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) &&
                (
                    this.Dnis == other.Dnis ||
                    this.Dnis != null &&
                    this.Dnis.Equals(other.Dnis)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
                ) &&
                (
                    this.LanguageId == other.LanguageId ||
                    this.LanguageId != null &&
                    this.LanguageId.Equals(other.LanguageId)
                ) &&
                (
                    this.InitialConfiguration == other.InitialConfiguration ||
                    this.InitialConfiguration != null &&
                    this.InitialConfiguration.Equals(other.InitialConfiguration)
                ) &&
                (
                    this.SourceConfiguration == other.SourceConfiguration ||
                    this.SourceConfiguration != null &&
                    this.SourceConfiguration.Equals(other.SourceConfiguration)
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

                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();

                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();

                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();

                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();

                if (this.LanguageId != null)
                    hash = hash * 59 + this.LanguageId.GetHashCode();

                if (this.InitialConfiguration != null)
                    hash = hash * 59 + this.InitialConfiguration.GetHashCode();

                if (this.SourceConfiguration != null)
                    hash = hash * 59 + this.SourceConfiguration.GetHashCode();

                return hash;
            }
        }
    }

}
