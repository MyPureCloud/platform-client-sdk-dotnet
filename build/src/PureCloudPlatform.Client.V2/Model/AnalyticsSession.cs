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
    /// AnalyticsSession
    /// </summary>
    [DataContract]
    public partial class AnalyticsSession :  IEquatable<AnalyticsSession>
    {
        /// <summary>
        /// The email or SMS delivery status
        /// </summary>
        /// <value>The email or SMS delivery status</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DeliveryStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Deliveryfailed for "DeliveryFailed"
            /// </summary>
            [EnumMember(Value = "DeliveryFailed")]
            Deliveryfailed,
            
            /// <summary>
            /// Enum Deliverysuccess for "DeliverySuccess"
            /// </summary>
            [EnumMember(Value = "DeliverySuccess")]
            Deliverysuccess,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Queued for "Queued"
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued,
            
            /// <summary>
            /// Enum Read for "Read"
            /// </summary>
            [EnumMember(Value = "Read")]
            Read,
            
            /// <summary>
            /// Enum Received for "Received"
            /// </summary>
            [EnumMember(Value = "Received")]
            Received,
            
            /// <summary>
            /// Enum Sent for "Sent"
            /// </summary>
            [EnumMember(Value = "Sent")]
            Sent
        }
        /// <summary>
        /// The direction of the communication
        /// </summary>
        /// <value>The direction of the communication</value>
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
        /// The session media type
        /// </summary>
        /// <value>The session media type</value>
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
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Chat for "chat"
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat,
            
            /// <summary>
            /// Enum Cobrowse for "cobrowse"
            /// </summary>
            [EnumMember(Value = "cobrowse")]
            Cobrowse,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message,
            
            /// <summary>
            /// Enum Screenshare for "screenshare"
            /// </summary>
            [EnumMember(Value = "screenshare")]
            Screenshare,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Video for "video"
            /// </summary>
            [EnumMember(Value = "video")]
            Video,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice
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
            /// Enum Bullseye for "Bullseye"
            /// </summary>
            [EnumMember(Value = "Bullseye")]
            Bullseye,
            
            /// <summary>
            /// Enum Conditional for "Conditional"
            /// </summary>
            [EnumMember(Value = "Conditional")]
            Conditional,
            
            /// <summary>
            /// Enum Last for "Last"
            /// </summary>
            [EnumMember(Value = "Last")]
            Last,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Predictive for "Predictive"
            /// </summary>
            [EnumMember(Value = "Predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Preferred for "Preferred"
            /// </summary>
            [EnumMember(Value = "Preferred")]
            Preferred,
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard
        }
        /// <summary>
        /// Complete routing method
        /// </summary>
        /// <value>Complete routing method</value>
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
            /// Enum Bullseye for "Bullseye"
            /// </summary>
            [EnumMember(Value = "Bullseye")]
            Bullseye,
            
            /// <summary>
            /// Enum Conditional for "Conditional"
            /// </summary>
            [EnumMember(Value = "Conditional")]
            Conditional,
            
            /// <summary>
            /// Enum Last for "Last"
            /// </summary>
            [EnumMember(Value = "Last")]
            Last,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Predictive for "Predictive"
            /// </summary>
            [EnumMember(Value = "Predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Preferred for "Preferred"
            /// </summary>
            [EnumMember(Value = "Preferred")]
            Preferred,
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard
        }
        /// <summary>
        /// The email or SMS delivery status
        /// </summary>
        /// <value>The email or SMS delivery status</value>
        [DataMember(Name="deliveryStatus", EmitDefaultValue=false)]
        public DeliveryStatusEnum? DeliveryStatus { get; set; }
        /// <summary>
        /// The direction of the communication
        /// </summary>
        /// <value>The direction of the communication</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// The session media type
        /// </summary>
        /// <value>The session media type</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Complete routing method
        /// </summary>
        /// <value>Complete routing method</value>
        [DataMember(Name="usedRouting", EmitDefaultValue=false)]
        public UsedRoutingEnum? UsedRouting { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsSession" /> class.
        /// </summary>
        /// <param name="ActiveSkillIds">ID(s) of Skill(s) that are active on the conversation.</param>
        /// <param name="AcwSkipped">Marker for an agent that skipped after call work.</param>
        /// <param name="AddressFrom">The address that initiated an action.</param>
        /// <param name="AddressOther">The email address for the participant on the other side of the email conversation.</param>
        /// <param name="AddressSelf">The email address for the participant on this side of the email conversation.</param>
        /// <param name="AddressTo">The address receiving an action.</param>
        /// <param name="AgentAssistantId">Unique identifier of the active virtual agent assistant.</param>
        /// <param name="AgentBullseyeRing">Bullseye ring of the targeted agent.</param>
        /// <param name="AgentOwned">Flag indicating an agent-owned callback.</param>
        /// <param name="Ani">Automatic Number Identification (caller's number).</param>
        /// <param name="AssignerId">ID of the user that manually assigned a conversation.</param>
        /// <param name="Authenticated">Flag that indicates that the identity of the customer has been asserted as verified by the provider..</param>
        /// <param name="BargedParticipantId">The participantId being barged in on (if someone (e.g. an agent) is being barged in on, this would correspond to one of the other participantIds present in the conversation).</param>
        /// <param name="Bcc">Blind carbon copy email address(es).</param>
        /// <param name="CallbackNumbers">Callback phone number(s).</param>
        /// <param name="CallbackScheduledTime">Scheduled callback date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CallbackUserName">The name of the user requesting a call back.</param>
        /// <param name="Cc">Carbon copy email address(es).</param>
        /// <param name="CoachedParticipantId">The participantId being coached (if someone (e.g. an agent) is being coached, this would correspond to one of the other participantIds present in the conversation).</param>
        /// <param name="CobrowseRole">Describes side of the cobrowse (sharer or viewer).</param>
        /// <param name="CobrowseRoomId">A unique identifier for a PureCloud cobrowse room.</param>
        /// <param name="DeliveryStatus">The email or SMS delivery status.</param>
        /// <param name="DeliveryStatusChangeDate">Date and time of the most recent delivery status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DestinationAddresses">Destination address(es) of transfers or consults.</param>
        /// <param name="Direction">The direction of the communication.</param>
        /// <param name="DispositionAnalyzer">(Dialer) Analyzer (for example speech.person).</param>
        /// <param name="DispositionName">(Dialer) Result of the analysis (for example disposition.classification.callable.machine).</param>
        /// <param name="Dnis">Dialed number identification service (number dialed by the calling party).</param>
        /// <param name="EdgeId">Unique identifier of the edge device.</param>
        /// <param name="EligibleAgentCounts">Number of eligible agents for each predictive routing attempt.</param>
        /// <param name="ExtendedDeliveryStatus">Extended delivery status.</param>
        /// <param name="FlowInType">Type of flow in that occurred when entering ACD..</param>
        /// <param name="FlowOutType">Type of flow out that occurred when emitting tFlowOut..</param>
        /// <param name="JourneyActionId">Identifier of the journey action..</param>
        /// <param name="JourneyActionMapId">Identifier of the journey action map that triggered the action..</param>
        /// <param name="JourneyActionMapVersion">Version of the journey action map that triggered the action..</param>
        /// <param name="JourneyCustomerId">Primary identifier of the journey customer in the source where the activities originate from..</param>
        /// <param name="JourneyCustomerIdType">Type of primary identifier of the journey customer (e.g. cookie)..</param>
        /// <param name="JourneyCustomerSessionId">Unique identifier of the journey session..</param>
        /// <param name="JourneyCustomerSessionIdType">Type or category of journey sessions (e.g. web, ticket, delivery, atm)..</param>
        /// <param name="MediaBridgeId">Media bridge ID for the conference session consistent across all participants.</param>
        /// <param name="MediaCount">Count of any media (images, files, etc) included in this session.</param>
        /// <param name="MediaType">The session media type.</param>
        /// <param name="MessageType">Message type for messaging services. E.g.: sms, facebook, twitter, line.</param>
        /// <param name="MonitoredParticipantId">The participantId being monitored (if someone (e.g. an agent) is being monitored, this would correspond to one of the other participantIds present in the conversation).</param>
        /// <param name="OutboundCampaignId">(Dialer) Unique identifier of the outbound campaign.</param>
        /// <param name="OutboundContactId">(Dialer) Unique identifier of the contact.</param>
        /// <param name="OutboundContactListId">(Dialer) Unique identifier of the contact list that this contact belongs to.</param>
        /// <param name="PeerId">This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session..</param>
        /// <param name="ProtocolCallId">The original voice protocol call ID, e.g. a SIP call ID.</param>
        /// <param name="Provider">The source provider for the communication..</param>
        /// <param name="Recording">Flag determining if an audio recording was started or not.</param>
        /// <param name="Remote">Name, phone number, or email address of the remote party..</param>
        /// <param name="RemoteNameDisplayable">Unique identifier for the remote party.</param>
        /// <param name="RemovedSkillIds">ID(s) of Skill(s) that have been removed by bullseye routing.</param>
        /// <param name="RequestedRoutings">Routing type(s) for requested/attempted routing methods..</param>
        /// <param name="RoomId">Unique identifier for the room.</param>
        /// <param name="RoutingRing">Routing ring for bullseye or preferred agent routing.</param>
        /// <param name="ScreenShareAddressSelf">Direct ScreenShare address.</param>
        /// <param name="ScreenShareRoomId">A unique identifier for a PureCloud ScreenShare room.</param>
        /// <param name="ScriptId">A unique identifier for a script.</param>
        /// <param name="SelectedAgentId">Selected agent ID.</param>
        /// <param name="SelectedAgentRank">Selected agent GPR rank.</param>
        /// <param name="SessionDnis">Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred.</param>
        /// <param name="SessionId">The unique identifier of this session.</param>
        /// <param name="SharingScreen">Flag determining if screenShare is started or not (true/false).</param>
        /// <param name="SkipEnabled">(Dialer) Whether the agent can skip the dialer contact.</param>
        /// <param name="TimeoutSeconds">The number of seconds before PureCloud begins the call for a call back (0 disables automatic calling).</param>
        /// <param name="UsedRouting">Complete routing method.</param>
        /// <param name="VideoAddressSelf">Direct Video address.</param>
        /// <param name="VideoRoomId">A unique identifier for a PureCloud video room.</param>
        /// <param name="WaitingInteractionCounts">Number of waiting interactions for each predictive routing attempt.</param>
        /// <param name="ProposedAgents">Proposed agents.</param>
        /// <param name="AgentGroups">Conditional group routing agent groups.</param>
        /// <param name="MediaEndpointStats">MediaEndpointStats associated with this session.</param>
        /// <param name="Flow">IVR flow execution associated with this session.</param>
        /// <param name="Metrics">List of metrics for this session.</param>
        /// <param name="Segments">List of segments for this session.</param>
        public AnalyticsSession(List<string> ActiveSkillIds = null, bool? AcwSkipped = null, string AddressFrom = null, string AddressOther = null, string AddressSelf = null, string AddressTo = null, string AgentAssistantId = null, int? AgentBullseyeRing = null, bool? AgentOwned = null, string Ani = null, string AssignerId = null, bool? Authenticated = null, string BargedParticipantId = null, List<string> Bcc = null, List<string> CallbackNumbers = null, DateTime? CallbackScheduledTime = null, string CallbackUserName = null, List<string> Cc = null, string CoachedParticipantId = null, string CobrowseRole = null, string CobrowseRoomId = null, DeliveryStatusEnum? DeliveryStatus = null, DateTime? DeliveryStatusChangeDate = null, List<string> DestinationAddresses = null, DirectionEnum? Direction = null, string DispositionAnalyzer = null, string DispositionName = null, string Dnis = null, string EdgeId = null, List<int?> EligibleAgentCounts = null, string ExtendedDeliveryStatus = null, string FlowInType = null, string FlowOutType = null, string JourneyActionId = null, string JourneyActionMapId = null, int? JourneyActionMapVersion = null, string JourneyCustomerId = null, string JourneyCustomerIdType = null, string JourneyCustomerSessionId = null, string JourneyCustomerSessionIdType = null, string MediaBridgeId = null, int? MediaCount = null, MediaTypeEnum? MediaType = null, string MessageType = null, string MonitoredParticipantId = null, string OutboundCampaignId = null, string OutboundContactId = null, string OutboundContactListId = null, string PeerId = null, string ProtocolCallId = null, string Provider = null, bool? Recording = null, string Remote = null, string RemoteNameDisplayable = null, List<string> RemovedSkillIds = null, List<RequestedRoutingsEnum> RequestedRoutings = null, string RoomId = null, int? RoutingRing = null, string ScreenShareAddressSelf = null, string ScreenShareRoomId = null, string ScriptId = null, string SelectedAgentId = null, int? SelectedAgentRank = null, string SessionDnis = null, string SessionId = null, bool? SharingScreen = null, bool? SkipEnabled = null, int? TimeoutSeconds = null, UsedRoutingEnum? UsedRouting = null, string VideoAddressSelf = null, string VideoRoomId = null, List<int?> WaitingInteractionCounts = null, List<AnalyticsProposedAgent> ProposedAgents = null, List<AnalyticsAgentGroup> AgentGroups = null, List<AnalyticsMediaEndpointStat> MediaEndpointStats = null, AnalyticsFlow Flow = null, List<AnalyticsSessionMetric> Metrics = null, List<AnalyticsConversationSegment> Segments = null)
        {
            this.ActiveSkillIds = ActiveSkillIds;
            this.AcwSkipped = AcwSkipped;
            this.AddressFrom = AddressFrom;
            this.AddressOther = AddressOther;
            this.AddressSelf = AddressSelf;
            this.AddressTo = AddressTo;
            this.AgentAssistantId = AgentAssistantId;
            this.AgentBullseyeRing = AgentBullseyeRing;
            this.AgentOwned = AgentOwned;
            this.Ani = Ani;
            this.AssignerId = AssignerId;
            this.Authenticated = Authenticated;
            this.BargedParticipantId = BargedParticipantId;
            this.Bcc = Bcc;
            this.CallbackNumbers = CallbackNumbers;
            this.CallbackScheduledTime = CallbackScheduledTime;
            this.CallbackUserName = CallbackUserName;
            this.Cc = Cc;
            this.CoachedParticipantId = CoachedParticipantId;
            this.CobrowseRole = CobrowseRole;
            this.CobrowseRoomId = CobrowseRoomId;
            this.DeliveryStatus = DeliveryStatus;
            this.DeliveryStatusChangeDate = DeliveryStatusChangeDate;
            this.DestinationAddresses = DestinationAddresses;
            this.Direction = Direction;
            this.DispositionAnalyzer = DispositionAnalyzer;
            this.DispositionName = DispositionName;
            this.Dnis = Dnis;
            this.EdgeId = EdgeId;
            this.EligibleAgentCounts = EligibleAgentCounts;
            this.ExtendedDeliveryStatus = ExtendedDeliveryStatus;
            this.FlowInType = FlowInType;
            this.FlowOutType = FlowOutType;
            this.JourneyActionId = JourneyActionId;
            this.JourneyActionMapId = JourneyActionMapId;
            this.JourneyActionMapVersion = JourneyActionMapVersion;
            this.JourneyCustomerId = JourneyCustomerId;
            this.JourneyCustomerIdType = JourneyCustomerIdType;
            this.JourneyCustomerSessionId = JourneyCustomerSessionId;
            this.JourneyCustomerSessionIdType = JourneyCustomerSessionIdType;
            this.MediaBridgeId = MediaBridgeId;
            this.MediaCount = MediaCount;
            this.MediaType = MediaType;
            this.MessageType = MessageType;
            this.MonitoredParticipantId = MonitoredParticipantId;
            this.OutboundCampaignId = OutboundCampaignId;
            this.OutboundContactId = OutboundContactId;
            this.OutboundContactListId = OutboundContactListId;
            this.PeerId = PeerId;
            this.ProtocolCallId = ProtocolCallId;
            this.Provider = Provider;
            this.Recording = Recording;
            this.Remote = Remote;
            this.RemoteNameDisplayable = RemoteNameDisplayable;
            this.RemovedSkillIds = RemovedSkillIds;
            this.RequestedRoutings = RequestedRoutings;
            this.RoomId = RoomId;
            this.RoutingRing = RoutingRing;
            this.ScreenShareAddressSelf = ScreenShareAddressSelf;
            this.ScreenShareRoomId = ScreenShareRoomId;
            this.ScriptId = ScriptId;
            this.SelectedAgentId = SelectedAgentId;
            this.SelectedAgentRank = SelectedAgentRank;
            this.SessionDnis = SessionDnis;
            this.SessionId = SessionId;
            this.SharingScreen = SharingScreen;
            this.SkipEnabled = SkipEnabled;
            this.TimeoutSeconds = TimeoutSeconds;
            this.UsedRouting = UsedRouting;
            this.VideoAddressSelf = VideoAddressSelf;
            this.VideoRoomId = VideoRoomId;
            this.WaitingInteractionCounts = WaitingInteractionCounts;
            this.ProposedAgents = ProposedAgents;
            this.AgentGroups = AgentGroups;
            this.MediaEndpointStats = MediaEndpointStats;
            this.Flow = Flow;
            this.Metrics = Metrics;
            this.Segments = Segments;
            
        }
        


        /// <summary>
        /// ID(s) of Skill(s) that are active on the conversation
        /// </summary>
        /// <value>ID(s) of Skill(s) that are active on the conversation</value>
        [DataMember(Name="activeSkillIds", EmitDefaultValue=false)]
        public List<string> ActiveSkillIds { get; set; }



        /// <summary>
        /// Marker for an agent that skipped after call work
        /// </summary>
        /// <value>Marker for an agent that skipped after call work</value>
        [DataMember(Name="acwSkipped", EmitDefaultValue=false)]
        public bool? AcwSkipped { get; set; }



        /// <summary>
        /// The address that initiated an action
        /// </summary>
        /// <value>The address that initiated an action</value>
        [DataMember(Name="addressFrom", EmitDefaultValue=false)]
        public string AddressFrom { get; set; }



        /// <summary>
        /// The email address for the participant on the other side of the email conversation
        /// </summary>
        /// <value>The email address for the participant on the other side of the email conversation</value>
        [DataMember(Name="addressOther", EmitDefaultValue=false)]
        public string AddressOther { get; set; }



        /// <summary>
        /// The email address for the participant on this side of the email conversation
        /// </summary>
        /// <value>The email address for the participant on this side of the email conversation</value>
        [DataMember(Name="addressSelf", EmitDefaultValue=false)]
        public string AddressSelf { get; set; }



        /// <summary>
        /// The address receiving an action
        /// </summary>
        /// <value>The address receiving an action</value>
        [DataMember(Name="addressTo", EmitDefaultValue=false)]
        public string AddressTo { get; set; }



        /// <summary>
        /// Unique identifier of the active virtual agent assistant
        /// </summary>
        /// <value>Unique identifier of the active virtual agent assistant</value>
        [DataMember(Name="agentAssistantId", EmitDefaultValue=false)]
        public string AgentAssistantId { get; set; }



        /// <summary>
        /// Bullseye ring of the targeted agent
        /// </summary>
        /// <value>Bullseye ring of the targeted agent</value>
        [DataMember(Name="agentBullseyeRing", EmitDefaultValue=false)]
        public int? AgentBullseyeRing { get; set; }



        /// <summary>
        /// Flag indicating an agent-owned callback
        /// </summary>
        /// <value>Flag indicating an agent-owned callback</value>
        [DataMember(Name="agentOwned", EmitDefaultValue=false)]
        public bool? AgentOwned { get; set; }



        /// <summary>
        /// Automatic Number Identification (caller's number)
        /// </summary>
        /// <value>Automatic Number Identification (caller's number)</value>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }



        /// <summary>
        /// ID of the user that manually assigned a conversation
        /// </summary>
        /// <value>ID of the user that manually assigned a conversation</value>
        [DataMember(Name="assignerId", EmitDefaultValue=false)]
        public string AssignerId { get; set; }



        /// <summary>
        /// Flag that indicates that the identity of the customer has been asserted as verified by the provider.
        /// </summary>
        /// <value>Flag that indicates that the identity of the customer has been asserted as verified by the provider.</value>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }



        /// <summary>
        /// The participantId being barged in on (if someone (e.g. an agent) is being barged in on, this would correspond to one of the other participantIds present in the conversation)
        /// </summary>
        /// <value>The participantId being barged in on (if someone (e.g. an agent) is being barged in on, this would correspond to one of the other participantIds present in the conversation)</value>
        [DataMember(Name="bargedParticipantId", EmitDefaultValue=false)]
        public string BargedParticipantId { get; set; }



        /// <summary>
        /// Blind carbon copy email address(es)
        /// </summary>
        /// <value>Blind carbon copy email address(es)</value>
        [DataMember(Name="bcc", EmitDefaultValue=false)]
        public List<string> Bcc { get; set; }



        /// <summary>
        /// Callback phone number(s)
        /// </summary>
        /// <value>Callback phone number(s)</value>
        [DataMember(Name="callbackNumbers", EmitDefaultValue=false)]
        public List<string> CallbackNumbers { get; set; }



        /// <summary>
        /// Scheduled callback date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Scheduled callback date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="callbackScheduledTime", EmitDefaultValue=false)]
        public DateTime? CallbackScheduledTime { get; set; }



        /// <summary>
        /// The name of the user requesting a call back
        /// </summary>
        /// <value>The name of the user requesting a call back</value>
        [DataMember(Name="callbackUserName", EmitDefaultValue=false)]
        public string CallbackUserName { get; set; }



        /// <summary>
        /// Carbon copy email address(es)
        /// </summary>
        /// <value>Carbon copy email address(es)</value>
        [DataMember(Name="cc", EmitDefaultValue=false)]
        public List<string> Cc { get; set; }



        /// <summary>
        /// The participantId being coached (if someone (e.g. an agent) is being coached, this would correspond to one of the other participantIds present in the conversation)
        /// </summary>
        /// <value>The participantId being coached (if someone (e.g. an agent) is being coached, this would correspond to one of the other participantIds present in the conversation)</value>
        [DataMember(Name="coachedParticipantId", EmitDefaultValue=false)]
        public string CoachedParticipantId { get; set; }



        /// <summary>
        /// Describes side of the cobrowse (sharer or viewer)
        /// </summary>
        /// <value>Describes side of the cobrowse (sharer or viewer)</value>
        [DataMember(Name="cobrowseRole", EmitDefaultValue=false)]
        public string CobrowseRole { get; set; }



        /// <summary>
        /// A unique identifier for a PureCloud cobrowse room
        /// </summary>
        /// <value>A unique identifier for a PureCloud cobrowse room</value>
        [DataMember(Name="cobrowseRoomId", EmitDefaultValue=false)]
        public string CobrowseRoomId { get; set; }





        /// <summary>
        /// Date and time of the most recent delivery status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date and time of the most recent delivery status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="deliveryStatusChangeDate", EmitDefaultValue=false)]
        public DateTime? DeliveryStatusChangeDate { get; set; }



        /// <summary>
        /// Destination address(es) of transfers or consults
        /// </summary>
        /// <value>Destination address(es) of transfers or consults</value>
        [DataMember(Name="destinationAddresses", EmitDefaultValue=false)]
        public List<string> DestinationAddresses { get; set; }





        /// <summary>
        /// (Dialer) Analyzer (for example speech.person)
        /// </summary>
        /// <value>(Dialer) Analyzer (for example speech.person)</value>
        [DataMember(Name="dispositionAnalyzer", EmitDefaultValue=false)]
        public string DispositionAnalyzer { get; set; }



        /// <summary>
        /// (Dialer) Result of the analysis (for example disposition.classification.callable.machine)
        /// </summary>
        /// <value>(Dialer) Result of the analysis (for example disposition.classification.callable.machine)</value>
        [DataMember(Name="dispositionName", EmitDefaultValue=false)]
        public string DispositionName { get; set; }



        /// <summary>
        /// Dialed number identification service (number dialed by the calling party)
        /// </summary>
        /// <value>Dialed number identification service (number dialed by the calling party)</value>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }



        /// <summary>
        /// Unique identifier of the edge device
        /// </summary>
        /// <value>Unique identifier of the edge device</value>
        [DataMember(Name="edgeId", EmitDefaultValue=false)]
        public string EdgeId { get; set; }



        /// <summary>
        /// Number of eligible agents for each predictive routing attempt
        /// </summary>
        /// <value>Number of eligible agents for each predictive routing attempt</value>
        [DataMember(Name="eligibleAgentCounts", EmitDefaultValue=false)]
        public List<int?> EligibleAgentCounts { get; set; }



        /// <summary>
        /// Extended delivery status
        /// </summary>
        /// <value>Extended delivery status</value>
        [DataMember(Name="extendedDeliveryStatus", EmitDefaultValue=false)]
        public string ExtendedDeliveryStatus { get; set; }



        /// <summary>
        /// Type of flow in that occurred when entering ACD.
        /// </summary>
        /// <value>Type of flow in that occurred when entering ACD.</value>
        [DataMember(Name="flowInType", EmitDefaultValue=false)]
        public string FlowInType { get; set; }



        /// <summary>
        /// Type of flow out that occurred when emitting tFlowOut.
        /// </summary>
        /// <value>Type of flow out that occurred when emitting tFlowOut.</value>
        [DataMember(Name="flowOutType", EmitDefaultValue=false)]
        public string FlowOutType { get; set; }



        /// <summary>
        /// Identifier of the journey action.
        /// </summary>
        /// <value>Identifier of the journey action.</value>
        [DataMember(Name="journeyActionId", EmitDefaultValue=false)]
        public string JourneyActionId { get; set; }



        /// <summary>
        /// Identifier of the journey action map that triggered the action.
        /// </summary>
        /// <value>Identifier of the journey action map that triggered the action.</value>
        [DataMember(Name="journeyActionMapId", EmitDefaultValue=false)]
        public string JourneyActionMapId { get; set; }



        /// <summary>
        /// Version of the journey action map that triggered the action.
        /// </summary>
        /// <value>Version of the journey action map that triggered the action.</value>
        [DataMember(Name="journeyActionMapVersion", EmitDefaultValue=false)]
        public int? JourneyActionMapVersion { get; set; }



        /// <summary>
        /// Primary identifier of the journey customer in the source where the activities originate from.
        /// </summary>
        /// <value>Primary identifier of the journey customer in the source where the activities originate from.</value>
        [DataMember(Name="journeyCustomerId", EmitDefaultValue=false)]
        public string JourneyCustomerId { get; set; }



        /// <summary>
        /// Type of primary identifier of the journey customer (e.g. cookie).
        /// </summary>
        /// <value>Type of primary identifier of the journey customer (e.g. cookie).</value>
        [DataMember(Name="journeyCustomerIdType", EmitDefaultValue=false)]
        public string JourneyCustomerIdType { get; set; }



        /// <summary>
        /// Unique identifier of the journey session.
        /// </summary>
        /// <value>Unique identifier of the journey session.</value>
        [DataMember(Name="journeyCustomerSessionId", EmitDefaultValue=false)]
        public string JourneyCustomerSessionId { get; set; }



        /// <summary>
        /// Type or category of journey sessions (e.g. web, ticket, delivery, atm).
        /// </summary>
        /// <value>Type or category of journey sessions (e.g. web, ticket, delivery, atm).</value>
        [DataMember(Name="journeyCustomerSessionIdType", EmitDefaultValue=false)]
        public string JourneyCustomerSessionIdType { get; set; }



        /// <summary>
        /// Media bridge ID for the conference session consistent across all participants
        /// </summary>
        /// <value>Media bridge ID for the conference session consistent across all participants</value>
        [DataMember(Name="mediaBridgeId", EmitDefaultValue=false)]
        public string MediaBridgeId { get; set; }



        /// <summary>
        /// Count of any media (images, files, etc) included in this session
        /// </summary>
        /// <value>Count of any media (images, files, etc) included in this session</value>
        [DataMember(Name="mediaCount", EmitDefaultValue=false)]
        public int? MediaCount { get; set; }





        /// <summary>
        /// Message type for messaging services. E.g.: sms, facebook, twitter, line
        /// </summary>
        /// <value>Message type for messaging services. E.g.: sms, facebook, twitter, line</value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public string MessageType { get; set; }



        /// <summary>
        /// The participantId being monitored (if someone (e.g. an agent) is being monitored, this would correspond to one of the other participantIds present in the conversation)
        /// </summary>
        /// <value>The participantId being monitored (if someone (e.g. an agent) is being monitored, this would correspond to one of the other participantIds present in the conversation)</value>
        [DataMember(Name="monitoredParticipantId", EmitDefaultValue=false)]
        public string MonitoredParticipantId { get; set; }



        /// <summary>
        /// (Dialer) Unique identifier of the outbound campaign
        /// </summary>
        /// <value>(Dialer) Unique identifier of the outbound campaign</value>
        [DataMember(Name="outboundCampaignId", EmitDefaultValue=false)]
        public string OutboundCampaignId { get; set; }



        /// <summary>
        /// (Dialer) Unique identifier of the contact
        /// </summary>
        /// <value>(Dialer) Unique identifier of the contact</value>
        [DataMember(Name="outboundContactId", EmitDefaultValue=false)]
        public string OutboundContactId { get; set; }



        /// <summary>
        /// (Dialer) Unique identifier of the contact list that this contact belongs to
        /// </summary>
        /// <value>(Dialer) Unique identifier of the contact list that this contact belongs to</value>
        [DataMember(Name="outboundContactListId", EmitDefaultValue=false)]
        public string OutboundContactListId { get; set; }



        /// <summary>
        /// This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.
        /// </summary>
        /// <value>This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.</value>
        [DataMember(Name="peerId", EmitDefaultValue=false)]
        public string PeerId { get; set; }



        /// <summary>
        /// The original voice protocol call ID, e.g. a SIP call ID
        /// </summary>
        /// <value>The original voice protocol call ID, e.g. a SIP call ID</value>
        [DataMember(Name="protocolCallId", EmitDefaultValue=false)]
        public string ProtocolCallId { get; set; }



        /// <summary>
        /// The source provider for the communication.
        /// </summary>
        /// <value>The source provider for the communication.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }



        /// <summary>
        /// Flag determining if an audio recording was started or not
        /// </summary>
        /// <value>Flag determining if an audio recording was started or not</value>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public bool? Recording { get; set; }



        /// <summary>
        /// Name, phone number, or email address of the remote party.
        /// </summary>
        /// <value>Name, phone number, or email address of the remote party.</value>
        [DataMember(Name="remote", EmitDefaultValue=false)]
        public string Remote { get; set; }



        /// <summary>
        /// Unique identifier for the remote party
        /// </summary>
        /// <value>Unique identifier for the remote party</value>
        [DataMember(Name="remoteNameDisplayable", EmitDefaultValue=false)]
        public string RemoteNameDisplayable { get; set; }



        /// <summary>
        /// ID(s) of Skill(s) that have been removed by bullseye routing
        /// </summary>
        /// <value>ID(s) of Skill(s) that have been removed by bullseye routing</value>
        [DataMember(Name="removedSkillIds", EmitDefaultValue=false)]
        public List<string> RemovedSkillIds { get; set; }



        /// <summary>
        /// Routing type(s) for requested/attempted routing methods.
        /// </summary>
        /// <value>Routing type(s) for requested/attempted routing methods.</value>
        [DataMember(Name="requestedRoutings", EmitDefaultValue=false)]
        public List<RequestedRoutingsEnum> RequestedRoutings { get; set; }



        /// <summary>
        /// Unique identifier for the room
        /// </summary>
        /// <value>Unique identifier for the room</value>
        [DataMember(Name="roomId", EmitDefaultValue=false)]
        public string RoomId { get; set; }



        /// <summary>
        /// Routing ring for bullseye or preferred agent routing
        /// </summary>
        /// <value>Routing ring for bullseye or preferred agent routing</value>
        [DataMember(Name="routingRing", EmitDefaultValue=false)]
        public int? RoutingRing { get; set; }



        /// <summary>
        /// Direct ScreenShare address
        /// </summary>
        /// <value>Direct ScreenShare address</value>
        [DataMember(Name="screenShareAddressSelf", EmitDefaultValue=false)]
        public string ScreenShareAddressSelf { get; set; }



        /// <summary>
        /// A unique identifier for a PureCloud ScreenShare room
        /// </summary>
        /// <value>A unique identifier for a PureCloud ScreenShare room</value>
        [DataMember(Name="screenShareRoomId", EmitDefaultValue=false)]
        public string ScreenShareRoomId { get; set; }



        /// <summary>
        /// A unique identifier for a script
        /// </summary>
        /// <value>A unique identifier for a script</value>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public string ScriptId { get; set; }



        /// <summary>
        /// Selected agent ID
        /// </summary>
        /// <value>Selected agent ID</value>
        [DataMember(Name="selectedAgentId", EmitDefaultValue=false)]
        public string SelectedAgentId { get; set; }



        /// <summary>
        /// Selected agent GPR rank
        /// </summary>
        /// <value>Selected agent GPR rank</value>
        [DataMember(Name="selectedAgentRank", EmitDefaultValue=false)]
        public int? SelectedAgentRank { get; set; }



        /// <summary>
        /// Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred
        /// </summary>
        /// <value>Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred</value>
        [DataMember(Name="sessionDnis", EmitDefaultValue=false)]
        public string SessionDnis { get; set; }



        /// <summary>
        /// The unique identifier of this session
        /// </summary>
        /// <value>The unique identifier of this session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// Flag determining if screenShare is started or not (true/false)
        /// </summary>
        /// <value>Flag determining if screenShare is started or not (true/false)</value>
        [DataMember(Name="sharingScreen", EmitDefaultValue=false)]
        public bool? SharingScreen { get; set; }



        /// <summary>
        /// (Dialer) Whether the agent can skip the dialer contact
        /// </summary>
        /// <value>(Dialer) Whether the agent can skip the dialer contact</value>
        [DataMember(Name="skipEnabled", EmitDefaultValue=false)]
        public bool? SkipEnabled { get; set; }



        /// <summary>
        /// The number of seconds before PureCloud begins the call for a call back (0 disables automatic calling)
        /// </summary>
        /// <value>The number of seconds before PureCloud begins the call for a call back (0 disables automatic calling)</value>
        [DataMember(Name="timeoutSeconds", EmitDefaultValue=false)]
        public int? TimeoutSeconds { get; set; }





        /// <summary>
        /// Direct Video address
        /// </summary>
        /// <value>Direct Video address</value>
        [DataMember(Name="videoAddressSelf", EmitDefaultValue=false)]
        public string VideoAddressSelf { get; set; }



        /// <summary>
        /// A unique identifier for a PureCloud video room
        /// </summary>
        /// <value>A unique identifier for a PureCloud video room</value>
        [DataMember(Name="videoRoomId", EmitDefaultValue=false)]
        public string VideoRoomId { get; set; }



        /// <summary>
        /// Number of waiting interactions for each predictive routing attempt
        /// </summary>
        /// <value>Number of waiting interactions for each predictive routing attempt</value>
        [DataMember(Name="waitingInteractionCounts", EmitDefaultValue=false)]
        public List<int?> WaitingInteractionCounts { get; set; }



        /// <summary>
        /// Proposed agents
        /// </summary>
        /// <value>Proposed agents</value>
        [DataMember(Name="proposedAgents", EmitDefaultValue=false)]
        public List<AnalyticsProposedAgent> ProposedAgents { get; set; }



        /// <summary>
        /// Conditional group routing agent groups
        /// </summary>
        /// <value>Conditional group routing agent groups</value>
        [DataMember(Name="agentGroups", EmitDefaultValue=false)]
        public List<AnalyticsAgentGroup> AgentGroups { get; set; }



        /// <summary>
        /// MediaEndpointStats associated with this session
        /// </summary>
        /// <value>MediaEndpointStats associated with this session</value>
        [DataMember(Name="mediaEndpointStats", EmitDefaultValue=false)]
        public List<AnalyticsMediaEndpointStat> MediaEndpointStats { get; set; }



        /// <summary>
        /// IVR flow execution associated with this session
        /// </summary>
        /// <value>IVR flow execution associated with this session</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public AnalyticsFlow Flow { get; set; }



        /// <summary>
        /// List of metrics for this session
        /// </summary>
        /// <value>List of metrics for this session</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<AnalyticsSessionMetric> Metrics { get; set; }



        /// <summary>
        /// List of segments for this session
        /// </summary>
        /// <value>List of segments for this session</value>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<AnalyticsConversationSegment> Segments { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsSession {\n");

            sb.Append("  ActiveSkillIds: ").Append(ActiveSkillIds).Append("\n");
            sb.Append("  AcwSkipped: ").Append(AcwSkipped).Append("\n");
            sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
            sb.Append("  AddressOther: ").Append(AddressOther).Append("\n");
            sb.Append("  AddressSelf: ").Append(AddressSelf).Append("\n");
            sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
            sb.Append("  AgentAssistantId: ").Append(AgentAssistantId).Append("\n");
            sb.Append("  AgentBullseyeRing: ").Append(AgentBullseyeRing).Append("\n");
            sb.Append("  AgentOwned: ").Append(AgentOwned).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  AssignerId: ").Append(AssignerId).Append("\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
            sb.Append("  BargedParticipantId: ").Append(BargedParticipantId).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
            sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
            sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  CoachedParticipantId: ").Append(CoachedParticipantId).Append("\n");
            sb.Append("  CobrowseRole: ").Append(CobrowseRole).Append("\n");
            sb.Append("  CobrowseRoomId: ").Append(CobrowseRoomId).Append("\n");
            sb.Append("  DeliveryStatus: ").Append(DeliveryStatus).Append("\n");
            sb.Append("  DeliveryStatusChangeDate: ").Append(DeliveryStatusChangeDate).Append("\n");
            sb.Append("  DestinationAddresses: ").Append(DestinationAddresses).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  DispositionAnalyzer: ").Append(DispositionAnalyzer).Append("\n");
            sb.Append("  DispositionName: ").Append(DispositionName).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  EdgeId: ").Append(EdgeId).Append("\n");
            sb.Append("  EligibleAgentCounts: ").Append(EligibleAgentCounts).Append("\n");
            sb.Append("  ExtendedDeliveryStatus: ").Append(ExtendedDeliveryStatus).Append("\n");
            sb.Append("  FlowInType: ").Append(FlowInType).Append("\n");
            sb.Append("  FlowOutType: ").Append(FlowOutType).Append("\n");
            sb.Append("  JourneyActionId: ").Append(JourneyActionId).Append("\n");
            sb.Append("  JourneyActionMapId: ").Append(JourneyActionMapId).Append("\n");
            sb.Append("  JourneyActionMapVersion: ").Append(JourneyActionMapVersion).Append("\n");
            sb.Append("  JourneyCustomerId: ").Append(JourneyCustomerId).Append("\n");
            sb.Append("  JourneyCustomerIdType: ").Append(JourneyCustomerIdType).Append("\n");
            sb.Append("  JourneyCustomerSessionId: ").Append(JourneyCustomerSessionId).Append("\n");
            sb.Append("  JourneyCustomerSessionIdType: ").Append(JourneyCustomerSessionIdType).Append("\n");
            sb.Append("  MediaBridgeId: ").Append(MediaBridgeId).Append("\n");
            sb.Append("  MediaCount: ").Append(MediaCount).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
            sb.Append("  OutboundCampaignId: ").Append(OutboundCampaignId).Append("\n");
            sb.Append("  OutboundContactId: ").Append(OutboundContactId).Append("\n");
            sb.Append("  OutboundContactListId: ").Append(OutboundContactListId).Append("\n");
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
            sb.Append("  ProtocolCallId: ").Append(ProtocolCallId).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            sb.Append("  Remote: ").Append(Remote).Append("\n");
            sb.Append("  RemoteNameDisplayable: ").Append(RemoteNameDisplayable).Append("\n");
            sb.Append("  RemovedSkillIds: ").Append(RemovedSkillIds).Append("\n");
            sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  RoutingRing: ").Append(RoutingRing).Append("\n");
            sb.Append("  ScreenShareAddressSelf: ").Append(ScreenShareAddressSelf).Append("\n");
            sb.Append("  ScreenShareRoomId: ").Append(ScreenShareRoomId).Append("\n");
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  SelectedAgentId: ").Append(SelectedAgentId).Append("\n");
            sb.Append("  SelectedAgentRank: ").Append(SelectedAgentRank).Append("\n");
            sb.Append("  SessionDnis: ").Append(SessionDnis).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  SharingScreen: ").Append(SharingScreen).Append("\n");
            sb.Append("  SkipEnabled: ").Append(SkipEnabled).Append("\n");
            sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
            sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
            sb.Append("  VideoAddressSelf: ").Append(VideoAddressSelf).Append("\n");
            sb.Append("  VideoRoomId: ").Append(VideoRoomId).Append("\n");
            sb.Append("  WaitingInteractionCounts: ").Append(WaitingInteractionCounts).Append("\n");
            sb.Append("  ProposedAgents: ").Append(ProposedAgents).Append("\n");
            sb.Append("  AgentGroups: ").Append(AgentGroups).Append("\n");
            sb.Append("  MediaEndpointStats: ").Append(MediaEndpointStats).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
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
            return this.Equals(obj as AnalyticsSession);
        }

        /// <summary>
        /// Returns true if AnalyticsSession instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActiveSkillIds == other.ActiveSkillIds ||
                    this.ActiveSkillIds != null &&
                    this.ActiveSkillIds.SequenceEqual(other.ActiveSkillIds)
                ) &&
                (
                    this.AcwSkipped == other.AcwSkipped ||
                    this.AcwSkipped != null &&
                    this.AcwSkipped.Equals(other.AcwSkipped)
                ) &&
                (
                    this.AddressFrom == other.AddressFrom ||
                    this.AddressFrom != null &&
                    this.AddressFrom.Equals(other.AddressFrom)
                ) &&
                (
                    this.AddressOther == other.AddressOther ||
                    this.AddressOther != null &&
                    this.AddressOther.Equals(other.AddressOther)
                ) &&
                (
                    this.AddressSelf == other.AddressSelf ||
                    this.AddressSelf != null &&
                    this.AddressSelf.Equals(other.AddressSelf)
                ) &&
                (
                    this.AddressTo == other.AddressTo ||
                    this.AddressTo != null &&
                    this.AddressTo.Equals(other.AddressTo)
                ) &&
                (
                    this.AgentAssistantId == other.AgentAssistantId ||
                    this.AgentAssistantId != null &&
                    this.AgentAssistantId.Equals(other.AgentAssistantId)
                ) &&
                (
                    this.AgentBullseyeRing == other.AgentBullseyeRing ||
                    this.AgentBullseyeRing != null &&
                    this.AgentBullseyeRing.Equals(other.AgentBullseyeRing)
                ) &&
                (
                    this.AgentOwned == other.AgentOwned ||
                    this.AgentOwned != null &&
                    this.AgentOwned.Equals(other.AgentOwned)
                ) &&
                (
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) &&
                (
                    this.AssignerId == other.AssignerId ||
                    this.AssignerId != null &&
                    this.AssignerId.Equals(other.AssignerId)
                ) &&
                (
                    this.Authenticated == other.Authenticated ||
                    this.Authenticated != null &&
                    this.Authenticated.Equals(other.Authenticated)
                ) &&
                (
                    this.BargedParticipantId == other.BargedParticipantId ||
                    this.BargedParticipantId != null &&
                    this.BargedParticipantId.Equals(other.BargedParticipantId)
                ) &&
                (
                    this.Bcc == other.Bcc ||
                    this.Bcc != null &&
                    this.Bcc.SequenceEqual(other.Bcc)
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
                    this.CallbackUserName == other.CallbackUserName ||
                    this.CallbackUserName != null &&
                    this.CallbackUserName.Equals(other.CallbackUserName)
                ) &&
                (
                    this.Cc == other.Cc ||
                    this.Cc != null &&
                    this.Cc.SequenceEqual(other.Cc)
                ) &&
                (
                    this.CoachedParticipantId == other.CoachedParticipantId ||
                    this.CoachedParticipantId != null &&
                    this.CoachedParticipantId.Equals(other.CoachedParticipantId)
                ) &&
                (
                    this.CobrowseRole == other.CobrowseRole ||
                    this.CobrowseRole != null &&
                    this.CobrowseRole.Equals(other.CobrowseRole)
                ) &&
                (
                    this.CobrowseRoomId == other.CobrowseRoomId ||
                    this.CobrowseRoomId != null &&
                    this.CobrowseRoomId.Equals(other.CobrowseRoomId)
                ) &&
                (
                    this.DeliveryStatus == other.DeliveryStatus ||
                    this.DeliveryStatus != null &&
                    this.DeliveryStatus.Equals(other.DeliveryStatus)
                ) &&
                (
                    this.DeliveryStatusChangeDate == other.DeliveryStatusChangeDate ||
                    this.DeliveryStatusChangeDate != null &&
                    this.DeliveryStatusChangeDate.Equals(other.DeliveryStatusChangeDate)
                ) &&
                (
                    this.DestinationAddresses == other.DestinationAddresses ||
                    this.DestinationAddresses != null &&
                    this.DestinationAddresses.SequenceEqual(other.DestinationAddresses)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.DispositionAnalyzer == other.DispositionAnalyzer ||
                    this.DispositionAnalyzer != null &&
                    this.DispositionAnalyzer.Equals(other.DispositionAnalyzer)
                ) &&
                (
                    this.DispositionName == other.DispositionName ||
                    this.DispositionName != null &&
                    this.DispositionName.Equals(other.DispositionName)
                ) &&
                (
                    this.Dnis == other.Dnis ||
                    this.Dnis != null &&
                    this.Dnis.Equals(other.Dnis)
                ) &&
                (
                    this.EdgeId == other.EdgeId ||
                    this.EdgeId != null &&
                    this.EdgeId.Equals(other.EdgeId)
                ) &&
                (
                    this.EligibleAgentCounts == other.EligibleAgentCounts ||
                    this.EligibleAgentCounts != null &&
                    this.EligibleAgentCounts.SequenceEqual(other.EligibleAgentCounts)
                ) &&
                (
                    this.ExtendedDeliveryStatus == other.ExtendedDeliveryStatus ||
                    this.ExtendedDeliveryStatus != null &&
                    this.ExtendedDeliveryStatus.Equals(other.ExtendedDeliveryStatus)
                ) &&
                (
                    this.FlowInType == other.FlowInType ||
                    this.FlowInType != null &&
                    this.FlowInType.Equals(other.FlowInType)
                ) &&
                (
                    this.FlowOutType == other.FlowOutType ||
                    this.FlowOutType != null &&
                    this.FlowOutType.Equals(other.FlowOutType)
                ) &&
                (
                    this.JourneyActionId == other.JourneyActionId ||
                    this.JourneyActionId != null &&
                    this.JourneyActionId.Equals(other.JourneyActionId)
                ) &&
                (
                    this.JourneyActionMapId == other.JourneyActionMapId ||
                    this.JourneyActionMapId != null &&
                    this.JourneyActionMapId.Equals(other.JourneyActionMapId)
                ) &&
                (
                    this.JourneyActionMapVersion == other.JourneyActionMapVersion ||
                    this.JourneyActionMapVersion != null &&
                    this.JourneyActionMapVersion.Equals(other.JourneyActionMapVersion)
                ) &&
                (
                    this.JourneyCustomerId == other.JourneyCustomerId ||
                    this.JourneyCustomerId != null &&
                    this.JourneyCustomerId.Equals(other.JourneyCustomerId)
                ) &&
                (
                    this.JourneyCustomerIdType == other.JourneyCustomerIdType ||
                    this.JourneyCustomerIdType != null &&
                    this.JourneyCustomerIdType.Equals(other.JourneyCustomerIdType)
                ) &&
                (
                    this.JourneyCustomerSessionId == other.JourneyCustomerSessionId ||
                    this.JourneyCustomerSessionId != null &&
                    this.JourneyCustomerSessionId.Equals(other.JourneyCustomerSessionId)
                ) &&
                (
                    this.JourneyCustomerSessionIdType == other.JourneyCustomerSessionIdType ||
                    this.JourneyCustomerSessionIdType != null &&
                    this.JourneyCustomerSessionIdType.Equals(other.JourneyCustomerSessionIdType)
                ) &&
                (
                    this.MediaBridgeId == other.MediaBridgeId ||
                    this.MediaBridgeId != null &&
                    this.MediaBridgeId.Equals(other.MediaBridgeId)
                ) &&
                (
                    this.MediaCount == other.MediaCount ||
                    this.MediaCount != null &&
                    this.MediaCount.Equals(other.MediaCount)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) &&
                (
                    this.MonitoredParticipantId == other.MonitoredParticipantId ||
                    this.MonitoredParticipantId != null &&
                    this.MonitoredParticipantId.Equals(other.MonitoredParticipantId)
                ) &&
                (
                    this.OutboundCampaignId == other.OutboundCampaignId ||
                    this.OutboundCampaignId != null &&
                    this.OutboundCampaignId.Equals(other.OutboundCampaignId)
                ) &&
                (
                    this.OutboundContactId == other.OutboundContactId ||
                    this.OutboundContactId != null &&
                    this.OutboundContactId.Equals(other.OutboundContactId)
                ) &&
                (
                    this.OutboundContactListId == other.OutboundContactListId ||
                    this.OutboundContactListId != null &&
                    this.OutboundContactListId.Equals(other.OutboundContactListId)
                ) &&
                (
                    this.PeerId == other.PeerId ||
                    this.PeerId != null &&
                    this.PeerId.Equals(other.PeerId)
                ) &&
                (
                    this.ProtocolCallId == other.ProtocolCallId ||
                    this.ProtocolCallId != null &&
                    this.ProtocolCallId.Equals(other.ProtocolCallId)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
                ) &&
                (
                    this.Remote == other.Remote ||
                    this.Remote != null &&
                    this.Remote.Equals(other.Remote)
                ) &&
                (
                    this.RemoteNameDisplayable == other.RemoteNameDisplayable ||
                    this.RemoteNameDisplayable != null &&
                    this.RemoteNameDisplayable.Equals(other.RemoteNameDisplayable)
                ) &&
                (
                    this.RemovedSkillIds == other.RemovedSkillIds ||
                    this.RemovedSkillIds != null &&
                    this.RemovedSkillIds.SequenceEqual(other.RemovedSkillIds)
                ) &&
                (
                    this.RequestedRoutings == other.RequestedRoutings ||
                    this.RequestedRoutings != null &&
                    this.RequestedRoutings.SequenceEqual(other.RequestedRoutings)
                ) &&
                (
                    this.RoomId == other.RoomId ||
                    this.RoomId != null &&
                    this.RoomId.Equals(other.RoomId)
                ) &&
                (
                    this.RoutingRing == other.RoutingRing ||
                    this.RoutingRing != null &&
                    this.RoutingRing.Equals(other.RoutingRing)
                ) &&
                (
                    this.ScreenShareAddressSelf == other.ScreenShareAddressSelf ||
                    this.ScreenShareAddressSelf != null &&
                    this.ScreenShareAddressSelf.Equals(other.ScreenShareAddressSelf)
                ) &&
                (
                    this.ScreenShareRoomId == other.ScreenShareRoomId ||
                    this.ScreenShareRoomId != null &&
                    this.ScreenShareRoomId.Equals(other.ScreenShareRoomId)
                ) &&
                (
                    this.ScriptId == other.ScriptId ||
                    this.ScriptId != null &&
                    this.ScriptId.Equals(other.ScriptId)
                ) &&
                (
                    this.SelectedAgentId == other.SelectedAgentId ||
                    this.SelectedAgentId != null &&
                    this.SelectedAgentId.Equals(other.SelectedAgentId)
                ) &&
                (
                    this.SelectedAgentRank == other.SelectedAgentRank ||
                    this.SelectedAgentRank != null &&
                    this.SelectedAgentRank.Equals(other.SelectedAgentRank)
                ) &&
                (
                    this.SessionDnis == other.SessionDnis ||
                    this.SessionDnis != null &&
                    this.SessionDnis.Equals(other.SessionDnis)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.SharingScreen == other.SharingScreen ||
                    this.SharingScreen != null &&
                    this.SharingScreen.Equals(other.SharingScreen)
                ) &&
                (
                    this.SkipEnabled == other.SkipEnabled ||
                    this.SkipEnabled != null &&
                    this.SkipEnabled.Equals(other.SkipEnabled)
                ) &&
                (
                    this.TimeoutSeconds == other.TimeoutSeconds ||
                    this.TimeoutSeconds != null &&
                    this.TimeoutSeconds.Equals(other.TimeoutSeconds)
                ) &&
                (
                    this.UsedRouting == other.UsedRouting ||
                    this.UsedRouting != null &&
                    this.UsedRouting.Equals(other.UsedRouting)
                ) &&
                (
                    this.VideoAddressSelf == other.VideoAddressSelf ||
                    this.VideoAddressSelf != null &&
                    this.VideoAddressSelf.Equals(other.VideoAddressSelf)
                ) &&
                (
                    this.VideoRoomId == other.VideoRoomId ||
                    this.VideoRoomId != null &&
                    this.VideoRoomId.Equals(other.VideoRoomId)
                ) &&
                (
                    this.WaitingInteractionCounts == other.WaitingInteractionCounts ||
                    this.WaitingInteractionCounts != null &&
                    this.WaitingInteractionCounts.SequenceEqual(other.WaitingInteractionCounts)
                ) &&
                (
                    this.ProposedAgents == other.ProposedAgents ||
                    this.ProposedAgents != null &&
                    this.ProposedAgents.SequenceEqual(other.ProposedAgents)
                ) &&
                (
                    this.AgentGroups == other.AgentGroups ||
                    this.AgentGroups != null &&
                    this.AgentGroups.SequenceEqual(other.AgentGroups)
                ) &&
                (
                    this.MediaEndpointStats == other.MediaEndpointStats ||
                    this.MediaEndpointStats != null &&
                    this.MediaEndpointStats.SequenceEqual(other.MediaEndpointStats)
                ) &&
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.Segments == other.Segments ||
                    this.Segments != null &&
                    this.Segments.SequenceEqual(other.Segments)
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
                if (this.ActiveSkillIds != null)
                    hash = hash * 59 + this.ActiveSkillIds.GetHashCode();

                if (this.AcwSkipped != null)
                    hash = hash * 59 + this.AcwSkipped.GetHashCode();

                if (this.AddressFrom != null)
                    hash = hash * 59 + this.AddressFrom.GetHashCode();

                if (this.AddressOther != null)
                    hash = hash * 59 + this.AddressOther.GetHashCode();

                if (this.AddressSelf != null)
                    hash = hash * 59 + this.AddressSelf.GetHashCode();

                if (this.AddressTo != null)
                    hash = hash * 59 + this.AddressTo.GetHashCode();

                if (this.AgentAssistantId != null)
                    hash = hash * 59 + this.AgentAssistantId.GetHashCode();

                if (this.AgentBullseyeRing != null)
                    hash = hash * 59 + this.AgentBullseyeRing.GetHashCode();

                if (this.AgentOwned != null)
                    hash = hash * 59 + this.AgentOwned.GetHashCode();

                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();

                if (this.AssignerId != null)
                    hash = hash * 59 + this.AssignerId.GetHashCode();

                if (this.Authenticated != null)
                    hash = hash * 59 + this.Authenticated.GetHashCode();

                if (this.BargedParticipantId != null)
                    hash = hash * 59 + this.BargedParticipantId.GetHashCode();

                if (this.Bcc != null)
                    hash = hash * 59 + this.Bcc.GetHashCode();

                if (this.CallbackNumbers != null)
                    hash = hash * 59 + this.CallbackNumbers.GetHashCode();

                if (this.CallbackScheduledTime != null)
                    hash = hash * 59 + this.CallbackScheduledTime.GetHashCode();

                if (this.CallbackUserName != null)
                    hash = hash * 59 + this.CallbackUserName.GetHashCode();

                if (this.Cc != null)
                    hash = hash * 59 + this.Cc.GetHashCode();

                if (this.CoachedParticipantId != null)
                    hash = hash * 59 + this.CoachedParticipantId.GetHashCode();

                if (this.CobrowseRole != null)
                    hash = hash * 59 + this.CobrowseRole.GetHashCode();

                if (this.CobrowseRoomId != null)
                    hash = hash * 59 + this.CobrowseRoomId.GetHashCode();

                if (this.DeliveryStatus != null)
                    hash = hash * 59 + this.DeliveryStatus.GetHashCode();

                if (this.DeliveryStatusChangeDate != null)
                    hash = hash * 59 + this.DeliveryStatusChangeDate.GetHashCode();

                if (this.DestinationAddresses != null)
                    hash = hash * 59 + this.DestinationAddresses.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.DispositionAnalyzer != null)
                    hash = hash * 59 + this.DispositionAnalyzer.GetHashCode();

                if (this.DispositionName != null)
                    hash = hash * 59 + this.DispositionName.GetHashCode();

                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();

                if (this.EdgeId != null)
                    hash = hash * 59 + this.EdgeId.GetHashCode();

                if (this.EligibleAgentCounts != null)
                    hash = hash * 59 + this.EligibleAgentCounts.GetHashCode();

                if (this.ExtendedDeliveryStatus != null)
                    hash = hash * 59 + this.ExtendedDeliveryStatus.GetHashCode();

                if (this.FlowInType != null)
                    hash = hash * 59 + this.FlowInType.GetHashCode();

                if (this.FlowOutType != null)
                    hash = hash * 59 + this.FlowOutType.GetHashCode();

                if (this.JourneyActionId != null)
                    hash = hash * 59 + this.JourneyActionId.GetHashCode();

                if (this.JourneyActionMapId != null)
                    hash = hash * 59 + this.JourneyActionMapId.GetHashCode();

                if (this.JourneyActionMapVersion != null)
                    hash = hash * 59 + this.JourneyActionMapVersion.GetHashCode();

                if (this.JourneyCustomerId != null)
                    hash = hash * 59 + this.JourneyCustomerId.GetHashCode();

                if (this.JourneyCustomerIdType != null)
                    hash = hash * 59 + this.JourneyCustomerIdType.GetHashCode();

                if (this.JourneyCustomerSessionId != null)
                    hash = hash * 59 + this.JourneyCustomerSessionId.GetHashCode();

                if (this.JourneyCustomerSessionIdType != null)
                    hash = hash * 59 + this.JourneyCustomerSessionIdType.GetHashCode();

                if (this.MediaBridgeId != null)
                    hash = hash * 59 + this.MediaBridgeId.GetHashCode();

                if (this.MediaCount != null)
                    hash = hash * 59 + this.MediaCount.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();

                if (this.MonitoredParticipantId != null)
                    hash = hash * 59 + this.MonitoredParticipantId.GetHashCode();

                if (this.OutboundCampaignId != null)
                    hash = hash * 59 + this.OutboundCampaignId.GetHashCode();

                if (this.OutboundContactId != null)
                    hash = hash * 59 + this.OutboundContactId.GetHashCode();

                if (this.OutboundContactListId != null)
                    hash = hash * 59 + this.OutboundContactListId.GetHashCode();

                if (this.PeerId != null)
                    hash = hash * 59 + this.PeerId.GetHashCode();

                if (this.ProtocolCallId != null)
                    hash = hash * 59 + this.ProtocolCallId.GetHashCode();

                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();

                if (this.Recording != null)
                    hash = hash * 59 + this.Recording.GetHashCode();

                if (this.Remote != null)
                    hash = hash * 59 + this.Remote.GetHashCode();

                if (this.RemoteNameDisplayable != null)
                    hash = hash * 59 + this.RemoteNameDisplayable.GetHashCode();

                if (this.RemovedSkillIds != null)
                    hash = hash * 59 + this.RemovedSkillIds.GetHashCode();

                if (this.RequestedRoutings != null)
                    hash = hash * 59 + this.RequestedRoutings.GetHashCode();

                if (this.RoomId != null)
                    hash = hash * 59 + this.RoomId.GetHashCode();

                if (this.RoutingRing != null)
                    hash = hash * 59 + this.RoutingRing.GetHashCode();

                if (this.ScreenShareAddressSelf != null)
                    hash = hash * 59 + this.ScreenShareAddressSelf.GetHashCode();

                if (this.ScreenShareRoomId != null)
                    hash = hash * 59 + this.ScreenShareRoomId.GetHashCode();

                if (this.ScriptId != null)
                    hash = hash * 59 + this.ScriptId.GetHashCode();

                if (this.SelectedAgentId != null)
                    hash = hash * 59 + this.SelectedAgentId.GetHashCode();

                if (this.SelectedAgentRank != null)
                    hash = hash * 59 + this.SelectedAgentRank.GetHashCode();

                if (this.SessionDnis != null)
                    hash = hash * 59 + this.SessionDnis.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.SharingScreen != null)
                    hash = hash * 59 + this.SharingScreen.GetHashCode();

                if (this.SkipEnabled != null)
                    hash = hash * 59 + this.SkipEnabled.GetHashCode();

                if (this.TimeoutSeconds != null)
                    hash = hash * 59 + this.TimeoutSeconds.GetHashCode();

                if (this.UsedRouting != null)
                    hash = hash * 59 + this.UsedRouting.GetHashCode();

                if (this.VideoAddressSelf != null)
                    hash = hash * 59 + this.VideoAddressSelf.GetHashCode();

                if (this.VideoRoomId != null)
                    hash = hash * 59 + this.VideoRoomId.GetHashCode();

                if (this.WaitingInteractionCounts != null)
                    hash = hash * 59 + this.WaitingInteractionCounts.GetHashCode();

                if (this.ProposedAgents != null)
                    hash = hash * 59 + this.ProposedAgents.GetHashCode();

                if (this.AgentGroups != null)
                    hash = hash * 59 + this.AgentGroups.GetHashCode();

                if (this.MediaEndpointStats != null)
                    hash = hash * 59 + this.MediaEndpointStats.GetHashCode();

                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.Segments != null)
                    hash = hash * 59 + this.Segments.GetHashCode();

                return hash;
            }
        }
    }

}
