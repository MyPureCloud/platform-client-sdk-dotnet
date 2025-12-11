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
    /// AgentChecklistResponse
    /// </summary>
    [DataContract]
    public partial class AgentChecklistResponse :  IEquatable<AgentChecklistResponse>
    {
        /// <summary>
        /// The evaluation status of the checklist.
        /// </summary>
        /// <value>The evaluation status of the checklist.</value>
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
            /// Enum Evaluationstarted for "EvaluationStarted"
            /// </summary>
            [EnumMember(Value = "EvaluationStarted")]
            Evaluationstarted,
            
            /// <summary>
            /// Enum Evaluationinprogress for "EvaluationInProgress"
            /// </summary>
            [EnumMember(Value = "EvaluationInProgress")]
            Evaluationinprogress,
            
            /// <summary>
            /// Enum Evaluationfinalized for "EvaluationFinalized"
            /// </summary>
            [EnumMember(Value = "EvaluationFinalized")]
            Evaluationfinalized,
            
            /// <summary>
            /// Enum Evaluationfinalizedwithacw for "EvaluationFinalizedWithAcw"
            /// </summary>
            [EnumMember(Value = "EvaluationFinalizedWithAcw")]
            Evaluationfinalizedwithacw
        }
        /// <summary>
        /// Media type.
        /// </summary>
        /// <value>Media type.</value>
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
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email
        }
        /// <summary>
        /// Direction of the conversation.
        /// </summary>
        /// <value>Direction of the conversation.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inbound for "Inbound"
            /// </summary>
            [EnumMember(Value = "Inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "Outbound"
            /// </summary>
            [EnumMember(Value = "Outbound")]
            Outbound
        }
        /// <summary>
        /// The evaluation status of the checklist.
        /// </summary>
        /// <value>The evaluation status of the checklist.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Media type.
        /// </summary>
        /// <value>Media type.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Direction of the conversation.
        /// </summary>
        /// <value>Direction of the conversation.</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChecklistResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentChecklistResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChecklistResponse" /> class.
        /// </summary>
        /// <param name="Id">ID of the checklist. (required).</param>
        /// <param name="Name">Name of the checklist. (required).</param>
        /// <param name="ChecklistItems">List of individual Checklist Items. (required).</param>
        /// <param name="ActivationTriggers">List of triggers that activated this checklist..</param>
        /// <param name="Status">The evaluation status of the checklist. (required).</param>
        /// <param name="ExitReason">Exit reason provided at the time of finalizing the checklist..</param>
        /// <param name="Language">Language associated with the checklist. (required).</param>
        /// <param name="AgentId">Agent ID..</param>
        /// <param name="ParticipantId">Participant ID..</param>
        /// <param name="QueueId">Queue ID..</param>
        /// <param name="AssistantId">Assistant ID..</param>
        /// <param name="MediaType">Media type..</param>
        /// <param name="Direction">Direction of the conversation..</param>
        /// <param name="EvaluationStartDate">Date when the checklist evaluation began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="EvaluationLastModifiedDate">Date when the checklist was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="EvaluationFinalizedDate">Date when the checklist was finalized. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="EvaluationFinalizedWithAcwDate">Date when the checklist was finalized with ACW. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public AgentChecklistResponse(string Id = null, string Name = null, List<ChecklistItem> ChecklistItems = null, List<ActivationTrigger> ActivationTriggers = null, StatusEnum? Status = null, string ExitReason = null, string Language = null, string AgentId = null, string ParticipantId = null, string QueueId = null, string AssistantId = null, MediaTypeEnum? MediaType = null, DirectionEnum? Direction = null, DateTime? EvaluationStartDate = null, DateTime? EvaluationLastModifiedDate = null, DateTime? EvaluationFinalizedDate = null, DateTime? EvaluationFinalizedWithAcwDate = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.ChecklistItems = ChecklistItems;
            this.ActivationTriggers = ActivationTriggers;
            this.Status = Status;
            this.ExitReason = ExitReason;
            this.Language = Language;
            this.AgentId = AgentId;
            this.ParticipantId = ParticipantId;
            this.QueueId = QueueId;
            this.AssistantId = AssistantId;
            this.MediaType = MediaType;
            this.Direction = Direction;
            this.EvaluationStartDate = EvaluationStartDate;
            this.EvaluationLastModifiedDate = EvaluationLastModifiedDate;
            this.EvaluationFinalizedDate = EvaluationFinalizedDate;
            this.EvaluationFinalizedWithAcwDate = EvaluationFinalizedWithAcwDate;
            
        }
        


        /// <summary>
        /// ID of the checklist.
        /// </summary>
        /// <value>ID of the checklist.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Name of the checklist.
        /// </summary>
        /// <value>Name of the checklist.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// List of individual Checklist Items.
        /// </summary>
        /// <value>List of individual Checklist Items.</value>
        [DataMember(Name="checklistItems", EmitDefaultValue=false)]
        public List<ChecklistItem> ChecklistItems { get; set; }



        /// <summary>
        /// List of triggers that activated this checklist.
        /// </summary>
        /// <value>List of triggers that activated this checklist.</value>
        [DataMember(Name="activationTriggers", EmitDefaultValue=false)]
        public List<ActivationTrigger> ActivationTriggers { get; set; }





        /// <summary>
        /// Exit reason provided at the time of finalizing the checklist.
        /// </summary>
        /// <value>Exit reason provided at the time of finalizing the checklist.</value>
        [DataMember(Name="exitReason", EmitDefaultValue=false)]
        public string ExitReason { get; set; }



        /// <summary>
        /// Language associated with the checklist.
        /// </summary>
        /// <value>Language associated with the checklist.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Agent ID.
        /// </summary>
        /// <value>Agent ID.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// Participant ID.
        /// </summary>
        /// <value>Participant ID.</value>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }



        /// <summary>
        /// Queue ID.
        /// </summary>
        /// <value>Queue ID.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// Assistant ID.
        /// </summary>
        /// <value>Assistant ID.</value>
        [DataMember(Name="assistantId", EmitDefaultValue=false)]
        public string AssistantId { get; set; }







        /// <summary>
        /// Date when the checklist evaluation began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the checklist evaluation began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="evaluationStartDate", EmitDefaultValue=false)]
        public DateTime? EvaluationStartDate { get; set; }



        /// <summary>
        /// Date when the checklist was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the checklist was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="evaluationLastModifiedDate", EmitDefaultValue=false)]
        public DateTime? EvaluationLastModifiedDate { get; set; }



        /// <summary>
        /// Date when the checklist was finalized. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the checklist was finalized. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="evaluationFinalizedDate", EmitDefaultValue=false)]
        public DateTime? EvaluationFinalizedDate { get; set; }



        /// <summary>
        /// Date when the checklist was finalized with ACW. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the checklist was finalized with ACW. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="evaluationFinalizedWithAcwDate", EmitDefaultValue=false)]
        public DateTime? EvaluationFinalizedWithAcwDate { get; set; }



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
            sb.Append("class AgentChecklistResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ChecklistItems: ").Append(ChecklistItems).Append("\n");
            sb.Append("  ActivationTriggers: ").Append(ActivationTriggers).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExitReason: ").Append(ExitReason).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  AssistantId: ").Append(AssistantId).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  EvaluationStartDate: ").Append(EvaluationStartDate).Append("\n");
            sb.Append("  EvaluationLastModifiedDate: ").Append(EvaluationLastModifiedDate).Append("\n");
            sb.Append("  EvaluationFinalizedDate: ").Append(EvaluationFinalizedDate).Append("\n");
            sb.Append("  EvaluationFinalizedWithAcwDate: ").Append(EvaluationFinalizedWithAcwDate).Append("\n");
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
            return this.Equals(obj as AgentChecklistResponse);
        }

        /// <summary>
        /// Returns true if AgentChecklistResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentChecklistResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentChecklistResponse other)
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
                    this.ChecklistItems == other.ChecklistItems ||
                    this.ChecklistItems != null &&
                    this.ChecklistItems.SequenceEqual(other.ChecklistItems)
                ) &&
                (
                    this.ActivationTriggers == other.ActivationTriggers ||
                    this.ActivationTriggers != null &&
                    this.ActivationTriggers.SequenceEqual(other.ActivationTriggers)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ExitReason == other.ExitReason ||
                    this.ExitReason != null &&
                    this.ExitReason.Equals(other.ExitReason)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.ParticipantId == other.ParticipantId ||
                    this.ParticipantId != null &&
                    this.ParticipantId.Equals(other.ParticipantId)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.AssistantId == other.AssistantId ||
                    this.AssistantId != null &&
                    this.AssistantId.Equals(other.AssistantId)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.EvaluationStartDate == other.EvaluationStartDate ||
                    this.EvaluationStartDate != null &&
                    this.EvaluationStartDate.Equals(other.EvaluationStartDate)
                ) &&
                (
                    this.EvaluationLastModifiedDate == other.EvaluationLastModifiedDate ||
                    this.EvaluationLastModifiedDate != null &&
                    this.EvaluationLastModifiedDate.Equals(other.EvaluationLastModifiedDate)
                ) &&
                (
                    this.EvaluationFinalizedDate == other.EvaluationFinalizedDate ||
                    this.EvaluationFinalizedDate != null &&
                    this.EvaluationFinalizedDate.Equals(other.EvaluationFinalizedDate)
                ) &&
                (
                    this.EvaluationFinalizedWithAcwDate == other.EvaluationFinalizedWithAcwDate ||
                    this.EvaluationFinalizedWithAcwDate != null &&
                    this.EvaluationFinalizedWithAcwDate.Equals(other.EvaluationFinalizedWithAcwDate)
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

                if (this.ChecklistItems != null)
                    hash = hash * 59 + this.ChecklistItems.GetHashCode();

                if (this.ActivationTriggers != null)
                    hash = hash * 59 + this.ActivationTriggers.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ExitReason != null)
                    hash = hash * 59 + this.ExitReason.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.AssistantId != null)
                    hash = hash * 59 + this.AssistantId.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.EvaluationStartDate != null)
                    hash = hash * 59 + this.EvaluationStartDate.GetHashCode();

                if (this.EvaluationLastModifiedDate != null)
                    hash = hash * 59 + this.EvaluationLastModifiedDate.GetHashCode();

                if (this.EvaluationFinalizedDate != null)
                    hash = hash * 59 + this.EvaluationFinalizedDate.GetHashCode();

                if (this.EvaluationFinalizedWithAcwDate != null)
                    hash = hash * 59 + this.EvaluationFinalizedWithAcwDate.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
