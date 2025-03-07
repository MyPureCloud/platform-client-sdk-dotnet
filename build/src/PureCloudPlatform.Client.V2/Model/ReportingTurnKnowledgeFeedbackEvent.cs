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
    /// ReportingTurnKnowledgeFeedbackEvent
    /// </summary>
    [DataContract]
    public partial class ReportingTurnKnowledgeFeedbackEvent :  IEquatable<ReportingTurnKnowledgeFeedbackEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurnKnowledgeFeedbackEvent" /> class.
        /// </summary>
        /// <param name="SearchId">The ID of this knowledge search..</param>
        /// <param name="KnowledgeBaseId">The Knowledge Base ID that the captured knowledge data relates to..</param>
        /// <param name="Documents">The list of search documents that the feedback applies to..</param>
        /// <param name="FeedbackRating">The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive..</param>
        /// <param name="DocumentVariationId">The variation of the document..</param>
        /// <param name="DocumentVersionId">The version of the document..</param>
        public ReportingTurnKnowledgeFeedbackEvent(string SearchId = null, string KnowledgeBaseId = null, List<ReportingTurnKnowledgeDocument> Documents = null, int? FeedbackRating = null, string DocumentVariationId = null, string DocumentVersionId = null)
        {
            this.SearchId = SearchId;
            this.KnowledgeBaseId = KnowledgeBaseId;
            this.Documents = Documents;
            this.FeedbackRating = FeedbackRating;
            this.DocumentVariationId = DocumentVariationId;
            this.DocumentVersionId = DocumentVersionId;
            
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
        /// The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive.
        /// </summary>
        /// <value>The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive.</value>
        [DataMember(Name="feedbackRating", EmitDefaultValue=false)]
        public int? FeedbackRating { get; set; }



        /// <summary>
        /// The variation of the document.
        /// </summary>
        /// <value>The variation of the document.</value>
        [DataMember(Name="documentVariationId", EmitDefaultValue=false)]
        public string DocumentVariationId { get; set; }



        /// <summary>
        /// The version of the document.
        /// </summary>
        /// <value>The version of the document.</value>
        [DataMember(Name="documentVersionId", EmitDefaultValue=false)]
        public string DocumentVersionId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurnKnowledgeFeedbackEvent {\n");

            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  KnowledgeBaseId: ").Append(KnowledgeBaseId).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  FeedbackRating: ").Append(FeedbackRating).Append("\n");
            sb.Append("  DocumentVariationId: ").Append(DocumentVariationId).Append("\n");
            sb.Append("  DocumentVersionId: ").Append(DocumentVersionId).Append("\n");
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
            return this.Equals(obj as ReportingTurnKnowledgeFeedbackEvent);
        }

        /// <summary>
        /// Returns true if ReportingTurnKnowledgeFeedbackEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurnKnowledgeFeedbackEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurnKnowledgeFeedbackEvent other)
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
                    this.FeedbackRating == other.FeedbackRating ||
                    this.FeedbackRating != null &&
                    this.FeedbackRating.Equals(other.FeedbackRating)
                ) &&
                (
                    this.DocumentVariationId == other.DocumentVariationId ||
                    this.DocumentVariationId != null &&
                    this.DocumentVariationId.Equals(other.DocumentVariationId)
                ) &&
                (
                    this.DocumentVersionId == other.DocumentVersionId ||
                    this.DocumentVersionId != null &&
                    this.DocumentVersionId.Equals(other.DocumentVersionId)
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

                if (this.FeedbackRating != null)
                    hash = hash * 59 + this.FeedbackRating.GetHashCode();

                if (this.DocumentVariationId != null)
                    hash = hash * 59 + this.DocumentVariationId.GetHashCode();

                if (this.DocumentVersionId != null)
                    hash = hash * 59 + this.DocumentVersionId.GetHashCode();

                return hash;
            }
        }
    }

}
