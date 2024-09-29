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
    /// ServiceNowSettings
    /// </summary>
    [DataContract]
    public partial class ServiceNowSettings :  IEquatable<ServiceNowSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceNowSettings" /> class.
        /// </summary>
        /// <param name="KnowledgeBaseIds">Filter source by knowledge base ids..</param>
        /// <param name="Language">Filter source by language..</param>
        /// <param name="Categories">Filter source by categories..</param>
        public ServiceNowSettings(List<string> KnowledgeBaseIds = null, string Language = null, List<string> Categories = null)
        {
            this.KnowledgeBaseIds = KnowledgeBaseIds;
            this.Language = Language;
            this.Categories = Categories;
            
        }
        


        /// <summary>
        /// Filter source by knowledge base ids.
        /// </summary>
        /// <value>Filter source by knowledge base ids.</value>
        [DataMember(Name="knowledgeBaseIds", EmitDefaultValue=false)]
        public List<string> KnowledgeBaseIds { get; set; }



        /// <summary>
        /// Filter source by language.
        /// </summary>
        /// <value>Filter source by language.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Filter source by categories.
        /// </summary>
        /// <value>Filter source by categories.</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<string> Categories { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceNowSettings {\n");

            sb.Append("  KnowledgeBaseIds: ").Append(KnowledgeBaseIds).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            return this.Equals(obj as ServiceNowSettings);
        }

        /// <summary>
        /// Returns true if ServiceNowSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceNowSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceNowSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.KnowledgeBaseIds == other.KnowledgeBaseIds ||
                    this.KnowledgeBaseIds != null &&
                    this.KnowledgeBaseIds.SequenceEqual(other.KnowledgeBaseIds)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
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
                if (this.KnowledgeBaseIds != null)
                    hash = hash * 59 + this.KnowledgeBaseIds.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();

                return hash;
            }
        }
    }

}
