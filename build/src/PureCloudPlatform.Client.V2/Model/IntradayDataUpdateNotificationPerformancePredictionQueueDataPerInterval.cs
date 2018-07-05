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
    /// IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval
    /// </summary>
    [DataContract]
    public partial class IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval :  IEquatable<IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval" /> class.
        /// </summary>
        /// <param name="ServiceLevelPercent">ServiceLevelPercent.</param>
        /// <param name="AverageSpeedOfAnswerSeconds">AverageSpeedOfAnswerSeconds.</param>
        /// <param name="NumberOfInteractions">NumberOfInteractions.</param>
        public IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval(double? ServiceLevelPercent = null, double? AverageSpeedOfAnswerSeconds = null, double? NumberOfInteractions = null)
        {
            this.ServiceLevelPercent = ServiceLevelPercent;
            this.AverageSpeedOfAnswerSeconds = AverageSpeedOfAnswerSeconds;
            this.NumberOfInteractions = NumberOfInteractions;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ServiceLevelPercent
        /// </summary>
        [DataMember(Name="serviceLevelPercent", EmitDefaultValue=false)]
        public double? ServiceLevelPercent { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AverageSpeedOfAnswerSeconds
        /// </summary>
        [DataMember(Name="averageSpeedOfAnswerSeconds", EmitDefaultValue=false)]
        public double? AverageSpeedOfAnswerSeconds { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NumberOfInteractions
        /// </summary>
        [DataMember(Name="numberOfInteractions", EmitDefaultValue=false)]
        public double? NumberOfInteractions { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval {\n");
            
            sb.Append("  ServiceLevelPercent: ").Append(ServiceLevelPercent).Append("\n");
            sb.Append("  AverageSpeedOfAnswerSeconds: ").Append(AverageSpeedOfAnswerSeconds).Append("\n");
            sb.Append("  NumberOfInteractions: ").Append(NumberOfInteractions).Append("\n");
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
            return this.Equals(obj as IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval);
        }

        /// <summary>
        /// Returns true if IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayDataUpdateNotificationPerformancePredictionQueueDataPerInterval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ServiceLevelPercent == other.ServiceLevelPercent ||
                    this.ServiceLevelPercent != null &&
                    this.ServiceLevelPercent.Equals(other.ServiceLevelPercent)
                ) &&
                (
                    this.AverageSpeedOfAnswerSeconds == other.AverageSpeedOfAnswerSeconds ||
                    this.AverageSpeedOfAnswerSeconds != null &&
                    this.AverageSpeedOfAnswerSeconds.Equals(other.AverageSpeedOfAnswerSeconds)
                ) &&
                (
                    this.NumberOfInteractions == other.NumberOfInteractions ||
                    this.NumberOfInteractions != null &&
                    this.NumberOfInteractions.Equals(other.NumberOfInteractions)
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
                
                if (this.ServiceLevelPercent != null)
                    hash = hash * 59 + this.ServiceLevelPercent.GetHashCode();
                
                if (this.AverageSpeedOfAnswerSeconds != null)
                    hash = hash * 59 + this.AverageSpeedOfAnswerSeconds.GetHashCode();
                
                if (this.NumberOfInteractions != null)
                    hash = hash * 59 + this.NumberOfInteractions.GetHashCode();
                
                return hash;
            }
        }
    }

}
