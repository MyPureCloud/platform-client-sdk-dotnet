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
    /// EdgeMetricsTopicOffsetDateTime
    /// </summary>
    [DataContract]
    public partial class EdgeMetricsTopicOffsetDateTime :  IEquatable<EdgeMetricsTopicOffsetDateTime>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeMetricsTopicOffsetDateTime" /> class.
        /// </summary>
        /// <param name="DateTime">DateTime.</param>
        /// <param name="Offset">Offset.</param>
        public EdgeMetricsTopicOffsetDateTime(EdgeMetricsTopicLocalDateTime DateTime = null, EdgeMetricsTopicZoneOffset Offset = null)
        {
            this.DateTime = DateTime;
            this.Offset = Offset;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public EdgeMetricsTopicLocalDateTime DateTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public EdgeMetricsTopicZoneOffset Offset { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeMetricsTopicOffsetDateTime {\n");
            
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
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
            return this.Equals(obj as EdgeMetricsTopicOffsetDateTime);
        }

        /// <summary>
        /// Returns true if EdgeMetricsTopicOffsetDateTime instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeMetricsTopicOffsetDateTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeMetricsTopicOffsetDateTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateTime == other.DateTime ||
                    this.DateTime != null &&
                    this.DateTime.Equals(other.DateTime)
                ) &&
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
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
                
                if (this.DateTime != null)
                    hash = hash * 59 + this.DateTime.GetHashCode();
                
                if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                
                return hash;
            }
        }
    }

}
