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
    /// ContactListUploadUrlRequest
    /// </summary>
    [DataContract]
    public partial class ContactListUploadUrlRequest :  IEquatable<ContactListUploadUrlRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListUploadUrlRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactListUploadUrlRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListUploadUrlRequest" /> class.
        /// </summary>
        /// <param name="SignedUrlTimeoutSeconds">The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds.</param>
        /// <param name="ContentType">The content type of the file to upload. Allows MIME types are text/csv, application/vnd.ms-excel, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet (required).</param>
        /// <param name="Id">Id of your contact list to upload to.</param>
        /// <param name="ContactIdName">The column name from your file to use as the contact id..</param>
        /// <param name="ImportTemplateId">Id of your import template to use..</param>
        /// <param name="ListNamePrefix">String that will replace %N in the listNameFormat specified on the import template..</param>
        /// <param name="ClearSystemData">Whether to clear system data.</param>
        /// <param name="DivisionIdForTargetContactLists">Id of the division to be used for the creation of the target contact lists. If not provided, Home division will be used..</param>
        /// <param name="FileSpecificationTemplateId">File specification template ID.</param>
        public ContactListUploadUrlRequest(int? SignedUrlTimeoutSeconds = null, string ContentType = null, string Id = null, string ContactIdName = null, string ImportTemplateId = null, string ListNamePrefix = null, bool? ClearSystemData = null, string DivisionIdForTargetContactLists = null, string FileSpecificationTemplateId = null)
        {
            this.SignedUrlTimeoutSeconds = SignedUrlTimeoutSeconds;
            this.ContentType = ContentType;
            this.Id = Id;
            this.ContactIdName = ContactIdName;
            this.ImportTemplateId = ImportTemplateId;
            this.ListNamePrefix = ListNamePrefix;
            this.ClearSystemData = ClearSystemData;
            this.DivisionIdForTargetContactLists = DivisionIdForTargetContactLists;
            this.FileSpecificationTemplateId = FileSpecificationTemplateId;
            
        }
        


        /// <summary>
        /// The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds
        /// </summary>
        /// <value>The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds</value>
        [DataMember(Name="signedUrlTimeoutSeconds", EmitDefaultValue=false)]
        public int? SignedUrlTimeoutSeconds { get; set; }



        /// <summary>
        /// The content type of the file to upload. Allows MIME types are text/csv, application/vnd.ms-excel, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
        /// </summary>
        /// <value>The content type of the file to upload. Allows MIME types are text/csv, application/vnd.ms-excel, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }



        /// <summary>
        /// Id of your contact list to upload to
        /// </summary>
        /// <value>Id of your contact list to upload to</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The column name from your file to use as the contact id.
        /// </summary>
        /// <value>The column name from your file to use as the contact id.</value>
        [DataMember(Name="contactIdName", EmitDefaultValue=false)]
        public string ContactIdName { get; set; }



        /// <summary>
        /// Id of your import template to use.
        /// </summary>
        /// <value>Id of your import template to use.</value>
        [DataMember(Name="importTemplateId", EmitDefaultValue=false)]
        public string ImportTemplateId { get; set; }



        /// <summary>
        /// String that will replace %N in the listNameFormat specified on the import template.
        /// </summary>
        /// <value>String that will replace %N in the listNameFormat specified on the import template.</value>
        [DataMember(Name="listNamePrefix", EmitDefaultValue=false)]
        public string ListNamePrefix { get; set; }



        /// <summary>
        /// Whether to clear system data
        /// </summary>
        /// <value>Whether to clear system data</value>
        [DataMember(Name="clearSystemData", EmitDefaultValue=false)]
        public bool? ClearSystemData { get; set; }



        /// <summary>
        /// Id of the division to be used for the creation of the target contact lists. If not provided, Home division will be used.
        /// </summary>
        /// <value>Id of the division to be used for the creation of the target contact lists. If not provided, Home division will be used.</value>
        [DataMember(Name="divisionIdForTargetContactLists", EmitDefaultValue=false)]
        public string DivisionIdForTargetContactLists { get; set; }



        /// <summary>
        /// File specification template ID
        /// </summary>
        /// <value>File specification template ID</value>
        [DataMember(Name="fileSpecificationTemplateId", EmitDefaultValue=false)]
        public string FileSpecificationTemplateId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListUploadUrlRequest {\n");

            sb.Append("  SignedUrlTimeoutSeconds: ").Append(SignedUrlTimeoutSeconds).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContactIdName: ").Append(ContactIdName).Append("\n");
            sb.Append("  ImportTemplateId: ").Append(ImportTemplateId).Append("\n");
            sb.Append("  ListNamePrefix: ").Append(ListNamePrefix).Append("\n");
            sb.Append("  ClearSystemData: ").Append(ClearSystemData).Append("\n");
            sb.Append("  DivisionIdForTargetContactLists: ").Append(DivisionIdForTargetContactLists).Append("\n");
            sb.Append("  FileSpecificationTemplateId: ").Append(FileSpecificationTemplateId).Append("\n");
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
            return this.Equals(obj as ContactListUploadUrlRequest);
        }

        /// <summary>
        /// Returns true if ContactListUploadUrlRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactListUploadUrlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListUploadUrlRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SignedUrlTimeoutSeconds == other.SignedUrlTimeoutSeconds ||
                    this.SignedUrlTimeoutSeconds != null &&
                    this.SignedUrlTimeoutSeconds.Equals(other.SignedUrlTimeoutSeconds)
                ) &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.ContactIdName == other.ContactIdName ||
                    this.ContactIdName != null &&
                    this.ContactIdName.Equals(other.ContactIdName)
                ) &&
                (
                    this.ImportTemplateId == other.ImportTemplateId ||
                    this.ImportTemplateId != null &&
                    this.ImportTemplateId.Equals(other.ImportTemplateId)
                ) &&
                (
                    this.ListNamePrefix == other.ListNamePrefix ||
                    this.ListNamePrefix != null &&
                    this.ListNamePrefix.Equals(other.ListNamePrefix)
                ) &&
                (
                    this.ClearSystemData == other.ClearSystemData ||
                    this.ClearSystemData != null &&
                    this.ClearSystemData.Equals(other.ClearSystemData)
                ) &&
                (
                    this.DivisionIdForTargetContactLists == other.DivisionIdForTargetContactLists ||
                    this.DivisionIdForTargetContactLists != null &&
                    this.DivisionIdForTargetContactLists.Equals(other.DivisionIdForTargetContactLists)
                ) &&
                (
                    this.FileSpecificationTemplateId == other.FileSpecificationTemplateId ||
                    this.FileSpecificationTemplateId != null &&
                    this.FileSpecificationTemplateId.Equals(other.FileSpecificationTemplateId)
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
                if (this.SignedUrlTimeoutSeconds != null)
                    hash = hash * 59 + this.SignedUrlTimeoutSeconds.GetHashCode();

                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.ContactIdName != null)
                    hash = hash * 59 + this.ContactIdName.GetHashCode();

                if (this.ImportTemplateId != null)
                    hash = hash * 59 + this.ImportTemplateId.GetHashCode();

                if (this.ListNamePrefix != null)
                    hash = hash * 59 + this.ListNamePrefix.GetHashCode();

                if (this.ClearSystemData != null)
                    hash = hash * 59 + this.ClearSystemData.GetHashCode();

                if (this.DivisionIdForTargetContactLists != null)
                    hash = hash * 59 + this.DivisionIdForTargetContactLists.GetHashCode();

                if (this.FileSpecificationTemplateId != null)
                    hash = hash * 59 + this.FileSpecificationTemplateId.GetHashCode();

                return hash;
            }
        }
    }

}
