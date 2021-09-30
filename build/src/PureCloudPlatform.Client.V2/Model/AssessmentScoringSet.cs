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
    /// AssessmentScoringSet
    /// </summary>
    [DataContract]
    public partial class AssessmentScoringSet :  IEquatable<AssessmentScoringSet>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets FailureReasons
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FailureReasonsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Score for "Score"
            /// </summary>
            [EnumMember(Value = "Score")]
            Score,
            
            /// <summary>
            /// Enum Criticalscore for "CriticalScore"
            /// </summary>
            [EnumMember(Value = "CriticalScore")]
            Criticalscore,
            
            /// <summary>
            /// Enum Killquestion for "KillQuestion"
            /// </summary>
            [EnumMember(Value = "KillQuestion")]
            Killquestion
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentScoringSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssessmentScoringSet() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentScoringSet" /> class.
        /// </summary>
        /// <param name="QuestionGroupScores">The individual scores for each question group (required).</param>
        /// <param name="Comments">Comments provided for these answers..</param>
        /// <param name="AgentComments">Comments provided by agent..</param>
        public AssessmentScoringSet(List<AssessmentQuestionGroupScore> QuestionGroupScores = null, string Comments = null, string AgentComments = null)
        {
            this.QuestionGroupScores = QuestionGroupScores;
            this.Comments = Comments;
            this.AgentComments = AgentComments;
            
        }
        
        
        
        /// <summary>
        /// The total score of the answers
        /// </summary>
        /// <value>The total score of the answers</value>
        [DataMember(Name="totalScore", EmitDefaultValue=false)]
        public float? TotalScore { get; private set; }
        
        
        
        /// <summary>
        /// The total score for the critical questions
        /// </summary>
        /// <value>The total score for the critical questions</value>
        [DataMember(Name="totalCriticalScore", EmitDefaultValue=false)]
        public float? TotalCriticalScore { get; private set; }
        
        
        
        /// <summary>
        /// The total score for the non-critical questions
        /// </summary>
        /// <value>The total score for the non-critical questions</value>
        [DataMember(Name="totalNonCriticalScore", EmitDefaultValue=false)]
        public float? TotalNonCriticalScore { get; private set; }
        
        
        
        /// <summary>
        /// The individual scores for each question group
        /// </summary>
        /// <value>The individual scores for each question group</value>
        [DataMember(Name="questionGroupScores", EmitDefaultValue=false)]
        public List<AssessmentQuestionGroupScore> QuestionGroupScores { get; set; }
        
        
        
        /// <summary>
        /// If the assessment was not passed, the reasons for failure.
        /// </summary>
        /// <value>If the assessment was not passed, the reasons for failure.</value>
        [DataMember(Name="failureReasons", EmitDefaultValue=false)]
        public List<FailureReasonsEnum> FailureReasons { get; private set; }
        
        
        
        /// <summary>
        /// Comments provided for these answers.
        /// </summary>
        /// <value>Comments provided for these answers.</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }
        
        
        
        /// <summary>
        /// Comments provided by agent.
        /// </summary>
        /// <value>Comments provided by agent.</value>
        [DataMember(Name="agentComments", EmitDefaultValue=false)]
        public string AgentComments { get; set; }
        
        
        
        /// <summary>
        /// True if the assessment was passed
        /// </summary>
        /// <value>True if the assessment was passed</value>
        [DataMember(Name="isPassed", EmitDefaultValue=false)]
        public bool? IsPassed { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssessmentScoringSet {\n");
            
            sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
            sb.Append("  TotalCriticalScore: ").Append(TotalCriticalScore).Append("\n");
            sb.Append("  TotalNonCriticalScore: ").Append(TotalNonCriticalScore).Append("\n");
            sb.Append("  QuestionGroupScores: ").Append(QuestionGroupScores).Append("\n");
            sb.Append("  FailureReasons: ").Append(FailureReasons).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  AgentComments: ").Append(AgentComments).Append("\n");
            sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
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
            return this.Equals(obj as AssessmentScoringSet);
        }

        /// <summary>
        /// Returns true if AssessmentScoringSet instances are equal
        /// </summary>
        /// <param name="other">Instance of AssessmentScoringSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssessmentScoringSet other)
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
                    this.FailureReasons == other.FailureReasons ||
                    this.FailureReasons != null &&
                    this.FailureReasons.SequenceEqual(other.FailureReasons)
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
                    this.IsPassed == other.IsPassed ||
                    this.IsPassed != null &&
                    this.IsPassed.Equals(other.IsPassed)
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
                
                if (this.FailureReasons != null)
                    hash = hash * 59 + this.FailureReasons.GetHashCode();
                
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                
                if (this.AgentComments != null)
                    hash = hash * 59 + this.AgentComments.GetHashCode();
                
                if (this.IsPassed != null)
                    hash = hash * 59 + this.IsPassed.GetHashCode();
                
                return hash;
            }
        }
    }

}
