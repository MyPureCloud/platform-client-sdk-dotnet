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
    /// Document
    /// </summary>
    [DataContract]
    public partial class Document :  IEquatable<Document>
    {
        /// <summary>
        /// Gets or Sets SystemType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SystemTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Document for "DOCUMENT"
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            Document,
            
            /// <summary>
            /// Enum Fax for "FAX"
            /// </summary>
            [EnumMember(Value = "FAX")]
            Fax,
            
            /// <summary>
            /// Enum Recording for "RECORDING"
            /// </summary>
            [EnumMember(Value = "RECORDING")]
            Recording
        }
        /// <summary>
        /// Gets or Sets UploadMethod
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UploadMethodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum SinglePut for "SINGLE_PUT"
            /// </summary>
            [EnumMember(Value = "SINGLE_PUT")]
            SinglePut,
            
            /// <summary>
            /// Enum MultipartPost for "MULTIPART_POST"
            /// </summary>
            [EnumMember(Value = "MULTIPART_POST")]
            MultipartPost
        }
        /// <summary>
        /// Gets or Sets SharingStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SharingStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None,
            
            /// <summary>
            /// Enum Limited for "LIMITED"
            /// </summary>
            [EnumMember(Value = "LIMITED")]
            Limited,
            
            /// <summary>
            /// Enum Public for "PUBLIC"
            /// </summary>
            [EnumMember(Value = "PUBLIC")]
            Public
        }
        /// <summary>
        /// Gets or Sets SystemType
        /// </summary>
        [DataMember(Name="systemType", EmitDefaultValue=false)]
        public SystemTypeEnum? SystemType { get; set; }
        /// <summary>
        /// Gets or Sets UploadMethod
        /// </summary>
        [DataMember(Name="uploadMethod", EmitDefaultValue=false)]
        public UploadMethodEnum? UploadMethod { get; set; }
        /// <summary>
        /// Gets or Sets SharingStatus
        /// </summary>
        [DataMember(Name="sharingStatus", EmitDefaultValue=false)]
        public SharingStatusEnum? SharingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ChangeNumber">ChangeNumber.</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateUploaded">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ContentUri">ContentUri.</param>
        /// <param name="Workspace">Workspace.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="UploadedBy">UploadedBy.</param>
        /// <param name="SharingUri">SharingUri.</param>
        /// <param name="ContentType">ContentType.</param>
        /// <param name="ContentLength">ContentLength.</param>
        /// <param name="SystemType">SystemType.</param>
        /// <param name="Filename">Filename.</param>
        /// <param name="PageCount">PageCount.</param>
        /// <param name="Read">Read.</param>
        /// <param name="CallerAddress">CallerAddress.</param>
        /// <param name="ReceiverAddress">ReceiverAddress.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="TagValues">TagValues.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="Thumbnails">Thumbnails.</param>
        /// <param name="UploadStatus">UploadStatus.</param>
        /// <param name="UploadDestinationUri">UploadDestinationUri.</param>
        /// <param name="UploadMethod">UploadMethod.</param>
        /// <param name="LockInfo">LockInfo.</param>
        /// <param name="Acl">A list of permitted action rights for the user making the request.</param>
        /// <param name="SharingStatus">SharingStatus.</param>
        /// <param name="DownloadSharingUri">DownloadSharingUri.</param>
        public Document(string Name = null, int? ChangeNumber = null, DateTime? DateCreated = null, DateTime? DateModified = null, DateTime? DateUploaded = null, string ContentUri = null, DomainEntityRef Workspace = null, DomainEntityRef CreatedBy = null, DomainEntityRef UploadedBy = null, string SharingUri = null, string ContentType = null, long? ContentLength = null, SystemTypeEnum? SystemType = null, string Filename = null, long? PageCount = null, bool? Read = null, string CallerAddress = null, string ReceiverAddress = null, List<string> Tags = null, List<TagValue> TagValues = null, List<DocumentAttribute> Attributes = null, List<DocumentThumbnail> Thumbnails = null, DomainEntityRef UploadStatus = null, string UploadDestinationUri = null, UploadMethodEnum? UploadMethod = null, LockInfo LockInfo = null, List<string> Acl = null, SharingStatusEnum? SharingStatus = null, string DownloadSharingUri = null)
        {
            this.Name = Name;
            this.ChangeNumber = ChangeNumber;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.DateUploaded = DateUploaded;
            this.ContentUri = ContentUri;
            this.Workspace = Workspace;
            this.CreatedBy = CreatedBy;
            this.UploadedBy = UploadedBy;
            this.SharingUri = SharingUri;
            this.ContentType = ContentType;
            this.ContentLength = ContentLength;
            this.SystemType = SystemType;
            this.Filename = Filename;
            this.PageCount = PageCount;
            this.Read = Read;
            this.CallerAddress = CallerAddress;
            this.ReceiverAddress = ReceiverAddress;
            this.Tags = Tags;
            this.TagValues = TagValues;
            this.Attributes = Attributes;
            this.Thumbnails = Thumbnails;
            this.UploadStatus = UploadStatus;
            this.UploadDestinationUri = UploadDestinationUri;
            this.UploadMethod = UploadMethod;
            this.LockInfo = LockInfo;
            this.Acl = Acl;
            this.SharingStatus = SharingStatus;
            this.DownloadSharingUri = DownloadSharingUri;
            
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
        /// Gets or Sets ChangeNumber
        /// </summary>
        [DataMember(Name="changeNumber", EmitDefaultValue=false)]
        public int? ChangeNumber { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateUploaded", EmitDefaultValue=false)]
        public DateTime? DateUploaded { get; set; }



        /// <summary>
        /// Gets or Sets ContentUri
        /// </summary>
        [DataMember(Name="contentUri", EmitDefaultValue=false)]
        public string ContentUri { get; set; }



        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public DomainEntityRef Workspace { get; set; }



        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public DomainEntityRef CreatedBy { get; set; }



        /// <summary>
        /// Gets or Sets UploadedBy
        /// </summary>
        [DataMember(Name="uploadedBy", EmitDefaultValue=false)]
        public DomainEntityRef UploadedBy { get; set; }



        /// <summary>
        /// Gets or Sets SharingUri
        /// </summary>
        [DataMember(Name="sharingUri", EmitDefaultValue=false)]
        public string SharingUri { get; set; }



        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }



        /// <summary>
        /// Gets or Sets ContentLength
        /// </summary>
        [DataMember(Name="contentLength", EmitDefaultValue=false)]
        public long? ContentLength { get; set; }





        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }



        /// <summary>
        /// Gets or Sets PageCount
        /// </summary>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public long? PageCount { get; set; }



        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }



        /// <summary>
        /// Gets or Sets CallerAddress
        /// </summary>
        [DataMember(Name="callerAddress", EmitDefaultValue=false)]
        public string CallerAddress { get; set; }



        /// <summary>
        /// Gets or Sets ReceiverAddress
        /// </summary>
        [DataMember(Name="receiverAddress", EmitDefaultValue=false)]
        public string ReceiverAddress { get; set; }



        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// Gets or Sets TagValues
        /// </summary>
        [DataMember(Name="tagValues", EmitDefaultValue=false)]
        public List<TagValue> TagValues { get; set; }



        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<DocumentAttribute> Attributes { get; set; }



        /// <summary>
        /// Gets or Sets Thumbnails
        /// </summary>
        [DataMember(Name="thumbnails", EmitDefaultValue=false)]
        public List<DocumentThumbnail> Thumbnails { get; set; }



        /// <summary>
        /// Gets or Sets UploadStatus
        /// </summary>
        [DataMember(Name="uploadStatus", EmitDefaultValue=false)]
        public DomainEntityRef UploadStatus { get; set; }



        /// <summary>
        /// Gets or Sets UploadDestinationUri
        /// </summary>
        [DataMember(Name="uploadDestinationUri", EmitDefaultValue=false)]
        public string UploadDestinationUri { get; set; }





        /// <summary>
        /// Gets or Sets LockInfo
        /// </summary>
        [DataMember(Name="lockInfo", EmitDefaultValue=false)]
        public LockInfo LockInfo { get; set; }



        /// <summary>
        /// A list of permitted action rights for the user making the request
        /// </summary>
        /// <value>A list of permitted action rights for the user making the request</value>
        [DataMember(Name="acl", EmitDefaultValue=false)]
        public List<string> Acl { get; set; }





        /// <summary>
        /// Gets or Sets DownloadSharingUri
        /// </summary>
        [DataMember(Name="downloadSharingUri", EmitDefaultValue=false)]
        public string DownloadSharingUri { get; set; }



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
            sb.Append("class Document {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ChangeNumber: ").Append(ChangeNumber).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DateUploaded: ").Append(DateUploaded).Append("\n");
            sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UploadedBy: ").Append(UploadedBy).Append("\n");
            sb.Append("  SharingUri: ").Append(SharingUri).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  SystemType: ").Append(SystemType).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
            sb.Append("  ReceiverAddress: ").Append(ReceiverAddress).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TagValues: ").Append(TagValues).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
            sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
            sb.Append("  UploadDestinationUri: ").Append(UploadDestinationUri).Append("\n");
            sb.Append("  UploadMethod: ").Append(UploadMethod).Append("\n");
            sb.Append("  LockInfo: ").Append(LockInfo).Append("\n");
            sb.Append("  Acl: ").Append(Acl).Append("\n");
            sb.Append("  SharingStatus: ").Append(SharingStatus).Append("\n");
            sb.Append("  DownloadSharingUri: ").Append(DownloadSharingUri).Append("\n");
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
            return this.Equals(obj as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="other">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document other)
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
                    this.ChangeNumber == other.ChangeNumber ||
                    this.ChangeNumber != null &&
                    this.ChangeNumber.Equals(other.ChangeNumber)
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
                    this.DateUploaded == other.DateUploaded ||
                    this.DateUploaded != null &&
                    this.DateUploaded.Equals(other.DateUploaded)
                ) &&
                (
                    this.ContentUri == other.ContentUri ||
                    this.ContentUri != null &&
                    this.ContentUri.Equals(other.ContentUri)
                ) &&
                (
                    this.Workspace == other.Workspace ||
                    this.Workspace != null &&
                    this.Workspace.Equals(other.Workspace)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.UploadedBy == other.UploadedBy ||
                    this.UploadedBy != null &&
                    this.UploadedBy.Equals(other.UploadedBy)
                ) &&
                (
                    this.SharingUri == other.SharingUri ||
                    this.SharingUri != null &&
                    this.SharingUri.Equals(other.SharingUri)
                ) &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.ContentLength == other.ContentLength ||
                    this.ContentLength != null &&
                    this.ContentLength.Equals(other.ContentLength)
                ) &&
                (
                    this.SystemType == other.SystemType ||
                    this.SystemType != null &&
                    this.SystemType.Equals(other.SystemType)
                ) &&
                (
                    this.Filename == other.Filename ||
                    this.Filename != null &&
                    this.Filename.Equals(other.Filename)
                ) &&
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) &&
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
                ) &&
                (
                    this.CallerAddress == other.CallerAddress ||
                    this.CallerAddress != null &&
                    this.CallerAddress.Equals(other.CallerAddress)
                ) &&
                (
                    this.ReceiverAddress == other.ReceiverAddress ||
                    this.ReceiverAddress != null &&
                    this.ReceiverAddress.Equals(other.ReceiverAddress)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.TagValues == other.TagValues ||
                    this.TagValues != null &&
                    this.TagValues.SequenceEqual(other.TagValues)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.Thumbnails == other.Thumbnails ||
                    this.Thumbnails != null &&
                    this.Thumbnails.SequenceEqual(other.Thumbnails)
                ) &&
                (
                    this.UploadStatus == other.UploadStatus ||
                    this.UploadStatus != null &&
                    this.UploadStatus.Equals(other.UploadStatus)
                ) &&
                (
                    this.UploadDestinationUri == other.UploadDestinationUri ||
                    this.UploadDestinationUri != null &&
                    this.UploadDestinationUri.Equals(other.UploadDestinationUri)
                ) &&
                (
                    this.UploadMethod == other.UploadMethod ||
                    this.UploadMethod != null &&
                    this.UploadMethod.Equals(other.UploadMethod)
                ) &&
                (
                    this.LockInfo == other.LockInfo ||
                    this.LockInfo != null &&
                    this.LockInfo.Equals(other.LockInfo)
                ) &&
                (
                    this.Acl == other.Acl ||
                    this.Acl != null &&
                    this.Acl.SequenceEqual(other.Acl)
                ) &&
                (
                    this.SharingStatus == other.SharingStatus ||
                    this.SharingStatus != null &&
                    this.SharingStatus.Equals(other.SharingStatus)
                ) &&
                (
                    this.DownloadSharingUri == other.DownloadSharingUri ||
                    this.DownloadSharingUri != null &&
                    this.DownloadSharingUri.Equals(other.DownloadSharingUri)
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

                if (this.ChangeNumber != null)
                    hash = hash * 59 + this.ChangeNumber.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DateUploaded != null)
                    hash = hash * 59 + this.DateUploaded.GetHashCode();

                if (this.ContentUri != null)
                    hash = hash * 59 + this.ContentUri.GetHashCode();

                if (this.Workspace != null)
                    hash = hash * 59 + this.Workspace.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.UploadedBy != null)
                    hash = hash * 59 + this.UploadedBy.GetHashCode();

                if (this.SharingUri != null)
                    hash = hash * 59 + this.SharingUri.GetHashCode();

                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();

                if (this.ContentLength != null)
                    hash = hash * 59 + this.ContentLength.GetHashCode();

                if (this.SystemType != null)
                    hash = hash * 59 + this.SystemType.GetHashCode();

                if (this.Filename != null)
                    hash = hash * 59 + this.Filename.GetHashCode();

                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();

                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();

                if (this.CallerAddress != null)
                    hash = hash * 59 + this.CallerAddress.GetHashCode();

                if (this.ReceiverAddress != null)
                    hash = hash * 59 + this.ReceiverAddress.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                if (this.TagValues != null)
                    hash = hash * 59 + this.TagValues.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.Thumbnails != null)
                    hash = hash * 59 + this.Thumbnails.GetHashCode();

                if (this.UploadStatus != null)
                    hash = hash * 59 + this.UploadStatus.GetHashCode();

                if (this.UploadDestinationUri != null)
                    hash = hash * 59 + this.UploadDestinationUri.GetHashCode();

                if (this.UploadMethod != null)
                    hash = hash * 59 + this.UploadMethod.GetHashCode();

                if (this.LockInfo != null)
                    hash = hash * 59 + this.LockInfo.GetHashCode();

                if (this.Acl != null)
                    hash = hash * 59 + this.Acl.GetHashCode();

                if (this.SharingStatus != null)
                    hash = hash * 59 + this.SharingStatus.GetHashCode();

                if (this.DownloadSharingUri != null)
                    hash = hash * 59 + this.DownloadSharingUri.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
