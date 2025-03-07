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
    /// KnowledgeDocumentVersion
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentVersion :  IEquatable<KnowledgeDocumentVersion>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentVersion" /> class.
        /// </summary>
        /// <param name="RestoreFromVersionId">The globally unique identifier for the document version. If the value is provided, the document is restored to the given version. If not, it publishes the draft changes as a new version of the document. (required).</param>
        public KnowledgeDocumentVersion(string RestoreFromVersionId = null)
        {
            this.RestoreFromVersionId = RestoreFromVersionId;
            
        }
        


        /// <summary>
        /// Globally unique identifier for the document version.
        /// </summary>
        /// <value>Globally unique identifier for the document version.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Published date of document version. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Published date of document version. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="datePublished", EmitDefaultValue=false)]
        public DateTime? DatePublished { get; private set; }



        /// <summary>
        /// The document which is versioned.
        /// </summary>
        /// <value>The document which is versioned.</value>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public KnowledgeDocumentResponse Document { get; private set; }



        /// <summary>
        /// The globally unique identifier for the document version. If the value is provided, the document is restored to the given version. If not, it publishes the draft changes as a new version of the document.
        /// </summary>
        /// <value>The globally unique identifier for the document version. If the value is provided, the document is restored to the given version. If not, it publishes the draft changes as a new version of the document.</value>
        [DataMember(Name="restoreFromVersionId", EmitDefaultValue=false)]
        public string RestoreFromVersionId { get; set; }



        /// <summary>
        /// Version Number of the document.
        /// </summary>
        /// <value>Version Number of the document.</value>
        [DataMember(Name="versionNumber", EmitDefaultValue=false)]
        public int? VersionNumber { get; private set; }



        /// <summary>
        /// Expiry date of document version, applicable only to the &#39;Archived&#39; version of the document. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Expiry date of document version, applicable only to the &#39;Archived&#39; version of the document. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateExpires", EmitDefaultValue=false)]
        public DateTime? DateExpires { get; private set; }



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
            sb.Append("class KnowledgeDocumentVersion {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  RestoreFromVersionId: ").Append(RestoreFromVersionId).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentVersion);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentVersion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.DatePublished == other.DatePublished ||
                    this.DatePublished != null &&
                    this.DatePublished.Equals(other.DatePublished)
                ) &&
                (
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
                ) &&
                (
                    this.RestoreFromVersionId == other.RestoreFromVersionId ||
                    this.RestoreFromVersionId != null &&
                    this.RestoreFromVersionId.Equals(other.RestoreFromVersionId)
                ) &&
                (
                    this.VersionNumber == other.VersionNumber ||
                    this.VersionNumber != null &&
                    this.VersionNumber.Equals(other.VersionNumber)
                ) &&
                (
                    this.DateExpires == other.DateExpires ||
                    this.DateExpires != null &&
                    this.DateExpires.Equals(other.DateExpires)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.DatePublished != null)
                    hash = hash * 59 + this.DatePublished.GetHashCode();

                if (this.Document != null)
                    hash = hash * 59 + this.Document.GetHashCode();

                if (this.RestoreFromVersionId != null)
                    hash = hash * 59 + this.RestoreFromVersionId.GetHashCode();

                if (this.VersionNumber != null)
                    hash = hash * 59 + this.VersionNumber.GetHashCode();

                if (this.DateExpires != null)
                    hash = hash * 59 + this.DateExpires.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
