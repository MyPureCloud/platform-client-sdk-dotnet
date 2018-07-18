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
    /// Create a new short term forecast by copying an existing forecast
    /// </summary>
    [DataContract]
    public partial class CopyShortTermForecastRequest :  IEquatable<CopyShortTermForecastRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyShortTermForecastRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CopyShortTermForecastRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyShortTermForecastRequest" /> class.
        /// </summary>
        /// <param name="WeekDate">The first day of the short term forecast in yyyy-MM-dd format.  Must be the management unit&#39;s start day of week (required).</param>
        /// <param name="Description">Description for the new forecast (required).</param>
        public CopyShortTermForecastRequest(string WeekDate = null, string Description = null)
        {
            this.WeekDate = WeekDate;
            this.Description = Description;
            
        }
        
        
        
        /// <summary>
        /// The first day of the short term forecast in yyyy-MM-dd format.  Must be the management unit&#39;s start day of week
        /// </summary>
        /// <value>The first day of the short term forecast in yyyy-MM-dd format.  Must be the management unit&#39;s start day of week</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public string WeekDate { get; set; }
        
        
        
        /// <summary>
        /// Description for the new forecast
        /// </summary>
        /// <value>Description for the new forecast</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyShortTermForecastRequest {\n");
            
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
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
            return this.Equals(obj as CopyShortTermForecastRequest);
        }

        /// <summary>
        /// Returns true if CopyShortTermForecastRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CopyShortTermForecastRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopyShortTermForecastRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
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
                
                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                return hash;
            }
        }
    }

}
