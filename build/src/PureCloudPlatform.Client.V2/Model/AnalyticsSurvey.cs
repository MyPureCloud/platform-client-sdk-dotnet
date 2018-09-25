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
    /// AnalyticsSurvey
    /// </summary>
    [DataContract]
    public partial class AnalyticsSurvey :  IEquatable<AnalyticsSurvey>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsSurvey" /> class.
        /// </summary>
        /// <param name="SurveyId">Unique identifier for the survey.</param>
        /// <param name="SurveyFormId">Unique identifier for the survey form.</param>
        /// <param name="SurveyFormContextId">Unique identifier for the survey form, regardless of version.</param>
        /// <param name="UserId">A unique identifier of the PureCloud user.</param>
        /// <param name="QueueId">Unique identifier for the queue the conversation was on.</param>
        /// <param name="Status">Survey status.</param>
        /// <param name="GetoSurveyTotalScore">Creation date of survey.</param>
        /// <param name="SurveyPromoterScore">NPS score of the survey.</param>
        /// <param name="SurveyCompletedTime">Completion time of the survey, in ms since the epoch, 1970-01-01T00:00:00.000Z.</param>
        /// <param name="MediaTypes">Media types associated with the conversation.</param>
        /// <param name="LanguageIds">Language IDs associated with the conversation.</param>
        /// <param name="SkillIds">Skill IDs associated with the conversation.</param>
        public AnalyticsSurvey(string SurveyId = null, string SurveyFormId = null, string SurveyFormContextId = null, string UserId = null, string QueueId = null, string Status = null, long? GetoSurveyTotalScore = null, int? SurveyPromoterScore = null, long? SurveyCompletedTime = null, List<string> MediaTypes = null, List<string> LanguageIds = null, List<string> SkillIds = null)
        {
            this.SurveyId = SurveyId;
            this.SurveyFormId = SurveyFormId;
            this.SurveyFormContextId = SurveyFormContextId;
            this.UserId = UserId;
            this.QueueId = QueueId;
            this.Status = Status;
            this.GetoSurveyTotalScore = GetoSurveyTotalScore;
            this.SurveyPromoterScore = SurveyPromoterScore;
            this.SurveyCompletedTime = SurveyCompletedTime;
            this.MediaTypes = MediaTypes;
            this.LanguageIds = LanguageIds;
            this.SkillIds = SkillIds;
            
        }
        
        
        
        /// <summary>
        /// Unique identifier for the survey
        /// </summary>
        /// <value>Unique identifier for the survey</value>
        [DataMember(Name="surveyId", EmitDefaultValue=false)]
        public string SurveyId { get; set; }
        
        
        
        /// <summary>
        /// Unique identifier for the survey form
        /// </summary>
        /// <value>Unique identifier for the survey form</value>
        [DataMember(Name="surveyFormId", EmitDefaultValue=false)]
        public string SurveyFormId { get; set; }
        
        
        
        /// <summary>
        /// Unique identifier for the survey form, regardless of version
        /// </summary>
        /// <value>Unique identifier for the survey form, regardless of version</value>
        [DataMember(Name="surveyFormContextId", EmitDefaultValue=false)]
        public string SurveyFormContextId { get; set; }
        
        
        
        /// <summary>
        /// A unique identifier of the PureCloud user
        /// </summary>
        /// <value>A unique identifier of the PureCloud user</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        /// <summary>
        /// Unique identifier for the queue the conversation was on
        /// </summary>
        /// <value>Unique identifier for the queue the conversation was on</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        /// <summary>
        /// Survey status
        /// </summary>
        /// <value>Survey status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        
        
        
        /// <summary>
        /// Creation date of survey
        /// </summary>
        /// <value>Creation date of survey</value>
        [DataMember(Name="getoSurveyTotalScore", EmitDefaultValue=false)]
        public long? GetoSurveyTotalScore { get; set; }
        
        
        
        /// <summary>
        /// NPS score of the survey
        /// </summary>
        /// <value>NPS score of the survey</value>
        [DataMember(Name="surveyPromoterScore", EmitDefaultValue=false)]
        public int? SurveyPromoterScore { get; set; }
        
        
        
        /// <summary>
        /// Completion time of the survey, in ms since the epoch, 1970-01-01T00:00:00.000Z
        /// </summary>
        /// <value>Completion time of the survey, in ms since the epoch, 1970-01-01T00:00:00.000Z</value>
        [DataMember(Name="surveyCompletedTime", EmitDefaultValue=false)]
        public long? SurveyCompletedTime { get; set; }
        
        
        
        /// <summary>
        /// Media types associated with the conversation
        /// </summary>
        /// <value>Media types associated with the conversation</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<string> MediaTypes { get; set; }
        
        
        
        /// <summary>
        /// Language IDs associated with the conversation
        /// </summary>
        /// <value>Language IDs associated with the conversation</value>
        [DataMember(Name="languageIds", EmitDefaultValue=false)]
        public List<string> LanguageIds { get; set; }
        
        
        
        /// <summary>
        /// Skill IDs associated with the conversation
        /// </summary>
        /// <value>Skill IDs associated with the conversation</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsSurvey {\n");
            
            sb.Append("  SurveyId: ").Append(SurveyId).Append("\n");
            sb.Append("  SurveyFormId: ").Append(SurveyFormId).Append("\n");
            sb.Append("  SurveyFormContextId: ").Append(SurveyFormContextId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  GetoSurveyTotalScore: ").Append(GetoSurveyTotalScore).Append("\n");
            sb.Append("  SurveyPromoterScore: ").Append(SurveyPromoterScore).Append("\n");
            sb.Append("  SurveyCompletedTime: ").Append(SurveyCompletedTime).Append("\n");
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  LanguageIds: ").Append(LanguageIds).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
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
            return this.Equals(obj as AnalyticsSurvey);
        }

        /// <summary>
        /// Returns true if AnalyticsSurvey instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsSurvey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsSurvey other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SurveyId == other.SurveyId ||
                    this.SurveyId != null &&
                    this.SurveyId.Equals(other.SurveyId)
                ) &&
                (
                    this.SurveyFormId == other.SurveyFormId ||
                    this.SurveyFormId != null &&
                    this.SurveyFormId.Equals(other.SurveyFormId)
                ) &&
                (
                    this.SurveyFormContextId == other.SurveyFormContextId ||
                    this.SurveyFormContextId != null &&
                    this.SurveyFormContextId.Equals(other.SurveyFormContextId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.GetoSurveyTotalScore == other.GetoSurveyTotalScore ||
                    this.GetoSurveyTotalScore != null &&
                    this.GetoSurveyTotalScore.Equals(other.GetoSurveyTotalScore)
                ) &&
                (
                    this.SurveyPromoterScore == other.SurveyPromoterScore ||
                    this.SurveyPromoterScore != null &&
                    this.SurveyPromoterScore.Equals(other.SurveyPromoterScore)
                ) &&
                (
                    this.SurveyCompletedTime == other.SurveyCompletedTime ||
                    this.SurveyCompletedTime != null &&
                    this.SurveyCompletedTime.Equals(other.SurveyCompletedTime)
                ) &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) &&
                (
                    this.LanguageIds == other.LanguageIds ||
                    this.LanguageIds != null &&
                    this.LanguageIds.SequenceEqual(other.LanguageIds)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
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
                
                if (this.SurveyId != null)
                    hash = hash * 59 + this.SurveyId.GetHashCode();
                
                if (this.SurveyFormId != null)
                    hash = hash * 59 + this.SurveyFormId.GetHashCode();
                
                if (this.SurveyFormContextId != null)
                    hash = hash * 59 + this.SurveyFormContextId.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.GetoSurveyTotalScore != null)
                    hash = hash * 59 + this.GetoSurveyTotalScore.GetHashCode();
                
                if (this.SurveyPromoterScore != null)
                    hash = hash * 59 + this.SurveyPromoterScore.GetHashCode();
                
                if (this.SurveyCompletedTime != null)
                    hash = hash * 59 + this.SurveyCompletedTime.GetHashCode();
                
                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();
                
                if (this.LanguageIds != null)
                    hash = hash * 59 + this.LanguageIds.GetHashCode();
                
                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
