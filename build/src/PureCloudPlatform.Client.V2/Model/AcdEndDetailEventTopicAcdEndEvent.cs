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
    /// AcdEndDetailEventTopicAcdEndEvent
    /// </summary>
    [DataContract]
    public partial class AcdEndDetailEventTopicAcdEndEvent :  IEquatable<AcdEndDetailEventTopicAcdEndEvent>
    {
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
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
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Endpoint for "ENDPOINT"
            /// </summary>
            [EnumMember(Value = "ENDPOINT")]
            Endpoint,
            
            /// <summary>
            /// Enum Client for "CLIENT"
            /// </summary>
            [EnumMember(Value = "CLIENT")]
            Client,
            
            /// <summary>
            /// Enum System for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            System,
            
            /// <summary>
            /// Enum Transfer for "TRANSFER"
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            Transfer,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error,
            
            /// <summary>
            /// Enum Peer for "PEER"
            /// </summary>
            [EnumMember(Value = "PEER")]
            Peer,
            
            /// <summary>
            /// Enum Other for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            Other,
            
            /// <summary>
            /// Enum Spam for "SPAM"
            /// </summary>
            [EnumMember(Value = "SPAM")]
            Spam,
            
            /// <summary>
            /// Enum Timeout for "TIMEOUT"
            /// </summary>
            [EnumMember(Value = "TIMEOUT")]
            Timeout,
            
            /// <summary>
            /// Enum TransportFailure for "TRANSPORT_FAILURE"
            /// </summary>
            [EnumMember(Value = "TRANSPORT_FAILURE")]
            TransportFailure,
            
            /// <summary>
            /// Enum ConferenceTransfer for "CONFERENCE_TRANSFER"
            /// </summary>
            [EnumMember(Value = "CONFERENCE_TRANSFER")]
            ConferenceTransfer,
            
            /// <summary>
            /// Enum ConsultTransfer for "CONSULT_TRANSFER"
            /// </summary>
            [EnumMember(Value = "CONSULT_TRANSFER")]
            ConsultTransfer,
            
            /// <summary>
            /// Enum ForwardTransfer for "FORWARD_TRANSFER"
            /// </summary>
            [EnumMember(Value = "FORWARD_TRANSFER")]
            ForwardTransfer,
            
            /// <summary>
            /// Enum NoAnswerTransfer for "NO_ANSWER_TRANSFER"
            /// </summary>
            [EnumMember(Value = "NO_ANSWER_TRANSFER")]
            NoAnswerTransfer,
            
            /// <summary>
            /// Enum NotAvailableTransfer for "NOT_AVAILABLE_TRANSFER"
            /// </summary>
            [EnumMember(Value = "NOT_AVAILABLE_TRANSFER")]
            NotAvailableTransfer,
            
            /// <summary>
            /// Enum Uncallable for "UNCALLABLE"
            /// </summary>
            [EnumMember(Value = "UNCALLABLE")]
            Uncallable,
            
            /// <summary>
            /// Enum DndEndpoint for "DND_ENDPOINT"
            /// </summary>
            [EnumMember(Value = "DND_ENDPOINT")]
            DndEndpoint,
            
            /// <summary>
            /// Enum DndTransfer for "DND_TRANSFER"
            /// </summary>
            [EnumMember(Value = "DND_TRANSFER")]
            DndTransfer
        }
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
            Message
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
        /// Gets or Sets AcdOutcome
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AcdOutcomeEnum
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
            /// Enum Abandon for "ABANDON"
            /// </summary>
            [EnumMember(Value = "ABANDON")]
            Abandon,
            
            /// <summary>
            /// Enum Answered for "ANSWERED"
            /// </summary>
            [EnumMember(Value = "ANSWERED")]
            Answered,
            
            /// <summary>
            /// Enum FlowOut for "FLOW_OUT"
            /// </summary>
            [EnumMember(Value = "FLOW_OUT")]
            FlowOut
        }
        /// <summary>
        /// Gets or Sets RequestedRoutings
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RequestedRoutingsEnum
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
            /// Enum Manual for "MANUAL"
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            Manual,
            
            /// <summary>
            /// Enum Predictive for "PREDICTIVE"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE")]
            Predictive,
            
            /// <summary>
            /// Enum Preferred for "PREFERRED"
            /// </summary>
            [EnumMember(Value = "PREFERRED")]
            Preferred,
            
            /// <summary>
            /// Enum Last for "LAST"
            /// </summary>
            [EnumMember(Value = "LAST")]
            Last,
            
            /// <summary>
            /// Enum Bullseye for "BULLSEYE"
            /// </summary>
            [EnumMember(Value = "BULLSEYE")]
            Bullseye,
            
            /// <summary>
            /// Enum Standard for "STANDARD"
            /// </summary>
            [EnumMember(Value = "STANDARD")]
            Standard,
            
            /// <summary>
            /// Enum Other for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            Other,
            
            /// <summary>
            /// Enum Conditional for "CONDITIONAL"
            /// </summary>
            [EnumMember(Value = "CONDITIONAL")]
            Conditional,
            
            /// <summary>
            /// Enum Vip for "VIP"
            /// </summary>
            [EnumMember(Value = "VIP")]
            Vip
        }
        /// <summary>
        /// Gets or Sets UsedRouting
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UsedRoutingEnum
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
            /// Enum Manual for "MANUAL"
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            Manual,
            
            /// <summary>
            /// Enum Predictive for "PREDICTIVE"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE")]
            Predictive,
            
            /// <summary>
            /// Enum Preferred for "PREFERRED"
            /// </summary>
            [EnumMember(Value = "PREFERRED")]
            Preferred,
            
            /// <summary>
            /// Enum Last for "LAST"
            /// </summary>
            [EnumMember(Value = "LAST")]
            Last,
            
            /// <summary>
            /// Enum Bullseye for "BULLSEYE"
            /// </summary>
            [EnumMember(Value = "BULLSEYE")]
            Bullseye,
            
            /// <summary>
            /// Enum Standard for "STANDARD"
            /// </summary>
            [EnumMember(Value = "STANDARD")]
            Standard,
            
            /// <summary>
            /// Enum Other for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            Other,
            
            /// <summary>
            /// Enum Conditional for "CONDITIONAL"
            /// </summary>
            [EnumMember(Value = "CONDITIONAL")]
            Conditional,
            
            /// <summary>
            /// Enum Vip for "VIP"
            /// </summary>
            [EnumMember(Value = "VIP")]
            Vip
        }
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
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
        /// Gets or Sets AcdOutcome
        /// </summary>
        [DataMember(Name="acdOutcome", EmitDefaultValue=false)]
        public AcdOutcomeEnum? AcdOutcome { get; set; }
        /// <summary>
        /// Gets or Sets UsedRouting
        /// </summary>
        [DataMember(Name="usedRouting", EmitDefaultValue=false)]
        public UsedRoutingEnum? UsedRouting { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AcdEndDetailEventTopicAcdEndEvent" /> class.
        /// </summary>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="ParticipantId">ParticipantId.</param>
        /// <param name="SessionId">SessionId.</param>
        /// <param name="DisconnectType">DisconnectType.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="Provider">Provider.</param>
        /// <param name="Direction">Direction.</param>
        /// <param name="Ani">Ani.</param>
        /// <param name="Dnis">Dnis.</param>
        /// <param name="AddressTo">AddressTo.</param>
        /// <param name="AddressFrom">AddressFrom.</param>
        /// <param name="CallbackUserName">CallbackUserName.</param>
        /// <param name="CallbackNumbers">CallbackNumbers.</param>
        /// <param name="CallbackScheduledTime">CallbackScheduledTime.</param>
        /// <param name="Subject">Subject.</param>
        /// <param name="MessageType">MessageType.</param>
        /// <param name="QueueId">QueueId.</param>
        /// <param name="DivisionId">DivisionId.</param>
        /// <param name="AcdOutcome">AcdOutcome.</param>
        /// <param name="AnsweredUserId">AnsweredUserId.</param>
        /// <param name="RequestedRoutings">RequestedRoutings.</param>
        /// <param name="UsedRouting">UsedRouting.</param>
        /// <param name="RequestedRoutingSkillIds">RequestedRoutingSkillIds.</param>
        /// <param name="RequestedLanguageId">RequestedLanguageId.</param>
        /// <param name="RequestedRoutingUserIds">RequestedRoutingUserIds.</param>
        /// <param name="RoutingPriority">RoutingPriority.</param>
        /// <param name="ConnectedDurationMs">ConnectedDurationMs.</param>
        /// <param name="ConversationExternalContactIds">ConversationExternalContactIds.</param>
        /// <param name="ConversationExternalOrganizationIds">ConversationExternalOrganizationIds.</param>
        /// <param name="UtilizationLabel">UtilizationLabel.</param>
        /// <param name="FlowType">FlowType.</param>
        public AcdEndDetailEventTopicAcdEndEvent(int? EventTime = null, string ConversationId = null, string ParticipantId = null, string SessionId = null, DisconnectTypeEnum? DisconnectType = null, MediaTypeEnum? MediaType = null, string Provider = null, DirectionEnum? Direction = null, string Ani = null, string Dnis = null, string AddressTo = null, string AddressFrom = null, string CallbackUserName = null, List<string> CallbackNumbers = null, int? CallbackScheduledTime = null, string Subject = null, MessageTypeEnum? MessageType = null, string QueueId = null, string DivisionId = null, AcdOutcomeEnum? AcdOutcome = null, string AnsweredUserId = null, List<RequestedRoutingsEnum> RequestedRoutings = null, UsedRoutingEnum? UsedRouting = null, List<string> RequestedRoutingSkillIds = null, string RequestedLanguageId = null, List<string> RequestedRoutingUserIds = null, int? RoutingPriority = null, int? ConnectedDurationMs = null, List<string> ConversationExternalContactIds = null, List<string> ConversationExternalOrganizationIds = null, string UtilizationLabel = null, string FlowType = null)
        {
            this.EventTime = EventTime;
            this.ConversationId = ConversationId;
            this.ParticipantId = ParticipantId;
            this.SessionId = SessionId;
            this.DisconnectType = DisconnectType;
            this.MediaType = MediaType;
            this.Provider = Provider;
            this.Direction = Direction;
            this.Ani = Ani;
            this.Dnis = Dnis;
            this.AddressTo = AddressTo;
            this.AddressFrom = AddressFrom;
            this.CallbackUserName = CallbackUserName;
            this.CallbackNumbers = CallbackNumbers;
            this.CallbackScheduledTime = CallbackScheduledTime;
            this.Subject = Subject;
            this.MessageType = MessageType;
            this.QueueId = QueueId;
            this.DivisionId = DivisionId;
            this.AcdOutcome = AcdOutcome;
            this.AnsweredUserId = AnsweredUserId;
            this.RequestedRoutings = RequestedRoutings;
            this.UsedRouting = UsedRouting;
            this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
            this.RequestedLanguageId = RequestedLanguageId;
            this.RequestedRoutingUserIds = RequestedRoutingUserIds;
            this.RoutingPriority = RoutingPriority;
            this.ConnectedDurationMs = ConnectedDurationMs;
            this.ConversationExternalContactIds = ConversationExternalContactIds;
            this.ConversationExternalOrganizationIds = ConversationExternalOrganizationIds;
            this.UtilizationLabel = UtilizationLabel;
            this.FlowType = FlowType;
            
        }
        


        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public int? EventTime { get; set; }



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
        /// Gets or Sets CallbackUserName
        /// </summary>
        [DataMember(Name="callbackUserName", EmitDefaultValue=false)]
        public string CallbackUserName { get; set; }



        /// <summary>
        /// Gets or Sets CallbackNumbers
        /// </summary>
        [DataMember(Name="callbackNumbers", EmitDefaultValue=false)]
        public List<string> CallbackNumbers { get; set; }



        /// <summary>
        /// Gets or Sets CallbackScheduledTime
        /// </summary>
        [DataMember(Name="callbackScheduledTime", EmitDefaultValue=false)]
        public int? CallbackScheduledTime { get; set; }



        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }





        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// Gets or Sets DivisionId
        /// </summary>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }





        /// <summary>
        /// Gets or Sets AnsweredUserId
        /// </summary>
        [DataMember(Name="answeredUserId", EmitDefaultValue=false)]
        public string AnsweredUserId { get; set; }



        /// <summary>
        /// Gets or Sets RequestedRoutings
        /// </summary>
        [DataMember(Name="requestedRoutings", EmitDefaultValue=false)]
        public List<RequestedRoutingsEnum> RequestedRoutings { get; set; }





        /// <summary>
        /// Gets or Sets RequestedRoutingSkillIds
        /// </summary>
        [DataMember(Name="requestedRoutingSkillIds", EmitDefaultValue=false)]
        public List<string> RequestedRoutingSkillIds { get; set; }



        /// <summary>
        /// Gets or Sets RequestedLanguageId
        /// </summary>
        [DataMember(Name="requestedLanguageId", EmitDefaultValue=false)]
        public string RequestedLanguageId { get; set; }



        /// <summary>
        /// Gets or Sets RequestedRoutingUserIds
        /// </summary>
        [DataMember(Name="requestedRoutingUserIds", EmitDefaultValue=false)]
        public List<string> RequestedRoutingUserIds { get; set; }



        /// <summary>
        /// Gets or Sets RoutingPriority
        /// </summary>
        [DataMember(Name="routingPriority", EmitDefaultValue=false)]
        public int? RoutingPriority { get; set; }



        /// <summary>
        /// Gets or Sets ConnectedDurationMs
        /// </summary>
        [DataMember(Name="connectedDurationMs", EmitDefaultValue=false)]
        public int? ConnectedDurationMs { get; set; }



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
        /// Gets or Sets UtilizationLabel
        /// </summary>
        [DataMember(Name="utilizationLabel", EmitDefaultValue=false)]
        public string UtilizationLabel { get; set; }



        /// <summary>
        /// Gets or Sets FlowType
        /// </summary>
        [DataMember(Name="flowType", EmitDefaultValue=false)]
        public string FlowType { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcdEndDetailEventTopicAcdEndEvent {\n");

            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
            sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
            sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
            sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
            sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  AcdOutcome: ").Append(AcdOutcome).Append("\n");
            sb.Append("  AnsweredUserId: ").Append(AnsweredUserId).Append("\n");
            sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
            sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
            sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
            sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
            sb.Append("  RequestedRoutingUserIds: ").Append(RequestedRoutingUserIds).Append("\n");
            sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
            sb.Append("  ConnectedDurationMs: ").Append(ConnectedDurationMs).Append("\n");
            sb.Append("  ConversationExternalContactIds: ").Append(ConversationExternalContactIds).Append("\n");
            sb.Append("  ConversationExternalOrganizationIds: ").Append(ConversationExternalOrganizationIds).Append("\n");
            sb.Append("  UtilizationLabel: ").Append(UtilizationLabel).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
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
            return this.Equals(obj as AcdEndDetailEventTopicAcdEndEvent);
        }

        /// <summary>
        /// Returns true if AcdEndDetailEventTopicAcdEndEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of AcdEndDetailEventTopicAcdEndEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcdEndDetailEventTopicAcdEndEvent other)
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
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
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
                    this.CallbackUserName == other.CallbackUserName ||
                    this.CallbackUserName != null &&
                    this.CallbackUserName.Equals(other.CallbackUserName)
                ) &&
                (
                    this.CallbackNumbers == other.CallbackNumbers ||
                    this.CallbackNumbers != null &&
                    this.CallbackNumbers.SequenceEqual(other.CallbackNumbers)
                ) &&
                (
                    this.CallbackScheduledTime == other.CallbackScheduledTime ||
                    this.CallbackScheduledTime != null &&
                    this.CallbackScheduledTime.Equals(other.CallbackScheduledTime)
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
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.AcdOutcome == other.AcdOutcome ||
                    this.AcdOutcome != null &&
                    this.AcdOutcome.Equals(other.AcdOutcome)
                ) &&
                (
                    this.AnsweredUserId == other.AnsweredUserId ||
                    this.AnsweredUserId != null &&
                    this.AnsweredUserId.Equals(other.AnsweredUserId)
                ) &&
                (
                    this.RequestedRoutings == other.RequestedRoutings ||
                    this.RequestedRoutings != null &&
                    this.RequestedRoutings.SequenceEqual(other.RequestedRoutings)
                ) &&
                (
                    this.UsedRouting == other.UsedRouting ||
                    this.UsedRouting != null &&
                    this.UsedRouting.Equals(other.UsedRouting)
                ) &&
                (
                    this.RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                    this.RequestedRoutingSkillIds != null &&
                    this.RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
                ) &&
                (
                    this.RequestedLanguageId == other.RequestedLanguageId ||
                    this.RequestedLanguageId != null &&
                    this.RequestedLanguageId.Equals(other.RequestedLanguageId)
                ) &&
                (
                    this.RequestedRoutingUserIds == other.RequestedRoutingUserIds ||
                    this.RequestedRoutingUserIds != null &&
                    this.RequestedRoutingUserIds.SequenceEqual(other.RequestedRoutingUserIds)
                ) &&
                (
                    this.RoutingPriority == other.RoutingPriority ||
                    this.RoutingPriority != null &&
                    this.RoutingPriority.Equals(other.RoutingPriority)
                ) &&
                (
                    this.ConnectedDurationMs == other.ConnectedDurationMs ||
                    this.ConnectedDurationMs != null &&
                    this.ConnectedDurationMs.Equals(other.ConnectedDurationMs)
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
                ) &&
                (
                    this.UtilizationLabel == other.UtilizationLabel ||
                    this.UtilizationLabel != null &&
                    this.UtilizationLabel.Equals(other.UtilizationLabel)
                ) &&
                (
                    this.FlowType == other.FlowType ||
                    this.FlowType != null &&
                    this.FlowType.Equals(other.FlowType)
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

                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();

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

                if (this.CallbackUserName != null)
                    hash = hash * 59 + this.CallbackUserName.GetHashCode();

                if (this.CallbackNumbers != null)
                    hash = hash * 59 + this.CallbackNumbers.GetHashCode();

                if (this.CallbackScheduledTime != null)
                    hash = hash * 59 + this.CallbackScheduledTime.GetHashCode();

                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();

                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.AcdOutcome != null)
                    hash = hash * 59 + this.AcdOutcome.GetHashCode();

                if (this.AnsweredUserId != null)
                    hash = hash * 59 + this.AnsweredUserId.GetHashCode();

                if (this.RequestedRoutings != null)
                    hash = hash * 59 + this.RequestedRoutings.GetHashCode();

                if (this.UsedRouting != null)
                    hash = hash * 59 + this.UsedRouting.GetHashCode();

                if (this.RequestedRoutingSkillIds != null)
                    hash = hash * 59 + this.RequestedRoutingSkillIds.GetHashCode();

                if (this.RequestedLanguageId != null)
                    hash = hash * 59 + this.RequestedLanguageId.GetHashCode();

                if (this.RequestedRoutingUserIds != null)
                    hash = hash * 59 + this.RequestedRoutingUserIds.GetHashCode();

                if (this.RoutingPriority != null)
                    hash = hash * 59 + this.RoutingPriority.GetHashCode();

                if (this.ConnectedDurationMs != null)
                    hash = hash * 59 + this.ConnectedDurationMs.GetHashCode();

                if (this.ConversationExternalContactIds != null)
                    hash = hash * 59 + this.ConversationExternalContactIds.GetHashCode();

                if (this.ConversationExternalOrganizationIds != null)
                    hash = hash * 59 + this.ConversationExternalOrganizationIds.GetHashCode();

                if (this.UtilizationLabel != null)
                    hash = hash * 59 + this.UtilizationLabel.GetHashCode();

                if (this.FlowType != null)
                    hash = hash * 59 + this.FlowType.GetHashCode();

                return hash;
            }
        }
    }

}
