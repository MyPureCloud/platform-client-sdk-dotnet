using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserPresenceEvent
	/// </summary>
	[DataContract]
	public partial class UserPresenceEvent : IEquatable<UserPresenceEvent>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UserPresenceEvent" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UserPresenceEvent() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UserPresenceEvent" /> class.
		/// </summary>
		/// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
		/// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="UserId">The User ID of the user associated with this UserPresence (required).</param>
		/// <param name="SourceId">The id (V4 UUID) of the presence source being updated (required).</param>
		/// <param name="PresenceDefinitionId">The id (UUID) of the presence definition that the user presence is associated with.</param>
		/// <param name="Message">The message associated with the presence.</param>
		public UserPresenceEvent(string EventId = null, DateTime? EventDateTime = null, string UserId = null, string SourceId = null, string PresenceDefinitionId = null, string Message = null)
		{
			this.EventId = EventId;
			this.EventDateTime = EventDateTime;
			this.UserId = UserId;
			this.SourceId = SourceId;
			this.PresenceDefinitionId = PresenceDefinitionId;
			this.Message = Message;

		}



		/// <summary>
		/// A unique (V4 UUID) eventId for this event
		/// </summary>
		/// <value>A unique (V4 UUID) eventId for this event</value>
		[DataMember(Name = "eventId", EmitDefaultValue = false)]
		public string EventId { get; set; }



		/// <summary>
		/// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "eventDateTime", EmitDefaultValue = false)]
		public DateTime? EventDateTime { get; set; }



		/// <summary>
		/// The User ID of the user associated with this UserPresence
		/// </summary>
		/// <value>The User ID of the user associated with this UserPresence</value>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }



		/// <summary>
		/// The id (V4 UUID) of the presence source being updated
		/// </summary>
		/// <value>The id (V4 UUID) of the presence source being updated</value>
		[DataMember(Name = "sourceId", EmitDefaultValue = false)]
		public string SourceId { get; set; }



		/// <summary>
		/// The id (UUID) of the presence definition that the user presence is associated with
		/// </summary>
		/// <value>The id (UUID) of the presence definition that the user presence is associated with</value>
		[DataMember(Name = "presenceDefinitionId", EmitDefaultValue = false)]
		public string PresenceDefinitionId { get; set; }



		/// <summary>
		/// The message associated with the presence
		/// </summary>
		/// <value>The message associated with the presence</value>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserPresenceEvent {\n");

			sb.Append("  EventId: ").Append(EventId).Append("\n");
			sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  SourceId: ").Append(SourceId).Append("\n");
			sb.Append("  PresenceDefinitionId: ").Append(PresenceDefinitionId).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
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
			return this.Equals(obj as UserPresenceEvent);
		}

		/// <summary>
		/// Returns true if UserPresenceEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of UserPresenceEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserPresenceEvent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EventId == other.EventId ||
					this.EventId != null &&
					this.EventId.Equals(other.EventId)
				) &&
				(
					this.EventDateTime == other.EventDateTime ||
					this.EventDateTime != null &&
					this.EventDateTime.Equals(other.EventDateTime)
				) &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
				) &&
				(
					this.SourceId == other.SourceId ||
					this.SourceId != null &&
					this.SourceId.Equals(other.SourceId)
				) &&
				(
					this.PresenceDefinitionId == other.PresenceDefinitionId ||
					this.PresenceDefinitionId != null &&
					this.PresenceDefinitionId.Equals(other.PresenceDefinitionId)
				) &&
				(
					this.Message == other.Message ||
					this.Message != null &&
					this.Message.Equals(other.Message)
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
				if (this.EventId != null)
					hash = hash * 59 + this.EventId.GetHashCode();

				if (this.EventDateTime != null)
					hash = hash * 59 + this.EventDateTime.GetHashCode();

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				if (this.SourceId != null)
					hash = hash * 59 + this.SourceId.GetHashCode();

				if (this.PresenceDefinitionId != null)
					hash = hash * 59 + this.PresenceDefinitionId.GetHashCode();

				if (this.Message != null)
					hash = hash * 59 + this.Message.GetHashCode();

				return hash;
			}
		}
	}

}
