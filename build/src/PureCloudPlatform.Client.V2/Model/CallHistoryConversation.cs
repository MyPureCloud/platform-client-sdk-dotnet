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
    /// CallHistoryConversation
    /// </summary>
    [DataContract]
    public partial class CallHistoryConversation :  IEquatable<CallHistoryConversation>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The direction of the call relating to the current user
        /// </summary>
        /// <value>The direction of the call relating to the current user</value>
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
        /// The direction of the call relating to the current user
        /// </summary>
        /// <value>The direction of the call relating to the current user</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CallHistoryConversation" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="Participants">The list of participants involved in the conversation..</param>
        
        
        
        /// <param name="Direction">The direction of the call relating to the current user.</param>
        
        
        
        /// <param name="WentToVoicemail">Did the call end in the current user&#39;s voicemail.</param>
        
        
        
        /// <param name="MissedCall">Did the user not answer this conversation.</param>
        
        
        
        /// <param name="StartTime">The time the user joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="WasConference">Was this conversation a conference.</param>
        
        
        
        /// <param name="WasCallback">Was this conversation a callback.</param>
        
        
        
        /// <param name="HadScreenShare">Did this conversation have a screen share session.</param>
        
        
        
        /// <param name="HadCobrowse">Did this conversation have a cobrowse session.</param>
        
        
        
        
        public CallHistoryConversation(string Name = null, List<CallHistoryParticipant> Participants = null, DirectionEnum? Direction = null, bool? WentToVoicemail = null, bool? MissedCall = null, DateTime? StartTime = null, bool? WasConference = null, bool? WasCallback = null, bool? HadScreenShare = null, bool? HadCobrowse = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.Participants = Participants;
            
            
            
            
            
            
            
            
this.Direction = Direction;
            
            
            
            
            
            
            
            
this.WentToVoicemail = WentToVoicemail;
            
            
            
            
            
            
            
            
this.MissedCall = MissedCall;
            
            
            
            
            
            
            
            
this.StartTime = StartTime;
            
            
            
            
            
            
            
            
this.WasConference = WasConference;
            
            
            
            
            
            
            
            
this.WasCallback = WasCallback;
            
            
            
            
            
            
            
            
this.HadScreenShare = HadScreenShare;
            
            
            
            
            
            
            
            
this.HadCobrowse = HadCobrowse;
            
            
            
            
            
            
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
        /// The list of participants involved in the conversation.
        /// </summary>
        /// <value>The list of participants involved in the conversation.</value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<CallHistoryParticipant> Participants { get; set; }
        
        
        
        
        
        /// <summary>
        /// Did the call end in the current user&#39;s voicemail
        /// </summary>
        /// <value>Did the call end in the current user&#39;s voicemail</value>
        [DataMember(Name="wentToVoicemail", EmitDefaultValue=false)]
        public bool? WentToVoicemail { get; set; }
        
        
        
        /// <summary>
        /// Did the user not answer this conversation
        /// </summary>
        /// <value>Did the user not answer this conversation</value>
        [DataMember(Name="missedCall", EmitDefaultValue=false)]
        public bool? MissedCall { get; set; }
        
        
        
        /// <summary>
        /// The time the user joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time the user joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
        
        
        
        /// <summary>
        /// Was this conversation a conference
        /// </summary>
        /// <value>Was this conversation a conference</value>
        [DataMember(Name="wasConference", EmitDefaultValue=false)]
        public bool? WasConference { get; set; }
        
        
        
        /// <summary>
        /// Was this conversation a callback
        /// </summary>
        /// <value>Was this conversation a callback</value>
        [DataMember(Name="wasCallback", EmitDefaultValue=false)]
        public bool? WasCallback { get; set; }
        
        
        
        /// <summary>
        /// Did this conversation have a screen share session
        /// </summary>
        /// <value>Did this conversation have a screen share session</value>
        [DataMember(Name="hadScreenShare", EmitDefaultValue=false)]
        public bool? HadScreenShare { get; set; }
        
        
        
        /// <summary>
        /// Did this conversation have a cobrowse session
        /// </summary>
        /// <value>Did this conversation have a cobrowse session</value>
        [DataMember(Name="hadCobrowse", EmitDefaultValue=false)]
        public bool? HadCobrowse { get; set; }
        
        
        
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
            sb.Append("class CallHistoryConversation {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            
            sb.Append("  WentToVoicemail: ").Append(WentToVoicemail).Append("\n");
            
            sb.Append("  MissedCall: ").Append(MissedCall).Append("\n");
            
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            
            sb.Append("  WasConference: ").Append(WasConference).Append("\n");
            
            sb.Append("  WasCallback: ").Append(WasCallback).Append("\n");
            
            sb.Append("  HadScreenShare: ").Append(HadScreenShare).Append("\n");
            
            sb.Append("  HadCobrowse: ").Append(HadCobrowse).Append("\n");
            
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
            return this.Equals(obj as CallHistoryConversation);
        }

        /// <summary>
        /// Returns true if CallHistoryConversation instances are equal
        /// </summary>
        /// <param name="other">Instance of CallHistoryConversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallHistoryConversation other)
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
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.WentToVoicemail == other.WentToVoicemail ||
                    this.WentToVoicemail != null &&
                    this.WentToVoicemail.Equals(other.WentToVoicemail)
                ) &&
                (
                    this.MissedCall == other.MissedCall ||
                    this.MissedCall != null &&
                    this.MissedCall.Equals(other.MissedCall)
                ) &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.WasConference == other.WasConference ||
                    this.WasConference != null &&
                    this.WasConference.Equals(other.WasConference)
                ) &&
                (
                    this.WasCallback == other.WasCallback ||
                    this.WasCallback != null &&
                    this.WasCallback.Equals(other.WasCallback)
                ) &&
                (
                    this.HadScreenShare == other.HadScreenShare ||
                    this.HadScreenShare != null &&
                    this.HadScreenShare.Equals(other.HadScreenShare)
                ) &&
                (
                    this.HadCobrowse == other.HadCobrowse ||
                    this.HadCobrowse != null &&
                    this.HadCobrowse.Equals(other.HadCobrowse)
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
                
                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();
                
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                
                if (this.WentToVoicemail != null)
                    hash = hash * 59 + this.WentToVoicemail.GetHashCode();
                
                if (this.MissedCall != null)
                    hash = hash * 59 + this.MissedCall.GetHashCode();
                
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                
                if (this.WasConference != null)
                    hash = hash * 59 + this.WasConference.GetHashCode();
                
                if (this.WasCallback != null)
                    hash = hash * 59 + this.WasCallback.GetHashCode();
                
                if (this.HadScreenShare != null)
                    hash = hash * 59 + this.HadScreenShare.GetHashCode();
                
                if (this.HadCobrowse != null)
                    hash = hash * 59 + this.HadCobrowse.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
