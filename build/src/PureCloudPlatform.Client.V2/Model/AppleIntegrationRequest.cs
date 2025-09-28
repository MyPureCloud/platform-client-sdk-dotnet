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
    /// AppleIntegrationRequest
    /// </summary>
    [DataContract]
    public partial class AppleIntegrationRequest :  IEquatable<AppleIntegrationRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AppleIntegrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppleIntegrationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleIntegrationRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the Apple messaging integration. (required).</param>
        /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
        /// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
        /// <param name="MessagesForBusinessId">The Apple Messages for Business Id for the Apple messaging integration. (required).</param>
        /// <param name="BusinessName">The name of the business..</param>
        /// <param name="LogoUrl">The url of the businesses logo..</param>
        public AppleIntegrationRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null, string MessagesForBusinessId = null, string BusinessName = null, string LogoUrl = null)
        {
            this.Name = Name;
            this.SupportedContent = SupportedContent;
            this.MessagingSetting = MessagingSetting;
            this.MessagesForBusinessId = MessagesForBusinessId;
            this.BusinessName = BusinessName;
            this.LogoUrl = LogoUrl;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the Apple messaging integration.
        /// </summary>
        /// <value>The name of the Apple messaging integration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Defines the SupportedContent profile configured for an integration
        /// </summary>
        /// <value>Defines the SupportedContent profile configured for an integration</value>
        [DataMember(Name="supportedContent", EmitDefaultValue=false)]
        public SupportedContentReference SupportedContent { get; set; }



        /// <summary>
        /// Defines the message settings to be applied for this integration
        /// </summary>
        /// <value>Defines the message settings to be applied for this integration</value>
        [DataMember(Name="messagingSetting", EmitDefaultValue=false)]
        public MessagingSettingRequestReference MessagingSetting { get; set; }



        /// <summary>
        /// The Apple Messages for Business Id for the Apple messaging integration.
        /// </summary>
        /// <value>The Apple Messages for Business Id for the Apple messaging integration.</value>
        [DataMember(Name="messagesForBusinessId", EmitDefaultValue=false)]
        public string MessagesForBusinessId { get; set; }



        /// <summary>
        /// The name of the business.
        /// </summary>
        /// <value>The name of the business.</value>
        [DataMember(Name="businessName", EmitDefaultValue=false)]
        public string BusinessName { get; set; }



        /// <summary>
        /// The url of the businesses logo.
        /// </summary>
        /// <value>The url of the businesses logo.</value>
        [DataMember(Name="logoUrl", EmitDefaultValue=false)]
        public string LogoUrl { get; set; }



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
            sb.Append("class AppleIntegrationRequest {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
            sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
            sb.Append("  MessagesForBusinessId: ").Append(MessagesForBusinessId).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
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
            return this.Equals(obj as AppleIntegrationRequest);
        }

        /// <summary>
        /// Returns true if AppleIntegrationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AppleIntegrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleIntegrationRequest other)
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
                    this.MessagesForBusinessId == other.MessagesForBusinessId ||
                    this.MessagesForBusinessId != null &&
                    this.MessagesForBusinessId.Equals(other.MessagesForBusinessId)
                ) &&
                (
                    this.BusinessName == other.BusinessName ||
                    this.BusinessName != null &&
                    this.BusinessName.Equals(other.BusinessName)
                ) &&
                (
                    this.LogoUrl == other.LogoUrl ||
                    this.LogoUrl != null &&
                    this.LogoUrl.Equals(other.LogoUrl)
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

                if (this.MessagesForBusinessId != null)
                    hash = hash * 59 + this.MessagesForBusinessId.GetHashCode();

                if (this.BusinessName != null)
                    hash = hash * 59 + this.BusinessName.GetHashCode();

                if (this.LogoUrl != null)
                    hash = hash * 59 + this.LogoUrl.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
