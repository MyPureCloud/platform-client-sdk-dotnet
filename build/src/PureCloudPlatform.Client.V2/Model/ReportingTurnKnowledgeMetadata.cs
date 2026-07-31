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
    /// ReportingTurnKnowledgeMetadata
    /// </summary>
    [DataContract]
    public partial class ReportingTurnKnowledgeMetadata :  IEquatable<ReportingTurnKnowledgeMetadata>
    {
        /// <summary>
        /// The result of the knowledge search
        /// </summary>
        /// <value>The result of the knowledge search</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RetrievalStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum Failure for "Failure"
            /// </summary>
            [EnumMember(Value = "Failure")]
            Failure,
            
            /// <summary>
            /// Enum Noresults for "NoResults"
            /// </summary>
            [EnumMember(Value = "NoResults")]
            Noresults,
            
            /// <summary>
            /// Enum Timeout for "Timeout"
            /// </summary>
            [EnumMember(Value = "Timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The result of the knowledge generation
        /// </summary>
        /// <value>The result of the knowledge generation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AnswerGenerationStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum Failure for "Failure"
            /// </summary>
            [EnumMember(Value = "Failure")]
            Failure,
            
            /// <summary>
            /// Enum Notattempted for "NotAttempted"
            /// </summary>
            [EnumMember(Value = "NotAttempted")]
            Notattempted,
            
            /// <summary>
            /// Enum Noanswergenerated for "NoAnswerGenerated"
            /// </summary>
            [EnumMember(Value = "NoAnswerGenerated")]
            Noanswergenerated,
            
            /// <summary>
            /// Enum Timeout for "Timeout"
            /// </summary>
            [EnumMember(Value = "Timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Failure reason if knowledge query failed
        /// </summary>
        /// <value>Failure reason if knowledge query failed</value>
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
            /// Enum Internalerror for "InternalError"
            /// </summary>
            [EnumMember(Value = "InternalError")]
            Internalerror,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The result of the knowledge search
        /// </summary>
        /// <value>The result of the knowledge search</value>
        [DataMember(Name="retrievalStatus", EmitDefaultValue=false)]
        public RetrievalStatusEnum? RetrievalStatus { get; set; }
        /// <summary>
        /// The result of the knowledge generation
        /// </summary>
        /// <value>The result of the knowledge generation</value>
        [DataMember(Name="answerGenerationStatus", EmitDefaultValue=false)]
        public AnswerGenerationStatusEnum? AnswerGenerationStatus { get; set; }
        /// <summary>
        /// Failure reason if knowledge query failed
        /// </summary>
        /// <value>Failure reason if knowledge query failed</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReasonEnum? FailureReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurnKnowledgeMetadata" /> class.
        /// </summary>
        /// <param name="KnowledgeId">The ID of the knowledge setting or knowledge base.</param>
        /// <param name="KnowledgeName">The name of the knowledge setting or knowledge base.</param>
        /// <param name="SearchId">SearchID used in the attempted search.</param>
        /// <param name="Query">The query used in the knowledge query.</param>
        /// <param name="RetrievalStatus">The result of the knowledge search.</param>
        /// <param name="AnswerGenerationStatus">The result of the knowledge generation.</param>
        /// <param name="GeneratedAnswer">The generated answer.</param>
        /// <param name="FailureReason">Failure reason if knowledge query failed.</param>
        /// <param name="TopConfidence">Highest confidence score of returned knowledgeSources.</param>
        /// <param name="RetrievedSources">List of the sources retrieved by the knowledge search.</param>
        public ReportingTurnKnowledgeMetadata(string KnowledgeId = null, string KnowledgeName = null, string SearchId = null, string Query = null, RetrievalStatusEnum? RetrievalStatus = null, AnswerGenerationStatusEnum? AnswerGenerationStatus = null, string GeneratedAnswer = null, FailureReasonEnum? FailureReason = null, double? TopConfidence = null, List<KnowledgeSource> RetrievedSources = null)
        {
            this.KnowledgeId = KnowledgeId;
            this.KnowledgeName = KnowledgeName;
            this.SearchId = SearchId;
            this.Query = Query;
            this.RetrievalStatus = RetrievalStatus;
            this.AnswerGenerationStatus = AnswerGenerationStatus;
            this.GeneratedAnswer = GeneratedAnswer;
            this.FailureReason = FailureReason;
            this.TopConfidence = TopConfidence;
            this.RetrievedSources = RetrievedSources;
            
        }
        


        /// <summary>
        /// The ID of the knowledge setting or knowledge base
        /// </summary>
        /// <value>The ID of the knowledge setting or knowledge base</value>
        [DataMember(Name="knowledgeId", EmitDefaultValue=false)]
        public string KnowledgeId { get; set; }



        /// <summary>
        /// The name of the knowledge setting or knowledge base
        /// </summary>
        /// <value>The name of the knowledge setting or knowledge base</value>
        [DataMember(Name="knowledgeName", EmitDefaultValue=false)]
        public string KnowledgeName { get; set; }



        /// <summary>
        /// SearchID used in the attempted search
        /// </summary>
        /// <value>SearchID used in the attempted search</value>
        [DataMember(Name="searchId", EmitDefaultValue=false)]
        public string SearchId { get; set; }



        /// <summary>
        /// The query used in the knowledge query
        /// </summary>
        /// <value>The query used in the knowledge query</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }







        /// <summary>
        /// The generated answer
        /// </summary>
        /// <value>The generated answer</value>
        [DataMember(Name="generatedAnswer", EmitDefaultValue=false)]
        public string GeneratedAnswer { get; set; }





        /// <summary>
        /// Highest confidence score of returned knowledgeSources
        /// </summary>
        /// <value>Highest confidence score of returned knowledgeSources</value>
        [DataMember(Name="topConfidence", EmitDefaultValue=false)]
        public double? TopConfidence { get; set; }



        /// <summary>
        /// List of the sources retrieved by the knowledge search
        /// </summary>
        /// <value>List of the sources retrieved by the knowledge search</value>
        [DataMember(Name="retrievedSources", EmitDefaultValue=false)]
        public List<KnowledgeSource> RetrievedSources { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurnKnowledgeMetadata {\n");

            sb.Append("  KnowledgeId: ").Append(KnowledgeId).Append("\n");
            sb.Append("  KnowledgeName: ").Append(KnowledgeName).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  RetrievalStatus: ").Append(RetrievalStatus).Append("\n");
            sb.Append("  AnswerGenerationStatus: ").Append(AnswerGenerationStatus).Append("\n");
            sb.Append("  GeneratedAnswer: ").Append(GeneratedAnswer).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  TopConfidence: ").Append(TopConfidence).Append("\n");
            sb.Append("  RetrievedSources: ").Append(RetrievedSources).Append("\n");
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
            return this.Equals(obj as ReportingTurnKnowledgeMetadata);
        }

        /// <summary>
        /// Returns true if ReportingTurnKnowledgeMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurnKnowledgeMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurnKnowledgeMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.KnowledgeId == other.KnowledgeId ||
                    this.KnowledgeId != null &&
                    this.KnowledgeId.Equals(other.KnowledgeId)
                ) &&
                (
                    this.KnowledgeName == other.KnowledgeName ||
                    this.KnowledgeName != null &&
                    this.KnowledgeName.Equals(other.KnowledgeName)
                ) &&
                (
                    this.SearchId == other.SearchId ||
                    this.SearchId != null &&
                    this.SearchId.Equals(other.SearchId)
                ) &&
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) &&
                (
                    this.RetrievalStatus == other.RetrievalStatus ||
                    this.RetrievalStatus != null &&
                    this.RetrievalStatus.Equals(other.RetrievalStatus)
                ) &&
                (
                    this.AnswerGenerationStatus == other.AnswerGenerationStatus ||
                    this.AnswerGenerationStatus != null &&
                    this.AnswerGenerationStatus.Equals(other.AnswerGenerationStatus)
                ) &&
                (
                    this.GeneratedAnswer == other.GeneratedAnswer ||
                    this.GeneratedAnswer != null &&
                    this.GeneratedAnswer.Equals(other.GeneratedAnswer)
                ) &&
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
                ) &&
                (
                    this.TopConfidence == other.TopConfidence ||
                    this.TopConfidence != null &&
                    this.TopConfidence.Equals(other.TopConfidence)
                ) &&
                (
                    this.RetrievedSources == other.RetrievedSources ||
                    this.RetrievedSources != null &&
                    this.RetrievedSources.SequenceEqual(other.RetrievedSources)
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
                if (this.KnowledgeId != null)
                    hash = hash * 59 + this.KnowledgeId.GetHashCode();

                if (this.KnowledgeName != null)
                    hash = hash * 59 + this.KnowledgeName.GetHashCode();

                if (this.SearchId != null)
                    hash = hash * 59 + this.SearchId.GetHashCode();

                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();

                if (this.RetrievalStatus != null)
                    hash = hash * 59 + this.RetrievalStatus.GetHashCode();

                if (this.AnswerGenerationStatus != null)
                    hash = hash * 59 + this.AnswerGenerationStatus.GetHashCode();

                if (this.GeneratedAnswer != null)
                    hash = hash * 59 + this.GeneratedAnswer.GetHashCode();

                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();

                if (this.TopConfidence != null)
                    hash = hash * 59 + this.TopConfidence.GetHashCode();

                if (this.RetrievedSources != null)
                    hash = hash * 59 + this.RetrievedSources.GetHashCode();

                return hash;
            }
        }
    }

}
