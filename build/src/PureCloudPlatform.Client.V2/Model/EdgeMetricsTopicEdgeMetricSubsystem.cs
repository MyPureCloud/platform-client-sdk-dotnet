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
    /// EdgeMetricsTopicEdgeMetricSubsystem
    /// </summary>
    [DataContract]
    public partial class EdgeMetricsTopicEdgeMetricSubsystem :  IEquatable<EdgeMetricsTopicEdgeMetricSubsystem>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeMetricsTopicEdgeMetricSubsystem" /> class.
        /// </summary>
        /// <param name="ProcessName">ProcessName.</param>
        /// <param name="DelayMs">DelayMs.</param>
        /// <param name="MediaSubsystem">MediaSubsystem.</param>
        public EdgeMetricsTopicEdgeMetricSubsystem(string ProcessName = null, int? DelayMs = null, EdgeMetricsTopicEdgeMetricSubsystemMedia MediaSubsystem = null)
        {
            this.ProcessName = ProcessName;
            this.DelayMs = DelayMs;
            this.MediaSubsystem = MediaSubsystem;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ProcessName
        /// </summary>
        [DataMember(Name="processName", EmitDefaultValue=false)]
        public string ProcessName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DelayMs
        /// </summary>
        [DataMember(Name="delayMs", EmitDefaultValue=false)]
        public int? DelayMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MediaSubsystem
        /// </summary>
        [DataMember(Name="mediaSubsystem", EmitDefaultValue=false)]
        public EdgeMetricsTopicEdgeMetricSubsystemMedia MediaSubsystem { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeMetricsTopicEdgeMetricSubsystem {\n");
            
            sb.Append("  ProcessName: ").Append(ProcessName).Append("\n");
            sb.Append("  DelayMs: ").Append(DelayMs).Append("\n");
            sb.Append("  MediaSubsystem: ").Append(MediaSubsystem).Append("\n");
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
            return this.Equals(obj as EdgeMetricsTopicEdgeMetricSubsystem);
        }

        /// <summary>
        /// Returns true if EdgeMetricsTopicEdgeMetricSubsystem instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeMetricsTopicEdgeMetricSubsystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeMetricsTopicEdgeMetricSubsystem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ProcessName == other.ProcessName ||
                    this.ProcessName != null &&
                    this.ProcessName.Equals(other.ProcessName)
                ) &&
                (
                    this.DelayMs == other.DelayMs ||
                    this.DelayMs != null &&
                    this.DelayMs.Equals(other.DelayMs)
                ) &&
                (
                    this.MediaSubsystem == other.MediaSubsystem ||
                    this.MediaSubsystem != null &&
                    this.MediaSubsystem.Equals(other.MediaSubsystem)
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
                
                if (this.ProcessName != null)
                    hash = hash * 59 + this.ProcessName.GetHashCode();
                
                if (this.DelayMs != null)
                    hash = hash * 59 + this.DelayMs.GetHashCode();
                
                if (this.MediaSubsystem != null)
                    hash = hash * 59 + this.MediaSubsystem.GetHashCode();
                
                return hash;
            }
        }
    }

}
