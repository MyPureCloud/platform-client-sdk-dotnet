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
    /// V3SynchronizationUploadUrlRequest
    /// </summary>
    [DataContract]
    public partial class V3SynchronizationUploadUrlRequest :  IEquatable<V3SynchronizationUploadUrlRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="V3SynchronizationUploadUrlRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V3SynchronizationUploadUrlRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SynchronizationUploadUrlRequest" /> class.
        /// </summary>
        /// <param name="FileName">Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#| (required).</param>
        /// <param name="ContentMd5">Content MD5 of the file to upload encoded in base64, example: \&quot;f8VicOenD6gaWTW3Lqy+KQ&#x3D;&#x3D;\&quot;. Not the hexadecimal representation as \&quot;7fc56270e7a70fa81a5935b72eacbe29\&quot;..</param>
        /// <param name="ContentType">The content type of the file to upload.</param>
        /// <param name="ContentLength">The length of the file to upload in bytes.</param>
        /// <param name="Metadata">The metadata of the file to upload.</param>
        public V3SynchronizationUploadUrlRequest(string FileName = null, string ContentMd5 = null, string ContentType = null, int? ContentLength = null, V3SynchronizationUploadMetadata Metadata = null)
        {
            this.FileName = FileName;
            this.ContentMd5 = ContentMd5;
            this.ContentType = ContentType;
            this.ContentLength = ContentLength;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|
        /// </summary>
        /// <value>Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }



        /// <summary>
        /// Content MD5 of the file to upload encoded in base64, example: \&quot;f8VicOenD6gaWTW3Lqy+KQ&#x3D;&#x3D;\&quot;. Not the hexadecimal representation as \&quot;7fc56270e7a70fa81a5935b72eacbe29\&quot;.
        /// </summary>
        /// <value>Content MD5 of the file to upload encoded in base64, example: \&quot;f8VicOenD6gaWTW3Lqy+KQ&#x3D;&#x3D;\&quot;. Not the hexadecimal representation as \&quot;7fc56270e7a70fa81a5935b72eacbe29\&quot;.</value>
        [DataMember(Name="contentMd5", EmitDefaultValue=false)]
        public string ContentMd5 { get; set; }



        /// <summary>
        /// The content type of the file to upload
        /// </summary>
        /// <value>The content type of the file to upload</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }



        /// <summary>
        /// The length of the file to upload in bytes
        /// </summary>
        /// <value>The length of the file to upload in bytes</value>
        [DataMember(Name="contentLength", EmitDefaultValue=false)]
        public int? ContentLength { get; set; }



        /// <summary>
        /// The metadata of the file to upload
        /// </summary>
        /// <value>The metadata of the file to upload</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public V3SynchronizationUploadMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SynchronizationUploadUrlRequest {\n");

            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  ContentMd5: ").Append(ContentMd5).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as V3SynchronizationUploadUrlRequest);
        }

        /// <summary>
        /// Returns true if V3SynchronizationUploadUrlRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SynchronizationUploadUrlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SynchronizationUploadUrlRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) &&
                (
                    this.ContentMd5 == other.ContentMd5 ||
                    this.ContentMd5 != null &&
                    this.ContentMd5.Equals(other.ContentMd5)
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
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();

                if (this.ContentMd5 != null)
                    hash = hash * 59 + this.ContentMd5.GetHashCode();

                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();

                if (this.ContentLength != null)
                    hash = hash * 59 + this.ContentLength.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
