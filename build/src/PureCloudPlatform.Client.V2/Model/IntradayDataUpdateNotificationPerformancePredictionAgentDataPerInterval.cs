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
    /// IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval
    /// </summary>
    [DataContract]
    public partial class IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval :  IEquatable<IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval" /> class.
        /// </summary>
        /// <param name="InteractingTimeSeconds">InteractingTimeSeconds.</param>
        public IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval(double? InteractingTimeSeconds = null)
        {
            this.InteractingTimeSeconds = InteractingTimeSeconds;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets InteractingTimeSeconds
        /// </summary>
        [DataMember(Name="interactingTimeSeconds", EmitDefaultValue=false)]
        public double? InteractingTimeSeconds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval {\n");
            
            sb.Append("  InteractingTimeSeconds: ").Append(InteractingTimeSeconds).Append("\n");
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
            return this.Equals(obj as IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval);
        }

        /// <summary>
        /// Returns true if IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayDataUpdateNotificationPerformancePredictionAgentDataPerInterval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.InteractingTimeSeconds == other.InteractingTimeSeconds ||
                    this.InteractingTimeSeconds != null &&
                    this.InteractingTimeSeconds.Equals(other.InteractingTimeSeconds)
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
                
                if (this.InteractingTimeSeconds != null)
                    hash = hash * 59 + this.InteractingTimeSeconds.GetHashCode();
                
                return hash;
            }
        }
    }

}
