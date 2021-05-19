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
    /// KnowledgeSearchDocument
    /// </summary>
    [DataContract]
    public partial class KnowledgeSearchDocument :  IEquatable<KnowledgeSearchDocument>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Language of the document
        /// </summary>
        /// <value>Language of the document</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LanguageCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Enus for "en-US"
            /// </summary>
            [EnumMember(Value = "en-US")]
            Enus,
            
            /// <summary>
            /// Enum Dede for "de-DE"
            /// </summary>
            [EnumMember(Value = "de-DE")]
            Dede
        }
        
        
        
        
        /// <summary>
        /// Document type
        /// </summary>
        /// <value>Document type</value>
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
        /// Language of the document
        /// </summary>
        /// <value>Language of the document</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public LanguageCodeEnum? LanguageCode { get; set; }
        
        
        
        /// <summary>
        /// Document type
        /// </summary>
        /// <value>Document type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchDocument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeSearchDocument() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchDocument" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="LanguageCode">Language of the document (required).</param>
        /// <param name="Type">Document type (required).</param>
        /// <param name="Faq">FAQ document details.</param>
        /// <param name="Categories">Document categories.</param>
        /// <param name="KnowledgeBase">Knowledge base which document does belong to.</param>
        /// <param name="ExternalUrl">External URL to the document.</param>
        /// <param name="Article">Article.</param>
        public KnowledgeSearchDocument(string Name = null, LanguageCodeEnum? LanguageCode = null, TypeEnum? Type = null, DocumentFaq Faq = null, List<KnowledgeCategory> Categories = null, KnowledgeBase KnowledgeBase = null, string ExternalUrl = null, DocumentArticle Article = null)
        {
            this.Name = Name;
            this.LanguageCode = LanguageCode;
            this.Type = Type;
            this.Faq = Faq;
            this.Categories = Categories;
            this.KnowledgeBase = KnowledgeBase;
            this.ExternalUrl = ExternalUrl;
            this.Article = Article;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// FAQ document details
        /// </summary>
        /// <value>FAQ document details</value>
        [DataMember(Name="faq", EmitDefaultValue=false)]
        public DocumentFaq Faq { get; set; }
        
        
        
        /// <summary>
        /// Document creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Document creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Document last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Document last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// Document categories
        /// </summary>
        /// <value>Document categories</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<KnowledgeCategory> Categories { get; set; }
        
        
        
        /// <summary>
        /// Knowledge base which document does belong to
        /// </summary>
        /// <value>Knowledge base which document does belong to</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public KnowledgeBase KnowledgeBase { get; set; }
        
        
        
        /// <summary>
        /// External URL to the document
        /// </summary>
        /// <value>External URL to the document</value>
        [DataMember(Name="externalUrl", EmitDefaultValue=false)]
        public string ExternalUrl { get; set; }
        
        
        
        /// <summary>
        /// Article
        /// </summary>
        /// <value>Article</value>
        [DataMember(Name="article", EmitDefaultValue=false)]
        public DocumentArticle Article { get; set; }
        
        
        
        /// <summary>
        /// The confidence associated with a document with respect to a search query
        /// </summary>
        /// <value>The confidence associated with a document with respect to a search query</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double? Confidence { get; private set; }
        
        
        
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
            sb.Append("class KnowledgeSearchDocument {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Faq: ").Append(Faq).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
            sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as KnowledgeSearchDocument);
        }

        /// <summary>
        /// Returns true if KnowledgeSearchDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSearchDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSearchDocument other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Faq == other.Faq ||
                    this.Faq != null &&
                    this.Faq.Equals(other.Faq)
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
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) &&
                (
                    this.KnowledgeBase == other.KnowledgeBase ||
                    this.KnowledgeBase != null &&
                    this.KnowledgeBase.Equals(other.KnowledgeBase)
                ) &&
                (
                    this.ExternalUrl == other.ExternalUrl ||
                    this.ExternalUrl != null &&
                    this.ExternalUrl.Equals(other.ExternalUrl)
                ) &&
                (
                    this.Article == other.Article ||
                    this.Article != null &&
                    this.Article.Equals(other.Article)
                ) &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Faq != null)
                    hash = hash * 59 + this.Faq.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
                
                if (this.KnowledgeBase != null)
                    hash = hash * 59 + this.KnowledgeBase.GetHashCode();
                
                if (this.ExternalUrl != null)
                    hash = hash * 59 + this.ExternalUrl.GetHashCode();
                
                if (this.Article != null)
                    hash = hash * 59 + this.Article.GetHashCode();
                
                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
