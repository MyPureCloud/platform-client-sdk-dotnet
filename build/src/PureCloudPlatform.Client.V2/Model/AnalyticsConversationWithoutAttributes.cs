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
        /// The original direction of the conversation
        /// </summary>
        /// <value>The original direction of the conversation</value>
        [DataMember(Name="originatingDirection", EmitDefaultValue=false)]
        public OriginatingDirectionEnum? OriginatingDirection { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsConversationWithoutAttributes" /> class.
        /// </summary>
        /// <param name="ConversationId">Unique identifier for the conversation.</param>
        /// <param name="ConversationStart">Date/time the conversation started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ConversationEnd">Date/time the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="MediaStatsMinConversationMos">The lowest estimated average MOS among all the audio streams belonging to this conversation.</param>
        /// <param name="MediaStatsMinConversationRFactor">The lowest R-factor value among all of the audio streams belonging to this conversation.</param>
        /// <param name="OriginatingDirection">The original direction of the conversation.</param>
        /// <param name="Evaluations">Evaluations tied to this conversation.</param>
        /// <param name="Surveys">Surveys tied to this conversation.</param>
        /// <param name="DivisionIds">Identifiers of divisions associated with this conversation.</param>
        /// <param name="Participants">Participants in the conversation.</param>
        public AnalyticsConversationWithoutAttributes(string ConversationId = null, DateTime? ConversationStart = null, DateTime? ConversationEnd = null, double? MediaStatsMinConversationMos = null, double? MediaStatsMinConversationRFactor = null, OriginatingDirectionEnum? OriginatingDirection = null, List<AnalyticsEvaluation> Evaluations = null, List<AnalyticsSurvey> Surveys = null, List<string> DivisionIds = null, List<AnalyticsParticipantWithoutAttributes> Participants = null)
        {
            this.ConversationId = ConversationId;
            this.ConversationStart = ConversationStart;
            this.ConversationEnd = ConversationEnd;
            this.MediaStatsMinConversationMos = MediaStatsMinConversationMos;
            this.MediaStatsMinConversationRFactor = MediaStatsMinConversationRFactor;
            this.OriginatingDirection = OriginatingDirection;
            this.Evaluations = Evaluations;
            this.Surveys = Surveys;
            this.DivisionIds = DivisionIds;
            this.Participants = Participants;
            
        }
        
        
        
        /// <summary>
        /// Unique identifier for the conversation
        /// </summary>
        /// <value>Unique identifier for the conversation</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// Date/time the conversation started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date/time the conversation started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="conversationStart", EmitDefaultValue=false)]
        public DateTime? ConversationStart { get; set; }
        
        
        
        /// <summary>
        /// Date/time the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date/time the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="conversationEnd", EmitDefaultValue=false)]
        public DateTime? ConversationEnd { get; set; }
        
        
        
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
        /// Evaluations tied to this conversation
        /// </summary>
        /// <value>Evaluations tied to this conversation</value>
        [DataMember(Name="evaluations", EmitDefaultValue=false)]
        public List<AnalyticsEvaluation> Evaluations { get; set; }
        
        
        
        /// <summary>
        /// Surveys tied to this conversation
        /// </summary>
        /// <value>Surveys tied to this conversation</value>
        [DataMember(Name="surveys", EmitDefaultValue=false)]
        public List<AnalyticsSurvey> Surveys { get; set; }
        
        
        
        /// <summary>
        /// Identifiers of divisions associated with this conversation
        /// </summary>
        /// <value>Identifiers of divisions associated with this conversation</value>
        [DataMember(Name="divisionIds", EmitDefaultValue=false)]
        public List<string> DivisionIds { get; set; }
        
        
        
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
            
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ConversationStart: ").Append(ConversationStart).Append("\n");
            sb.Append("  ConversationEnd: ").Append(ConversationEnd).Append("\n");
            sb.Append("  MediaStatsMinConversationMos: ").Append(MediaStatsMinConversationMos).Append("\n");
            sb.Append("  MediaStatsMinConversationRFactor: ").Append(MediaStatsMinConversationRFactor).Append("\n");
            sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
            sb.Append("  Evaluations: ").Append(Evaluations).Append("\n");
            sb.Append("  Surveys: ").Append(Surveys).Append("\n");
            sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
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
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.ConversationStart == other.ConversationStart ||
                    this.ConversationStart != null &&
                    this.ConversationStart.Equals(other.ConversationStart)
                ) &&
                (
                    this.ConversationEnd == other.ConversationEnd ||
                    this.ConversationEnd != null &&
                    this.ConversationEnd.Equals(other.ConversationEnd)
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
                    this.DivisionIds == other.DivisionIds ||
                    this.DivisionIds != null &&
                    this.DivisionIds.SequenceEqual(other.DivisionIds)
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
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.ConversationStart != null)
                    hash = hash * 59 + this.ConversationStart.GetHashCode();
                
                if (this.ConversationEnd != null)
                    hash = hash * 59 + this.ConversationEnd.GetHashCode();
                
                if (this.MediaStatsMinConversationMos != null)
                    hash = hash * 59 + this.MediaStatsMinConversationMos.GetHashCode();
                
                if (this.MediaStatsMinConversationRFactor != null)
                    hash = hash * 59 + this.MediaStatsMinConversationRFactor.GetHashCode();
                
                if (this.OriginatingDirection != null)
                    hash = hash * 59 + this.OriginatingDirection.GetHashCode();
                
                if (this.Evaluations != null)
                    hash = hash * 59 + this.Evaluations.GetHashCode();
                
                if (this.Surveys != null)
                    hash = hash * 59 + this.Surveys.GetHashCode();
                
                if (this.DivisionIds != null)
                    hash = hash * 59 + this.DivisionIds.GetHashCode();
                
                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();
                
                return hash;
            }
        }
    }

}
