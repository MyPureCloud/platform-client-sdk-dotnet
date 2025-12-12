using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TransferRequest
	/// </summary>
	[DataContract]
	public partial class TransferRequest : IEquatable<TransferRequest>
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
		/// Initializes a new instance of the <see cref="TransferRequest" /> class.
		/// </summary>
		/// <param name="TransferType">The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended..</param>
		/// <param name="KeepInternalMessageAlive">If true, the digital internal message will NOT be terminated..</param>
		/// <param name="UserId">The user ID of the transfer target..</param>
		/// <param name="Address">The user ID or queue ID of the transfer target. Address like a phone number can not be used for callbacks, but they can be used for other forms of communication..</param>
		/// <param name="UserName">The user name of the transfer target..</param>
		/// <param name="QueueId">The queue ID of the transfer target..</param>
		/// <param name="Voicemail">If true, transfer to the voicemail inbox of the participant that is being replaced..</param>
		public TransferRequest(TransferTypeEnum? TransferType = null, bool? KeepInternalMessageAlive = null, string UserId = null, string Address = null, string UserName = null, string QueueId = null, bool? Voicemail = null)
		{
			this.TransferType = TransferType;
			this.KeepInternalMessageAlive = KeepInternalMessageAlive;
			this.UserId = UserId;
			this.Address = Address;
			this.UserName = UserName;
			this.QueueId = QueueId;
			this.Voicemail = Voicemail;

		}





		/// <summary>
		/// If true, the digital internal message will NOT be terminated.
		/// </summary>
		/// <value>If true, the digital internal message will NOT be terminated.</value>
		[DataMember(Name = "keepInternalMessageAlive", EmitDefaultValue = false)]
		public bool? KeepInternalMessageAlive { get; set; }



		/// <summary>
		/// The user ID of the transfer target.
		/// </summary>
		/// <value>The user ID of the transfer target.</value>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }



		/// <summary>
		/// The user ID or queue ID of the transfer target. Address like a phone number can not be used for callbacks, but they can be used for other forms of communication.
		/// </summary>
		/// <value>The user ID or queue ID of the transfer target. Address like a phone number can not be used for callbacks, but they can be used for other forms of communication.</value>
		[DataMember(Name = "address", EmitDefaultValue = false)]
		public string Address { get; set; }



		/// <summary>
		/// The user name of the transfer target.
		/// </summary>
		/// <value>The user name of the transfer target.</value>
		[DataMember(Name = "userName", EmitDefaultValue = false)]
		public string UserName { get; set; }



		/// <summary>
		/// The queue ID of the transfer target.
		/// </summary>
		/// <value>The queue ID of the transfer target.</value>
		[DataMember(Name = "queueId", EmitDefaultValue = false)]
		public string QueueId { get; set; }



		/// <summary>
		/// If true, transfer to the voicemail inbox of the participant that is being replaced.
		/// </summary>
		/// <value>If true, transfer to the voicemail inbox of the participant that is being replaced.</value>
		[DataMember(Name = "voicemail", EmitDefaultValue = false)]
		public bool? Voicemail { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TransferRequest {\n");

			sb.Append("  TransferType: ").Append(TransferType).Append("\n");
			sb.Append("  KeepInternalMessageAlive: ").Append(KeepInternalMessageAlive).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  Address: ").Append(Address).Append("\n");
			sb.Append("  UserName: ").Append(UserName).Append("\n");
			sb.Append("  QueueId: ").Append(QueueId).Append("\n");
			sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
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
			return this.Equals(obj as TransferRequest);
		}

		/// <summary>
		/// Returns true if TransferRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of TransferRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TransferRequest other)
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
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
				) &&
				(
					this.Address == other.Address ||
					this.Address != null &&
					this.Address.Equals(other.Address)
				) &&
				(
					this.UserName == other.UserName ||
					this.UserName != null &&
					this.UserName.Equals(other.UserName)
				) &&
				(
					this.QueueId == other.QueueId ||
					this.QueueId != null &&
					this.QueueId.Equals(other.QueueId)
				) &&
				(
					this.Voicemail == other.Voicemail ||
					this.Voicemail != null &&
					this.Voicemail.Equals(other.Voicemail)
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

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				if (this.Address != null)
					hash = hash * 59 + this.Address.GetHashCode();

				if (this.UserName != null)
					hash = hash * 59 + this.UserName.GetHashCode();

				if (this.QueueId != null)
					hash = hash * 59 + this.QueueId.GetHashCode();

				if (this.Voicemail != null)
					hash = hash * 59 + this.Voicemail.GetHashCode();

				return hash;
			}
		}
	}

}
