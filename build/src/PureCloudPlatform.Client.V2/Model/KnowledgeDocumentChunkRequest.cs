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
    /// KnowledgeDocumentChunkRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentChunkRequest :  IEquatable<KnowledgeDocumentChunkRequest>
    {
        /// <summary>
        /// The type of the query that initiates the chunks search.
        /// </summary>
        /// <value>The type of the query that initiates the chunks search.</value>
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
        /// The type of the query that initiates the chunks search.
        /// </summary>
        /// <value>The type of the query that initiates the chunks search.</value>
        [DataMember(Name="queryType", EmitDefaultValue=false)]
        public QueryTypeEnum? QueryType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentChunkRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentChunkRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentChunkRequest" /> class.
        /// </summary>
        /// <param name="Query">Query to search chunks in the knowledge base. (required).</param>
        /// <param name="PageSize">Page size of the returned results..</param>
        /// <param name="PageNumber">Page number of the returned results..</param>
        /// <param name="Filter">Filter for the document chunks..</param>
        /// <param name="QueryType">The type of the query that initiates the chunks search..</param>
        /// <param name="PreprocessQuery">Indicates whether the chunks search query should be preprocessed..</param>
        /// <param name="IncludeDraftDocuments">Indicates whether the chunk results would also include draft documents..</param>
        /// <param name="Application">The client application details from which chunks request was sent..</param>
        /// <param name="ConversationContext">Conversation context information if the chunks search is initiated in the context of a conversation..</param>
        /// <param name="ConfidenceThreshold">The confidence threshold for the chunk results. If applied, the returned results will have an equal or higher confidence than the threshold. The value should be between 0 to 1..</param>
        public KnowledgeDocumentChunkRequest(string Query = null, int? PageSize = null, int? PageNumber = null, DocumentQuery Filter = null, QueryTypeEnum? QueryType = null, bool? PreprocessQuery = null, bool? IncludeDraftDocuments = null, KnowledgeSearchClientApplication Application = null, KnowledgeConversationContext ConversationContext = null, float? ConfidenceThreshold = null)
        {
            this.Query = Query;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.Filter = Filter;
            this.QueryType = QueryType;
            this.PreprocessQuery = PreprocessQuery;
            this.IncludeDraftDocuments = IncludeDraftDocuments;
            this.Application = Application;
            this.ConversationContext = ConversationContext;
            this.ConfidenceThreshold = ConfidenceThreshold;
            
        }
        


        /// <summary>
        /// Query to search chunks in the knowledge base.
        /// </summary>
        /// <value>Query to search chunks in the knowledge base.</value>
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
        /// Filter for the document chunks.
        /// </summary>
        /// <value>Filter for the document chunks.</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public DocumentQuery Filter { get; set; }





        /// <summary>
        /// Indicates whether the chunks search query should be preprocessed.
        /// </summary>
        /// <value>Indicates whether the chunks search query should be preprocessed.</value>
        [DataMember(Name="preprocessQuery", EmitDefaultValue=false)]
        public bool? PreprocessQuery { get; set; }



        /// <summary>
        /// Indicates whether the chunk results would also include draft documents.
        /// </summary>
        /// <value>Indicates whether the chunk results would also include draft documents.</value>
        [DataMember(Name="includeDraftDocuments", EmitDefaultValue=false)]
        public bool? IncludeDraftDocuments { get; set; }



        /// <summary>
        /// The client application details from which chunks request was sent.
        /// </summary>
        /// <value>The client application details from which chunks request was sent.</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public KnowledgeSearchClientApplication Application { get; set; }



        /// <summary>
        /// Conversation context information if the chunks search is initiated in the context of a conversation.
        /// </summary>
        /// <value>Conversation context information if the chunks search is initiated in the context of a conversation.</value>
        [DataMember(Name="conversationContext", EmitDefaultValue=false)]
        public KnowledgeConversationContext ConversationContext { get; set; }



        /// <summary>
        /// The confidence threshold for the chunk results. If applied, the returned results will have an equal or higher confidence than the threshold. The value should be between 0 to 1.
        /// </summary>
        /// <value>The confidence threshold for the chunk results. If applied, the returned results will have an equal or higher confidence than the threshold. The value should be between 0 to 1.</value>
        [DataMember(Name="confidenceThreshold", EmitDefaultValue=false)]
        public float? ConfidenceThreshold { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentChunkRequest {\n");

            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
            sb.Append("  PreprocessQuery: ").Append(PreprocessQuery).Append("\n");
            sb.Append("  IncludeDraftDocuments: ").Append(IncludeDraftDocuments).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
            sb.Append("  ConfidenceThreshold: ").Append(ConfidenceThreshold).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentChunkRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentChunkRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentChunkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentChunkRequest other)
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
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.QueryType == other.QueryType ||
                    this.QueryType != null &&
                    this.QueryType.Equals(other.QueryType)
                ) &&
                (
                    this.PreprocessQuery == other.PreprocessQuery ||
                    this.PreprocessQuery != null &&
                    this.PreprocessQuery.Equals(other.PreprocessQuery)
                ) &&
                (
                    this.IncludeDraftDocuments == other.IncludeDraftDocuments ||
                    this.IncludeDraftDocuments != null &&
                    this.IncludeDraftDocuments.Equals(other.IncludeDraftDocuments)
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
                ) &&
                (
                    this.ConfidenceThreshold == other.ConfidenceThreshold ||
                    this.ConfidenceThreshold != null &&
                    this.ConfidenceThreshold.Equals(other.ConfidenceThreshold)
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

                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();

                if (this.QueryType != null)
                    hash = hash * 59 + this.QueryType.GetHashCode();

                if (this.PreprocessQuery != null)
                    hash = hash * 59 + this.PreprocessQuery.GetHashCode();

                if (this.IncludeDraftDocuments != null)
                    hash = hash * 59 + this.IncludeDraftDocuments.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.ConversationContext != null)
                    hash = hash * 59 + this.ConversationContext.GetHashCode();

                if (this.ConfidenceThreshold != null)
                    hash = hash * 59 + this.ConfidenceThreshold.GetHashCode();

                return hash;
            }
        }
    }

}
