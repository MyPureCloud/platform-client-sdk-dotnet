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
    /// KnowledgeSearchPreviewResponse
    /// </summary>
    [DataContract]
    public partial class KnowledgeSearchPreviewResponse :  IEquatable<KnowledgeSearchPreviewResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchPreviewResponse" /> class.
        /// </summary>
        /// <param name="Query">Query to search content in the knowledge base..</param>
        /// <param name="Application">The touchpoint application used for the preview..</param>
        /// <param name="ConversationContext">The channel context used for the preview..</param>
        public KnowledgeSearchPreviewResponse(string Query = null, V3KnowledgeSearchPreviewClientApplication Application = null, KnowledgeV3PreviewConversationContext ConversationContext = null)
        {
            this.Query = Query;
            this.Application = Application;
            this.ConversationContext = ConversationContext;
            
        }
        


        /// <summary>
        /// Query to search content in the knowledge base.
        /// </summary>
        /// <value>Query to search content in the knowledge base.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }



        /// <summary>
        /// The globally unique identifier for the search.
        /// </summary>
        /// <value>The globally unique identifier for the search.</value>
        [DataMember(Name="searchId", EmitDefaultValue=false)]
        public string SearchId { get; private set; }



        /// <summary>
        /// The sessionId for search request.
        /// </summary>
        /// <value>The sessionId for search request.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; private set; }



        /// <summary>
        /// Content matching the search query.
        /// </summary>
        /// <value>Content matching the search query.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public KnowledgeSearchResult Result { get; private set; }



        /// <summary>
        /// The touchpoint application used for the preview.
        /// </summary>
        /// <value>The touchpoint application used for the preview.</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public V3KnowledgeSearchPreviewClientApplication Application { get; set; }



        /// <summary>
        /// The channel context used for the preview.
        /// </summary>
        /// <value>The channel context used for the preview.</value>
        [DataMember(Name="conversationContext", EmitDefaultValue=false)]
        public KnowledgeV3PreviewConversationContext ConversationContext { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSearchPreviewResponse {\n");

            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(obj as KnowledgeSearchPreviewResponse);
        }

        /// <summary>
        /// Returns true if KnowledgeSearchPreviewResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSearchPreviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSearchPreviewResponse other)
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
                    this.SearchId == other.SearchId ||
                    this.SearchId != null &&
                    this.SearchId.Equals(other.SearchId)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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

                if (this.SearchId != null)
                    hash = hash * 59 + this.SearchId.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.ConversationContext != null)
                    hash = hash * 59 + this.ConversationContext.GetHashCode();

                return hash;
            }
        }
    }

}
