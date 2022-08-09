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
    /// IpAddressRange
    /// </summary>
    [DataContract]
    public partial class IpAddressRange :  IEquatable<IpAddressRange>
    {
        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ServiceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Dataactions for "data-actions"
            /// </summary>
            [EnumMember(Value = "data-actions")]
            Dataactions,
            
            /// <summary>
            /// Enum Smtp for "smtp"
            /// </summary>
            [EnumMember(Value = "smtp")]
            Smtp,
            
            /// <summary>
            /// Enum Audiohook for "audiohook"
            /// </summary>
            [EnumMember(Value = "audiohook")]
            Audiohook
        }
        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public ServiceEnum? Service { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IpAddressRange" /> class.
        /// </summary>
        /// <param name="Cidr">Cidr.</param>
        /// <param name="Service">Service.</param>
        /// <param name="Region">Region.</param>
        public IpAddressRange(string Cidr = null, ServiceEnum? Service = null, string Region = null)
        {
            this.Cidr = Cidr;
            this.Service = Service;
            this.Region = Region;
            
        }
        


        /// <summary>
        /// Gets or Sets Cidr
        /// </summary>
        [DataMember(Name="cidr", EmitDefaultValue=false)]
        public string Cidr { get; set; }





        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpAddressRange {\n");

            sb.Append("  Cidr: ").Append(Cidr).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
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
            return this.Equals(obj as IpAddressRange);
        }

        /// <summary>
        /// Returns true if IpAddressRange instances are equal
        /// </summary>
        /// <param name="other">Instance of IpAddressRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpAddressRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Cidr == other.Cidr ||
                    this.Cidr != null &&
                    this.Cidr.Equals(other.Cidr)
                ) &&
                (
                    this.Service == other.Service ||
                    this.Service != null &&
                    this.Service.Equals(other.Service)
                ) &&
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
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
                if (this.Cidr != null)
                    hash = hash * 59 + this.Cidr.GetHashCode();

                if (this.Service != null)
                    hash = hash * 59 + this.Service.GetHashCode();

                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();

                return hash;
            }
        }
    }

}
