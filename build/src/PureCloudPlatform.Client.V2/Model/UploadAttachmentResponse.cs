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
    /// UploadAttachmentResponse
    /// </summary>
    [DataContract]
    public partial class UploadAttachmentResponse :  IEquatable<UploadAttachmentResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAttachmentResponse" /> class.
        /// </summary>
        /// <param name="AttachmentId">The attachment ID.</param>
        /// <param name="Name">The name of the attachment file.</param>
        /// <param name="Url">Pre-signed URL to upload the file.</param>
        /// <param name="Headers">Required headers when uploading a file through PUT request to the URL.</param>
        /// <param name="ConversationId">The conversation ID.</param>
        public UploadAttachmentResponse(string AttachmentId = null, string Name = null, string Url = null, Dictionary<string, string> Headers = null, string ConversationId = null)
        {
            this.AttachmentId = AttachmentId;
            this.Name = Name;
            this.Url = Url;
            this.Headers = Headers;
            this.ConversationId = ConversationId;
            
        }
        


        /// <summary>
        /// The attachment ID
        /// </summary>
        /// <value>The attachment ID</value>
        [DataMember(Name="attachmentId", EmitDefaultValue=false)]
        public string AttachmentId { get; set; }



        /// <summary>
        /// The name of the attachment file
        /// </summary>
        /// <value>The name of the attachment file</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Pre-signed URL to upload the file
        /// </summary>
        /// <value>Pre-signed URL to upload the file</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Required headers when uploading a file through PUT request to the URL
        /// </summary>
        /// <value>Required headers when uploading a file through PUT request to the URL</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, string> Headers { get; set; }



        /// <summary>
        /// The conversation ID
        /// </summary>
        /// <value>The conversation ID</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadAttachmentResponse {\n");

            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
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
            return this.Equals(obj as UploadAttachmentResponse);
        }

        /// <summary>
        /// Returns true if UploadAttachmentResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UploadAttachmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadAttachmentResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AttachmentId == other.AttachmentId ||
                    this.AttachmentId != null &&
                    this.AttachmentId.Equals(other.AttachmentId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
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
                if (this.AttachmentId != null)
                    hash = hash * 59 + this.AttachmentId.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                return hash;
            }
        }
    }

}
