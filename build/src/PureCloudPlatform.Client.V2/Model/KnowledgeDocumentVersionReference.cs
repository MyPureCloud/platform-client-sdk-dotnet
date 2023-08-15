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
    /// KnowledgeDocumentVersionReference
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentVersionReference :  IEquatable<KnowledgeDocumentVersionReference>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentVersionReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentVersionReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentVersionReference" /> class.
        /// </summary>
        /// <param name="VersionId">The globally unique identifier for the version of the document. (required).</param>
        public KnowledgeDocumentVersionReference(string VersionId = null)
        {
            this.VersionId = VersionId;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the document.
        /// </summary>
        /// <value>The globally unique identifier for the document.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The knowledge base that the document belongs to.
        /// </summary>
        /// <value>The knowledge base that the document belongs to.</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public KnowledgeBaseReference KnowledgeBase { get; private set; }



        /// <summary>
        /// The globally unique identifier for the version of the document.
        /// </summary>
        /// <value>The globally unique identifier for the version of the document.</value>
        [DataMember(Name="versionId", EmitDefaultValue=false)]
        public string VersionId { get; set; }



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
            sb.Append("class KnowledgeDocumentVersionReference {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentVersionReference);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentVersionReference instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentVersionReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentVersionReference other)
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
                    this.KnowledgeBase == other.KnowledgeBase ||
                    this.KnowledgeBase != null &&
                    this.KnowledgeBase.Equals(other.KnowledgeBase)
                ) &&
                (
                    this.VersionId == other.VersionId ||
                    this.VersionId != null &&
                    this.VersionId.Equals(other.VersionId)
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

                if (this.KnowledgeBase != null)
                    hash = hash * 59 + this.KnowledgeBase.GetHashCode();

                if (this.VersionId != null)
                    hash = hash * 59 + this.VersionId.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
