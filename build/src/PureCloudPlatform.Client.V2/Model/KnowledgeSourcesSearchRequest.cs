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
    /// KnowledgeSourcesSearchRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeSourcesSearchRequest :  IEquatable<KnowledgeSourcesSearchRequest>
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
            Manualsearch
        }
        /// <summary>
        /// The language to use for answer generation.
        /// </summary>
        /// <value>The language to use for answer generation.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GenerationLanguageEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Arae for "ar-AE"
            /// </summary>
            [EnumMember(Value = "ar-AE")]
            Arae,
            
            /// <summary>
            /// Enum Cscz for "cs-CZ"
            /// </summary>
            [EnumMember(Value = "cs-CZ")]
            Cscz,
            
            /// <summary>
            /// Enum Dadk for "da-DK"
            /// </summary>
            [EnumMember(Value = "da-DK")]
            Dadk,
            
            /// <summary>
            /// Enum Deat for "de-AT"
            /// </summary>
            [EnumMember(Value = "de-AT")]
            Deat,
            
            /// <summary>
            /// Enum Dech for "de-CH"
            /// </summary>
            [EnumMember(Value = "de-CH")]
            Dech,
            
            /// <summary>
            /// Enum Dede for "de-DE"
            /// </summary>
            [EnumMember(Value = "de-DE")]
            Dede,
            
            /// <summary>
            /// Enum Enau for "en-AU"
            /// </summary>
            [EnumMember(Value = "en-AU")]
            Enau,
            
            /// <summary>
            /// Enum Enca for "en-CA"
            /// </summary>
            [EnumMember(Value = "en-CA")]
            Enca,
            
            /// <summary>
            /// Enum Engb for "en-GB"
            /// </summary>
            [EnumMember(Value = "en-GB")]
            Engb,
            
            /// <summary>
            /// Enum Enhk for "en-HK"
            /// </summary>
            [EnumMember(Value = "en-HK")]
            Enhk,
            
            /// <summary>
            /// Enum Enie for "en-IE"
            /// </summary>
            [EnumMember(Value = "en-IE")]
            Enie,
            
            /// <summary>
            /// Enum Enin for "en-IN"
            /// </summary>
            [EnumMember(Value = "en-IN")]
            Enin,
            
            /// <summary>
            /// Enum Ennz for "en-NZ"
            /// </summary>
            [EnumMember(Value = "en-NZ")]
            Ennz,
            
            /// <summary>
            /// Enum Enph for "en-PH"
            /// </summary>
            [EnumMember(Value = "en-PH")]
            Enph,
            
            /// <summary>
            /// Enum Ensg for "en-SG"
            /// </summary>
            [EnumMember(Value = "en-SG")]
            Ensg,
            
            /// <summary>
            /// Enum Enus for "en-US"
            /// </summary>
            [EnumMember(Value = "en-US")]
            Enus,
            
            /// <summary>
            /// Enum Enza for "en-ZA"
            /// </summary>
            [EnumMember(Value = "en-ZA")]
            Enza,
            
            /// <summary>
            /// Enum Esar for "es-AR"
            /// </summary>
            [EnumMember(Value = "es-AR")]
            Esar,
            
            /// <summary>
            /// Enum Esco for "es-CO"
            /// </summary>
            [EnumMember(Value = "es-CO")]
            Esco,
            
            /// <summary>
            /// Enum Eses for "es-ES"
            /// </summary>
            [EnumMember(Value = "es-ES")]
            Eses,
            
            /// <summary>
            /// Enum Esmx for "es-MX"
            /// </summary>
            [EnumMember(Value = "es-MX")]
            Esmx,
            
            /// <summary>
            /// Enum Esus for "es-US"
            /// </summary>
            [EnumMember(Value = "es-US")]
            Esus,
            
            /// <summary>
            /// Enum Fifi for "fi-FI"
            /// </summary>
            [EnumMember(Value = "fi-FI")]
            Fifi,
            
            /// <summary>
            /// Enum Frbe for "fr-BE"
            /// </summary>
            [EnumMember(Value = "fr-BE")]
            Frbe,
            
            /// <summary>
            /// Enum Frca for "fr-CA"
            /// </summary>
            [EnumMember(Value = "fr-CA")]
            Frca,
            
            /// <summary>
            /// Enum Frch for "fr-CH"
            /// </summary>
            [EnumMember(Value = "fr-CH")]
            Frch,
            
            /// <summary>
            /// Enum Frfr for "fr-FR"
            /// </summary>
            [EnumMember(Value = "fr-FR")]
            Frfr,
            
            /// <summary>
            /// Enum Hiin for "hi-IN"
            /// </summary>
            [EnumMember(Value = "hi-IN")]
            Hiin,
            
            /// <summary>
            /// Enum Huhu for "hu-HU"
            /// </summary>
            [EnumMember(Value = "hu-HU")]
            Huhu,
            
            /// <summary>
            /// Enum Itit for "it-IT"
            /// </summary>
            [EnumMember(Value = "it-IT")]
            Itit,
            
            /// <summary>
            /// Enum Jajp for "ja-JP"
            /// </summary>
            [EnumMember(Value = "ja-JP")]
            Jajp,
            
            /// <summary>
            /// Enum Kokr for "ko-KR"
            /// </summary>
            [EnumMember(Value = "ko-KR")]
            Kokr,
            
            /// <summary>
            /// Enum Nbno for "nb-NO"
            /// </summary>
            [EnumMember(Value = "nb-NO")]
            Nbno,
            
            /// <summary>
            /// Enum Nlbe for "nl-BE"
            /// </summary>
            [EnumMember(Value = "nl-BE")]
            Nlbe,
            
            /// <summary>
            /// Enum Nlnl for "nl-NL"
            /// </summary>
            [EnumMember(Value = "nl-NL")]
            Nlnl,
            
            /// <summary>
            /// Enum Ptbr for "pt-BR"
            /// </summary>
            [EnumMember(Value = "pt-BR")]
            Ptbr,
            
            /// <summary>
            /// Enum Ptpt for "pt-PT"
            /// </summary>
            [EnumMember(Value = "pt-PT")]
            Ptpt,
            
            /// <summary>
            /// Enum Svse for "sv-SE"
            /// </summary>
            [EnumMember(Value = "sv-SE")]
            Svse,
            
            /// <summary>
            /// Enum Trtr for "tr-TR"
            /// </summary>
            [EnumMember(Value = "tr-TR")]
            Trtr
        }
        /// <summary>
        /// The type of the query that initiates the search.
        /// </summary>
        /// <value>The type of the query that initiates the search.</value>
        [DataMember(Name="queryType", EmitDefaultValue=false)]
        public QueryTypeEnum? QueryType { get; set; }
        /// <summary>
        /// The language to use for answer generation.
        /// </summary>
        /// <value>The language to use for answer generation.</value>
        [DataMember(Name="generationLanguage", EmitDefaultValue=false)]
        public GenerationLanguageEnum? GenerationLanguage { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSourcesSearchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeSourcesSearchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSourcesSearchRequest" /> class.
        /// </summary>
        /// <param name="Query">Input query to search content on the knowledge setting. (required).</param>
        /// <param name="KnowledgeSettingId">Knowledge Setting Id to use for search request. (required).</param>
        /// <param name="Application">The client application details from which search requested..</param>
        /// <param name="ConversationContext">Conversation context information if the search is initiated in the context of a conversation..</param>
        /// <param name="SessionId">The session id for search request..</param>
        /// <param name="QueryType">The type of the query that initiates the search..</param>
        /// <param name="GenerationLanguage">The language to use for answer generation..</param>
        /// <param name="ConversationTurns">List of conversation turns to use for stateful search..</param>
        public KnowledgeSourcesSearchRequest(string Query = null, string KnowledgeSettingId = null, V3KnowledgeSearchClientApplication Application = null, KnowledgeV3ConversationContext ConversationContext = null, string SessionId = null, QueryTypeEnum? QueryType = null, GenerationLanguageEnum? GenerationLanguage = null, List<KnowledgeConversationTurn> ConversationTurns = null)
        {
            this.Query = Query;
            this.KnowledgeSettingId = KnowledgeSettingId;
            this.Application = Application;
            this.ConversationContext = ConversationContext;
            this.SessionId = SessionId;
            this.QueryType = QueryType;
            this.GenerationLanguage = GenerationLanguage;
            this.ConversationTurns = ConversationTurns;
            
        }
        


        /// <summary>
        /// Input query to search content on the knowledge setting.
        /// </summary>
        /// <value>Input query to search content on the knowledge setting.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }



        /// <summary>
        /// Knowledge Setting Id to use for search request.
        /// </summary>
        /// <value>Knowledge Setting Id to use for search request.</value>
        [DataMember(Name="knowledgeSettingId", EmitDefaultValue=false)]
        public string KnowledgeSettingId { get; set; }



        /// <summary>
        /// The client application details from which search requested.
        /// </summary>
        /// <value>The client application details from which search requested.</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public V3KnowledgeSearchClientApplication Application { get; set; }



        /// <summary>
        /// Conversation context information if the search is initiated in the context of a conversation.
        /// </summary>
        /// <value>Conversation context information if the search is initiated in the context of a conversation.</value>
        [DataMember(Name="conversationContext", EmitDefaultValue=false)]
        public KnowledgeV3ConversationContext ConversationContext { get; set; }



        /// <summary>
        /// The session id for search request.
        /// </summary>
        /// <value>The session id for search request.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }







        /// <summary>
        /// List of conversation turns to use for stateful search.
        /// </summary>
        /// <value>List of conversation turns to use for stateful search.</value>
        [DataMember(Name="conversationTurns", EmitDefaultValue=false)]
        public List<KnowledgeConversationTurn> ConversationTurns { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSourcesSearchRequest {\n");

            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  KnowledgeSettingId: ").Append(KnowledgeSettingId).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
            sb.Append("  GenerationLanguage: ").Append(GenerationLanguage).Append("\n");
            sb.Append("  ConversationTurns: ").Append(ConversationTurns).Append("\n");
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
            return this.Equals(obj as KnowledgeSourcesSearchRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeSourcesSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSourcesSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSourcesSearchRequest other)
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
                    this.KnowledgeSettingId == other.KnowledgeSettingId ||
                    this.KnowledgeSettingId != null &&
                    this.KnowledgeSettingId.Equals(other.KnowledgeSettingId)
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
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.QueryType == other.QueryType ||
                    this.QueryType != null &&
                    this.QueryType.Equals(other.QueryType)
                ) &&
                (
                    this.GenerationLanguage == other.GenerationLanguage ||
                    this.GenerationLanguage != null &&
                    this.GenerationLanguage.Equals(other.GenerationLanguage)
                ) &&
                (
                    this.ConversationTurns == other.ConversationTurns ||
                    this.ConversationTurns != null &&
                    this.ConversationTurns.SequenceEqual(other.ConversationTurns)
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

                if (this.KnowledgeSettingId != null)
                    hash = hash * 59 + this.KnowledgeSettingId.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.ConversationContext != null)
                    hash = hash * 59 + this.ConversationContext.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.QueryType != null)
                    hash = hash * 59 + this.QueryType.GetHashCode();

                if (this.GenerationLanguage != null)
                    hash = hash * 59 + this.GenerationLanguage.GetHashCode();

                if (this.ConversationTurns != null)
                    hash = hash * 59 + this.ConversationTurns.GetHashCode();

                return hash;
            }
        }
    }

}
