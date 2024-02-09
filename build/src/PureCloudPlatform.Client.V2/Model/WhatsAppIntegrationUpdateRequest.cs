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
    /// WhatsAppIntegrationUpdateRequest
    /// </summary>
    [DataContract]
    public partial class WhatsAppIntegrationUpdateRequest :  IEquatable<WhatsAppIntegrationUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppIntegrationUpdateRequest" /> class.
        /// </summary>
        /// <param name="Name">WhatsApp Integration name.</param>
        /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
        /// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
        public WhatsAppIntegrationUpdateRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null)
        {
            this.Name = Name;
            this.SupportedContent = SupportedContent;
            this.MessagingSetting = MessagingSetting;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// WhatsApp Integration name
        /// </summary>
        /// <value>WhatsApp Integration name</value>
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
            sb.Append("class WhatsAppIntegrationUpdateRequest {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
            sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
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
            return this.Equals(obj as WhatsAppIntegrationUpdateRequest);
        }

        /// <summary>
        /// Returns true if WhatsAppIntegrationUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WhatsAppIntegrationUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppIntegrationUpdateRequest other)
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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
