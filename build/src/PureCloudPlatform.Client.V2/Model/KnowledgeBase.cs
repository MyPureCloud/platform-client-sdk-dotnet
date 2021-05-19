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
    /// KnowledgeBase
    /// </summary>
    [DataContract]
    public partial class KnowledgeBase :  IEquatable<KnowledgeBase>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Core language for knowledge base in which initial content must be created first
        /// </summary>
        /// <value>Core language for knowledge base in which initial content must be created first</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CoreLanguageEnum
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
        /// Core language for knowledge base in which initial content must be created first
        /// </summary>
        /// <value>Core language for knowledge base in which initial content must be created first</value>
        [DataMember(Name="coreLanguage", EmitDefaultValue=false)]
        public CoreLanguageEnum? CoreLanguage { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeBase() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Knowledge base description.</param>
        /// <param name="CoreLanguage">Core language for knowledge base in which initial content must be created first (required).</param>
        public KnowledgeBase(string Name = null, string Description = null, CoreLanguageEnum? CoreLanguage = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.CoreLanguage = CoreLanguage;
            
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
        /// Knowledge base description
        /// </summary>
        /// <value>Knowledge base description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        
        
        /// <summary>
        /// Knowledge base creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Knowledge base creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Knowledge base last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Knowledge base last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// The count representing the number of documents of type FAQ in the KnowledgeBase
        /// </summary>
        /// <value>The count representing the number of documents of type FAQ in the KnowledgeBase</value>
        [DataMember(Name="faqCount", EmitDefaultValue=false)]
        public int? FaqCount { get; private set; }
        
        
        
        /// <summary>
        /// The date representing when the last document is modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date representing when the last document is modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateDocumentLastModified", EmitDefaultValue=false)]
        public DateTime? DateDocumentLastModified { get; private set; }
        
        
        
        /// <summary>
        /// The count representing the number of documents of type Article in the KnowledgeBase
        /// </summary>
        /// <value>The count representing the number of documents of type Article in the KnowledgeBase</value>
        [DataMember(Name="articleCount", EmitDefaultValue=false)]
        public int? ArticleCount { get; private set; }
        
        
        
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
            sb.Append("class KnowledgeBase {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CoreLanguage: ").Append(CoreLanguage).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  FaqCount: ").Append(FaqCount).Append("\n");
            sb.Append("  DateDocumentLastModified: ").Append(DateDocumentLastModified).Append("\n");
            sb.Append("  ArticleCount: ").Append(ArticleCount).Append("\n");
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
            return this.Equals(obj as KnowledgeBase);
        }

        /// <summary>
        /// Returns true if KnowledgeBase instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeBase other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.CoreLanguage == other.CoreLanguage ||
                    this.CoreLanguage != null &&
                    this.CoreLanguage.Equals(other.CoreLanguage)
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
                    this.FaqCount == other.FaqCount ||
                    this.FaqCount != null &&
                    this.FaqCount.Equals(other.FaqCount)
                ) &&
                (
                    this.DateDocumentLastModified == other.DateDocumentLastModified ||
                    this.DateDocumentLastModified != null &&
                    this.DateDocumentLastModified.Equals(other.DateDocumentLastModified)
                ) &&
                (
                    this.ArticleCount == other.ArticleCount ||
                    this.ArticleCount != null &&
                    this.ArticleCount.Equals(other.ArticleCount)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.CoreLanguage != null)
                    hash = hash * 59 + this.CoreLanguage.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.FaqCount != null)
                    hash = hash * 59 + this.FaqCount.GetHashCode();
                
                if (this.DateDocumentLastModified != null)
                    hash = hash * 59 + this.DateDocumentLastModified.GetHashCode();
                
                if (this.ArticleCount != null)
                    hash = hash * 59 + this.ArticleCount.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
