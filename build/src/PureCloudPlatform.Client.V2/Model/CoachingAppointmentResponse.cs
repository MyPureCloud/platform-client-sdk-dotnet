using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Coaching appointment response
	/// </summary>
	[DataContract]
	public partial class CoachingAppointmentResponse : IEquatable<CoachingAppointmentResponse>
	{
		/// <summary>
		/// The status of coaching appointment
		/// </summary>
		/// <value>The status of coaching appointment</value>
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
		/// The status of coaching appointment
		/// </summary>
		/// <value>The status of coaching appointment</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="CoachingAppointmentResponse" /> class.
		/// </summary>
		public CoachingAppointmentResponse()
		{

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of coaching appointment
		/// </summary>
		/// <value>The name of coaching appointment</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; private set; }



		/// <summary>
		/// The description of coaching appointment
		/// </summary>
		/// <value>The description of coaching appointment</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; private set; }



		/// <summary>
		/// The date/time the coaching appointment starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date/time the coaching appointment starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public DateTime? DateStart { get; private set; }



		/// <summary>
		/// The duration of coaching appointment in minutes
		/// </summary>
		/// <value>The duration of coaching appointment in minutes</value>
		[DataMember(Name = "lengthInMinutes", EmitDefaultValue = false)]
		public int? LengthInMinutes { get; private set; }





		/// <summary>
		/// The facilitator of coaching appointment
		/// </summary>
		/// <value>The facilitator of coaching appointment</value>
		[DataMember(Name = "facilitator", EmitDefaultValue = false)]
		public UserReference Facilitator { get; private set; }



		/// <summary>
		/// The list of attendees attending the coaching
		/// </summary>
		/// <value>The list of attendees attending the coaching</value>
		[DataMember(Name = "attendees", EmitDefaultValue = false)]
		public List<UserReference> Attendees { get; private set; }



		/// <summary>
		/// The user who created the coaching appointment
		/// </summary>
		/// <value>The user who created the coaching appointment</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public UserReference CreatedBy { get; private set; }



		/// <summary>
		/// The date/time the coaching appointment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date/time the coaching appointment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// The last user to modify the coaching appointment
		/// </summary>
		/// <value>The last user to modify the coaching appointment</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public UserReference ModifiedBy { get; private set; }



		/// <summary>
		/// The date/time the coaching appointment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date/time the coaching appointment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



		/// <summary>
		/// The list of conversations associated with coaching appointment.
		/// </summary>
		/// <value>The list of conversations associated with coaching appointment.</value>
		[DataMember(Name = "conversations", EmitDefaultValue = false)]
		public List<ConversationReference> Conversations { get; private set; }



		/// <summary>
		/// The list of documents associated with coaching appointment.
		/// </summary>
		/// <value>The list of documents associated with coaching appointment.</value>
		[DataMember(Name = "documents", EmitDefaultValue = false)]
		public List<DocumentReference> Documents { get; private set; }



		/// <summary>
		/// Whether the appointment is overdue.
		/// </summary>
		/// <value>Whether the appointment is overdue.</value>
		[DataMember(Name = "isOverdue", EmitDefaultValue = false)]
		public bool? IsOverdue { get; private set; }



		/// <summary>
		/// The Workforce Management schedule the appointment is associated with.
		/// </summary>
		/// <value>The Workforce Management schedule the appointment is associated with.</value>
		[DataMember(Name = "wfmSchedule", EmitDefaultValue = false)]
		public WfmScheduleReference WfmSchedule { get; private set; }



		/// <summary>
		/// The date/time the coaching appointment was set to completed status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date/time the coaching appointment was set to completed status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCompleted", EmitDefaultValue = false)]
		public DateTime? DateCompleted { get; private set; }



		/// <summary>
		/// The list of external links related to the appointment
		/// </summary>
		/// <value>The list of external links related to the appointment</value>
		[DataMember(Name = "externalLinks", EmitDefaultValue = false)]
		public List<string> ExternalLinks { get; private set; }



		/// <summary>
		/// The location of the appointment
		/// </summary>
		/// <value>The location of the appointment</value>
		[DataMember(Name = "location", EmitDefaultValue = false)]
		public string Location { get; private set; }



		/// <summary>
		/// Whether to share the insight data
		/// </summary>
		/// <value>Whether to share the insight data</value>
		[DataMember(Name = "shareInsightsData", EmitDefaultValue = false)]
		public bool? ShareInsightsData { get; private set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CoachingAppointmentResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Facilitator: ").Append(Facilitator).Append("\n");
			sb.Append("  Attendees: ").Append(Attendees).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Conversations: ").Append(Conversations).Append("\n");
			sb.Append("  Documents: ").Append(Documents).Append("\n");
			sb.Append("  IsOverdue: ").Append(IsOverdue).Append("\n");
			sb.Append("  WfmSchedule: ").Append(WfmSchedule).Append("\n");
			sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
			sb.Append("  ExternalLinks: ").Append(ExternalLinks).Append("\n");
			sb.Append("  Location: ").Append(Location).Append("\n");
			sb.Append("  ShareInsightsData: ").Append(ShareInsightsData).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as CoachingAppointmentResponse);
		}

		/// <summary>
		/// Returns true if CoachingAppointmentResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of CoachingAppointmentResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CoachingAppointmentResponse other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
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
				) &&
				(
					this.Facilitator == other.Facilitator ||
					this.Facilitator != null &&
					this.Facilitator.Equals(other.Facilitator)
				) &&
				(
					this.Attendees == other.Attendees ||
					this.Attendees != null &&
					this.Attendees.SequenceEqual(other.Attendees)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.Conversations == other.Conversations ||
					this.Conversations != null &&
					this.Conversations.SequenceEqual(other.Conversations)
				) &&
				(
					this.Documents == other.Documents ||
					this.Documents != null &&
					this.Documents.SequenceEqual(other.Documents)
				) &&
				(
					this.IsOverdue == other.IsOverdue ||
					this.IsOverdue != null &&
					this.IsOverdue.Equals(other.IsOverdue)
				) &&
				(
					this.WfmSchedule == other.WfmSchedule ||
					this.WfmSchedule != null &&
					this.WfmSchedule.Equals(other.WfmSchedule)
				) &&
				(
					this.DateCompleted == other.DateCompleted ||
					this.DateCompleted != null &&
					this.DateCompleted.Equals(other.DateCompleted)
				) &&
				(
					this.ExternalLinks == other.ExternalLinks ||
					this.ExternalLinks != null &&
					this.ExternalLinks.SequenceEqual(other.ExternalLinks)
				) &&
				(
					this.Location == other.Location ||
					this.Location != null &&
					this.Location.Equals(other.Location)
				) &&
				(
					this.ShareInsightsData == other.ShareInsightsData ||
					this.ShareInsightsData != null &&
					this.ShareInsightsData.Equals(other.ShareInsightsData)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.LengthInMinutes != null)
					hash = hash * 59 + this.LengthInMinutes.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Facilitator != null)
					hash = hash * 59 + this.Facilitator.GetHashCode();

				if (this.Attendees != null)
					hash = hash * 59 + this.Attendees.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.Conversations != null)
					hash = hash * 59 + this.Conversations.GetHashCode();

				if (this.Documents != null)
					hash = hash * 59 + this.Documents.GetHashCode();

				if (this.IsOverdue != null)
					hash = hash * 59 + this.IsOverdue.GetHashCode();

				if (this.WfmSchedule != null)
					hash = hash * 59 + this.WfmSchedule.GetHashCode();

				if (this.DateCompleted != null)
					hash = hash * 59 + this.DateCompleted.GetHashCode();

				if (this.ExternalLinks != null)
					hash = hash * 59 + this.ExternalLinks.GetHashCode();

				if (this.Location != null)
					hash = hash * 59 + this.Location.GetHashCode();

				if (this.ShareInsightsData != null)
					hash = hash * 59 + this.ShareInsightsData.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
