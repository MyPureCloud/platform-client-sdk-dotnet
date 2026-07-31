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
    /// PublicKeyCredentialCreationResponse
    /// </summary>
    [DataContract]
    public partial class PublicKeyCredentialCreationResponse :  IEquatable<PublicKeyCredentialCreationResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyCredentialCreationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicKeyCredentialCreationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyCredentialCreationResponse" /> class.
        /// </summary>
        /// <param name="Id">The credential identifier (base64url-encoded). (required).</param>
        /// <param name="Type">The credential type (must be &#39;public-key&#39;). (required).</param>
        /// <param name="RawId">The raw credential identifier as a binary value (base64url-encoded). (required).</param>
        /// <param name="AuthenticatorAttachment">The authenticator attachment modality used (&#39;platform&#39; or &#39;cross-platform&#39;)..</param>
        /// <param name="ClientExtensionResults">Outputs from client-side WebAuthn extensions..</param>
        /// <param name="Response">The authenticator&#39;s attestation response. (required).</param>
        public PublicKeyCredentialCreationResponse(string Id = null, string Type = null, string RawId = null, string AuthenticatorAttachment = null, Dictionary<string, Object> ClientExtensionResults = null, AuthenticatorAttestationResponse Response = null)
        {
            this.Id = Id;
            this.Type = Type;
            this.RawId = RawId;
            this.AuthenticatorAttachment = AuthenticatorAttachment;
            this.ClientExtensionResults = ClientExtensionResults;
            this.Response = Response;
            
        }
        


        /// <summary>
        /// The credential identifier (base64url-encoded).
        /// </summary>
        /// <value>The credential identifier (base64url-encoded).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The credential type (must be &#39;public-key&#39;).
        /// </summary>
        /// <value>The credential type (must be &#39;public-key&#39;).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// The raw credential identifier as a binary value (base64url-encoded).
        /// </summary>
        /// <value>The raw credential identifier as a binary value (base64url-encoded).</value>
        [DataMember(Name="rawId", EmitDefaultValue=false)]
        public string RawId { get; set; }



        /// <summary>
        /// The authenticator attachment modality used (&#39;platform&#39; or &#39;cross-platform&#39;).
        /// </summary>
        /// <value>The authenticator attachment modality used (&#39;platform&#39; or &#39;cross-platform&#39;).</value>
        [DataMember(Name="authenticatorAttachment", EmitDefaultValue=false)]
        public string AuthenticatorAttachment { get; set; }



        /// <summary>
        /// Outputs from client-side WebAuthn extensions.
        /// </summary>
        /// <value>Outputs from client-side WebAuthn extensions.</value>
        [DataMember(Name="clientExtensionResults", EmitDefaultValue=false)]
        public Dictionary<string, Object> ClientExtensionResults { get; set; }



        /// <summary>
        /// The authenticator&#39;s attestation response.
        /// </summary>
        /// <value>The authenticator&#39;s attestation response.</value>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public AuthenticatorAttestationResponse Response { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicKeyCredentialCreationResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RawId: ").Append(RawId).Append("\n");
            sb.Append("  AuthenticatorAttachment: ").Append(AuthenticatorAttachment).Append("\n");
            sb.Append("  ClientExtensionResults: ").Append(ClientExtensionResults).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
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
            return this.Equals(obj as PublicKeyCredentialCreationResponse);
        }

        /// <summary>
        /// Returns true if PublicKeyCredentialCreationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PublicKeyCredentialCreationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicKeyCredentialCreationResponse other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.RawId == other.RawId ||
                    this.RawId != null &&
                    this.RawId.Equals(other.RawId)
                ) &&
                (
                    this.AuthenticatorAttachment == other.AuthenticatorAttachment ||
                    this.AuthenticatorAttachment != null &&
                    this.AuthenticatorAttachment.Equals(other.AuthenticatorAttachment)
                ) &&
                (
                    this.ClientExtensionResults == other.ClientExtensionResults ||
                    this.ClientExtensionResults != null &&
                    this.ClientExtensionResults.SequenceEqual(other.ClientExtensionResults)
                ) &&
                (
                    this.Response == other.Response ||
                    this.Response != null &&
                    this.Response.Equals(other.Response)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.RawId != null)
                    hash = hash * 59 + this.RawId.GetHashCode();

                if (this.AuthenticatorAttachment != null)
                    hash = hash * 59 + this.AuthenticatorAttachment.GetHashCode();

                if (this.ClientExtensionResults != null)
                    hash = hash * 59 + this.ClientExtensionResults.GetHashCode();

                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();

                return hash;
            }
        }
    }

}
