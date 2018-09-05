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
        /// <param name="ParticipantId">Unique identifier of participant.</param>
        /// <param name="ExternalContactId">External contact id.</param>
        /// <param name="CustomerAddress">Customer address.</param>
        /// <param name="UserId">A unique identifier of the PureCloud user.</param>
        /// <param name="QueueId">Unique identifier for the queue the conversation was on.</param>
        /// <param name="Status">Survey status.</param>
        /// <param name="CreatedDate">Creation date of survey. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="GetoSurveyTotalScore">The total score for the survey.</param>
        public AnalyticsSurvey(string SurveyId = null, string SurveyFormId = null, string SurveyFormContextId = null, string ParticipantId = null, string ExternalContactId = null, string CustomerAddress = null, string UserId = null, string QueueId = null, string Status = null, DateTime? CreatedDate = null, long? GetoSurveyTotalScore = null)
        {
            this.SurveyId = SurveyId;
            this.SurveyFormId = SurveyFormId;
            this.SurveyFormContextId = SurveyFormContextId;
            this.ParticipantId = ParticipantId;
            this.ExternalContactId = ExternalContactId;
            this.CustomerAddress = CustomerAddress;
            this.UserId = UserId;
            this.QueueId = QueueId;
            this.Status = Status;
            this.CreatedDate = CreatedDate;
            this.GetoSurveyTotalScore = GetoSurveyTotalScore;
            
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
        /// Unique identifier of participant
        /// </summary>
        /// <value>Unique identifier of participant</value>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }
        
        
        
        /// <summary>
        /// External contact id
        /// </summary>
        /// <value>External contact id</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }
        
        
        
        /// <summary>
        /// Customer address
        /// </summary>
        /// <value>Customer address</value>
        [DataMember(Name="customerAddress", EmitDefaultValue=false)]
        public string CustomerAddress { get; set; }
        
        
        
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
        /// Creation date of survey. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Creation date of survey. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        
        /// <summary>
        /// The total score for the survey
        /// </summary>
        /// <value>The total score for the survey</value>
        [DataMember(Name="getoSurveyTotalScore", EmitDefaultValue=false)]
        public long? GetoSurveyTotalScore { get; set; }
        
        
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
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  CustomerAddress: ").Append(CustomerAddress).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  GetoSurveyTotalScore: ").Append(GetoSurveyTotalScore).Append("\n");
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
                    this.ParticipantId == other.ParticipantId ||
                    this.ParticipantId != null &&
                    this.ParticipantId.Equals(other.ParticipantId)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.CustomerAddress == other.CustomerAddress ||
                    this.CustomerAddress != null &&
                    this.CustomerAddress.Equals(other.CustomerAddress)
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
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.GetoSurveyTotalScore == other.GetoSurveyTotalScore ||
                    this.GetoSurveyTotalScore != null &&
                    this.GetoSurveyTotalScore.Equals(other.GetoSurveyTotalScore)
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
                
                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();
                
                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();
                
                if (this.CustomerAddress != null)
                    hash = hash * 59 + this.CustomerAddress.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.GetoSurveyTotalScore != null)
                    hash = hash * 59 + this.GetoSurveyTotalScore.GetHashCode();
                
                return hash;
            }
        }
    }

}
