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
    /// BeginWebAuthnRegistrationResponse
    /// </summary>
    [DataContract]
    public partial class BeginWebAuthnRegistrationResponse :  IEquatable<BeginWebAuthnRegistrationResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BeginWebAuthnRegistrationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeginWebAuthnRegistrationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeginWebAuthnRegistrationResponse" /> class.
        /// </summary>
        /// <param name="PublicKey">The public key credential creation options the client should pass to the WebAuthn API&#39;s navigator.credentials.create() call. (required).</param>
        public BeginWebAuthnRegistrationResponse(PublicKeyCredentialCreationOptions PublicKey = null)
        {
            this.PublicKey = PublicKey;
            
        }
        


        /// <summary>
        /// The public key credential creation options the client should pass to the WebAuthn API&#39;s navigator.credentials.create() call.
        /// </summary>
        /// <value>The public key credential creation options the client should pass to the WebAuthn API&#39;s navigator.credentials.create() call.</value>
        [DataMember(Name="publicKey", EmitDefaultValue=false)]
        public PublicKeyCredentialCreationOptions PublicKey { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeginWebAuthnRegistrationResponse {\n");

            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(obj as BeginWebAuthnRegistrationResponse);
        }

        /// <summary>
        /// Returns true if BeginWebAuthnRegistrationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BeginWebAuthnRegistrationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeginWebAuthnRegistrationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PublicKey == other.PublicKey ||
                    this.PublicKey != null &&
                    this.PublicKey.Equals(other.PublicKey)
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
                if (this.PublicKey != null)
                    hash = hash * 59 + this.PublicKey.GetHashCode();

                return hash;
            }
        }
    }

}
