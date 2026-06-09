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
    /// State of a decision table row import job
    /// </summary>
    [DataContract]
    public partial class DecisionTableImportJob :  IEquatable<DecisionTableImportJob>
    {
        /// <summary>
        /// Current status of the import job
        /// </summary>
        /// <value>Current status of the import job</value>
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
            /// Enum Uploading for "Uploading"
            /// </summary>
            [EnumMember(Value = "Uploading")]
            Uploading,
            
            /// <summary>
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Cancelled for "Cancelled"
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled
        }
        /// <summary>
        /// Whether rows are appended to existing rows or rows are replaced
        /// </summary>
        /// <value>Whether rows are appended to existing rows or rows are replaced</value>
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
            /// Enum Append for "Append"
            /// </summary>
            [EnumMember(Value = "Append")]
            Append,
            
            /// <summary>
            /// Enum Replace for "Replace"
            /// </summary>
            [EnumMember(Value = "Replace")]
            Replace
        }
        /// <summary>
        /// Current status of the import job
        /// </summary>
        /// <value>Current status of the import job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Whether rows are appended to existing rows or rows are replaced
        /// </summary>
        /// <value>Whether rows are appended to existing rows or rows are replaced</value>
        [DataMember(Name="importMode", EmitDefaultValue=false)]
        public ImportModeEnum? ImportMode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableImportJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecisionTableImportJob() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableImportJob" /> class.
        /// </summary>
        /// <param name="TableVersion">The table version to be replaced by this import.</param>
        /// <param name="Status">Current status of the import job (required).</param>
        /// <param name="UploadUrl">Pre-signed URL to upload the import file (PUT).</param>
        /// <param name="UploadHeaders">Headers required when uploading file with data to be imported to uploadUrl.</param>
        /// <param name="ImportMode">Whether rows are appended to existing rows or rows are replaced (required).</param>
        /// <param name="FileName">Original file name supplied when the job was created, including the file extension.</param>
        /// <param name="DateCreated">When the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">When the job was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateCompleted">When processing finished, successfully or not. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateExpires">When upload credentials expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="RowMetrics">Row-level metrics populated incrementally during import processing.</param>
        /// <param name="Error">Present when the import job could not be successfully finished.</param>
        public DecisionTableImportJob(int? TableVersion = null, StatusEnum? Status = null, string UploadUrl = null, Dictionary<string, string> UploadHeaders = null, ImportModeEnum? ImportMode = null, string FileName = null, DateTime? DateCreated = null, DateTime? DateModified = null, DateTime? DateCompleted = null, DateTime? DateExpires = null, DecisionTableImportRowMetrics RowMetrics = null, DecisionTableImportJobError Error = null)
        {
            this.TableVersion = TableVersion;
            this.Status = Status;
            this.UploadUrl = UploadUrl;
            this.UploadHeaders = UploadHeaders;
            this.ImportMode = ImportMode;
            this.FileName = FileName;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.DateCompleted = DateCompleted;
            this.DateExpires = DateExpires;
            this.RowMetrics = RowMetrics;
            this.Error = Error;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The table version to be replaced by this import
        /// </summary>
        /// <value>The table version to be replaced by this import</value>
        [DataMember(Name="tableVersion", EmitDefaultValue=false)]
        public int? TableVersion { get; set; }





        /// <summary>
        /// Pre-signed URL to upload the import file (PUT)
        /// </summary>
        /// <value>Pre-signed URL to upload the import file (PUT)</value>
        [DataMember(Name="uploadUrl", EmitDefaultValue=false)]
        public string UploadUrl { get; set; }



        /// <summary>
        /// Headers required when uploading file with data to be imported to uploadUrl
        /// </summary>
        /// <value>Headers required when uploading file with data to be imported to uploadUrl</value>
        [DataMember(Name="uploadHeaders", EmitDefaultValue=false)]
        public Dictionary<string, string> UploadHeaders { get; set; }





        /// <summary>
        /// Original file name supplied when the job was created, including the file extension
        /// </summary>
        /// <value>Original file name supplied when the job was created, including the file extension</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }



        /// <summary>
        /// The user who created the job
        /// </summary>
        /// <value>The user who created the job</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public AddressableEntityRef CreatedBy { get; private set; }



        /// <summary>
        /// When the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>When the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// When the job was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>When the job was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// When processing finished, successfully or not. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>When processing finished, successfully or not. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; set; }



        /// <summary>
        /// When upload credentials expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>When upload credentials expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateExpires", EmitDefaultValue=false)]
        public DateTime? DateExpires { get; set; }



        /// <summary>
        /// Row-level metrics populated incrementally during import processing
        /// </summary>
        /// <value>Row-level metrics populated incrementally during import processing</value>
        [DataMember(Name="rowMetrics", EmitDefaultValue=false)]
        public DecisionTableImportRowMetrics RowMetrics { get; set; }



        /// <summary>
        /// Present when the import job could not be successfully finished
        /// </summary>
        /// <value>Present when the import job could not be successfully finished</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public DecisionTableImportJobError Error { get; set; }



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
            sb.Append("class DecisionTableImportJob {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TableVersion: ").Append(TableVersion).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
            sb.Append("  UploadHeaders: ").Append(UploadHeaders).Append("\n");
            sb.Append("  ImportMode: ").Append(ImportMode).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
            sb.Append("  RowMetrics: ").Append(RowMetrics).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(obj as DecisionTableImportJob);
        }

        /// <summary>
        /// Returns true if DecisionTableImportJob instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableImportJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableImportJob other)
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
                    this.TableVersion == other.TableVersion ||
                    this.TableVersion != null &&
                    this.TableVersion.Equals(other.TableVersion)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.UploadUrl == other.UploadUrl ||
                    this.UploadUrl != null &&
                    this.UploadUrl.Equals(other.UploadUrl)
                ) &&
                (
                    this.UploadHeaders == other.UploadHeaders ||
                    this.UploadHeaders != null &&
                    this.UploadHeaders.SequenceEqual(other.UploadHeaders)
                ) &&
                (
                    this.ImportMode == other.ImportMode ||
                    this.ImportMode != null &&
                    this.ImportMode.Equals(other.ImportMode)
                ) &&
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
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
                    this.DateCompleted == other.DateCompleted ||
                    this.DateCompleted != null &&
                    this.DateCompleted.Equals(other.DateCompleted)
                ) &&
                (
                    this.DateExpires == other.DateExpires ||
                    this.DateExpires != null &&
                    this.DateExpires.Equals(other.DateExpires)
                ) &&
                (
                    this.RowMetrics == other.RowMetrics ||
                    this.RowMetrics != null &&
                    this.RowMetrics.Equals(other.RowMetrics)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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

                if (this.TableVersion != null)
                    hash = hash * 59 + this.TableVersion.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.UploadUrl != null)
                    hash = hash * 59 + this.UploadUrl.GetHashCode();

                if (this.UploadHeaders != null)
                    hash = hash * 59 + this.UploadHeaders.GetHashCode();

                if (this.ImportMode != null)
                    hash = hash * 59 + this.ImportMode.GetHashCode();

                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();

                if (this.DateExpires != null)
                    hash = hash * 59 + this.DateExpires.GetHashCode();

                if (this.RowMetrics != null)
                    hash = hash * 59 + this.RowMetrics.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
