using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Fields identifying the initiator of a given conversation command.
	/// </summary>
	[DataContract]
	public partial class QueueConversationVideoEventTopicTransferInitiator : IEquatable<QueueConversationVideoEventTopicTransferInitiator>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicTransferInitiator" /> class.
		/// </summary>
		/// <param name="UserId">The id of the user who initiated the command if it was initiated by a user..</param>
		public QueueConversationVideoEventTopicTransferInitiator(string UserId = null)
		{
			this.UserId = UserId;

		}



		/// <summary>
		/// The id of the user who initiated the command if it was initiated by a user.
		/// </summary>
		/// <value>The id of the user who initiated the command if it was initiated by a user.</value>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QueueConversationVideoEventTopicTransferInitiator {\n");

			sb.Append("  UserId: ").Append(UserId).Append("\n");
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
			return this.Equals(obj as QueueConversationVideoEventTopicTransferInitiator);
		}

		/// <summary>
		/// Returns true if QueueConversationVideoEventTopicTransferInitiator instances are equal
		/// </summary>
		/// <param name="other">Instance of QueueConversationVideoEventTopicTransferInitiator to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(QueueConversationVideoEventTopicTransferInitiator other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
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
				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				return hash;
			}
		}
	}

}
