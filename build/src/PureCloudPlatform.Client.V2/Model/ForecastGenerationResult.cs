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
    /// ForecastGenerationResult
    /// </summary>
    [DataContract]
    public partial class ForecastGenerationResult :  IEquatable<ForecastGenerationResult>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastGenerationResult" /> class.
        /// </summary>
        /// <param name="RouteGroupResults">Generation results, broken down by route group.</param>
        public ForecastGenerationResult(List<ForecastGenerationRouteGroupResult> RouteGroupResults = null)
        {
            this.RouteGroupResults = RouteGroupResults;
            
        }
        
        
        
        /// <summary>
        /// Generation results, broken down by route group
        /// </summary>
        /// <value>Generation results, broken down by route group</value>
        [DataMember(Name="routeGroupResults", EmitDefaultValue=false)]
        public List<ForecastGenerationRouteGroupResult> RouteGroupResults { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastGenerationResult {\n");
            
            sb.Append("  RouteGroupResults: ").Append(RouteGroupResults).Append("\n");
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
            return this.Equals(obj as ForecastGenerationResult);
        }

        /// <summary>
        /// Returns true if ForecastGenerationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastGenerationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastGenerationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RouteGroupResults == other.RouteGroupResults ||
                    this.RouteGroupResults != null &&
                    this.RouteGroupResults.SequenceEqual(other.RouteGroupResults)
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
                
                if (this.RouteGroupResults != null)
                    hash = hash * 59 + this.RouteGroupResults.GetHashCode();
                
                return hash;
            }
        }
    }

}
