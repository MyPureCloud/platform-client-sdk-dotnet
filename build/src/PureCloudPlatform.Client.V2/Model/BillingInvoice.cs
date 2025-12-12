using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BillingInvoice
	/// </summary>
	[DataContract]
	public partial class BillingInvoice : IEquatable<BillingInvoice>
	{
		/// <summary>
		/// Status of the payment.
		/// </summary>
		/// <value>Status of the payment.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum PaymentStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Paid for "Paid"
			/// </summary>
			[EnumMember(Value = "Paid")]
			Paid,

			/// <summary>
			/// Enum Unpaid for "Unpaid"
			/// </summary>
			[EnumMember(Value = "Unpaid")]
			Unpaid
		}
		/// <summary>
		/// Status of the payment.
		/// </summary>
		/// <value>Status of the payment.</value>
		[DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
		public PaymentStatusEnum? PaymentStatus { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="BillingInvoice" /> class.
		/// </summary>
		/// <param name="BillToCustomer">The bill to customer..</param>
		/// <param name="ShipToCustomer">The ship to customer..</param>
		/// <param name="SoldToCustomer">The sold to customer..</param>
		/// <param name="DateInvoiced">Date when the invoice was issued. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="BillToAddress">Details of the bill to address..</param>
		/// <param name="ShipToAddress">Details of the ship to address..</param>
		/// <param name="CurrencyIsoCode">Contains the ISO code for any currency allowed by the organization..</param>
		/// <param name="PaymentStatus">Status of the payment..</param>
		/// <param name="PaymentTerms">Payment terms..</param>
		/// <param name="PaymentLink">Payment link..</param>
		/// <param name="CustomerPoNumber">Purchase Order Number..</param>
		/// <param name="CustomerInvoiceType">Type of the invoice..</param>
		/// <param name="Amount">Amount..</param>
		public BillingInvoice(Customer BillToCustomer = null, Customer ShipToCustomer = null, Customer SoldToCustomer = null, String DateInvoiced = null, InvoiceAddress BillToAddress = null, InvoiceAddress ShipToAddress = null, string CurrencyIsoCode = null, PaymentStatusEnum? PaymentStatus = null, string PaymentTerms = null, string PaymentLink = null, string CustomerPoNumber = null, string CustomerInvoiceType = null, double? Amount = null)
		{
			this.BillToCustomer = BillToCustomer;
			this.ShipToCustomer = ShipToCustomer;
			this.SoldToCustomer = SoldToCustomer;
			this.DateInvoiced = DateInvoiced;
			this.BillToAddress = BillToAddress;
			this.ShipToAddress = ShipToAddress;
			this.CurrencyIsoCode = CurrencyIsoCode;
			this.PaymentStatus = PaymentStatus;
			this.PaymentTerms = PaymentTerms;
			this.PaymentLink = PaymentLink;
			this.CustomerPoNumber = CustomerPoNumber;
			this.CustomerInvoiceType = CustomerInvoiceType;
			this.Amount = Amount;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The bill to customer.
		/// </summary>
		/// <value>The bill to customer.</value>
		[DataMember(Name = "billToCustomer", EmitDefaultValue = false)]
		public Customer BillToCustomer { get; set; }



		/// <summary>
		/// The ship to customer.
		/// </summary>
		/// <value>The ship to customer.</value>
		[DataMember(Name = "shipToCustomer", EmitDefaultValue = false)]
		public Customer ShipToCustomer { get; set; }



		/// <summary>
		/// The sold to customer.
		/// </summary>
		/// <value>The sold to customer.</value>
		[DataMember(Name = "soldToCustomer", EmitDefaultValue = false)]
		public Customer SoldToCustomer { get; set; }



		/// <summary>
		/// Date when the invoice was issued. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Date when the invoice was issued. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateInvoiced", EmitDefaultValue = false)]
		public String DateInvoiced { get; set; }



		/// <summary>
		/// Details of the bill to address.
		/// </summary>
		/// <value>Details of the bill to address.</value>
		[DataMember(Name = "billToAddress", EmitDefaultValue = false)]
		public InvoiceAddress BillToAddress { get; set; }



		/// <summary>
		/// Details of the ship to address.
		/// </summary>
		/// <value>Details of the ship to address.</value>
		[DataMember(Name = "shipToAddress", EmitDefaultValue = false)]
		public InvoiceAddress ShipToAddress { get; set; }



		/// <summary>
		/// Contains the ISO code for any currency allowed by the organization.
		/// </summary>
		/// <value>Contains the ISO code for any currency allowed by the organization.</value>
		[DataMember(Name = "currencyIsoCode", EmitDefaultValue = false)]
		public string CurrencyIsoCode { get; set; }





		/// <summary>
		/// Payment terms.
		/// </summary>
		/// <value>Payment terms.</value>
		[DataMember(Name = "paymentTerms", EmitDefaultValue = false)]
		public string PaymentTerms { get; set; }



		/// <summary>
		/// Payment link.
		/// </summary>
		/// <value>Payment link.</value>
		[DataMember(Name = "paymentLink", EmitDefaultValue = false)]
		public string PaymentLink { get; set; }



		/// <summary>
		/// Purchase Order Number.
		/// </summary>
		/// <value>Purchase Order Number.</value>
		[DataMember(Name = "customerPoNumber", EmitDefaultValue = false)]
		public string CustomerPoNumber { get; set; }



		/// <summary>
		/// Type of the invoice.
		/// </summary>
		/// <value>Type of the invoice.</value>
		[DataMember(Name = "customerInvoiceType", EmitDefaultValue = false)]
		public string CustomerInvoiceType { get; set; }



		/// <summary>
		/// Amount.
		/// </summary>
		/// <value>Amount.</value>
		[DataMember(Name = "amount", EmitDefaultValue = false)]
		public double? Amount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BillingInvoice {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  BillToCustomer: ").Append(BillToCustomer).Append("\n");
			sb.Append("  ShipToCustomer: ").Append(ShipToCustomer).Append("\n");
			sb.Append("  SoldToCustomer: ").Append(SoldToCustomer).Append("\n");
			sb.Append("  DateInvoiced: ").Append(DateInvoiced).Append("\n");
			sb.Append("  BillToAddress: ").Append(BillToAddress).Append("\n");
			sb.Append("  ShipToAddress: ").Append(ShipToAddress).Append("\n");
			sb.Append("  CurrencyIsoCode: ").Append(CurrencyIsoCode).Append("\n");
			sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
			sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
			sb.Append("  PaymentLink: ").Append(PaymentLink).Append("\n");
			sb.Append("  CustomerPoNumber: ").Append(CustomerPoNumber).Append("\n");
			sb.Append("  CustomerInvoiceType: ").Append(CustomerInvoiceType).Append("\n");
			sb.Append("  Amount: ").Append(Amount).Append("\n");
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
			return this.Equals(obj as BillingInvoice);
		}

		/// <summary>
		/// Returns true if BillingInvoice instances are equal
		/// </summary>
		/// <param name="other">Instance of BillingInvoice to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BillingInvoice other)
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
					this.BillToCustomer == other.BillToCustomer ||
					this.BillToCustomer != null &&
					this.BillToCustomer.Equals(other.BillToCustomer)
				) &&
				(
					this.ShipToCustomer == other.ShipToCustomer ||
					this.ShipToCustomer != null &&
					this.ShipToCustomer.Equals(other.ShipToCustomer)
				) &&
				(
					this.SoldToCustomer == other.SoldToCustomer ||
					this.SoldToCustomer != null &&
					this.SoldToCustomer.Equals(other.SoldToCustomer)
				) &&
				(
					this.DateInvoiced == other.DateInvoiced ||
					this.DateInvoiced != null &&
					this.DateInvoiced.Equals(other.DateInvoiced)
				) &&
				(
					this.BillToAddress == other.BillToAddress ||
					this.BillToAddress != null &&
					this.BillToAddress.Equals(other.BillToAddress)
				) &&
				(
					this.ShipToAddress == other.ShipToAddress ||
					this.ShipToAddress != null &&
					this.ShipToAddress.Equals(other.ShipToAddress)
				) &&
				(
					this.CurrencyIsoCode == other.CurrencyIsoCode ||
					this.CurrencyIsoCode != null &&
					this.CurrencyIsoCode.Equals(other.CurrencyIsoCode)
				) &&
				(
					this.PaymentStatus == other.PaymentStatus ||
					this.PaymentStatus != null &&
					this.PaymentStatus.Equals(other.PaymentStatus)
				) &&
				(
					this.PaymentTerms == other.PaymentTerms ||
					this.PaymentTerms != null &&
					this.PaymentTerms.Equals(other.PaymentTerms)
				) &&
				(
					this.PaymentLink == other.PaymentLink ||
					this.PaymentLink != null &&
					this.PaymentLink.Equals(other.PaymentLink)
				) &&
				(
					this.CustomerPoNumber == other.CustomerPoNumber ||
					this.CustomerPoNumber != null &&
					this.CustomerPoNumber.Equals(other.CustomerPoNumber)
				) &&
				(
					this.CustomerInvoiceType == other.CustomerInvoiceType ||
					this.CustomerInvoiceType != null &&
					this.CustomerInvoiceType.Equals(other.CustomerInvoiceType)
				) &&
				(
					this.Amount == other.Amount ||
					this.Amount != null &&
					this.Amount.Equals(other.Amount)
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

				if (this.BillToCustomer != null)
					hash = hash * 59 + this.BillToCustomer.GetHashCode();

				if (this.ShipToCustomer != null)
					hash = hash * 59 + this.ShipToCustomer.GetHashCode();

				if (this.SoldToCustomer != null)
					hash = hash * 59 + this.SoldToCustomer.GetHashCode();

				if (this.DateInvoiced != null)
					hash = hash * 59 + this.DateInvoiced.GetHashCode();

				if (this.BillToAddress != null)
					hash = hash * 59 + this.BillToAddress.GetHashCode();

				if (this.ShipToAddress != null)
					hash = hash * 59 + this.ShipToAddress.GetHashCode();

				if (this.CurrencyIsoCode != null)
					hash = hash * 59 + this.CurrencyIsoCode.GetHashCode();

				if (this.PaymentStatus != null)
					hash = hash * 59 + this.PaymentStatus.GetHashCode();

				if (this.PaymentTerms != null)
					hash = hash * 59 + this.PaymentTerms.GetHashCode();

				if (this.PaymentLink != null)
					hash = hash * 59 + this.PaymentLink.GetHashCode();

				if (this.CustomerPoNumber != null)
					hash = hash * 59 + this.CustomerPoNumber.GetHashCode();

				if (this.CustomerInvoiceType != null)
					hash = hash * 59 + this.CustomerInvoiceType.GetHashCode();

				if (this.Amount != null)
					hash = hash * 59 + this.Amount.GetHashCode();

				return hash;
			}
		}
	}

}
