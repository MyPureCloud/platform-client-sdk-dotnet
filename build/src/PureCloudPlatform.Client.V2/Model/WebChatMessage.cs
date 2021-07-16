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
    /// WebChatMessage
    /// </summary>
    [DataContract]
    public partial class WebChatMessage :  IEquatable<WebChatMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The purpose of the message within the conversation, such as a standard text entry versus a greeting.
        /// </summary>
        /// <value>The purpose of the message within the conversation, such as a standard text entry versus a greeting.</value>
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
            /// Enum Standard for "standard"
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard,
            
            /// <summary>
            /// Enum Notice for "notice"
            /// </summary>
            [EnumMember(Value = "notice")]
            Notice,
            
            /// <summary>
            /// Enum Memberjoin for "member-join"
            /// </summary>
            [EnumMember(Value = "member-join")]
            Memberjoin,
            
            /// <summary>
            /// Enum Memberleave for "member-leave"
            /// </summary>
            [EnumMember(Value = "member-leave")]
            Memberleave,
            
            /// <summary>
            /// Enum Mediarequest for "media-request"
            /// </summary>
            [EnumMember(Value = "media-request")]
            Mediarequest
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The purpose of the message within the conversation, such as a standard text entry versus a greeting.
        /// </summary>
        /// <value>The purpose of the message within the conversation, such as a standard text entry versus a greeting.</value>
        [DataMember(Name="bodyType", EmitDefaultValue=false)]
        public BodyTypeEnum? BodyType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebChatMessage() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatMessage" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Conversation">The identifier of the conversation (required).</param>
        /// <param name="Sender">The member who sent the message (required).</param>
        /// <param name="Body">The message body. (required).</param>
        /// <param name="BodyType">The purpose of the message within the conversation, such as a standard text entry versus a greeting. (required).</param>
        /// <param name="Timestamp">The timestamp of the message, in ISO-8601 format (required).</param>
        public WebChatMessage(string Name = null, WebChatConversation Conversation = null, WebChatMemberInfo Sender = null, string Body = null, BodyTypeEnum? BodyType = null, DateTime? Timestamp = null)
        {
            this.Name = Name;
            this.Conversation = Conversation;
            this.Sender = Sender;
            this.Body = Body;
            this.BodyType = BodyType;
            this.Timestamp = Timestamp;
            
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
        /// The identifier of the conversation
        /// </summary>
        /// <value>The identifier of the conversation</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public WebChatConversation Conversation { get; set; }
        
        
        
        /// <summary>
        /// The member who sent the message
        /// </summary>
        /// <value>The member who sent the message</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public WebChatMemberInfo Sender { get; set; }
        
        
        
        /// <summary>
        /// The message body.
        /// </summary>
        /// <value>The message body.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }
        
        
        
        
        
        /// <summary>
        /// The timestamp of the message, in ISO-8601 format
        /// </summary>
        /// <value>The timestamp of the message, in ISO-8601 format</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        
        
        
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
            sb.Append("class WebChatMessage {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyType: ").Append(BodyType).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(obj as WebChatMessage);
        }

        /// <summary>
        /// Returns true if WebChatMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of WebChatMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebChatMessage other)
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
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.Sender == other.Sender ||
                    this.Sender != null &&
                    this.Sender.Equals(other.Sender)
                ) &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) &&
                (
                    this.BodyType == other.BodyType ||
                    this.BodyType != null &&
                    this.BodyType.Equals(other.BodyType)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();
                
                if (this.Sender != null)
                    hash = hash * 59 + this.Sender.GetHashCode();
                
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                
                if (this.BodyType != null)
                    hash = hash * 59 + this.BodyType.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
