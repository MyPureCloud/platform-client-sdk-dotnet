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
    /// V3SynchronizationUploadUrlResponse
    /// </summary>
    [DataContract]
    public partial class V3SynchronizationUploadUrlResponse :  IEquatable<V3SynchronizationUploadUrlResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SynchronizationUploadUrlResponse" /> class.
        /// </summary>
        /// <param name="FileId">The unique identifier for the upload object..</param>
        /// <param name="FileName">Name of the uploaded file..</param>
        /// <param name="Metadata">The metadata of the uploaded file.</param>
        /// <param name="Synchronization">The synchronization of the file upload..</param>
        /// <param name="Url">Pre-signed URL to PUT the file to..</param>
        /// <param name="Headers">Required headers when uploading a file through PUT request to the URL..</param>
        public V3SynchronizationUploadUrlResponse(string FileId = null, string FileName = null, V3SynchronizationUploadMetadata Metadata = null, V3SynchronizationRef Synchronization = null, string Url = null, Dictionary<string, string> Headers = null)
        {
            this.FileId = FileId;
            this.FileName = FileName;
            this.Metadata = Metadata;
            this.Synchronization = Synchronization;
            this.Url = Url;
            this.Headers = Headers;
            
        }
        


        /// <summary>
        /// The unique identifier for the upload object.
        /// </summary>
        /// <value>The unique identifier for the upload object.</value>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }



        /// <summary>
        /// Name of the uploaded file.
        /// </summary>
        /// <value>Name of the uploaded file.</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }



        /// <summary>
        /// The metadata of the uploaded file
        /// </summary>
        /// <value>The metadata of the uploaded file</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public V3SynchronizationUploadMetadata Metadata { get; set; }



        /// <summary>
        /// The synchronization of the file upload.
        /// </summary>
        /// <value>The synchronization of the file upload.</value>
        [DataMember(Name="synchronization", EmitDefaultValue=false)]
        public V3SynchronizationRef Synchronization { get; set; }



        /// <summary>
        /// Pre-signed URL to PUT the file to.
        /// </summary>
        /// <value>Pre-signed URL to PUT the file to.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Required headers when uploading a file through PUT request to the URL.
        /// </summary>
        /// <value>Required headers when uploading a file through PUT request to the URL.</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, string> Headers { get; set; }



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
            sb.Append("class V3SynchronizationUploadUrlResponse {\n");

            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Synchronization: ").Append(Synchronization).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
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
            return this.Equals(obj as V3SynchronizationUploadUrlResponse);
        }

        /// <summary>
        /// Returns true if V3SynchronizationUploadUrlResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SynchronizationUploadUrlResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SynchronizationUploadUrlResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FileId == other.FileId ||
                    this.FileId != null &&
                    this.FileId.Equals(other.FileId)
                ) &&
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.Synchronization == other.Synchronization ||
                    this.Synchronization != null &&
                    this.Synchronization.Equals(other.Synchronization)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
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
                if (this.FileId != null)
                    hash = hash * 59 + this.FileId.GetHashCode();

                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.Synchronization != null)
                    hash = hash * 59 + this.Synchronization.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
