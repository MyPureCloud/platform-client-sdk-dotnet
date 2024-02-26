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
    /// KnowledgeDocumentVersionVariationReference
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentVersionVariationReference :  IEquatable<KnowledgeDocumentVersionVariationReference>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentVersionVariationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentVersionVariationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentVersionVariationReference" /> class.
        /// </summary>
        /// <param name="DocumentId">The ID of the document. (required).</param>
        /// <param name="DocumentVariationId">The variation of the document. (required).</param>
        /// <param name="DocumentVersionId">The version of the document. (required).</param>
        public KnowledgeDocumentVersionVariationReference(string DocumentId = null, string DocumentVariationId = null, string DocumentVersionId = null)
        {
            this.DocumentId = DocumentId;
            this.DocumentVariationId = DocumentVariationId;
            this.DocumentVersionId = DocumentVersionId;
            
        }
        


        /// <summary>
        /// The ID of the document.
        /// </summary>
        /// <value>The ID of the document.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }



        /// <summary>
        /// The variation of the document.
        /// </summary>
        /// <value>The variation of the document.</value>
        [DataMember(Name="documentVariationId", EmitDefaultValue=false)]
        public string DocumentVariationId { get; set; }



        /// <summary>
        /// The version of the document.
        /// </summary>
        /// <value>The version of the document.</value>
        [DataMember(Name="documentVersionId", EmitDefaultValue=false)]
        public string DocumentVersionId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentVersionVariationReference {\n");

            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentVariationId: ").Append(DocumentVariationId).Append("\n");
            sb.Append("  DocumentVersionId: ").Append(DocumentVersionId).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentVersionVariationReference);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentVersionVariationReference instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentVersionVariationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentVersionVariationReference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) &&
                (
                    this.DocumentVariationId == other.DocumentVariationId ||
                    this.DocumentVariationId != null &&
                    this.DocumentVariationId.Equals(other.DocumentVariationId)
                ) &&
                (
                    this.DocumentVersionId == other.DocumentVersionId ||
                    this.DocumentVersionId != null &&
                    this.DocumentVersionId.Equals(other.DocumentVersionId)
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
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();

                if (this.DocumentVariationId != null)
                    hash = hash * 59 + this.DocumentVariationId.GetHashCode();

                if (this.DocumentVersionId != null)
                    hash = hash * 59 + this.DocumentVersionId.GetHashCode();

                return hash;
            }
        }
    }

}
