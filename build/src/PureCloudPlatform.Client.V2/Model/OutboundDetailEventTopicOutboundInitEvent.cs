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
    /// OutboundDetailEventTopicOutboundInitEvent
    /// </summary>
    [DataContract]
    public partial class OutboundDetailEventTopicOutboundInitEvent :  IEquatable<OutboundDetailEventTopicOutboundInitEvent>
    {
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Voice for "VOICE"
            /// </summary>
            [EnumMember(Value = "VOICE")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "CHAT"
            /// </summary>
            [EnumMember(Value = "CHAT")]
            Chat,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email,
            
            /// <summary>
            /// Enum Callback for "CALLBACK"
            /// </summary>
            [EnumMember(Value = "CALLBACK")]
            Callback,
            
            /// <summary>
            /// Enum Cobrowse for "COBROWSE"
            /// </summary>
            [EnumMember(Value = "COBROWSE")]
            Cobrowse,
            
            /// <summary>
            /// Enum Video for "VIDEO"
            /// </summary>
            [EnumMember(Value = "VIDEO")]
            Video,
            
            /// <summary>
            /// Enum Screenshare for "SCREENSHARE"
            /// </summary>
            [EnumMember(Value = "SCREENSHARE")]
            Screenshare,
            
            /// <summary>
            /// Enum Message for "MESSAGE"
            /// </summary>
            [EnumMember(Value = "MESSAGE")]
            Message,
            
            /// <summary>
            /// Enum Internalmessage for "INTERNALMESSAGE"
            /// </summary>
            [EnumMember(Value = "INTERNALMESSAGE")]
            Internalmessage
        }
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Inbound for "INBOUND"
            /// </summary>
            [EnumMember(Value = "INBOUND")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "OUTBOUND"
            /// </summary>
            [EnumMember(Value = "OUTBOUND")]
            Outbound
        }
        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessageTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Sms for "SMS"
            /// </summary>
            [EnumMember(Value = "SMS")]
            Sms,
            
            /// <summary>
            /// Enum Twitter for "TWITTER"
            /// </summary>
            [EnumMember(Value = "TWITTER")]
            Twitter,
            
            /// <summary>
            /// Enum Facebook for "FACEBOOK"
            /// </summary>
            [EnumMember(Value = "FACEBOOK")]
            Facebook,
            
            /// <summary>
            /// Enum Line for "LINE"
            /// </summary>
            [EnumMember(Value = "LINE")]
            Line,
            
            /// <summary>
            /// Enum Whatsapp for "WHATSAPP"
            /// </summary>
            [EnumMember(Value = "WHATSAPP")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessaging for "WEBMESSAGING"
            /// </summary>
            [EnumMember(Value = "WEBMESSAGING")]
            Webmessaging,
            
            /// <summary>
            /// Enum Open for "OPEN"
            /// </summary>
            [EnumMember(Value = "OPEN")]
            Open,
            
            /// <summary>
            /// Enum Instagram for "INSTAGRAM"
            /// </summary>
            [EnumMember(Value = "INSTAGRAM")]
            Instagram,
            
            /// <summary>
            /// Enum Apple for "APPLE"
            /// </summary>
            [EnumMember(Value = "APPLE")]
            Apple
        }
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundDetailEventTopicOutboundInitEvent" /> class.
        /// </summary>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="ParticipantId">ParticipantId.</param>
        /// <param name="SessionId">SessionId.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="Provider">Provider.</param>
        /// <param name="Direction">Direction.</param>
        /// <param name="Ani">Ani.</param>
        /// <param name="Dnis">Dnis.</param>
        /// <param name="AddressTo">AddressTo.</param>
        /// <param name="AddressFrom">AddressFrom.</param>
        /// <param name="Subject">Subject.</param>
        /// <param name="MessageType">MessageType.</param>
        /// <param name="OutboundCampaignId">OutboundCampaignId.</param>
        /// <param name="DivisionId">DivisionId.</param>
        /// <param name="OutboundContactListId">OutboundContactListId.</param>
        /// <param name="OutboundContactId">OutboundContactId.</param>
        /// <param name="ConversationExternalContactIds">ConversationExternalContactIds.</param>
        /// <param name="ConversationExternalOrganizationIds">ConversationExternalOrganizationIds.</param>
        public OutboundDetailEventTopicOutboundInitEvent(long? EventTime = null, string ConversationId = null, string ParticipantId = null, string SessionId = null, MediaTypeEnum? MediaType = null, string Provider = null, DirectionEnum? Direction = null, string Ani = null, string Dnis = null, string AddressTo = null, string AddressFrom = null, string Subject = null, MessageTypeEnum? MessageType = null, string OutboundCampaignId = null, string DivisionId = null, string OutboundContactListId = null, string OutboundContactId = null, List<string> ConversationExternalContactIds = null, List<string> ConversationExternalOrganizationIds = null)
        {
            this.EventTime = EventTime;
            this.ConversationId = ConversationId;
            this.ParticipantId = ParticipantId;
            this.SessionId = SessionId;
            this.MediaType = MediaType;
            this.Provider = Provider;
            this.Direction = Direction;
            this.Ani = Ani;
            this.Dnis = Dnis;
            this.AddressTo = AddressTo;
            this.AddressFrom = AddressFrom;
            this.Subject = Subject;
            this.MessageType = MessageType;
            this.OutboundCampaignId = OutboundCampaignId;
            this.DivisionId = DivisionId;
            this.OutboundContactListId = OutboundContactListId;
            this.OutboundContactId = OutboundContactId;
            this.ConversationExternalContactIds = ConversationExternalContactIds;
            this.ConversationExternalOrganizationIds = ConversationExternalOrganizationIds;
            
        }
        


        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public long? EventTime { get; set; }



        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets ParticipantId
        /// </summary>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }



        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }





        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }





        /// <summary>
        /// Gets or Sets Ani
        /// </summary>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }



        /// <summary>
        /// Gets or Sets Dnis
        /// </summary>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }



        /// <summary>
        /// Gets or Sets AddressTo
        /// </summary>
        [DataMember(Name="addressTo", EmitDefaultValue=false)]
        public string AddressTo { get; set; }



        /// <summary>
        /// Gets or Sets AddressFrom
        /// </summary>
        [DataMember(Name="addressFrom", EmitDefaultValue=false)]
        public string AddressFrom { get; set; }



        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }





        /// <summary>
        /// Gets or Sets OutboundCampaignId
        /// </summary>
        [DataMember(Name="outboundCampaignId", EmitDefaultValue=false)]
        public string OutboundCampaignId { get; set; }



        /// <summary>
        /// Gets or Sets DivisionId
        /// </summary>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// Gets or Sets OutboundContactListId
        /// </summary>
        [DataMember(Name="outboundContactListId", EmitDefaultValue=false)]
        public string OutboundContactListId { get; set; }



        /// <summary>
        /// Gets or Sets OutboundContactId
        /// </summary>
        [DataMember(Name="outboundContactId", EmitDefaultValue=false)]
        public string OutboundContactId { get; set; }



        /// <summary>
        /// Gets or Sets ConversationExternalContactIds
        /// </summary>
        [DataMember(Name="conversationExternalContactIds", EmitDefaultValue=false)]
        public List<string> ConversationExternalContactIds { get; set; }



        /// <summary>
        /// Gets or Sets ConversationExternalOrganizationIds
        /// </summary>
        [DataMember(Name="conversationExternalOrganizationIds", EmitDefaultValue=false)]
        public List<string> ConversationExternalOrganizationIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundDetailEventTopicOutboundInitEvent {\n");

            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
            sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  OutboundCampaignId: ").Append(OutboundCampaignId).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  OutboundContactListId: ").Append(OutboundContactListId).Append("\n");
            sb.Append("  OutboundContactId: ").Append(OutboundContactId).Append("\n");
            sb.Append("  ConversationExternalContactIds: ").Append(ConversationExternalContactIds).Append("\n");
            sb.Append("  ConversationExternalOrganizationIds: ").Append(ConversationExternalOrganizationIds).Append("\n");
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
            return this.Equals(obj as OutboundDetailEventTopicOutboundInitEvent);
        }

        /// <summary>
        /// Returns true if OutboundDetailEventTopicOutboundInitEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundDetailEventTopicOutboundInitEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundDetailEventTopicOutboundInitEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.ParticipantId == other.ParticipantId ||
                    this.ParticipantId != null &&
                    this.ParticipantId.Equals(other.ParticipantId)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
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
                    this.AddressTo == other.AddressTo ||
                    this.AddressTo != null &&
                    this.AddressTo.Equals(other.AddressTo)
                ) &&
                (
                    this.AddressFrom == other.AddressFrom ||
                    this.AddressFrom != null &&
                    this.AddressFrom.Equals(other.AddressFrom)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) &&
                (
                    this.OutboundCampaignId == other.OutboundCampaignId ||
                    this.OutboundCampaignId != null &&
                    this.OutboundCampaignId.Equals(other.OutboundCampaignId)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.OutboundContactListId == other.OutboundContactListId ||
                    this.OutboundContactListId != null &&
                    this.OutboundContactListId.Equals(other.OutboundContactListId)
                ) &&
                (
                    this.OutboundContactId == other.OutboundContactId ||
                    this.OutboundContactId != null &&
                    this.OutboundContactId.Equals(other.OutboundContactId)
                ) &&
                (
                    this.ConversationExternalContactIds == other.ConversationExternalContactIds ||
                    this.ConversationExternalContactIds != null &&
                    this.ConversationExternalContactIds.SequenceEqual(other.ConversationExternalContactIds)
                ) &&
                (
                    this.ConversationExternalOrganizationIds == other.ConversationExternalOrganizationIds ||
                    this.ConversationExternalOrganizationIds != null &&
                    this.ConversationExternalOrganizationIds.SequenceEqual(other.ConversationExternalOrganizationIds)
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
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();

                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();

                if (this.AddressTo != null)
                    hash = hash * 59 + this.AddressTo.GetHashCode();

                if (this.AddressFrom != null)
                    hash = hash * 59 + this.AddressFrom.GetHashCode();

                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();

                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();

                if (this.OutboundCampaignId != null)
                    hash = hash * 59 + this.OutboundCampaignId.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.OutboundContactListId != null)
                    hash = hash * 59 + this.OutboundContactListId.GetHashCode();

                if (this.OutboundContactId != null)
                    hash = hash * 59 + this.OutboundContactId.GetHashCode();

                if (this.ConversationExternalContactIds != null)
                    hash = hash * 59 + this.ConversationExternalContactIds.GetHashCode();

                if (this.ConversationExternalOrganizationIds != null)
                    hash = hash * 59 + this.ConversationExternalOrganizationIds.GetHashCode();

                return hash;
            }
        }
    }

}
