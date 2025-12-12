using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WemCoachingUserNotificationTopicCoachingUserNotification
	/// </summary>
	[DataContract]
	public partial class WemCoachingUserNotificationTopicCoachingUserNotification : IEquatable<WemCoachingUserNotificationTopicCoachingUserNotification>
	{
		/// <summary>
		/// Gets or Sets ActionType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActionTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Create for "Create"
			/// </summary>
			[EnumMember(Value = "Create")]
			Create,

			/// <summary>
			/// Enum Update for "Update"
			/// </summary>
			[EnumMember(Value = "Update")]
			Update,

			/// <summary>
			/// Enum Delete for "Delete"
			/// </summary>
			[EnumMember(Value = "Delete")]
			Delete,

			/// <summary>
			/// Enum Statuschange for "StatusChange"
			/// </summary>
			[EnumMember(Value = "StatusChange")]
			Statuschange
		}
		/// <summary>
		/// Gets or Sets Relationship
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum RelationshipEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Attendee for "Attendee"
			/// </summary>
			[EnumMember(Value = "Attendee")]
			Attendee,

			/// <summary>
			/// Enum Facilitator for "Facilitator"
			/// </summary>
			[EnumMember(Value = "Facilitator")]
			Facilitator,

			/// <summary>
			/// Enum Creator for "Creator"
			/// </summary>
			[EnumMember(Value = "Creator")]
			Creator
		}
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Scheduled for "Scheduled"
			/// </summary>
			[EnumMember(Value = "Scheduled")]
			Scheduled,

			/// <summary>
			/// Enum Inprogress for "InProgress"
			/// </summary>
			[EnumMember(Value = "InProgress")]
			Inprogress,

			/// <summary>
			/// Enum Completed for "Completed"
			/// </summary>
			[EnumMember(Value = "Completed")]
			Completed,

			/// <summary>
			/// Enum Invalidschedule for "InvalidSchedule"
			/// </summary>
			[EnumMember(Value = "InvalidSchedule")]
			Invalidschedule
		}
		/// <summary>
		/// Gets or Sets ActionType
		/// </summary>
		[DataMember(Name = "actionType", EmitDefaultValue = false)]
		public ActionTypeEnum? ActionType { get; set; }
		/// <summary>
		/// Gets or Sets Relationship
		/// </summary>
		[DataMember(Name = "relationship", EmitDefaultValue = false)]
		public RelationshipEnum? Relationship { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WemCoachingUserNotificationTopicCoachingUserNotification" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Name">Name.</param>
		/// <param name="MarkedAsRead">MarkedAsRead.</param>
		/// <param name="ActionType">ActionType.</param>
		/// <param name="Relationship">Relationship.</param>
		/// <param name="Appointment">Appointment.</param>
		/// <param name="DateStart">DateStart.</param>
		/// <param name="LengthInMinutes">LengthInMinutes.</param>
		/// <param name="Status">Status.</param>
		public WemCoachingUserNotificationTopicCoachingUserNotification(string Id = null, string Name = null, bool? MarkedAsRead = null, ActionTypeEnum? ActionType = null, RelationshipEnum? Relationship = null, WemCoachingUserNotificationTopicCoachingAppointmentReference Appointment = null, DateTime? DateStart = null, long? LengthInMinutes = null, StatusEnum? Status = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.MarkedAsRead = MarkedAsRead;
			this.ActionType = ActionType;
			this.Relationship = Relationship;
			this.Appointment = Appointment;
			this.DateStart = DateStart;
			this.LengthInMinutes = LengthInMinutes;
			this.Status = Status;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets MarkedAsRead
		/// </summary>
		[DataMember(Name = "markedAsRead", EmitDefaultValue = false)]
		public bool? MarkedAsRead { get; set; }







		/// <summary>
		/// Gets or Sets Appointment
		/// </summary>
		[DataMember(Name = "appointment", EmitDefaultValue = false)]
		public WemCoachingUserNotificationTopicCoachingAppointmentReference Appointment { get; set; }



		/// <summary>
		/// Gets or Sets DateStart
		/// </summary>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public DateTime? DateStart { get; set; }



		/// <summary>
		/// Gets or Sets LengthInMinutes
		/// </summary>
		[DataMember(Name = "lengthInMinutes", EmitDefaultValue = false)]
		public long? LengthInMinutes { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WemCoachingUserNotificationTopicCoachingUserNotification {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  MarkedAsRead: ").Append(MarkedAsRead).Append("\n");
			sb.Append("  ActionType: ").Append(ActionType).Append("\n");
			sb.Append("  Relationship: ").Append(Relationship).Append("\n");
			sb.Append("  Appointment: ").Append(Appointment).Append("\n");
			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
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
			return this.Equals(obj as WemCoachingUserNotificationTopicCoachingUserNotification);
		}

		/// <summary>
		/// Returns true if WemCoachingUserNotificationTopicCoachingUserNotification instances are equal
		/// </summary>
		/// <param name="other">Instance of WemCoachingUserNotificationTopicCoachingUserNotification to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WemCoachingUserNotificationTopicCoachingUserNotification other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.MarkedAsRead == other.MarkedAsRead ||
					this.MarkedAsRead != null &&
					this.MarkedAsRead.Equals(other.MarkedAsRead)
				) &&
				(
					this.ActionType == other.ActionType ||
					this.ActionType != null &&
					this.ActionType.Equals(other.ActionType)
				) &&
				(
					this.Relationship == other.Relationship ||
					this.Relationship != null &&
					this.Relationship.Equals(other.Relationship)
				) &&
				(
					this.Appointment == other.Appointment ||
					this.Appointment != null &&
					this.Appointment.Equals(other.Appointment)
				) &&
				(
					this.DateStart == other.DateStart ||
					this.DateStart != null &&
					this.DateStart.Equals(other.DateStart)
				) &&
				(
					this.LengthInMinutes == other.LengthInMinutes ||
					this.LengthInMinutes != null &&
					this.LengthInMinutes.Equals(other.LengthInMinutes)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.MarkedAsRead != null)
					hash = hash * 59 + this.MarkedAsRead.GetHashCode();

				if (this.ActionType != null)
					hash = hash * 59 + this.ActionType.GetHashCode();

				if (this.Relationship != null)
					hash = hash * 59 + this.Relationship.GetHashCode();

				if (this.Appointment != null)
					hash = hash * 59 + this.Appointment.GetHashCode();

				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.LengthInMinutes != null)
					hash = hash * 59 + this.LengthInMinutes.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				return hash;
			}
		}
	}

}
