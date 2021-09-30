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
    /// QueueConversationSocialExpressionEventTopicMessage
    /// </summary>
    [DataContract]
    public partial class QueueConversationSocialExpressionEventTopicMessage :  IEquatable<QueueConversationSocialExpressionEventTopicMessage>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alerting for "ALERTING"
            /// </summary>
            [EnumMember(Value = "ALERTING")]
            Alerting,
            
            /// <summary>
            /// Enum Connected for "CONNECTED"
            /// </summary>
            [EnumMember(Value = "CONNECTED")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "DISCONNECTED"
            /// </summary>
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
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
            /// Enum Timeout for "TIMEOUT"
            /// </summary>
            [EnumMember(Value = "TIMEOUT")]
            Timeout,
            
            /// <summary>
            /// Enum Transfer for "TRANSFER"
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            Transfer,
            
            /// <summary>
            /// Enum TransferConference for "TRANSFER_CONFERENCE"
            /// </summary>
            [EnumMember(Value = "TRANSFER_CONFERENCE")]
            TransferConference,
            
            /// <summary>
            /// Enum TransferConsult for "TRANSFER_CONSULT"
            /// </summary>
            [EnumMember(Value = "TRANSFER_CONSULT")]
            TransferConsult,
            
            /// <summary>
            /// Enum TransferForward for "TRANSFER_FORWARD"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FORWARD")]
            TransferForward,
            
            /// <summary>
            /// Enum TransferNoanswer for "TRANSFER_NOANSWER"
            /// </summary>
            [EnumMember(Value = "TRANSFER_NOANSWER")]
            TransferNoanswer,
            
            /// <summary>
            /// Enum TransferNotavailable for "TRANSFER_NOTAVAILABLE"
            /// </summary>
            [EnumMember(Value = "TRANSFER_NOTAVAILABLE")]
            TransferNotavailable,
            
            /// <summary>
            /// Enum TransportFailure for "TRANSPORT_FAILURE"
            /// </summary>
            [EnumMember(Value = "TRANSPORT_FAILURE")]
            TransportFailure,
            
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
            /// Enum Uncallable for "UNCALLABLE"
            /// </summary>
            [EnumMember(Value = "UNCALLABLE")]
            Uncallable
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
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
            /// Enum Viber for "VIBER"
            /// </summary>
            [EnumMember(Value = "VIBER")]
            Viber,
            
            /// <summary>
            /// Enum Wechat for "WECHAT"
            /// </summary>
            [EnumMember(Value = "WECHAT")]
            Wechat,
            
            /// <summary>
            /// Enum Whatsapp for "WHATSAPP"
            /// </summary>
            [EnumMember(Value = "WHATSAPP")]
            Whatsapp,
            
            /// <summary>
            /// Enum Telegram for "TELEGRAM"
            /// </summary>
            [EnumMember(Value = "TELEGRAM")]
            Telegram,
            
            /// <summary>
            /// Enum Kakao for "KAKAO"
            /// </summary>
            [EnumMember(Value = "KAKAO")]
            Kakao,
            
            /// <summary>
            /// Enum Webmessaging for "WEBMESSAGING"
            /// </summary>
            [EnumMember(Value = "WEBMESSAGING")]
            Webmessaging,
            
            /// <summary>
            /// Enum Open for "OPEN"
            /// </summary>
            [EnumMember(Value = "OPEN")]
            Open
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationSocialExpressionEventTopicMessage" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="State">State.</param>
        /// <param name="Held">Held.</param>
        /// <param name="ErrorInfo">ErrorInfo.</param>
        /// <param name="Provider">Provider.</param>
        /// <param name="ScriptId">ScriptId.</param>
        /// <param name="PeerId">PeerId.</param>
        /// <param name="DisconnectType">DisconnectType.</param>
        /// <param name="StartHoldTime">StartHoldTime.</param>
        /// <param name="ConnectedTime">ConnectedTime.</param>
        /// <param name="DisconnectedTime">DisconnectedTime.</param>
        /// <param name="ToAddress">ToAddress.</param>
        /// <param name="FromAddress">FromAddress.</param>
        /// <param name="Messages">Messages.</param>
        /// <param name="MessagesTranscriptUri">MessagesTranscriptUri.</param>
        /// <param name="Type">Type.</param>
        /// <param name="RecipientCountry">RecipientCountry.</param>
        /// <param name="RecipientType">RecipientType.</param>
        /// <param name="JourneyContext">JourneyContext.</param>
        /// <param name="Wrapup">Wrapup.</param>
        /// <param name="AfterCallWork">AfterCallWork.</param>
        /// <param name="AfterCallWorkRequired">AfterCallWorkRequired.</param>
        /// <param name="AgentAssistantId">AgentAssistantId.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public QueueConversationSocialExpressionEventTopicMessage(string Id = null, StateEnum? State = null, bool? Held = null, QueueConversationSocialExpressionEventTopicErrorDetails ErrorInfo = null, string Provider = null, string ScriptId = null, string PeerId = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, QueueConversationSocialExpressionEventTopicAddress ToAddress = null, QueueConversationSocialExpressionEventTopicAddress FromAddress = null, List<QueueConversationSocialExpressionEventTopicMessageDetails> Messages = null, string MessagesTranscriptUri = null, TypeEnum? Type = null, string RecipientCountry = null, string RecipientType = null, QueueConversationSocialExpressionEventTopicJourneyContext JourneyContext = null, QueueConversationSocialExpressionEventTopicWrapup Wrapup = null, QueueConversationSocialExpressionEventTopicAfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, string AgentAssistantId = null, Object AdditionalProperties = null)
        {
            this.Id = Id;
            this.State = State;
            this.Held = Held;
            this.ErrorInfo = ErrorInfo;
            this.Provider = Provider;
            this.ScriptId = ScriptId;
            this.PeerId = PeerId;
            this.DisconnectType = DisconnectType;
            this.StartHoldTime = StartHoldTime;
            this.ConnectedTime = ConnectedTime;
            this.DisconnectedTime = DisconnectedTime;
            this.ToAddress = ToAddress;
            this.FromAddress = FromAddress;
            this.Messages = Messages;
            this.MessagesTranscriptUri = MessagesTranscriptUri;
            this.Type = Type;
            this.RecipientCountry = RecipientCountry;
            this.RecipientType = RecipientType;
            this.JourneyContext = JourneyContext;
            this.Wrapup = Wrapup;
            this.AfterCallWork = AfterCallWork;
            this.AfterCallWorkRequired = AfterCallWorkRequired;
            this.AgentAssistantId = AgentAssistantId;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Held
        /// </summary>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorInfo
        /// </summary>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public QueueConversationSocialExpressionEventTopicErrorDetails ErrorInfo { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ScriptId
        /// </summary>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public string ScriptId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PeerId
        /// </summary>
        [DataMember(Name="peerId", EmitDefaultValue=false)]
        public string PeerId { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets StartHoldTime
        /// </summary>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ConnectedTime
        /// </summary>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DisconnectedTime
        /// </summary>
        [DataMember(Name="disconnectedTime", EmitDefaultValue=false)]
        public DateTime? DisconnectedTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ToAddress
        /// </summary>
        [DataMember(Name="toAddress", EmitDefaultValue=false)]
        public QueueConversationSocialExpressionEventTopicAddress ToAddress { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public QueueConversationSocialExpressionEventTopicAddress FromAddress { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<QueueConversationSocialExpressionEventTopicMessageDetails> Messages { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessagesTranscriptUri
        /// </summary>
        [DataMember(Name="messagesTranscriptUri", EmitDefaultValue=false)]
        public string MessagesTranscriptUri { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets RecipientCountry
        /// </summary>
        [DataMember(Name="recipientCountry", EmitDefaultValue=false)]
        public string RecipientCountry { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RecipientType
        /// </summary>
        [DataMember(Name="recipientType", EmitDefaultValue=false)]
        public string RecipientType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets JourneyContext
        /// </summary>
        [DataMember(Name="journeyContext", EmitDefaultValue=false)]
        public QueueConversationSocialExpressionEventTopicJourneyContext JourneyContext { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Wrapup
        /// </summary>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public QueueConversationSocialExpressionEventTopicWrapup Wrapup { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AfterCallWork
        /// </summary>
        [DataMember(Name="afterCallWork", EmitDefaultValue=false)]
        public QueueConversationSocialExpressionEventTopicAfterCallWork AfterCallWork { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AfterCallWorkRequired
        /// </summary>
        [DataMember(Name="afterCallWorkRequired", EmitDefaultValue=false)]
        public bool? AfterCallWorkRequired { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AgentAssistantId
        /// </summary>
        [DataMember(Name="agentAssistantId", EmitDefaultValue=false)]
        public string AgentAssistantId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationSocialExpressionEventTopicMessage {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Held: ").Append(Held).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  MessagesTranscriptUri: ").Append(MessagesTranscriptUri).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RecipientCountry: ").Append(RecipientCountry).Append("\n");
            sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
            sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
            sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
            sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
            sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
            sb.Append("  AgentAssistantId: ").Append(AgentAssistantId).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as QueueConversationSocialExpressionEventTopicMessage);
        }

        /// <summary>
        /// Returns true if QueueConversationSocialExpressionEventTopicMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationSocialExpressionEventTopicMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationSocialExpressionEventTopicMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Held == other.Held ||
                    this.Held != null &&
                    this.Held.Equals(other.Held)
                ) &&
                (
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.ScriptId == other.ScriptId ||
                    this.ScriptId != null &&
                    this.ScriptId.Equals(other.ScriptId)
                ) &&
                (
                    this.PeerId == other.PeerId ||
                    this.PeerId != null &&
                    this.PeerId.Equals(other.PeerId)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.StartHoldTime == other.StartHoldTime ||
                    this.StartHoldTime != null &&
                    this.StartHoldTime.Equals(other.StartHoldTime)
                ) &&
                (
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.DisconnectedTime == other.DisconnectedTime ||
                    this.DisconnectedTime != null &&
                    this.DisconnectedTime.Equals(other.DisconnectedTime)
                ) &&
                (
                    this.ToAddress == other.ToAddress ||
                    this.ToAddress != null &&
                    this.ToAddress.Equals(other.ToAddress)
                ) &&
                (
                    this.FromAddress == other.FromAddress ||
                    this.FromAddress != null &&
                    this.FromAddress.Equals(other.FromAddress)
                ) &&
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
                ) &&
                (
                    this.MessagesTranscriptUri == other.MessagesTranscriptUri ||
                    this.MessagesTranscriptUri != null &&
                    this.MessagesTranscriptUri.Equals(other.MessagesTranscriptUri)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.RecipientCountry == other.RecipientCountry ||
                    this.RecipientCountry != null &&
                    this.RecipientCountry.Equals(other.RecipientCountry)
                ) &&
                (
                    this.RecipientType == other.RecipientType ||
                    this.RecipientType != null &&
                    this.RecipientType.Equals(other.RecipientType)
                ) &&
                (
                    this.JourneyContext == other.JourneyContext ||
                    this.JourneyContext != null &&
                    this.JourneyContext.Equals(other.JourneyContext)
                ) &&
                (
                    this.Wrapup == other.Wrapup ||
                    this.Wrapup != null &&
                    this.Wrapup.Equals(other.Wrapup)
                ) &&
                (
                    this.AfterCallWork == other.AfterCallWork ||
                    this.AfterCallWork != null &&
                    this.AfterCallWork.Equals(other.AfterCallWork)
                ) &&
                (
                    this.AfterCallWorkRequired == other.AfterCallWorkRequired ||
                    this.AfterCallWorkRequired != null &&
                    this.AfterCallWorkRequired.Equals(other.AfterCallWorkRequired)
                ) &&
                (
                    this.AgentAssistantId == other.AgentAssistantId ||
                    this.AgentAssistantId != null &&
                    this.AgentAssistantId.Equals(other.AgentAssistantId)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();
                
                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();
                
                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();
                
                if (this.ScriptId != null)
                    hash = hash * 59 + this.ScriptId.GetHashCode();
                
                if (this.PeerId != null)
                    hash = hash * 59 + this.PeerId.GetHashCode();
                
                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();
                
                if (this.StartHoldTime != null)
                    hash = hash * 59 + this.StartHoldTime.GetHashCode();
                
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                
                if (this.DisconnectedTime != null)
                    hash = hash * 59 + this.DisconnectedTime.GetHashCode();
                
                if (this.ToAddress != null)
                    hash = hash * 59 + this.ToAddress.GetHashCode();
                
                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();
                
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                
                if (this.MessagesTranscriptUri != null)
                    hash = hash * 59 + this.MessagesTranscriptUri.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.RecipientCountry != null)
                    hash = hash * 59 + this.RecipientCountry.GetHashCode();
                
                if (this.RecipientType != null)
                    hash = hash * 59 + this.RecipientType.GetHashCode();
                
                if (this.JourneyContext != null)
                    hash = hash * 59 + this.JourneyContext.GetHashCode();
                
                if (this.Wrapup != null)
                    hash = hash * 59 + this.Wrapup.GetHashCode();
                
                if (this.AfterCallWork != null)
                    hash = hash * 59 + this.AfterCallWork.GetHashCode();
                
                if (this.AfterCallWorkRequired != null)
                    hash = hash * 59 + this.AfterCallWorkRequired.GetHashCode();
                
                if (this.AgentAssistantId != null)
                    hash = hash * 59 + this.AgentAssistantId.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
