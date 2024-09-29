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
    /// KnowledgeSyncJobResponse
    /// </summary>
    [DataContract]
    public partial class KnowledgeSyncJobResponse :  IEquatable<KnowledgeSyncJobResponse>
    {
        /// <summary>
        /// The status of the export job.
        /// </summary>
        /// <value>The status of the export job.</value>
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
            /// Enum Created for "Created"
            /// </summary>
            [EnumMember(Value = "Created")]
            Created,
            
            /// <summary>
            /// Enum Validationinprogress for "ValidationInProgress"
            /// </summary>
            [EnumMember(Value = "ValidationInProgress")]
            Validationinprogress,
            
            /// <summary>
            /// Enum Validationcompleted for "ValidationCompleted"
            /// </summary>
            [EnumMember(Value = "ValidationCompleted")]
            Validationcompleted,
            
            /// <summary>
            /// Enum Validationfailed for "ValidationFailed"
            /// </summary>
            [EnumMember(Value = "ValidationFailed")]
            Validationfailed,
            
            /// <summary>
            /// Enum Started for "Started"
            /// </summary>
            [EnumMember(Value = "Started")]
            Started,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Partialcompleted for "PartialCompleted"
            /// </summary>
            [EnumMember(Value = "PartialCompleted")]
            Partialcompleted,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Abortrequested for "AbortRequested"
            /// </summary>
            [EnumMember(Value = "AbortRequested")]
            Abortrequested,
            
            /// <summary>
            /// Enum Aborted for "Aborted"
            /// </summary>
            [EnumMember(Value = "Aborted")]
            Aborted
        }
        /// <summary>
        /// The status of the export job.
        /// </summary>
        /// <value>The status of the export job.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSyncJobResponse" /> class.
        /// </summary>
        /// <param name="Id">Id of the sync job..</param>
        /// <param name="UploadKey">UploadKey.</param>
        /// <param name="Status">The status of the export job..</param>
        /// <param name="Report">Report of the sync job.</param>
        /// <param name="KnowledgeBase">Knowledge base which document export belongs to..</param>
        /// <param name="DateCreated">The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The timestamp of when the export stopped. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreatedBy">The user who created the operation.</param>
        /// <param name="DownloadURL">The URL of the location at which the caller can download the sync file, when available..</param>
        /// <param name="FailedEntitiesURL">The URL of the location at which the caller can download the entities in json format that failed during the sync..</param>
        /// <param name="Source">Source of the sync job..</param>
        public KnowledgeSyncJobResponse(string Id = null, string UploadKey = null, StatusEnum? Status = null, KnowledgeSyncJobReport Report = null, KnowledgeBaseReference KnowledgeBase = null, DateTime? DateCreated = null, DateTime? DateModified = null, UserReference CreatedBy = null, string DownloadURL = null, string FailedEntitiesURL = null, KnowledgeOperationSource Source = null)
        {
            this.Id = Id;
            this.UploadKey = UploadKey;
            this.Status = Status;
            this.Report = Report;
            this.KnowledgeBase = KnowledgeBase;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.CreatedBy = CreatedBy;
            this.DownloadURL = DownloadURL;
            this.FailedEntitiesURL = FailedEntitiesURL;
            this.Source = Source;
            
        }
        


        /// <summary>
        /// Id of the sync job.
        /// </summary>
        /// <value>Id of the sync job.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets UploadKey
        /// </summary>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }





        /// <summary>
        /// Report of the sync job
        /// </summary>
        /// <value>Report of the sync job</value>
        [DataMember(Name="report", EmitDefaultValue=false)]
        public KnowledgeSyncJobReport Report { get; set; }



        /// <summary>
        /// Knowledge base which document export belongs to.
        /// </summary>
        /// <value>Knowledge base which document export belongs to.</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public KnowledgeBaseReference KnowledgeBase { get; set; }



        /// <summary>
        /// The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The timestamp of when the export stopped. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp of when the export stopped. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The user who created the operation
        /// </summary>
        /// <value>The user who created the operation</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; set; }



        /// <summary>
        /// The URL of the location at which the caller can download the sync file, when available.
        /// </summary>
        /// <value>The URL of the location at which the caller can download the sync file, when available.</value>
        [DataMember(Name="downloadURL", EmitDefaultValue=false)]
        public string DownloadURL { get; set; }



        /// <summary>
        /// The URL of the location at which the caller can download the entities in json format that failed during the sync.
        /// </summary>
        /// <value>The URL of the location at which the caller can download the entities in json format that failed during the sync.</value>
        [DataMember(Name="failedEntitiesURL", EmitDefaultValue=false)]
        public string FailedEntitiesURL { get; set; }



        /// <summary>
        /// Source of the sync job.
        /// </summary>
        /// <value>Source of the sync job.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public KnowledgeOperationSource Source { get; set; }



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
            sb.Append("class KnowledgeSyncJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DownloadURL: ").Append(DownloadURL).Append("\n");
            sb.Append("  FailedEntitiesURL: ").Append(FailedEntitiesURL).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(obj as KnowledgeSyncJobResponse);
        }

        /// <summary>
        /// Returns true if KnowledgeSyncJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSyncJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSyncJobResponse other)
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
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Report == other.Report ||
                    this.Report != null &&
                    this.Report.Equals(other.Report)
                ) &&
                (
                    this.KnowledgeBase == other.KnowledgeBase ||
                    this.KnowledgeBase != null &&
                    this.KnowledgeBase.Equals(other.KnowledgeBase)
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
                    this.DownloadURL == other.DownloadURL ||
                    this.DownloadURL != null &&
                    this.DownloadURL.Equals(other.DownloadURL)
                ) &&
                (
                    this.FailedEntitiesURL == other.FailedEntitiesURL ||
                    this.FailedEntitiesURL != null &&
                    this.FailedEntitiesURL.Equals(other.FailedEntitiesURL)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
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

                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Report != null)
                    hash = hash * 59 + this.Report.GetHashCode();

                if (this.KnowledgeBase != null)
                    hash = hash * 59 + this.KnowledgeBase.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.DownloadURL != null)
                    hash = hash * 59 + this.DownloadURL.GetHashCode();

                if (this.FailedEntitiesURL != null)
                    hash = hash * 59 + this.FailedEntitiesURL.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
