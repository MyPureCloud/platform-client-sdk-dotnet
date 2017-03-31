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
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }
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
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
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
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Version">Version.</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="State">State.</param>
        /// <param name="ModifiedByApp">ModifiedByApp.</param>
        /// <param name="CreatedByApp">CreatedByApp.</param>
        /// <param name="MediaSettings">The media settings for the queue. (required).</param>
        /// <param name="Bullseye">The bulls-eye settings for the queue..</param>
        /// <param name="AcwSettings">The ACW settings for the queue. (required).</param>
        /// <param name="SkillEvaluationMethod">The skill evaluation method to use when routing conversations. (required).</param>
        /// <param name="QueueFlow">The in-queue flow to use for conversations waiting in queue..</param>
        /// <param name="CallingPartyName">The name to use for caller identification for outbound calls from this queue..</param>
        /// <param name="CallingPartyNumber">The phone number to use for caller identification for outbound calls from this queue..</param>
        /// <param name="DefaultScripts">The default script Ids for the communication types..</param>
        /// <param name="OutboundEmailAddress">OutboundEmailAddress.</param>
        /// <param name="SourceQueueId">The id of an existing queue to copy the settings from when creating a new queue..</param>
        /// <param name="MemberCount">MemberCount.</param>
        public CreateQueueRequest(string Name = null, string Description = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, StateEnum? State = null, string ModifiedByApp = null, string CreatedByApp = null, Dictionary<string, MediaSetting> MediaSettings = null, Bullseye Bullseye = null, AcwSettings AcwSettings = null, SkillEvaluationMethodEnum? SkillEvaluationMethod = null, UriReference QueueFlow = null, string CallingPartyName = null, string CallingPartyNumber = null, Dictionary<string, Script> DefaultScripts = null, QueueEmailAddress OutboundEmailAddress = null, string SourceQueueId = null, int? MemberCount = null)
        {
            // to ensure "MediaSettings" is required (not null)
            if (MediaSettings == null)
            {
                throw new InvalidDataException("MediaSettings is a required property for CreateQueueRequest and cannot be null");
            }
            else
            {
                this.MediaSettings = MediaSettings;
            }
            // to ensure "AcwSettings" is required (not null)
            if (AcwSettings == null)
            {
                throw new InvalidDataException("AcwSettings is a required property for CreateQueueRequest and cannot be null");
            }
            else
            {
                this.AcwSettings = AcwSettings;
            }
            // to ensure "SkillEvaluationMethod" is required (not null)
            if (SkillEvaluationMethod == null)
            {
                throw new InvalidDataException("SkillEvaluationMethod is a required property for CreateQueueRequest and cannot be null");
            }
            else
            {
                this.SkillEvaluationMethod = SkillEvaluationMethod;
            }
            this.Name = Name;
            this.Description = Description;
            this.Version = Version;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.CreatedBy = CreatedBy;
            this.State = State;
            this.ModifiedByApp = ModifiedByApp;
            this.CreatedByApp = CreatedByApp;
            this.Bullseye = Bullseye;
            this.QueueFlow = QueueFlow;
            this.CallingPartyName = CallingPartyName;
            this.CallingPartyNumber = CallingPartyNumber;
            this.DefaultScripts = DefaultScripts;
            this.OutboundEmailAddress = OutboundEmailAddress;
            this.SourceQueueId = SourceQueueId;
            this.MemberCount = MemberCount;
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedByApp
        /// </summary>
        [DataMember(Name="modifiedByApp", EmitDefaultValue=false)]
        public string ModifiedByApp { get; set; }
        /// <summary>
        /// Gets or Sets CreatedByApp
        /// </summary>
        [DataMember(Name="createdByApp", EmitDefaultValue=false)]
        public string CreatedByApp { get; set; }
        /// <summary>
        /// The media settings for the queue.
        /// </summary>
        /// <value>The media settings for the queue.</value>
        [DataMember(Name="mediaSettings", EmitDefaultValue=false)]
        public Dictionary<string, MediaSetting> MediaSettings { get; set; }
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
        public UriReference QueueFlow { get; set; }
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
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public int? MemberCount { get; set; }
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
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
            sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
            sb.Append("  MediaSettings: ").Append(MediaSettings).Append("\n");
            sb.Append("  Bullseye: ").Append(Bullseye).Append("\n");
            sb.Append("  AcwSettings: ").Append(AcwSettings).Append("\n");
            sb.Append("  SkillEvaluationMethod: ").Append(SkillEvaluationMethod).Append("\n");
            sb.Append("  QueueFlow: ").Append(QueueFlow).Append("\n");
            sb.Append("  CallingPartyName: ").Append(CallingPartyName).Append("\n");
            sb.Append("  CallingPartyNumber: ").Append(CallingPartyNumber).Append("\n");
            sb.Append("  DefaultScripts: ").Append(DefaultScripts).Append("\n");
            sb.Append("  OutboundEmailAddress: ").Append(OutboundEmailAddress).Append("\n");
            sb.Append("  SourceQueueId: ").Append(SourceQueueId).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ModifiedByApp == other.ModifiedByApp ||
                    this.ModifiedByApp != null &&
                    this.ModifiedByApp.Equals(other.ModifiedByApp)
                ) &&
                (
                    this.CreatedByApp == other.CreatedByApp ||
                    this.CreatedByApp != null &&
                    this.CreatedByApp.Equals(other.CreatedByApp)
                ) &&
                (
                    this.MediaSettings == other.MediaSettings ||
                    this.MediaSettings != null &&
                    this.MediaSettings.SequenceEqual(other.MediaSettings)
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
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.ModifiedByApp != null)
                    hash = hash * 59 + this.ModifiedByApp.GetHashCode();
                if (this.CreatedByApp != null)
                    hash = hash * 59 + this.CreatedByApp.GetHashCode();
                if (this.MediaSettings != null)
                    hash = hash * 59 + this.MediaSettings.GetHashCode();
                if (this.Bullseye != null)
                    hash = hash * 59 + this.Bullseye.GetHashCode();
                if (this.AcwSettings != null)
                    hash = hash * 59 + this.AcwSettings.GetHashCode();
                if (this.SkillEvaluationMethod != null)
                    hash = hash * 59 + this.SkillEvaluationMethod.GetHashCode();
                if (this.QueueFlow != null)
                    hash = hash * 59 + this.QueueFlow.GetHashCode();
                if (this.CallingPartyName != null)
                    hash = hash * 59 + this.CallingPartyName.GetHashCode();
                if (this.CallingPartyNumber != null)
                    hash = hash * 59 + this.CallingPartyNumber.GetHashCode();
                if (this.DefaultScripts != null)
                    hash = hash * 59 + this.DefaultScripts.GetHashCode();
                if (this.OutboundEmailAddress != null)
                    hash = hash * 59 + this.OutboundEmailAddress.GetHashCode();
                if (this.SourceQueueId != null)
                    hash = hash * 59 + this.SourceQueueId.GetHashCode();
                if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
