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
    /// AnalyticsAgentStateAgentSessionResult
    /// </summary>
    [DataContract]
    public partial class AnalyticsAgentStateAgentSessionResult :  IEquatable<AnalyticsAgentStateAgentSessionResult>
    {
        /// <summary>
        /// Segment type
        /// </summary>
        /// <value>Segment type</value>
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
            /// Enum Barging for "barging"
            /// </summary>
            [EnumMember(Value = "barging")]
            Barging,
            
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
            /// Enum Parked for "parked"
            /// </summary>
            [EnumMember(Value = "parked")]
            Parked,
            
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
        /// Originating direction
        /// </summary>
        /// <value>Originating direction</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OriginatingDirectionEnum
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
        /// Media type
        /// </summary>
        /// <value>Media type</value>
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
            /// Enum Internalmessage for "internalmessage"
            /// </summary>
            [EnumMember(Value = "internalmessage")]
            Internalmessage,
            
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
        /// Segment type
        /// </summary>
        /// <value>Segment type</value>
        [DataMember(Name="segmentType", EmitDefaultValue=false)]
        public SegmentTypeEnum? SegmentType { get; set; }
        /// <summary>
        /// Originating direction
        /// </summary>
        /// <value>Originating direction</value>
        [DataMember(Name="originatingDirection", EmitDefaultValue=false)]
        public OriginatingDirectionEnum? OriginatingDirection { get; set; }
        /// <summary>
        /// Media type
        /// </summary>
        /// <value>Media type</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsAgentStateAgentSessionResult" /> class.
        /// </summary>
        /// <param name="ConversationId">Conversation Id.</param>
        /// <param name="SessionId">Session Id.</param>
        /// <param name="SessionStart">Session start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="SegmentStart">Segment start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="SegmentType">Segment type.</param>
        /// <param name="RoutedQueueId">Routed queue Id.</param>
        /// <param name="RequestedRoutingSkillIds">List of requested routing skill Id.</param>
        /// <param name="RequestedLanguageId">Requested language Id.</param>
        /// <param name="OriginatingDirection">Originating direction.</param>
        /// <param name="MediaType">Media type.</param>
        public AnalyticsAgentStateAgentSessionResult(string ConversationId = null, string SessionId = null, DateTime? SessionStart = null, DateTime? SegmentStart = null, SegmentTypeEnum? SegmentType = null, string RoutedQueueId = null, List<string> RequestedRoutingSkillIds = null, string RequestedLanguageId = null, OriginatingDirectionEnum? OriginatingDirection = null, MediaTypeEnum? MediaType = null)
        {
            this.ConversationId = ConversationId;
            this.SessionId = SessionId;
            this.SessionStart = SessionStart;
            this.SegmentStart = SegmentStart;
            this.SegmentType = SegmentType;
            this.RoutedQueueId = RoutedQueueId;
            this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
            this.RequestedLanguageId = RequestedLanguageId;
            this.OriginatingDirection = OriginatingDirection;
            this.MediaType = MediaType;
            
        }
        


        /// <summary>
        /// Conversation Id
        /// </summary>
        /// <value>Conversation Id</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// Session Id
        /// </summary>
        /// <value>Session Id</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// Session start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Session start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="sessionStart", EmitDefaultValue=false)]
        public DateTime? SessionStart { get; set; }



        /// <summary>
        /// Segment start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Segment start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="segmentStart", EmitDefaultValue=false)]
        public DateTime? SegmentStart { get; set; }





        /// <summary>
        /// Routed queue Id
        /// </summary>
        /// <value>Routed queue Id</value>
        [DataMember(Name="routedQueueId", EmitDefaultValue=false)]
        public string RoutedQueueId { get; set; }



        /// <summary>
        /// List of requested routing skill Id
        /// </summary>
        /// <value>List of requested routing skill Id</value>
        [DataMember(Name="requestedRoutingSkillIds", EmitDefaultValue=false)]
        public List<string> RequestedRoutingSkillIds { get; set; }



        /// <summary>
        /// Requested language Id
        /// </summary>
        /// <value>Requested language Id</value>
        [DataMember(Name="requestedLanguageId", EmitDefaultValue=false)]
        public string RequestedLanguageId { get; set; }






        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsAgentStateAgentSessionResult {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  SessionStart: ").Append(SessionStart).Append("\n");
            sb.Append("  SegmentStart: ").Append(SegmentStart).Append("\n");
            sb.Append("  SegmentType: ").Append(SegmentType).Append("\n");
            sb.Append("  RoutedQueueId: ").Append(RoutedQueueId).Append("\n");
            sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
            sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
            sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
            return this.Equals(obj as AnalyticsAgentStateAgentSessionResult);
        }

        /// <summary>
        /// Returns true if AnalyticsAgentStateAgentSessionResult instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsAgentStateAgentSessionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsAgentStateAgentSessionResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.SessionStart == other.SessionStart ||
                    this.SessionStart != null &&
                    this.SessionStart.Equals(other.SessionStart)
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
                    this.RoutedQueueId == other.RoutedQueueId ||
                    this.RoutedQueueId != null &&
                    this.RoutedQueueId.Equals(other.RoutedQueueId)
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
                    this.OriginatingDirection == other.OriginatingDirection ||
                    this.OriginatingDirection != null &&
                    this.OriginatingDirection.Equals(other.OriginatingDirection)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
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
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.SessionStart != null)
                    hash = hash * 59 + this.SessionStart.GetHashCode();

                if (this.SegmentStart != null)
                    hash = hash * 59 + this.SegmentStart.GetHashCode();

                if (this.SegmentType != null)
                    hash = hash * 59 + this.SegmentType.GetHashCode();

                if (this.RoutedQueueId != null)
                    hash = hash * 59 + this.RoutedQueueId.GetHashCode();

                if (this.RequestedRoutingSkillIds != null)
                    hash = hash * 59 + this.RequestedRoutingSkillIds.GetHashCode();

                if (this.RequestedLanguageId != null)
                    hash = hash * 59 + this.RequestedLanguageId.GetHashCode();

                if (this.OriginatingDirection != null)
                    hash = hash * 59 + this.OriginatingDirection.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                return hash;
            }
        }
    }

}
