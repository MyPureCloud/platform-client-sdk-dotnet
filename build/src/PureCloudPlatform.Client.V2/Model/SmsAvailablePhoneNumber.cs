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
    /// SmsAvailablePhoneNumber
    /// </summary>
    [DataContract]
    public partial class SmsAvailablePhoneNumber :  IEquatable<SmsAvailablePhoneNumber>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CapabilitiesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms,
            
            /// <summary>
            /// Enum Mms for "mms"
            /// </summary>
            [EnumMember(Value = "mms")]
            Mms,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice
        }
        
        
        
        
        /// <summary>
        /// The type of phone number available for provisioning.
        /// </summary>
        /// <value>The type of phone number available for provisioning.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PhoneNumberTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Local for "local"
            /// </summary>
            [EnumMember(Value = "local")]
            Local,
            
            /// <summary>
            /// Enum Mobile for "mobile"
            /// </summary>
            [EnumMember(Value = "mobile")]
            Mobile,
            
            /// <summary>
            /// Enum Tollfree for "tollfree"
            /// </summary>
            [EnumMember(Value = "tollfree")]
            Tollfree,
            
            /// <summary>
            /// Enum Shortcode for "shortcode"
            /// </summary>
            [EnumMember(Value = "shortcode")]
            Shortcode
        }
        
        
        
        
        /// <summary>
        /// The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number.
        /// </summary>
        /// <value>The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AddressRequirementEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Any for "any"
            /// </summary>
            [EnumMember(Value = "any")]
            Any,
            
            /// <summary>
            /// Enum Local for "local"
            /// </summary>
            [EnumMember(Value = "local")]
            Local,
            
            /// <summary>
            /// Enum Foreign for "foreign"
            /// </summary>
            [EnumMember(Value = "foreign")]
            Foreign
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of phone number available for provisioning.
        /// </summary>
        /// <value>The type of phone number available for provisioning.</value>
        [DataMember(Name="phoneNumberType", EmitDefaultValue=false)]
        public PhoneNumberTypeEnum? PhoneNumberType { get; set; }
        
        
        
        /// <summary>
        /// The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number.
        /// </summary>
        /// <value>The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number.</value>
        [DataMember(Name="addressRequirement", EmitDefaultValue=false)]
        public AddressRequirementEnum? AddressRequirement { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsAvailablePhoneNumber" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="PhoneNumber">A phone number available for provisioning in E.164 format. E.g. +13175555555 or +34234234234.</param>
        
        
        
        /// <param name="CountryCode">The ISO 3166-1 alpha-2 country code of the country this phone number is associated with..</param>
        
        
        
        /// <param name="Region">The region/province/state the phone number is associated with..</param>
        
        
        
        /// <param name="City">The city the phone number is associated with..</param>
        
        
        
        /// <param name="Capabilities">The capabilities of the phone number available for provisioning..</param>
        
        
        
        /// <param name="PhoneNumberType">The type of phone number available for provisioning..</param>
        
        
        
        /// <param name="AddressRequirement">The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number..</param>
        
        
        
        
        public SmsAvailablePhoneNumber(string Name = null, string PhoneNumber = null, string CountryCode = null, string Region = null, string City = null, List<CapabilitiesEnum> Capabilities = null, PhoneNumberTypeEnum? PhoneNumberType = null, AddressRequirementEnum? AddressRequirement = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.PhoneNumber = PhoneNumber;
            
            
            
            
            
            
            
            
this.CountryCode = CountryCode;
            
            
            
            
            
            
            
            
this.Region = Region;
            
            
            
            
            
            
            
            
this.City = City;
            
            
            
            
            
            
            
            
this.Capabilities = Capabilities;
            
            
            
            
            
            
            
            
this.PhoneNumberType = PhoneNumberType;
            
            
            
            
            
            
            
            
this.AddressRequirement = AddressRequirement;
            
            
            
            
            
            
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
        /// A phone number available for provisioning in E.164 format. E.g. +13175555555 or +34234234234
        /// </summary>
        /// <value>A phone number available for provisioning in E.164 format. E.g. +13175555555 or +34234234234</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        
        
        
        /// <summary>
        /// The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.
        /// </summary>
        /// <value>The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        
        
        
        /// <summary>
        /// The region/province/state the phone number is associated with.
        /// </summary>
        /// <value>The region/province/state the phone number is associated with.</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }
        
        
        
        /// <summary>
        /// The city the phone number is associated with.
        /// </summary>
        /// <value>The city the phone number is associated with.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        
        
        
        /// <summary>
        /// The capabilities of the phone number available for provisioning.
        /// </summary>
        /// <value>The capabilities of the phone number available for provisioning.</value>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public List<CapabilitiesEnum> Capabilities { get; set; }
        
        
        
        
        
        
        
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
            sb.Append("class SmsAvailablePhoneNumber {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            
            sb.Append("  Region: ").Append(Region).Append("\n");
            
            sb.Append("  City: ").Append(City).Append("\n");
            
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            
            sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
            
            sb.Append("  AddressRequirement: ").Append(AddressRequirement).Append("\n");
            
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SmsAvailablePhoneNumber);
        }

        /// <summary>
        /// Returns true if SmsAvailablePhoneNumber instances are equal
        /// </summary>
        /// <param name="other">Instance of SmsAvailablePhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsAvailablePhoneNumber other)
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
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) &&
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) &&
                (
                    this.Capabilities == other.Capabilities ||
                    this.Capabilities != null &&
                    this.Capabilities.SequenceEqual(other.Capabilities)
                ) &&
                (
                    this.PhoneNumberType == other.PhoneNumberType ||
                    this.PhoneNumberType != null &&
                    this.PhoneNumberType.Equals(other.PhoneNumberType)
                ) &&
                (
                    this.AddressRequirement == other.AddressRequirement ||
                    this.AddressRequirement != null &&
                    this.AddressRequirement.Equals(other.AddressRequirement)
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
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.Capabilities != null)
                    hash = hash * 59 + this.Capabilities.GetHashCode();
                
                if (this.PhoneNumberType != null)
                    hash = hash * 59 + this.PhoneNumberType.GetHashCode();
                
                if (this.AddressRequirement != null)
                    hash = hash * 59 + this.AddressRequirement.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
