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
    /// BillingContract
    /// </summary>
    [DataContract]
    public partial class BillingContract :  IEquatable<BillingContract>
    {
        /// <summary>
        /// The status of the contract.
        /// </summary>
        /// <value>The status of the contract.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive
        }
        /// <summary>
        /// The status of the contract.
        /// </summary>
        /// <value>The status of the contract.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingContract" /> class.
        /// </summary>
        /// <param name="ExternalNumber">Unique external number..</param>
        /// <param name="Status">The status of the contract..</param>
        /// <param name="CommercialModel">The type of commercial model..</param>
        /// <param name="PurchaseOrderNumbers">List of po numbers periods for this contract..</param>
        /// <param name="BillToCustomer">The bill to customer..</param>
        /// <param name="SoldToCustomer">The sold to customer..</param>
        /// <param name="EndCustomer">The end customer..</param>
        /// <param name="DateStart">The start date of the contract. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="DateEnd">The end date of the contract. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="DateRampStart">the date when the first revenue or quantity in a ramped deal begins. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="DateRampEnd">the date when the first revenue or quantity in a ramped deal ends. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="BillingPeriods">List of billing periods for the contract..</param>
        /// <param name="Plans">The collection of prices for the related organizations..</param>
        public BillingContract(string ExternalNumber = null, StatusEnum? Status = null, string CommercialModel = null, List<string> PurchaseOrderNumbers = null, Customer BillToCustomer = null, Customer SoldToCustomer = null, Customer EndCustomer = null, String DateStart = null, String DateEnd = null, String DateRampStart = null, String DateRampEnd = null, List<BillingContractPeriod> BillingPeriods = null, List<BillingPlan> Plans = null)
        {
            this.ExternalNumber = ExternalNumber;
            this.Status = Status;
            this.CommercialModel = CommercialModel;
            this.PurchaseOrderNumbers = PurchaseOrderNumbers;
            this.BillToCustomer = BillToCustomer;
            this.SoldToCustomer = SoldToCustomer;
            this.EndCustomer = EndCustomer;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.DateRampStart = DateRampStart;
            this.DateRampEnd = DateRampEnd;
            this.BillingPeriods = BillingPeriods;
            this.Plans = Plans;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Unique external number.
        /// </summary>
        /// <value>Unique external number.</value>
        [DataMember(Name="externalNumber", EmitDefaultValue=false)]
        public string ExternalNumber { get; set; }





        /// <summary>
        /// The type of commercial model.
        /// </summary>
        /// <value>The type of commercial model.</value>
        [DataMember(Name="commercialModel", EmitDefaultValue=false)]
        public string CommercialModel { get; set; }



        /// <summary>
        /// List of po numbers periods for this contract.
        /// </summary>
        /// <value>List of po numbers periods for this contract.</value>
        [DataMember(Name="purchaseOrderNumbers", EmitDefaultValue=false)]
        public List<string> PurchaseOrderNumbers { get; set; }



        /// <summary>
        /// The bill to customer.
        /// </summary>
        /// <value>The bill to customer.</value>
        [DataMember(Name="billToCustomer", EmitDefaultValue=false)]
        public Customer BillToCustomer { get; set; }



        /// <summary>
        /// The sold to customer.
        /// </summary>
        /// <value>The sold to customer.</value>
        [DataMember(Name="soldToCustomer", EmitDefaultValue=false)]
        public Customer SoldToCustomer { get; set; }



        /// <summary>
        /// The end customer.
        /// </summary>
        /// <value>The end customer.</value>
        [DataMember(Name="endCustomer", EmitDefaultValue=false)]
        public Customer EndCustomer { get; set; }



        /// <summary>
        /// The start date of the contract. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start date of the contract. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public String DateStart { get; set; }



        /// <summary>
        /// The end date of the contract. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The end date of the contract. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public String DateEnd { get; set; }



        /// <summary>
        /// the date when the first revenue or quantity in a ramped deal begins. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>the date when the first revenue or quantity in a ramped deal begins. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateRampStart", EmitDefaultValue=false)]
        public String DateRampStart { get; set; }



        /// <summary>
        /// the date when the first revenue or quantity in a ramped deal ends. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>the date when the first revenue or quantity in a ramped deal ends. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateRampEnd", EmitDefaultValue=false)]
        public String DateRampEnd { get; set; }



        /// <summary>
        /// List of billing periods for the contract.
        /// </summary>
        /// <value>List of billing periods for the contract.</value>
        [DataMember(Name="billingPeriods", EmitDefaultValue=false)]
        public List<BillingContractPeriod> BillingPeriods { get; set; }



        /// <summary>
        /// The collection of prices for the related organizations.
        /// </summary>
        /// <value>The collection of prices for the related organizations.</value>
        [DataMember(Name="plans", EmitDefaultValue=false)]
        public List<BillingPlan> Plans { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingContract {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalNumber: ").Append(ExternalNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CommercialModel: ").Append(CommercialModel).Append("\n");
            sb.Append("  PurchaseOrderNumbers: ").Append(PurchaseOrderNumbers).Append("\n");
            sb.Append("  BillToCustomer: ").Append(BillToCustomer).Append("\n");
            sb.Append("  SoldToCustomer: ").Append(SoldToCustomer).Append("\n");
            sb.Append("  EndCustomer: ").Append(EndCustomer).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  DateRampStart: ").Append(DateRampStart).Append("\n");
            sb.Append("  DateRampEnd: ").Append(DateRampEnd).Append("\n");
            sb.Append("  BillingPeriods: ").Append(BillingPeriods).Append("\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
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
            return this.Equals(obj as BillingContract);
        }

        /// <summary>
        /// Returns true if BillingContract instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingContract other)
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
                    this.ExternalNumber == other.ExternalNumber ||
                    this.ExternalNumber != null &&
                    this.ExternalNumber.Equals(other.ExternalNumber)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.CommercialModel == other.CommercialModel ||
                    this.CommercialModel != null &&
                    this.CommercialModel.Equals(other.CommercialModel)
                ) &&
                (
                    this.PurchaseOrderNumbers == other.PurchaseOrderNumbers ||
                    this.PurchaseOrderNumbers != null &&
                    this.PurchaseOrderNumbers.SequenceEqual(other.PurchaseOrderNumbers)
                ) &&
                (
                    this.BillToCustomer == other.BillToCustomer ||
                    this.BillToCustomer != null &&
                    this.BillToCustomer.Equals(other.BillToCustomer)
                ) &&
                (
                    this.SoldToCustomer == other.SoldToCustomer ||
                    this.SoldToCustomer != null &&
                    this.SoldToCustomer.Equals(other.SoldToCustomer)
                ) &&
                (
                    this.EndCustomer == other.EndCustomer ||
                    this.EndCustomer != null &&
                    this.EndCustomer.Equals(other.EndCustomer)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
                ) &&
                (
                    this.DateRampStart == other.DateRampStart ||
                    this.DateRampStart != null &&
                    this.DateRampStart.Equals(other.DateRampStart)
                ) &&
                (
                    this.DateRampEnd == other.DateRampEnd ||
                    this.DateRampEnd != null &&
                    this.DateRampEnd.Equals(other.DateRampEnd)
                ) &&
                (
                    this.BillingPeriods == other.BillingPeriods ||
                    this.BillingPeriods != null &&
                    this.BillingPeriods.SequenceEqual(other.BillingPeriods)
                ) &&
                (
                    this.Plans == other.Plans ||
                    this.Plans != null &&
                    this.Plans.SequenceEqual(other.Plans)
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

                if (this.ExternalNumber != null)
                    hash = hash * 59 + this.ExternalNumber.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.CommercialModel != null)
                    hash = hash * 59 + this.CommercialModel.GetHashCode();

                if (this.PurchaseOrderNumbers != null)
                    hash = hash * 59 + this.PurchaseOrderNumbers.GetHashCode();

                if (this.BillToCustomer != null)
                    hash = hash * 59 + this.BillToCustomer.GetHashCode();

                if (this.SoldToCustomer != null)
                    hash = hash * 59 + this.SoldToCustomer.GetHashCode();

                if (this.EndCustomer != null)
                    hash = hash * 59 + this.EndCustomer.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();

                if (this.DateRampStart != null)
                    hash = hash * 59 + this.DateRampStart.GetHashCode();

                if (this.DateRampEnd != null)
                    hash = hash * 59 + this.DateRampEnd.GetHashCode();

                if (this.BillingPeriods != null)
                    hash = hash * 59 + this.BillingPeriods.GetHashCode();

                if (this.Plans != null)
                    hash = hash * 59 + this.Plans.GetHashCode();

                return hash;
            }
        }
    }

}
