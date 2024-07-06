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
    /// SuggestionKnowledgeArticle
    /// </summary>
    [DataContract]
    public partial class SuggestionKnowledgeArticle :  IEquatable<SuggestionKnowledgeArticle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionKnowledgeArticle" /> class.
        /// </summary>
        public SuggestionKnowledgeArticle()
        {
            
        }
        


        /// <summary>
        /// The article title.
        /// </summary>
        /// <value>The article title.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; private set; }



        /// <summary>
        /// Snippets of text from the article matching the query.
        /// </summary>
        /// <value>Snippets of text from the article matching the query.</value>
        [DataMember(Name="snippets", EmitDefaultValue=false)]
        public List<string> Snippets { get; private set; }



        /// <summary>
        /// The article.
        /// </summary>
        /// <value>The article.</value>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public AddressableEntityRef Document { get; private set; }



        /// <summary>
        /// The version of the article.
        /// </summary>
        /// <value>The version of the article.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public AddressableEntityRef Version { get; private set; }



        /// <summary>
        /// The most relevant answer within the suggested article.
        /// </summary>
        /// <value>The most relevant answer within the suggested article.</value>
        [DataMember(Name="knowledgeAnswer", EmitDefaultValue=false)]
        public SuggestionKnowledgeAnswer KnowledgeAnswer { get; private set; }



        /// <summary>
        /// The variations of the article.
        /// </summary>
        /// <value>The variations of the article.</value>
        [DataMember(Name="variations", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Variations { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuggestionKnowledgeArticle {\n");

            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Snippets: ").Append(Snippets).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  KnowledgeAnswer: ").Append(KnowledgeAnswer).Append("\n");
            sb.Append("  Variations: ").Append(Variations).Append("\n");
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
            return this.Equals(obj as SuggestionKnowledgeArticle);
        }

        /// <summary>
        /// Returns true if SuggestionKnowledgeArticle instances are equal
        /// </summary>
        /// <param name="other">Instance of SuggestionKnowledgeArticle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuggestionKnowledgeArticle other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Snippets == other.Snippets ||
                    this.Snippets != null &&
                    this.Snippets.SequenceEqual(other.Snippets)
                ) &&
                (
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.KnowledgeAnswer == other.KnowledgeAnswer ||
                    this.KnowledgeAnswer != null &&
                    this.KnowledgeAnswer.Equals(other.KnowledgeAnswer)
                ) &&
                (
                    this.Variations == other.Variations ||
                    this.Variations != null &&
                    this.Variations.SequenceEqual(other.Variations)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Snippets != null)
                    hash = hash * 59 + this.Snippets.GetHashCode();

                if (this.Document != null)
                    hash = hash * 59 + this.Document.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.KnowledgeAnswer != null)
                    hash = hash * 59 + this.KnowledgeAnswer.GetHashCode();

                if (this.Variations != null)
                    hash = hash * 59 + this.Variations.GetHashCode();

                return hash;
            }
        }
    }

}
