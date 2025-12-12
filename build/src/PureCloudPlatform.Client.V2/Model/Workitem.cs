using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Workitem
	/// </summary>
	[DataContract]
	public partial class Workitem : IEquatable<Workitem>
	{
		/// <summary>
		/// The Category of the current Status of the Workitem.
		/// </summary>
		/// <value>The Category of the current Status of the Workitem.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusCategoryEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Open for "Open"
			/// </summary>
			[EnumMember(Value = "Open")]
			Open,

			/// <summary>
			/// Enum Inprogress for "InProgress"
			/// </summary>
			[EnumMember(Value = "InProgress")]
			Inprogress,

			/// <summary>
			/// Enum Waiting for "Waiting"
			/// </summary>
			[EnumMember(Value = "Waiting")]
			Waiting,

			/// <summary>
			/// Enum Closed for "Closed"
			/// </summary>
			[EnumMember(Value = "Closed")]
			Closed,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// The assignment state of the workitem.
		/// </summary>
		/// <value>The assignment state of the workitem.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AssignmentStateEnum
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
			/// Enum Acdstarted for "AcdStarted"
			/// </summary>
			[EnumMember(Value = "AcdStarted")]
			Acdstarted,

			/// <summary>
			/// Enum Alerting for "Alerting"
			/// </summary>
			[EnumMember(Value = "Alerting")]
			Alerting,

			/// <summary>
			/// Enum Alerttimeout for "AlertTimeout"
			/// </summary>
			[EnumMember(Value = "AlertTimeout")]
			Alerttimeout,

			/// <summary>
			/// Enum Acdcancelled for "AcdCancelled"
			/// </summary>
			[EnumMember(Value = "AcdCancelled")]
			Acdcancelled,

			/// <summary>
			/// Enum Terminated for "Terminated"
			/// </summary>
			[EnumMember(Value = "Terminated")]
			Terminated,

			/// <summary>
			/// Enum Idle for "Idle"
			/// </summary>
			[EnumMember(Value = "Idle")]
			Idle,

			/// <summary>
			/// Enum Declined for "Declined"
			/// </summary>
			[EnumMember(Value = "Declined")]
			Declined,

			/// <summary>
			/// Enum Connected for "Connected"
			/// </summary>
			[EnumMember(Value = "Connected")]
			Connected,

			/// <summary>
			/// Enum Disconnected for "Disconnected"
			/// </summary>
			[EnumMember(Value = "Disconnected")]
			Disconnected,

			/// <summary>
			/// Enum Parked for "Parked"
			/// </summary>
			[EnumMember(Value = "Parked")]
			Parked,

			/// <summary>
			/// Enum Held for "Held"
			/// </summary>
			[EnumMember(Value = "Held")]
			Held,

			/// <summary>
			/// Enum Acdexpired for "AcdExpired"
			/// </summary>
			[EnumMember(Value = "AcdExpired")]
			Acdexpired
		}
		/// <summary>
		/// The Category of the current Status of the Workitem.
		/// </summary>
		/// <value>The Category of the current Status of the Workitem.</value>
		[DataMember(Name = "statusCategory", EmitDefaultValue = false)]
		public StatusCategoryEnum? StatusCategory { get; set; }
		/// <summary>
		/// The assignment state of the workitem.
		/// </summary>
		/// <value>The assignment state of the workitem.</value>
		[DataMember(Name = "assignmentState", EmitDefaultValue = false)]
		public AssignmentStateEnum? AssignmentState { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="Workitem" /> class.
		/// </summary>
		/// <param name="Name">The name of the Workitem..</param>
		/// <param name="Division">The division to which this entity belongs..</param>
		/// <param name="Type">The Worktype of the Workitem..</param>
		/// <param name="Description">The description of the Workitem..</param>
		/// <param name="Language">The language of the Workitem..</param>
		/// <param name="UtilizationLabel">The utilization label of the Workitem..</param>
		/// <param name="Priority">The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000..</param>
		/// <param name="DateCreated">The creation date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateModified">The modified date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateDue">The due date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateExpires">The expiry date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DurationSeconds">The estimated duration in seconds to complete the workitem..</param>
		/// <param name="Ttl">The time to live of the Workitem in seconds..</param>
		/// <param name="Status">The current Status of the Workitem..</param>
		/// <param name="StatusCategory">The Category of the current Status of the Workitem..</param>
		/// <param name="DateStatusChanged">The State change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateClosed">The date the Workitem was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Workbin">The Workbin that contains the Workitem..</param>
		/// <param name="Reporter">The reporter of the Workitem..</param>
		/// <param name="Assignee">The assignee of the Workitem..</param>
		/// <param name="ExternalContact">The external contact of the Workitem..</param>
		/// <param name="ExternalTag">The external tag of the Workitem..</param>
		/// <param name="ModifiedBy">The User who modified the Workitem..</param>
		/// <param name="Queue">The Workitems queue..</param>
		/// <param name="AssignmentState">The assignment state of the workitem..</param>
		/// <param name="DateAssignmentStateChanged">The assignment state change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="AlertTimeoutSeconds">The duration in seconds before an alert will timeout..</param>
		/// <param name="Skills">The skills of the Workitem..</param>
		/// <param name="PreferredAgents">The preferred agents of the Workitem..</param>
		/// <param name="AutoStatusTransition">Set it to false to disable auto status transition. By default, it is enabled..</param>
		/// <param name="Schema">The schema defining the custom fields of the Workitem. The schema is inherited from the Workitems Worktype at creation time..</param>
		/// <param name="CustomFields">Custom fields defined in the schema referenced by the Workitem..</param>
		/// <param name="AutoStatusTransitionDetail">Auto status transition details of Workitem..</param>
		/// <param name="ScoredAgents">A list of scored agents for the Workitem..</param>
		/// <param name="Script">The script that will be executed for the Workitem..</param>
		public Workitem(string Name = null, Division Division = null, WorktypeReference Type = null, string Description = null, LanguageReference Language = null, WorkitemUtilizationLabelReference UtilizationLabel = null, int? Priority = null, DateTime? DateCreated = null, DateTime? DateModified = null, DateTime? DateDue = null, DateTime? DateExpires = null, int? DurationSeconds = null, int? Ttl = null, WorkitemStatusReference Status = null, StatusCategoryEnum? StatusCategory = null, DateTime? DateStatusChanged = null, DateTime? DateClosed = null, WorkbinReference Workbin = null, UserReferenceWithName Reporter = null, UserReferenceWithName Assignee = null, ExternalContactReference ExternalContact = null, string ExternalTag = null, UserReference ModifiedBy = null, WorkitemQueueReference Queue = null, AssignmentStateEnum? AssignmentState = null, DateTime? DateAssignmentStateChanged = null, int? AlertTimeoutSeconds = null, List<RoutingSkillReference> Skills = null, List<UserReference> PreferredAgents = null, bool? AutoStatusTransition = null, WorkitemSchema Schema = null, Dictionary<string, Object> CustomFields = null, AutoStatusTransitionDetail AutoStatusTransitionDetail = null, List<WorkitemScoredAgent> ScoredAgents = null, WorkitemScriptReference Script = null)
		{
			this.Name = Name;
			this.Division = Division;
			this.Type = Type;
			this.Description = Description;
			this.Language = Language;
			this.UtilizationLabel = UtilizationLabel;
			this.Priority = Priority;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;
			this.DateDue = DateDue;
			this.DateExpires = DateExpires;
			this.DurationSeconds = DurationSeconds;
			this.Ttl = Ttl;
			this.Status = Status;
			this.StatusCategory = StatusCategory;
			this.DateStatusChanged = DateStatusChanged;
			this.DateClosed = DateClosed;
			this.Workbin = Workbin;
			this.Reporter = Reporter;
			this.Assignee = Assignee;
			this.ExternalContact = ExternalContact;
			this.ExternalTag = ExternalTag;
			this.ModifiedBy = ModifiedBy;
			this.Queue = Queue;
			this.AssignmentState = AssignmentState;
			this.DateAssignmentStateChanged = DateAssignmentStateChanged;
			this.AlertTimeoutSeconds = AlertTimeoutSeconds;
			this.Skills = Skills;
			this.PreferredAgents = PreferredAgents;
			this.AutoStatusTransition = AutoStatusTransition;
			this.Schema = Schema;
			this.CustomFields = CustomFields;
			this.AutoStatusTransitionDetail = AutoStatusTransitionDetail;
			this.ScoredAgents = ScoredAgents;
			this.Script = Script;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the Workitem.
		/// </summary>
		/// <value>The name of the Workitem.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The division to which this entity belongs.
		/// </summary>
		/// <value>The division to which this entity belongs.</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public Division Division { get; set; }



		/// <summary>
		/// The Worktype of the Workitem.
		/// </summary>
		/// <value>The Worktype of the Workitem.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public WorktypeReference Type { get; set; }



		/// <summary>
		/// The description of the Workitem.
		/// </summary>
		/// <value>The description of the Workitem.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The language of the Workitem.
		/// </summary>
		/// <value>The language of the Workitem.</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public LanguageReference Language { get; set; }



		/// <summary>
		/// The utilization label of the Workitem.
		/// </summary>
		/// <value>The utilization label of the Workitem.</value>
		[DataMember(Name = "utilizationLabel", EmitDefaultValue = false)]
		public WorkitemUtilizationLabelReference UtilizationLabel { get; set; }



		/// <summary>
		/// The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000.
		/// </summary>
		/// <value>The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000.</value>
		[DataMember(Name = "priority", EmitDefaultValue = false)]
		public int? Priority { get; set; }



		/// <summary>
		/// The creation date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The creation date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// The modified date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The modified date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// The due date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The due date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateDue", EmitDefaultValue = false)]
		public DateTime? DateDue { get; set; }



		/// <summary>
		/// The expiry date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The expiry date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateExpires", EmitDefaultValue = false)]
		public DateTime? DateExpires { get; set; }



		/// <summary>
		/// The estimated duration in seconds to complete the workitem.
		/// </summary>
		/// <value>The estimated duration in seconds to complete the workitem.</value>
		[DataMember(Name = "durationSeconds", EmitDefaultValue = false)]
		public int? DurationSeconds { get; set; }



		/// <summary>
		/// The time to live of the Workitem in seconds.
		/// </summary>
		/// <value>The time to live of the Workitem in seconds.</value>
		[DataMember(Name = "ttl", EmitDefaultValue = false)]
		public int? Ttl { get; set; }



		/// <summary>
		/// The current Status of the Workitem.
		/// </summary>
		/// <value>The current Status of the Workitem.</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public WorkitemStatusReference Status { get; set; }





		/// <summary>
		/// The State change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The State change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateStatusChanged", EmitDefaultValue = false)]
		public DateTime? DateStatusChanged { get; set; }



		/// <summary>
		/// The date the Workitem was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the Workitem was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateClosed", EmitDefaultValue = false)]
		public DateTime? DateClosed { get; set; }



		/// <summary>
		/// The Workbin that contains the Workitem.
		/// </summary>
		/// <value>The Workbin that contains the Workitem.</value>
		[DataMember(Name = "workbin", EmitDefaultValue = false)]
		public WorkbinReference Workbin { get; set; }



		/// <summary>
		/// The reporter of the Workitem.
		/// </summary>
		/// <value>The reporter of the Workitem.</value>
		[DataMember(Name = "reporter", EmitDefaultValue = false)]
		public UserReferenceWithName Reporter { get; set; }



		/// <summary>
		/// The assignee of the Workitem.
		/// </summary>
		/// <value>The assignee of the Workitem.</value>
		[DataMember(Name = "assignee", EmitDefaultValue = false)]
		public UserReferenceWithName Assignee { get; set; }



		/// <summary>
		/// The external contact of the Workitem.
		/// </summary>
		/// <value>The external contact of the Workitem.</value>
		[DataMember(Name = "externalContact", EmitDefaultValue = false)]
		public ExternalContactReference ExternalContact { get; set; }



		/// <summary>
		/// The external tag of the Workitem.
		/// </summary>
		/// <value>The external tag of the Workitem.</value>
		[DataMember(Name = "externalTag", EmitDefaultValue = false)]
		public string ExternalTag { get; set; }



		/// <summary>
		/// The User who modified the Workitem.
		/// </summary>
		/// <value>The User who modified the Workitem.</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public UserReference ModifiedBy { get; set; }



		/// <summary>
		/// The Workitems queue.
		/// </summary>
		/// <value>The Workitems queue.</value>
		[DataMember(Name = "queue", EmitDefaultValue = false)]
		public WorkitemQueueReference Queue { get; set; }





		/// <summary>
		/// The assignment state change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The assignment state change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateAssignmentStateChanged", EmitDefaultValue = false)]
		public DateTime? DateAssignmentStateChanged { get; set; }



		/// <summary>
		/// The duration in seconds before an alert will timeout.
		/// </summary>
		/// <value>The duration in seconds before an alert will timeout.</value>
		[DataMember(Name = "alertTimeoutSeconds", EmitDefaultValue = false)]
		public int? AlertTimeoutSeconds { get; set; }



		/// <summary>
		/// The skills of the Workitem.
		/// </summary>
		/// <value>The skills of the Workitem.</value>
		[DataMember(Name = "skills", EmitDefaultValue = false)]
		public List<RoutingSkillReference> Skills { get; set; }



		/// <summary>
		/// The preferred agents of the Workitem.
		/// </summary>
		/// <value>The preferred agents of the Workitem.</value>
		[DataMember(Name = "preferredAgents", EmitDefaultValue = false)]
		public List<UserReference> PreferredAgents { get; set; }



		/// <summary>
		/// Set it to false to disable auto status transition. By default, it is enabled.
		/// </summary>
		/// <value>Set it to false to disable auto status transition. By default, it is enabled.</value>
		[DataMember(Name = "autoStatusTransition", EmitDefaultValue = false)]
		public bool? AutoStatusTransition { get; set; }



		/// <summary>
		/// The schema defining the custom fields of the Workitem. The schema is inherited from the Workitems Worktype at creation time.
		/// </summary>
		/// <value>The schema defining the custom fields of the Workitem. The schema is inherited from the Workitems Worktype at creation time.</value>
		[DataMember(Name = "schema", EmitDefaultValue = false)]
		public WorkitemSchema Schema { get; set; }



		/// <summary>
		/// Custom fields defined in the schema referenced by the Workitem.
		/// </summary>
		/// <value>Custom fields defined in the schema referenced by the Workitem.</value>
		[DataMember(Name = "customFields", EmitDefaultValue = false)]
		public Dictionary<string, Object> CustomFields { get; set; }



		/// <summary>
		/// Auto status transition details of Workitem.
		/// </summary>
		/// <value>Auto status transition details of Workitem.</value>
		[DataMember(Name = "autoStatusTransitionDetail", EmitDefaultValue = false)]
		public AutoStatusTransitionDetail AutoStatusTransitionDetail { get; set; }



		/// <summary>
		/// A list of scored agents for the Workitem.
		/// </summary>
		/// <value>A list of scored agents for the Workitem.</value>
		[DataMember(Name = "scoredAgents", EmitDefaultValue = false)]
		public List<WorkitemScoredAgent> ScoredAgents { get; set; }



		/// <summary>
		/// The script that will be executed for the Workitem.
		/// </summary>
		/// <value>The script that will be executed for the Workitem.</value>
		[DataMember(Name = "script", EmitDefaultValue = false)]
		public WorkitemScriptReference Script { get; set; }



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
			sb.Append("class Workitem {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  UtilizationLabel: ").Append(UtilizationLabel).Append("\n");
			sb.Append("  Priority: ").Append(Priority).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  DateDue: ").Append(DateDue).Append("\n");
			sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
			sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
			sb.Append("  Ttl: ").Append(Ttl).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  StatusCategory: ").Append(StatusCategory).Append("\n");
			sb.Append("  DateStatusChanged: ").Append(DateStatusChanged).Append("\n");
			sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
			sb.Append("  Workbin: ").Append(Workbin).Append("\n");
			sb.Append("  Reporter: ").Append(Reporter).Append("\n");
			sb.Append("  Assignee: ").Append(Assignee).Append("\n");
			sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
			sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  Queue: ").Append(Queue).Append("\n");
			sb.Append("  AssignmentState: ").Append(AssignmentState).Append("\n");
			sb.Append("  DateAssignmentStateChanged: ").Append(DateAssignmentStateChanged).Append("\n");
			sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
			sb.Append("  Skills: ").Append(Skills).Append("\n");
			sb.Append("  PreferredAgents: ").Append(PreferredAgents).Append("\n");
			sb.Append("  AutoStatusTransition: ").Append(AutoStatusTransition).Append("\n");
			sb.Append("  Schema: ").Append(Schema).Append("\n");
			sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
			sb.Append("  AutoStatusTransitionDetail: ").Append(AutoStatusTransitionDetail).Append("\n");
			sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
			sb.Append("  Script: ").Append(Script).Append("\n");
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
			return this.Equals(obj as Workitem);
		}

		/// <summary>
		/// Returns true if Workitem instances are equal
		/// </summary>
		/// <param name="other">Instance of Workitem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Workitem other)
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
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
				) &&
				(
					this.UtilizationLabel == other.UtilizationLabel ||
					this.UtilizationLabel != null &&
					this.UtilizationLabel.Equals(other.UtilizationLabel)
				) &&
				(
					this.Priority == other.Priority ||
					this.Priority != null &&
					this.Priority.Equals(other.Priority)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.DateDue == other.DateDue ||
					this.DateDue != null &&
					this.DateDue.Equals(other.DateDue)
				) &&
				(
					this.DateExpires == other.DateExpires ||
					this.DateExpires != null &&
					this.DateExpires.Equals(other.DateExpires)
				) &&
				(
					this.DurationSeconds == other.DurationSeconds ||
					this.DurationSeconds != null &&
					this.DurationSeconds.Equals(other.DurationSeconds)
				) &&
				(
					this.Ttl == other.Ttl ||
					this.Ttl != null &&
					this.Ttl.Equals(other.Ttl)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.StatusCategory == other.StatusCategory ||
					this.StatusCategory != null &&
					this.StatusCategory.Equals(other.StatusCategory)
				) &&
				(
					this.DateStatusChanged == other.DateStatusChanged ||
					this.DateStatusChanged != null &&
					this.DateStatusChanged.Equals(other.DateStatusChanged)
				) &&
				(
					this.DateClosed == other.DateClosed ||
					this.DateClosed != null &&
					this.DateClosed.Equals(other.DateClosed)
				) &&
				(
					this.Workbin == other.Workbin ||
					this.Workbin != null &&
					this.Workbin.Equals(other.Workbin)
				) &&
				(
					this.Reporter == other.Reporter ||
					this.Reporter != null &&
					this.Reporter.Equals(other.Reporter)
				) &&
				(
					this.Assignee == other.Assignee ||
					this.Assignee != null &&
					this.Assignee.Equals(other.Assignee)
				) &&
				(
					this.ExternalContact == other.ExternalContact ||
					this.ExternalContact != null &&
					this.ExternalContact.Equals(other.ExternalContact)
				) &&
				(
					this.ExternalTag == other.ExternalTag ||
					this.ExternalTag != null &&
					this.ExternalTag.Equals(other.ExternalTag)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.Queue == other.Queue ||
					this.Queue != null &&
					this.Queue.Equals(other.Queue)
				) &&
				(
					this.AssignmentState == other.AssignmentState ||
					this.AssignmentState != null &&
					this.AssignmentState.Equals(other.AssignmentState)
				) &&
				(
					this.DateAssignmentStateChanged == other.DateAssignmentStateChanged ||
					this.DateAssignmentStateChanged != null &&
					this.DateAssignmentStateChanged.Equals(other.DateAssignmentStateChanged)
				) &&
				(
					this.AlertTimeoutSeconds == other.AlertTimeoutSeconds ||
					this.AlertTimeoutSeconds != null &&
					this.AlertTimeoutSeconds.Equals(other.AlertTimeoutSeconds)
				) &&
				(
					this.Skills == other.Skills ||
					this.Skills != null &&
					this.Skills.SequenceEqual(other.Skills)
				) &&
				(
					this.PreferredAgents == other.PreferredAgents ||
					this.PreferredAgents != null &&
					this.PreferredAgents.SequenceEqual(other.PreferredAgents)
				) &&
				(
					this.AutoStatusTransition == other.AutoStatusTransition ||
					this.AutoStatusTransition != null &&
					this.AutoStatusTransition.Equals(other.AutoStatusTransition)
				) &&
				(
					this.Schema == other.Schema ||
					this.Schema != null &&
					this.Schema.Equals(other.Schema)
				) &&
				(
					this.CustomFields == other.CustomFields ||
					this.CustomFields != null &&
					this.CustomFields.SequenceEqual(other.CustomFields)
				) &&
				(
					this.AutoStatusTransitionDetail == other.AutoStatusTransitionDetail ||
					this.AutoStatusTransitionDetail != null &&
					this.AutoStatusTransitionDetail.Equals(other.AutoStatusTransitionDetail)
				) &&
				(
					this.ScoredAgents == other.ScoredAgents ||
					this.ScoredAgents != null &&
					this.ScoredAgents.SequenceEqual(other.ScoredAgents)
				) &&
				(
					this.Script == other.Script ||
					this.Script != null &&
					this.Script.Equals(other.Script)
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

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				if (this.UtilizationLabel != null)
					hash = hash * 59 + this.UtilizationLabel.GetHashCode();

				if (this.Priority != null)
					hash = hash * 59 + this.Priority.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.DateDue != null)
					hash = hash * 59 + this.DateDue.GetHashCode();

				if (this.DateExpires != null)
					hash = hash * 59 + this.DateExpires.GetHashCode();

				if (this.DurationSeconds != null)
					hash = hash * 59 + this.DurationSeconds.GetHashCode();

				if (this.Ttl != null)
					hash = hash * 59 + this.Ttl.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.StatusCategory != null)
					hash = hash * 59 + this.StatusCategory.GetHashCode();

				if (this.DateStatusChanged != null)
					hash = hash * 59 + this.DateStatusChanged.GetHashCode();

				if (this.DateClosed != null)
					hash = hash * 59 + this.DateClosed.GetHashCode();

				if (this.Workbin != null)
					hash = hash * 59 + this.Workbin.GetHashCode();

				if (this.Reporter != null)
					hash = hash * 59 + this.Reporter.GetHashCode();

				if (this.Assignee != null)
					hash = hash * 59 + this.Assignee.GetHashCode();

				if (this.ExternalContact != null)
					hash = hash * 59 + this.ExternalContact.GetHashCode();

				if (this.ExternalTag != null)
					hash = hash * 59 + this.ExternalTag.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.Queue != null)
					hash = hash * 59 + this.Queue.GetHashCode();

				if (this.AssignmentState != null)
					hash = hash * 59 + this.AssignmentState.GetHashCode();

				if (this.DateAssignmentStateChanged != null)
					hash = hash * 59 + this.DateAssignmentStateChanged.GetHashCode();

				if (this.AlertTimeoutSeconds != null)
					hash = hash * 59 + this.AlertTimeoutSeconds.GetHashCode();

				if (this.Skills != null)
					hash = hash * 59 + this.Skills.GetHashCode();

				if (this.PreferredAgents != null)
					hash = hash * 59 + this.PreferredAgents.GetHashCode();

				if (this.AutoStatusTransition != null)
					hash = hash * 59 + this.AutoStatusTransition.GetHashCode();

				if (this.Schema != null)
					hash = hash * 59 + this.Schema.GetHashCode();

				if (this.CustomFields != null)
					hash = hash * 59 + this.CustomFields.GetHashCode();

				if (this.AutoStatusTransitionDetail != null)
					hash = hash * 59 + this.AutoStatusTransitionDetail.GetHashCode();

				if (this.ScoredAgents != null)
					hash = hash * 59 + this.ScoredAgents.GetHashCode();

				if (this.Script != null)
					hash = hash * 59 + this.Script.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
