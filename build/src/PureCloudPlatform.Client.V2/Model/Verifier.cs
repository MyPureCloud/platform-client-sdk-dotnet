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
    /// Verifier
    /// </summary>
    [DataContract]
    public partial class Verifier :  IEquatable<Verifier>
    {
        /// <summary>
        /// The type of verifier.
        /// </summary>
        /// <value>The type of verifier.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Totp for "TOTP"
            /// </summary>
            [EnumMember(Value = "TOTP")]
            Totp,
            
            /// <summary>
            /// Enum Webauthn for "WEBAUTHN"
            /// </summary>
            [EnumMember(Value = "WEBAUTHN")]
            Webauthn
        }
        /// <summary>
        /// The type of verifier.
        /// </summary>
        /// <value>The type of verifier.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Verifier" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">The type of verifier..</param>
        /// <param name="Enabled">Indicates whether this verifier is enabled..</param>
        /// <param name="Credential">The WebAuthn credential associated with this verifier..</param>
        /// <param name="Default">Indicates whether this is the default verifier..</param>
        public Verifier(string Name = null, TypeEnum? Type = null, bool? Enabled = null, Credential Credential = null, bool? Default = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.Enabled = Enabled;
            this.Credential = Credential;
            this.Default = Default;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// Indicates whether this verifier is enabled.
        /// </summary>
        /// <value>Indicates whether this verifier is enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The WebAuthn credential associated with this verifier.
        /// </summary>
        /// <value>The WebAuthn credential associated with this verifier.</value>
        [DataMember(Name="credential", EmitDefaultValue=false)]
        public Credential Credential { get; set; }



        /// <summary>
        /// Indicates whether this is the default verifier.
        /// </summary>
        /// <value>Indicates whether this is the default verifier.</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }



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
            sb.Append("class Verifier {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Credential: ").Append(Credential).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return this.Equals(obj as Verifier);
        }

        /// <summary>
        /// Returns true if Verifier instances are equal
        /// </summary>
        /// <param name="other">Instance of Verifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Verifier other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Credential == other.Credential ||
                    this.Credential != null &&
                    this.Credential.Equals(other.Credential)
                ) &&
                (
                    this.Default == other.Default ||
                    this.Default != null &&
                    this.Default.Equals(other.Default)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Credential != null)
                    hash = hash * 59 + this.Credential.GetHashCode();

                if (this.Default != null)
                    hash = hash * 59 + this.Default.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
