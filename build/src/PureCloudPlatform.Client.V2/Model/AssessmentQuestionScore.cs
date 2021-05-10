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
    /// AssessmentQuestionScore
    /// </summary>
    [DataContract]
    public partial class AssessmentQuestionScore :  IEquatable<AssessmentQuestionScore>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentQuestionScore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssessmentQuestionScore() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentQuestionScore" /> class.
        /// </summary>
        /// <param name="Comments">Comments provided for the answer.</param>
        /// <param name="QuestionId">The ID of the question (required).</param>
        /// <param name="AnswerId">The ID of the selected answer.</param>
        /// <param name="MarkedNA">True if this question was marked as NA.</param>
        /// <param name="FreeTextAnswer">Answer for free text answer type.</param>
        public AssessmentQuestionScore(string Comments = null, string QuestionId = null, string AnswerId = null, bool? MarkedNA = null, string FreeTextAnswer = null)
        {
            this.Comments = Comments;
            this.QuestionId = QuestionId;
            this.AnswerId = AnswerId;
            this.MarkedNA = MarkedNA;
            this.FreeTextAnswer = FreeTextAnswer;
            
        }
        
        
        
        /// <summary>
        /// True if this was a failed Kill question
        /// </summary>
        /// <value>True if this was a failed Kill question</value>
        [DataMember(Name="failedKillQuestion", EmitDefaultValue=false)]
        public bool? FailedKillQuestion { get; private set; }
        
        
        
        /// <summary>
        /// Comments provided for the answer
        /// </summary>
        /// <value>Comments provided for the answer</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }
        
        
        
        /// <summary>
        /// The ID of the question
        /// </summary>
        /// <value>The ID of the question</value>
        [DataMember(Name="questionId", EmitDefaultValue=false)]
        public string QuestionId { get; set; }
        
        
        
        /// <summary>
        /// The ID of the selected answer
        /// </summary>
        /// <value>The ID of the selected answer</value>
        [DataMember(Name="answerId", EmitDefaultValue=false)]
        public string AnswerId { get; set; }
        
        
        
        /// <summary>
        /// The score received for this question
        /// </summary>
        /// <value>The score received for this question</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public int? Score { get; private set; }
        
        
        
        /// <summary>
        /// True if this question was marked as NA
        /// </summary>
        /// <value>True if this question was marked as NA</value>
        [DataMember(Name="markedNA", EmitDefaultValue=false)]
        public bool? MarkedNA { get; set; }
        
        
        
        /// <summary>
        /// Answer for free text answer type
        /// </summary>
        /// <value>Answer for free text answer type</value>
        [DataMember(Name="freeTextAnswer", EmitDefaultValue=false)]
        public string FreeTextAnswer { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssessmentQuestionScore {\n");
            
            sb.Append("  FailedKillQuestion: ").Append(FailedKillQuestion).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
            sb.Append("  AnswerId: ").Append(AnswerId).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  MarkedNA: ").Append(MarkedNA).Append("\n");
            sb.Append("  FreeTextAnswer: ").Append(FreeTextAnswer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AssessmentQuestionScore);
        }

        /// <summary>
        /// Returns true if AssessmentQuestionScore instances are equal
        /// </summary>
        /// <param name="other">Instance of AssessmentQuestionScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssessmentQuestionScore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FailedKillQuestion == other.FailedKillQuestion ||
                    this.FailedKillQuestion != null &&
                    this.FailedKillQuestion.Equals(other.FailedKillQuestion)
                ) &&
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) &&
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
                    this.FreeTextAnswer == other.FreeTextAnswer ||
                    this.FreeTextAnswer != null &&
                    this.FreeTextAnswer.Equals(other.FreeTextAnswer)
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
                
                if (this.FailedKillQuestion != null)
                    hash = hash * 59 + this.FailedKillQuestion.GetHashCode();
                
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                
                if (this.QuestionId != null)
                    hash = hash * 59 + this.QuestionId.GetHashCode();
                
                if (this.AnswerId != null)
                    hash = hash * 59 + this.AnswerId.GetHashCode();
                
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                
                if (this.MarkedNA != null)
                    hash = hash * 59 + this.MarkedNA.GetHashCode();
                
                if (this.FreeTextAnswer != null)
                    hash = hash * 59 + this.FreeTextAnswer.GetHashCode();
                
                return hash;
            }
        }
    }

}
