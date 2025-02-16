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
    /// Worktype
    /// </summary>
    [DataContract]
    public partial class Worktype :  IEquatable<Worktype>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Worktype" /> class.
        /// </summary>
        /// <param name="Name">The name of the Worktype..</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Description">The description of the Worktype..</param>
        /// <param name="DateCreated">The creation date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The modified date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DefaultWorkbin">The default Workbin for Workitems created from the Worktype..</param>
        /// <param name="DefaultStatus">The default status for Workitems created from the Worktype..</param>
        /// <param name="Statuses">The list of possible statuses for Workitems created from the Worktype..</param>
        /// <param name="DefaultDurationSeconds">The default duration in seconds for Workitems created from the Worktype..</param>
        /// <param name="DefaultExpirationSeconds">The default expiration time in seconds for Workitems created from the Worktype..</param>
        /// <param name="DefaultDueDurationSeconds">The default due duration in seconds for Workitems created from the Worktype..</param>
        /// <param name="DefaultPriority">The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000..</param>
        /// <param name="DefaultLanguage">The default language for Workitems created from the Worktype..</param>
        /// <param name="DefaultTtlSeconds">The default time to time to live in seconds for Workitems created from the Worktype..</param>
        /// <param name="ModifiedBy">The id of the User who modified the Worktype..</param>
        /// <param name="DefaultQueue">The default queue for Workitems created from the Worktype..</param>
        /// <param name="DefaultSkills">The default skills for Workitems created from the Worktype..</param>
        /// <param name="AssignmentEnabled">When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false..</param>
        /// <param name="Schema">The schema defining the custom attributes for Workitems created from the Worktype..</param>
        /// <param name="ServiceLevelTarget">The target service level for Workitems created from the Worktype. The default value is 100..</param>
        /// <param name="RuleSettings">Settings for the worktypes rules..</param>
        /// <param name="Flow">The flow associated with the Worktype..</param>
        /// <param name="DefaultScript">The default script for Workitems created from the Worktype..</param>
        public Worktype(string Name = null, Division Division = null, string Description = null, DateTime? DateCreated = null, DateTime? DateModified = null, WorkbinReference DefaultWorkbin = null, WorkitemStatusReference DefaultStatus = null, List<WorkitemStatus> Statuses = null, int? DefaultDurationSeconds = null, int? DefaultExpirationSeconds = null, int? DefaultDueDurationSeconds = null, int? DefaultPriority = null, LanguageReference DefaultLanguage = null, int? DefaultTtlSeconds = null, UserReference ModifiedBy = null, WorkitemQueueReference DefaultQueue = null, List<RoutingSkillReference> DefaultSkills = null, bool? AssignmentEnabled = null, WorkitemSchema Schema = null, int? ServiceLevelTarget = null, WorkitemRuleSettings RuleSettings = null, WorkitemFlowReference Flow = null, WorkitemScriptReference DefaultScript = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.Description = Description;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.DefaultWorkbin = DefaultWorkbin;
            this.DefaultStatus = DefaultStatus;
            this.Statuses = Statuses;
            this.DefaultDurationSeconds = DefaultDurationSeconds;
            this.DefaultExpirationSeconds = DefaultExpirationSeconds;
            this.DefaultDueDurationSeconds = DefaultDueDurationSeconds;
            this.DefaultPriority = DefaultPriority;
            this.DefaultLanguage = DefaultLanguage;
            this.DefaultTtlSeconds = DefaultTtlSeconds;
            this.ModifiedBy = ModifiedBy;
            this.DefaultQueue = DefaultQueue;
            this.DefaultSkills = DefaultSkills;
            this.AssignmentEnabled = AssignmentEnabled;
            this.Schema = Schema;
            this.ServiceLevelTarget = ServiceLevelTarget;
            this.RuleSettings = RuleSettings;
            this.Flow = Flow;
            this.DefaultScript = DefaultScript;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the Worktype.
        /// </summary>
        /// <value>The name of the Worktype.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public Division Division { get; set; }



        /// <summary>
        /// The description of the Worktype.
        /// </summary>
        /// <value>The description of the Worktype.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The creation date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The creation date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The modified date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The modified date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The default Workbin for Workitems created from the Worktype.
        /// </summary>
        /// <value>The default Workbin for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultWorkbin", EmitDefaultValue=false)]
        public WorkbinReference DefaultWorkbin { get; set; }



        /// <summary>
        /// The default status for Workitems created from the Worktype.
        /// </summary>
        /// <value>The default status for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultStatus", EmitDefaultValue=false)]
        public WorkitemStatusReference DefaultStatus { get; set; }



        /// <summary>
        /// The list of possible statuses for Workitems created from the Worktype.
        /// </summary>
        /// <value>The list of possible statuses for Workitems created from the Worktype.</value>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public List<WorkitemStatus> Statuses { get; set; }



        /// <summary>
        /// The default duration in seconds for Workitems created from the Worktype.
        /// </summary>
        /// <value>The default duration in seconds for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultDurationSeconds", EmitDefaultValue=false)]
        public int? DefaultDurationSeconds { get; set; }



        /// <summary>
        /// The default expiration time in seconds for Workitems created from the Worktype.
        /// </summary>
        /// <value>The default expiration time in seconds for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultExpirationSeconds", EmitDefaultValue=false)]
        public int? DefaultExpirationSeconds { get; set; }



        /// <summary>
        /// The default due duration in seconds for Workitems created from the Worktype.
        /// </summary>
        /// <value>The default due duration in seconds for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultDueDurationSeconds", EmitDefaultValue=false)]
        public int? DefaultDueDurationSeconds { get; set; }



        /// <summary>
        /// The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000.
        /// </summary>
        /// <value>The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000.</value>
        [DataMember(Name="defaultPriority", EmitDefaultValue=false)]
        public int? DefaultPriority { get; set; }



        /// <summary>
        /// The default language for Workitems created from the Worktype.
        /// </summary>
        /// <value>The default language for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultLanguage", EmitDefaultValue=false)]
        public LanguageReference DefaultLanguage { get; set; }



        /// <summary>
        /// The default time to time to live in seconds for Workitems created from the Worktype.
        /// </summary>
        /// <value>The default time to time to live in seconds for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultTtlSeconds", EmitDefaultValue=false)]
        public int? DefaultTtlSeconds { get; set; }



        /// <summary>
        /// The id of the User who modified the Worktype.
        /// </summary>
        /// <value>The id of the User who modified the Worktype.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; set; }



        /// <summary>
        /// The default queue for Workitems created from the Worktype.
        /// </summary>
        /// <value>The default queue for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultQueue", EmitDefaultValue=false)]
        public WorkitemQueueReference DefaultQueue { get; set; }



        /// <summary>
        /// The default skills for Workitems created from the Worktype.
        /// </summary>
        /// <value>The default skills for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultSkills", EmitDefaultValue=false)]
        public List<RoutingSkillReference> DefaultSkills { get; set; }



        /// <summary>
        /// When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false.
        /// </summary>
        /// <value>When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false.</value>
        [DataMember(Name="assignmentEnabled", EmitDefaultValue=false)]
        public bool? AssignmentEnabled { get; set; }



        /// <summary>
        /// The schema defining the custom attributes for Workitems created from the Worktype.
        /// </summary>
        /// <value>The schema defining the custom attributes for Workitems created from the Worktype.</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public WorkitemSchema Schema { get; set; }



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
        /// The flow associated with the Worktype.
        /// </summary>
        /// <value>The flow associated with the Worktype.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public WorkitemFlowReference Flow { get; set; }



        /// <summary>
        /// The default script for Workitems created from the Worktype.
        /// </summary>
        /// <value>The default script for Workitems created from the Worktype.</value>
        [DataMember(Name="defaultScript", EmitDefaultValue=false)]
        public WorkitemScriptReference DefaultScript { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Worktype {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DefaultWorkbin: ").Append(DefaultWorkbin).Append("\n");
            sb.Append("  DefaultStatus: ").Append(DefaultStatus).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  DefaultDurationSeconds: ").Append(DefaultDurationSeconds).Append("\n");
            sb.Append("  DefaultExpirationSeconds: ").Append(DefaultExpirationSeconds).Append("\n");
            sb.Append("  DefaultDueDurationSeconds: ").Append(DefaultDueDurationSeconds).Append("\n");
            sb.Append("  DefaultPriority: ").Append(DefaultPriority).Append("\n");
            sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  DefaultTtlSeconds: ").Append(DefaultTtlSeconds).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DefaultQueue: ").Append(DefaultQueue).Append("\n");
            sb.Append("  DefaultSkills: ").Append(DefaultSkills).Append("\n");
            sb.Append("  AssignmentEnabled: ").Append(AssignmentEnabled).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  ServiceLevelTarget: ").Append(ServiceLevelTarget).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  DefaultScript: ").Append(DefaultScript).Append("\n");
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
            return this.Equals(obj as Worktype);
        }

        /// <summary>
        /// Returns true if Worktype instances are equal
        /// </summary>
        /// <param name="other">Instance of Worktype to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Worktype other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                    this.DefaultWorkbin == other.DefaultWorkbin ||
                    this.DefaultWorkbin != null &&
                    this.DefaultWorkbin.Equals(other.DefaultWorkbin)
                ) &&
                (
                    this.DefaultStatus == other.DefaultStatus ||
                    this.DefaultStatus != null &&
                    this.DefaultStatus.Equals(other.DefaultStatus)
                ) &&
                (
                    this.Statuses == other.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.SequenceEqual(other.Statuses)
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
                    this.DefaultLanguage == other.DefaultLanguage ||
                    this.DefaultLanguage != null &&
                    this.DefaultLanguage.Equals(other.DefaultLanguage)
                ) &&
                (
                    this.DefaultTtlSeconds == other.DefaultTtlSeconds ||
                    this.DefaultTtlSeconds != null &&
                    this.DefaultTtlSeconds.Equals(other.DefaultTtlSeconds)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.DefaultQueue == other.DefaultQueue ||
                    this.DefaultQueue != null &&
                    this.DefaultQueue.Equals(other.DefaultQueue)
                ) &&
                (
                    this.DefaultSkills == other.DefaultSkills ||
                    this.DefaultSkills != null &&
                    this.DefaultSkills.SequenceEqual(other.DefaultSkills)
                ) &&
                (
                    this.AssignmentEnabled == other.AssignmentEnabled ||
                    this.AssignmentEnabled != null &&
                    this.AssignmentEnabled.Equals(other.AssignmentEnabled)
                ) &&
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
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
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
                ) &&
                (
                    this.DefaultScript == other.DefaultScript ||
                    this.DefaultScript != null &&
                    this.DefaultScript.Equals(other.DefaultScript)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DefaultWorkbin != null)
                    hash = hash * 59 + this.DefaultWorkbin.GetHashCode();

                if (this.DefaultStatus != null)
                    hash = hash * 59 + this.DefaultStatus.GetHashCode();

                if (this.Statuses != null)
                    hash = hash * 59 + this.Statuses.GetHashCode();

                if (this.DefaultDurationSeconds != null)
                    hash = hash * 59 + this.DefaultDurationSeconds.GetHashCode();

                if (this.DefaultExpirationSeconds != null)
                    hash = hash * 59 + this.DefaultExpirationSeconds.GetHashCode();

                if (this.DefaultDueDurationSeconds != null)
                    hash = hash * 59 + this.DefaultDueDurationSeconds.GetHashCode();

                if (this.DefaultPriority != null)
                    hash = hash * 59 + this.DefaultPriority.GetHashCode();

                if (this.DefaultLanguage != null)
                    hash = hash * 59 + this.DefaultLanguage.GetHashCode();

                if (this.DefaultTtlSeconds != null)
                    hash = hash * 59 + this.DefaultTtlSeconds.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DefaultQueue != null)
                    hash = hash * 59 + this.DefaultQueue.GetHashCode();

                if (this.DefaultSkills != null)
                    hash = hash * 59 + this.DefaultSkills.GetHashCode();

                if (this.AssignmentEnabled != null)
                    hash = hash * 59 + this.AssignmentEnabled.GetHashCode();

                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();

                if (this.ServiceLevelTarget != null)
                    hash = hash * 59 + this.ServiceLevelTarget.GetHashCode();

                if (this.RuleSettings != null)
                    hash = hash * 59 + this.RuleSettings.GetHashCode();

                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();

                if (this.DefaultScript != null)
                    hash = hash * 59 + this.DefaultScript.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
