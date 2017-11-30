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
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "chat"
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Cobrowse for "cobrowse"
            /// </summary>
            [EnumMember(Value = "cobrowse")]
            Cobrowse,
            
            /// <summary>
            /// Enum Video for "video"
            /// </summary>
            [EnumMember(Value = "video")]
            Video,
            
            /// <summary>
            /// Enum Screenshare for "screenshare"
            /// </summary>
            [EnumMember(Value = "screenshare")]
            Screenshare,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Message type for messaging services such as sms
        /// </summary>
        /// <value>Message type for messaging services such as sms</value>
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
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Direction
        /// </summary>
        /// <value>Direction</value>
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
        /// (Dialer) Result of the analysis (for example disposition.classification.callable.machine) 
        /// </summary>
        /// <value>(Dialer) Result of the analysis (for example disposition.classification.callable.machine) </value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DispositionNameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Disconnect for "disconnect"
            /// </summary>
            [EnumMember(Value = "disconnect")]
            Disconnect,
            
            /// <summary>
            /// Enum Person for "person"
            /// </summary>
            [EnumMember(Value = "person")]
            Person,
            
            /// <summary>
            /// Enum Busy for "busy"
            /// </summary>
            [EnumMember(Value = "busy")]
            Busy,
            
            /// <summary>
            /// Enum Machine for "machine"
            /// </summary>
            [EnumMember(Value = "machine")]
            Machine,
            
            /// <summary>
            /// Enum Noanswer for "noanswer"
            /// </summary>
            [EnumMember(Value = "noanswer")]
            Noanswer,
            
            /// <summary>
            /// Enum Fax for "fax"
            /// </summary>
            [EnumMember(Value = "fax")]
            Fax,
            
            /// <summary>
            /// Enum Sit for "sit"
            /// </summary>
            [EnumMember(Value = "sit")]
            Sit
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The session media type
        /// </summary>
        /// <value>The session media type</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Message type for messaging services such as sms
        /// </summary>
        /// <value>Message type for messaging services such as sms</value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }
        
        
        
        
        
        /// <summary>
        /// Direction
        /// </summary>
        /// <value>Direction</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// (Dialer) Result of the analysis (for example disposition.classification.callable.machine) 
        /// </summary>
        /// <value>(Dialer) Result of the analysis (for example disposition.classification.callable.machine) </value>
        [DataMember(Name="dispositionName", EmitDefaultValue=false)]
        public DispositionNameEnum? DispositionName { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsSession" /> class.
        /// </summary>
        
        
        /// <param name="MediaType">The session media type.</param>
        
        
        
        /// <param name="SessionId">The unique identifier of this session.</param>
        
        
        
        /// <param name="AddressOther">AddressOther.</param>
        
        
        
        /// <param name="AddressSelf">AddressSelf.</param>
        
        
        
        /// <param name="AddressFrom">AddressFrom.</param>
        
        
        
        /// <param name="AddressTo">AddressTo.</param>
        
        
        
        /// <param name="MessageType">Message type for messaging services such as sms.</param>
        
        
        
        /// <param name="Ani">Automatic Number Identification (caller&#39;s number).</param>
        
        
        
        /// <param name="Direction">Direction.</param>
        
        
        
        /// <param name="Dnis">Automatic Number Identification (caller&#39;s number).</param>
        
        
        
        /// <param name="OutboundCampaignId">(Dialer) Unique identifier of the outbound campaign.</param>
        
        
        
        /// <param name="OutboundContactId">(Dialer) Unique identifier of the contact.</param>
        
        
        
        /// <param name="OutboundContactListId">(Dialer) Unique identifier of the contact list that this contact belongs to.</param>
        
        
        
        /// <param name="DispositionAnalyzer">(Dialer) Unique identifier of the contact list that this contact belongs to.</param>
        
        
        
        /// <param name="DispositionName">(Dialer) Result of the analysis (for example disposition.classification.callable.machine) .</param>
        
        
        
        /// <param name="EdgeId">Unique identifier of the edge device.</param>
        
        
        
        /// <param name="RemoteNameDisplayable">RemoteNameDisplayable.</param>
        
        
        
        /// <param name="RoomId">Unique identifier for the room.</param>
        
        
        
        /// <param name="MonitoredSessionId">The sessionID being monitored.</param>
        
        
        
        /// <param name="MonitoredParticipantId">MonitoredParticipantId.</param>
        
        
        
        /// <param name="CallbackUserName">The name of the user requesting a call back.</param>
        
        
        
        /// <param name="CallbackNumbers">List of numbers to callback.</param>
        
        
        
        /// <param name="CallbackScheduledTime">Scheduled callback date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="ScriptId">Scheduled callback date/time, Date time is represented as an ISO-8601 string. .</param>
        
        
        
        /// <param name="PeerId">A unique identifier for a peer.</param>
        
        
        
        /// <param name="SkipEnabled">(Dialer) Whether the agent can skip the dialer contact.</param>
        
        
        
        /// <param name="TimeoutSeconds">The number of seconds before PureCloud begins the call for a call back. 0 disables automatic calling.</param>
        
        
        
        /// <param name="CobrowseRole">Describe side of the cobrowse (sharer or viewer).</param>
        
        
        
        /// <param name="CobrowseRoomId">A unique identifier for a PureCloud Cobrowse room..</param>
        
        
        
        /// <param name="MediaBridgeId">MediaBridgeId.</param>
        
        
        
        /// <param name="ScreenShareAddressSelf">Direct ScreenShare address.</param>
        
        
        
        /// <param name="SharingScreen">Flag determining if screenShare is started or not (true/false).</param>
        
        
        
        /// <param name="ScreenShareRoomId">A unique identifier for a PureCloud ScreenShare room..</param>
        
        
        
        /// <param name="VideoRoomId">A unique identifier for a PureCloud video room..</param>
        
        
        
        /// <param name="VideoAddressSelf">Direct Video address.</param>
        
        
        
        /// <param name="Segments">List of segments for this session.</param>
        
        
        public AnalyticsSession(MediaTypeEnum? MediaType = null, string SessionId = null, string AddressOther = null, string AddressSelf = null, string AddressFrom = null, string AddressTo = null, MessageTypeEnum? MessageType = null, string Ani = null, DirectionEnum? Direction = null, string Dnis = null, string OutboundCampaignId = null, string OutboundContactId = null, string OutboundContactListId = null, string DispositionAnalyzer = null, DispositionNameEnum? DispositionName = null, string EdgeId = null, string RemoteNameDisplayable = null, string RoomId = null, string MonitoredSessionId = null, string MonitoredParticipantId = null, string CallbackUserName = null, List<string> CallbackNumbers = null, DateTime? CallbackScheduledTime = null, string ScriptId = null, string PeerId = null, bool? SkipEnabled = null, int? TimeoutSeconds = null, string CobrowseRole = null, string CobrowseRoomId = null, string MediaBridgeId = null, string ScreenShareAddressSelf = null, bool? SharingScreen = null, string ScreenShareRoomId = null, string VideoRoomId = null, string VideoAddressSelf = null, List<AnalyticsConversationSegment> Segments = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.MediaType = MediaType;
            
            
            
            
            
            
            
            
this.SessionId = SessionId;
            
            
            
            
            
            
            
            
this.AddressOther = AddressOther;
            
            
            
            
            
            
            
            
this.AddressSelf = AddressSelf;
            
            
            
            
            
            
            
            
this.AddressFrom = AddressFrom;
            
            
            
            
            
            
            
            
this.AddressTo = AddressTo;
            
            
            
            
            
            
            
            
this.MessageType = MessageType;
            
            
            
            
            
            
            
            
this.Ani = Ani;
            
            
            
            
            
            
            
            
this.Direction = Direction;
            
            
            
            
            
            
            
            
this.Dnis = Dnis;
            
            
            
            
            
            
            
            
this.OutboundCampaignId = OutboundCampaignId;
            
            
            
            
            
            
            
            
this.OutboundContactId = OutboundContactId;
            
            
            
            
            
            
            
            
this.OutboundContactListId = OutboundContactListId;
            
            
            
            
            
            
            
            
this.DispositionAnalyzer = DispositionAnalyzer;
            
            
            
            
            
            
            
            
this.DispositionName = DispositionName;
            
            
            
            
            
            
            
            
this.EdgeId = EdgeId;
            
            
            
            
            
            
            
            
this.RemoteNameDisplayable = RemoteNameDisplayable;
            
            
            
            
            
            
            
            
this.RoomId = RoomId;
            
            
            
            
            
            
            
            
this.MonitoredSessionId = MonitoredSessionId;
            
            
            
            
            
            
            
            
this.MonitoredParticipantId = MonitoredParticipantId;
            
            
            
            
            
            
            
            
this.CallbackUserName = CallbackUserName;
            
            
            
            
            
            
            
            
this.CallbackNumbers = CallbackNumbers;
            
            
            
            
            
            
            
            
this.CallbackScheduledTime = CallbackScheduledTime;
            
            
            
            
            
            
            
            
this.ScriptId = ScriptId;
            
            
            
            
            
            
            
            
this.PeerId = PeerId;
            
            
            
            
            
            
            
            
this.SkipEnabled = SkipEnabled;
            
            
            
            
            
            
            
            
this.TimeoutSeconds = TimeoutSeconds;
            
            
            
            
            
            
            
            
this.CobrowseRole = CobrowseRole;
            
            
            
            
            
            
            
            
this.CobrowseRoomId = CobrowseRoomId;
            
            
            
            
            
            
            
            
this.MediaBridgeId = MediaBridgeId;
            
            
            
            
            
            
            
            
this.ScreenShareAddressSelf = ScreenShareAddressSelf;
            
            
            
            
            
            
            
            
this.SharingScreen = SharingScreen;
            
            
            
            
            
            
            
            
this.ScreenShareRoomId = ScreenShareRoomId;
            
            
            
            
            
            
            
            
this.VideoRoomId = VideoRoomId;
            
            
            
            
            
            
            
            
this.VideoAddressSelf = VideoAddressSelf;
            
            
            
            
            
            
            
            
this.Segments = Segments;
            
            
            
            
        }
        
        
        
        
        
        /// <summary>
        /// The unique identifier of this session
        /// </summary>
        /// <value>The unique identifier of this session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddressOther
        /// </summary>
        [DataMember(Name="addressOther", EmitDefaultValue=false)]
        public string AddressOther { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddressSelf
        /// </summary>
        [DataMember(Name="addressSelf", EmitDefaultValue=false)]
        public string AddressSelf { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddressFrom
        /// </summary>
        [DataMember(Name="addressFrom", EmitDefaultValue=false)]
        public string AddressFrom { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddressTo
        /// </summary>
        [DataMember(Name="addressTo", EmitDefaultValue=false)]
        public string AddressTo { get; set; }
        
        
        
        
        
        /// <summary>
        /// Automatic Number Identification (caller&#39;s number)
        /// </summary>
        /// <value>Automatic Number Identification (caller&#39;s number)</value>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }
        
        
        
        
        
        /// <summary>
        /// Automatic Number Identification (caller&#39;s number)
        /// </summary>
        /// <value>Automatic Number Identification (caller&#39;s number)</value>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }
        
        
        
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
        /// (Dialer) Unique identifier of the contact list that this contact belongs to
        /// </summary>
        /// <value>(Dialer) Unique identifier of the contact list that this contact belongs to</value>
        [DataMember(Name="dispositionAnalyzer", EmitDefaultValue=false)]
        public string DispositionAnalyzer { get; set; }
        
        
        
        
        
        /// <summary>
        /// Unique identifier of the edge device
        /// </summary>
        /// <value>Unique identifier of the edge device</value>
        [DataMember(Name="edgeId", EmitDefaultValue=false)]
        public string EdgeId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RemoteNameDisplayable
        /// </summary>
        [DataMember(Name="remoteNameDisplayable", EmitDefaultValue=false)]
        public string RemoteNameDisplayable { get; set; }
        
        
        
        /// <summary>
        /// Unique identifier for the room
        /// </summary>
        /// <value>Unique identifier for the room</value>
        [DataMember(Name="roomId", EmitDefaultValue=false)]
        public string RoomId { get; set; }
        
        
        
        /// <summary>
        /// The sessionID being monitored
        /// </summary>
        /// <value>The sessionID being monitored</value>
        [DataMember(Name="monitoredSessionId", EmitDefaultValue=false)]
        public string MonitoredSessionId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MonitoredParticipantId
        /// </summary>
        [DataMember(Name="monitoredParticipantId", EmitDefaultValue=false)]
        public string MonitoredParticipantId { get; set; }
        
        
        
        /// <summary>
        /// The name of the user requesting a call back
        /// </summary>
        /// <value>The name of the user requesting a call back</value>
        [DataMember(Name="callbackUserName", EmitDefaultValue=false)]
        public string CallbackUserName { get; set; }
        
        
        
        /// <summary>
        /// List of numbers to callback
        /// </summary>
        /// <value>List of numbers to callback</value>
        [DataMember(Name="callbackNumbers", EmitDefaultValue=false)]
        public List<string> CallbackNumbers { get; set; }
        
        
        
        /// <summary>
        /// Scheduled callback date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Scheduled callback date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="callbackScheduledTime", EmitDefaultValue=false)]
        public DateTime? CallbackScheduledTime { get; set; }
        
        
        
        /// <summary>
        /// Scheduled callback date/time, Date time is represented as an ISO-8601 string. 
        /// </summary>
        /// <value>Scheduled callback date/time, Date time is represented as an ISO-8601 string. </value>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public string ScriptId { get; set; }
        
        
        
        /// <summary>
        /// A unique identifier for a peer
        /// </summary>
        /// <value>A unique identifier for a peer</value>
        [DataMember(Name="peerId", EmitDefaultValue=false)]
        public string PeerId { get; set; }
        
        
        
        /// <summary>
        /// (Dialer) Whether the agent can skip the dialer contact
        /// </summary>
        /// <value>(Dialer) Whether the agent can skip the dialer contact</value>
        [DataMember(Name="skipEnabled", EmitDefaultValue=false)]
        public bool? SkipEnabled { get; set; }
        
        
        
        /// <summary>
        /// The number of seconds before PureCloud begins the call for a call back. 0 disables automatic calling
        /// </summary>
        /// <value>The number of seconds before PureCloud begins the call for a call back. 0 disables automatic calling</value>
        [DataMember(Name="timeoutSeconds", EmitDefaultValue=false)]
        public int? TimeoutSeconds { get; set; }
        
        
        
        /// <summary>
        /// Describe side of the cobrowse (sharer or viewer)
        /// </summary>
        /// <value>Describe side of the cobrowse (sharer or viewer)</value>
        [DataMember(Name="cobrowseRole", EmitDefaultValue=false)]
        public string CobrowseRole { get; set; }
        
        
        
        /// <summary>
        /// A unique identifier for a PureCloud Cobrowse room.
        /// </summary>
        /// <value>A unique identifier for a PureCloud Cobrowse room.</value>
        [DataMember(Name="cobrowseRoomId", EmitDefaultValue=false)]
        public string CobrowseRoomId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MediaBridgeId
        /// </summary>
        [DataMember(Name="mediaBridgeId", EmitDefaultValue=false)]
        public string MediaBridgeId { get; set; }
        
        
        
        /// <summary>
        /// Direct ScreenShare address
        /// </summary>
        /// <value>Direct ScreenShare address</value>
        [DataMember(Name="screenShareAddressSelf", EmitDefaultValue=false)]
        public string ScreenShareAddressSelf { get; set; }
        
        
        
        /// <summary>
        /// Flag determining if screenShare is started or not (true/false)
        /// </summary>
        /// <value>Flag determining if screenShare is started or not (true/false)</value>
        [DataMember(Name="sharingScreen", EmitDefaultValue=false)]
        public bool? SharingScreen { get; set; }
        
        
        
        /// <summary>
        /// A unique identifier for a PureCloud ScreenShare room.
        /// </summary>
        /// <value>A unique identifier for a PureCloud ScreenShare room.</value>
        [DataMember(Name="screenShareRoomId", EmitDefaultValue=false)]
        public string ScreenShareRoomId { get; set; }
        
        
        
        /// <summary>
        /// A unique identifier for a PureCloud video room.
        /// </summary>
        /// <value>A unique identifier for a PureCloud video room.</value>
        [DataMember(Name="videoRoomId", EmitDefaultValue=false)]
        public string VideoRoomId { get; set; }
        
        
        
        /// <summary>
        /// Direct Video address
        /// </summary>
        /// <value>Direct Video address</value>
        [DataMember(Name="videoAddressSelf", EmitDefaultValue=false)]
        public string VideoAddressSelf { get; set; }
        
        
        
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
            
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            
            sb.Append("  AddressOther: ").Append(AddressOther).Append("\n");
            
            sb.Append("  AddressSelf: ").Append(AddressSelf).Append("\n");
            
            sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
            
            sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
            
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            
            sb.Append("  OutboundCampaignId: ").Append(OutboundCampaignId).Append("\n");
            
            sb.Append("  OutboundContactId: ").Append(OutboundContactId).Append("\n");
            
            sb.Append("  OutboundContactListId: ").Append(OutboundContactListId).Append("\n");
            
            sb.Append("  DispositionAnalyzer: ").Append(DispositionAnalyzer).Append("\n");
            
            sb.Append("  DispositionName: ").Append(DispositionName).Append("\n");
            
            sb.Append("  EdgeId: ").Append(EdgeId).Append("\n");
            
            sb.Append("  RemoteNameDisplayable: ").Append(RemoteNameDisplayable).Append("\n");
            
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            
            sb.Append("  MonitoredSessionId: ").Append(MonitoredSessionId).Append("\n");
            
            sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
            
            sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
            
            sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
            
            sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
            
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
            
            sb.Append("  SkipEnabled: ").Append(SkipEnabled).Append("\n");
            
            sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
            
            sb.Append("  CobrowseRole: ").Append(CobrowseRole).Append("\n");
            
            sb.Append("  CobrowseRoomId: ").Append(CobrowseRoomId).Append("\n");
            
            sb.Append("  MediaBridgeId: ").Append(MediaBridgeId).Append("\n");
            
            sb.Append("  ScreenShareAddressSelf: ").Append(ScreenShareAddressSelf).Append("\n");
            
            sb.Append("  SharingScreen: ").Append(SharingScreen).Append("\n");
            
            sb.Append("  ScreenShareRoomId: ").Append(ScreenShareRoomId).Append("\n");
            
            sb.Append("  VideoRoomId: ").Append(VideoRoomId).Append("\n");
            
            sb.Append("  VideoAddressSelf: ").Append(VideoAddressSelf).Append("\n");
            
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
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
                    this.AddressFrom == other.AddressFrom ||
                    this.AddressFrom != null &&
                    this.AddressFrom.Equals(other.AddressFrom)
                ) &&
                (
                    this.AddressTo == other.AddressTo ||
                    this.AddressTo != null &&
                    this.AddressTo.Equals(other.AddressTo)
                ) &&
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) &&
                (
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.Dnis == other.Dnis ||
                    this.Dnis != null &&
                    this.Dnis.Equals(other.Dnis)
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
                    this.EdgeId == other.EdgeId ||
                    this.EdgeId != null &&
                    this.EdgeId.Equals(other.EdgeId)
                ) &&
                (
                    this.RemoteNameDisplayable == other.RemoteNameDisplayable ||
                    this.RemoteNameDisplayable != null &&
                    this.RemoteNameDisplayable.Equals(other.RemoteNameDisplayable)
                ) &&
                (
                    this.RoomId == other.RoomId ||
                    this.RoomId != null &&
                    this.RoomId.Equals(other.RoomId)
                ) &&
                (
                    this.MonitoredSessionId == other.MonitoredSessionId ||
                    this.MonitoredSessionId != null &&
                    this.MonitoredSessionId.Equals(other.MonitoredSessionId)
                ) &&
                (
                    this.MonitoredParticipantId == other.MonitoredParticipantId ||
                    this.MonitoredParticipantId != null &&
                    this.MonitoredParticipantId.Equals(other.MonitoredParticipantId)
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
                    this.MediaBridgeId == other.MediaBridgeId ||
                    this.MediaBridgeId != null &&
                    this.MediaBridgeId.Equals(other.MediaBridgeId)
                ) &&
                (
                    this.ScreenShareAddressSelf == other.ScreenShareAddressSelf ||
                    this.ScreenShareAddressSelf != null &&
                    this.ScreenShareAddressSelf.Equals(other.ScreenShareAddressSelf)
                ) &&
                (
                    this.SharingScreen == other.SharingScreen ||
                    this.SharingScreen != null &&
                    this.SharingScreen.Equals(other.SharingScreen)
                ) &&
                (
                    this.ScreenShareRoomId == other.ScreenShareRoomId ||
                    this.ScreenShareRoomId != null &&
                    this.ScreenShareRoomId.Equals(other.ScreenShareRoomId)
                ) &&
                (
                    this.VideoRoomId == other.VideoRoomId ||
                    this.VideoRoomId != null &&
                    this.VideoRoomId.Equals(other.VideoRoomId)
                ) &&
                (
                    this.VideoAddressSelf == other.VideoAddressSelf ||
                    this.VideoAddressSelf != null &&
                    this.VideoAddressSelf.Equals(other.VideoAddressSelf)
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
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();
                
                if (this.AddressOther != null)
                    hash = hash * 59 + this.AddressOther.GetHashCode();
                
                if (this.AddressSelf != null)
                    hash = hash * 59 + this.AddressSelf.GetHashCode();
                
                if (this.AddressFrom != null)
                    hash = hash * 59 + this.AddressFrom.GetHashCode();
                
                if (this.AddressTo != null)
                    hash = hash * 59 + this.AddressTo.GetHashCode();
                
                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();
                
                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();
                
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                
                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();
                
                if (this.OutboundCampaignId != null)
                    hash = hash * 59 + this.OutboundCampaignId.GetHashCode();
                
                if (this.OutboundContactId != null)
                    hash = hash * 59 + this.OutboundContactId.GetHashCode();
                
                if (this.OutboundContactListId != null)
                    hash = hash * 59 + this.OutboundContactListId.GetHashCode();
                
                if (this.DispositionAnalyzer != null)
                    hash = hash * 59 + this.DispositionAnalyzer.GetHashCode();
                
                if (this.DispositionName != null)
                    hash = hash * 59 + this.DispositionName.GetHashCode();
                
                if (this.EdgeId != null)
                    hash = hash * 59 + this.EdgeId.GetHashCode();
                
                if (this.RemoteNameDisplayable != null)
                    hash = hash * 59 + this.RemoteNameDisplayable.GetHashCode();
                
                if (this.RoomId != null)
                    hash = hash * 59 + this.RoomId.GetHashCode();
                
                if (this.MonitoredSessionId != null)
                    hash = hash * 59 + this.MonitoredSessionId.GetHashCode();
                
                if (this.MonitoredParticipantId != null)
                    hash = hash * 59 + this.MonitoredParticipantId.GetHashCode();
                
                if (this.CallbackUserName != null)
                    hash = hash * 59 + this.CallbackUserName.GetHashCode();
                
                if (this.CallbackNumbers != null)
                    hash = hash * 59 + this.CallbackNumbers.GetHashCode();
                
                if (this.CallbackScheduledTime != null)
                    hash = hash * 59 + this.CallbackScheduledTime.GetHashCode();
                
                if (this.ScriptId != null)
                    hash = hash * 59 + this.ScriptId.GetHashCode();
                
                if (this.PeerId != null)
                    hash = hash * 59 + this.PeerId.GetHashCode();
                
                if (this.SkipEnabled != null)
                    hash = hash * 59 + this.SkipEnabled.GetHashCode();
                
                if (this.TimeoutSeconds != null)
                    hash = hash * 59 + this.TimeoutSeconds.GetHashCode();
                
                if (this.CobrowseRole != null)
                    hash = hash * 59 + this.CobrowseRole.GetHashCode();
                
                if (this.CobrowseRoomId != null)
                    hash = hash * 59 + this.CobrowseRoomId.GetHashCode();
                
                if (this.MediaBridgeId != null)
                    hash = hash * 59 + this.MediaBridgeId.GetHashCode();
                
                if (this.ScreenShareAddressSelf != null)
                    hash = hash * 59 + this.ScreenShareAddressSelf.GetHashCode();
                
                if (this.SharingScreen != null)
                    hash = hash * 59 + this.SharingScreen.GetHashCode();
                
                if (this.ScreenShareRoomId != null)
                    hash = hash * 59 + this.ScreenShareRoomId.GetHashCode();
                
                if (this.VideoRoomId != null)
                    hash = hash * 59 + this.VideoRoomId.GetHashCode();
                
                if (this.VideoAddressSelf != null)
                    hash = hash * 59 + this.VideoAddressSelf.GetHashCode();
                
                if (this.Segments != null)
                    hash = hash * 59 + this.Segments.GetHashCode();
                
                return hash;
            }
        }
    }

}
