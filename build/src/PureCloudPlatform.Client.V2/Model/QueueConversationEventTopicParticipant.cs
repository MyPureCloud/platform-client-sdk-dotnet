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
    /// QueueConversationEventTopicParticipant
    /// </summary>
    [DataContract]
    public partial class QueueConversationEventTopicParticipant :  IEquatable<QueueConversationEventTopicParticipant>
    {
        /// <summary>
        /// The current screen recording state for this participant.
        /// </summary>
        /// <value>The current screen recording state for this participant.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ScreenRecordingStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Requested for "requested"
            /// </summary>
            [EnumMember(Value = "requested")]
            Requested,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Paused for "paused"
            /// </summary>
            [EnumMember(Value = "paused")]
            Paused,
            
            /// <summary>
            /// Enum Stopped for "stopped"
            /// </summary>
            [EnumMember(Value = "stopped")]
            Stopped,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error,
            
            /// <summary>
            /// Enum Timeout for "timeout"
            /// </summary>
            [EnumMember(Value = "timeout")]
            Timeout
        }
        /// <summary>
        /// The current screen recording state for this participant.
        /// </summary>
        /// <value>The current screen recording state for this participant.</value>
        [DataMember(Name="screenRecordingState", EmitDefaultValue=false)]
        public ScreenRecordingStateEnum? ScreenRecordingState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationEventTopicParticipant" /> class.
        /// </summary>
        /// <param name="Id">A globally unique identifier for this conversation..</param>
        /// <param name="ConnectedTime">The timestamp when this participant was connected to the conversation in the provider clock..</param>
        /// <param name="EndTime">The timestamp when this participant disconnected from the conversation in the provider clock..</param>
        /// <param name="UserId">If this participant represents a user, then this will be the globally unique identifier for the user..</param>
        /// <param name="ExternalContactId">If this participant represents an external contact, then this will be the globally unique identifier for the external contact..</param>
        /// <param name="ExternalContactInitialDivisionId">If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned..</param>
        /// <param name="ExternalOrganizationId">If this participant represents an external org, then this will be the globally unique identifier for the external org..</param>
        /// <param name="Name">A human readable name identifying the participant..</param>
        /// <param name="QueueId">If present, the queue id that the communication channel came in on..</param>
        /// <param name="GroupId">If present, the group id that the participant represents..</param>
        /// <param name="TeamId">The team id that this participant is a member of when added to the conversation..</param>
        /// <param name="Purpose">A well known string that specifies the purpose or type of this participant..</param>
        /// <param name="ConsultParticipantId">If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred..</param>
        /// <param name="Address">The address for the this participant. For a phone call this will be the ANI..</param>
        /// <param name="WrapupRequired">True iff this participant is required to enter wrapup for this conversation..</param>
        /// <param name="WrapupExpected">True when a participant is expected to enter a wrapup code once the call connects..</param>
        /// <param name="WrapupPrompt">This field controls how the UI prompts the agent for a wrapup..</param>
        /// <param name="WrapupTimeoutMs">Specifies how long a timed ACW session will last..</param>
        /// <param name="Wrapup">Wrapup.</param>
        /// <param name="StartAcwTime">The timestamp when this participant started after-call work..</param>
        /// <param name="EndAcwTime">The timestamp when this participant ended after-call work..</param>
        /// <param name="ConversationRoutingData">ConversationRoutingData.</param>
        /// <param name="AlertingTimeoutMs">Specifies how long the agent has to answer an interaction before being marked as not responding..</param>
        /// <param name="MonitoredParticipantId">If this participant is a monitor, then this will be the id of the participant that is being monitored..</param>
        /// <param name="CoachedParticipantId">If this participant is a coach, then this will be the id of the participant that is being coached..</param>
        /// <param name="BargedParticipantId">If this participant created a barge in conference, then this will be the id of the participant that is barged in..</param>
        /// <param name="MediaRoles">List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc..</param>
        /// <param name="ScreenRecordingState">The current screen recording state for this participant..</param>
        /// <param name="FlaggedReason">If this participant has flagged the conversation, the reason code given..</param>
        /// <param name="Attributes">Additional participant attributes.</param>
        /// <param name="Calls">Calls.</param>
        /// <param name="Callbacks">Callbacks.</param>
        /// <param name="Chats">Chats.</param>
        /// <param name="Cobrowsesessions">Cobrowsesessions.</param>
        /// <param name="Emails">Emails.</param>
        /// <param name="Messages">Messages.</param>
        /// <param name="InternalMessages">InternalMessages.</param>
        /// <param name="ScreenMonitorings">ScreenMonitorings.</param>
        /// <param name="Screenshares">Screenshares.</param>
        /// <param name="SocialExpressions">SocialExpressions.</param>
        /// <param name="Videos">Videos.</param>
        /// <param name="Workflow">Workflow.</param>
        public QueueConversationEventTopicParticipant(string Id = null, DateTime? ConnectedTime = null, DateTime? EndTime = null, string UserId = null, string ExternalContactId = null, string ExternalContactInitialDivisionId = null, string ExternalOrganizationId = null, string Name = null, string QueueId = null, string GroupId = null, string TeamId = null, string Purpose = null, string ConsultParticipantId = null, string Address = null, bool? WrapupRequired = null, bool? WrapupExpected = null, string WrapupPrompt = null, long? WrapupTimeoutMs = null, QueueConversationEventTopicWrapup Wrapup = null, DateTime? StartAcwTime = null, DateTime? EndAcwTime = null, QueueConversationEventTopicConversationRoutingData ConversationRoutingData = null, long? AlertingTimeoutMs = null, string MonitoredParticipantId = null, string CoachedParticipantId = null, string BargedParticipantId = null, List<string> MediaRoles = null, ScreenRecordingStateEnum? ScreenRecordingState = null, string FlaggedReason = null, Dictionary<string, string> Attributes = null, List<QueueConversationEventTopicCall> Calls = null, List<QueueConversationEventTopicCallback> Callbacks = null, List<QueueConversationEventTopicChat> Chats = null, List<QueueConversationEventTopicCobrowse> Cobrowsesessions = null, List<QueueConversationEventTopicEmail> Emails = null, List<QueueConversationEventTopicMessage> Messages = null, List<QueueConversationEventTopicInternalMessage> InternalMessages = null, List<QueueConversationEventTopicScreenMonitoring> ScreenMonitorings = null, List<QueueConversationEventTopicScreenShare> Screenshares = null, List<QueueConversationEventTopicSocialExpression> SocialExpressions = null, List<QueueConversationEventTopicVideo> Videos = null, QueueConversationEventTopicWorkflow Workflow = null)
        {
            this.Id = Id;
            this.ConnectedTime = ConnectedTime;
            this.EndTime = EndTime;
            this.UserId = UserId;
            this.ExternalContactId = ExternalContactId;
            this.ExternalContactInitialDivisionId = ExternalContactInitialDivisionId;
            this.ExternalOrganizationId = ExternalOrganizationId;
            this.Name = Name;
            this.QueueId = QueueId;
            this.GroupId = GroupId;
            this.TeamId = TeamId;
            this.Purpose = Purpose;
            this.ConsultParticipantId = ConsultParticipantId;
            this.Address = Address;
            this.WrapupRequired = WrapupRequired;
            this.WrapupExpected = WrapupExpected;
            this.WrapupPrompt = WrapupPrompt;
            this.WrapupTimeoutMs = WrapupTimeoutMs;
            this.Wrapup = Wrapup;
            this.StartAcwTime = StartAcwTime;
            this.EndAcwTime = EndAcwTime;
            this.ConversationRoutingData = ConversationRoutingData;
            this.AlertingTimeoutMs = AlertingTimeoutMs;
            this.MonitoredParticipantId = MonitoredParticipantId;
            this.CoachedParticipantId = CoachedParticipantId;
            this.BargedParticipantId = BargedParticipantId;
            this.MediaRoles = MediaRoles;
            this.ScreenRecordingState = ScreenRecordingState;
            this.FlaggedReason = FlaggedReason;
            this.Attributes = Attributes;
            this.Calls = Calls;
            this.Callbacks = Callbacks;
            this.Chats = Chats;
            this.Cobrowsesessions = Cobrowsesessions;
            this.Emails = Emails;
            this.Messages = Messages;
            this.InternalMessages = InternalMessages;
            this.ScreenMonitorings = ScreenMonitorings;
            this.Screenshares = Screenshares;
            this.SocialExpressions = SocialExpressions;
            this.Videos = Videos;
            this.Workflow = Workflow;
            
        }
        


        /// <summary>
        /// A globally unique identifier for this conversation.
        /// </summary>
        /// <value>A globally unique identifier for this conversation.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The timestamp when this participant was connected to the conversation in the provider clock.
        /// </summary>
        /// <value>The timestamp when this participant was connected to the conversation in the provider clock.</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }



        /// <summary>
        /// The timestamp when this participant disconnected from the conversation in the provider clock.
        /// </summary>
        /// <value>The timestamp when this participant disconnected from the conversation in the provider clock.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }



        /// <summary>
        /// If this participant represents a user, then this will be the globally unique identifier for the user.
        /// </summary>
        /// <value>If this participant represents a user, then this will be the globally unique identifier for the user.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// If this participant represents an external contact, then this will be the globally unique identifier for the external contact.
        /// </summary>
        /// <value>If this participant represents an external contact, then this will be the globally unique identifier for the external contact.</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }



        /// <summary>
        /// If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned.
        /// </summary>
        /// <value>If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned.</value>
        [DataMember(Name="externalContactInitialDivisionId", EmitDefaultValue=false)]
        public string ExternalContactInitialDivisionId { get; set; }



        /// <summary>
        /// If this participant represents an external org, then this will be the globally unique identifier for the external org.
        /// </summary>
        /// <value>If this participant represents an external org, then this will be the globally unique identifier for the external org.</value>
        [DataMember(Name="externalOrganizationId", EmitDefaultValue=false)]
        public string ExternalOrganizationId { get; set; }



        /// <summary>
        /// A human readable name identifying the participant.
        /// </summary>
        /// <value>A human readable name identifying the participant.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// If present, the queue id that the communication channel came in on.
        /// </summary>
        /// <value>If present, the queue id that the communication channel came in on.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// If present, the group id that the participant represents.
        /// </summary>
        /// <value>If present, the group id that the participant represents.</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }



        /// <summary>
        /// The team id that this participant is a member of when added to the conversation.
        /// </summary>
        /// <value>The team id that this participant is a member of when added to the conversation.</value>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }



        /// <summary>
        /// A well known string that specifies the purpose or type of this participant.
        /// </summary>
        /// <value>A well known string that specifies the purpose or type of this participant.</value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }



        /// <summary>
        /// If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred.
        /// </summary>
        /// <value>If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred.</value>
        [DataMember(Name="consultParticipantId", EmitDefaultValue=false)]
        public string ConsultParticipantId { get; set; }



        /// <summary>
        /// The address for the this participant. For a phone call this will be the ANI.
        /// </summary>
        /// <value>The address for the this participant. For a phone call this will be the ANI.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }



        /// <summary>
        /// True iff this participant is required to enter wrapup for this conversation.
        /// </summary>
        /// <value>True iff this participant is required to enter wrapup for this conversation.</value>
        [DataMember(Name="wrapupRequired", EmitDefaultValue=false)]
        public bool? WrapupRequired { get; set; }



        /// <summary>
        /// True when a participant is expected to enter a wrapup code once the call connects.
        /// </summary>
        /// <value>True when a participant is expected to enter a wrapup code once the call connects.</value>
        [DataMember(Name="wrapupExpected", EmitDefaultValue=false)]
        public bool? WrapupExpected { get; set; }



        /// <summary>
        /// This field controls how the UI prompts the agent for a wrapup.
        /// </summary>
        /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
        [DataMember(Name="wrapupPrompt", EmitDefaultValue=false)]
        public string WrapupPrompt { get; set; }



        /// <summary>
        /// Specifies how long a timed ACW session will last.
        /// </summary>
        /// <value>Specifies how long a timed ACW session will last.</value>
        [DataMember(Name="wrapupTimeoutMs", EmitDefaultValue=false)]
        public long? WrapupTimeoutMs { get; set; }



        /// <summary>
        /// Gets or Sets Wrapup
        /// </summary>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public QueueConversationEventTopicWrapup Wrapup { get; set; }



        /// <summary>
        /// The timestamp when this participant started after-call work.
        /// </summary>
        /// <value>The timestamp when this participant started after-call work.</value>
        [DataMember(Name="startAcwTime", EmitDefaultValue=false)]
        public DateTime? StartAcwTime { get; set; }



        /// <summary>
        /// The timestamp when this participant ended after-call work.
        /// </summary>
        /// <value>The timestamp when this participant ended after-call work.</value>
        [DataMember(Name="endAcwTime", EmitDefaultValue=false)]
        public DateTime? EndAcwTime { get; set; }



        /// <summary>
        /// Gets or Sets ConversationRoutingData
        /// </summary>
        [DataMember(Name="conversationRoutingData", EmitDefaultValue=false)]
        public QueueConversationEventTopicConversationRoutingData ConversationRoutingData { get; set; }



        /// <summary>
        /// Specifies how long the agent has to answer an interaction before being marked as not responding.
        /// </summary>
        /// <value>Specifies how long the agent has to answer an interaction before being marked as not responding.</value>
        [DataMember(Name="alertingTimeoutMs", EmitDefaultValue=false)]
        public long? AlertingTimeoutMs { get; set; }



        /// <summary>
        /// If this participant is a monitor, then this will be the id of the participant that is being monitored.
        /// </summary>
        /// <value>If this participant is a monitor, then this will be the id of the participant that is being monitored.</value>
        [DataMember(Name="monitoredParticipantId", EmitDefaultValue=false)]
        public string MonitoredParticipantId { get; set; }



        /// <summary>
        /// If this participant is a coach, then this will be the id of the participant that is being coached.
        /// </summary>
        /// <value>If this participant is a coach, then this will be the id of the participant that is being coached.</value>
        [DataMember(Name="coachedParticipantId", EmitDefaultValue=false)]
        public string CoachedParticipantId { get; set; }



        /// <summary>
        /// If this participant created a barge in conference, then this will be the id of the participant that is barged in.
        /// </summary>
        /// <value>If this participant created a barge in conference, then this will be the id of the participant that is barged in.</value>
        [DataMember(Name="bargedParticipantId", EmitDefaultValue=false)]
        public string BargedParticipantId { get; set; }



        /// <summary>
        /// List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.
        /// </summary>
        /// <value>List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.</value>
        [DataMember(Name="mediaRoles", EmitDefaultValue=false)]
        public List<string> MediaRoles { get; set; }





        /// <summary>
        /// If this participant has flagged the conversation, the reason code given.
        /// </summary>
        /// <value>If this participant has flagged the conversation, the reason code given.</value>
        [DataMember(Name="flaggedReason", EmitDefaultValue=false)]
        public string FlaggedReason { get; set; }



        /// <summary>
        /// Additional participant attributes
        /// </summary>
        /// <value>Additional participant attributes</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }



        /// <summary>
        /// Gets or Sets Calls
        /// </summary>
        [DataMember(Name="calls", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicCall> Calls { get; set; }



        /// <summary>
        /// Gets or Sets Callbacks
        /// </summary>
        [DataMember(Name="callbacks", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicCallback> Callbacks { get; set; }



        /// <summary>
        /// Gets or Sets Chats
        /// </summary>
        [DataMember(Name="chats", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicChat> Chats { get; set; }



        /// <summary>
        /// Gets or Sets Cobrowsesessions
        /// </summary>
        [DataMember(Name="cobrowsesessions", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicCobrowse> Cobrowsesessions { get; set; }



        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicEmail> Emails { get; set; }



        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicMessage> Messages { get; set; }



        /// <summary>
        /// Gets or Sets InternalMessages
        /// </summary>
        [DataMember(Name="internalMessages", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicInternalMessage> InternalMessages { get; set; }



        /// <summary>
        /// Gets or Sets ScreenMonitorings
        /// </summary>
        [DataMember(Name="screenMonitorings", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicScreenMonitoring> ScreenMonitorings { get; set; }



        /// <summary>
        /// Gets or Sets Screenshares
        /// </summary>
        [DataMember(Name="screenshares", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicScreenShare> Screenshares { get; set; }



        /// <summary>
        /// Gets or Sets SocialExpressions
        /// </summary>
        [DataMember(Name="socialExpressions", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicSocialExpression> SocialExpressions { get; set; }



        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name="videos", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicVideo> Videos { get; set; }



        /// <summary>
        /// Gets or Sets Workflow
        /// </summary>
        [DataMember(Name="workflow", EmitDefaultValue=false)]
        public QueueConversationEventTopicWorkflow Workflow { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationEventTopicParticipant {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  ExternalContactInitialDivisionId: ").Append(ExternalContactInitialDivisionId).Append("\n");
            sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  ConsultParticipantId: ").Append(ConsultParticipantId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
            sb.Append("  WrapupExpected: ").Append(WrapupExpected).Append("\n");
            sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
            sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
            sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
            sb.Append("  StartAcwTime: ").Append(StartAcwTime).Append("\n");
            sb.Append("  EndAcwTime: ").Append(EndAcwTime).Append("\n");
            sb.Append("  ConversationRoutingData: ").Append(ConversationRoutingData).Append("\n");
            sb.Append("  AlertingTimeoutMs: ").Append(AlertingTimeoutMs).Append("\n");
            sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
            sb.Append("  CoachedParticipantId: ").Append(CoachedParticipantId).Append("\n");
            sb.Append("  BargedParticipantId: ").Append(BargedParticipantId).Append("\n");
            sb.Append("  MediaRoles: ").Append(MediaRoles).Append("\n");
            sb.Append("  ScreenRecordingState: ").Append(ScreenRecordingState).Append("\n");
            sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Calls: ").Append(Calls).Append("\n");
            sb.Append("  Callbacks: ").Append(Callbacks).Append("\n");
            sb.Append("  Chats: ").Append(Chats).Append("\n");
            sb.Append("  Cobrowsesessions: ").Append(Cobrowsesessions).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  InternalMessages: ").Append(InternalMessages).Append("\n");
            sb.Append("  ScreenMonitorings: ").Append(ScreenMonitorings).Append("\n");
            sb.Append("  Screenshares: ").Append(Screenshares).Append("\n");
            sb.Append("  SocialExpressions: ").Append(SocialExpressions).Append("\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");
            sb.Append("  Workflow: ").Append(Workflow).Append("\n");
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
            return this.Equals(obj as QueueConversationEventTopicParticipant);
        }

        /// <summary>
        /// Returns true if QueueConversationEventTopicParticipant instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationEventTopicParticipant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationEventTopicParticipant other)
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
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.ExternalContactInitialDivisionId == other.ExternalContactInitialDivisionId ||
                    this.ExternalContactInitialDivisionId != null &&
                    this.ExternalContactInitialDivisionId.Equals(other.ExternalContactInitialDivisionId)
                ) &&
                (
                    this.ExternalOrganizationId == other.ExternalOrganizationId ||
                    this.ExternalOrganizationId != null &&
                    this.ExternalOrganizationId.Equals(other.ExternalOrganizationId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) &&
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.ConsultParticipantId == other.ConsultParticipantId ||
                    this.ConsultParticipantId != null &&
                    this.ConsultParticipantId.Equals(other.ConsultParticipantId)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.WrapupRequired == other.WrapupRequired ||
                    this.WrapupRequired != null &&
                    this.WrapupRequired.Equals(other.WrapupRequired)
                ) &&
                (
                    this.WrapupExpected == other.WrapupExpected ||
                    this.WrapupExpected != null &&
                    this.WrapupExpected.Equals(other.WrapupExpected)
                ) &&
                (
                    this.WrapupPrompt == other.WrapupPrompt ||
                    this.WrapupPrompt != null &&
                    this.WrapupPrompt.Equals(other.WrapupPrompt)
                ) &&
                (
                    this.WrapupTimeoutMs == other.WrapupTimeoutMs ||
                    this.WrapupTimeoutMs != null &&
                    this.WrapupTimeoutMs.Equals(other.WrapupTimeoutMs)
                ) &&
                (
                    this.Wrapup == other.Wrapup ||
                    this.Wrapup != null &&
                    this.Wrapup.Equals(other.Wrapup)
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
                    this.ConversationRoutingData == other.ConversationRoutingData ||
                    this.ConversationRoutingData != null &&
                    this.ConversationRoutingData.Equals(other.ConversationRoutingData)
                ) &&
                (
                    this.AlertingTimeoutMs == other.AlertingTimeoutMs ||
                    this.AlertingTimeoutMs != null &&
                    this.AlertingTimeoutMs.Equals(other.AlertingTimeoutMs)
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
                    this.MediaRoles == other.MediaRoles ||
                    this.MediaRoles != null &&
                    this.MediaRoles.SequenceEqual(other.MediaRoles)
                ) &&
                (
                    this.ScreenRecordingState == other.ScreenRecordingState ||
                    this.ScreenRecordingState != null &&
                    this.ScreenRecordingState.Equals(other.ScreenRecordingState)
                ) &&
                (
                    this.FlaggedReason == other.FlaggedReason ||
                    this.FlaggedReason != null &&
                    this.FlaggedReason.Equals(other.FlaggedReason)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.Calls == other.Calls ||
                    this.Calls != null &&
                    this.Calls.SequenceEqual(other.Calls)
                ) &&
                (
                    this.Callbacks == other.Callbacks ||
                    this.Callbacks != null &&
                    this.Callbacks.SequenceEqual(other.Callbacks)
                ) &&
                (
                    this.Chats == other.Chats ||
                    this.Chats != null &&
                    this.Chats.SequenceEqual(other.Chats)
                ) &&
                (
                    this.Cobrowsesessions == other.Cobrowsesessions ||
                    this.Cobrowsesessions != null &&
                    this.Cobrowsesessions.SequenceEqual(other.Cobrowsesessions)
                ) &&
                (
                    this.Emails == other.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(other.Emails)
                ) &&
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
                ) &&
                (
                    this.InternalMessages == other.InternalMessages ||
                    this.InternalMessages != null &&
                    this.InternalMessages.SequenceEqual(other.InternalMessages)
                ) &&
                (
                    this.ScreenMonitorings == other.ScreenMonitorings ||
                    this.ScreenMonitorings != null &&
                    this.ScreenMonitorings.SequenceEqual(other.ScreenMonitorings)
                ) &&
                (
                    this.Screenshares == other.Screenshares ||
                    this.Screenshares != null &&
                    this.Screenshares.SequenceEqual(other.Screenshares)
                ) &&
                (
                    this.SocialExpressions == other.SocialExpressions ||
                    this.SocialExpressions != null &&
                    this.SocialExpressions.SequenceEqual(other.SocialExpressions)
                ) &&
                (
                    this.Videos == other.Videos ||
                    this.Videos != null &&
                    this.Videos.SequenceEqual(other.Videos)
                ) &&
                (
                    this.Workflow == other.Workflow ||
                    this.Workflow != null &&
                    this.Workflow.Equals(other.Workflow)
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

                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();

                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                if (this.ExternalContactInitialDivisionId != null)
                    hash = hash * 59 + this.ExternalContactInitialDivisionId.GetHashCode();

                if (this.ExternalOrganizationId != null)
                    hash = hash * 59 + this.ExternalOrganizationId.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();

                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();

                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();

                if (this.ConsultParticipantId != null)
                    hash = hash * 59 + this.ConsultParticipantId.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                if (this.WrapupRequired != null)
                    hash = hash * 59 + this.WrapupRequired.GetHashCode();

                if (this.WrapupExpected != null)
                    hash = hash * 59 + this.WrapupExpected.GetHashCode();

                if (this.WrapupPrompt != null)
                    hash = hash * 59 + this.WrapupPrompt.GetHashCode();

                if (this.WrapupTimeoutMs != null)
                    hash = hash * 59 + this.WrapupTimeoutMs.GetHashCode();

                if (this.Wrapup != null)
                    hash = hash * 59 + this.Wrapup.GetHashCode();

                if (this.StartAcwTime != null)
                    hash = hash * 59 + this.StartAcwTime.GetHashCode();

                if (this.EndAcwTime != null)
                    hash = hash * 59 + this.EndAcwTime.GetHashCode();

                if (this.ConversationRoutingData != null)
                    hash = hash * 59 + this.ConversationRoutingData.GetHashCode();

                if (this.AlertingTimeoutMs != null)
                    hash = hash * 59 + this.AlertingTimeoutMs.GetHashCode();

                if (this.MonitoredParticipantId != null)
                    hash = hash * 59 + this.MonitoredParticipantId.GetHashCode();

                if (this.CoachedParticipantId != null)
                    hash = hash * 59 + this.CoachedParticipantId.GetHashCode();

                if (this.BargedParticipantId != null)
                    hash = hash * 59 + this.BargedParticipantId.GetHashCode();

                if (this.MediaRoles != null)
                    hash = hash * 59 + this.MediaRoles.GetHashCode();

                if (this.ScreenRecordingState != null)
                    hash = hash * 59 + this.ScreenRecordingState.GetHashCode();

                if (this.FlaggedReason != null)
                    hash = hash * 59 + this.FlaggedReason.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.Calls != null)
                    hash = hash * 59 + this.Calls.GetHashCode();

                if (this.Callbacks != null)
                    hash = hash * 59 + this.Callbacks.GetHashCode();

                if (this.Chats != null)
                    hash = hash * 59 + this.Chats.GetHashCode();

                if (this.Cobrowsesessions != null)
                    hash = hash * 59 + this.Cobrowsesessions.GetHashCode();

                if (this.Emails != null)
                    hash = hash * 59 + this.Emails.GetHashCode();

                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();

                if (this.InternalMessages != null)
                    hash = hash * 59 + this.InternalMessages.GetHashCode();

                if (this.ScreenMonitorings != null)
                    hash = hash * 59 + this.ScreenMonitorings.GetHashCode();

                if (this.Screenshares != null)
                    hash = hash * 59 + this.Screenshares.GetHashCode();

                if (this.SocialExpressions != null)
                    hash = hash * 59 + this.SocialExpressions.GetHashCode();

                if (this.Videos != null)
                    hash = hash * 59 + this.Videos.GetHashCode();

                if (this.Workflow != null)
                    hash = hash * 59 + this.Workflow.GetHashCode();

                return hash;
            }
        }
    }

}
