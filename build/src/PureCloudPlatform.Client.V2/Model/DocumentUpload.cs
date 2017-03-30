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
    /// DocumentUpload
    /// </summary>
    [DataContract]
    public partial class DocumentUpload :  IEquatable<DocumentUpload>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentUpload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpload" /> class.
        /// </summary>
        /// <param name="Name">The name of the document (required).</param>
        /// <param name="Workspace">The workspace the document will be uploaded to (required).</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="TagIds">TagIds.</param>
        public DocumentUpload(string Name = null, UriReference Workspace = null, List<string> Tags = null, List<string> TagIds = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DocumentUpload and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Workspace" is required (not null)
            if (Workspace == null)
            {
                throw new InvalidDataException("Workspace is a required property for DocumentUpload and cannot be null");
            }
            else
            {
                this.Workspace = Workspace;
            }
            this.Tags = Tags;
            this.TagIds = TagIds;
        }
        
        /// <summary>
        /// The name of the document
        /// </summary>
        /// <value>The name of the document</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The workspace the document will be uploaded to
        /// </summary>
        /// <value>The workspace the document will be uploaded to</value>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public UriReference Workspace { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
        /// <summary>
        /// Gets or Sets TagIds
        /// </summary>
        [DataMember(Name="tagIds", EmitDefaultValue=false)]
        public List<string> TagIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentUpload {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
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
            return this.Equals(obj as DocumentUpload);
        }

        /// <summary>
        /// Returns true if DocumentUpload instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentUpload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentUpload other)
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
                    this.Workspace == other.Workspace ||
                    this.Workspace != null &&
                    this.Workspace.Equals(other.Workspace)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.TagIds == other.TagIds ||
                    this.TagIds != null &&
                    this.TagIds.SequenceEqual(other.TagIds)
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
                if (this.Workspace != null)
                    hash = hash * 59 + this.Workspace.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.TagIds != null)
                    hash = hash * 59 + this.TagIds.GetHashCode();
                return hash;
            }
        }
    }

}
