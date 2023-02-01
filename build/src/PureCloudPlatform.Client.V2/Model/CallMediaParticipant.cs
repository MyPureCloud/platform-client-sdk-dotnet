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
    /// CallMediaParticipant
    /// </summary>
    [DataContract]
    public partial class CallMediaParticipant :  IEquatable<CallMediaParticipant>
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
        /// The state of the call recording.
        /// </summary>
        /// <value>The state of the call recording.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RecordingStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Paused for "paused"
            /// </summary>
            [EnumMember(Value = "paused")]
            Paused
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
        /// The state of the call recording.
        /// </summary>
        /// <value>The state of the call recording.</value>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public RecordingStateEnum? RecordingState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallMediaParticipant" /> class.
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
        /// <param name="Muted">Value is true when the call is muted..</param>
        /// <param name="Confined">Value is true when the call is confined..</param>
        /// <param name="Recording">Value is true when the call is being recorded..</param>
        /// <param name="RecordingState">The state of the call recording..</param>
        /// <param name="Group">The group involved in the group ring call..</param>
        /// <param name="Ani">The call ANI..</param>
        /// <param name="Dnis">The call DNIS..</param>
        /// <param name="DocumentId">The ID of the Content Management document if the call is a fax..</param>
        /// <param name="FaxStatus">Extra fax information if the call is a fax..</param>
        /// <param name="MonitoredParticipantId">The ID of the participant being monitored when performing a call monitor..</param>
        /// <param name="CoachedParticipantId">The ID of the participant being coached when performing a call coach..</param>
        /// <param name="BargedParticipantId">If this participant barged in a participant's call, then this will be the id of the targeted participant..</param>
        /// <param name="ConsultParticipantId">The ID of the consult transfer target participant when performing a consult transfer..</param>
        /// <param name="UuiData">User-to-User information which maps to a SIP header field defined in RFC7433. UUI data is used in the Public Switched Telephone Network (PSTN) for use cases described in RFC6567..</param>
        /// <param name="BargedTime">The timestamp when this participant was connected to the barge conference in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public CallMediaParticipant(string Id = null, string Name = null, string Address = null, DateTime? StartTime = null, DateTime? ConnectedTime = null, DateTime? EndTime = null, DateTime? StartHoldTime = null, string Purpose = null, StateEnum? State = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, bool? Held = null, bool? WrapupRequired = null, string WrapupPrompt = null, List<string> MediaRoles = null, DomainEntityRef User = null, DomainEntityRef Queue = null, DomainEntityRef Team = null, Dictionary<string, string> Attributes = null, ErrorInfo ErrorInfo = null, DomainEntityRef Script = null, int? WrapupTimeoutMs = null, bool? WrapupSkipped = null, int? AlertingTimeoutMs = null, string Provider = null, DomainEntityRef ExternalContact = null, DomainEntityRef ExternalOrganization = null, Wrapup Wrapup = null, string Peer = null, FlaggedReasonEnum? FlaggedReason = null, JourneyContext JourneyContext = null, ConversationRoutingData ConversationRoutingData = null, DateTime? StartAcwTime = null, DateTime? EndAcwTime = null, bool? Muted = null, bool? Confined = null, bool? Recording = null, RecordingStateEnum? RecordingState = null, DomainEntityRef Group = null, string Ani = null, string Dnis = null, string DocumentId = null, FaxStatus FaxStatus = null, string MonitoredParticipantId = null, string CoachedParticipantId = null, string BargedParticipantId = null, string ConsultParticipantId = null, string UuiData = null, DateTime? BargedTime = null)
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
            this.Muted = Muted;
            this.Confined = Confined;
            this.Recording = Recording;
            this.RecordingState = RecordingState;
            this.Group = Group;
            this.Ani = Ani;
            this.Dnis = Dnis;
            this.DocumentId = DocumentId;
            this.FaxStatus = FaxStatus;
            this.MonitoredParticipantId = MonitoredParticipantId;
            this.CoachedParticipantId = CoachedParticipantId;
            this.BargedParticipantId = BargedParticipantId;
            this.ConsultParticipantId = ConsultParticipantId;
            this.UuiData = UuiData;
            this.BargedTime = BargedTime;
            
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
        /// Value is true when the call is muted.
        /// </summary>
        /// <value>Value is true when the call is muted.</value>
        [DataMember(Name="muted", EmitDefaultValue=false)]
        public bool? Muted { get; set; }



        /// <summary>
        /// Value is true when the call is confined.
        /// </summary>
        /// <value>Value is true when the call is confined.</value>
        [DataMember(Name="confined", EmitDefaultValue=false)]
        public bool? Confined { get; set; }



        /// <summary>
        /// Value is true when the call is being recorded.
        /// </summary>
        /// <value>Value is true when the call is being recorded.</value>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public bool? Recording { get; set; }





        /// <summary>
        /// The group involved in the group ring call.
        /// </summary>
        /// <value>The group involved in the group ring call.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public DomainEntityRef Group { get; set; }



        /// <summary>
        /// The call ANI.
        /// </summary>
        /// <value>The call ANI.</value>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }



        /// <summary>
        /// The call DNIS.
        /// </summary>
        /// <value>The call DNIS.</value>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }



        /// <summary>
        /// The ID of the Content Management document if the call is a fax.
        /// </summary>
        /// <value>The ID of the Content Management document if the call is a fax.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }



        /// <summary>
        /// Extra fax information if the call is a fax.
        /// </summary>
        /// <value>Extra fax information if the call is a fax.</value>
        [DataMember(Name="faxStatus", EmitDefaultValue=false)]
        public FaxStatus FaxStatus { get; set; }



        /// <summary>
        /// The ID of the participant being monitored when performing a call monitor.
        /// </summary>
        /// <value>The ID of the participant being monitored when performing a call monitor.</value>
        [DataMember(Name="monitoredParticipantId", EmitDefaultValue=false)]
        public string MonitoredParticipantId { get; set; }



        /// <summary>
        /// The ID of the participant being coached when performing a call coach.
        /// </summary>
        /// <value>The ID of the participant being coached when performing a call coach.</value>
        [DataMember(Name="coachedParticipantId", EmitDefaultValue=false)]
        public string CoachedParticipantId { get; set; }



        /// <summary>
        /// If this participant barged in a participant's call, then this will be the id of the targeted participant.
        /// </summary>
        /// <value>If this participant barged in a participant's call, then this will be the id of the targeted participant.</value>
        [DataMember(Name="bargedParticipantId", EmitDefaultValue=false)]
        public string BargedParticipantId { get; set; }



        /// <summary>
        /// The ID of the consult transfer target participant when performing a consult transfer.
        /// </summary>
        /// <value>The ID of the consult transfer target participant when performing a consult transfer.</value>
        [DataMember(Name="consultParticipantId", EmitDefaultValue=false)]
        public string ConsultParticipantId { get; set; }



        /// <summary>
        /// User-to-User information which maps to a SIP header field defined in RFC7433. UUI data is used in the Public Switched Telephone Network (PSTN) for use cases described in RFC6567.
        /// </summary>
        /// <value>User-to-User information which maps to a SIP header field defined in RFC7433. UUI data is used in the Public Switched Telephone Network (PSTN) for use cases described in RFC6567.</value>
        [DataMember(Name="uuiData", EmitDefaultValue=false)]
        public string UuiData { get; set; }



        /// <summary>
        /// The timestamp when this participant was connected to the barge conference in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when this participant was connected to the barge conference in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="bargedTime", EmitDefaultValue=false)]
        public DateTime? BargedTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallMediaParticipant {\n");

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
            sb.Append("  Muted: ").Append(Muted).Append("\n");
            sb.Append("  Confined: ").Append(Confined).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  FaxStatus: ").Append(FaxStatus).Append("\n");
            sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
            sb.Append("  CoachedParticipantId: ").Append(CoachedParticipantId).Append("\n");
            sb.Append("  BargedParticipantId: ").Append(BargedParticipantId).Append("\n");
            sb.Append("  ConsultParticipantId: ").Append(ConsultParticipantId).Append("\n");
            sb.Append("  UuiData: ").Append(UuiData).Append("\n");
            sb.Append("  BargedTime: ").Append(BargedTime).Append("\n");
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
            return this.Equals(obj as CallMediaParticipant);
        }

        /// <summary>
        /// Returns true if CallMediaParticipant instances are equal
        /// </summary>
        /// <param name="other">Instance of CallMediaParticipant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallMediaParticipant other)
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
                    this.Muted == other.Muted ||
                    this.Muted != null &&
                    this.Muted.Equals(other.Muted)
                ) &&
                (
                    this.Confined == other.Confined ||
                    this.Confined != null &&
                    this.Confined.Equals(other.Confined)
                ) &&
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
                ) &&
                (
                    this.RecordingState == other.RecordingState ||
                    this.RecordingState != null &&
                    this.RecordingState.Equals(other.RecordingState)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
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
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) &&
                (
                    this.FaxStatus == other.FaxStatus ||
                    this.FaxStatus != null &&
                    this.FaxStatus.Equals(other.FaxStatus)
                ) &&
                (
                    this.MonitoredParticipantId == other.MonitoredParticipantId ||
                    this.MonitoredParticipantId != null &&
                    this.MonitoredParticipantId.Equals(other.MonitoredParticipantId)
                ) &&
                (
                    this.CoachedParticipantId == other.CoachedParticipantId ||
                    this.CoachedParticipantId != null &&
                    this.CoachedParticipantId.Equals(other.CoachedParticipantId)
                ) &&
                (
                    this.BargedParticipantId == other.BargedParticipantId ||
                    this.BargedParticipantId != null &&
                    this.BargedParticipantId.Equals(other.BargedParticipantId)
                ) &&
                (
                    this.ConsultParticipantId == other.ConsultParticipantId ||
                    this.ConsultParticipantId != null &&
                    this.ConsultParticipantId.Equals(other.ConsultParticipantId)
                ) &&
                (
                    this.UuiData == other.UuiData ||
                    this.UuiData != null &&
                    this.UuiData.Equals(other.UuiData)
                ) &&
                (
                    this.BargedTime == other.BargedTime ||
                    this.BargedTime != null &&
                    this.BargedTime.Equals(other.BargedTime)
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

                if (this.Muted != null)
                    hash = hash * 59 + this.Muted.GetHashCode();

                if (this.Confined != null)
                    hash = hash * 59 + this.Confined.GetHashCode();

                if (this.Recording != null)
                    hash = hash * 59 + this.Recording.GetHashCode();

                if (this.RecordingState != null)
                    hash = hash * 59 + this.RecordingState.GetHashCode();

                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();

                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();

                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();

                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();

                if (this.FaxStatus != null)
                    hash = hash * 59 + this.FaxStatus.GetHashCode();

                if (this.MonitoredParticipantId != null)
                    hash = hash * 59 + this.MonitoredParticipantId.GetHashCode();

                if (this.CoachedParticipantId != null)
                    hash = hash * 59 + this.CoachedParticipantId.GetHashCode();

                if (this.BargedParticipantId != null)
                    hash = hash * 59 + this.BargedParticipantId.GetHashCode();

                if (this.ConsultParticipantId != null)
                    hash = hash * 59 + this.ConsultParticipantId.GetHashCode();

                if (this.UuiData != null)
                    hash = hash * 59 + this.UuiData.GetHashCode();

                if (this.BargedTime != null)
                    hash = hash * 59 + this.BargedTime.GetHashCode();

                return hash;
            }
        }
    }

}
