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
    /// KnowledgeDocumentRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentRequest :  IEquatable<KnowledgeDocumentRequest>
    {
        /// <summary>
        /// Document type according to assigned template
        /// </summary>
        /// <value>Document type according to assigned template</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Faq for "Faq"
            /// </summary>
            [EnumMember(Value = "Faq")]
            Faq,
            
            /// <summary>
            /// Enum Article for "Article"
            /// </summary>
            [EnumMember(Value = "Article")]
            Article
        }
        /// <summary>
        /// Document type according to assigned template
        /// </summary>
        /// <value>Document type according to assigned template</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentRequest" /> class.
        /// </summary>
        /// <param name="Type">Document type according to assigned template (required).</param>
        /// <param name="ExternalUrl">External Url to the document.</param>
        /// <param name="Faq">Faq document details.</param>
        /// <param name="Categories">Document categories.</param>
        /// <param name="Article">Article details.</param>
        public KnowledgeDocumentRequest(TypeEnum? Type = null, string ExternalUrl = null, DocumentFaq Faq = null, List<DocumentCategoryInput> Categories = null, DocumentArticle Article = null)
        {
            this.Type = Type;
            this.ExternalUrl = ExternalUrl;
            this.Faq = Faq;
            this.Categories = Categories;
            this.Article = Article;
            
        }
        




        /// <summary>
        /// External Url to the document
        /// </summary>
        /// <value>External Url to the document</value>
        [DataMember(Name="externalUrl", EmitDefaultValue=false)]
        public string ExternalUrl { get; set; }



        /// <summary>
        /// Faq document details
        /// </summary>
        /// <value>Faq document details</value>
        [DataMember(Name="faq", EmitDefaultValue=false)]
        public DocumentFaq Faq { get; set; }



        /// <summary>
        /// Document categories
        /// </summary>
        /// <value>Document categories</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<DocumentCategoryInput> Categories { get; set; }



        /// <summary>
        /// Article details
        /// </summary>
        /// <value>Article details</value>
        [DataMember(Name="article", EmitDefaultValue=false)]
        public DocumentArticle Article { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentRequest {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
            sb.Append("  Faq: ").Append(Faq).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ExternalUrl == other.ExternalUrl ||
                    this.ExternalUrl != null &&
                    this.ExternalUrl.Equals(other.ExternalUrl)
                ) &&
                (
                    this.Faq == other.Faq ||
                    this.Faq != null &&
                    this.Faq.Equals(other.Faq)
                ) &&
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) &&
                (
                    this.Article == other.Article ||
                    this.Article != null &&
                    this.Article.Equals(other.Article)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.ExternalUrl != null)
                    hash = hash * 59 + this.ExternalUrl.GetHashCode();

                if (this.Faq != null)
                    hash = hash * 59 + this.Faq.GetHashCode();

                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();

                if (this.Article != null)
                    hash = hash * 59 + this.Article.GetHashCode();

                return hash;
            }
        }
    }

}
