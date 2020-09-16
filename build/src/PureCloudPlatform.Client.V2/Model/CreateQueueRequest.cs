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
    /// CreateQueueRequest
    /// </summary>
    [DataContract]
    public partial class CreateQueueRequest :  IEquatable<CreateQueueRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The skill evaluation method to use when routing conversations.
        /// </summary>
        /// <value>The skill evaluation method to use when routing conversations.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SkillEvaluationMethodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None,
            
            /// <summary>
            /// Enum Best for "BEST"
            /// </summary>
            [EnumMember(Value = "BEST")]
            Best,
            
            /// <summary>
            /// Enum All for "ALL"
            /// </summary>
            [EnumMember(Value = "ALL")]
            All
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The skill evaluation method to use when routing conversations.
        /// </summary>
        /// <value>The skill evaluation method to use when routing conversations.</value>
        [DataMember(Name="skillEvaluationMethod", EmitDefaultValue=false)]
        public SkillEvaluationMethodEnum? SkillEvaluationMethod { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQueueRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateQueueRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQueueRequest" /> class.
        /// </summary>
        /// <param name="Name">The queue name (required).</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Description">The queue description..</param>
        /// <param name="DateCreated">The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ModifiedBy">The ID of the user that last modified the queue..</param>
        /// <param name="CreatedBy">The ID of the user that created the queue..</param>
        /// <param name="MediaSettings">The media settings for the queue. Valid key values: CALL, CALLBACK, CHAT, EMAIL, MESSAGE, SOCIAL_EXPRESSION, VIDEO_COMM.</param>
        /// <param name="RoutingRules">The routing rules for the queue, used for routing to known or preferred agents..</param>
        /// <param name="Bullseye">The bulls-eye settings for the queue..</param>
        /// <param name="AcwSettings">The ACW settings for the queue..</param>
        /// <param name="SkillEvaluationMethod">The skill evaluation method to use when routing conversations..</param>
        /// <param name="QueueFlow">The in-queue flow to use for conversations waiting in queue..</param>
        /// <param name="WhisperPrompt">The prompt used for whisper on the queue, if configured..</param>
        /// <param name="AutoAnswerOnly">Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered..</param>
        /// <param name="EnableTranscription">Indicates whether voice transcription is enabled for this queue..</param>
        /// <param name="EnableManualAssignment">Indicates whether manual assignment is enabled for this queue..</param>
        /// <param name="CallingPartyName">The name to use for caller identification for outbound calls from this queue..</param>
        /// <param name="CallingPartyNumber">The phone number to use for caller identification for outbound calls from this queue..</param>
        /// <param name="DefaultScripts">The default script Ids for the communication types..</param>
        /// <param name="OutboundMessagingAddresses">The messaging addresses for the queue..</param>
        /// <param name="OutboundEmailAddress">OutboundEmailAddress.</param>
        /// <param name="SourceQueueId">The id of an existing queue to copy the settings from when creating a new queue..</param>
        public CreateQueueRequest(string Name = null, WritableDivision Division = null, string Description = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, Dictionary<string, MediaSetting> MediaSettings = null, List<RoutingRule> RoutingRules = null, Bullseye Bullseye = null, AcwSettings AcwSettings = null, SkillEvaluationMethodEnum? SkillEvaluationMethod = null, DomainEntityRef QueueFlow = null, DomainEntityRef WhisperPrompt = null, bool? AutoAnswerOnly = null, bool? EnableTranscription = null, bool? EnableManualAssignment = null, string CallingPartyName = null, string CallingPartyNumber = null, Dictionary<string, Script> DefaultScripts = null, QueueMessagingAddresses OutboundMessagingAddresses = null, QueueEmailAddress OutboundEmailAddress = null, string SourceQueueId = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.Description = Description;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.CreatedBy = CreatedBy;
            this.MediaSettings = MediaSettings;
            this.RoutingRules = RoutingRules;
            this.Bullseye = Bullseye;
            this.AcwSettings = AcwSettings;
            this.SkillEvaluationMethod = SkillEvaluationMethod;
            this.QueueFlow = QueueFlow;
            this.WhisperPrompt = WhisperPrompt;
            this.AutoAnswerOnly = AutoAnswerOnly;
            this.EnableTranscription = EnableTranscription;
            this.EnableManualAssignment = EnableManualAssignment;
            this.CallingPartyName = CallingPartyName;
            this.CallingPartyNumber = CallingPartyNumber;
            this.DefaultScripts = DefaultScripts;
            this.OutboundMessagingAddresses = OutboundMessagingAddresses;
            this.OutboundEmailAddress = OutboundEmailAddress;
            this.SourceQueueId = SourceQueueId;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The queue name
        /// </summary>
        /// <value>The queue name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableDivision Division { get; set; }
        
        
        
        /// <summary>
        /// The queue description.
        /// </summary>
        /// <value>The queue description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// The ID of the user that last modified the queue.
        /// </summary>
        /// <value>The ID of the user that last modified the queue.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// The ID of the user that created the queue.
        /// </summary>
        /// <value>The ID of the user that created the queue.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        
        
        
        /// <summary>
        /// The number of users in the queue.
        /// </summary>
        /// <value>The number of users in the queue.</value>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public int? MemberCount { get; private set; }
        
        
        
        /// <summary>
        /// The media settings for the queue. Valid key values: CALL, CALLBACK, CHAT, EMAIL, MESSAGE, SOCIAL_EXPRESSION, VIDEO_COMM
        /// </summary>
        /// <value>The media settings for the queue. Valid key values: CALL, CALLBACK, CHAT, EMAIL, MESSAGE, SOCIAL_EXPRESSION, VIDEO_COMM</value>
        [DataMember(Name="mediaSettings", EmitDefaultValue=false)]
        public Dictionary<string, MediaSetting> MediaSettings { get; set; }
        
        
        
        /// <summary>
        /// The routing rules for the queue, used for routing to known or preferred agents.
        /// </summary>
        /// <value>The routing rules for the queue, used for routing to known or preferred agents.</value>
        [DataMember(Name="routingRules", EmitDefaultValue=false)]
        public List<RoutingRule> RoutingRules { get; set; }
        
        
        
        /// <summary>
        /// The bulls-eye settings for the queue.
        /// </summary>
        /// <value>The bulls-eye settings for the queue.</value>
        [DataMember(Name="bullseye", EmitDefaultValue=false)]
        public Bullseye Bullseye { get; set; }
        
        
        
        /// <summary>
        /// The ACW settings for the queue.
        /// </summary>
        /// <value>The ACW settings for the queue.</value>
        [DataMember(Name="acwSettings", EmitDefaultValue=false)]
        public AcwSettings AcwSettings { get; set; }
        
        
        
        
        
        /// <summary>
        /// The in-queue flow to use for conversations waiting in queue.
        /// </summary>
        /// <value>The in-queue flow to use for conversations waiting in queue.</value>
        [DataMember(Name="queueFlow", EmitDefaultValue=false)]
        public DomainEntityRef QueueFlow { get; set; }
        
        
        
        /// <summary>
        /// The prompt used for whisper on the queue, if configured.
        /// </summary>
        /// <value>The prompt used for whisper on the queue, if configured.</value>
        [DataMember(Name="whisperPrompt", EmitDefaultValue=false)]
        public DomainEntityRef WhisperPrompt { get; set; }
        
        
        
        /// <summary>
        /// Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered.
        /// </summary>
        /// <value>Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered.</value>
        [DataMember(Name="autoAnswerOnly", EmitDefaultValue=false)]
        public bool? AutoAnswerOnly { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether voice transcription is enabled for this queue.
        /// </summary>
        /// <value>Indicates whether voice transcription is enabled for this queue.</value>
        [DataMember(Name="enableTranscription", EmitDefaultValue=false)]
        public bool? EnableTranscription { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether manual assignment is enabled for this queue.
        /// </summary>
        /// <value>Indicates whether manual assignment is enabled for this queue.</value>
        [DataMember(Name="enableManualAssignment", EmitDefaultValue=false)]
        public bool? EnableManualAssignment { get; set; }
        
        
        
        /// <summary>
        /// The name to use for caller identification for outbound calls from this queue.
        /// </summary>
        /// <value>The name to use for caller identification for outbound calls from this queue.</value>
        [DataMember(Name="callingPartyName", EmitDefaultValue=false)]
        public string CallingPartyName { get; set; }
        
        
        
        /// <summary>
        /// The phone number to use for caller identification for outbound calls from this queue.
        /// </summary>
        /// <value>The phone number to use for caller identification for outbound calls from this queue.</value>
        [DataMember(Name="callingPartyNumber", EmitDefaultValue=false)]
        public string CallingPartyNumber { get; set; }
        
        
        
        /// <summary>
        /// The default script Ids for the communication types.
        /// </summary>
        /// <value>The default script Ids for the communication types.</value>
        [DataMember(Name="defaultScripts", EmitDefaultValue=false)]
        public Dictionary<string, Script> DefaultScripts { get; set; }
        
        
        
        /// <summary>
        /// The messaging addresses for the queue.
        /// </summary>
        /// <value>The messaging addresses for the queue.</value>
        [DataMember(Name="outboundMessagingAddresses", EmitDefaultValue=false)]
        public QueueMessagingAddresses OutboundMessagingAddresses { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OutboundEmailAddress
        /// </summary>
        [DataMember(Name="outboundEmailAddress", EmitDefaultValue=false)]
        public QueueEmailAddress OutboundEmailAddress { get; set; }
        
        
        
        /// <summary>
        /// The id of an existing queue to copy the settings from when creating a new queue.
        /// </summary>
        /// <value>The id of an existing queue to copy the settings from when creating a new queue.</value>
        [DataMember(Name="sourceQueueId", EmitDefaultValue=false)]
        public string SourceQueueId { get; set; }
        
        
        
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
            sb.Append("class CreateQueueRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  MediaSettings: ").Append(MediaSettings).Append("\n");
            sb.Append("  RoutingRules: ").Append(RoutingRules).Append("\n");
            sb.Append("  Bullseye: ").Append(Bullseye).Append("\n");
            sb.Append("  AcwSettings: ").Append(AcwSettings).Append("\n");
            sb.Append("  SkillEvaluationMethod: ").Append(SkillEvaluationMethod).Append("\n");
            sb.Append("  QueueFlow: ").Append(QueueFlow).Append("\n");
            sb.Append("  WhisperPrompt: ").Append(WhisperPrompt).Append("\n");
            sb.Append("  AutoAnswerOnly: ").Append(AutoAnswerOnly).Append("\n");
            sb.Append("  EnableTranscription: ").Append(EnableTranscription).Append("\n");
            sb.Append("  EnableManualAssignment: ").Append(EnableManualAssignment).Append("\n");
            sb.Append("  CallingPartyName: ").Append(CallingPartyName).Append("\n");
            sb.Append("  CallingPartyNumber: ").Append(CallingPartyNumber).Append("\n");
            sb.Append("  DefaultScripts: ").Append(DefaultScripts).Append("\n");
            sb.Append("  OutboundMessagingAddresses: ").Append(OutboundMessagingAddresses).Append("\n");
            sb.Append("  OutboundEmailAddress: ").Append(OutboundEmailAddress).Append("\n");
            sb.Append("  SourceQueueId: ").Append(SourceQueueId).Append("\n");
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
            return this.Equals(obj as CreateQueueRequest);
        }

        /// <summary>
        /// Returns true if CreateQueueRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateQueueRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateQueueRequest other)
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
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
                ) &&
                (
                    this.MediaSettings == other.MediaSettings ||
                    this.MediaSettings != null &&
                    this.MediaSettings.SequenceEqual(other.MediaSettings)
                ) &&
                (
                    this.RoutingRules == other.RoutingRules ||
                    this.RoutingRules != null &&
                    this.RoutingRules.SequenceEqual(other.RoutingRules)
                ) &&
                (
                    this.Bullseye == other.Bullseye ||
                    this.Bullseye != null &&
                    this.Bullseye.Equals(other.Bullseye)
                ) &&
                (
                    this.AcwSettings == other.AcwSettings ||
                    this.AcwSettings != null &&
                    this.AcwSettings.Equals(other.AcwSettings)
                ) &&
                (
                    this.SkillEvaluationMethod == other.SkillEvaluationMethod ||
                    this.SkillEvaluationMethod != null &&
                    this.SkillEvaluationMethod.Equals(other.SkillEvaluationMethod)
                ) &&
                (
                    this.QueueFlow == other.QueueFlow ||
                    this.QueueFlow != null &&
                    this.QueueFlow.Equals(other.QueueFlow)
                ) &&
                (
                    this.WhisperPrompt == other.WhisperPrompt ||
                    this.WhisperPrompt != null &&
                    this.WhisperPrompt.Equals(other.WhisperPrompt)
                ) &&
                (
                    this.AutoAnswerOnly == other.AutoAnswerOnly ||
                    this.AutoAnswerOnly != null &&
                    this.AutoAnswerOnly.Equals(other.AutoAnswerOnly)
                ) &&
                (
                    this.EnableTranscription == other.EnableTranscription ||
                    this.EnableTranscription != null &&
                    this.EnableTranscription.Equals(other.EnableTranscription)
                ) &&
                (
                    this.EnableManualAssignment == other.EnableManualAssignment ||
                    this.EnableManualAssignment != null &&
                    this.EnableManualAssignment.Equals(other.EnableManualAssignment)
                ) &&
                (
                    this.CallingPartyName == other.CallingPartyName ||
                    this.CallingPartyName != null &&
                    this.CallingPartyName.Equals(other.CallingPartyName)
                ) &&
                (
                    this.CallingPartyNumber == other.CallingPartyNumber ||
                    this.CallingPartyNumber != null &&
                    this.CallingPartyNumber.Equals(other.CallingPartyNumber)
                ) &&
                (
                    this.DefaultScripts == other.DefaultScripts ||
                    this.DefaultScripts != null &&
                    this.DefaultScripts.SequenceEqual(other.DefaultScripts)
                ) &&
                (
                    this.OutboundMessagingAddresses == other.OutboundMessagingAddresses ||
                    this.OutboundMessagingAddresses != null &&
                    this.OutboundMessagingAddresses.Equals(other.OutboundMessagingAddresses)
                ) &&
                (
                    this.OutboundEmailAddress == other.OutboundEmailAddress ||
                    this.OutboundEmailAddress != null &&
                    this.OutboundEmailAddress.Equals(other.OutboundEmailAddress)
                ) &&
                (
                    this.SourceQueueId == other.SourceQueueId ||
                    this.SourceQueueId != null &&
                    this.SourceQueueId.Equals(other.SourceQueueId)
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
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();
                
                if (this.MediaSettings != null)
                    hash = hash * 59 + this.MediaSettings.GetHashCode();
                
                if (this.RoutingRules != null)
                    hash = hash * 59 + this.RoutingRules.GetHashCode();
                
                if (this.Bullseye != null)
                    hash = hash * 59 + this.Bullseye.GetHashCode();
                
                if (this.AcwSettings != null)
                    hash = hash * 59 + this.AcwSettings.GetHashCode();
                
                if (this.SkillEvaluationMethod != null)
                    hash = hash * 59 + this.SkillEvaluationMethod.GetHashCode();
                
                if (this.QueueFlow != null)
                    hash = hash * 59 + this.QueueFlow.GetHashCode();
                
                if (this.WhisperPrompt != null)
                    hash = hash * 59 + this.WhisperPrompt.GetHashCode();
                
                if (this.AutoAnswerOnly != null)
                    hash = hash * 59 + this.AutoAnswerOnly.GetHashCode();
                
                if (this.EnableTranscription != null)
                    hash = hash * 59 + this.EnableTranscription.GetHashCode();
                
                if (this.EnableManualAssignment != null)
                    hash = hash * 59 + this.EnableManualAssignment.GetHashCode();
                
                if (this.CallingPartyName != null)
                    hash = hash * 59 + this.CallingPartyName.GetHashCode();
                
                if (this.CallingPartyNumber != null)
                    hash = hash * 59 + this.CallingPartyNumber.GetHashCode();
                
                if (this.DefaultScripts != null)
                    hash = hash * 59 + this.DefaultScripts.GetHashCode();
                
                if (this.OutboundMessagingAddresses != null)
                    hash = hash * 59 + this.OutboundMessagingAddresses.GetHashCode();
                
                if (this.OutboundEmailAddress != null)
                    hash = hash * 59 + this.OutboundEmailAddress.GetHashCode();
                
                if (this.SourceQueueId != null)
                    hash = hash * 59 + this.SourceQueueId.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
