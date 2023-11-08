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
    /// Evaluation
    /// </summary>
    [DataContract]
    public partial class Evaluation :  IEquatable<Evaluation>
    {
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
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending,
            
            /// <summary>
            /// Enum Inprogress for "INPROGRESS"
            /// </summary>
            [EnumMember(Value = "INPROGRESS")]
            Inprogress,
            
            /// <summary>
            /// Enum Finished for "FINISHED"
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            Finished,
            
            /// <summary>
            /// Enum Inreview for "INREVIEW"
            /// </summary>
            [EnumMember(Value = "INREVIEW")]
            Inreview,
            
            /// <summary>
            /// Enum Retracted for "RETRACTED"
            /// </summary>
            [EnumMember(Value = "RETRACTED")]
            Retracted
        }
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Call for "CALL"
            /// </summary>
            [EnumMember(Value = "CALL")]
            Call,
            
            /// <summary>
            /// Enum Callback for "CALLBACK"
            /// </summary>
            [EnumMember(Value = "CALLBACK")]
            Callback,
            
            /// <summary>
            /// Enum Chat for "CHAT"
            /// </summary>
            [EnumMember(Value = "CHAT")]
            Chat,
            
            /// <summary>
            /// Enum Cobrowse for "COBROWSE"
            /// </summary>
            [EnumMember(Value = "COBROWSE")]
            Cobrowse,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email,
            
            /// <summary>
            /// Enum Message for "MESSAGE"
            /// </summary>
            [EnumMember(Value = "MESSAGE")]
            Message,
            
            /// <summary>
            /// Enum SocialExpression for "SOCIAL_EXPRESSION"
            /// </summary>
            [EnumMember(Value = "SOCIAL_EXPRESSION")]
            SocialExpression,
            
            /// <summary>
            /// Enum Video for "VIDEO"
            /// </summary>
            [EnumMember(Value = "VIDEO")]
            Video,
            
            /// <summary>
            /// Enum Screenshare for "SCREENSHARE"
            /// </summary>
            [EnumMember(Value = "SCREENSHARE")]
            Screenshare
        }
        /// <summary>
        /// The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.
        /// </summary>
        /// <value>The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ResourceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.
        /// </summary>
        /// <value>The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.</value>
        [DataMember(Name="resourceType", EmitDefaultValue=false)]
        public ResourceTypeEnum? ResourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Evaluation" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Conversation">Conversation.</param>
        /// <param name="EvaluationForm">Evaluation form used for evaluation..</param>
        /// <param name="Evaluator">Evaluator.</param>
        /// <param name="Agent">Agent.</param>
        /// <param name="Calibration">Calibration.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Answers">Answers.</param>
        /// <param name="AgentHasRead">AgentHasRead.</param>
        /// <param name="Assignee">Assignee.</param>
        /// <param name="AssigneeApplicable">Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable..</param>
        /// <param name="ReleaseDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="AssignedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ChangedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="RevisionCreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="MediaType">List of different communication types used in conversation..</param>
        /// <param name="Rescore">Is only true when evaluation is re-scored..</param>
        /// <param name="ConversationDate">Date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ConversationEndDate">End date of conversation if it had completed before evaluation creation. Null if created before the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="NeverRelease">Signifies if the evaluation is never to be released. This cannot be set true if release date is also set..</param>
        /// <param name="Assigned">Set to false to unassign the evaluation. This cannot be set to false when assignee is also set..</param>
        /// <param name="DateAssigneeChanged">Date when the assignee was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ResourceId">Only used for email evaluations. Will be null for all other evaluations..</param>
        /// <param name="ResourceType">The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources..</param>
        /// <param name="Redacted">Is only true when the user making the request does not have sufficient permissions to see evaluation.</param>
        /// <param name="IsScoringIndex">IsScoringIndex.</param>
        /// <param name="AuthorizedActions">List of user authorized actions on evaluation. Possible values: assign, edit, editScore, editAgentSignoff, delete, release, viewAudit.</param>
        /// <param name="HasAssistanceFailed">Is true when evaluation assistance didn't execute successfully.</param>
        public Evaluation(string Name = null, ConversationReference Conversation = null, EvaluationForm EvaluationForm = null, User Evaluator = null, User Agent = null, Calibration Calibration = null, StatusEnum? Status = null, EvaluationScoringSet Answers = null, bool? AgentHasRead = null, User Assignee = null, bool? AssigneeApplicable = null, DateTime? ReleaseDate = null, DateTime? AssignedDate = null, DateTime? ChangedDate = null, DateTime? RevisionCreatedDate = null, Queue Queue = null, List<MediaTypeEnum> MediaType = null, bool? Rescore = null, DateTime? ConversationDate = null, DateTime? ConversationEndDate = null, bool? NeverRelease = null, bool? Assigned = null, DateTime? DateAssigneeChanged = null, string ResourceId = null, ResourceTypeEnum? ResourceType = null, bool? Redacted = null, bool? IsScoringIndex = null, List<string> AuthorizedActions = null, bool? HasAssistanceFailed = null)
        {
            this.Name = Name;
            this.Conversation = Conversation;
            this.EvaluationForm = EvaluationForm;
            this.Evaluator = Evaluator;
            this.Agent = Agent;
            this.Calibration = Calibration;
            this.Status = Status;
            this.Answers = Answers;
            this.AgentHasRead = AgentHasRead;
            this.Assignee = Assignee;
            this.AssigneeApplicable = AssigneeApplicable;
            this.ReleaseDate = ReleaseDate;
            this.AssignedDate = AssignedDate;
            this.ChangedDate = ChangedDate;
            this.RevisionCreatedDate = RevisionCreatedDate;
            this.Queue = Queue;
            this.MediaType = MediaType;
            this.Rescore = Rescore;
            this.ConversationDate = ConversationDate;
            this.ConversationEndDate = ConversationEndDate;
            this.NeverRelease = NeverRelease;
            this.Assigned = Assigned;
            this.DateAssigneeChanged = DateAssigneeChanged;
            this.ResourceId = ResourceId;
            this.ResourceType = ResourceType;
            this.Redacted = Redacted;
            this.IsScoringIndex = IsScoringIndex;
            this.AuthorizedActions = AuthorizedActions;
            this.HasAssistanceFailed = HasAssistanceFailed;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public ConversationReference Conversation { get; set; }



        /// <summary>
        /// Evaluation form used for evaluation.
        /// </summary>
        /// <value>Evaluation form used for evaluation.</value>
        [DataMember(Name="evaluationForm", EmitDefaultValue=false)]
        public EvaluationForm EvaluationForm { get; set; }



        /// <summary>
        /// Gets or Sets Evaluator
        /// </summary>
        [DataMember(Name="evaluator", EmitDefaultValue=false)]
        public User Evaluator { get; set; }



        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public User Agent { get; set; }



        /// <summary>
        /// Gets or Sets Calibration
        /// </summary>
        [DataMember(Name="calibration", EmitDefaultValue=false)]
        public Calibration Calibration { get; set; }





        /// <summary>
        /// Gets or Sets Answers
        /// </summary>
        [DataMember(Name="answers", EmitDefaultValue=false)]
        public EvaluationScoringSet Answers { get; set; }



        /// <summary>
        /// Gets or Sets AgentHasRead
        /// </summary>
        [DataMember(Name="agentHasRead", EmitDefaultValue=false)]
        public bool? AgentHasRead { get; set; }



        /// <summary>
        /// Gets or Sets Assignee
        /// </summary>
        [DataMember(Name="assignee", EmitDefaultValue=false)]
        public User Assignee { get; set; }



        /// <summary>
        /// Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable.
        /// </summary>
        /// <value>Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable.</value>
        [DataMember(Name="assigneeApplicable", EmitDefaultValue=false)]
        public bool? AssigneeApplicable { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="releaseDate", EmitDefaultValue=false)]
        public DateTime? ReleaseDate { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="assignedDate", EmitDefaultValue=false)]
        public DateTime? AssignedDate { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="changedDate", EmitDefaultValue=false)]
        public DateTime? ChangedDate { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="revisionCreatedDate", EmitDefaultValue=false)]
        public DateTime? RevisionCreatedDate { get; set; }



        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public Queue Queue { get; set; }



        /// <summary>
        /// List of different communication types used in conversation.
        /// </summary>
        /// <value>List of different communication types used in conversation.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public List<MediaTypeEnum> MediaType { get; set; }



        /// <summary>
        /// Is only true when evaluation is re-scored.
        /// </summary>
        /// <value>Is only true when evaluation is re-scored.</value>
        [DataMember(Name="rescore", EmitDefaultValue=false)]
        public bool? Rescore { get; set; }



        /// <summary>
        /// Date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="conversationDate", EmitDefaultValue=false)]
        public DateTime? ConversationDate { get; set; }



        /// <summary>
        /// End date of conversation if it had completed before evaluation creation. Null if created before the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>End date of conversation if it had completed before evaluation creation. Null if created before the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="conversationEndDate", EmitDefaultValue=false)]
        public DateTime? ConversationEndDate { get; set; }



        /// <summary>
        /// Signifies if the evaluation is never to be released. This cannot be set true if release date is also set.
        /// </summary>
        /// <value>Signifies if the evaluation is never to be released. This cannot be set true if release date is also set.</value>
        [DataMember(Name="neverRelease", EmitDefaultValue=false)]
        public bool? NeverRelease { get; set; }



        /// <summary>
        /// Set to false to unassign the evaluation. This cannot be set to false when assignee is also set.
        /// </summary>
        /// <value>Set to false to unassign the evaluation. This cannot be set to false when assignee is also set.</value>
        [DataMember(Name="assigned", EmitDefaultValue=false)]
        public bool? Assigned { get; set; }



        /// <summary>
        /// Date when the assignee was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the assignee was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateAssigneeChanged", EmitDefaultValue=false)]
        public DateTime? DateAssigneeChanged { get; set; }



        /// <summary>
        /// Only used for email evaluations. Will be null for all other evaluations.
        /// </summary>
        /// <value>Only used for email evaluations. Will be null for all other evaluations.</value>
        [DataMember(Name="resourceId", EmitDefaultValue=false)]
        public string ResourceId { get; set; }





        /// <summary>
        /// Is only true when the user making the request does not have sufficient permissions to see evaluation
        /// </summary>
        /// <value>Is only true when the user making the request does not have sufficient permissions to see evaluation</value>
        [DataMember(Name="redacted", EmitDefaultValue=false)]
        public bool? Redacted { get; set; }



        /// <summary>
        /// Gets or Sets IsScoringIndex
        /// </summary>
        [DataMember(Name="isScoringIndex", EmitDefaultValue=false)]
        public bool? IsScoringIndex { get; set; }



        /// <summary>
        /// List of user authorized actions on evaluation. Possible values: assign, edit, editScore, editAgentSignoff, delete, release, viewAudit
        /// </summary>
        /// <value>List of user authorized actions on evaluation. Possible values: assign, edit, editScore, editAgentSignoff, delete, release, viewAudit</value>
        [DataMember(Name="authorizedActions", EmitDefaultValue=false)]
        public List<string> AuthorizedActions { get; set; }



        /// <summary>
        /// Is true when evaluation assistance didn't execute successfully
        /// </summary>
        /// <value>Is true when evaluation assistance didn't execute successfully</value>
        [DataMember(Name="hasAssistanceFailed", EmitDefaultValue=false)]
        public bool? HasAssistanceFailed { get; set; }



        /// <summary>
        /// The source that created the evaluation.
        /// </summary>
        /// <value>The source that created the evaluation.</value>
        [DataMember(Name="evaluationSource", EmitDefaultValue=false)]
        public EvaluationSource EvaluationSource { get; private set; }



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
            sb.Append("class Evaluation {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
            sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Calibration: ").Append(Calibration).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Answers: ").Append(Answers).Append("\n");
            sb.Append("  AgentHasRead: ").Append(AgentHasRead).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  AssigneeApplicable: ").Append(AssigneeApplicable).Append("\n");
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  AssignedDate: ").Append(AssignedDate).Append("\n");
            sb.Append("  ChangedDate: ").Append(ChangedDate).Append("\n");
            sb.Append("  RevisionCreatedDate: ").Append(RevisionCreatedDate).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Rescore: ").Append(Rescore).Append("\n");
            sb.Append("  ConversationDate: ").Append(ConversationDate).Append("\n");
            sb.Append("  ConversationEndDate: ").Append(ConversationEndDate).Append("\n");
            sb.Append("  NeverRelease: ").Append(NeverRelease).Append("\n");
            sb.Append("  Assigned: ").Append(Assigned).Append("\n");
            sb.Append("  DateAssigneeChanged: ").Append(DateAssigneeChanged).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
            sb.Append("  IsScoringIndex: ").Append(IsScoringIndex).Append("\n");
            sb.Append("  AuthorizedActions: ").Append(AuthorizedActions).Append("\n");
            sb.Append("  HasAssistanceFailed: ").Append(HasAssistanceFailed).Append("\n");
            sb.Append("  EvaluationSource: ").Append(EvaluationSource).Append("\n");
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
            return this.Equals(obj as Evaluation);
        }

        /// <summary>
        /// Returns true if Evaluation instances are equal
        /// </summary>
        /// <param name="other">Instance of Evaluation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Evaluation other)
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
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.EvaluationForm == other.EvaluationForm ||
                    this.EvaluationForm != null &&
                    this.EvaluationForm.Equals(other.EvaluationForm)
                ) &&
                (
                    this.Evaluator == other.Evaluator ||
                    this.Evaluator != null &&
                    this.Evaluator.Equals(other.Evaluator)
                ) &&
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.Calibration == other.Calibration ||
                    this.Calibration != null &&
                    this.Calibration.Equals(other.Calibration)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Answers == other.Answers ||
                    this.Answers != null &&
                    this.Answers.Equals(other.Answers)
                ) &&
                (
                    this.AgentHasRead == other.AgentHasRead ||
                    this.AgentHasRead != null &&
                    this.AgentHasRead.Equals(other.AgentHasRead)
                ) &&
                (
                    this.Assignee == other.Assignee ||
                    this.Assignee != null &&
                    this.Assignee.Equals(other.Assignee)
                ) &&
                (
                    this.AssigneeApplicable == other.AssigneeApplicable ||
                    this.AssigneeApplicable != null &&
                    this.AssigneeApplicable.Equals(other.AssigneeApplicable)
                ) &&
                (
                    this.ReleaseDate == other.ReleaseDate ||
                    this.ReleaseDate != null &&
                    this.ReleaseDate.Equals(other.ReleaseDate)
                ) &&
                (
                    this.AssignedDate == other.AssignedDate ||
                    this.AssignedDate != null &&
                    this.AssignedDate.Equals(other.AssignedDate)
                ) &&
                (
                    this.ChangedDate == other.ChangedDate ||
                    this.ChangedDate != null &&
                    this.ChangedDate.Equals(other.ChangedDate)
                ) &&
                (
                    this.RevisionCreatedDate == other.RevisionCreatedDate ||
                    this.RevisionCreatedDate != null &&
                    this.RevisionCreatedDate.Equals(other.RevisionCreatedDate)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.SequenceEqual(other.MediaType)
                ) &&
                (
                    this.Rescore == other.Rescore ||
                    this.Rescore != null &&
                    this.Rescore.Equals(other.Rescore)
                ) &&
                (
                    this.ConversationDate == other.ConversationDate ||
                    this.ConversationDate != null &&
                    this.ConversationDate.Equals(other.ConversationDate)
                ) &&
                (
                    this.ConversationEndDate == other.ConversationEndDate ||
                    this.ConversationEndDate != null &&
                    this.ConversationEndDate.Equals(other.ConversationEndDate)
                ) &&
                (
                    this.NeverRelease == other.NeverRelease ||
                    this.NeverRelease != null &&
                    this.NeverRelease.Equals(other.NeverRelease)
                ) &&
                (
                    this.Assigned == other.Assigned ||
                    this.Assigned != null &&
                    this.Assigned.Equals(other.Assigned)
                ) &&
                (
                    this.DateAssigneeChanged == other.DateAssigneeChanged ||
                    this.DateAssigneeChanged != null &&
                    this.DateAssigneeChanged.Equals(other.DateAssigneeChanged)
                ) &&
                (
                    this.ResourceId == other.ResourceId ||
                    this.ResourceId != null &&
                    this.ResourceId.Equals(other.ResourceId)
                ) &&
                (
                    this.ResourceType == other.ResourceType ||
                    this.ResourceType != null &&
                    this.ResourceType.Equals(other.ResourceType)
                ) &&
                (
                    this.Redacted == other.Redacted ||
                    this.Redacted != null &&
                    this.Redacted.Equals(other.Redacted)
                ) &&
                (
                    this.IsScoringIndex == other.IsScoringIndex ||
                    this.IsScoringIndex != null &&
                    this.IsScoringIndex.Equals(other.IsScoringIndex)
                ) &&
                (
                    this.AuthorizedActions == other.AuthorizedActions ||
                    this.AuthorizedActions != null &&
                    this.AuthorizedActions.SequenceEqual(other.AuthorizedActions)
                ) &&
                (
                    this.HasAssistanceFailed == other.HasAssistanceFailed ||
                    this.HasAssistanceFailed != null &&
                    this.HasAssistanceFailed.Equals(other.HasAssistanceFailed)
                ) &&
                (
                    this.EvaluationSource == other.EvaluationSource ||
                    this.EvaluationSource != null &&
                    this.EvaluationSource.Equals(other.EvaluationSource)
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

                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();

                if (this.EvaluationForm != null)
                    hash = hash * 59 + this.EvaluationForm.GetHashCode();

                if (this.Evaluator != null)
                    hash = hash * 59 + this.Evaluator.GetHashCode();

                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();

                if (this.Calibration != null)
                    hash = hash * 59 + this.Calibration.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Answers != null)
                    hash = hash * 59 + this.Answers.GetHashCode();

                if (this.AgentHasRead != null)
                    hash = hash * 59 + this.AgentHasRead.GetHashCode();

                if (this.Assignee != null)
                    hash = hash * 59 + this.Assignee.GetHashCode();

                if (this.AssigneeApplicable != null)
                    hash = hash * 59 + this.AssigneeApplicable.GetHashCode();

                if (this.ReleaseDate != null)
                    hash = hash * 59 + this.ReleaseDate.GetHashCode();

                if (this.AssignedDate != null)
                    hash = hash * 59 + this.AssignedDate.GetHashCode();

                if (this.ChangedDate != null)
                    hash = hash * 59 + this.ChangedDate.GetHashCode();

                if (this.RevisionCreatedDate != null)
                    hash = hash * 59 + this.RevisionCreatedDate.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.Rescore != null)
                    hash = hash * 59 + this.Rescore.GetHashCode();

                if (this.ConversationDate != null)
                    hash = hash * 59 + this.ConversationDate.GetHashCode();

                if (this.ConversationEndDate != null)
                    hash = hash * 59 + this.ConversationEndDate.GetHashCode();

                if (this.NeverRelease != null)
                    hash = hash * 59 + this.NeverRelease.GetHashCode();

                if (this.Assigned != null)
                    hash = hash * 59 + this.Assigned.GetHashCode();

                if (this.DateAssigneeChanged != null)
                    hash = hash * 59 + this.DateAssigneeChanged.GetHashCode();

                if (this.ResourceId != null)
                    hash = hash * 59 + this.ResourceId.GetHashCode();

                if (this.ResourceType != null)
                    hash = hash * 59 + this.ResourceType.GetHashCode();

                if (this.Redacted != null)
                    hash = hash * 59 + this.Redacted.GetHashCode();

                if (this.IsScoringIndex != null)
                    hash = hash * 59 + this.IsScoringIndex.GetHashCode();

                if (this.AuthorizedActions != null)
                    hash = hash * 59 + this.AuthorizedActions.GetHashCode();

                if (this.HasAssistanceFailed != null)
                    hash = hash * 59 + this.HasAssistanceFailed.GetHashCode();

                if (this.EvaluationSource != null)
                    hash = hash * 59 + this.EvaluationSource.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
