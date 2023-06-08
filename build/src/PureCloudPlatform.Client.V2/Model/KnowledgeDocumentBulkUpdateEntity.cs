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
    /// KnowledgeDocumentBulkUpdateEntity
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentBulkUpdateEntity :  IEquatable<KnowledgeDocumentBulkUpdateEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentBulkUpdateEntity" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="CategoryId">The category associated with the document..</param>
        /// <param name="LabelIds">The ids of labels associated with the document..</param>
        public KnowledgeDocumentBulkUpdateEntity(string Id = null, string CategoryId = null, List<string> LabelIds = null)
        {
            this.Id = Id;
            this.CategoryId = CategoryId;
            this.LabelIds = LabelIds;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The category associated with the document.
        /// </summary>
        /// <value>The category associated with the document.</value>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public string CategoryId { get; set; }



        /// <summary>
        /// The ids of labels associated with the document.
        /// </summary>
        /// <value>The ids of labels associated with the document.</value>
        [DataMember(Name="labelIds", EmitDefaultValue=false)]
        public List<string> LabelIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentBulkUpdateEntity {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentBulkUpdateEntity);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentBulkUpdateEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentBulkUpdateEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentBulkUpdateEntity other)
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
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId)
                ) &&
                (
                    this.LabelIds == other.LabelIds ||
                    this.LabelIds != null &&
                    this.LabelIds.SequenceEqual(other.LabelIds)
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

                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();

                if (this.LabelIds != null)
                    hash = hash * 59 + this.LabelIds.GetHashCode();

                return hash;
            }
        }
    }

}
