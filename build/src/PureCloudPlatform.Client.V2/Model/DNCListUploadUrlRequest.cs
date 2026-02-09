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
    /// DNCListUploadUrlRequest
    /// </summary>
    [DataContract]
    public partial class DNCListUploadUrlRequest :  IEquatable<DNCListUploadUrlRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DNCListUploadUrlRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DNCListUploadUrlRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DNCListUploadUrlRequest" /> class.
        /// </summary>
        /// <param name="SignedUrlTimeoutSeconds">The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds.</param>
        /// <param name="ContentType">The content type of the file to upload. Allows all types are text/csv, application/vnd.ms-excel, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet (required).</param>
        /// <param name="Id">Id of your dnc list to upload to (required).</param>
        /// <param name="PhoneColumns">The column names from your file from which to upload dnc phone numbers..</param>
        /// <param name="EmailColumns">The column names from your file from which to upload dnc emails..</param>
        /// <param name="CustomExclusionColumns">The column names from your file from which to upload dnc custom exclusion column entries..</param>
        /// <param name="ExpirationDateTimeColumn">The column name from your file to use as the dnc expiration date time..</param>
        /// <param name="WhatsAppColumns">The column names from your file from which to upload dnc whatsapp..</param>
        public DNCListUploadUrlRequest(int? SignedUrlTimeoutSeconds = null, string ContentType = null, string Id = null, string PhoneColumns = null, string EmailColumns = null, string CustomExclusionColumns = null, string ExpirationDateTimeColumn = null, string WhatsAppColumns = null)
        {
            this.SignedUrlTimeoutSeconds = SignedUrlTimeoutSeconds;
            this.ContentType = ContentType;
            this.Id = Id;
            this.PhoneColumns = PhoneColumns;
            this.EmailColumns = EmailColumns;
            this.CustomExclusionColumns = CustomExclusionColumns;
            this.ExpirationDateTimeColumn = ExpirationDateTimeColumn;
            this.WhatsAppColumns = WhatsAppColumns;
            
        }
        


        /// <summary>
        /// The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds
        /// </summary>
        /// <value>The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds</value>
        [DataMember(Name="signedUrlTimeoutSeconds", EmitDefaultValue=false)]
        public int? SignedUrlTimeoutSeconds { get; set; }



        /// <summary>
        /// The content type of the file to upload. Allows all types are text/csv, application/vnd.ms-excel, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
        /// </summary>
        /// <value>The content type of the file to upload. Allows all types are text/csv, application/vnd.ms-excel, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }



        /// <summary>
        /// Id of your dnc list to upload to
        /// </summary>
        /// <value>Id of your dnc list to upload to</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The column names from your file from which to upload dnc phone numbers.
        /// </summary>
        /// <value>The column names from your file from which to upload dnc phone numbers.</value>
        [DataMember(Name="phoneColumns", EmitDefaultValue=false)]
        public string PhoneColumns { get; set; }



        /// <summary>
        /// The column names from your file from which to upload dnc emails.
        /// </summary>
        /// <value>The column names from your file from which to upload dnc emails.</value>
        [DataMember(Name="emailColumns", EmitDefaultValue=false)]
        public string EmailColumns { get; set; }



        /// <summary>
        /// The column names from your file from which to upload dnc custom exclusion column entries.
        /// </summary>
        /// <value>The column names from your file from which to upload dnc custom exclusion column entries.</value>
        [DataMember(Name="customExclusionColumns", EmitDefaultValue=false)]
        public string CustomExclusionColumns { get; set; }



        /// <summary>
        /// The column name from your file to use as the dnc expiration date time.
        /// </summary>
        /// <value>The column name from your file to use as the dnc expiration date time.</value>
        [DataMember(Name="expirationDateTimeColumn", EmitDefaultValue=false)]
        public string ExpirationDateTimeColumn { get; set; }



        /// <summary>
        /// The column names from your file from which to upload dnc whatsapp.
        /// </summary>
        /// <value>The column names from your file from which to upload dnc whatsapp.</value>
        [DataMember(Name="whatsAppColumns", EmitDefaultValue=false)]
        public string WhatsAppColumns { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DNCListUploadUrlRequest {\n");

            sb.Append("  SignedUrlTimeoutSeconds: ").Append(SignedUrlTimeoutSeconds).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
            sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
            sb.Append("  CustomExclusionColumns: ").Append(CustomExclusionColumns).Append("\n");
            sb.Append("  ExpirationDateTimeColumn: ").Append(ExpirationDateTimeColumn).Append("\n");
            sb.Append("  WhatsAppColumns: ").Append(WhatsAppColumns).Append("\n");
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
            return this.Equals(obj as DNCListUploadUrlRequest);
        }

        /// <summary>
        /// Returns true if DNCListUploadUrlRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DNCListUploadUrlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DNCListUploadUrlRequest other)
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
                    this.PhoneColumns == other.PhoneColumns ||
                    this.PhoneColumns != null &&
                    this.PhoneColumns.Equals(other.PhoneColumns)
                ) &&
                (
                    this.EmailColumns == other.EmailColumns ||
                    this.EmailColumns != null &&
                    this.EmailColumns.Equals(other.EmailColumns)
                ) &&
                (
                    this.CustomExclusionColumns == other.CustomExclusionColumns ||
                    this.CustomExclusionColumns != null &&
                    this.CustomExclusionColumns.Equals(other.CustomExclusionColumns)
                ) &&
                (
                    this.ExpirationDateTimeColumn == other.ExpirationDateTimeColumn ||
                    this.ExpirationDateTimeColumn != null &&
                    this.ExpirationDateTimeColumn.Equals(other.ExpirationDateTimeColumn)
                ) &&
                (
                    this.WhatsAppColumns == other.WhatsAppColumns ||
                    this.WhatsAppColumns != null &&
                    this.WhatsAppColumns.Equals(other.WhatsAppColumns)
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

                if (this.PhoneColumns != null)
                    hash = hash * 59 + this.PhoneColumns.GetHashCode();

                if (this.EmailColumns != null)
                    hash = hash * 59 + this.EmailColumns.GetHashCode();

                if (this.CustomExclusionColumns != null)
                    hash = hash * 59 + this.CustomExclusionColumns.GetHashCode();

                if (this.ExpirationDateTimeColumn != null)
                    hash = hash * 59 + this.ExpirationDateTimeColumn.GetHashCode();

                if (this.WhatsAppColumns != null)
                    hash = hash * 59 + this.WhatsAppColumns.GetHashCode();

                return hash;
            }
        }
    }

}
