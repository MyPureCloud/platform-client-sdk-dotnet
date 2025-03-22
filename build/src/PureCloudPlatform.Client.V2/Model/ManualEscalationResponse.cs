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
    /// ManualEscalationResponse
    /// </summary>
    [DataContract]
    public partial class ManualEscalationResponse :  IEquatable<ManualEscalationResponse>
    {
        /// <summary>
        /// Escalation Status of the message.
        /// </summary>
        /// <value>Escalation Status of the message.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EscalationStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Throttled for "Throttled"
            /// </summary>
            [EnumMember(Value = "Throttled")]
            Throttled,
            
            /// <summary>
            /// Enum Previouslyescalated for "PreviouslyEscalated"
            /// </summary>
            [EnumMember(Value = "PreviouslyEscalated")]
            Previouslyescalated,
            
            /// <summary>
            /// Enum Notescalated for "NotEscalated"
            /// </summary>
            [EnumMember(Value = "NotEscalated")]
            Notescalated,
            
            /// <summary>
            /// Enum Automatic for "Automatic"
            /// </summary>
            [EnumMember(Value = "Automatic")]
            Automatic
        }
        /// <summary>
        /// Escalation Status of the message.
        /// </summary>
        /// <value>Escalation Status of the message.</value>
        [DataMember(Name="escalationStatus", EmitDefaultValue=false)]
        public EscalationStatusEnum? EscalationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualEscalationResponse" /> class.
        /// </summary>
        /// <param name="SocialMediaNormalizedMessageId">The Id of the message that got escalated..</param>
        /// <param name="ConversationNormalizedMessageId">The ID of the message in the conversation..</param>
        /// <param name="EscalationTarget">The target integration configuration used for an social media message..</param>
        /// <param name="EscalationStatus">Escalation Status of the message..</param>
        public ManualEscalationResponse(string SocialMediaNormalizedMessageId = null, string ConversationNormalizedMessageId = null, EscalationTarget EscalationTarget = null, EscalationStatusEnum? EscalationStatus = null)
        {
            this.SocialMediaNormalizedMessageId = SocialMediaNormalizedMessageId;
            this.ConversationNormalizedMessageId = ConversationNormalizedMessageId;
            this.EscalationTarget = EscalationTarget;
            this.EscalationStatus = EscalationStatus;
            
        }
        


        /// <summary>
        /// The Id of the message that got escalated.
        /// </summary>
        /// <value>The Id of the message that got escalated.</value>
        [DataMember(Name="socialMediaNormalizedMessageId", EmitDefaultValue=false)]
        public string SocialMediaNormalizedMessageId { get; set; }



        /// <summary>
        /// The ID of the message in the conversation.
        /// </summary>
        /// <value>The ID of the message in the conversation.</value>
        [DataMember(Name="conversationNormalizedMessageId", EmitDefaultValue=false)]
        public string ConversationNormalizedMessageId { get; set; }



        /// <summary>
        /// The target integration configuration used for an social media message.
        /// </summary>
        /// <value>The target integration configuration used for an social media message.</value>
        [DataMember(Name="escalationTarget", EmitDefaultValue=false)]
        public EscalationTarget EscalationTarget { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualEscalationResponse {\n");

            sb.Append("  SocialMediaNormalizedMessageId: ").Append(SocialMediaNormalizedMessageId).Append("\n");
            sb.Append("  ConversationNormalizedMessageId: ").Append(ConversationNormalizedMessageId).Append("\n");
            sb.Append("  EscalationTarget: ").Append(EscalationTarget).Append("\n");
            sb.Append("  EscalationStatus: ").Append(EscalationStatus).Append("\n");
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
            return this.Equals(obj as ManualEscalationResponse);
        }

        /// <summary>
        /// Returns true if ManualEscalationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ManualEscalationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualEscalationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SocialMediaNormalizedMessageId == other.SocialMediaNormalizedMessageId ||
                    this.SocialMediaNormalizedMessageId != null &&
                    this.SocialMediaNormalizedMessageId.Equals(other.SocialMediaNormalizedMessageId)
                ) &&
                (
                    this.ConversationNormalizedMessageId == other.ConversationNormalizedMessageId ||
                    this.ConversationNormalizedMessageId != null &&
                    this.ConversationNormalizedMessageId.Equals(other.ConversationNormalizedMessageId)
                ) &&
                (
                    this.EscalationTarget == other.EscalationTarget ||
                    this.EscalationTarget != null &&
                    this.EscalationTarget.Equals(other.EscalationTarget)
                ) &&
                (
                    this.EscalationStatus == other.EscalationStatus ||
                    this.EscalationStatus != null &&
                    this.EscalationStatus.Equals(other.EscalationStatus)
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
                if (this.SocialMediaNormalizedMessageId != null)
                    hash = hash * 59 + this.SocialMediaNormalizedMessageId.GetHashCode();

                if (this.ConversationNormalizedMessageId != null)
                    hash = hash * 59 + this.ConversationNormalizedMessageId.GetHashCode();

                if (this.EscalationTarget != null)
                    hash = hash * 59 + this.EscalationTarget.GetHashCode();

                if (this.EscalationStatus != null)
                    hash = hash * 59 + this.EscalationStatus.GetHashCode();

                return hash;
            }
        }
    }

}
