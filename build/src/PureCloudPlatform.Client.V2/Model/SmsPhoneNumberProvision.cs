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
    /// SmsPhoneNumberProvision
    /// </summary>
    [DataContract]
    public partial class SmsPhoneNumberProvision :  IEquatable<SmsPhoneNumberProvision>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Type of the phone number provisioned.
        /// </summary>
        /// <value>Type of the phone number provisioned.</value>
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
        /// Type of the phone number provisioned.
        /// </summary>
        /// <value>Type of the phone number provisioned.</value>
        [DataMember(Name="phoneNumberType", EmitDefaultValue=false)]
        public PhoneNumberTypeEnum? PhoneNumberType { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsPhoneNumberProvision" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsPhoneNumberProvision() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsPhoneNumberProvision" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="PhoneNumber">A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234 (required).</param>
        /// <param name="PhoneNumberType">Type of the phone number provisioned. (required).</param>
        /// <param name="CountryCode">The ISO 3166-1 alpha-2 country code of the country this phone number is associated with. (required).</param>
        /// <param name="AddressId">The id of an address added on your account. Due to regulatory requirements in some countries, an address may be required when provisioning a sms number. In those cases you should provide the provisioned sms address id here.</param>
        public SmsPhoneNumberProvision(string Name = null, string PhoneNumber = null, PhoneNumberTypeEnum? PhoneNumberType = null, string CountryCode = null, string AddressId = null)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.PhoneNumberType = PhoneNumberType;
            this.CountryCode = CountryCode;
            this.AddressId = AddressId;
            
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
        /// A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234
        /// </summary>
        /// <value>A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        
        
        
        
        
        /// <summary>
        /// The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.
        /// </summary>
        /// <value>The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        
        
        
        /// <summary>
        /// The id of an address added on your account. Due to regulatory requirements in some countries, an address may be required when provisioning a sms number. In those cases you should provide the provisioned sms address id here
        /// </summary>
        /// <value>The id of an address added on your account. Due to regulatory requirements in some countries, an address may be required when provisioning a sms number. In those cases you should provide the provisioned sms address id here</value>
        [DataMember(Name="addressId", EmitDefaultValue=false)]
        public string AddressId { get; set; }
        
        
        
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
            sb.Append("class SmsPhoneNumberProvision {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
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
            return this.Equals(obj as SmsPhoneNumberProvision);
        }

        /// <summary>
        /// Returns true if SmsPhoneNumberProvision instances are equal
        /// </summary>
        /// <param name="other">Instance of SmsPhoneNumberProvision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsPhoneNumberProvision other)
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
                    this.PhoneNumberType == other.PhoneNumberType ||
                    this.PhoneNumberType != null &&
                    this.PhoneNumberType.Equals(other.PhoneNumberType)
                ) &&
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    this.AddressId == other.AddressId ||
                    this.AddressId != null &&
                    this.AddressId.Equals(other.AddressId)
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
                
                if (this.PhoneNumberType != null)
                    hash = hash * 59 + this.PhoneNumberType.GetHashCode();
                
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                
                if (this.AddressId != null)
                    hash = hash * 59 + this.AddressId.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
