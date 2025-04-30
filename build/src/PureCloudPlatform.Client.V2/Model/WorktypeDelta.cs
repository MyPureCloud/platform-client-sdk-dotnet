using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// WorktypeDelta
    /// </summary>
    [DataContract]
    public partial class WorktypeDelta :  IEquatable<WorktypeDelta>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorktypeDelta" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Statuses">Statuses.</param>
        /// <param name="DefaultWorkbinId">DefaultWorkbinId.</param>
        /// <param name="DefaultDurationSeconds">DefaultDurationSeconds.</param>
        /// <param name="DefaultExpirationSeconds">DefaultExpirationSeconds.</param>
        /// <param name="DefaultDueDurationSeconds">DefaultDueDurationSeconds.</param>
        /// <param name="DefaultPriority">DefaultPriority.</param>
        /// <param name="DefaultSkillIds">DefaultSkillIds.</param>
        /// <param name="DefaultStatusId">DefaultStatusId.</param>
        /// <param name="DefaultLanguageId">DefaultLanguageId.</param>
        /// <param name="DefaultTtlSeconds">DefaultTtlSeconds.</param>
        /// <param name="AssignmentEnabled">AssignmentEnabled.</param>
        /// <param name="DefaultQueueId">DefaultQueueId.</param>
        /// <param name="SchemaId">SchemaId.</param>
        /// <param name="SchemaVersion">SchemaVersion.</param>
        /// <param name="ServiceLevelTarget">ServiceLevelTarget.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="DefaultScriptId">DefaultScriptId.</param>
        /// <param name="FlowId">FlowId.</param>
        /// <param name="RuleSettings">RuleSettings.</param>
        /// <param name="UnassignedDivisionContactsEnabled">UnassignedDivisionContactsEnabled.</param>
        public WorktypeDelta(WorkitemsAttributeChangeString Name = null, WorkitemsAttributeChangeString Description = null, WorkitemsAttributeChangeList Statuses = null, WorkitemsAttributeChangeString DefaultWorkbinId = null, WorkitemsAttributeChangeInteger DefaultDurationSeconds = null, WorkitemsAttributeChangeInteger DefaultExpirationSeconds = null, WorkitemsAttributeChangeInteger DefaultDueDurationSeconds = null, WorkitemsAttributeChangeInteger DefaultPriority = null, WorkitemsAttributeChangeList DefaultSkillIds = null, WorkitemsAttributeChangeString DefaultStatusId = null, WorkitemsAttributeChangeString DefaultLanguageId = null, WorkitemsAttributeChangeInteger DefaultTtlSeconds = null, WorkitemsAttributeChangeBoolean AssignmentEnabled = null, WorkitemsAttributeChangeString DefaultQueueId = null, WorkitemsAttributeChangeString SchemaId = null, WorkitemsAttributeChangeString SchemaVersion = null, WorkitemsAttributeChangeInteger ServiceLevelTarget = null, WorkitemsAttributeChangeInstant DateModified = null, WorkitemsAttributeChangeString ModifiedBy = null, WorkitemsAttributeChangeString DefaultScriptId = null, WorkitemsAttributeChangeString FlowId = null, WorkitemsAttributeChangeWorkitemRuleSettings RuleSettings = null, WorkitemsAttributeChangeBoolean UnassignedDivisionContactsEnabled = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Statuses = Statuses;
            this.DefaultWorkbinId = DefaultWorkbinId;
            this.DefaultDurationSeconds = DefaultDurationSeconds;
            this.DefaultExpirationSeconds = DefaultExpirationSeconds;
            this.DefaultDueDurationSeconds = DefaultDueDurationSeconds;
            this.DefaultPriority = DefaultPriority;
            this.DefaultSkillIds = DefaultSkillIds;
            this.DefaultStatusId = DefaultStatusId;
            this.DefaultLanguageId = DefaultLanguageId;
            this.DefaultTtlSeconds = DefaultTtlSeconds;
            this.AssignmentEnabled = AssignmentEnabled;
            this.DefaultQueueId = DefaultQueueId;
            this.SchemaId = SchemaId;
            this.SchemaVersion = SchemaVersion;
            this.ServiceLevelTarget = ServiceLevelTarget;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.DefaultScriptId = DefaultScriptId;
            this.FlowId = FlowId;
            this.RuleSettings = RuleSettings;
            this.UnassignedDivisionContactsEnabled = UnassignedDivisionContactsEnabled;
            
        }
        


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString Name { get; set; }



        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString Description { get; set; }



        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeList Statuses { get; set; }



        /// <summary>
        /// Gets or Sets DefaultWorkbinId
        /// </summary>
        [DataMember(Name="defaultWorkbinId", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString DefaultWorkbinId { get; set; }



        /// <summary>
        /// Gets or Sets DefaultDurationSeconds
        /// </summary>
        [DataMember(Name="defaultDurationSeconds", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeInteger DefaultDurationSeconds { get; set; }



        /// <summary>
        /// Gets or Sets DefaultExpirationSeconds
        /// </summary>
        [DataMember(Name="defaultExpirationSeconds", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeInteger DefaultExpirationSeconds { get; set; }



        /// <summary>
        /// Gets or Sets DefaultDueDurationSeconds
        /// </summary>
        [DataMember(Name="defaultDueDurationSeconds", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeInteger DefaultDueDurationSeconds { get; set; }



        /// <summary>
        /// Gets or Sets DefaultPriority
        /// </summary>
        [DataMember(Name="defaultPriority", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeInteger DefaultPriority { get; set; }



        /// <summary>
        /// Gets or Sets DefaultSkillIds
        /// </summary>
        [DataMember(Name="defaultSkillIds", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeList DefaultSkillIds { get; set; }



        /// <summary>
        /// Gets or Sets DefaultStatusId
        /// </summary>
        [DataMember(Name="defaultStatusId", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString DefaultStatusId { get; set; }



        /// <summary>
        /// Gets or Sets DefaultLanguageId
        /// </summary>
        [DataMember(Name="defaultLanguageId", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString DefaultLanguageId { get; set; }



        /// <summary>
        /// Gets or Sets DefaultTtlSeconds
        /// </summary>
        [DataMember(Name="defaultTtlSeconds", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeInteger DefaultTtlSeconds { get; set; }



        /// <summary>
        /// Gets or Sets AssignmentEnabled
        /// </summary>
        [DataMember(Name="assignmentEnabled", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeBoolean AssignmentEnabled { get; set; }



        /// <summary>
        /// Gets or Sets DefaultQueueId
        /// </summary>
        [DataMember(Name="defaultQueueId", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString DefaultQueueId { get; set; }



        /// <summary>
        /// Gets or Sets SchemaId
        /// </summary>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString SchemaId { get; set; }



        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        [DataMember(Name="schemaVersion", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString SchemaVersion { get; set; }



        /// <summary>
        /// Gets or Sets ServiceLevelTarget
        /// </summary>
        [DataMember(Name="serviceLevelTarget", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeInteger ServiceLevelTarget { get; set; }



        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeInstant DateModified { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString ModifiedBy { get; set; }



        /// <summary>
        /// Gets or Sets DefaultScriptId
        /// </summary>
        [DataMember(Name="defaultScriptId", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString DefaultScriptId { get; set; }



        /// <summary>
        /// Gets or Sets FlowId
        /// </summary>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeString FlowId { get; set; }



        /// <summary>
        /// Gets or Sets RuleSettings
        /// </summary>
        [DataMember(Name="ruleSettings", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeWorkitemRuleSettings RuleSettings { get; set; }



        /// <summary>
        /// Gets or Sets UnassignedDivisionContactsEnabled
        /// </summary>
        [DataMember(Name="unassignedDivisionContactsEnabled", EmitDefaultValue=false)]
        public WorkitemsAttributeChangeBoolean UnassignedDivisionContactsEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorktypeDelta {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  DefaultWorkbinId: ").Append(DefaultWorkbinId).Append("\n");
            sb.Append("  DefaultDurationSeconds: ").Append(DefaultDurationSeconds).Append("\n");
            sb.Append("  DefaultExpirationSeconds: ").Append(DefaultExpirationSeconds).Append("\n");
            sb.Append("  DefaultDueDurationSeconds: ").Append(DefaultDueDurationSeconds).Append("\n");
            sb.Append("  DefaultPriority: ").Append(DefaultPriority).Append("\n");
            sb.Append("  DefaultSkillIds: ").Append(DefaultSkillIds).Append("\n");
            sb.Append("  DefaultStatusId: ").Append(DefaultStatusId).Append("\n");
            sb.Append("  DefaultLanguageId: ").Append(DefaultLanguageId).Append("\n");
            sb.Append("  DefaultTtlSeconds: ").Append(DefaultTtlSeconds).Append("\n");
            sb.Append("  AssignmentEnabled: ").Append(AssignmentEnabled).Append("\n");
            sb.Append("  DefaultQueueId: ").Append(DefaultQueueId).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  ServiceLevelTarget: ").Append(ServiceLevelTarget).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DefaultScriptId: ").Append(DefaultScriptId).Append("\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
            sb.Append("  UnassignedDivisionContactsEnabled: ").Append(UnassignedDivisionContactsEnabled).Append("\n");
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
            return this.Equals(obj as WorktypeDelta);
        }

        /// <summary>
        /// Returns true if WorktypeDelta instances are equal
        /// </summary>
        /// <param name="other">Instance of WorktypeDelta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorktypeDelta other)
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
                    this.Statuses == other.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.Equals(other.Statuses)
                ) &&
                (
                    this.DefaultWorkbinId == other.DefaultWorkbinId ||
                    this.DefaultWorkbinId != null &&
                    this.DefaultWorkbinId.Equals(other.DefaultWorkbinId)
                ) &&
                (
                    this.DefaultDurationSeconds == other.DefaultDurationSeconds ||
                    this.DefaultDurationSeconds != null &&
                    this.DefaultDurationSeconds.Equals(other.DefaultDurationSeconds)
                ) &&
                (
                    this.DefaultExpirationSeconds == other.DefaultExpirationSeconds ||
                    this.DefaultExpirationSeconds != null &&
                    this.DefaultExpirationSeconds.Equals(other.DefaultExpirationSeconds)
                ) &&
                (
                    this.DefaultDueDurationSeconds == other.DefaultDueDurationSeconds ||
                    this.DefaultDueDurationSeconds != null &&
                    this.DefaultDueDurationSeconds.Equals(other.DefaultDueDurationSeconds)
                ) &&
                (
                    this.DefaultPriority == other.DefaultPriority ||
                    this.DefaultPriority != null &&
                    this.DefaultPriority.Equals(other.DefaultPriority)
                ) &&
                (
                    this.DefaultSkillIds == other.DefaultSkillIds ||
                    this.DefaultSkillIds != null &&
                    this.DefaultSkillIds.Equals(other.DefaultSkillIds)
                ) &&
                (
                    this.DefaultStatusId == other.DefaultStatusId ||
                    this.DefaultStatusId != null &&
                    this.DefaultStatusId.Equals(other.DefaultStatusId)
                ) &&
                (
                    this.DefaultLanguageId == other.DefaultLanguageId ||
                    this.DefaultLanguageId != null &&
                    this.DefaultLanguageId.Equals(other.DefaultLanguageId)
                ) &&
                (
                    this.DefaultTtlSeconds == other.DefaultTtlSeconds ||
                    this.DefaultTtlSeconds != null &&
                    this.DefaultTtlSeconds.Equals(other.DefaultTtlSeconds)
                ) &&
                (
                    this.AssignmentEnabled == other.AssignmentEnabled ||
                    this.AssignmentEnabled != null &&
                    this.AssignmentEnabled.Equals(other.AssignmentEnabled)
                ) &&
                (
                    this.DefaultQueueId == other.DefaultQueueId ||
                    this.DefaultQueueId != null &&
                    this.DefaultQueueId.Equals(other.DefaultQueueId)
                ) &&
                (
                    this.SchemaId == other.SchemaId ||
                    this.SchemaId != null &&
                    this.SchemaId.Equals(other.SchemaId)
                ) &&
                (
                    this.SchemaVersion == other.SchemaVersion ||
                    this.SchemaVersion != null &&
                    this.SchemaVersion.Equals(other.SchemaVersion)
                ) &&
                (
                    this.ServiceLevelTarget == other.ServiceLevelTarget ||
                    this.ServiceLevelTarget != null &&
                    this.ServiceLevelTarget.Equals(other.ServiceLevelTarget)
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
                    this.DefaultScriptId == other.DefaultScriptId ||
                    this.DefaultScriptId != null &&
                    this.DefaultScriptId.Equals(other.DefaultScriptId)
                ) &&
                (
                    this.FlowId == other.FlowId ||
                    this.FlowId != null &&
                    this.FlowId.Equals(other.FlowId)
                ) &&
                (
                    this.RuleSettings == other.RuleSettings ||
                    this.RuleSettings != null &&
                    this.RuleSettings.Equals(other.RuleSettings)
                ) &&
                (
                    this.UnassignedDivisionContactsEnabled == other.UnassignedDivisionContactsEnabled ||
                    this.UnassignedDivisionContactsEnabled != null &&
                    this.UnassignedDivisionContactsEnabled.Equals(other.UnassignedDivisionContactsEnabled)
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

                if (this.Statuses != null)
                    hash = hash * 59 + this.Statuses.GetHashCode();

                if (this.DefaultWorkbinId != null)
                    hash = hash * 59 + this.DefaultWorkbinId.GetHashCode();

                if (this.DefaultDurationSeconds != null)
                    hash = hash * 59 + this.DefaultDurationSeconds.GetHashCode();

                if (this.DefaultExpirationSeconds != null)
                    hash = hash * 59 + this.DefaultExpirationSeconds.GetHashCode();

                if (this.DefaultDueDurationSeconds != null)
                    hash = hash * 59 + this.DefaultDueDurationSeconds.GetHashCode();

                if (this.DefaultPriority != null)
                    hash = hash * 59 + this.DefaultPriority.GetHashCode();

                if (this.DefaultSkillIds != null)
                    hash = hash * 59 + this.DefaultSkillIds.GetHashCode();

                if (this.DefaultStatusId != null)
                    hash = hash * 59 + this.DefaultStatusId.GetHashCode();

                if (this.DefaultLanguageId != null)
                    hash = hash * 59 + this.DefaultLanguageId.GetHashCode();

                if (this.DefaultTtlSeconds != null)
                    hash = hash * 59 + this.DefaultTtlSeconds.GetHashCode();

                if (this.AssignmentEnabled != null)
                    hash = hash * 59 + this.AssignmentEnabled.GetHashCode();

                if (this.DefaultQueueId != null)
                    hash = hash * 59 + this.DefaultQueueId.GetHashCode();

                if (this.SchemaId != null)
                    hash = hash * 59 + this.SchemaId.GetHashCode();

                if (this.SchemaVersion != null)
                    hash = hash * 59 + this.SchemaVersion.GetHashCode();

                if (this.ServiceLevelTarget != null)
                    hash = hash * 59 + this.ServiceLevelTarget.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DefaultScriptId != null)
                    hash = hash * 59 + this.DefaultScriptId.GetHashCode();

                if (this.FlowId != null)
                    hash = hash * 59 + this.FlowId.GetHashCode();

                if (this.RuleSettings != null)
                    hash = hash * 59 + this.RuleSettings.GetHashCode();

                if (this.UnassignedDivisionContactsEnabled != null)
                    hash = hash * 59 + this.UnassignedDivisionContactsEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
