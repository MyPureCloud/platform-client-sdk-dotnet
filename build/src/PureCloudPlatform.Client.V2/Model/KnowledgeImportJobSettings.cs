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
    /// KnowledgeImportJobSettings
    /// </summary>
    [DataContract]
    public partial class KnowledgeImportJobSettings :  IEquatable<KnowledgeImportJobSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeImportJobSettings" /> class.
        /// </summary>
        /// <param name="ImportAsNew">If enabled import creates a new document even if update is available..</param>
        /// <param name="Visible">If specified, import will override the visibility of the imported documents..</param>
        /// <param name="CategoryId">If specified, import will override the category of the imported documents..</param>
        /// <param name="LabelIds">If specified, import will add this labels to the imported documents..</param>
        public KnowledgeImportJobSettings(bool? ImportAsNew = null, bool? Visible = null, string CategoryId = null, List<string> LabelIds = null)
        {
            this.ImportAsNew = ImportAsNew;
            this.Visible = Visible;
            this.CategoryId = CategoryId;
            this.LabelIds = LabelIds;
            
        }
        


        /// <summary>
        /// If enabled import creates a new document even if update is available.
        /// </summary>
        /// <value>If enabled import creates a new document even if update is available.</value>
        [DataMember(Name="importAsNew", EmitDefaultValue=false)]
        public bool? ImportAsNew { get; set; }



        /// <summary>
        /// If specified, import will override the visibility of the imported documents.
        /// </summary>
        /// <value>If specified, import will override the visibility of the imported documents.</value>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }



        /// <summary>
        /// If specified, import will override the category of the imported documents.
        /// </summary>
        /// <value>If specified, import will override the category of the imported documents.</value>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public string CategoryId { get; set; }



        /// <summary>
        /// If specified, import will add this labels to the imported documents.
        /// </summary>
        /// <value>If specified, import will add this labels to the imported documents.</value>
        [DataMember(Name="labelIds", EmitDefaultValue=false)]
        public List<string> LabelIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeImportJobSettings {\n");

            sb.Append("  ImportAsNew: ").Append(ImportAsNew).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
            return this.Equals(obj as KnowledgeImportJobSettings);
        }

        /// <summary>
        /// Returns true if KnowledgeImportJobSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeImportJobSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeImportJobSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ImportAsNew == other.ImportAsNew ||
                    this.ImportAsNew != null &&
                    this.ImportAsNew.Equals(other.ImportAsNew)
                ) &&
                (
                    this.Visible == other.Visible ||
                    this.Visible != null &&
                    this.Visible.Equals(other.Visible)
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
                if (this.ImportAsNew != null)
                    hash = hash * 59 + this.ImportAsNew.GetHashCode();

                if (this.Visible != null)
                    hash = hash * 59 + this.Visible.GetHashCode();

                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();

                if (this.LabelIds != null)
                    hash = hash * 59 + this.LabelIds.GetHashCode();

                return hash;
            }
        }
    }

}
