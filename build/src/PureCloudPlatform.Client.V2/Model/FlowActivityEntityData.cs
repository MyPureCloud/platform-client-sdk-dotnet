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
    /// FlowActivityEntityData
    /// </summary>
    [DataContract]
    public partial class FlowActivityEntityData :  IEquatable<FlowActivityEntityData>
    {
        /// <summary>
        /// Activity metric
        /// </summary>
        /// <value>Activity metric</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Oflow for "oFlow"
            /// </summary>
            [EnumMember(Value = "oFlow")]
            Oflow
        }
        /// <summary>
        /// Active routing method
        /// </summary>
        /// <value>Active routing method</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActiveRoutingEnum
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
            /// Enum Direct for "Direct"
            /// </summary>
            [EnumMember(Value = "Direct")]
            Direct,
            
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
            Standard,
            
            /// <summary>
            /// Enum Vip for "Vip"
            /// </summary>
            [EnumMember(Value = "Vip")]
            Vip
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
        /// The type of this flow
        /// </summary>
        /// <value>The type of this flow</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlowTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bot for "BOT"
            /// </summary>
            [EnumMember(Value = "BOT")]
            Bot,
            
            /// <summary>
            /// Enum Commonmodule for "COMMONMODULE"
            /// </summary>
            [EnumMember(Value = "COMMONMODULE")]
            Commonmodule,
            
            /// <summary>
            /// Enum Digitalbot for "DIGITALBOT"
            /// </summary>
            [EnumMember(Value = "DIGITALBOT")]
            Digitalbot,
            
            /// <summary>
            /// Enum Inboundcall for "INBOUNDCALL"
            /// </summary>
            [EnumMember(Value = "INBOUNDCALL")]
            Inboundcall,
            
            /// <summary>
            /// Enum Inboundchat for "INBOUNDCHAT"
            /// </summary>
            [EnumMember(Value = "INBOUNDCHAT")]
            Inboundchat,
            
            /// <summary>
            /// Enum Inboundemail for "INBOUNDEMAIL"
            /// </summary>
            [EnumMember(Value = "INBOUNDEMAIL")]
            Inboundemail,
            
            /// <summary>
            /// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
            /// </summary>
            [EnumMember(Value = "INBOUNDSHORTMESSAGE")]
            Inboundshortmessage,
            
            /// <summary>
            /// Enum Inqueuecall for "INQUEUECALL"
            /// </summary>
            [EnumMember(Value = "INQUEUECALL")]
            Inqueuecall,
            
            /// <summary>
            /// Enum Inqueueemail for "INQUEUEEMAIL"
            /// </summary>
            [EnumMember(Value = "INQUEUEEMAIL")]
            Inqueueemail,
            
            /// <summary>
            /// Enum Inqueueshortmessage for "INQUEUESHORTMESSAGE"
            /// </summary>
            [EnumMember(Value = "INQUEUESHORTMESSAGE")]
            Inqueueshortmessage,
            
            /// <summary>
            /// Enum Outboundcall for "OUTBOUNDCALL"
            /// </summary>
            [EnumMember(Value = "OUTBOUNDCALL")]
            Outboundcall,
            
            /// <summary>
            /// Enum Securecall for "SECURECALL"
            /// </summary>
            [EnumMember(Value = "SECURECALL")]
            Securecall,
            
            /// <summary>
            /// Enum Speech for "SPEECH"
            /// </summary>
            [EnumMember(Value = "SPEECH")]
            Speech,
            
            /// <summary>
            /// Enum Surveyinvite for "SURVEYINVITE"
            /// </summary>
            [EnumMember(Value = "SURVEYINVITE")]
            Surveyinvite,
            
            /// <summary>
            /// Enum Voice for "VOICE"
            /// </summary>
            [EnumMember(Value = "VOICE")]
            Voice,
            
            /// <summary>
            /// Enum Voicemail for "VOICEMAIL"
            /// </summary>
            [EnumMember(Value = "VOICEMAIL")]
            Voicemail,
            
            /// <summary>
            /// Enum Voicesurvey for "VOICESURVEY"
            /// </summary>
            [EnumMember(Value = "VOICESURVEY")]
            Voicesurvey,
            
            /// <summary>
            /// Enum Workflow for "WORKFLOW"
            /// </summary>
            [EnumMember(Value = "WORKFLOW")]
            Workflow,
            
            /// <summary>
            /// Enum Workitem for "WORKITEM"
            /// </summary>
            [EnumMember(Value = "WORKITEM")]
            Workitem
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
            /// Enum Direct for "Direct"
            /// </summary>
            [EnumMember(Value = "Direct")]
            Direct,
            
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
            Standard,
            
            /// <summary>
            /// Enum Vip for "Vip"
            /// </summary>
            [EnumMember(Value = "Vip")]
            Vip
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
            /// Enum Direct for "Direct"
            /// </summary>
            [EnumMember(Value = "Direct")]
            Direct,
            
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
            Standard,
            
            /// <summary>
            /// Enum Vip for "Vip"
            /// </summary>
            [EnumMember(Value = "Vip")]
            Vip
        }
        /// <summary>
        /// Activity metric
        /// </summary>
        /// <value>Activity metric</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        /// <summary>
        /// Active routing method
        /// </summary>
        /// <value>Active routing method</value>
        [DataMember(Name="activeRouting", EmitDefaultValue=false)]
        public ActiveRoutingEnum? ActiveRouting { get; set; }
        /// <summary>
        /// The direction of the communication
        /// </summary>
        /// <value>The direction of the communication</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// The type of this flow
        /// </summary>
        /// <value>The type of this flow</value>
        [DataMember(Name="flowType", EmitDefaultValue=false)]
        public FlowTypeEnum? FlowType { get; set; }
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
        /// Initializes a new instance of the <see cref="FlowActivityEntityData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlowActivityEntityData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowActivityEntityData" /> class.
        /// </summary>
        /// <param name="ActivityDate">The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="Metric">Activity metric.</param>
        /// <param name="ActiveRouting">Active routing method.</param>
        /// <param name="AddressFrom">The address that initiated an action.</param>
        /// <param name="AddressTo">The address receiving an action.</param>
        /// <param name="Ani">Automatic Number Identification (caller's number).</param>
        /// <param name="ConversationId">Unique identifier for the conversation.</param>
        /// <param name="ConvertedFrom">Session media type that was converted from in case of a media type conversion.</param>
        /// <param name="ConvertedTo">Session media type that was converted to in case of a media type conversion.</param>
        /// <param name="Direction">The direction of the communication.</param>
        /// <param name="Dnis">Dialed number identification service (number dialed by the calling party).</param>
        /// <param name="FlowId">The unique identifier of this flow.</param>
        /// <param name="FlowType">The type of this flow.</param>
        /// <param name="MediaType">The session media type.</param>
        /// <param name="ParticipantName">A human readable name identifying the participant.</param>
        /// <param name="QueueId">Queue identifier.</param>
        /// <param name="RequestedLanguageId">Unique identifier for the language requested for an interaction.</param>
        /// <param name="RequestedRoutingSkillIds">Unique identifier(s) for skill(s) requested for an interaction.</param>
        /// <param name="RequestedRoutings">Routing type(s) for requested/attempted routing methods..</param>
        /// <param name="RoutingPriority">Routing priority for the current interaction.</param>
        /// <param name="SessionId">The unique identifier of this session.</param>
        /// <param name="TeamId">The team ID the user is a member of.</param>
        /// <param name="UsedRouting">Complete routing method.</param>
        /// <param name="UserId">Unique identifier for the user.</param>
        /// <param name="ScoredAgents">Scored agents.</param>
        public FlowActivityEntityData(DateTime? ActivityDate = null, MetricEnum? Metric = null, ActiveRoutingEnum? ActiveRouting = null, string AddressFrom = null, string AddressTo = null, string Ani = null, string ConversationId = null, string ConvertedFrom = null, string ConvertedTo = null, DirectionEnum? Direction = null, string Dnis = null, string FlowId = null, FlowTypeEnum? FlowType = null, MediaTypeEnum? MediaType = null, string ParticipantName = null, string QueueId = null, string RequestedLanguageId = null, List<string> RequestedRoutingSkillIds = null, List<RequestedRoutingsEnum> RequestedRoutings = null, long? RoutingPriority = null, string SessionId = null, string TeamId = null, UsedRoutingEnum? UsedRouting = null, string UserId = null, List<FlowActivityScoredAgent> ScoredAgents = null)
        {
            this.ActivityDate = ActivityDate;
            this.Metric = Metric;
            this.ActiveRouting = ActiveRouting;
            this.AddressFrom = AddressFrom;
            this.AddressTo = AddressTo;
            this.Ani = Ani;
            this.ConversationId = ConversationId;
            this.ConvertedFrom = ConvertedFrom;
            this.ConvertedTo = ConvertedTo;
            this.Direction = Direction;
            this.Dnis = Dnis;
            this.FlowId = FlowId;
            this.FlowType = FlowType;
            this.MediaType = MediaType;
            this.ParticipantName = ParticipantName;
            this.QueueId = QueueId;
            this.RequestedLanguageId = RequestedLanguageId;
            this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
            this.RequestedRoutings = RequestedRoutings;
            this.RoutingPriority = RoutingPriority;
            this.SessionId = SessionId;
            this.TeamId = TeamId;
            this.UsedRouting = UsedRouting;
            this.UserId = UserId;
            this.ScoredAgents = ScoredAgents;
            
        }
        


        /// <summary>
        /// The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="activityDate", EmitDefaultValue=false)]
        public DateTime? ActivityDate { get; set; }







        /// <summary>
        /// The address that initiated an action
        /// </summary>
        /// <value>The address that initiated an action</value>
        [DataMember(Name="addressFrom", EmitDefaultValue=false)]
        public string AddressFrom { get; set; }



        /// <summary>
        /// The address receiving an action
        /// </summary>
        /// <value>The address receiving an action</value>
        [DataMember(Name="addressTo", EmitDefaultValue=false)]
        public string AddressTo { get; set; }



        /// <summary>
        /// Automatic Number Identification (caller's number)
        /// </summary>
        /// <value>Automatic Number Identification (caller's number)</value>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }



        /// <summary>
        /// Unique identifier for the conversation
        /// </summary>
        /// <value>Unique identifier for the conversation</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// Session media type that was converted from in case of a media type conversion
        /// </summary>
        /// <value>Session media type that was converted from in case of a media type conversion</value>
        [DataMember(Name="convertedFrom", EmitDefaultValue=false)]
        public string ConvertedFrom { get; set; }



        /// <summary>
        /// Session media type that was converted to in case of a media type conversion
        /// </summary>
        /// <value>Session media type that was converted to in case of a media type conversion</value>
        [DataMember(Name="convertedTo", EmitDefaultValue=false)]
        public string ConvertedTo { get; set; }





        /// <summary>
        /// Dialed number identification service (number dialed by the calling party)
        /// </summary>
        /// <value>Dialed number identification service (number dialed by the calling party)</value>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }



        /// <summary>
        /// The unique identifier of this flow
        /// </summary>
        /// <value>The unique identifier of this flow</value>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public string FlowId { get; set; }







        /// <summary>
        /// A human readable name identifying the participant
        /// </summary>
        /// <value>A human readable name identifying the participant</value>
        [DataMember(Name="participantName", EmitDefaultValue=false)]
        public string ParticipantName { get; set; }



        /// <summary>
        /// Queue identifier
        /// </summary>
        /// <value>Queue identifier</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// Unique identifier for the language requested for an interaction
        /// </summary>
        /// <value>Unique identifier for the language requested for an interaction</value>
        [DataMember(Name="requestedLanguageId", EmitDefaultValue=false)]
        public string RequestedLanguageId { get; set; }



        /// <summary>
        /// Unique identifier(s) for skill(s) requested for an interaction
        /// </summary>
        /// <value>Unique identifier(s) for skill(s) requested for an interaction</value>
        [DataMember(Name="requestedRoutingSkillIds", EmitDefaultValue=false)]
        public List<string> RequestedRoutingSkillIds { get; set; }



        /// <summary>
        /// Routing type(s) for requested/attempted routing methods.
        /// </summary>
        /// <value>Routing type(s) for requested/attempted routing methods.</value>
        [DataMember(Name="requestedRoutings", EmitDefaultValue=false)]
        public List<RequestedRoutingsEnum> RequestedRoutings { get; set; }



        /// <summary>
        /// Routing priority for the current interaction
        /// </summary>
        /// <value>Routing priority for the current interaction</value>
        [DataMember(Name="routingPriority", EmitDefaultValue=false)]
        public long? RoutingPriority { get; set; }



        /// <summary>
        /// The unique identifier of this session
        /// </summary>
        /// <value>The unique identifier of this session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// The team ID the user is a member of
        /// </summary>
        /// <value>The team ID the user is a member of</value>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }





        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        /// <value>Unique identifier for the user</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Scored agents
        /// </summary>
        /// <value>Scored agents</value>
        [DataMember(Name="scoredAgents", EmitDefaultValue=false)]
        public List<FlowActivityScoredAgent> ScoredAgents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowActivityEntityData {\n");

            sb.Append("  ActivityDate: ").Append(ActivityDate).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  ActiveRouting: ").Append(ActiveRouting).Append("\n");
            sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
            sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ConvertedFrom: ").Append(ConvertedFrom).Append("\n");
            sb.Append("  ConvertedTo: ").Append(ConvertedTo).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
            sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
            sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
            sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
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
            return this.Equals(obj as FlowActivityEntityData);
        }

        /// <summary>
        /// Returns true if FlowActivityEntityData instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowActivityEntityData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowActivityEntityData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActivityDate == other.ActivityDate ||
                    this.ActivityDate != null &&
                    this.ActivityDate.Equals(other.ActivityDate)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.ActiveRouting == other.ActiveRouting ||
                    this.ActiveRouting != null &&
                    this.ActiveRouting.Equals(other.ActiveRouting)
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
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.ConvertedFrom == other.ConvertedFrom ||
                    this.ConvertedFrom != null &&
                    this.ConvertedFrom.Equals(other.ConvertedFrom)
                ) &&
                (
                    this.ConvertedTo == other.ConvertedTo ||
                    this.ConvertedTo != null &&
                    this.ConvertedTo.Equals(other.ConvertedTo)
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
                    this.FlowId == other.FlowId ||
                    this.FlowId != null &&
                    this.FlowId.Equals(other.FlowId)
                ) &&
                (
                    this.FlowType == other.FlowType ||
                    this.FlowType != null &&
                    this.FlowType.Equals(other.FlowType)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.ParticipantName == other.ParticipantName ||
                    this.ParticipantName != null &&
                    this.ParticipantName.Equals(other.ParticipantName)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.RequestedLanguageId == other.RequestedLanguageId ||
                    this.RequestedLanguageId != null &&
                    this.RequestedLanguageId.Equals(other.RequestedLanguageId)
                ) &&
                (
                    this.RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                    this.RequestedRoutingSkillIds != null &&
                    this.RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
                ) &&
                (
                    this.RequestedRoutings == other.RequestedRoutings ||
                    this.RequestedRoutings != null &&
                    this.RequestedRoutings.SequenceEqual(other.RequestedRoutings)
                ) &&
                (
                    this.RoutingPriority == other.RoutingPriority ||
                    this.RoutingPriority != null &&
                    this.RoutingPriority.Equals(other.RoutingPriority)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) &&
                (
                    this.UsedRouting == other.UsedRouting ||
                    this.UsedRouting != null &&
                    this.UsedRouting.Equals(other.UsedRouting)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.ScoredAgents == other.ScoredAgents ||
                    this.ScoredAgents != null &&
                    this.ScoredAgents.SequenceEqual(other.ScoredAgents)
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
                if (this.ActivityDate != null)
                    hash = hash * 59 + this.ActivityDate.GetHashCode();

                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                if (this.ActiveRouting != null)
                    hash = hash * 59 + this.ActiveRouting.GetHashCode();

                if (this.AddressFrom != null)
                    hash = hash * 59 + this.AddressFrom.GetHashCode();

                if (this.AddressTo != null)
                    hash = hash * 59 + this.AddressTo.GetHashCode();

                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.ConvertedFrom != null)
                    hash = hash * 59 + this.ConvertedFrom.GetHashCode();

                if (this.ConvertedTo != null)
                    hash = hash * 59 + this.ConvertedTo.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();

                if (this.FlowId != null)
                    hash = hash * 59 + this.FlowId.GetHashCode();

                if (this.FlowType != null)
                    hash = hash * 59 + this.FlowType.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.ParticipantName != null)
                    hash = hash * 59 + this.ParticipantName.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.RequestedLanguageId != null)
                    hash = hash * 59 + this.RequestedLanguageId.GetHashCode();

                if (this.RequestedRoutingSkillIds != null)
                    hash = hash * 59 + this.RequestedRoutingSkillIds.GetHashCode();

                if (this.RequestedRoutings != null)
                    hash = hash * 59 + this.RequestedRoutings.GetHashCode();

                if (this.RoutingPriority != null)
                    hash = hash * 59 + this.RoutingPriority.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();

                if (this.UsedRouting != null)
                    hash = hash * 59 + this.UsedRouting.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.ScoredAgents != null)
                    hash = hash * 59 + this.ScoredAgents.GetHashCode();

                return hash;
            }
        }
    }

}
