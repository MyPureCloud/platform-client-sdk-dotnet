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
            /// Enum Invalid for "INVALID"
            /// </summary>
            [EnumMember(Value = "INVALID")]
            Invalid,
            
            /// <summary>
            /// Enum Active for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            /// <summary>
            /// Enum Porting for "PORTING"
            /// </summary>
            [EnumMember(Value = "PORTING")]
            Porting,
            
            /// <summary>
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending,
            
            /// <summary>
            /// Enum PendingCancellation for "PENDING_CANCELLATION"
            /// </summary>
            [EnumMember(Value = "PENDING_CANCELLATION")]
            PendingCancellation
        }
        
        
        
        
        
        
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
        /// Renewal time period of this phone number, if the phoneNumberType is shortcode.
        /// </summary>
        /// <value>Renewal time period of this phone number, if the phoneNumberType is shortcode.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AutoRenewableEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Quarterly for "Quarterly"
            /// </summary>
            [EnumMember(Value = "Quarterly")]
            Quarterly
        }
        
        
        
        
        
        
        
        /// <summary>
        /// BillingType of this phone number, if the phoneNumberType is shortcode.
        /// </summary>
        /// <value>BillingType of this phone number, if the phoneNumberType is shortcode.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ShortCodeBillingTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Basic for "Basic"
            /// </summary>
            [EnumMember(Value = "Basic")]
            Basic,
            
            /// <summary>
            /// Enum Vanity for "Vanity"
            /// </summary>
            [EnumMember(Value = "Vanity")]
            Vanity
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
        /// Renewal time period of this phone number, if the phoneNumberType is shortcode.
        /// </summary>
        /// <value>Renewal time period of this phone number, if the phoneNumberType is shortcode.</value>
        [DataMember(Name="autoRenewable", EmitDefaultValue=false)]
        public AutoRenewableEnum? AutoRenewable { get; set; }
        
        
        
        
        
        /// <summary>
        /// BillingType of this phone number, if the phoneNumberType is shortcode.
        /// </summary>
        /// <value>BillingType of this phone number, if the phoneNumberType is shortcode.</value>
        [DataMember(Name="shortCodeBillingType", EmitDefaultValue=false)]
        public ShortCodeBillingTypeEnum? ShortCodeBillingType { get; set; }
        
        
        
        
    
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
        /// <param name="ProvisionedThroughPureCloud">Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud.</param>
        /// <param name="PhoneNumberStatus">Status of the provisioned phone number..</param>
        /// <param name="Capabilities">The capabilities of the phone number available for provisioning..</param>
        /// <param name="CountryCode">The ISO 3166-1 alpha-2 country code of the country this phone number is associated with..</param>
        /// <param name="DateCreated">Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreatedBy">User that provisioned this phone number.</param>
        /// <param name="ModifiedBy">User that last modified this phone number.</param>
        /// <param name="Version">Version number required for updates. (required).</param>
        /// <param name="PurchaseDate">Date this phone number was purchased, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CancellationDate">Contract end date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="RenewalDate">Contract renewal date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="AutoRenewable">Renewal time period of this phone number, if the phoneNumberType is shortcode..</param>
        /// <param name="AddressId">The id of an address attached to this phone number..</param>
        /// <param name="ShortCodeBillingType">BillingType of this phone number, if the phoneNumberType is shortcode..</param>
        public SmsPhoneNumber(string Name = null, string PhoneNumber = null, bool? ProvisionedThroughPureCloud = null, PhoneNumberStatusEnum? PhoneNumberStatus = null, List<CapabilitiesEnum> Capabilities = null, string CountryCode = null, DateTime? DateCreated = null, DateTime? DateModified = null, User CreatedBy = null, User ModifiedBy = null, int? Version = null, DateTime? PurchaseDate = null, DateTime? CancellationDate = null, DateTime? RenewalDate = null, AutoRenewableEnum? AutoRenewable = null, SmsAddress AddressId = null, ShortCodeBillingTypeEnum? ShortCodeBillingType = null)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.ProvisionedThroughPureCloud = ProvisionedThroughPureCloud;
            this.PhoneNumberStatus = PhoneNumberStatus;
            this.Capabilities = Capabilities;
            this.CountryCode = CountryCode;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.CreatedBy = CreatedBy;
            this.ModifiedBy = ModifiedBy;
            this.Version = Version;
            this.PurchaseDate = PurchaseDate;
            this.CancellationDate = CancellationDate;
            this.RenewalDate = RenewalDate;
            this.AutoRenewable = AutoRenewable;
            this.AddressId = AddressId;
            this.ShortCodeBillingType = ShortCodeBillingType;
            
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
        /// The capabilities of the phone number available for provisioning.
        /// </summary>
        /// <value>The capabilities of the phone number available for provisioning.</value>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public List<CapabilitiesEnum> Capabilities { get; set; }
        
        
        
        /// <summary>
        /// The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.
        /// </summary>
        /// <value>The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        
        
        
        /// <summary>
        /// Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
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
        /// Date this phone number was purchased, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date this phone number was purchased, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="purchaseDate", EmitDefaultValue=false)]
        public DateTime? PurchaseDate { get; set; }
        
        
        
        /// <summary>
        /// Contract end date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Contract end date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="cancellationDate", EmitDefaultValue=false)]
        public DateTime? CancellationDate { get; set; }
        
        
        
        /// <summary>
        /// Contract renewal date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Contract renewal date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="renewalDate", EmitDefaultValue=false)]
        public DateTime? RenewalDate { get; set; }
        
        
        
        
        
        /// <summary>
        /// The id of an address attached to this phone number.
        /// </summary>
        /// <value>The id of an address attached to this phone number.</value>
        [DataMember(Name="addressId", EmitDefaultValue=false)]
        public SmsAddress AddressId { get; set; }
        
        
        
        
        
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
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
            sb.Append("  CancellationDate: ").Append(CancellationDate).Append("\n");
            sb.Append("  RenewalDate: ").Append(RenewalDate).Append("\n");
            sb.Append("  AutoRenewable: ").Append(AutoRenewable).Append("\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  ShortCodeBillingType: ").Append(ShortCodeBillingType).Append("\n");
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
                    this.Capabilities == other.Capabilities ||
                    this.Capabilities != null &&
                    this.Capabilities.SequenceEqual(other.Capabilities)
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
                    this.PurchaseDate == other.PurchaseDate ||
                    this.PurchaseDate != null &&
                    this.PurchaseDate.Equals(other.PurchaseDate)
                ) &&
                (
                    this.CancellationDate == other.CancellationDate ||
                    this.CancellationDate != null &&
                    this.CancellationDate.Equals(other.CancellationDate)
                ) &&
                (
                    this.RenewalDate == other.RenewalDate ||
                    this.RenewalDate != null &&
                    this.RenewalDate.Equals(other.RenewalDate)
                ) &&
                (
                    this.AutoRenewable == other.AutoRenewable ||
                    this.AutoRenewable != null &&
                    this.AutoRenewable.Equals(other.AutoRenewable)
                ) &&
                (
                    this.AddressId == other.AddressId ||
                    this.AddressId != null &&
                    this.AddressId.Equals(other.AddressId)
                ) &&
                (
                    this.ShortCodeBillingType == other.ShortCodeBillingType ||
                    this.ShortCodeBillingType != null &&
                    this.ShortCodeBillingType.Equals(other.ShortCodeBillingType)
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
                
                if (this.Capabilities != null)
                    hash = hash * 59 + this.Capabilities.GetHashCode();
                
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
                
                if (this.PurchaseDate != null)
                    hash = hash * 59 + this.PurchaseDate.GetHashCode();
                
                if (this.CancellationDate != null)
                    hash = hash * 59 + this.CancellationDate.GetHashCode();
                
                if (this.RenewalDate != null)
                    hash = hash * 59 + this.RenewalDate.GetHashCode();
                
                if (this.AutoRenewable != null)
                    hash = hash * 59 + this.AutoRenewable.GetHashCode();
                
                if (this.AddressId != null)
                    hash = hash * 59 + this.AddressId.GetHashCode();
                
                if (this.ShortCodeBillingType != null)
                    hash = hash * 59 + this.ShortCodeBillingType.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
