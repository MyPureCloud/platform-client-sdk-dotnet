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
    /// TranscriptionTopicTranscriptionMessage
    /// </summary>
    [DataContract]
    public partial class TranscriptionTopicTranscriptionMessage :  IEquatable<TranscriptionTopicTranscriptionMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionTopicTranscriptionMessage" /> class.
        /// </summary>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="CommunicationId">CommunicationId.</param>
        /// <param name="SessionStartTimeMs">SessionStartTimeMs.</param>
        /// <param name="TranscriptionStartTimeMs">TranscriptionStartTimeMs.</param>
        /// <param name="Transcripts">Transcripts.</param>
        /// <param name="Status">Status.</param>
        public TranscriptionTopicTranscriptionMessage(DateTime? EventTime = null, string OrganizationId = null, string ConversationId = null, string CommunicationId = null, int? SessionStartTimeMs = null, int? TranscriptionStartTimeMs = null, List<TranscriptionTopicTranscriptResult> Transcripts = null, TranscriptionTopicTranscriptionRequestStatus Status = null)
        {
            this.EventTime = EventTime;
            this.OrganizationId = OrganizationId;
            this.ConversationId = ConversationId;
            this.CommunicationId = CommunicationId;
            this.SessionStartTimeMs = SessionStartTimeMs;
            this.TranscriptionStartTimeMs = TranscriptionStartTimeMs;
            this.Transcripts = Transcripts;
            this.Status = Status;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }
        
        
        
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
        /// Gets or Sets SessionStartTimeMs
        /// </summary>
        [DataMember(Name="sessionStartTimeMs", EmitDefaultValue=false)]
        public int? SessionStartTimeMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TranscriptionStartTimeMs
        /// </summary>
        [DataMember(Name="transcriptionStartTimeMs", EmitDefaultValue=false)]
        public int? TranscriptionStartTimeMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Transcripts
        /// </summary>
        [DataMember(Name="transcripts", EmitDefaultValue=false)]
        public List<TranscriptionTopicTranscriptResult> Transcripts { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public TranscriptionTopicTranscriptionRequestStatus Status { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptionTopicTranscriptionMessage {\n");
            
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  SessionStartTimeMs: ").Append(SessionStartTimeMs).Append("\n");
            sb.Append("  TranscriptionStartTimeMs: ").Append(TranscriptionStartTimeMs).Append("\n");
            sb.Append("  Transcripts: ").Append(Transcripts).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as TranscriptionTopicTranscriptionMessage);
        }

        /// <summary>
        /// Returns true if TranscriptionTopicTranscriptionMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptionTopicTranscriptionMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionTopicTranscriptionMessage other)
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
                    this.SessionStartTimeMs == other.SessionStartTimeMs ||
                    this.SessionStartTimeMs != null &&
                    this.SessionStartTimeMs.Equals(other.SessionStartTimeMs)
                ) &&
                (
                    this.TranscriptionStartTimeMs == other.TranscriptionStartTimeMs ||
                    this.TranscriptionStartTimeMs != null &&
                    this.TranscriptionStartTimeMs.Equals(other.TranscriptionStartTimeMs)
                ) &&
                (
                    this.Transcripts == other.Transcripts ||
                    this.Transcripts != null &&
                    this.Transcripts.SequenceEqual(other.Transcripts)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();
                
                if (this.SessionStartTimeMs != null)
                    hash = hash * 59 + this.SessionStartTimeMs.GetHashCode();
                
                if (this.TranscriptionStartTimeMs != null)
                    hash = hash * 59 + this.TranscriptionStartTimeMs.GetHashCode();
                
                if (this.Transcripts != null)
                    hash = hash * 59 + this.Transcripts.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }
    }

}
