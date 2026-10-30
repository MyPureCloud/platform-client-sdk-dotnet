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
    /// V2StaRealtimeCustomerSentimentTopicRealTimeCustomerSentimentMessage
    /// </summary>
    [DataContract]
    public partial class V2StaRealtimeCustomerSentimentTopicRealTimeCustomerSentimentMessage :  IEquatable<V2StaRealtimeCustomerSentimentTopicRealTimeCustomerSentimentMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2StaRealtimeCustomerSentimentTopicRealTimeCustomerSentimentMessage" /> class.
        /// </summary>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="CommunicationId">CommunicationId.</param>
        /// <param name="ProgramId">ProgramId.</param>
        /// <param name="Sentiments">Sentiments.</param>
        /// <param name="Participants">Participants.</param>
        public V2StaRealtimeCustomerSentimentTopicRealTimeCustomerSentimentMessage(string OrganizationId = null, Guid? ConversationId = null, Guid? CommunicationId = null, Guid? ProgramId = null, List<V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag> Sentiments = null, List<V2StaRealtimeCustomerSentimentTopicConversationParticipant> Participants = null)
        {
            this.OrganizationId = OrganizationId;
            this.ConversationId = ConversationId;
            this.CommunicationId = CommunicationId;
            this.ProgramId = ProgramId;
            this.Sentiments = Sentiments;
            this.Participants = Participants;
            
        }
        


        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }



        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public Guid? ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets CommunicationId
        /// </summary>
        [DataMember(Name="communicationId", EmitDefaultValue=false)]
        public Guid? CommunicationId { get; set; }



        /// <summary>
        /// Gets or Sets ProgramId
        /// </summary>
        [DataMember(Name="programId", EmitDefaultValue=false)]
        public Guid? ProgramId { get; set; }



        /// <summary>
        /// Gets or Sets Sentiments
        /// </summary>
        [DataMember(Name="sentiments", EmitDefaultValue=false)]
        public List<V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag> Sentiments { get; set; }



        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<V2StaRealtimeCustomerSentimentTopicConversationParticipant> Participants { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2StaRealtimeCustomerSentimentTopicRealTimeCustomerSentimentMessage {\n");

            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  Sentiments: ").Append(Sentiments).Append("\n");
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
            return this.Equals(obj as V2StaRealtimeCustomerSentimentTopicRealTimeCustomerSentimentMessage);
        }

        /// <summary>
        /// Returns true if V2StaRealtimeCustomerSentimentTopicRealTimeCustomerSentimentMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of V2StaRealtimeCustomerSentimentTopicRealTimeCustomerSentimentMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2StaRealtimeCustomerSentimentTopicRealTimeCustomerSentimentMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.ProgramId == other.ProgramId ||
                    this.ProgramId != null &&
                    this.ProgramId.Equals(other.ProgramId)
                ) &&
                (
                    this.Sentiments == other.Sentiments ||
                    this.Sentiments != null &&
                    this.Sentiments.SequenceEqual(other.Sentiments)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();

                if (this.ProgramId != null)
                    hash = hash * 59 + this.ProgramId.GetHashCode();

                if (this.Sentiments != null)
                    hash = hash * 59 + this.Sentiments.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                return hash;
            }
        }
    }

}
