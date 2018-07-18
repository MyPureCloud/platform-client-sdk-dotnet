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
    /// Request to generate a week schedule
    /// </summary>
    [DataContract]
    public partial class GenerateWeekScheduleRequest :  IEquatable<GenerateWeekScheduleRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateWeekScheduleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateWeekScheduleRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateWeekScheduleRequest" /> class.
        /// </summary>
        /// <param name="Description">Description for the generated week schedule (required).</param>
        /// <param name="ShortTermForecastId">ID of short term forecast used for schedule generation (required).</param>
        public GenerateWeekScheduleRequest(string Description = null, string ShortTermForecastId = null)
        {
            this.Description = Description;
            this.ShortTermForecastId = ShortTermForecastId;
            
        }
        
        
        
        /// <summary>
        /// Description for the generated week schedule
        /// </summary>
        /// <value>Description for the generated week schedule</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// ID of short term forecast used for schedule generation
        /// </summary>
        /// <value>ID of short term forecast used for schedule generation</value>
        [DataMember(Name="shortTermForecastId", EmitDefaultValue=false)]
        public string ShortTermForecastId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateWeekScheduleRequest {\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShortTermForecastId: ").Append(ShortTermForecastId).Append("\n");
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
            return this.Equals(obj as GenerateWeekScheduleRequest);
        }

        /// <summary>
        /// Returns true if GenerateWeekScheduleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GenerateWeekScheduleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateWeekScheduleRequest other)
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
                    this.ShortTermForecastId == other.ShortTermForecastId ||
                    this.ShortTermForecastId != null &&
                    this.ShortTermForecastId.Equals(other.ShortTermForecastId)
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
                
                if (this.ShortTermForecastId != null)
                    hash = hash * 59 + this.ShortTermForecastId.GetHashCode();
                
                return hash;
            }
        }
    }

}
