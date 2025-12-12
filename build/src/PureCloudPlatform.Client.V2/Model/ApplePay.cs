using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ApplePay
	/// </summary>
	[DataContract]
	public partial class ApplePay : IEquatable<ApplePay>
	{
		/// <summary>
		/// Gets or Sets PaymentCapabilities
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum PaymentCapabilitiesEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum _3ds for "3DS"
			/// </summary>
			[EnumMember(Value = "3DS")]
			_3ds,

			/// <summary>
			/// Enum Creditcard for "creditCard"
			/// </summary>
			[EnumMember(Value = "creditCard")]
			Creditcard,

			/// <summary>
			/// Enum Debitcard for "debitCard"
			/// </summary>
			[EnumMember(Value = "debitCard")]
			Debitcard
		}
		/// <summary>
		/// Gets or Sets SupportedPaymentNetworks
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SupportedPaymentNetworksEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Amex for "amex"
			/// </summary>
			[EnumMember(Value = "amex")]
			Amex,

			/// <summary>
			/// Enum Discover for "discover"
			/// </summary>
			[EnumMember(Value = "discover")]
			Discover,

			/// <summary>
			/// Enum Jcb for "jcb"
			/// </summary>
			[EnumMember(Value = "jcb")]
			Jcb,

			/// <summary>
			/// Enum Mastercard for "masterCard"
			/// </summary>
			[EnumMember(Value = "masterCard")]
			Mastercard,

			/// <summary>
			/// Enum Privatelabel for "privateLabel"
			/// </summary>
			[EnumMember(Value = "privateLabel")]
			Privatelabel,

			/// <summary>
			/// Enum Visa for "visa"
			/// </summary>
			[EnumMember(Value = "visa")]
			Visa
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ApplePay" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ApplePay() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ApplePay" /> class.
		/// </summary>
		/// <param name="StoreName">The name of the store. (required).</param>
		/// <param name="MerchantId">The stores merchant identifier. (required).</param>
		/// <param name="DomainName">The domain name associated with the merchant account. (required).</param>
		/// <param name="PaymentCapabilities">The payment capabilities supported by the merchant. (required).</param>
		/// <param name="SupportedPaymentNetworks">The payment networks supported by the merchant. (required).</param>
		/// <param name="PaymentCertificateCredentialId">The Genesys credentialId the payment certificates are stored under. (required).</param>
		/// <param name="PaymentGatewayUrl">The url used to process payments. (required).</param>
		/// <param name="FallbackUrl">The url opened in a web browser if the customers device is unable to make payments using Apple Pay..</param>
		/// <param name="ShippingMethodUpdateUrl">The url called when the customer changes the shipping method..</param>
		/// <param name="ShippingContactUpdateUrl">The url called when the customer changes their shipping address information..</param>
		/// <param name="PaymentMethodUpdateUrl">The url called when the customer changes their payment method..</param>
		/// <param name="OrderTrackingUrl">The url called after completing the order to update the order information in your system.</param>
		public ApplePay(string StoreName = null, string MerchantId = null, string DomainName = null, List<PaymentCapabilitiesEnum> PaymentCapabilities = null, List<SupportedPaymentNetworksEnum> SupportedPaymentNetworks = null, string PaymentCertificateCredentialId = null, string PaymentGatewayUrl = null, string FallbackUrl = null, string ShippingMethodUpdateUrl = null, string ShippingContactUpdateUrl = null, string PaymentMethodUpdateUrl = null, string OrderTrackingUrl = null)
		{
			this.StoreName = StoreName;
			this.MerchantId = MerchantId;
			this.DomainName = DomainName;
			this.PaymentCapabilities = PaymentCapabilities;
			this.SupportedPaymentNetworks = SupportedPaymentNetworks;
			this.PaymentCertificateCredentialId = PaymentCertificateCredentialId;
			this.PaymentGatewayUrl = PaymentGatewayUrl;
			this.FallbackUrl = FallbackUrl;
			this.ShippingMethodUpdateUrl = ShippingMethodUpdateUrl;
			this.ShippingContactUpdateUrl = ShippingContactUpdateUrl;
			this.PaymentMethodUpdateUrl = PaymentMethodUpdateUrl;
			this.OrderTrackingUrl = OrderTrackingUrl;

		}



		/// <summary>
		/// The name of the store.
		/// </summary>
		/// <value>The name of the store.</value>
		[DataMember(Name = "storeName", EmitDefaultValue = false)]
		public string StoreName { get; set; }



		/// <summary>
		/// The stores merchant identifier.
		/// </summary>
		/// <value>The stores merchant identifier.</value>
		[DataMember(Name = "merchantId", EmitDefaultValue = false)]
		public string MerchantId { get; set; }



		/// <summary>
		/// The domain name associated with the merchant account.
		/// </summary>
		/// <value>The domain name associated with the merchant account.</value>
		[DataMember(Name = "domainName", EmitDefaultValue = false)]
		public string DomainName { get; set; }



		/// <summary>
		/// The payment capabilities supported by the merchant.
		/// </summary>
		/// <value>The payment capabilities supported by the merchant.</value>
		[DataMember(Name = "paymentCapabilities", EmitDefaultValue = false)]
		public List<PaymentCapabilitiesEnum> PaymentCapabilities { get; set; }



		/// <summary>
		/// The payment networks supported by the merchant.
		/// </summary>
		/// <value>The payment networks supported by the merchant.</value>
		[DataMember(Name = "supportedPaymentNetworks", EmitDefaultValue = false)]
		public List<SupportedPaymentNetworksEnum> SupportedPaymentNetworks { get; set; }



		/// <summary>
		/// The Genesys credentialId the payment certificates are stored under.
		/// </summary>
		/// <value>The Genesys credentialId the payment certificates are stored under.</value>
		[DataMember(Name = "paymentCertificateCredentialId", EmitDefaultValue = false)]
		public string PaymentCertificateCredentialId { get; set; }



		/// <summary>
		/// The url used to process payments.
		/// </summary>
		/// <value>The url used to process payments.</value>
		[DataMember(Name = "paymentGatewayUrl", EmitDefaultValue = false)]
		public string PaymentGatewayUrl { get; set; }



		/// <summary>
		/// The url opened in a web browser if the customers device is unable to make payments using Apple Pay.
		/// </summary>
		/// <value>The url opened in a web browser if the customers device is unable to make payments using Apple Pay.</value>
		[DataMember(Name = "fallbackUrl", EmitDefaultValue = false)]
		public string FallbackUrl { get; set; }



		/// <summary>
		/// The url called when the customer changes the shipping method.
		/// </summary>
		/// <value>The url called when the customer changes the shipping method.</value>
		[DataMember(Name = "shippingMethodUpdateUrl", EmitDefaultValue = false)]
		public string ShippingMethodUpdateUrl { get; set; }



		/// <summary>
		/// The url called when the customer changes their shipping address information.
		/// </summary>
		/// <value>The url called when the customer changes their shipping address information.</value>
		[DataMember(Name = "shippingContactUpdateUrl", EmitDefaultValue = false)]
		public string ShippingContactUpdateUrl { get; set; }



		/// <summary>
		/// The url called when the customer changes their payment method.
		/// </summary>
		/// <value>The url called when the customer changes their payment method.</value>
		[DataMember(Name = "paymentMethodUpdateUrl", EmitDefaultValue = false)]
		public string PaymentMethodUpdateUrl { get; set; }



		/// <summary>
		/// The url called after completing the order to update the order information in your system
		/// </summary>
		/// <value>The url called after completing the order to update the order information in your system</value>
		[DataMember(Name = "orderTrackingUrl", EmitDefaultValue = false)]
		public string OrderTrackingUrl { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ApplePay {\n");

			sb.Append("  StoreName: ").Append(StoreName).Append("\n");
			sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
			sb.Append("  DomainName: ").Append(DomainName).Append("\n");
			sb.Append("  PaymentCapabilities: ").Append(PaymentCapabilities).Append("\n");
			sb.Append("  SupportedPaymentNetworks: ").Append(SupportedPaymentNetworks).Append("\n");
			sb.Append("  PaymentCertificateCredentialId: ").Append(PaymentCertificateCredentialId).Append("\n");
			sb.Append("  PaymentGatewayUrl: ").Append(PaymentGatewayUrl).Append("\n");
			sb.Append("  FallbackUrl: ").Append(FallbackUrl).Append("\n");
			sb.Append("  ShippingMethodUpdateUrl: ").Append(ShippingMethodUpdateUrl).Append("\n");
			sb.Append("  ShippingContactUpdateUrl: ").Append(ShippingContactUpdateUrl).Append("\n");
			sb.Append("  PaymentMethodUpdateUrl: ").Append(PaymentMethodUpdateUrl).Append("\n");
			sb.Append("  OrderTrackingUrl: ").Append(OrderTrackingUrl).Append("\n");
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
			return this.Equals(obj as ApplePay);
		}

		/// <summary>
		/// Returns true if ApplePay instances are equal
		/// </summary>
		/// <param name="other">Instance of ApplePay to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApplePay other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StoreName == other.StoreName ||
					this.StoreName != null &&
					this.StoreName.Equals(other.StoreName)
				) &&
				(
					this.MerchantId == other.MerchantId ||
					this.MerchantId != null &&
					this.MerchantId.Equals(other.MerchantId)
				) &&
				(
					this.DomainName == other.DomainName ||
					this.DomainName != null &&
					this.DomainName.Equals(other.DomainName)
				) &&
				(
					this.PaymentCapabilities == other.PaymentCapabilities ||
					this.PaymentCapabilities != null &&
					this.PaymentCapabilities.SequenceEqual(other.PaymentCapabilities)
				) &&
				(
					this.SupportedPaymentNetworks == other.SupportedPaymentNetworks ||
					this.SupportedPaymentNetworks != null &&
					this.SupportedPaymentNetworks.SequenceEqual(other.SupportedPaymentNetworks)
				) &&
				(
					this.PaymentCertificateCredentialId == other.PaymentCertificateCredentialId ||
					this.PaymentCertificateCredentialId != null &&
					this.PaymentCertificateCredentialId.Equals(other.PaymentCertificateCredentialId)
				) &&
				(
					this.PaymentGatewayUrl == other.PaymentGatewayUrl ||
					this.PaymentGatewayUrl != null &&
					this.PaymentGatewayUrl.Equals(other.PaymentGatewayUrl)
				) &&
				(
					this.FallbackUrl == other.FallbackUrl ||
					this.FallbackUrl != null &&
					this.FallbackUrl.Equals(other.FallbackUrl)
				) &&
				(
					this.ShippingMethodUpdateUrl == other.ShippingMethodUpdateUrl ||
					this.ShippingMethodUpdateUrl != null &&
					this.ShippingMethodUpdateUrl.Equals(other.ShippingMethodUpdateUrl)
				) &&
				(
					this.ShippingContactUpdateUrl == other.ShippingContactUpdateUrl ||
					this.ShippingContactUpdateUrl != null &&
					this.ShippingContactUpdateUrl.Equals(other.ShippingContactUpdateUrl)
				) &&
				(
					this.PaymentMethodUpdateUrl == other.PaymentMethodUpdateUrl ||
					this.PaymentMethodUpdateUrl != null &&
					this.PaymentMethodUpdateUrl.Equals(other.PaymentMethodUpdateUrl)
				) &&
				(
					this.OrderTrackingUrl == other.OrderTrackingUrl ||
					this.OrderTrackingUrl != null &&
					this.OrderTrackingUrl.Equals(other.OrderTrackingUrl)
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
				if (this.StoreName != null)
					hash = hash * 59 + this.StoreName.GetHashCode();

				if (this.MerchantId != null)
					hash = hash * 59 + this.MerchantId.GetHashCode();

				if (this.DomainName != null)
					hash = hash * 59 + this.DomainName.GetHashCode();

				if (this.PaymentCapabilities != null)
					hash = hash * 59 + this.PaymentCapabilities.GetHashCode();

				if (this.SupportedPaymentNetworks != null)
					hash = hash * 59 + this.SupportedPaymentNetworks.GetHashCode();

				if (this.PaymentCertificateCredentialId != null)
					hash = hash * 59 + this.PaymentCertificateCredentialId.GetHashCode();

				if (this.PaymentGatewayUrl != null)
					hash = hash * 59 + this.PaymentGatewayUrl.GetHashCode();

				if (this.FallbackUrl != null)
					hash = hash * 59 + this.FallbackUrl.GetHashCode();

				if (this.ShippingMethodUpdateUrl != null)
					hash = hash * 59 + this.ShippingMethodUpdateUrl.GetHashCode();

				if (this.ShippingContactUpdateUrl != null)
					hash = hash * 59 + this.ShippingContactUpdateUrl.GetHashCode();

				if (this.PaymentMethodUpdateUrl != null)
					hash = hash * 59 + this.PaymentMethodUpdateUrl.GetHashCode();

				if (this.OrderTrackingUrl != null)
					hash = hash * 59 + this.OrderTrackingUrl.GetHashCode();

				return hash;
			}
		}
	}

}
