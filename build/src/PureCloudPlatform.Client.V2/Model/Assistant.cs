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
    /// Assistant
    /// </summary>
    [DataContract]
    public partial class Assistant :  IEquatable<Assistant>
    {
        /// <summary>
        /// State of the assistant.
        /// </summary>
        /// <value>State of the assistant.</value>
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
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive
        }
        /// <summary>
        /// State of the assistant.
        /// </summary>
        /// <value>State of the assistant.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Assistant" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Assistant() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Assistant" /> class.
        /// </summary>
        /// <param name="Name">The name of the assistant that will assist the agent. (required).</param>
        /// <param name="GoogleDialogflowConfig">(Deprecated: use the &#39;knowledgeSuggestionConfig&#39; for genesys knowledge suggestions) Configuration of Dialogflow used to assist the agent with transcriptions and knowledge suggestions..</param>
        /// <param name="TranscriptionConfig">Configuration for speech transcription used to assist the agent. (required).</param>
        /// <param name="KnowledgeSuggestionConfig">Configuration that defines how to produce knowledge suggestions. (required).</param>
        public Assistant(string Name = null, GoogleDialogflowConfig GoogleDialogflowConfig = null, TranscriptionConfig TranscriptionConfig = null, KnowledgeSuggestionConfig KnowledgeSuggestionConfig = null)
        {
            this.Name = Name;
            this.GoogleDialogflowConfig = GoogleDialogflowConfig;
            this.TranscriptionConfig = TranscriptionConfig;
            this.KnowledgeSuggestionConfig = KnowledgeSuggestionConfig;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the assistant that will assist the agent.
        /// </summary>
        /// <value>The name of the assistant that will assist the agent.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Date when the assistant was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the assistant was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Date when the assistant was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the assistant was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The user who created the assistant.
        /// </summary>
        /// <value>The user who created the assistant.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; private set; }



        /// <summary>
        /// The user who last modified the assistant.
        /// </summary>
        /// <value>The user who last modified the assistant.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; private set; }



        /// <summary>
        /// (Deprecated: use the &#39;knowledgeSuggestionConfig&#39; for genesys knowledge suggestions) Configuration of Dialogflow used to assist the agent with transcriptions and knowledge suggestions.
        /// </summary>
        /// <value>(Deprecated: use the &#39;knowledgeSuggestionConfig&#39; for genesys knowledge suggestions) Configuration of Dialogflow used to assist the agent with transcriptions and knowledge suggestions.</value>
        [DataMember(Name="googleDialogflowConfig", EmitDefaultValue=false)]
        public GoogleDialogflowConfig GoogleDialogflowConfig { get; set; }



        /// <summary>
        /// Configuration for speech transcription used to assist the agent.
        /// </summary>
        /// <value>Configuration for speech transcription used to assist the agent.</value>
        [DataMember(Name="transcriptionConfig", EmitDefaultValue=false)]
        public TranscriptionConfig TranscriptionConfig { get; set; }



        /// <summary>
        /// Configuration that defines how to produce knowledge suggestions.
        /// </summary>
        /// <value>Configuration that defines how to produce knowledge suggestions.</value>
        [DataMember(Name="knowledgeSuggestionConfig", EmitDefaultValue=false)]
        public KnowledgeSuggestionConfig KnowledgeSuggestionConfig { get; set; }





        /// <summary>
        /// Agent copilot configuration.
        /// </summary>
        /// <value>Agent copilot configuration.</value>
        [DataMember(Name="copilot", EmitDefaultValue=false)]
        public Copilot Copilot { get; private set; }



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
            sb.Append("class Assistant {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  GoogleDialogflowConfig: ").Append(GoogleDialogflowConfig).Append("\n");
            sb.Append("  TranscriptionConfig: ").Append(TranscriptionConfig).Append("\n");
            sb.Append("  KnowledgeSuggestionConfig: ").Append(KnowledgeSuggestionConfig).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Copilot: ").Append(Copilot).Append("\n");
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
            return this.Equals(obj as Assistant);
        }

        /// <summary>
        /// Returns true if Assistant instances are equal
        /// </summary>
        /// <param name="other">Instance of Assistant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Assistant other)
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
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.GoogleDialogflowConfig == other.GoogleDialogflowConfig ||
                    this.GoogleDialogflowConfig != null &&
                    this.GoogleDialogflowConfig.Equals(other.GoogleDialogflowConfig)
                ) &&
                (
                    this.TranscriptionConfig == other.TranscriptionConfig ||
                    this.TranscriptionConfig != null &&
                    this.TranscriptionConfig.Equals(other.TranscriptionConfig)
                ) &&
                (
                    this.KnowledgeSuggestionConfig == other.KnowledgeSuggestionConfig ||
                    this.KnowledgeSuggestionConfig != null &&
                    this.KnowledgeSuggestionConfig.Equals(other.KnowledgeSuggestionConfig)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Copilot == other.Copilot ||
                    this.Copilot != null &&
                    this.Copilot.Equals(other.Copilot)
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

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.GoogleDialogflowConfig != null)
                    hash = hash * 59 + this.GoogleDialogflowConfig.GetHashCode();

                if (this.TranscriptionConfig != null)
                    hash = hash * 59 + this.TranscriptionConfig.GetHashCode();

                if (this.KnowledgeSuggestionConfig != null)
                    hash = hash * 59 + this.KnowledgeSuggestionConfig.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Copilot != null)
                    hash = hash * 59 + this.Copilot.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
