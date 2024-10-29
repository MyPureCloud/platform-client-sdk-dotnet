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
    /// GamificationScorecardChangeTopicEvaluationDetail
    /// </summary>
    [DataContract]
    public partial class GamificationScorecardChangeTopicEvaluationDetail :  IEquatable<GamificationScorecardChangeTopicEvaluationDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationScorecardChangeTopicEvaluationDetail" /> class.
        /// </summary>
        /// <param name="EvaluationId">EvaluationId.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="ConversationDate">ConversationDate.</param>
        /// <param name="FormName">FormName.</param>
        /// <param name="Points">Points.</param>
        /// <param name="MaxPoints">MaxPoints.</param>
        /// <param name="EvaluationScore">EvaluationScore.</param>
        /// <param name="EvaluationScoreDouble">EvaluationScoreDouble.</param>
        /// <param name="MediaTypes">MediaTypes.</param>
        public GamificationScorecardChangeTopicEvaluationDetail(Guid? EvaluationId = null, Guid? ConversationId = null, string ConversationDate = null, string FormName = null, int? Points = null, int? MaxPoints = null, int? EvaluationScore = null, double? EvaluationScoreDouble = null, List<string> MediaTypes = null)
        {
            this.EvaluationId = EvaluationId;
            this.ConversationId = ConversationId;
            this.ConversationDate = ConversationDate;
            this.FormName = FormName;
            this.Points = Points;
            this.MaxPoints = MaxPoints;
            this.EvaluationScore = EvaluationScore;
            this.EvaluationScoreDouble = EvaluationScoreDouble;
            this.MediaTypes = MediaTypes;
            
        }
        


        /// <summary>
        /// Gets or Sets EvaluationId
        /// </summary>
        [DataMember(Name="evaluationId", EmitDefaultValue=false)]
        public Guid? EvaluationId { get; set; }



        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public Guid? ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets ConversationDate
        /// </summary>
        [DataMember(Name="conversationDate", EmitDefaultValue=false)]
        public string ConversationDate { get; set; }



        /// <summary>
        /// Gets or Sets FormName
        /// </summary>
        [DataMember(Name="formName", EmitDefaultValue=false)]
        public string FormName { get; set; }



        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; set; }



        /// <summary>
        /// Gets or Sets MaxPoints
        /// </summary>
        [DataMember(Name="maxPoints", EmitDefaultValue=false)]
        public int? MaxPoints { get; set; }



        /// <summary>
        /// Gets or Sets EvaluationScore
        /// </summary>
        [DataMember(Name="evaluationScore", EmitDefaultValue=false)]
        public int? EvaluationScore { get; set; }



        /// <summary>
        /// Gets or Sets EvaluationScoreDouble
        /// </summary>
        [DataMember(Name="evaluationScoreDouble", EmitDefaultValue=false)]
        public double? EvaluationScoreDouble { get; set; }



        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<string> MediaTypes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GamificationScorecardChangeTopicEvaluationDetail {\n");

            sb.Append("  EvaluationId: ").Append(EvaluationId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ConversationDate: ").Append(ConversationDate).Append("\n");
            sb.Append("  FormName: ").Append(FormName).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
            sb.Append("  EvaluationScore: ").Append(EvaluationScore).Append("\n");
            sb.Append("  EvaluationScoreDouble: ").Append(EvaluationScoreDouble).Append("\n");
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
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
            return this.Equals(obj as GamificationScorecardChangeTopicEvaluationDetail);
        }

        /// <summary>
        /// Returns true if GamificationScorecardChangeTopicEvaluationDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of GamificationScorecardChangeTopicEvaluationDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GamificationScorecardChangeTopicEvaluationDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EvaluationId == other.EvaluationId ||
                    this.EvaluationId != null &&
                    this.EvaluationId.Equals(other.EvaluationId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.ConversationDate == other.ConversationDate ||
                    this.ConversationDate != null &&
                    this.ConversationDate.Equals(other.ConversationDate)
                ) &&
                (
                    this.FormName == other.FormName ||
                    this.FormName != null &&
                    this.FormName.Equals(other.FormName)
                ) &&
                (
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.Equals(other.Points)
                ) &&
                (
                    this.MaxPoints == other.MaxPoints ||
                    this.MaxPoints != null &&
                    this.MaxPoints.Equals(other.MaxPoints)
                ) &&
                (
                    this.EvaluationScore == other.EvaluationScore ||
                    this.EvaluationScore != null &&
                    this.EvaluationScore.Equals(other.EvaluationScore)
                ) &&
                (
                    this.EvaluationScoreDouble == other.EvaluationScoreDouble ||
                    this.EvaluationScoreDouble != null &&
                    this.EvaluationScoreDouble.Equals(other.EvaluationScoreDouble)
                ) &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
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
                if (this.EvaluationId != null)
                    hash = hash * 59 + this.EvaluationId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.ConversationDate != null)
                    hash = hash * 59 + this.ConversationDate.GetHashCode();

                if (this.FormName != null)
                    hash = hash * 59 + this.FormName.GetHashCode();

                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();

                if (this.MaxPoints != null)
                    hash = hash * 59 + this.MaxPoints.GetHashCode();

                if (this.EvaluationScore != null)
                    hash = hash * 59 + this.EvaluationScore.GetHashCode();

                if (this.EvaluationScoreDouble != null)
                    hash = hash * 59 + this.EvaluationScoreDouble.GetHashCode();

                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();

                return hash;
            }
        }
    }

}
