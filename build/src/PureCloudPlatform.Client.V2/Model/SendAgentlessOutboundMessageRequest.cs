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
    /// SendAgentlessOutboundMessageRequest
    /// </summary>
    [DataContract]
    public partial class SendAgentlessOutboundMessageRequest :  IEquatable<SendAgentlessOutboundMessageRequest>
    {
        /// <summary>
        /// The recipient messaging address messenger type.
        /// </summary>
        /// <value>The recipient messaging address messenger type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ToAddressMessengerTypeEnum
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
        /// The recipient messaging address messenger type.
        /// </summary>
        /// <value>The recipient messaging address messenger type.</value>
        [DataMember(Name="toAddressMessengerType", EmitDefaultValue=false)]
        public ToAddressMessengerTypeEnum? ToAddressMessengerType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendAgentlessOutboundMessageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendAgentlessOutboundMessageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendAgentlessOutboundMessageRequest" /> class.
        /// </summary>
        /// <param name="FromAddress">The messaging address of the sender of the message. For an SMS messenger type, this must be a currently provisioned SMS phone number. For a WhatsApp messenger type use the provisioned WhatsApp integration’s ID (required).</param>
        /// <param name="ToAddress">The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234. For WhatsApp messenger type, use a WhatsApp ID of a phone number. E.g for a E.164 formatted phone number `+13175555555`, a WhatsApp ID would be 13175555555 (required).</param>
        /// <param name="ToAddressMessengerType">The recipient messaging address messenger type. (required).</param>
        /// <param name="TextBody">The text of the message to send. This field is required in the case of SMS messenger type. Maximum character counts are: SMS - 765 characters, other channels - 2000 characters..</param>
        /// <param name="MessagingTemplate">The messaging template to use in the case of WhatsApp messenger type. This field is required when using WhatsApp messenger type.</param>
        /// <param name="UseExistingActiveConversation">Use an existing active conversation to send the agentless outbound message. Set this parameter to 'true' to use active conversation. Default value: false.</param>
        public SendAgentlessOutboundMessageRequest(string FromAddress = null, string ToAddress = null, ToAddressMessengerTypeEnum? ToAddressMessengerType = null, string TextBody = null, SendMessagingTemplateRequest MessagingTemplate = null, bool? UseExistingActiveConversation = null)
        {
            this.FromAddress = FromAddress;
            this.ToAddress = ToAddress;
            this.ToAddressMessengerType = ToAddressMessengerType;
            this.TextBody = TextBody;
            this.MessagingTemplate = MessagingTemplate;
            this.UseExistingActiveConversation = UseExistingActiveConversation;
            
        }
        


        /// <summary>
        /// The messaging address of the sender of the message. For an SMS messenger type, this must be a currently provisioned SMS phone number. For a WhatsApp messenger type use the provisioned WhatsApp integration’s ID
        /// </summary>
        /// <value>The messaging address of the sender of the message. For an SMS messenger type, this must be a currently provisioned SMS phone number. For a WhatsApp messenger type use the provisioned WhatsApp integration’s ID</value>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public string FromAddress { get; set; }



        /// <summary>
        /// The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234. For WhatsApp messenger type, use a WhatsApp ID of a phone number. E.g for a E.164 formatted phone number `+13175555555`, a WhatsApp ID would be 13175555555
        /// </summary>
        /// <value>The messaging address of the recipient of the message. For an SMS messenger type, the phone number address must be in E.164 format. E.g. +13175555555 or +34234234234. For WhatsApp messenger type, use a WhatsApp ID of a phone number. E.g for a E.164 formatted phone number `+13175555555`, a WhatsApp ID would be 13175555555</value>
        [DataMember(Name="toAddress", EmitDefaultValue=false)]
        public string ToAddress { get; set; }





        /// <summary>
        /// The text of the message to send. This field is required in the case of SMS messenger type. Maximum character counts are: SMS - 765 characters, other channels - 2000 characters.
        /// </summary>
        /// <value>The text of the message to send. This field is required in the case of SMS messenger type. Maximum character counts are: SMS - 765 characters, other channels - 2000 characters.</value>
        [DataMember(Name="textBody", EmitDefaultValue=false)]
        public string TextBody { get; set; }



        /// <summary>
        /// The messaging template to use in the case of WhatsApp messenger type. This field is required when using WhatsApp messenger type
        /// </summary>
        /// <value>The messaging template to use in the case of WhatsApp messenger type. This field is required when using WhatsApp messenger type</value>
        [DataMember(Name="messagingTemplate", EmitDefaultValue=false)]
        public SendMessagingTemplateRequest MessagingTemplate { get; set; }



        /// <summary>
        /// Use an existing active conversation to send the agentless outbound message. Set this parameter to 'true' to use active conversation. Default value: false
        /// </summary>
        /// <value>Use an existing active conversation to send the agentless outbound message. Set this parameter to 'true' to use active conversation. Default value: false</value>
        [DataMember(Name="useExistingActiveConversation", EmitDefaultValue=false)]
        public bool? UseExistingActiveConversation { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendAgentlessOutboundMessageRequest {\n");

            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  ToAddressMessengerType: ").Append(ToAddressMessengerType).Append("\n");
            sb.Append("  TextBody: ").Append(TextBody).Append("\n");
            sb.Append("  MessagingTemplate: ").Append(MessagingTemplate).Append("\n");
            sb.Append("  UseExistingActiveConversation: ").Append(UseExistingActiveConversation).Append("\n");
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
            return this.Equals(obj as SendAgentlessOutboundMessageRequest);
        }

        /// <summary>
        /// Returns true if SendAgentlessOutboundMessageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SendAgentlessOutboundMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendAgentlessOutboundMessageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.ToAddressMessengerType == other.ToAddressMessengerType ||
                    this.ToAddressMessengerType != null &&
                    this.ToAddressMessengerType.Equals(other.ToAddressMessengerType)
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
                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();

                if (this.ToAddress != null)
                    hash = hash * 59 + this.ToAddress.GetHashCode();

                if (this.ToAddressMessengerType != null)
                    hash = hash * 59 + this.ToAddressMessengerType.GetHashCode();

                if (this.TextBody != null)
                    hash = hash * 59 + this.TextBody.GetHashCode();

                if (this.MessagingTemplate != null)
                    hash = hash * 59 + this.MessagingTemplate.GetHashCode();

                if (this.UseExistingActiveConversation != null)
                    hash = hash * 59 + this.UseExistingActiveConversation.GetHashCode();

                return hash;
            }
        }
    }

}
