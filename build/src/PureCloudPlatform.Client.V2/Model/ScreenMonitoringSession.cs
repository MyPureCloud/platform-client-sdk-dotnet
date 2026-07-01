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
    /// ScreenMonitoringSession
    /// </summary>
    [DataContract]
    public partial class ScreenMonitoringSession :  IEquatable<ScreenMonitoringSession>
    {
        /// <summary>
        /// The type of screen monitoring session
        /// </summary>
        /// <value>The type of screen monitoring session</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MonitoringTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agentlevel for "AgentLevel"
            /// </summary>
            [EnumMember(Value = "AgentLevel")]
            Agentlevel,
            
            /// <summary>
            /// Enum Conversationlevel for "ConversationLevel"
            /// </summary>
            [EnumMember(Value = "ConversationLevel")]
            Conversationlevel
        }
        /// <summary>
        /// The type of screen monitoring session
        /// </summary>
        /// <value>The type of screen monitoring session</value>
        [DataMember(Name="monitoringType", EmitDefaultValue=false)]
        public MonitoringTypeEnum? MonitoringType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenMonitoringSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScreenMonitoringSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenMonitoringSession" /> class.
        /// </summary>
        /// <param name="SourceUser">The user who initiated the screen monitoring session (required).</param>
        /// <param name="TargetUser">The user being monitored (for agent-level monitoring).</param>
        /// <param name="Conversation">The conversation being monitored (for conversation-level monitoring).</param>
        /// <param name="ParticipantId">The ID of the participant being monitored (for conversation-level monitoring).</param>
        /// <param name="MonitoringType">The type of screen monitoring session (required).</param>
        /// <param name="DateCreated">The date and time when the screen monitoring session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ScreenMonitoringId">The unique identifier for this screen monitoring session (required).</param>
        public ScreenMonitoringSession(AddressableEntityRef SourceUser = null, AddressableEntityRef TargetUser = null, AddressableEntityRef Conversation = null, string ParticipantId = null, MonitoringTypeEnum? MonitoringType = null, DateTime? DateCreated = null, string ScreenMonitoringId = null)
        {
            this.SourceUser = SourceUser;
            this.TargetUser = TargetUser;
            this.Conversation = Conversation;
            this.ParticipantId = ParticipantId;
            this.MonitoringType = MonitoringType;
            this.DateCreated = DateCreated;
            this.ScreenMonitoringId = ScreenMonitoringId;
            
        }
        


        /// <summary>
        /// The user who initiated the screen monitoring session
        /// </summary>
        /// <value>The user who initiated the screen monitoring session</value>
        [DataMember(Name="sourceUser", EmitDefaultValue=false)]
        public AddressableEntityRef SourceUser { get; set; }



        /// <summary>
        /// The user being monitored (for agent-level monitoring)
        /// </summary>
        /// <value>The user being monitored (for agent-level monitoring)</value>
        [DataMember(Name="targetUser", EmitDefaultValue=false)]
        public AddressableEntityRef TargetUser { get; set; }



        /// <summary>
        /// The conversation being monitored (for conversation-level monitoring)
        /// </summary>
        /// <value>The conversation being monitored (for conversation-level monitoring)</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public AddressableEntityRef Conversation { get; set; }



        /// <summary>
        /// The ID of the participant being monitored (for conversation-level monitoring)
        /// </summary>
        /// <value>The ID of the participant being monitored (for conversation-level monitoring)</value>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }





        /// <summary>
        /// The date and time when the screen monitoring session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time when the screen monitoring session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The unique identifier for this screen monitoring session
        /// </summary>
        /// <value>The unique identifier for this screen monitoring session</value>
        [DataMember(Name="screenMonitoringId", EmitDefaultValue=false)]
        public string ScreenMonitoringId { get; set; }



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
            sb.Append("class ScreenMonitoringSession {\n");

            sb.Append("  SourceUser: ").Append(SourceUser).Append("\n");
            sb.Append("  TargetUser: ").Append(TargetUser).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  MonitoringType: ").Append(MonitoringType).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ScreenMonitoringId: ").Append(ScreenMonitoringId).Append("\n");
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
            return this.Equals(obj as ScreenMonitoringSession);
        }

        /// <summary>
        /// Returns true if ScreenMonitoringSession instances are equal
        /// </summary>
        /// <param name="other">Instance of ScreenMonitoringSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenMonitoringSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceUser == other.SourceUser ||
                    this.SourceUser != null &&
                    this.SourceUser.Equals(other.SourceUser)
                ) &&
                (
                    this.TargetUser == other.TargetUser ||
                    this.TargetUser != null &&
                    this.TargetUser.Equals(other.TargetUser)
                ) &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.ParticipantId == other.ParticipantId ||
                    this.ParticipantId != null &&
                    this.ParticipantId.Equals(other.ParticipantId)
                ) &&
                (
                    this.MonitoringType == other.MonitoringType ||
                    this.MonitoringType != null &&
                    this.MonitoringType.Equals(other.MonitoringType)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.ScreenMonitoringId == other.ScreenMonitoringId ||
                    this.ScreenMonitoringId != null &&
                    this.ScreenMonitoringId.Equals(other.ScreenMonitoringId)
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
                if (this.SourceUser != null)
                    hash = hash * 59 + this.SourceUser.GetHashCode();

                if (this.TargetUser != null)
                    hash = hash * 59 + this.TargetUser.GetHashCode();

                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();

                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();

                if (this.MonitoringType != null)
                    hash = hash * 59 + this.MonitoringType.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.ScreenMonitoringId != null)
                    hash = hash * 59 + this.ScreenMonitoringId.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
