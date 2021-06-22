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
    /// PatchPredictorRequest
    /// </summary>
    [DataContract]
    public partial class PatchPredictorRequest :  IEquatable<PatchPredictorRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPredictorRequest" /> class.
        /// </summary>
        /// <param name="RoutingTimeoutSeconds">Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds..</param>
        /// <param name="Schedule">The predictor schedule that determines when the predictor is used for routing interactions..</param>
        /// <param name="WorkloadBalancingConfig">The predictor balancing configuration to enable workload balancing.</param>
        public PatchPredictorRequest(int? RoutingTimeoutSeconds = null, PredictorSchedule Schedule = null, PredictorWorkloadBalancing WorkloadBalancingConfig = null)
        {
            this.RoutingTimeoutSeconds = RoutingTimeoutSeconds;
            this.Schedule = Schedule;
            this.WorkloadBalancingConfig = WorkloadBalancingConfig;
            
        }
        
        
        
        /// <summary>
        /// Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds.
        /// </summary>
        /// <value>Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds.</value>
        [DataMember(Name="routingTimeoutSeconds", EmitDefaultValue=false)]
        public int? RoutingTimeoutSeconds { get; set; }
        
        
        
        /// <summary>
        /// The predictor schedule that determines when the predictor is used for routing interactions.
        /// </summary>
        /// <value>The predictor schedule that determines when the predictor is used for routing interactions.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public PredictorSchedule Schedule { get; set; }
        
        
        
        /// <summary>
        /// The predictor balancing configuration to enable workload balancing
        /// </summary>
        /// <value>The predictor balancing configuration to enable workload balancing</value>
        [DataMember(Name="workloadBalancingConfig", EmitDefaultValue=false)]
        public PredictorWorkloadBalancing WorkloadBalancingConfig { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchPredictorRequest {\n");
            
            sb.Append("  RoutingTimeoutSeconds: ").Append(RoutingTimeoutSeconds).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  WorkloadBalancingConfig: ").Append(WorkloadBalancingConfig).Append("\n");
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
            return this.Equals(obj as PatchPredictorRequest);
        }

        /// <summary>
        /// Returns true if PatchPredictorRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchPredictorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchPredictorRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RoutingTimeoutSeconds == other.RoutingTimeoutSeconds ||
                    this.RoutingTimeoutSeconds != null &&
                    this.RoutingTimeoutSeconds.Equals(other.RoutingTimeoutSeconds)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.WorkloadBalancingConfig == other.WorkloadBalancingConfig ||
                    this.WorkloadBalancingConfig != null &&
                    this.WorkloadBalancingConfig.Equals(other.WorkloadBalancingConfig)
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
                
                if (this.RoutingTimeoutSeconds != null)
                    hash = hash * 59 + this.RoutingTimeoutSeconds.GetHashCode();
                
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                
                if (this.WorkloadBalancingConfig != null)
                    hash = hash * 59 + this.WorkloadBalancingConfig.GetHashCode();
                
                return hash;
            }
        }
    }

}
