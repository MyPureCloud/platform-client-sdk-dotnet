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
    /// ContentManagementWorkspaceDocumentsTopicDocumentDataV2
    /// </summary>
    [DataContract]
    public partial class ContentManagementWorkspaceDocumentsTopicDocumentDataV2 :  IEquatable<ContentManagementWorkspaceDocumentsTopicDocumentDataV2>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentManagementWorkspaceDocumentsTopicDocumentDataV2" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="Workspace">Workspace.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="ContentType">ContentType.</param>
        /// <param name="ContentLength">ContentLength.</param>
        /// <param name="Filename">Filename.</param>
        /// <param name="ChangeNumber">ChangeNumber.</param>
        /// <param name="DateUploaded">DateUploaded.</param>
        /// <param name="UploadedBy">UploadedBy.</param>
        /// <param name="LockInfo">LockInfo.</param>
        /// <param name="SelfUri">SelfUri.</param>
        public ContentManagementWorkspaceDocumentsTopicDocumentDataV2(string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, ContentManagementWorkspaceDocumentsTopicWorkspaceData Workspace = null, ContentManagementWorkspaceDocumentsTopicUserData CreatedBy = null, string ContentType = null, int? ContentLength = null, string Filename = null, int? ChangeNumber = null, DateTime? DateUploaded = null, ContentManagementWorkspaceDocumentsTopicUserData UploadedBy = null, ContentManagementWorkspaceDocumentsTopicLockData LockInfo = null, string SelfUri = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Workspace = Workspace;
            this.CreatedBy = CreatedBy;
            this.ContentType = ContentType;
            this.ContentLength = ContentLength;
            this.Filename = Filename;
            this.ChangeNumber = ChangeNumber;
            this.DateUploaded = DateUploaded;
            this.UploadedBy = UploadedBy;
            this.LockInfo = LockInfo;
            this.SelfUri = SelfUri;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public ContentManagementWorkspaceDocumentsTopicWorkspaceData Workspace { get; set; }



        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public ContentManagementWorkspaceDocumentsTopicUserData CreatedBy { get; set; }



        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }



        /// <summary>
        /// Gets or Sets ContentLength
        /// </summary>
        [DataMember(Name="contentLength", EmitDefaultValue=false)]
        public int? ContentLength { get; set; }



        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }



        /// <summary>
        /// Gets or Sets ChangeNumber
        /// </summary>
        [DataMember(Name="changeNumber", EmitDefaultValue=false)]
        public int? ChangeNumber { get; set; }



        /// <summary>
        /// Gets or Sets DateUploaded
        /// </summary>
        [DataMember(Name="dateUploaded", EmitDefaultValue=false)]
        public DateTime? DateUploaded { get; set; }



        /// <summary>
        /// Gets or Sets UploadedBy
        /// </summary>
        [DataMember(Name="uploadedBy", EmitDefaultValue=false)]
        public ContentManagementWorkspaceDocumentsTopicUserData UploadedBy { get; set; }



        /// <summary>
        /// Gets or Sets LockInfo
        /// </summary>
        [DataMember(Name="lockInfo", EmitDefaultValue=false)]
        public ContentManagementWorkspaceDocumentsTopicLockData LockInfo { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentManagementWorkspaceDocumentsTopicDocumentDataV2 {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  ChangeNumber: ").Append(ChangeNumber).Append("\n");
            sb.Append("  DateUploaded: ").Append(DateUploaded).Append("\n");
            sb.Append("  UploadedBy: ").Append(UploadedBy).Append("\n");
            sb.Append("  LockInfo: ").Append(LockInfo).Append("\n");
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
            return this.Equals(obj as ContentManagementWorkspaceDocumentsTopicDocumentDataV2);
        }

        /// <summary>
        /// Returns true if ContentManagementWorkspaceDocumentsTopicDocumentDataV2 instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentManagementWorkspaceDocumentsTopicDocumentDataV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentManagementWorkspaceDocumentsTopicDocumentDataV2 other)
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
                    this.Filename == other.Filename ||
                    this.Filename != null &&
                    this.Filename.Equals(other.Filename)
                ) &&
                (
                    this.ChangeNumber == other.ChangeNumber ||
                    this.ChangeNumber != null &&
                    this.ChangeNumber.Equals(other.ChangeNumber)
                ) &&
                (
                    this.DateUploaded == other.DateUploaded ||
                    this.DateUploaded != null &&
                    this.DateUploaded.Equals(other.DateUploaded)
                ) &&
                (
                    this.UploadedBy == other.UploadedBy ||
                    this.UploadedBy != null &&
                    this.UploadedBy.Equals(other.UploadedBy)
                ) &&
                (
                    this.LockInfo == other.LockInfo ||
                    this.LockInfo != null &&
                    this.LockInfo.Equals(other.LockInfo)
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

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Workspace != null)
                    hash = hash * 59 + this.Workspace.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();

                if (this.ContentLength != null)
                    hash = hash * 59 + this.ContentLength.GetHashCode();

                if (this.Filename != null)
                    hash = hash * 59 + this.Filename.GetHashCode();

                if (this.ChangeNumber != null)
                    hash = hash * 59 + this.ChangeNumber.GetHashCode();

                if (this.DateUploaded != null)
                    hash = hash * 59 + this.DateUploaded.GetHashCode();

                if (this.UploadedBy != null)
                    hash = hash * 59 + this.UploadedBy.GetHashCode();

                if (this.LockInfo != null)
                    hash = hash * 59 + this.LockInfo.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
