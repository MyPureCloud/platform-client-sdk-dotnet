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
    /// CreateVerifierRequest
    /// </summary>
    [DataContract]
    public partial class CreateVerifierRequest :  IEquatable<CreateVerifierRequest>
    {
        /// <summary>
        /// The hashing algorithm for the TOTP verifier.
        /// </summary>
        /// <value>The hashing algorithm for the TOTP verifier.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AlgorithmEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sha1 for "SHA1"
            /// </summary>
            [EnumMember(Value = "SHA1")]
            Sha1,
            
            /// <summary>
            /// Enum Sha256 for "SHA256"
            /// </summary>
            [EnumMember(Value = "SHA256")]
            Sha256,
            
            /// <summary>
            /// Enum Sha512 for "SHA512"
            /// </summary>
            [EnumMember(Value = "SHA512")]
            Sha512
        }
        /// <summary>
        /// The hashing algorithm for the TOTP verifier.
        /// </summary>
        /// <value>The hashing algorithm for the TOTP verifier.</value>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public AlgorithmEnum? Algorithm { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVerifierRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateVerifierRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVerifierRequest" /> class.
        /// </summary>
        /// <param name="Algorithm">The hashing algorithm for the TOTP verifier. (required).</param>
        /// <param name="Digits">The number of digits in the TOTP code. Must be between 6 and 12. (required).</param>
        /// <param name="Enabled">Indicates whether this verifier will be enabled. (required).</param>
        /// <param name="Name">The name of the verifier. Maximum length is 100 characters. (required).</param>
        /// <param name="Period">The time period in seconds for the TOTP code. (required).</param>
        /// <param name="SecretSize">The size of the shared secret in bytes. Must be between 10 and 64. (required).</param>
        /// <param name="Default">Indicates whether this will be the default verifier. (required).</param>
        public CreateVerifierRequest(AlgorithmEnum? Algorithm = null, int? Digits = null, bool? Enabled = null, string Name = null, int? Period = null, int? SecretSize = null, bool? Default = null)
        {
            this.Algorithm = Algorithm;
            this.Digits = Digits;
            this.Enabled = Enabled;
            this.Name = Name;
            this.Period = Period;
            this.SecretSize = SecretSize;
            this.Default = Default;
            
        }
        




        /// <summary>
        /// The number of digits in the TOTP code. Must be between 6 and 12.
        /// </summary>
        /// <value>The number of digits in the TOTP code. Must be between 6 and 12.</value>
        [DataMember(Name="digits", EmitDefaultValue=false)]
        public int? Digits { get; set; }



        /// <summary>
        /// Indicates whether this verifier will be enabled.
        /// </summary>
        /// <value>Indicates whether this verifier will be enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The name of the verifier. Maximum length is 100 characters.
        /// </summary>
        /// <value>The name of the verifier. Maximum length is 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The time period in seconds for the TOTP code.
        /// </summary>
        /// <value>The time period in seconds for the TOTP code.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }



        /// <summary>
        /// The size of the shared secret in bytes. Must be between 10 and 64.
        /// </summary>
        /// <value>The size of the shared secret in bytes. Must be between 10 and 64.</value>
        [DataMember(Name="secretSize", EmitDefaultValue=false)]
        public int? SecretSize { get; set; }



        /// <summary>
        /// Indicates whether this will be the default verifier.
        /// </summary>
        /// <value>Indicates whether this will be the default verifier.</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVerifierRequest {\n");

            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  SecretSize: ").Append(SecretSize).Append("\n");
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
            return this.Equals(obj as CreateVerifierRequest);
        }

        /// <summary>
        /// Returns true if CreateVerifierRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateVerifierRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateVerifierRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Algorithm == other.Algorithm ||
                    this.Algorithm != null &&
                    this.Algorithm.Equals(other.Algorithm)
                ) &&
                (
                    this.Digits == other.Digits ||
                    this.Digits != null &&
                    this.Digits.Equals(other.Digits)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) &&
                (
                    this.SecretSize == other.SecretSize ||
                    this.SecretSize != null &&
                    this.SecretSize.Equals(other.SecretSize)
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
                if (this.Algorithm != null)
                    hash = hash * 59 + this.Algorithm.GetHashCode();

                if (this.Digits != null)
                    hash = hash * 59 + this.Digits.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();

                if (this.SecretSize != null)
                    hash = hash * 59 + this.SecretSize.GetHashCode();

                if (this.Default != null)
                    hash = hash * 59 + this.Default.GetHashCode();

                return hash;
            }
        }
    }

}
