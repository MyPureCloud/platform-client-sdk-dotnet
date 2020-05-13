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
    /// GenerateBuForecastRequest
    /// </summary>
    [DataContract]
    public partial class GenerateBuForecastRequest :  IEquatable<GenerateBuForecastRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateBuForecastRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateBuForecastRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateBuForecastRequest" /> class.
        /// </summary>
        /// <param name="Description">The description for the forecast (required).</param>
        /// <param name="WeekCount">The number of weeks this forecast covers.</param>
        public GenerateBuForecastRequest(string Description = null, int? WeekCount = null)
        {
            this.Description = Description;
            this.WeekCount = WeekCount;
            
        }
        
        
        
        /// <summary>
        /// The description for the forecast
        /// </summary>
        /// <value>The description for the forecast</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The number of weeks this forecast covers
        /// </summary>
        /// <value>The number of weeks this forecast covers</value>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public int? WeekCount { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateBuForecastRequest {\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
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
            return this.Equals(obj as GenerateBuForecastRequest);
        }

        /// <summary>
        /// Returns true if GenerateBuForecastRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GenerateBuForecastRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateBuForecastRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.WeekCount == other.WeekCount ||
                    this.WeekCount != null &&
                    this.WeekCount.Equals(other.WeekCount)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();
                
                return hash;
            }
        }
    }

}
