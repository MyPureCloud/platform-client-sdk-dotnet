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
    /// ClientExtensionResults
    /// </summary>
    [DataContract]
    public partial class ClientExtensionResults :  IEquatable<ClientExtensionResults>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientExtensionResults" /> class.
        /// </summary>
        /// <param name="Appid">App ID extension output (legacy U2F migration)..</param>
        /// <param name="CredProps">Credential properties extension output..</param>
        /// <param name="HmacCreateSecret">HMAC secret extension output..</param>
        /// <param name="LargeBlob">Large blob extension outputs..</param>
        /// <param name="Prf">Pseudo-random function (PRF) extension outputs..</param>
        public ClientExtensionResults(bool? Appid = null, CredentialPropertiesOutput CredProps = null, bool? HmacCreateSecret = null, AuthenticationExtensionsLargeBlobOutputs LargeBlob = null, AuthenticationExtensionsPRFOutputs Prf = null)
        {
            this.Appid = Appid;
            this.CredProps = CredProps;
            this.HmacCreateSecret = HmacCreateSecret;
            this.LargeBlob = LargeBlob;
            this.Prf = Prf;
            
        }
        


        /// <summary>
        /// App ID extension output (legacy U2F migration).
        /// </summary>
        /// <value>App ID extension output (legacy U2F migration).</value>
        [DataMember(Name="appid", EmitDefaultValue=false)]
        public bool? Appid { get; set; }



        /// <summary>
        /// Credential properties extension output.
        /// </summary>
        /// <value>Credential properties extension output.</value>
        [DataMember(Name="credProps", EmitDefaultValue=false)]
        public CredentialPropertiesOutput CredProps { get; set; }



        /// <summary>
        /// HMAC secret extension output.
        /// </summary>
        /// <value>HMAC secret extension output.</value>
        [DataMember(Name="hmacCreateSecret", EmitDefaultValue=false)]
        public bool? HmacCreateSecret { get; set; }



        /// <summary>
        /// Large blob extension outputs.
        /// </summary>
        /// <value>Large blob extension outputs.</value>
        [DataMember(Name="largeBlob", EmitDefaultValue=false)]
        public AuthenticationExtensionsLargeBlobOutputs LargeBlob { get; set; }



        /// <summary>
        /// Pseudo-random function (PRF) extension outputs.
        /// </summary>
        /// <value>Pseudo-random function (PRF) extension outputs.</value>
        [DataMember(Name="prf", EmitDefaultValue=false)]
        public AuthenticationExtensionsPRFOutputs Prf { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientExtensionResults {\n");

            sb.Append("  Appid: ").Append(Appid).Append("\n");
            sb.Append("  CredProps: ").Append(CredProps).Append("\n");
            sb.Append("  HmacCreateSecret: ").Append(HmacCreateSecret).Append("\n");
            sb.Append("  LargeBlob: ").Append(LargeBlob).Append("\n");
            sb.Append("  Prf: ").Append(Prf).Append("\n");
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
            return this.Equals(obj as ClientExtensionResults);
        }

        /// <summary>
        /// Returns true if ClientExtensionResults instances are equal
        /// </summary>
        /// <param name="other">Instance of ClientExtensionResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientExtensionResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Appid == other.Appid ||
                    this.Appid != null &&
                    this.Appid.Equals(other.Appid)
                ) &&
                (
                    this.CredProps == other.CredProps ||
                    this.CredProps != null &&
                    this.CredProps.Equals(other.CredProps)
                ) &&
                (
                    this.HmacCreateSecret == other.HmacCreateSecret ||
                    this.HmacCreateSecret != null &&
                    this.HmacCreateSecret.Equals(other.HmacCreateSecret)
                ) &&
                (
                    this.LargeBlob == other.LargeBlob ||
                    this.LargeBlob != null &&
                    this.LargeBlob.Equals(other.LargeBlob)
                ) &&
                (
                    this.Prf == other.Prf ||
                    this.Prf != null &&
                    this.Prf.Equals(other.Prf)
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
                if (this.Appid != null)
                    hash = hash * 59 + this.Appid.GetHashCode();

                if (this.CredProps != null)
                    hash = hash * 59 + this.CredProps.GetHashCode();

                if (this.HmacCreateSecret != null)
                    hash = hash * 59 + this.HmacCreateSecret.GetHashCode();

                if (this.LargeBlob != null)
                    hash = hash * 59 + this.LargeBlob.GetHashCode();

                if (this.Prf != null)
                    hash = hash * 59 + this.Prf.GetHashCode();

                return hash;
            }
        }
    }

}
