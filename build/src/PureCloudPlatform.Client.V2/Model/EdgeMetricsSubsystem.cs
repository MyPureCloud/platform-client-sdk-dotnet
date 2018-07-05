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
    /// EdgeMetricsSubsystem
    /// </summary>
    [DataContract]
    public partial class EdgeMetricsSubsystem :  IEquatable<EdgeMetricsSubsystem>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeMetricsSubsystem" /> class.
        /// </summary>
        /// <param name="DelayMs">Delay in milliseconds..</param>
        /// <param name="ProcessName">Name of the Edge process..</param>
        /// <param name="MediaSubsystem">Subsystem for an Edge device..</param>
        public EdgeMetricsSubsystem(int? DelayMs = null, string ProcessName = null, EdgeMetricsSubsystem MediaSubsystem = null)
        {
            this.DelayMs = DelayMs;
            this.ProcessName = ProcessName;
            this.MediaSubsystem = MediaSubsystem;
            
        }
        
        
        
        /// <summary>
        /// Delay in milliseconds.
        /// </summary>
        /// <value>Delay in milliseconds.</value>
        [DataMember(Name="delayMs", EmitDefaultValue=false)]
        public int? DelayMs { get; set; }
        
        
        
        /// <summary>
        /// Name of the Edge process.
        /// </summary>
        /// <value>Name of the Edge process.</value>
        [DataMember(Name="processName", EmitDefaultValue=false)]
        public string ProcessName { get; set; }
        
        
        
        /// <summary>
        /// Subsystem for an Edge device.
        /// </summary>
        /// <value>Subsystem for an Edge device.</value>
        [DataMember(Name="mediaSubsystem", EmitDefaultValue=false)]
        public EdgeMetricsSubsystem MediaSubsystem { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeMetricsSubsystem {\n");
            
            sb.Append("  DelayMs: ").Append(DelayMs).Append("\n");
            sb.Append("  ProcessName: ").Append(ProcessName).Append("\n");
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
            return this.Equals(obj as EdgeMetricsSubsystem);
        }

        /// <summary>
        /// Returns true if EdgeMetricsSubsystem instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeMetricsSubsystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeMetricsSubsystem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DelayMs == other.DelayMs ||
                    this.DelayMs != null &&
                    this.DelayMs.Equals(other.DelayMs)
                ) &&
                (
                    this.ProcessName == other.ProcessName ||
                    this.ProcessName != null &&
                    this.ProcessName.Equals(other.ProcessName)
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
                
                if (this.DelayMs != null)
                    hash = hash * 59 + this.DelayMs.GetHashCode();
                
                if (this.ProcessName != null)
                    hash = hash * 59 + this.ProcessName.GetHashCode();
                
                if (this.MediaSubsystem != null)
                    hash = hash * 59 + this.MediaSubsystem.GetHashCode();
                
                return hash;
            }
        }
    }

}
