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
    /// WeekScheduleGenerationResult
    /// </summary>
    [DataContract]
    public partial class WeekScheduleGenerationResult :  IEquatable<WeekScheduleGenerationResult>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WeekScheduleGenerationResult" /> class.
        /// </summary>
        /// <param name="Failed">Whether the schedule generation failed.</param>
        /// <param name="RunId">ID of the schedule run.</param>
        /// <param name="AgentWarnings">Warning messages from the schedule run. This will be available only when requesting information for a single week schedule.</param>
        /// <param name="AgentWarningCount">Count of warning messages from the schedule run. This will be available only when requesting multiple week schedules.</param>
        public WeekScheduleGenerationResult(bool? Failed = null, string RunId = null, List<ScheduleGenerationWarning> AgentWarnings = null, int? AgentWarningCount = null)
        {
            this.Failed = Failed;
            this.RunId = RunId;
            this.AgentWarnings = AgentWarnings;
            this.AgentWarningCount = AgentWarningCount;
            
        }
        
        
        
        /// <summary>
        /// Whether the schedule generation failed
        /// </summary>
        /// <value>Whether the schedule generation failed</value>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public bool? Failed { get; set; }
        
        
        
        /// <summary>
        /// ID of the schedule run
        /// </summary>
        /// <value>ID of the schedule run</value>
        [DataMember(Name="runId", EmitDefaultValue=false)]
        public string RunId { get; set; }
        
        
        
        /// <summary>
        /// Warning messages from the schedule run. This will be available only when requesting information for a single week schedule
        /// </summary>
        /// <value>Warning messages from the schedule run. This will be available only when requesting information for a single week schedule</value>
        [DataMember(Name="agentWarnings", EmitDefaultValue=false)]
        public List<ScheduleGenerationWarning> AgentWarnings { get; set; }
        
        
        
        /// <summary>
        /// Count of warning messages from the schedule run. This will be available only when requesting multiple week schedules
        /// </summary>
        /// <value>Count of warning messages from the schedule run. This will be available only when requesting multiple week schedules</value>
        [DataMember(Name="agentWarningCount", EmitDefaultValue=false)]
        public int? AgentWarningCount { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeekScheduleGenerationResult {\n");
            
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
            sb.Append("  AgentWarnings: ").Append(AgentWarnings).Append("\n");
            sb.Append("  AgentWarningCount: ").Append(AgentWarningCount).Append("\n");
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
            return this.Equals(obj as WeekScheduleGenerationResult);
        }

        /// <summary>
        /// Returns true if WeekScheduleGenerationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of WeekScheduleGenerationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeekScheduleGenerationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Failed == other.Failed ||
                    this.Failed != null &&
                    this.Failed.Equals(other.Failed)
                ) &&
                (
                    this.RunId == other.RunId ||
                    this.RunId != null &&
                    this.RunId.Equals(other.RunId)
                ) &&
                (
                    this.AgentWarnings == other.AgentWarnings ||
                    this.AgentWarnings != null &&
                    this.AgentWarnings.SequenceEqual(other.AgentWarnings)
                ) &&
                (
                    this.AgentWarningCount == other.AgentWarningCount ||
                    this.AgentWarningCount != null &&
                    this.AgentWarningCount.Equals(other.AgentWarningCount)
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
                
                if (this.Failed != null)
                    hash = hash * 59 + this.Failed.GetHashCode();
                
                if (this.RunId != null)
                    hash = hash * 59 + this.RunId.GetHashCode();
                
                if (this.AgentWarnings != null)
                    hash = hash * 59 + this.AgentWarnings.GetHashCode();
                
                if (this.AgentWarningCount != null)
                    hash = hash * 59 + this.AgentWarningCount.GetHashCode();
                
                return hash;
            }
        }
    }

}
