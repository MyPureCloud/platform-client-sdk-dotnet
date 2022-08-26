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
    /// KnowledgeDocumentVersionVariation
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentVersionVariation :  IEquatable<KnowledgeDocumentVersionVariation>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentVersionVariation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentVersionVariation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentVersionVariation" /> class.
        /// </summary>
        /// <param name="Body">The content for the variation..</param>
        /// <param name="Contexts">The context values associated with the variation. (required).</param>
        public KnowledgeDocumentVersionVariation(DocumentBody Body = null, List<DocumentVariationContext> Contexts = null)
        {
            this.Body = Body;
            this.Contexts = Contexts;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the variation.
        /// </summary>
        /// <value>The globally unique identifier for the variation.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The content for the variation.
        /// </summary>
        /// <value>The content for the variation.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public DocumentBody Body { get; set; }



        /// <summary>
        /// The creation date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The creation date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The last modification date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The last modification date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The context values associated with the variation.
        /// </summary>
        /// <value>The context values associated with the variation.</value>
        [DataMember(Name="contexts", EmitDefaultValue=false)]
        public List<DocumentVariationContext> Contexts { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }



        /// <summary>
        /// Reference to the document version to which the variation is associated with.
        /// </summary>
        /// <value>Reference to the document version to which the variation is associated with.</value>
        [DataMember(Name="documentVersion", EmitDefaultValue=false)]
        public AddressableEntityRef DocumentVersion { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentVersionVariation {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Contexts: ").Append(Contexts).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  DocumentVersion: ").Append(DocumentVersion).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentVersionVariation);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentVersionVariation instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentVersionVariation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentVersionVariation other)
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
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Contexts == other.Contexts ||
                    this.Contexts != null &&
                    this.Contexts.SequenceEqual(other.Contexts)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.DocumentVersion == other.DocumentVersion ||
                    this.DocumentVersion != null &&
                    this.DocumentVersion.Equals(other.DocumentVersion)
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

                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Contexts != null)
                    hash = hash * 59 + this.Contexts.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.DocumentVersion != null)
                    hash = hash * 59 + this.DocumentVersion.GetHashCode();

                return hash;
            }
        }
    }

}
