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
    /// ConversationSummaryTopicConversationSummaryEvent
    /// </summary>
    [DataContract]
    public partial class ConversationSummaryTopicConversationSummaryEvent :  IEquatable<ConversationSummaryTopicConversationSummaryEvent>
    {
        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
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
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Sms for "SMS"
            /// </summary>
            [EnumMember(Value = "SMS")]
            Sms,
            
            /// <summary>
            /// Enum Twitter for "TWITTER"
            /// </summary>
            [EnumMember(Value = "TWITTER")]
            Twitter,
            
            /// <summary>
            /// Enum Facebook for "FACEBOOK"
            /// </summary>
            [EnumMember(Value = "FACEBOOK")]
            Facebook,
            
            /// <summary>
            /// Enum Instagram for "INSTAGRAM"
            /// </summary>
            [EnumMember(Value = "INSTAGRAM")]
            Instagram,
            
            /// <summary>
            /// Enum Line for "LINE"
            /// </summary>
            [EnumMember(Value = "LINE")]
            Line,
            
            /// <summary>
            /// Enum Whatsapp for "WHATSAPP"
            /// </summary>
            [EnumMember(Value = "WHATSAPP")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessaging for "WEBMESSAGING"
            /// </summary>
            [EnumMember(Value = "WEBMESSAGING")]
            Webmessaging,
            
            /// <summary>
            /// Enum Open for "OPEN"
            /// </summary>
            [EnumMember(Value = "OPEN")]
            Open,
            
            /// <summary>
            /// Enum Apple for "APPLE"
            /// </summary>
            [EnumMember(Value = "APPLE")]
            Apple
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
            /// Enum Message for "MESSAGE"
            /// </summary>
            [EnumMember(Value = "MESSAGE")]
            Message,
            
            /// <summary>
            /// Enum Call for "CALL"
            /// </summary>
            [EnumMember(Value = "CALL")]
            Call,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email
        }
        /// <summary>
        /// Gets or Sets ErrorType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ErrorTypeEnum
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
            /// Enum ConversationTooLong for "CONVERSATION_TOO_LONG"
            /// </summary>
            [EnumMember(Value = "CONVERSATION_TOO_LONG")]
            ConversationTooLong,
            
            /// <summary>
            /// Enum ConversationTooShort for "CONVERSATION_TOO_SHORT"
            /// </summary>
            [EnumMember(Value = "CONVERSATION_TOO_SHORT")]
            ConversationTooShort,
            
            /// <summary>
            /// Enum RateLimited for "RATE_LIMITED"
            /// </summary>
            [EnumMember(Value = "RATE_LIMITED")]
            RateLimited
        }
        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Gets or Sets ErrorType
        /// </summary>
        [DataMember(Name="errorType", EmitDefaultValue=false)]
        public ErrorTypeEnum? ErrorType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryTopicConversationSummaryEvent" /> class.
        /// </summary>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="QueueId">QueueId.</param>
        /// <param name="Participants">Participants.</param>
        /// <param name="CommunicationIds">CommunicationIds.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="MessageType">MessageType.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="SummaryId">SummaryId.</param>
        /// <param name="Language">Language.</param>
        /// <param name="Summary">Summary.</param>
        /// <param name="Headline">Headline.</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="Resolution">Resolution.</param>
        /// <param name="WrapUpCodes">WrapUpCodes.</param>
        /// <param name="TriggerSource">TriggerSource.</param>
        /// <param name="LastEditedBy">LastEditedBy.</param>
        /// <param name="ErrorType">ErrorType.</param>
        /// <param name="DurationMs">DurationMs.</param>
        public ConversationSummaryTopicConversationSummaryEvent(Guid? ConversationId = null, Guid? QueueId = null, List<ConversationSummaryTopicConversationSummaryParticipant> Participants = null, List<string> CommunicationIds = null, DateTime? CreatedDate = null, MessageTypeEnum? MessageType = null, MediaTypeEnum? MediaType = null, Guid? SummaryId = null, string Language = null, ConversationSummaryTopicConversationSummary Summary = null, ConversationSummaryTopicConversationHeadline Headline = null, ConversationSummaryTopicConversationReason Reason = null, ConversationSummaryTopicConversationResolution Resolution = null, List<ConversationSummaryTopicConversationWrapUpCode> WrapUpCodes = null, ConversationSummaryTopicTriggerSource TriggerSource = null, ConversationSummaryTopicConversationSummaryParticipant LastEditedBy = null, ErrorTypeEnum? ErrorType = null, long? DurationMs = null)
        {
            this.ConversationId = ConversationId;
            this.QueueId = QueueId;
            this.Participants = Participants;
            this.CommunicationIds = CommunicationIds;
            this.CreatedDate = CreatedDate;
            this.MessageType = MessageType;
            this.MediaType = MediaType;
            this.SummaryId = SummaryId;
            this.Language = Language;
            this.Summary = Summary;
            this.Headline = Headline;
            this.Reason = Reason;
            this.Resolution = Resolution;
            this.WrapUpCodes = WrapUpCodes;
            this.TriggerSource = TriggerSource;
            this.LastEditedBy = LastEditedBy;
            this.ErrorType = ErrorType;
            this.DurationMs = DurationMs;
            
        }
        


        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public Guid? ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public Guid? QueueId { get; set; }



        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<ConversationSummaryTopicConversationSummaryParticipant> Participants { get; set; }



        /// <summary>
        /// Gets or Sets CommunicationIds
        /// </summary>
        [DataMember(Name="communicationIds", EmitDefaultValue=false)]
        public List<string> CommunicationIds { get; set; }



        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }







        /// <summary>
        /// Gets or Sets SummaryId
        /// </summary>
        [DataMember(Name="summaryId", EmitDefaultValue=false)]
        public Guid? SummaryId { get; set; }



        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public ConversationSummaryTopicConversationSummary Summary { get; set; }



        /// <summary>
        /// Gets or Sets Headline
        /// </summary>
        [DataMember(Name="headline", EmitDefaultValue=false)]
        public ConversationSummaryTopicConversationHeadline Headline { get; set; }



        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ConversationSummaryTopicConversationReason Reason { get; set; }



        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public ConversationSummaryTopicConversationResolution Resolution { get; set; }



        /// <summary>
        /// Gets or Sets WrapUpCodes
        /// </summary>
        [DataMember(Name="wrapUpCodes", EmitDefaultValue=false)]
        public List<ConversationSummaryTopicConversationWrapUpCode> WrapUpCodes { get; set; }



        /// <summary>
        /// Gets or Sets TriggerSource
        /// </summary>
        [DataMember(Name="triggerSource", EmitDefaultValue=false)]
        public ConversationSummaryTopicTriggerSource TriggerSource { get; set; }



        /// <summary>
        /// Gets or Sets LastEditedBy
        /// </summary>
        [DataMember(Name="lastEditedBy", EmitDefaultValue=false)]
        public ConversationSummaryTopicConversationSummaryParticipant LastEditedBy { get; set; }





        /// <summary>
        /// Gets or Sets DurationMs
        /// </summary>
        [DataMember(Name="durationMs", EmitDefaultValue=false)]
        public long? DurationMs { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSummaryTopicConversationSummaryEvent {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  CommunicationIds: ").Append(CommunicationIds).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  SummaryId: ").Append(SummaryId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Headline: ").Append(Headline).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  WrapUpCodes: ").Append(WrapUpCodes).Append("\n");
            sb.Append("  TriggerSource: ").Append(TriggerSource).Append("\n");
            sb.Append("  LastEditedBy: ").Append(LastEditedBy).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
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
            return this.Equals(obj as ConversationSummaryTopicConversationSummaryEvent);
        }

        /// <summary>
        /// Returns true if ConversationSummaryTopicConversationSummaryEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSummaryTopicConversationSummaryEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSummaryTopicConversationSummaryEvent other)
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
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
                ) &&
                (
                    this.CommunicationIds == other.CommunicationIds ||
                    this.CommunicationIds != null &&
                    this.CommunicationIds.SequenceEqual(other.CommunicationIds)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.SummaryId == other.SummaryId ||
                    this.SummaryId != null &&
                    this.SummaryId.Equals(other.SummaryId)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) &&
                (
                    this.Headline == other.Headline ||
                    this.Headline != null &&
                    this.Headline.Equals(other.Headline)
                ) &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) &&
                (
                    this.Resolution == other.Resolution ||
                    this.Resolution != null &&
                    this.Resolution.Equals(other.Resolution)
                ) &&
                (
                    this.WrapUpCodes == other.WrapUpCodes ||
                    this.WrapUpCodes != null &&
                    this.WrapUpCodes.SequenceEqual(other.WrapUpCodes)
                ) &&
                (
                    this.TriggerSource == other.TriggerSource ||
                    this.TriggerSource != null &&
                    this.TriggerSource.Equals(other.TriggerSource)
                ) &&
                (
                    this.LastEditedBy == other.LastEditedBy ||
                    this.LastEditedBy != null &&
                    this.LastEditedBy.Equals(other.LastEditedBy)
                ) &&
                (
                    this.ErrorType == other.ErrorType ||
                    this.ErrorType != null &&
                    this.ErrorType.Equals(other.ErrorType)
                ) &&
                (
                    this.DurationMs == other.DurationMs ||
                    this.DurationMs != null &&
                    this.DurationMs.Equals(other.DurationMs)
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

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                if (this.CommunicationIds != null)
                    hash = hash * 59 + this.CommunicationIds.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.SummaryId != null)
                    hash = hash * 59 + this.SummaryId.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();

                if (this.Headline != null)
                    hash = hash * 59 + this.Headline.GetHashCode();

                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();

                if (this.Resolution != null)
                    hash = hash * 59 + this.Resolution.GetHashCode();

                if (this.WrapUpCodes != null)
                    hash = hash * 59 + this.WrapUpCodes.GetHashCode();

                if (this.TriggerSource != null)
                    hash = hash * 59 + this.TriggerSource.GetHashCode();

                if (this.LastEditedBy != null)
                    hash = hash * 59 + this.LastEditedBy.GetHashCode();

                if (this.ErrorType != null)
                    hash = hash * 59 + this.ErrorType.GetHashCode();

                if (this.DurationMs != null)
                    hash = hash * 59 + this.DurationMs.GetHashCode();

                return hash;
            }
        }
    }

}
