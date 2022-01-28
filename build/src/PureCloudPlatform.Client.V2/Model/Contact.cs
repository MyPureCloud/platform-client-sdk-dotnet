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
    /// Contact
    /// </summary>
    [DataContract]
    public partial class Contact :  IEquatable<Contact>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Phone for "PHONE"
            /// </summary>
            [EnumMember(Value = "PHONE")]
            Phone,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email,
            
            /// <summary>
            /// Enum Sms for "SMS"
            /// </summary>
            [EnumMember(Value = "SMS")]
            Sms
        }
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum Primary for "PRIMARY"
            /// </summary>
            [EnumMember(Value = "PRIMARY")]
            Primary,
            
            /// <summary>
            /// Enum Work for "WORK"
            /// </summary>
            [EnumMember(Value = "WORK")]
            Work,
            
            /// <summary>
            /// Enum Work2 for "WORK2"
            /// </summary>
            [EnumMember(Value = "WORK2")]
            Work2,
            
            /// <summary>
            /// Enum Work3 for "WORK3"
            /// </summary>
            [EnumMember(Value = "WORK3")]
            Work3,
            
            /// <summary>
            /// Enum Work4 for "WORK4"
            /// </summary>
            [EnumMember(Value = "WORK4")]
            Work4,
            
            /// <summary>
            /// Enum Home for "HOME"
            /// </summary>
            [EnumMember(Value = "HOME")]
            Home,
            
            /// <summary>
            /// Enum Mobile for "MOBILE"
            /// </summary>
            [EnumMember(Value = "MOBILE")]
            Mobile,
            
            /// <summary>
            /// Enum Main for "MAIN"
            /// </summary>
            [EnumMember(Value = "MAIN")]
            Main,
            
            /// <summary>
            /// Enum Other for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            Other
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="Address">Email address or phone number for this contact type.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Extension">Use internal extension instead of address. Mutually exclusive with the address field..</param>
        /// <param name="CountryCode">CountryCode.</param>
        /// <param name="Integration">Integration tag value if this number is associated with an external integration..</param>
        public Contact(string Address = null, MediaTypeEnum? MediaType = null, TypeEnum? Type = null, string Extension = null, string CountryCode = null, string Integration = null)
        {
            this.Address = Address;
            this.MediaType = MediaType;
            this.Type = Type;
            this.Extension = Extension;
            this.CountryCode = CountryCode;
            this.Integration = Integration;
            
        }
        
        
        
        /// <summary>
        /// Email address or phone number for this contact type
        /// </summary>
        /// <value>Email address or phone number for this contact type</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        
        
        
        /// <summary>
        /// Formatted version of the address property
        /// </summary>
        /// <value>Formatted version of the address property</value>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public string Display { get; private set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Use internal extension instead of address. Mutually exclusive with the address field.
        /// </summary>
        /// <value>Use internal extension instead of address. Mutually exclusive with the address field.</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        
        
        
        /// <summary>
        /// Integration tag value if this number is associated with an external integration.
        /// </summary>
        /// <value>Integration tag value if this number is associated with an external integration.</value>
        [DataMember(Name="integration", EmitDefaultValue=false)]
        public string Integration { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
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
            return this.Equals(obj as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="other">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.Display == other.Display ||
                    this.Display != null &&
                    this.Display.Equals(other.Display)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) &&
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    this.Integration == other.Integration ||
                    this.Integration != null &&
                    this.Integration.Equals(other.Integration)
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
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.Display != null)
                    hash = hash * 59 + this.Display.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                
                if (this.Integration != null)
                    hash = hash * 59 + this.Integration.GetHashCode();
                
                return hash;
            }
        }
    }

}
