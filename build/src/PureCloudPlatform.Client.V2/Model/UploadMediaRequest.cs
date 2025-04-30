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
    /// UploadMediaRequest
    /// </summary>
    [DataContract]
    public partial class UploadMediaRequest :  IEquatable<UploadMediaRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UploadMediaRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaRequest" /> class.
        /// </summary>
        /// <param name="FileName">Name of the media file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#| (required).</param>
        /// <param name="ContentLengthBytes">The length of the file to upload in bytes (required).</param>
        /// <param name="ContentMd5">Content MD5 of the file to upload.</param>
        public UploadMediaRequest(string FileName = null, int? ContentLengthBytes = null, string ContentMd5 = null)
        {
            this.FileName = FileName;
            this.ContentLengthBytes = ContentLengthBytes;
            this.ContentMd5 = ContentMd5;
            
        }
        


        /// <summary>
        /// Name of the media file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|
        /// </summary>
        /// <value>Name of the media file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }



        /// <summary>
        /// The length of the file to upload in bytes
        /// </summary>
        /// <value>The length of the file to upload in bytes</value>
        [DataMember(Name="contentLengthBytes", EmitDefaultValue=false)]
        public int? ContentLengthBytes { get; set; }



        /// <summary>
        /// Content MD5 of the file to upload
        /// </summary>
        /// <value>Content MD5 of the file to upload</value>
        [DataMember(Name="contentMd5", EmitDefaultValue=false)]
        public string ContentMd5 { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadMediaRequest {\n");

            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  ContentLengthBytes: ").Append(ContentLengthBytes).Append("\n");
            sb.Append("  ContentMd5: ").Append(ContentMd5).Append("\n");
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
            return this.Equals(obj as UploadMediaRequest);
        }

        /// <summary>
        /// Returns true if UploadMediaRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UploadMediaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadMediaRequest other)
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
                    this.ContentLengthBytes == other.ContentLengthBytes ||
                    this.ContentLengthBytes != null &&
                    this.ContentLengthBytes.Equals(other.ContentLengthBytes)
                ) &&
                (
                    this.ContentMd5 == other.ContentMd5 ||
                    this.ContentMd5 != null &&
                    this.ContentMd5.Equals(other.ContentMd5)
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

                if (this.ContentLengthBytes != null)
                    hash = hash * 59 + this.ContentLengthBytes.GetHashCode();

                if (this.ContentMd5 != null)
                    hash = hash * 59 + this.ContentMd5.GetHashCode();

                return hash;
            }
        }
    }

}
