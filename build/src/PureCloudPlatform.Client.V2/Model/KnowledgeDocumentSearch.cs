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
    /// KnowledgeDocumentSearch
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentSearch :  IEquatable<KnowledgeDocumentSearch>
    {
        /// <summary>
        /// The type of the query that initiates the search.
        /// </summary>
        /// <value>The type of the query that initiates the search.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum QueryTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Autosearch for "AutoSearch"
            /// </summary>
            [EnumMember(Value = "AutoSearch")]
            Autosearch,
            
            /// <summary>
            /// Enum Manualsearch for "ManualSearch"
            /// </summary>
            [EnumMember(Value = "ManualSearch")]
            Manualsearch,
            
            /// <summary>
            /// Enum Suggestion for "Suggestion"
            /// </summary>
            [EnumMember(Value = "Suggestion")]
            Suggestion
        }
        /// <summary>
        /// The type of the query that initiates the search.
        /// </summary>
        /// <value>The type of the query that initiates the search.</value>
        [DataMember(Name="queryType", EmitDefaultValue=false)]
        public QueryTypeEnum? QueryType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentSearch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentSearch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentSearch" /> class.
        /// </summary>
        /// <param name="Query">Query to search content in the knowledge base. Maximum of 30 records per query can be fetched. (required).</param>
        /// <param name="PageSize">Page size of the returned results..</param>
        /// <param name="PageNumber">Page number of the returned results..</param>
        /// <param name="QueryType">The type of the query that initiates the search..</param>
        /// <param name="Application">The client application details from which search happened..</param>
        /// <param name="ConversationContext">Conversation context information if the search is initiated in the context of a conversation..</param>
        public KnowledgeDocumentSearch(string Query = null, int? PageSize = null, int? PageNumber = null, QueryTypeEnum? QueryType = null, KnowledgeSearchClientApplication Application = null, KnowledgeConversationContextResponse ConversationContext = null)
        {
            this.Query = Query;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.QueryType = QueryType;
            this.Application = Application;
            this.ConversationContext = ConversationContext;
            
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
        /// Documents matching the search query.
        /// </summary>
        /// <value>Documents matching the search query.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<KnowledgeDocumentSearchResult> Results { get; private set; }



        /// <summary>
        /// The client application details from which search happened.
        /// </summary>
        /// <value>The client application details from which search happened.</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public KnowledgeSearchClientApplication Application { get; set; }



        /// <summary>
        /// Conversation context information if the search is initiated in the context of a conversation.
        /// </summary>
        /// <value>Conversation context information if the search is initiated in the context of a conversation.</value>
        [DataMember(Name="conversationContext", EmitDefaultValue=false)]
        public KnowledgeConversationContextResponse ConversationContext { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentSearch {\n");

            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentSearch);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentSearch instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentSearch other)
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
                    this.QueryType == other.QueryType ||
                    this.QueryType != null &&
                    this.QueryType.Equals(other.QueryType)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) &&
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) &&
                (
                    this.ConversationContext == other.ConversationContext ||
                    this.ConversationContext != null &&
                    this.ConversationContext.Equals(other.ConversationContext)
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

                if (this.QueryType != null)
                    hash = hash * 59 + this.QueryType.GetHashCode();

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.ConversationContext != null)
                    hash = hash * 59 + this.ConversationContext.GetHashCode();

                return hash;
            }
        }
    }

}
