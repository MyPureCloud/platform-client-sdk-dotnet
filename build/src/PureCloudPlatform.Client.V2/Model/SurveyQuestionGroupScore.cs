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
    /// SurveyQuestionGroupScore
    /// </summary>
    [DataContract]
    public partial class SurveyQuestionGroupScore :  IEquatable<SurveyQuestionGroupScore>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyQuestionGroupScore" /> class.
        /// </summary>
        /// <param name="QuestionGroupId">QuestionGroupId.</param>
        /// <param name="TotalScore">Score of all questions in the group.</param>
        /// <param name="MaxTotalScore">Maximum possible score of all questions in the group.</param>
        /// <param name="MarkedNA">True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system.</param>
        /// <param name="SystemMarkedNA">If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false..</param>
        /// <param name="QuestionScores">QuestionScores.</param>
        public SurveyQuestionGroupScore(string QuestionGroupId = null, float? TotalScore = null, float? MaxTotalScore = null, bool? MarkedNA = null, bool? SystemMarkedNA = null, List<SurveyQuestionScore> QuestionScores = null)
        {
            this.QuestionGroupId = QuestionGroupId;
            this.TotalScore = TotalScore;
            this.MaxTotalScore = MaxTotalScore;
            this.MarkedNA = MarkedNA;
            this.SystemMarkedNA = SystemMarkedNA;
            this.QuestionScores = QuestionScores;
            
        }
        


        /// <summary>
        /// Gets or Sets QuestionGroupId
        /// </summary>
        [DataMember(Name="questionGroupId", EmitDefaultValue=false)]
        public string QuestionGroupId { get; set; }



        /// <summary>
        /// Score of all questions in the group
        /// </summary>
        /// <value>Score of all questions in the group</value>
        [DataMember(Name="totalScore", EmitDefaultValue=false)]
        public float? TotalScore { get; set; }



        /// <summary>
        /// Maximum possible score of all questions in the group
        /// </summary>
        /// <value>Maximum possible score of all questions in the group</value>
        [DataMember(Name="maxTotalScore", EmitDefaultValue=false)]
        public float? MaxTotalScore { get; set; }



        /// <summary>
        /// True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system
        /// </summary>
        /// <value>True when the evaluation is submitted with a question group that does not have any answers. Only allowed when naEnabled is true or if set by the system</value>
        [DataMember(Name="markedNA", EmitDefaultValue=false)]
        public bool? MarkedNA { get; set; }



        /// <summary>
        /// If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.
        /// </summary>
        /// <value>If markedNA is true, systemMarkedNA indicates whether it was marked by a user or by the system due to visibility conditions. Always false if markedNA is false.</value>
        [DataMember(Name="systemMarkedNA", EmitDefaultValue=false)]
        public bool? SystemMarkedNA { get; set; }



        /// <summary>
        /// Gets or Sets QuestionScores
        /// </summary>
        [DataMember(Name="questionScores", EmitDefaultValue=false)]
        public List<SurveyQuestionScore> QuestionScores { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SurveyQuestionGroupScore {\n");

            sb.Append("  QuestionGroupId: ").Append(QuestionGroupId).Append("\n");
            sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
            sb.Append("  MaxTotalScore: ").Append(MaxTotalScore).Append("\n");
            sb.Append("  MarkedNA: ").Append(MarkedNA).Append("\n");
            sb.Append("  SystemMarkedNA: ").Append(SystemMarkedNA).Append("\n");
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
            return this.Equals(obj as SurveyQuestionGroupScore);
        }

        /// <summary>
        /// Returns true if SurveyQuestionGroupScore instances are equal
        /// </summary>
        /// <param name="other">Instance of SurveyQuestionGroupScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurveyQuestionGroupScore other)
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
                    this.SystemMarkedNA == other.SystemMarkedNA ||
                    this.SystemMarkedNA != null &&
                    this.SystemMarkedNA.Equals(other.SystemMarkedNA)
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

                if (this.SystemMarkedNA != null)
                    hash = hash * 59 + this.SystemMarkedNA.GetHashCode();

                if (this.QuestionScores != null)
                    hash = hash * 59 + this.QuestionScores.GetHashCode();

                return hash;
            }
        }
    }

}
