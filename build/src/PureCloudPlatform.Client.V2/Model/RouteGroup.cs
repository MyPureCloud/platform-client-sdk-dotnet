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
    /// Route group for calculated forecasts
    /// </summary>
    [DataContract]
    public partial class RouteGroup :  IEquatable<RouteGroup>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RouteGroup() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteGroup" /> class.
        /// </summary>
        /// <param name="Attributes">The attributes that describe this route group (required).</param>
        /// <param name="OfferedPerInterval">Interactions offered per 15 minute interval (required).</param>
        /// <param name="AverageTalkTimeSecondsPerInterval">Average talk time in seconds per 15 minute interval (required).</param>
        /// <param name="AverageAfterCallWorkSecondsPerInterval">Average after call work in seconds per 15 minute interval (required).</param>
        /// <param name="CompletedPerInterval">Interactions completed per 15 minute interval.</param>
        /// <param name="AbandonedPerInterval">Interactions abandoned per 15 minute interval.</param>
        public RouteGroup(RouteGroupAttributes Attributes = null, List<double?> OfferedPerInterval = null, List<double?> AverageTalkTimeSecondsPerInterval = null, List<double?> AverageAfterCallWorkSecondsPerInterval = null, List<double?> CompletedPerInterval = null, List<double?> AbandonedPerInterval = null)
        {
            this.Attributes = Attributes;
            this.OfferedPerInterval = OfferedPerInterval;
            this.AverageTalkTimeSecondsPerInterval = AverageTalkTimeSecondsPerInterval;
            this.AverageAfterCallWorkSecondsPerInterval = AverageAfterCallWorkSecondsPerInterval;
            this.CompletedPerInterval = CompletedPerInterval;
            this.AbandonedPerInterval = AbandonedPerInterval;
            
        }
        
        
        
        /// <summary>
        /// The attributes that describe this route group
        /// </summary>
        /// <value>The attributes that describe this route group</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public RouteGroupAttributes Attributes { get; set; }
        
        
        
        /// <summary>
        /// Interactions offered per 15 minute interval
        /// </summary>
        /// <value>Interactions offered per 15 minute interval</value>
        [DataMember(Name="offeredPerInterval", EmitDefaultValue=false)]
        public List<double?> OfferedPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Average talk time in seconds per 15 minute interval
        /// </summary>
        /// <value>Average talk time in seconds per 15 minute interval</value>
        [DataMember(Name="averageTalkTimeSecondsPerInterval", EmitDefaultValue=false)]
        public List<double?> AverageTalkTimeSecondsPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Average after call work in seconds per 15 minute interval
        /// </summary>
        /// <value>Average after call work in seconds per 15 minute interval</value>
        [DataMember(Name="averageAfterCallWorkSecondsPerInterval", EmitDefaultValue=false)]
        public List<double?> AverageAfterCallWorkSecondsPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Interactions completed per 15 minute interval
        /// </summary>
        /// <value>Interactions completed per 15 minute interval</value>
        [DataMember(Name="completedPerInterval", EmitDefaultValue=false)]
        public List<double?> CompletedPerInterval { get; set; }
        
        
        
        /// <summary>
        /// Interactions abandoned per 15 minute interval
        /// </summary>
        /// <value>Interactions abandoned per 15 minute interval</value>
        [DataMember(Name="abandonedPerInterval", EmitDefaultValue=false)]
        public List<double?> AbandonedPerInterval { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouteGroup {\n");
            
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  OfferedPerInterval: ").Append(OfferedPerInterval).Append("\n");
            sb.Append("  AverageTalkTimeSecondsPerInterval: ").Append(AverageTalkTimeSecondsPerInterval).Append("\n");
            sb.Append("  AverageAfterCallWorkSecondsPerInterval: ").Append(AverageAfterCallWorkSecondsPerInterval).Append("\n");
            sb.Append("  CompletedPerInterval: ").Append(CompletedPerInterval).Append("\n");
            sb.Append("  AbandonedPerInterval: ").Append(AbandonedPerInterval).Append("\n");
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
            return this.Equals(obj as RouteGroup);
        }

        /// <summary>
        /// Returns true if RouteGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of RouteGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RouteGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.Equals(other.Attributes)
                ) &&
                (
                    this.OfferedPerInterval == other.OfferedPerInterval ||
                    this.OfferedPerInterval != null &&
                    this.OfferedPerInterval.SequenceEqual(other.OfferedPerInterval)
                ) &&
                (
                    this.AverageTalkTimeSecondsPerInterval == other.AverageTalkTimeSecondsPerInterval ||
                    this.AverageTalkTimeSecondsPerInterval != null &&
                    this.AverageTalkTimeSecondsPerInterval.SequenceEqual(other.AverageTalkTimeSecondsPerInterval)
                ) &&
                (
                    this.AverageAfterCallWorkSecondsPerInterval == other.AverageAfterCallWorkSecondsPerInterval ||
                    this.AverageAfterCallWorkSecondsPerInterval != null &&
                    this.AverageAfterCallWorkSecondsPerInterval.SequenceEqual(other.AverageAfterCallWorkSecondsPerInterval)
                ) &&
                (
                    this.CompletedPerInterval == other.CompletedPerInterval ||
                    this.CompletedPerInterval != null &&
                    this.CompletedPerInterval.SequenceEqual(other.CompletedPerInterval)
                ) &&
                (
                    this.AbandonedPerInterval == other.AbandonedPerInterval ||
                    this.AbandonedPerInterval != null &&
                    this.AbandonedPerInterval.SequenceEqual(other.AbandonedPerInterval)
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
                
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                
                if (this.OfferedPerInterval != null)
                    hash = hash * 59 + this.OfferedPerInterval.GetHashCode();
                
                if (this.AverageTalkTimeSecondsPerInterval != null)
                    hash = hash * 59 + this.AverageTalkTimeSecondsPerInterval.GetHashCode();
                
                if (this.AverageAfterCallWorkSecondsPerInterval != null)
                    hash = hash * 59 + this.AverageAfterCallWorkSecondsPerInterval.GetHashCode();
                
                if (this.CompletedPerInterval != null)
                    hash = hash * 59 + this.CompletedPerInterval.GetHashCode();
                
                if (this.AbandonedPerInterval != null)
                    hash = hash * 59 + this.AbandonedPerInterval.GetHashCode();
                
                return hash;
            }
        }
    }

}
