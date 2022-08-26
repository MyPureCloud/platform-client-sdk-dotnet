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
    /// KnowledgeImportJobResponse
    /// </summary>
    [DataContract]
    public partial class KnowledgeImportJobResponse :  IEquatable<KnowledgeImportJobResponse>
    {
        /// <summary>
        /// file type of the document
        /// </summary>
        /// <value>file type of the document</value>
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
            Csv
        }
        /// <summary>
        /// Status of the import job
        /// </summary>
        /// <value>Status of the import job</value>
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
        /// file type of the document
        /// </summary>
        /// <value>file type of the document</value>
        [DataMember(Name="fileType", EmitDefaultValue=false)]
        public FileTypeEnum? FileType { get; set; }
        /// <summary>
        /// Status of the import job
        /// </summary>
        /// <value>Status of the import job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeImportJobResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeImportJobResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeImportJobResponse" /> class.
        /// </summary>
        /// <param name="UploadKey">Upload key (required).</param>
        /// <param name="FileType">file type of the document (required).</param>
        /// <param name="Settings">Additional optional settings.</param>
        public KnowledgeImportJobResponse(string UploadKey = null, FileTypeEnum? FileType = null, KnowledgeImportJobSettings Settings = null)
        {
            this.UploadKey = UploadKey;
            this.FileType = FileType;
            this.Settings = Settings;
            
        }
        


        /// <summary>
        /// Id of the import job
        /// </summary>
        /// <value>Id of the import job</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Upload key
        /// </summary>
        /// <value>Upload key</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }





        /// <summary>
        /// Additional optional settings
        /// </summary>
        /// <value>Additional optional settings</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public KnowledgeImportJobSettings Settings { get; set; }





        /// <summary>
        /// Report of the import job
        /// </summary>
        /// <value>Report of the import job</value>
        [DataMember(Name="report", EmitDefaultValue=false)]
        public KnowledgeImportJobReport Report { get; private set; }



        /// <summary>
        /// Knowledge base which document import does belong to
        /// </summary>
        /// <value>Knowledge base which document import does belong to</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public KnowledgeBase KnowledgeBase { get; private set; }



        /// <summary>
        /// Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



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
            sb.Append("class KnowledgeImportJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as KnowledgeImportJobResponse);
        }

        /// <summary>
        /// Returns true if KnowledgeImportJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeImportJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeImportJobResponse other)
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
                    this.FileType == other.FileType ||
                    this.FileType != null &&
                    this.FileType.Equals(other.FileType)
                ) &&
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
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

                if (this.FileType != null)
                    hash = hash * 59 + this.FileType.GetHashCode();

                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();

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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
