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
    /// PromptAssetCreate
    /// </summary>
    [DataContract]
    public partial class PromptAssetCreate :  IEquatable<PromptAssetCreate>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAssetCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PromptAssetCreate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAssetCreate" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Language">The prompt language. (required).</param>
        /// <param name="TtsString">Text to speech of the resource.</param>
        /// <param name="Text">Text of the resource.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="DurationSeconds">DurationSeconds.</param>
        public PromptAssetCreate(string Name = null, string Language = null, string TtsString = null, string Text = null, Dictionary<string, List<string>> Tags = null, double? DurationSeconds = null)
        {
            this.Name = Name;
            this.Language = Language;
            this.TtsString = TtsString;
            this.Text = Text;
            this.Tags = Tags;
            this.DurationSeconds = DurationSeconds;
            
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
        /// Associated prompt ID
        /// </summary>
        /// <value>Associated prompt ID</value>
        [DataMember(Name="promptId", EmitDefaultValue=false)]
        public string PromptId { get; private set; }
        
        
        
        /// <summary>
        /// The prompt language.
        /// </summary>
        /// <value>The prompt language.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        
        
        
        /// <summary>
        /// URI of the resource audio
        /// </summary>
        /// <value>URI of the resource audio</value>
        [DataMember(Name="mediaUri", EmitDefaultValue=false)]
        public string MediaUri { get; private set; }
        
        
        
        /// <summary>
        /// Text to speech of the resource
        /// </summary>
        /// <value>Text to speech of the resource</value>
        [DataMember(Name="ttsString", EmitDefaultValue=false)]
        public string TtsString { get; set; }
        
        
        
        /// <summary>
        /// Text of the resource
        /// </summary>
        /// <value>Text of the resource</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Audio upload status
        /// </summary>
        /// <value>Audio upload status</value>
        [DataMember(Name="uploadStatus", EmitDefaultValue=false)]
        public string UploadStatus { get; private set; }
        
        
        
        /// <summary>
        /// Upload URI for the resource audio
        /// </summary>
        /// <value>Upload URI for the resource audio</value>
        [DataMember(Name="uploadUri", EmitDefaultValue=false)]
        public string UploadUri { get; private set; }
        
        
        
        /// <summary>
        /// Whether or not this resource locale is the default for the language
        /// </summary>
        /// <value>Whether or not this resource locale is the default for the language</value>
        [DataMember(Name="languageDefault", EmitDefaultValue=false)]
        public bool? LanguageDefault { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> Tags { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DurationSeconds
        /// </summary>
        [DataMember(Name="durationSeconds", EmitDefaultValue=false)]
        public double? DurationSeconds { get; set; }
        
        
        
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
            sb.Append("class PromptAssetCreate {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PromptId: ").Append(PromptId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MediaUri: ").Append(MediaUri).Append("\n");
            sb.Append("  TtsString: ").Append(TtsString).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
            sb.Append("  UploadUri: ").Append(UploadUri).Append("\n");
            sb.Append("  LanguageDefault: ").Append(LanguageDefault).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
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
            return this.Equals(obj as PromptAssetCreate);
        }

        /// <summary>
        /// Returns true if PromptAssetCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of PromptAssetCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromptAssetCreate other)
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
                    this.PromptId == other.PromptId ||
                    this.PromptId != null &&
                    this.PromptId.Equals(other.PromptId)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.MediaUri == other.MediaUri ||
                    this.MediaUri != null &&
                    this.MediaUri.Equals(other.MediaUri)
                ) &&
                (
                    this.TtsString == other.TtsString ||
                    this.TtsString != null &&
                    this.TtsString.Equals(other.TtsString)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.UploadStatus == other.UploadStatus ||
                    this.UploadStatus != null &&
                    this.UploadStatus.Equals(other.UploadStatus)
                ) &&
                (
                    this.UploadUri == other.UploadUri ||
                    this.UploadUri != null &&
                    this.UploadUri.Equals(other.UploadUri)
                ) &&
                (
                    this.LanguageDefault == other.LanguageDefault ||
                    this.LanguageDefault != null &&
                    this.LanguageDefault.Equals(other.LanguageDefault)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.DurationSeconds == other.DurationSeconds ||
                    this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(other.DurationSeconds)
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
                
                if (this.PromptId != null)
                    hash = hash * 59 + this.PromptId.GetHashCode();
                
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                
                if (this.MediaUri != null)
                    hash = hash * 59 + this.MediaUri.GetHashCode();
                
                if (this.TtsString != null)
                    hash = hash * 59 + this.TtsString.GetHashCode();
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                if (this.UploadStatus != null)
                    hash = hash * 59 + this.UploadStatus.GetHashCode();
                
                if (this.UploadUri != null)
                    hash = hash * 59 + this.UploadUri.GetHashCode();
                
                if (this.LanguageDefault != null)
                    hash = hash * 59 + this.LanguageDefault.GetHashCode();
                
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                
                if (this.DurationSeconds != null)
                    hash = hash * 59 + this.DurationSeconds.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
