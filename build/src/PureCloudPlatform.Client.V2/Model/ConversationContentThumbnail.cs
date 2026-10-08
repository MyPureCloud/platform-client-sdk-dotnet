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
    /// Thumbnail image metadata for the attachment content.
    /// </summary>
    [DataContract]
    public partial class ConversationContentThumbnail :  IEquatable<ConversationContentThumbnail>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentThumbnail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentThumbnail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentThumbnail" /> class.
        /// </summary>
        /// <param name="Url">URL of the thumbnail image. (required).</param>
        /// <param name="Mime">Thumbnail mime type (e.g. image/jpeg)..</param>
        /// <param name="Sha256">Secure hash of the thumbnail content..</param>
        /// <param name="ContentSizeBytes">Size in bytes of the thumbnail content..</param>
        public ConversationContentThumbnail(string Url = null, string Mime = null, string Sha256 = null, long? ContentSizeBytes = null)
        {
            this.Url = Url;
            this.Mime = Mime;
            this.Sha256 = Sha256;
            this.ContentSizeBytes = ContentSizeBytes;
            
        }
        


        /// <summary>
        /// URL of the thumbnail image.
        /// </summary>
        /// <value>URL of the thumbnail image.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Thumbnail mime type (e.g. image/jpeg).
        /// </summary>
        /// <value>Thumbnail mime type (e.g. image/jpeg).</value>
        [DataMember(Name="mime", EmitDefaultValue=false)]
        public string Mime { get; set; }



        /// <summary>
        /// Secure hash of the thumbnail content.
        /// </summary>
        /// <value>Secure hash of the thumbnail content.</value>
        [DataMember(Name="sha256", EmitDefaultValue=false)]
        public string Sha256 { get; set; }



        /// <summary>
        /// Size in bytes of the thumbnail content.
        /// </summary>
        /// <value>Size in bytes of the thumbnail content.</value>
        [DataMember(Name="contentSizeBytes", EmitDefaultValue=false)]
        public long? ContentSizeBytes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentThumbnail {\n");

            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Mime: ").Append(Mime).Append("\n");
            sb.Append("  Sha256: ").Append(Sha256).Append("\n");
            sb.Append("  ContentSizeBytes: ").Append(ContentSizeBytes).Append("\n");
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
            return this.Equals(obj as ConversationContentThumbnail);
        }

        /// <summary>
        /// Returns true if ConversationContentThumbnail instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentThumbnail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentThumbnail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Mime == other.Mime ||
                    this.Mime != null &&
                    this.Mime.Equals(other.Mime)
                ) &&
                (
                    this.Sha256 == other.Sha256 ||
                    this.Sha256 != null &&
                    this.Sha256.Equals(other.Sha256)
                ) &&
                (
                    this.ContentSizeBytes == other.ContentSizeBytes ||
                    this.ContentSizeBytes != null &&
                    this.ContentSizeBytes.Equals(other.ContentSizeBytes)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Mime != null)
                    hash = hash * 59 + this.Mime.GetHashCode();

                if (this.Sha256 != null)
                    hash = hash * 59 + this.Sha256.GetHashCode();

                if (this.ContentSizeBytes != null)
                    hash = hash * 59 + this.ContentSizeBytes.GetHashCode();

                return hash;
            }
        }
    }

}
