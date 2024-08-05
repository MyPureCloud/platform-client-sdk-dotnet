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
    /// Suggestion
    /// </summary>
    [DataContract]
    public partial class Suggestion :  IEquatable<Suggestion>
    {
        /// <summary>
        /// The type of the documents for which the suggestion is.
        /// </summary>
        /// <value>The type of the documents for which the suggestion is.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
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
            Faq,
            
            /// <summary>
            /// Enum Article for "Article"
            /// </summary>
            [EnumMember(Value = "Article")]
            Article,
            
            /// <summary>
            /// Enum Knowledgearticle for "KnowledgeArticle"
            /// </summary>
            [EnumMember(Value = "KnowledgeArticle")]
            Knowledgearticle,
            
            /// <summary>
            /// Enum Knowledgesearch for "KnowledgeSearch"
            /// </summary>
            [EnumMember(Value = "KnowledgeSearch")]
            Knowledgesearch,
            
            /// <summary>
            /// Enum Cannedresponse for "CannedResponse"
            /// </summary>
            [EnumMember(Value = "CannedResponse")]
            Cannedresponse,
            
            /// <summary>
            /// Enum Script for "Script"
            /// </summary>
            [EnumMember(Value = "Script")]
            Script
        }
        /// <summary>
        /// The trigger type of the suggestion.
        /// </summary>
        /// <value>The trigger type of the suggestion.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TriggerTypeEnum
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
            /// Enum Fallback for "Fallback"
            /// </summary>
            [EnumMember(Value = "Fallback")]
            Fallback,
            
            /// <summary>
            /// Enum Conversationstart for "ConversationStart"
            /// </summary>
            [EnumMember(Value = "ConversationStart")]
            Conversationstart,
            
            /// <summary>
            /// Enum Conversationtransfer for "ConversationTransfer"
            /// </summary>
            [EnumMember(Value = "ConversationTransfer")]
            Conversationtransfer,
            
            /// <summary>
            /// Enum Conversationend for "ConversationEnd"
            /// </summary>
            [EnumMember(Value = "ConversationEnd")]
            Conversationend,
            
            /// <summary>
            /// Enum Intent for "Intent"
            /// </summary>
            [EnumMember(Value = "Intent")]
            Intent
        }
        /// <summary>
        /// The state of the suggestion.
        /// </summary>
        /// <value>The state of the suggestion.</value>
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
            /// Enum Suggested for "Suggested"
            /// </summary>
            [EnumMember(Value = "Suggested")]
            Suggested,
            
            /// <summary>
            /// Enum Accepted for "Accepted"
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted,
            
            /// <summary>
            /// Enum Dismissed for "Dismissed"
            /// </summary>
            [EnumMember(Value = "Dismissed")]
            Dismissed,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Rated for "Rated"
            /// </summary>
            [EnumMember(Value = "Rated")]
            Rated
        }
        /// <summary>
        /// The type of the documents for which the suggestion is.
        /// </summary>
        /// <value>The type of the documents for which the suggestion is.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; private set; }
        /// <summary>
        /// The trigger type of the suggestion.
        /// </summary>
        /// <value>The trigger type of the suggestion.</value>
        [DataMember(Name="triggerType", EmitDefaultValue=false)]
        public TriggerTypeEnum? TriggerType { get; private set; }
        /// <summary>
        /// The state of the suggestion.
        /// </summary>
        /// <value>The state of the suggestion.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestion" /> class.
        /// </summary>
        public Suggestion()
        {
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// The Faq from the knowledgebase that was provided as the suggestion.
        /// </summary>
        /// <value>The Faq from the knowledgebase that was provided as the suggestion.</value>
        [DataMember(Name="faq", EmitDefaultValue=false)]
        public Faq Faq { get; private set; }



        /// <summary>
        /// The article from the knowledgebase that was provided as the suggestion.
        /// </summary>
        /// <value>The article from the knowledgebase that was provided as the suggestion.</value>
        [DataMember(Name="article", EmitDefaultValue=false)]
        public Article Article { get; private set; }



        /// <summary>
        /// Date when the suggestion was created. For example: yyyy-MM-ddTHH:mm:ss.SSZ. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the suggestion was created. For example: yyyy-MM-ddTHH:mm:ss.SSZ. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The ID of the knowledge search that provided the suggestion.
        /// </summary>
        /// <value>The ID of the knowledge search that provided the suggestion.</value>
        [DataMember(Name="answerRecordId", EmitDefaultValue=false)]
        public string AnswerRecordId { get; private set; }





        /// <summary>
        /// The conversation context in which the suggestion was raised.
        /// </summary>
        /// <value>The conversation context in which the suggestion was raised.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public SuggestionContext Context { get; private set; }





        /// <summary>
        /// The suggested knowledge search result that was provided as the suggestion.
        /// </summary>
        /// <value>The suggested knowledge search result that was provided as the suggestion.</value>
        [DataMember(Name="knowledgeSearch", EmitDefaultValue=false)]
        public SuggestionKnowledgeSearch KnowledgeSearch { get; private set; }



        /// <summary>
        /// The suggested knowledge article that was provided as the suggestion.
        /// </summary>
        /// <value>The suggested knowledge article that was provided as the suggestion.</value>
        [DataMember(Name="knowledgeArticle", EmitDefaultValue=false)]
        public SuggestionKnowledgeArticle KnowledgeArticle { get; private set; }



        /// <summary>
        /// The suggested canned response that was provided as the suggestion.
        /// </summary>
        /// <value>The suggested canned response that was provided as the suggestion.</value>
        [DataMember(Name="cannedResponse", EmitDefaultValue=false)]
        public SuggestionCannedResponse CannedResponse { get; private set; }



        /// <summary>
        /// The suggested script that was provided as the suggestion.
        /// </summary>
        /// <value>The suggested script that was provided as the suggestion.</value>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public SuggestionScript Script { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }



        /// <summary>
        /// The conversation that the suggestions correspond to.
        /// </summary>
        /// <value>The conversation that the suggestions correspond to.</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public AddressableEntityRef Conversation { get; private set; }



        /// <summary>
        /// The assistant that was used to provide the suggestions.
        /// </summary>
        /// <value>The assistant that was used to provide the suggestions.</value>
        [DataMember(Name="assistant", EmitDefaultValue=false)]
        public AddressableEntityRef Assistant { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Suggestion {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Faq: ").Append(Faq).Append("\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  AnswerRecordId: ").Append(AnswerRecordId).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  KnowledgeSearch: ").Append(KnowledgeSearch).Append("\n");
            sb.Append("  KnowledgeArticle: ").Append(KnowledgeArticle).Append("\n");
            sb.Append("  CannedResponse: ").Append(CannedResponse).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Assistant: ").Append(Assistant).Append("\n");
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
            return this.Equals(obj as Suggestion);
        }

        /// <summary>
        /// Returns true if Suggestion instances are equal
        /// </summary>
        /// <param name="other">Instance of Suggestion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Suggestion other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Faq == other.Faq ||
                    this.Faq != null &&
                    this.Faq.Equals(other.Faq)
                ) &&
                (
                    this.Article == other.Article ||
                    this.Article != null &&
                    this.Article.Equals(other.Article)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.AnswerRecordId == other.AnswerRecordId ||
                    this.AnswerRecordId != null &&
                    this.AnswerRecordId.Equals(other.AnswerRecordId)
                ) &&
                (
                    this.TriggerType == other.TriggerType ||
                    this.TriggerType != null &&
                    this.TriggerType.Equals(other.TriggerType)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.KnowledgeSearch == other.KnowledgeSearch ||
                    this.KnowledgeSearch != null &&
                    this.KnowledgeSearch.Equals(other.KnowledgeSearch)
                ) &&
                (
                    this.KnowledgeArticle == other.KnowledgeArticle ||
                    this.KnowledgeArticle != null &&
                    this.KnowledgeArticle.Equals(other.KnowledgeArticle)
                ) &&
                (
                    this.CannedResponse == other.CannedResponse ||
                    this.CannedResponse != null &&
                    this.CannedResponse.Equals(other.CannedResponse)
                ) &&
                (
                    this.Script == other.Script ||
                    this.Script != null &&
                    this.Script.Equals(other.Script)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.Assistant == other.Assistant ||
                    this.Assistant != null &&
                    this.Assistant.Equals(other.Assistant)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Faq != null)
                    hash = hash * 59 + this.Faq.GetHashCode();

                if (this.Article != null)
                    hash = hash * 59 + this.Article.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.AnswerRecordId != null)
                    hash = hash * 59 + this.AnswerRecordId.GetHashCode();

                if (this.TriggerType != null)
                    hash = hash * 59 + this.TriggerType.GetHashCode();

                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.KnowledgeSearch != null)
                    hash = hash * 59 + this.KnowledgeSearch.GetHashCode();

                if (this.KnowledgeArticle != null)
                    hash = hash * 59 + this.KnowledgeArticle.GetHashCode();

                if (this.CannedResponse != null)
                    hash = hash * 59 + this.CannedResponse.GetHashCode();

                if (this.Script != null)
                    hash = hash * 59 + this.Script.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();

                if (this.Assistant != null)
                    hash = hash * 59 + this.Assistant.GetHashCode();

                return hash;
            }
        }
    }

}
