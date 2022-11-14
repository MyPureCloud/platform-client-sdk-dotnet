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
    /// CommunicationEndedEvent
    /// </summary>
    [DataContract]
    public partial class CommunicationEndedEvent :  IEquatable<CommunicationEndedEvent>
    {
        /// <summary>
        /// Indicates how this communication was ended.
        /// </summary>
        /// <value>Indicates how this communication was ended.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DisconnectTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Self for "Self"
            /// </summary>
            [EnumMember(Value = "Self")]
            Self,
            
            /// <summary>
            /// Enum Peer for "Peer"
            /// </summary>
            [EnumMember(Value = "Peer")]
            Peer,
            
            /// <summary>
            /// Enum System for "System"
            /// </summary>
            [EnumMember(Value = "System")]
            System,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Transfer for "Transfer"
            /// </summary>
            [EnumMember(Value = "Transfer")]
            Transfer,
            
            /// <summary>
            /// Enum Transferconsult for "TransferConsult"
            /// </summary>
            [EnumMember(Value = "TransferConsult")]
            Transferconsult,
            
            /// <summary>
            /// Enum Transferconference for "TransferConference"
            /// </summary>
            [EnumMember(Value = "TransferConference")]
            Transferconference
        }
        /// <summary>
        /// Indicates how this communication was ended.
        /// </summary>
        /// <value>Indicates how this communication was ended.</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunicationEndedEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommunicationEndedEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommunicationEndedEvent" /> class.
        /// </summary>
        /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
        /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
        /// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication (required).</param>
        /// <param name="DisconnectType">Indicates how this communication was ended. (required).</param>
        /// <param name="DestinationConversationId">The id (V4 UUID) of the conversation that the communication is being moved to when conversations are merged..</param>
        public CommunicationEndedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, DisconnectTypeEnum? DisconnectType = null, string DestinationConversationId = null)
        {
            this.EventId = EventId;
            this.EventDateTime = EventDateTime;
            this.ConversationId = ConversationId;
            this.CommunicationId = CommunicationId;
            this.DisconnectType = DisconnectType;
            this.DestinationConversationId = DestinationConversationId;
            
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
        /// The id (V4 UUID) of the conversation that the communication is being moved to when conversations are merged.
        /// </summary>
        /// <value>The id (V4 UUID) of the conversation that the communication is being moved to when conversations are merged.</value>
        [DataMember(Name="destinationConversationId", EmitDefaultValue=false)]
        public string DestinationConversationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommunicationEndedEvent {\n");

            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  DestinationConversationId: ").Append(DestinationConversationId).Append("\n");
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
            return this.Equals(obj as CommunicationEndedEvent);
        }

        /// <summary>
        /// Returns true if CommunicationEndedEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of CommunicationEndedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommunicationEndedEvent other)
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
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.DestinationConversationId == other.DestinationConversationId ||
                    this.DestinationConversationId != null &&
                    this.DestinationConversationId.Equals(other.DestinationConversationId)
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

                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();

                if (this.DestinationConversationId != null)
                    hash = hash * 59 + this.DestinationConversationId.GetHashCode();

                return hash;
            }
        }
    }

}
