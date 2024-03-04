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
    /// EvaluationCreateBody
    /// </summary>
    [DataContract]
    public partial class EvaluationCreateBody :  IEquatable<EvaluationCreateBody>
    {
        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>
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
        /// Gets or Sets ResourceType
        /// </summary>
        [DataMember(Name="resourceType", EmitDefaultValue=false)]
        public ResourceTypeEnum? ResourceType { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCreateBody" /> class.
        /// </summary>
        /// <param name="EvaluationForm">Evaluation form used for evaluation (must be included for a successful request).</param>
        /// <param name="Evaluator">User ID of the evaluator (must be included for a successful request).</param>
        /// <param name="Agent">User ID of the agent (must be included for a successful request).</param>
        /// <param name="AgentHasRead">AgentHasRead.</param>
        /// <param name="Answers">Answers.</param>
        /// <param name="Calibration">Calibration.</param>
        /// <param name="EvaluationContextId">EvaluationContextId.</param>
        /// <param name="Conversation">Conversation.</param>
        /// <param name="ResourceType">ResourceType.</param>
        /// <param name="EvaluationSource">EvaluationSource.</param>
        /// <param name="Rescore">Rescore.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="ReleaseDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Status">Status.</param>
        /// <param name="NeverRelease">NeverRelease.</param>
        /// <param name="DateAssigneeChanged">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Assignee">Assignee.</param>
        public EvaluationCreateBody(EvaluationCreateEvalForm EvaluationForm = null, EvaluationCreateUser Evaluator = null, EvaluationCreateUser Agent = null, bool? AgentHasRead = null, EvaluationScoringSet Answers = null, EvaluationCreateCalibration Calibration = null, string EvaluationContextId = null, EvaluationCreateConversation Conversation = null, ResourceTypeEnum? ResourceType = null, EvaluationSource EvaluationSource = null, bool? Rescore = null, EvaluationCreateQueue Queue = null, DateTime? ReleaseDate = null, StatusEnum? Status = null, bool? NeverRelease = null, DateTime? DateAssigneeChanged = null, EvaluationCreateUser Assignee = null)
        {
            this.EvaluationForm = EvaluationForm;
            this.Evaluator = Evaluator;
            this.Agent = Agent;
            this.AgentHasRead = AgentHasRead;
            this.Answers = Answers;
            this.Calibration = Calibration;
            this.EvaluationContextId = EvaluationContextId;
            this.Conversation = Conversation;
            this.ResourceType = ResourceType;
            this.EvaluationSource = EvaluationSource;
            this.Rescore = Rescore;
            this.Queue = Queue;
            this.ReleaseDate = ReleaseDate;
            this.Status = Status;
            this.NeverRelease = NeverRelease;
            this.DateAssigneeChanged = DateAssigneeChanged;
            this.Assignee = Assignee;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Evaluation form used for evaluation (must be included for a successful request)
        /// </summary>
        /// <value>Evaluation form used for evaluation (must be included for a successful request)</value>
        [DataMember(Name="evaluationForm", EmitDefaultValue=false)]
        public EvaluationCreateEvalForm EvaluationForm { get; set; }



        /// <summary>
        /// User ID of the evaluator (must be included for a successful request)
        /// </summary>
        /// <value>User ID of the evaluator (must be included for a successful request)</value>
        [DataMember(Name="evaluator", EmitDefaultValue=false)]
        public EvaluationCreateUser Evaluator { get; set; }



        /// <summary>
        /// User ID of the agent (must be included for a successful request)
        /// </summary>
        /// <value>User ID of the agent (must be included for a successful request)</value>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public EvaluationCreateUser Agent { get; set; }



        /// <summary>
        /// Gets or Sets AgentHasRead
        /// </summary>
        [DataMember(Name="agentHasRead", EmitDefaultValue=false)]
        public bool? AgentHasRead { get; set; }



        /// <summary>
        /// Gets or Sets Answers
        /// </summary>
        [DataMember(Name="answers", EmitDefaultValue=false)]
        public EvaluationScoringSet Answers { get; set; }



        /// <summary>
        /// Gets or Sets Calibration
        /// </summary>
        [DataMember(Name="calibration", EmitDefaultValue=false)]
        public EvaluationCreateCalibration Calibration { get; set; }



        /// <summary>
        /// Gets or Sets EvaluationContextId
        /// </summary>
        [DataMember(Name="evaluationContextId", EmitDefaultValue=false)]
        public string EvaluationContextId { get; set; }



        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public EvaluationCreateConversation Conversation { get; set; }





        /// <summary>
        /// Gets or Sets EvaluationSource
        /// </summary>
        [DataMember(Name="evaluationSource", EmitDefaultValue=false)]
        public EvaluationSource EvaluationSource { get; set; }



        /// <summary>
        /// Gets or Sets Rescore
        /// </summary>
        [DataMember(Name="rescore", EmitDefaultValue=false)]
        public bool? Rescore { get; set; }



        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public EvaluationCreateQueue Queue { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="releaseDate", EmitDefaultValue=false)]
        public DateTime? ReleaseDate { get; set; }





        /// <summary>
        /// Gets or Sets NeverRelease
        /// </summary>
        [DataMember(Name="neverRelease", EmitDefaultValue=false)]
        public bool? NeverRelease { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateAssigneeChanged", EmitDefaultValue=false)]
        public DateTime? DateAssigneeChanged { get; set; }



        /// <summary>
        /// Gets or Sets Assignee
        /// </summary>
        [DataMember(Name="assignee", EmitDefaultValue=false)]
        public EvaluationCreateUser Assignee { get; set; }



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
            sb.Append("class EvaluationCreateBody {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
            sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  AgentHasRead: ").Append(AgentHasRead).Append("\n");
            sb.Append("  Answers: ").Append(Answers).Append("\n");
            sb.Append("  Calibration: ").Append(Calibration).Append("\n");
            sb.Append("  EvaluationContextId: ").Append(EvaluationContextId).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  EvaluationSource: ").Append(EvaluationSource).Append("\n");
            sb.Append("  Rescore: ").Append(Rescore).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  NeverRelease: ").Append(NeverRelease).Append("\n");
            sb.Append("  DateAssigneeChanged: ").Append(DateAssigneeChanged).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
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
            return this.Equals(obj as EvaluationCreateBody);
        }

        /// <summary>
        /// Returns true if EvaluationCreateBody instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationCreateBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationCreateBody other)
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
                    this.AgentHasRead == other.AgentHasRead ||
                    this.AgentHasRead != null &&
                    this.AgentHasRead.Equals(other.AgentHasRead)
                ) &&
                (
                    this.Answers == other.Answers ||
                    this.Answers != null &&
                    this.Answers.Equals(other.Answers)
                ) &&
                (
                    this.Calibration == other.Calibration ||
                    this.Calibration != null &&
                    this.Calibration.Equals(other.Calibration)
                ) &&
                (
                    this.EvaluationContextId == other.EvaluationContextId ||
                    this.EvaluationContextId != null &&
                    this.EvaluationContextId.Equals(other.EvaluationContextId)
                ) &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.ResourceType == other.ResourceType ||
                    this.ResourceType != null &&
                    this.ResourceType.Equals(other.ResourceType)
                ) &&
                (
                    this.EvaluationSource == other.EvaluationSource ||
                    this.EvaluationSource != null &&
                    this.EvaluationSource.Equals(other.EvaluationSource)
                ) &&
                (
                    this.Rescore == other.Rescore ||
                    this.Rescore != null &&
                    this.Rescore.Equals(other.Rescore)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.ReleaseDate == other.ReleaseDate ||
                    this.ReleaseDate != null &&
                    this.ReleaseDate.Equals(other.ReleaseDate)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.NeverRelease == other.NeverRelease ||
                    this.NeverRelease != null &&
                    this.NeverRelease.Equals(other.NeverRelease)
                ) &&
                (
                    this.DateAssigneeChanged == other.DateAssigneeChanged ||
                    this.DateAssigneeChanged != null &&
                    this.DateAssigneeChanged.Equals(other.DateAssigneeChanged)
                ) &&
                (
                    this.Assignee == other.Assignee ||
                    this.Assignee != null &&
                    this.Assignee.Equals(other.Assignee)
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

                if (this.EvaluationForm != null)
                    hash = hash * 59 + this.EvaluationForm.GetHashCode();

                if (this.Evaluator != null)
                    hash = hash * 59 + this.Evaluator.GetHashCode();

                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();

                if (this.AgentHasRead != null)
                    hash = hash * 59 + this.AgentHasRead.GetHashCode();

                if (this.Answers != null)
                    hash = hash * 59 + this.Answers.GetHashCode();

                if (this.Calibration != null)
                    hash = hash * 59 + this.Calibration.GetHashCode();

                if (this.EvaluationContextId != null)
                    hash = hash * 59 + this.EvaluationContextId.GetHashCode();

                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();

                if (this.ResourceType != null)
                    hash = hash * 59 + this.ResourceType.GetHashCode();

                if (this.EvaluationSource != null)
                    hash = hash * 59 + this.EvaluationSource.GetHashCode();

                if (this.Rescore != null)
                    hash = hash * 59 + this.Rescore.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.ReleaseDate != null)
                    hash = hash * 59 + this.ReleaseDate.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.NeverRelease != null)
                    hash = hash * 59 + this.NeverRelease.GetHashCode();

                if (this.DateAssigneeChanged != null)
                    hash = hash * 59 + this.DateAssigneeChanged.GetHashCode();

                if (this.Assignee != null)
                    hash = hash * 59 + this.Assignee.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
