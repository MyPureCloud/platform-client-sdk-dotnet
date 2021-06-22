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
    /// EvaluationQualityV2TopicEvaluationV2
    /// </summary>
    [DataContract]
    public partial class EvaluationQualityV2TopicEvaluationV2 :  IEquatable<EvaluationQualityV2TopicEvaluationV2>
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Finished for "Finished"
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationQualityV2TopicEvaluationV2" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="Agent">Agent.</param>
        /// <param name="Evaluator">Evaluator.</param>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="EvaluationFormId">EvaluationFormId.</param>
        /// <param name="FormName">FormName.</param>
        /// <param name="ScoringSet">ScoringSet.</param>
        /// <param name="ContextId">ContextId.</param>
        /// <param name="Status">Status.</param>
        /// <param name="AgentHasRead">AgentHasRead.</param>
        /// <param name="ReleaseDate">ReleaseDate.</param>
        /// <param name="AssignedDate">AssignedDate.</param>
        /// <param name="ChangedDate">ChangedDate.</param>
        /// <param name="EventType">EventType.</param>
        /// <param name="ResourceId">ResourceId.</param>
        /// <param name="ResourceType">ResourceType.</param>
        /// <param name="DivisionIds">DivisionIds.</param>
        /// <param name="Rescore">Rescore.</param>
        /// <param name="ConversationDate">ConversationDate.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="Calibration">Calibration.</param>
        public EvaluationQualityV2TopicEvaluationV2(string Id = null, string ConversationId = null, EvaluationQualityV2TopicUser Agent = null, EvaluationQualityV2TopicUser Evaluator = null, DateTime? EventTime = null, string EvaluationFormId = null, string FormName = null, EvaluationQualityV2TopicEvaluationScoringSet ScoringSet = null, string ContextId = null, StatusEnum? Status = null, bool? AgentHasRead = null, DateTime? ReleaseDate = null, DateTime? AssignedDate = null, DateTime? ChangedDate = null, string EventType = null, string ResourceId = null, string ResourceType = null, List<string> DivisionIds = null, bool? Rescore = null, DateTime? ConversationDate = null, List<string> MediaType = null, EvaluationQualityV2TopicCalibration Calibration = null)
        {
            this.Id = Id;
            this.ConversationId = ConversationId;
            this.Agent = Agent;
            this.Evaluator = Evaluator;
            this.EventTime = EventTime;
            this.EvaluationFormId = EvaluationFormId;
            this.FormName = FormName;
            this.ScoringSet = ScoringSet;
            this.ContextId = ContextId;
            this.Status = Status;
            this.AgentHasRead = AgentHasRead;
            this.ReleaseDate = ReleaseDate;
            this.AssignedDate = AssignedDate;
            this.ChangedDate = ChangedDate;
            this.EventType = EventType;
            this.ResourceId = ResourceId;
            this.ResourceType = ResourceType;
            this.DivisionIds = DivisionIds;
            this.Rescore = Rescore;
            this.ConversationDate = ConversationDate;
            this.MediaType = MediaType;
            this.Calibration = Calibration;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public EvaluationQualityV2TopicUser Agent { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Evaluator
        /// </summary>
        [DataMember(Name="evaluator", EmitDefaultValue=false)]
        public EvaluationQualityV2TopicUser Evaluator { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EvaluationFormId
        /// </summary>
        [DataMember(Name="evaluationFormId", EmitDefaultValue=false)]
        public string EvaluationFormId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FormName
        /// </summary>
        [DataMember(Name="formName", EmitDefaultValue=false)]
        public string FormName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ScoringSet
        /// </summary>
        [DataMember(Name="scoringSet", EmitDefaultValue=false)]
        public EvaluationQualityV2TopicEvaluationScoringSet ScoringSet { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContextId
        /// </summary>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets AgentHasRead
        /// </summary>
        [DataMember(Name="agentHasRead", EmitDefaultValue=false)]
        public bool? AgentHasRead { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ReleaseDate
        /// </summary>
        [DataMember(Name="releaseDate", EmitDefaultValue=false)]
        public DateTime? ReleaseDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AssignedDate
        /// </summary>
        [DataMember(Name="assignedDate", EmitDefaultValue=false)]
        public DateTime? AssignedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ChangedDate
        /// </summary>
        [DataMember(Name="changedDate", EmitDefaultValue=false)]
        public DateTime? ChangedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public string EventType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ResourceId
        /// </summary>
        [DataMember(Name="resourceId", EmitDefaultValue=false)]
        public string ResourceId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>
        [DataMember(Name="resourceType", EmitDefaultValue=false)]
        public string ResourceType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DivisionIds
        /// </summary>
        [DataMember(Name="divisionIds", EmitDefaultValue=false)]
        public List<string> DivisionIds { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Rescore
        /// </summary>
        [DataMember(Name="rescore", EmitDefaultValue=false)]
        public bool? Rescore { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ConversationDate
        /// </summary>
        [DataMember(Name="conversationDate", EmitDefaultValue=false)]
        public DateTime? ConversationDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public List<string> MediaType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Calibration
        /// </summary>
        [DataMember(Name="calibration", EmitDefaultValue=false)]
        public EvaluationQualityV2TopicCalibration Calibration { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationQualityV2TopicEvaluationV2 {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  EvaluationFormId: ").Append(EvaluationFormId).Append("\n");
            sb.Append("  FormName: ").Append(FormName).Append("\n");
            sb.Append("  ScoringSet: ").Append(ScoringSet).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AgentHasRead: ").Append(AgentHasRead).Append("\n");
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  AssignedDate: ").Append(AssignedDate).Append("\n");
            sb.Append("  ChangedDate: ").Append(ChangedDate).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
            sb.Append("  Rescore: ").Append(Rescore).Append("\n");
            sb.Append("  ConversationDate: ").Append(ConversationDate).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Calibration: ").Append(Calibration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EvaluationQualityV2TopicEvaluationV2);
        }

        /// <summary>
        /// Returns true if EvaluationQualityV2TopicEvaluationV2 instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationQualityV2TopicEvaluationV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationQualityV2TopicEvaluationV2 other)
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
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.Evaluator == other.Evaluator ||
                    this.Evaluator != null &&
                    this.Evaluator.Equals(other.Evaluator)
                ) &&
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) &&
                (
                    this.EvaluationFormId == other.EvaluationFormId ||
                    this.EvaluationFormId != null &&
                    this.EvaluationFormId.Equals(other.EvaluationFormId)
                ) &&
                (
                    this.FormName == other.FormName ||
                    this.FormName != null &&
                    this.FormName.Equals(other.FormName)
                ) &&
                (
                    this.ScoringSet == other.ScoringSet ||
                    this.ScoringSet != null &&
                    this.ScoringSet.Equals(other.ScoringSet)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.AgentHasRead == other.AgentHasRead ||
                    this.AgentHasRead != null &&
                    this.AgentHasRead.Equals(other.AgentHasRead)
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
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
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
                    this.DivisionIds == other.DivisionIds ||
                    this.DivisionIds != null &&
                    this.DivisionIds.SequenceEqual(other.DivisionIds)
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
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.SequenceEqual(other.MediaType)
                ) &&
                (
                    this.Calibration == other.Calibration ||
                    this.Calibration != null &&
                    this.Calibration.Equals(other.Calibration)
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
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();
                
                if (this.Evaluator != null)
                    hash = hash * 59 + this.Evaluator.GetHashCode();
                
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();
                
                if (this.EvaluationFormId != null)
                    hash = hash * 59 + this.EvaluationFormId.GetHashCode();
                
                if (this.FormName != null)
                    hash = hash * 59 + this.FormName.GetHashCode();
                
                if (this.ScoringSet != null)
                    hash = hash * 59 + this.ScoringSet.GetHashCode();
                
                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.AgentHasRead != null)
                    hash = hash * 59 + this.AgentHasRead.GetHashCode();
                
                if (this.ReleaseDate != null)
                    hash = hash * 59 + this.ReleaseDate.GetHashCode();
                
                if (this.AssignedDate != null)
                    hash = hash * 59 + this.AssignedDate.GetHashCode();
                
                if (this.ChangedDate != null)
                    hash = hash * 59 + this.ChangedDate.GetHashCode();
                
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();
                
                if (this.ResourceId != null)
                    hash = hash * 59 + this.ResourceId.GetHashCode();
                
                if (this.ResourceType != null)
                    hash = hash * 59 + this.ResourceType.GetHashCode();
                
                if (this.DivisionIds != null)
                    hash = hash * 59 + this.DivisionIds.GetHashCode();
                
                if (this.Rescore != null)
                    hash = hash * 59 + this.Rescore.GetHashCode();
                
                if (this.ConversationDate != null)
                    hash = hash * 59 + this.ConversationDate.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.Calibration != null)
                    hash = hash * 59 + this.Calibration.GetHashCode();
                
                return hash;
            }
        }
    }

}
