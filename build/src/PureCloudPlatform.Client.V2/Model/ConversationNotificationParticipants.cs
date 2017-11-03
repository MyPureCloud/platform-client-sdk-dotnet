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
    /// ConversationNotificationParticipants
    /// </summary>
    [DataContract]
    public partial class ConversationNotificationParticipants :  IEquatable<ConversationNotificationParticipants>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ScreenRecordingState
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ScreenRecordingStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Requested for "REQUESTED"
            /// </summary>
            [EnumMember(Value = "REQUESTED")]
            Requested,
            
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
            /// Enum Stopped for "STOPPED"
            /// </summary>
            [EnumMember(Value = "STOPPED")]
            Stopped,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error,
            
            /// <summary>
            /// Enum Timeout for "TIMEOUT"
            /// </summary>
            [EnumMember(Value = "TIMEOUT")]
            Timeout
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ScreenRecordingState
        /// </summary>
        [DataMember(Name="screenRecordingState", EmitDefaultValue=false)]
        public ScreenRecordingStateEnum? ScreenRecordingState { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNotificationParticipants" /> class.
        /// </summary>
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="ConnectedTime">ConnectedTime.</param>
        
        
        
        /// <param name="EndTime">EndTime.</param>
        
        
        
        /// <param name="UserId">UserId.</param>
        
        
        
        /// <param name="ExternalContactId">ExternalContactId.</param>
        
        
        
        /// <param name="ExternalOrganizationId">ExternalOrganizationId.</param>
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="QueueId">QueueId.</param>
        
        
        
        /// <param name="GroupId">GroupId.</param>
        
        
        
        /// <param name="Purpose">Purpose.</param>
        
        
        
        /// <param name="ConsultParticipantId">ConsultParticipantId.</param>
        
        
        
        /// <param name="Address">Address.</param>
        
        
        
        /// <param name="WrapupRequired">WrapupRequired.</param>
        
        
        
        /// <param name="WrapupExpected">WrapupExpected.</param>
        
        
        
        /// <param name="WrapupPrompt">WrapupPrompt.</param>
        
        
        
        /// <param name="WrapupTimeoutMs">WrapupTimeoutMs.</param>
        
        
        
        /// <param name="Wrapup">Wrapup.</param>
        
        
        
        /// <param name="MonitoredParticipantId">MonitoredParticipantId.</param>
        
        
        
        /// <param name="ScreenRecordingState">ScreenRecordingState.</param>
        
        
        
        /// <param name="Attributes">Attributes.</param>
        
        
        
        /// <param name="Calls">Calls.</param>
        
        
        
        /// <param name="Callbacks">Callbacks.</param>
        
        
        
        /// <param name="Chats">Chats.</param>
        
        
        
        /// <param name="Cobrowsesessions">Cobrowsesessions.</param>
        
        
        
        /// <param name="Emails">Emails.</param>
        
        
        
        /// <param name="Messages">Messages.</param>
        
        
        
        /// <param name="Screenshares">Screenshares.</param>
        
        
        
        /// <param name="SocialExpressions">SocialExpressions.</param>
        
        
        
        /// <param name="Videos">Videos.</param>
        
        
        
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        
        
        public ConversationNotificationParticipants(string Id = null, DateTime? ConnectedTime = null, DateTime? EndTime = null, string UserId = null, string ExternalContactId = null, string ExternalOrganizationId = null, string Name = null, string QueueId = null, string GroupId = null, string Purpose = null, string ConsultParticipantId = null, string Address = null, bool? WrapupRequired = null, bool? WrapupExpected = null, string WrapupPrompt = null, int? WrapupTimeoutMs = null, ConversationNotificationWrapup Wrapup = null, string MonitoredParticipantId = null, ScreenRecordingStateEnum? ScreenRecordingState = null, Dictionary<string, string> Attributes = null, List<ConversationNotificationCalls> Calls = null, List<ConversationNotificationCallbacks> Callbacks = null, List<ConversationNotificationChats> Chats = null, List<ConversationNotificationCobrowsesessions> Cobrowsesessions = null, List<ConversationNotificationEmails> Emails = null, List<ConversationNotificationMessages1> Messages = null, List<ConversationNotificationScreenshares> Screenshares = null, List<ConversationNotificationSocialExpressions> SocialExpressions = null, List<ConversationNotificationVideos> Videos = null, Object AdditionalProperties = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.ConnectedTime = ConnectedTime;
            
            
            
            
            
            
            
            
this.EndTime = EndTime;
            
            
            
            
            
            
            
            
this.UserId = UserId;
            
            
            
            
            
            
            
            
this.ExternalContactId = ExternalContactId;
            
            
            
            
            
            
            
            
this.ExternalOrganizationId = ExternalOrganizationId;
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.QueueId = QueueId;
            
            
            
            
            
            
            
            
this.GroupId = GroupId;
            
            
            
            
            
            
            
            
this.Purpose = Purpose;
            
            
            
            
            
            
            
            
this.ConsultParticipantId = ConsultParticipantId;
            
            
            
            
            
            
            
            
this.Address = Address;
            
            
            
            
            
            
            
            
this.WrapupRequired = WrapupRequired;
            
            
            
            
            
            
            
            
this.WrapupExpected = WrapupExpected;
            
            
            
            
            
            
            
            
this.WrapupPrompt = WrapupPrompt;
            
            
            
            
            
            
            
            
this.WrapupTimeoutMs = WrapupTimeoutMs;
            
            
            
            
            
            
            
            
this.Wrapup = Wrapup;
            
            
            
            
            
            
            
            
this.MonitoredParticipantId = MonitoredParticipantId;
            
            
            
            
            
            
            
            
this.ScreenRecordingState = ScreenRecordingState;
            
            
            
            
            
            
            
            
this.Attributes = Attributes;
            
            
            
            
            
            
            
            
this.Calls = Calls;
            
            
            
            
            
            
            
            
this.Callbacks = Callbacks;
            
            
            
            
            
            
            
            
this.Chats = Chats;
            
            
            
            
            
            
            
            
this.Cobrowsesessions = Cobrowsesessions;
            
            
            
            
            
            
            
            
this.Emails = Emails;
            
            
            
            
            
            
            
            
this.Messages = Messages;
            
            
            
            
            
            
            
            
this.Screenshares = Screenshares;
            
            
            
            
            
            
            
            
this.SocialExpressions = SocialExpressions;
            
            
            
            
            
            
            
            
this.Videos = Videos;
            
            
            
            
            
            
            
            
this.AdditionalProperties = AdditionalProperties;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ConnectedTime
        /// </summary>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExternalContactId
        /// </summary>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExternalOrganizationId
        /// </summary>
        [DataMember(Name="externalOrganizationId", EmitDefaultValue=false)]
        public string ExternalOrganizationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ConsultParticipantId
        /// </summary>
        [DataMember(Name="consultParticipantId", EmitDefaultValue=false)]
        public string ConsultParticipantId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets WrapupRequired
        /// </summary>
        [DataMember(Name="wrapupRequired", EmitDefaultValue=false)]
        public bool? WrapupRequired { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets WrapupExpected
        /// </summary>
        [DataMember(Name="wrapupExpected", EmitDefaultValue=false)]
        public bool? WrapupExpected { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets WrapupPrompt
        /// </summary>
        [DataMember(Name="wrapupPrompt", EmitDefaultValue=false)]
        public string WrapupPrompt { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets WrapupTimeoutMs
        /// </summary>
        [DataMember(Name="wrapupTimeoutMs", EmitDefaultValue=false)]
        public int? WrapupTimeoutMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Wrapup
        /// </summary>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public ConversationNotificationWrapup Wrapup { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MonitoredParticipantId
        /// </summary>
        [DataMember(Name="monitoredParticipantId", EmitDefaultValue=false)]
        public string MonitoredParticipantId { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Calls
        /// </summary>
        [DataMember(Name="calls", EmitDefaultValue=false)]
        public List<ConversationNotificationCalls> Calls { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Callbacks
        /// </summary>
        [DataMember(Name="callbacks", EmitDefaultValue=false)]
        public List<ConversationNotificationCallbacks> Callbacks { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Chats
        /// </summary>
        [DataMember(Name="chats", EmitDefaultValue=false)]
        public List<ConversationNotificationChats> Chats { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Cobrowsesessions
        /// </summary>
        [DataMember(Name="cobrowsesessions", EmitDefaultValue=false)]
        public List<ConversationNotificationCobrowsesessions> Cobrowsesessions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<ConversationNotificationEmails> Emails { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<ConversationNotificationMessages1> Messages { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Screenshares
        /// </summary>
        [DataMember(Name="screenshares", EmitDefaultValue=false)]
        public List<ConversationNotificationScreenshares> Screenshares { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SocialExpressions
        /// </summary>
        [DataMember(Name="socialExpressions", EmitDefaultValue=false)]
        public List<ConversationNotificationSocialExpressions> SocialExpressions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name="videos", EmitDefaultValue=false)]
        public List<ConversationNotificationVideos> Videos { get; set; }
        
        
        
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
            sb.Append("class ConversationNotificationParticipants {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            
            sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            
            sb.Append("  ConsultParticipantId: ").Append(ConsultParticipantId).Append("\n");
            
            sb.Append("  Address: ").Append(Address).Append("\n");
            
            sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
            
            sb.Append("  WrapupExpected: ").Append(WrapupExpected).Append("\n");
            
            sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
            
            sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
            
            sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
            
            sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
            
            sb.Append("  ScreenRecordingState: ").Append(ScreenRecordingState).Append("\n");
            
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            
            sb.Append("  Calls: ").Append(Calls).Append("\n");
            
            sb.Append("  Callbacks: ").Append(Callbacks).Append("\n");
            
            sb.Append("  Chats: ").Append(Chats).Append("\n");
            
            sb.Append("  Cobrowsesessions: ").Append(Cobrowsesessions).Append("\n");
            
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            
            sb.Append("  Screenshares: ").Append(Screenshares).Append("\n");
            
            sb.Append("  SocialExpressions: ").Append(SocialExpressions).Append("\n");
            
            sb.Append("  Videos: ").Append(Videos).Append("\n");
            
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
            return this.Equals(obj as ConversationNotificationParticipants);
        }

        /// <summary>
        /// Returns true if ConversationNotificationParticipants instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationNotificationParticipants to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationNotificationParticipants other)
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
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.ExternalOrganizationId == other.ExternalOrganizationId ||
                    this.ExternalOrganizationId != null &&
                    this.ExternalOrganizationId.Equals(other.ExternalOrganizationId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.ConsultParticipantId == other.ConsultParticipantId ||
                    this.ConsultParticipantId != null &&
                    this.ConsultParticipantId.Equals(other.ConsultParticipantId)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.WrapupRequired == other.WrapupRequired ||
                    this.WrapupRequired != null &&
                    this.WrapupRequired.Equals(other.WrapupRequired)
                ) &&
                (
                    this.WrapupExpected == other.WrapupExpected ||
                    this.WrapupExpected != null &&
                    this.WrapupExpected.Equals(other.WrapupExpected)
                ) &&
                (
                    this.WrapupPrompt == other.WrapupPrompt ||
                    this.WrapupPrompt != null &&
                    this.WrapupPrompt.Equals(other.WrapupPrompt)
                ) &&
                (
                    this.WrapupTimeoutMs == other.WrapupTimeoutMs ||
                    this.WrapupTimeoutMs != null &&
                    this.WrapupTimeoutMs.Equals(other.WrapupTimeoutMs)
                ) &&
                (
                    this.Wrapup == other.Wrapup ||
                    this.Wrapup != null &&
                    this.Wrapup.Equals(other.Wrapup)
                ) &&
                (
                    this.MonitoredParticipantId == other.MonitoredParticipantId ||
                    this.MonitoredParticipantId != null &&
                    this.MonitoredParticipantId.Equals(other.MonitoredParticipantId)
                ) &&
                (
                    this.ScreenRecordingState == other.ScreenRecordingState ||
                    this.ScreenRecordingState != null &&
                    this.ScreenRecordingState.Equals(other.ScreenRecordingState)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.Calls == other.Calls ||
                    this.Calls != null &&
                    this.Calls.SequenceEqual(other.Calls)
                ) &&
                (
                    this.Callbacks == other.Callbacks ||
                    this.Callbacks != null &&
                    this.Callbacks.SequenceEqual(other.Callbacks)
                ) &&
                (
                    this.Chats == other.Chats ||
                    this.Chats != null &&
                    this.Chats.SequenceEqual(other.Chats)
                ) &&
                (
                    this.Cobrowsesessions == other.Cobrowsesessions ||
                    this.Cobrowsesessions != null &&
                    this.Cobrowsesessions.SequenceEqual(other.Cobrowsesessions)
                ) &&
                (
                    this.Emails == other.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(other.Emails)
                ) &&
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
                ) &&
                (
                    this.Screenshares == other.Screenshares ||
                    this.Screenshares != null &&
                    this.Screenshares.SequenceEqual(other.Screenshares)
                ) &&
                (
                    this.SocialExpressions == other.SocialExpressions ||
                    this.SocialExpressions != null &&
                    this.SocialExpressions.SequenceEqual(other.SocialExpressions)
                ) &&
                (
                    this.Videos == other.Videos ||
                    this.Videos != null &&
                    this.Videos.SequenceEqual(other.Videos)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();
                
                if (this.ExternalOrganizationId != null)
                    hash = hash * 59 + this.ExternalOrganizationId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                
                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();
                
                if (this.ConsultParticipantId != null)
                    hash = hash * 59 + this.ConsultParticipantId.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.WrapupRequired != null)
                    hash = hash * 59 + this.WrapupRequired.GetHashCode();
                
                if (this.WrapupExpected != null)
                    hash = hash * 59 + this.WrapupExpected.GetHashCode();
                
                if (this.WrapupPrompt != null)
                    hash = hash * 59 + this.WrapupPrompt.GetHashCode();
                
                if (this.WrapupTimeoutMs != null)
                    hash = hash * 59 + this.WrapupTimeoutMs.GetHashCode();
                
                if (this.Wrapup != null)
                    hash = hash * 59 + this.Wrapup.GetHashCode();
                
                if (this.MonitoredParticipantId != null)
                    hash = hash * 59 + this.MonitoredParticipantId.GetHashCode();
                
                if (this.ScreenRecordingState != null)
                    hash = hash * 59 + this.ScreenRecordingState.GetHashCode();
                
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                
                if (this.Calls != null)
                    hash = hash * 59 + this.Calls.GetHashCode();
                
                if (this.Callbacks != null)
                    hash = hash * 59 + this.Callbacks.GetHashCode();
                
                if (this.Chats != null)
                    hash = hash * 59 + this.Chats.GetHashCode();
                
                if (this.Cobrowsesessions != null)
                    hash = hash * 59 + this.Cobrowsesessions.GetHashCode();
                
                if (this.Emails != null)
                    hash = hash * 59 + this.Emails.GetHashCode();
                
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                
                if (this.Screenshares != null)
                    hash = hash * 59 + this.Screenshares.GetHashCode();
                
                if (this.SocialExpressions != null)
                    hash = hash * 59 + this.SocialExpressions.GetHashCode();
                
                if (this.Videos != null)
                    hash = hash * 59 + this.Videos.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
