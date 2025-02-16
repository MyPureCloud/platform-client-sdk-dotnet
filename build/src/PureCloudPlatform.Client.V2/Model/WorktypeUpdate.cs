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
    /// WorktypeUpdate
    /// </summary>
    [DataContract]
    public partial class WorktypeUpdate :  IEquatable<WorktypeUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorktypeUpdate" /> class.
        /// </summary>
        /// <param name="Name">The name of the Worktype. Valid length between 3 and 256 characters..</param>
        /// <param name="DefaultWorkbinId">The ID of the default Workbin for Workitems created from the Worktype..</param>
        /// <param name="DefaultDurationSeconds">The default duration in seconds for Workitems created from the Worktype. Maximum of 365 days..</param>
        /// <param name="DefaultExpirationSeconds">The default expiration time in seconds for Workitems created from the Worktype. Maximum of 365 days..</param>
        /// <param name="DefaultDueDurationSeconds">The default due duration in seconds for Workitems created from the Worktype. Maximum of 365 days..</param>
        /// <param name="DefaultPriority">The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000..</param>
        /// <param name="DefaultTtlSeconds">The default time to time to live in seconds for Workitems created from the Worktype. The valid range is between 1 and 365 days..</param>
        /// <param name="AssignmentEnabled">When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false..</param>
        /// <param name="SchemaId">The ID of the custom attribute schema for Workitems created from the Worktype. Must be a valid UUID..</param>
        /// <param name="ServiceLevelTarget">The target service level for Workitems created from the Worktype. The default value is 100..</param>
        /// <param name="RuleSettings">Settings for the worktypes rules..</param>
        /// <param name="Description">The description of the Worktype. Maximum length of 512 characters..</param>
        /// <param name="DefaultStatusId">The ID of the default status for Workitems created from the Worktype..</param>
        /// <param name="SchemaVersion">The version of the Worktypes custom attribute schema. The latest schema version will be used if this property is not set..</param>
        /// <param name="DefaultLanguageId">The ID of the default language for Workitems created from the Worktype. Must be a valid UUID..</param>
        /// <param name="DefaultSkillIds">The IDs of the default skills for Workitems created from the Worktype. Must be valid UUIDs. Maximum of 20 IDs.</param>
        /// <param name="DefaultQueueId">The ID of the default queue for Workitems created from the Worktype. Must be a valid UUID..</param>
        /// <param name="DefaultScriptId">The default script for Workitems created from the Worktype. Must be a valid UUID..</param>
        public WorktypeUpdate(string Name = null, string DefaultWorkbinId = null, int? DefaultDurationSeconds = null, int? DefaultExpirationSeconds = null, int? DefaultDueDurationSeconds = null, int? DefaultPriority = null, int? DefaultTtlSeconds = null, bool? AssignmentEnabled = null, string SchemaId = null, int? ServiceLevelTarget = null, WorkitemRuleSettings RuleSettings = null, string Description = null, string DefaultStatusId = null, int? SchemaVersion = null, string DefaultLanguageId = null, List<string> DefaultSkillIds = null, string DefaultQueueId = null, string DefaultScriptId = null)
        {
            this.Name = Name;
            this.DefaultWorkbinId = DefaultWorkbinId;
            this.DefaultDurationSeconds = DefaultDurationSeconds;
            this.DefaultExpirationSeconds = DefaultExpirationSeconds;
            this.DefaultDueDurationSeconds = DefaultDueDurationSeconds;
            this.DefaultPriority = DefaultPriority;
            this.DefaultTtlSeconds = DefaultTtlSeconds;
            this.AssignmentEnabled = AssignmentEnabled;
            this.SchemaId = SchemaId;
            this.ServiceLevelTarget = ServiceLevelTarget;
            this.RuleSettings = RuleSettings;
            this.Description = Description;
            this.DefaultStatusId = DefaultStatusId;
            this.SchemaVersion = SchemaVersion;
            this.DefaultLanguageId = DefaultLanguageId;
            this.DefaultSkillIds = DefaultSkillIds;
            this.DefaultQueueId = DefaultQueueId;
            this.DefaultScriptId = DefaultScriptId;
            
        }
        


        /// <summary>
        /// The name of the Worktype. Valid length between 3 and 256 characters.
        /// </summary>
        /// <value>The name of the Worktype. Valid length between 3 and 256 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The ID of the default Workbin for Workitems created from the Worktype.
        /// </summary>
        /// <value>The ID of the default Workbin for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultWorkbinId", EmitDefaultValue=false)]
        public string DefaultWorkbinId { get; set; }



        /// <summary>
        /// The default duration in seconds for Workitems created from the Worktype. Maximum of 365 days.
        /// </summary>
        /// <value>The default duration in seconds for Workitems created from the Worktype. Maximum of 365 days.</value>
        [DataMember(Name="defaultDurationSeconds", EmitDefaultValue=false)]
        public int? DefaultDurationSeconds { get; set; }



        /// <summary>
        /// The default expiration time in seconds for Workitems created from the Worktype. Maximum of 365 days.
        /// </summary>
        /// <value>The default expiration time in seconds for Workitems created from the Worktype. Maximum of 365 days.</value>
        [DataMember(Name="defaultExpirationSeconds", EmitDefaultValue=false)]
        public int? DefaultExpirationSeconds { get; set; }



        /// <summary>
        /// The default due duration in seconds for Workitems created from the Worktype. Maximum of 365 days.
        /// </summary>
        /// <value>The default due duration in seconds for Workitems created from the Worktype. Maximum of 365 days.</value>
        [DataMember(Name="defaultDueDurationSeconds", EmitDefaultValue=false)]
        public int? DefaultDueDurationSeconds { get; set; }



        /// <summary>
        /// The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000.
        /// </summary>
        /// <value>The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000.</value>
        [DataMember(Name="defaultPriority", EmitDefaultValue=false)]
        public int? DefaultPriority { get; set; }



        /// <summary>
        /// The default time to time to live in seconds for Workitems created from the Worktype. The valid range is between 1 and 365 days.
        /// </summary>
        /// <value>The default time to time to live in seconds for Workitems created from the Worktype. The valid range is between 1 and 365 days.</value>
        [DataMember(Name="defaultTtlSeconds", EmitDefaultValue=false)]
        public int? DefaultTtlSeconds { get; set; }



        /// <summary>
        /// When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false.
        /// </summary>
        /// <value>When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false.</value>
        [DataMember(Name="assignmentEnabled", EmitDefaultValue=false)]
        public bool? AssignmentEnabled { get; set; }



        /// <summary>
        /// The ID of the custom attribute schema for Workitems created from the Worktype. Must be a valid UUID.
        /// </summary>
        /// <value>The ID of the custom attribute schema for Workitems created from the Worktype. Must be a valid UUID.</value>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public string SchemaId { get; set; }



        /// <summary>
        /// The target service level for Workitems created from the Worktype. The default value is 100.
        /// </summary>
        /// <value>The target service level for Workitems created from the Worktype. The default value is 100.</value>
        [DataMember(Name="serviceLevelTarget", EmitDefaultValue=false)]
        public int? ServiceLevelTarget { get; set; }



        /// <summary>
        /// Settings for the worktypes rules.
        /// </summary>
        /// <value>Settings for the worktypes rules.</value>
        [DataMember(Name="ruleSettings", EmitDefaultValue=false)]
        public WorkitemRuleSettings RuleSettings { get; set; }



        /// <summary>
        /// The description of the Worktype. Maximum length of 512 characters.
        /// </summary>
        /// <value>The description of the Worktype. Maximum length of 512 characters.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The ID of the default status for Workitems created from the Worktype.
        /// </summary>
        /// <value>The ID of the default status for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultStatusId", EmitDefaultValue=false)]
        public string DefaultStatusId { get; set; }



        /// <summary>
        /// The version of the Worktypes custom attribute schema. The latest schema version will be used if this property is not set.
        /// </summary>
        /// <value>The version of the Worktypes custom attribute schema. The latest schema version will be used if this property is not set.</value>
        [DataMember(Name="schemaVersion", EmitDefaultValue=false)]
        public int? SchemaVersion { get; set; }



        /// <summary>
        /// The ID of the default language for Workitems created from the Worktype. Must be a valid UUID.
        /// </summary>
        /// <value>The ID of the default language for Workitems created from the Worktype. Must be a valid UUID.</value>
        [DataMember(Name="defaultLanguageId", EmitDefaultValue=false)]
        public string DefaultLanguageId { get; set; }



        /// <summary>
        /// The IDs of the default skills for Workitems created from the Worktype. Must be valid UUIDs. Maximum of 20 IDs
        /// </summary>
        /// <value>The IDs of the default skills for Workitems created from the Worktype. Must be valid UUIDs. Maximum of 20 IDs</value>
        [DataMember(Name="defaultSkillIds", EmitDefaultValue=false)]
        public List<string> DefaultSkillIds { get; set; }



        /// <summary>
        /// The ID of the default queue for Workitems created from the Worktype. Must be a valid UUID.
        /// </summary>
        /// <value>The ID of the default queue for Workitems created from the Worktype. Must be a valid UUID.</value>
        [DataMember(Name="defaultQueueId", EmitDefaultValue=false)]
        public string DefaultQueueId { get; set; }



        /// <summary>
        /// The default script for Workitems created from the Worktype. Must be a valid UUID.
        /// </summary>
        /// <value>The default script for Workitems created from the Worktype. Must be a valid UUID.</value>
        [DataMember(Name="defaultScriptId", EmitDefaultValue=false)]
        public string DefaultScriptId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorktypeUpdate {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultWorkbinId: ").Append(DefaultWorkbinId).Append("\n");
            sb.Append("  DefaultDurationSeconds: ").Append(DefaultDurationSeconds).Append("\n");
            sb.Append("  DefaultExpirationSeconds: ").Append(DefaultExpirationSeconds).Append("\n");
            sb.Append("  DefaultDueDurationSeconds: ").Append(DefaultDueDurationSeconds).Append("\n");
            sb.Append("  DefaultPriority: ").Append(DefaultPriority).Append("\n");
            sb.Append("  DefaultTtlSeconds: ").Append(DefaultTtlSeconds).Append("\n");
            sb.Append("  AssignmentEnabled: ").Append(AssignmentEnabled).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  ServiceLevelTarget: ").Append(ServiceLevelTarget).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultStatusId: ").Append(DefaultStatusId).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  DefaultLanguageId: ").Append(DefaultLanguageId).Append("\n");
            sb.Append("  DefaultSkillIds: ").Append(DefaultSkillIds).Append("\n");
            sb.Append("  DefaultQueueId: ").Append(DefaultQueueId).Append("\n");
            sb.Append("  DefaultScriptId: ").Append(DefaultScriptId).Append("\n");
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
            return this.Equals(obj as WorktypeUpdate);
        }

        /// <summary>
        /// Returns true if WorktypeUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of WorktypeUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorktypeUpdate other)
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
                    this.SchemaId == other.SchemaId ||
                    this.SchemaId != null &&
                    this.SchemaId.Equals(other.SchemaId)
                ) &&
                (
                    this.ServiceLevelTarget == other.ServiceLevelTarget ||
                    this.ServiceLevelTarget != null &&
                    this.ServiceLevelTarget.Equals(other.ServiceLevelTarget)
                ) &&
                (
                    this.RuleSettings == other.RuleSettings ||
                    this.RuleSettings != null &&
                    this.RuleSettings.Equals(other.RuleSettings)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DefaultStatusId == other.DefaultStatusId ||
                    this.DefaultStatusId != null &&
                    this.DefaultStatusId.Equals(other.DefaultStatusId)
                ) &&
                (
                    this.SchemaVersion == other.SchemaVersion ||
                    this.SchemaVersion != null &&
                    this.SchemaVersion.Equals(other.SchemaVersion)
                ) &&
                (
                    this.DefaultLanguageId == other.DefaultLanguageId ||
                    this.DefaultLanguageId != null &&
                    this.DefaultLanguageId.Equals(other.DefaultLanguageId)
                ) &&
                (
                    this.DefaultSkillIds == other.DefaultSkillIds ||
                    this.DefaultSkillIds != null &&
                    this.DefaultSkillIds.SequenceEqual(other.DefaultSkillIds)
                ) &&
                (
                    this.DefaultQueueId == other.DefaultQueueId ||
                    this.DefaultQueueId != null &&
                    this.DefaultQueueId.Equals(other.DefaultQueueId)
                ) &&
                (
                    this.DefaultScriptId == other.DefaultScriptId ||
                    this.DefaultScriptId != null &&
                    this.DefaultScriptId.Equals(other.DefaultScriptId)
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

                if (this.DefaultTtlSeconds != null)
                    hash = hash * 59 + this.DefaultTtlSeconds.GetHashCode();

                if (this.AssignmentEnabled != null)
                    hash = hash * 59 + this.AssignmentEnabled.GetHashCode();

                if (this.SchemaId != null)
                    hash = hash * 59 + this.SchemaId.GetHashCode();

                if (this.ServiceLevelTarget != null)
                    hash = hash * 59 + this.ServiceLevelTarget.GetHashCode();

                if (this.RuleSettings != null)
                    hash = hash * 59 + this.RuleSettings.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DefaultStatusId != null)
                    hash = hash * 59 + this.DefaultStatusId.GetHashCode();

                if (this.SchemaVersion != null)
                    hash = hash * 59 + this.SchemaVersion.GetHashCode();

                if (this.DefaultLanguageId != null)
                    hash = hash * 59 + this.DefaultLanguageId.GetHashCode();

                if (this.DefaultSkillIds != null)
                    hash = hash * 59 + this.DefaultSkillIds.GetHashCode();

                if (this.DefaultQueueId != null)
                    hash = hash * 59 + this.DefaultQueueId.GetHashCode();

                if (this.DefaultScriptId != null)
                    hash = hash * 59 + this.DefaultScriptId.GetHashCode();

                return hash;
            }
        }
    }

}
