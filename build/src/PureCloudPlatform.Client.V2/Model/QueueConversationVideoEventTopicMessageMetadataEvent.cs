using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// QueueConversationVideoEventTopicMessageMetadataEvent
	/// </summary>
	[DataContract]
	public partial class QueueConversationVideoEventTopicMessageMetadataEvent : IEquatable<QueueConversationVideoEventTopicMessageMetadataEvent>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicMessageMetadataEvent" /> class.
		/// </summary>
		/// <param name="EventType">Type of this event element..</param>
		/// <param name="SubType">Event subtype, if any.</param>
		public QueueConversationVideoEventTopicMessageMetadataEvent(string EventType = null, string SubType = null)
		{
			this.EventType = EventType;
			this.SubType = SubType;

		}



		/// <summary>
		/// Type of this event element.
		/// </summary>
		/// <value>Type of this event element.</value>
		[DataMember(Name = "eventType", EmitDefaultValue = false)]
		public string EventType { get; set; }



		/// <summary>
		/// Event subtype, if any
		/// </summary>
		/// <value>Event subtype, if any</value>
		[DataMember(Name = "subType", EmitDefaultValue = false)]
		public string SubType { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QueueConversationVideoEventTopicMessageMetadataEvent {\n");

			sb.Append("  EventType: ").Append(EventType).Append("\n");
			sb.Append("  SubType: ").Append(SubType).Append("\n");
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
			return this.Equals(obj as QueueConversationVideoEventTopicMessageMetadataEvent);
		}

		/// <summary>
		/// Returns true if QueueConversationVideoEventTopicMessageMetadataEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of QueueConversationVideoEventTopicMessageMetadataEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(QueueConversationVideoEventTopicMessageMetadataEvent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EventType == other.EventType ||
					this.EventType != null &&
					this.EventType.Equals(other.EventType)
				) &&
				(
					this.SubType == other.SubType ||
					this.SubType != null &&
					this.SubType.Equals(other.SubType)
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
				if (this.EventType != null)
					hash = hash * 59 + this.EventType.GetHashCode();

				if (this.SubType != null)
					hash = hash * 59 + this.SubType.GetHashCode();

				return hash;
			}
		}
	}

}
