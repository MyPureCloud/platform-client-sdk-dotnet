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
    /// AgentlessEmailSendRequestDto
    /// </summary>
    [DataContract]
    public partial class AgentlessEmailSendRequestDto :  IEquatable<AgentlessEmailSendRequestDto>
    {
        /// <summary>
        /// The direction of the message.
        /// </summary>
        /// <value>The direction of the message.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SenderTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Outbound for "Outbound"
            /// </summary>
            [EnumMember(Value = "Outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Inbound for "Inbound"
            /// </summary>
            [EnumMember(Value = "Inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Integration for "Integration"
            /// </summary>
            [EnumMember(Value = "Integration")]
            Integration
        }
        /// <summary>
        /// The direction of the message.
        /// </summary>
        /// <value>The direction of the message.</value>
        [DataMember(Name="senderType", EmitDefaultValue=false)]
        public SenderTypeEnum? SenderType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentlessEmailSendRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentlessEmailSendRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentlessEmailSendRequestDto" /> class.
        /// </summary>
        /// <param name="SenderType">The direction of the message. (required).</param>
        /// <param name="ConversationId">The identifier of the conversation..</param>
        /// <param name="FromAddress">The sender of the message. (required).</param>
        /// <param name="ToAddresses">The recipient(s) of the message. (required).</param>
        /// <param name="ReplyToAddress">The address to use for reply..</param>
        /// <param name="Subject">The subject of the message..</param>
        /// <param name="TextBody">The Content of the message, in plain text..</param>
        /// <param name="HtmlBody">The Content of the message, in HTML. Links, images and styles are allowed.</param>
        public AgentlessEmailSendRequestDto(SenderTypeEnum? SenderType = null, string ConversationId = null, EmailAddress FromAddress = null, List<EmailAddress> ToAddresses = null, EmailAddress ReplyToAddress = null, string Subject = null, string TextBody = null, string HtmlBody = null)
        {
            this.SenderType = SenderType;
            this.ConversationId = ConversationId;
            this.FromAddress = FromAddress;
            this.ToAddresses = ToAddresses;
            this.ReplyToAddress = ReplyToAddress;
            this.Subject = Subject;
            this.TextBody = TextBody;
            this.HtmlBody = HtmlBody;
            
        }
        




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
        public EmailAddress FromAddress { get; set; }



        /// <summary>
        /// The recipient(s) of the message.
        /// </summary>
        /// <value>The recipient(s) of the message.</value>
        [DataMember(Name="toAddresses", EmitDefaultValue=false)]
        public List<EmailAddress> ToAddresses { get; set; }



        /// <summary>
        /// The address to use for reply.
        /// </summary>
        /// <value>The address to use for reply.</value>
        [DataMember(Name="replyToAddress", EmitDefaultValue=false)]
        public EmailAddress ReplyToAddress { get; set; }



        /// <summary>
        /// The subject of the message.
        /// </summary>
        /// <value>The subject of the message.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }



        /// <summary>
        /// The Content of the message, in plain text.
        /// </summary>
        /// <value>The Content of the message, in plain text.</value>
        [DataMember(Name="textBody", EmitDefaultValue=false)]
        public string TextBody { get; set; }



        /// <summary>
        /// The Content of the message, in HTML. Links, images and styles are allowed
        /// </summary>
        /// <value>The Content of the message, in HTML. Links, images and styles are allowed</value>
        [DataMember(Name="htmlBody", EmitDefaultValue=false)]
        public string HtmlBody { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentlessEmailSendRequestDto {\n");

            sb.Append("  SenderType: ").Append(SenderType).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddresses: ").Append(ToAddresses).Append("\n");
            sb.Append("  ReplyToAddress: ").Append(ReplyToAddress).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TextBody: ").Append(TextBody).Append("\n");
            sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
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
            return this.Equals(obj as AgentlessEmailSendRequestDto);
        }

        /// <summary>
        /// Returns true if AgentlessEmailSendRequestDto instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentlessEmailSendRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentlessEmailSendRequestDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SenderType == other.SenderType ||
                    this.SenderType != null &&
                    this.SenderType.Equals(other.SenderType)
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
                    this.ToAddresses == other.ToAddresses ||
                    this.ToAddresses != null &&
                    this.ToAddresses.SequenceEqual(other.ToAddresses)
                ) &&
                (
                    this.ReplyToAddress == other.ReplyToAddress ||
                    this.ReplyToAddress != null &&
                    this.ReplyToAddress.Equals(other.ReplyToAddress)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.TextBody == other.TextBody ||
                    this.TextBody != null &&
                    this.TextBody.Equals(other.TextBody)
                ) &&
                (
                    this.HtmlBody == other.HtmlBody ||
                    this.HtmlBody != null &&
                    this.HtmlBody.Equals(other.HtmlBody)
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
                if (this.SenderType != null)
                    hash = hash * 59 + this.SenderType.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();

                if (this.ToAddresses != null)
                    hash = hash * 59 + this.ToAddresses.GetHashCode();

                if (this.ReplyToAddress != null)
                    hash = hash * 59 + this.ReplyToAddress.GetHashCode();

                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();

                if (this.TextBody != null)
                    hash = hash * 59 + this.TextBody.GetHashCode();

                if (this.HtmlBody != null)
                    hash = hash * 59 + this.HtmlBody.GetHashCode();

                return hash;
            }
        }
    }

}
