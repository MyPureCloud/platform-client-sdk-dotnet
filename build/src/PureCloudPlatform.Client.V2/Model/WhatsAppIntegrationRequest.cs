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
    /// WhatsAppIntegrationRequest
    /// </summary>
    [DataContract]
    public partial class WhatsAppIntegrationRequest :  IEquatable<WhatsAppIntegrationRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppIntegrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppIntegrationRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppIntegrationRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the WhatsApp Integration (required).</param>
        /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
        /// <param name="PhoneNumber">The phone number associated to the whatsApp integration (required).</param>
        /// <param name="WabaCertificate">The waba(WhatsApp Business Manager) certificate associated to the WhatsApp integration phone number (required).</param>
        public WhatsAppIntegrationRequest(string Name = null, SupportedContentReference SupportedContent = null, string PhoneNumber = null, string WabaCertificate = null)
        {
            this.Name = Name;
            this.SupportedContent = SupportedContent;
            this.PhoneNumber = PhoneNumber;
            this.WabaCertificate = WabaCertificate;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the WhatsApp Integration
        /// </summary>
        /// <value>The name of the WhatsApp Integration</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Defines the SupportedContent profile configured for an integration
        /// </summary>
        /// <value>Defines the SupportedContent profile configured for an integration</value>
        [DataMember(Name="supportedContent", EmitDefaultValue=false)]
        public SupportedContentReference SupportedContent { get; set; }
        
        
        
        /// <summary>
        /// The phone number associated to the whatsApp integration
        /// </summary>
        /// <value>The phone number associated to the whatsApp integration</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        
        
        
        /// <summary>
        /// The waba(WhatsApp Business Manager) certificate associated to the WhatsApp integration phone number
        /// </summary>
        /// <value>The waba(WhatsApp Business Manager) certificate associated to the WhatsApp integration phone number</value>
        [DataMember(Name="wabaCertificate", EmitDefaultValue=false)]
        public string WabaCertificate { get; set; }
        
        
        
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
            sb.Append("class WhatsAppIntegrationRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  WabaCertificate: ").Append(WabaCertificate).Append("\n");
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
            return this.Equals(obj as WhatsAppIntegrationRequest);
        }

        /// <summary>
        /// Returns true if WhatsAppIntegrationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WhatsAppIntegrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppIntegrationRequest other)
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
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.WabaCertificate == other.WabaCertificate ||
                    this.WabaCertificate != null &&
                    this.WabaCertificate.Equals(other.WabaCertificate)
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
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.WabaCertificate != null)
                    hash = hash * 59 + this.WabaCertificate.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
