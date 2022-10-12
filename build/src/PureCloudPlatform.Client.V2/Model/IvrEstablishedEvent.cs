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
    /// IvrEstablishedEvent
    /// </summary>
    [DataContract]
    public partial class IvrEstablishedEvent :  IEquatable<IvrEstablishedEvent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="IvrEstablishedEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IvrEstablishedEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IvrEstablishedEvent" /> class.
        /// </summary>
        /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
        /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
        /// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication (required).</param>
        /// <param name="IvrPhoneNumber">The phone number for this IVR, if any is known.</param>
        /// <param name="IvrName">A displayable name for this IVR, if any is known..</param>
        /// <param name="InitialConfiguration">Metadata about this communication. (required).</param>
        /// <param name="SourceConfiguration">Metadata about the source of this communication's interaction. (required).</param>
        public IvrEstablishedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string IvrPhoneNumber = null, string IvrName = null, InitialConfiguration InitialConfiguration = null, SourceConfiguration SourceConfiguration = null)
        {
            this.EventId = EventId;
            this.EventDateTime = EventDateTime;
            this.ConversationId = ConversationId;
            this.CommunicationId = CommunicationId;
            this.IvrPhoneNumber = IvrPhoneNumber;
            this.IvrName = IvrName;
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
        /// The phone number for this IVR, if any is known
        /// </summary>
        /// <value>The phone number for this IVR, if any is known</value>
        [DataMember(Name="ivrPhoneNumber", EmitDefaultValue=false)]
        public string IvrPhoneNumber { get; set; }



        /// <summary>
        /// A displayable name for this IVR, if any is known.
        /// </summary>
        /// <value>A displayable name for this IVR, if any is known.</value>
        [DataMember(Name="ivrName", EmitDefaultValue=false)]
        public string IvrName { get; set; }



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
            sb.Append("class IvrEstablishedEvent {\n");

            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  IvrPhoneNumber: ").Append(IvrPhoneNumber).Append("\n");
            sb.Append("  IvrName: ").Append(IvrName).Append("\n");
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
            return this.Equals(obj as IvrEstablishedEvent);
        }

        /// <summary>
        /// Returns true if IvrEstablishedEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of IvrEstablishedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IvrEstablishedEvent other)
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
                    this.IvrPhoneNumber == other.IvrPhoneNumber ||
                    this.IvrPhoneNumber != null &&
                    this.IvrPhoneNumber.Equals(other.IvrPhoneNumber)
                ) &&
                (
                    this.IvrName == other.IvrName ||
                    this.IvrName != null &&
                    this.IvrName.Equals(other.IvrName)
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

                if (this.IvrPhoneNumber != null)
                    hash = hash * 59 + this.IvrPhoneNumber.GetHashCode();

                if (this.IvrName != null)
                    hash = hash * 59 + this.IvrName.GetHashCode();

                if (this.InitialConfiguration != null)
                    hash = hash * 59 + this.InitialConfiguration.GetHashCode();

                if (this.SourceConfiguration != null)
                    hash = hash * 59 + this.SourceConfiguration.GetHashCode();

                return hash;
            }
        }
    }

}
