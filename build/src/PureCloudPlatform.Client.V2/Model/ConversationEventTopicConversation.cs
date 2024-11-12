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
    /// ConversationEventTopicConversation
    /// </summary>
    [DataContract]
    public partial class ConversationEventTopicConversation :  IEquatable<ConversationEventTopicConversation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventTopicConversation" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="MaxParticipants">MaxParticipants.</param>
        /// <param name="Participants">Participants.</param>
        /// <param name="RecentTransfers">RecentTransfers.</param>
        /// <param name="RecordingState">RecordingState.</param>
        /// <param name="Address">Address.</param>
        /// <param name="ExternalTag">ExternalTag.</param>
        /// <param name="UtilizationLabelId">UtilizationLabelId.</param>
        /// <param name="SecurePause">SecurePause.</param>
        /// <param name="Divisions">Divisions.</param>
        public ConversationEventTopicConversation(string Id = null, int? MaxParticipants = null, List<ConversationEventTopicParticipant> Participants = null, List<ConversationEventTopicTransferResponse> RecentTransfers = null, string RecordingState = null, string Address = null, string ExternalTag = null, string UtilizationLabelId = null, bool? SecurePause = null, List<ConversationEventTopicConversationDivisionMembership> Divisions = null)
        {
            this.Id = Id;
            this.MaxParticipants = MaxParticipants;
            this.Participants = Participants;
            this.RecentTransfers = RecentTransfers;
            this.RecordingState = RecordingState;
            this.Address = Address;
            this.ExternalTag = ExternalTag;
            this.UtilizationLabelId = UtilizationLabelId;
            this.SecurePause = SecurePause;
            this.Divisions = Divisions;
            
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
        public List<ConversationEventTopicParticipant> Participants { get; set; }



        /// <summary>
        /// Gets or Sets RecentTransfers
        /// </summary>
        [DataMember(Name="recentTransfers", EmitDefaultValue=false)]
        public List<ConversationEventTopicTransferResponse> RecentTransfers { get; set; }



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
        /// Gets or Sets UtilizationLabelId
        /// </summary>
        [DataMember(Name="utilizationLabelId", EmitDefaultValue=false)]
        public string UtilizationLabelId { get; set; }



        /// <summary>
        /// Gets or Sets SecurePause
        /// </summary>
        [DataMember(Name="securePause", EmitDefaultValue=false)]
        public bool? SecurePause { get; set; }



        /// <summary>
        /// Gets or Sets Divisions
        /// </summary>
        [DataMember(Name="divisions", EmitDefaultValue=false)]
        public List<ConversationEventTopicConversationDivisionMembership> Divisions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEventTopicConversation {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaxParticipants: ").Append(MaxParticipants).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  RecentTransfers: ").Append(RecentTransfers).Append("\n");
            sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
            sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
            sb.Append("  SecurePause: ").Append(SecurePause).Append("\n");
            sb.Append("  Divisions: ").Append(Divisions).Append("\n");
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
            return this.Equals(obj as ConversationEventTopicConversation);
        }

        /// <summary>
        /// Returns true if ConversationEventTopicConversation instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationEventTopicConversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEventTopicConversation other)
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
                    this.RecentTransfers == other.RecentTransfers ||
                    this.RecentTransfers != null &&
                    this.RecentTransfers.SequenceEqual(other.RecentTransfers)
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
                ) &&
                (
                    this.UtilizationLabelId == other.UtilizationLabelId ||
                    this.UtilizationLabelId != null &&
                    this.UtilizationLabelId.Equals(other.UtilizationLabelId)
                ) &&
                (
                    this.SecurePause == other.SecurePause ||
                    this.SecurePause != null &&
                    this.SecurePause.Equals(other.SecurePause)
                ) &&
                (
                    this.Divisions == other.Divisions ||
                    this.Divisions != null &&
                    this.Divisions.SequenceEqual(other.Divisions)
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

                if (this.RecentTransfers != null)
                    hash = hash * 59 + this.RecentTransfers.GetHashCode();

                if (this.RecordingState != null)
                    hash = hash * 59 + this.RecordingState.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                if (this.ExternalTag != null)
                    hash = hash * 59 + this.ExternalTag.GetHashCode();

                if (this.UtilizationLabelId != null)
                    hash = hash * 59 + this.UtilizationLabelId.GetHashCode();

                if (this.SecurePause != null)
                    hash = hash * 59 + this.SecurePause.GetHashCode();

                if (this.Divisions != null)
                    hash = hash * 59 + this.Divisions.GetHashCode();

                return hash;
            }
        }
    }

}
