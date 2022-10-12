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
    /// KnowledgeDocumentSearchRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentSearchRequest :  IEquatable<KnowledgeDocumentSearchRequest>
    {
        /// <summary>
        /// The sort order for search results.
        /// </summary>
        /// <value>The sort order for search results.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SortOrderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Asc for "ASC"
            /// </summary>
            [EnumMember(Value = "ASC")]
            Asc,
            
            /// <summary>
            /// Enum Desc for "DESC"
            /// </summary>
            [EnumMember(Value = "DESC")]
            Desc,
            
            /// <summary>
            /// Enum Score for "SCORE"
            /// </summary>
            [EnumMember(Value = "SCORE")]
            Score
        }
        /// <summary>
        /// The field in the documents that you want to sort the search results by.
        /// </summary>
        /// <value>The field in the documents that you want to sort the search results by.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SortByEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Confidencescore for "ConfidenceScore"
            /// </summary>
            [EnumMember(Value = "ConfidenceScore")]
            Confidencescore,
            
            /// <summary>
            /// Enum Datecreated for "DateCreated"
            /// </summary>
            [EnumMember(Value = "DateCreated")]
            Datecreated,
            
            /// <summary>
            /// Enum Datemodified for "DateModified"
            /// </summary>
            [EnumMember(Value = "DateModified")]
            Datemodified,
            
            /// <summary>
            /// Enum Categoryid for "CategoryId"
            /// </summary>
            [EnumMember(Value = "CategoryId")]
            Categoryid,
            
            /// <summary>
            /// Enum Categoryname for "CategoryName"
            /// </summary>
            [EnumMember(Value = "CategoryName")]
            Categoryname,
            
            /// <summary>
            /// Enum Contextid for "ContextId"
            /// </summary>
            [EnumMember(Value = "ContextId")]
            Contextid,
            
            /// <summary>
            /// Enum Contextname for "ContextName"
            /// </summary>
            [EnumMember(Value = "ContextName")]
            Contextname,
            
            /// <summary>
            /// Enum Contextvalueid for "ContextValueId"
            /// </summary>
            [EnumMember(Value = "ContextValueId")]
            Contextvalueid,
            
            /// <summary>
            /// Enum Contextvaluename for "ContextValueName"
            /// </summary>
            [EnumMember(Value = "ContextValueName")]
            Contextvaluename,
            
            /// <summary>
            /// Enum Labelid for "LabelId"
            /// </summary>
            [EnumMember(Value = "LabelId")]
            Labelid,
            
            /// <summary>
            /// Enum Labelname for "LabelName"
            /// </summary>
            [EnumMember(Value = "LabelName")]
            Labelname
        }
        /// <summary>
        /// The sort order for search results.
        /// </summary>
        /// <value>The sort order for search results.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        /// The field in the documents that you want to sort the search results by.
        /// </summary>
        /// <value>The field in the documents that you want to sort the search results by.</value>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public SortByEnum? SortBy { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentSearchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentSearchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentSearchRequest" /> class.
        /// </summary>
        /// <param name="Query">Query to search content in the knowledge base. Maximum of 30 records per query can be fetched. (required).</param>
        /// <param name="PageSize">Page size of the returned results..</param>
        /// <param name="PageNumber">Page number of the returned results..</param>
        /// <param name="IncludeDraftDocuments">Indicates whether the search results would also include draft documents..</param>
        /// <param name="Interval">Retrieves the documents created/modified/published in specified date and time range..</param>
        /// <param name="Filter">Filter for the document search..</param>
        /// <param name="SortOrder">The sort order for search results..</param>
        /// <param name="SortBy">The field in the documents that you want to sort the search results by..</param>
        public KnowledgeDocumentSearchRequest(string Query = null, int? PageSize = null, int? PageNumber = null, bool? IncludeDraftDocuments = null, DocumentQueryInterval Interval = null, DocumentQuery Filter = null, SortOrderEnum? SortOrder = null, SortByEnum? SortBy = null)
        {
            this.Query = Query;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.IncludeDraftDocuments = IncludeDraftDocuments;
            this.Interval = Interval;
            this.Filter = Filter;
            this.SortOrder = SortOrder;
            this.SortBy = SortBy;
            
        }
        


        /// <summary>
        /// Query to search content in the knowledge base. Maximum of 30 records per query can be fetched.
        /// </summary>
        /// <value>Query to search content in the knowledge base. Maximum of 30 records per query can be fetched.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }



        /// <summary>
        /// Page size of the returned results.
        /// </summary>
        /// <value>Page size of the returned results.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Page number of the returned results.
        /// </summary>
        /// <value>Page number of the returned results.</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }



        /// <summary>
        /// The globally unique identifier for the search.
        /// </summary>
        /// <value>The globally unique identifier for the search.</value>
        [DataMember(Name="searchId", EmitDefaultValue=false)]
        public string SearchId { get; private set; }



        /// <summary>
        /// The total number of documents matching the query.
        /// </summary>
        /// <value>The total number of documents matching the query.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; private set; }



        /// <summary>
        /// Number of pages returned in the result calculated according to the pageSize and the total
        /// </summary>
        /// <value>Number of pages returned in the result calculated according to the pageSize and the total</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; private set; }



        /// <summary>
        /// Indicates whether the search results would also include draft documents.
        /// </summary>
        /// <value>Indicates whether the search results would also include draft documents.</value>
        [DataMember(Name="includeDraftDocuments", EmitDefaultValue=false)]
        public bool? IncludeDraftDocuments { get; set; }



        /// <summary>
        /// Retrieves the documents created/modified/published in specified date and time range.
        /// </summary>
        /// <value>Retrieves the documents created/modified/published in specified date and time range.</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public DocumentQueryInterval Interval { get; set; }



        /// <summary>
        /// Filter for the document search.
        /// </summary>
        /// <value>Filter for the document search.</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public DocumentQuery Filter { get; set; }






        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentSearchRequest {\n");

            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  IncludeDraftDocuments: ").Append(IncludeDraftDocuments).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentSearchRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentSearchRequest other)
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
                    this.SearchId == other.SearchId ||
                    this.SearchId != null &&
                    this.SearchId.Equals(other.SearchId)
                ) &&
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) &&
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) &&
                (
                    this.IncludeDraftDocuments == other.IncludeDraftDocuments ||
                    this.IncludeDraftDocuments != null &&
                    this.IncludeDraftDocuments.Equals(other.IncludeDraftDocuments)
                ) &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) &&
                (
                    this.SortBy == other.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.Equals(other.SortBy)
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

                if (this.SearchId != null)
                    hash = hash * 59 + this.SearchId.GetHashCode();

                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();

                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();

                if (this.IncludeDraftDocuments != null)
                    hash = hash * 59 + this.IncludeDraftDocuments.GetHashCode();

                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();

                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();

                if (this.SortBy != null)
                    hash = hash * 59 + this.SortBy.GetHashCode();

                return hash;
            }
        }
    }

}
