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
        /// A description of the event that disconnected the segment
        /// </summary>
        /// <value>A description of the event that disconnected the segment</value>
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
            /// Enum Transportfailure for "transportFailure"
            /// </summary>
            [EnumMember(Value = "transportFailure")]
            Transportfailure,
            
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
            /// Enum Forwardtransfer for "forwardTransfer"
            /// </summary>
            [EnumMember(Value = "forwardTransfer")]
            Forwardtransfer,
            
            /// <summary>
            /// Enum Timeout for "timeout"
            /// </summary>
            [EnumMember(Value = "timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Noanswertransfer for "noAnswerTransfer"
            /// </summary>
            [EnumMember(Value = "noAnswerTransfer")]
            Noanswertransfer,
            
            /// <summary>
            /// Enum Notavailabletransfer for "notAvailableTransfer"
            /// </summary>
            [EnumMember(Value = "notAvailableTransfer")]
            Notavailabletransfer
        }
        
        
        
        
        /// <summary>
        /// The activity taking place for the participant in the segment
        /// </summary>
        /// <value>The activity taking place for the participant in the segment</value>
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
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Alert for "alert"
            /// </summary>
            [EnumMember(Value = "alert")]
            Alert,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System,
            
            /// <summary>
            /// Enum Delay for "delay"
            /// </summary>
            [EnumMember(Value = "delay")]
            Delay,
            
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
            /// Enum Dialing for "dialing"
            /// </summary>
            [EnumMember(Value = "dialing")]
            Dialing,
            
            /// <summary>
            /// Enum Wrapup for "wrapup"
            /// </summary>
            [EnumMember(Value = "wrapup")]
            Wrapup,
            
            /// <summary>
            /// Enum Voicemail for "voicemail"
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail,
            
            /// <summary>
            /// Enum Scheduled for "scheduled"
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// A description of the event that disconnected the segment
        /// </summary>
        /// <value>A description of the event that disconnected the segment</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        
        
        
        /// <summary>
        /// The activity taking place for the participant in the segment
        /// </summary>
        /// <value>The activity taking place for the participant in the segment</value>
        [DataMember(Name="segmentType", EmitDefaultValue=false)]
        public SegmentTypeEnum? SegmentType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsConversationSegment" /> class.
        /// </summary>
        
        
        /// <param name="SegmentStart">The timestamp when this segment began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="SegmentEnd">The timestamp when this segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="QueueId">Queue identifier.</param>
        
        
        
        /// <param name="WrapUpCode">Wrapup Code id.</param>
        
        
        
        /// <param name="WrapUpNote">Note entered by an agent during after-call work.</param>
        
        
        
        /// <param name="WrapUpTags">WrapUpTags.</param>
        
        
        
        /// <param name="ErrorCode">ErrorCode.</param>
        
        
        
        /// <param name="DisconnectType">A description of the event that disconnected the segment.</param>
        
        
        
        /// <param name="SegmentType">The activity taking place for the participant in the segment.</param>
        
        
        
        /// <param name="RequestedRoutingUserIds">RequestedRoutingUserIds.</param>
        
        
        
        /// <param name="RequestedRoutingSkillIds">RequestedRoutingSkillIds.</param>
        
        
        
        /// <param name="RequestedLanguageId">A unique identifier for the language requested for an interaction..</param>
        
        
        
        /// <param name="Properties">Properties.</param>
        
        
        
        /// <param name="SourceConversationId">SourceConversationId.</param>
        
        
        
        /// <param name="DestinationConversationId">DestinationConversationId.</param>
        
        
        
        /// <param name="SourceSessionId">SourceSessionId.</param>
        
        
        
        /// <param name="DestinationSessionId">DestinationSessionId.</param>
        
        
        
        /// <param name="SipResponseCodes">SipResponseCodes.</param>
        
        
        
        /// <param name="Q850ResponseCodes">Q850ResponseCodes.</param>
        
        
        
        /// <param name="Conference">Indicates whether the segment was a conference.</param>
        
        
        
        /// <param name="GroupId">GroupId.</param>
        
        
        
        /// <param name="Subject">Subject.</param>
        
        
        
        /// <param name="AudioMuted">AudioMuted.</param>
        
        
        
        /// <param name="VideoMuted">VideoMuted.</param>
        
        
        public AnalyticsConversationSegment(DateTime? SegmentStart = null, DateTime? SegmentEnd = null, string QueueId = null, string WrapUpCode = null, string WrapUpNote = null, List<string> WrapUpTags = null, string ErrorCode = null, DisconnectTypeEnum? DisconnectType = null, SegmentTypeEnum? SegmentType = null, List<string> RequestedRoutingUserIds = null, List<string> RequestedRoutingSkillIds = null, string RequestedLanguageId = null, List<AnalyticsProperty> Properties = null, string SourceConversationId = null, string DestinationConversationId = null, string SourceSessionId = null, string DestinationSessionId = null, List<long?> SipResponseCodes = null, List<long?> Q850ResponseCodes = null, bool? Conference = null, string GroupId = null, string Subject = null, bool? AudioMuted = null, bool? VideoMuted = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.SegmentStart = SegmentStart;
            
            
            
            
            
            
            
            
this.SegmentEnd = SegmentEnd;
            
            
            
            
            
            
            
            
this.QueueId = QueueId;
            
            
            
            
            
            
            
            
this.WrapUpCode = WrapUpCode;
            
            
            
            
            
            
            
            
this.WrapUpNote = WrapUpNote;
            
            
            
            
            
            
            
            
this.WrapUpTags = WrapUpTags;
            
            
            
            
            
            
            
            
this.ErrorCode = ErrorCode;
            
            
            
            
            
            
            
            
this.DisconnectType = DisconnectType;
            
            
            
            
            
            
            
            
this.SegmentType = SegmentType;
            
            
            
            
            
            
            
            
this.RequestedRoutingUserIds = RequestedRoutingUserIds;
            
            
            
            
            
            
            
            
this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
            
            
            
            
            
            
            
            
this.RequestedLanguageId = RequestedLanguageId;
            
            
            
            
            
            
            
            
this.Properties = Properties;
            
            
            
            
            
            
            
            
this.SourceConversationId = SourceConversationId;
            
            
            
            
            
            
            
            
this.DestinationConversationId = DestinationConversationId;
            
            
            
            
            
            
            
            
this.SourceSessionId = SourceSessionId;
            
            
            
            
            
            
            
            
this.DestinationSessionId = DestinationSessionId;
            
            
            
            
            
            
            
            
this.SipResponseCodes = SipResponseCodes;
            
            
            
            
            
            
            
            
this.Q850ResponseCodes = Q850ResponseCodes;
            
            
            
            
            
            
            
            
this.Conference = Conference;
            
            
            
            
            
            
            
            
this.GroupId = GroupId;
            
            
            
            
            
            
            
            
this.Subject = Subject;
            
            
            
            
            
            
            
            
this.AudioMuted = AudioMuted;
            
            
            
            
            
            
            
            
this.VideoMuted = VideoMuted;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The timestamp when this segment began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this segment began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="segmentStart", EmitDefaultValue=false)]
        public DateTime? SegmentStart { get; set; }
        
        
        
        /// <summary>
        /// The timestamp when this segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="segmentEnd", EmitDefaultValue=false)]
        public DateTime? SegmentEnd { get; set; }
        
        
        
        /// <summary>
        /// Queue identifier
        /// </summary>
        /// <value>Queue identifier</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        /// <summary>
        /// Wrapup Code id
        /// </summary>
        /// <value>Wrapup Code id</value>
        [DataMember(Name="wrapUpCode", EmitDefaultValue=false)]
        public string WrapUpCode { get; set; }
        
        
        
        /// <summary>
        /// Note entered by an agent during after-call work
        /// </summary>
        /// <value>Note entered by an agent during after-call work</value>
        [DataMember(Name="wrapUpNote", EmitDefaultValue=false)]
        public string WrapUpNote { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets WrapUpTags
        /// </summary>
        [DataMember(Name="wrapUpTags", EmitDefaultValue=false)]
        public List<string> WrapUpTags { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets RequestedRoutingUserIds
        /// </summary>
        [DataMember(Name="requestedRoutingUserIds", EmitDefaultValue=false)]
        public List<string> RequestedRoutingUserIds { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RequestedRoutingSkillIds
        /// </summary>
        [DataMember(Name="requestedRoutingSkillIds", EmitDefaultValue=false)]
        public List<string> RequestedRoutingSkillIds { get; set; }
        
        
        
        /// <summary>
        /// A unique identifier for the language requested for an interaction.
        /// </summary>
        /// <value>A unique identifier for the language requested for an interaction.</value>
        [DataMember(Name="requestedLanguageId", EmitDefaultValue=false)]
        public string RequestedLanguageId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<AnalyticsProperty> Properties { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SourceConversationId
        /// </summary>
        [DataMember(Name="sourceConversationId", EmitDefaultValue=false)]
        public string SourceConversationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DestinationConversationId
        /// </summary>
        [DataMember(Name="destinationConversationId", EmitDefaultValue=false)]
        public string DestinationConversationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SourceSessionId
        /// </summary>
        [DataMember(Name="sourceSessionId", EmitDefaultValue=false)]
        public string SourceSessionId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DestinationSessionId
        /// </summary>
        [DataMember(Name="destinationSessionId", EmitDefaultValue=false)]
        public string DestinationSessionId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SipResponseCodes
        /// </summary>
        [DataMember(Name="sipResponseCodes", EmitDefaultValue=false)]
        public List<long?> SipResponseCodes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Q850ResponseCodes
        /// </summary>
        [DataMember(Name="q850ResponseCodes", EmitDefaultValue=false)]
        public List<long?> Q850ResponseCodes { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether the segment was a conference
        /// </summary>
        /// <value>Indicates whether the segment was a conference</value>
        [DataMember(Name="conference", EmitDefaultValue=false)]
        public bool? Conference { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AudioMuted
        /// </summary>
        [DataMember(Name="audioMuted", EmitDefaultValue=false)]
        public bool? AudioMuted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets VideoMuted
        /// </summary>
        [DataMember(Name="videoMuted", EmitDefaultValue=false)]
        public bool? VideoMuted { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsConversationSegment {\n");
            
            sb.Append("  SegmentStart: ").Append(SegmentStart).Append("\n");
            
            sb.Append("  SegmentEnd: ").Append(SegmentEnd).Append("\n");
            
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            
            sb.Append("  WrapUpCode: ").Append(WrapUpCode).Append("\n");
            
            sb.Append("  WrapUpNote: ").Append(WrapUpNote).Append("\n");
            
            sb.Append("  WrapUpTags: ").Append(WrapUpTags).Append("\n");
            
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            
            sb.Append("  SegmentType: ").Append(SegmentType).Append("\n");
            
            sb.Append("  RequestedRoutingUserIds: ").Append(RequestedRoutingUserIds).Append("\n");
            
            sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
            
            sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
            
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            
            sb.Append("  SourceConversationId: ").Append(SourceConversationId).Append("\n");
            
            sb.Append("  DestinationConversationId: ").Append(DestinationConversationId).Append("\n");
            
            sb.Append("  SourceSessionId: ").Append(SourceSessionId).Append("\n");
            
            sb.Append("  DestinationSessionId: ").Append(DestinationSessionId).Append("\n");
            
            sb.Append("  SipResponseCodes: ").Append(SipResponseCodes).Append("\n");
            
            sb.Append("  Q850ResponseCodes: ").Append(Q850ResponseCodes).Append("\n");
            
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            
            sb.Append("  AudioMuted: ").Append(AudioMuted).Append("\n");
            
            sb.Append("  VideoMuted: ").Append(VideoMuted).Append("\n");
            
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
                    this.SegmentStart == other.SegmentStart ||
                    this.SegmentStart != null &&
                    this.SegmentStart.Equals(other.SegmentStart)
                ) &&
                (
                    this.SegmentEnd == other.SegmentEnd ||
                    this.SegmentEnd != null &&
                    this.SegmentEnd.Equals(other.SegmentEnd)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
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
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.SegmentType == other.SegmentType ||
                    this.SegmentType != null &&
                    this.SegmentType.Equals(other.SegmentType)
                ) &&
                (
                    this.RequestedRoutingUserIds == other.RequestedRoutingUserIds ||
                    this.RequestedRoutingUserIds != null &&
                    this.RequestedRoutingUserIds.SequenceEqual(other.RequestedRoutingUserIds)
                ) &&
                (
                    this.RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                    this.RequestedRoutingSkillIds != null &&
                    this.RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
                ) &&
                (
                    this.RequestedLanguageId == other.RequestedLanguageId ||
                    this.RequestedLanguageId != null &&
                    this.RequestedLanguageId.Equals(other.RequestedLanguageId)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) &&
                (
                    this.SourceConversationId == other.SourceConversationId ||
                    this.SourceConversationId != null &&
                    this.SourceConversationId.Equals(other.SourceConversationId)
                ) &&
                (
                    this.DestinationConversationId == other.DestinationConversationId ||
                    this.DestinationConversationId != null &&
                    this.DestinationConversationId.Equals(other.DestinationConversationId)
                ) &&
                (
                    this.SourceSessionId == other.SourceSessionId ||
                    this.SourceSessionId != null &&
                    this.SourceSessionId.Equals(other.SourceSessionId)
                ) &&
                (
                    this.DestinationSessionId == other.DestinationSessionId ||
                    this.DestinationSessionId != null &&
                    this.DestinationSessionId.Equals(other.DestinationSessionId)
                ) &&
                (
                    this.SipResponseCodes == other.SipResponseCodes ||
                    this.SipResponseCodes != null &&
                    this.SipResponseCodes.SequenceEqual(other.SipResponseCodes)
                ) &&
                (
                    this.Q850ResponseCodes == other.Q850ResponseCodes ||
                    this.Q850ResponseCodes != null &&
                    this.Q850ResponseCodes.SequenceEqual(other.Q850ResponseCodes)
                ) &&
                (
                    this.Conference == other.Conference ||
                    this.Conference != null &&
                    this.Conference.Equals(other.Conference)
                ) &&
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.AudioMuted == other.AudioMuted ||
                    this.AudioMuted != null &&
                    this.AudioMuted.Equals(other.AudioMuted)
                ) &&
                (
                    this.VideoMuted == other.VideoMuted ||
                    this.VideoMuted != null &&
                    this.VideoMuted.Equals(other.VideoMuted)
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
                
                if (this.SegmentStart != null)
                    hash = hash * 59 + this.SegmentStart.GetHashCode();
                
                if (this.SegmentEnd != null)
                    hash = hash * 59 + this.SegmentEnd.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.WrapUpCode != null)
                    hash = hash * 59 + this.WrapUpCode.GetHashCode();
                
                if (this.WrapUpNote != null)
                    hash = hash * 59 + this.WrapUpNote.GetHashCode();
                
                if (this.WrapUpTags != null)
                    hash = hash * 59 + this.WrapUpTags.GetHashCode();
                
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                
                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();
                
                if (this.SegmentType != null)
                    hash = hash * 59 + this.SegmentType.GetHashCode();
                
                if (this.RequestedRoutingUserIds != null)
                    hash = hash * 59 + this.RequestedRoutingUserIds.GetHashCode();
                
                if (this.RequestedRoutingSkillIds != null)
                    hash = hash * 59 + this.RequestedRoutingSkillIds.GetHashCode();
                
                if (this.RequestedLanguageId != null)
                    hash = hash * 59 + this.RequestedLanguageId.GetHashCode();
                
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                
                if (this.SourceConversationId != null)
                    hash = hash * 59 + this.SourceConversationId.GetHashCode();
                
                if (this.DestinationConversationId != null)
                    hash = hash * 59 + this.DestinationConversationId.GetHashCode();
                
                if (this.SourceSessionId != null)
                    hash = hash * 59 + this.SourceSessionId.GetHashCode();
                
                if (this.DestinationSessionId != null)
                    hash = hash * 59 + this.DestinationSessionId.GetHashCode();
                
                if (this.SipResponseCodes != null)
                    hash = hash * 59 + this.SipResponseCodes.GetHashCode();
                
                if (this.Q850ResponseCodes != null)
                    hash = hash * 59 + this.Q850ResponseCodes.GetHashCode();
                
                if (this.Conference != null)
                    hash = hash * 59 + this.Conference.GetHashCode();
                
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                
                if (this.AudioMuted != null)
                    hash = hash * 59 + this.AudioMuted.GetHashCode();
                
                if (this.VideoMuted != null)
                    hash = hash * 59 + this.VideoMuted.GetHashCode();
                
                return hash;
            }
        }
    }

}
