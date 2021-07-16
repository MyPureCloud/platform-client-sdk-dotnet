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
    /// QueueConversationEventTopicConversation
    /// </summary>
    [DataContract]
    public partial class QueueConversationEventTopicConversation :  IEquatable<QueueConversationEventTopicConversation>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationEventTopicConversation" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="MaxParticipants">MaxParticipants.</param>
        /// <param name="Participants">Participants.</param>
        /// <param name="RecordingState">RecordingState.</param>
        /// <param name="Address">Address.</param>
        /// <param name="ExternalTag">ExternalTag.</param>
        public QueueConversationEventTopicConversation(string Id = null, int? MaxParticipants = null, List<QueueConversationEventTopicParticipant> Participants = null, string RecordingState = null, string Address = null, string ExternalTag = null)
        {
            this.Id = Id;
            this.MaxParticipants = MaxParticipants;
            this.Participants = Participants;
            this.RecordingState = RecordingState;
            this.Address = Address;
            this.ExternalTag = ExternalTag;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MaxParticipants
        /// </summary>
        [DataMember(Name="maxParticipants", EmitDefaultValue=false)]
        public int? MaxParticipants { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicParticipant> Participants { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RecordingState
        /// </summary>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public string RecordingState { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExternalTag
        /// </summary>
        [DataMember(Name="externalTag", EmitDefaultValue=false)]
        public string ExternalTag { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationEventTopicConversation {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaxParticipants: ").Append(MaxParticipants).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
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
            return this.Equals(obj as QueueConversationEventTopicConversation);
        }

        /// <summary>
        /// Returns true if QueueConversationEventTopicConversation instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationEventTopicConversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationEventTopicConversation other)
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
                    this.MaxParticipants == other.MaxParticipants ||
                    this.MaxParticipants != null &&
                    this.MaxParticipants.Equals(other.MaxParticipants)
                ) &&
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
                ) &&
                (
                    this.RecordingState == other.RecordingState ||
                    this.RecordingState != null &&
                    this.RecordingState.Equals(other.RecordingState)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.ExternalTag == other.ExternalTag ||
                    this.ExternalTag != null &&
                    this.ExternalTag.Equals(other.ExternalTag)
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
                
                if (this.MaxParticipants != null)
                    hash = hash * 59 + this.MaxParticipants.GetHashCode();
                
                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();
                
                if (this.RecordingState != null)
                    hash = hash * 59 + this.RecordingState.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.ExternalTag != null)
                    hash = hash * 59 + this.ExternalTag.GetHashCode();
                
                return hash;
            }
        }
    }

}
