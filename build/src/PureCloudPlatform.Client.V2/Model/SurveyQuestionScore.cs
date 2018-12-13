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
    /// SurveyQuestionScore
    /// </summary>
    [DataContract]
    public partial class SurveyQuestionScore :  IEquatable<SurveyQuestionScore>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyQuestionScore" /> class.
        /// </summary>
        /// <param name="QuestionId">QuestionId.</param>
        /// <param name="AnswerId">AnswerId.</param>
        /// <param name="Score">Score.</param>
        /// <param name="MarkedNA">MarkedNA.</param>
        /// <param name="NpsScore">NpsScore.</param>
        /// <param name="NpsTextAnswer">NpsTextAnswer.</param>
        /// <param name="FreeTextAnswer">FreeTextAnswer.</param>
        public SurveyQuestionScore(string QuestionId = null, string AnswerId = null, int? Score = null, bool? MarkedNA = null, int? NpsScore = null, string NpsTextAnswer = null, string FreeTextAnswer = null)
        {
            this.QuestionId = QuestionId;
            this.AnswerId = AnswerId;
            this.Score = Score;
            this.MarkedNA = MarkedNA;
            this.NpsScore = NpsScore;
            this.NpsTextAnswer = NpsTextAnswer;
            this.FreeTextAnswer = FreeTextAnswer;
            
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
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public int? Score { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MarkedNA
        /// </summary>
        [DataMember(Name="markedNA", EmitDefaultValue=false)]
        public bool? MarkedNA { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NpsScore
        /// </summary>
        [DataMember(Name="npsScore", EmitDefaultValue=false)]
        public int? NpsScore { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NpsTextAnswer
        /// </summary>
        [DataMember(Name="npsTextAnswer", EmitDefaultValue=false)]
        public string NpsTextAnswer { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FreeTextAnswer
        /// </summary>
        [DataMember(Name="freeTextAnswer", EmitDefaultValue=false)]
        public string FreeTextAnswer { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SurveyQuestionScore {\n");
            
            sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
            sb.Append("  AnswerId: ").Append(AnswerId).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  MarkedNA: ").Append(MarkedNA).Append("\n");
            sb.Append("  NpsScore: ").Append(NpsScore).Append("\n");
            sb.Append("  NpsTextAnswer: ").Append(NpsTextAnswer).Append("\n");
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
            return this.Equals(obj as SurveyQuestionScore);
        }

        /// <summary>
        /// Returns true if SurveyQuestionScore instances are equal
        /// </summary>
        /// <param name="other">Instance of SurveyQuestionScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurveyQuestionScore other)
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
                    this.NpsScore == other.NpsScore ||
                    this.NpsScore != null &&
                    this.NpsScore.Equals(other.NpsScore)
                ) &&
                (
                    this.NpsTextAnswer == other.NpsTextAnswer ||
                    this.NpsTextAnswer != null &&
                    this.NpsTextAnswer.Equals(other.NpsTextAnswer)
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
                
                if (this.QuestionId != null)
                    hash = hash * 59 + this.QuestionId.GetHashCode();
                
                if (this.AnswerId != null)
                    hash = hash * 59 + this.AnswerId.GetHashCode();
                
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                
                if (this.MarkedNA != null)
                    hash = hash * 59 + this.MarkedNA.GetHashCode();
                
                if (this.NpsScore != null)
                    hash = hash * 59 + this.NpsScore.GetHashCode();
                
                if (this.NpsTextAnswer != null)
                    hash = hash * 59 + this.NpsTextAnswer.GetHashCode();
                
                if (this.FreeTextAnswer != null)
                    hash = hash * 59 + this.FreeTextAnswer.GetHashCode();
                
                return hash;
            }
        }
    }

}
