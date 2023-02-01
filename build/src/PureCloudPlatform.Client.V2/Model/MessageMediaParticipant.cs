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
    /// MessageMediaParticipant
    /// </summary>
    [DataContract]
    public partial class MessageMediaParticipant :  IEquatable<MessageMediaParticipant>
    {
        /// <summary>
        /// The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting
        /// </summary>
        /// <value>The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting</value>
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
            /// Enum Dialing for "dialing"
            /// </summary>
            [EnumMember(Value = "dialing")]
            Dialing,
            
            /// <summary>
            /// Enum Contacting for "contacting"
            /// </summary>
            [EnumMember(Value = "contacting")]
            Contacting,
            
            /// <summary>
            /// Enum Offering for "offering"
            /// </summary>
            [EnumMember(Value = "offering")]
            Offering,
            
            /// <summary>
            /// Enum Connected for "connected"
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "disconnected"
            /// </summary>
            [EnumMember(Value = "disconnected")]
            Disconnected,
            
            /// <summary>
            /// Enum Terminated for "terminated"
            /// </summary>
            [EnumMember(Value = "terminated")]
            Terminated,
            
            /// <summary>
            /// Enum Converting for "converting"
            /// </summary>
            [EnumMember(Value = "converting")]
            Converting,
            
            /// <summary>
            /// Enum Uploading for "uploading"
            /// </summary>
            [EnumMember(Value = "uploading")]
            Uploading,
            
            /// <summary>
            /// Enum Transmitting for "transmitting"
            /// </summary>
            [EnumMember(Value = "transmitting")]
            Transmitting,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None
        }
        /// <summary>
        /// The participant's direction.  Values can be: 'inbound' or 'outbound'
        /// </summary>
        /// <value>The participant's direction.  Values can be: 'inbound' or 'outbound'</value>
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
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }
        /// <summary>
        /// The reason the participant was disconnected from the conversation.
        /// </summary>
        /// <value>The reason the participant was disconnected from the conversation.</value>
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
            Spam
        }
        /// <summary>
        /// The reason specifying why participant flagged the conversation.
        /// </summary>
        /// <value>The reason specifying why participant flagged the conversation.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlaggedReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum General for "general"
            /// </summary>
            [EnumMember(Value = "general")]
            General
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
        /// The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting
        /// </summary>
        /// <value>The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// The participant's direction.  Values can be: 'inbound' or 'outbound'
        /// </summary>
        /// <value>The participant's direction.  Values can be: 'inbound' or 'outbound'</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// The reason the participant was disconnected from the conversation.
        /// </summary>
        /// <value>The reason the participant was disconnected from the conversation.</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        /// <summary>
        /// The reason specifying why participant flagged the conversation.
        /// </summary>
        /// <value>The reason specifying why participant flagged the conversation.</value>
        [DataMember(Name="flaggedReason", EmitDefaultValue=false)]
        public FlaggedReasonEnum? FlaggedReason { get; set; }
        /// <summary>
        /// Indicates the type of message platform from which the message originated.
        /// </summary>
        /// <value>Indicates the type of message platform from which the message originated.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageMediaParticipant" /> class.
        /// </summary>
        /// <param name="Id">The unique participant ID..</param>
        /// <param name="Name">The display friendly name of the participant..</param>
        /// <param name="Address">The participant address..</param>
        /// <param name="StartTime">The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ConnectedTime">The time when this participant went connected for this media (eg: video connected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="EndTime">The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="StartHoldTime">The time when this participant's hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Purpose">The participant's purpose.  Values can be: 'agent', 'user', 'customer', 'external', 'acd', 'ivr.</param>
        /// <param name="State">The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting.</param>
        /// <param name="Direction">The participant's direction.  Values can be: 'inbound' or 'outbound'.</param>
        /// <param name="DisconnectType">The reason the participant was disconnected from the conversation..</param>
        /// <param name="Held">Value is true when the participant is on hold..</param>
        /// <param name="WrapupRequired">Value is true when the participant requires wrap-up..</param>
        /// <param name="WrapupPrompt">The wrap-up prompt indicating the type of wrap-up to be performed..</param>
        /// <param name="MediaRoles">List of roles this participant's media has had on the conversation, ie monitor, coach, etc.</param>
        /// <param name="User">The PureCloud user for this participant..</param>
        /// <param name="Queue">The PureCloud queue for this participant..</param>
        /// <param name="Team">The PureCloud team for this participant..</param>
        /// <param name="Attributes">A list of ad-hoc attributes for the participant..</param>
        /// <param name="ErrorInfo">If the conversation ends in error, contains additional error details..</param>
        /// <param name="Script">The Engage script that should be used by this participant..</param>
        /// <param name="WrapupTimeoutMs">The amount of time the participant has to complete wrap-up..</param>
        /// <param name="WrapupSkipped">Value is true when the participant has skipped wrap-up..</param>
        /// <param name="AlertingTimeoutMs">Specifies how long the agent has to answer an interaction before being marked as not responding..</param>
        /// <param name="Provider">The source provider for the communication..</param>
        /// <param name="ExternalContact">If this participant represents an external contact, then this will be the reference for the external contact..</param>
        /// <param name="ExternalOrganization">If this participant represents an external org, then this will be the reference for the external org..</param>
        /// <param name="Wrapup">Wrapup for this participant, if it has been applied..</param>
        /// <param name="Peer">The peer communication corresponding to a matching leg for this communication..</param>
        /// <param name="FlaggedReason">The reason specifying why participant flagged the conversation..</param>
        /// <param name="JourneyContext">Journey System data/context that is applicable to this communication.  When used for historical purposes, the context should be immutable.  When null, there is no applicable Journey System context..</param>
        /// <param name="ConversationRoutingData">Information on how a communication should be routed to an agent..</param>
        /// <param name="StartAcwTime">The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="EndAcwTime">The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ToAddress">Address for the participant on receiving side of the message conversation. If the address is a phone number, E.164 format is recommended..</param>
        /// <param name="FromAddress">Address for the participant on the sending side of the message conversation. If the address is a phone number, E.164 format is recommended..</param>
        /// <param name="Messages">Message instance details on the communication..</param>
        /// <param name="Type">Indicates the type of message platform from which the message originated..</param>
        /// <param name="RecipientCountry">Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format..</param>
        /// <param name="RecipientType">The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type..</param>
        /// <param name="Authenticated">If true, the participant member is authenticated..</param>
        public MessageMediaParticipant(string Id = null, string Name = null, string Address = null, DateTime? StartTime = null, DateTime? ConnectedTime = null, DateTime? EndTime = null, DateTime? StartHoldTime = null, string Purpose = null, StateEnum? State = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, bool? Held = null, bool? WrapupRequired = null, string WrapupPrompt = null, List<string> MediaRoles = null, DomainEntityRef User = null, DomainEntityRef Queue = null, DomainEntityRef Team = null, Dictionary<string, string> Attributes = null, ErrorInfo ErrorInfo = null, DomainEntityRef Script = null, int? WrapupTimeoutMs = null, bool? WrapupSkipped = null, int? AlertingTimeoutMs = null, string Provider = null, DomainEntityRef ExternalContact = null, DomainEntityRef ExternalOrganization = null, Wrapup Wrapup = null, string Peer = null, FlaggedReasonEnum? FlaggedReason = null, JourneyContext JourneyContext = null, ConversationRoutingData ConversationRoutingData = null, DateTime? StartAcwTime = null, DateTime? EndAcwTime = null, Address ToAddress = null, Address FromAddress = null, List<MessageDetails> Messages = null, TypeEnum? Type = null, string RecipientCountry = null, string RecipientType = null, bool? Authenticated = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.StartTime = StartTime;
            this.ConnectedTime = ConnectedTime;
            this.EndTime = EndTime;
            this.StartHoldTime = StartHoldTime;
            this.Purpose = Purpose;
            this.State = State;
            this.Direction = Direction;
            this.DisconnectType = DisconnectType;
            this.Held = Held;
            this.WrapupRequired = WrapupRequired;
            this.WrapupPrompt = WrapupPrompt;
            this.MediaRoles = MediaRoles;
            this.User = User;
            this.Queue = Queue;
            this.Team = Team;
            this.Attributes = Attributes;
            this.ErrorInfo = ErrorInfo;
            this.Script = Script;
            this.WrapupTimeoutMs = WrapupTimeoutMs;
            this.WrapupSkipped = WrapupSkipped;
            this.AlertingTimeoutMs = AlertingTimeoutMs;
            this.Provider = Provider;
            this.ExternalContact = ExternalContact;
            this.ExternalOrganization = ExternalOrganization;
            this.Wrapup = Wrapup;
            this.Peer = Peer;
            this.FlaggedReason = FlaggedReason;
            this.JourneyContext = JourneyContext;
            this.ConversationRoutingData = ConversationRoutingData;
            this.StartAcwTime = StartAcwTime;
            this.EndAcwTime = EndAcwTime;
            this.ToAddress = ToAddress;
            this.FromAddress = FromAddress;
            this.Messages = Messages;
            this.Type = Type;
            this.RecipientCountry = RecipientCountry;
            this.RecipientType = RecipientType;
            this.Authenticated = Authenticated;
            
        }
        


        /// <summary>
        /// The unique participant ID.
        /// </summary>
        /// <value>The unique participant ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The display friendly name of the participant.
        /// </summary>
        /// <value>The display friendly name of the participant.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The participant address.
        /// </summary>
        /// <value>The participant address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }



        /// <summary>
        /// The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }



        /// <summary>
        /// The time when this participant went connected for this media (eg: video connected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when this participant went connected for this media (eg: video connected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }



        /// <summary>
        /// The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }



        /// <summary>
        /// The time when this participant's hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when this participant's hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }



        /// <summary>
        /// The participant's purpose.  Values can be: 'agent', 'user', 'customer', 'external', 'acd', 'ivr
        /// </summary>
        /// <value>The participant's purpose.  Values can be: 'agent', 'user', 'customer', 'external', 'acd', 'ivr</value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }









        /// <summary>
        /// Value is true when the participant is on hold.
        /// </summary>
        /// <value>Value is true when the participant is on hold.</value>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }



        /// <summary>
        /// Value is true when the participant requires wrap-up.
        /// </summary>
        /// <value>Value is true when the participant requires wrap-up.</value>
        [DataMember(Name="wrapupRequired", EmitDefaultValue=false)]
        public bool? WrapupRequired { get; set; }



        /// <summary>
        /// The wrap-up prompt indicating the type of wrap-up to be performed.
        /// </summary>
        /// <value>The wrap-up prompt indicating the type of wrap-up to be performed.</value>
        [DataMember(Name="wrapupPrompt", EmitDefaultValue=false)]
        public string WrapupPrompt { get; set; }



        /// <summary>
        /// List of roles this participant's media has had on the conversation, ie monitor, coach, etc
        /// </summary>
        /// <value>List of roles this participant's media has had on the conversation, ie monitor, coach, etc</value>
        [DataMember(Name="mediaRoles", EmitDefaultValue=false)]
        public List<string> MediaRoles { get; set; }



        /// <summary>
        /// The PureCloud user for this participant.
        /// </summary>
        /// <value>The PureCloud user for this participant.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public DomainEntityRef User { get; set; }



        /// <summary>
        /// The PureCloud queue for this participant.
        /// </summary>
        /// <value>The PureCloud queue for this participant.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public DomainEntityRef Queue { get; set; }



        /// <summary>
        /// The PureCloud team for this participant.
        /// </summary>
        /// <value>The PureCloud team for this participant.</value>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public DomainEntityRef Team { get; set; }



        /// <summary>
        /// A list of ad-hoc attributes for the participant.
        /// </summary>
        /// <value>A list of ad-hoc attributes for the participant.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }



        /// <summary>
        /// If the conversation ends in error, contains additional error details.
        /// </summary>
        /// <value>If the conversation ends in error, contains additional error details.</value>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public ErrorInfo ErrorInfo { get; set; }



        /// <summary>
        /// The Engage script that should be used by this participant.
        /// </summary>
        /// <value>The Engage script that should be used by this participant.</value>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public DomainEntityRef Script { get; set; }



        /// <summary>
        /// The amount of time the participant has to complete wrap-up.
        /// </summary>
        /// <value>The amount of time the participant has to complete wrap-up.</value>
        [DataMember(Name="wrapupTimeoutMs", EmitDefaultValue=false)]
        public int? WrapupTimeoutMs { get; set; }



        /// <summary>
        /// Value is true when the participant has skipped wrap-up.
        /// </summary>
        /// <value>Value is true when the participant has skipped wrap-up.</value>
        [DataMember(Name="wrapupSkipped", EmitDefaultValue=false)]
        public bool? WrapupSkipped { get; set; }



        /// <summary>
        /// Specifies how long the agent has to answer an interaction before being marked as not responding.
        /// </summary>
        /// <value>Specifies how long the agent has to answer an interaction before being marked as not responding.</value>
        [DataMember(Name="alertingTimeoutMs", EmitDefaultValue=false)]
        public int? AlertingTimeoutMs { get; set; }



        /// <summary>
        /// The source provider for the communication.
        /// </summary>
        /// <value>The source provider for the communication.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }



        /// <summary>
        /// If this participant represents an external contact, then this will be the reference for the external contact.
        /// </summary>
        /// <value>If this participant represents an external contact, then this will be the reference for the external contact.</value>
        [DataMember(Name="externalContact", EmitDefaultValue=false)]
        public DomainEntityRef ExternalContact { get; set; }



        /// <summary>
        /// If this participant represents an external org, then this will be the reference for the external org.
        /// </summary>
        /// <value>If this participant represents an external org, then this will be the reference for the external org.</value>
        [DataMember(Name="externalOrganization", EmitDefaultValue=false)]
        public DomainEntityRef ExternalOrganization { get; set; }



        /// <summary>
        /// Wrapup for this participant, if it has been applied.
        /// </summary>
        /// <value>Wrapup for this participant, if it has been applied.</value>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public Wrapup Wrapup { get; set; }



        /// <summary>
        /// The peer communication corresponding to a matching leg for this communication.
        /// </summary>
        /// <value>The peer communication corresponding to a matching leg for this communication.</value>
        [DataMember(Name="peer", EmitDefaultValue=false)]
        public string Peer { get; set; }





        /// <summary>
        /// Journey System data/context that is applicable to this communication.  When used for historical purposes, the context should be immutable.  When null, there is no applicable Journey System context.
        /// </summary>
        /// <value>Journey System data/context that is applicable to this communication.  When used for historical purposes, the context should be immutable.  When null, there is no applicable Journey System context.</value>
        [DataMember(Name="journeyContext", EmitDefaultValue=false)]
        public JourneyContext JourneyContext { get; set; }



        /// <summary>
        /// Information on how a communication should be routed to an agent.
        /// </summary>
        /// <value>Information on how a communication should be routed to an agent.</value>
        [DataMember(Name="conversationRoutingData", EmitDefaultValue=false)]
        public ConversationRoutingData ConversationRoutingData { get; set; }



        /// <summary>
        /// The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startAcwTime", EmitDefaultValue=false)]
        public DateTime? StartAcwTime { get; set; }



        /// <summary>
        /// The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="endAcwTime", EmitDefaultValue=false)]
        public DateTime? EndAcwTime { get; set; }



        /// <summary>
        /// Address for the participant on receiving side of the message conversation. If the address is a phone number, E.164 format is recommended.
        /// </summary>
        /// <value>Address for the participant on receiving side of the message conversation. If the address is a phone number, E.164 format is recommended.</value>
        [DataMember(Name="toAddress", EmitDefaultValue=false)]
        public Address ToAddress { get; set; }



        /// <summary>
        /// Address for the participant on the sending side of the message conversation. If the address is a phone number, E.164 format is recommended.
        /// </summary>
        /// <value>Address for the participant on the sending side of the message conversation. If the address is a phone number, E.164 format is recommended.</value>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public Address FromAddress { get; set; }



        /// <summary>
        /// Message instance details on the communication.
        /// </summary>
        /// <value>Message instance details on the communication.</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<MessageDetails> Messages { get; set; }





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
        /// If true, the participant member is authenticated.
        /// </summary>
        /// <value>If true, the participant member is authenticated.</value>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageMediaParticipant {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  Held: ").Append(Held).Append("\n");
            sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
            sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
            sb.Append("  MediaRoles: ").Append(MediaRoles).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
            sb.Append("  WrapupSkipped: ").Append(WrapupSkipped).Append("\n");
            sb.Append("  AlertingTimeoutMs: ").Append(AlertingTimeoutMs).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
            sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
            sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
            sb.Append("  Peer: ").Append(Peer).Append("\n");
            sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
            sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
            sb.Append("  ConversationRoutingData: ").Append(ConversationRoutingData).Append("\n");
            sb.Append("  StartAcwTime: ").Append(StartAcwTime).Append("\n");
            sb.Append("  EndAcwTime: ").Append(EndAcwTime).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RecipientCountry: ").Append(RecipientCountry).Append("\n");
            sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
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
            return this.Equals(obj as MessageMediaParticipant);
        }

        /// <summary>
        /// Returns true if MessageMediaParticipant instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageMediaParticipant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageMediaParticipant other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.StartHoldTime == other.StartHoldTime ||
                    this.StartHoldTime != null &&
                    this.StartHoldTime.Equals(other.StartHoldTime)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.Held == other.Held ||
                    this.Held != null &&
                    this.Held.Equals(other.Held)
                ) &&
                (
                    this.WrapupRequired == other.WrapupRequired ||
                    this.WrapupRequired != null &&
                    this.WrapupRequired.Equals(other.WrapupRequired)
                ) &&
                (
                    this.WrapupPrompt == other.WrapupPrompt ||
                    this.WrapupPrompt != null &&
                    this.WrapupPrompt.Equals(other.WrapupPrompt)
                ) &&
                (
                    this.MediaRoles == other.MediaRoles ||
                    this.MediaRoles != null &&
                    this.MediaRoles.SequenceEqual(other.MediaRoles)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
                ) &&
                (
                    this.Script == other.Script ||
                    this.Script != null &&
                    this.Script.Equals(other.Script)
                ) &&
                (
                    this.WrapupTimeoutMs == other.WrapupTimeoutMs ||
                    this.WrapupTimeoutMs != null &&
                    this.WrapupTimeoutMs.Equals(other.WrapupTimeoutMs)
                ) &&
                (
                    this.WrapupSkipped == other.WrapupSkipped ||
                    this.WrapupSkipped != null &&
                    this.WrapupSkipped.Equals(other.WrapupSkipped)
                ) &&
                (
                    this.AlertingTimeoutMs == other.AlertingTimeoutMs ||
                    this.AlertingTimeoutMs != null &&
                    this.AlertingTimeoutMs.Equals(other.AlertingTimeoutMs)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.ExternalContact == other.ExternalContact ||
                    this.ExternalContact != null &&
                    this.ExternalContact.Equals(other.ExternalContact)
                ) &&
                (
                    this.ExternalOrganization == other.ExternalOrganization ||
                    this.ExternalOrganization != null &&
                    this.ExternalOrganization.Equals(other.ExternalOrganization)
                ) &&
                (
                    this.Wrapup == other.Wrapup ||
                    this.Wrapup != null &&
                    this.Wrapup.Equals(other.Wrapup)
                ) &&
                (
                    this.Peer == other.Peer ||
                    this.Peer != null &&
                    this.Peer.Equals(other.Peer)
                ) &&
                (
                    this.FlaggedReason == other.FlaggedReason ||
                    this.FlaggedReason != null &&
                    this.FlaggedReason.Equals(other.FlaggedReason)
                ) &&
                (
                    this.JourneyContext == other.JourneyContext ||
                    this.JourneyContext != null &&
                    this.JourneyContext.Equals(other.JourneyContext)
                ) &&
                (
                    this.ConversationRoutingData == other.ConversationRoutingData ||
                    this.ConversationRoutingData != null &&
                    this.ConversationRoutingData.Equals(other.ConversationRoutingData)
                ) &&
                (
                    this.StartAcwTime == other.StartAcwTime ||
                    this.StartAcwTime != null &&
                    this.StartAcwTime.Equals(other.StartAcwTime)
                ) &&
                (
                    this.EndAcwTime == other.EndAcwTime ||
                    this.EndAcwTime != null &&
                    this.EndAcwTime.Equals(other.EndAcwTime)
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
                    this.Authenticated == other.Authenticated ||
                    this.Authenticated != null &&
                    this.Authenticated.Equals(other.Authenticated)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();

                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();

                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();

                if (this.StartHoldTime != null)
                    hash = hash * 59 + this.StartHoldTime.GetHashCode();

                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();

                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();

                if (this.WrapupRequired != null)
                    hash = hash * 59 + this.WrapupRequired.GetHashCode();

                if (this.WrapupPrompt != null)
                    hash = hash * 59 + this.WrapupPrompt.GetHashCode();

                if (this.MediaRoles != null)
                    hash = hash * 59 + this.MediaRoles.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();

                if (this.Script != null)
                    hash = hash * 59 + this.Script.GetHashCode();

                if (this.WrapupTimeoutMs != null)
                    hash = hash * 59 + this.WrapupTimeoutMs.GetHashCode();

                if (this.WrapupSkipped != null)
                    hash = hash * 59 + this.WrapupSkipped.GetHashCode();

                if (this.AlertingTimeoutMs != null)
                    hash = hash * 59 + this.AlertingTimeoutMs.GetHashCode();

                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();

                if (this.ExternalContact != null)
                    hash = hash * 59 + this.ExternalContact.GetHashCode();

                if (this.ExternalOrganization != null)
                    hash = hash * 59 + this.ExternalOrganization.GetHashCode();

                if (this.Wrapup != null)
                    hash = hash * 59 + this.Wrapup.GetHashCode();

                if (this.Peer != null)
                    hash = hash * 59 + this.Peer.GetHashCode();

                if (this.FlaggedReason != null)
                    hash = hash * 59 + this.FlaggedReason.GetHashCode();

                if (this.JourneyContext != null)
                    hash = hash * 59 + this.JourneyContext.GetHashCode();

                if (this.ConversationRoutingData != null)
                    hash = hash * 59 + this.ConversationRoutingData.GetHashCode();

                if (this.StartAcwTime != null)
                    hash = hash * 59 + this.StartAcwTime.GetHashCode();

                if (this.EndAcwTime != null)
                    hash = hash * 59 + this.EndAcwTime.GetHashCode();

                if (this.ToAddress != null)
                    hash = hash * 59 + this.ToAddress.GetHashCode();

                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();

                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.RecipientCountry != null)
                    hash = hash * 59 + this.RecipientCountry.GetHashCode();

                if (this.RecipientType != null)
                    hash = hash * 59 + this.RecipientType.GetHashCode();

                if (this.Authenticated != null)
                    hash = hash * 59 + this.Authenticated.GetHashCode();

                return hash;
            }
        }
    }

}
