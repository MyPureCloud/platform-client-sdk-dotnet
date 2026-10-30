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
    /// V2StaTopicsDetectedRealtimeTopicTopicSpottingRealTimeNotification
    /// </summary>
    [DataContract]
    public partial class V2StaTopicsDetectedRealtimeTopicTopicSpottingRealTimeNotification :  IEquatable<V2StaTopicsDetectedRealtimeTopicTopicSpottingRealTimeNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2StaTopicsDetectedRealtimeTopicTopicSpottingRealTimeNotification" /> class.
        /// </summary>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="CommunicationId">CommunicationId.</param>
        /// <param name="ProgramId">ProgramId.</param>
        /// <param name="Topics">Topics.</param>
        /// <param name="Participants">Participants.</param>
        public V2StaTopicsDetectedRealtimeTopicTopicSpottingRealTimeNotification(string ConversationId = null, string CommunicationId = null, string ProgramId = null, List<V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag> Topics = null, List<V2StaTopicsDetectedRealtimeTopicConversationParticipant> Participants = null)
        {
            this.ConversationId = ConversationId;
            this.CommunicationId = CommunicationId;
            this.ProgramId = ProgramId;
            this.Topics = Topics;
            this.Participants = Participants;
            
        }
        


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
        /// Gets or Sets ProgramId
        /// </summary>
        [DataMember(Name="programId", EmitDefaultValue=false)]
        public string ProgramId { get; set; }



        /// <summary>
        /// Gets or Sets Topics
        /// </summary>
        [DataMember(Name="topics", EmitDefaultValue=false)]
        public List<V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag> Topics { get; set; }



        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<V2StaTopicsDetectedRealtimeTopicConversationParticipant> Participants { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2StaTopicsDetectedRealtimeTopicTopicSpottingRealTimeNotification {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
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
            return this.Equals(obj as V2StaTopicsDetectedRealtimeTopicTopicSpottingRealTimeNotification);
        }

        /// <summary>
        /// Returns true if V2StaTopicsDetectedRealtimeTopicTopicSpottingRealTimeNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of V2StaTopicsDetectedRealtimeTopicTopicSpottingRealTimeNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2StaTopicsDetectedRealtimeTopicTopicSpottingRealTimeNotification other)
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
                    this.Topics == other.Topics ||
                    this.Topics != null &&
                    this.Topics.SequenceEqual(other.Topics)
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

                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();

                if (this.ProgramId != null)
                    hash = hash * 59 + this.ProgramId.GetHashCode();

                if (this.Topics != null)
                    hash = hash * 59 + this.Topics.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                return hash;
            }
        }
    }

}
