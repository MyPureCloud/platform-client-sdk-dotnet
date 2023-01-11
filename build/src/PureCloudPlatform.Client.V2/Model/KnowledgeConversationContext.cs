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
    /// KnowledgeConversationContext
    /// </summary>
    [DataContract]
    public partial class KnowledgeConversationContext :  IEquatable<KnowledgeConversationContext>
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
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Cobrowse for "Cobrowse"
            /// </summary>
            [EnumMember(Value = "Cobrowse")]
            Cobrowse,
            
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
            /// Enum Screenshare for "Screenshare"
            /// </summary>
            [EnumMember(Value = "Screenshare")]
            Screenshare,
            
            /// <summary>
            /// Enum Video for "Video"
            /// </summary>
            [EnumMember(Value = "Video")]
            Video,
            
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
        /// Initializes a new instance of the <see cref="KnowledgeConversationContext" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeConversationContext() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeConversationContext" /> class.
        /// </summary>
        /// <param name="ConversationId">The unique identifier of the conversation. (required).</param>
        /// <param name="MediaType">The media type of the conversation..</param>
        /// <param name="QueueId">The unique identifier of the queue used to assign the interaction to the user..</param>
        /// <param name="ExternalContactId">The external contact identifier of the end-user participant..</param>
        public KnowledgeConversationContext(string ConversationId = null, MediaTypeEnum? MediaType = null, string QueueId = null, string ExternalContactId = null)
        {
            this.ConversationId = ConversationId;
            this.MediaType = MediaType;
            this.QueueId = QueueId;
            this.ExternalContactId = ExternalContactId;
            
        }
        


        /// <summary>
        /// The unique identifier of the conversation.
        /// </summary>
        /// <value>The unique identifier of the conversation.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }





        /// <summary>
        /// The unique identifier of the queue used to assign the interaction to the user.
        /// </summary>
        /// <value>The unique identifier of the queue used to assign the interaction to the user.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// The external contact identifier of the end-user participant.
        /// </summary>
        /// <value>The external contact identifier of the end-user participant.</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeConversationContext {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
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
            return this.Equals(obj as KnowledgeConversationContext);
        }

        /// <summary>
        /// Returns true if KnowledgeConversationContext instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeConversationContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeConversationContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
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
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                return hash;
            }
        }
    }

}
