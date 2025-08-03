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
    /// FlowVersion
    /// </summary>
    [DataContract]
    public partial class FlowVersion :  IEquatable<FlowVersion>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Publish for "PUBLISH"
            /// </summary>
            [EnumMember(Value = "PUBLISH")]
            Publish,
            
            /// <summary>
            /// Enum Checkin for "CHECKIN"
            /// </summary>
            [EnumMember(Value = "CHECKIN")]
            Checkin,
            
            /// <summary>
            /// Enum Save for "SAVE"
            /// </summary>
            [EnumMember(Value = "SAVE")]
            Save
        }
        /// <summary>
        /// Gets or Sets CompatibleFlowTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CompatibleFlowTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bot for "BOT"
            /// </summary>
            [EnumMember(Value = "BOT")]
            Bot,
            
            /// <summary>
            /// Enum Commonmodule for "COMMONMODULE"
            /// </summary>
            [EnumMember(Value = "COMMONMODULE")]
            Commonmodule,
            
            /// <summary>
            /// Enum Digitalbot for "DIGITALBOT"
            /// </summary>
            [EnumMember(Value = "DIGITALBOT")]
            Digitalbot,
            
            /// <summary>
            /// Enum Inboundcall for "INBOUNDCALL"
            /// </summary>
            [EnumMember(Value = "INBOUNDCALL")]
            Inboundcall,
            
            /// <summary>
            /// Enum Inboundchat for "INBOUNDCHAT"
            /// </summary>
            [EnumMember(Value = "INBOUNDCHAT")]
            Inboundchat,
            
            /// <summary>
            /// Enum Inboundemail for "INBOUNDEMAIL"
            /// </summary>
            [EnumMember(Value = "INBOUNDEMAIL")]
            Inboundemail,
            
            /// <summary>
            /// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
            /// </summary>
            [EnumMember(Value = "INBOUNDSHORTMESSAGE")]
            Inboundshortmessage,
            
            /// <summary>
            /// Enum Inqueuecall for "INQUEUECALL"
            /// </summary>
            [EnumMember(Value = "INQUEUECALL")]
            Inqueuecall,
            
            /// <summary>
            /// Enum Inqueueemail for "INQUEUEEMAIL"
            /// </summary>
            [EnumMember(Value = "INQUEUEEMAIL")]
            Inqueueemail,
            
            /// <summary>
            /// Enum Inqueueshortmessage for "INQUEUESHORTMESSAGE"
            /// </summary>
            [EnumMember(Value = "INQUEUESHORTMESSAGE")]
            Inqueueshortmessage,
            
            /// <summary>
            /// Enum Outboundcall for "OUTBOUNDCALL"
            /// </summary>
            [EnumMember(Value = "OUTBOUNDCALL")]
            Outboundcall,
            
            /// <summary>
            /// Enum Securecall for "SECURECALL"
            /// </summary>
            [EnumMember(Value = "SECURECALL")]
            Securecall,
            
            /// <summary>
            /// Enum Speech for "SPEECH"
            /// </summary>
            [EnumMember(Value = "SPEECH")]
            Speech,
            
            /// <summary>
            /// Enum Surveyinvite for "SURVEYINVITE"
            /// </summary>
            [EnumMember(Value = "SURVEYINVITE")]
            Surveyinvite,
            
            /// <summary>
            /// Enum Voice for "VOICE"
            /// </summary>
            [EnumMember(Value = "VOICE")]
            Voice,
            
            /// <summary>
            /// Enum Voicemail for "VOICEMAIL"
            /// </summary>
            [EnumMember(Value = "VOICEMAIL")]
            Voicemail,
            
            /// <summary>
            /// Enum Voicesurvey for "VOICESURVEY"
            /// </summary>
            [EnumMember(Value = "VOICESURVEY")]
            Voicesurvey,
            
            /// <summary>
            /// Enum Workflow for "WORKFLOW"
            /// </summary>
            [EnumMember(Value = "WORKFLOW")]
            Workflow,
            
            /// <summary>
            /// Enum Workitem for "WORKITEM"
            /// </summary>
            [EnumMember(Value = "WORKITEM")]
            Workitem
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowVersion" /> class.
        /// </summary>
        /// <param name="Id">The flow version identifier.</param>
        /// <param name="Name">Name.</param>
        /// <param name="CommitVersion">CommitVersion.</param>
        /// <param name="ConfigurationVersion">ConfigurationVersion.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Secure">Secure.</param>
        /// <param name="Debug">Debug.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="CreatedByClient">CreatedByClient.</param>
        /// <param name="ConfigurationUri">ConfigurationUri.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateCheckedIn">DateCheckedIn.</param>
        /// <param name="DateSaved">DateSaved.</param>
        /// <param name="GenerationId">GenerationId.</param>
        /// <param name="PublishResultUri">PublishResultUri.</param>
        /// <param name="InputSchema">InputSchema.</param>
        /// <param name="OutputSchema">OutputSchema.</param>
        /// <param name="VirtualAgentEnabled">VirtualAgentEnabled.</param>
        /// <param name="AgenticVirtualAgentEnabled">AgenticVirtualAgentEnabled.</param>
        public FlowVersion(string Id = null, string Name = null, string CommitVersion = null, string ConfigurationVersion = null, TypeEnum? Type = null, bool? Secure = null, bool? Debug = null, User CreatedBy = null, DomainEntityRef CreatedByClient = null, string ConfigurationUri = null, long? DateCreated = null, long? DateCheckedIn = null, long? DateSaved = null, string GenerationId = null, string PublishResultUri = null, JsonSchemaDocument InputSchema = null, JsonSchemaDocument OutputSchema = null, bool? VirtualAgentEnabled = null, bool? AgenticVirtualAgentEnabled = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.CommitVersion = CommitVersion;
            this.ConfigurationVersion = ConfigurationVersion;
            this.Type = Type;
            this.Secure = Secure;
            this.Debug = Debug;
            this.CreatedBy = CreatedBy;
            this.CreatedByClient = CreatedByClient;
            this.ConfigurationUri = ConfigurationUri;
            this.DateCreated = DateCreated;
            this.DateCheckedIn = DateCheckedIn;
            this.DateSaved = DateSaved;
            this.GenerationId = GenerationId;
            this.PublishResultUri = PublishResultUri;
            this.InputSchema = InputSchema;
            this.OutputSchema = OutputSchema;
            this.VirtualAgentEnabled = VirtualAgentEnabled;
            this.AgenticVirtualAgentEnabled = AgenticVirtualAgentEnabled;
            
        }
        


        /// <summary>
        /// The flow version identifier
        /// </summary>
        /// <value>The flow version identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets CommitVersion
        /// </summary>
        [DataMember(Name="commitVersion", EmitDefaultValue=false)]
        public string CommitVersion { get; set; }



        /// <summary>
        /// Gets or Sets ConfigurationVersion
        /// </summary>
        [DataMember(Name="configurationVersion", EmitDefaultValue=false)]
        public string ConfigurationVersion { get; set; }





        /// <summary>
        /// Gets or Sets Secure
        /// </summary>
        [DataMember(Name="secure", EmitDefaultValue=false)]
        public bool? Secure { get; set; }



        /// <summary>
        /// Gets or Sets Debug
        /// </summary>
        [DataMember(Name="debug", EmitDefaultValue=false)]
        public bool? Debug { get; set; }



        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public User CreatedBy { get; set; }



        /// <summary>
        /// Gets or Sets CreatedByClient
        /// </summary>
        [DataMember(Name="createdByClient", EmitDefaultValue=false)]
        public DomainEntityRef CreatedByClient { get; set; }



        /// <summary>
        /// Gets or Sets ConfigurationUri
        /// </summary>
        [DataMember(Name="configurationUri", EmitDefaultValue=false)]
        public string ConfigurationUri { get; set; }



        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public long? DateCreated { get; set; }



        /// <summary>
        /// Gets or Sets DateCheckedIn
        /// </summary>
        [DataMember(Name="dateCheckedIn", EmitDefaultValue=false)]
        public long? DateCheckedIn { get; set; }



        /// <summary>
        /// Gets or Sets DateSaved
        /// </summary>
        [DataMember(Name="dateSaved", EmitDefaultValue=false)]
        public long? DateSaved { get; set; }



        /// <summary>
        /// Gets or Sets GenerationId
        /// </summary>
        [DataMember(Name="generationId", EmitDefaultValue=false)]
        public string GenerationId { get; set; }



        /// <summary>
        /// Gets or Sets PublishResultUri
        /// </summary>
        [DataMember(Name="publishResultUri", EmitDefaultValue=false)]
        public string PublishResultUri { get; set; }



        /// <summary>
        /// Gets or Sets InputSchema
        /// </summary>
        [DataMember(Name="inputSchema", EmitDefaultValue=false)]
        public JsonSchemaDocument InputSchema { get; set; }



        /// <summary>
        /// Gets or Sets OutputSchema
        /// </summary>
        [DataMember(Name="outputSchema", EmitDefaultValue=false)]
        public JsonSchemaDocument OutputSchema { get; set; }



        /// <summary>
        /// Gets or Sets VirtualAgentEnabled
        /// </summary>
        [DataMember(Name="virtualAgentEnabled", EmitDefaultValue=false)]
        public bool? VirtualAgentEnabled { get; set; }



        /// <summary>
        /// Gets or Sets AgenticVirtualAgentEnabled
        /// </summary>
        [DataMember(Name="agenticVirtualAgentEnabled", EmitDefaultValue=false)]
        public bool? AgenticVirtualAgentEnabled { get; set; }



        /// <summary>
        /// The date this version became the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date this version became the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="datePublished", EmitDefaultValue=false)]
        public DateTime? DatePublished { get; private set; }



        /// <summary>
        /// The date this version was no longer the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date this version was no longer the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="datePublishedEnd", EmitDefaultValue=false)]
        public DateTime? DatePublishedEnd { get; private set; }



        /// <summary>
        /// Information about the natural language understanding configuration for the flow version
        /// </summary>
        /// <value>Information about the natural language understanding configuration for the flow version</value>
        [DataMember(Name="nluInfo", EmitDefaultValue=false)]
        public NluInfo NluInfo { get; private set; }



        /// <summary>
        /// List of supported languages for this version of the flow
        /// </summary>
        /// <value>List of supported languages for this version of the flow</value>
        [DataMember(Name="supportedLanguages", EmitDefaultValue=false)]
        public List<SupportedLanguage> SupportedLanguages { get; private set; }



        /// <summary>
        /// Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action.
        /// </summary>
        /// <value>Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action.</value>
        [DataMember(Name="compatibleFlowTypes", EmitDefaultValue=false)]
        public List<CompatibleFlowTypesEnum> CompatibleFlowTypes { get; private set; }



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
            sb.Append("class FlowVersion {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CommitVersion: ").Append(CommitVersion).Append("\n");
            sb.Append("  ConfigurationVersion: ").Append(ConfigurationVersion).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedByClient: ").Append(CreatedByClient).Append("\n");
            sb.Append("  ConfigurationUri: ").Append(ConfigurationUri).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateCheckedIn: ").Append(DateCheckedIn).Append("\n");
            sb.Append("  DateSaved: ").Append(DateSaved).Append("\n");
            sb.Append("  GenerationId: ").Append(GenerationId).Append("\n");
            sb.Append("  PublishResultUri: ").Append(PublishResultUri).Append("\n");
            sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
            sb.Append("  OutputSchema: ").Append(OutputSchema).Append("\n");
            sb.Append("  VirtualAgentEnabled: ").Append(VirtualAgentEnabled).Append("\n");
            sb.Append("  AgenticVirtualAgentEnabled: ").Append(AgenticVirtualAgentEnabled).Append("\n");
            sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
            sb.Append("  DatePublishedEnd: ").Append(DatePublishedEnd).Append("\n");
            sb.Append("  NluInfo: ").Append(NluInfo).Append("\n");
            sb.Append("  SupportedLanguages: ").Append(SupportedLanguages).Append("\n");
            sb.Append("  CompatibleFlowTypes: ").Append(CompatibleFlowTypes).Append("\n");
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
            return this.Equals(obj as FlowVersion);
        }

        /// <summary>
        /// Returns true if FlowVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowVersion other)
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
                    this.CommitVersion == other.CommitVersion ||
                    this.CommitVersion != null &&
                    this.CommitVersion.Equals(other.CommitVersion)
                ) &&
                (
                    this.ConfigurationVersion == other.ConfigurationVersion ||
                    this.ConfigurationVersion != null &&
                    this.ConfigurationVersion.Equals(other.ConfigurationVersion)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Secure == other.Secure ||
                    this.Secure != null &&
                    this.Secure.Equals(other.Secure)
                ) &&
                (
                    this.Debug == other.Debug ||
                    this.Debug != null &&
                    this.Debug.Equals(other.Debug)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.CreatedByClient == other.CreatedByClient ||
                    this.CreatedByClient != null &&
                    this.CreatedByClient.Equals(other.CreatedByClient)
                ) &&
                (
                    this.ConfigurationUri == other.ConfigurationUri ||
                    this.ConfigurationUri != null &&
                    this.ConfigurationUri.Equals(other.ConfigurationUri)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateCheckedIn == other.DateCheckedIn ||
                    this.DateCheckedIn != null &&
                    this.DateCheckedIn.Equals(other.DateCheckedIn)
                ) &&
                (
                    this.DateSaved == other.DateSaved ||
                    this.DateSaved != null &&
                    this.DateSaved.Equals(other.DateSaved)
                ) &&
                (
                    this.GenerationId == other.GenerationId ||
                    this.GenerationId != null &&
                    this.GenerationId.Equals(other.GenerationId)
                ) &&
                (
                    this.PublishResultUri == other.PublishResultUri ||
                    this.PublishResultUri != null &&
                    this.PublishResultUri.Equals(other.PublishResultUri)
                ) &&
                (
                    this.InputSchema == other.InputSchema ||
                    this.InputSchema != null &&
                    this.InputSchema.Equals(other.InputSchema)
                ) &&
                (
                    this.OutputSchema == other.OutputSchema ||
                    this.OutputSchema != null &&
                    this.OutputSchema.Equals(other.OutputSchema)
                ) &&
                (
                    this.VirtualAgentEnabled == other.VirtualAgentEnabled ||
                    this.VirtualAgentEnabled != null &&
                    this.VirtualAgentEnabled.Equals(other.VirtualAgentEnabled)
                ) &&
                (
                    this.AgenticVirtualAgentEnabled == other.AgenticVirtualAgentEnabled ||
                    this.AgenticVirtualAgentEnabled != null &&
                    this.AgenticVirtualAgentEnabled.Equals(other.AgenticVirtualAgentEnabled)
                ) &&
                (
                    this.DatePublished == other.DatePublished ||
                    this.DatePublished != null &&
                    this.DatePublished.Equals(other.DatePublished)
                ) &&
                (
                    this.DatePublishedEnd == other.DatePublishedEnd ||
                    this.DatePublishedEnd != null &&
                    this.DatePublishedEnd.Equals(other.DatePublishedEnd)
                ) &&
                (
                    this.NluInfo == other.NluInfo ||
                    this.NluInfo != null &&
                    this.NluInfo.Equals(other.NluInfo)
                ) &&
                (
                    this.SupportedLanguages == other.SupportedLanguages ||
                    this.SupportedLanguages != null &&
                    this.SupportedLanguages.SequenceEqual(other.SupportedLanguages)
                ) &&
                (
                    this.CompatibleFlowTypes == other.CompatibleFlowTypes ||
                    this.CompatibleFlowTypes != null &&
                    this.CompatibleFlowTypes.SequenceEqual(other.CompatibleFlowTypes)
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

                if (this.CommitVersion != null)
                    hash = hash * 59 + this.CommitVersion.GetHashCode();

                if (this.ConfigurationVersion != null)
                    hash = hash * 59 + this.ConfigurationVersion.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Secure != null)
                    hash = hash * 59 + this.Secure.GetHashCode();

                if (this.Debug != null)
                    hash = hash * 59 + this.Debug.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.CreatedByClient != null)
                    hash = hash * 59 + this.CreatedByClient.GetHashCode();

                if (this.ConfigurationUri != null)
                    hash = hash * 59 + this.ConfigurationUri.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateCheckedIn != null)
                    hash = hash * 59 + this.DateCheckedIn.GetHashCode();

                if (this.DateSaved != null)
                    hash = hash * 59 + this.DateSaved.GetHashCode();

                if (this.GenerationId != null)
                    hash = hash * 59 + this.GenerationId.GetHashCode();

                if (this.PublishResultUri != null)
                    hash = hash * 59 + this.PublishResultUri.GetHashCode();

                if (this.InputSchema != null)
                    hash = hash * 59 + this.InputSchema.GetHashCode();

                if (this.OutputSchema != null)
                    hash = hash * 59 + this.OutputSchema.GetHashCode();

                if (this.VirtualAgentEnabled != null)
                    hash = hash * 59 + this.VirtualAgentEnabled.GetHashCode();

                if (this.AgenticVirtualAgentEnabled != null)
                    hash = hash * 59 + this.AgenticVirtualAgentEnabled.GetHashCode();

                if (this.DatePublished != null)
                    hash = hash * 59 + this.DatePublished.GetHashCode();

                if (this.DatePublishedEnd != null)
                    hash = hash * 59 + this.DatePublishedEnd.GetHashCode();

                if (this.NluInfo != null)
                    hash = hash * 59 + this.NluInfo.GetHashCode();

                if (this.SupportedLanguages != null)
                    hash = hash * 59 + this.SupportedLanguages.GetHashCode();

                if (this.CompatibleFlowTypes != null)
                    hash = hash * 59 + this.CompatibleFlowTypes.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
