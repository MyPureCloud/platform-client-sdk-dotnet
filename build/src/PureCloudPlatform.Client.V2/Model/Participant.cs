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
    /// Participant
    /// </summary>
    [DataContract]
    public partial class Participant :  IEquatable<Participant>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// This field controls how the UI prompts the agent for a wrapup.
        /// </summary>
        /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum WrapupPromptEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Mandatory for "mandatory"
            /// </summary>
            [EnumMember(Value = "mandatory")]
            Mandatory,
            
            /// <summary>
            /// Enum Optional for "optional"
            /// </summary>
            [EnumMember(Value = "optional")]
            Optional,
            
            /// <summary>
            /// Enum Timeout for "timeout"
            /// </summary>
            [EnumMember(Value = "timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Forcedtimeout for "forcedTimeout"
            /// </summary>
            [EnumMember(Value = "forcedTimeout")]
            Forcedtimeout
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
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
        /// This field controls how the UI prompts the agent for a wrapup.
        /// </summary>
        /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
        [DataMember(Name="wrapupPrompt", EmitDefaultValue=false)]
        public WrapupPromptEnum? WrapupPrompt { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The current screen recording state for this participant.
        /// </summary>
        /// <value>The current screen recording state for this participant.</value>
        [DataMember(Name="screenRecordingState", EmitDefaultValue=false)]
        public ScreenRecordingStateEnum? ScreenRecordingState { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Participant" /> class.
        /// </summary>
        
        
        /// <param name="Id">A globally unique identifier for this conversation..</param>
        
        
        
        /// <param name="StartTime">The timestamp when this participant joined the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="EndTime">The timestamp when this participant disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="ConnectedTime">The timestamp when this participant was connected to the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="Name">A human readable name identifying the participant..</param>
        
        
        
        /// <param name="UserUri">If this participant represents a user, then this will be an URI that can be used to fetch the user..</param>
        
        
        
        /// <param name="UserId">If this participant represents a user, then this will be the globally unique identifier for the user..</param>
        
        
        
        /// <param name="ExternalContactId">If this participant represents an external contact, then this will be the globally unique identifier for the external contact..</param>
        
        
        
        /// <param name="ExternalOrganizationId">If this participant represents an external org, then this will be the globally unique identifier for the external org..</param>
        
        
        
        /// <param name="QueueId">If present, the queue id that the communication channel came in on..</param>
        
        
        
        /// <param name="GroupId">If present, group of users the participant represents..</param>
        
        
        
        /// <param name="QueueName">If present, the queue name that the communication channel came in on..</param>
        
        
        
        /// <param name="Purpose">A well known string that specifies the purpose of this participant..</param>
        
        
        
        /// <param name="ParticipantType">A well known string that specifies the type of this participant..</param>
        
        
        
        /// <param name="ConsultParticipantId">If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred..</param>
        
        
        
        /// <param name="Address">The address for the this participant. For a phone call this will be the ANI..</param>
        
        
        
        /// <param name="Ani">The address for the this participant. For a phone call this will be the ANI..</param>
        
        
        
        /// <param name="AniName">The ani-based name for this participant..</param>
        
        
        
        /// <param name="Dnis">The address for the this participant. For a phone call this will be the ANI..</param>
        
        
        
        /// <param name="Locale">An ISO 639 language code specifying the locale for this participant.</param>
        
        
        
        /// <param name="WrapupRequired">True iff this participant is required to enter wrapup for this conversation..</param>
        
        
        
        /// <param name="WrapupPrompt">This field controls how the UI prompts the agent for a wrapup..</param>
        
        
        
        /// <param name="WrapupTimeoutMs">Specifies how long a timed ACW session will last..</param>
        
        
        
        /// <param name="WrapupSkipped">The UI sets this field when the agent chooses to skip entering a wrapup for this participant..</param>
        
        
        
        /// <param name="Wrapup">Call wrap up or disposition data..</param>
        
        
        
        /// <param name="MonitoredParticipantId">If this participant is a monitor, then this will be the id of the participant that is being monitored..</param>
        
        
        
        /// <param name="Attributes">Additional participant attributes.</param>
        
        
        
        /// <param name="Calls">Calls.</param>
        
        
        
        /// <param name="Callbacks">Callbacks.</param>
        
        
        
        /// <param name="Chats">Chats.</param>
        
        
        
        /// <param name="Cobrowsesessions">Cobrowsesessions.</param>
        
        
        
        /// <param name="Emails">Emails.</param>
        
        
        
        /// <param name="Messages">Messages.</param>
        
        
        
        /// <param name="Screenshares">Screenshares.</param>
        
        
        
        /// <param name="SocialExpressions">SocialExpressions.</param>
        
        
        
        /// <param name="Videos">Videos.</param>
        
        
        
        /// <param name="Evaluations">Evaluations.</param>
        
        
        
        /// <param name="ScreenRecordingState">The current screen recording state for this participant..</param>
        
        
        public Participant(string Id = null, DateTime? StartTime = null, DateTime? EndTime = null, DateTime? ConnectedTime = null, string Name = null, string UserUri = null, string UserId = null, string ExternalContactId = null, string ExternalOrganizationId = null, string QueueId = null, string GroupId = null, string QueueName = null, string Purpose = null, string ParticipantType = null, string ConsultParticipantId = null, string Address = null, string Ani = null, string AniName = null, string Dnis = null, string Locale = null, bool? WrapupRequired = null, WrapupPromptEnum? WrapupPrompt = null, int? WrapupTimeoutMs = null, bool? WrapupSkipped = null, Wrapup Wrapup = null, string MonitoredParticipantId = null, Dictionary<string, string> Attributes = null, List<Call> Calls = null, List<Callback> Callbacks = null, List<ConversationChat> Chats = null, List<Cobrowsesession> Cobrowsesessions = null, List<Email> Emails = null, List<Message> Messages = null, List<Screenshare> Screenshares = null, List<SocialExpression> SocialExpressions = null, List<Video> Videos = null, List<Evaluation> Evaluations = null, ScreenRecordingStateEnum? ScreenRecordingState = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.StartTime = StartTime;
            
            
            
            
            
            
            
            
this.EndTime = EndTime;
            
            
            
            
            
            
            
            
this.ConnectedTime = ConnectedTime;
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.UserUri = UserUri;
            
            
            
            
            
            
            
            
this.UserId = UserId;
            
            
            
            
            
            
            
            
this.ExternalContactId = ExternalContactId;
            
            
            
            
            
            
            
            
this.ExternalOrganizationId = ExternalOrganizationId;
            
            
            
            
            
            
            
            
this.QueueId = QueueId;
            
            
            
            
            
            
            
            
this.GroupId = GroupId;
            
            
            
            
            
            
            
            
this.QueueName = QueueName;
            
            
            
            
            
            
            
            
this.Purpose = Purpose;
            
            
            
            
            
            
            
            
this.ParticipantType = ParticipantType;
            
            
            
            
            
            
            
            
this.ConsultParticipantId = ConsultParticipantId;
            
            
            
            
            
            
            
            
this.Address = Address;
            
            
            
            
            
            
            
            
this.Ani = Ani;
            
            
            
            
            
            
            
            
this.AniName = AniName;
            
            
            
            
            
            
            
            
this.Dnis = Dnis;
            
            
            
            
            
            
            
            
this.Locale = Locale;
            
            
            
            
            
            
            
            
this.WrapupRequired = WrapupRequired;
            
            
            
            
            
            
            
            
this.WrapupPrompt = WrapupPrompt;
            
            
            
            
            
            
            
            
this.WrapupTimeoutMs = WrapupTimeoutMs;
            
            
            
            
            
            
            
            
this.WrapupSkipped = WrapupSkipped;
            
            
            
            
            
            
            
            
this.Wrapup = Wrapup;
            
            
            
            
            
            
            
            
this.MonitoredParticipantId = MonitoredParticipantId;
            
            
            
            
            
            
            
            
this.Attributes = Attributes;
            
            
            
            
            
            
            
            
this.Calls = Calls;
            
            
            
            
            
            
            
            
this.Callbacks = Callbacks;
            
            
            
            
            
            
            
            
this.Chats = Chats;
            
            
            
            
            
            
            
            
this.Cobrowsesessions = Cobrowsesessions;
            
            
            
            
            
            
            
            
this.Emails = Emails;
            
            
            
            
            
            
            
            
this.Messages = Messages;
            
            
            
            
            
            
            
            
this.Screenshares = Screenshares;
            
            
            
            
            
            
            
            
this.SocialExpressions = SocialExpressions;
            
            
            
            
            
            
            
            
this.Videos = Videos;
            
            
            
            
            
            
            
            
this.Evaluations = Evaluations;
            
            
            
            
            
            
            
            
this.ScreenRecordingState = ScreenRecordingState;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// A globally unique identifier for this conversation.
        /// </summary>
        /// <value>A globally unique identifier for this conversation.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The timestamp when this participant joined the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this participant joined the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
        
        
        
        /// <summary>
        /// The timestamp when this participant disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this participant disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }
        
        
        
        /// <summary>
        /// The timestamp when this participant was connected to the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this participant was connected to the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }
        
        
        
        /// <summary>
        /// A human readable name identifying the participant.
        /// </summary>
        /// <value>A human readable name identifying the participant.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// If this participant represents a user, then this will be an URI that can be used to fetch the user.
        /// </summary>
        /// <value>If this participant represents a user, then this will be an URI that can be used to fetch the user.</value>
        [DataMember(Name="userUri", EmitDefaultValue=false)]
        public string UserUri { get; set; }
        
        
        
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
        /// If this participant represents an external org, then this will be the globally unique identifier for the external org.
        /// </summary>
        /// <value>If this participant represents an external org, then this will be the globally unique identifier for the external org.</value>
        [DataMember(Name="externalOrganizationId", EmitDefaultValue=false)]
        public string ExternalOrganizationId { get; set; }
        
        
        
        /// <summary>
        /// If present, the queue id that the communication channel came in on.
        /// </summary>
        /// <value>If present, the queue id that the communication channel came in on.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        /// <summary>
        /// If present, group of users the participant represents.
        /// </summary>
        /// <value>If present, group of users the participant represents.</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }
        
        
        
        /// <summary>
        /// If present, the queue name that the communication channel came in on.
        /// </summary>
        /// <value>If present, the queue name that the communication channel came in on.</value>
        [DataMember(Name="queueName", EmitDefaultValue=false)]
        public string QueueName { get; set; }
        
        
        
        /// <summary>
        /// A well known string that specifies the purpose of this participant.
        /// </summary>
        /// <value>A well known string that specifies the purpose of this participant.</value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }
        
        
        
        /// <summary>
        /// A well known string that specifies the type of this participant.
        /// </summary>
        /// <value>A well known string that specifies the type of this participant.</value>
        [DataMember(Name="participantType", EmitDefaultValue=false)]
        public string ParticipantType { get; set; }
        
        
        
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
        /// The address for the this participant. For a phone call this will be the ANI.
        /// </summary>
        /// <value>The address for the this participant. For a phone call this will be the ANI.</value>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }
        
        
        
        /// <summary>
        /// The ani-based name for this participant.
        /// </summary>
        /// <value>The ani-based name for this participant.</value>
        [DataMember(Name="aniName", EmitDefaultValue=false)]
        public string AniName { get; set; }
        
        
        
        /// <summary>
        /// The address for the this participant. For a phone call this will be the ANI.
        /// </summary>
        /// <value>The address for the this participant. For a phone call this will be the ANI.</value>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }
        
        
        
        /// <summary>
        /// An ISO 639 language code specifying the locale for this participant
        /// </summary>
        /// <value>An ISO 639 language code specifying the locale for this participant</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }
        
        
        
        /// <summary>
        /// True iff this participant is required to enter wrapup for this conversation.
        /// </summary>
        /// <value>True iff this participant is required to enter wrapup for this conversation.</value>
        [DataMember(Name="wrapupRequired", EmitDefaultValue=false)]
        public bool? WrapupRequired { get; set; }
        
        
        
        
        
        /// <summary>
        /// Specifies how long a timed ACW session will last.
        /// </summary>
        /// <value>Specifies how long a timed ACW session will last.</value>
        [DataMember(Name="wrapupTimeoutMs", EmitDefaultValue=false)]
        public int? WrapupTimeoutMs { get; set; }
        
        
        
        /// <summary>
        /// The UI sets this field when the agent chooses to skip entering a wrapup for this participant.
        /// </summary>
        /// <value>The UI sets this field when the agent chooses to skip entering a wrapup for this participant.</value>
        [DataMember(Name="wrapupSkipped", EmitDefaultValue=false)]
        public bool? WrapupSkipped { get; set; }
        
        
        
        /// <summary>
        /// Call wrap up or disposition data.
        /// </summary>
        /// <value>Call wrap up or disposition data.</value>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public Wrapup Wrapup { get; set; }
        
        
        
        /// <summary>
        /// If this participant is a monitor, then this will be the id of the participant that is being monitored.
        /// </summary>
        /// <value>If this participant is a monitor, then this will be the id of the participant that is being monitored.</value>
        [DataMember(Name="monitoredParticipantId", EmitDefaultValue=false)]
        public string MonitoredParticipantId { get; set; }
        
        
        
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
        public List<Call> Calls { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Callbacks
        /// </summary>
        [DataMember(Name="callbacks", EmitDefaultValue=false)]
        public List<Callback> Callbacks { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Chats
        /// </summary>
        [DataMember(Name="chats", EmitDefaultValue=false)]
        public List<ConversationChat> Chats { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Cobrowsesessions
        /// </summary>
        [DataMember(Name="cobrowsesessions", EmitDefaultValue=false)]
        public List<Cobrowsesession> Cobrowsesessions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<Email> Emails { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<Message> Messages { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Screenshares
        /// </summary>
        [DataMember(Name="screenshares", EmitDefaultValue=false)]
        public List<Screenshare> Screenshares { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SocialExpressions
        /// </summary>
        [DataMember(Name="socialExpressions", EmitDefaultValue=false)]
        public List<SocialExpression> SocialExpressions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name="videos", EmitDefaultValue=false)]
        public List<Video> Videos { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Evaluations
        /// </summary>
        [DataMember(Name="evaluations", EmitDefaultValue=false)]
        public List<Evaluation> Evaluations { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Participant {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  UserUri: ").Append(UserUri).Append("\n");
            
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            
            sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
            
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            
            sb.Append("  QueueName: ").Append(QueueName).Append("\n");
            
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            
            sb.Append("  ParticipantType: ").Append(ParticipantType).Append("\n");
            
            sb.Append("  ConsultParticipantId: ").Append(ConsultParticipantId).Append("\n");
            
            sb.Append("  Address: ").Append(Address).Append("\n");
            
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            
            sb.Append("  AniName: ").Append(AniName).Append("\n");
            
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            
            sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
            
            sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
            
            sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
            
            sb.Append("  WrapupSkipped: ").Append(WrapupSkipped).Append("\n");
            
            sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
            
            sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
            
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            
            sb.Append("  Calls: ").Append(Calls).Append("\n");
            
            sb.Append("  Callbacks: ").Append(Callbacks).Append("\n");
            
            sb.Append("  Chats: ").Append(Chats).Append("\n");
            
            sb.Append("  Cobrowsesessions: ").Append(Cobrowsesessions).Append("\n");
            
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            
            sb.Append("  Screenshares: ").Append(Screenshares).Append("\n");
            
            sb.Append("  SocialExpressions: ").Append(SocialExpressions).Append("\n");
            
            sb.Append("  Videos: ").Append(Videos).Append("\n");
            
            sb.Append("  Evaluations: ").Append(Evaluations).Append("\n");
            
            sb.Append("  ScreenRecordingState: ").Append(ScreenRecordingState).Append("\n");
            
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
            return this.Equals(obj as Participant);
        }

        /// <summary>
        /// Returns true if Participant instances are equal
        /// </summary>
        /// <param name="other">Instance of Participant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Participant other)
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
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.UserUri == other.UserUri ||
                    this.UserUri != null &&
                    this.UserUri.Equals(other.UserUri)
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
                    this.ExternalOrganizationId == other.ExternalOrganizationId ||
                    this.ExternalOrganizationId != null &&
                    this.ExternalOrganizationId.Equals(other.ExternalOrganizationId)
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
                    this.QueueName == other.QueueName ||
                    this.QueueName != null &&
                    this.QueueName.Equals(other.QueueName)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.ParticipantType == other.ParticipantType ||
                    this.ParticipantType != null &&
                    this.ParticipantType.Equals(other.ParticipantType)
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
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) &&
                (
                    this.AniName == other.AniName ||
                    this.AniName != null &&
                    this.AniName.Equals(other.AniName)
                ) &&
                (
                    this.Dnis == other.Dnis ||
                    this.Dnis != null &&
                    this.Dnis.Equals(other.Dnis)
                ) &&
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
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
                    this.Wrapup == other.Wrapup ||
                    this.Wrapup != null &&
                    this.Wrapup.Equals(other.Wrapup)
                ) &&
                (
                    this.MonitoredParticipantId == other.MonitoredParticipantId ||
                    this.MonitoredParticipantId != null &&
                    this.MonitoredParticipantId.Equals(other.MonitoredParticipantId)
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
                    this.Evaluations == other.Evaluations ||
                    this.Evaluations != null &&
                    this.Evaluations.SequenceEqual(other.Evaluations)
                ) &&
                (
                    this.ScreenRecordingState == other.ScreenRecordingState ||
                    this.ScreenRecordingState != null &&
                    this.ScreenRecordingState.Equals(other.ScreenRecordingState)
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
                
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.UserUri != null)
                    hash = hash * 59 + this.UserUri.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();
                
                if (this.ExternalOrganizationId != null)
                    hash = hash * 59 + this.ExternalOrganizationId.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                
                if (this.QueueName != null)
                    hash = hash * 59 + this.QueueName.GetHashCode();
                
                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();
                
                if (this.ParticipantType != null)
                    hash = hash * 59 + this.ParticipantType.GetHashCode();
                
                if (this.ConsultParticipantId != null)
                    hash = hash * 59 + this.ConsultParticipantId.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();
                
                if (this.AniName != null)
                    hash = hash * 59 + this.AniName.GetHashCode();
                
                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();
                
                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();
                
                if (this.WrapupRequired != null)
                    hash = hash * 59 + this.WrapupRequired.GetHashCode();
                
                if (this.WrapupPrompt != null)
                    hash = hash * 59 + this.WrapupPrompt.GetHashCode();
                
                if (this.WrapupTimeoutMs != null)
                    hash = hash * 59 + this.WrapupTimeoutMs.GetHashCode();
                
                if (this.WrapupSkipped != null)
                    hash = hash * 59 + this.WrapupSkipped.GetHashCode();
                
                if (this.Wrapup != null)
                    hash = hash * 59 + this.Wrapup.GetHashCode();
                
                if (this.MonitoredParticipantId != null)
                    hash = hash * 59 + this.MonitoredParticipantId.GetHashCode();
                
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
                
                if (this.Screenshares != null)
                    hash = hash * 59 + this.Screenshares.GetHashCode();
                
                if (this.SocialExpressions != null)
                    hash = hash * 59 + this.SocialExpressions.GetHashCode();
                
                if (this.Videos != null)
                    hash = hash * 59 + this.Videos.GetHashCode();
                
                if (this.Evaluations != null)
                    hash = hash * 59 + this.Evaluations.GetHashCode();
                
                if (this.ScreenRecordingState != null)
                    hash = hash * 59 + this.ScreenRecordingState.GetHashCode();
                
                return hash;
            }
        }
    }

}
