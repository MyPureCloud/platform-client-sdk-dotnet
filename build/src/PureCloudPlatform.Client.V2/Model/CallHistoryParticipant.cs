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
    /// CallHistoryParticipant
    /// </summary>
    [DataContract]
    public partial class CallHistoryParticipant :  IEquatable<CallHistoryParticipant>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The participant's direction.  Values can be: 'inbound' or 'outbound'
        /// </summary>
        /// <value>The participant's direction.  Values can be: 'inbound' or 'outbound'</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionEnum
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
        /// The reason the participant was disconnected from the conversation.
        /// </summary>
        /// <value>The reason the participant was disconnected from the conversation.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DisconnectTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Endpoint for "endpoint"
            /// </summary>
            [EnumMember(Value = "endpoint")]
            Endpoint,
            
            /// <summary>
            /// Enum Client for "client"
            /// </summary>
            [EnumMember(Value = "client")]
            Client,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System,
            
            /// <summary>
            /// Enum Transfer for "transfer"
            /// </summary>
            [EnumMember(Value = "transfer")]
            Transfer,
            
            /// <summary>
            /// Enum Transferconference for "transfer.conference"
            /// </summary>
            [EnumMember(Value = "transfer.conference")]
            Transferconference,
            
            /// <summary>
            /// Enum Transferconsult for "transfer.consult"
            /// </summary>
            [EnumMember(Value = "transfer.consult")]
            Transferconsult,
            
            /// <summary>
            /// Enum Transferforward for "transfer.forward"
            /// </summary>
            [EnumMember(Value = "transfer.forward")]
            Transferforward,
            
            /// <summary>
            /// Enum Transfernoanswer for "transfer.noanswer"
            /// </summary>
            [EnumMember(Value = "transfer.noanswer")]
            Transfernoanswer,
            
            /// <summary>
            /// Enum Transfernotavailable for "transfer.notavailable"
            /// </summary>
            [EnumMember(Value = "transfer.notavailable")]
            Transfernotavailable,
            
            /// <summary>
            /// Enum Transportfailure for "transport.failure"
            /// </summary>
            [EnumMember(Value = "transport.failure")]
            Transportfailure,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error,
            
            /// <summary>
            /// Enum Peer for "peer"
            /// </summary>
            [EnumMember(Value = "peer")]
            Peer,
            
            /// <summary>
            /// Enum Other for "other"
            /// </summary>
            [EnumMember(Value = "other")]
            Other,
            
            /// <summary>
            /// Enum Spam for "spam"
            /// </summary>
            [EnumMember(Value = "spam")]
            Spam
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The participant's direction.  Values can be: 'inbound' or 'outbound'
        /// </summary>
        /// <value>The participant's direction.  Values can be: 'inbound' or 'outbound'</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The reason the participant was disconnected from the conversation.
        /// </summary>
        /// <value>The reason the participant was disconnected from the conversation.</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CallHistoryParticipant" /> class.
        /// </summary>
        
        
        /// <param name="Id">The unique participant ID..</param>
        
        
        
        /// <param name="Name">The display friendly name of the participant..</param>
        
        
        
        /// <param name="Address">The participant address..</param>
        
        
        
        /// <param name="StartTime">The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="EndTime">The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="Purpose">The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr.</param>
        
        
        
        /// <param name="Direction">The participant&#39;s direction.  Values can be: &#39;inbound&#39; or &#39;outbound&#39;.</param>
        
        
        
        /// <param name="Ani">The call ANI..</param>
        
        
        
        /// <param name="Dnis">The call DNIS..</param>
        
        
        
        /// <param name="User">The PureCloud user for this participant..</param>
        
        
        
        /// <param name="Queue">The PureCloud queue for this participant..</param>
        
        
        
        /// <param name="Group">The group involved in the group ring call..</param>
        
        
        
        /// <param name="DisconnectType">The reason the participant was disconnected from the conversation..</param>
        
        
        
        /// <param name="ExternalContact">The PureCloud external contact.</param>
        
        
        
        /// <param name="ExternalOrganization">The PureCloud external organization.</param>
        
        
        
        /// <param name="DidInteract">Indicates whether the contact ever connected.</param>
        
        
        
        /// <param name="SipResponseCodes">Indicates SIP Response codes associated with the participant.</param>
        
        
        public CallHistoryParticipant(string Id = null, string Name = null, string Address = null, DateTime? StartTime = null, DateTime? EndTime = null, string Purpose = null, DirectionEnum? Direction = null, string Ani = null, string Dnis = null, User User = null, Queue Queue = null, Group Group = null, DisconnectTypeEnum? DisconnectType = null, ExternalContact ExternalContact = null, ExternalOrganization ExternalOrganization = null, bool? DidInteract = null, List<long?> SipResponseCodes = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.Address = Address;
            
            
            
            
            
            
            
            
this.StartTime = StartTime;
            
            
            
            
            
            
            
            
this.EndTime = EndTime;
            
            
            
            
            
            
            
            
this.Purpose = Purpose;
            
            
            
            
            
            
            
            
this.Direction = Direction;
            
            
            
            
            
            
            
            
this.Ani = Ani;
            
            
            
            
            
            
            
            
this.Dnis = Dnis;
            
            
            
            
            
            
            
            
this.User = User;
            
            
            
            
            
            
            
            
this.Queue = Queue;
            
            
            
            
            
            
            
            
this.Group = Group;
            
            
            
            
            
            
            
            
this.DisconnectType = DisconnectType;
            
            
            
            
            
            
            
            
this.ExternalContact = ExternalContact;
            
            
            
            
            
            
            
            
this.ExternalOrganization = ExternalOrganization;
            
            
            
            
            
            
            
            
this.DidInteract = DidInteract;
            
            
            
            
            
            
            
            
this.SipResponseCodes = SipResponseCodes;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The unique participant ID.
        /// </summary>
        /// <value>The unique participant ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The display friendly name of the participant.
        /// </summary>
        /// <value>The display friendly name of the participant.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The participant address.
        /// </summary>
        /// <value>The participant address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        
        
        
        /// <summary>
        /// The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
        
        
        
        /// <summary>
        /// The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }
        
        
        
        /// <summary>
        /// The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr
        /// </summary>
        /// <value>The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr</value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }
        
        
        
        
        
        /// <summary>
        /// The call ANI.
        /// </summary>
        /// <value>The call ANI.</value>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }
        
        
        
        /// <summary>
        /// The call DNIS.
        /// </summary>
        /// <value>The call DNIS.</value>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }
        
        
        
        /// <summary>
        /// The PureCloud user for this participant.
        /// </summary>
        /// <value>The PureCloud user for this participant.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        
        
        
        /// <summary>
        /// The PureCloud queue for this participant.
        /// </summary>
        /// <value>The PureCloud queue for this participant.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public Queue Queue { get; set; }
        
        
        
        /// <summary>
        /// The group involved in the group ring call.
        /// </summary>
        /// <value>The group involved in the group ring call.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Group Group { get; set; }
        
        
        
        
        
        /// <summary>
        /// The PureCloud external contact
        /// </summary>
        /// <value>The PureCloud external contact</value>
        [DataMember(Name="externalContact", EmitDefaultValue=false)]
        public ExternalContact ExternalContact { get; set; }
        
        
        
        /// <summary>
        /// The PureCloud external organization
        /// </summary>
        /// <value>The PureCloud external organization</value>
        [DataMember(Name="externalOrganization", EmitDefaultValue=false)]
        public ExternalOrganization ExternalOrganization { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether the contact ever connected
        /// </summary>
        /// <value>Indicates whether the contact ever connected</value>
        [DataMember(Name="didInteract", EmitDefaultValue=false)]
        public bool? DidInteract { get; set; }
        
        
        
        /// <summary>
        /// Indicates SIP Response codes associated with the participant
        /// </summary>
        /// <value>Indicates SIP Response codes associated with the participant</value>
        [DataMember(Name="sipResponseCodes", EmitDefaultValue=false)]
        public List<long?> SipResponseCodes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallHistoryParticipant {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Address: ").Append(Address).Append("\n");
            
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            
            sb.Append("  Group: ").Append(Group).Append("\n");
            
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            
            sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
            
            sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
            
            sb.Append("  DidInteract: ").Append(DidInteract).Append("\n");
            
            sb.Append("  SipResponseCodes: ").Append(SipResponseCodes).Append("\n");
            
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
            return this.Equals(obj as CallHistoryParticipant);
        }

        /// <summary>
        /// Returns true if CallHistoryParticipant instances are equal
        /// </summary>
        /// <param name="other">Instance of CallHistoryParticipant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallHistoryParticipant other)
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
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
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
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) &&
                (
                    this.Dnis == other.Dnis ||
                    this.Dnis != null &&
                    this.Dnis.Equals(other.Dnis)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.ExternalContact == other.ExternalContact ||
                    this.ExternalContact != null &&
                    this.ExternalContact.Equals(other.ExternalContact)
                ) &&
                (
                    this.ExternalOrganization == other.ExternalOrganization ||
                    this.ExternalOrganization != null &&
                    this.ExternalOrganization.Equals(other.ExternalOrganization)
                ) &&
                (
                    this.DidInteract == other.DidInteract ||
                    this.DidInteract != null &&
                    this.DidInteract.Equals(other.DidInteract)
                ) &&
                (
                    this.SipResponseCodes == other.SipResponseCodes ||
                    this.SipResponseCodes != null &&
                    this.SipResponseCodes.SequenceEqual(other.SipResponseCodes)
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
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                
                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();
                
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                
                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();
                
                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                
                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();
                
                if (this.ExternalContact != null)
                    hash = hash * 59 + this.ExternalContact.GetHashCode();
                
                if (this.ExternalOrganization != null)
                    hash = hash * 59 + this.ExternalOrganization.GetHashCode();
                
                if (this.DidInteract != null)
                    hash = hash * 59 + this.DidInteract.GetHashCode();
                
                if (this.SipResponseCodes != null)
                    hash = hash * 59 + this.SipResponseCodes.GetHashCode();
                
                return hash;
            }
        }
    }

}
