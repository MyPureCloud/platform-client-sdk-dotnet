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
    /// PublicKeyCredentialCreationOptions
    /// </summary>
    [DataContract]
    public partial class PublicKeyCredentialCreationOptions :  IEquatable<PublicKeyCredentialCreationOptions>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyCredentialCreationOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicKeyCredentialCreationOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyCredentialCreationOptions" /> class.
        /// </summary>
        /// <param name="Challenge">Cryptographic challenge from the relying party (base64url-encoded). Must be returned to the relying party in the authenticator&#39;s response. (required).</param>
        /// <param name="Rp">Information about the relying party. (required).</param>
        /// <param name="User">Information about the user being registered. (required).</param>
        /// <param name="PubKeyCredParams">Public key credential parameters acceptable to the relying party, in order of preference. (required).</param>
        /// <param name="Timeout">Time in milliseconds the relying party is willing to wait for the registration operation to complete..</param>
        /// <param name="ExcludeCredentials">Credentials that should be excluded from registration (e.g., to prevent re-registering an existing authenticator)..</param>
        /// <param name="AuthenticatorSelection">Constraints on the type of authenticator that can be used..</param>
        /// <param name="Hints">Hints about the type of authenticator the user should use (e.g., &#39;security-key&#39;, &#39;client-device&#39;, &#39;hybrid&#39;)..</param>
        /// <param name="Attestation">The relying party&#39;s attestation conveyance preference (&#39;none&#39;, &#39;indirect&#39;, &#39;direct&#39;, or &#39;enterprise&#39;)..</param>
        /// <param name="AttestationFormats">Acceptable attestation statement formats, in order of preference..</param>
        /// <param name="Extensions">Inputs to client-side WebAuthn extensions..</param>
        public PublicKeyCredentialCreationOptions(string Challenge = null, RelyingPartyEntity Rp = null, UserEntity User = null, List<CredentialParameter> PubKeyCredParams = null, int? Timeout = null, List<CredentialDescriptor> ExcludeCredentials = null, AuthenticatorSelection AuthenticatorSelection = null, List<string> Hints = null, string Attestation = null, List<string> AttestationFormats = null, Dictionary<string, Object> Extensions = null)
        {
            this.Challenge = Challenge;
            this.Rp = Rp;
            this.User = User;
            this.PubKeyCredParams = PubKeyCredParams;
            this.Timeout = Timeout;
            this.ExcludeCredentials = ExcludeCredentials;
            this.AuthenticatorSelection = AuthenticatorSelection;
            this.Hints = Hints;
            this.Attestation = Attestation;
            this.AttestationFormats = AttestationFormats;
            this.Extensions = Extensions;
            
        }
        


        /// <summary>
        /// Cryptographic challenge from the relying party (base64url-encoded). Must be returned to the relying party in the authenticator&#39;s response.
        /// </summary>
        /// <value>Cryptographic challenge from the relying party (base64url-encoded). Must be returned to the relying party in the authenticator&#39;s response.</value>
        [DataMember(Name="challenge", EmitDefaultValue=false)]
        public string Challenge { get; set; }



        /// <summary>
        /// Information about the relying party.
        /// </summary>
        /// <value>Information about the relying party.</value>
        [DataMember(Name="rp", EmitDefaultValue=false)]
        public RelyingPartyEntity Rp { get; set; }



        /// <summary>
        /// Information about the user being registered.
        /// </summary>
        /// <value>Information about the user being registered.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserEntity User { get; set; }



        /// <summary>
        /// Public key credential parameters acceptable to the relying party, in order of preference.
        /// </summary>
        /// <value>Public key credential parameters acceptable to the relying party, in order of preference.</value>
        [DataMember(Name="pubKeyCredParams", EmitDefaultValue=false)]
        public List<CredentialParameter> PubKeyCredParams { get; set; }



        /// <summary>
        /// Time in milliseconds the relying party is willing to wait for the registration operation to complete.
        /// </summary>
        /// <value>Time in milliseconds the relying party is willing to wait for the registration operation to complete.</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }



        /// <summary>
        /// Credentials that should be excluded from registration (e.g., to prevent re-registering an existing authenticator).
        /// </summary>
        /// <value>Credentials that should be excluded from registration (e.g., to prevent re-registering an existing authenticator).</value>
        [DataMember(Name="excludeCredentials", EmitDefaultValue=false)]
        public List<CredentialDescriptor> ExcludeCredentials { get; set; }



        /// <summary>
        /// Constraints on the type of authenticator that can be used.
        /// </summary>
        /// <value>Constraints on the type of authenticator that can be used.</value>
        [DataMember(Name="authenticatorSelection", EmitDefaultValue=false)]
        public AuthenticatorSelection AuthenticatorSelection { get; set; }



        /// <summary>
        /// Hints about the type of authenticator the user should use (e.g., &#39;security-key&#39;, &#39;client-device&#39;, &#39;hybrid&#39;).
        /// </summary>
        /// <value>Hints about the type of authenticator the user should use (e.g., &#39;security-key&#39;, &#39;client-device&#39;, &#39;hybrid&#39;).</value>
        [DataMember(Name="hints", EmitDefaultValue=false)]
        public List<string> Hints { get; set; }



        /// <summary>
        /// The relying party&#39;s attestation conveyance preference (&#39;none&#39;, &#39;indirect&#39;, &#39;direct&#39;, or &#39;enterprise&#39;).
        /// </summary>
        /// <value>The relying party&#39;s attestation conveyance preference (&#39;none&#39;, &#39;indirect&#39;, &#39;direct&#39;, or &#39;enterprise&#39;).</value>
        [DataMember(Name="attestation", EmitDefaultValue=false)]
        public string Attestation { get; set; }



        /// <summary>
        /// Acceptable attestation statement formats, in order of preference.
        /// </summary>
        /// <value>Acceptable attestation statement formats, in order of preference.</value>
        [DataMember(Name="attestationFormats", EmitDefaultValue=false)]
        public List<string> AttestationFormats { get; set; }



        /// <summary>
        /// Inputs to client-side WebAuthn extensions.
        /// </summary>
        /// <value>Inputs to client-side WebAuthn extensions.</value>
        [DataMember(Name="extensions", EmitDefaultValue=false)]
        public Dictionary<string, Object> Extensions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicKeyCredentialCreationOptions {\n");

            sb.Append("  Challenge: ").Append(Challenge).Append("\n");
            sb.Append("  Rp: ").Append(Rp).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  PubKeyCredParams: ").Append(PubKeyCredParams).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  ExcludeCredentials: ").Append(ExcludeCredentials).Append("\n");
            sb.Append("  AuthenticatorSelection: ").Append(AuthenticatorSelection).Append("\n");
            sb.Append("  Hints: ").Append(Hints).Append("\n");
            sb.Append("  Attestation: ").Append(Attestation).Append("\n");
            sb.Append("  AttestationFormats: ").Append(AttestationFormats).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
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
            return this.Equals(obj as PublicKeyCredentialCreationOptions);
        }

        /// <summary>
        /// Returns true if PublicKeyCredentialCreationOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of PublicKeyCredentialCreationOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicKeyCredentialCreationOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Challenge == other.Challenge ||
                    this.Challenge != null &&
                    this.Challenge.Equals(other.Challenge)
                ) &&
                (
                    this.Rp == other.Rp ||
                    this.Rp != null &&
                    this.Rp.Equals(other.Rp)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.PubKeyCredParams == other.PubKeyCredParams ||
                    this.PubKeyCredParams != null &&
                    this.PubKeyCredParams.SequenceEqual(other.PubKeyCredParams)
                ) &&
                (
                    this.Timeout == other.Timeout ||
                    this.Timeout != null &&
                    this.Timeout.Equals(other.Timeout)
                ) &&
                (
                    this.ExcludeCredentials == other.ExcludeCredentials ||
                    this.ExcludeCredentials != null &&
                    this.ExcludeCredentials.SequenceEqual(other.ExcludeCredentials)
                ) &&
                (
                    this.AuthenticatorSelection == other.AuthenticatorSelection ||
                    this.AuthenticatorSelection != null &&
                    this.AuthenticatorSelection.Equals(other.AuthenticatorSelection)
                ) &&
                (
                    this.Hints == other.Hints ||
                    this.Hints != null &&
                    this.Hints.SequenceEqual(other.Hints)
                ) &&
                (
                    this.Attestation == other.Attestation ||
                    this.Attestation != null &&
                    this.Attestation.Equals(other.Attestation)
                ) &&
                (
                    this.AttestationFormats == other.AttestationFormats ||
                    this.AttestationFormats != null &&
                    this.AttestationFormats.SequenceEqual(other.AttestationFormats)
                ) &&
                (
                    this.Extensions == other.Extensions ||
                    this.Extensions != null &&
                    this.Extensions.SequenceEqual(other.Extensions)
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
                if (this.Challenge != null)
                    hash = hash * 59 + this.Challenge.GetHashCode();

                if (this.Rp != null)
                    hash = hash * 59 + this.Rp.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.PubKeyCredParams != null)
                    hash = hash * 59 + this.PubKeyCredParams.GetHashCode();

                if (this.Timeout != null)
                    hash = hash * 59 + this.Timeout.GetHashCode();

                if (this.ExcludeCredentials != null)
                    hash = hash * 59 + this.ExcludeCredentials.GetHashCode();

                if (this.AuthenticatorSelection != null)
                    hash = hash * 59 + this.AuthenticatorSelection.GetHashCode();

                if (this.Hints != null)
                    hash = hash * 59 + this.Hints.GetHashCode();

                if (this.Attestation != null)
                    hash = hash * 59 + this.Attestation.GetHashCode();

                if (this.AttestationFormats != null)
                    hash = hash * 59 + this.AttestationFormats.GetHashCode();

                if (this.Extensions != null)
                    hash = hash * 59 + this.Extensions.GetHashCode();

                return hash;
            }
        }
    }

}
