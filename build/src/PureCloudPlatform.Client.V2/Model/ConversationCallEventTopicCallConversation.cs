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
    /// ConversationCallEventTopicCallConversation
    /// </summary>
    [DataContract]
    public partial class ConversationCallEventTopicCallConversation :  IEquatable<ConversationCallEventTopicCallConversation>
    {
        /// <summary>
        /// Gets or Sets RecordingState
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RecordingStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Paused for "paused"
            /// </summary>
            [EnumMember(Value = "paused")]
            Paused
        }
        /// <summary>
        /// Gets or Sets RecordingState
        /// </summary>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public RecordingStateEnum? RecordingState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCallEventTopicCallConversation" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Participants">Participants.</param>
        /// <param name="OtherMediaUris">OtherMediaUris.</param>
        /// <param name="Address">Address.</param>
        /// <param name="UtilizationLabelId">UtilizationLabelId.</param>
        /// <param name="RecordingState">RecordingState.</param>
        /// <param name="SecurePause">SecurePause.</param>
        /// <param name="MaxParticipants">MaxParticipants.</param>
        public ConversationCallEventTopicCallConversation(string Id = null, string Name = null, List<ConversationCallEventTopicCallMediaParticipant> Participants = null, List<string> OtherMediaUris = null, string Address = null, string UtilizationLabelId = null, RecordingStateEnum? RecordingState = null, bool? SecurePause = null, int? MaxParticipants = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Participants = Participants;
            this.OtherMediaUris = OtherMediaUris;
            this.Address = Address;
            this.UtilizationLabelId = UtilizationLabelId;
            this.RecordingState = RecordingState;
            this.SecurePause = SecurePause;
            this.MaxParticipants = MaxParticipants;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<ConversationCallEventTopicCallMediaParticipant> Participants { get; set; }



        /// <summary>
        /// Gets or Sets OtherMediaUris
        /// </summary>
        [DataMember(Name="otherMediaUris", EmitDefaultValue=false)]
        public List<string> OtherMediaUris { get; set; }



        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }



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
        /// Gets or Sets MaxParticipants
        /// </summary>
        [DataMember(Name="maxParticipants", EmitDefaultValue=false)]
        public int? MaxParticipants { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationCallEventTopicCallConversation {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  OtherMediaUris: ").Append(OtherMediaUris).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
            sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
            sb.Append("  SecurePause: ").Append(SecurePause).Append("\n");
            sb.Append("  MaxParticipants: ").Append(MaxParticipants).Append("\n");
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
            return this.Equals(obj as ConversationCallEventTopicCallConversation);
        }

        /// <summary>
        /// Returns true if ConversationCallEventTopicCallConversation instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationCallEventTopicCallConversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationCallEventTopicCallConversation other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
                ) &&
                (
                    this.OtherMediaUris == other.OtherMediaUris ||
                    this.OtherMediaUris != null &&
                    this.OtherMediaUris.SequenceEqual(other.OtherMediaUris)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.UtilizationLabelId == other.UtilizationLabelId ||
                    this.UtilizationLabelId != null &&
                    this.UtilizationLabelId.Equals(other.UtilizationLabelId)
                ) &&
                (
                    this.RecordingState == other.RecordingState ||
                    this.RecordingState != null &&
                    this.RecordingState.Equals(other.RecordingState)
                ) &&
                (
                    this.SecurePause == other.SecurePause ||
                    this.SecurePause != null &&
                    this.SecurePause.Equals(other.SecurePause)
                ) &&
                (
                    this.MaxParticipants == other.MaxParticipants ||
                    this.MaxParticipants != null &&
                    this.MaxParticipants.Equals(other.MaxParticipants)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                if (this.OtherMediaUris != null)
                    hash = hash * 59 + this.OtherMediaUris.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                if (this.UtilizationLabelId != null)
                    hash = hash * 59 + this.UtilizationLabelId.GetHashCode();

                if (this.RecordingState != null)
                    hash = hash * 59 + this.RecordingState.GetHashCode();

                if (this.SecurePause != null)
                    hash = hash * 59 + this.SecurePause.GetHashCode();

                if (this.MaxParticipants != null)
                    hash = hash * 59 + this.MaxParticipants.GetHashCode();

                return hash;
            }
        }
    }

}
