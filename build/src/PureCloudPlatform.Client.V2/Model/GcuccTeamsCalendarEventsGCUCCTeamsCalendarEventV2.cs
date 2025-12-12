using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// GcuccTeamsCalendarEventsGCUCCTeamsCalendarEventV2
	/// </summary>
	[DataContract]
	public partial class GcuccTeamsCalendarEventsGCUCCTeamsCalendarEventV2 : IEquatable<GcuccTeamsCalendarEventsGCUCCTeamsCalendarEventV2>
	{
		/// <summary>
		/// Gets or Sets Trigger
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TriggerEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Eventstart for "EventStart"
			/// </summary>
			[EnumMember(Value = "EventStart")]
			Eventstart,

			/// <summary>
			/// Enum Eventend for "EventEnd"
			/// </summary>
			[EnumMember(Value = "EventEnd")]
			Eventend
		}
		/// <summary>
		/// Gets or Sets EventType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum EventTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Calendar for "Calendar"
			/// </summary>
			[EnumMember(Value = "Calendar")]
			Calendar,

			/// <summary>
			/// Enum Instantmeeting for "InstantMeeting"
			/// </summary>
			[EnumMember(Value = "InstantMeeting")]
			Instantmeeting
		}
		/// <summary>
		/// Gets or Sets ResponseStatus
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ResponseStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "unknown"
			/// </summary>
			[EnumMember(Value = "unknown")]
			Unknown,

			/// <summary>
			/// Enum None for "none"
			/// </summary>
			[EnumMember(Value = "none")]
			None,

			/// <summary>
			/// Enum Organizer for "organizer"
			/// </summary>
			[EnumMember(Value = "organizer")]
			Organizer,

			/// <summary>
			/// Enum Tentativelyaccepted for "tentativelyAccepted"
			/// </summary>
			[EnumMember(Value = "tentativelyAccepted")]
			Tentativelyaccepted,

			/// <summary>
			/// Enum Accepted for "accepted"
			/// </summary>
			[EnumMember(Value = "accepted")]
			Accepted,

			/// <summary>
			/// Enum Declined for "declined"
			/// </summary>
			[EnumMember(Value = "declined")]
			Declined,

			/// <summary>
			/// Enum Notresponded for "notResponded"
			/// </summary>
			[EnumMember(Value = "notResponded")]
			Notresponded
		}
		/// <summary>
		/// Gets or Sets Trigger
		/// </summary>
		[DataMember(Name = "trigger", EmitDefaultValue = false)]
		public TriggerEnum? Trigger { get; set; }
		/// <summary>
		/// Gets or Sets EventType
		/// </summary>
		[DataMember(Name = "eventType", EmitDefaultValue = false)]
		public EventTypeEnum? EventType { get; set; }
		/// <summary>
		/// Gets or Sets ResponseStatus
		/// </summary>
		[DataMember(Name = "responseStatus", EmitDefaultValue = false)]
		public ResponseStatusEnum? ResponseStatus { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="GcuccTeamsCalendarEventsGCUCCTeamsCalendarEventV2" /> class.
		/// </summary>
		/// <param name="ExternalUserId">ExternalUserId.</param>
		/// <param name="GenesysUserId">GenesysUserId.</param>
		/// <param name="Trigger">Trigger.</param>
		/// <param name="EventType">EventType.</param>
		/// <param name="EventTime">EventTime.</param>
		/// <param name="ResponseStatus">ResponseStatus.</param>
		/// <param name="MeetingId">MeetingId.</param>
		public GcuccTeamsCalendarEventsGCUCCTeamsCalendarEventV2(Guid? ExternalUserId = null, Guid? GenesysUserId = null, TriggerEnum? Trigger = null, EventTypeEnum? EventType = null, DateTime? EventTime = null, ResponseStatusEnum? ResponseStatus = null, string MeetingId = null)
		{
			this.ExternalUserId = ExternalUserId;
			this.GenesysUserId = GenesysUserId;
			this.Trigger = Trigger;
			this.EventType = EventType;
			this.EventTime = EventTime;
			this.ResponseStatus = ResponseStatus;
			this.MeetingId = MeetingId;

		}



		/// <summary>
		/// Gets or Sets ExternalUserId
		/// </summary>
		[DataMember(Name = "externalUserId", EmitDefaultValue = false)]
		public Guid? ExternalUserId { get; set; }



		/// <summary>
		/// Gets or Sets GenesysUserId
		/// </summary>
		[DataMember(Name = "genesysUserId", EmitDefaultValue = false)]
		public Guid? GenesysUserId { get; set; }







		/// <summary>
		/// Gets or Sets EventTime
		/// </summary>
		[DataMember(Name = "eventTime", EmitDefaultValue = false)]
		public DateTime? EventTime { get; set; }





		/// <summary>
		/// Gets or Sets MeetingId
		/// </summary>
		[DataMember(Name = "meetingId", EmitDefaultValue = false)]
		public string MeetingId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GcuccTeamsCalendarEventsGCUCCTeamsCalendarEventV2 {\n");

			sb.Append("  ExternalUserId: ").Append(ExternalUserId).Append("\n");
			sb.Append("  GenesysUserId: ").Append(GenesysUserId).Append("\n");
			sb.Append("  Trigger: ").Append(Trigger).Append("\n");
			sb.Append("  EventType: ").Append(EventType).Append("\n");
			sb.Append("  EventTime: ").Append(EventTime).Append("\n");
			sb.Append("  ResponseStatus: ").Append(ResponseStatus).Append("\n");
			sb.Append("  MeetingId: ").Append(MeetingId).Append("\n");
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
			return this.Equals(obj as GcuccTeamsCalendarEventsGCUCCTeamsCalendarEventV2);
		}

		/// <summary>
		/// Returns true if GcuccTeamsCalendarEventsGCUCCTeamsCalendarEventV2 instances are equal
		/// </summary>
		/// <param name="other">Instance of GcuccTeamsCalendarEventsGCUCCTeamsCalendarEventV2 to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GcuccTeamsCalendarEventsGCUCCTeamsCalendarEventV2 other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ExternalUserId == other.ExternalUserId ||
					this.ExternalUserId != null &&
					this.ExternalUserId.Equals(other.ExternalUserId)
				) &&
				(
					this.GenesysUserId == other.GenesysUserId ||
					this.GenesysUserId != null &&
					this.GenesysUserId.Equals(other.GenesysUserId)
				) &&
				(
					this.Trigger == other.Trigger ||
					this.Trigger != null &&
					this.Trigger.Equals(other.Trigger)
				) &&
				(
					this.EventType == other.EventType ||
					this.EventType != null &&
					this.EventType.Equals(other.EventType)
				) &&
				(
					this.EventTime == other.EventTime ||
					this.EventTime != null &&
					this.EventTime.Equals(other.EventTime)
				) &&
				(
					this.ResponseStatus == other.ResponseStatus ||
					this.ResponseStatus != null &&
					this.ResponseStatus.Equals(other.ResponseStatus)
				) &&
				(
					this.MeetingId == other.MeetingId ||
					this.MeetingId != null &&
					this.MeetingId.Equals(other.MeetingId)
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
				if (this.ExternalUserId != null)
					hash = hash * 59 + this.ExternalUserId.GetHashCode();

				if (this.GenesysUserId != null)
					hash = hash * 59 + this.GenesysUserId.GetHashCode();

				if (this.Trigger != null)
					hash = hash * 59 + this.Trigger.GetHashCode();

				if (this.EventType != null)
					hash = hash * 59 + this.EventType.GetHashCode();

				if (this.EventTime != null)
					hash = hash * 59 + this.EventTime.GetHashCode();

				if (this.ResponseStatus != null)
					hash = hash * 59 + this.ResponseStatus.GetHashCode();

				if (this.MeetingId != null)
					hash = hash * 59 + this.MeetingId.GetHashCode();

				return hash;
			}
		}
	}

}
