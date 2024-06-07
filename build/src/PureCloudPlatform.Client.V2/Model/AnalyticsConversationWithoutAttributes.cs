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
    /// AnalyticsConversationWithoutAttributes
    /// </summary>
    [DataContract]
    public partial class AnalyticsConversationWithoutAttributes :  IEquatable<AnalyticsConversationWithoutAttributes>
    {
        /// <summary>
        /// Indicates the participant purpose of the participant initiating a message conversation
        /// </summary>
        /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ConversationInitiatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Acd for "acd"
            /// </summary>
            [EnumMember(Value = "acd")]
            Acd,
            
            /// <summary>
            /// Enum Agent for "agent"
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent,
            
            /// <summary>
            /// Enum Api for "api"
            /// </summary>
            [EnumMember(Value = "api")]
            Api,
            
            /// <summary>
            /// Enum Botflow for "botflow"
            /// </summary>
            [EnumMember(Value = "botflow")]
            Botflow,
            
            /// <summary>
            /// Enum Campaign for "campaign"
            /// </summary>
            [EnumMember(Value = "campaign")]
            Campaign,
            
            /// <summary>
            /// Enum Customer for "customer"
            /// </summary>
            [EnumMember(Value = "customer")]
            Customer,
            
            /// <summary>
            /// Enum Dialer for "dialer"
            /// </summary>
            [EnumMember(Value = "dialer")]
            Dialer,
            
            /// <summary>
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External,
            
            /// <summary>
            /// Enum Fax for "fax"
            /// </summary>
            [EnumMember(Value = "fax")]
            Fax,
            
            /// <summary>
            /// Enum Group for "group"
            /// </summary>
            [EnumMember(Value = "group")]
            Group,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Ivr for "ivr"
            /// </summary>
            [EnumMember(Value = "ivr")]
            Ivr,
            
            /// <summary>
            /// Enum Manual for "manual"
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Station for "station"
            /// </summary>
            [EnumMember(Value = "station")]
            Station,
            
            /// <summary>
            /// Enum User for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            User,
            
            /// <summary>
            /// Enum Voicemail for "voicemail"
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail,
            
            /// <summary>
            /// Enum Voicesurveyflow for "voicesurveyflow"
            /// </summary>
            [EnumMember(Value = "voicesurveyflow")]
            Voicesurveyflow,
            
            /// <summary>
            /// Enum Workflow for "workflow"
            /// </summary>
            [EnumMember(Value = "workflow")]
            Workflow
        }
        /// <summary>
        /// The original direction of the conversation
        /// </summary>
        /// <value>The original direction of the conversation</value>
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
        /// Indicates the participant purpose of the participant initiating a message conversation
        /// </summary>
        /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
        [DataMember(Name="conversationInitiator", EmitDefaultValue=false)]
        public ConversationInitiatorEnum? ConversationInitiator { get; set; }
        /// <summary>
        /// The original direction of the conversation
        /// </summary>
        /// <value>The original direction of the conversation</value>
        [DataMember(Name="originatingDirection", EmitDefaultValue=false)]
        public OriginatingDirectionEnum? OriginatingDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsConversationWithoutAttributes" /> class.
        /// </summary>
        /// <param name="ConferenceStart">The start time of a conference call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ConversationEnd">The end time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ConversationId">Unique identifier for the conversation.</param>
        /// <param name="ConversationInitiator">Indicates the participant purpose of the participant initiating a message conversation.</param>
        /// <param name="ConversationStart">The start time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CustomerParticipation">Indicates a messaging conversation in which the customer participated by sending at least one message.</param>
        /// <param name="DivisionIds">Identifier(s) of division(s) associated with a conversation.</param>
        /// <param name="ExternalTag">External tag for the conversation.</param>
        /// <param name="KnowledgeBaseIds">The unique identifier(s) of the knowledge base(s) used.</param>
        /// <param name="MediaStatsMinConversationMos">The lowest estimated average MOS among all the audio streams belonging to this conversation.</param>
        /// <param name="MediaStatsMinConversationRFactor">The lowest R-factor value among all of the audio streams belonging to this conversation.</param>
        /// <param name="OriginatingDirection">The original direction of the conversation.</param>
        /// <param name="SelfServed">Indicates whether all flow sessions were self serviced.</param>
        /// <param name="Evaluations">Evaluations associated with this conversation.</param>
        /// <param name="Surveys">Surveys associated with this conversation.</param>
        /// <param name="Resolutions">Resolutions associated with this conversation.</param>
        /// <param name="Participants">Participants in the conversation.</param>
        public AnalyticsConversationWithoutAttributes(DateTime? ConferenceStart = null, DateTime? ConversationEnd = null, string ConversationId = null, ConversationInitiatorEnum? ConversationInitiator = null, DateTime? ConversationStart = null, bool? CustomerParticipation = null, List<string> DivisionIds = null, string ExternalTag = null, List<string> KnowledgeBaseIds = null, double? MediaStatsMinConversationMos = null, double? MediaStatsMinConversationRFactor = null, OriginatingDirectionEnum? OriginatingDirection = null, bool? SelfServed = null, List<AnalyticsEvaluation> Evaluations = null, List<AnalyticsSurvey> Surveys = null, List<AnalyticsResolution> Resolutions = null, List<AnalyticsParticipantWithoutAttributes> Participants = null)
        {
            this.ConferenceStart = ConferenceStart;
            this.ConversationEnd = ConversationEnd;
            this.ConversationId = ConversationId;
            this.ConversationInitiator = ConversationInitiator;
            this.ConversationStart = ConversationStart;
            this.CustomerParticipation = CustomerParticipation;
            this.DivisionIds = DivisionIds;
            this.ExternalTag = ExternalTag;
            this.KnowledgeBaseIds = KnowledgeBaseIds;
            this.MediaStatsMinConversationMos = MediaStatsMinConversationMos;
            this.MediaStatsMinConversationRFactor = MediaStatsMinConversationRFactor;
            this.OriginatingDirection = OriginatingDirection;
            this.SelfServed = SelfServed;
            this.Evaluations = Evaluations;
            this.Surveys = Surveys;
            this.Resolutions = Resolutions;
            this.Participants = Participants;
            
        }
        


        /// <summary>
        /// The start time of a conference call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start time of a conference call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="conferenceStart", EmitDefaultValue=false)]
        public DateTime? ConferenceStart { get; set; }



        /// <summary>
        /// The end time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The end time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="conversationEnd", EmitDefaultValue=false)]
        public DateTime? ConversationEnd { get; set; }



        /// <summary>
        /// Unique identifier for the conversation
        /// </summary>
        /// <value>Unique identifier for the conversation</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }





        /// <summary>
        /// The start time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start time of a conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="conversationStart", EmitDefaultValue=false)]
        public DateTime? ConversationStart { get; set; }



        /// <summary>
        /// Indicates a messaging conversation in which the customer participated by sending at least one message
        /// </summary>
        /// <value>Indicates a messaging conversation in which the customer participated by sending at least one message</value>
        [DataMember(Name="customerParticipation", EmitDefaultValue=false)]
        public bool? CustomerParticipation { get; set; }



        /// <summary>
        /// Identifier(s) of division(s) associated with a conversation
        /// </summary>
        /// <value>Identifier(s) of division(s) associated with a conversation</value>
        [DataMember(Name="divisionIds", EmitDefaultValue=false)]
        public List<string> DivisionIds { get; set; }



        /// <summary>
        /// External tag for the conversation
        /// </summary>
        /// <value>External tag for the conversation</value>
        [DataMember(Name="externalTag", EmitDefaultValue=false)]
        public string ExternalTag { get; set; }



        /// <summary>
        /// The unique identifier(s) of the knowledge base(s) used
        /// </summary>
        /// <value>The unique identifier(s) of the knowledge base(s) used</value>
        [DataMember(Name="knowledgeBaseIds", EmitDefaultValue=false)]
        public List<string> KnowledgeBaseIds { get; set; }



        /// <summary>
        /// The lowest estimated average MOS among all the audio streams belonging to this conversation
        /// </summary>
        /// <value>The lowest estimated average MOS among all the audio streams belonging to this conversation</value>
        [DataMember(Name="mediaStatsMinConversationMos", EmitDefaultValue=false)]
        public double? MediaStatsMinConversationMos { get; set; }



        /// <summary>
        /// The lowest R-factor value among all of the audio streams belonging to this conversation
        /// </summary>
        /// <value>The lowest R-factor value among all of the audio streams belonging to this conversation</value>
        [DataMember(Name="mediaStatsMinConversationRFactor", EmitDefaultValue=false)]
        public double? MediaStatsMinConversationRFactor { get; set; }





        /// <summary>
        /// Indicates whether all flow sessions were self serviced
        /// </summary>
        /// <value>Indicates whether all flow sessions were self serviced</value>
        [DataMember(Name="selfServed", EmitDefaultValue=false)]
        public bool? SelfServed { get; set; }



        /// <summary>
        /// Evaluations associated with this conversation
        /// </summary>
        /// <value>Evaluations associated with this conversation</value>
        [DataMember(Name="evaluations", EmitDefaultValue=false)]
        public List<AnalyticsEvaluation> Evaluations { get; set; }



        /// <summary>
        /// Surveys associated with this conversation
        /// </summary>
        /// <value>Surveys associated with this conversation</value>
        [DataMember(Name="surveys", EmitDefaultValue=false)]
        public List<AnalyticsSurvey> Surveys { get; set; }



        /// <summary>
        /// Resolutions associated with this conversation
        /// </summary>
        /// <value>Resolutions associated with this conversation</value>
        [DataMember(Name="resolutions", EmitDefaultValue=false)]
        public List<AnalyticsResolution> Resolutions { get; set; }



        /// <summary>
        /// Participants in the conversation
        /// </summary>
        /// <value>Participants in the conversation</value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<AnalyticsParticipantWithoutAttributes> Participants { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsConversationWithoutAttributes {\n");

            sb.Append("  ConferenceStart: ").Append(ConferenceStart).Append("\n");
            sb.Append("  ConversationEnd: ").Append(ConversationEnd).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ConversationInitiator: ").Append(ConversationInitiator).Append("\n");
            sb.Append("  ConversationStart: ").Append(ConversationStart).Append("\n");
            sb.Append("  CustomerParticipation: ").Append(CustomerParticipation).Append("\n");
            sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
            sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
            sb.Append("  KnowledgeBaseIds: ").Append(KnowledgeBaseIds).Append("\n");
            sb.Append("  MediaStatsMinConversationMos: ").Append(MediaStatsMinConversationMos).Append("\n");
            sb.Append("  MediaStatsMinConversationRFactor: ").Append(MediaStatsMinConversationRFactor).Append("\n");
            sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
            sb.Append("  SelfServed: ").Append(SelfServed).Append("\n");
            sb.Append("  Evaluations: ").Append(Evaluations).Append("\n");
            sb.Append("  Surveys: ").Append(Surveys).Append("\n");
            sb.Append("  Resolutions: ").Append(Resolutions).Append("\n");
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
            return this.Equals(obj as AnalyticsConversationWithoutAttributes);
        }

        /// <summary>
        /// Returns true if AnalyticsConversationWithoutAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsConversationWithoutAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsConversationWithoutAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConferenceStart == other.ConferenceStart ||
                    this.ConferenceStart != null &&
                    this.ConferenceStart.Equals(other.ConferenceStart)
                ) &&
                (
                    this.ConversationEnd == other.ConversationEnd ||
                    this.ConversationEnd != null &&
                    this.ConversationEnd.Equals(other.ConversationEnd)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.ConversationInitiator == other.ConversationInitiator ||
                    this.ConversationInitiator != null &&
                    this.ConversationInitiator.Equals(other.ConversationInitiator)
                ) &&
                (
                    this.ConversationStart == other.ConversationStart ||
                    this.ConversationStart != null &&
                    this.ConversationStart.Equals(other.ConversationStart)
                ) &&
                (
                    this.CustomerParticipation == other.CustomerParticipation ||
                    this.CustomerParticipation != null &&
                    this.CustomerParticipation.Equals(other.CustomerParticipation)
                ) &&
                (
                    this.DivisionIds == other.DivisionIds ||
                    this.DivisionIds != null &&
                    this.DivisionIds.SequenceEqual(other.DivisionIds)
                ) &&
                (
                    this.ExternalTag == other.ExternalTag ||
                    this.ExternalTag != null &&
                    this.ExternalTag.Equals(other.ExternalTag)
                ) &&
                (
                    this.KnowledgeBaseIds == other.KnowledgeBaseIds ||
                    this.KnowledgeBaseIds != null &&
                    this.KnowledgeBaseIds.SequenceEqual(other.KnowledgeBaseIds)
                ) &&
                (
                    this.MediaStatsMinConversationMos == other.MediaStatsMinConversationMos ||
                    this.MediaStatsMinConversationMos != null &&
                    this.MediaStatsMinConversationMos.Equals(other.MediaStatsMinConversationMos)
                ) &&
                (
                    this.MediaStatsMinConversationRFactor == other.MediaStatsMinConversationRFactor ||
                    this.MediaStatsMinConversationRFactor != null &&
                    this.MediaStatsMinConversationRFactor.Equals(other.MediaStatsMinConversationRFactor)
                ) &&
                (
                    this.OriginatingDirection == other.OriginatingDirection ||
                    this.OriginatingDirection != null &&
                    this.OriginatingDirection.Equals(other.OriginatingDirection)
                ) &&
                (
                    this.SelfServed == other.SelfServed ||
                    this.SelfServed != null &&
                    this.SelfServed.Equals(other.SelfServed)
                ) &&
                (
                    this.Evaluations == other.Evaluations ||
                    this.Evaluations != null &&
                    this.Evaluations.SequenceEqual(other.Evaluations)
                ) &&
                (
                    this.Surveys == other.Surveys ||
                    this.Surveys != null &&
                    this.Surveys.SequenceEqual(other.Surveys)
                ) &&
                (
                    this.Resolutions == other.Resolutions ||
                    this.Resolutions != null &&
                    this.Resolutions.SequenceEqual(other.Resolutions)
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
                if (this.ConferenceStart != null)
                    hash = hash * 59 + this.ConferenceStart.GetHashCode();

                if (this.ConversationEnd != null)
                    hash = hash * 59 + this.ConversationEnd.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.ConversationInitiator != null)
                    hash = hash * 59 + this.ConversationInitiator.GetHashCode();

                if (this.ConversationStart != null)
                    hash = hash * 59 + this.ConversationStart.GetHashCode();

                if (this.CustomerParticipation != null)
                    hash = hash * 59 + this.CustomerParticipation.GetHashCode();

                if (this.DivisionIds != null)
                    hash = hash * 59 + this.DivisionIds.GetHashCode();

                if (this.ExternalTag != null)
                    hash = hash * 59 + this.ExternalTag.GetHashCode();

                if (this.KnowledgeBaseIds != null)
                    hash = hash * 59 + this.KnowledgeBaseIds.GetHashCode();

                if (this.MediaStatsMinConversationMos != null)
                    hash = hash * 59 + this.MediaStatsMinConversationMos.GetHashCode();

                if (this.MediaStatsMinConversationRFactor != null)
                    hash = hash * 59 + this.MediaStatsMinConversationRFactor.GetHashCode();

                if (this.OriginatingDirection != null)
                    hash = hash * 59 + this.OriginatingDirection.GetHashCode();

                if (this.SelfServed != null)
                    hash = hash * 59 + this.SelfServed.GetHashCode();

                if (this.Evaluations != null)
                    hash = hash * 59 + this.Evaluations.GetHashCode();

                if (this.Surveys != null)
                    hash = hash * 59 + this.Surveys.GetHashCode();

                if (this.Resolutions != null)
                    hash = hash * 59 + this.Resolutions.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                return hash;
            }
        }
    }

}
