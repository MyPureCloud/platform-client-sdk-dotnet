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
    /// AnalyticsConversation
    /// </summary>
    [DataContract]
    public partial class AnalyticsConversation :  IEquatable<AnalyticsConversation>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsConversation" /> class.
        /// </summary>
        
        
        /// <param name="ConversationId">ConversationId.</param>
        
        
        
        /// <param name="ConversationStart">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="ConversationEnd">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="Participants">Participants.</param>
        
        
        
        /// <param name="Evaluations">Evaluations.</param>
        
        
        public AnalyticsConversation(string ConversationId = null, DateTime? ConversationStart = null, DateTime? ConversationEnd = null, List<AnalyticsParticipant> Participants = null, List<AnalyticsEvaluation> Evaluations = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.ConversationId = ConversationId;
            
            
            
            
            
            
            
            
this.ConversationStart = ConversationStart;
            
            
            
            
            
            
            
            
this.ConversationEnd = ConversationEnd;
            
            
            
            
            
            
            
            
this.Participants = Participants;
            
            
            
            
            
            
            
            
this.Evaluations = Evaluations;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="conversationStart", EmitDefaultValue=false)]
        public DateTime? ConversationStart { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="conversationEnd", EmitDefaultValue=false)]
        public DateTime? ConversationEnd { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<AnalyticsParticipant> Participants { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Evaluations
        /// </summary>
        [DataMember(Name="evaluations", EmitDefaultValue=false)]
        public List<AnalyticsEvaluation> Evaluations { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsConversation {\n");
            
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            
            sb.Append("  ConversationStart: ").Append(ConversationStart).Append("\n");
            
            sb.Append("  ConversationEnd: ").Append(ConversationEnd).Append("\n");
            
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            
            sb.Append("  Evaluations: ").Append(Evaluations).Append("\n");
            
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
            return this.Equals(obj as AnalyticsConversation);
        }

        /// <summary>
        /// Returns true if AnalyticsConversation instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsConversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsConversation other)
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
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
                ) &&
                (
                    this.Evaluations == other.Evaluations ||
                    this.Evaluations != null &&
                    this.Evaluations.SequenceEqual(other.Evaluations)
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
                
                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();
                
                if (this.Evaluations != null)
                    hash = hash * 59 + this.Evaluations.GetHashCode();
                
                return hash;
            }
        }
    }

}
