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
    /// KnowledgeDocumentSuggestionRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentSuggestionRequest :  IEquatable<KnowledgeDocumentSuggestionRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentSuggestionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentSuggestionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentSuggestionRequest" /> class.
        /// </summary>
        /// <param name="Query">Query to get autocomplete suggestions for the matching knowledge documents. (required).</param>
        /// <param name="PageSize">Page size of the returned results..</param>
        /// <param name="IncludeDraftDocuments">Indicates whether the suggestion results would also include draft documents..</param>
        public KnowledgeDocumentSuggestionRequest(string Query = null, int? PageSize = null, bool? IncludeDraftDocuments = null)
        {
            this.Query = Query;
            this.PageSize = PageSize;
            this.IncludeDraftDocuments = IncludeDraftDocuments;
            
        }
        


        /// <summary>
        /// Query to get autocomplete suggestions for the matching knowledge documents.
        /// </summary>
        /// <value>Query to get autocomplete suggestions for the matching knowledge documents.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }



        /// <summary>
        /// Page size of the returned results.
        /// </summary>
        /// <value>Page size of the returned results.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Indicates whether the suggestion results would also include draft documents.
        /// </summary>
        /// <value>Indicates whether the suggestion results would also include draft documents.</value>
        [DataMember(Name="includeDraftDocuments", EmitDefaultValue=false)]
        public bool? IncludeDraftDocuments { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentSuggestionRequest {\n");

            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  IncludeDraftDocuments: ").Append(IncludeDraftDocuments).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentSuggestionRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentSuggestionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentSuggestionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentSuggestionRequest other)
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
                    this.IncludeDraftDocuments == other.IncludeDraftDocuments ||
                    this.IncludeDraftDocuments != null &&
                    this.IncludeDraftDocuments.Equals(other.IncludeDraftDocuments)
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

                if (this.IncludeDraftDocuments != null)
                    hash = hash * 59 + this.IncludeDraftDocuments.GetHashCode();

                return hash;
            }
        }
    }

}
