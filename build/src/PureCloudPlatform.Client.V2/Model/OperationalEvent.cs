using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OperationalEvent
	/// </summary>
	[DataContract]
	public partial class OperationalEvent : IEquatable<OperationalEvent>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OperationalEvent" /> class.
		/// </summary>
		/// <param name="EventDefinition">The event that occurred..</param>
		/// <param name="EntityId">The unique identifier for the entity.</param>
		/// <param name="EntityToken">A token representing the entity.</param>
		/// <param name="EntityName">The name for the entity.</param>
		/// <param name="PreviousValue">The value prior to the event.</param>
		/// <param name="CurrentValue">The changed value following the event.</param>
		/// <param name="ErrorCode">The error code of the entity in the providing service associated to the event.</param>
		/// <param name="ParentEntityId">The unique identifier for the parent of the entity.</param>
		/// <param name="Conversation">The link to a conversation.</param>
		/// <param name="DateCreated">The date when the event created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="EntityVersion">The version of the entity in the providing service.</param>
		public OperationalEvent(AddressableEntityRef EventDefinition = null, string EntityId = null, string EntityToken = null, string EntityName = null, string PreviousValue = null, string CurrentValue = null, string ErrorCode = null, string ParentEntityId = null, AddressableEntityRef Conversation = null, DateTime? DateCreated = null, string EntityVersion = null)
		{
			this.EventDefinition = EventDefinition;
			this.EntityId = EntityId;
			this.EntityToken = EntityToken;
			this.EntityName = EntityName;
			this.PreviousValue = PreviousValue;
			this.CurrentValue = CurrentValue;
			this.ErrorCode = ErrorCode;
			this.ParentEntityId = ParentEntityId;
			this.Conversation = Conversation;
			this.DateCreated = DateCreated;
			this.EntityVersion = EntityVersion;

		}



		/// <summary>
		/// The event that occurred.
		/// </summary>
		/// <value>The event that occurred.</value>
		[DataMember(Name = "eventDefinition", EmitDefaultValue = false)]
		public AddressableEntityRef EventDefinition { get; set; }



		/// <summary>
		/// The unique identifier for the entity
		/// </summary>
		/// <value>The unique identifier for the entity</value>
		[DataMember(Name = "entityId", EmitDefaultValue = false)]
		public string EntityId { get; set; }



		/// <summary>
		/// A token representing the entity
		/// </summary>
		/// <value>A token representing the entity</value>
		[DataMember(Name = "entityToken", EmitDefaultValue = false)]
		public string EntityToken { get; set; }



		/// <summary>
		/// The name for the entity
		/// </summary>
		/// <value>The name for the entity</value>
		[DataMember(Name = "entityName", EmitDefaultValue = false)]
		public string EntityName { get; set; }



		/// <summary>
		/// The value prior to the event
		/// </summary>
		/// <value>The value prior to the event</value>
		[DataMember(Name = "previousValue", EmitDefaultValue = false)]
		public string PreviousValue { get; set; }



		/// <summary>
		/// The changed value following the event
		/// </summary>
		/// <value>The changed value following the event</value>
		[DataMember(Name = "currentValue", EmitDefaultValue = false)]
		public string CurrentValue { get; set; }



		/// <summary>
		/// The error code of the entity in the providing service associated to the event
		/// </summary>
		/// <value>The error code of the entity in the providing service associated to the event</value>
		[DataMember(Name = "errorCode", EmitDefaultValue = false)]
		public string ErrorCode { get; set; }



		/// <summary>
		/// The unique identifier for the parent of the entity
		/// </summary>
		/// <value>The unique identifier for the parent of the entity</value>
		[DataMember(Name = "parentEntityId", EmitDefaultValue = false)]
		public string ParentEntityId { get; set; }



		/// <summary>
		/// The link to a conversation
		/// </summary>
		/// <value>The link to a conversation</value>
		[DataMember(Name = "conversation", EmitDefaultValue = false)]
		public AddressableEntityRef Conversation { get; set; }



		/// <summary>
		/// The date when the event created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date when the event created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// The version of the entity in the providing service
		/// </summary>
		/// <value>The version of the entity in the providing service</value>
		[DataMember(Name = "entityVersion", EmitDefaultValue = false)]
		public string EntityVersion { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OperationalEvent {\n");

			sb.Append("  EventDefinition: ").Append(EventDefinition).Append("\n");
			sb.Append("  EntityId: ").Append(EntityId).Append("\n");
			sb.Append("  EntityToken: ").Append(EntityToken).Append("\n");
			sb.Append("  EntityName: ").Append(EntityName).Append("\n");
			sb.Append("  PreviousValue: ").Append(PreviousValue).Append("\n");
			sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
			sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
			sb.Append("  ParentEntityId: ").Append(ParentEntityId).Append("\n");
			sb.Append("  Conversation: ").Append(Conversation).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  EntityVersion: ").Append(EntityVersion).Append("\n");
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
			return this.Equals(obj as OperationalEvent);
		}

		/// <summary>
		/// Returns true if OperationalEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of OperationalEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OperationalEvent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EventDefinition == other.EventDefinition ||
					this.EventDefinition != null &&
					this.EventDefinition.Equals(other.EventDefinition)
				) &&
				(
					this.EntityId == other.EntityId ||
					this.EntityId != null &&
					this.EntityId.Equals(other.EntityId)
				) &&
				(
					this.EntityToken == other.EntityToken ||
					this.EntityToken != null &&
					this.EntityToken.Equals(other.EntityToken)
				) &&
				(
					this.EntityName == other.EntityName ||
					this.EntityName != null &&
					this.EntityName.Equals(other.EntityName)
				) &&
				(
					this.PreviousValue == other.PreviousValue ||
					this.PreviousValue != null &&
					this.PreviousValue.Equals(other.PreviousValue)
				) &&
				(
					this.CurrentValue == other.CurrentValue ||
					this.CurrentValue != null &&
					this.CurrentValue.Equals(other.CurrentValue)
				) &&
				(
					this.ErrorCode == other.ErrorCode ||
					this.ErrorCode != null &&
					this.ErrorCode.Equals(other.ErrorCode)
				) &&
				(
					this.ParentEntityId == other.ParentEntityId ||
					this.ParentEntityId != null &&
					this.ParentEntityId.Equals(other.ParentEntityId)
				) &&
				(
					this.Conversation == other.Conversation ||
					this.Conversation != null &&
					this.Conversation.Equals(other.Conversation)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.EntityVersion == other.EntityVersion ||
					this.EntityVersion != null &&
					this.EntityVersion.Equals(other.EntityVersion)
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
				if (this.EventDefinition != null)
					hash = hash * 59 + this.EventDefinition.GetHashCode();

				if (this.EntityId != null)
					hash = hash * 59 + this.EntityId.GetHashCode();

				if (this.EntityToken != null)
					hash = hash * 59 + this.EntityToken.GetHashCode();

				if (this.EntityName != null)
					hash = hash * 59 + this.EntityName.GetHashCode();

				if (this.PreviousValue != null)
					hash = hash * 59 + this.PreviousValue.GetHashCode();

				if (this.CurrentValue != null)
					hash = hash * 59 + this.CurrentValue.GetHashCode();

				if (this.ErrorCode != null)
					hash = hash * 59 + this.ErrorCode.GetHashCode();

				if (this.ParentEntityId != null)
					hash = hash * 59 + this.ParentEntityId.GetHashCode();

				if (this.Conversation != null)
					hash = hash * 59 + this.Conversation.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.EntityVersion != null)
					hash = hash * 59 + this.EntityVersion.GetHashCode();

				return hash;
			}
		}
	}

}
