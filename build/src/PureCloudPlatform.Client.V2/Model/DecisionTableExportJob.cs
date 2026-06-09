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
    /// DecisionTableExportJob
    /// </summary>
    [DataContract]
    public partial class DecisionTableExportJob :  IEquatable<DecisionTableExportJob>
    {
        /// <summary>
        /// Current status of the export job.
        /// </summary>
        /// <value>Current status of the export job.</value>
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        /// <summary>
        /// The type of export that was performed.
        /// </summary>
        /// <value>The type of export that was performed.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExportTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Template for "Template"
            /// </summary>
            [EnumMember(Value = "Template")]
            Template,
            
            /// <summary>
            /// Enum Populated for "Populated"
            /// </summary>
            [EnumMember(Value = "Populated")]
            Populated
        }
        /// <summary>
        /// The format of the exported file.
        /// </summary>
        /// <value>The format of the exported file.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Csv for "Csv"
            /// </summary>
            [EnumMember(Value = "Csv")]
            Csv
        }
        /// <summary>
        /// Current status of the export job.
        /// </summary>
        /// <value>Current status of the export job.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// The type of export that was performed.
        /// </summary>
        /// <value>The type of export that was performed.</value>
        [DataMember(Name="exportType", EmitDefaultValue=false)]
        public ExportTypeEnum? ExportType { get; private set; }
        /// <summary>
        /// The format of the exported file.
        /// </summary>
        /// <value>The format of the exported file.</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableExportJob" /> class.
        /// </summary>
        public DecisionTableExportJob()
        {
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The version of the decision table that was exported.
        /// </summary>
        /// <value>The version of the decision table that was exported.</value>
        [DataMember(Name="tableVersion", EmitDefaultValue=false)]
        public int? TableVersion { get; private set; }





        /// <summary>
        /// The user who created the export job.
        /// </summary>
        /// <value>The user who created the export job.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public AddressableEntityRef CreatedBy { get; private set; }



        /// <summary>
        /// Date when this export job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when this export job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Date when this export job was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when this export job was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// Name of the exported file.
        /// </summary>
        /// <value>Name of the exported file.</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; private set; }



        /// <summary>
        /// Reference to the download resource for obtaining the exported file.
        /// </summary>
        /// <value>Reference to the download resource for obtaining the exported file.</value>
        [DataMember(Name="download", EmitDefaultValue=false)]
        public AddressableEntityRef Download { get; private set; }



        /// <summary>
        /// Date when the download link expires. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the download link expires. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateDownloadExpires", EmitDefaultValue=false)]
        public DateTime? DateDownloadExpires { get; private set; }





        /// <summary>
        /// Total number of rows to export (set when row loading begins).
        /// </summary>
        /// <value>Total number of rows to export (set when row loading begins).</value>
        [DataMember(Name="totalRows", EmitDefaultValue=false)]
        public int? TotalRows { get; private set; }



        /// <summary>
        /// The number of rows exported.
        /// </summary>
        /// <value>The number of rows exported.</value>
        [DataMember(Name="rowsExported", EmitDefaultValue=false)]
        public int? RowsExported { get; private set; }





        /// <summary>
        /// Error details if the export job failed.
        /// </summary>
        /// <value>Error details if the export job failed.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public DecisionTableExportJobError Error { get; private set; }



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
            sb.Append("class DecisionTableExportJob {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TableVersion: ").Append(TableVersion).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  DateDownloadExpires: ").Append(DateDownloadExpires).Append("\n");
            sb.Append("  ExportType: ").Append(ExportType).Append("\n");
            sb.Append("  TotalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  RowsExported: ").Append(RowsExported).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
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
            return this.Equals(obj as DecisionTableExportJob);
        }

        /// <summary>
        /// Returns true if DecisionTableExportJob instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableExportJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableExportJob other)
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
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) &&
                (
                    this.Download == other.Download ||
                    this.Download != null &&
                    this.Download.Equals(other.Download)
                ) &&
                (
                    this.DateDownloadExpires == other.DateDownloadExpires ||
                    this.DateDownloadExpires != null &&
                    this.DateDownloadExpires.Equals(other.DateDownloadExpires)
                ) &&
                (
                    this.ExportType == other.ExportType ||
                    this.ExportType != null &&
                    this.ExportType.Equals(other.ExportType)
                ) &&
                (
                    this.TotalRows == other.TotalRows ||
                    this.TotalRows != null &&
                    this.TotalRows.Equals(other.TotalRows)
                ) &&
                (
                    this.RowsExported == other.RowsExported ||
                    this.RowsExported != null &&
                    this.RowsExported.Equals(other.RowsExported)
                ) &&
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
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

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();

                if (this.Download != null)
                    hash = hash * 59 + this.Download.GetHashCode();

                if (this.DateDownloadExpires != null)
                    hash = hash * 59 + this.DateDownloadExpires.GetHashCode();

                if (this.ExportType != null)
                    hash = hash * 59 + this.ExportType.GetHashCode();

                if (this.TotalRows != null)
                    hash = hash * 59 + this.TotalRows.GetHashCode();

                if (this.RowsExported != null)
                    hash = hash * 59 + this.RowsExported.GetHashCode();

                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
