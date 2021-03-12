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
    /// SingleWorkdayAveragePoints
    /// </summary>
    [DataContract]
    public partial class SingleWorkdayAveragePoints :  IEquatable<SingleWorkdayAveragePoints>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleWorkdayAveragePoints" /> class.
        /// </summary>
        /// <param name="Division">The targeted division for the average points.</param>
        public SingleWorkdayAveragePoints(Division Division = null)
        {
            this.Division = Division;
            
        }
        
        
        
        /// <summary>
        /// Queried target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Queried target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateWorkday", EmitDefaultValue=false)]
        public String DateWorkday { get; private set; }
        
        
        
        /// <summary>
        /// The targeted division for the average points
        /// </summary>
        /// <value>The targeted division for the average points</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public Division Division { get; set; }
        
        
        
        /// <summary>
        /// The average points per agent earned within the division
        /// </summary>
        /// <value>The average points per agent earned within the division</value>
        [DataMember(Name="averagePoints", EmitDefaultValue=false)]
        public double? AveragePoints { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SingleWorkdayAveragePoints {\n");
            
            sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  AveragePoints: ").Append(AveragePoints).Append("\n");
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
            return this.Equals(obj as SingleWorkdayAveragePoints);
        }

        /// <summary>
        /// Returns true if SingleWorkdayAveragePoints instances are equal
        /// </summary>
        /// <param name="other">Instance of SingleWorkdayAveragePoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SingleWorkdayAveragePoints other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateWorkday == other.DateWorkday ||
                    this.DateWorkday != null &&
                    this.DateWorkday.Equals(other.DateWorkday)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.AveragePoints == other.AveragePoints ||
                    this.AveragePoints != null &&
                    this.AveragePoints.Equals(other.AveragePoints)
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
                
                if (this.DateWorkday != null)
                    hash = hash * 59 + this.DateWorkday.GetHashCode();
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
                if (this.AveragePoints != null)
                    hash = hash * 59 + this.AveragePoints.GetHashCode();
                
                return hash;
            }
        }
    }

}
