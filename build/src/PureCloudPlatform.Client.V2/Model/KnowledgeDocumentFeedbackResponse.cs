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
    /// KnowledgeDocumentFeedbackResponse
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentFeedbackResponse :  IEquatable<KnowledgeDocumentFeedbackResponse>
    {
        /// <summary>
        /// Feedback rating.
        /// </summary>
        /// <value>Feedback rating.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RatingEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Negative for "Negative"
            /// </summary>
            [EnumMember(Value = "Negative")]
            Negative,
            
            /// <summary>
            /// Enum Positive for "Positive"
            /// </summary>
            [EnumMember(Value = "Positive")]
            Positive
        }
        /// <summary>
        /// Feedback reason.
        /// </summary>
        /// <value>Feedback reason.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Documentcontent for "DocumentContent"
            /// </summary>
            [EnumMember(Value = "DocumentContent")]
            Documentcontent,
            
            /// <summary>
            /// Enum Searchresults for "SearchResults"
            /// </summary>
            [EnumMember(Value = "SearchResults")]
            Searchresults
        }
        /// <summary>
        /// The type of the query that surfaced the document on which the feedback was given.
        /// </summary>
        /// <value>The type of the query that surfaced the document on which the feedback was given.</value>
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
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Article for "Article"
            /// </summary>
            [EnumMember(Value = "Article")]
            Article,
            
            /// <summary>
            /// Enum Autosearch for "AutoSearch"
            /// </summary>
            [EnumMember(Value = "AutoSearch")]
            Autosearch,
            
            /// <summary>
            /// Enum Category for "Category"
            /// </summary>
            [EnumMember(Value = "Category")]
            Category,
            
            /// <summary>
            /// Enum Manualsearch for "ManualSearch"
            /// </summary>
            [EnumMember(Value = "ManualSearch")]
            Manualsearch,
            
            /// <summary>
            /// Enum Recommendation for "Recommendation"
            /// </summary>
            [EnumMember(Value = "Recommendation")]
            Recommendation,
            
            /// <summary>
            /// Enum Suggestion for "Suggestion"
            /// </summary>
            [EnumMember(Value = "Suggestion")]
            Suggestion,
            
            /// <summary>
            /// Enum Expandedarticle for "ExpandedArticle"
            /// </summary>
            [EnumMember(Value = "ExpandedArticle")]
            Expandedarticle
        }
        /// <summary>
        /// The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown.
        /// </summary>
        /// <value>The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SurfacingMethodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Article for "Article"
            /// </summary>
            [EnumMember(Value = "Article")]
            Article,
            
            /// <summary>
            /// Enum Snippet for "Snippet"
            /// </summary>
            [EnumMember(Value = "Snippet")]
            Snippet,
            
            /// <summary>
            /// Enum Highlight for "Highlight"
            /// </summary>
            [EnumMember(Value = "Highlight")]
            Highlight,
            
            /// <summary>
            /// Enum Generative for "Generative"
            /// </summary>
            [EnumMember(Value = "Generative")]
            Generative
        }
        /// <summary>
        /// The state of the feedback.
        /// </summary>
        /// <value>The state of the feedback.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Final for "Final"
            /// </summary>
            [EnumMember(Value = "Final")]
            Final
        }
        /// <summary>
        /// Feedback rating.
        /// </summary>
        /// <value>Feedback rating.</value>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public RatingEnum? Rating { get; set; }
        /// <summary>
        /// Feedback reason.
        /// </summary>
        /// <value>Feedback reason.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// The type of the query that surfaced the document on which the feedback was given.
        /// </summary>
        /// <value>The type of the query that surfaced the document on which the feedback was given.</value>
        [DataMember(Name="queryType", EmitDefaultValue=false)]
        public QueryTypeEnum? QueryType { get; set; }
        /// <summary>
        /// The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown.
        /// </summary>
        /// <value>The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown.</value>
        [DataMember(Name="surfacingMethod", EmitDefaultValue=false)]
        public SurfacingMethodEnum? SurfacingMethod { get; set; }
        /// <summary>
        /// The state of the feedback.
        /// </summary>
        /// <value>The state of the feedback.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentFeedbackResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentFeedbackResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentFeedbackResponse" /> class.
        /// </summary>
        /// <param name="DocumentVariation">The variation of the document on which feedback was given. (required).</param>
        /// <param name="Rating">Feedback rating. (required).</param>
        /// <param name="Reason">Feedback reason..</param>
        /// <param name="Comment">Free-text comment of the feedback. Maximum length: 2000 characters..</param>
        /// <param name="Search">The search that surfaced the document on which feedback was given..</param>
        /// <param name="QueryType">The type of the query that surfaced the document on which the feedback was given..</param>
        /// <param name="SurfacingMethod">The method how knowledge was surfaced. Article: Full article was shown. Snippet: A snippet from the article was shown. Highlight: A highlighted answer in a snippet was shown.Generative: A generated answer in a snippet was shown..</param>
        /// <param name="State">The state of the feedback..</param>
        /// <param name="Document">The document on which feedback was given..</param>
        /// <param name="Application">The client application from which feedback was given..</param>
        /// <param name="ConversationContext">Conversation context information if the feedback is given in the context of a conversation..</param>
        public KnowledgeDocumentFeedbackResponse(EntityReference DocumentVariation = null, RatingEnum? Rating = null, ReasonEnum? Reason = null, string Comment = null, EntityReference Search = null, QueryTypeEnum? QueryType = null, SurfacingMethodEnum? SurfacingMethod = null, StateEnum? State = null, KnowledgeDocumentVersionReference Document = null, KnowledgeSearchClientApplication Application = null, KnowledgeConversationContextResponse ConversationContext = null)
        {
            this.DocumentVariation = DocumentVariation;
            this.Rating = Rating;
            this.Reason = Reason;
            this.Comment = Comment;
            this.Search = Search;
            this.QueryType = QueryType;
            this.SurfacingMethod = SurfacingMethod;
            this.State = State;
            this.Document = Document;
            this.Application = Application;
            this.ConversationContext = ConversationContext;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The variation of the document on which feedback was given.
        /// </summary>
        /// <value>The variation of the document on which feedback was given.</value>
        [DataMember(Name="documentVariation", EmitDefaultValue=false)]
        public EntityReference DocumentVariation { get; set; }







        /// <summary>
        /// Free-text comment of the feedback. Maximum length: 2000 characters.
        /// </summary>
        /// <value>Free-text comment of the feedback. Maximum length: 2000 characters.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }



        /// <summary>
        /// The search that surfaced the document on which feedback was given.
        /// </summary>
        /// <value>The search that surfaced the document on which feedback was given.</value>
        [DataMember(Name="search", EmitDefaultValue=false)]
        public EntityReference Search { get; set; }



        /// <summary>
        /// Knowledge guest session ID.
        /// </summary>
        /// <value>Knowledge guest session ID.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; private set; }



        /// <summary>
        /// The date and time of the feedback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time of the feedback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }









        /// <summary>
        /// The document on which feedback was given.
        /// </summary>
        /// <value>The document on which feedback was given.</value>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public KnowledgeDocumentVersionReference Document { get; set; }



        /// <summary>
        /// The client application from which feedback was given.
        /// </summary>
        /// <value>The client application from which feedback was given.</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public KnowledgeSearchClientApplication Application { get; set; }



        /// <summary>
        /// Conversation context information if the feedback is given in the context of a conversation.
        /// </summary>
        /// <value>Conversation context information if the feedback is given in the context of a conversation.</value>
        [DataMember(Name="conversationContext", EmitDefaultValue=false)]
        public KnowledgeConversationContextResponse ConversationContext { get; set; }



        /// <summary>
        /// The user who created the feedback.
        /// </summary>
        /// <value>The user who created the feedback.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public AddressableEntityRef User { get; private set; }



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
            sb.Append("class KnowledgeDocumentFeedbackResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DocumentVariation: ").Append(DocumentVariation).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
            sb.Append("  SurfacingMethod: ").Append(SurfacingMethod).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentFeedbackResponse);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentFeedbackResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentFeedbackResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentFeedbackResponse other)
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
                    this.DocumentVariation == other.DocumentVariation ||
                    this.DocumentVariation != null &&
                    this.DocumentVariation.Equals(other.DocumentVariation)
                ) &&
                (
                    this.Rating == other.Rating ||
                    this.Rating != null &&
                    this.Rating.Equals(other.Rating)
                ) &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) &&
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) &&
                (
                    this.Search == other.Search ||
                    this.Search != null &&
                    this.Search.Equals(other.Search)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.QueryType == other.QueryType ||
                    this.QueryType != null &&
                    this.QueryType.Equals(other.QueryType)
                ) &&
                (
                    this.SurfacingMethod == other.SurfacingMethod ||
                    this.SurfacingMethod != null &&
                    this.SurfacingMethod.Equals(other.SurfacingMethod)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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

                if (this.DocumentVariation != null)
                    hash = hash * 59 + this.DocumentVariation.GetHashCode();

                if (this.Rating != null)
                    hash = hash * 59 + this.Rating.GetHashCode();

                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();

                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();

                if (this.Search != null)
                    hash = hash * 59 + this.Search.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.QueryType != null)
                    hash = hash * 59 + this.QueryType.GetHashCode();

                if (this.SurfacingMethod != null)
                    hash = hash * 59 + this.SurfacingMethod.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Document != null)
                    hash = hash * 59 + this.Document.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.ConversationContext != null)
                    hash = hash * 59 + this.ConversationContext.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
