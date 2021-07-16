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
    /// TrunkMetrics
    /// </summary>
    [DataContract]
    public partial class TrunkMetrics :  IEquatable<TrunkMetrics>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkMetrics" /> class.
        /// </summary>
        /// <param name="EventTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="LogicalInterface">LogicalInterface.</param>
        /// <param name="Trunk">Trunk.</param>
        /// <param name="Calls">Calls.</param>
        /// <param name="Qos">Qos.</param>
        public TrunkMetrics(DateTime? EventTime = null, DomainEntityRef LogicalInterface = null, DomainEntityRef Trunk = null, TrunkMetricsCalls Calls = null, TrunkMetricsQoS Qos = null)
        {
            this.EventTime = EventTime;
            this.LogicalInterface = LogicalInterface;
            this.Trunk = Trunk;
            this.Calls = Calls;
            this.Qos = Qos;
            
        }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LogicalInterface
        /// </summary>
        [DataMember(Name="logicalInterface", EmitDefaultValue=false)]
        public DomainEntityRef LogicalInterface { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Trunk
        /// </summary>
        [DataMember(Name="trunk", EmitDefaultValue=false)]
        public DomainEntityRef Trunk { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Calls
        /// </summary>
        [DataMember(Name="calls", EmitDefaultValue=false)]
        public TrunkMetricsCalls Calls { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Qos
        /// </summary>
        [DataMember(Name="qos", EmitDefaultValue=false)]
        public TrunkMetricsQoS Qos { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrunkMetrics {\n");
            
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  LogicalInterface: ").Append(LogicalInterface).Append("\n");
            sb.Append("  Trunk: ").Append(Trunk).Append("\n");
            sb.Append("  Calls: ").Append(Calls).Append("\n");
            sb.Append("  Qos: ").Append(Qos).Append("\n");
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
            return this.Equals(obj as TrunkMetrics);
        }

        /// <summary>
        /// Returns true if TrunkMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of TrunkMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrunkMetrics other)
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
                    this.LogicalInterface == other.LogicalInterface ||
                    this.LogicalInterface != null &&
                    this.LogicalInterface.Equals(other.LogicalInterface)
                ) &&
                (
                    this.Trunk == other.Trunk ||
                    this.Trunk != null &&
                    this.Trunk.Equals(other.Trunk)
                ) &&
                (
                    this.Calls == other.Calls ||
                    this.Calls != null &&
                    this.Calls.Equals(other.Calls)
                ) &&
                (
                    this.Qos == other.Qos ||
                    this.Qos != null &&
                    this.Qos.Equals(other.Qos)
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
                
                if (this.LogicalInterface != null)
                    hash = hash * 59 + this.LogicalInterface.GetHashCode();
                
                if (this.Trunk != null)
                    hash = hash * 59 + this.Trunk.GetHashCode();
                
                if (this.Calls != null)
                    hash = hash * 59 + this.Calls.GetHashCode();
                
                if (this.Qos != null)
                    hash = hash * 59 + this.Qos.GetHashCode();
                
                return hash;
            }
        }
    }

}
