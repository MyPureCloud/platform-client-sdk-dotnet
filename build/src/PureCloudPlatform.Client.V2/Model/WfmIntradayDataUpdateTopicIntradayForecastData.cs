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
    /// WfmIntradayDataUpdateTopicIntradayForecastData
    /// </summary>
    [DataContract]
    public partial class WfmIntradayDataUpdateTopicIntradayForecastData :  IEquatable<WfmIntradayDataUpdateTopicIntradayForecastData>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmIntradayDataUpdateTopicIntradayForecastData" /> class.
        /// </summary>
        /// <param name="Offered">Offered.</param>
        /// <param name="AverageTalkTimeSeconds">AverageTalkTimeSeconds.</param>
        /// <param name="AverageAfterCallWorkSeconds">AverageAfterCallWorkSeconds.</param>
        public WfmIntradayDataUpdateTopicIntradayForecastData(double? Offered = null, double? AverageTalkTimeSeconds = null, double? AverageAfterCallWorkSeconds = null)
        {
            this.Offered = Offered;
            this.AverageTalkTimeSeconds = AverageTalkTimeSeconds;
            this.AverageAfterCallWorkSeconds = AverageAfterCallWorkSeconds;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Offered
        /// </summary>
        [DataMember(Name="offered", EmitDefaultValue=false)]
        public double? Offered { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AverageTalkTimeSeconds
        /// </summary>
        [DataMember(Name="averageTalkTimeSeconds", EmitDefaultValue=false)]
        public double? AverageTalkTimeSeconds { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AverageAfterCallWorkSeconds
        /// </summary>
        [DataMember(Name="averageAfterCallWorkSeconds", EmitDefaultValue=false)]
        public double? AverageAfterCallWorkSeconds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmIntradayDataUpdateTopicIntradayForecastData {\n");
            
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
            return this.Equals(obj as WfmIntradayDataUpdateTopicIntradayForecastData);
        }

        /// <summary>
        /// Returns true if WfmIntradayDataUpdateTopicIntradayForecastData instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmIntradayDataUpdateTopicIntradayForecastData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmIntradayDataUpdateTopicIntradayForecastData other)
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
