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
    /// QueueConversationEventTopicAttachment
    /// </summary>
    [DataContract]
    public partial class QueueConversationEventTopicAttachment :  IEquatable<QueueConversationEventTopicAttachment>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationEventTopicAttachment" /> class.
        /// </summary>
        /// <param name="AttachmentId">AttachmentId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ContentUri">ContentUri.</param>
        /// <param name="ContentType">ContentType.</param>
        /// <param name="ContentLength">ContentLength.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public QueueConversationEventTopicAttachment(string AttachmentId = null, string Name = null, string ContentUri = null, string ContentType = null, int? ContentLength = null, Object AdditionalProperties = null)
        {
            this.AttachmentId = AttachmentId;
            this.Name = Name;
            this.ContentUri = ContentUri;
            this.ContentType = ContentType;
            this.ContentLength = ContentLength;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets AttachmentId
        /// </summary>
        [DataMember(Name="attachmentId", EmitDefaultValue=false)]
        public string AttachmentId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContentUri
        /// </summary>
        [DataMember(Name="contentUri", EmitDefaultValue=false)]
        public string ContentUri { get; set; }
        
        
        
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
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationEventTopicAttachment {\n");
            
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as QueueConversationEventTopicAttachment);
        }

        /// <summary>
        /// Returns true if QueueConversationEventTopicAttachment instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationEventTopicAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationEventTopicAttachment other)
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
                    this.ContentUri == other.ContentUri ||
                    this.ContentUri != null &&
                    this.ContentUri.Equals(other.ContentUri)
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
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                
                if (this.ContentUri != null)
                    hash = hash * 59 + this.ContentUri.GetHashCode();
                
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                
                if (this.ContentLength != null)
                    hash = hash * 59 + this.ContentLength.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
