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
    /// Contains information about a response.
    /// </summary>
    [DataContract]
    public partial class Response :  IEquatable<Response>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The interaction type for this response.
        /// </summary>
        /// <value>The interaction type for this response.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InteractionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Chat for "chat"
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Twitter for "twitter"
            /// </summary>
            [EnumMember(Value = "twitter")]
            Twitter
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The response type represented by the response.
        /// </summary>
        /// <value>The response type represented by the response.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ResponseTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Messagingtemplate for "MessagingTemplate"
            /// </summary>
            [EnumMember(Value = "MessagingTemplate")]
            Messagingtemplate,
            
            /// <summary>
            /// Enum Campaignsmstemplate for "CampaignSmsTemplate"
            /// </summary>
            [EnumMember(Value = "CampaignSmsTemplate")]
            Campaignsmstemplate,
            
            /// <summary>
            /// Enum Campaignemailtemplate for "CampaignEmailTemplate"
            /// </summary>
            [EnumMember(Value = "CampaignEmailTemplate")]
            Campaignemailtemplate
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The interaction type for this response.
        /// </summary>
        /// <value>The interaction type for this response.</value>
        [DataMember(Name="interactionType", EmitDefaultValue=false)]
        public InteractionTypeEnum? InteractionType { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// The response type represented by the response.
        /// </summary>
        /// <value>The response type represented by the response.</value>
        [DataMember(Name="responseType", EmitDefaultValue=false)]
        public ResponseTypeEnum? ResponseType { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Response() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">Version number required for updates..</param>
        /// <param name="Libraries">One or more libraries response is associated with. (required).</param>
        /// <param name="Texts">One or more texts associated with the response. (required).</param>
        /// <param name="CreatedBy">User that created the response.</param>
        /// <param name="InteractionType">The interaction type for this response..</param>
        /// <param name="Substitutions">Details about any text substitutions used in the texts for this response..</param>
        /// <param name="SubstitutionsSchema">Metadata about the text substitutions in json schema format..</param>
        /// <param name="ResponseType">The response type represented by the response..</param>
        /// <param name="MessagingTemplate">An optional messaging template definition for responseType.MessagingTemplate..</param>
        /// <param name="Assets">Assets used in the response.</param>
        public Response(string Name = null, int? Version = null, List<DomainEntityRef> Libraries = null, List<ResponseText> Texts = null, User CreatedBy = null, InteractionTypeEnum? InteractionType = null, List<ResponseSubstitution> Substitutions = null, JsonSchemaDocument SubstitutionsSchema = null, ResponseTypeEnum? ResponseType = null, MessagingTemplate MessagingTemplate = null, List<AddressableEntityRef> Assets = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.Libraries = Libraries;
            this.Texts = Texts;
            this.CreatedBy = CreatedBy;
            this.InteractionType = InteractionType;
            this.Substitutions = Substitutions;
            this.SubstitutionsSchema = SubstitutionsSchema;
            this.ResponseType = ResponseType;
            this.MessagingTemplate = MessagingTemplate;
            this.Assets = Assets;
            
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
        /// Version number required for updates.
        /// </summary>
        /// <value>Version number required for updates.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// One or more libraries response is associated with.
        /// </summary>
        /// <value>One or more libraries response is associated with.</value>
        [DataMember(Name="libraries", EmitDefaultValue=false)]
        public List<DomainEntityRef> Libraries { get; set; }
        
        
        
        /// <summary>
        /// One or more texts associated with the response.
        /// </summary>
        /// <value>One or more texts associated with the response.</value>
        [DataMember(Name="texts", EmitDefaultValue=false)]
        public List<ResponseText> Texts { get; set; }
        
        
        
        /// <summary>
        /// User that created the response
        /// </summary>
        /// <value>User that created the response</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public User CreatedBy { get; set; }
        
        
        
        /// <summary>
        /// The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Details about any text substitutions used in the texts for this response.
        /// </summary>
        /// <value>Details about any text substitutions used in the texts for this response.</value>
        [DataMember(Name="substitutions", EmitDefaultValue=false)]
        public List<ResponseSubstitution> Substitutions { get; set; }
        
        
        
        /// <summary>
        /// Metadata about the text substitutions in json schema format.
        /// </summary>
        /// <value>Metadata about the text substitutions in json schema format.</value>
        [DataMember(Name="substitutionsSchema", EmitDefaultValue=false)]
        public JsonSchemaDocument SubstitutionsSchema { get; set; }
        
        
        
        
        
        /// <summary>
        /// An optional messaging template definition for responseType.MessagingTemplate.
        /// </summary>
        /// <value>An optional messaging template definition for responseType.MessagingTemplate.</value>
        [DataMember(Name="messagingTemplate", EmitDefaultValue=false)]
        public MessagingTemplate MessagingTemplate { get; set; }
        
        
        
        /// <summary>
        /// Assets used in the response
        /// </summary>
        /// <value>Assets used in the response</value>
        [DataMember(Name="assets", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Assets { get; set; }
        
        
        
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
            sb.Append("class Response {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Libraries: ").Append(Libraries).Append("\n");
            sb.Append("  Texts: ").Append(Texts).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
            sb.Append("  Substitutions: ").Append(Substitutions).Append("\n");
            sb.Append("  SubstitutionsSchema: ").Append(SubstitutionsSchema).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  MessagingTemplate: ").Append(MessagingTemplate).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
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
            return this.Equals(obj as Response);
        }

        /// <summary>
        /// Returns true if Response instances are equal
        /// </summary>
        /// <param name="other">Instance of Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Response other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Libraries == other.Libraries ||
                    this.Libraries != null &&
                    this.Libraries.SequenceEqual(other.Libraries)
                ) &&
                (
                    this.Texts == other.Texts ||
                    this.Texts != null &&
                    this.Texts.SequenceEqual(other.Texts)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.InteractionType == other.InteractionType ||
                    this.InteractionType != null &&
                    this.InteractionType.Equals(other.InteractionType)
                ) &&
                (
                    this.Substitutions == other.Substitutions ||
                    this.Substitutions != null &&
                    this.Substitutions.SequenceEqual(other.Substitutions)
                ) &&
                (
                    this.SubstitutionsSchema == other.SubstitutionsSchema ||
                    this.SubstitutionsSchema != null &&
                    this.SubstitutionsSchema.Equals(other.SubstitutionsSchema)
                ) &&
                (
                    this.ResponseType == other.ResponseType ||
                    this.ResponseType != null &&
                    this.ResponseType.Equals(other.ResponseType)
                ) &&
                (
                    this.MessagingTemplate == other.MessagingTemplate ||
                    this.MessagingTemplate != null &&
                    this.MessagingTemplate.Equals(other.MessagingTemplate)
                ) &&
                (
                    this.Assets == other.Assets ||
                    this.Assets != null &&
                    this.Assets.SequenceEqual(other.Assets)
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
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Libraries != null)
                    hash = hash * 59 + this.Libraries.GetHashCode();
                
                if (this.Texts != null)
                    hash = hash * 59 + this.Texts.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.InteractionType != null)
                    hash = hash * 59 + this.InteractionType.GetHashCode();
                
                if (this.Substitutions != null)
                    hash = hash * 59 + this.Substitutions.GetHashCode();
                
                if (this.SubstitutionsSchema != null)
                    hash = hash * 59 + this.SubstitutionsSchema.GetHashCode();
                
                if (this.ResponseType != null)
                    hash = hash * 59 + this.ResponseType.GetHashCode();
                
                if (this.MessagingTemplate != null)
                    hash = hash * 59 + this.MessagingTemplate.GetHashCode();
                
                if (this.Assets != null)
                    hash = hash * 59 + this.Assets.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
