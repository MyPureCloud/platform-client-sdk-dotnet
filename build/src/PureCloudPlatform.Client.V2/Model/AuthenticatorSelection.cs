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
    /// AuthenticatorSelection
    /// </summary>
    [DataContract]
    public partial class AuthenticatorSelection :  IEquatable<AuthenticatorSelection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatorSelection" /> class.
        /// </summary>
        /// <param name="AuthenticatorAttachment">Desired authenticator attachment modality (&#39;platform&#39; or &#39;cross-platform&#39;)..</param>
        /// <param name="RequireResidentKey">Whether a resident (discoverable) credential is required. Deprecated by the WebAuthn spec in favor of residentKey..</param>
        /// <param name="ResidentKey">The relying party&#39;s requirement for resident (discoverable) credentials (&#39;discouraged&#39;, &#39;preferred&#39;, or &#39;required&#39;)..</param>
        /// <param name="UserVerification">The user verification requirement (&#39;discouraged&#39;, &#39;preferred&#39;, or &#39;required&#39;)..</param>
        public AuthenticatorSelection(string AuthenticatorAttachment = null, bool? RequireResidentKey = null, string ResidentKey = null, string UserVerification = null)
        {
            this.AuthenticatorAttachment = AuthenticatorAttachment;
            this.RequireResidentKey = RequireResidentKey;
            this.ResidentKey = ResidentKey;
            this.UserVerification = UserVerification;
            
        }
        


        /// <summary>
        /// Desired authenticator attachment modality (&#39;platform&#39; or &#39;cross-platform&#39;).
        /// </summary>
        /// <value>Desired authenticator attachment modality (&#39;platform&#39; or &#39;cross-platform&#39;).</value>
        [DataMember(Name="authenticatorAttachment", EmitDefaultValue=false)]
        public string AuthenticatorAttachment { get; set; }



        /// <summary>
        /// Whether a resident (discoverable) credential is required. Deprecated by the WebAuthn spec in favor of residentKey.
        /// </summary>
        /// <value>Whether a resident (discoverable) credential is required. Deprecated by the WebAuthn spec in favor of residentKey.</value>
        [DataMember(Name="requireResidentKey", EmitDefaultValue=false)]
        public bool? RequireResidentKey { get; set; }



        /// <summary>
        /// The relying party&#39;s requirement for resident (discoverable) credentials (&#39;discouraged&#39;, &#39;preferred&#39;, or &#39;required&#39;).
        /// </summary>
        /// <value>The relying party&#39;s requirement for resident (discoverable) credentials (&#39;discouraged&#39;, &#39;preferred&#39;, or &#39;required&#39;).</value>
        [DataMember(Name="residentKey", EmitDefaultValue=false)]
        public string ResidentKey { get; set; }



        /// <summary>
        /// The user verification requirement (&#39;discouraged&#39;, &#39;preferred&#39;, or &#39;required&#39;).
        /// </summary>
        /// <value>The user verification requirement (&#39;discouraged&#39;, &#39;preferred&#39;, or &#39;required&#39;).</value>
        [DataMember(Name="userVerification", EmitDefaultValue=false)]
        public string UserVerification { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticatorSelection {\n");

            sb.Append("  AuthenticatorAttachment: ").Append(AuthenticatorAttachment).Append("\n");
            sb.Append("  RequireResidentKey: ").Append(RequireResidentKey).Append("\n");
            sb.Append("  ResidentKey: ").Append(ResidentKey).Append("\n");
            sb.Append("  UserVerification: ").Append(UserVerification).Append("\n");
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
            return this.Equals(obj as AuthenticatorSelection);
        }

        /// <summary>
        /// Returns true if AuthenticatorSelection instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthenticatorSelection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticatorSelection other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AuthenticatorAttachment == other.AuthenticatorAttachment ||
                    this.AuthenticatorAttachment != null &&
                    this.AuthenticatorAttachment.Equals(other.AuthenticatorAttachment)
                ) &&
                (
                    this.RequireResidentKey == other.RequireResidentKey ||
                    this.RequireResidentKey != null &&
                    this.RequireResidentKey.Equals(other.RequireResidentKey)
                ) &&
                (
                    this.ResidentKey == other.ResidentKey ||
                    this.ResidentKey != null &&
                    this.ResidentKey.Equals(other.ResidentKey)
                ) &&
                (
                    this.UserVerification == other.UserVerification ||
                    this.UserVerification != null &&
                    this.UserVerification.Equals(other.UserVerification)
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
                if (this.AuthenticatorAttachment != null)
                    hash = hash * 59 + this.AuthenticatorAttachment.GetHashCode();

                if (this.RequireResidentKey != null)
                    hash = hash * 59 + this.RequireResidentKey.GetHashCode();

                if (this.ResidentKey != null)
                    hash = hash * 59 + this.ResidentKey.GetHashCode();

                if (this.UserVerification != null)
                    hash = hash * 59 + this.UserVerification.GetHashCode();

                return hash;
            }
        }
    }

}
