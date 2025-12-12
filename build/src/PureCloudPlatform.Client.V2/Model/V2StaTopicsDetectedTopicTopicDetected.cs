using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2StaTopicsDetectedTopicTopicDetected
	/// </summary>
	[DataContract]
	public partial class V2StaTopicsDetectedTopicTopicDetected : IEquatable<V2StaTopicsDetectedTopicTopicDetected>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2StaTopicsDetectedTopicTopicDetected" /> class.
		/// </summary>
		/// <param name="Participant">Participant.</param>
		/// <param name="TopicId">TopicId.</param>
		/// <param name="TopicName">TopicName.</param>
		public V2StaTopicsDetectedTopicTopicDetected(string Participant = null, string TopicId = null, string TopicName = null)
		{
			this.Participant = Participant;
			this.TopicId = TopicId;
			this.TopicName = TopicName;

		}



		/// <summary>
		/// Gets or Sets Participant
		/// </summary>
		[DataMember(Name = "participant", EmitDefaultValue = false)]
		public string Participant { get; set; }



		/// <summary>
		/// Gets or Sets TopicId
		/// </summary>
		[DataMember(Name = "topicId", EmitDefaultValue = false)]
		public string TopicId { get; set; }



		/// <summary>
		/// Gets or Sets TopicName
		/// </summary>
		[DataMember(Name = "topicName", EmitDefaultValue = false)]
		public string TopicName { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2StaTopicsDetectedTopicTopicDetected {\n");

			sb.Append("  Participant: ").Append(Participant).Append("\n");
			sb.Append("  TopicId: ").Append(TopicId).Append("\n");
			sb.Append("  TopicName: ").Append(TopicName).Append("\n");
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
			return this.Equals(obj as V2StaTopicsDetectedTopicTopicDetected);
		}

		/// <summary>
		/// Returns true if V2StaTopicsDetectedTopicTopicDetected instances are equal
		/// </summary>
		/// <param name="other">Instance of V2StaTopicsDetectedTopicTopicDetected to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2StaTopicsDetectedTopicTopicDetected other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Participant == other.Participant ||
					this.Participant != null &&
					this.Participant.Equals(other.Participant)
				) &&
				(
					this.TopicId == other.TopicId ||
					this.TopicId != null &&
					this.TopicId.Equals(other.TopicId)
				) &&
				(
					this.TopicName == other.TopicName ||
					this.TopicName != null &&
					this.TopicName.Equals(other.TopicName)
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
				if (this.Participant != null)
					hash = hash * 59 + this.Participant.GetHashCode();

				if (this.TopicId != null)
					hash = hash * 59 + this.TopicId.GetHashCode();

				if (this.TopicName != null)
					hash = hash * 59 + this.TopicName.GetHashCode();

				return hash;
			}
		}
	}

}
