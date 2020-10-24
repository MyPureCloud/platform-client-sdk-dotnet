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
        /// <param name="SurveyFormName">Name of the survey form.</param>
        /// <param name="SurveyFormContextId">Unique identifier for the survey form, regardless of version.</param>
        /// <param name="EventTime">Specifies when a survey occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="UserId">A unique identifier of the PureCloud user.</param>
        /// <param name="QueueId">Unique identifier for the queue the conversation was on.</param>
        /// <param name="SurveyStatus">Survey status.</param>
        /// <param name="SurveyPromoterScore">Promoter score of the survey.</param>
        /// <param name="SurveyCompletedDate">Completion date/time of the survey. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="OSurveyTotalScore">OSurveyTotalScore.</param>
        public AnalyticsSurvey(string SurveyId = null, string SurveyFormId = null, string SurveyFormName = null, string SurveyFormContextId = null, DateTime? EventTime = null, string UserId = null, string QueueId = null, string SurveyStatus = null, int? SurveyPromoterScore = null, DateTime? SurveyCompletedDate = null, long? OSurveyTotalScore = null)
        {
            this.SurveyId = SurveyId;
            this.SurveyFormId = SurveyFormId;
            this.SurveyFormName = SurveyFormName;
            this.SurveyFormContextId = SurveyFormContextId;
            this.EventTime = EventTime;
            this.UserId = UserId;
            this.QueueId = QueueId;
            this.SurveyStatus = SurveyStatus;
            this.SurveyPromoterScore = SurveyPromoterScore;
            this.SurveyCompletedDate = SurveyCompletedDate;
            this.OSurveyTotalScore = OSurveyTotalScore;
            
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
        /// Name of the survey form
        /// </summary>
        /// <value>Name of the survey form</value>
        [DataMember(Name="surveyFormName", EmitDefaultValue=false)]
        public string SurveyFormName { get; set; }
        
        
        
        /// <summary>
        /// Unique identifier for the survey form, regardless of version
        /// </summary>
        /// <value>Unique identifier for the survey form, regardless of version</value>
        [DataMember(Name="surveyFormContextId", EmitDefaultValue=false)]
        public string SurveyFormContextId { get; set; }
        
        
        
        /// <summary>
        /// Specifies when a survey occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Specifies when a survey occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }
        
        
        
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
        [DataMember(Name="surveyStatus", EmitDefaultValue=false)]
        public string SurveyStatus { get; set; }
        
        
        
        /// <summary>
        /// Promoter score of the survey
        /// </summary>
        /// <value>Promoter score of the survey</value>
        [DataMember(Name="surveyPromoterScore", EmitDefaultValue=false)]
        public int? SurveyPromoterScore { get; set; }
        
        
        
        /// <summary>
        /// Completion date/time of the survey. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Completion date/time of the survey. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="surveyCompletedDate", EmitDefaultValue=false)]
        public DateTime? SurveyCompletedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OSurveyTotalScore
        /// </summary>
        [DataMember(Name="oSurveyTotalScore", EmitDefaultValue=false)]
        public long? OSurveyTotalScore { get; set; }
        
        
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
            sb.Append("  SurveyFormName: ").Append(SurveyFormName).Append("\n");
            sb.Append("  SurveyFormContextId: ").Append(SurveyFormContextId).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  SurveyStatus: ").Append(SurveyStatus).Append("\n");
            sb.Append("  SurveyPromoterScore: ").Append(SurveyPromoterScore).Append("\n");
            sb.Append("  SurveyCompletedDate: ").Append(SurveyCompletedDate).Append("\n");
            sb.Append("  OSurveyTotalScore: ").Append(OSurveyTotalScore).Append("\n");
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
                    this.SurveyFormName == other.SurveyFormName ||
                    this.SurveyFormName != null &&
                    this.SurveyFormName.Equals(other.SurveyFormName)
                ) &&
                (
                    this.SurveyFormContextId == other.SurveyFormContextId ||
                    this.SurveyFormContextId != null &&
                    this.SurveyFormContextId.Equals(other.SurveyFormContextId)
                ) &&
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
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
                    this.SurveyStatus == other.SurveyStatus ||
                    this.SurveyStatus != null &&
                    this.SurveyStatus.Equals(other.SurveyStatus)
                ) &&
                (
                    this.SurveyPromoterScore == other.SurveyPromoterScore ||
                    this.SurveyPromoterScore != null &&
                    this.SurveyPromoterScore.Equals(other.SurveyPromoterScore)
                ) &&
                (
                    this.SurveyCompletedDate == other.SurveyCompletedDate ||
                    this.SurveyCompletedDate != null &&
                    this.SurveyCompletedDate.Equals(other.SurveyCompletedDate)
                ) &&
                (
                    this.OSurveyTotalScore == other.OSurveyTotalScore ||
                    this.OSurveyTotalScore != null &&
                    this.OSurveyTotalScore.Equals(other.OSurveyTotalScore)
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
                
                if (this.SurveyFormName != null)
                    hash = hash * 59 + this.SurveyFormName.GetHashCode();
                
                if (this.SurveyFormContextId != null)
                    hash = hash * 59 + this.SurveyFormContextId.GetHashCode();
                
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.SurveyStatus != null)
                    hash = hash * 59 + this.SurveyStatus.GetHashCode();
                
                if (this.SurveyPromoterScore != null)
                    hash = hash * 59 + this.SurveyPromoterScore.GetHashCode();
                
                if (this.SurveyCompletedDate != null)
                    hash = hash * 59 + this.SurveyCompletedDate.GetHashCode();
                
                if (this.OSurveyTotalScore != null)
                    hash = hash * 59 + this.OSurveyTotalScore.GetHashCode();
                
                return hash;
            }
        }
    }

}
