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
    /// Configuration for filtering tracking based on IP addresses.
    /// </summary>
    [DataContract]
    public partial class IpFilter :  IEquatable<IpFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpFilter" /> class.
        /// </summary>
        /// <param name="IpAddress">IP address or CIDR range to filter (e.g. &#39;192.168.1.0/24&#39;)..</param>
        /// <param name="Name">Descriptive name for the IP address filter..</param>
        public IpFilter(string IpAddress = null, string Name = null)
        {
            this.IpAddress = IpAddress;
            this.Name = Name;
            
        }
        


        /// <summary>
        /// IP address or CIDR range to filter (e.g. &#39;192.168.1.0/24&#39;).
        /// </summary>
        /// <value>IP address or CIDR range to filter (e.g. &#39;192.168.1.0/24&#39;).</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }



        /// <summary>
        /// Descriptive name for the IP address filter.
        /// </summary>
        /// <value>Descriptive name for the IP address filter.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpFilter {\n");

            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as IpFilter);
        }

        /// <summary>
        /// Returns true if IpFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of IpFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                return hash;
            }
        }
    }

}
