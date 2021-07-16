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
    /// ChatMessage
    /// </summary>
    [DataContract]
    public partial class ChatMessage :  IEquatable<ChatMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Type of the message body (v2 chats only)
        /// </summary>
        /// <value>Type of the message body (v2 chats only)</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BodyTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Standard for "STANDARD"
            /// </summary>
            [EnumMember(Value = "STANDARD")]
            Standard,
            
            /// <summary>
            /// Enum Activity for "ACTIVITY"
            /// </summary>
            [EnumMember(Value = "ACTIVITY")]
            Activity,
            
            /// <summary>
            /// Enum Typing for "TYPING"
            /// </summary>
            [EnumMember(Value = "TYPING")]
            Typing,
            
            /// <summary>
            /// Enum Notice for "NOTICE"
            /// </summary>
            [EnumMember(Value = "NOTICE")]
            Notice,
            
            /// <summary>
            /// Enum Memberjoin for "MEMBERJOIN"
            /// </summary>
            [EnumMember(Value = "MEMBERJOIN")]
            Memberjoin,
            
            /// <summary>
            /// Enum Memberleave for "MEMBERLEAVE"
            /// </summary>
            [EnumMember(Value = "MEMBERLEAVE")]
            Memberleave,
            
            /// <summary>
            /// Enum Mediarequest for "MEDIAREQUEST"
            /// </summary>
            [EnumMember(Value = "MEDIAREQUEST")]
            Mediarequest
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Type of the message body (v2 chats only)
        /// </summary>
        /// <value>Type of the message body (v2 chats only)</value>
        [DataMember(Name="bodyType", EmitDefaultValue=false)]
        public BodyTypeEnum? BodyType { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        /// <param name="Body">The message body.</param>
        /// <param name="Id">Id.</param>
        /// <param name="To">The message recipient.</param>
        /// <param name="From">The message sender.</param>
        /// <param name="Utc">Utc.</param>
        /// <param name="Chat">The interaction id (if available).</param>
        /// <param name="Message">The message id.</param>
        /// <param name="Type">Type.</param>
        /// <param name="BodyType">Type of the message body (v2 chats only).</param>
        /// <param name="SenderCommunicationId">Communication of sender (v2 chats only).</param>
        /// <param name="ParticipantPurpose">Participant purpose of sender (v2 chats only).</param>
        /// <param name="User">The user information for the sender (if available).</param>
        public ChatMessage(string Body = null, string Id = null, string To = null, string From = null, string Utc = null, string Chat = null, string Message = null, string Type = null, BodyTypeEnum? BodyType = null, string SenderCommunicationId = null, string ParticipantPurpose = null, ChatMessageUser User = null)
        {
            this.Body = Body;
            this.Id = Id;
            this.To = To;
            this.From = From;
            this.Utc = Utc;
            this.Chat = Chat;
            this.Message = Message;
            this.Type = Type;
            this.BodyType = BodyType;
            this.SenderCommunicationId = SenderCommunicationId;
            this.ParticipantPurpose = ParticipantPurpose;
            this.User = User;
            
        }
        
        
        
        /// <summary>
        /// The message body
        /// </summary>
        /// <value>The message body</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The message recipient
        /// </summary>
        /// <value>The message recipient</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }
        
        
        
        /// <summary>
        /// The message sender
        /// </summary>
        /// <value>The message sender</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Utc
        /// </summary>
        [DataMember(Name="utc", EmitDefaultValue=false)]
        public string Utc { get; set; }
        
        
        
        /// <summary>
        /// The interaction id (if available)
        /// </summary>
        /// <value>The interaction id (if available)</value>
        [DataMember(Name="chat", EmitDefaultValue=false)]
        public string Chat { get; set; }
        
        
        
        /// <summary>
        /// The message id
        /// </summary>
        /// <value>The message id</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        
        
        
        /// <summary>
        /// Communication of sender (v2 chats only)
        /// </summary>
        /// <value>Communication of sender (v2 chats only)</value>
        [DataMember(Name="senderCommunicationId", EmitDefaultValue=false)]
        public string SenderCommunicationId { get; set; }
        
        
        
        /// <summary>
        /// Participant purpose of sender (v2 chats only)
        /// </summary>
        /// <value>Participant purpose of sender (v2 chats only)</value>
        [DataMember(Name="participantPurpose", EmitDefaultValue=false)]
        public string ParticipantPurpose { get; set; }
        
        
        
        /// <summary>
        /// The user information for the sender (if available)
        /// </summary>
        /// <value>The user information for the sender (if available)</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public ChatMessageUser User { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatMessage {\n");
            
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Utc: ").Append(Utc).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BodyType: ").Append(BodyType).Append("\n");
            sb.Append("  SenderCommunicationId: ").Append(SenderCommunicationId).Append("\n");
            sb.Append("  ParticipantPurpose: ").Append(ParticipantPurpose).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as ChatMessage);
        }

        /// <summary>
        /// Returns true if ChatMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ChatMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.Utc == other.Utc ||
                    this.Utc != null &&
                    this.Utc.Equals(other.Utc)
                ) &&
                (
                    this.Chat == other.Chat ||
                    this.Chat != null &&
                    this.Chat.Equals(other.Chat)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.BodyType == other.BodyType ||
                    this.BodyType != null &&
                    this.BodyType.Equals(other.BodyType)
                ) &&
                (
                    this.SenderCommunicationId == other.SenderCommunicationId ||
                    this.SenderCommunicationId != null &&
                    this.SenderCommunicationId.Equals(other.SenderCommunicationId)
                ) &&
                (
                    this.ParticipantPurpose == other.ParticipantPurpose ||
                    this.ParticipantPurpose != null &&
                    this.ParticipantPurpose.Equals(other.ParticipantPurpose)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.Utc != null)
                    hash = hash * 59 + this.Utc.GetHashCode();
                
                if (this.Chat != null)
                    hash = hash * 59 + this.Chat.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.BodyType != null)
                    hash = hash * 59 + this.BodyType.GetHashCode();
                
                if (this.SenderCommunicationId != null)
                    hash = hash * 59 + this.SenderCommunicationId.GetHashCode();
                
                if (this.ParticipantPurpose != null)
                    hash = hash * 59 + this.ParticipantPurpose.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                return hash;
            }
        }
    }

}
