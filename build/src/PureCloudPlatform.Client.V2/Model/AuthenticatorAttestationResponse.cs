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
    /// AuthenticatorAttestationResponse
    /// </summary>
    [DataContract]
    public partial class AuthenticatorAttestationResponse :  IEquatable<AuthenticatorAttestationResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatorAttestationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticatorAttestationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatorAttestationResponse" /> class.
        /// </summary>
        /// <param name="ClientDataJSON">The JSON-serialized client data passed to the authenticator (base64url-encoded). (required).</param>
        /// <param name="AttestationObject">The attestation object containing the credential public key and attestation statement (base64url-encoded CBOR). (required).</param>
        /// <param name="Transports">The transports the authenticator is believed to support..</param>
        public AuthenticatorAttestationResponse(string ClientDataJSON = null, string AttestationObject = null, List<string> Transports = null)
        {
            this.ClientDataJSON = ClientDataJSON;
            this.AttestationObject = AttestationObject;
            this.Transports = Transports;
            
        }
        


        /// <summary>
        /// The JSON-serialized client data passed to the authenticator (base64url-encoded).
        /// </summary>
        /// <value>The JSON-serialized client data passed to the authenticator (base64url-encoded).</value>
        [DataMember(Name="clientDataJSON", EmitDefaultValue=false)]
        public string ClientDataJSON { get; set; }



        /// <summary>
        /// The attestation object containing the credential public key and attestation statement (base64url-encoded CBOR).
        /// </summary>
        /// <value>The attestation object containing the credential public key and attestation statement (base64url-encoded CBOR).</value>
        [DataMember(Name="attestationObject", EmitDefaultValue=false)]
        public string AttestationObject { get; set; }



        /// <summary>
        /// The transports the authenticator is believed to support.
        /// </summary>
        /// <value>The transports the authenticator is believed to support.</value>
        [DataMember(Name="transports", EmitDefaultValue=false)]
        public List<string> Transports { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticatorAttestationResponse {\n");

            sb.Append("  ClientDataJSON: ").Append(ClientDataJSON).Append("\n");
            sb.Append("  AttestationObject: ").Append(AttestationObject).Append("\n");
            sb.Append("  Transports: ").Append(Transports).Append("\n");
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
            return this.Equals(obj as AuthenticatorAttestationResponse);
        }

        /// <summary>
        /// Returns true if AuthenticatorAttestationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthenticatorAttestationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticatorAttestationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ClientDataJSON == other.ClientDataJSON ||
                    this.ClientDataJSON != null &&
                    this.ClientDataJSON.Equals(other.ClientDataJSON)
                ) &&
                (
                    this.AttestationObject == other.AttestationObject ||
                    this.AttestationObject != null &&
                    this.AttestationObject.Equals(other.AttestationObject)
                ) &&
                (
                    this.Transports == other.Transports ||
                    this.Transports != null &&
                    this.Transports.SequenceEqual(other.Transports)
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
                if (this.ClientDataJSON != null)
                    hash = hash * 59 + this.ClientDataJSON.GetHashCode();

                if (this.AttestationObject != null)
                    hash = hash * 59 + this.AttestationObject.GetHashCode();

                if (this.Transports != null)
                    hash = hash * 59 + this.Transports.GetHashCode();

                return hash;
            }
        }
    }

}
