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
    /// ForecastGenerationRouteGroupResult
    /// </summary>
    [DataContract]
    public partial class ForecastGenerationRouteGroupResult :  IEquatable<ForecastGenerationRouteGroupResult>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastGenerationRouteGroupResult" /> class.
        /// </summary>
        /// <param name="RouteGroup">The route group this result represents.</param>
        /// <param name="MetricResults">The generation results for the associated route group.</param>
        public ForecastGenerationRouteGroupResult(RouteGroupAttributes RouteGroup = null, List<ForecastTimeSeriesResult> MetricResults = null)
        {
            this.RouteGroup = RouteGroup;
            this.MetricResults = MetricResults;
            
        }
        
        
        
        /// <summary>
        /// The route group this result represents
        /// </summary>
        /// <value>The route group this result represents</value>
        [DataMember(Name="routeGroup", EmitDefaultValue=false)]
        public RouteGroupAttributes RouteGroup { get; set; }
        
        
        
        /// <summary>
        /// The generation results for the associated route group
        /// </summary>
        /// <value>The generation results for the associated route group</value>
        [DataMember(Name="metricResults", EmitDefaultValue=false)]
        public List<ForecastTimeSeriesResult> MetricResults { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastGenerationRouteGroupResult {\n");
            
            sb.Append("  RouteGroup: ").Append(RouteGroup).Append("\n");
            sb.Append("  MetricResults: ").Append(MetricResults).Append("\n");
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
            return this.Equals(obj as ForecastGenerationRouteGroupResult);
        }

        /// <summary>
        /// Returns true if ForecastGenerationRouteGroupResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastGenerationRouteGroupResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastGenerationRouteGroupResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RouteGroup == other.RouteGroup ||
                    this.RouteGroup != null &&
                    this.RouteGroup.Equals(other.RouteGroup)
                ) &&
                (
                    this.MetricResults == other.MetricResults ||
                    this.MetricResults != null &&
                    this.MetricResults.SequenceEqual(other.MetricResults)
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
                
                if (this.RouteGroup != null)
                    hash = hash * 59 + this.RouteGroup.GetHashCode();
                
                if (this.MetricResults != null)
                    hash = hash * 59 + this.MetricResults.GetHashCode();
                
                return hash;
            }
        }
    }

}
