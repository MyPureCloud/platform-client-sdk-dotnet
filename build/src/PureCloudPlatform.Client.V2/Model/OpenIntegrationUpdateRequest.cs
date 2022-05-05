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
    /// OpenIntegrationUpdateRequest
    /// </summary>
    [DataContract]
    public partial class OpenIntegrationUpdateRequest :  IEquatable<OpenIntegrationUpdateRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenIntegrationUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpenIntegrationUpdateRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenIntegrationUpdateRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the Open messaging integration. (required).</param>
        /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
        /// <param name="MessagingSetting">MessagingSetting.</param>
        /// <param name="OutboundNotificationWebhookUrl">The outbound notification webhook URL for the Open messaging integration..</param>
        /// <param name="OutboundNotificationWebhookSignatureSecretToken">The outbound notification webhook signature secret token..</param>
        /// <param name="WebhookHeaders">The user specified headers for the Open messaging integration..</param>
        public OpenIntegrationUpdateRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingReference MessagingSetting = null, string OutboundNotificationWebhookUrl = null, string OutboundNotificationWebhookSignatureSecretToken = null, Dictionary<string, string> WebhookHeaders = null)
        {
            this.Name = Name;
            this.SupportedContent = SupportedContent;
            this.MessagingSetting = MessagingSetting;
            this.OutboundNotificationWebhookUrl = OutboundNotificationWebhookUrl;
            this.OutboundNotificationWebhookSignatureSecretToken = OutboundNotificationWebhookSignatureSecretToken;
            this.WebhookHeaders = WebhookHeaders;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the Open messaging integration.
        /// </summary>
        /// <value>The name of the Open messaging integration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Defines the SupportedContent profile configured for an integration
        /// </summary>
        /// <value>Defines the SupportedContent profile configured for an integration</value>
        [DataMember(Name="supportedContent", EmitDefaultValue=false)]
        public SupportedContentReference SupportedContent { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessagingSetting
        /// </summary>
        [DataMember(Name="messagingSetting", EmitDefaultValue=false)]
        public MessagingSettingReference MessagingSetting { get; set; }
        
        
        
        /// <summary>
        /// The outbound notification webhook URL for the Open messaging integration.
        /// </summary>
        /// <value>The outbound notification webhook URL for the Open messaging integration.</value>
        [DataMember(Name="outboundNotificationWebhookUrl", EmitDefaultValue=false)]
        public string OutboundNotificationWebhookUrl { get; set; }
        
        
        
        /// <summary>
        /// The outbound notification webhook signature secret token.
        /// </summary>
        /// <value>The outbound notification webhook signature secret token.</value>
        [DataMember(Name="outboundNotificationWebhookSignatureSecretToken", EmitDefaultValue=false)]
        public string OutboundNotificationWebhookSignatureSecretToken { get; set; }
        
        
        
        /// <summary>
        /// The user specified headers for the Open messaging integration.
        /// </summary>
        /// <value>The user specified headers for the Open messaging integration.</value>
        [DataMember(Name="webhookHeaders", EmitDefaultValue=false)]
        public Dictionary<string, string> WebhookHeaders { get; set; }
        
        
        
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
            sb.Append("class OpenIntegrationUpdateRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
            sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
            sb.Append("  OutboundNotificationWebhookUrl: ").Append(OutboundNotificationWebhookUrl).Append("\n");
            sb.Append("  OutboundNotificationWebhookSignatureSecretToken: ").Append(OutboundNotificationWebhookSignatureSecretToken).Append("\n");
            sb.Append("  WebhookHeaders: ").Append(WebhookHeaders).Append("\n");
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
            return this.Equals(obj as OpenIntegrationUpdateRequest);
        }

        /// <summary>
        /// Returns true if OpenIntegrationUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenIntegrationUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenIntegrationUpdateRequest other)
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
                    this.SupportedContent == other.SupportedContent ||
                    this.SupportedContent != null &&
                    this.SupportedContent.Equals(other.SupportedContent)
                ) &&
                (
                    this.MessagingSetting == other.MessagingSetting ||
                    this.MessagingSetting != null &&
                    this.MessagingSetting.Equals(other.MessagingSetting)
                ) &&
                (
                    this.OutboundNotificationWebhookUrl == other.OutboundNotificationWebhookUrl ||
                    this.OutboundNotificationWebhookUrl != null &&
                    this.OutboundNotificationWebhookUrl.Equals(other.OutboundNotificationWebhookUrl)
                ) &&
                (
                    this.OutboundNotificationWebhookSignatureSecretToken == other.OutboundNotificationWebhookSignatureSecretToken ||
                    this.OutboundNotificationWebhookSignatureSecretToken != null &&
                    this.OutboundNotificationWebhookSignatureSecretToken.Equals(other.OutboundNotificationWebhookSignatureSecretToken)
                ) &&
                (
                    this.WebhookHeaders == other.WebhookHeaders ||
                    this.WebhookHeaders != null &&
                    this.WebhookHeaders.SequenceEqual(other.WebhookHeaders)
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
                
                if (this.SupportedContent != null)
                    hash = hash * 59 + this.SupportedContent.GetHashCode();
                
                if (this.MessagingSetting != null)
                    hash = hash * 59 + this.MessagingSetting.GetHashCode();
                
                if (this.OutboundNotificationWebhookUrl != null)
                    hash = hash * 59 + this.OutboundNotificationWebhookUrl.GetHashCode();
                
                if (this.OutboundNotificationWebhookSignatureSecretToken != null)
                    hash = hash * 59 + this.OutboundNotificationWebhookSignatureSecretToken.GetHashCode();
                
                if (this.WebhookHeaders != null)
                    hash = hash * 59 + this.WebhookHeaders.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
