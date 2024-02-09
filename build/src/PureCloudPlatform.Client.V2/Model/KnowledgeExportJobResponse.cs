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
    /// KnowledgeExportJobResponse
    /// </summary>
    [DataContract]
    public partial class KnowledgeExportJobResponse :  IEquatable<KnowledgeExportJobResponse>
    {
        /// <summary>
        /// File type of the document
        /// </summary>
        /// <value>File type of the document</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FileTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Json for "Json"
            /// </summary>
            [EnumMember(Value = "Json")]
            Json,
            
            /// <summary>
            /// Enum Csv for "Csv"
            /// </summary>
            [EnumMember(Value = "Csv")]
            Csv,
            
            /// <summary>
            /// Enum Xlsx for "Xlsx"
            /// </summary>
            [EnumMember(Value = "Xlsx")]
            Xlsx
        }
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
        /// File type of the document
        /// </summary>
        /// <value>File type of the document</value>
        [DataMember(Name="fileType", EmitDefaultValue=false)]
        public FileTypeEnum? FileType { get; set; }
        /// <summary>
        /// The status of the export job.
        /// </summary>
        /// <value>The status of the export job.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeExportJobResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeExportJobResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeExportJobResponse" /> class.
        /// </summary>
        /// <param name="Id">Id of the export job..</param>
        /// <param name="DownloadURL">The URL of the location at which the caller can download the export file, when available..</param>
        /// <param name="FileType">File type of the document (required).</param>
        /// <param name="JsonFileVersion">Requested version of the exported json file..</param>
        /// <param name="CountDocumentProcessed">The current count of the number of records processed..</param>
        /// <param name="ExportFilter">Filters to narrow down what to export..</param>
        /// <param name="Status">The status of the export job..</param>
        /// <param name="KnowledgeBase">Knowledge base which document export belongs to..</param>
        /// <param name="CreatedBy">The user who created the operation.</param>
        /// <param name="DateCreated">The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The timestamp of when the export stopped. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ErrorInformation">Any error information, or null of the processing is not in failed state..</param>
        public KnowledgeExportJobResponse(string Id = null, string DownloadURL = null, FileTypeEnum? FileType = null, int? JsonFileVersion = null, int? CountDocumentProcessed = null, KnowledgeExportJobFilter ExportFilter = null, StatusEnum? Status = null, KnowledgeBase KnowledgeBase = null, UserReference CreatedBy = null, DateTime? DateCreated = null, DateTime? DateModified = null, ErrorBody ErrorInformation = null)
        {
            this.Id = Id;
            this.DownloadURL = DownloadURL;
            this.FileType = FileType;
            this.JsonFileVersion = JsonFileVersion;
            this.CountDocumentProcessed = CountDocumentProcessed;
            this.ExportFilter = ExportFilter;
            this.Status = Status;
            this.KnowledgeBase = KnowledgeBase;
            this.CreatedBy = CreatedBy;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ErrorInformation = ErrorInformation;
            
        }
        


        /// <summary>
        /// Id of the export job.
        /// </summary>
        /// <value>Id of the export job.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The URL of the location at which the caller can download the export file, when available.
        /// </summary>
        /// <value>The URL of the location at which the caller can download the export file, when available.</value>
        [DataMember(Name="downloadURL", EmitDefaultValue=false)]
        public string DownloadURL { get; set; }





        /// <summary>
        /// Requested version of the exported json file.
        /// </summary>
        /// <value>Requested version of the exported json file.</value>
        [DataMember(Name="jsonFileVersion", EmitDefaultValue=false)]
        public int? JsonFileVersion { get; set; }



        /// <summary>
        /// The current count of the number of records processed.
        /// </summary>
        /// <value>The current count of the number of records processed.</value>
        [DataMember(Name="countDocumentProcessed", EmitDefaultValue=false)]
        public int? CountDocumentProcessed { get; set; }



        /// <summary>
        /// Filters to narrow down what to export.
        /// </summary>
        /// <value>Filters to narrow down what to export.</value>
        [DataMember(Name="exportFilter", EmitDefaultValue=false)]
        public KnowledgeExportJobFilter ExportFilter { get; set; }





        /// <summary>
        /// Knowledge base which document export belongs to.
        /// </summary>
        /// <value>Knowledge base which document export belongs to.</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public KnowledgeBase KnowledgeBase { get; set; }



        /// <summary>
        /// The user who created the operation
        /// </summary>
        /// <value>The user who created the operation</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; set; }



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
        /// Any error information, or null of the processing is not in failed state.
        /// </summary>
        /// <value>Any error information, or null of the processing is not in failed state.</value>
        [DataMember(Name="errorInformation", EmitDefaultValue=false)]
        public ErrorBody ErrorInformation { get; set; }



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
            sb.Append("class KnowledgeExportJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownloadURL: ").Append(DownloadURL).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  JsonFileVersion: ").Append(JsonFileVersion).Append("\n");
            sb.Append("  CountDocumentProcessed: ").Append(CountDocumentProcessed).Append("\n");
            sb.Append("  ExportFilter: ").Append(ExportFilter).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
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
            return this.Equals(obj as KnowledgeExportJobResponse);
        }

        /// <summary>
        /// Returns true if KnowledgeExportJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeExportJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeExportJobResponse other)
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
                    this.DownloadURL == other.DownloadURL ||
                    this.DownloadURL != null &&
                    this.DownloadURL.Equals(other.DownloadURL)
                ) &&
                (
                    this.FileType == other.FileType ||
                    this.FileType != null &&
                    this.FileType.Equals(other.FileType)
                ) &&
                (
                    this.JsonFileVersion == other.JsonFileVersion ||
                    this.JsonFileVersion != null &&
                    this.JsonFileVersion.Equals(other.JsonFileVersion)
                ) &&
                (
                    this.CountDocumentProcessed == other.CountDocumentProcessed ||
                    this.CountDocumentProcessed != null &&
                    this.CountDocumentProcessed.Equals(other.CountDocumentProcessed)
                ) &&
                (
                    this.ExportFilter == other.ExportFilter ||
                    this.ExportFilter != null &&
                    this.ExportFilter.Equals(other.ExportFilter)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.KnowledgeBase == other.KnowledgeBase ||
                    this.KnowledgeBase != null &&
                    this.KnowledgeBase.Equals(other.KnowledgeBase)
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
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.ErrorInformation == other.ErrorInformation ||
                    this.ErrorInformation != null &&
                    this.ErrorInformation.Equals(other.ErrorInformation)
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

                if (this.DownloadURL != null)
                    hash = hash * 59 + this.DownloadURL.GetHashCode();

                if (this.FileType != null)
                    hash = hash * 59 + this.FileType.GetHashCode();

                if (this.JsonFileVersion != null)
                    hash = hash * 59 + this.JsonFileVersion.GetHashCode();

                if (this.CountDocumentProcessed != null)
                    hash = hash * 59 + this.CountDocumentProcessed.GetHashCode();

                if (this.ExportFilter != null)
                    hash = hash * 59 + this.ExportFilter.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.KnowledgeBase != null)
                    hash = hash * 59 + this.KnowledgeBase.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.ErrorInformation != null)
                    hash = hash * 59 + this.ErrorInformation.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
