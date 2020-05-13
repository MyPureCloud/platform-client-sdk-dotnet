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
    /// KnowledgeSearchRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeSearchRequest :  IEquatable<KnowledgeSearchRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Document type to be used while searching
        /// </summary>
        /// <value>Document type to be used while searching</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DocumentTypeEnum
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
            Faq
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Document type to be used while searching
        /// </summary>
        /// <value>Document type to be used while searching</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeEnum? DocumentType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeSearchRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchRequest" /> class.
        /// </summary>
        /// <param name="Query">Input query to search content in the knowledge base (required).</param>
        /// <param name="PageSize">Page size of the returned results (required).</param>
        /// <param name="PageNumber">Page number of the returned results (required).</param>
        /// <param name="DocumentType">Document type to be used while searching (required).</param>
        /// <param name="LanguageCode">query search for specific languageCode (required).</param>
        /// <param name="SearchOnDraftDocuments">If true the search query will be executed on draft documents, else it will be on active documents.</param>
        public KnowledgeSearchRequest(string Query = null, int? PageSize = null, int? PageNumber = null, DocumentTypeEnum? DocumentType = null, string LanguageCode = null, bool? SearchOnDraftDocuments = null)
        {
            this.Query = Query;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.DocumentType = DocumentType;
            this.LanguageCode = LanguageCode;
            this.SearchOnDraftDocuments = SearchOnDraftDocuments;
            
        }
        
        
        
        /// <summary>
        /// Input query to search content in the knowledge base
        /// </summary>
        /// <value>Input query to search content in the knowledge base</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }
        
        
        
        /// <summary>
        /// Page size of the returned results
        /// </summary>
        /// <value>Page size of the returned results</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        
        
        
        /// <summary>
        /// Page number of the returned results
        /// </summary>
        /// <value>Page number of the returned results</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
        
        
        
        
        
        /// <summary>
        /// query search for specific languageCode
        /// </summary>
        /// <value>query search for specific languageCode</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }
        
        
        
        /// <summary>
        /// If true the search query will be executed on draft documents, else it will be on active documents
        /// </summary>
        /// <value>If true the search query will be executed on draft documents, else it will be on active documents</value>
        [DataMember(Name="searchOnDraftDocuments", EmitDefaultValue=false)]
        public bool? SearchOnDraftDocuments { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSearchRequest {\n");
            
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  SearchOnDraftDocuments: ").Append(SearchOnDraftDocuments).Append("\n");
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
            return this.Equals(obj as KnowledgeSearchRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) &&
                (
                    this.DocumentType == other.DocumentType ||
                    this.DocumentType != null &&
                    this.DocumentType.Equals(other.DocumentType)
                ) &&
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) &&
                (
                    this.SearchOnDraftDocuments == other.SearchOnDraftDocuments ||
                    this.SearchOnDraftDocuments != null &&
                    this.SearchOnDraftDocuments.Equals(other.SearchOnDraftDocuments)
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
                
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                
                if (this.DocumentType != null)
                    hash = hash * 59 + this.DocumentType.GetHashCode();
                
                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();
                
                if (this.SearchOnDraftDocuments != null)
                    hash = hash * 59 + this.SearchOnDraftDocuments.GetHashCode();
                
                return hash;
            }
        }
    }

}
