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
    /// SmsPhoneNumber
    /// </summary>
    [DataContract]
    public partial class SmsPhoneNumber :  IEquatable<SmsPhoneNumber>
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
        /// Status of the provisioned phone number.
        /// </summary>
        /// <value>Status of the provisioned phone number.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PhoneNumberStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Invalid for "invalid"
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Porting for "porting"
            /// </summary>
            [EnumMember(Value = "porting")]
            Porting
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Type of the phone number provisioned.
        /// </summary>
        /// <value>Type of the phone number provisioned.</value>
        [DataMember(Name="phoneNumberType", EmitDefaultValue=false)]
        public PhoneNumberTypeEnum? PhoneNumberType { get; set; }
        
        
        
        
        
        /// <summary>
        /// Status of the provisioned phone number.
        /// </summary>
        /// <value>Status of the provisioned phone number.</value>
        [DataMember(Name="phoneNumberStatus", EmitDefaultValue=false)]
        public PhoneNumberStatusEnum? PhoneNumberStatus { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsPhoneNumber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsPhoneNumber() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsPhoneNumber" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="PhoneNumber">A phone number provisioned for SMS communications in E.164 format. E.g. +13175555555 or +34234234234 (required).</param>
        
        
        
        /// <param name="PhoneNumberType">Type of the phone number provisioned..</param>
        
        
        
        /// <param name="ProvisionedThroughPureCloud">Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud.</param>
        
        
        
        /// <param name="PhoneNumberStatus">Status of the provisioned phone number..</param>
        
        
        
        /// <param name="CountryCode">The ISO 3166-1 alpha-2 country code of the country this phone number is associated with..</param>
        
        
        
        /// <param name="DateCreated">Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="DateModified">Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="CreatedBy">User that provisioned this phone number.</param>
        
        
        
        /// <param name="ModifiedBy">User that last modified this phone number.</param>
        
        
        
        /// <param name="Version">Version number required for updates..</param>
        
        
        
        
        public SmsPhoneNumber(string Name = null, string PhoneNumber = null, PhoneNumberTypeEnum? PhoneNumberType = null, bool? ProvisionedThroughPureCloud = null, PhoneNumberStatusEnum? PhoneNumberStatus = null, string CountryCode = null, DateTime? DateCreated = null, DateTime? DateModified = null, User CreatedBy = null, User ModifiedBy = null, int? Version = null)
        {
            
            
            
            
            
            
            
            
            
            // to ensure "PhoneNumber" is required (not null)
            if (PhoneNumber == null)
            {
                throw new InvalidDataException("PhoneNumber is a required property for SmsPhoneNumber and cannot be null");
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
            
            
            
            
this.PhoneNumberType = PhoneNumberType;
            
            
            
            
            
            
            
            
this.ProvisionedThroughPureCloud = ProvisionedThroughPureCloud;
            
            
            
            
            
            
            
            
this.PhoneNumberStatus = PhoneNumberStatus;
            
            
            
            
            
            
            
            
this.CountryCode = CountryCode;
            
            
            
            
            
            
            
            
this.DateCreated = DateCreated;
            
            
            
            
            
            
            
            
this.DateModified = DateModified;
            
            
            
            
            
            
            
            
this.CreatedBy = CreatedBy;
            
            
            
            
            
            
            
            
this.ModifiedBy = ModifiedBy;
            
            
            
            
            
            
            
            
this.Version = Version;
            
            
            
            
            
            
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
        /// A phone number provisioned for SMS communications in E.164 format. E.g. +13175555555 or +34234234234
        /// </summary>
        /// <value>A phone number provisioned for SMS communications in E.164 format. E.g. +13175555555 or +34234234234</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        
        
        
        
        
        /// <summary>
        /// Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud
        /// </summary>
        /// <value>Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud</value>
        [DataMember(Name="provisionedThroughPureCloud", EmitDefaultValue=false)]
        public bool? ProvisionedThroughPureCloud { get; set; }
        
        
        
        
        
        /// <summary>
        /// The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.
        /// </summary>
        /// <value>The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        
        
        
        /// <summary>
        /// Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// User that provisioned this phone number
        /// </summary>
        /// <value>User that provisioned this phone number</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public User CreatedBy { get; set; }
        
        
        
        /// <summary>
        /// User that last modified this phone number
        /// </summary>
        /// <value>User that last modified this phone number</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public User ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// Version number required for updates.
        /// </summary>
        /// <value>Version number required for updates.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
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
            sb.Append("class SmsPhoneNumber {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            
            sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
            
            sb.Append("  ProvisionedThroughPureCloud: ").Append(ProvisionedThroughPureCloud).Append("\n");
            
            sb.Append("  PhoneNumberStatus: ").Append(PhoneNumberStatus).Append("\n");
            
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            
            sb.Append("  Version: ").Append(Version).Append("\n");
            
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
            return this.Equals(obj as SmsPhoneNumber);
        }

        /// <summary>
        /// Returns true if SmsPhoneNumber instances are equal
        /// </summary>
        /// <param name="other">Instance of SmsPhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsPhoneNumber other)
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
                    this.ProvisionedThroughPureCloud == other.ProvisionedThroughPureCloud ||
                    this.ProvisionedThroughPureCloud != null &&
                    this.ProvisionedThroughPureCloud.Equals(other.ProvisionedThroughPureCloud)
                ) &&
                (
                    this.PhoneNumberStatus == other.PhoneNumberStatus ||
                    this.PhoneNumberStatus != null &&
                    this.PhoneNumberStatus.Equals(other.PhoneNumberStatus)
                ) &&
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                
                if (this.ProvisionedThroughPureCloud != null)
                    hash = hash * 59 + this.ProvisionedThroughPureCloud.GetHashCode();
                
                if (this.PhoneNumberStatus != null)
                    hash = hash * 59 + this.PhoneNumberStatus.GetHashCode();
                
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
