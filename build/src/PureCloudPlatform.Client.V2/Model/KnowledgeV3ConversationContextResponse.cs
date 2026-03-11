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
    /// KnowledgeV3ConversationContextResponse
    /// </summary>
    [DataContract]
    public partial class KnowledgeV3ConversationContextResponse :  IEquatable<KnowledgeV3ConversationContextResponse>
    {
        /// <summary>
        /// The media type of the conversation.
        /// </summary>
        /// <value>The media type of the conversation.</value>
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
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice
        }
        /// <summary>
        /// The media type of the conversation.
        /// </summary>
        /// <value>The media type of the conversation.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeV3ConversationContextResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeV3ConversationContextResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeV3ConversationContextResponse" /> class.
        /// </summary>
        /// <param name="Conversation">The conversation. (required).</param>
        /// <param name="Queue">The queue used to assign the interaction to the user..</param>
        /// <param name="ExternalContact">The end-user participant of the conversation..</param>
        /// <param name="MediaType">The media type of the conversation..</param>
        public KnowledgeV3ConversationContextResponse(AddressableEntityRef Conversation = null, AddressableEntityRef Queue = null, AddressableEntityRef ExternalContact = null, MediaTypeEnum? MediaType = null)
        {
            this.Conversation = Conversation;
            this.Queue = Queue;
            this.ExternalContact = ExternalContact;
            this.MediaType = MediaType;
            
        }
        


        /// <summary>
        /// The conversation.
        /// </summary>
        /// <value>The conversation.</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public AddressableEntityRef Conversation { get; set; }



        /// <summary>
        /// The queue used to assign the interaction to the user.
        /// </summary>
        /// <value>The queue used to assign the interaction to the user.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public AddressableEntityRef Queue { get; set; }



        /// <summary>
        /// The end-user participant of the conversation.
        /// </summary>
        /// <value>The end-user participant of the conversation.</value>
        [DataMember(Name="externalContact", EmitDefaultValue=false)]
        public AddressableEntityRef ExternalContact { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeV3ConversationContextResponse {\n");

            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
            return this.Equals(obj as KnowledgeV3ConversationContextResponse);
        }

        /// <summary>
        /// Returns true if KnowledgeV3ConversationContextResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeV3ConversationContextResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeV3ConversationContextResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.ExternalContact == other.ExternalContact ||
                    this.ExternalContact != null &&
                    this.ExternalContact.Equals(other.ExternalContact)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
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
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.ExternalContact != null)
                    hash = hash * 59 + this.ExternalContact.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                return hash;
            }
        }
    }

}
