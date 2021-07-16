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
    /// State information for an import job of rows to a datatable
    /// </summary>
    [DataContract]
    public partial class DataTableImportJob :  IEquatable<DataTableImportJob>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the import job
        /// </summary>
        /// <value>The status of the import job</value>
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
            /// Enum Waitingforupload for "WaitingForUpload"
            /// </summary>
            [EnumMember(Value = "WaitingForUpload")]
            Waitingforupload,
            
            /// <summary>
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Succeeded for "Succeeded"
            /// </summary>
            [EnumMember(Value = "Succeeded")]
            Succeeded
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The indication of whether the processing should remove rows that don't appear in the import file
        /// </summary>
        /// <value>The indication of whether the processing should remove rows that don't appear in the import file</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ImportModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Replaceall for "ReplaceAll"
            /// </summary>
            [EnumMember(Value = "ReplaceAll")]
            Replaceall,
            
            /// <summary>
            /// Enum Append for "Append"
            /// </summary>
            [EnumMember(Value = "Append")]
            Append
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the import job
        /// </summary>
        /// <value>The status of the import job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The indication of whether the processing should remove rows that don't appear in the import file
        /// </summary>
        /// <value>The indication of whether the processing should remove rows that don't appear in the import file</value>
        [DataMember(Name="importMode", EmitDefaultValue=false)]
        public ImportModeEnum? ImportMode { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTableImportJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataTableImportJob() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTableImportJob" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Owner">The PureCloud user who started the import job.</param>
        /// <param name="Status">The status of the import job (required).</param>
        /// <param name="DateCreated">The timestamp of when the import began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateCompleted">The timestamp of when the import stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="UploadURI">The URL of the location at which the caller can upload the file to be imported.</param>
        /// <param name="ImportMode">The indication of whether the processing should remove rows that don&#39;t appear in the import file.</param>
        /// <param name="ErrorInformation">Any error information, or null of the processing is not in an error state.</param>
        /// <param name="CountRecordsUpdated">The current count of the number of records processed.</param>
        /// <param name="CountRecordsDeleted">The current count of the number of records deleted.</param>
        /// <param name="CountRecordsFailed">The current count of the number of records that failed to import.</param>
        public DataTableImportJob(string Name = null, AddressableEntityRef Owner = null, StatusEnum? Status = null, DateTime? DateCreated = null, DateTime? DateCompleted = null, string UploadURI = null, ImportModeEnum? ImportMode = null, ErrorBody ErrorInformation = null, int? CountRecordsUpdated = null, int? CountRecordsDeleted = null, int? CountRecordsFailed = null)
        {
            this.Name = Name;
            this.Owner = Owner;
            this.Status = Status;
            this.DateCreated = DateCreated;
            this.DateCompleted = DateCompleted;
            this.UploadURI = UploadURI;
            this.ImportMode = ImportMode;
            this.ErrorInformation = ErrorInformation;
            this.CountRecordsUpdated = CountRecordsUpdated;
            this.CountRecordsDeleted = CountRecordsDeleted;
            this.CountRecordsFailed = CountRecordsFailed;
            
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
        /// The PureCloud user who started the import job
        /// </summary>
        /// <value>The PureCloud user who started the import job</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public AddressableEntityRef Owner { get; set; }
        
        
        
        
        
        /// <summary>
        /// The timestamp of when the import began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp of when the import began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// The timestamp of when the import stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp of when the import stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; set; }
        
        
        
        /// <summary>
        /// The URL of the location at which the caller can upload the file to be imported
        /// </summary>
        /// <value>The URL of the location at which the caller can upload the file to be imported</value>
        [DataMember(Name="uploadURI", EmitDefaultValue=false)]
        public string UploadURI { get; set; }
        
        
        
        
        
        /// <summary>
        /// Any error information, or null of the processing is not in an error state
        /// </summary>
        /// <value>Any error information, or null of the processing is not in an error state</value>
        [DataMember(Name="errorInformation", EmitDefaultValue=false)]
        public ErrorBody ErrorInformation { get; set; }
        
        
        
        /// <summary>
        /// The current count of the number of records processed
        /// </summary>
        /// <value>The current count of the number of records processed</value>
        [DataMember(Name="countRecordsUpdated", EmitDefaultValue=false)]
        public int? CountRecordsUpdated { get; set; }
        
        
        
        /// <summary>
        /// The current count of the number of records deleted
        /// </summary>
        /// <value>The current count of the number of records deleted</value>
        [DataMember(Name="countRecordsDeleted", EmitDefaultValue=false)]
        public int? CountRecordsDeleted { get; set; }
        
        
        
        /// <summary>
        /// The current count of the number of records that failed to import
        /// </summary>
        /// <value>The current count of the number of records that failed to import</value>
        [DataMember(Name="countRecordsFailed", EmitDefaultValue=false)]
        public int? CountRecordsFailed { get; set; }
        
        
        
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
            sb.Append("class DataTableImportJob {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  UploadURI: ").Append(UploadURI).Append("\n");
            sb.Append("  ImportMode: ").Append(ImportMode).Append("\n");
            sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
            sb.Append("  CountRecordsUpdated: ").Append(CountRecordsUpdated).Append("\n");
            sb.Append("  CountRecordsDeleted: ").Append(CountRecordsDeleted).Append("\n");
            sb.Append("  CountRecordsFailed: ").Append(CountRecordsFailed).Append("\n");
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
            return this.Equals(obj as DataTableImportJob);
        }

        /// <summary>
        /// Returns true if DataTableImportJob instances are equal
        /// </summary>
        /// <param name="other">Instance of DataTableImportJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTableImportJob other)
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
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateCompleted == other.DateCompleted ||
                    this.DateCompleted != null &&
                    this.DateCompleted.Equals(other.DateCompleted)
                ) &&
                (
                    this.UploadURI == other.UploadURI ||
                    this.UploadURI != null &&
                    this.UploadURI.Equals(other.UploadURI)
                ) &&
                (
                    this.ImportMode == other.ImportMode ||
                    this.ImportMode != null &&
                    this.ImportMode.Equals(other.ImportMode)
                ) &&
                (
                    this.ErrorInformation == other.ErrorInformation ||
                    this.ErrorInformation != null &&
                    this.ErrorInformation.Equals(other.ErrorInformation)
                ) &&
                (
                    this.CountRecordsUpdated == other.CountRecordsUpdated ||
                    this.CountRecordsUpdated != null &&
                    this.CountRecordsUpdated.Equals(other.CountRecordsUpdated)
                ) &&
                (
                    this.CountRecordsDeleted == other.CountRecordsDeleted ||
                    this.CountRecordsDeleted != null &&
                    this.CountRecordsDeleted.Equals(other.CountRecordsDeleted)
                ) &&
                (
                    this.CountRecordsFailed == other.CountRecordsFailed ||
                    this.CountRecordsFailed != null &&
                    this.CountRecordsFailed.Equals(other.CountRecordsFailed)
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
                
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();
                
                if (this.UploadURI != null)
                    hash = hash * 59 + this.UploadURI.GetHashCode();
                
                if (this.ImportMode != null)
                    hash = hash * 59 + this.ImportMode.GetHashCode();
                
                if (this.ErrorInformation != null)
                    hash = hash * 59 + this.ErrorInformation.GetHashCode();
                
                if (this.CountRecordsUpdated != null)
                    hash = hash * 59 + this.CountRecordsUpdated.GetHashCode();
                
                if (this.CountRecordsDeleted != null)
                    hash = hash * 59 + this.CountRecordsDeleted.GetHashCode();
                
                if (this.CountRecordsFailed != null)
                    hash = hash * 59 + this.CountRecordsFailed.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
