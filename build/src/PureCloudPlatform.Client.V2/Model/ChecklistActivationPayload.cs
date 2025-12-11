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
    /// ChecklistActivationPayload
    /// </summary>
    [DataContract]
    public partial class ChecklistActivationPayload :  IEquatable<ChecklistActivationPayload>
    {
        /// <summary>
        /// Trigger type that activated this checklist.
        /// </summary>
        /// <value>Trigger type that activated this checklist.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActivationTriggerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Intent for "Intent"
            /// </summary>
            [EnumMember(Value = "Intent")]
            Intent,
            
            /// <summary>
            /// Enum Conversationstart for "ConversationStart"
            /// </summary>
            [EnumMember(Value = "ConversationStart")]
            Conversationstart
        }
        /// <summary>
        /// Media type.
        /// </summary>
        /// <value>Media type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email
        }
        /// <summary>
        /// Direction of the conversation.
        /// </summary>
        /// <value>Direction of the conversation.</value>
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
            /// Enum Inbound for "Inbound"
            /// </summary>
            [EnumMember(Value = "Inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "Outbound"
            /// </summary>
            [EnumMember(Value = "Outbound")]
            Outbound
        }
        /// <summary>
        /// Trigger type that activated this checklist.
        /// </summary>
        /// <value>Trigger type that activated this checklist.</value>
        [DataMember(Name="activationTriggerType", EmitDefaultValue=false)]
        public ActivationTriggerTypeEnum? ActivationTriggerType { get; set; }
        /// <summary>
        /// Media type.
        /// </summary>
        /// <value>Media type.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Direction of the conversation.
        /// </summary>
        /// <value>Direction of the conversation.</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistActivationPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChecklistActivationPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistActivationPayload" /> class.
        /// </summary>
        /// <param name="ActivationTriggerType">Trigger type that activated this checklist. (required).</param>
        /// <param name="IntentId">The intent ID if checklist was triggered by an intent..</param>
        /// <param name="IntentName">The intent name if checklist was triggered by an intent..</param>
        /// <param name="Language">Language associated with the checklist. (required).</param>
        /// <param name="AgentId">Agent ID..</param>
        /// <param name="ParticipantId">Participant ID..</param>
        /// <param name="QueueId">Queue ID..</param>
        /// <param name="AssistantId">Assistant ID..</param>
        /// <param name="MediaType">Media type..</param>
        /// <param name="Direction">Direction of the conversation..</param>
        public ChecklistActivationPayload(ActivationTriggerTypeEnum? ActivationTriggerType = null, string IntentId = null, string IntentName = null, string Language = null, string AgentId = null, string ParticipantId = null, string QueueId = null, string AssistantId = null, MediaTypeEnum? MediaType = null, DirectionEnum? Direction = null)
        {
            this.ActivationTriggerType = ActivationTriggerType;
            this.IntentId = IntentId;
            this.IntentName = IntentName;
            this.Language = Language;
            this.AgentId = AgentId;
            this.ParticipantId = ParticipantId;
            this.QueueId = QueueId;
            this.AssistantId = AssistantId;
            this.MediaType = MediaType;
            this.Direction = Direction;
            
        }
        




        /// <summary>
        /// The intent ID if checklist was triggered by an intent.
        /// </summary>
        /// <value>The intent ID if checklist was triggered by an intent.</value>
        [DataMember(Name="intentId", EmitDefaultValue=false)]
        public string IntentId { get; set; }



        /// <summary>
        /// The intent name if checklist was triggered by an intent.
        /// </summary>
        /// <value>The intent name if checklist was triggered by an intent.</value>
        [DataMember(Name="intentName", EmitDefaultValue=false)]
        public string IntentName { get; set; }



        /// <summary>
        /// Language associated with the checklist.
        /// </summary>
        /// <value>Language associated with the checklist.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Agent ID.
        /// </summary>
        /// <value>Agent ID.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// Participant ID.
        /// </summary>
        /// <value>Participant ID.</value>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }



        /// <summary>
        /// Queue ID.
        /// </summary>
        /// <value>Queue ID.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// Assistant ID.
        /// </summary>
        /// <value>Assistant ID.</value>
        [DataMember(Name="assistantId", EmitDefaultValue=false)]
        public string AssistantId { get; set; }






        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChecklistActivationPayload {\n");

            sb.Append("  ActivationTriggerType: ").Append(ActivationTriggerType).Append("\n");
            sb.Append("  IntentId: ").Append(IntentId).Append("\n");
            sb.Append("  IntentName: ").Append(IntentName).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  AssistantId: ").Append(AssistantId).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(obj as ChecklistActivationPayload);
        }

        /// <summary>
        /// Returns true if ChecklistActivationPayload instances are equal
        /// </summary>
        /// <param name="other">Instance of ChecklistActivationPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChecklistActivationPayload other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActivationTriggerType == other.ActivationTriggerType ||
                    this.ActivationTriggerType != null &&
                    this.ActivationTriggerType.Equals(other.ActivationTriggerType)
                ) &&
                (
                    this.IntentId == other.IntentId ||
                    this.IntentId != null &&
                    this.IntentId.Equals(other.IntentId)
                ) &&
                (
                    this.IntentName == other.IntentName ||
                    this.IntentName != null &&
                    this.IntentName.Equals(other.IntentName)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.ParticipantId == other.ParticipantId ||
                    this.ParticipantId != null &&
                    this.ParticipantId.Equals(other.ParticipantId)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.AssistantId == other.AssistantId ||
                    this.AssistantId != null &&
                    this.AssistantId.Equals(other.AssistantId)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
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
                if (this.ActivationTriggerType != null)
                    hash = hash * 59 + this.ActivationTriggerType.GetHashCode();

                if (this.IntentId != null)
                    hash = hash * 59 + this.IntentId.GetHashCode();

                if (this.IntentName != null)
                    hash = hash * 59 + this.IntentName.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.AssistantId != null)
                    hash = hash * 59 + this.AssistantId.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                return hash;
            }
        }
    }

}
