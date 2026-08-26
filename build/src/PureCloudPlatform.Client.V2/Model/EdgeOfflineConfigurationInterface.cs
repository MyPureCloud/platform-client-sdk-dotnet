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
    /// EdgeOfflineConfigurationInterface
    /// </summary>
    [DataContract]
    public partial class EdgeOfflineConfigurationInterface :  IEquatable<EdgeOfflineConfigurationInterface>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeOfflineConfigurationInterface" /> class.
        /// </summary>
        /// <param name="Routes">The list of routes assigned to this interface..</param>
        /// <param name="Addresses">The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list..</param>
        /// <param name="Ipv4Capabilities">IPv4 interface settings..</param>
        /// <param name="Ipv6Capabilities">IPv6 interface settings..</param>
        public EdgeOfflineConfigurationInterface(List<DomainNetworkRoute> Routes = null, List<DomainNetworkAddress> Addresses = null, DomainCapabilities Ipv4Capabilities = null, DomainCapabilities Ipv6Capabilities = null)
        {
            this.Routes = Routes;
            this.Addresses = Addresses;
            this.Ipv4Capabilities = Ipv4Capabilities;
            this.Ipv6Capabilities = Ipv6Capabilities;
            
        }
        


        /// <summary>
        /// The list of routes assigned to this interface.
        /// </summary>
        /// <value>The list of routes assigned to this interface.</value>
        [DataMember(Name="routes", EmitDefaultValue=false)]
        public List<DomainNetworkRoute> Routes { get; set; }



        /// <summary>
        /// The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list.
        /// </summary>
        /// <value>The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list.</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<DomainNetworkAddress> Addresses { get; set; }



        /// <summary>
        /// IPv4 interface settings.
        /// </summary>
        /// <value>IPv4 interface settings.</value>
        [DataMember(Name="ipv4Capabilities", EmitDefaultValue=false)]
        public DomainCapabilities Ipv4Capabilities { get; set; }



        /// <summary>
        /// IPv6 interface settings.
        /// </summary>
        /// <value>IPv6 interface settings.</value>
        [DataMember(Name="ipv6Capabilities", EmitDefaultValue=false)]
        public DomainCapabilities Ipv6Capabilities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeOfflineConfigurationInterface {\n");

            sb.Append("  Routes: ").Append(Routes).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Ipv4Capabilities: ").Append(Ipv4Capabilities).Append("\n");
            sb.Append("  Ipv6Capabilities: ").Append(Ipv6Capabilities).Append("\n");
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
            return this.Equals(obj as EdgeOfflineConfigurationInterface);
        }

        /// <summary>
        /// Returns true if EdgeOfflineConfigurationInterface instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeOfflineConfigurationInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeOfflineConfigurationInterface other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Routes == other.Routes ||
                    this.Routes != null &&
                    this.Routes.SequenceEqual(other.Routes)
                ) &&
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) &&
                (
                    this.Ipv4Capabilities == other.Ipv4Capabilities ||
                    this.Ipv4Capabilities != null &&
                    this.Ipv4Capabilities.Equals(other.Ipv4Capabilities)
                ) &&
                (
                    this.Ipv6Capabilities == other.Ipv6Capabilities ||
                    this.Ipv6Capabilities != null &&
                    this.Ipv6Capabilities.Equals(other.Ipv6Capabilities)
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
                if (this.Routes != null)
                    hash = hash * 59 + this.Routes.GetHashCode();

                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();

                if (this.Ipv4Capabilities != null)
                    hash = hash * 59 + this.Ipv4Capabilities.GetHashCode();

                if (this.Ipv6Capabilities != null)
                    hash = hash * 59 + this.Ipv6Capabilities.GetHashCode();

                return hash;
            }
        }
    }

}
