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
    /// TranscriptionsTopicTranscriptionMessage
    /// </summary>
    [DataContract]
    public partial class TranscriptionsTopicTranscriptionMessage :  IEquatable<TranscriptionsTopicTranscriptionMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionsTopicTranscriptionMessage" /> class.
        /// </summary>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="BatchIntervalMs">BatchIntervalMs.</param>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="CommunicationId">CommunicationId.</param>
        /// <param name="SessionId">SessionId.</param>
        /// <param name="Transcripts">Transcripts.</param>
        public TranscriptionsTopicTranscriptionMessage(DateTime? EventTime = null, int? BatchIntervalMs = null, string OrganizationId = null, string ConversationId = null, string CommunicationId = null, string SessionId = null, List<TranscriptionsTopicTranscriptResult> Transcripts = null)
        {
            this.EventTime = EventTime;
            this.BatchIntervalMs = BatchIntervalMs;
            this.OrganizationId = OrganizationId;
            this.ConversationId = ConversationId;
            this.CommunicationId = CommunicationId;
            this.SessionId = SessionId;
            this.Transcripts = Transcripts;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets BatchIntervalMs
        /// </summary>
        [DataMember(Name="batchIntervalMs", EmitDefaultValue=false)]
        public int? BatchIntervalMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CommunicationId
        /// </summary>
        [DataMember(Name="communicationId", EmitDefaultValue=false)]
        public string CommunicationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Transcripts
        /// </summary>
        [DataMember(Name="transcripts", EmitDefaultValue=false)]
        public List<TranscriptionsTopicTranscriptResult> Transcripts { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptionsTopicTranscriptionMessage {\n");
            
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  BatchIntervalMs: ").Append(BatchIntervalMs).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  Transcripts: ").Append(Transcripts).Append("\n");
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
            return this.Equals(obj as TranscriptionsTopicTranscriptionMessage);
        }

        /// <summary>
        /// Returns true if TranscriptionsTopicTranscriptionMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptionsTopicTranscriptionMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionsTopicTranscriptionMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) &&
                (
                    this.BatchIntervalMs == other.BatchIntervalMs ||
                    this.BatchIntervalMs != null &&
                    this.BatchIntervalMs.Equals(other.BatchIntervalMs)
                ) &&
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.CommunicationId == other.CommunicationId ||
                    this.CommunicationId != null &&
                    this.CommunicationId.Equals(other.CommunicationId)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.Transcripts == other.Transcripts ||
                    this.Transcripts != null &&
                    this.Transcripts.SequenceEqual(other.Transcripts)
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
                
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();
                
                if (this.BatchIntervalMs != null)
                    hash = hash * 59 + this.BatchIntervalMs.GetHashCode();
                
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();
                
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();
                
                if (this.Transcripts != null)
                    hash = hash * 59 + this.Transcripts.GetHashCode();
                
                return hash;
            }
        }
    }

}
