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
    /// ConversationEventTopicMessage
    /// </summary>
    [DataContract]
    public partial class ConversationEventTopicMessage :  IEquatable<ConversationEventTopicMessage>
    {
        
        
        
        
        
        /// <summary>
        /// The connection state of this communication.
        /// </summary>
        /// <value>The connection state of this communication.</value>
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
            /// Enum Alerting for "alerting"
            /// </summary>
            [EnumMember(Value = "alerting")]
            Alerting,
            
            /// <summary>
            /// Enum Connected for "connected"
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "disconnected"
            /// </summary>
            [EnumMember(Value = "disconnected")]
            Disconnected
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
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
            /// Enum Endpoint for "endpoint"
            /// </summary>
            [EnumMember(Value = "endpoint")]
            Endpoint,
            
            /// <summary>
            /// Enum Client for "client"
            /// </summary>
            [EnumMember(Value = "client")]
            Client,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System,
            
            /// <summary>
            /// Enum Timeout for "timeout"
            /// </summary>
            [EnumMember(Value = "timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Transfer for "transfer"
            /// </summary>
            [EnumMember(Value = "transfer")]
            Transfer,
            
            /// <summary>
            /// Enum Transferconference for "transfer.conference"
            /// </summary>
            [EnumMember(Value = "transfer.conference")]
            Transferconference,
            
            /// <summary>
            /// Enum Transferconsult for "transfer.consult"
            /// </summary>
            [EnumMember(Value = "transfer.consult")]
            Transferconsult,
            
            /// <summary>
            /// Enum Transferforward for "transfer.forward"
            /// </summary>
            [EnumMember(Value = "transfer.forward")]
            Transferforward,
            
            /// <summary>
            /// Enum Transfernoanswer for "transfer.noanswer"
            /// </summary>
            [EnumMember(Value = "transfer.noanswer")]
            Transfernoanswer,
            
            /// <summary>
            /// Enum Transfernotavailable for "transfer.notavailable"
            /// </summary>
            [EnumMember(Value = "transfer.notavailable")]
            Transfernotavailable,
            
            /// <summary>
            /// Enum Transportfailure for "transport.failure"
            /// </summary>
            [EnumMember(Value = "transport.failure")]
            Transportfailure,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error,
            
            /// <summary>
            /// Enum Peer for "peer"
            /// </summary>
            [EnumMember(Value = "peer")]
            Peer,
            
            /// <summary>
            /// Enum Other for "other"
            /// </summary>
            [EnumMember(Value = "other")]
            Other,
            
            /// <summary>
            /// Enum Spam for "spam"
            /// </summary>
            [EnumMember(Value = "spam")]
            Spam,
            
            /// <summary>
            /// Enum Uncallable for "uncallable"
            /// </summary>
            [EnumMember(Value = "uncallable")]
            Uncallable
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates the type of message platform from which the message originated.
        /// </summary>
        /// <value>Indicates the type of message platform from which the message originated.</value>
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
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms,
            
            /// <summary>
            /// Enum Twitter for "twitter"
            /// </summary>
            [EnumMember(Value = "twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Facebook for "facebook"
            /// </summary>
            [EnumMember(Value = "facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Line for "line"
            /// </summary>
            [EnumMember(Value = "line")]
            Line,
            
            /// <summary>
            /// Enum Viber for "viber"
            /// </summary>
            [EnumMember(Value = "viber")]
            Viber,
            
            /// <summary>
            /// Enum Wechat for "wechat"
            /// </summary>
            [EnumMember(Value = "wechat")]
            Wechat,
            
            /// <summary>
            /// Enum Whatsapp for "whatsapp"
            /// </summary>
            [EnumMember(Value = "whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Telegram for "telegram"
            /// </summary>
            [EnumMember(Value = "telegram")]
            Telegram,
            
            /// <summary>
            /// Enum Kakao for "kakao"
            /// </summary>
            [EnumMember(Value = "kakao")]
            Kakao,
            
            /// <summary>
            /// Enum Webmessaging for "webmessaging"
            /// </summary>
            [EnumMember(Value = "webmessaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Open for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            Open,
            
            /// <summary>
            /// Enum Instagram for "instagram"
            /// </summary>
            [EnumMember(Value = "instagram")]
            Instagram
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The connection state of this communication.
        /// </summary>
        /// <value>The connection state of this communication.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates the type of message platform from which the message originated.
        /// </summary>
        /// <value>Indicates the type of message platform from which the message originated.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventTopicMessage" /> class.
        /// </summary>
        /// <param name="Id">A globally unique identifier for this communication..</param>
        /// <param name="State">The connection state of this communication..</param>
        /// <param name="Held">True if this call is held and the person on this side hears silence..</param>
        /// <param name="ErrorInfo">Detailed information about an error response..</param>
        /// <param name="Provider">The source provider of the email..</param>
        /// <param name="ScriptId">The UUID of the script to use..</param>
        /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
        /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
        /// <param name="StartHoldTime">The timestamp the email was placed on hold in the cloud clock if the email is currently on hold..</param>
        /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock..</param>
        /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock..</param>
        /// <param name="ToAddress">Address and name data for a call endpoint..</param>
        /// <param name="FromAddress">Address and name data for a call endpoint..</param>
        /// <param name="Messages">The messages sent on this communication channel..</param>
        /// <param name="MessagesTranscriptUri">the messages transcript file uri..</param>
        /// <param name="Type">Indicates the type of message platform from which the message originated..</param>
        /// <param name="RecipientCountry">Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format..</param>
        /// <param name="RecipientType">The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type..</param>
        /// <param name="JourneyContext">A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context)..</param>
        /// <param name="Wrapup">Call wrap up or disposition data..</param>
        /// <param name="AfterCallWork">A communication&#39;s after-call work data..</param>
        /// <param name="AfterCallWorkRequired">Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
        /// <param name="AgentAssistantId">UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation..</param>
        public ConversationEventTopicMessage(string Id = null, StateEnum? State = null, bool? Held = null, ConversationEventTopicErrorDetails ErrorInfo = null, string Provider = null, string ScriptId = null, string PeerId = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, ConversationEventTopicAddress ToAddress = null, ConversationEventTopicAddress FromAddress = null, List<ConversationEventTopicMessageDetails> Messages = null, string MessagesTranscriptUri = null, TypeEnum? Type = null, string RecipientCountry = null, string RecipientType = null, ConversationEventTopicJourneyContext JourneyContext = null, ConversationEventTopicWrapup Wrapup = null, ConversationEventTopicAfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, string AgentAssistantId = null)
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
            
        }
        
        
        
        /// <summary>
        /// A globally unique identifier for this communication.
        /// </summary>
        /// <value>A globally unique identifier for this communication.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
        /// <summary>
        /// True if this call is held and the person on this side hears silence.
        /// </summary>
        /// <value>True if this call is held and the person on this side hears silence.</value>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }
        
        
        
        /// <summary>
        /// Detailed information about an error response.
        /// </summary>
        /// <value>Detailed information about an error response.</value>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public ConversationEventTopicErrorDetails ErrorInfo { get; set; }
        
        
        
        /// <summary>
        /// The source provider of the email.
        /// </summary>
        /// <value>The source provider of the email.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }
        
        
        
        /// <summary>
        /// The UUID of the script to use.
        /// </summary>
        /// <value>The UUID of the script to use.</value>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public string ScriptId { get; set; }
        
        
        
        /// <summary>
        /// The id of the peer communication corresponding to a matching leg for this communication.
        /// </summary>
        /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
        [DataMember(Name="peerId", EmitDefaultValue=false)]
        public string PeerId { get; set; }
        
        
        
        
        
        /// <summary>
        /// The timestamp the email was placed on hold in the cloud clock if the email is currently on hold.
        /// </summary>
        /// <value>The timestamp the email was placed on hold in the cloud clock if the email is currently on hold.</value>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }
        
        
        
        /// <summary>
        /// The timestamp when this communication was connected in the cloud clock.
        /// </summary>
        /// <value>The timestamp when this communication was connected in the cloud clock.</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }
        
        
        
        /// <summary>
        /// The timestamp when this communication disconnected from the conversation in the provider clock.
        /// </summary>
        /// <value>The timestamp when this communication disconnected from the conversation in the provider clock.</value>
        [DataMember(Name="disconnectedTime", EmitDefaultValue=false)]
        public DateTime? DisconnectedTime { get; set; }
        
        
        
        /// <summary>
        /// Address and name data for a call endpoint.
        /// </summary>
        /// <value>Address and name data for a call endpoint.</value>
        [DataMember(Name="toAddress", EmitDefaultValue=false)]
        public ConversationEventTopicAddress ToAddress { get; set; }
        
        
        
        /// <summary>
        /// Address and name data for a call endpoint.
        /// </summary>
        /// <value>Address and name data for a call endpoint.</value>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public ConversationEventTopicAddress FromAddress { get; set; }
        
        
        
        /// <summary>
        /// The messages sent on this communication channel.
        /// </summary>
        /// <value>The messages sent on this communication channel.</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<ConversationEventTopicMessageDetails> Messages { get; set; }
        
        
        
        /// <summary>
        /// the messages transcript file uri.
        /// </summary>
        /// <value>the messages transcript file uri.</value>
        [DataMember(Name="messagesTranscriptUri", EmitDefaultValue=false)]
        public string MessagesTranscriptUri { get; set; }
        
        
        
        
        
        /// <summary>
        /// Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <value>Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format.</value>
        [DataMember(Name="recipientCountry", EmitDefaultValue=false)]
        public string RecipientCountry { get; set; }
        
        
        
        /// <summary>
        /// The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type.
        /// </summary>
        /// <value>The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type.</value>
        [DataMember(Name="recipientType", EmitDefaultValue=false)]
        public string RecipientType { get; set; }
        
        
        
        /// <summary>
        /// A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).
        /// </summary>
        /// <value>A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).</value>
        [DataMember(Name="journeyContext", EmitDefaultValue=false)]
        public ConversationEventTopicJourneyContext JourneyContext { get; set; }
        
        
        
        /// <summary>
        /// Call wrap up or disposition data.
        /// </summary>
        /// <value>Call wrap up or disposition data.</value>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public ConversationEventTopicWrapup Wrapup { get; set; }
        
        
        
        /// <summary>
        /// A communication&#39;s after-call work data.
        /// </summary>
        /// <value>A communication&#39;s after-call work data.</value>
        [DataMember(Name="afterCallWork", EmitDefaultValue=false)]
        public ConversationEventTopicAfterCallWork AfterCallWork { get; set; }
        
        
        
        /// <summary>
        /// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
        /// </summary>
        /// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
        [DataMember(Name="afterCallWorkRequired", EmitDefaultValue=false)]
        public bool? AfterCallWorkRequired { get; set; }
        
        
        
        /// <summary>
        /// UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.
        /// </summary>
        /// <value>UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.</value>
        [DataMember(Name="agentAssistantId", EmitDefaultValue=false)]
        public string AgentAssistantId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEventTopicMessage {\n");
            
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
            return this.Equals(obj as ConversationEventTopicMessage);
        }

        /// <summary>
        /// Returns true if ConversationEventTopicMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationEventTopicMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEventTopicMessage other)
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
                
                return hash;
            }
        }
    }

}
