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
    /// AgentStateEventTopicAgentStateEventNotification
    /// </summary>
    [DataContract]
    public partial class AgentStateEventTopicAgentStateEventNotification :  IEquatable<AgentStateEventTopicAgentStateEventNotification>
    {
        /// <summary>
        /// Gets or Sets CurrentState
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CurrentStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Alert for "ALERT"
            /// </summary>
            [EnumMember(Value = "ALERT")]
            Alert,
            
            /// <summary>
            /// Enum Interact for "INTERACT"
            /// </summary>
            [EnumMember(Value = "INTERACT")]
            Interact,
            
            /// <summary>
            /// Enum Wrapup for "WRAPUP"
            /// </summary>
            [EnumMember(Value = "WRAPUP")]
            Wrapup,
            
            /// <summary>
            /// Enum Barging for "BARGING"
            /// </summary>
            [EnumMember(Value = "BARGING")]
            Barging,
            
            /// <summary>
            /// Enum Callback for "CALLBACK"
            /// </summary>
            [EnumMember(Value = "CALLBACK")]
            Callback,
            
            /// <summary>
            /// Enum Coaching for "COACHING"
            /// </summary>
            [EnumMember(Value = "COACHING")]
            Coaching,
            
            /// <summary>
            /// Enum Contacting for "CONTACTING"
            /// </summary>
            [EnumMember(Value = "CONTACTING")]
            Contacting,
            
            /// <summary>
            /// Enum Converting for "CONVERTING"
            /// </summary>
            [EnumMember(Value = "CONVERTING")]
            Converting,
            
            /// <summary>
            /// Enum Delay for "DELAY"
            /// </summary>
            [EnumMember(Value = "DELAY")]
            Delay,
            
            /// <summary>
            /// Enum Dialing for "DIALING"
            /// </summary>
            [EnumMember(Value = "DIALING")]
            Dialing,
            
            /// <summary>
            /// Enum Hold for "HOLD"
            /// </summary>
            [EnumMember(Value = "HOLD")]
            Hold,
            
            /// <summary>
            /// Enum Ivr for "IVR"
            /// </summary>
            [EnumMember(Value = "IVR")]
            Ivr,
            
            /// <summary>
            /// Enum Monitoring for "MONITORING"
            /// </summary>
            [EnumMember(Value = "MONITORING")]
            Monitoring,
            
            /// <summary>
            /// Enum Parked for "PARKED"
            /// </summary>
            [EnumMember(Value = "PARKED")]
            Parked,
            
            /// <summary>
            /// Enum Scheduled for "SCHEDULED"
            /// </summary>
            [EnumMember(Value = "SCHEDULED")]
            Scheduled,
            
            /// <summary>
            /// Enum Sharing for "SHARING"
            /// </summary>
            [EnumMember(Value = "SHARING")]
            Sharing,
            
            /// <summary>
            /// Enum System for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            System,
            
            /// <summary>
            /// Enum Transmitting for "TRANSMITTING"
            /// </summary>
            [EnumMember(Value = "TRANSMITTING")]
            Transmitting,
            
            /// <summary>
            /// Enum Uploading for "UPLOADING"
            /// </summary>
            [EnumMember(Value = "UPLOADING")]
            Uploading,
            
            /// <summary>
            /// Enum Voicemail for "VOICEMAIL"
            /// </summary>
            [EnumMember(Value = "VOICEMAIL")]
            Voicemail,
            
            /// <summary>
            /// Enum Terminated for "TERMINATED"
            /// </summary>
            [EnumMember(Value = "TERMINATED")]
            Terminated
        }
        /// <summary>
        /// Gets or Sets OriginatingDirection
        /// </summary>
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
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Inbound for "INBOUND"
            /// </summary>
            [EnumMember(Value = "INBOUND")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "OUTBOUND"
            /// </summary>
            [EnumMember(Value = "OUTBOUND")]
            Outbound
        }
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
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
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Voice for "VOICE"
            /// </summary>
            [EnumMember(Value = "VOICE")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "CHAT"
            /// </summary>
            [EnumMember(Value = "CHAT")]
            Chat,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email,
            
            /// <summary>
            /// Enum Callback for "CALLBACK"
            /// </summary>
            [EnumMember(Value = "CALLBACK")]
            Callback,
            
            /// <summary>
            /// Enum Cobrowse for "COBROWSE"
            /// </summary>
            [EnumMember(Value = "COBROWSE")]
            Cobrowse,
            
            /// <summary>
            /// Enum Video for "VIDEO"
            /// </summary>
            [EnumMember(Value = "VIDEO")]
            Video,
            
            /// <summary>
            /// Enum Screenshare for "SCREENSHARE"
            /// </summary>
            [EnumMember(Value = "SCREENSHARE")]
            Screenshare,
            
            /// <summary>
            /// Enum Message for "MESSAGE"
            /// </summary>
            [EnumMember(Value = "MESSAGE")]
            Message,
            
            /// <summary>
            /// Enum Internalmessage for "INTERNALMESSAGE"
            /// </summary>
            [EnumMember(Value = "INTERNALMESSAGE")]
            Internalmessage,
            
            /// <summary>
            /// Enum Screenmonitoring for "SCREENMONITORING"
            /// </summary>
            [EnumMember(Value = "SCREENMONITORING")]
            Screenmonitoring
        }
        /// <summary>
        /// Gets or Sets CurrentState
        /// </summary>
        [DataMember(Name="currentState", EmitDefaultValue=false)]
        public CurrentStateEnum? CurrentState { get; set; }
        /// <summary>
        /// Gets or Sets OriginatingDirection
        /// </summary>
        [DataMember(Name="originatingDirection", EmitDefaultValue=false)]
        public OriginatingDirectionEnum? OriginatingDirection { get; set; }
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStateEventTopicAgentStateEventNotification" /> class.
        /// </summary>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="SessionId">SessionId.</param>
        /// <param name="SessionStart">SessionStart.</param>
        /// <param name="CurrentStateStart">CurrentStateStart.</param>
        /// <param name="CurrentState">CurrentState.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="OriginatingDirection">OriginatingDirection.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="QueueId">QueueId.</param>
        /// <param name="RequestedLanguageId">RequestedLanguageId.</param>
        /// <param name="RequestedSkillIds">RequestedSkillIds.</param>
        public AgentStateEventTopicAgentStateEventNotification(string ConversationId = null, string SessionId = null, long? SessionStart = null, long? CurrentStateStart = null, CurrentStateEnum? CurrentState = null, string UserId = null, OriginatingDirectionEnum? OriginatingDirection = null, MediaTypeEnum? MediaType = null, string QueueId = null, string RequestedLanguageId = null, List<Guid?> RequestedSkillIds = null)
        {
            this.ConversationId = ConversationId;
            this.SessionId = SessionId;
            this.SessionStart = SessionStart;
            this.CurrentStateStart = CurrentStateStart;
            this.CurrentState = CurrentState;
            this.UserId = UserId;
            this.OriginatingDirection = OriginatingDirection;
            this.MediaType = MediaType;
            this.QueueId = QueueId;
            this.RequestedLanguageId = RequestedLanguageId;
            this.RequestedSkillIds = RequestedSkillIds;
            
        }
        


        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// Gets or Sets SessionStart
        /// </summary>
        [DataMember(Name="sessionStart", EmitDefaultValue=false)]
        public long? SessionStart { get; set; }



        /// <summary>
        /// Gets or Sets CurrentStateStart
        /// </summary>
        [DataMember(Name="currentStateStart", EmitDefaultValue=false)]
        public long? CurrentStateStart { get; set; }





        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }







        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// Gets or Sets RequestedLanguageId
        /// </summary>
        [DataMember(Name="requestedLanguageId", EmitDefaultValue=false)]
        public string RequestedLanguageId { get; set; }



        /// <summary>
        /// Gets or Sets RequestedSkillIds
        /// </summary>
        [DataMember(Name="requestedSkillIds", EmitDefaultValue=false)]
        public List<Guid?> RequestedSkillIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentStateEventTopicAgentStateEventNotification {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  SessionStart: ").Append(SessionStart).Append("\n");
            sb.Append("  CurrentStateStart: ").Append(CurrentStateStart).Append("\n");
            sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
            sb.Append("  RequestedSkillIds: ").Append(RequestedSkillIds).Append("\n");
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
            return this.Equals(obj as AgentStateEventTopicAgentStateEventNotification);
        }

        /// <summary>
        /// Returns true if AgentStateEventTopicAgentStateEventNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentStateEventTopicAgentStateEventNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentStateEventTopicAgentStateEventNotification other)
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
                    this.CurrentStateStart == other.CurrentStateStart ||
                    this.CurrentStateStart != null &&
                    this.CurrentStateStart.Equals(other.CurrentStateStart)
                ) &&
                (
                    this.CurrentState == other.CurrentState ||
                    this.CurrentState != null &&
                    this.CurrentState.Equals(other.CurrentState)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                    this.RequestedSkillIds == other.RequestedSkillIds ||
                    this.RequestedSkillIds != null &&
                    this.RequestedSkillIds.SequenceEqual(other.RequestedSkillIds)
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

                if (this.CurrentStateStart != null)
                    hash = hash * 59 + this.CurrentStateStart.GetHashCode();

                if (this.CurrentState != null)
                    hash = hash * 59 + this.CurrentState.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.OriginatingDirection != null)
                    hash = hash * 59 + this.OriginatingDirection.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.RequestedLanguageId != null)
                    hash = hash * 59 + this.RequestedLanguageId.GetHashCode();

                if (this.RequestedSkillIds != null)
                    hash = hash * 59 + this.RequestedSkillIds.GetHashCode();

                return hash;
            }
        }
    }

}
