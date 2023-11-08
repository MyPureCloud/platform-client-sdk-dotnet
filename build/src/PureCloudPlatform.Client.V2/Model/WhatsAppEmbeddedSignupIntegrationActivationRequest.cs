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
    /// WhatsAppEmbeddedSignupIntegrationActivationRequest
    /// </summary>
    [DataContract]
    public partial class WhatsAppEmbeddedSignupIntegrationActivationRequest :  IEquatable<WhatsAppEmbeddedSignupIntegrationActivationRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppEmbeddedSignupIntegrationActivationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppEmbeddedSignupIntegrationActivationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppEmbeddedSignupIntegrationActivationRequest" /> class.
        /// </summary>
        /// <param name="PhoneNumber">Phone number to associate with the WhatsApp integration (required).</param>
        /// <param name="Pin">Specify the two-step verification PIN for that phone number (required).</param>
        public WhatsAppEmbeddedSignupIntegrationActivationRequest(string PhoneNumber = null, string Pin = null)
        {
            this.PhoneNumber = PhoneNumber;
            this.Pin = Pin;
            
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
        public string Name { get; private set; }



        /// <summary>
        /// Phone number to associate with the WhatsApp integration
        /// </summary>
        /// <value>Phone number to associate with the WhatsApp integration</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }



        /// <summary>
        /// Specify the two-step verification PIN for that phone number
        /// </summary>
        /// <value>Specify the two-step verification PIN for that phone number</value>
        [DataMember(Name="pin", EmitDefaultValue=false)]
        public string Pin { get; set; }



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
            sb.Append("class WhatsAppEmbeddedSignupIntegrationActivationRequest {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Pin: ").Append(Pin).Append("\n");
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
            return this.Equals(obj as WhatsAppEmbeddedSignupIntegrationActivationRequest);
        }

        /// <summary>
        /// Returns true if WhatsAppEmbeddedSignupIntegrationActivationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WhatsAppEmbeddedSignupIntegrationActivationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppEmbeddedSignupIntegrationActivationRequest other)
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
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.Pin == other.Pin ||
                    this.Pin != null &&
                    this.Pin.Equals(other.Pin)
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

                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();

                if (this.Pin != null)
                    hash = hash * 59 + this.Pin.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
