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
    /// EmailUserEstablishedEvent
    /// </summary>
    [DataContract]
    public partial class EmailUserEstablishedEvent :  IEquatable<EmailUserEstablishedEvent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailUserEstablishedEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailUserEstablishedEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailUserEstablishedEvent" /> class.
        /// </summary>
        /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
        /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
        /// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication. (required).</param>
        /// <param name="UserId">A unique Id (V4 UUID) identifying this userId this communication belongs to. (required).</param>
        /// <param name="QueueId">A unique Id (V4 UUID) identifying the queue that the user is emailing on behalf of. Applies to outbound emails only..</param>
        /// <param name="AfterCallWorkRequired">Indicates whether or not this user will be required to complete after call work..</param>
        /// <param name="InitialConfiguration">Metadata about this communication. (required).</param>
        /// <param name="SourceConfiguration">Metadata about the source of this communication's interaction. (required).</param>
        public EmailUserEstablishedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string UserId = null, string QueueId = null, bool? AfterCallWorkRequired = null, EmailInitialConfiguration InitialConfiguration = null, SourceConfiguration SourceConfiguration = null)
        {
            this.EventId = EventId;
            this.EventDateTime = EventDateTime;
            this.ConversationId = ConversationId;
            this.CommunicationId = CommunicationId;
            this.UserId = UserId;
            this.QueueId = QueueId;
            this.AfterCallWorkRequired = AfterCallWorkRequired;
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
        /// A unique Id (V4 UUID) identifying this communication.
        /// </summary>
        /// <value>A unique Id (V4 UUID) identifying this communication.</value>
        [DataMember(Name="communicationId", EmitDefaultValue=false)]
        public string CommunicationId { get; set; }



        /// <summary>
        /// A unique Id (V4 UUID) identifying this userId this communication belongs to.
        /// </summary>
        /// <value>A unique Id (V4 UUID) identifying this userId this communication belongs to.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// A unique Id (V4 UUID) identifying the queue that the user is emailing on behalf of. Applies to outbound emails only.
        /// </summary>
        /// <value>A unique Id (V4 UUID) identifying the queue that the user is emailing on behalf of. Applies to outbound emails only.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// Indicates whether or not this user will be required to complete after call work.
        /// </summary>
        /// <value>Indicates whether or not this user will be required to complete after call work.</value>
        [DataMember(Name="afterCallWorkRequired", EmitDefaultValue=false)]
        public bool? AfterCallWorkRequired { get; set; }



        /// <summary>
        /// Metadata about this communication.
        /// </summary>
        /// <value>Metadata about this communication.</value>
        [DataMember(Name="initialConfiguration", EmitDefaultValue=false)]
        public EmailInitialConfiguration InitialConfiguration { get; set; }



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
            sb.Append("class EmailUserEstablishedEvent {\n");

            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
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
            return this.Equals(obj as EmailUserEstablishedEvent);
        }

        /// <summary>
        /// Returns true if EmailUserEstablishedEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailUserEstablishedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailUserEstablishedEvent other)
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
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.AfterCallWorkRequired == other.AfterCallWorkRequired ||
                    this.AfterCallWorkRequired != null &&
                    this.AfterCallWorkRequired.Equals(other.AfterCallWorkRequired)
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

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.AfterCallWorkRequired != null)
                    hash = hash * 59 + this.AfterCallWorkRequired.GetHashCode();

                if (this.InitialConfiguration != null)
                    hash = hash * 59 + this.InitialConfiguration.GetHashCode();

                if (this.SourceConfiguration != null)
                    hash = hash * 59 + this.SourceConfiguration.GetHashCode();

                return hash;
            }
        }
    }

}
