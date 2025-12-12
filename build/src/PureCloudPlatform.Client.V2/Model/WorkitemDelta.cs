using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemDelta
	/// </summary>
	[DataContract]
	public partial class WorkitemDelta : IEquatable<WorkitemDelta>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemDelta" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Description">Description.</param>
		/// <param name="LanguageId">LanguageId.</param>
		/// <param name="UtilizationLabelId">UtilizationLabelId.</param>
		/// <param name="Priority">Priority.</param>
		/// <param name="SkillIds">SkillIds.</param>
		/// <param name="PreferredAgentIds">PreferredAgentIds.</param>
		/// <param name="DateDue">DateDue.</param>
		/// <param name="DateExpires">DateExpires.</param>
		/// <param name="DurationSeconds">DurationSeconds.</param>
		/// <param name="StatusId">StatusId.</param>
		/// <param name="ReporterId">ReporterId.</param>
		/// <param name="ExternalContactId">ExternalContactId.</param>
		/// <param name="AssigneeId">AssigneeId.</param>
		/// <param name="WorkbinId">WorkbinId.</param>
		/// <param name="QueueId">QueueId.</param>
		/// <param name="ExternalTag">ExternalTag.</param>
		/// <param name="WrapupId">WrapupId.</param>
		/// <param name="Wrapup">Wrapup.</param>
		/// <param name="Ttl">Ttl.</param>
		/// <param name="DateClosed">DateClosed.</param>
		/// <param name="AssignmentState">AssignmentState.</param>
		/// <param name="AutoStatusTransition">AutoStatusTransition.</param>
		/// <param name="CustomFields">CustomFields.</param>
		/// <param name="DateModified">DateModified.</param>
		/// <param name="ModifiedBy">ModifiedBy.</param>
		/// <param name="StatusCategory">StatusCategory.</param>
		/// <param name="ScriptId">ScriptId.</param>
		/// <param name="DateAssignmentStateChanged">DateAssignmentStateChanged.</param>
		/// <param name="AlertTimeoutSeconds">AlertTimeoutSeconds.</param>
		/// <param name="ScoredAgents">ScoredAgents.</param>
		public WorkitemDelta(WorkitemsAttributeChangeString Name = null, WorkitemsAttributeChangeString Description = null, WorkitemsAttributeChangeString LanguageId = null, WorkitemsAttributeChangeString UtilizationLabelId = null, WorkitemsAttributeChangeInteger Priority = null, WorkitemsAttributeChangeList SkillIds = null, WorkitemsAttributeChangeList PreferredAgentIds = null, WorkitemsAttributeChangeInstant DateDue = null, WorkitemsAttributeChangeInstant DateExpires = null, WorkitemsAttributeChangeInteger DurationSeconds = null, WorkitemsAttributeChangeString StatusId = null, WorkitemsAttributeChangeString ReporterId = null, WorkitemsAttributeChangeString ExternalContactId = null, WorkitemsAttributeChangeString AssigneeId = null, WorkitemsAttributeChangeString WorkbinId = null, WorkitemsAttributeChangeString QueueId = null, WorkitemsAttributeChangeString ExternalTag = null, WorkitemsAttributeChangeString WrapupId = null, WorkitemsAttributeChangeWrapupDelta Wrapup = null, WorkitemsAttributeChangeInteger Ttl = null, WorkitemsAttributeChangeInstant DateClosed = null, WorkitemsAttributeChangeString AssignmentState = null, WorkitemsAttributeChangeBoolean AutoStatusTransition = null, WorkitemsAttributeChangeMap CustomFields = null, WorkitemsAttributeChangeInstant DateModified = null, WorkitemsAttributeChangeString ModifiedBy = null, WorkitemsAttributeChangeWorkitemStatusCategory StatusCategory = null, WorkitemsAttributeChangeString ScriptId = null, WorkitemsAttributeChangeInstant DateAssignmentStateChanged = null, WorkitemsAttributeChangeInteger AlertTimeoutSeconds = null, WorkitemsAttributeChangeListWorkitemScoredAgentDelta ScoredAgents = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.LanguageId = LanguageId;
			this.UtilizationLabelId = UtilizationLabelId;
			this.Priority = Priority;
			this.SkillIds = SkillIds;
			this.PreferredAgentIds = PreferredAgentIds;
			this.DateDue = DateDue;
			this.DateExpires = DateExpires;
			this.DurationSeconds = DurationSeconds;
			this.StatusId = StatusId;
			this.ReporterId = ReporterId;
			this.ExternalContactId = ExternalContactId;
			this.AssigneeId = AssigneeId;
			this.WorkbinId = WorkbinId;
			this.QueueId = QueueId;
			this.ExternalTag = ExternalTag;
			this.WrapupId = WrapupId;
			this.Wrapup = Wrapup;
			this.Ttl = Ttl;
			this.DateClosed = DateClosed;
			this.AssignmentState = AssignmentState;
			this.AutoStatusTransition = AutoStatusTransition;
			this.CustomFields = CustomFields;
			this.DateModified = DateModified;
			this.ModifiedBy = ModifiedBy;
			this.StatusCategory = StatusCategory;
			this.ScriptId = ScriptId;
			this.DateAssignmentStateChanged = DateAssignmentStateChanged;
			this.AlertTimeoutSeconds = AlertTimeoutSeconds;
			this.ScoredAgents = ScoredAgents;

		}



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString Name { get; set; }



		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString Description { get; set; }



		/// <summary>
		/// Gets or Sets LanguageId
		/// </summary>
		[DataMember(Name = "languageId", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString LanguageId { get; set; }



		/// <summary>
		/// Gets or Sets UtilizationLabelId
		/// </summary>
		[DataMember(Name = "utilizationLabelId", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString UtilizationLabelId { get; set; }



		/// <summary>
		/// Gets or Sets Priority
		/// </summary>
		[DataMember(Name = "priority", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeInteger Priority { get; set; }



		/// <summary>
		/// Gets or Sets SkillIds
		/// </summary>
		[DataMember(Name = "skillIds", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeList SkillIds { get; set; }



		/// <summary>
		/// Gets or Sets PreferredAgentIds
		/// </summary>
		[DataMember(Name = "preferredAgentIds", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeList PreferredAgentIds { get; set; }



		/// <summary>
		/// Gets or Sets DateDue
		/// </summary>
		[DataMember(Name = "dateDue", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeInstant DateDue { get; set; }



		/// <summary>
		/// Gets or Sets DateExpires
		/// </summary>
		[DataMember(Name = "dateExpires", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeInstant DateExpires { get; set; }



		/// <summary>
		/// Gets or Sets DurationSeconds
		/// </summary>
		[DataMember(Name = "durationSeconds", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeInteger DurationSeconds { get; set; }



		/// <summary>
		/// Gets or Sets StatusId
		/// </summary>
		[DataMember(Name = "statusId", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString StatusId { get; set; }



		/// <summary>
		/// Gets or Sets ReporterId
		/// </summary>
		[DataMember(Name = "reporterId", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString ReporterId { get; set; }



		/// <summary>
		/// Gets or Sets ExternalContactId
		/// </summary>
		[DataMember(Name = "externalContactId", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString ExternalContactId { get; set; }



		/// <summary>
		/// Gets or Sets AssigneeId
		/// </summary>
		[DataMember(Name = "assigneeId", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString AssigneeId { get; set; }



		/// <summary>
		/// Gets or Sets WorkbinId
		/// </summary>
		[DataMember(Name = "workbinId", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString WorkbinId { get; set; }



		/// <summary>
		/// Gets or Sets QueueId
		/// </summary>
		[DataMember(Name = "queueId", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString QueueId { get; set; }



		/// <summary>
		/// Gets or Sets ExternalTag
		/// </summary>
		[DataMember(Name = "externalTag", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString ExternalTag { get; set; }



		/// <summary>
		/// Gets or Sets WrapupId
		/// </summary>
		[DataMember(Name = "wrapupId", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString WrapupId { get; set; }



		/// <summary>
		/// Gets or Sets Wrapup
		/// </summary>
		[DataMember(Name = "wrapup", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeWrapupDelta Wrapup { get; set; }



		/// <summary>
		/// Gets or Sets Ttl
		/// </summary>
		[DataMember(Name = "ttl", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeInteger Ttl { get; set; }



		/// <summary>
		/// Gets or Sets DateClosed
		/// </summary>
		[DataMember(Name = "dateClosed", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeInstant DateClosed { get; set; }



		/// <summary>
		/// Gets or Sets AssignmentState
		/// </summary>
		[DataMember(Name = "assignmentState", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString AssignmentState { get; set; }



		/// <summary>
		/// Gets or Sets AutoStatusTransition
		/// </summary>
		[DataMember(Name = "autoStatusTransition", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeBoolean AutoStatusTransition { get; set; }



		/// <summary>
		/// Gets or Sets CustomFields
		/// </summary>
		[DataMember(Name = "customFields", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeMap CustomFields { get; set; }



		/// <summary>
		/// Gets or Sets DateModified
		/// </summary>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeInstant DateModified { get; set; }



		/// <summary>
		/// Gets or Sets ModifiedBy
		/// </summary>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString ModifiedBy { get; set; }



		/// <summary>
		/// Gets or Sets StatusCategory
		/// </summary>
		[DataMember(Name = "statusCategory", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeWorkitemStatusCategory StatusCategory { get; set; }



		/// <summary>
		/// Gets or Sets ScriptId
		/// </summary>
		[DataMember(Name = "scriptId", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeString ScriptId { get; set; }



		/// <summary>
		/// Gets or Sets DateAssignmentStateChanged
		/// </summary>
		[DataMember(Name = "dateAssignmentStateChanged", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeInstant DateAssignmentStateChanged { get; set; }



		/// <summary>
		/// Gets or Sets AlertTimeoutSeconds
		/// </summary>
		[DataMember(Name = "alertTimeoutSeconds", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeInteger AlertTimeoutSeconds { get; set; }



		/// <summary>
		/// Gets or Sets ScoredAgents
		/// </summary>
		[DataMember(Name = "scoredAgents", EmitDefaultValue = false)]
		public WorkitemsAttributeChangeListWorkitemScoredAgentDelta ScoredAgents { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemDelta {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
			sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
			sb.Append("  Priority: ").Append(Priority).Append("\n");
			sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
			sb.Append("  PreferredAgentIds: ").Append(PreferredAgentIds).Append("\n");
			sb.Append("  DateDue: ").Append(DateDue).Append("\n");
			sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
			sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
			sb.Append("  StatusId: ").Append(StatusId).Append("\n");
			sb.Append("  ReporterId: ").Append(ReporterId).Append("\n");
			sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
			sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
			sb.Append("  WorkbinId: ").Append(WorkbinId).Append("\n");
			sb.Append("  QueueId: ").Append(QueueId).Append("\n");
			sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
			sb.Append("  WrapupId: ").Append(WrapupId).Append("\n");
			sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
			sb.Append("  Ttl: ").Append(Ttl).Append("\n");
			sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
			sb.Append("  AssignmentState: ").Append(AssignmentState).Append("\n");
			sb.Append("  AutoStatusTransition: ").Append(AutoStatusTransition).Append("\n");
			sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  StatusCategory: ").Append(StatusCategory).Append("\n");
			sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
			sb.Append("  DateAssignmentStateChanged: ").Append(DateAssignmentStateChanged).Append("\n");
			sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
			sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
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
			return this.Equals(obj as WorkitemDelta);
		}

		/// <summary>
		/// Returns true if WorkitemDelta instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemDelta to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemDelta other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
					this.LanguageId == other.LanguageId ||
					this.LanguageId != null &&
					this.LanguageId.Equals(other.LanguageId)
				) &&
				(
					this.UtilizationLabelId == other.UtilizationLabelId ||
					this.UtilizationLabelId != null &&
					this.UtilizationLabelId.Equals(other.UtilizationLabelId)
				) &&
				(
					this.Priority == other.Priority ||
					this.Priority != null &&
					this.Priority.Equals(other.Priority)
				) &&
				(
					this.SkillIds == other.SkillIds ||
					this.SkillIds != null &&
					this.SkillIds.Equals(other.SkillIds)
				) &&
				(
					this.PreferredAgentIds == other.PreferredAgentIds ||
					this.PreferredAgentIds != null &&
					this.PreferredAgentIds.Equals(other.PreferredAgentIds)
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
					this.StatusId == other.StatusId ||
					this.StatusId != null &&
					this.StatusId.Equals(other.StatusId)
				) &&
				(
					this.ReporterId == other.ReporterId ||
					this.ReporterId != null &&
					this.ReporterId.Equals(other.ReporterId)
				) &&
				(
					this.ExternalContactId == other.ExternalContactId ||
					this.ExternalContactId != null &&
					this.ExternalContactId.Equals(other.ExternalContactId)
				) &&
				(
					this.AssigneeId == other.AssigneeId ||
					this.AssigneeId != null &&
					this.AssigneeId.Equals(other.AssigneeId)
				) &&
				(
					this.WorkbinId == other.WorkbinId ||
					this.WorkbinId != null &&
					this.WorkbinId.Equals(other.WorkbinId)
				) &&
				(
					this.QueueId == other.QueueId ||
					this.QueueId != null &&
					this.QueueId.Equals(other.QueueId)
				) &&
				(
					this.ExternalTag == other.ExternalTag ||
					this.ExternalTag != null &&
					this.ExternalTag.Equals(other.ExternalTag)
				) &&
				(
					this.WrapupId == other.WrapupId ||
					this.WrapupId != null &&
					this.WrapupId.Equals(other.WrapupId)
				) &&
				(
					this.Wrapup == other.Wrapup ||
					this.Wrapup != null &&
					this.Wrapup.Equals(other.Wrapup)
				) &&
				(
					this.Ttl == other.Ttl ||
					this.Ttl != null &&
					this.Ttl.Equals(other.Ttl)
				) &&
				(
					this.DateClosed == other.DateClosed ||
					this.DateClosed != null &&
					this.DateClosed.Equals(other.DateClosed)
				) &&
				(
					this.AssignmentState == other.AssignmentState ||
					this.AssignmentState != null &&
					this.AssignmentState.Equals(other.AssignmentState)
				) &&
				(
					this.AutoStatusTransition == other.AutoStatusTransition ||
					this.AutoStatusTransition != null &&
					this.AutoStatusTransition.Equals(other.AutoStatusTransition)
				) &&
				(
					this.CustomFields == other.CustomFields ||
					this.CustomFields != null &&
					this.CustomFields.Equals(other.CustomFields)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.StatusCategory == other.StatusCategory ||
					this.StatusCategory != null &&
					this.StatusCategory.Equals(other.StatusCategory)
				) &&
				(
					this.ScriptId == other.ScriptId ||
					this.ScriptId != null &&
					this.ScriptId.Equals(other.ScriptId)
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
					this.ScoredAgents == other.ScoredAgents ||
					this.ScoredAgents != null &&
					this.ScoredAgents.Equals(other.ScoredAgents)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.LanguageId != null)
					hash = hash * 59 + this.LanguageId.GetHashCode();

				if (this.UtilizationLabelId != null)
					hash = hash * 59 + this.UtilizationLabelId.GetHashCode();

				if (this.Priority != null)
					hash = hash * 59 + this.Priority.GetHashCode();

				if (this.SkillIds != null)
					hash = hash * 59 + this.SkillIds.GetHashCode();

				if (this.PreferredAgentIds != null)
					hash = hash * 59 + this.PreferredAgentIds.GetHashCode();

				if (this.DateDue != null)
					hash = hash * 59 + this.DateDue.GetHashCode();

				if (this.DateExpires != null)
					hash = hash * 59 + this.DateExpires.GetHashCode();

				if (this.DurationSeconds != null)
					hash = hash * 59 + this.DurationSeconds.GetHashCode();

				if (this.StatusId != null)
					hash = hash * 59 + this.StatusId.GetHashCode();

				if (this.ReporterId != null)
					hash = hash * 59 + this.ReporterId.GetHashCode();

				if (this.ExternalContactId != null)
					hash = hash * 59 + this.ExternalContactId.GetHashCode();

				if (this.AssigneeId != null)
					hash = hash * 59 + this.AssigneeId.GetHashCode();

				if (this.WorkbinId != null)
					hash = hash * 59 + this.WorkbinId.GetHashCode();

				if (this.QueueId != null)
					hash = hash * 59 + this.QueueId.GetHashCode();

				if (this.ExternalTag != null)
					hash = hash * 59 + this.ExternalTag.GetHashCode();

				if (this.WrapupId != null)
					hash = hash * 59 + this.WrapupId.GetHashCode();

				if (this.Wrapup != null)
					hash = hash * 59 + this.Wrapup.GetHashCode();

				if (this.Ttl != null)
					hash = hash * 59 + this.Ttl.GetHashCode();

				if (this.DateClosed != null)
					hash = hash * 59 + this.DateClosed.GetHashCode();

				if (this.AssignmentState != null)
					hash = hash * 59 + this.AssignmentState.GetHashCode();

				if (this.AutoStatusTransition != null)
					hash = hash * 59 + this.AutoStatusTransition.GetHashCode();

				if (this.CustomFields != null)
					hash = hash * 59 + this.CustomFields.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.StatusCategory != null)
					hash = hash * 59 + this.StatusCategory.GetHashCode();

				if (this.ScriptId != null)
					hash = hash * 59 + this.ScriptId.GetHashCode();

				if (this.DateAssignmentStateChanged != null)
					hash = hash * 59 + this.DateAssignmentStateChanged.GetHashCode();

				if (this.AlertTimeoutSeconds != null)
					hash = hash * 59 + this.AlertTimeoutSeconds.GetHashCode();

				if (this.ScoredAgents != null)
					hash = hash * 59 + this.ScoredAgents.GetHashCode();

				return hash;
			}
		}
	}

}
