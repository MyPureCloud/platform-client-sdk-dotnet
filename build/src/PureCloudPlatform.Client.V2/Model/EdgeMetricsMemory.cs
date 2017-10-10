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
    /// EdgeMetricsMemory
    /// </summary>
    [DataContract]
    public partial class EdgeMetricsMemory :  IEquatable<EdgeMetricsMemory>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeMetricsMemory" /> class.
        /// </summary>
        
        
        /// <param name="AvailableBytes">Available memory in bytes..</param>
        
        
        
        /// <param name="Type">Type of memory. Virtual or physical..</param>
        
        
        
        /// <param name="TotalBytes">Total memory in bytes..</param>
        
        
        public EdgeMetricsMemory(double? AvailableBytes = null, string Type = null, double? TotalBytes = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.AvailableBytes = AvailableBytes;
            
            
            
            
            
            
            
            
this.Type = Type;
            
            
            
            
            
            
            
            
this.TotalBytes = TotalBytes;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Available memory in bytes.
        /// </summary>
        /// <value>Available memory in bytes.</value>
        [DataMember(Name="availableBytes", EmitDefaultValue=false)]
        public double? AvailableBytes { get; set; }
        
        
        
        /// <summary>
        /// Type of memory. Virtual or physical.
        /// </summary>
        /// <value>Type of memory. Virtual or physical.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        
        /// <summary>
        /// Total memory in bytes.
        /// </summary>
        /// <value>Total memory in bytes.</value>
        [DataMember(Name="totalBytes", EmitDefaultValue=false)]
        public double? TotalBytes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeMetricsMemory {\n");
            
            sb.Append("  AvailableBytes: ").Append(AvailableBytes).Append("\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            
            sb.Append("  TotalBytes: ").Append(TotalBytes).Append("\n");
            
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
            return this.Equals(obj as EdgeMetricsMemory);
        }

        /// <summary>
        /// Returns true if EdgeMetricsMemory instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeMetricsMemory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeMetricsMemory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AvailableBytes == other.AvailableBytes ||
                    this.AvailableBytes != null &&
                    this.AvailableBytes.Equals(other.AvailableBytes)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.TotalBytes == other.TotalBytes ||
                    this.TotalBytes != null &&
                    this.TotalBytes.Equals(other.TotalBytes)
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
                
                if (this.AvailableBytes != null)
                    hash = hash * 59 + this.AvailableBytes.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.TotalBytes != null)
                    hash = hash * 59 + this.TotalBytes.GetHashCode();
                
                return hash;
            }
        }
    }

}
