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
    /// KnowledgeDocumentBulkVersionAddEntity
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentBulkVersionAddEntity :  IEquatable<KnowledgeDocumentBulkVersionAddEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentBulkVersionAddEntity" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="RestoreFromVersionId">The globally unique identifier for the document version. If the value is provided, the document is restored to the given version..</param>
        /// <param name="RestorePrevious">Indicates if the document's previous version will be restored.</param>
        public KnowledgeDocumentBulkVersionAddEntity(string Id = null, string RestoreFromVersionId = null, bool? RestorePrevious = null)
        {
            this.Id = Id;
            this.RestoreFromVersionId = RestoreFromVersionId;
            this.RestorePrevious = RestorePrevious;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The globally unique identifier for the document version. If the value is provided, the document is restored to the given version.
        /// </summary>
        /// <value>The globally unique identifier for the document version. If the value is provided, the document is restored to the given version.</value>
        [DataMember(Name="restoreFromVersionId", EmitDefaultValue=false)]
        public string RestoreFromVersionId { get; set; }



        /// <summary>
        /// Indicates if the document's previous version will be restored
        /// </summary>
        /// <value>Indicates if the document's previous version will be restored</value>
        [DataMember(Name="restorePrevious", EmitDefaultValue=false)]
        public bool? RestorePrevious { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentBulkVersionAddEntity {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RestoreFromVersionId: ").Append(RestoreFromVersionId).Append("\n");
            sb.Append("  RestorePrevious: ").Append(RestorePrevious).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentBulkVersionAddEntity);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentBulkVersionAddEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentBulkVersionAddEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentBulkVersionAddEntity other)
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
                    this.RestoreFromVersionId == other.RestoreFromVersionId ||
                    this.RestoreFromVersionId != null &&
                    this.RestoreFromVersionId.Equals(other.RestoreFromVersionId)
                ) &&
                (
                    this.RestorePrevious == other.RestorePrevious ||
                    this.RestorePrevious != null &&
                    this.RestorePrevious.Equals(other.RestorePrevious)
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

                if (this.RestoreFromVersionId != null)
                    hash = hash * 59 + this.RestoreFromVersionId.GetHashCode();

                if (this.RestorePrevious != null)
                    hash = hash * 59 + this.RestorePrevious.GetHashCode();

                return hash;
            }
        }
    }

}
