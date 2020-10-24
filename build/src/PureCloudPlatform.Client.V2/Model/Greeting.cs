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
    /// Greeting
    /// </summary>
    [DataContract]
    public partial class Greeting :  IEquatable<Greeting>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Greeting type
        /// </summary>
        /// <value>Greeting type</value>
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
            /// Enum Station for "STATION"
            /// </summary>
            [EnumMember(Value = "STATION")]
            Station,
            
            /// <summary>
            /// Enum Voicemail for "VOICEMAIL"
            /// </summary>
            [EnumMember(Value = "VOICEMAIL")]
            Voicemail,
            
            /// <summary>
            /// Enum Name for "NAME"
            /// </summary>
            [EnumMember(Value = "NAME")]
            Name
        }
        
        
        
        
        /// <summary>
        /// Greeting owner type
        /// </summary>
        /// <value>Greeting owner type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OwnerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User,
            
            /// <summary>
            /// Enum Organization for "ORGANIZATION"
            /// </summary>
            [EnumMember(Value = "ORGANIZATION")]
            Organization,
            
            /// <summary>
            /// Enum Group for "GROUP"
            /// </summary>
            [EnumMember(Value = "GROUP")]
            Group
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Greeting type
        /// </summary>
        /// <value>Greeting type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        /// <summary>
        /// Greeting owner type
        /// </summary>
        /// <value>Greeting owner type</value>
        [DataMember(Name="ownerType", EmitDefaultValue=false)]
        public OwnerTypeEnum? OwnerType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Greeting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Greeting() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Greeting" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Greeting type (required).</param>
        /// <param name="OwnerType">Greeting owner type (required).</param>
        /// <param name="Owner">Greeting owner (required).</param>
        /// <param name="AudioFile">AudioFile.</param>
        /// <param name="AudioTTS">AudioTTS.</param>
        /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        public Greeting(string Name = null, TypeEnum? Type = null, OwnerTypeEnum? OwnerType = null, DomainEntity Owner = null, GreetingAudioFile AudioFile = null, string AudioTTS = null, DateTime? CreatedDate = null, string CreatedBy = null, DateTime? ModifiedDate = null, string ModifiedBy = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.OwnerType = OwnerType;
            this.Owner = Owner;
            this.AudioFile = AudioFile;
            this.AudioTTS = AudioTTS;
            this.CreatedDate = CreatedDate;
            this.CreatedBy = CreatedBy;
            this.ModifiedDate = ModifiedDate;
            this.ModifiedBy = ModifiedBy;
            
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
        /// Greeting owner
        /// </summary>
        /// <value>Greeting owner</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public DomainEntity Owner { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AudioFile
        /// </summary>
        [DataMember(Name="audioFile", EmitDefaultValue=false)]
        public GreetingAudioFile AudioFile { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AudioTTS
        /// </summary>
        [DataMember(Name="audioTTS", EmitDefaultValue=false)]
        public string AudioTTS { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        
        
        
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
            sb.Append("class Greeting {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  AudioFile: ").Append(AudioFile).Append("\n");
            sb.Append("  AudioTTS: ").Append(AudioTTS).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
            return this.Equals(obj as Greeting);
        }

        /// <summary>
        /// Returns true if Greeting instances are equal
        /// </summary>
        /// <param name="other">Instance of Greeting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Greeting other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.OwnerType == other.OwnerType ||
                    this.OwnerType != null &&
                    this.OwnerType.Equals(other.OwnerType)
                ) &&
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) &&
                (
                    this.AudioFile == other.AudioFile ||
                    this.AudioFile != null &&
                    this.AudioFile.Equals(other.AudioFile)
                ) &&
                (
                    this.AudioTTS == other.AudioTTS ||
                    this.AudioTTS != null &&
                    this.AudioTTS.Equals(other.AudioTTS)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.OwnerType != null)
                    hash = hash * 59 + this.OwnerType.GetHashCode();
                
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                
                if (this.AudioFile != null)
                    hash = hash * 59 + this.AudioFile.GetHashCode();
                
                if (this.AudioTTS != null)
                    hash = hash * 59 + this.AudioTTS.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
