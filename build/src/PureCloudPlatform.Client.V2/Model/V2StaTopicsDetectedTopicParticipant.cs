using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2StaTopicsDetectedTopicParticipant
	/// </summary>
	[DataContract]
	public partial class V2StaTopicsDetectedTopicParticipant : IEquatable<V2StaTopicsDetectedTopicParticipant>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2StaTopicsDetectedTopicParticipant" /> class.
		/// </summary>
		/// <param name="UserId">UserId.</param>
		/// <param name="QueueId">QueueId.</param>
		/// <param name="DivisionId">DivisionId.</param>
		/// <param name="Purpose">Purpose.</param>
		/// <param name="FlowId">FlowId.</param>
		public V2StaTopicsDetectedTopicParticipant(string UserId = null, string QueueId = null, string DivisionId = null, string Purpose = null, string FlowId = null)
		{
			this.UserId = UserId;
			this.QueueId = QueueId;
			this.DivisionId = DivisionId;
			this.Purpose = Purpose;
			this.FlowId = FlowId;

		}



		/// <summary>
		/// Gets or Sets UserId
		/// </summary>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }



		/// <summary>
		/// Gets or Sets QueueId
		/// </summary>
		[DataMember(Name = "queueId", EmitDefaultValue = false)]
		public string QueueId { get; set; }



		/// <summary>
		/// Gets or Sets DivisionId
		/// </summary>
		[DataMember(Name = "divisionId", EmitDefaultValue = false)]
		public string DivisionId { get; set; }



		/// <summary>
		/// Gets or Sets Purpose
		/// </summary>
		[DataMember(Name = "purpose", EmitDefaultValue = false)]
		public string Purpose { get; set; }



		/// <summary>
		/// Gets or Sets FlowId
		/// </summary>
		[DataMember(Name = "flowId", EmitDefaultValue = false)]
		public string FlowId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2StaTopicsDetectedTopicParticipant {\n");

			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  QueueId: ").Append(QueueId).Append("\n");
			sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
			sb.Append("  Purpose: ").Append(Purpose).Append("\n");
			sb.Append("  FlowId: ").Append(FlowId).Append("\n");
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
			return this.Equals(obj as V2StaTopicsDetectedTopicParticipant);
		}

		/// <summary>
		/// Returns true if V2StaTopicsDetectedTopicParticipant instances are equal
		/// </summary>
		/// <param name="other">Instance of V2StaTopicsDetectedTopicParticipant to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2StaTopicsDetectedTopicParticipant other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
				) &&
				(
					this.QueueId == other.QueueId ||
					this.QueueId != null &&
					this.QueueId.Equals(other.QueueId)
				) &&
				(
					this.DivisionId == other.DivisionId ||
					this.DivisionId != null &&
					this.DivisionId.Equals(other.DivisionId)
				) &&
				(
					this.Purpose == other.Purpose ||
					this.Purpose != null &&
					this.Purpose.Equals(other.Purpose)
				) &&
				(
					this.FlowId == other.FlowId ||
					this.FlowId != null &&
					this.FlowId.Equals(other.FlowId)
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

				if (this.QueueId != null)
					hash = hash * 59 + this.QueueId.GetHashCode();

				if (this.DivisionId != null)
					hash = hash * 59 + this.DivisionId.GetHashCode();

				if (this.Purpose != null)
					hash = hash * 59 + this.Purpose.GetHashCode();

				if (this.FlowId != null)
					hash = hash * 59 + this.FlowId.GetHashCode();

				return hash;
			}
		}
	}

}
