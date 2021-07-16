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
    /// RecordingMetadata
    /// </summary>
    [DataContract]
    public partial class RecordingMetadata :  IEquatable<RecordingMetadata>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Represents the current file state for a recording. Examples: Uploading, Archived, etc
        /// </summary>
        /// <value>Represents the current file state for a recording. Examples: Uploading, Archived, etc</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FileStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Archived for "ARCHIVED"
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            Archived,
            
            /// <summary>
            /// Enum Available for "AVAILABLE"
            /// </summary>
            [EnumMember(Value = "AVAILABLE")]
            Available,
            
            /// <summary>
            /// Enum Deleted for "DELETED"
            /// </summary>
            [EnumMember(Value = "DELETED")]
            Deleted,
            
            /// <summary>
            /// Enum Restored for "RESTORED"
            /// </summary>
            [EnumMember(Value = "RESTORED")]
            Restored,
            
            /// <summary>
            /// Enum Restoring for "RESTORING"
            /// </summary>
            [EnumMember(Value = "RESTORING")]
            Restoring,
            
            /// <summary>
            /// Enum Uploading for "UPLOADING"
            /// </summary>
            [EnumMember(Value = "UPLOADING")]
            Uploading,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of archive medium used. Example: CloudArchive
        /// </summary>
        /// <value>The type of archive medium used. Example: CloudArchive</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ArchiveMediumEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Cloudarchive for "CLOUDARCHIVE"
            /// </summary>
            [EnumMember(Value = "CLOUDARCHIVE")]
            Cloudarchive
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Represents the current file state for a recording. Examples: Uploading, Archived, etc
        /// </summary>
        /// <value>Represents the current file state for a recording. Examples: Uploading, Archived, etc</value>
        [DataMember(Name="fileState", EmitDefaultValue=false)]
        public FileStateEnum? FileState { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// The type of archive medium used. Example: CloudArchive
        /// </summary>
        /// <value>The type of archive medium used. Example: CloudArchive</value>
        [DataMember(Name="archiveMedium", EmitDefaultValue=false)]
        public ArchiveMediumEnum? ArchiveMedium { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingMetadata" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="Path">Path.</param>
        /// <param name="StartTime">The start time of the recording for screen recordings. Null for other types..</param>
        /// <param name="EndTime">EndTime.</param>
        /// <param name="Media">The type of media that the recording is. At the moment that could be audio, chat, email, or message..</param>
        /// <param name="Annotations">Annotations that belong to the recording. Populated when recording filestate is AVAILABLE..</param>
        /// <param name="FileState">Represents the current file state for a recording. Examples: Uploading, Archived, etc.</param>
        /// <param name="RestoreExpirationTime">The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ArchiveDate">The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ArchiveMedium">The type of archive medium used. Example: CloudArchive.</param>
        /// <param name="DeleteDate">The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ExportDate">The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ExportedDate">The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="MaxAllowedRestorationsForOrg">How many archive restorations the organization is allowed to have..</param>
        /// <param name="RemainingRestorationsAllowedForOrg">The remaining archive restorations the organization has..</param>
        /// <param name="SessionId">The session id represents an external resource id, such as email, call, chat, etc.</param>
        public RecordingMetadata(string Name = null, string ConversationId = null, string Path = null, string StartTime = null, string EndTime = null, string Media = null, List<Annotation> Annotations = null, FileStateEnum? FileState = null, DateTime? RestoreExpirationTime = null, DateTime? ArchiveDate = null, ArchiveMediumEnum? ArchiveMedium = null, DateTime? DeleteDate = null, DateTime? ExportDate = null, DateTime? ExportedDate = null, int? MaxAllowedRestorationsForOrg = null, int? RemainingRestorationsAllowedForOrg = null, string SessionId = null)
        {
            this.Name = Name;
            this.ConversationId = ConversationId;
            this.Path = Path;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Media = Media;
            this.Annotations = Annotations;
            this.FileState = FileState;
            this.RestoreExpirationTime = RestoreExpirationTime;
            this.ArchiveDate = ArchiveDate;
            this.ArchiveMedium = ArchiveMedium;
            this.DeleteDate = DeleteDate;
            this.ExportDate = ExportDate;
            this.ExportedDate = ExportedDate;
            this.MaxAllowedRestorationsForOrg = MaxAllowedRestorationsForOrg;
            this.RemainingRestorationsAllowedForOrg = RemainingRestorationsAllowedForOrg;
            this.SessionId = SessionId;
            
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
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
        
        
        
        /// <summary>
        /// The start time of the recording for screen recordings. Null for other types.
        /// </summary>
        /// <value>The start time of the recording for screen recordings. Null for other types.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public string EndTime { get; set; }
        
        
        
        /// <summary>
        /// The type of media that the recording is. At the moment that could be audio, chat, email, or message.
        /// </summary>
        /// <value>The type of media that the recording is. At the moment that could be audio, chat, email, or message.</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public string Media { get; set; }
        
        
        
        /// <summary>
        /// Annotations that belong to the recording. Populated when recording filestate is AVAILABLE.
        /// </summary>
        /// <value>Annotations that belong to the recording. Populated when recording filestate is AVAILABLE.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        public List<Annotation> Annotations { get; set; }
        
        
        
        
        
        /// <summary>
        /// The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="restoreExpirationTime", EmitDefaultValue=false)]
        public DateTime? RestoreExpirationTime { get; set; }
        
        
        
        /// <summary>
        /// The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="archiveDate", EmitDefaultValue=false)]
        public DateTime? ArchiveDate { get; set; }
        
        
        
        
        
        /// <summary>
        /// The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="deleteDate", EmitDefaultValue=false)]
        public DateTime? DeleteDate { get; set; }
        
        
        
        /// <summary>
        /// The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="exportDate", EmitDefaultValue=false)]
        public DateTime? ExportDate { get; set; }
        
        
        
        /// <summary>
        /// The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="exportedDate", EmitDefaultValue=false)]
        public DateTime? ExportedDate { get; set; }
        
        
        
        /// <summary>
        /// How many archive restorations the organization is allowed to have.
        /// </summary>
        /// <value>How many archive restorations the organization is allowed to have.</value>
        [DataMember(Name="maxAllowedRestorationsForOrg", EmitDefaultValue=false)]
        public int? MaxAllowedRestorationsForOrg { get; set; }
        
        
        
        /// <summary>
        /// The remaining archive restorations the organization has.
        /// </summary>
        /// <value>The remaining archive restorations the organization has.</value>
        [DataMember(Name="remainingRestorationsAllowedForOrg", EmitDefaultValue=false)]
        public int? RemainingRestorationsAllowedForOrg { get; set; }
        
        
        
        /// <summary>
        /// The session id represents an external resource id, such as email, call, chat, etc
        /// </summary>
        /// <value>The session id represents an external resource id, such as email, call, chat, etc</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }
        
        
        
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
            sb.Append("class RecordingMetadata {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  FileState: ").Append(FileState).Append("\n");
            sb.Append("  RestoreExpirationTime: ").Append(RestoreExpirationTime).Append("\n");
            sb.Append("  ArchiveDate: ").Append(ArchiveDate).Append("\n");
            sb.Append("  ArchiveMedium: ").Append(ArchiveMedium).Append("\n");
            sb.Append("  DeleteDate: ").Append(DeleteDate).Append("\n");
            sb.Append("  ExportDate: ").Append(ExportDate).Append("\n");
            sb.Append("  ExportedDate: ").Append(ExportedDate).Append("\n");
            sb.Append("  MaxAllowedRestorationsForOrg: ").Append(MaxAllowedRestorationsForOrg).Append("\n");
            sb.Append("  RemainingRestorationsAllowedForOrg: ").Append(RemainingRestorationsAllowedForOrg).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
            return this.Equals(obj as RecordingMetadata);
        }

        /// <summary>
        /// Returns true if RecordingMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingMetadata other)
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
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
                ) &&
                (
                    this.Annotations == other.Annotations ||
                    this.Annotations != null &&
                    this.Annotations.SequenceEqual(other.Annotations)
                ) &&
                (
                    this.FileState == other.FileState ||
                    this.FileState != null &&
                    this.FileState.Equals(other.FileState)
                ) &&
                (
                    this.RestoreExpirationTime == other.RestoreExpirationTime ||
                    this.RestoreExpirationTime != null &&
                    this.RestoreExpirationTime.Equals(other.RestoreExpirationTime)
                ) &&
                (
                    this.ArchiveDate == other.ArchiveDate ||
                    this.ArchiveDate != null &&
                    this.ArchiveDate.Equals(other.ArchiveDate)
                ) &&
                (
                    this.ArchiveMedium == other.ArchiveMedium ||
                    this.ArchiveMedium != null &&
                    this.ArchiveMedium.Equals(other.ArchiveMedium)
                ) &&
                (
                    this.DeleteDate == other.DeleteDate ||
                    this.DeleteDate != null &&
                    this.DeleteDate.Equals(other.DeleteDate)
                ) &&
                (
                    this.ExportDate == other.ExportDate ||
                    this.ExportDate != null &&
                    this.ExportDate.Equals(other.ExportDate)
                ) &&
                (
                    this.ExportedDate == other.ExportedDate ||
                    this.ExportedDate != null &&
                    this.ExportedDate.Equals(other.ExportedDate)
                ) &&
                (
                    this.MaxAllowedRestorationsForOrg == other.MaxAllowedRestorationsForOrg ||
                    this.MaxAllowedRestorationsForOrg != null &&
                    this.MaxAllowedRestorationsForOrg.Equals(other.MaxAllowedRestorationsForOrg)
                ) &&
                (
                    this.RemainingRestorationsAllowedForOrg == other.RemainingRestorationsAllowedForOrg ||
                    this.RemainingRestorationsAllowedForOrg != null &&
                    this.RemainingRestorationsAllowedForOrg.Equals(other.RemainingRestorationsAllowedForOrg)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
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
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                
                if (this.Annotations != null)
                    hash = hash * 59 + this.Annotations.GetHashCode();
                
                if (this.FileState != null)
                    hash = hash * 59 + this.FileState.GetHashCode();
                
                if (this.RestoreExpirationTime != null)
                    hash = hash * 59 + this.RestoreExpirationTime.GetHashCode();
                
                if (this.ArchiveDate != null)
                    hash = hash * 59 + this.ArchiveDate.GetHashCode();
                
                if (this.ArchiveMedium != null)
                    hash = hash * 59 + this.ArchiveMedium.GetHashCode();
                
                if (this.DeleteDate != null)
                    hash = hash * 59 + this.DeleteDate.GetHashCode();
                
                if (this.ExportDate != null)
                    hash = hash * 59 + this.ExportDate.GetHashCode();
                
                if (this.ExportedDate != null)
                    hash = hash * 59 + this.ExportedDate.GetHashCode();
                
                if (this.MaxAllowedRestorationsForOrg != null)
                    hash = hash * 59 + this.MaxAllowedRestorationsForOrg.GetHashCode();
                
                if (this.RemainingRestorationsAllowedForOrg != null)
                    hash = hash * 59 + this.RemainingRestorationsAllowedForOrg.GetHashCode();
                
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
