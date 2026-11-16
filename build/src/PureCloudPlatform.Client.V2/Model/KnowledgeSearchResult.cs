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
    /// KnowledgeSearchResult
    /// </summary>
    [DataContract]
    public partial class KnowledgeSearchResult :  IEquatable<KnowledgeSearchResult>
    {
        /// <summary>
        /// Reason the search request did not produce an answer or relevant content.
        /// </summary>
        /// <value>Reason the search request did not produce an answer or relevant content.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FailureReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum EMPTY for ""
            /// </summary>
            [EnumMember(Value = "")]
            EMPTY,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Invalidquery for "invalidQuery"
            /// </summary>
            [EnumMember(Value = "invalidQuery")]
            Invalidquery,
            
            /// <summary>
            /// Enum Ratelimitexceeded for "rateLimitExceeded"
            /// </summary>
            [EnumMember(Value = "rateLimitExceeded")]
            Ratelimitexceeded,
            
            /// <summary>
            /// Enum Modeltimeout for "modelTimeout"
            /// </summary>
            [EnumMember(Value = "modelTimeout")]
            Modeltimeout,
            
            /// <summary>
            /// Enum Promptinjection for "promptInjection"
            /// </summary>
            [EnumMember(Value = "promptInjection")]
            Promptinjection,
            
            /// <summary>
            /// Enum Nocitations for "noCitations"
            /// </summary>
            [EnumMember(Value = "noCitations")]
            Nocitations,
            
            /// <summary>
            /// Enum Invalidanswerformat for "invalidAnswerFormat"
            /// </summary>
            [EnumMember(Value = "invalidAnswerFormat")]
            Invalidanswerformat,
            
            /// <summary>
            /// Enum Unanswerable for "unanswerable"
            /// </summary>
            [EnumMember(Value = "unanswerable")]
            Unanswerable,
            
            /// <summary>
            /// Enum Postprocessingrejected for "postProcessingRejected"
            /// </summary>
            [EnumMember(Value = "postProcessingRejected")]
            Postprocessingrejected,
            
            /// <summary>
            /// Enum Similartoconversation for "similarToConversation"
            /// </summary>
            [EnumMember(Value = "similarToConversation")]
            Similartoconversation,
            
            /// <summary>
            /// Enum Ignorablephrase for "ignorablePhrase"
            /// </summary>
            [EnumMember(Value = "ignorablePhrase")]
            Ignorablephrase,
            
            /// <summary>
            /// Enum Modelerror for "modelError"
            /// </summary>
            [EnumMember(Value = "modelError")]
            Modelerror,
            
            /// <summary>
            /// Enum Nochunksfound for "noChunksFound"
            /// </summary>
            [EnumMember(Value = "noChunksFound")]
            Nochunksfound,
            
            /// <summary>
            /// Enum Answergenerationtimeout for "answerGenerationTimeout"
            /// </summary>
            [EnumMember(Value = "answerGenerationTimeout")]
            Answergenerationtimeout
        }
        /// <summary>
        /// Reason the search request did not produce an answer or relevant content.
        /// </summary>
        /// <value>Reason the search request did not produce an answer or relevant content.</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReasonEnum? FailureReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchResult" /> class.
        /// </summary>
        /// <param name="GeneratedAnswer">The generated answer for search query..</param>
        /// <param name="RetrievedReferences">The retrieved references for the search query..</param>
        /// <param name="FailureReason">Reason the search request did not produce an answer or relevant content..</param>
        /// <param name="Message">A detailed error message describing the failureReason..</param>
        public KnowledgeSearchResult(string GeneratedAnswer = null, List<KnowledgeRetrievedReference> RetrievedReferences = null, FailureReasonEnum? FailureReason = null, string Message = null)
        {
            this.GeneratedAnswer = GeneratedAnswer;
            this.RetrievedReferences = RetrievedReferences;
            this.FailureReason = FailureReason;
            this.Message = Message;
            
        }
        


        /// <summary>
        /// The generated answer for search query.
        /// </summary>
        /// <value>The generated answer for search query.</value>
        [DataMember(Name="generatedAnswer", EmitDefaultValue=false)]
        public string GeneratedAnswer { get; set; }



        /// <summary>
        /// The retrieved references for the search query.
        /// </summary>
        /// <value>The retrieved references for the search query.</value>
        [DataMember(Name="retrievedReferences", EmitDefaultValue=false)]
        public List<KnowledgeRetrievedReference> RetrievedReferences { get; set; }





        /// <summary>
        /// A detailed error message describing the failureReason.
        /// </summary>
        /// <value>A detailed error message describing the failureReason.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSearchResult {\n");

            sb.Append("  GeneratedAnswer: ").Append(GeneratedAnswer).Append("\n");
            sb.Append("  RetrievedReferences: ").Append(RetrievedReferences).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as KnowledgeSearchResult);
        }

        /// <summary>
        /// Returns true if KnowledgeSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.GeneratedAnswer == other.GeneratedAnswer ||
                    this.GeneratedAnswer != null &&
                    this.GeneratedAnswer.Equals(other.GeneratedAnswer)
                ) &&
                (
                    this.RetrievedReferences == other.RetrievedReferences ||
                    this.RetrievedReferences != null &&
                    this.RetrievedReferences.SequenceEqual(other.RetrievedReferences)
                ) &&
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.GeneratedAnswer != null)
                    hash = hash * 59 + this.GeneratedAnswer.GetHashCode();

                if (this.RetrievedReferences != null)
                    hash = hash * 59 + this.RetrievedReferences.GetHashCode();

                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                return hash;
            }
        }
    }

}
