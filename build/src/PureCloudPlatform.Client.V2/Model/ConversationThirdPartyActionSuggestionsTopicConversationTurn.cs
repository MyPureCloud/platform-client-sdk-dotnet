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
    /// ConversationThirdPartyActionSuggestionsTopicConversationTurn
    /// </summary>
    [DataContract]
    public partial class ConversationThirdPartyActionSuggestionsTopicConversationTurn :  IEquatable<ConversationThirdPartyActionSuggestionsTopicConversationTurn>
    {
        /// <summary>
        /// Gets or Sets Participant
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ParticipantEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Agent for "AGENT"
            /// </summary>
            [EnumMember(Value = "AGENT")]
            Agent,
            
            /// <summary>
            /// Enum Customer for "CUSTOMER"
            /// </summary>
            [EnumMember(Value = "CUSTOMER")]
            Customer
        }
        /// <summary>
        /// Gets or Sets Participant
        /// </summary>
        [DataMember(Name="participant", EmitDefaultValue=false)]
        public ParticipantEnum? Participant { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationThirdPartyActionSuggestionsTopicConversationTurn" /> class.
        /// </summary>
        /// <param name="UtteranceId">UtteranceId.</param>
        /// <param name="MessageId">MessageId.</param>
        /// <param name="Participant">Participant.</param>
        /// <param name="Text">Text.</param>
        public ConversationThirdPartyActionSuggestionsTopicConversationTurn(Guid? UtteranceId = null, string MessageId = null, ParticipantEnum? Participant = null, string Text = null)
        {
            this.UtteranceId = UtteranceId;
            this.MessageId = MessageId;
            this.Participant = Participant;
            this.Text = Text;
            
        }
        


        /// <summary>
        /// Gets or Sets UtteranceId
        /// </summary>
        [DataMember(Name="utteranceId", EmitDefaultValue=false)]
        public Guid? UtteranceId { get; set; }



        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }





        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationThirdPartyActionSuggestionsTopicConversationTurn {\n");

            sb.Append("  UtteranceId: ").Append(UtteranceId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Participant: ").Append(Participant).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as ConversationThirdPartyActionSuggestionsTopicConversationTurn);
        }

        /// <summary>
        /// Returns true if ConversationThirdPartyActionSuggestionsTopicConversationTurn instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationThirdPartyActionSuggestionsTopicConversationTurn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationThirdPartyActionSuggestionsTopicConversationTurn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UtteranceId == other.UtteranceId ||
                    this.UtteranceId != null &&
                    this.UtteranceId.Equals(other.UtteranceId)
                ) &&
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) &&
                (
                    this.Participant == other.Participant ||
                    this.Participant != null &&
                    this.Participant.Equals(other.Participant)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                if (this.UtteranceId != null)
                    hash = hash * 59 + this.UtteranceId.GetHashCode();

                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();

                if (this.Participant != null)
                    hash = hash * 59 + this.Participant.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                return hash;
            }
        }
    }

}
