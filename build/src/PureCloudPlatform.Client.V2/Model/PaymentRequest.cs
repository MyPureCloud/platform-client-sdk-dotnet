using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PaymentRequest
	/// </summary>
	[DataContract]
	public partial class PaymentRequest : IEquatable<PaymentRequest>
	{
		/// <summary>
		/// The payment platform being used (e.g. Apple Pay)
		/// </summary>
		/// <value>The payment platform being used (e.g. Apple Pay)</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum PaymentPlatformEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Applepay for "ApplePay"
			/// </summary>
			[EnumMember(Value = "ApplePay")]
			Applepay
		}
		/// <summary>
		/// The payment platform being used (e.g. Apple Pay)
		/// </summary>
		/// <value>The payment platform being used (e.g. Apple Pay)</value>
		[DataMember(Name = "paymentPlatform", EmitDefaultValue = false)]
		public PaymentPlatformEnum? PaymentPlatform { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="PaymentRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected PaymentRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="PaymentRequest" /> class.
		/// </summary>
		/// <param name="PaymentPlatform">The payment platform being used (e.g. Apple Pay).</param>
		/// <param name="CountryCode">The merchant&#39;s two-letter ISO 3166 country code..</param>
		/// <param name="CurrencyCode">The three-letter ISO 4217 currency code for the payment..</param>
		/// <param name="OrderTotal">The total price of the order. (required).</param>
		/// <param name="LineItems">The items that make up the order..</param>
		/// <param name="ShippingOptions">The available shipping options..</param>
		public PaymentRequest(PaymentPlatformEnum? PaymentPlatform = null, string CountryCode = null, string CurrencyCode = null, double? OrderTotal = null, List<PaymentLineItem> LineItems = null, List<PaymentLineItem> ShippingOptions = null)
		{
			this.PaymentPlatform = PaymentPlatform;
			this.CountryCode = CountryCode;
			this.CurrencyCode = CurrencyCode;
			this.OrderTotal = OrderTotal;
			this.LineItems = LineItems;
			this.ShippingOptions = ShippingOptions;

		}





		/// <summary>
		/// The merchant&#39;s two-letter ISO 3166 country code.
		/// </summary>
		/// <value>The merchant&#39;s two-letter ISO 3166 country code.</value>
		[DataMember(Name = "countryCode", EmitDefaultValue = false)]
		public string CountryCode { get; set; }



		/// <summary>
		/// The three-letter ISO 4217 currency code for the payment.
		/// </summary>
		/// <value>The three-letter ISO 4217 currency code for the payment.</value>
		[DataMember(Name = "currencyCode", EmitDefaultValue = false)]
		public string CurrencyCode { get; set; }



		/// <summary>
		/// The total price of the order.
		/// </summary>
		/// <value>The total price of the order.</value>
		[DataMember(Name = "orderTotal", EmitDefaultValue = false)]
		public double? OrderTotal { get; set; }



		/// <summary>
		/// The items that make up the order.
		/// </summary>
		/// <value>The items that make up the order.</value>
		[DataMember(Name = "lineItems", EmitDefaultValue = false)]
		public List<PaymentLineItem> LineItems { get; set; }



		/// <summary>
		/// The available shipping options.
		/// </summary>
		/// <value>The available shipping options.</value>
		[DataMember(Name = "shippingOptions", EmitDefaultValue = false)]
		public List<PaymentLineItem> ShippingOptions { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PaymentRequest {\n");

			sb.Append("  PaymentPlatform: ").Append(PaymentPlatform).Append("\n");
			sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
			sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
			sb.Append("  OrderTotal: ").Append(OrderTotal).Append("\n");
			sb.Append("  LineItems: ").Append(LineItems).Append("\n");
			sb.Append("  ShippingOptions: ").Append(ShippingOptions).Append("\n");
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
			return this.Equals(obj as PaymentRequest);
		}

		/// <summary>
		/// Returns true if PaymentRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of PaymentRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PaymentRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.PaymentPlatform == other.PaymentPlatform ||
					this.PaymentPlatform != null &&
					this.PaymentPlatform.Equals(other.PaymentPlatform)
				) &&
				(
					this.CountryCode == other.CountryCode ||
					this.CountryCode != null &&
					this.CountryCode.Equals(other.CountryCode)
				) &&
				(
					this.CurrencyCode == other.CurrencyCode ||
					this.CurrencyCode != null &&
					this.CurrencyCode.Equals(other.CurrencyCode)
				) &&
				(
					this.OrderTotal == other.OrderTotal ||
					this.OrderTotal != null &&
					this.OrderTotal.Equals(other.OrderTotal)
				) &&
				(
					this.LineItems == other.LineItems ||
					this.LineItems != null &&
					this.LineItems.SequenceEqual(other.LineItems)
				) &&
				(
					this.ShippingOptions == other.ShippingOptions ||
					this.ShippingOptions != null &&
					this.ShippingOptions.SequenceEqual(other.ShippingOptions)
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
				if (this.PaymentPlatform != null)
					hash = hash * 59 + this.PaymentPlatform.GetHashCode();

				if (this.CountryCode != null)
					hash = hash * 59 + this.CountryCode.GetHashCode();

				if (this.CurrencyCode != null)
					hash = hash * 59 + this.CurrencyCode.GetHashCode();

				if (this.OrderTotal != null)
					hash = hash * 59 + this.OrderTotal.GetHashCode();

				if (this.LineItems != null)
					hash = hash * 59 + this.LineItems.GetHashCode();

				if (this.ShippingOptions != null)
					hash = hash * 59 + this.ShippingOptions.GetHashCode();

				return hash;
			}
		}
	}

}
