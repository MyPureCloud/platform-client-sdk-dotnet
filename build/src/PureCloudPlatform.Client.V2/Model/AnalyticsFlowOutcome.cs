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
    /// AnalyticsFlowOutcome
    /// </summary>
    [DataContract]
    public partial class AnalyticsFlowOutcome :  IEquatable<AnalyticsFlowOutcome>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsFlowOutcome" /> class.
        /// </summary>
        /// <param name="FlowOutcomeId">Unique identifiers of a flow outcome.</param>
        /// <param name="FlowOutcomeValue">Flow outcome value, e.g. SUCCESS.</param>
        /// <param name="FlowOutcome">Colon-separated combinations of unique flow outcome identifier and value.</param>
        /// <param name="FlowOutcomeStartTimestamp">Date/time the outcome started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="FlowOutcomeEndTimestamp">Date/time the outcome ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public AnalyticsFlowOutcome(string FlowOutcomeId = null, string FlowOutcomeValue = null, string FlowOutcome = null, DateTime? FlowOutcomeStartTimestamp = null, DateTime? FlowOutcomeEndTimestamp = null)
        {
            this.FlowOutcomeId = FlowOutcomeId;
            this.FlowOutcomeValue = FlowOutcomeValue;
            this.FlowOutcome = FlowOutcome;
            this.FlowOutcomeStartTimestamp = FlowOutcomeStartTimestamp;
            this.FlowOutcomeEndTimestamp = FlowOutcomeEndTimestamp;
            
        }
        
        
        
        /// <summary>
        /// Unique identifiers of a flow outcome
        /// </summary>
        /// <value>Unique identifiers of a flow outcome</value>
        [DataMember(Name="flowOutcomeId", EmitDefaultValue=false)]
        public string FlowOutcomeId { get; set; }
        
        
        
        /// <summary>
        /// Flow outcome value, e.g. SUCCESS
        /// </summary>
        /// <value>Flow outcome value, e.g. SUCCESS</value>
        [DataMember(Name="flowOutcomeValue", EmitDefaultValue=false)]
        public string FlowOutcomeValue { get; set; }
        
        
        
        /// <summary>
        /// Colon-separated combinations of unique flow outcome identifier and value
        /// </summary>
        /// <value>Colon-separated combinations of unique flow outcome identifier and value</value>
        [DataMember(Name="flowOutcome", EmitDefaultValue=false)]
        public string FlowOutcome { get; set; }
        
        
        
        /// <summary>
        /// Date/time the outcome started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date/time the outcome started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="flowOutcomeStartTimestamp", EmitDefaultValue=false)]
        public DateTime? FlowOutcomeStartTimestamp { get; set; }
        
        
        
        /// <summary>
        /// Date/time the outcome ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date/time the outcome ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="flowOutcomeEndTimestamp", EmitDefaultValue=false)]
        public DateTime? FlowOutcomeEndTimestamp { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsFlowOutcome {\n");
            
            sb.Append("  FlowOutcomeId: ").Append(FlowOutcomeId).Append("\n");
            sb.Append("  FlowOutcomeValue: ").Append(FlowOutcomeValue).Append("\n");
            sb.Append("  FlowOutcome: ").Append(FlowOutcome).Append("\n");
            sb.Append("  FlowOutcomeStartTimestamp: ").Append(FlowOutcomeStartTimestamp).Append("\n");
            sb.Append("  FlowOutcomeEndTimestamp: ").Append(FlowOutcomeEndTimestamp).Append("\n");
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
            return this.Equals(obj as AnalyticsFlowOutcome);
        }

        /// <summary>
        /// Returns true if AnalyticsFlowOutcome instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsFlowOutcome to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsFlowOutcome other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FlowOutcomeId == other.FlowOutcomeId ||
                    this.FlowOutcomeId != null &&
                    this.FlowOutcomeId.Equals(other.FlowOutcomeId)
                ) &&
                (
                    this.FlowOutcomeValue == other.FlowOutcomeValue ||
                    this.FlowOutcomeValue != null &&
                    this.FlowOutcomeValue.Equals(other.FlowOutcomeValue)
                ) &&
                (
                    this.FlowOutcome == other.FlowOutcome ||
                    this.FlowOutcome != null &&
                    this.FlowOutcome.Equals(other.FlowOutcome)
                ) &&
                (
                    this.FlowOutcomeStartTimestamp == other.FlowOutcomeStartTimestamp ||
                    this.FlowOutcomeStartTimestamp != null &&
                    this.FlowOutcomeStartTimestamp.Equals(other.FlowOutcomeStartTimestamp)
                ) &&
                (
                    this.FlowOutcomeEndTimestamp == other.FlowOutcomeEndTimestamp ||
                    this.FlowOutcomeEndTimestamp != null &&
                    this.FlowOutcomeEndTimestamp.Equals(other.FlowOutcomeEndTimestamp)
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
                
                if (this.FlowOutcomeId != null)
                    hash = hash * 59 + this.FlowOutcomeId.GetHashCode();
                
                if (this.FlowOutcomeValue != null)
                    hash = hash * 59 + this.FlowOutcomeValue.GetHashCode();
                
                if (this.FlowOutcome != null)
                    hash = hash * 59 + this.FlowOutcome.GetHashCode();
                
                if (this.FlowOutcomeStartTimestamp != null)
                    hash = hash * 59 + this.FlowOutcomeStartTimestamp.GetHashCode();
                
                if (this.FlowOutcomeEndTimestamp != null)
                    hash = hash * 59 + this.FlowOutcomeEndTimestamp.GetHashCode();
                
                return hash;
            }
        }
    }

}
