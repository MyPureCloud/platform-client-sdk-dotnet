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
    /// TimeInterval
    /// </summary>
    [DataContract]
    public partial class TimeInterval :  IEquatable<TimeInterval>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeInterval" /> class.
        /// </summary>
        /// <param name="Days">Days.</param>
        /// <param name="Hours">Hours.</param>
        public TimeInterval(int? Days = null, int? Hours = null)
        {
            this.Days = Days;
            this.Hours = Hours;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public int? Days { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [DataMember(Name="hours", EmitDefaultValue=false)]
        public int? Hours { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeInterval {\n");
            
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
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
            return this.Equals(obj as TimeInterval);
        }

        /// <summary>
        /// Returns true if TimeInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeInterval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Days == other.Days ||
                    this.Days != null &&
                    this.Days.Equals(other.Days)
                ) &&
                (
                    this.Hours == other.Hours ||
                    this.Hours != null &&
                    this.Hours.Equals(other.Hours)
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
                
                if (this.Days != null)
                    hash = hash * 59 + this.Days.GetHashCode();
                
                if (this.Hours != null)
                    hash = hash * 59 + this.Hours.GetHashCode();
                
                return hash;
            }
        }
    }

}
