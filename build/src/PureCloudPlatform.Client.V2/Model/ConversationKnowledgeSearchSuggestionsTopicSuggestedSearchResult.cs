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
    /// ConversationKnowledgeSearchSuggestionsTopicSuggestedSearchResult
    /// </summary>
    [DataContract]
    public partial class ConversationKnowledgeSearchSuggestionsTopicSuggestedSearchResult :  IEquatable<ConversationKnowledgeSearchSuggestionsTopicSuggestedSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationKnowledgeSearchSuggestionsTopicSuggestedSearchResult" /> class.
        /// </summary>
        /// <param name="Title">Title.</param>
        /// <param name="Uri">Uri.</param>
        /// <param name="Snippets">Snippets.</param>
        /// <param name="Confidence">Confidence.</param>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="SearchId">SearchId.</param>
        /// <param name="DocumentId">DocumentId.</param>
        /// <param name="VersionId">VersionId.</param>
        /// <param name="VariationIds">VariationIds.</param>
        /// <param name="KnowledgeAnswer">KnowledgeAnswer.</param>
        public ConversationKnowledgeSearchSuggestionsTopicSuggestedSearchResult(string Title = null, string Uri = null, List<string> Snippets = null, double? Confidence = null, Dictionary<string, string> Metadata = null, Guid? SearchId = null, Guid? DocumentId = null, Guid? VersionId = null, List<Guid?> VariationIds = null, ConversationKnowledgeSearchSuggestionsTopicKnowledgeAnswer KnowledgeAnswer = null)
        {
            this.Title = Title;
            this.Uri = Uri;
            this.Snippets = Snippets;
            this.Confidence = Confidence;
            this.Metadata = Metadata;
            this.SearchId = SearchId;
            this.DocumentId = DocumentId;
            this.VersionId = VersionId;
            this.VariationIds = VariationIds;
            this.KnowledgeAnswer = KnowledgeAnswer;
            
        }
        


        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }



        /// <summary>
        /// Gets or Sets Snippets
        /// </summary>
        [DataMember(Name="snippets", EmitDefaultValue=false)]
        public List<string> Snippets { get; set; }



        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double? Confidence { get; set; }



        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, string> Metadata { get; set; }



        /// <summary>
        /// Gets or Sets SearchId
        /// </summary>
        [DataMember(Name="searchId", EmitDefaultValue=false)]
        public Guid? SearchId { get; set; }



        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public Guid? DocumentId { get; set; }



        /// <summary>
        /// Gets or Sets VersionId
        /// </summary>
        [DataMember(Name="versionId", EmitDefaultValue=false)]
        public Guid? VersionId { get; set; }



        /// <summary>
        /// Gets or Sets VariationIds
        /// </summary>
        [DataMember(Name="variationIds", EmitDefaultValue=false)]
        public List<Guid?> VariationIds { get; set; }



        /// <summary>
        /// Gets or Sets KnowledgeAnswer
        /// </summary>
        [DataMember(Name="knowledgeAnswer", EmitDefaultValue=false)]
        public ConversationKnowledgeSearchSuggestionsTopicKnowledgeAnswer KnowledgeAnswer { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationKnowledgeSearchSuggestionsTopicSuggestedSearchResult {\n");

            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Snippets: ").Append(Snippets).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  VariationIds: ").Append(VariationIds).Append("\n");
            sb.Append("  KnowledgeAnswer: ").Append(KnowledgeAnswer).Append("\n");
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
            return this.Equals(obj as ConversationKnowledgeSearchSuggestionsTopicSuggestedSearchResult);
        }

        /// <summary>
        /// Returns true if ConversationKnowledgeSearchSuggestionsTopicSuggestedSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationKnowledgeSearchSuggestionsTopicSuggestedSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationKnowledgeSearchSuggestionsTopicSuggestedSearchResult other)
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
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) &&
                (
                    this.Snippets == other.Snippets ||
                    this.Snippets != null &&
                    this.Snippets.SequenceEqual(other.Snippets)
                ) &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.SequenceEqual(other.Metadata)
                ) &&
                (
                    this.SearchId == other.SearchId ||
                    this.SearchId != null &&
                    this.SearchId.Equals(other.SearchId)
                ) &&
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) &&
                (
                    this.VersionId == other.VersionId ||
                    this.VersionId != null &&
                    this.VersionId.Equals(other.VersionId)
                ) &&
                (
                    this.VariationIds == other.VariationIds ||
                    this.VariationIds != null &&
                    this.VariationIds.SequenceEqual(other.VariationIds)
                ) &&
                (
                    this.KnowledgeAnswer == other.KnowledgeAnswer ||
                    this.KnowledgeAnswer != null &&
                    this.KnowledgeAnswer.Equals(other.KnowledgeAnswer)
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

                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();

                if (this.Snippets != null)
                    hash = hash * 59 + this.Snippets.GetHashCode();

                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.SearchId != null)
                    hash = hash * 59 + this.SearchId.GetHashCode();

                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();

                if (this.VersionId != null)
                    hash = hash * 59 + this.VersionId.GetHashCode();

                if (this.VariationIds != null)
                    hash = hash * 59 + this.VariationIds.GetHashCode();

                if (this.KnowledgeAnswer != null)
                    hash = hash * 59 + this.KnowledgeAnswer.GetHashCode();

                return hash;
            }
        }
    }

}
