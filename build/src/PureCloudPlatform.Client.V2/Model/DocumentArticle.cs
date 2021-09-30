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
    /// DocumentArticle
    /// </summary>
    [DataContract]
    public partial class DocumentArticle :  IEquatable<DocumentArticle>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentArticle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentArticle() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentArticle" /> class.
        /// </summary>
        /// <param name="Title">The title of the Article. (required).</param>
        /// <param name="Alternatives">List of Alternative questions related to the title which helps in improving the likelihood of a match to user query..</param>
        public DocumentArticle(string Title = null, List<string> Alternatives = null)
        {
            this.Title = Title;
            this.Alternatives = Alternatives;
            
        }
        
        
        
        /// <summary>
        /// The title of the Article.
        /// </summary>
        /// <value>The title of the Article.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        
        
        
        /// <summary>
        /// The content of the Article.
        /// </summary>
        /// <value>The content of the Article.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public ArticleContent Content { get; private set; }
        
        
        
        /// <summary>
        /// List of Alternative questions related to the title which helps in improving the likelihood of a match to user query.
        /// </summary>
        /// <value>List of Alternative questions related to the title which helps in improving the likelihood of a match to user query.</value>
        [DataMember(Name="alternatives", EmitDefaultValue=false)]
        public List<string> Alternatives { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentArticle {\n");
            
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
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
            return this.Equals(obj as DocumentArticle);
        }

        /// <summary>
        /// Returns true if DocumentArticle instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentArticle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentArticle other)
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
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) &&
                (
                    this.Alternatives == other.Alternatives ||
                    this.Alternatives != null &&
                    this.Alternatives.SequenceEqual(other.Alternatives)
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
                
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                
                if (this.Alternatives != null)
                    hash = hash * 59 + this.Alternatives.GetHashCode();
                
                return hash;
            }
        }
    }

}
