using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Development Activity object
	/// </summary>
	[DataContract]
	public partial class DevelopmentActivity : IEquatable<DevelopmentActivity>
	{
		/// <summary>
		/// Module archive type
		/// </summary>
		/// <value>Module archive type</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ArchivalModeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Graceful for "Graceful"
			/// </summary>
			[EnumMember(Value = "Graceful")]
			Graceful,

			/// <summary>
			/// Enum Immediate for "Immediate"
			/// </summary>
			[EnumMember(Value = "Immediate")]
			Immediate
		}
		/// <summary>
		/// The type of activity
		/// </summary>
		/// <value>The type of activity</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Informational for "Informational"
			/// </summary>
			[EnumMember(Value = "Informational")]
			Informational,

			/// <summary>
			/// Enum Coaching for "Coaching"
			/// </summary>
			[EnumMember(Value = "Coaching")]
			Coaching,

			/// <summary>
			/// Enum Assessedcontent for "AssessedContent"
			/// </summary>
			[EnumMember(Value = "AssessedContent")]
			Assessedcontent,

			/// <summary>
			/// Enum Assessment for "Assessment"
			/// </summary>
			[EnumMember(Value = "Assessment")]
			Assessment,

			/// <summary>
			/// Enum External for "External"
			/// </summary>
			[EnumMember(Value = "External")]
			External,

			/// <summary>
			/// Enum Native for "Native"
			/// </summary>
			[EnumMember(Value = "Native")]
			Native
		}
		/// <summary>
		/// The status of the activity
		/// </summary>
		/// <value>The status of the activity</value>
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
			/// Enum Planned for "Planned"
			/// </summary>
			[EnumMember(Value = "Planned")]
			Planned,

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
			Invalidschedule,

			/// <summary>
			/// Enum Notcompleted for "NotCompleted"
			/// </summary>
			[EnumMember(Value = "NotCompleted")]
			Notcompleted
		}
		/// <summary>
		/// Module archive type
		/// </summary>
		/// <value>Module archive type</value>
		[DataMember(Name = "archivalMode", EmitDefaultValue = false)]
		public ArchivalModeEnum? ArchivalMode { get; set; }
		/// <summary>
		/// The type of activity
		/// </summary>
		/// <value>The type of activity</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// The status of the activity
		/// </summary>
		/// <value>The status of the activity</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DevelopmentActivity" /> class.
		/// </summary>
		/// <param name="IsLatest">True if this is the latest version of assignment assigned to the user.</param>
		/// <param name="IsModuleArchived">True if the associated module is archived.</param>
		/// <param name="ArchivalMode">Module archive type.</param>
		/// <param name="Name">The name of the activity.</param>
		/// <param name="Type">The type of activity.</param>
		/// <param name="Status">The status of the activity.</param>
		/// <param name="DateDue">Due date for completion of the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Facilitator">Facilitator of the activity.</param>
		/// <param name="Attendees">List of users attending the activity.</param>
		/// <param name="IsOverdue">Indicates if the activity is overdue.</param>
		public DevelopmentActivity(bool? IsLatest = null, bool? IsModuleArchived = null, ArchivalModeEnum? ArchivalMode = null, string Name = null, TypeEnum? Type = null, StatusEnum? Status = null, DateTime? DateDue = null, UserReference Facilitator = null, List<UserReference> Attendees = null, bool? IsOverdue = null)
		{
			this.IsLatest = IsLatest;
			this.IsModuleArchived = IsModuleArchived;
			this.ArchivalMode = ArchivalMode;
			this.Name = Name;
			this.Type = Type;
			this.Status = Status;
			this.DateDue = DateDue;
			this.Facilitator = Facilitator;
			this.Attendees = Attendees;
			this.IsOverdue = IsOverdue;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Date that activity was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date that activity was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCompleted", EmitDefaultValue = false)]
		public DateTime? DateCompleted { get; private set; }



		/// <summary>
		/// User that created activity
		/// </summary>
		/// <value>User that created activity</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public UserReference CreatedBy { get; private set; }



		/// <summary>
		/// Date activity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date activity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// The user&#39;s percentage score for this activity
		/// </summary>
		/// <value>The user&#39;s percentage score for this activity</value>
		[DataMember(Name = "percentageScore", EmitDefaultValue = false)]
		public float? PercentageScore { get; private set; }



		/// <summary>
		/// True if the activity was passed
		/// </summary>
		/// <value>True if the activity was passed</value>
		[DataMember(Name = "isPassed", EmitDefaultValue = false)]
		public bool? IsPassed { get; private set; }



		/// <summary>
		/// True if this is the latest version of assignment assigned to the user
		/// </summary>
		/// <value>True if this is the latest version of assignment assigned to the user</value>
		[DataMember(Name = "isLatest", EmitDefaultValue = false)]
		public bool? IsLatest { get; set; }



		/// <summary>
		/// True if the associated module is archived
		/// </summary>
		/// <value>True if the associated module is archived</value>
		[DataMember(Name = "isModuleArchived", EmitDefaultValue = false)]
		public bool? IsModuleArchived { get; set; }





		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }



		/// <summary>
		/// The name of the activity
		/// </summary>
		/// <value>The name of the activity</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }







		/// <summary>
		/// Due date for completion of the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Due date for completion of the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateDue", EmitDefaultValue = false)]
		public DateTime? DateDue { get; set; }



		/// <summary>
		/// Facilitator of the activity
		/// </summary>
		/// <value>Facilitator of the activity</value>
		[DataMember(Name = "facilitator", EmitDefaultValue = false)]
		public UserReference Facilitator { get; set; }



		/// <summary>
		/// List of users attending the activity
		/// </summary>
		/// <value>List of users attending the activity</value>
		[DataMember(Name = "attendees", EmitDefaultValue = false)]
		public List<UserReference> Attendees { get; set; }



		/// <summary>
		/// Indicates if the activity is overdue
		/// </summary>
		/// <value>Indicates if the activity is overdue</value>
		[DataMember(Name = "isOverdue", EmitDefaultValue = false)]
		public bool? IsOverdue { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DevelopmentActivity {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
			sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
			sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
			sb.Append("  IsModuleArchived: ").Append(IsModuleArchived).Append("\n");
			sb.Append("  ArchivalMode: ").Append(ArchivalMode).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  DateDue: ").Append(DateDue).Append("\n");
			sb.Append("  Facilitator: ").Append(Facilitator).Append("\n");
			sb.Append("  Attendees: ").Append(Attendees).Append("\n");
			sb.Append("  IsOverdue: ").Append(IsOverdue).Append("\n");
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
			return this.Equals(obj as DevelopmentActivity);
		}

		/// <summary>
		/// Returns true if DevelopmentActivity instances are equal
		/// </summary>
		/// <param name="other">Instance of DevelopmentActivity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DevelopmentActivity other)
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
					this.DateCompleted == other.DateCompleted ||
					this.DateCompleted != null &&
					this.DateCompleted.Equals(other.DateCompleted)
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
					this.PercentageScore == other.PercentageScore ||
					this.PercentageScore != null &&
					this.PercentageScore.Equals(other.PercentageScore)
				) &&
				(
					this.IsPassed == other.IsPassed ||
					this.IsPassed != null &&
					this.IsPassed.Equals(other.IsPassed)
				) &&
				(
					this.IsLatest == other.IsLatest ||
					this.IsLatest != null &&
					this.IsLatest.Equals(other.IsLatest)
				) &&
				(
					this.IsModuleArchived == other.IsModuleArchived ||
					this.IsModuleArchived != null &&
					this.IsModuleArchived.Equals(other.IsModuleArchived)
				) &&
				(
					this.ArchivalMode == other.ArchivalMode ||
					this.ArchivalMode != null &&
					this.ArchivalMode.Equals(other.ArchivalMode)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.DateDue == other.DateDue ||
					this.DateDue != null &&
					this.DateDue.Equals(other.DateDue)
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
					this.IsOverdue == other.IsOverdue ||
					this.IsOverdue != null &&
					this.IsOverdue.Equals(other.IsOverdue)
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

				if (this.DateCompleted != null)
					hash = hash * 59 + this.DateCompleted.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.PercentageScore != null)
					hash = hash * 59 + this.PercentageScore.GetHashCode();

				if (this.IsPassed != null)
					hash = hash * 59 + this.IsPassed.GetHashCode();

				if (this.IsLatest != null)
					hash = hash * 59 + this.IsLatest.GetHashCode();

				if (this.IsModuleArchived != null)
					hash = hash * 59 + this.IsModuleArchived.GetHashCode();

				if (this.ArchivalMode != null)
					hash = hash * 59 + this.ArchivalMode.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.DateDue != null)
					hash = hash * 59 + this.DateDue.GetHashCode();

				if (this.Facilitator != null)
					hash = hash * 59 + this.Facilitator.GetHashCode();

				if (this.Attendees != null)
					hash = hash * 59 + this.Attendees.GetHashCode();

				if (this.IsOverdue != null)
					hash = hash * 59 + this.IsOverdue.GetHashCode();

				return hash;
			}
		}
	}

}
