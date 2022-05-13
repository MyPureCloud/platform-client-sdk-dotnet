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
    /// AnalyticsConversationSegment
    /// </summary>
    [DataContract]
    public partial class AnalyticsConversationSegment :  IEquatable<AnalyticsConversationSegment>
    {
        /// <summary>
        /// The session disconnect type
        /// </summary>
        /// <value>The session disconnect type</value>
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
            /// Enum Client for "client"
            /// </summary>
            [EnumMember(Value = "client")]
            Client,
            
            /// <summary>
            /// Enum Conferencetransfer for "conferenceTransfer"
            /// </summary>
            [EnumMember(Value = "conferenceTransfer")]
            Conferencetransfer,
            
            /// <summary>
            /// Enum Consulttransfer for "consultTransfer"
            /// </summary>
            [EnumMember(Value = "consultTransfer")]
            Consulttransfer,
            
            /// <summary>
            /// Enum Endpoint for "endpoint"
            /// </summary>
            [EnumMember(Value = "endpoint")]
            Endpoint,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error,
            
            /// <summary>
            /// Enum Forwardtransfer for "forwardTransfer"
            /// </summary>
            [EnumMember(Value = "forwardTransfer")]
            Forwardtransfer,
            
            /// <summary>
            /// Enum Noanswertransfer for "noAnswerTransfer"
            /// </summary>
            [EnumMember(Value = "noAnswerTransfer")]
            Noanswertransfer,
            
            /// <summary>
            /// Enum Notavailabletransfer for "notAvailableTransfer"
            /// </summary>
            [EnumMember(Value = "notAvailableTransfer")]
            Notavailabletransfer,
            
            /// <summary>
            /// Enum Other for "other"
            /// </summary>
            [EnumMember(Value = "other")]
            Other,
            
            /// <summary>
            /// Enum Peer for "peer"
            /// </summary>
            [EnumMember(Value = "peer")]
            Peer,
            
            /// <summary>
            /// Enum Spam for "spam"
            /// </summary>
            [EnumMember(Value = "spam")]
            Spam,
            
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
            /// Enum Transportfailure for "transportFailure"
            /// </summary>
            [EnumMember(Value = "transportFailure")]
            Transportfailure,
            
            /// <summary>
            /// Enum Uncallable for "uncallable"
            /// </summary>
            [EnumMember(Value = "uncallable")]
            Uncallable
        }
        /// <summary>
        /// The activity that takes place in the segment, such as hold or interact
        /// </summary>
        /// <value>The activity that takes place in the segment, such as hold or interact</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SegmentTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alert for "alert"
            /// </summary>
            [EnumMember(Value = "alert")]
            Alert,
            
            /// <summary>
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Coaching for "coaching"
            /// </summary>
            [EnumMember(Value = "coaching")]
            Coaching,
            
            /// <summary>
            /// Enum Contacting for "contacting"
            /// </summary>
            [EnumMember(Value = "contacting")]
            Contacting,
            
            /// <summary>
            /// Enum Converting for "converting"
            /// </summary>
            [EnumMember(Value = "converting")]
            Converting,
            
            /// <summary>
            /// Enum Delay for "delay"
            /// </summary>
            [EnumMember(Value = "delay")]
            Delay,
            
            /// <summary>
            /// Enum Dialing for "dialing"
            /// </summary>
            [EnumMember(Value = "dialing")]
            Dialing,
            
            /// <summary>
            /// Enum Hold for "hold"
            /// </summary>
            [EnumMember(Value = "hold")]
            Hold,
            
            /// <summary>
            /// Enum Interact for "interact"
            /// </summary>
            [EnumMember(Value = "interact")]
            Interact,
            
            /// <summary>
            /// Enum Ivr for "ivr"
            /// </summary>
            [EnumMember(Value = "ivr")]
            Ivr,
            
            /// <summary>
            /// Enum Monitoring for "monitoring"
            /// </summary>
            [EnumMember(Value = "monitoring")]
            Monitoring,
            
            /// <summary>
            /// Enum Scheduled for "scheduled"
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Sharing for "sharing"
            /// </summary>
            [EnumMember(Value = "sharing")]
            Sharing,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System,
            
            /// <summary>
            /// Enum Transmitting for "transmitting"
            /// </summary>
            [EnumMember(Value = "transmitting")]
            Transmitting,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Uploading for "uploading"
            /// </summary>
            [EnumMember(Value = "uploading")]
            Uploading,
            
            /// <summary>
            /// Enum Voicemail for "voicemail"
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail,
            
            /// <summary>
            /// Enum Wrapup for "wrapup"
            /// </summary>
            [EnumMember(Value = "wrapup")]
            Wrapup
        }
        /// <summary>
        /// The session disconnect type
        /// </summary>
        /// <value>The session disconnect type</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        /// <summary>
        /// The activity that takes place in the segment, such as hold or interact
        /// </summary>
        /// <value>The activity that takes place in the segment, such as hold or interact</value>
        [DataMember(Name="segmentType", EmitDefaultValue=false)]
        public SegmentTypeEnum? SegmentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsConversationSegment" /> class.
        /// </summary>
        /// <param name="AudioMuted">Flag indicating if audio is muted or not (true/false).</param>
        /// <param name="Conference">Indicates whether the segment was a conference.</param>
        /// <param name="DestinationConversationId">The unique identifier of a new conversation when a conversation is ended for a conference.</param>
        /// <param name="DestinationSessionId">The unique identifier of a new session when a session is ended for a conference.</param>
        /// <param name="DisconnectType">The session disconnect type.</param>
        /// <param name="ErrorCode">A code corresponding to the error that occurred.</param>
        /// <param name="GroupId">Unique identifier for a PureCloud group.</param>
        /// <param name="Q850ResponseCodes">Q.850 response code(s).</param>
        /// <param name="QueueId">Queue identifier.</param>
        /// <param name="RequestedLanguageId">Unique identifier for the language requested for an interaction.</param>
        /// <param name="RequestedRoutingSkillIds">Unique identifier(s) for skill(s) requested for an interaction.</param>
        /// <param name="RequestedRoutingUserIds">Unique identifier(s) for agent(s) requested for an interaction.</param>
        /// <param name="SegmentEnd">The end time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="SegmentStart">The start time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="SegmentType">The activity that takes place in the segment, such as hold or interact.</param>
        /// <param name="SipResponseCodes">SIP response code(s).</param>
        /// <param name="SourceConversationId">The unique identifier of the previous conversation when a new conversation is created for a conference.</param>
        /// <param name="SourceSessionId">The unique identifier of the previous session when a new session is created for a conference.</param>
        /// <param name="Subject">The subject for the initial email that started this conversation.</param>
        /// <param name="VideoMuted">Flag indicating if video is muted/paused or not (true/false).</param>
        /// <param name="WrapUpCode">Wrap up code.</param>
        /// <param name="WrapUpNote">Note entered by an agent during after-call work.</param>
        /// <param name="WrapUpTags">Tag(s) assigned during after-call work.</param>
        /// <param name="ScoredAgents">Scored agents.</param>
        /// <param name="Properties">Additional segment properties.</param>
        public AnalyticsConversationSegment(bool? AudioMuted = null, bool? Conference = null, string DestinationConversationId = null, string DestinationSessionId = null, DisconnectTypeEnum? DisconnectType = null, string ErrorCode = null, string GroupId = null, List<long?> Q850ResponseCodes = null, string QueueId = null, string RequestedLanguageId = null, List<string> RequestedRoutingSkillIds = null, List<string> RequestedRoutingUserIds = null, DateTime? SegmentEnd = null, DateTime? SegmentStart = null, SegmentTypeEnum? SegmentType = null, List<long?> SipResponseCodes = null, string SourceConversationId = null, string SourceSessionId = null, string Subject = null, bool? VideoMuted = null, string WrapUpCode = null, string WrapUpNote = null, List<string> WrapUpTags = null, List<AnalyticsScoredAgent> ScoredAgents = null, List<AnalyticsProperty> Properties = null)
        {
            this.AudioMuted = AudioMuted;
            this.Conference = Conference;
            this.DestinationConversationId = DestinationConversationId;
            this.DestinationSessionId = DestinationSessionId;
            this.DisconnectType = DisconnectType;
            this.ErrorCode = ErrorCode;
            this.GroupId = GroupId;
            this.Q850ResponseCodes = Q850ResponseCodes;
            this.QueueId = QueueId;
            this.RequestedLanguageId = RequestedLanguageId;
            this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
            this.RequestedRoutingUserIds = RequestedRoutingUserIds;
            this.SegmentEnd = SegmentEnd;
            this.SegmentStart = SegmentStart;
            this.SegmentType = SegmentType;
            this.SipResponseCodes = SipResponseCodes;
            this.SourceConversationId = SourceConversationId;
            this.SourceSessionId = SourceSessionId;
            this.Subject = Subject;
            this.VideoMuted = VideoMuted;
            this.WrapUpCode = WrapUpCode;
            this.WrapUpNote = WrapUpNote;
            this.WrapUpTags = WrapUpTags;
            this.ScoredAgents = ScoredAgents;
            this.Properties = Properties;
            
        }
        


        /// <summary>
        /// Flag indicating if audio is muted or not (true/false)
        /// </summary>
        /// <value>Flag indicating if audio is muted or not (true/false)</value>
        [DataMember(Name="audioMuted", EmitDefaultValue=false)]
        public bool? AudioMuted { get; set; }



        /// <summary>
        /// Indicates whether the segment was a conference
        /// </summary>
        /// <value>Indicates whether the segment was a conference</value>
        [DataMember(Name="conference", EmitDefaultValue=false)]
        public bool? Conference { get; set; }



        /// <summary>
        /// The unique identifier of a new conversation when a conversation is ended for a conference
        /// </summary>
        /// <value>The unique identifier of a new conversation when a conversation is ended for a conference</value>
        [DataMember(Name="destinationConversationId", EmitDefaultValue=false)]
        public string DestinationConversationId { get; set; }



        /// <summary>
        /// The unique identifier of a new session when a session is ended for a conference
        /// </summary>
        /// <value>The unique identifier of a new session when a session is ended for a conference</value>
        [DataMember(Name="destinationSessionId", EmitDefaultValue=false)]
        public string DestinationSessionId { get; set; }





        /// <summary>
        /// A code corresponding to the error that occurred
        /// </summary>
        /// <value>A code corresponding to the error that occurred</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Unique identifier for a PureCloud group
        /// </summary>
        /// <value>Unique identifier for a PureCloud group</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }



        /// <summary>
        /// Q.850 response code(s)
        /// </summary>
        /// <value>Q.850 response code(s)</value>
        [DataMember(Name="q850ResponseCodes", EmitDefaultValue=false)]
        public List<long?> Q850ResponseCodes { get; set; }



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
        /// Unique identifier(s) for agent(s) requested for an interaction
        /// </summary>
        /// <value>Unique identifier(s) for agent(s) requested for an interaction</value>
        [DataMember(Name="requestedRoutingUserIds", EmitDefaultValue=false)]
        public List<string> RequestedRoutingUserIds { get; set; }



        /// <summary>
        /// The end time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The end time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="segmentEnd", EmitDefaultValue=false)]
        public DateTime? SegmentEnd { get; set; }



        /// <summary>
        /// The start time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="segmentStart", EmitDefaultValue=false)]
        public DateTime? SegmentStart { get; set; }





        /// <summary>
        /// SIP response code(s)
        /// </summary>
        /// <value>SIP response code(s)</value>
        [DataMember(Name="sipResponseCodes", EmitDefaultValue=false)]
        public List<long?> SipResponseCodes { get; set; }



        /// <summary>
        /// The unique identifier of the previous conversation when a new conversation is created for a conference
        /// </summary>
        /// <value>The unique identifier of the previous conversation when a new conversation is created for a conference</value>
        [DataMember(Name="sourceConversationId", EmitDefaultValue=false)]
        public string SourceConversationId { get; set; }



        /// <summary>
        /// The unique identifier of the previous session when a new session is created for a conference
        /// </summary>
        /// <value>The unique identifier of the previous session when a new session is created for a conference</value>
        [DataMember(Name="sourceSessionId", EmitDefaultValue=false)]
        public string SourceSessionId { get; set; }



        /// <summary>
        /// The subject for the initial email that started this conversation
        /// </summary>
        /// <value>The subject for the initial email that started this conversation</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }



        /// <summary>
        /// Flag indicating if video is muted/paused or not (true/false)
        /// </summary>
        /// <value>Flag indicating if video is muted/paused or not (true/false)</value>
        [DataMember(Name="videoMuted", EmitDefaultValue=false)]
        public bool? VideoMuted { get; set; }



        /// <summary>
        /// Wrap up code
        /// </summary>
        /// <value>Wrap up code</value>
        [DataMember(Name="wrapUpCode", EmitDefaultValue=false)]
        public string WrapUpCode { get; set; }



        /// <summary>
        /// Note entered by an agent during after-call work
        /// </summary>
        /// <value>Note entered by an agent during after-call work</value>
        [DataMember(Name="wrapUpNote", EmitDefaultValue=false)]
        public string WrapUpNote { get; set; }



        /// <summary>
        /// Tag(s) assigned during after-call work
        /// </summary>
        /// <value>Tag(s) assigned during after-call work</value>
        [DataMember(Name="wrapUpTags", EmitDefaultValue=false)]
        public List<string> WrapUpTags { get; set; }



        /// <summary>
        /// Scored agents
        /// </summary>
        /// <value>Scored agents</value>
        [DataMember(Name="scoredAgents", EmitDefaultValue=false)]
        public List<AnalyticsScoredAgent> ScoredAgents { get; set; }



        /// <summary>
        /// Additional segment properties
        /// </summary>
        /// <value>Additional segment properties</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<AnalyticsProperty> Properties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsConversationSegment {\n");

            sb.Append("  AudioMuted: ").Append(AudioMuted).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  DestinationConversationId: ").Append(DestinationConversationId).Append("\n");
            sb.Append("  DestinationSessionId: ").Append(DestinationSessionId).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Q850ResponseCodes: ").Append(Q850ResponseCodes).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
            sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
            sb.Append("  RequestedRoutingUserIds: ").Append(RequestedRoutingUserIds).Append("\n");
            sb.Append("  SegmentEnd: ").Append(SegmentEnd).Append("\n");
            sb.Append("  SegmentStart: ").Append(SegmentStart).Append("\n");
            sb.Append("  SegmentType: ").Append(SegmentType).Append("\n");
            sb.Append("  SipResponseCodes: ").Append(SipResponseCodes).Append("\n");
            sb.Append("  SourceConversationId: ").Append(SourceConversationId).Append("\n");
            sb.Append("  SourceSessionId: ").Append(SourceSessionId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  VideoMuted: ").Append(VideoMuted).Append("\n");
            sb.Append("  WrapUpCode: ").Append(WrapUpCode).Append("\n");
            sb.Append("  WrapUpNote: ").Append(WrapUpNote).Append("\n");
            sb.Append("  WrapUpTags: ").Append(WrapUpTags).Append("\n");
            sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as AnalyticsConversationSegment);
        }

        /// <summary>
        /// Returns true if AnalyticsConversationSegment instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsConversationSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsConversationSegment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AudioMuted == other.AudioMuted ||
                    this.AudioMuted != null &&
                    this.AudioMuted.Equals(other.AudioMuted)
                ) &&
                (
                    this.Conference == other.Conference ||
                    this.Conference != null &&
                    this.Conference.Equals(other.Conference)
                ) &&
                (
                    this.DestinationConversationId == other.DestinationConversationId ||
                    this.DestinationConversationId != null &&
                    this.DestinationConversationId.Equals(other.DestinationConversationId)
                ) &&
                (
                    this.DestinationSessionId == other.DestinationSessionId ||
                    this.DestinationSessionId != null &&
                    this.DestinationSessionId.Equals(other.DestinationSessionId)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) &&
                (
                    this.Q850ResponseCodes == other.Q850ResponseCodes ||
                    this.Q850ResponseCodes != null &&
                    this.Q850ResponseCodes.SequenceEqual(other.Q850ResponseCodes)
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
                    this.RequestedRoutingUserIds == other.RequestedRoutingUserIds ||
                    this.RequestedRoutingUserIds != null &&
                    this.RequestedRoutingUserIds.SequenceEqual(other.RequestedRoutingUserIds)
                ) &&
                (
                    this.SegmentEnd == other.SegmentEnd ||
                    this.SegmentEnd != null &&
                    this.SegmentEnd.Equals(other.SegmentEnd)
                ) &&
                (
                    this.SegmentStart == other.SegmentStart ||
                    this.SegmentStart != null &&
                    this.SegmentStart.Equals(other.SegmentStart)
                ) &&
                (
                    this.SegmentType == other.SegmentType ||
                    this.SegmentType != null &&
                    this.SegmentType.Equals(other.SegmentType)
                ) &&
                (
                    this.SipResponseCodes == other.SipResponseCodes ||
                    this.SipResponseCodes != null &&
                    this.SipResponseCodes.SequenceEqual(other.SipResponseCodes)
                ) &&
                (
                    this.SourceConversationId == other.SourceConversationId ||
                    this.SourceConversationId != null &&
                    this.SourceConversationId.Equals(other.SourceConversationId)
                ) &&
                (
                    this.SourceSessionId == other.SourceSessionId ||
                    this.SourceSessionId != null &&
                    this.SourceSessionId.Equals(other.SourceSessionId)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.VideoMuted == other.VideoMuted ||
                    this.VideoMuted != null &&
                    this.VideoMuted.Equals(other.VideoMuted)
                ) &&
                (
                    this.WrapUpCode == other.WrapUpCode ||
                    this.WrapUpCode != null &&
                    this.WrapUpCode.Equals(other.WrapUpCode)
                ) &&
                (
                    this.WrapUpNote == other.WrapUpNote ||
                    this.WrapUpNote != null &&
                    this.WrapUpNote.Equals(other.WrapUpNote)
                ) &&
                (
                    this.WrapUpTags == other.WrapUpTags ||
                    this.WrapUpTags != null &&
                    this.WrapUpTags.SequenceEqual(other.WrapUpTags)
                ) &&
                (
                    this.ScoredAgents == other.ScoredAgents ||
                    this.ScoredAgents != null &&
                    this.ScoredAgents.SequenceEqual(other.ScoredAgents)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                if (this.AudioMuted != null)
                    hash = hash * 59 + this.AudioMuted.GetHashCode();

                if (this.Conference != null)
                    hash = hash * 59 + this.Conference.GetHashCode();

                if (this.DestinationConversationId != null)
                    hash = hash * 59 + this.DestinationConversationId.GetHashCode();

                if (this.DestinationSessionId != null)
                    hash = hash * 59 + this.DestinationSessionId.GetHashCode();

                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();

                if (this.Q850ResponseCodes != null)
                    hash = hash * 59 + this.Q850ResponseCodes.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.RequestedLanguageId != null)
                    hash = hash * 59 + this.RequestedLanguageId.GetHashCode();

                if (this.RequestedRoutingSkillIds != null)
                    hash = hash * 59 + this.RequestedRoutingSkillIds.GetHashCode();

                if (this.RequestedRoutingUserIds != null)
                    hash = hash * 59 + this.RequestedRoutingUserIds.GetHashCode();

                if (this.SegmentEnd != null)
                    hash = hash * 59 + this.SegmentEnd.GetHashCode();

                if (this.SegmentStart != null)
                    hash = hash * 59 + this.SegmentStart.GetHashCode();

                if (this.SegmentType != null)
                    hash = hash * 59 + this.SegmentType.GetHashCode();

                if (this.SipResponseCodes != null)
                    hash = hash * 59 + this.SipResponseCodes.GetHashCode();

                if (this.SourceConversationId != null)
                    hash = hash * 59 + this.SourceConversationId.GetHashCode();

                if (this.SourceSessionId != null)
                    hash = hash * 59 + this.SourceSessionId.GetHashCode();

                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();

                if (this.VideoMuted != null)
                    hash = hash * 59 + this.VideoMuted.GetHashCode();

                if (this.WrapUpCode != null)
                    hash = hash * 59 + this.WrapUpCode.GetHashCode();

                if (this.WrapUpNote != null)
                    hash = hash * 59 + this.WrapUpNote.GetHashCode();

                if (this.WrapUpTags != null)
                    hash = hash * 59 + this.WrapUpTags.GetHashCode();

                if (this.ScoredAgents != null)
                    hash = hash * 59 + this.ScoredAgents.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                return hash;
            }
        }
    }

}
