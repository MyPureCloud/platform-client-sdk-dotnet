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
    /// EmailAttachment
    /// </summary>
    [DataContract]
    public partial class EmailAttachment :  IEquatable<EmailAttachment>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAttachment" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ContentPath">ContentPath.</param>
        /// <param name="ContentType">ContentType.</param>
        /// <param name="AttachmentId">AttachmentId.</param>
        /// <param name="ContentLength">ContentLength.</param>
        public EmailAttachment(string Name = null, string ContentPath = null, string ContentType = null, string AttachmentId = null, int? ContentLength = null)
        {
            this.Name = Name;
            this.ContentPath = ContentPath;
            this.ContentType = ContentType;
            this.AttachmentId = AttachmentId;
            this.ContentLength = ContentLength;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContentPath
        /// </summary>
        [DataMember(Name="contentPath", EmitDefaultValue=false)]
        public string ContentPath { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AttachmentId
        /// </summary>
        [DataMember(Name="attachmentId", EmitDefaultValue=false)]
        public string AttachmentId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContentLength
        /// </summary>
        [DataMember(Name="contentLength", EmitDefaultValue=false)]
        public int? ContentLength { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailAttachment {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContentPath: ").Append(ContentPath).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
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
            return this.Equals(obj as EmailAttachment);
        }

        /// <summary>
        /// Returns true if EmailAttachment instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailAttachment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ContentPath == other.ContentPath ||
                    this.ContentPath != null &&
                    this.ContentPath.Equals(other.ContentPath)
                ) &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.AttachmentId == other.AttachmentId ||
                    this.AttachmentId != null &&
                    this.AttachmentId.Equals(other.AttachmentId)
                ) &&
                (
                    this.ContentLength == other.ContentLength ||
                    this.ContentLength != null &&
                    this.ContentLength.Equals(other.ContentLength)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ContentPath != null)
                    hash = hash * 59 + this.ContentPath.GetHashCode();
                
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                
                if (this.AttachmentId != null)
                    hash = hash * 59 + this.AttachmentId.GetHashCode();
                
                if (this.ContentLength != null)
                    hash = hash * 59 + this.ContentLength.GetHashCode();
                
                return hash;
            }
        }
    }

}
