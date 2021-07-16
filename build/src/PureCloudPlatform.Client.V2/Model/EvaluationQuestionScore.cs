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
    /// EvaluationQuestionScore
    /// </summary>
    [DataContract]
    public partial class EvaluationQuestionScore :  IEquatable<EvaluationQuestionScore>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationQuestionScore" /> class.
        /// </summary>
        /// <param name="QuestionId">QuestionId.</param>
        /// <param name="AnswerId">AnswerId.</param>
        /// <param name="Score">Unweighted score of the question.</param>
        /// <param name="MarkedNA">MarkedNA.</param>
        /// <param name="FailedKillQuestion">Applicable only on fatal questions. Indicates that the answer selected was not the highest score available for the question.</param>
        /// <param name="Comments">Comments from the evaluator specific to this question.</param>
        public EvaluationQuestionScore(string QuestionId = null, string AnswerId = null, int? Score = null, bool? MarkedNA = null, bool? FailedKillQuestion = null, string Comments = null)
        {
            this.QuestionId = QuestionId;
            this.AnswerId = AnswerId;
            this.Score = Score;
            this.MarkedNA = MarkedNA;
            this.FailedKillQuestion = FailedKillQuestion;
            this.Comments = Comments;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets QuestionId
        /// </summary>
        [DataMember(Name="questionId", EmitDefaultValue=false)]
        public string QuestionId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AnswerId
        /// </summary>
        [DataMember(Name="answerId", EmitDefaultValue=false)]
        public string AnswerId { get; set; }
        
        
        
        /// <summary>
        /// Unweighted score of the question
        /// </summary>
        /// <value>Unweighted score of the question</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public int? Score { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MarkedNA
        /// </summary>
        [DataMember(Name="markedNA", EmitDefaultValue=false)]
        public bool? MarkedNA { get; set; }
        
        
        
        /// <summary>
        /// Applicable only on fatal questions. Indicates that the answer selected was not the highest score available for the question
        /// </summary>
        /// <value>Applicable only on fatal questions. Indicates that the answer selected was not the highest score available for the question</value>
        [DataMember(Name="failedKillQuestion", EmitDefaultValue=false)]
        public bool? FailedKillQuestion { get; set; }
        
        
        
        /// <summary>
        /// Comments from the evaluator specific to this question
        /// </summary>
        /// <value>Comments from the evaluator specific to this question</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationQuestionScore {\n");
            
            sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
            sb.Append("  AnswerId: ").Append(AnswerId).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  MarkedNA: ").Append(MarkedNA).Append("\n");
            sb.Append("  FailedKillQuestion: ").Append(FailedKillQuestion).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
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
            return this.Equals(obj as EvaluationQuestionScore);
        }

        /// <summary>
        /// Returns true if EvaluationQuestionScore instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationQuestionScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationQuestionScore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QuestionId == other.QuestionId ||
                    this.QuestionId != null &&
                    this.QuestionId.Equals(other.QuestionId)
                ) &&
                (
                    this.AnswerId == other.AnswerId ||
                    this.AnswerId != null &&
                    this.AnswerId.Equals(other.AnswerId)
                ) &&
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) &&
                (
                    this.MarkedNA == other.MarkedNA ||
                    this.MarkedNA != null &&
                    this.MarkedNA.Equals(other.MarkedNA)
                ) &&
                (
                    this.FailedKillQuestion == other.FailedKillQuestion ||
                    this.FailedKillQuestion != null &&
                    this.FailedKillQuestion.Equals(other.FailedKillQuestion)
                ) &&
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
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
                
                if (this.QuestionId != null)
                    hash = hash * 59 + this.QuestionId.GetHashCode();
                
                if (this.AnswerId != null)
                    hash = hash * 59 + this.AnswerId.GetHashCode();
                
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                
                if (this.MarkedNA != null)
                    hash = hash * 59 + this.MarkedNA.GetHashCode();
                
                if (this.FailedKillQuestion != null)
                    hash = hash * 59 + this.FailedKillQuestion.GetHashCode();
                
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                
                return hash;
            }
        }
    }

}
