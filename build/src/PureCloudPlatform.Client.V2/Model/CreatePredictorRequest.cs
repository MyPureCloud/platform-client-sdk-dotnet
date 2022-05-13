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
    /// CreatePredictorRequest
    /// </summary>
    [DataContract]
    public partial class CreatePredictorRequest :  IEquatable<CreatePredictorRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictorRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePredictorRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictorRequest" /> class.
        /// </summary>
        /// <param name="QueueIds">The queue IDs associated with the predictor. (required).</param>
        /// <param name="Kpi">The KPI that the predictor attempts to maximize/minimize. (required).</param>
        /// <param name="RoutingTimeoutSeconds">Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds..</param>
        /// <param name="Schedule">The predictor schedule that determines when the predictor is used for routing interactions..</param>
        /// <param name="WorkloadBalancingConfig">The predictor balancing configuration to enable workload balancing.</param>
        public CreatePredictorRequest(List<string> QueueIds = null, string Kpi = null, int? RoutingTimeoutSeconds = null, PredictorSchedule Schedule = null, PredictorWorkloadBalancing WorkloadBalancingConfig = null)
        {
            this.QueueIds = QueueIds;
            this.Kpi = Kpi;
            this.RoutingTimeoutSeconds = RoutingTimeoutSeconds;
            this.Schedule = Schedule;
            this.WorkloadBalancingConfig = WorkloadBalancingConfig;
            
        }
        


        /// <summary>
        /// The queue IDs associated with the predictor.
        /// </summary>
        /// <value>The queue IDs associated with the predictor.</value>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<string> QueueIds { get; set; }



        /// <summary>
        /// The KPI that the predictor attempts to maximize/minimize.
        /// </summary>
        /// <value>The KPI that the predictor attempts to maximize/minimize.</value>
        [DataMember(Name="kpi", EmitDefaultValue=false)]
        public string Kpi { get; set; }



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
            sb.Append("class CreatePredictorRequest {\n");

            sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
            sb.Append("  Kpi: ").Append(Kpi).Append("\n");
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
            return this.Equals(obj as CreatePredictorRequest);
        }

        /// <summary>
        /// Returns true if CreatePredictorRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePredictorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePredictorRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueueIds == other.QueueIds ||
                    this.QueueIds != null &&
                    this.QueueIds.SequenceEqual(other.QueueIds)
                ) &&
                (
                    this.Kpi == other.Kpi ||
                    this.Kpi != null &&
                    this.Kpi.Equals(other.Kpi)
                ) &&
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
                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();

                if (this.Kpi != null)
                    hash = hash * 59 + this.Kpi.GetHashCode();

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
