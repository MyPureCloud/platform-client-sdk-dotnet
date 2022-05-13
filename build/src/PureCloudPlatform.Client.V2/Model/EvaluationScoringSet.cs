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
    /// EvaluationScoringSet
    /// </summary>
    [DataContract]
    public partial class EvaluationScoringSet :  IEquatable<EvaluationScoringSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationScoringSet" /> class.
        /// </summary>
        /// <param name="TotalScore">Score of all questions.</param>
        /// <param name="TotalCriticalScore">Score of only the critical questions.</param>
        /// <param name="TotalNonCriticalScore">Score of only the non-critical questions.</param>
        /// <param name="QuestionGroupScores">QuestionGroupScores.</param>
        /// <param name="AnyFailedKillQuestions">Indicates that at least one fatal question was answered without having the highest score available for the question.</param>
        /// <param name="Comments">Overall comments from the evaluator.</param>
        /// <param name="AgentComments">Comments from the agent while reviewing evaluation results.</param>
        /// <param name="TranscriptTopics">List of topics found within the conversation's transcripts.</param>
        public EvaluationScoringSet(float? TotalScore = null, float? TotalCriticalScore = null, float? TotalNonCriticalScore = null, List<EvaluationQuestionGroupScore> QuestionGroupScores = null, bool? AnyFailedKillQuestions = null, string Comments = null, string AgentComments = null, List<TranscriptTopic> TranscriptTopics = null)
        {
            this.TotalScore = TotalScore;
            this.TotalCriticalScore = TotalCriticalScore;
            this.TotalNonCriticalScore = TotalNonCriticalScore;
            this.QuestionGroupScores = QuestionGroupScores;
            this.AnyFailedKillQuestions = AnyFailedKillQuestions;
            this.Comments = Comments;
            this.AgentComments = AgentComments;
            this.TranscriptTopics = TranscriptTopics;
            
        }
        


        /// <summary>
        /// Score of all questions
        /// </summary>
        /// <value>Score of all questions</value>
        [DataMember(Name="totalScore", EmitDefaultValue=false)]
        public float? TotalScore { get; set; }



        /// <summary>
        /// Score of only the critical questions
        /// </summary>
        /// <value>Score of only the critical questions</value>
        [DataMember(Name="totalCriticalScore", EmitDefaultValue=false)]
        public float? TotalCriticalScore { get; set; }



        /// <summary>
        /// Score of only the non-critical questions
        /// </summary>
        /// <value>Score of only the non-critical questions</value>
        [DataMember(Name="totalNonCriticalScore", EmitDefaultValue=false)]
        public float? TotalNonCriticalScore { get; set; }



        /// <summary>
        /// Gets or Sets QuestionGroupScores
        /// </summary>
        [DataMember(Name="questionGroupScores", EmitDefaultValue=false)]
        public List<EvaluationQuestionGroupScore> QuestionGroupScores { get; set; }



        /// <summary>
        /// Indicates that at least one fatal question was answered without having the highest score available for the question
        /// </summary>
        /// <value>Indicates that at least one fatal question was answered without having the highest score available for the question</value>
        [DataMember(Name="anyFailedKillQuestions", EmitDefaultValue=false)]
        public bool? AnyFailedKillQuestions { get; set; }



        /// <summary>
        /// Overall comments from the evaluator
        /// </summary>
        /// <value>Overall comments from the evaluator</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }



        /// <summary>
        /// Comments from the agent while reviewing evaluation results
        /// </summary>
        /// <value>Comments from the agent while reviewing evaluation results</value>
        [DataMember(Name="agentComments", EmitDefaultValue=false)]
        public string AgentComments { get; set; }



        /// <summary>
        /// List of topics found within the conversation's transcripts
        /// </summary>
        /// <value>List of topics found within the conversation's transcripts</value>
        [DataMember(Name="transcriptTopics", EmitDefaultValue=false)]
        public List<TranscriptTopic> TranscriptTopics { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationScoringSet {\n");

            sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
            sb.Append("  TotalCriticalScore: ").Append(TotalCriticalScore).Append("\n");
            sb.Append("  TotalNonCriticalScore: ").Append(TotalNonCriticalScore).Append("\n");
            sb.Append("  QuestionGroupScores: ").Append(QuestionGroupScores).Append("\n");
            sb.Append("  AnyFailedKillQuestions: ").Append(AnyFailedKillQuestions).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  AgentComments: ").Append(AgentComments).Append("\n");
            sb.Append("  TranscriptTopics: ").Append(TranscriptTopics).Append("\n");
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
            return this.Equals(obj as EvaluationScoringSet);
        }

        /// <summary>
        /// Returns true if EvaluationScoringSet instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationScoringSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationScoringSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TotalScore == other.TotalScore ||
                    this.TotalScore != null &&
                    this.TotalScore.Equals(other.TotalScore)
                ) &&
                (
                    this.TotalCriticalScore == other.TotalCriticalScore ||
                    this.TotalCriticalScore != null &&
                    this.TotalCriticalScore.Equals(other.TotalCriticalScore)
                ) &&
                (
                    this.TotalNonCriticalScore == other.TotalNonCriticalScore ||
                    this.TotalNonCriticalScore != null &&
                    this.TotalNonCriticalScore.Equals(other.TotalNonCriticalScore)
                ) &&
                (
                    this.QuestionGroupScores == other.QuestionGroupScores ||
                    this.QuestionGroupScores != null &&
                    this.QuestionGroupScores.SequenceEqual(other.QuestionGroupScores)
                ) &&
                (
                    this.AnyFailedKillQuestions == other.AnyFailedKillQuestions ||
                    this.AnyFailedKillQuestions != null &&
                    this.AnyFailedKillQuestions.Equals(other.AnyFailedKillQuestions)
                ) &&
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) &&
                (
                    this.AgentComments == other.AgentComments ||
                    this.AgentComments != null &&
                    this.AgentComments.Equals(other.AgentComments)
                ) &&
                (
                    this.TranscriptTopics == other.TranscriptTopics ||
                    this.TranscriptTopics != null &&
                    this.TranscriptTopics.SequenceEqual(other.TranscriptTopics)
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
                if (this.TotalScore != null)
                    hash = hash * 59 + this.TotalScore.GetHashCode();

                if (this.TotalCriticalScore != null)
                    hash = hash * 59 + this.TotalCriticalScore.GetHashCode();

                if (this.TotalNonCriticalScore != null)
                    hash = hash * 59 + this.TotalNonCriticalScore.GetHashCode();

                if (this.QuestionGroupScores != null)
                    hash = hash * 59 + this.QuestionGroupScores.GetHashCode();

                if (this.AnyFailedKillQuestions != null)
                    hash = hash * 59 + this.AnyFailedKillQuestions.GetHashCode();

                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();

                if (this.AgentComments != null)
                    hash = hash * 59 + this.AgentComments.GetHashCode();

                if (this.TranscriptTopics != null)
                    hash = hash * 59 + this.TranscriptTopics.GetHashCode();

                return hash;
            }
        }
    }

}
