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
            /// Enum Api for "api"
            /// </summary>
            [EnumMember(Value = "api")]
            Api,
            
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
            /// Enum Imap for "imap"
            /// </summary>
            [EnumMember(Value = "imap")]
            Imap,
            
            /// <summary>
            /// Enum Graphapi for "graphapi"
            /// </summary>
            [EnumMember(Value = "graphapi")]
            Graphapi,
            
            /// <summary>
            /// Enum Audiohook for "audiohook"
            /// </summary>
            [EnumMember(Value = "audiohook")]
            Audiohook,
            
            /// <summary>
            /// Enum Openmessaging for "open-messaging"
            /// </summary>
            [EnumMember(Value = "open-messaging")]
            Openmessaging,
            
            /// <summary>
            /// Enum Ttsconnector for "tts-connector"
            /// </summary>
            [EnumMember(Value = "tts-connector")]
            Ttsconnector,
            
            /// <summary>
            /// Enum Audioconnector for "audio-connector"
            /// </summary>
            [EnumMember(Value = "audio-connector")]
            Audioconnector,
            
            /// <summary>
            /// Enum Byotstt for "byot-stt"
            /// </summary>
            [EnumMember(Value = "byot-stt")]
            Byotstt,
            
            /// <summary>
            /// Enum Botconnector for "bot-connector"
            /// </summary>
            [EnumMember(Value = "bot-connector")]
            Botconnector,
            
            /// <summary>
            /// Enum Byosmpp for "byo-smpp"
            /// </summary>
            [EnumMember(Value = "byo-smpp")]
            Byosmpp,
            
            /// <summary>
            /// Enum Encryption for "encryption"
            /// </summary>
            [EnumMember(Value = "encryption")]
            Encryption
        }
        /// <summary>
        /// The direction of traffic for the IP range from the perspective of Genesys Cloud (e.g. inbound to Genesys; outbound from Genesys)
        /// </summary>
        /// <value>The direction of traffic for the IP range from the perspective of Genesys Cloud (e.g. inbound to Genesys; outbound from Genesys)</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Both for "both"
            /// </summary>
            [EnumMember(Value = "both")]
            Both
        }
        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public ServiceEnum? Service { get; set; }
        /// <summary>
        /// The direction of traffic for the IP range from the perspective of Genesys Cloud (e.g. inbound to Genesys; outbound from Genesys)
        /// </summary>
        /// <value>The direction of traffic for the IP range from the perspective of Genesys Cloud (e.g. inbound to Genesys; outbound from Genesys)</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IpAddressRange" /> class.
        /// </summary>
        /// <param name="Cidr">Cidr.</param>
        /// <param name="Service">Service.</param>
        /// <param name="Region">Region.</param>
        /// <param name="Direction">The direction of traffic for the IP range from the perspective of Genesys Cloud (e.g. inbound to Genesys; outbound from Genesys).</param>
        public IpAddressRange(string Cidr = null, ServiceEnum? Service = null, string Region = null, DirectionEnum? Direction = null)
        {
            this.Cidr = Cidr;
            this.Service = Service;
            this.Region = Region;
            this.Direction = Direction;
            
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
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
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

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                return hash;
            }
        }
    }

}
