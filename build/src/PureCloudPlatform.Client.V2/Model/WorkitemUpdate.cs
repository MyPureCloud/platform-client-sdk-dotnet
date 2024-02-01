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
    /// WorkitemUpdate
    /// </summary>
    [DataContract]
    public partial class WorkitemUpdate :  IEquatable<WorkitemUpdate>
    {
        /// <summary>
        /// The assignment state of the Workitem.
        /// </summary>
        /// <value>The assignment state of the Workitem.</value>
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
        /// Set this value to AgentAssignmentAlerting and supply an 'assigneeId' to assign the workitem to an agent and alert the agent of the assignment. Set this value to QueueAssignmentAlerting and supply a 'queueId' to route the workitem to an agent who is a member of the queue and alert the agent.
        /// </summary>
        /// <value>Set this value to AgentAssignmentAlerting and supply an 'assigneeId' to assign the workitem to an agent and alert the agent of the assignment. Set this value to QueueAssignmentAlerting and supply a 'queueId' to route the workitem to an agent who is a member of the queue and alert the agent.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AssignmentOperationEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agentassignmentalerting for "AgentAssignmentAlerting"
            /// </summary>
            [EnumMember(Value = "AgentAssignmentAlerting")]
            Agentassignmentalerting,
            
            /// <summary>
            /// Enum Queueassignmentalerting for "QueueAssignmentAlerting"
            /// </summary>
            [EnumMember(Value = "QueueAssignmentAlerting")]
            Queueassignmentalerting
        }
        /// <summary>
        /// The assignment state of the Workitem.
        /// </summary>
        /// <value>The assignment state of the Workitem.</value>
        [DataMember(Name="assignmentState", EmitDefaultValue=false)]
        public AssignmentStateEnum? AssignmentState { get; set; }
        /// <summary>
        /// Set this value to AgentAssignmentAlerting and supply an 'assigneeId' to assign the workitem to an agent and alert the agent of the assignment. Set this value to QueueAssignmentAlerting and supply a 'queueId' to route the workitem to an agent who is a member of the queue and alert the agent.
        /// </summary>
        /// <value>Set this value to AgentAssignmentAlerting and supply an 'assigneeId' to assign the workitem to an agent and alert the agent of the assignment. Set this value to QueueAssignmentAlerting and supply a 'queueId' to route the workitem to an agent who is a member of the queue and alert the agent.</value>
        [DataMember(Name="assignmentOperation", EmitDefaultValue=false)]
        public AssignmentOperationEnum? AssignmentOperation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemUpdate" /> class.
        /// </summary>
        /// <param name="Name">The name of the Workitem. Valid length between 3 and 256 characters..</param>
        /// <param name="Priority">The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000..</param>
        /// <param name="DateDue">The due date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateExpires">The expiry date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DurationSeconds">The estimated duration in seconds to complete the Workitem. Maximum of 365 days..</param>
        /// <param name="Ttl">The epoch timestamp in seconds specifying the time to live for the Workitem. Can not be greater than 365 days from the current time..</param>
        /// <param name="StatusId">The ID of the Status of the Workitem..</param>
        /// <param name="WorkbinId">The ID of Workbin that contains the Workitem..</param>
        /// <param name="AutoStatusTransition">Set it to false to disable auto status transition. By default, it is enabled..</param>
        /// <param name="Description">The description of the Workitem. Maximum length of 4096 characters..</param>
        /// <param name="DateClosed">The closed date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="AssignmentState">The assignment state of the Workitem..</param>
        /// <param name="AssignmentOperation">Set this value to AgentAssignmentAlerting and supply an 'assigneeId' to assign the workitem to an agent and alert the agent of the assignment. Set this value to QueueAssignmentAlerting and supply a 'queueId' to route the workitem to an agent who is a member of the queue and alert the agent..</param>
        /// <param name="CustomFields">Custom fields defined in the schema referenced by the worktype of the workitem. If set to {}, the existing keys and values will be removed..</param>
        /// <param name="QueueId">The ID of the Workitems queue. Must be a valid UUID..</param>
        /// <param name="AssigneeId">The ID of the assignee of the Workitem. If supplied it must be a valid UUID..</param>
        /// <param name="ScoredAgents">A list of scored agents for the Workitem. A workitem can have a maximum of 20 scored agents..</param>
        /// <param name="ExternalContactId">The ID of the external contact of the Workitem. Must be a valid UUID..</param>
        /// <param name="ExternalTag">The external tag of the Workitem..</param>
        /// <param name="SkillIds">The skill IDs of the Workitem. Must be valid UUIDs..</param>
        /// <param name="LanguageId">The ID of language of the Workitem. Must be a valid UUID..</param>
        /// <param name="UtilizationLabelId">The ID of the utilization label of the Workitem. Must be a valid UUID..</param>
        /// <param name="PreferredAgentIds">The preferred agent IDs of the Workitem. Must be valid UUIDs..</param>
        public WorkitemUpdate(string Name = null, int? Priority = null, DateTime? DateDue = null, DateTime? DateExpires = null, int? DurationSeconds = null, int? Ttl = null, string StatusId = null, string WorkbinId = null, bool? AutoStatusTransition = null, string Description = null, DateTime? DateClosed = null, AssignmentStateEnum? AssignmentState = null, AssignmentOperationEnum? AssignmentOperation = null, Dictionary<string, Object> CustomFields = null, string QueueId = null, string AssigneeId = null, List<WorkitemScoredAgentRequest> ScoredAgents = null, string ExternalContactId = null, string ExternalTag = null, List<string> SkillIds = null, string LanguageId = null, string UtilizationLabelId = null, List<string> PreferredAgentIds = null)
        {
            this.Name = Name;
            this.Priority = Priority;
            this.DateDue = DateDue;
            this.DateExpires = DateExpires;
            this.DurationSeconds = DurationSeconds;
            this.Ttl = Ttl;
            this.StatusId = StatusId;
            this.WorkbinId = WorkbinId;
            this.AutoStatusTransition = AutoStatusTransition;
            this.Description = Description;
            this.DateClosed = DateClosed;
            this.AssignmentState = AssignmentState;
            this.AssignmentOperation = AssignmentOperation;
            this.CustomFields = CustomFields;
            this.QueueId = QueueId;
            this.AssigneeId = AssigneeId;
            this.ScoredAgents = ScoredAgents;
            this.ExternalContactId = ExternalContactId;
            this.ExternalTag = ExternalTag;
            this.SkillIds = SkillIds;
            this.LanguageId = LanguageId;
            this.UtilizationLabelId = UtilizationLabelId;
            this.PreferredAgentIds = PreferredAgentIds;
            
        }
        


        /// <summary>
        /// The name of the Workitem. Valid length between 3 and 256 characters.
        /// </summary>
        /// <value>The name of the Workitem. Valid length between 3 and 256 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000.
        /// </summary>
        /// <value>The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }



        /// <summary>
        /// The due date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The due date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateDue", EmitDefaultValue=false)]
        public DateTime? DateDue { get; set; }



        /// <summary>
        /// The expiry date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The expiry date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateExpires", EmitDefaultValue=false)]
        public DateTime? DateExpires { get; set; }



        /// <summary>
        /// The estimated duration in seconds to complete the Workitem. Maximum of 365 days.
        /// </summary>
        /// <value>The estimated duration in seconds to complete the Workitem. Maximum of 365 days.</value>
        [DataMember(Name="durationSeconds", EmitDefaultValue=false)]
        public int? DurationSeconds { get; set; }



        /// <summary>
        /// The epoch timestamp in seconds specifying the time to live for the Workitem. Can not be greater than 365 days from the current time.
        /// </summary>
        /// <value>The epoch timestamp in seconds specifying the time to live for the Workitem. Can not be greater than 365 days from the current time.</value>
        [DataMember(Name="ttl", EmitDefaultValue=false)]
        public int? Ttl { get; set; }



        /// <summary>
        /// The ID of the Status of the Workitem.
        /// </summary>
        /// <value>The ID of the Status of the Workitem.</value>
        [DataMember(Name="statusId", EmitDefaultValue=false)]
        public string StatusId { get; set; }



        /// <summary>
        /// The ID of Workbin that contains the Workitem.
        /// </summary>
        /// <value>The ID of Workbin that contains the Workitem.</value>
        [DataMember(Name="workbinId", EmitDefaultValue=false)]
        public string WorkbinId { get; set; }



        /// <summary>
        /// Set it to false to disable auto status transition. By default, it is enabled.
        /// </summary>
        /// <value>Set it to false to disable auto status transition. By default, it is enabled.</value>
        [DataMember(Name="autoStatusTransition", EmitDefaultValue=false)]
        public bool? AutoStatusTransition { get; set; }



        /// <summary>
        /// The description of the Workitem. Maximum length of 4096 characters.
        /// </summary>
        /// <value>The description of the Workitem. Maximum length of 4096 characters.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The closed date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The closed date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateClosed", EmitDefaultValue=false)]
        public DateTime? DateClosed { get; set; }







        /// <summary>
        /// Custom fields defined in the schema referenced by the worktype of the workitem. If set to {}, the existing keys and values will be removed.
        /// </summary>
        /// <value>Custom fields defined in the schema referenced by the worktype of the workitem. If set to {}, the existing keys and values will be removed.</value>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }



        /// <summary>
        /// The ID of the Workitems queue. Must be a valid UUID.
        /// </summary>
        /// <value>The ID of the Workitems queue. Must be a valid UUID.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// The ID of the assignee of the Workitem. If supplied it must be a valid UUID.
        /// </summary>
        /// <value>The ID of the assignee of the Workitem. If supplied it must be a valid UUID.</value>
        [DataMember(Name="assigneeId", EmitDefaultValue=false)]
        public string AssigneeId { get; set; }



        /// <summary>
        /// A list of scored agents for the Workitem. A workitem can have a maximum of 20 scored agents.
        /// </summary>
        /// <value>A list of scored agents for the Workitem. A workitem can have a maximum of 20 scored agents.</value>
        [DataMember(Name="scoredAgents", EmitDefaultValue=false)]
        public List<WorkitemScoredAgentRequest> ScoredAgents { get; set; }



        /// <summary>
        /// The ID of the external contact of the Workitem. Must be a valid UUID.
        /// </summary>
        /// <value>The ID of the external contact of the Workitem. Must be a valid UUID.</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }



        /// <summary>
        /// The external tag of the Workitem.
        /// </summary>
        /// <value>The external tag of the Workitem.</value>
        [DataMember(Name="externalTag", EmitDefaultValue=false)]
        public string ExternalTag { get; set; }



        /// <summary>
        /// The skill IDs of the Workitem. Must be valid UUIDs.
        /// </summary>
        /// <value>The skill IDs of the Workitem. Must be valid UUIDs.</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }



        /// <summary>
        /// The ID of language of the Workitem. Must be a valid UUID.
        /// </summary>
        /// <value>The ID of language of the Workitem. Must be a valid UUID.</value>
        [DataMember(Name="languageId", EmitDefaultValue=false)]
        public string LanguageId { get; set; }



        /// <summary>
        /// The ID of the utilization label of the Workitem. Must be a valid UUID.
        /// </summary>
        /// <value>The ID of the utilization label of the Workitem. Must be a valid UUID.</value>
        [DataMember(Name="utilizationLabelId", EmitDefaultValue=false)]
        public string UtilizationLabelId { get; set; }



        /// <summary>
        /// The preferred agent IDs of the Workitem. Must be valid UUIDs.
        /// </summary>
        /// <value>The preferred agent IDs of the Workitem. Must be valid UUIDs.</value>
        [DataMember(Name="preferredAgentIds", EmitDefaultValue=false)]
        public List<string> PreferredAgentIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemUpdate {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  DateDue: ").Append(DateDue).Append("\n");
            sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
            sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  WorkbinId: ").Append(WorkbinId).Append("\n");
            sb.Append("  AutoStatusTransition: ").Append(AutoStatusTransition).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
            sb.Append("  AssignmentState: ").Append(AssignmentState).Append("\n");
            sb.Append("  AssignmentOperation: ").Append(AssignmentOperation).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
            sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
            sb.Append("  PreferredAgentIds: ").Append(PreferredAgentIds).Append("\n");
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
            return this.Equals(obj as WorkitemUpdate);
        }

        /// <summary>
        /// Returns true if WorkitemUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemUpdate other)
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
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
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
                    this.StatusId == other.StatusId ||
                    this.StatusId != null &&
                    this.StatusId.Equals(other.StatusId)
                ) &&
                (
                    this.WorkbinId == other.WorkbinId ||
                    this.WorkbinId != null &&
                    this.WorkbinId.Equals(other.WorkbinId)
                ) &&
                (
                    this.AutoStatusTransition == other.AutoStatusTransition ||
                    this.AutoStatusTransition != null &&
                    this.AutoStatusTransition.Equals(other.AutoStatusTransition)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                    this.AssignmentOperation == other.AssignmentOperation ||
                    this.AssignmentOperation != null &&
                    this.AssignmentOperation.Equals(other.AssignmentOperation)
                ) &&
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.AssigneeId == other.AssigneeId ||
                    this.AssigneeId != null &&
                    this.AssigneeId.Equals(other.AssigneeId)
                ) &&
                (
                    this.ScoredAgents == other.ScoredAgents ||
                    this.ScoredAgents != null &&
                    this.ScoredAgents.SequenceEqual(other.ScoredAgents)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.ExternalTag == other.ExternalTag ||
                    this.ExternalTag != null &&
                    this.ExternalTag.Equals(other.ExternalTag)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
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
                    this.PreferredAgentIds == other.PreferredAgentIds ||
                    this.PreferredAgentIds != null &&
                    this.PreferredAgentIds.SequenceEqual(other.PreferredAgentIds)
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

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.DateDue != null)
                    hash = hash * 59 + this.DateDue.GetHashCode();

                if (this.DateExpires != null)
                    hash = hash * 59 + this.DateExpires.GetHashCode();

                if (this.DurationSeconds != null)
                    hash = hash * 59 + this.DurationSeconds.GetHashCode();

                if (this.Ttl != null)
                    hash = hash * 59 + this.Ttl.GetHashCode();

                if (this.StatusId != null)
                    hash = hash * 59 + this.StatusId.GetHashCode();

                if (this.WorkbinId != null)
                    hash = hash * 59 + this.WorkbinId.GetHashCode();

                if (this.AutoStatusTransition != null)
                    hash = hash * 59 + this.AutoStatusTransition.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DateClosed != null)
                    hash = hash * 59 + this.DateClosed.GetHashCode();

                if (this.AssignmentState != null)
                    hash = hash * 59 + this.AssignmentState.GetHashCode();

                if (this.AssignmentOperation != null)
                    hash = hash * 59 + this.AssignmentOperation.GetHashCode();

                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.AssigneeId != null)
                    hash = hash * 59 + this.AssigneeId.GetHashCode();

                if (this.ScoredAgents != null)
                    hash = hash * 59 + this.ScoredAgents.GetHashCode();

                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                if (this.ExternalTag != null)
                    hash = hash * 59 + this.ExternalTag.GetHashCode();

                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();

                if (this.LanguageId != null)
                    hash = hash * 59 + this.LanguageId.GetHashCode();

                if (this.UtilizationLabelId != null)
                    hash = hash * 59 + this.UtilizationLabelId.GetHashCode();

                if (this.PreferredAgentIds != null)
                    hash = hash * 59 + this.PreferredAgentIds.GetHashCode();

                return hash;
            }
        }
    }

}
