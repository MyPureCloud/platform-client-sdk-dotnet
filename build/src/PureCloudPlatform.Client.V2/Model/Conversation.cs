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
    /// Conversation
    /// </summary>
    [DataContract]
    public partial class Conversation :  IEquatable<Conversation>
    {
        /// <summary>
        /// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.
        /// </summary>
        /// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.</value>
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
            /// Enum Active for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            /// <summary>
            /// Enum Paused for "PAUSED"
            /// </summary>
            [EnumMember(Value = "PAUSED")]
            Paused,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None
        }
        /// <summary>
        /// The conversation's state
        /// </summary>
        /// <value>The conversation's state</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alerting for "alerting"
            /// </summary>
            [EnumMember(Value = "alerting")]
            Alerting,
            
            /// <summary>
            /// Enum Dialing for "dialing"
            /// </summary>
            [EnumMember(Value = "dialing")]
            Dialing,
            
            /// <summary>
            /// Enum Contacting for "contacting"
            /// </summary>
            [EnumMember(Value = "contacting")]
            Contacting,
            
            /// <summary>
            /// Enum Offering for "offering"
            /// </summary>
            [EnumMember(Value = "offering")]
            Offering,
            
            /// <summary>
            /// Enum Connected for "connected"
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "disconnected"
            /// </summary>
            [EnumMember(Value = "disconnected")]
            Disconnected,
            
            /// <summary>
            /// Enum Terminated for "terminated"
            /// </summary>
            [EnumMember(Value = "terminated")]
            Terminated,
            
            /// <summary>
            /// Enum Converting for "converting"
            /// </summary>
            [EnumMember(Value = "converting")]
            Converting,
            
            /// <summary>
            /// Enum Uploading for "uploading"
            /// </summary>
            [EnumMember(Value = "uploading")]
            Uploading,
            
            /// <summary>
            /// Enum Transmitting for "transmitting"
            /// </summary>
            [EnumMember(Value = "transmitting")]
            Transmitting,
            
            /// <summary>
            /// Enum Parked for "parked"
            /// </summary>
            [EnumMember(Value = "parked")]
            Parked,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None
        }
        /// <summary>
        /// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.
        /// </summary>
        /// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.</value>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public RecordingStateEnum? RecordingState { get; set; }
        /// <summary>
        /// The conversation's state
        /// </summary>
        /// <value>The conversation's state</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Conversation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ExternalTag">The external tag associated with the conversation..</param>
        /// <param name="StartTime">The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="EndTime">The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Address">The address of the conversation as seen from an external participant. For phone calls this will be the DNIS for inbound calls and the ANI for outbound calls. For other media types this will be the address of the destination participant for inbound and the address of the initiating participant for outbound..</param>
        /// <param name="Participants">The list of all participants in the conversation. (required).</param>
        /// <param name="ConversationIds">A list of conversations to merge into this conversation to create a conference. This field is null except when being used to create a conference..</param>
        /// <param name="MaxParticipants">If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference..</param>
        /// <param name="RecordingState">On update, &#39;paused&#39; initiates a secure pause, &#39;active&#39; resumes any paused recordings; otherwise indicates state of conversation recording..</param>
        /// <param name="State">The conversation&#39;s state.</param>
        /// <param name="Divisions">Identifiers of divisions associated with this conversation.</param>
        /// <param name="RecentTransfers">The list of the most recent 20 transfer commands applied to this conversation..</param>
        /// <param name="SecurePause">True when the recording of this conversation is in secure pause status..</param>
        /// <param name="UtilizationLabelId">An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level.</param>
        public Conversation(string Name = null, string ExternalTag = null, DateTime? StartTime = null, DateTime? EndTime = null, string Address = null, List<Participant> Participants = null, List<string> ConversationIds = null, int? MaxParticipants = null, RecordingStateEnum? RecordingState = null, StateEnum? State = null, List<ConversationDivisionMembership> Divisions = null, List<TransferResponse> RecentTransfers = null, bool? SecurePause = null, string UtilizationLabelId = null)
        {
            this.Name = Name;
            this.ExternalTag = ExternalTag;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Address = Address;
            this.Participants = Participants;
            this.ConversationIds = ConversationIds;
            this.MaxParticipants = MaxParticipants;
            this.RecordingState = RecordingState;
            this.State = State;
            this.Divisions = Divisions;
            this.RecentTransfers = RecentTransfers;
            this.SecurePause = SecurePause;
            this.UtilizationLabelId = UtilizationLabelId;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The external tag associated with the conversation.
        /// </summary>
        /// <value>The external tag associated with the conversation.</value>
        [DataMember(Name="externalTag", EmitDefaultValue=false)]
        public string ExternalTag { get; set; }



        /// <summary>
        /// The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }



        /// <summary>
        /// The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }



        /// <summary>
        /// The address of the conversation as seen from an external participant. For phone calls this will be the DNIS for inbound calls and the ANI for outbound calls. For other media types this will be the address of the destination participant for inbound and the address of the initiating participant for outbound.
        /// </summary>
        /// <value>The address of the conversation as seen from an external participant. For phone calls this will be the DNIS for inbound calls and the ANI for outbound calls. For other media types this will be the address of the destination participant for inbound and the address of the initiating participant for outbound.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }



        /// <summary>
        /// The list of all participants in the conversation.
        /// </summary>
        /// <value>The list of all participants in the conversation.</value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<Participant> Participants { get; set; }



        /// <summary>
        /// A list of conversations to merge into this conversation to create a conference. This field is null except when being used to create a conference.
        /// </summary>
        /// <value>A list of conversations to merge into this conversation to create a conference. This field is null except when being used to create a conference.</value>
        [DataMember(Name="conversationIds", EmitDefaultValue=false)]
        public List<string> ConversationIds { get; set; }



        /// <summary>
        /// If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference.
        /// </summary>
        /// <value>If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference.</value>
        [DataMember(Name="maxParticipants", EmitDefaultValue=false)]
        public int? MaxParticipants { get; set; }







        /// <summary>
        /// Identifiers of divisions associated with this conversation
        /// </summary>
        /// <value>Identifiers of divisions associated with this conversation</value>
        [DataMember(Name="divisions", EmitDefaultValue=false)]
        public List<ConversationDivisionMembership> Divisions { get; set; }



        /// <summary>
        /// The list of the most recent 20 transfer commands applied to this conversation.
        /// </summary>
        /// <value>The list of the most recent 20 transfer commands applied to this conversation.</value>
        [DataMember(Name="recentTransfers", EmitDefaultValue=false)]
        public List<TransferResponse> RecentTransfers { get; set; }



        /// <summary>
        /// True when the recording of this conversation is in secure pause status.
        /// </summary>
        /// <value>True when the recording of this conversation is in secure pause status.</value>
        [DataMember(Name="securePause", EmitDefaultValue=false)]
        public bool? SecurePause { get; set; }



        /// <summary>
        /// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
        /// </summary>
        /// <value>An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level</value>
        [DataMember(Name="utilizationLabelId", EmitDefaultValue=false)]
        public string UtilizationLabelId { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conversation {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  ConversationIds: ").Append(ConversationIds).Append("\n");
            sb.Append("  MaxParticipants: ").Append(MaxParticipants).Append("\n");
            sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Divisions: ").Append(Divisions).Append("\n");
            sb.Append("  RecentTransfers: ").Append(RecentTransfers).Append("\n");
            sb.Append("  SecurePause: ").Append(SecurePause).Append("\n");
            sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as Conversation);
        }

        /// <summary>
        /// Returns true if Conversation instances are equal
        /// </summary>
        /// <param name="other">Instance of Conversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conversation other)
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
                    this.ExternalTag == other.ExternalTag ||
                    this.ExternalTag != null &&
                    this.ExternalTag.Equals(other.ExternalTag)
                ) &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
                ) &&
                (
                    this.ConversationIds == other.ConversationIds ||
                    this.ConversationIds != null &&
                    this.ConversationIds.SequenceEqual(other.ConversationIds)
                ) &&
                (
                    this.MaxParticipants == other.MaxParticipants ||
                    this.MaxParticipants != null &&
                    this.MaxParticipants.Equals(other.MaxParticipants)
                ) &&
                (
                    this.RecordingState == other.RecordingState ||
                    this.RecordingState != null &&
                    this.RecordingState.Equals(other.RecordingState)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Divisions == other.Divisions ||
                    this.Divisions != null &&
                    this.Divisions.SequenceEqual(other.Divisions)
                ) &&
                (
                    this.RecentTransfers == other.RecentTransfers ||
                    this.RecentTransfers != null &&
                    this.RecentTransfers.SequenceEqual(other.RecentTransfers)
                ) &&
                (
                    this.SecurePause == other.SecurePause ||
                    this.SecurePause != null &&
                    this.SecurePause.Equals(other.SecurePause)
                ) &&
                (
                    this.UtilizationLabelId == other.UtilizationLabelId ||
                    this.UtilizationLabelId != null &&
                    this.UtilizationLabelId.Equals(other.UtilizationLabelId)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.ExternalTag != null)
                    hash = hash * 59 + this.ExternalTag.GetHashCode();

                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();

                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                if (this.ConversationIds != null)
                    hash = hash * 59 + this.ConversationIds.GetHashCode();

                if (this.MaxParticipants != null)
                    hash = hash * 59 + this.MaxParticipants.GetHashCode();

                if (this.RecordingState != null)
                    hash = hash * 59 + this.RecordingState.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Divisions != null)
                    hash = hash * 59 + this.Divisions.GetHashCode();

                if (this.RecentTransfers != null)
                    hash = hash * 59 + this.RecentTransfers.GetHashCode();

                if (this.SecurePause != null)
                    hash = hash * 59 + this.SecurePause.GetHashCode();

                if (this.UtilizationLabelId != null)
                    hash = hash * 59 + this.UtilizationLabelId.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
