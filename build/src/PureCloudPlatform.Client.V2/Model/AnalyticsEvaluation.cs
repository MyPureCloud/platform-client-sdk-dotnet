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
        
        
        /// <param name="EvaluationId">EvaluationId.</param>
        
        
        
        /// <param name="EvaluatorId">EvaluatorId.</param>
        
        
        
        /// <param name="UserId">UserId.</param>
        
        
        
        /// <param name="EventTime">EventTime.</param>
        
        
        
        /// <param name="QueueId">QueueId.</param>
        
        
        
        /// <param name="FormId">FormId.</param>
        
        
        
        /// <param name="ContextId">ContextId.</param>
        
        
        
        /// <param name="FormName">FormName.</param>
        
        
        
        /// <param name="GetoTotalScore">GetoTotalScore.</param>
        
        
        
        /// <param name="GetoTotalCriticalScore">GetoTotalCriticalScore.</param>
        
        
        public AnalyticsEvaluation(string EvaluationId = null, string EvaluatorId = null, string UserId = null, string EventTime = null, string QueueId = null, string FormId = null, string ContextId = null, string FormName = null, long? GetoTotalScore = null, long? GetoTotalCriticalScore = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.EvaluationId = EvaluationId;
            
            
            
            
            
            
            
            
this.EvaluatorId = EvaluatorId;
            
            
            
            
            
            
            
            
this.UserId = UserId;
            
            
            
            
            
            
            
            
this.EventTime = EventTime;
            
            
            
            
            
            
            
            
this.QueueId = QueueId;
            
            
            
            
            
            
            
            
this.FormId = FormId;
            
            
            
            
            
            
            
            
this.ContextId = ContextId;
            
            
            
            
            
            
            
            
this.FormName = FormName;
            
            
            
            
            
            
            
            
this.GetoTotalScore = GetoTotalScore;
            
            
            
            
            
            
            
            
this.GetoTotalCriticalScore = GetoTotalCriticalScore;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets EvaluationId
        /// </summary>
        [DataMember(Name="evaluationId", EmitDefaultValue=false)]
        public string EvaluationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EvaluatorId
        /// </summary>
        [DataMember(Name="evaluatorId", EmitDefaultValue=false)]
        public string EvaluatorId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public string EventTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FormId
        /// </summary>
        [DataMember(Name="formId", EmitDefaultValue=false)]
        public string FormId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContextId
        /// </summary>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FormName
        /// </summary>
        [DataMember(Name="formName", EmitDefaultValue=false)]
        public string FormName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets GetoTotalScore
        /// </summary>
        [DataMember(Name="getoTotalScore", EmitDefaultValue=false)]
        public long? GetoTotalScore { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets GetoTotalCriticalScore
        /// </summary>
        [DataMember(Name="getoTotalCriticalScore", EmitDefaultValue=false)]
        public long? GetoTotalCriticalScore { get; set; }
        
        
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
            
            sb.Append("  GetoTotalScore: ").Append(GetoTotalScore).Append("\n");
            
            sb.Append("  GetoTotalCriticalScore: ").Append(GetoTotalCriticalScore).Append("\n");
            
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
                    this.GetoTotalScore == other.GetoTotalScore ||
                    this.GetoTotalScore != null &&
                    this.GetoTotalScore.Equals(other.GetoTotalScore)
                ) &&
                (
                    this.GetoTotalCriticalScore == other.GetoTotalCriticalScore ||
                    this.GetoTotalCriticalScore != null &&
                    this.GetoTotalCriticalScore.Equals(other.GetoTotalCriticalScore)
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
                
                if (this.GetoTotalScore != null)
                    hash = hash * 59 + this.GetoTotalScore.GetHashCode();
                
                if (this.GetoTotalCriticalScore != null)
                    hash = hash * 59 + this.GetoTotalCriticalScore.GetHashCode();
                
                return hash;
            }
        }
    }

}
