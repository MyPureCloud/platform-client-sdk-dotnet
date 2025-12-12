using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TransferToQueueRequest
	/// </summary>
	[DataContract]
	public partial class TransferToQueueRequest : IEquatable<TransferToQueueRequest>
	{
		/// <summary>
		/// The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.
		/// </summary>
		/// <value>The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TransferTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Attended for "Attended"
			/// </summary>
			[EnumMember(Value = "Attended")]
			Attended,

			/// <summary>
			/// Enum Unattended for "Unattended"
			/// </summary>
			[EnumMember(Value = "Unattended")]
			Unattended
		}
		/// <summary>
		/// The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.
		/// </summary>
		/// <value>The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.</value>
		[DataMember(Name = "transferType", EmitDefaultValue = false)]
		public TransferTypeEnum? TransferType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="TransferToQueueRequest" /> class.
		/// </summary>
		/// <param name="TransferType">The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended..</param>
		/// <param name="KeepInternalMessageAlive">If true, the digital internal message will NOT be terminated..</param>
		/// <param name="QueueId">The id of the queue..</param>
		/// <param name="QueueName">The name of the queue..</param>
		public TransferToQueueRequest(TransferTypeEnum? TransferType = null, bool? KeepInternalMessageAlive = null, string QueueId = null, string QueueName = null)
		{
			this.TransferType = TransferType;
			this.KeepInternalMessageAlive = KeepInternalMessageAlive;
			this.QueueId = QueueId;
			this.QueueName = QueueName;

		}





		/// <summary>
		/// If true, the digital internal message will NOT be terminated.
		/// </summary>
		/// <value>If true, the digital internal message will NOT be terminated.</value>
		[DataMember(Name = "keepInternalMessageAlive", EmitDefaultValue = false)]
		public bool? KeepInternalMessageAlive { get; set; }



		/// <summary>
		/// The id of the queue.
		/// </summary>
		/// <value>The id of the queue.</value>
		[DataMember(Name = "queueId", EmitDefaultValue = false)]
		public string QueueId { get; set; }



		/// <summary>
		/// The name of the queue.
		/// </summary>
		/// <value>The name of the queue.</value>
		[DataMember(Name = "queueName", EmitDefaultValue = false)]
		public string QueueName { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TransferToQueueRequest {\n");

			sb.Append("  TransferType: ").Append(TransferType).Append("\n");
			sb.Append("  KeepInternalMessageAlive: ").Append(KeepInternalMessageAlive).Append("\n");
			sb.Append("  QueueId: ").Append(QueueId).Append("\n");
			sb.Append("  QueueName: ").Append(QueueName).Append("\n");
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
			return this.Equals(obj as TransferToQueueRequest);
		}

		/// <summary>
		/// Returns true if TransferToQueueRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of TransferToQueueRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TransferToQueueRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TransferType == other.TransferType ||
					this.TransferType != null &&
					this.TransferType.Equals(other.TransferType)
				) &&
				(
					this.KeepInternalMessageAlive == other.KeepInternalMessageAlive ||
					this.KeepInternalMessageAlive != null &&
					this.KeepInternalMessageAlive.Equals(other.KeepInternalMessageAlive)
				) &&
				(
					this.QueueId == other.QueueId ||
					this.QueueId != null &&
					this.QueueId.Equals(other.QueueId)
				) &&
				(
					this.QueueName == other.QueueName ||
					this.QueueName != null &&
					this.QueueName.Equals(other.QueueName)
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
				if (this.TransferType != null)
					hash = hash * 59 + this.TransferType.GetHashCode();

				if (this.KeepInternalMessageAlive != null)
					hash = hash * 59 + this.KeepInternalMessageAlive.GetHashCode();

				if (this.QueueId != null)
					hash = hash * 59 + this.QueueId.GetHashCode();

				if (this.QueueName != null)
					hash = hash * 59 + this.QueueName.GetHashCode();

				return hash;
			}
		}
	}

}
