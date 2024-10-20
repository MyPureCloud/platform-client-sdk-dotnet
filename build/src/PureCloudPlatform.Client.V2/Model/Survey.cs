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
    /// Survey
    /// </summary>
    [DataContract]
    public partial class Survey :  IEquatable<Survey>
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
            /// Enum Sent for "Sent"
            /// </summary>
            [EnumMember(Value = "Sent")]
            Sent,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Finished for "Finished"
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished,
            
            /// <summary>
            /// Enum Optout for "OptOut"
            /// </summary>
            [EnumMember(Value = "OptOut")]
            Optout,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Expired for "Expired"
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired
        }
        /// <summary>
        /// Type of the survey
        /// </summary>
        /// <value>Type of the survey</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SurveyTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Web for "Web"
            /// </summary>
            [EnumMember(Value = "Web")]
            Web,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Type of the survey
        /// </summary>
        /// <value>Type of the survey</value>
        [DataMember(Name="surveyType", EmitDefaultValue=false)]
        public SurveyTypeEnum? SurveyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Survey" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Conversation">Conversation.</param>
        /// <param name="SurveyForm">Survey form used for this survey..</param>
        /// <param name="Agent">Agent.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="Answers">Answers.</param>
        /// <param name="CompletedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="SurveyErrorDetails">Additional information about what happened when the survey is in Error status..</param>
        /// <param name="AgentTeam">The team that the agent belongs to.</param>
        /// <param name="SurveyType">Type of the survey.</param>
        /// <param name="MissingRequiredAnswer">True if any of the required questions for the survey form have not been answered. Null if survey is not finished..</param>
        /// <param name="Flow">An Architect flow that executed in order to collect the answers for this survey..</param>
        public Survey(string Name = null, ConversationReference Conversation = null, SurveyForm SurveyForm = null, DomainEntityRef Agent = null, StatusEnum? Status = null, QueueReference Queue = null, SurveyScoringSet Answers = null, DateTime? CompletedDate = null, SurveyErrorDetails SurveyErrorDetails = null, Team AgentTeam = null, SurveyTypeEnum? SurveyType = null, bool? MissingRequiredAnswer = null, AddressableEntityRef Flow = null)
        {
            this.Name = Name;
            this.Conversation = Conversation;
            this.SurveyForm = SurveyForm;
            this.Agent = Agent;
            this.Status = Status;
            this.Queue = Queue;
            this.Answers = Answers;
            this.CompletedDate = CompletedDate;
            this.SurveyErrorDetails = SurveyErrorDetails;
            this.AgentTeam = AgentTeam;
            this.SurveyType = SurveyType;
            this.MissingRequiredAnswer = MissingRequiredAnswer;
            this.Flow = Flow;
            
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
        /// Survey form used for this survey.
        /// </summary>
        /// <value>Survey form used for this survey.</value>
        [DataMember(Name="surveyForm", EmitDefaultValue=false)]
        public SurveyForm SurveyForm { get; set; }



        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public DomainEntityRef Agent { get; set; }





        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public QueueReference Queue { get; set; }



        /// <summary>
        /// Gets or Sets Answers
        /// </summary>
        [DataMember(Name="answers", EmitDefaultValue=false)]
        public SurveyScoringSet Answers { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="completedDate", EmitDefaultValue=false)]
        public DateTime? CompletedDate { get; set; }



        /// <summary>
        /// Additional information about what happened when the survey is in Error status.
        /// </summary>
        /// <value>Additional information about what happened when the survey is in Error status.</value>
        [DataMember(Name="surveyErrorDetails", EmitDefaultValue=false)]
        public SurveyErrorDetails SurveyErrorDetails { get; set; }



        /// <summary>
        /// The team that the agent belongs to
        /// </summary>
        /// <value>The team that the agent belongs to</value>
        [DataMember(Name="agentTeam", EmitDefaultValue=false)]
        public Team AgentTeam { get; set; }





        /// <summary>
        /// True if any of the required questions for the survey form have not been answered. Null if survey is not finished.
        /// </summary>
        /// <value>True if any of the required questions for the survey form have not been answered. Null if survey is not finished.</value>
        [DataMember(Name="missingRequiredAnswer", EmitDefaultValue=false)]
        public bool? MissingRequiredAnswer { get; set; }



        /// <summary>
        /// An Architect flow that executed in order to collect the answers for this survey.
        /// </summary>
        /// <value>An Architect flow that executed in order to collect the answers for this survey.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public AddressableEntityRef Flow { get; set; }



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
            sb.Append("class Survey {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  SurveyForm: ").Append(SurveyForm).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Answers: ").Append(Answers).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
            sb.Append("  SurveyErrorDetails: ").Append(SurveyErrorDetails).Append("\n");
            sb.Append("  AgentTeam: ").Append(AgentTeam).Append("\n");
            sb.Append("  SurveyType: ").Append(SurveyType).Append("\n");
            sb.Append("  MissingRequiredAnswer: ").Append(MissingRequiredAnswer).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
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
            return this.Equals(obj as Survey);
        }

        /// <summary>
        /// Returns true if Survey instances are equal
        /// </summary>
        /// <param name="other">Instance of Survey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Survey other)
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
                    this.SurveyForm == other.SurveyForm ||
                    this.SurveyForm != null &&
                    this.SurveyForm.Equals(other.SurveyForm)
                ) &&
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Answers == other.Answers ||
                    this.Answers != null &&
                    this.Answers.Equals(other.Answers)
                ) &&
                (
                    this.CompletedDate == other.CompletedDate ||
                    this.CompletedDate != null &&
                    this.CompletedDate.Equals(other.CompletedDate)
                ) &&
                (
                    this.SurveyErrorDetails == other.SurveyErrorDetails ||
                    this.SurveyErrorDetails != null &&
                    this.SurveyErrorDetails.Equals(other.SurveyErrorDetails)
                ) &&
                (
                    this.AgentTeam == other.AgentTeam ||
                    this.AgentTeam != null &&
                    this.AgentTeam.Equals(other.AgentTeam)
                ) &&
                (
                    this.SurveyType == other.SurveyType ||
                    this.SurveyType != null &&
                    this.SurveyType.Equals(other.SurveyType)
                ) &&
                (
                    this.MissingRequiredAnswer == other.MissingRequiredAnswer ||
                    this.MissingRequiredAnswer != null &&
                    this.MissingRequiredAnswer.Equals(other.MissingRequiredAnswer)
                ) &&
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
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

                if (this.SurveyForm != null)
                    hash = hash * 59 + this.SurveyForm.GetHashCode();

                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.Answers != null)
                    hash = hash * 59 + this.Answers.GetHashCode();

                if (this.CompletedDate != null)
                    hash = hash * 59 + this.CompletedDate.GetHashCode();

                if (this.SurveyErrorDetails != null)
                    hash = hash * 59 + this.SurveyErrorDetails.GetHashCode();

                if (this.AgentTeam != null)
                    hash = hash * 59 + this.AgentTeam.GetHashCode();

                if (this.SurveyType != null)
                    hash = hash * 59 + this.SurveyType.GetHashCode();

                if (this.MissingRequiredAnswer != null)
                    hash = hash * 59 + this.MissingRequiredAnswer.GetHashCode();

                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
