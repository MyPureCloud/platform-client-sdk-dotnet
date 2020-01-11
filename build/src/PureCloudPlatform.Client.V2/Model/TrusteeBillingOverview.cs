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
    /// TrusteeBillingOverview
    /// </summary>
    [DataContract]
    public partial class TrusteeBillingOverview :  IEquatable<TrusteeBillingOverview>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The subscription type.
        /// </summary>
        /// <value>The subscription type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SubscriptionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inin for "ININ"
            /// </summary>
            [EnumMember(Value = "ININ")]
            Inin,
            
            /// <summary>
            /// Enum MonthToMonth for "MONTH_TO_MONTH"
            /// </summary>
            [EnumMember(Value = "MONTH_TO_MONTH")]
            MonthToMonth,
            
            /// <summary>
            /// Enum FreeTrialMonthToMonth for "FREE_TRIAL_MONTH_TO_MONTH"
            /// </summary>
            [EnumMember(Value = "FREE_TRIAL_MONTH_TO_MONTH")]
            FreeTrialMonthToMonth,
            
            /// <summary>
            /// Enum PrepayMonthlyCommitment for "PREPAY_MONTHLY_COMMITMENT"
            /// </summary>
            [EnumMember(Value = "PREPAY_MONTHLY_COMMITMENT")]
            PrepayMonthlyCommitment,
            
            /// <summary>
            /// Enum Prepay for "PREPAY"
            /// </summary>
            [EnumMember(Value = "PREPAY")]
            Prepay,
            
            /// <summary>
            /// Enum DevOrgMonthToMonth for "DEV_ORG_MONTH_TO_MONTH"
            /// </summary>
            [EnumMember(Value = "DEV_ORG_MONTH_TO_MONTH")]
            DevOrgMonthToMonth,
            
            /// <summary>
            /// Enum DevOrgPrepayMonthlyCommitment for "DEV_ORG_PREPAY_MONTHLY_COMMITMENT"
            /// </summary>
            [EnumMember(Value = "DEV_ORG_PREPAY_MONTHLY_COMMITMENT")]
            DevOrgPrepayMonthlyCommitment,
            
            /// <summary>
            /// Enum DevOrgPrepay for "DEV_ORG_PREPAY"
            /// </summary>
            [EnumMember(Value = "DEV_ORG_PREPAY")]
            DevOrgPrepay
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The subscription type.
        /// </summary>
        /// <value>The subscription type.</value>
        [DataMember(Name="subscriptionType", EmitDefaultValue=false)]
        public SubscriptionTypeEnum? SubscriptionType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrusteeBillingOverview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrusteeBillingOverview() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrusteeBillingOverview" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Organization">Organization (required).</param>
        /// <param name="Currency">The currency type. (required).</param>
        /// <param name="EnabledProducts">The charge short names for products enabled during the specified period. (required).</param>
        /// <param name="SubscriptionType">The subscription type. (required).</param>
        /// <param name="RampPeriodStartDate">Date-time the ramp period starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="RampPeriodEndDate">Date-time the ramp period ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="BillingPeriodStartDate">Date-time the billing period started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="BillingPeriodEndDate">Date-time the billing period ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Usages">Usages for the specified period. (required).</param>
        /// <param name="ContractAmendmentDate">Date-time the contract was last amended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ContractEffectiveDate">Date-time the contract became effective. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ContractEndDate">Date-time the contract ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="MinimumMonthlyAmount">Minimum amount that will be charged for the month.</param>
        /// <param name="InRampPeriod">InRampPeriod.</param>
        public TrusteeBillingOverview(string Name = null, NamedEntity Organization = null, string Currency = null, List<string> EnabledProducts = null, SubscriptionTypeEnum? SubscriptionType = null, DateTime? RampPeriodStartDate = null, DateTime? RampPeriodEndDate = null, DateTime? BillingPeriodStartDate = null, DateTime? BillingPeriodEndDate = null, List<SubscriptionOverviewUsage> Usages = null, DateTime? ContractAmendmentDate = null, DateTime? ContractEffectiveDate = null, DateTime? ContractEndDate = null, string MinimumMonthlyAmount = null, bool? InRampPeriod = null)
        {
            this.Name = Name;
            this.Organization = Organization;
            this.Currency = Currency;
            this.EnabledProducts = EnabledProducts;
            this.SubscriptionType = SubscriptionType;
            this.RampPeriodStartDate = RampPeriodStartDate;
            this.RampPeriodEndDate = RampPeriodEndDate;
            this.BillingPeriodStartDate = BillingPeriodStartDate;
            this.BillingPeriodEndDate = BillingPeriodEndDate;
            this.Usages = Usages;
            this.ContractAmendmentDate = ContractAmendmentDate;
            this.ContractEffectiveDate = ContractEffectiveDate;
            this.ContractEndDate = ContractEndDate;
            this.MinimumMonthlyAmount = MinimumMonthlyAmount;
            this.InRampPeriod = InRampPeriod;
            
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
        /// Organization
        /// </summary>
        /// <value>Organization</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public NamedEntity Organization { get; set; }
        
        
        
        /// <summary>
        /// The currency type.
        /// </summary>
        /// <value>The currency type.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        
        
        
        /// <summary>
        /// The charge short names for products enabled during the specified period.
        /// </summary>
        /// <value>The charge short names for products enabled during the specified period.</value>
        [DataMember(Name="enabledProducts", EmitDefaultValue=false)]
        public List<string> EnabledProducts { get; set; }
        
        
        
        
        
        /// <summary>
        /// Date-time the ramp period starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date-time the ramp period starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="rampPeriodStartDate", EmitDefaultValue=false)]
        public DateTime? RampPeriodStartDate { get; set; }
        
        
        
        /// <summary>
        /// Date-time the ramp period ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date-time the ramp period ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="rampPeriodEndDate", EmitDefaultValue=false)]
        public DateTime? RampPeriodEndDate { get; set; }
        
        
        
        /// <summary>
        /// Date-time the billing period started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date-time the billing period started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="billingPeriodStartDate", EmitDefaultValue=false)]
        public DateTime? BillingPeriodStartDate { get; set; }
        
        
        
        /// <summary>
        /// Date-time the billing period ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date-time the billing period ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="billingPeriodEndDate", EmitDefaultValue=false)]
        public DateTime? BillingPeriodEndDate { get; set; }
        
        
        
        /// <summary>
        /// Usages for the specified period.
        /// </summary>
        /// <value>Usages for the specified period.</value>
        [DataMember(Name="usages", EmitDefaultValue=false)]
        public List<SubscriptionOverviewUsage> Usages { get; set; }
        
        
        
        /// <summary>
        /// Date-time the contract was last amended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date-time the contract was last amended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="contractAmendmentDate", EmitDefaultValue=false)]
        public DateTime? ContractAmendmentDate { get; set; }
        
        
        
        /// <summary>
        /// Date-time the contract became effective. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date-time the contract became effective. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="contractEffectiveDate", EmitDefaultValue=false)]
        public DateTime? ContractEffectiveDate { get; set; }
        
        
        
        /// <summary>
        /// Date-time the contract ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date-time the contract ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="contractEndDate", EmitDefaultValue=false)]
        public DateTime? ContractEndDate { get; set; }
        
        
        
        /// <summary>
        /// Minimum amount that will be charged for the month
        /// </summary>
        /// <value>Minimum amount that will be charged for the month</value>
        [DataMember(Name="minimumMonthlyAmount", EmitDefaultValue=false)]
        public string MinimumMonthlyAmount { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets InRampPeriod
        /// </summary>
        [DataMember(Name="inRampPeriod", EmitDefaultValue=false)]
        public bool? InRampPeriod { get; set; }
        
        
        
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
            sb.Append("class TrusteeBillingOverview {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  EnabledProducts: ").Append(EnabledProducts).Append("\n");
            sb.Append("  SubscriptionType: ").Append(SubscriptionType).Append("\n");
            sb.Append("  RampPeriodStartDate: ").Append(RampPeriodStartDate).Append("\n");
            sb.Append("  RampPeriodEndDate: ").Append(RampPeriodEndDate).Append("\n");
            sb.Append("  BillingPeriodStartDate: ").Append(BillingPeriodStartDate).Append("\n");
            sb.Append("  BillingPeriodEndDate: ").Append(BillingPeriodEndDate).Append("\n");
            sb.Append("  Usages: ").Append(Usages).Append("\n");
            sb.Append("  ContractAmendmentDate: ").Append(ContractAmendmentDate).Append("\n");
            sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
            sb.Append("  ContractEndDate: ").Append(ContractEndDate).Append("\n");
            sb.Append("  MinimumMonthlyAmount: ").Append(MinimumMonthlyAmount).Append("\n");
            sb.Append("  InRampPeriod: ").Append(InRampPeriod).Append("\n");
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
            return this.Equals(obj as TrusteeBillingOverview);
        }

        /// <summary>
        /// Returns true if TrusteeBillingOverview instances are equal
        /// </summary>
        /// <param name="other">Instance of TrusteeBillingOverview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrusteeBillingOverview other)
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
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) &&
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) &&
                (
                    this.EnabledProducts == other.EnabledProducts ||
                    this.EnabledProducts != null &&
                    this.EnabledProducts.SequenceEqual(other.EnabledProducts)
                ) &&
                (
                    this.SubscriptionType == other.SubscriptionType ||
                    this.SubscriptionType != null &&
                    this.SubscriptionType.Equals(other.SubscriptionType)
                ) &&
                (
                    this.RampPeriodStartDate == other.RampPeriodStartDate ||
                    this.RampPeriodStartDate != null &&
                    this.RampPeriodStartDate.Equals(other.RampPeriodStartDate)
                ) &&
                (
                    this.RampPeriodEndDate == other.RampPeriodEndDate ||
                    this.RampPeriodEndDate != null &&
                    this.RampPeriodEndDate.Equals(other.RampPeriodEndDate)
                ) &&
                (
                    this.BillingPeriodStartDate == other.BillingPeriodStartDate ||
                    this.BillingPeriodStartDate != null &&
                    this.BillingPeriodStartDate.Equals(other.BillingPeriodStartDate)
                ) &&
                (
                    this.BillingPeriodEndDate == other.BillingPeriodEndDate ||
                    this.BillingPeriodEndDate != null &&
                    this.BillingPeriodEndDate.Equals(other.BillingPeriodEndDate)
                ) &&
                (
                    this.Usages == other.Usages ||
                    this.Usages != null &&
                    this.Usages.SequenceEqual(other.Usages)
                ) &&
                (
                    this.ContractAmendmentDate == other.ContractAmendmentDate ||
                    this.ContractAmendmentDate != null &&
                    this.ContractAmendmentDate.Equals(other.ContractAmendmentDate)
                ) &&
                (
                    this.ContractEffectiveDate == other.ContractEffectiveDate ||
                    this.ContractEffectiveDate != null &&
                    this.ContractEffectiveDate.Equals(other.ContractEffectiveDate)
                ) &&
                (
                    this.ContractEndDate == other.ContractEndDate ||
                    this.ContractEndDate != null &&
                    this.ContractEndDate.Equals(other.ContractEndDate)
                ) &&
                (
                    this.MinimumMonthlyAmount == other.MinimumMonthlyAmount ||
                    this.MinimumMonthlyAmount != null &&
                    this.MinimumMonthlyAmount.Equals(other.MinimumMonthlyAmount)
                ) &&
                (
                    this.InRampPeriod == other.InRampPeriod ||
                    this.InRampPeriod != null &&
                    this.InRampPeriod.Equals(other.InRampPeriod)
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
                
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                
                if (this.EnabledProducts != null)
                    hash = hash * 59 + this.EnabledProducts.GetHashCode();
                
                if (this.SubscriptionType != null)
                    hash = hash * 59 + this.SubscriptionType.GetHashCode();
                
                if (this.RampPeriodStartDate != null)
                    hash = hash * 59 + this.RampPeriodStartDate.GetHashCode();
                
                if (this.RampPeriodEndDate != null)
                    hash = hash * 59 + this.RampPeriodEndDate.GetHashCode();
                
                if (this.BillingPeriodStartDate != null)
                    hash = hash * 59 + this.BillingPeriodStartDate.GetHashCode();
                
                if (this.BillingPeriodEndDate != null)
                    hash = hash * 59 + this.BillingPeriodEndDate.GetHashCode();
                
                if (this.Usages != null)
                    hash = hash * 59 + this.Usages.GetHashCode();
                
                if (this.ContractAmendmentDate != null)
                    hash = hash * 59 + this.ContractAmendmentDate.GetHashCode();
                
                if (this.ContractEffectiveDate != null)
                    hash = hash * 59 + this.ContractEffectiveDate.GetHashCode();
                
                if (this.ContractEndDate != null)
                    hash = hash * 59 + this.ContractEndDate.GetHashCode();
                
                if (this.MinimumMonthlyAmount != null)
                    hash = hash * 59 + this.MinimumMonthlyAmount.GetHashCode();
                
                if (this.InRampPeriod != null)
                    hash = hash * 59 + this.InRampPeriod.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
