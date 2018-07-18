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
    /// GenerateShortTermForecastRequest
    /// </summary>
    [DataContract]
    public partial class GenerateShortTermForecastRequest :  IEquatable<GenerateShortTermForecastRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateShortTermForecastRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateShortTermForecastRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateShortTermForecastRequest" /> class.
        /// </summary>
        /// <param name="Description">Description for the generated forecast.  Pass an empty string for no description (required).</param>
        public GenerateShortTermForecastRequest(string Description = null)
        {
            this.Description = Description;
            
        }
        
        
        
        /// <summary>
        /// Description for the generated forecast.  Pass an empty string for no description
        /// </summary>
        /// <value>Description for the generated forecast.  Pass an empty string for no description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateShortTermForecastRequest {\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as GenerateShortTermForecastRequest);
        }

        /// <summary>
        /// Returns true if GenerateShortTermForecastRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GenerateShortTermForecastRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateShortTermForecastRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                
                return hash;
            }
        }
    }

}
