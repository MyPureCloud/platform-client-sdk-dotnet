using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConsultTransferToQueue
	/// </summary>
	[DataContract]
	public partial class ConsultTransferToQueue : IEquatable<ConsultTransferToQueue>
	{
		/// <summary>
		/// Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION
		/// </summary>
		/// <value>Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SpeakToEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Destination for "DESTINATION"
			/// </summary>
			[EnumMember(Value = "DESTINATION")]
			Destination,

			/// <summary>
			/// Enum Object for "OBJECT"
			/// </summary>
			[EnumMember(Value = "OBJECT")]
			Object,

			/// <summary>
			/// Enum Both for "BOTH"
			/// </summary>
			[EnumMember(Value = "BOTH")]
			Both,

			/// <summary>
			/// Enum Conference for "CONFERENCE"
			/// </summary>
			[EnumMember(Value = "CONFERENCE")]
			Conference
		}
		/// <summary>
		/// Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION
		/// </summary>
		/// <value>Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION</value>
		[DataMember(Name = "speakTo", EmitDefaultValue = false)]
		public SpeakToEnum? SpeakTo { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConsultTransferToQueue" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConsultTransferToQueue() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConsultTransferToQueue" /> class.
		/// </summary>
		/// <param name="SpeakTo">Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION (required).</param>
		/// <param name="ConsultingUserId">The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID.</param>
		/// <param name="QueueId">The id of the queue..</param>
		/// <param name="QueueName">The name of the queue..</param>
		public ConsultTransferToQueue(SpeakToEnum? SpeakTo = null, string ConsultingUserId = null, string QueueId = null, string QueueName = null)
		{
			this.SpeakTo = SpeakTo;
			this.ConsultingUserId = ConsultingUserId;
			this.QueueId = QueueId;
			this.QueueName = QueueName;

		}





		/// <summary>
		/// The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID
		/// </summary>
		/// <value>The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID</value>
		[DataMember(Name = "consultingUserId", EmitDefaultValue = false)]
		public string ConsultingUserId { get; set; }



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
			sb.Append("class ConsultTransferToQueue {\n");

			sb.Append("  SpeakTo: ").Append(SpeakTo).Append("\n");
			sb.Append("  ConsultingUserId: ").Append(ConsultingUserId).Append("\n");
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
			return this.Equals(obj as ConsultTransferToQueue);
		}

		/// <summary>
		/// Returns true if ConsultTransferToQueue instances are equal
		/// </summary>
		/// <param name="other">Instance of ConsultTransferToQueue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConsultTransferToQueue other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SpeakTo == other.SpeakTo ||
					this.SpeakTo != null &&
					this.SpeakTo.Equals(other.SpeakTo)
				) &&
				(
					this.ConsultingUserId == other.ConsultingUserId ||
					this.ConsultingUserId != null &&
					this.ConsultingUserId.Equals(other.ConsultingUserId)
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
				if (this.SpeakTo != null)
					hash = hash * 59 + this.SpeakTo.GetHashCode();

				if (this.ConsultingUserId != null)
					hash = hash * 59 + this.ConsultingUserId.GetHashCode();

				if (this.QueueId != null)
					hash = hash * 59 + this.QueueId.GetHashCode();

				if (this.QueueName != null)
					hash = hash * 59 + this.QueueName.GetHashCode();

				return hash;
			}
		}
	}

}
