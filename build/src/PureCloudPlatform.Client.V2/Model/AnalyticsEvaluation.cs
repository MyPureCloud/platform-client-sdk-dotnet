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
    /// AnalyticsEvaluation
    /// </summary>
    [DataContract]
    public partial class AnalyticsEvaluation :  IEquatable<AnalyticsEvaluation>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsEvaluation" /> class.
        /// </summary>
        /// <param name="EvaluationId">Unique identifier for the evaluation.</param>
        /// <param name="EvaluatorId">A unique identifier of the PureCloud user who evaluated the interaction.</param>
        /// <param name="UserId">Unique identifier for the user being evaluated.</param>
        /// <param name="EventTime">Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="QueueId">Unique identifier for the queue the conversation was on.</param>
        /// <param name="FormId">Unique identifier for the form used to evaluate the conversation/agent.</param>
        /// <param name="ContextId">A unique identifier for an evaluation form, regardless of version.</param>
        /// <param name="FormName">Name of the evaluation form.</param>
        /// <param name="CalibrationId">The calibration id used for the purpose of training evaluators.</param>
        /// <param name="Rescored">Whether this evaluation has ever been rescored.</param>
        /// <param name="Deleted">Whether this evaluation has been deleted.</param>
        /// <param name="OTotalScore">OTotalScore.</param>
        /// <param name="OTotalCriticalScore">OTotalCriticalScore.</param>
        public AnalyticsEvaluation(string EvaluationId = null, string EvaluatorId = null, string UserId = null, DateTime? EventTime = null, string QueueId = null, string FormId = null, string ContextId = null, string FormName = null, string CalibrationId = null, bool? Rescored = null, bool? Deleted = null, long? OTotalScore = null, long? OTotalCriticalScore = null)
        {
            this.EvaluationId = EvaluationId;
            this.EvaluatorId = EvaluatorId;
            this.UserId = UserId;
            this.EventTime = EventTime;
            this.QueueId = QueueId;
            this.FormId = FormId;
            this.ContextId = ContextId;
            this.FormName = FormName;
            this.CalibrationId = CalibrationId;
            this.Rescored = Rescored;
            this.Deleted = Deleted;
            this.OTotalScore = OTotalScore;
            this.OTotalCriticalScore = OTotalCriticalScore;
            
        }
        
        
        
        /// <summary>
        /// Unique identifier for the evaluation
        /// </summary>
        /// <value>Unique identifier for the evaluation</value>
        [DataMember(Name="evaluationId", EmitDefaultValue=false)]
        public string EvaluationId { get; set; }
        
        
        
        /// <summary>
        /// A unique identifier of the PureCloud user who evaluated the interaction
        /// </summary>
        /// <value>A unique identifier of the PureCloud user who evaluated the interaction</value>
        [DataMember(Name="evaluatorId", EmitDefaultValue=false)]
        public string EvaluatorId { get; set; }
        
        
        
        /// <summary>
        /// Unique identifier for the user being evaluated
        /// </summary>
        /// <value>Unique identifier for the user being evaluated</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        /// <summary>
        /// Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }
        
        
        
        /// <summary>
        /// Unique identifier for the queue the conversation was on
        /// </summary>
        /// <value>Unique identifier for the queue the conversation was on</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        /// <summary>
        /// Unique identifier for the form used to evaluate the conversation/agent
        /// </summary>
        /// <value>Unique identifier for the form used to evaluate the conversation/agent</value>
        [DataMember(Name="formId", EmitDefaultValue=false)]
        public string FormId { get; set; }
        
        
        
        /// <summary>
        /// A unique identifier for an evaluation form, regardless of version
        /// </summary>
        /// <value>A unique identifier for an evaluation form, regardless of version</value>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }
        
        
        
        /// <summary>
        /// Name of the evaluation form
        /// </summary>
        /// <value>Name of the evaluation form</value>
        [DataMember(Name="formName", EmitDefaultValue=false)]
        public string FormName { get; set; }
        
        
        
        /// <summary>
        /// The calibration id used for the purpose of training evaluators
        /// </summary>
        /// <value>The calibration id used for the purpose of training evaluators</value>
        [DataMember(Name="calibrationId", EmitDefaultValue=false)]
        public string CalibrationId { get; set; }
        
        
        
        /// <summary>
        /// Whether this evaluation has ever been rescored
        /// </summary>
        /// <value>Whether this evaluation has ever been rescored</value>
        [DataMember(Name="rescored", EmitDefaultValue=false)]
        public bool? Rescored { get; set; }
        
        
        
        /// <summary>
        /// Whether this evaluation has been deleted
        /// </summary>
        /// <value>Whether this evaluation has been deleted</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OTotalScore
        /// </summary>
        [DataMember(Name="oTotalScore", EmitDefaultValue=false)]
        public long? OTotalScore { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OTotalCriticalScore
        /// </summary>
        [DataMember(Name="oTotalCriticalScore", EmitDefaultValue=false)]
        public long? OTotalCriticalScore { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsEvaluation {\n");
            
            sb.Append("  EvaluationId: ").Append(EvaluationId).Append("\n");
            sb.Append("  EvaluatorId: ").Append(EvaluatorId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  FormName: ").Append(FormName).Append("\n");
            sb.Append("  CalibrationId: ").Append(CalibrationId).Append("\n");
            sb.Append("  Rescored: ").Append(Rescored).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  OTotalScore: ").Append(OTotalScore).Append("\n");
            sb.Append("  OTotalCriticalScore: ").Append(OTotalCriticalScore).Append("\n");
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
            return this.Equals(obj as AnalyticsEvaluation);
        }

        /// <summary>
        /// Returns true if AnalyticsEvaluation instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsEvaluation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsEvaluation other)
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
                    this.EvaluatorId == other.EvaluatorId ||
                    this.EvaluatorId != null &&
                    this.EvaluatorId.Equals(other.EvaluatorId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
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
                    this.FormId == other.FormId ||
                    this.FormId != null &&
                    this.FormId.Equals(other.FormId)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) &&
                (
                    this.FormName == other.FormName ||
                    this.FormName != null &&
                    this.FormName.Equals(other.FormName)
                ) &&
                (
                    this.CalibrationId == other.CalibrationId ||
                    this.CalibrationId != null &&
                    this.CalibrationId.Equals(other.CalibrationId)
                ) &&
                (
                    this.Rescored == other.Rescored ||
                    this.Rescored != null &&
                    this.Rescored.Equals(other.Rescored)
                ) &&
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) &&
                (
                    this.OTotalScore == other.OTotalScore ||
                    this.OTotalScore != null &&
                    this.OTotalScore.Equals(other.OTotalScore)
                ) &&
                (
                    this.OTotalCriticalScore == other.OTotalCriticalScore ||
                    this.OTotalCriticalScore != null &&
                    this.OTotalCriticalScore.Equals(other.OTotalCriticalScore)
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
                
                if (this.EvaluatorId != null)
                    hash = hash * 59 + this.EvaluatorId.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.FormId != null)
                    hash = hash * 59 + this.FormId.GetHashCode();
                
                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();
                
                if (this.FormName != null)
                    hash = hash * 59 + this.FormName.GetHashCode();
                
                if (this.CalibrationId != null)
                    hash = hash * 59 + this.CalibrationId.GetHashCode();
                
                if (this.Rescored != null)
                    hash = hash * 59 + this.Rescored.GetHashCode();
                
                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();
                
                if (this.OTotalScore != null)
                    hash = hash * 59 + this.OTotalScore.GetHashCode();
                
                if (this.OTotalCriticalScore != null)
                    hash = hash * 59 + this.OTotalCriticalScore.GetHashCode();
                
                return hash;
            }
        }
    }

}
