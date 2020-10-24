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
    /// EdgeLogsJobFile
    /// </summary>
    [DataContract]
    public partial class EdgeLogsJobFile :  IEquatable<EdgeLogsJobFile>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates if the resource is active, inactive, or deleted.
        /// </summary>
        /// <value>Indicates if the resource is active, inactive, or deleted.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the upload of this file from the Edge to the cloud.  Use /upload to start an upload.
        /// </summary>
        /// <value>The status of the upload of this file from the Edge to the cloud.  Use /upload to start an upload.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UploadStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Uploading for "UPLOADING"
            /// </summary>
            [EnumMember(Value = "UPLOADING")]
            Uploading,
            
            /// <summary>
            /// Enum NotUploaded for "NOT_UPLOADED"
            /// </summary>
            [EnumMember(Value = "NOT_UPLOADED")]
            NotUploaded,
            
            /// <summary>
            /// Enum Uploaded for "UPLOADED"
            /// </summary>
            [EnumMember(Value = "UPLOADED")]
            Uploaded,
            
            /// <summary>
            /// Enum ErrorOnUpload for "ERROR_ON_UPLOAD"
            /// </summary>
            [EnumMember(Value = "ERROR_ON_UPLOAD")]
            ErrorOnUpload
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates if the resource is active, inactive, or deleted.
        /// </summary>
        /// <value>Indicates if the resource is active, inactive, or deleted.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the upload of this file from the Edge to the cloud.  Use /upload to start an upload.
        /// </summary>
        /// <value>The status of the upload of this file from the Edge to the cloud.  Use /upload to start an upload.</value>
        [DataMember(Name="uploadStatus", EmitDefaultValue=false)]
        public UploadStatusEnum? UploadStatus { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeLogsJobFile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdgeLogsJobFile() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeLogsJobFile" /> class.
        /// </summary>
        /// <param name="Name">The name of the entity. (required).</param>
        /// <param name="Description">The resource&#39;s description..</param>
        /// <param name="Version">The current version of the resource..</param>
        /// <param name="DateCreated">The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ModifiedBy">The ID of the user that last modified the resource..</param>
        /// <param name="CreatedBy">The ID of the user that created the resource..</param>
        /// <param name="ModifiedByApp">The application that last modified the resource..</param>
        /// <param name="CreatedByApp">The application that created the resource..</param>
        /// <param name="TimeCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="TimeModified">The time this log file was last modified on the Edge. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="SizeBytes">The size of this file in bytes..</param>
        /// <param name="UploadStatus">The status of the upload of this file from the Edge to the cloud.  Use /upload to start an upload..</param>
        /// <param name="EdgePath">The path of this file on the Edge..</param>
        /// <param name="DownloadId">The download ID to use with the downloads API..</param>
        public EdgeLogsJobFile(string Name = null, string Description = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, string ModifiedByApp = null, string CreatedByApp = null, DateTime? TimeCreated = null, DateTime? TimeModified = null, double? SizeBytes = null, UploadStatusEnum? UploadStatus = null, string EdgePath = null, string DownloadId = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Version = Version;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.CreatedBy = CreatedBy;
            this.ModifiedByApp = ModifiedByApp;
            this.CreatedByApp = CreatedByApp;
            this.TimeCreated = TimeCreated;
            this.TimeModified = TimeModified;
            this.SizeBytes = SizeBytes;
            this.UploadStatus = UploadStatus;
            this.EdgePath = EdgePath;
            this.DownloadId = DownloadId;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The resource&#39;s description.
        /// </summary>
        /// <value>The resource&#39;s description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The current version of the resource.
        /// </summary>
        /// <value>The current version of the resource.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// The ID of the user that last modified the resource.
        /// </summary>
        /// <value>The ID of the user that last modified the resource.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// The ID of the user that created the resource.
        /// </summary>
        /// <value>The ID of the user that created the resource.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        
        
        
        
        
        /// <summary>
        /// The application that last modified the resource.
        /// </summary>
        /// <value>The application that last modified the resource.</value>
        [DataMember(Name="modifiedByApp", EmitDefaultValue=false)]
        public string ModifiedByApp { get; set; }
        
        
        
        /// <summary>
        /// The application that created the resource.
        /// </summary>
        /// <value>The application that created the resource.</value>
        [DataMember(Name="createdByApp", EmitDefaultValue=false)]
        public string CreatedByApp { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timeCreated", EmitDefaultValue=false)]
        public DateTime? TimeCreated { get; set; }
        
        
        
        /// <summary>
        /// The time this log file was last modified on the Edge. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time this log file was last modified on the Edge. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timeModified", EmitDefaultValue=false)]
        public DateTime? TimeModified { get; set; }
        
        
        
        /// <summary>
        /// The size of this file in bytes.
        /// </summary>
        /// <value>The size of this file in bytes.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
        public double? SizeBytes { get; set; }
        
        
        
        
        
        /// <summary>
        /// The path of this file on the Edge.
        /// </summary>
        /// <value>The path of this file on the Edge.</value>
        [DataMember(Name="edgePath", EmitDefaultValue=false)]
        public string EdgePath { get; set; }
        
        
        
        /// <summary>
        /// The download ID to use with the downloads API.
        /// </summary>
        /// <value>The download ID to use with the downloads API.</value>
        [DataMember(Name="downloadId", EmitDefaultValue=false)]
        public string DownloadId { get; set; }
        
        
        
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
            sb.Append("class EdgeLogsJobFile {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
            sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
            sb.Append("  TimeCreated: ").Append(TimeCreated).Append("\n");
            sb.Append("  TimeModified: ").Append(TimeModified).Append("\n");
            sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
            sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
            sb.Append("  EdgePath: ").Append(EdgePath).Append("\n");
            sb.Append("  DownloadId: ").Append(DownloadId).Append("\n");
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
            return this.Equals(obj as EdgeLogsJobFile);
        }

        /// <summary>
        /// Returns true if EdgeLogsJobFile instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeLogsJobFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeLogsJobFile other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ModifiedByApp == other.ModifiedByApp ||
                    this.ModifiedByApp != null &&
                    this.ModifiedByApp.Equals(other.ModifiedByApp)
                ) &&
                (
                    this.CreatedByApp == other.CreatedByApp ||
                    this.CreatedByApp != null &&
                    this.CreatedByApp.Equals(other.CreatedByApp)
                ) &&
                (
                    this.TimeCreated == other.TimeCreated ||
                    this.TimeCreated != null &&
                    this.TimeCreated.Equals(other.TimeCreated)
                ) &&
                (
                    this.TimeModified == other.TimeModified ||
                    this.TimeModified != null &&
                    this.TimeModified.Equals(other.TimeModified)
                ) &&
                (
                    this.SizeBytes == other.SizeBytes ||
                    this.SizeBytes != null &&
                    this.SizeBytes.Equals(other.SizeBytes)
                ) &&
                (
                    this.UploadStatus == other.UploadStatus ||
                    this.UploadStatus != null &&
                    this.UploadStatus.Equals(other.UploadStatus)
                ) &&
                (
                    this.EdgePath == other.EdgePath ||
                    this.EdgePath != null &&
                    this.EdgePath.Equals(other.EdgePath)
                ) &&
                (
                    this.DownloadId == other.DownloadId ||
                    this.DownloadId != null &&
                    this.DownloadId.Equals(other.DownloadId)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.ModifiedByApp != null)
                    hash = hash * 59 + this.ModifiedByApp.GetHashCode();
                
                if (this.CreatedByApp != null)
                    hash = hash * 59 + this.CreatedByApp.GetHashCode();
                
                if (this.TimeCreated != null)
                    hash = hash * 59 + this.TimeCreated.GetHashCode();
                
                if (this.TimeModified != null)
                    hash = hash * 59 + this.TimeModified.GetHashCode();
                
                if (this.SizeBytes != null)
                    hash = hash * 59 + this.SizeBytes.GetHashCode();
                
                if (this.UploadStatus != null)
                    hash = hash * 59 + this.UploadStatus.GetHashCode();
                
                if (this.EdgePath != null)
                    hash = hash * 59 + this.EdgePath.GetHashCode();
                
                if (this.DownloadId != null)
                    hash = hash * 59 + this.DownloadId.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
