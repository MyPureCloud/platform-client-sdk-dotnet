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
    /// IntradayForecastData
    /// </summary>
    [DataContract]
    public partial class IntradayForecastData :  IEquatable<IntradayForecastData>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayForecastData" /> class.
        /// </summary>
        /// <param name="Offered">The number of interactions routed into the queue for the given media type(s) for an agent to answer.</param>
        /// <param name="AverageTalkTimeSeconds">The average time in seconds an agent spends interacting with a customer.</param>
        /// <param name="AverageAfterCallWorkSeconds">The average time in seconds spent in after-call work. After-call work is the work that an agent performs immediately following an interaction.</param>
        public IntradayForecastData(double? Offered = null, double? AverageTalkTimeSeconds = null, double? AverageAfterCallWorkSeconds = null)
        {
            this.Offered = Offered;
            this.AverageTalkTimeSeconds = AverageTalkTimeSeconds;
            this.AverageAfterCallWorkSeconds = AverageAfterCallWorkSeconds;
            
        }
        
        
        
        /// <summary>
        /// The number of interactions routed into the queue for the given media type(s) for an agent to answer
        /// </summary>
        /// <value>The number of interactions routed into the queue for the given media type(s) for an agent to answer</value>
        [DataMember(Name="offered", EmitDefaultValue=false)]
        public double? Offered { get; set; }
        
        
        
        /// <summary>
        /// The average time in seconds an agent spends interacting with a customer
        /// </summary>
        /// <value>The average time in seconds an agent spends interacting with a customer</value>
        [DataMember(Name="averageTalkTimeSeconds", EmitDefaultValue=false)]
        public double? AverageTalkTimeSeconds { get; set; }
        
        
        
        /// <summary>
        /// The average time in seconds spent in after-call work. After-call work is the work that an agent performs immediately following an interaction
        /// </summary>
        /// <value>The average time in seconds spent in after-call work. After-call work is the work that an agent performs immediately following an interaction</value>
        [DataMember(Name="averageAfterCallWorkSeconds", EmitDefaultValue=false)]
        public double? AverageAfterCallWorkSeconds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayForecastData {\n");
            
            sb.Append("  Offered: ").Append(Offered).Append("\n");
            sb.Append("  AverageTalkTimeSeconds: ").Append(AverageTalkTimeSeconds).Append("\n");
            sb.Append("  AverageAfterCallWorkSeconds: ").Append(AverageAfterCallWorkSeconds).Append("\n");
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
            return this.Equals(obj as IntradayForecastData);
        }

        /// <summary>
        /// Returns true if IntradayForecastData instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayForecastData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayForecastData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Offered == other.Offered ||
                    this.Offered != null &&
                    this.Offered.Equals(other.Offered)
                ) &&
                (
                    this.AverageTalkTimeSeconds == other.AverageTalkTimeSeconds ||
                    this.AverageTalkTimeSeconds != null &&
                    this.AverageTalkTimeSeconds.Equals(other.AverageTalkTimeSeconds)
                ) &&
                (
                    this.AverageAfterCallWorkSeconds == other.AverageAfterCallWorkSeconds ||
                    this.AverageAfterCallWorkSeconds != null &&
                    this.AverageAfterCallWorkSeconds.Equals(other.AverageAfterCallWorkSeconds)
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
                
                if (this.Offered != null)
                    hash = hash * 59 + this.Offered.GetHashCode();
                
                if (this.AverageTalkTimeSeconds != null)
                    hash = hash * 59 + this.AverageTalkTimeSeconds.GetHashCode();
                
                if (this.AverageAfterCallWorkSeconds != null)
                    hash = hash * 59 + this.AverageAfterCallWorkSeconds.GetHashCode();
                
                return hash;
            }
        }
    }

}
