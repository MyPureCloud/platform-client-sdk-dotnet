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
    /// ReportingTurnKnowledgeSearchEvent
    /// </summary>
    [DataContract]
    public partial class ReportingTurnKnowledgeSearchEvent :  IEquatable<ReportingTurnKnowledgeSearchEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurnKnowledgeSearchEvent" /> class.
        /// </summary>
        /// <param name="SearchId">The ID of this knowledge search..</param>
        /// <param name="KnowledgeBaseId">The Knowledge Base ID that the captured knowledge data relates to..</param>
        /// <param name="Documents">The list of search documents that the feedback applies to..</param>
        /// <param name="SearchQuery">The search query that was used to search the Knowledge Base documents for a matching question..</param>
        /// <param name="AnswerDocumentId">The document ID of the search answer..</param>
        public ReportingTurnKnowledgeSearchEvent(string SearchId = null, string KnowledgeBaseId = null, List<ReportingTurnKnowledgeDocument> Documents = null, string SearchQuery = null, string AnswerDocumentId = null)
        {
            this.SearchId = SearchId;
            this.KnowledgeBaseId = KnowledgeBaseId;
            this.Documents = Documents;
            this.SearchQuery = SearchQuery;
            this.AnswerDocumentId = AnswerDocumentId;
            
        }
        


        /// <summary>
        /// The ID of this knowledge search.
        /// </summary>
        /// <value>The ID of this knowledge search.</value>
        [DataMember(Name="searchId", EmitDefaultValue=false)]
        public string SearchId { get; set; }



        /// <summary>
        /// The Knowledge Base ID that the captured knowledge data relates to.
        /// </summary>
        /// <value>The Knowledge Base ID that the captured knowledge data relates to.</value>
        [DataMember(Name="knowledgeBaseId", EmitDefaultValue=false)]
        public string KnowledgeBaseId { get; set; }



        /// <summary>
        /// The list of search documents that the feedback applies to.
        /// </summary>
        /// <value>The list of search documents that the feedback applies to.</value>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<ReportingTurnKnowledgeDocument> Documents { get; set; }



        /// <summary>
        /// The search query that was used to search the Knowledge Base documents for a matching question.
        /// </summary>
        /// <value>The search query that was used to search the Knowledge Base documents for a matching question.</value>
        [DataMember(Name="searchQuery", EmitDefaultValue=false)]
        public string SearchQuery { get; set; }



        /// <summary>
        /// The document ID of the search answer.
        /// </summary>
        /// <value>The document ID of the search answer.</value>
        [DataMember(Name="answerDocumentId", EmitDefaultValue=false)]
        public string AnswerDocumentId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurnKnowledgeSearchEvent {\n");

            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  KnowledgeBaseId: ").Append(KnowledgeBaseId).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
            sb.Append("  AnswerDocumentId: ").Append(AnswerDocumentId).Append("\n");
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
            return this.Equals(obj as ReportingTurnKnowledgeSearchEvent);
        }

        /// <summary>
        /// Returns true if ReportingTurnKnowledgeSearchEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurnKnowledgeSearchEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurnKnowledgeSearchEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SearchId == other.SearchId ||
                    this.SearchId != null &&
                    this.SearchId.Equals(other.SearchId)
                ) &&
                (
                    this.KnowledgeBaseId == other.KnowledgeBaseId ||
                    this.KnowledgeBaseId != null &&
                    this.KnowledgeBaseId.Equals(other.KnowledgeBaseId)
                ) &&
                (
                    this.Documents == other.Documents ||
                    this.Documents != null &&
                    this.Documents.SequenceEqual(other.Documents)
                ) &&
                (
                    this.SearchQuery == other.SearchQuery ||
                    this.SearchQuery != null &&
                    this.SearchQuery.Equals(other.SearchQuery)
                ) &&
                (
                    this.AnswerDocumentId == other.AnswerDocumentId ||
                    this.AnswerDocumentId != null &&
                    this.AnswerDocumentId.Equals(other.AnswerDocumentId)
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
                if (this.SearchId != null)
                    hash = hash * 59 + this.SearchId.GetHashCode();

                if (this.KnowledgeBaseId != null)
                    hash = hash * 59 + this.KnowledgeBaseId.GetHashCode();

                if (this.Documents != null)
                    hash = hash * 59 + this.Documents.GetHashCode();

                if (this.SearchQuery != null)
                    hash = hash * 59 + this.SearchQuery.GetHashCode();

                if (this.AnswerDocumentId != null)
                    hash = hash * 59 + this.AnswerDocumentId.GetHashCode();

                return hash;
            }
        }
    }

}
