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
    /// KnowledgeSearchPreviewRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeSearchPreviewRequest :  IEquatable<KnowledgeSearchPreviewRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchPreviewRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeSearchPreviewRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchPreviewRequest" /> class.
        /// </summary>
        /// <param name="Query">Query to search content in the knowledge sources. (required).</param>
        /// <param name="Sources">Source information to search upon. (required).</param>
        /// <param name="GenerationSetting">Setting for answer generation. (required).</param>
        /// <param name="Stateful">Indicates if stateful search and generation is enabled for the knowledge setting..</param>
        /// <param name="ConversationTurns">List of conversation turns to use for stateful search..</param>
        public KnowledgeSearchPreviewRequest(string Query = null, List<V3SourceRef> Sources = null, KnowledgeGenerationSetting GenerationSetting = null, bool? Stateful = null, List<KnowledgeConversationTurn> ConversationTurns = null)
        {
            this.Query = Query;
            this.Sources = Sources;
            this.GenerationSetting = GenerationSetting;
            this.Stateful = Stateful;
            this.ConversationTurns = ConversationTurns;
            
        }
        


        /// <summary>
        /// Query to search content in the knowledge sources.
        /// </summary>
        /// <value>Query to search content in the knowledge sources.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }



        /// <summary>
        /// Source information to search upon.
        /// </summary>
        /// <value>Source information to search upon.</value>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public List<V3SourceRef> Sources { get; set; }



        /// <summary>
        /// Setting for answer generation.
        /// </summary>
        /// <value>Setting for answer generation.</value>
        [DataMember(Name="generationSetting", EmitDefaultValue=false)]
        public KnowledgeGenerationSetting GenerationSetting { get; set; }



        /// <summary>
        /// Indicates if stateful search and generation is enabled for the knowledge setting.
        /// </summary>
        /// <value>Indicates if stateful search and generation is enabled for the knowledge setting.</value>
        [DataMember(Name="stateful", EmitDefaultValue=false)]
        public bool? Stateful { get; set; }



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
            sb.Append("class KnowledgeSearchPreviewRequest {\n");

            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  GenerationSetting: ").Append(GenerationSetting).Append("\n");
            sb.Append("  Stateful: ").Append(Stateful).Append("\n");
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
            return this.Equals(obj as KnowledgeSearchPreviewRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeSearchPreviewRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSearchPreviewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSearchPreviewRequest other)
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
                    this.Sources == other.Sources ||
                    this.Sources != null &&
                    this.Sources.SequenceEqual(other.Sources)
                ) &&
                (
                    this.GenerationSetting == other.GenerationSetting ||
                    this.GenerationSetting != null &&
                    this.GenerationSetting.Equals(other.GenerationSetting)
                ) &&
                (
                    this.Stateful == other.Stateful ||
                    this.Stateful != null &&
                    this.Stateful.Equals(other.Stateful)
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

                if (this.Sources != null)
                    hash = hash * 59 + this.Sources.GetHashCode();

                if (this.GenerationSetting != null)
                    hash = hash * 59 + this.GenerationSetting.GetHashCode();

                if (this.Stateful != null)
                    hash = hash * 59 + this.Stateful.GetHashCode();

                if (this.ConversationTurns != null)
                    hash = hash * 59 + this.ConversationTurns.GetHashCode();

                return hash;
            }
        }
    }

}
