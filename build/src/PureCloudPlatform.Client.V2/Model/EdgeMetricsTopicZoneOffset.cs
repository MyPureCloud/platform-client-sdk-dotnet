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
    /// EdgeMetricsTopicZoneOffset
    /// </summary>
    [DataContract]
    public partial class EdgeMetricsTopicZoneOffset :  IEquatable<EdgeMetricsTopicZoneOffset>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeMetricsTopicZoneOffset" /> class.
        /// </summary>
        /// <param name="TotalSeconds">TotalSeconds.</param>
        public EdgeMetricsTopicZoneOffset(int? TotalSeconds = null)
        {
            this.TotalSeconds = TotalSeconds;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets TotalSeconds
        /// </summary>
        [DataMember(Name="totalSeconds", EmitDefaultValue=false)]
        public int? TotalSeconds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeMetricsTopicZoneOffset {\n");
            
            sb.Append("  TotalSeconds: ").Append(TotalSeconds).Append("\n");
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
            return this.Equals(obj as EdgeMetricsTopicZoneOffset);
        }

        /// <summary>
        /// Returns true if EdgeMetricsTopicZoneOffset instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeMetricsTopicZoneOffset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeMetricsTopicZoneOffset other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TotalSeconds == other.TotalSeconds ||
                    this.TotalSeconds != null &&
                    this.TotalSeconds.Equals(other.TotalSeconds)
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
                
                if (this.TotalSeconds != null)
                    hash = hash * 59 + this.TotalSeconds.GetHashCode();
                
                return hash;
            }
        }
    }

}
