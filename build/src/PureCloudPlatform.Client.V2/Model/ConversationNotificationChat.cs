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
    /// ConversationNotificationChat
    /// </summary>
    [DataContract]
    public partial class ConversationNotificationChat :  IEquatable<ConversationNotificationChat>
    {
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
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
            /// Enum Alerting for "ALERTING"
            /// </summary>
            [EnumMember(Value = "ALERTING")]
            Alerting,
            
            /// <summary>
            /// Enum Dialing for "DIALING"
            /// </summary>
            [EnumMember(Value = "DIALING")]
            Dialing,
            
            /// <summary>
            /// Enum Contacting for "CONTACTING"
            /// </summary>
            [EnumMember(Value = "CONTACTING")]
            Contacting,
            
            /// <summary>
            /// Enum Offering for "OFFERING"
            /// </summary>
            [EnumMember(Value = "OFFERING")]
            Offering,
            
            /// <summary>
            /// Enum Connected for "CONNECTED"
            /// </summary>
            [EnumMember(Value = "CONNECTED")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "DISCONNECTED"
            /// </summary>
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected,
            
            /// <summary>
            /// Enum Terminated for "TERMINATED"
            /// </summary>
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
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
            /// Enum Endpoint for "ENDPOINT"
            /// </summary>
            [EnumMember(Value = "ENDPOINT")]
            Endpoint,
            
            /// <summary>
            /// Enum Client for "CLIENT"
            /// </summary>
            [EnumMember(Value = "CLIENT")]
            Client,
            
            /// <summary>
            /// Enum System for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            System,
            
            /// <summary>
            /// Enum Timeout for "TIMEOUT"
            /// </summary>
            [EnumMember(Value = "TIMEOUT")]
            Timeout,
            
            /// <summary>
            /// Enum Transfer for "TRANSFER"
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            Transfer,
            
            /// <summary>
            /// Enum TransferConference for "TRANSFER_CONFERENCE"
            /// </summary>
            [EnumMember(Value = "TRANSFER_CONFERENCE")]
            TransferConference,
            
            /// <summary>
            /// Enum TransferConsult for "TRANSFER_CONSULT"
            /// </summary>
            [EnumMember(Value = "TRANSFER_CONSULT")]
            TransferConsult,
            
            /// <summary>
            /// Enum TransferNoanswer for "TRANSFER_NOANSWER"
            /// </summary>
            [EnumMember(Value = "TRANSFER_NOANSWER")]
            TransferNoanswer,
            
            /// <summary>
            /// Enum TransferNotavailable for "TRANSFER_NOTAVAILABLE"
            /// </summary>
            [EnumMember(Value = "TRANSFER_NOTAVAILABLE")]
            TransferNotavailable,
            
            /// <summary>
            /// Enum TransferForward for "TRANSFER_FORWARD"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FORWARD")]
            TransferForward,
            
            /// <summary>
            /// Enum TransportFailure for "TRANSPORT_FAILURE"
            /// </summary>
            [EnumMember(Value = "TRANSPORT_FAILURE")]
            TransportFailure,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error,
            
            /// <summary>
            /// Enum Peer for "PEER"
            /// </summary>
            [EnumMember(Value = "PEER")]
            Peer,
            
            /// <summary>
            /// Enum Other for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            Other,
            
            /// <summary>
            /// Enum Spam for "SPAM"
            /// </summary>
            [EnumMember(Value = "SPAM")]
            Spam,
            
            /// <summary>
            /// Enum Uncallable for "UNCALLABLE"
            /// </summary>
            [EnumMember(Value = "UNCALLABLE")]
            Uncallable
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNotificationChat" /> class.
        /// </summary>
        
        
        /// <param name="State">State.</param>
        
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="Provider">Provider.</param>
        
        
        
        /// <param name="ScriptId">ScriptId.</param>
        
        
        
        /// <param name="PeerId">PeerId.</param>
        
        
        
        /// <param name="RoomId">RoomId.</param>
        
        
        
        /// <param name="Held">Held.</param>
        
        
        
        /// <param name="DisconnectType">DisconnectType.</param>
        
        
        
        /// <param name="StartHoldTime">StartHoldTime.</param>
        
        
        
        /// <param name="ConnectedTime">ConnectedTime.</param>
        
        
        
        /// <param name="DisconnectedTime">DisconnectedTime.</param>
        
        
        
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        
        
        public ConversationNotificationChat(StateEnum? State = null, string Id = null, string Provider = null, string ScriptId = null, string PeerId = null, string RoomId = null, bool? Held = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, Object AdditionalProperties = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.State = State;
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.Provider = Provider;
            
            
            
            
            
            
            
            
this.ScriptId = ScriptId;
            
            
            
            
            
            
            
            
this.PeerId = PeerId;
            
            
            
            
            
            
            
            
this.RoomId = RoomId;
            
            
            
            
            
            
            
            
this.Held = Held;
            
            
            
            
            
            
            
            
this.DisconnectType = DisconnectType;
            
            
            
            
            
            
            
            
this.StartHoldTime = StartHoldTime;
            
            
            
            
            
            
            
            
this.ConnectedTime = ConnectedTime;
            
            
            
            
            
            
            
            
this.DisconnectedTime = DisconnectedTime;
            
            
            
            
            
            
            
            
this.AdditionalProperties = AdditionalProperties;
            
            
            
            
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ScriptId
        /// </summary>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public string ScriptId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PeerId
        /// </summary>
        [DataMember(Name="peerId", EmitDefaultValue=false)]
        public string PeerId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RoomId
        /// </summary>
        [DataMember(Name="roomId", EmitDefaultValue=false)]
        public string RoomId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Held
        /// </summary>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets StartHoldTime
        /// </summary>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ConnectedTime
        /// </summary>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DisconnectedTime
        /// </summary>
        [DataMember(Name="disconnectedTime", EmitDefaultValue=false)]
        public DateTime? DisconnectedTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationNotificationChat {\n");
            
            sb.Append("  State: ").Append(State).Append("\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
            
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            
            sb.Append("  Held: ").Append(Held).Append("\n");
            
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            
            sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
            
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            
            sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
            
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            
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
            return this.Equals(obj as ConversationNotificationChat);
        }

        /// <summary>
        /// Returns true if ConversationNotificationChat instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationNotificationChat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationNotificationChat other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.ScriptId == other.ScriptId ||
                    this.ScriptId != null &&
                    this.ScriptId.Equals(other.ScriptId)
                ) &&
                (
                    this.PeerId == other.PeerId ||
                    this.PeerId != null &&
                    this.PeerId.Equals(other.PeerId)
                ) &&
                (
                    this.RoomId == other.RoomId ||
                    this.RoomId != null &&
                    this.RoomId.Equals(other.RoomId)
                ) &&
                (
                    this.Held == other.Held ||
                    this.Held != null &&
                    this.Held.Equals(other.Held)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.StartHoldTime == other.StartHoldTime ||
                    this.StartHoldTime != null &&
                    this.StartHoldTime.Equals(other.StartHoldTime)
                ) &&
                (
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.DisconnectedTime == other.DisconnectedTime ||
                    this.DisconnectedTime != null &&
                    this.DisconnectedTime.Equals(other.DisconnectedTime)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();
                
                if (this.ScriptId != null)
                    hash = hash * 59 + this.ScriptId.GetHashCode();
                
                if (this.PeerId != null)
                    hash = hash * 59 + this.PeerId.GetHashCode();
                
                if (this.RoomId != null)
                    hash = hash * 59 + this.RoomId.GetHashCode();
                
                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();
                
                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();
                
                if (this.StartHoldTime != null)
                    hash = hash * 59 + this.StartHoldTime.GetHashCode();
                
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                
                if (this.DisconnectedTime != null)
                    hash = hash * 59 + this.DisconnectedTime.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
