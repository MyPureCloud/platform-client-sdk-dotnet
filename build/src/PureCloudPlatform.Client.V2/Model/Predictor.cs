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
    /// Predictor
    /// </summary>
    [DataContract]
    public partial class Predictor :  IEquatable<Predictor>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The predictor state.
        /// </summary>
        /// <value>The predictor state.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Created for "Created"
            /// </summary>
            [EnumMember(Value = "Created")]
            Created,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The predictor state.
        /// </summary>
        /// <value>The predictor state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Predictor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Predictor() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Predictor" /> class.
        /// </summary>
        /// <param name="Queues">The queue IDs associated with the predictor. (required).</param>
        /// <param name="Kpi">The KPI that the predictor attempts to maximize/minimize. (required).</param>
        /// <param name="RoutingTimeoutSeconds">Number of seconds allocated to predictive routing before attempting a different routing method. This is a value between 12 and 900 seconds..</param>
        /// <param name="Schedule">The predictor schedule that determines when the predictor is used for routing interactions..</param>
        /// <param name="WorkloadBalancingConfig">The predictor balancing configuration to enable workload balancing..</param>
        public Predictor(List<AddressableEntityRef> Queues = null, string Kpi = null, int? RoutingTimeoutSeconds = null, PredictorSchedule Schedule = null, PredictorWorkloadBalancing WorkloadBalancingConfig = null)
        {
            this.Queues = Queues;
            this.Kpi = Kpi;
            this.RoutingTimeoutSeconds = RoutingTimeoutSeconds;
            this.Schedule = Schedule;
            this.WorkloadBalancingConfig = WorkloadBalancingConfig;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The queue IDs associated with the predictor.
        /// </summary>
        /// <value>The queue IDs associated with the predictor.</value>
        [DataMember(Name="queues", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Queues { get; set; }
        
        
        
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
        /// DateTime indicating when the predictor was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>DateTime indicating when the predictor was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// DateTime indicating when the predictor was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>DateTime indicating when the predictor was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// The predictor balancing configuration to enable workload balancing.
        /// </summary>
        /// <value>The predictor balancing configuration to enable workload balancing.</value>
        [DataMember(Name="workloadBalancingConfig", EmitDefaultValue=false)]
        public PredictorWorkloadBalancing WorkloadBalancingConfig { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Predictor {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Queues: ").Append(Queues).Append("\n");
            sb.Append("  Kpi: ").Append(Kpi).Append("\n");
            sb.Append("  RoutingTimeoutSeconds: ").Append(RoutingTimeoutSeconds).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  WorkloadBalancingConfig: ").Append(WorkloadBalancingConfig).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as Predictor);
        }

        /// <summary>
        /// Returns true if Predictor instances are equal
        /// </summary>
        /// <param name="other">Instance of Predictor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Predictor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Queues == other.Queues ||
                    this.Queues != null &&
                    this.Queues.SequenceEqual(other.Queues)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.WorkloadBalancingConfig == other.WorkloadBalancingConfig ||
                    this.WorkloadBalancingConfig != null &&
                    this.WorkloadBalancingConfig.Equals(other.WorkloadBalancingConfig)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Queues != null)
                    hash = hash * 59 + this.Queues.GetHashCode();
                
                if (this.Kpi != null)
                    hash = hash * 59 + this.Kpi.GetHashCode();
                
                if (this.RoutingTimeoutSeconds != null)
                    hash = hash * 59 + this.RoutingTimeoutSeconds.GetHashCode();
                
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.WorkloadBalancingConfig != null)
                    hash = hash * 59 + this.WorkloadBalancingConfig.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
