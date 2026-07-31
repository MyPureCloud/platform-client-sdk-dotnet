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
    /// FinishWebAuthnRegistrationRequest
    /// </summary>
    [DataContract]
    public partial class FinishWebAuthnRegistrationRequest :  IEquatable<FinishWebAuthnRegistrationRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FinishWebAuthnRegistrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FinishWebAuthnRegistrationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FinishWebAuthnRegistrationRequest" /> class.
        /// </summary>
        /// <param name="Credential">The credential creation response returned by the authenticator (i.e., the result of navigator.credentials.create()). (required).</param>
        /// <param name="Name">The user-facing name for this verifier. (required).</param>
        /// <param name="Default">Indicates whether this should be set as the user&#39;s default verifier..</param>
        public FinishWebAuthnRegistrationRequest(PublicKeyCredentialCreationResponse Credential = null, string Name = null, bool? Default = null)
        {
            this.Credential = Credential;
            this.Name = Name;
            this.Default = Default;
            
        }
        


        /// <summary>
        /// The credential creation response returned by the authenticator (i.e., the result of navigator.credentials.create()).
        /// </summary>
        /// <value>The credential creation response returned by the authenticator (i.e., the result of navigator.credentials.create()).</value>
        [DataMember(Name="credential", EmitDefaultValue=false)]
        public PublicKeyCredentialCreationResponse Credential { get; set; }



        /// <summary>
        /// The user-facing name for this verifier.
        /// </summary>
        /// <value>The user-facing name for this verifier.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Indicates whether this should be set as the user&#39;s default verifier.
        /// </summary>
        /// <value>Indicates whether this should be set as the user&#39;s default verifier.</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinishWebAuthnRegistrationRequest {\n");

            sb.Append("  Credential: ").Append(Credential).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return this.Equals(obj as FinishWebAuthnRegistrationRequest);
        }

        /// <summary>
        /// Returns true if FinishWebAuthnRegistrationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FinishWebAuthnRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinishWebAuthnRegistrationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Credential == other.Credential ||
                    this.Credential != null &&
                    this.Credential.Equals(other.Credential)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Default == other.Default ||
                    this.Default != null &&
                    this.Default.Equals(other.Default)
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
                if (this.Credential != null)
                    hash = hash * 59 + this.Credential.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Default != null)
                    hash = hash * 59 + this.Default.GetHashCode();

                return hash;
            }
        }
    }

}
