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
    /// RecordingMessagingMessage
    /// </summary>
    [DataContract]
    public partial class RecordingMessagingMessage :  IEquatable<RecordingMessagingMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingMessagingMessage" /> class.
        /// </summary>
        /// <param name="From">The message sender session id..</param>
        /// <param name="FromUser">The user who sent this message..</param>
        /// <param name="FromExternalContact">The PureCloud external contact sender details..</param>
        /// <param name="To">The message recipient..</param>
        /// <param name="Timestamp">The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Id">A globally unique identifier for this communication..</param>
        /// <param name="MessageText">The content of this message..</param>
        /// <param name="MessageMediaAttachments">List of media objects attached  with this message..</param>
        /// <param name="MessageStickerAttachments">List of message stickers attached with this message..</param>
        /// <param name="QuickReplies">List of quick reply options offered with this message..</param>
        /// <param name="ButtonResponse">Button Response selected by user for this message..</param>
        public RecordingMessagingMessage(string From = null, User FromUser = null, ExternalContact FromExternalContact = null, string To = null, DateTime? Timestamp = null, string Id = null, string MessageText = null, List<MessageMediaAttachment> MessageMediaAttachments = null, List<MessageStickerAttachment> MessageStickerAttachments = null, List<QuickReply> QuickReplies = null, ButtonResponse ButtonResponse = null)
        {
            this.From = From;
            this.FromUser = FromUser;
            this.FromExternalContact = FromExternalContact;
            this.To = To;
            this.Timestamp = Timestamp;
            this.Id = Id;
            this.MessageText = MessageText;
            this.MessageMediaAttachments = MessageMediaAttachments;
            this.MessageStickerAttachments = MessageStickerAttachments;
            this.QuickReplies = QuickReplies;
            this.ButtonResponse = ButtonResponse;
            
        }
        
        
        
        /// <summary>
        /// The message sender session id.
        /// </summary>
        /// <value>The message sender session id.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }
        
        
        
        /// <summary>
        /// The user who sent this message.
        /// </summary>
        /// <value>The user who sent this message.</value>
        [DataMember(Name="fromUser", EmitDefaultValue=false)]
        public User FromUser { get; set; }
        
        
        
        /// <summary>
        /// The PureCloud external contact sender details.
        /// </summary>
        /// <value>The PureCloud external contact sender details.</value>
        [DataMember(Name="fromExternalContact", EmitDefaultValue=false)]
        public ExternalContact FromExternalContact { get; set; }
        
        
        
        /// <summary>
        /// The message recipient.
        /// </summary>
        /// <value>The message recipient.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }
        
        
        
        /// <summary>
        /// The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        
        
        
        /// <summary>
        /// A globally unique identifier for this communication.
        /// </summary>
        /// <value>A globally unique identifier for this communication.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The content of this message.
        /// </summary>
        /// <value>The content of this message.</value>
        [DataMember(Name="messageText", EmitDefaultValue=false)]
        public string MessageText { get; set; }
        
        
        
        /// <summary>
        /// List of media objects attached  with this message.
        /// </summary>
        /// <value>List of media objects attached  with this message.</value>
        [DataMember(Name="messageMediaAttachments", EmitDefaultValue=false)]
        public List<MessageMediaAttachment> MessageMediaAttachments { get; set; }
        
        
        
        /// <summary>
        /// List of message stickers attached with this message.
        /// </summary>
        /// <value>List of message stickers attached with this message.</value>
        [DataMember(Name="messageStickerAttachments", EmitDefaultValue=false)]
        public List<MessageStickerAttachment> MessageStickerAttachments { get; set; }
        
        
        
        /// <summary>
        /// List of quick reply options offered with this message.
        /// </summary>
        /// <value>List of quick reply options offered with this message.</value>
        [DataMember(Name="quickReplies", EmitDefaultValue=false)]
        public List<QuickReply> QuickReplies { get; set; }
        
        
        
        /// <summary>
        /// Button Response selected by user for this message.
        /// </summary>
        /// <value>Button Response selected by user for this message.</value>
        [DataMember(Name="buttonResponse", EmitDefaultValue=false)]
        public ButtonResponse ButtonResponse { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingMessagingMessage {\n");
            
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            sb.Append("  FromExternalContact: ").Append(FromExternalContact).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MessageText: ").Append(MessageText).Append("\n");
            sb.Append("  MessageMediaAttachments: ").Append(MessageMediaAttachments).Append("\n");
            sb.Append("  MessageStickerAttachments: ").Append(MessageStickerAttachments).Append("\n");
            sb.Append("  QuickReplies: ").Append(QuickReplies).Append("\n");
            sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
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
            return this.Equals(obj as RecordingMessagingMessage);
        }

        /// <summary>
        /// Returns true if RecordingMessagingMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingMessagingMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingMessagingMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.FromUser == other.FromUser ||
                    this.FromUser != null &&
                    this.FromUser.Equals(other.FromUser)
                ) &&
                (
                    this.FromExternalContact == other.FromExternalContact ||
                    this.FromExternalContact != null &&
                    this.FromExternalContact.Equals(other.FromExternalContact)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.MessageText == other.MessageText ||
                    this.MessageText != null &&
                    this.MessageText.Equals(other.MessageText)
                ) &&
                (
                    this.MessageMediaAttachments == other.MessageMediaAttachments ||
                    this.MessageMediaAttachments != null &&
                    this.MessageMediaAttachments.SequenceEqual(other.MessageMediaAttachments)
                ) &&
                (
                    this.MessageStickerAttachments == other.MessageStickerAttachments ||
                    this.MessageStickerAttachments != null &&
                    this.MessageStickerAttachments.SequenceEqual(other.MessageStickerAttachments)
                ) &&
                (
                    this.QuickReplies == other.QuickReplies ||
                    this.QuickReplies != null &&
                    this.QuickReplies.SequenceEqual(other.QuickReplies)
                ) &&
                (
                    this.ButtonResponse == other.ButtonResponse ||
                    this.ButtonResponse != null &&
                    this.ButtonResponse.Equals(other.ButtonResponse)
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
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.FromUser != null)
                    hash = hash * 59 + this.FromUser.GetHashCode();
                
                if (this.FromExternalContact != null)
                    hash = hash * 59 + this.FromExternalContact.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.MessageText != null)
                    hash = hash * 59 + this.MessageText.GetHashCode();
                
                if (this.MessageMediaAttachments != null)
                    hash = hash * 59 + this.MessageMediaAttachments.GetHashCode();
                
                if (this.MessageStickerAttachments != null)
                    hash = hash * 59 + this.MessageStickerAttachments.GetHashCode();
                
                if (this.QuickReplies != null)
                    hash = hash * 59 + this.QuickReplies.GetHashCode();
                
                if (this.ButtonResponse != null)
                    hash = hash * 59 + this.ButtonResponse.GetHashCode();
                
                return hash;
            }
        }
    }

}
