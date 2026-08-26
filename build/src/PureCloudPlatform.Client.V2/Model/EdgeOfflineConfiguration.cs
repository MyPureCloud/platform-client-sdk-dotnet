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
    /// EdgeOfflineConfiguration
    /// </summary>
    [DataContract]
    public partial class EdgeOfflineConfiguration :  IEquatable<EdgeOfflineConfiguration>
    {
        /// <summary>
        /// The type of Certificate Authority this Edge will use. Defaults to NotRequested if the Edge is already provisioned. PureCloud signed CA is recommended. Public CA signed by a trusted third party. China CA must be used if the Site's Location is in China.
        /// </summary>
        /// <value>The type of Certificate Authority this Edge will use. Defaults to NotRequested if the Edge is already provisioned. PureCloud signed CA is recommended. Public CA signed by a trusted third party. China CA must be used if the Site's Location is in China.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CertTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Purecloud for "PureCloud"
            /// </summary>
            [EnumMember(Value = "PureCloud")]
            Purecloud,
            
            /// <summary>
            /// Enum Public for "Public"
            /// </summary>
            [EnumMember(Value = "Public")]
            Public,
            
            /// <summary>
            /// Enum China for "China"
            /// </summary>
            [EnumMember(Value = "China")]
            China,
            
            /// <summary>
            /// Enum Notrequested for "NotRequested"
            /// </summary>
            [EnumMember(Value = "NotRequested")]
            Notrequested
        }
        /// <summary>
        /// The type of Certificate Authority this Edge will use. Defaults to NotRequested if the Edge is already provisioned. PureCloud signed CA is recommended. Public CA signed by a trusted third party. China CA must be used if the Site's Location is in China.
        /// </summary>
        /// <value>The type of Certificate Authority this Edge will use. Defaults to NotRequested if the Edge is already provisioned. PureCloud signed CA is recommended. Public CA signed by a trusted third party. China CA must be used if the Site's Location is in China.</value>
        [DataMember(Name="certType", EmitDefaultValue=false)]
        public CertTypeEnum? CertType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeOfflineConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdgeOfflineConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeOfflineConfiguration" /> class.
        /// </summary>
        /// <param name="PairingId">The pairingId for your hardware Edge in the format: 00000-00000-00000-00000-00000. (required).</param>
        /// <param name="Network">Network settings for your hardware Edge. (required).</param>
        /// <param name="UseVerificationCode">Boolean to know if the verification code will be used to provision the Edge. Only used if the Edge is being provisioned..</param>
        /// <param name="CertType">The type of Certificate Authority this Edge will use. Defaults to NotRequested if the Edge is already provisioned. PureCloud signed CA is recommended. Public CA signed by a trusted third party. China CA must be used if the Site&#39;s Location is in China..</param>
        /// <param name="Site">The Site that will be associated to the Edge. Required if the Edge is being provisioned..</param>
        /// <param name="Proxy">Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed..</param>
        public EdgeOfflineConfiguration(string PairingId = null, EdgeOfflineConfigurationNetwork Network = null, bool? UseVerificationCode = null, CertTypeEnum? CertType = null, DomainEntityRef Site = null, string Proxy = null)
        {
            this.PairingId = PairingId;
            this.Network = Network;
            this.UseVerificationCode = UseVerificationCode;
            this.CertType = CertType;
            this.Site = Site;
            this.Proxy = Proxy;
            
        }
        


        /// <summary>
        /// The pairingId for your hardware Edge in the format: 00000-00000-00000-00000-00000.
        /// </summary>
        /// <value>The pairingId for your hardware Edge in the format: 00000-00000-00000-00000-00000.</value>
        [DataMember(Name="pairingId", EmitDefaultValue=false)]
        public string PairingId { get; set; }



        /// <summary>
        /// Network settings for your hardware Edge.
        /// </summary>
        /// <value>Network settings for your hardware Edge.</value>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public EdgeOfflineConfigurationNetwork Network { get; set; }



        /// <summary>
        /// Boolean to know if the verification code will be used to provision the Edge. Only used if the Edge is being provisioned.
        /// </summary>
        /// <value>Boolean to know if the verification code will be used to provision the Edge. Only used if the Edge is being provisioned.</value>
        [DataMember(Name="useVerificationCode", EmitDefaultValue=false)]
        public bool? UseVerificationCode { get; set; }





        /// <summary>
        /// The Site that will be associated to the Edge. Required if the Edge is being provisioned.
        /// </summary>
        /// <value>The Site that will be associated to the Edge. Required if the Edge is being provisioned.</value>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public DomainEntityRef Site { get; set; }



        /// <summary>
        /// Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed.
        /// </summary>
        /// <value>Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed.</value>
        [DataMember(Name="proxy", EmitDefaultValue=false)]
        public string Proxy { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeOfflineConfiguration {\n");

            sb.Append("  PairingId: ").Append(PairingId).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  UseVerificationCode: ").Append(UseVerificationCode).Append("\n");
            sb.Append("  CertType: ").Append(CertType).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  Proxy: ").Append(Proxy).Append("\n");
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
            return this.Equals(obj as EdgeOfflineConfiguration);
        }

        /// <summary>
        /// Returns true if EdgeOfflineConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeOfflineConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeOfflineConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PairingId == other.PairingId ||
                    this.PairingId != null &&
                    this.PairingId.Equals(other.PairingId)
                ) &&
                (
                    this.Network == other.Network ||
                    this.Network != null &&
                    this.Network.Equals(other.Network)
                ) &&
                (
                    this.UseVerificationCode == other.UseVerificationCode ||
                    this.UseVerificationCode != null &&
                    this.UseVerificationCode.Equals(other.UseVerificationCode)
                ) &&
                (
                    this.CertType == other.CertType ||
                    this.CertType != null &&
                    this.CertType.Equals(other.CertType)
                ) &&
                (
                    this.Site == other.Site ||
                    this.Site != null &&
                    this.Site.Equals(other.Site)
                ) &&
                (
                    this.Proxy == other.Proxy ||
                    this.Proxy != null &&
                    this.Proxy.Equals(other.Proxy)
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
                if (this.PairingId != null)
                    hash = hash * 59 + this.PairingId.GetHashCode();

                if (this.Network != null)
                    hash = hash * 59 + this.Network.GetHashCode();

                if (this.UseVerificationCode != null)
                    hash = hash * 59 + this.UseVerificationCode.GetHashCode();

                if (this.CertType != null)
                    hash = hash * 59 + this.CertType.GetHashCode();

                if (this.Site != null)
                    hash = hash * 59 + this.Site.GetHashCode();

                if (this.Proxy != null)
                    hash = hash * 59 + this.Proxy.GetHashCode();

                return hash;
            }
        }
    }

}
