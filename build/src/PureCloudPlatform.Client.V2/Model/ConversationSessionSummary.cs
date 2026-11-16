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
    /// ConversationSessionSummary
    /// </summary>
    [DataContract]
    public partial class ConversationSessionSummary :  IEquatable<ConversationSessionSummary>
    {
        /// <summary>
        /// The status of the conversation summary.
        /// </summary>
        /// <value>The status of the conversation summary.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Queued for "Queued"
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued,
            
            /// <summary>
            /// Enum Started for "Started"
            /// </summary>
            [EnumMember(Value = "Started")]
            Started,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing
        }
        /// <summary>
        /// The media type of the conversation.
        /// </summary>
        /// <value>The media type of the conversation.</value>
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
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Webmessaging for "Webmessaging"
            /// </summary>
            [EnumMember(Value = "Webmessaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The service used to generate the summary.
        /// </summary>
        /// <value>The service used to generate the summary.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SummarySourceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Genesysnativeservice for "GenesysNativeService"
            /// </summary>
            [EnumMember(Value = "GenesysNativeService")]
            Genesysnativeservice,
            
            /// <summary>
            /// Enum Externalservice for "ExternalService"
            /// </summary>
            [EnumMember(Value = "ExternalService")]
            Externalservice
        }
        /// <summary>
        /// How summarization was triggered, either on-demand by an agent or automatically after the conversation disconnect.
        /// </summary>
        /// <value>How summarization was triggered, either on-demand by an agent or automatically after the conversation disconnect.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TriggerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ondemand for "OnDemand"
            /// </summary>
            [EnumMember(Value = "OnDemand")]
            Ondemand,
            
            /// <summary>
            /// Enum Afterdisconnect for "AfterDisconnect"
            /// </summary>
            [EnumMember(Value = "AfterDisconnect")]
            Afterdisconnect
        }
        /// <summary>
        /// The status of the conversation summary.
        /// </summary>
        /// <value>The status of the conversation summary.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The media type of the conversation.
        /// </summary>
        /// <value>The media type of the conversation.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// The service used to generate the summary.
        /// </summary>
        /// <value>The service used to generate the summary.</value>
        [DataMember(Name="summarySourceType", EmitDefaultValue=false)]
        public SummarySourceTypeEnum? SummarySourceType { get; set; }
        /// <summary>
        /// How summarization was triggered, either on-demand by an agent or automatically after the conversation disconnect.
        /// </summary>
        /// <value>How summarization was triggered, either on-demand by an agent or automatically after the conversation disconnect.</value>
        [DataMember(Name="triggerType", EmitDefaultValue=false)]
        public TriggerTypeEnum? TriggerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSessionSummary" /> class.
        /// </summary>
        /// <param name="Id">The id of the summary..</param>
        /// <param name="Text">The text of the summary..</param>
        /// <param name="Confidence">The AI confidence value..</param>
        /// <param name="Status">The status of the conversation summary..</param>
        /// <param name="MediaType">The media type of the conversation..</param>
        /// <param name="Language">The language of the conversation..</param>
        /// <param name="PredictedWrapupCodes">The wrapup codes of the conversation summary..</param>
        /// <param name="EditedSummary">The edited summary of the conversation..</param>
        /// <param name="Reason">The reason of the conversation summary..</param>
        /// <param name="Followup">The followup of the conversation summary..</param>
        /// <param name="Resolution">The resolution of the conversation summary..</param>
        /// <param name="DateCreated">The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="LatestCommunication">The most recent communication whose corresponding content was used for generating the summary. This field will be null if not available..</param>
        /// <param name="Labels">The summary labels..</param>
        /// <param name="Queue">The queue that handled the conversation, if any..</param>
        /// <param name="TriggerSource">The configuration source that triggered summarization..</param>
        /// <param name="SummarySourceType">The service used to generate the summary..</param>
        /// <param name="TriggerType">How summarization was triggered, either on-demand by an agent or automatically after the conversation disconnect..</param>
        /// <param name="LastEditedBy">The user that last edited the summary, if the summary was edited..</param>
        /// <param name="Communication">The communication object of the summary..</param>
        /// <param name="Participants">The list of participants..</param>
        public ConversationSessionSummary(string Id = null, string Text = null, float? Confidence = null, StatusEnum? Status = null, MediaTypeEnum? MediaType = null, string Language = null, List<ConversationSummaryWrapupCode> PredictedWrapupCodes = null, ConversationEditedInput EditedSummary = null, ConversationSummaryReason Reason = null, ConversationSummaryFollowup Followup = null, ConversationSummaryResolution Resolution = null, DateTime? DateCreated = null, Entity LatestCommunication = null, List<ConversationSummaryLabel> Labels = null, AddressableEntityRef Queue = null, ConversationSummaryTriggerSource TriggerSource = null, SummarySourceTypeEnum? SummarySourceType = null, TriggerTypeEnum? TriggerType = null, ConversationSummaryEditedBy LastEditedBy = null, Entity Communication = null, List<AddressableEntityRef> Participants = null)
        {
            this.Id = Id;
            this.Text = Text;
            this.Confidence = Confidence;
            this.Status = Status;
            this.MediaType = MediaType;
            this.Language = Language;
            this.PredictedWrapupCodes = PredictedWrapupCodes;
            this.EditedSummary = EditedSummary;
            this.Reason = Reason;
            this.Followup = Followup;
            this.Resolution = Resolution;
            this.DateCreated = DateCreated;
            this.LatestCommunication = LatestCommunication;
            this.Labels = Labels;
            this.Queue = Queue;
            this.TriggerSource = TriggerSource;
            this.SummarySourceType = SummarySourceType;
            this.TriggerType = TriggerType;
            this.LastEditedBy = LastEditedBy;
            this.Communication = Communication;
            this.Participants = Participants;
            
        }
        


        /// <summary>
        /// The id of the summary.
        /// </summary>
        /// <value>The id of the summary.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The text of the summary.
        /// </summary>
        /// <value>The text of the summary.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// The AI confidence value.
        /// </summary>
        /// <value>The AI confidence value.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public float? Confidence { get; set; }







        /// <summary>
        /// The language of the conversation.
        /// </summary>
        /// <value>The language of the conversation.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// The wrapup codes of the conversation summary.
        /// </summary>
        /// <value>The wrapup codes of the conversation summary.</value>
        [DataMember(Name="predictedWrapupCodes", EmitDefaultValue=false)]
        public List<ConversationSummaryWrapupCode> PredictedWrapupCodes { get; set; }



        /// <summary>
        /// The edited summary of the conversation.
        /// </summary>
        /// <value>The edited summary of the conversation.</value>
        [DataMember(Name="editedSummary", EmitDefaultValue=false)]
        public ConversationEditedInput EditedSummary { get; set; }



        /// <summary>
        /// The reason of the conversation summary.
        /// </summary>
        /// <value>The reason of the conversation summary.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ConversationSummaryReason Reason { get; set; }



        /// <summary>
        /// The followup of the conversation summary.
        /// </summary>
        /// <value>The followup of the conversation summary.</value>
        [DataMember(Name="followup", EmitDefaultValue=false)]
        public ConversationSummaryFollowup Followup { get; set; }



        /// <summary>
        /// The resolution of the conversation summary.
        /// </summary>
        /// <value>The resolution of the conversation summary.</value>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public ConversationSummaryResolution Resolution { get; set; }



        /// <summary>
        /// The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The most recent communication whose corresponding content was used for generating the summary. This field will be null if not available.
        /// </summary>
        /// <value>The most recent communication whose corresponding content was used for generating the summary. This field will be null if not available.</value>
        [DataMember(Name="latestCommunication", EmitDefaultValue=false)]
        public Entity LatestCommunication { get; set; }



        /// <summary>
        /// The summary labels.
        /// </summary>
        /// <value>The summary labels.</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<ConversationSummaryLabel> Labels { get; set; }



        /// <summary>
        /// The queue that handled the conversation, if any.
        /// </summary>
        /// <value>The queue that handled the conversation, if any.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public AddressableEntityRef Queue { get; set; }



        /// <summary>
        /// The configuration source that triggered summarization.
        /// </summary>
        /// <value>The configuration source that triggered summarization.</value>
        [DataMember(Name="triggerSource", EmitDefaultValue=false)]
        public ConversationSummaryTriggerSource TriggerSource { get; set; }







        /// <summary>
        /// The user that last edited the summary, if the summary was edited.
        /// </summary>
        /// <value>The user that last edited the summary, if the summary was edited.</value>
        [DataMember(Name="lastEditedBy", EmitDefaultValue=false)]
        public ConversationSummaryEditedBy LastEditedBy { get; set; }



        /// <summary>
        /// The communication object of the summary.
        /// </summary>
        /// <value>The communication object of the summary.</value>
        [DataMember(Name="communication", EmitDefaultValue=false)]
        public Entity Communication { get; set; }



        /// <summary>
        /// The list of participants.
        /// </summary>
        /// <value>The list of participants.</value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Participants { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSessionSummary {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  PredictedWrapupCodes: ").Append(PredictedWrapupCodes).Append("\n");
            sb.Append("  EditedSummary: ").Append(EditedSummary).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Followup: ").Append(Followup).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  LatestCommunication: ").Append(LatestCommunication).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  TriggerSource: ").Append(TriggerSource).Append("\n");
            sb.Append("  SummarySourceType: ").Append(SummarySourceType).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  LastEditedBy: ").Append(LastEditedBy).Append("\n");
            sb.Append("  Communication: ").Append(Communication).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
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
            return this.Equals(obj as ConversationSessionSummary);
        }

        /// <summary>
        /// Returns true if ConversationSessionSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSessionSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSessionSummary other)
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
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.PredictedWrapupCodes == other.PredictedWrapupCodes ||
                    this.PredictedWrapupCodes != null &&
                    this.PredictedWrapupCodes.SequenceEqual(other.PredictedWrapupCodes)
                ) &&
                (
                    this.EditedSummary == other.EditedSummary ||
                    this.EditedSummary != null &&
                    this.EditedSummary.Equals(other.EditedSummary)
                ) &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) &&
                (
                    this.Followup == other.Followup ||
                    this.Followup != null &&
                    this.Followup.Equals(other.Followup)
                ) &&
                (
                    this.Resolution == other.Resolution ||
                    this.Resolution != null &&
                    this.Resolution.Equals(other.Resolution)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.LatestCommunication == other.LatestCommunication ||
                    this.LatestCommunication != null &&
                    this.LatestCommunication.Equals(other.LatestCommunication)
                ) &&
                (
                    this.Labels == other.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(other.Labels)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.TriggerSource == other.TriggerSource ||
                    this.TriggerSource != null &&
                    this.TriggerSource.Equals(other.TriggerSource)
                ) &&
                (
                    this.SummarySourceType == other.SummarySourceType ||
                    this.SummarySourceType != null &&
                    this.SummarySourceType.Equals(other.SummarySourceType)
                ) &&
                (
                    this.TriggerType == other.TriggerType ||
                    this.TriggerType != null &&
                    this.TriggerType.Equals(other.TriggerType)
                ) &&
                (
                    this.LastEditedBy == other.LastEditedBy ||
                    this.LastEditedBy != null &&
                    this.LastEditedBy.Equals(other.LastEditedBy)
                ) &&
                (
                    this.Communication == other.Communication ||
                    this.Communication != null &&
                    this.Communication.Equals(other.Communication)
                ) &&
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
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

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.PredictedWrapupCodes != null)
                    hash = hash * 59 + this.PredictedWrapupCodes.GetHashCode();

                if (this.EditedSummary != null)
                    hash = hash * 59 + this.EditedSummary.GetHashCode();

                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();

                if (this.Followup != null)
                    hash = hash * 59 + this.Followup.GetHashCode();

                if (this.Resolution != null)
                    hash = hash * 59 + this.Resolution.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.LatestCommunication != null)
                    hash = hash * 59 + this.LatestCommunication.GetHashCode();

                if (this.Labels != null)
                    hash = hash * 59 + this.Labels.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.TriggerSource != null)
                    hash = hash * 59 + this.TriggerSource.GetHashCode();

                if (this.SummarySourceType != null)
                    hash = hash * 59 + this.SummarySourceType.GetHashCode();

                if (this.TriggerType != null)
                    hash = hash * 59 + this.TriggerType.GetHashCode();

                if (this.LastEditedBy != null)
                    hash = hash * 59 + this.LastEditedBy.GetHashCode();

                if (this.Communication != null)
                    hash = hash * 59 + this.Communication.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                return hash;
            }
        }
    }

}
