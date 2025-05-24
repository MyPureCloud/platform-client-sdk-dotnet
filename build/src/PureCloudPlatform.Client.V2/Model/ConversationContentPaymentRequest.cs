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
    /// Payment Request object used to request payment from a customer.
    /// </summary>
    [DataContract]
    public partial class ConversationContentPaymentRequest :  IEquatable<ConversationContentPaymentRequest>
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
        [DataMember(Name="paymentPlatform", EmitDefaultValue=false)]
        public PaymentPlatformEnum? PaymentPlatform { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentPaymentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentPaymentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentPaymentRequest" /> class.
        /// </summary>
        /// <param name="CountryCode">The merchant&#39;s two-letter ISO 3166 country code. (required).</param>
        /// <param name="CurrencyCode">The three-letter ISO 4217 currency code for the payment. (required).</param>
        /// <param name="OrderTotal">The total price of the order. (required).</param>
        /// <param name="LineItems">The items that make up the order..</param>
        /// <param name="ShippingOptions">The available shipping options..</param>
        /// <param name="RequiredContactFields">Contact fields required to complete the order..</param>
        /// <param name="ReceivedMessage">The message prompt to complete a payment transaction..</param>
        /// <param name="ReplyMessage">The reply message after the user has completed the payment transaction..</param>
        public ConversationContentPaymentRequest(string CountryCode = null, string CurrencyCode = null, double? OrderTotal = null, List<ConversationContentLineItem> LineItems = null, List<ConversationContentLineItem> ShippingOptions = null, List<ConversationContentRequiredContactField> RequiredContactFields = null, ConversationContentReceivedReplyMessage ReceivedMessage = null, ConversationContentReceivedReplyMessage ReplyMessage = null)
        {
            this.CountryCode = CountryCode;
            this.CurrencyCode = CurrencyCode;
            this.OrderTotal = OrderTotal;
            this.LineItems = LineItems;
            this.ShippingOptions = ShippingOptions;
            this.RequiredContactFields = RequiredContactFields;
            this.ReceivedMessage = ReceivedMessage;
            this.ReplyMessage = ReplyMessage;
            
        }
        




        /// <summary>
        /// The merchant&#39;s two-letter ISO 3166 country code.
        /// </summary>
        /// <value>The merchant&#39;s two-letter ISO 3166 country code.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }



        /// <summary>
        /// The three-letter ISO 4217 currency code for the payment.
        /// </summary>
        /// <value>The three-letter ISO 4217 currency code for the payment.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }



        /// <summary>
        /// The total price of the order.
        /// </summary>
        /// <value>The total price of the order.</value>
        [DataMember(Name="orderTotal", EmitDefaultValue=false)]
        public double? OrderTotal { get; set; }



        /// <summary>
        /// The items that make up the order.
        /// </summary>
        /// <value>The items that make up the order.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<ConversationContentLineItem> LineItems { get; set; }



        /// <summary>
        /// The available shipping options.
        /// </summary>
        /// <value>The available shipping options.</value>
        [DataMember(Name="shippingOptions", EmitDefaultValue=false)]
        public List<ConversationContentLineItem> ShippingOptions { get; set; }



        /// <summary>
        /// Contact fields required to complete the order.
        /// </summary>
        /// <value>Contact fields required to complete the order.</value>
        [DataMember(Name="requiredContactFields", EmitDefaultValue=false)]
        public List<ConversationContentRequiredContactField> RequiredContactFields { get; set; }



        /// <summary>
        /// The message prompt to complete a payment transaction.
        /// </summary>
        /// <value>The message prompt to complete a payment transaction.</value>
        [DataMember(Name="receivedMessage", EmitDefaultValue=false)]
        public ConversationContentReceivedReplyMessage ReceivedMessage { get; set; }



        /// <summary>
        /// The reply message after the user has completed the payment transaction.
        /// </summary>
        /// <value>The reply message after the user has completed the payment transaction.</value>
        [DataMember(Name="replyMessage", EmitDefaultValue=false)]
        public ConversationContentReceivedReplyMessage ReplyMessage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentPaymentRequest {\n");

            sb.Append("  PaymentPlatform: ").Append(PaymentPlatform).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  OrderTotal: ").Append(OrderTotal).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  ShippingOptions: ").Append(ShippingOptions).Append("\n");
            sb.Append("  RequiredContactFields: ").Append(RequiredContactFields).Append("\n");
            sb.Append("  ReceivedMessage: ").Append(ReceivedMessage).Append("\n");
            sb.Append("  ReplyMessage: ").Append(ReplyMessage).Append("\n");
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
            return this.Equals(obj as ConversationContentPaymentRequest);
        }

        /// <summary>
        /// Returns true if ConversationContentPaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentPaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentPaymentRequest other)
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
                ) &&
                (
                    this.RequiredContactFields == other.RequiredContactFields ||
                    this.RequiredContactFields != null &&
                    this.RequiredContactFields.SequenceEqual(other.RequiredContactFields)
                ) &&
                (
                    this.ReceivedMessage == other.ReceivedMessage ||
                    this.ReceivedMessage != null &&
                    this.ReceivedMessage.Equals(other.ReceivedMessage)
                ) &&
                (
                    this.ReplyMessage == other.ReplyMessage ||
                    this.ReplyMessage != null &&
                    this.ReplyMessage.Equals(other.ReplyMessage)
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

                if (this.RequiredContactFields != null)
                    hash = hash * 59 + this.RequiredContactFields.GetHashCode();

                if (this.ReceivedMessage != null)
                    hash = hash * 59 + this.ReceivedMessage.GetHashCode();

                if (this.ReplyMessage != null)
                    hash = hash * 59 + this.ReplyMessage.GetHashCode();

                return hash;
            }
        }
    }

}
