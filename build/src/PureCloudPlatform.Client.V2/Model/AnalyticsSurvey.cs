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
        /// <param name="EventTime">Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="QueueId">The ID of the associated queue.</param>
        /// <param name="SurveyCompletedDate">Completion datetime of the survey in ISO 8601 format.</param>
        /// <param name="SurveyFormContextId">Unique identifier for the survey form, regardless of version.</param>
        /// <param name="SurveyFormId">ID of the survey form used.</param>
        /// <param name="SurveyFormName">Name of the survey form used.</param>
        /// <param name="SurveyId">ID of the survey.</param>
        /// <param name="SurveyPromoterScore">Score of the survey used with NPS.</param>
        /// <param name="SurveyStatus">The status of the survey.</param>
        /// <param name="UserId">ID of the agent the survey was performed against.</param>
        /// <param name="OSurveyTotalScore">OSurveyTotalScore.</param>
        public AnalyticsSurvey(DateTime? EventTime = null, string QueueId = null, DateTime? SurveyCompletedDate = null, string SurveyFormContextId = null, string SurveyFormId = null, string SurveyFormName = null, string SurveyId = null, int? SurveyPromoterScore = null, string SurveyStatus = null, string UserId = null, long? OSurveyTotalScore = null)
        {
            this.EventTime = EventTime;
            this.QueueId = QueueId;
            this.SurveyCompletedDate = SurveyCompletedDate;
            this.SurveyFormContextId = SurveyFormContextId;
            this.SurveyFormId = SurveyFormId;
            this.SurveyFormName = SurveyFormName;
            this.SurveyId = SurveyId;
            this.SurveyPromoterScore = SurveyPromoterScore;
            this.SurveyStatus = SurveyStatus;
            this.UserId = UserId;
            this.OSurveyTotalScore = OSurveyTotalScore;
            
        }
        
        
        
        /// <summary>
        /// Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }
        
        
        
        /// <summary>
        /// The ID of the associated queue
        /// </summary>
        /// <value>The ID of the associated queue</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        /// <summary>
        /// Completion datetime of the survey in ISO 8601 format
        /// </summary>
        /// <value>Completion datetime of the survey in ISO 8601 format</value>
        [DataMember(Name="surveyCompletedDate", EmitDefaultValue=false)]
        public DateTime? SurveyCompletedDate { get; set; }
        
        
        
        /// <summary>
        /// Unique identifier for the survey form, regardless of version
        /// </summary>
        /// <value>Unique identifier for the survey form, regardless of version</value>
        [DataMember(Name="surveyFormContextId", EmitDefaultValue=false)]
        public string SurveyFormContextId { get; set; }
        
        
        
        /// <summary>
        /// ID of the survey form used
        /// </summary>
        /// <value>ID of the survey form used</value>
        [DataMember(Name="surveyFormId", EmitDefaultValue=false)]
        public string SurveyFormId { get; set; }
        
        
        
        /// <summary>
        /// Name of the survey form used
        /// </summary>
        /// <value>Name of the survey form used</value>
        [DataMember(Name="surveyFormName", EmitDefaultValue=false)]
        public string SurveyFormName { get; set; }
        
        
        
        /// <summary>
        /// ID of the survey
        /// </summary>
        /// <value>ID of the survey</value>
        [DataMember(Name="surveyId", EmitDefaultValue=false)]
        public string SurveyId { get; set; }
        
        
        
        /// <summary>
        /// Score of the survey used with NPS
        /// </summary>
        /// <value>Score of the survey used with NPS</value>
        [DataMember(Name="surveyPromoterScore", EmitDefaultValue=false)]
        public int? SurveyPromoterScore { get; set; }
        
        
        
        /// <summary>
        /// The status of the survey
        /// </summary>
        /// <value>The status of the survey</value>
        [DataMember(Name="surveyStatus", EmitDefaultValue=false)]
        public string SurveyStatus { get; set; }
        
        
        
        /// <summary>
        /// ID of the agent the survey was performed against
        /// </summary>
        /// <value>ID of the agent the survey was performed against</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
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
            
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  SurveyCompletedDate: ").Append(SurveyCompletedDate).Append("\n");
            sb.Append("  SurveyFormContextId: ").Append(SurveyFormContextId).Append("\n");
            sb.Append("  SurveyFormId: ").Append(SurveyFormId).Append("\n");
            sb.Append("  SurveyFormName: ").Append(SurveyFormName).Append("\n");
            sb.Append("  SurveyId: ").Append(SurveyId).Append("\n");
            sb.Append("  SurveyPromoterScore: ").Append(SurveyPromoterScore).Append("\n");
            sb.Append("  SurveyStatus: ").Append(SurveyStatus).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.SurveyCompletedDate == other.SurveyCompletedDate ||
                    this.SurveyCompletedDate != null &&
                    this.SurveyCompletedDate.Equals(other.SurveyCompletedDate)
                ) &&
                (
                    this.SurveyFormContextId == other.SurveyFormContextId ||
                    this.SurveyFormContextId != null &&
                    this.SurveyFormContextId.Equals(other.SurveyFormContextId)
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
                    this.SurveyId == other.SurveyId ||
                    this.SurveyId != null &&
                    this.SurveyId.Equals(other.SurveyId)
                ) &&
                (
                    this.SurveyPromoterScore == other.SurveyPromoterScore ||
                    this.SurveyPromoterScore != null &&
                    this.SurveyPromoterScore.Equals(other.SurveyPromoterScore)
                ) &&
                (
                    this.SurveyStatus == other.SurveyStatus ||
                    this.SurveyStatus != null &&
                    this.SurveyStatus.Equals(other.SurveyStatus)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.SurveyCompletedDate != null)
                    hash = hash * 59 + this.SurveyCompletedDate.GetHashCode();
                
                if (this.SurveyFormContextId != null)
                    hash = hash * 59 + this.SurveyFormContextId.GetHashCode();
                
                if (this.SurveyFormId != null)
                    hash = hash * 59 + this.SurveyFormId.GetHashCode();
                
                if (this.SurveyFormName != null)
                    hash = hash * 59 + this.SurveyFormName.GetHashCode();
                
                if (this.SurveyId != null)
                    hash = hash * 59 + this.SurveyId.GetHashCode();
                
                if (this.SurveyPromoterScore != null)
                    hash = hash * 59 + this.SurveyPromoterScore.GetHashCode();
                
                if (this.SurveyStatus != null)
                    hash = hash * 59 + this.SurveyStatus.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.OSurveyTotalScore != null)
                    hash = hash * 59 + this.OSurveyTotalScore.GetHashCode();
                
                return hash;
            }
        }
    }

}
