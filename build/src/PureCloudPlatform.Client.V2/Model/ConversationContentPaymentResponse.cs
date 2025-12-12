using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Payment response object representing the status of a payment transaction.
	/// </summary>
	[DataContract]
	public partial class ConversationContentPaymentResponse : IEquatable<ConversationContentPaymentResponse>
	{
		/// <summary>
		/// The status of the payment transaction.
		/// </summary>
		/// <value>The status of the payment transaction.</value>
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
			/// Enum Completed for "Completed"
			/// </summary>
			[EnumMember(Value = "Completed")]
			Completed,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed
		}
		/// <summary>
		/// The status of the payment transaction.
		/// </summary>
		/// <value>The status of the payment transaction.</value>
		[DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
		public PaymentStatusEnum? PaymentStatus { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentPaymentResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationContentPaymentResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentPaymentResponse" /> class.
		/// </summary>
		/// <param name="OriginatingMessageId">Reference to the ID of the original payment request message this response is for. (required).</param>
		/// <param name="PaymentStatus">The status of the payment transaction. (required).</param>
		/// <param name="FailureReason">The reason the payment request failed..</param>
		public ConversationContentPaymentResponse(string OriginatingMessageId = null, PaymentStatusEnum? PaymentStatus = null, string FailureReason = null)
		{
			this.OriginatingMessageId = OriginatingMessageId;
			this.PaymentStatus = PaymentStatus;
			this.FailureReason = FailureReason;

		}



		/// <summary>
		/// Reference to the ID of the original payment request message this response is for.
		/// </summary>
		/// <value>Reference to the ID of the original payment request message this response is for.</value>
		[DataMember(Name = "originatingMessageId", EmitDefaultValue = false)]
		public string OriginatingMessageId { get; set; }





		/// <summary>
		/// The reason the payment request failed.
		/// </summary>
		/// <value>The reason the payment request failed.</value>
		[DataMember(Name = "failureReason", EmitDefaultValue = false)]
		public string FailureReason { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentPaymentResponse {\n");

			sb.Append("  OriginatingMessageId: ").Append(OriginatingMessageId).Append("\n");
			sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
			sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
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
			return this.Equals(obj as ConversationContentPaymentResponse);
		}

		/// <summary>
		/// Returns true if ConversationContentPaymentResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentPaymentResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentPaymentResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.OriginatingMessageId == other.OriginatingMessageId ||
					this.OriginatingMessageId != null &&
					this.OriginatingMessageId.Equals(other.OriginatingMessageId)
				) &&
				(
					this.PaymentStatus == other.PaymentStatus ||
					this.PaymentStatus != null &&
					this.PaymentStatus.Equals(other.PaymentStatus)
				) &&
				(
					this.FailureReason == other.FailureReason ||
					this.FailureReason != null &&
					this.FailureReason.Equals(other.FailureReason)
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
				if (this.OriginatingMessageId != null)
					hash = hash * 59 + this.OriginatingMessageId.GetHashCode();

				if (this.PaymentStatus != null)
					hash = hash * 59 + this.PaymentStatus.GetHashCode();

				if (this.FailureReason != null)
					hash = hash * 59 + this.FailureReason.GetHashCode();

				return hash;
			}
		}
	}

}
