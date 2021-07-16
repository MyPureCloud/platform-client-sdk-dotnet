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
    /// AssessmentQuestionGroupScore
    /// </summary>
    [DataContract]
    public partial class AssessmentQuestionGroupScore :  IEquatable<AssessmentQuestionGroupScore>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentQuestionGroupScore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssessmentQuestionGroupScore() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentQuestionGroupScore" /> class.
        /// </summary>
        /// <param name="QuestionGroupId">The ID of the question group (required).</param>
        /// <param name="MarkedNA">True if this question group is marked NA.</param>
        /// <param name="QuestionScores">The individual question scores.</param>
        public AssessmentQuestionGroupScore(string QuestionGroupId = null, bool? MarkedNA = null, List<AssessmentQuestionScore> QuestionScores = null)
        {
            this.QuestionGroupId = QuestionGroupId;
            this.MarkedNA = MarkedNA;
            this.QuestionScores = QuestionScores;
            
        }
        
        
        
        /// <summary>
        /// The ID of the question group
        /// </summary>
        /// <value>The ID of the question group</value>
        [DataMember(Name="questionGroupId", EmitDefaultValue=false)]
        public string QuestionGroupId { get; set; }
        
        
        
        /// <summary>
        /// The total score for the questions
        /// </summary>
        /// <value>The total score for the questions</value>
        [DataMember(Name="totalScore", EmitDefaultValue=false)]
        public float? TotalScore { get; private set; }
        
        
        
        /// <summary>
        /// The maximum total score for the questions
        /// </summary>
        /// <value>The maximum total score for the questions</value>
        [DataMember(Name="maxTotalScore", EmitDefaultValue=false)]
        public float? MaxTotalScore { get; private set; }
        
        
        
        /// <summary>
        /// True if this question group is marked NA
        /// </summary>
        /// <value>True if this question group is marked NA</value>
        [DataMember(Name="markedNA", EmitDefaultValue=false)]
        public bool? MarkedNA { get; set; }
        
        
        
        /// <summary>
        /// The total score for the critical questions
        /// </summary>
        /// <value>The total score for the critical questions</value>
        [DataMember(Name="totalCriticalScore", EmitDefaultValue=false)]
        public float? TotalCriticalScore { get; private set; }
        
        
        
        /// <summary>
        /// The maximum total score for the critical questions
        /// </summary>
        /// <value>The maximum total score for the critical questions</value>
        [DataMember(Name="maxTotalCriticalScore", EmitDefaultValue=false)]
        public float? MaxTotalCriticalScore { get; private set; }
        
        
        
        /// <summary>
        /// The total score for the non-critical questions
        /// </summary>
        /// <value>The total score for the non-critical questions</value>
        [DataMember(Name="totalNonCriticalScore", EmitDefaultValue=false)]
        public float? TotalNonCriticalScore { get; private set; }
        
        
        
        /// <summary>
        /// The maximum total score for the non-critical questions
        /// </summary>
        /// <value>The maximum total score for the non-critical questions</value>
        [DataMember(Name="maxTotalNonCriticalScore", EmitDefaultValue=false)]
        public float? MaxTotalNonCriticalScore { get; private set; }
        
        
        
        /// <summary>
        /// The unweighted total score for this question group
        /// </summary>
        /// <value>The unweighted total score for this question group</value>
        [DataMember(Name="totalScoreUnweighted", EmitDefaultValue=false)]
        public float? TotalScoreUnweighted { get; private set; }
        
        
        
        /// <summary>
        /// The maximum unweighted total score for this question group
        /// </summary>
        /// <value>The maximum unweighted total score for this question group</value>
        [DataMember(Name="maxTotalScoreUnweighted", EmitDefaultValue=false)]
        public float? MaxTotalScoreUnweighted { get; private set; }
        
        
        
        /// <summary>
        /// The unweighted total score for the critical questions
        /// </summary>
        /// <value>The unweighted total score for the critical questions</value>
        [DataMember(Name="totalCriticalScoreUnweighted", EmitDefaultValue=false)]
        public float? TotalCriticalScoreUnweighted { get; private set; }
        
        
        
        /// <summary>
        /// The maximum unweighted total score for the critical questions
        /// </summary>
        /// <value>The maximum unweighted total score for the critical questions</value>
        [DataMember(Name="maxTotalCriticalScoreUnweighted", EmitDefaultValue=false)]
        public float? MaxTotalCriticalScoreUnweighted { get; private set; }
        
        
        
        /// <summary>
        /// The total unweighted score for the non-critical questions
        /// </summary>
        /// <value>The total unweighted score for the non-critical questions</value>
        [DataMember(Name="totalNonCriticalScoreUnweighted", EmitDefaultValue=false)]
        public float? TotalNonCriticalScoreUnweighted { get; private set; }
        
        
        
        /// <summary>
        /// The maximum unweighted total score for the non-critical questions
        /// </summary>
        /// <value>The maximum unweighted total score for the non-critical questions</value>
        [DataMember(Name="maxTotalNonCriticalScoreUnweighted", EmitDefaultValue=false)]
        public float? MaxTotalNonCriticalScoreUnweighted { get; private set; }
        
        
        
        /// <summary>
        /// The individual question scores
        /// </summary>
        /// <value>The individual question scores</value>
        [DataMember(Name="questionScores", EmitDefaultValue=false)]
        public List<AssessmentQuestionScore> QuestionScores { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssessmentQuestionGroupScore {\n");
            
            sb.Append("  QuestionGroupId: ").Append(QuestionGroupId).Append("\n");
            sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
            sb.Append("  MaxTotalScore: ").Append(MaxTotalScore).Append("\n");
            sb.Append("  MarkedNA: ").Append(MarkedNA).Append("\n");
            sb.Append("  TotalCriticalScore: ").Append(TotalCriticalScore).Append("\n");
            sb.Append("  MaxTotalCriticalScore: ").Append(MaxTotalCriticalScore).Append("\n");
            sb.Append("  TotalNonCriticalScore: ").Append(TotalNonCriticalScore).Append("\n");
            sb.Append("  MaxTotalNonCriticalScore: ").Append(MaxTotalNonCriticalScore).Append("\n");
            sb.Append("  TotalScoreUnweighted: ").Append(TotalScoreUnweighted).Append("\n");
            sb.Append("  MaxTotalScoreUnweighted: ").Append(MaxTotalScoreUnweighted).Append("\n");
            sb.Append("  TotalCriticalScoreUnweighted: ").Append(TotalCriticalScoreUnweighted).Append("\n");
            sb.Append("  MaxTotalCriticalScoreUnweighted: ").Append(MaxTotalCriticalScoreUnweighted).Append("\n");
            sb.Append("  TotalNonCriticalScoreUnweighted: ").Append(TotalNonCriticalScoreUnweighted).Append("\n");
            sb.Append("  MaxTotalNonCriticalScoreUnweighted: ").Append(MaxTotalNonCriticalScoreUnweighted).Append("\n");
            sb.Append("  QuestionScores: ").Append(QuestionScores).Append("\n");
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
            return this.Equals(obj as AssessmentQuestionGroupScore);
        }

        /// <summary>
        /// Returns true if AssessmentQuestionGroupScore instances are equal
        /// </summary>
        /// <param name="other">Instance of AssessmentQuestionGroupScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssessmentQuestionGroupScore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QuestionGroupId == other.QuestionGroupId ||
                    this.QuestionGroupId != null &&
                    this.QuestionGroupId.Equals(other.QuestionGroupId)
                ) &&
                (
                    this.TotalScore == other.TotalScore ||
                    this.TotalScore != null &&
                    this.TotalScore.Equals(other.TotalScore)
                ) &&
                (
                    this.MaxTotalScore == other.MaxTotalScore ||
                    this.MaxTotalScore != null &&
                    this.MaxTotalScore.Equals(other.MaxTotalScore)
                ) &&
                (
                    this.MarkedNA == other.MarkedNA ||
                    this.MarkedNA != null &&
                    this.MarkedNA.Equals(other.MarkedNA)
                ) &&
                (
                    this.TotalCriticalScore == other.TotalCriticalScore ||
                    this.TotalCriticalScore != null &&
                    this.TotalCriticalScore.Equals(other.TotalCriticalScore)
                ) &&
                (
                    this.MaxTotalCriticalScore == other.MaxTotalCriticalScore ||
                    this.MaxTotalCriticalScore != null &&
                    this.MaxTotalCriticalScore.Equals(other.MaxTotalCriticalScore)
                ) &&
                (
                    this.TotalNonCriticalScore == other.TotalNonCriticalScore ||
                    this.TotalNonCriticalScore != null &&
                    this.TotalNonCriticalScore.Equals(other.TotalNonCriticalScore)
                ) &&
                (
                    this.MaxTotalNonCriticalScore == other.MaxTotalNonCriticalScore ||
                    this.MaxTotalNonCriticalScore != null &&
                    this.MaxTotalNonCriticalScore.Equals(other.MaxTotalNonCriticalScore)
                ) &&
                (
                    this.TotalScoreUnweighted == other.TotalScoreUnweighted ||
                    this.TotalScoreUnweighted != null &&
                    this.TotalScoreUnweighted.Equals(other.TotalScoreUnweighted)
                ) &&
                (
                    this.MaxTotalScoreUnweighted == other.MaxTotalScoreUnweighted ||
                    this.MaxTotalScoreUnweighted != null &&
                    this.MaxTotalScoreUnweighted.Equals(other.MaxTotalScoreUnweighted)
                ) &&
                (
                    this.TotalCriticalScoreUnweighted == other.TotalCriticalScoreUnweighted ||
                    this.TotalCriticalScoreUnweighted != null &&
                    this.TotalCriticalScoreUnweighted.Equals(other.TotalCriticalScoreUnweighted)
                ) &&
                (
                    this.MaxTotalCriticalScoreUnweighted == other.MaxTotalCriticalScoreUnweighted ||
                    this.MaxTotalCriticalScoreUnweighted != null &&
                    this.MaxTotalCriticalScoreUnweighted.Equals(other.MaxTotalCriticalScoreUnweighted)
                ) &&
                (
                    this.TotalNonCriticalScoreUnweighted == other.TotalNonCriticalScoreUnweighted ||
                    this.TotalNonCriticalScoreUnweighted != null &&
                    this.TotalNonCriticalScoreUnweighted.Equals(other.TotalNonCriticalScoreUnweighted)
                ) &&
                (
                    this.MaxTotalNonCriticalScoreUnweighted == other.MaxTotalNonCriticalScoreUnweighted ||
                    this.MaxTotalNonCriticalScoreUnweighted != null &&
                    this.MaxTotalNonCriticalScoreUnweighted.Equals(other.MaxTotalNonCriticalScoreUnweighted)
                ) &&
                (
                    this.QuestionScores == other.QuestionScores ||
                    this.QuestionScores != null &&
                    this.QuestionScores.SequenceEqual(other.QuestionScores)
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
                
                if (this.QuestionGroupId != null)
                    hash = hash * 59 + this.QuestionGroupId.GetHashCode();
                
                if (this.TotalScore != null)
                    hash = hash * 59 + this.TotalScore.GetHashCode();
                
                if (this.MaxTotalScore != null)
                    hash = hash * 59 + this.MaxTotalScore.GetHashCode();
                
                if (this.MarkedNA != null)
                    hash = hash * 59 + this.MarkedNA.GetHashCode();
                
                if (this.TotalCriticalScore != null)
                    hash = hash * 59 + this.TotalCriticalScore.GetHashCode();
                
                if (this.MaxTotalCriticalScore != null)
                    hash = hash * 59 + this.MaxTotalCriticalScore.GetHashCode();
                
                if (this.TotalNonCriticalScore != null)
                    hash = hash * 59 + this.TotalNonCriticalScore.GetHashCode();
                
                if (this.MaxTotalNonCriticalScore != null)
                    hash = hash * 59 + this.MaxTotalNonCriticalScore.GetHashCode();
                
                if (this.TotalScoreUnweighted != null)
                    hash = hash * 59 + this.TotalScoreUnweighted.GetHashCode();
                
                if (this.MaxTotalScoreUnweighted != null)
                    hash = hash * 59 + this.MaxTotalScoreUnweighted.GetHashCode();
                
                if (this.TotalCriticalScoreUnweighted != null)
                    hash = hash * 59 + this.TotalCriticalScoreUnweighted.GetHashCode();
                
                if (this.MaxTotalCriticalScoreUnweighted != null)
                    hash = hash * 59 + this.MaxTotalCriticalScoreUnweighted.GetHashCode();
                
                if (this.TotalNonCriticalScoreUnweighted != null)
                    hash = hash * 59 + this.TotalNonCriticalScoreUnweighted.GetHashCode();
                
                if (this.MaxTotalNonCriticalScoreUnweighted != null)
                    hash = hash * 59 + this.MaxTotalNonCriticalScoreUnweighted.GetHashCode();
                
                if (this.QuestionScores != null)
                    hash = hash * 59 + this.QuestionScores.GetHashCode();
                
                return hash;
            }
        }
    }

}
