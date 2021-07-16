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
    /// EdgeMetricsTopicEdgeMetricProcessor
    /// </summary>
    [DataContract]
    public partial class EdgeMetricsTopicEdgeMetricProcessor :  IEquatable<EdgeMetricsTopicEdgeMetricProcessor>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeMetricsTopicEdgeMetricProcessor" /> class.
        /// </summary>
        /// <param name="CpuId">CpuId.</param>
        /// <param name="IdleTimePct">IdleTimePct.</param>
        /// <param name="ActiveTimePct">ActiveTimePct.</param>
        /// <param name="PrivilegedTimePct">PrivilegedTimePct.</param>
        /// <param name="UserTimePct">UserTimePct.</param>
        public EdgeMetricsTopicEdgeMetricProcessor(string CpuId = null, int? IdleTimePct = null, int? ActiveTimePct = null, int? PrivilegedTimePct = null, int? UserTimePct = null)
        {
            this.CpuId = CpuId;
            this.IdleTimePct = IdleTimePct;
            this.ActiveTimePct = ActiveTimePct;
            this.PrivilegedTimePct = PrivilegedTimePct;
            this.UserTimePct = UserTimePct;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets CpuId
        /// </summary>
        [DataMember(Name="cpuId", EmitDefaultValue=false)]
        public string CpuId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IdleTimePct
        /// </summary>
        [DataMember(Name="idleTimePct", EmitDefaultValue=false)]
        public int? IdleTimePct { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ActiveTimePct
        /// </summary>
        [DataMember(Name="activeTimePct", EmitDefaultValue=false)]
        public int? ActiveTimePct { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PrivilegedTimePct
        /// </summary>
        [DataMember(Name="privilegedTimePct", EmitDefaultValue=false)]
        public int? PrivilegedTimePct { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserTimePct
        /// </summary>
        [DataMember(Name="userTimePct", EmitDefaultValue=false)]
        public int? UserTimePct { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeMetricsTopicEdgeMetricProcessor {\n");
            
            sb.Append("  CpuId: ").Append(CpuId).Append("\n");
            sb.Append("  IdleTimePct: ").Append(IdleTimePct).Append("\n");
            sb.Append("  ActiveTimePct: ").Append(ActiveTimePct).Append("\n");
            sb.Append("  PrivilegedTimePct: ").Append(PrivilegedTimePct).Append("\n");
            sb.Append("  UserTimePct: ").Append(UserTimePct).Append("\n");
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
            return this.Equals(obj as EdgeMetricsTopicEdgeMetricProcessor);
        }

        /// <summary>
        /// Returns true if EdgeMetricsTopicEdgeMetricProcessor instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeMetricsTopicEdgeMetricProcessor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeMetricsTopicEdgeMetricProcessor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CpuId == other.CpuId ||
                    this.CpuId != null &&
                    this.CpuId.Equals(other.CpuId)
                ) &&
                (
                    this.IdleTimePct == other.IdleTimePct ||
                    this.IdleTimePct != null &&
                    this.IdleTimePct.Equals(other.IdleTimePct)
                ) &&
                (
                    this.ActiveTimePct == other.ActiveTimePct ||
                    this.ActiveTimePct != null &&
                    this.ActiveTimePct.Equals(other.ActiveTimePct)
                ) &&
                (
                    this.PrivilegedTimePct == other.PrivilegedTimePct ||
                    this.PrivilegedTimePct != null &&
                    this.PrivilegedTimePct.Equals(other.PrivilegedTimePct)
                ) &&
                (
                    this.UserTimePct == other.UserTimePct ||
                    this.UserTimePct != null &&
                    this.UserTimePct.Equals(other.UserTimePct)
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
                
                if (this.CpuId != null)
                    hash = hash * 59 + this.CpuId.GetHashCode();
                
                if (this.IdleTimePct != null)
                    hash = hash * 59 + this.IdleTimePct.GetHashCode();
                
                if (this.ActiveTimePct != null)
                    hash = hash * 59 + this.ActiveTimePct.GetHashCode();
                
                if (this.PrivilegedTimePct != null)
                    hash = hash * 59 + this.PrivilegedTimePct.GetHashCode();
                
                if (this.UserTimePct != null)
                    hash = hash * 59 + this.UserTimePct.GetHashCode();
                
                return hash;
            }
        }
    }

}
