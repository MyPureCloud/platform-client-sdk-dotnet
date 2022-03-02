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
    /// SendAgentlessOutboundMessageResponse
    /// </summary>
    [DataContract]
    public partial class SendAgentlessOutboundMessageResponse :  IEquatable<SendAgentlessOutboundMessageResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Type of messenger.
        /// </summary>
        /// <value>Type of messenger.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessengerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms,
            
            /// <summary>
            /// Enum Whatsapp for "whatsapp"
            /// </summary>
            [EnumMember(Value = "whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Open for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            Open
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Type of messenger.
        /// </summary>
        /// <value>Type of messenger.</value>
        [DataMember(Name="messengerType", EmitDefaultValue=false)]
        public MessengerTypeEnum? MessengerType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SendAgentlessOutboundMessageResponse" /> class.
        /// </summary>
        /// <param name="ConversationId">The identifier of the conversation..</param>
        /// <param name="FromAddress">The sender of the message..</param>
        /// <param name="ToAddress">The recipient of the message..</param>
        /// <param name="MessengerType">Type of messenger..</param>
        /// <param name="TextBody">The body of the text message..</param>
        /// <param name="MessagingTemplate">The messaging template sent.</param>
        /// <param name="UseExistingActiveConversation">Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false.</param>
        /// <param name="Timestamp">The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public SendAgentlessOutboundMessageResponse(string ConversationId = null, string FromAddress = null, string ToAddress = null, MessengerTypeEnum? MessengerType = null, string TextBody = null, MessagingTemplateRequest MessagingTemplate = null, bool? UseExistingActiveConversation = null, DateTime? Timestamp = null)
        {
            this.ConversationId = ConversationId;
            this.FromAddress = FromAddress;
            this.ToAddress = ToAddress;
            this.MessengerType = MessengerType;
            this.TextBody = TextBody;
            this.MessagingTemplate = MessagingTemplate;
            this.UseExistingActiveConversation = UseExistingActiveConversation;
            this.Timestamp = Timestamp;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The identifier of the conversation.
        /// </summary>
        /// <value>The identifier of the conversation.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// The sender of the message.
        /// </summary>
        /// <value>The sender of the message.</value>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public string FromAddress { get; set; }
        
        
        
        /// <summary>
        /// The recipient of the message.
        /// </summary>
        /// <value>The recipient of the message.</value>
        [DataMember(Name="toAddress", EmitDefaultValue=false)]
        public string ToAddress { get; set; }
        
        
        
        
        
        /// <summary>
        /// The body of the text message.
        /// </summary>
        /// <value>The body of the text message.</value>
        [DataMember(Name="textBody", EmitDefaultValue=false)]
        public string TextBody { get; set; }
        
        
        
        /// <summary>
        /// The messaging template sent
        /// </summary>
        /// <value>The messaging template sent</value>
        [DataMember(Name="messagingTemplate", EmitDefaultValue=false)]
        public MessagingTemplateRequest MessagingTemplate { get; set; }
        
        
        
        /// <summary>
        /// Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false
        /// </summary>
        /// <value>Use an existing active conversation to send the agentless outbound message. Set this parameter to &#39;true&#39; to use active conversation. Default value: false</value>
        [DataMember(Name="useExistingActiveConversation", EmitDefaultValue=false)]
        public bool? UseExistingActiveConversation { get; set; }
        
        
        
        /// <summary>
        /// The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// Details of the user created the job
        /// </summary>
        /// <value>Details of the user created the job</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public AddressableEntityRef User { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendAgentlessOutboundMessageResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  MessengerType: ").Append(MessengerType).Append("\n");
            sb.Append("  TextBody: ").Append(TextBody).Append("\n");
            sb.Append("  MessagingTemplate: ").Append(MessagingTemplate).Append("\n");
            sb.Append("  UseExistingActiveConversation: ").Append(UseExistingActiveConversation).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as SendAgentlessOutboundMessageResponse);
        }

        /// <summary>
        /// Returns true if SendAgentlessOutboundMessageResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SendAgentlessOutboundMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendAgentlessOutboundMessageResponse other)
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
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.FromAddress == other.FromAddress ||
                    this.FromAddress != null &&
                    this.FromAddress.Equals(other.FromAddress)
                ) &&
                (
                    this.ToAddress == other.ToAddress ||
                    this.ToAddress != null &&
                    this.ToAddress.Equals(other.ToAddress)
                ) &&
                (
                    this.MessengerType == other.MessengerType ||
                    this.MessengerType != null &&
                    this.MessengerType.Equals(other.MessengerType)
                ) &&
                (
                    this.TextBody == other.TextBody ||
                    this.TextBody != null &&
                    this.TextBody.Equals(other.TextBody)
                ) &&
                (
                    this.MessagingTemplate == other.MessagingTemplate ||
                    this.MessagingTemplate != null &&
                    this.MessagingTemplate.Equals(other.MessagingTemplate)
                ) &&
                (
                    this.UseExistingActiveConversation == other.UseExistingActiveConversation ||
                    this.UseExistingActiveConversation != null &&
                    this.UseExistingActiveConversation.Equals(other.UseExistingActiveConversation)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();
                
                if (this.ToAddress != null)
                    hash = hash * 59 + this.ToAddress.GetHashCode();
                
                if (this.MessengerType != null)
                    hash = hash * 59 + this.MessengerType.GetHashCode();
                
                if (this.TextBody != null)
                    hash = hash * 59 + this.TextBody.GetHashCode();
                
                if (this.MessagingTemplate != null)
                    hash = hash * 59 + this.MessagingTemplate.GetHashCode();
                
                if (this.UseExistingActiveConversation != null)
                    hash = hash * 59 + this.UseExistingActiveConversation.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                return hash;
            }
        }
    }

}
