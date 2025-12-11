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
    /// ChecklistInferenceJobResponse
    /// </summary>
    [DataContract]
    public partial class ChecklistInferenceJobResponse :  IEquatable<ChecklistInferenceJobResponse>
    {
        /// <summary>
        /// Status of the checklist inference job.
        /// </summary>
        /// <value>Status of the checklist inference job.</value>
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
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete
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
        /// Status of the checklist inference job.
        /// </summary>
        /// <value>Status of the checklist inference job.</value>
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
        /// Initializes a new instance of the <see cref="ChecklistInferenceJobResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChecklistInferenceJobResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistInferenceJobResponse" /> class.
        /// </summary>
        /// <param name="Id">ID of the inference job. (required).</param>
        /// <param name="Status">Status of the checklist inference job. (required).</param>
        /// <param name="Error">Error information associated with a job in case of any errors..</param>
        /// <param name="AgentChecklistInfo">Agent checklist info..</param>
        /// <param name="JobStartTime">Date when the inference job started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="JobEndTime">Date when the inference job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Language">Language associated with the checklist..</param>
        /// <param name="AgentId">Agent ID..</param>
        /// <param name="ParticipantId">Participant ID..</param>
        /// <param name="QueueId">Queue ID..</param>
        /// <param name="AssistantId">Assistant ID..</param>
        /// <param name="MediaType">Media type..</param>
        /// <param name="Direction">Direction of the conversation..</param>
        public ChecklistInferenceJobResponse(string Id = null, StatusEnum? Status = null, ErrorInfo Error = null, AgentChecklistInfo AgentChecklistInfo = null, DateTime? JobStartTime = null, DateTime? JobEndTime = null, string Language = null, string AgentId = null, string ParticipantId = null, string QueueId = null, string AssistantId = null, MediaTypeEnum? MediaType = null, DirectionEnum? Direction = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.Error = Error;
            this.AgentChecklistInfo = AgentChecklistInfo;
            this.JobStartTime = JobStartTime;
            this.JobEndTime = JobEndTime;
            this.Language = Language;
            this.AgentId = AgentId;
            this.ParticipantId = ParticipantId;
            this.QueueId = QueueId;
            this.AssistantId = AssistantId;
            this.MediaType = MediaType;
            this.Direction = Direction;
            
        }
        


        /// <summary>
        /// ID of the inference job.
        /// </summary>
        /// <value>ID of the inference job.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// Error information associated with a job in case of any errors.
        /// </summary>
        /// <value>Error information associated with a job in case of any errors.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorInfo Error { get; set; }



        /// <summary>
        /// Agent checklist info.
        /// </summary>
        /// <value>Agent checklist info.</value>
        [DataMember(Name="agentChecklistInfo", EmitDefaultValue=false)]
        public AgentChecklistInfo AgentChecklistInfo { get; set; }



        /// <summary>
        /// Date when the inference job started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the inference job started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="jobStartTime", EmitDefaultValue=false)]
        public DateTime? JobStartTime { get; set; }



        /// <summary>
        /// Date when the inference job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the inference job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="jobEndTime", EmitDefaultValue=false)]
        public DateTime? JobEndTime { get; set; }



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
            sb.Append("class ChecklistInferenceJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  AgentChecklistInfo: ").Append(AgentChecklistInfo).Append("\n");
            sb.Append("  JobStartTime: ").Append(JobStartTime).Append("\n");
            sb.Append("  JobEndTime: ").Append(JobEndTime).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  AssistantId: ").Append(AssistantId).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(obj as ChecklistInferenceJobResponse);
        }

        /// <summary>
        /// Returns true if ChecklistInferenceJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ChecklistInferenceJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChecklistInferenceJobResponse other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.AgentChecklistInfo == other.AgentChecklistInfo ||
                    this.AgentChecklistInfo != null &&
                    this.AgentChecklistInfo.Equals(other.AgentChecklistInfo)
                ) &&
                (
                    this.JobStartTime == other.JobStartTime ||
                    this.JobStartTime != null &&
                    this.JobStartTime.Equals(other.JobStartTime)
                ) &&
                (
                    this.JobEndTime == other.JobEndTime ||
                    this.JobEndTime != null &&
                    this.JobEndTime.Equals(other.JobEndTime)
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

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.AgentChecklistInfo != null)
                    hash = hash * 59 + this.AgentChecklistInfo.GetHashCode();

                if (this.JobStartTime != null)
                    hash = hash * 59 + this.JobStartTime.GetHashCode();

                if (this.JobEndTime != null)
                    hash = hash * 59 + this.JobEndTime.GetHashCode();

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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
