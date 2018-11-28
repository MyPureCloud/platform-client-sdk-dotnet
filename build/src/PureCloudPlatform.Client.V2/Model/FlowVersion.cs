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
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="ConfigurationUri">ConfigurationUri.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="GenerationId">GenerationId.</param>
        /// <param name="PublishResultUri">PublishResultUri.</param>
        public FlowVersion(string Id = null, string Name = null, string CommitVersion = null, string ConfigurationVersion = null, TypeEnum? Type = null, bool? Secure = null, User CreatedBy = null, string ConfigurationUri = null, long? DateCreated = null, string GenerationId = null, string PublishResultUri = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.CommitVersion = CommitVersion;
            this.ConfigurationVersion = ConfigurationVersion;
            this.Type = Type;
            this.Secure = Secure;
            this.CreatedBy = CreatedBy;
            this.ConfigurationUri = ConfigurationUri;
            this.DateCreated = DateCreated;
            this.GenerationId = GenerationId;
            this.PublishResultUri = PublishResultUri;
            
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
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public User CreatedBy { get; set; }
        
        
        
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
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ConfigurationUri: ").Append(ConfigurationUri).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  GenerationId: ").Append(GenerationId).Append("\n");
            sb.Append("  PublishResultUri: ").Append(PublishResultUri).Append("\n");
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
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
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
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.ConfigurationUri != null)
                    hash = hash * 59 + this.ConfigurationUri.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.GenerationId != null)
                    hash = hash * 59 + this.GenerationId.GetHashCode();
                
                if (this.PublishResultUri != null)
                    hash = hash * 59 + this.PublishResultUri.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
